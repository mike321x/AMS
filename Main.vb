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


                AssessmentForm.DataLayoutControl1.DataSource = custable("select * from assessmentlisttable where AssessmentID='" & param1 & "'", dt)
                AssessmentForm.display1("select * from violationstable where AssessmentID like '" & param1 & "'")
                AssessmentForm.ShowDialog()
            Else

            End If
        Catch ex As Exception
            MsgBox("Please Select only 1 Specific Item to View " & vbNewLine & " " & ex.ToString & "")
        End Try
    End Sub

  
    Private Sub UpdateAssessmentStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAssessmentStatusToolStripMenuItem.Click
        If GridView2.SelectedRowsCount = 1 Then
            Dim param1 As String = GridView2.GetFocusedRowCellValue("AssessmentID").ToString

        End If
    End Sub

  

End Class
