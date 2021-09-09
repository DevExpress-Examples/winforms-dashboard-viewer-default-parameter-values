using System.Collections.Generic;
using DevExpress.DashboardCommon;
using DevExpress.DashboardWin;
using DevExpress.DataAccess.ConnectionParameters;

namespace WinViewer_DefaultParameterValues {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();
        }
        private void dashboardViewer1_SetInitialDashboardState(object sender, SetInitialDashboardStateEventArgs e) {
            DashboardState state = new DashboardState();
            DashboardParameterState parameters = new DashboardParameterState();
            parameters.Name = "customerIdParameter";
            parameters.Value = new List<string>() { "ALFKI", "AROUT", "BONAP" };
            state.Parameters.Add(parameters);
            e.InitialState = state;
        }
        private void dashboardViewer1_ConfigureDataConnection(object sender, DashboardConfigureDataConnectionEventArgs e) {
            if (e.DataSourceName == "SQL Data Source 1")
                e.ConnectionParameters = new Access97ConnectionParameters(@"..\..\Data\nwind.mdb", "", "");
        }
    }
}
