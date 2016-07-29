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
    Inherits XtraForm
    Private dashboardId As Integer = 1
    Private currentDashboardStream As MemoryStream


    Public Sub New()
        InitializeComponent()
    End Sub


    

    Private Sub DashboardView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\dsbrd.xml") Then
            DashboardViewer1.Dashboard = New Dashboard
            DashboardViewer1.LoadDashboard(Application.StartupPath & "\dsbrd.xml")

            ' DashboardViewer1.DashboardSource() = Application.StartupPath & "\dsbrd.xml"
            DashboardViewer1.Refresh()
            'MsgBox(currentDashboardStream.)
        Else
            MsgBox("Cannot Find dsbrd.xml!", vbInformation)
        End If


        refdata()

    End Sub
    


    Private Sub RefreshDashboard()
        Try

            
            Dim ms As New MemoryStream


            'Dim bt As New Byte(File.Length - 1) {}

          


            Using ms1 As New MemoryStream()
                Using file As New FileStream(Application.StartupPath & "\dsbrd.xml", FileMode.Open, FileAccess.Read)
                    Dim bytes As Byte() = New Byte(file.Length - 1) {}
                    file.Read(bytes, 0, CInt(file.Length))
                    ms.Write(bytes, 0, CInt(file.Length))
                End Using
            End Using



            If ms IsNot Nothing Then
                If currentDashboardStream IsNot Nothing Then
                    currentDashboardStream.Dispose()
                End If
                currentDashboardStream = ms
            End If
            If currentDashboardStream IsNot Nothing Then
                DashboardViewer1.LoadDashboard(currentDashboardStream)
                DashboardViewer1.Dashboard.Title.Visible = False
            End If
        Catch e As Exception
            XtraMessageBox.Show(If(e.InnerException IsNot Nothing, e.InnerException.Message, e.Message), "AMS Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        'RefreshDashboard()
        refdata()
    End Sub

    Sub refdata()
        DashboardViewer1.Dashboard.DataSources(0).SqlDataProvider.SqlQuery = "select * from assessmentlisttable INNER JOIN Establishmenttable ON assessmentlisttable.establishmentID=establishmenttable.establishmentID "
        DashboardViewer1.ReloadData()
    End Sub
End Class