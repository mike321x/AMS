Public Class Establishment_Detail 



    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        DataLayoutControl1.DataSource = Globals.table2
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
        display1("select * from assessmentlisttable where AssessmentID like '" & EstablishmentIDTextEdit.Text & "' ")
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
                loadtable("select * from assessmentlisttable where AssessmentID='" & param1 & "'")
                AssessmentForm.ShowDialog()
                AssessmentForm.display1("select * from violationstable where AssessmentID like '" & param1 & "'")
            Else

            End If
        Catch ex As Exception
            MsgBox("Please Select only 1 Specific Item to View " & vbNewLine & " " & ex.ToString & "")
        End Try
    End Sub
End Class