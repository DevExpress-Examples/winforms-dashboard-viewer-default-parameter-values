<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581362/16.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T475858)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WinViewer_DefaultParameterValues/Form1.cs) (VB: [Form1.vb](./VB/WinViewer_DefaultParameterValues/Form1.vb))
<!-- default file list end -->
# How to specify default parameter values in the WinForms Viewer


The following example shows how to specify default parameter values on dashboard loading. To do this, handle the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_DashboardLoadedtopic">DashboardViewer.DashboardLoaded</a> event, get access to the dashboard object using the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardLoadedEventArgs_Dashboardtopic">DashboardLoadedEventArgs.Dashboard</a> event parameter and specify the default value(s) using the <strong>Dashboard</strong>.<a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardCommonDashboard_Parameterstopic">Parameters</a>["parameterName"].<a href="https://documentation.devexpress.com/#Dashboard/DevExpressDataAccessParameter_Valuetopic">Value</a> property.<br><br><strong>See also:</strong> <a href="https://www.devexpress.com/Support/Center/p/T338459">How to pass a hidden dashboard parameter to a custom SQL query in the WinForms Viewer</a>

<br/>


