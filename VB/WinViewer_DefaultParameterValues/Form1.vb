Imports System.Collections.Generic
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports DevExpress.DataAccess.ConnectionParameters

Namespace WinViewer_DefaultParameterValues
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub dashboardViewer1_DashboardLoaded(ByVal sender As Object, ByVal e As DashboardLoadedEventArgs) _
            Handles dashboardViewer1.DashboardLoaded
            ' Specifies default parameter values.
            e.Dashboard.Parameters("customerIdParameter").Value = New List(Of String)() From {"ALFKI", "AROUT", "BONAP"}
        End Sub

        Private Sub dashboardViewer1_ConfigureDataConnection(ByVal sender As Object, _
                                                             ByVal e As DashboardConfigureDataConnectionEventArgs) _
                                                         Handles dashboardViewer1.ConfigureDataConnection
            If e.DataSourceName = "SQL Data Source 1" Then
                e.ConnectionParameters = New Access97ConnectionParameters("..\..\Data\nwind.mdb", "", "")
            End If
        End Sub
    End Class
End Namespace
