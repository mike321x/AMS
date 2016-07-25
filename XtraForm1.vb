Public Class XtraForm1 

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        DataLayoutControl1.DataSource = Globals.table

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub XtraForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbdbDataSet.establishmenttable' table. You can move, or remove it, as needed.
        'Me.EstablishmenttableTableAdapter.Connection.ConnectionString = getsql()
        'Me.EstablishmenttableTableAdapter.Fill(Me.DbdbDataSet.establishmenttable)





    End Sub

  

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Me.Dispose()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'MsgBox("VALUES('" & EstablishmentNameTextEdit.Text & "',  '" & EstablishmentAddressTextEdit.Text & "',  '" & EstablishmentOwnerTextEdit.Text & "',  '" & NoOfMaleWorkersSpinEdit.Text & "',  '" & NoOfFemaleWorkersSpinEdit.Text & "',  '" & UnionComboBoxEdit.SelectedItem.ToString & "',  '" & CBAComboBoxEdit.SelectedItem.ToString & "',  '" & EstablishmentTypeComboBoxEdit.Text & "',  '" & NatureOfBusinessComboBoxEdit.Text & "'")
        sqlcoms("INSERT INTO  establishmenttable(EstablishmentName, EstablishmentAddress, EstablishmentOwner, NoOfMaleWorkers, NoOfFemaleWorkers, `Union`, CBA, EstablishmentType, NatureOfBusiness) VALUES ('" & EstablishmentNameTextEdit.Text & "',  '" & EstablishmentAddressTextEdit.Text & "',  '" & EstablishmentOwnerTextEdit.Text & "',  '" & NoOfMaleWorkersSpinEdit.Text & "',  '" & NoOfFemaleWorkersSpinEdit.Text & "',  '" & UnionComboBoxEdit.SelectedItem & "',  '" & CBAComboBoxEdit.SelectedItem & "',  '" & EstablishmentTypeComboBoxEdit.Text & "',  '" & NatureOfBusinessComboBoxEdit.Text & "')", True)
        'sqlcoms("INSERT INTO establishmenttable(EstablishmentName, EstablishmentAddress, EstablishmentOwner, NoOfMaleWorkers, NoOfFemaleWorkers, Union, CBA, EstablishmentType, NatureOfBusiness) VALUES('A', 'B', 'C', '4', '5', 'YES', 'YES', 'Type', 'Bus')", True)
        Main.establishmentlist()
        Me.Dispose()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        cleardata()
    End Sub

    Sub cleardata()
        EstablishmentNameTextEdit.Text = ""
        EstablishmentAddressTextEdit.Text = ""
        EstablishmentOwnerTextEdit.Text = ""
        EstablishmentTypeComboBoxEdit.Text = ""
        NoOfFemaleWorkersSpinEdit.Value = 0
        NoOfMaleWorkersSpinEdit.Value = 0
        NatureOfBusinessComboBoxEdit.Text = ""
        CBAComboBoxEdit.Text = ""
        UnionComboBoxEdit.Text = ""

    End Sub
End Class