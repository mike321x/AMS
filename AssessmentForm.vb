Public Class AssessmentForm 

 
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        DataLayoutControl1.DataSource = Globals.table

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub AssessmentForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
    Private Sub AssessmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MsgBox(AssessmentIDSpinEdit.Text)
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
                    item.Text = Globals.table.Rows(i)("ViolationsID")
                    item.SubItems.Add(Globals.table.Rows(i)("ViolationName"))
                    item.SubItems.Add(Globals.table.Rows(i)("ViolationType"))
                    item.SubItems.Add(Globals.table.Rows(i)("ViolationStatus"))
                  
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
End Class