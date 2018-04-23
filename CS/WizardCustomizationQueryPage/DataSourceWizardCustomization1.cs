using DevExpress.DashboardCommon;
using DevExpress.DashboardWin.ServiceModel;
using DevExpress.DataAccess.UI.Wizard;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.DataAccess.Wizard.Services;
using DevExpress.DataAccess.Wizard.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardCustomizationQueryPage {
    public class DataSourceWizardCustomization : IDashboardDataSourceWizardCustomization {

        public void CustomizeDataSourceWizard(IWizardCustomization<DashboardDataSourceModel> customization) {
            customization.StartPage = typeof(ChooseConnectionPage<DashboardDataSourceModel>);
            customization.Model.DataSourceType = DashboardDataSourceType.Xpo;
            customization.RegisterPageView<IChooseConnectionPageView, CustomChooseConnectionPageView>();
            customization.RegisterPageView<IConfigureQueryPageView, CustomConfigureQueryPageView>();
        }
    }    
}
