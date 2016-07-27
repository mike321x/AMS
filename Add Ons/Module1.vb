Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Security.Cryptography
Module Module1

    Sub getindex(cb As ComboBox, str As String)
        Dim indx As Integer = cb.FindString(str)
        cb.SelectedIndex = indx

    End Sub

  

    Function detectnull(ss As Object)
        Dim s As String
        If IsDBNull(ss) = True Then
            s = ""
        Else
            s = ss.ToString
        End If

        Return s
    End Function
    Sub autoformatdate(dt As DateTimePicker, lb As Label)
        lb.Text = dt.Value.Year.ToString & "-" & dt.Value.Month.ToString & "-" & dt.Value.Day.ToString
    End Sub
    Sub chkboxval2(chkbox As CheckBox, s As String)
        If s = "YES" Then
            chkbox.Checked = True
        Else
            chkbox.Checked = False
        End If
    End Sub

    Function chkboxval(chkbox As CheckBox)
        Dim vl As String
        If chkbox.Checked = True Then
            vl = "YES"
        Else
            vl = "NO"
        End If

        Return vl
    End Function
    Function GenerateHash(ByVal SourceText As String) As String
        'Create an encoding object to ensure the encoding standard for the source text
        Dim Ue As New UnicodeEncoding()
        'Retrieve a byte array based on the source text
        Dim ByteSourceText() As Byte = Ue.GetBytes(SourceText)
        'Instantiate an MD5 Provider object
        Dim Md5 As New MD5CryptoServiceProvider()
        'Compute the hash value from the source
        Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)
        'And convert it to String format for return
        Return Convert.ToBase64String(ByteHash)
    End Function
    Sub sqlcoms(ByRef sqlinfo As String, ByVal b As Boolean)
        Call open()
        Dim cmd As MySqlCommand = New MySqlCommand
        With cmd
            .CommandText = sqlinfo
            .CommandType = CommandType.Text
            .Connection = Globals.sqlconnection
            .ExecuteNonQuery()
        End With
        Call cls()
        If b = True Then
            MsgBox("Success!")
        End If
    End Sub

    Sub sqlcoms2(ByRef sqlinfo As String, ByVal b As Boolean)
        Call open()
        Dim cmd As MySqlCommand = New MySqlCommand
        With cmd
            .CommandText = sqlinfo
            .CommandType = CommandType.StoredProcedure
            .Connection = Globals.sqlconnection
            .ExecuteNonQuery()
        End With
        Call cls()
        If b = True Then
            MsgBox("Success!")
        End If
    End Sub

    Function sqlrcv(ByVal sqlst As String)
        Call open()
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim rval As Integer
        With cmd
            Try
                .CommandText = sqlst
                .CommandType = CommandType.Text
                .Connection = Globals.sqlconnection
                rval = Integer.Parse(.ExecuteScalar())
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End With
        Call cls()
        Return rval
    End Function

    Function sqlrcv2(ByVal sqlst As String)
        Call open()
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim rval As Double
        With cmd
            Try
                .CommandText = sqlst
                .CommandType = CommandType.Text
                .Connection = Globals.sqlconnection
                rval = Double.Parse(.ExecuteScalar())
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End With
        Call cls()
        Return rval
    End Function

    Function dateval(ByVal chk As CheckBox, ByVal dt As DateTimePicker)
        If chk.Checked = True Then
            Return Format(dt.Value, "yyyy-MM-dd")
        Else
            Return Format(Date.MinValue, "yyyy-MM-dd")
        End If

    End Function

    Function determinepages(ByVal num As Integer)
        Dim z As Integer
        Select Case num
            Case Is <= 10
                z = 1
            Case Is <= 20
                z = 2
            Case Is <= 30
                z = 3
            Case Is <= 40
                z = 4
        End Select
        Return z
    End Function
    Sub boxpic(ByVal picbox As PictureBox, ByVal img As String)
        If My.Computer.FileSystem.FileExists(img) = True Then
            picbox.Image = ResizeImage(System.Drawing.Bitmap.FromFile(img), picbox.Width, picbox.Height)
            picbox.Tag = img
        Else
            picbox.Image = Nothing

            ''ResizeImage(System.Drawing.Bitmap.FromFile("nopayroll.jpg"), picbox.Width, picbox.Height)
        End If
    End Sub

    Sub sqlaccess(ByVal sql As String)
        Call openaccess()
        With Globals.accessscmd
            .CommandText = sql
            .CommandType = CommandType.Text
            .Connection = Globals.accessconnection
            .ExecuteNonQuery()
        End With
        Call accesscls()
        MsgBox("Success!")
    End Sub

    Function checkdb(ByVal sql As String)
        loadtable2(sql)
        If Globals.table2.Rows.Count = 0 Then
            Return False
        ElseIf Globals.table2.Rows.Count = 1 Then

            Return True
        Else
            Return False
            MsgBox("Something Went Wrong, Please Contact Your System Administrator", MsgBoxStyle.Exclamation, "Error")
        End If
    End Function

    Sub addmonths(ByVal cbo As ComboBox)
        cbo.Items.Clear()
        cbo.Items.Add("Jan")
        cbo.Items.Add("Feb")
        cbo.Items.Add("Mar")
        cbo.Items.Add("Apr")
        cbo.Items.Add("May")
        cbo.Items.Add("Jun")
        cbo.Items.Add("Jul")
        cbo.Items.Add("Aug")
        cbo.Items.Add("Sep")
        cbo.Items.Add("Oct")
        cbo.Items.Add("Nov")
        cbo.Items.Add("Dec")
    End Sub

    Sub cls()
        If Globals.sqlconnection.State = ConnectionState.Open Then
            Globals.sqlconnection.Close()
            Globals.sqlconnection.Dispose()
        End If
    End Sub

    Sub accesscls()
        If Globals.accessconnection.State = ConnectionState.Open Then
            Globals.accessconnection.Close()
            Globals.accessconnection.Dispose()
        End If
    End Sub

    Function autosum(ByVal sql As String, ByVal amt As String)
        Dim i, a As Integer
        a = 0
        loadtable2(sql)
        For i = 0 To Globals.table2.Rows.Count - 1
            a = a + Integer.Parse(Globals.table2.Rows(i)(amt))
        Next
        Return a
    End Function

    Function filecounter(ByVal str1 As String, ByVal str2 As String)
        Dim fileCount As Integer
        If (Not System.IO.Directory.Exists(str1)) Then
            System.IO.Directory.CreateDirectory(str1)
        End If

        fileCount = IO.Directory.GetFiles(str1, str2).Length

        Return fileCount
    End Function

    Function loadtable(ByVal sqlsql As String)
        Dim sqladapter As New MySqlDataAdapter
        Globals.table.Rows.Clear()
        Call open()

        With Globals.sqlcommand
            .CommandText = sqlsql
            .Connection = Globals.sqlconnection
        End With

        With sqladapter
            .SelectCommand = Globals.sqlcommand
            .Fill(Globals.table)

        End With
        Return Globals.table
        Call cls()
    End Function

    Function accesstable(ByVal sqlsql As String)
        Globals.securitytable.Rows.Clear()
        Dim oleadapter As New OleDbDataAdapter
        Call openaccess()
        With Globals.accessscmd
            .CommandText = sqlsql
            .Connection = Globals.accessconnection
        End With
        With oleadapter
            .SelectCommand = Globals.accessscmd
            .Fill(Globals.securitytable)
        End With
        Return Globals.securitytable
        Call accesscls()

    End Function

    Function loadtable2(ByVal sqlsql As String)
        Dim sqladapter As New MySqlDataAdapter
        Globals.table2.Rows.Clear()
        Call open()

        With Globals.sqlcommand
            .CommandText = sqlsql
            .Connection = Globals.sqlconnection
        End With

        With sqladapter
            .SelectCommand = Globals.sqlcommand
            .Fill(Globals.table2)
        End With
        Return Globals.table2
        Call cls()
    End Function

    Function custable(ByVal sqlsql As String, Dt1 As DataTable)
        Dim sqladapter As New MySqlDataAdapter
        Dt1.Rows.Clear()
        Call open()

        With Globals.sqlcommand
            .CommandText = sqlsql
            .Connection = Globals.sqlconnection
        End With

        With sqladapter
            .SelectCommand = Globals.sqlcommand
            .Fill(Dt1)
        End With
        Return Dt1
        Call cls()
    End Function
    Function savekowt(ByVal s As String)
        Dim a As String
        a = Replace(s, "'", "@,")
        Return a
    End Function

    Function reversekowt(ByVal s As String)
        Dim a As String
        a = Replace(s, "@,", "'")
        Return a
    End Function

    Function ResizeImage(ByVal bmSource As Drawing.Bitmap, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32) As Drawing.Bitmap
        Dim bmDest As New Drawing.Bitmap(TargetWidth, TargetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)
        Dim nSourceAspectRatio = bmSource.Width / bmSource.Height
        Dim nDestAspectRatio = bmDest.Width / bmDest.Height
        Dim NewX = 0
        Dim NewY = 0
        Dim NewWidth = bmDest.Width
        Dim NewHeight = bmDest.Height
        If nDestAspectRatio = nSourceAspectRatio Then
            'same ratio
        ElseIf nDestAspectRatio > nSourceAspectRatio Then
            'Source is taller
            NewWidth = Convert.ToInt32(Math.Floor(nSourceAspectRatio * NewHeight))
            NewX = Convert.ToInt32(Math.Floor((bmDest.Width - NewWidth) / 2))
        Else
            'Source is wider
            NewHeight = Convert.ToInt32(Math.Floor((1 / nSourceAspectRatio) * NewWidth))
            NewY = Convert.ToInt32(Math.Floor((bmDest.Height - NewHeight) / 2))
        End If
        Using grDest = Drawing.Graphics.FromImage(bmDest)
            With grDest
                .CompositingQuality = Drawing.Drawing2D.CompositingQuality.HighQuality
                .InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                .PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighQuality
                .SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
                .CompositingMode = Drawing.Drawing2D.CompositingMode.SourceOver
                .DrawImage(bmSource, NewX, NewY, NewWidth, NewHeight)
            End With
        End Using
        Return bmDest
    End Function

    Function formatstringtodate(ByVal str As String)
        Dim d1 As Date
        Dim strarray() As String
        strarray = str.Split("-")
        d1 = strarray(0) & "-" & strarray(1) & "-" & strarray(2)
        Return Format(d1, "yyyy-MM-dd")
    End Function

    Function checktablecount(ByVal sqlsql As String)
        Dim sqladapter As New MySqlDataAdapter
        Globals.table.Rows.Clear()
        Call open()
        With Globals.sqlcommand
            .CommandText = sqlsql
            .Connection = Globals.sqlconnection
        End With

        With sqladapter
            .SelectCommand = Globals.sqlcommand
            .Fill(Globals.table)
        End With
        Return Globals.table.Rows.Count
        Call cls()
    End Function

    Sub populatecombobox(ByVal sqlsql As String, ByVal item As String, ByVal c As ComboBox)
        loadtable(sqlsql)
        c.Items.Clear()
        For i = 0 To Globals.table.Rows.Count - 1
            c.Items.Add(Globals.table.Rows(i)(item))
        Next
    End Sub

    Function fetchdata(ByVal sqlsql As String, ByVal item As String)
        loadtable(sqlsql)
        Return Globals.table.Rows(0)(item)
    End Function

    Sub open()

            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\config.txt") Then
                Dim lines = System.IO.File.ReadAllLines(Application.StartupPath & "\config.txt")
            Dim svrstring As String = lines(1)
            Dim userid As String = lines(5)
            Dim pass As String = lines(7)
            Dim dbname As String = lines(9)
            Dim PortNo As String = lines(3)
                Dim connstring As String = "server=" & svrstring & ";userid=" & userid & ";Port='" & PortNo & "';password=" & pass & ";database=" & dbname & ";"


            If Globals.sqlconnection.State = ConnectionState.Closed Then

                Globals.sqlconnection.ConnectionString = connstring
                Globals.sqlconnection.Open()



            End If
        Else
            MsgBox("Config.txt could not be found",MsgBoxStyle.Exclamation)

        End If


      

    End Sub

    Sub openaccess()
        If Globals.accessconnection.State = ConnectionState.Closed Then
            ' Globals.accessconnection.ConnectionString = Globals.connstring2
            Globals.accessconnection.Open()
            If Globals.accessconnection.State = ConnectionState.Open Then
            Else
                MsgBox("Access Connection Failed!")
            End If
        End If
    End Sub

    Function spellmonth(ByVal a As Integer)
        Dim b As String = ""
        Select Case a
            Case 1
                b = "Jan"
            Case 2
                b = "Feb"
            Case 3
                b = "Mar"
            Case 4
                b = "Apr"
            Case 5
                b = "May"
            Case 6
                b = "Jun"
            Case 7
                b = "Jul"
            Case 8
                b = "Aug"
            Case 9
                b = "Sep"
            Case 10
                b = "Oct"
            Case 11
                b = "Nov"
            Case 12
                b = "Dec"
        End Select
        Return b
    End Function

    Function spellmonth(ByVal a As String)
        Dim b As Integer
        Select Case a
            Case "Jan"
                b = 1
            Case "Feb"
                b = 2
            Case "Mar"
                b = 3
            Case "Apr"
                b = 4
            Case "May"
                b = 5
            Case "Jun"
                b = 6
            Case "Jul"
                b = 7
            Case "Aug"
                b = 8
            Case "Sep"
                b = 9
            Case "Oct"
                b = 10
            Case "Nov"
                b = 11
            Case "Dec"
                b = 12
        End Select
        Return b
    End Function
    Function getsql()

        Dim lines = System.IO.File.ReadAllLines(Application.StartupPath & "\config.txt")
        Dim svrstring As String = lines(1)
        Dim userid As String = lines(5)
        Dim pass As String = lines(7)
        Dim dbname As String = lines(9)
        Dim PortNo As String = lines(3)
        Dim connstring As String = "server=" & svrstring & ";userid=" & userid & ";Port='" & PortNo & "';password=" & pass & ";database=" & dbname & ";"


        Return (connstring)
    End Function

End Module
