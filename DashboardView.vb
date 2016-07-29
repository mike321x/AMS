Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DashboardCommon
Imports DevExpress.XtraEditors
Imports System
Imports System.Data
Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.DataAccess
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Helpers


Public Class DashboardView
 
    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub DashboardView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\dsbrd.xml") Then
            DashboardViewer1.Dashboard = New Dashboard
            DashboardViewer1.LoadDashboard(Application.StartupPath & "\dsbrd.xml")
            DashboardViewer1.Refresh()
        Else
            MsgBox("Cannot Find dsbrd.xml!", vbInformation)
        End If
        refdata()

    End Sub
    
    Sub refdata()

        DashboardViewer1.Dashboard.DataSources(0).SqlDataProvider.SqlQuery = "select * from assessmentlisttable INNER JOIN Establishmenttable ON assessmentlisttable.establishmentID=establishmenttable.establishmentID "
        DashboardViewer1.ReloadData()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        refdata()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        refdata()
    End Sub
End Class