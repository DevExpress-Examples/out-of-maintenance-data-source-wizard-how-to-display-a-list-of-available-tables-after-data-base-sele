Imports DevExpress.XtraBars.Ribbon

Namespace DSWizardCustomizationNoSP
    Partial Public Class Form1
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
            dashboardDesigner1.DataSourceWizardCustomization = New DataSourceWizardCustomization()
        End Sub
    End Class
End Namespace
