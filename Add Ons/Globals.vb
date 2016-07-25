Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Public Class Globals

    'Public Shared connstring2 As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SAPConfig.accdb;Persist Security Info=False;"
    'Public Shared connstring2 = "provider = Microsoft.ACE.OLEDB.12.0; data source =" & Application.StartupPath & "\WASConfig.accdb"
    Public Shared accessconnection As New OleDbConnection
    Public Shared accessscmd As New OleDbCommand
    Public Shared securitytable As New DataTable
    Public Shared dbname As String
    Public Shared LLCONAME As String

    'Public Shared svrstring As String
    'Public Shared userid As String
    'Public Shared pass As String
    'Public Shared picfolder As String


    Public Shared sqlconnection As MySqlConnection = New MySqlConnection
    Public Shared sqlcommand As New MySqlCommand
    Public Shared sqlinfo As String
    Public Shared table As New DataTable
    Public Shared table2 As New DataTable

    Public Shared a As String
    Public Shared orsnumber As String
    Public Shared arraystr() As String
    Public Shared stritems As New List(Of String)
    Public Shared usrid As String


End Class
