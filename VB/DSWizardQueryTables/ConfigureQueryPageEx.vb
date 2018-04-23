Imports System.Linq
Imports DevExpress.DataAccess.Native.Sql
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.DataAccess.Wizard.Model
Imports DevExpress.DataAccess.Wizard.Presenters
Imports DevExpress.DataAccess.Wizard.Services
Imports DevExpress.DataAccess.Wizard.Views

Namespace DSWizardCustomizationNoSP

    Public Class ConfigureQueryPageEx(Of TModel As ISqlDataSourceModel)
        Inherits ConfigureQueryPage(Of TModel)

        Private ReadOnly schemaProvider As IDBSchemaProviderEx
        Private result As SelectQuery
        Public Sub New(ByVal view As IConfigureQueryPageView, ByVal context As IWizardRunnerContext, ByVal options As SqlWizardOptions, ByVal dbSchemaProvider As IDBSchemaProviderEx, ByVal parameterService As IParameterService, ByVal customQueryValidator As ICustomQueryValidator)
            MyBase.New(view, context, options, dbSchemaProvider, parameterService, customQueryValidator)
            schemaProvider = dbSchemaProvider
        End Sub

        Public Overrides ReadOnly Property FinishEnabled() As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides ReadOnly Property MoveNextEnabled() As Boolean
            Get
                Return False
            End Get
        End Property

        Public Overrides Sub Begin()
            MyBase.Begin()
            MyBase.LoadTablesAndViews()

            Dim configureQueryPageViewEx = DirectCast(View, ConfigureQueryPageViewEx)
            AddHandler configureQueryPageViewEx.SelectedTableChanged, AddressOf configureQueryPageViewEx_SelectedTableChanged
            configureQueryPageViewEx.InitializeTables(DBSchema)
        End Sub

        Private Sub configureQueryPageViewEx_SelectedTableChanged(ByVal sender As Object, ByVal e As SelectedTableChanged)
            result = Nothing
            Dim dbTable = DBSchema.Tables.FirstOrDefault(Function(t) String.Equals(t.Name, e.TableName))
            If dbTable IsNot Nothing Then
                schemaProvider.LoadColumns(Model.DataConnection, dbTable)
                result = SelectQueryFluentBuilder.AddTable(e.TableName).SelectColumns(dbTable.Columns.Select(Function(c) c.Name).ToArray()).Build(e.TableName)
            End If
            RaiseChanged()
        End Sub

        Protected Overrides Function GetResult() As SqlQuery
            Return result
        End Function

        Public Overrides Sub Commit()
            RemoveHandler DirectCast(View, ConfigureQueryPageViewEx).SelectedTableChanged, AddressOf configureQueryPageViewEx_SelectedTableChanged
            MyBase.Commit()
            Model.DataSchema = SqlQueryHelper.GetDataSchema(result, DBSchema, Model.DataConnection, New ConnectionOptions(), Nothing)
        End Sub


    End Class

End Namespace
