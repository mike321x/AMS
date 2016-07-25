Public Class NewAssessmentForm 

    Private Sub NewAssessmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TODO: This line of code loads data into the 'DbdbDataSet.violationstable' table. You can move, or remove it, as needed.
    
        'TODO: This line of code loads data into the 'DbdbDataSet.violationlist' table. You can move, or remove it, as needed.
        Me.ViolationlistTableAdapter.Connection.ConnectionString = getsql()
        Me.ViolationlistTableAdapter.Fill(Me.DbdbDataSet.violationlist)
        'TODO: This line of code loads data into the 'DbdbDataSet.establishmenttable' table. You can move, or remove it, as needed.
        Me.EstablishmenttableTableAdapter.Connection.ConnectionString = getsql()
        Me.EstablishmenttableTableAdapter.Fill(Me.DbdbDataSet.establishmenttable)

        AssessmentDateDateEdit.Properties.DisplayFormat.FormatString = "yyyy-MM-dd"

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Dispose()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'BackgroundWorker1.RunWorkerAsync()

        '>>

        loadtable2("select * from assessmentlisttable")
        Dim idnum As Integer = Globals.table2.Rows.Count + 1
        sqlcoms("insert into assessmentlisttable(AssessmentID, EstablishmentID, AssessmentTypeVisit, AssessmentStatus, AssessmentDate, AssessmentAuthorityNumber, AssessmentProvince, AssessmentCategory, COCStatus, `AssessmentFindings/Remarks`, AssessmentLLCO ) Values('" & idnum & "', '" & EstablishmentIDLookUpEdit.EditValue & "', '" & AssessmentTypeVisitComboBoxEdit.Text & "', '" & AssessmentStatusComboBoxEdit.Text & "', '" & AssessmentDateDateEdit.Text & "', '" & AssessmentAuthorityNumberTextEdit.Text & "', '" & AssessmentProvinceComboBoxEdit.Text & "', '" & AssessmentCategoryComboBoxEdit.Text & "', '" & COCStatusComboBoxEdit.Text & "', '" & MemoEdit1.Text & "', '" & Globals.LLCONAME & "')", False)
        loadtable2("select * from assessmentlisttable where AssessmentID='" & idnum & "'")
        If ListView1.Items.Count > 0 Then
            If Globals.table2.Rows.Count = 1 Then
                Dim sqlins As String = "Insert into violationstable(AssessmentID, ViolationName, ViolationStatus, ViolationType)"
                Dim sqlval As String = "Values"
                For i = 0 To ListView1.Items.Count - 1
                    If i = ListView1.Items.Count - 1 Then
                        sqlval &= "('" & idnum & "', '" & ListView1.Items(i).Text & "', '" & ListView1.Items(i).SubItems(2).Text & "', '" & ListView1.Items(i).SubItems(1).Text & "')"
                    Else
                        sqlval &= "('" & idnum & "', '" & ListView1.Items(i).Text & "', '" & ListView1.Items(i).SubItems(2).Text & "', '" & ListView1.Items(i).SubItems(1).Text & "'), "
                    End If
                Next
                sqlcoms(sqlins & sqlval, False)
            End If
        End If


        '>>>
        Main.assessmentlist()

        Me.Dispose()
    End Sub


    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If LookUpEdit1.Text = "" And ComboBoxEdit1.Text = "" Then
            MsgBox("Please provide a violation with a status")
        Else
            Dim i As Integer = ListView1.Items.Count


            ListView1.Items.Add(LookUpEdit1.Text)
            ListView1.Items(i).SubItems.Add(LookUpEdit1.Tag)
            ListView1.Items(i).SubItems.Add(ComboBoxEdit1.Text)
        End If
        
    End Sub


    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim i As Integer = 0
            Do Until ListView1.SelectedItems.Count = 0
                ListView1.SelectedItems(i).Remove()
                i += i

            Loop
        Else
            MsgBox("Please select an Item to remove")
        End If
    End Sub

   

    Private Sub LookUpEdit1_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

  
End Class