using System;
using System.Linq;
using DevExpress.Data;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.UI.Wizard.Views;
using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Services;

namespace DSWizardCustomizationNoSP {
    public partial class ConfigureQueryPageViewEx : ConfigureQueryPageView {
        internal event EventHandler<SelectedTableChanged> SelectedTableChanged;
        QueryControlView tableQueryControl { get { return panel.Controls[0] as QueryControlView; } }

        public ConfigureQueryPageViewEx(IDisplayNameProvider displayNameProvider,
            IServiceProvider propertyGridServices,
            ICustomQueryValidator customQueryValidator,
            SqlWizardOptions options) :
            base(displayNameProvider, propertyGridServices, customQueryValidator, options) {
            InitializeComponent();
            layoutItemQueryType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutItemQuery.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutItemQueryBuilderButton.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        void RaiseSelectedTableChanged(string tableName) {
            if (SelectedTableChanged != null) {
                SelectedTableChanged(this, new SelectedTableChanged { TableName = tableName });
            }
        }

        internal void InitializeTables(DBSchema dbSchema) {
            listBoxDsTables.Items.Clear();
            listBoxDsTables.Items.AddRange(dbSchema.Tables.Select(t => t.Name).ToArray());
            listBoxDsTables.SelectedIndex = 0;
        }

        private void listBoxDsTables_SelectedIndexChanged(object sender, EventArgs e) {
            RaiseSelectedTableChanged((string)listBoxDsTables.SelectedItem);
        }
    }

    public class SelectedTableChanged : EventArgs {
        public string TableName { get; set; }
    }
}

