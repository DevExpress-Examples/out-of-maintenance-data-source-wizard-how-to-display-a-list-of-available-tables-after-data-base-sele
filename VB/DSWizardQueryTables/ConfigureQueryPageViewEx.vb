Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.DataAccess.UI.Wizard.Views
Imports DevExpress.DataAccess.Wizard.Views
Imports DevExpress.Data
Imports DevExpress.DataAccess.Wizard.Services
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.XtraEditors
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.Wizard.Presenters
Imports DevExpress.DataAccess.Native.Sql.QueryBuilder
Imports DevExpress.Xpo.DB

Namespace DSWizardCustomizationNoSP
	Partial Public Class ConfigureQueryPageViewEx
		Inherits ConfigureQueryPageView
		Friend Event SelectedTableChanged As EventHandler(Of SelectedTableChanged)
		Private ReadOnly Property tableQueryControl() As QueryControlView
			Get
				Return TryCast(panel.Controls(0), QueryControlView)
			End Get
		End Property

		Public Sub New(ByVal displayNameProvider As IDisplayNameProvider, ByVal propertyGridServices As IServiceProvider, ByVal customQueryValidator As ICustomQueryValidator, ByVal options As SqlWizardOptions)
			MyBase.New(displayNameProvider, propertyGridServices, customQueryValidator, options)
			InitializeComponent()
			layoutItemQueryType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
			layoutItemQuery.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
			layoutItemQueryBuilderButton.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
		End Sub


		Private Sub RaiseSelectedTableChanged(ByVal tableName As String)
			RaiseEvent SelectedTableChanged(Me, New SelectedTableChanged With {.TableName = tableName})
		End Sub

		Friend Sub InitializeTables(ByVal dbSchema As DBSchema)
			listBoxDsTables.Items.Clear()
			listBoxDsTables.Items.AddRange(dbSchema.Tables.Select(Function(t) t.Name).ToArray())
		End Sub


		Private Sub listBoxDsTables_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listBoxDsTables.SelectedIndexChanged
			RaiseSelectedTableChanged(CStr(listBoxDsTables.SelectedItem))
			'DBTable table = listBoxDsTables.SelectedItem as DBTable;
			'tableQueryControl.SqlString = string.Format("SELECT * FROM {0}", table.Name);
			'base.RaiseChanged();
		End Sub


	End Class
	Public Class SelectedTableChanged
		Inherits EventArgs
		Private privateTableName As String
		Public Property TableName() As String
			Get
				Return privateTableName
			End Get
			Set(ByVal value As String)
				privateTableName = value
			End Set
		End Property
	End Class
End Namespace

