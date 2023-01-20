<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581362/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T475858)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for WinForms - Specify Default Parameter Values for the Dashboard Loaded in the WinForms Viewer


This example demonstrates how to specify default parameter values when loading a dashboard.

## Example Overview

Handle the [SetInitialDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.SetInitialDashboardState) event. Create a [DashboardParameterState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardParameterState) instance and use its `Name` and `Value` properties to configure parameter values. Create a [DashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardState) object and add the specified dashboard parameter to the [DashboardState.Parameters](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardState.Parameters) collection. Assign the created `DashboardState` object to the [SetInitialDashboardStateBaseEventArgs.InitialState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.SetInitialDashboardStateBaseEventArgs.InitialState) property to apply specified parameter values when a dashboard is loading.

![screenshot](/images/screenshot.png)


## Files to Review

* [Form1.cs](./CS/WinViewer_DefaultParameterValues/Form1.cs) (VB: [Form1.vb](./VB/WinViewer_DefaultParameterValues/Form1.vb))

## Documentation

- [Dashboard Parameters](https://docs.devexpress.com/Dashboard/116918)
- [WinForms Viewer - Manage Dashboard Parameters](https://docs.devexpress.com/Dashboard/17632/winforms-dashboard/winforms-viewer/manage-dashboard-parameters)

## More Examples

* [How to: Pass a Dashboard Parameter to a Filter String in Code](https://github.com/DevExpress-Examples/how-to-pass-a-dashboard-parameter-to-a-filter-string-in-code-e5117)
* [How to: Pass a Dashboard Parameter to a Calculated Field's Expression in Code](https://github.com/DevExpress-Examples/how-to-pass-a-dashboard-parameter-to-a-calculated-fields-expression-in-code-e5135)
* [How to: Pass a Dashboard Parameter to a Custom SQL Query in Code](https://github.com/DevExpress-Examples/how-to-pass-a-dashboard-parameter-to-a-custom-sql-query-in-code-e5120)
* [How to: Pass a Hidden Dashboard Parameter to a Custom SQL Query in the WinForms Viewer](https://github.com/DevExpress-Examples/how-to-pass-a-hidden-dashboard-parameter-to-a-custom-sql-query-in-the-winforms-viewer-t338459)
* [How to: Use Dashboard Parameters with the Expression Format Condition](https://github.com/DevExpress-Examples/how-to-usedashboard-parameters-with-the-expressionformat-condition-t260065)
* [How to: Manage Parameters in the WinForms Viewer](https://github.com/DevExpress-Examples/winforms-dashboard-how-to-manage-dashboard-parameters-in-code-t635871)
* [How to: Display the Others Slice in the Pie Chart](https://github.com/DevExpress-Examples/how-to-display-pie-chart-others-slice)
