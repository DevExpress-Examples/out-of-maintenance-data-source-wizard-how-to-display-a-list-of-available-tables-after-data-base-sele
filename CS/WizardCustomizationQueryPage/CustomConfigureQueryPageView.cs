using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataAccess.UI.Wizard.Views;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Wizard.Services;
using DevExpress.Data;
using DevExpress.DataAccess.Wizard.Views;
using DevExpress.Xpo.DB;

namespace WizardCustomizationQueryPage {
    public partial class CustomConfigureQueryPageView : WizardViewBase, IConfigureQueryPageView {
        SqlDataConnection dataConnection;
        DBSchema dbSchema;
        IDBSchemaProvider dbSchemaProvider;


        public SqlQuery Query { get; private set; }
        public string SqlQueryText { get { return string.Empty; } }
        public object DataSchema { get { return dbSchema; } }
        public override string HeaderDescription { get { return "Select a table"; } }

        public event EventHandler Changed;

        public CustomConfigureQueryPageView(IDBSchemaProvider dbSchemaProvider, IParameterService parameterService, 
            IDisplayNameProvider displayNameProvider) {
                this.dbSchemaProvider = dbSchemaProvider;
            InitializeComponent();
            listBoxControl1.SelectedIndexChanged += OnSelectedIndexChanged;
        }

        void OnSelectedIndexChanged(object sender, EventArgs e) {
            TableQuery tableQuery = new TableQuery();
            string tableName = (string)listBoxControl1.SelectedItem;
            TableInfo tableInfo = tableQuery.AddTable(tableName);
            DBTable dbTable = dbSchema.Tables.First(table => table.Name == tableName);
            dbSchemaProvider.LoadColumns(dataConnection, dbTable);
            foreach(DBColumn dbColumn in dbSchema.Tables.First(table => table.Name == tableName).Columns) {
                tableInfo.SelectColumn(dbColumn.Name);
            }
            Query = tableQuery;
            Changed(this, new EventArgs());
        }
        public void Initialize(object dataSchema, SqlQuery query, SqlDataConnection dataConnection, string sqlQuery, bool allowCustomSql, bool queryBuilderLight) {
            this.dataConnection = dataConnection;
            dbSchema = dbSchemaProvider.GetSchema(dataConnection) as DBSchema;
            listBoxControl1.Items.AddRange(dbSchema.Tables.Select(table=> table.Name).ToArray());    
        }
    }
}
