Imports System.ComponentModel
Imports System.Text
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins


Public Class Main
    Sub New()
        InitSkins()
        InitializeComponent()
        Me.InitSkinGallery()
    End Sub
    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")
    End Sub
    Private Sub InitSkinGallery()
        SkinHelper.InitSkinGallery(rgbiSkins, True)
    End Sub


    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Process.GetCurrentProcess.Kill()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbdbDataSet.ForCOCIssuance' table. You can move, or remove it, as needed.

        DbdbDataSet.EnforceConstraints = False

        'TODO: This line of code loads data into the 'DbdbDataSet.ListOfAssessment' table. You can move, or remove it, as needed.
        'Me.ListOfAssessmentTableAdapter.Fill(Me.DbdbDataSet.ListOfAssessment)

        'TODO: This line of code loads data into the 'DbdbDataSet.establishmenttable' table. You can move, or remove it, as needed.
        establishmentlist()

        assessmentlist()

        getcoc()

    End Sub

    Sub getcoc()
        ForCOCIssuanceTableAdapter.Connection.ConnectionString = getsql()
        Me.ForCOCIssuanceTableAdapter.Fill(Me.DbdbDataSet.ForCOCIssuance)
    End Sub
    Sub establishmentlist()
        'Establishment Listing
        'loadtable("Select * from establishmenttable")
        'EstablishmenttableBindingSource.DataSource = Globals.table

        EstablishmenttableTableAdapter.Connection.ConnectionString = getsql()
        Me.EstablishmenttableTableAdapter.Fill(Me.DbdbDataSet.establishmenttable)
    End Sub

    Sub assessmentlist()
        'loadtable("SELECT assessmentlisttable.AssessmentID, establishmenttable.EstablishmentName, establishmenttable.EstablishmentAddress, establishmenttable.EstablishmentOwner, assessmentlisttable.AssessmentTypeVisit, assessmentlisttable.AssessmentStatus, assessmentlisttable.AssessmentDate, assessmentlisttable.AssessmentAuthorityNumber, assessmentlisttable.AssessmentCategory, assessmentlisttable.COCStatus, assessmentlisttable.AssessmentLLCO FROM assessmentlisttable INNER JOIN establishmenttable ON assessmentlisttable.EstablishmentID = establishmenttable.EstablishmentID")
        'ListOfAssessmentBindingSource.DataSource = Globals.table

        ListOfAssessmentTableAdapter.Connection.ConnectionString = getsql()
        Me.ListOfAssessmentTableAdapter.Fill(Me.DbdbDataSet.ListOfAssessment)

    End Sub

    
    Private Sub iNew_ItemClick(sender As Object, e As ItemClickEventArgs) Handles iNew.ItemClick

        Globals.table.Clear()
        XtraForm1.ShowDialog()
    End Sub

    Private Sub iExit_ItemClick(sender As Object, e As ItemClickEventArgs) Handles iExit.ItemClick
        End
    End Sub

   
    Private Sub ViewEstablishmentDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewEstablishmentDetailsToolStripMenuItem.Click
        Try

            'DataLayoutControl1.DataSource = Globals.table2
        If GridView1.SelectedRowsCount = 1 Then
                Dim param1 As String = GridView1.GetFocusedRowCellValue("EstablishmentID").ToString
                Dim dt1 As New DataTable
                Establishment_Detail.DataLayoutControl1.DataSource = custable("select * from establishmenttable where EstablishmentID='" & param1 & "'", dt1)
                Establishment_Detail.ShowDialog()

            Else


            End If
        Catch ex As Exception
            MsgBox("Please Select only 1 Specific Item to View " & vbNewLine & " " & ex.ToString & "")
        End Try
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        NewAssessmentForm.ShowDialog()

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As ItemClickEventArgs)
        establishmentlist()

    End Sub



    Private Sub BarButtonItem2_ItemClick_1(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem2.ItemClick

        Select Case (XtraTabControl1.SelectedTabPageIndex)
            Case 0
                GridControl1.ShowPrintPreview()
            Case 1
                GridControl2.ShowPrintPreview()
            Case 2
                GridControl3.ShowPrintPreview()
        End Select
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Select Case (XtraTabControl1.SelectedTabPageIndex)
            Case 0
                GridControl1.PrintDialog()
            Case 1
                GridControl2.PrintDialog()
            Case 2
                GridControl3.PrintDialog()

        End Select
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        DashboardView.Show()
    End Sub


 
  
    Private Sub ViewAssessmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAssessmentToolStripMenuItem.Click
        Try


            If GridView2.SelectedRowsCount = 1 Then
                Dim param1 As String = GridView2.GetFocusedRowCellValue("AssessmentID").ToString
                Dim dt As New DataTable


                AssessmentForm.DataLayoutControl1.DataSource = custable("select * from assessmentlisttable Inner Join establishmenttable on assessmentlisttable.EstablishmentID=establishmenttable.EstablishmentID where AssessmentID='" & param1 & "'", dt)
                AssessmentForm.SpinEdit2.Properties.DataSource = custable("select * from assessmentlisttable Inner Join establishmenttable on assessmentlisttable.EstablishmentID=establishmenttable.EstablishmentID where AssessmentID='" & param1 & "'", dt)
                AssessmentForm.SpinEdit2.Properties.DisplayMember = "EstablishmentName"
                AssessmentForm.SpinEdit2.Properties.ValueMember = "EstablishmentID"
                AssessmentForm.display1("select * from violationstable where AssessmentID like '" & param1 & "'")
                AssessmentForm.ShowDialog()
            Else

            End If
        Catch ex As Exception
            MsgBox("Please Select only 1 Specific Item to View " & vbNewLine & " " & ex.ToString & "")
        End Try
    End Sub




    Private Sub NoViolationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoViolationToolStripMenuItem.Click
        If GridView2.SelectedRowsCount = 1 Then
            Dim param1 As String = GridView2.GetFocusedRowCellValue("AssessmentID").ToString
            sqlcoms("Update assessmentlisttable set AssessmentStatus='NO VIOLATION' where AssessmentID='" & param1 & "'", True)
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "AssessmentStatus", "NO VIOLATION")
        End If
    End Sub

    Private Sub WithViolationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithViolationToolStripMenuItem.Click
        If GridView2.SelectedRowsCount = 1 Then
            Dim param1 As String = GridView2.GetFocusedRowCellValue("AssessmentID").ToString
            sqlcoms("Update assessmentlisttable set AssessmentStatus='WITH VIOLATION' where AssessmentID='" & param1 & "'", True)
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "AssessmentStatus", "WITH VIOLATION")
        End If
    End Sub

    Private Sub CompliedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompliedToolStripMenuItem.Click
        If GridView2.SelectedRowsCount = 1 Then
            Dim param1 As String = GridView2.GetFocusedRowCellValue("AssessmentID").ToString
            sqlcoms("Update assessmentlisttable set AssessmentStatus='COMPLIED' where AssessmentID='" & param1 & "'", True)
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "AssessmentStatus", "COMPLIED")
        End If
    End Sub

    Private Sub PrintedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintedToolStripMenuItem.Click
        If GridView2.SelectedRowsCount = 1 Then
            Dim param1 As String = GridView2.GetFocusedRowCellValue("AssessmentID").ToString
            sqlcoms("Update assessmentlisttable set COCStatus='PRINTED' where AssessmentID='" & param1 & "'", True)
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "COCStatus", "PRINTED")
        End If
    End Sub

    Private Sub IssuedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssuedToolStripMenuItem.Click
        If GridView2.SelectedRowsCount = 1 Then
            Dim param1 As String = GridView2.GetFocusedRowCellValue("AssessmentID").ToString
            sqlcoms("Update assessmentlisttable set COCStatus='ISSUED' where AssessmentID='" & param1 & "'", True)
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "COCStatus", "ISSUED")
        End If
    End Sub

    Private Sub ForIssuanceGLSOSHSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForIssuanceGLSOSHSToolStripMenuItem.Click
        If GridView2.SelectedRowsCount = 1 Then
            Dim param1 As String = GridView2.GetFocusedRowCellValue("AssessmentID").ToString
            sqlcoms("Update assessmentlisttable set COCStatus='FOR ISSUANCE OSHS & GLS' where AssessmentID='" & param1 & "'", True)
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "COCStatus", "FOR ISSUANCE OSH & GLS")
        End If
    End Sub

    Private Sub ForIssuanceOSHSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForIssuanceOSHSToolStripMenuItem.Click
        If GridView2.SelectedRowsCount = 1 Then
            Dim param1 As String = GridView2.GetFocusedRowCellValue("AssessmentID").ToString
            sqlcoms("Update assessmentlisttable set COCStatus='FOR ISSUANCE OSHS' where AssessmentID='" & param1 & "'", True)
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "COCStatus", "FOR ISSUANCE OSHS")
        End If
    End Sub

    Private Sub ForIssuanceGLSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForIssuanceGLSToolStripMenuItem.Click
        If GridView2.SelectedRowsCount = 1 Then
            Dim param1 As String = GridView2.GetFocusedRowCellValue("AssessmentID").ToString
            sqlcoms("Update assessmentlisttable set COCStatus='FOR ISSUANCE GLS' where AssessmentID='" & param1 & "'", True)
            GridView2.SetRowCellValue(GridView2.FocusedRowHandle, "COCStatus", "FOR ISSUANCE GLS")
        End If
    End Sub
End Class
