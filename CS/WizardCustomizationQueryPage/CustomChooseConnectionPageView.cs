using DevExpress.DataAccess;
using DevExpress.DataAccess.Native;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.UI.Native;
using DevExpress.DataAccess.UI.Wizard.Views;
using DevExpress.DataAccess.Wizard.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WizardCustomizationQueryPage {
    public partial class CustomChooseConnectionPageView : WizardViewBase, IChooseConnectionPageView {
        private DevExpress.XtraEditors.ListBoxControl lbConnections;
        bool anyExceptions = false;

        public CustomChooseConnectionPageView(IEnumerable<SqlDataConnection> connections) {
            InitializeComponent();
            lbConnections.SelectedIndexChanged += listBoxControl1_SelectedIndexChanged;
            this.lbConnections.Items.Clear();
            foreach(SqlDataConnection dataConnection in connections) {
                if(dataConnection is DataConnection)
                    this.lbConnections.Items.Add(new ConnectionListBoxItem(dataConnection));
            }
        }

        void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e) {
            if(Changed != null)
                Changed(this, new EventArgs());
        }

        public override string HeaderDescription {
            get { return "Choose one connection from the list."; }
        }
        public event EventHandler Changed;

        public string ExistingConnectionName {
            get { return ((INamedItem)((ConnectionListBoxItem)lbConnections.SelectedItem).Connection).Name; }
        }

        public void SetSelectedConnection(INamedItem connection) {
            if(connection != null)
                foreach(ConnectionListBoxItem connectionListBoxItem in this.lbConnections.Items) {
                    if(((INamedItem)connectionListBoxItem.Connection).Name == connection.Name) {
                        lbConnections.SelectedItem = connectionListBoxItem;
                        break;
                    }
                }
        }

        public bool ShouldCreateNewConnection { get { return false; } }

        public IWaitFormActivator WaitFormActivator {
            get { return new WaitFormActivator(FindForm(), typeof(WaitFormWithCancel), true); }
        }

        public bool AnyExceptions { get { return anyExceptions; } }

        public void HandleException(Exception exception) {
            MessageBox.Show(exception.Message);
        }
    }
    public class ConnectionListBoxItem { 
        public SqlDataConnection Connection { get; private set; }
        public ConnectionListBoxItem(SqlDataConnection connection) {
            Connection = connection;
        }
        public override string ToString()
        {
            return Connection.Name;
        }
    }
}
