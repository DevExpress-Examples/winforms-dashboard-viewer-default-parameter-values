<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WinViewer_DefaultParameterValues/Form1.cs) (VB: [Form1.vb](./VB/WinViewer_DefaultParameterValues/Form1.vb))
<!-- default file list end -->
# How to Specify Default Parameter Values for the Dashboard Loaded in the WinForms Viewer


This example demonstrates how to specify default parameter values when loading a dashboard.

Handle the [DashboardLoaded](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardLoaded) event, use the  [e.Dashboard](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardLoadedEventArgs.Dashboard) property to get access to the dashboard and specify values in the [Dashboard.Parameters](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.Dashboard.Parameters) collection.

See also:
*  [How to Pass a Hidden Dashboard Parameter to a Custom SQL query](https://github.com/DevExpress-Examples/how-to-pass-a-hidden-dashboard-parameter-to-a-custom-sql-query-in-the-winforms-viewer-t338459)



![screenshot](/images/screenshot.png)

