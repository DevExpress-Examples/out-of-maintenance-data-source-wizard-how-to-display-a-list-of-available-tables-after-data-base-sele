Imports System
Imports System.Linq
Imports DevExpress.Data
Imports DevExpress.DataAccess.Sql
Imports DevExpress.DataAccess.UI.Wizard.Views
Imports DevExpress.DataAccess.Wizard
Imports DevExpress.DataAccess.Wizard.Services

Namespace DSWizardCustomizationNoSP
    Partial Public Class ConfigureQueryPageViewEx
        Inherits ConfigureQueryPageView

        Friend Event SelectedTableChanged As EventHandler(Of SelectedTableChanged)
        Private ReadOnly Property tableQueryControl() As QueryControlView
            Get
                Return TryCast(panel.Controls(0), QueryControlView)
            End Get
        End Property

        Public Sub New(ByVal displayNameProvider As IDisplayNameProvider,
                       ByVal propertyGridServices As IServiceProvider,
                       ByVal customQueryValidator As ICustomQueryValidator,
                       ByVal options As SqlWizardOptions)
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


        Private Sub listBoxDsTables_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) _
            Handles listBoxDsTables.SelectedIndexChanged
            RaiseSelectedTableChanged(CStr(listBoxDsTables.SelectedItem))
        End Sub


    End Class
    Public Class SelectedTableChanged
        Inherits EventArgs

        Public Property TableName() As String
    End Class
End Namespace

