Public Class Establishment_Detail 



    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        display1("select * from assessmentlisttable where AssessmentID like '" & EstablishmentIDTextEdit.Text & "' ")
    End Sub

    Private Sub Establishment_Detail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub Establishment_Detail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub Establishment_Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        display1("select * from assessmentlisttable where EstablishmentID like '" & EstablishmentIDTextEdit.Text & "' ")

    End Sub




    Sub display1(ss As String)
        Try
            loadtable(ss)
            ListView1.Items.Clear()
            If Globals.table.Rows.Count >= 1 Then
                Dim items As New List(Of ListViewItem)
                Dim i = 0
                Do
                    Dim item As New ListViewItem
                    item.Text = Globals.table.Rows(i)("AssessmentID")
                    item.SubItems.Add(Globals.table.Rows(i)("AssessmentTypeVisit"))
                    item.SubItems.Add(Globals.table.Rows(i)("AssessmentCategory"))
                    item.SubItems.Add(Globals.table.Rows(i)("AssessmentAuthorityNumber"))
                    item.SubItems.Add(Globals.table.Rows(i)("AssessmentDate"))
                    item.SubItems.Add(Globals.table.Rows(i)("AssessmentLLCO"))
                    item.SubItems.Add(Globals.table.Rows(i)("AssessmentStatus"))
                    item.SubItems.Add(Globals.table.Rows(i)("COCStatus"))
                    i = i + 1
                    items.Add(item)
                Loop While (i <= Globals.table.Rows.Count - 1)
                ListView1.Items.AddRange(items.ToArray())
            Else
                ListView1.Items.Clear()
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Dispose()
    End Sub

    Private Sub ViewAssessmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAssessmentToolStripMenuItem.Click
        Try
            If ListView1.SelectedItems.Count = 1 Then
                Dim param1 As String = ListView1.SelectedItems(0).Text
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


    Private Sub UpdateAssessmentStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAssessmentStatusToolStripMenuItem.Click

    End Sub

    Private Sub WithViolationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WithViolationToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim param1 As String = ListView1.SelectedItems(0).Text
            sqlcoms("Update assessmentlisttable set AssessmentStatus='WITH VIOLATION' where AssessmentID='" & param1 & "'", True)
            ListView1.SelectedItems(0).SubItems(6).Text = "WITH VIOLATION"
        End If
    End Sub

    Private Sub NoViolationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoViolationToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim param1 As String = ListView1.SelectedItems(0).Text
            sqlcoms("Update assessmentlisttable set AssessmentStatus='NO VIOLATION' where AssessmentID='" & param1 & "'", True)
            ListView1.SelectedItems(0).SubItems(6).Text = "NO VIOLATION"
        End If
    End Sub

    Private Sub CompliedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompliedToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim param1 As String = ListView1.SelectedItems(0).Text
            sqlcoms("Update assessmentlisttable set AssessmentStatus='COMPLIED' where AssessmentID='" & param1 & "'", True)
            ListView1.SelectedItems(0).SubItems(6).Text = "COMPLIED"
        End If
    End Sub

    Private Sub PrintedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintedToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim param1 As String = ListView1.SelectedItems(0).Text
            sqlcoms("Update assessmentlisttable set COCStatus='PRINTED' where AssessmentID='" & param1 & "'", True)
            ListView1.SelectedItems(0).SubItems(7).Text = "PRINTED"
        End If
    End Sub

    Private Sub ForIssuanceGLSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForIssuanceGLSToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim param1 As String = ListView1.SelectedItems(0).Text
            sqlcoms("Update assessmentlisttable set COCStatus='FOR ISSUANCE GLS' where AssessmentID='" & param1 & "'", True)
            ListView1.SelectedItems(0).SubItems(7).Text = "FOR ISSUANCE GLS"
        End If
    End Sub

    Private Sub ForIssuanceOSHSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForIssuanceOSHSToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim param1 As String = ListView1.SelectedItems(0).Text
            sqlcoms("Update assessmentlisttable set COCStatus='FOR ISSUANCE OSHS' where AssessmentID='" & param1 & "'", True)
            ListView1.SelectedItems(0).SubItems(7).Text = "FOR ISSUANCE OSHS"
        End If
    End Sub

    Private Sub ForIssuanceGLSAndOSHSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForIssuanceGLSAndOSHSToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim param1 As String = ListView1.SelectedItems(0).Text
            sqlcoms("Update assessmentlisttable set COCStatus='FOR ISSUANCE GLS AND OSHS' where AssessmentID='" & param1 & "'", True)
            ListView1.SelectedItems(0).SubItems(7).Text = "FOR ISSUANCE GLS AND OSHS"
        End If
    End Sub

    Private Sub IssuedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IssuedToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            Dim param1 As String = ListView1.SelectedItems(0).Text
            sqlcoms("Update assessmentlisttable set COCStatus='ISSUED' where AssessmentID='" & param1 & "'", True)
            ListView1.SelectedItems(0).SubItems(7).Text = "ISSUED"
        End If
    End Sub
End Class