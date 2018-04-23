using System.Linq;
using DevExpress.DataAccess.Native.Sql;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.DataAccess.Wizard.Presenters;
using DevExpress.DataAccess.Wizard.Services;
using DevExpress.DataAccess.Wizard.Views;

namespace DSWizardCustomizationNoSP {

    public class ConfigureQueryPageEx<TModel> : ConfigureQueryPage<TModel>
        where TModel : ISqlDataSourceModel {

        readonly IDBSchemaProviderEx schemaProvider;
        SelectQuery result;
        public ConfigureQueryPageEx(IConfigureQueryPageView view,
            IWizardRunnerContext context,
            SqlWizardOptions options,
            IDBSchemaProviderEx dbSchemaProvider,
            IParameterService parameterService,
            ICustomQueryValidator customQueryValidator)
            : base(view, context, options, dbSchemaProvider, parameterService, customQueryValidator) {
            schemaProvider = dbSchemaProvider;
        }

        public override bool FinishEnabled { get { return true; } }

        public override bool MoveNextEnabled { get { return false; } }

        public override void Begin() {
            base.Begin();
            base.LoadTablesAndViews();

            var configureQueryPageViewEx = (ConfigureQueryPageViewEx)View;
            configureQueryPageViewEx.SelectedTableChanged += configureQueryPageViewEx_SelectedTableChanged;
            configureQueryPageViewEx.InitializeTables(DBSchema);
        }

        void configureQueryPageViewEx_SelectedTableChanged(object sender, SelectedTableChanged e) {
            result = null;
            var dbTable = DBSchema.Tables.FirstOrDefault(t => string.Equals(t.Name, e.TableName));
            if (dbTable != null) {
                schemaProvider.LoadColumns(Model.DataConnection, dbTable);
                result = SelectQueryFluentBuilder.AddTable(e.TableName)
                    .SelectColumns(dbTable.Columns.Select(c => c.Name).ToArray())
                    .Build(e.TableName);
            }
            RaiseChanged();
        }

        protected override SqlQuery GetResult() {
            return result;
        }

        public override void Commit() {
            ((ConfigureQueryPageViewEx)View).SelectedTableChanged -= configureQueryPageViewEx_SelectedTableChanged;
            base.Commit();
            Model.DataSchema = SqlQueryHelper.GetDataSchema(result, DBSchema, Model.DataConnection, new ConnectionOptions(), null);
        }


    }

}
