Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DashboardCommon
Imports DevExpress.XtraEditors

Public Class DashboardView

   

    

    Private Sub DashboardView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\dsbrd.xml") Then
            DashboardViewer1.LoadDashboard(Application.StartupPath & "\dsbrd.xml")
        Else
            MsgBox("Cannot Find dsbrd.xml!", vbInformation)

        End If




    End Sub
End Class