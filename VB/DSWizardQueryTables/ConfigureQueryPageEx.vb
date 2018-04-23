Imports System.Linq
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.DataAccess.Wizard.Model
Imports DevExpress.DataAccess.Wizard.Presenters
Imports DevExpress.DataAccess.Wizard.Services
Imports DevExpress.DataAccess.Wizard.Views

Namespace DSWizardCustomizationNoSP

    Public Class ConfigureQueryPageEx(Of TModel As ISqlDataSourceModel)
        Inherits ConfigureQueryPage(Of TModel)

        Private ReadOnly schemaProvider As IDBSchemaProvider
        Public Sub New(ByVal view As IConfigureQueryPageView,
                       ByVal context As IWizardRunnerContext,
                       ByVal options As SqlWizardOptions,
                       ByVal dbSchemaProvider As IDBSchemaProvider,
                       ByVal parameterService As IParameterService,
                       ByVal customQueryValidator As ICustomQueryValidator)
            MyBase.New(view, context, options, dbSchemaProvider, parameterService, customQueryValidator)
            schemaProvider = dbSchemaProvider
        End Sub

        Public Overrides Sub Begin()
            MyBase.Begin()
            MyBase.LoadTablesAndViews()
            MyBase.LoadStoredProcedures()

            Dim configureQueryPageViewEx = CType(View, ConfigureQueryPageViewEx)
            configureQueryPageViewEx.InitializeTables(DBSchema)
            AddHandler configureQueryPageViewEx.SelectedTableChanged,
                AddressOf configureQueryPageViewEx_SelectedTableChanged

        End Sub
        Private Sub configureQueryPageViewEx_SelectedTableChanged(ByVal sender As Object, ByVal e As SelectedTableChanged)
            Dim dbTable = DBSchema.Tables.First(Function(t) String.Equals(t.Name, e.TableName))
            schemaProvider.LoadColumns(Model.DataConnection, dbTable)

            Dim selectQuery = SelectQueryFluentBuilder.AddTable(e.TableName) _
                              .SelectColumns(dbTable.Columns.Select(Function(c) c.Name).ToArray()).Build(e.TableName)

            SetTableOrCustomSqlQuery(selectQuery)

            RaiseChanged()
        End Sub

        Public Overrides Sub Commit()
            RemoveHandler CType(View, ConfigureQueryPageViewEx).SelectedTableChanged,
                AddressOf configureQueryPageViewEx_SelectedTableChanged
            MyBase.Commit()
        End Sub
    End Class

End Namespace
