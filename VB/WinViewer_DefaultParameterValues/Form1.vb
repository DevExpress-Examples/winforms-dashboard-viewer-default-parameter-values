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

		Private Sub dashboardViewer1_SetInitialDashboardState(ByVal sender As Object, ByVal e As SetInitialDashboardStateEventArgs)
			Dim state As New DashboardState()
			Dim parameters As New DashboardParameterState()
			parameters.Name = "customerIdParameter"
			parameters.Value = New List(Of String)() From {"ALFKI", "AROUT", "BONAP"}
			state.Parameters.Add(parameters)
			e.InitialState = state
		End Sub

		Private Sub dashboardViewer1_ConfigureDataConnection(ByVal sender As Object, ByVal e As DashboardConfigureDataConnectionEventArgs) Handles dashboardViewer1.ConfigureDataConnection
			If e.DataSourceName = "SQL Data Source 1" Then
				e.ConnectionParameters = New Access97ConnectionParameters("..\..\Data\nwind.mdb", "", "")
			End If
		End Sub
	End Class
End Namespace
