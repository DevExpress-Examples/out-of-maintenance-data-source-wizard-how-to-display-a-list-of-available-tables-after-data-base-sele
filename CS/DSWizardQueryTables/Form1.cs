using DevExpress.XtraBars.Ribbon;

namespace DSWizardCustomizationNoSP
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            dashboardDesigner1.DataSourceWizardCustomization = new DataSourceWizardCustomization();
        }
    }
}
