using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.DataAccess.UI.Wizard.Views;
using DevExpress.DataAccess.Wizard.Views;
using DevExpress.Data;
using DevExpress.DataAccess.Wizard.Services;
using DevExpress.DataAccess.Wizard;
using DevExpress.XtraEditors;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.DataAccess.Native.Sql.QueryBuilder;
using DevExpress.Xpo.DB;

namespace DSWizardCustomizationNoSP
{
    public partial class ConfigureQueryPageViewEx : ConfigureQueryPageView
    {
        internal event EventHandler<SelectedTableChanged> SelectedTableChanged;
        QueryControlView tableQueryControl { get { return panel.Controls[0] as QueryControlView; } }

        public ConfigureQueryPageViewEx(IDisplayNameProvider displayNameProvider, IServiceProvider propertyGridServices, ICustomQueryValidator customQueryValidator, SqlWizardOptions options) :
            base(displayNameProvider, propertyGridServices, customQueryValidator, options)
        {
            InitializeComponent();
            layoutItemQueryType.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutItemQuery.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            layoutItemQueryBuilderButton.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        
        void RaiseSelectedTableChanged(string tableName)
        {
            if (SelectedTableChanged != null)
            {
                SelectedTableChanged(this, new SelectedTableChanged { TableName = tableName });
            }
        }

        internal void InitializeTables(DBSchema dbSchema)
        {
            listBoxDsTables.Items.Clear();
            listBoxDsTables.Items.AddRange(dbSchema.Tables.Select(t => t.Name).ToArray());
        }
        

        private void listBoxDsTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            RaiseSelectedTableChanged((string)listBoxDsTables.SelectedItem);
            //DBTable table = listBoxDsTables.SelectedItem as DBTable;
            //tableQueryControl.SqlString = string.Format("SELECT * FROM {0}", table.Name);
            //base.RaiseChanged();
        }
        
        
    }
    public class SelectedTableChanged : EventArgs
    {
        public string TableName { get; set; }
    }
}

