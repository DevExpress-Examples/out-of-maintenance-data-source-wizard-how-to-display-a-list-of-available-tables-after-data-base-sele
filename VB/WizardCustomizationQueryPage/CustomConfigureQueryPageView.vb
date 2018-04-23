Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.DataAccess.UI.Wizard.Views
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.Wizard.Services
Imports DevExpress.Data
Imports DevExpress.DataAccess.Wizard.Views
Imports DevExpress.Xpo.DB

Namespace WizardCustomizationQueryPage
    Partial Public Class CustomConfigureQueryPageView
        Inherits WizardViewBase
        Implements IConfigureQueryPageView

        Private dataConnection As SqlDataConnection
        Private dbSchema As DBSchema
        Private dbSchemaProvider As IDBSchemaProvider


        Private privateQuery As SqlQuery
        Public ReadOnly Property Query() As SqlQuery Implements IConfigureQueryPageView.Query
            Get
                Return privateQuery
            End Get
        End Property
        Public ReadOnly Property SqlQueryText() As String Implements IConfigureQueryPageView.SqlQueryText
            Get
                Return String.Empty
            End Get
        End Property
        Public ReadOnly Property DataSchema() As Object Implements IConfigureQueryPageView.DataSchema
            Get
                Return dbSchema
            End Get
        End Property
        Public Overrides ReadOnly Property HeaderDescription() As String
            Get
                Return "Select a table"
            End Get
        End Property

        Public Event Changed As EventHandler Implements IConfigureQueryPageView.Changed

        Public Sub New(ByVal dbSchemaProvider As IDBSchemaProvider, ByVal parameterService As IParameterService, ByVal displayNameProvider As IDisplayNameProvider)
                Me.dbSchemaProvider = dbSchemaProvider
            InitializeComponent()
            AddHandler listBoxControl1.SelectedIndexChanged, AddressOf OnSelectedIndexChanged
        End Sub

        Private Sub OnSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim tableQuery As New TableQuery()
            Dim tableName As String = CStr(listBoxControl1.SelectedItem)
            Dim tableInfo As TableInfo = tableQuery.AddTable(tableName)
            Dim dbTable As DBTable = dbSchema.Tables.First(Function(table) table.Name = tableName)
            dbSchemaProvider.LoadColumns(dataConnection, dbTable)
            For Each dbColumn As DBColumn In dbSchema.Tables.First(Function(table) table.Name = tableName).Columns
                tableInfo.SelectColumn(dbColumn.Name)
            Next dbColumn
            privateQuery = tableQuery
            RaiseEvent Changed(Me, New EventArgs())
        End Sub
        Public Sub Initialize(ByVal dataSchema As Object, ByVal query As SqlQuery, ByVal dataConnection As SqlDataConnection, ByVal sqlQuery As String, ByVal allowCustomSql As Boolean, ByVal queryBuilderLight As Boolean) Implements IConfigureQueryPageView.Initialize
            Me.dataConnection = dataConnection
            dbSchema = TryCast(dbSchemaProvider.GetSchema(dataConnection), DBSchema)
            listBoxControl1.Items.AddRange(dbSchema.Tables.Select(Function(table) table.Name).ToArray())
        End Sub
    End Class
End Namespace
