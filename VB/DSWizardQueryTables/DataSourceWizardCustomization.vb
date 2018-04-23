Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin.ServiceModel
Imports DevExpress.DataAccess.UI.Wizard
Imports DevExpress.DataAccess.Wizard.Presenters
Imports DevExpress.DataAccess.Wizard.Views

Namespace DSWizardCustomizationNoSP
    Public Class DataSourceWizardCustomization
        Implements IDashboardDataSourceWizardCustomization

        Public Sub CustomizeDataSourceWizard(ByVal customization As IWizardCustomization(Of DashboardDataSourceModel)) _
            Implements IDashboardDataSourceWizardCustomization.CustomizeDataSourceWizard
            customization.RegisterPage(Of ConfigureQueryPage(Of DashboardDataSourceModel), 
                ConfigureQueryPageEx(Of DashboardDataSourceModel))()
            customization.RegisterPageView(Of IConfigureQueryPageView, ConfigureQueryPageViewEx)()
        End Sub
    End Class
End Namespace
