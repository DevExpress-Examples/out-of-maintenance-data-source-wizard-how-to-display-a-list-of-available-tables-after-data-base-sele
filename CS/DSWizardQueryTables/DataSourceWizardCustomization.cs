using DevExpress.DashboardCommon;
using DevExpress.DashboardWin.ServiceModel;
using DevExpress.DataAccess.UI.Wizard;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.DataAccess.Wizard.Views;

namespace DSWizardCustomizationNoSP
{
    public class DataSourceWizardCustomization : IDashboardDataSourceWizardCustomization
    {
        public void CustomizeDataSourceWizard(IWizardCustomization<DashboardDataSourceModel> customization)
        {
            customization.RegisterPage<ConfigureQueryPage<DashboardDataSourceModel>, 
                ConfigureQueryPageEx<DashboardDataSourceModel>>();
            customization.RegisterPageView<IConfigureQueryPageView, 
                ConfigureQueryPageViewEx>();
        }
    }
}
