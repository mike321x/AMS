Public Class Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            Dim sqlstr As String = "select * from accountstable where AccountUser like '" & UsernameTextBox.Text & "' and AccountPassword like'" & PasswordTextBox.Text & "'"

            If checktablecount(sqlstr) = 1 Then
                loadtable("select * from accountstable where AccountUser like '" & UsernameTextBox.Text & "' and AccountPassword like'" & PasswordTextBox.Text & "'")
                Globals.LLCONAME = Globals.table.Rows(0)("FirstName") & " " & Globals.table.Rows(0)("LastName")

                Main.Show()
                MsgBox("You have logged in as " & Globals.LLCONAME)
                cleartext()
            ElseIf checktablecount(sqlstr) = 0 Then
                MsgBox("Invalid Username or Password", MsgBoxStyle.Information, "Error")
                cleartext()
            Else
                MsgBox("Something Went Wrong, Please Contact Your System Administrator", MsgBoxStyle.Exclamation, "Error")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Dispose()
    End Sub
    Sub cleartext()
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
