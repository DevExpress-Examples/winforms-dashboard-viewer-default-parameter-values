<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WinViewer_DefaultParameterValues/Form1.cs) (VB: [Form1.vb](./VB/WinViewer_DefaultParameterValues/Form1.vb))
<!-- default file list end -->
# How to specify default parameter values in the WinForms Viewer


The following example shows how to specify default parameter values on dashboard loading. To do this, handle the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_DashboardLoadedtopic">DashboardViewer.DashboardLoaded</a> event, get access to the dashboard object using the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardLoadedEventArgs_Dashboardtopic">DashboardLoadedEventArgs.Dashboard</a> event parameter and specify the default value(s) using the <strong>Dashboard</strong>.<a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboard_Parameterstopic">Parameters</a>["parameterName"].<a href="https://documentation.devexpress.com/#Dashboard/DevExpressDataAccessParameter_Valuetopic">Value</a> property.<br><br><strong>See also:</strong> <a href="https://www.devexpress.com/Support/Center/p/T338459">How to pass a hidden dashboard parameter to a custom SQL query in the WinForms Viewer</a>

<br/>


