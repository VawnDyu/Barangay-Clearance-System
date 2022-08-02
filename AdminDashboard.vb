Imports $safeprojectname$.Data.Odbc

Public Class AdminDashboard

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con = New OdbcConnection("DSN=mydatabase")


        con.Open()
        Dim Query As String

        Query = "select Count(*) from employee where userlevel = 'Admin Staff'"
        com = New OdbcCommand(Query, con)
        Dim i As Integer = com.ExecuteScalar()
        com = Nothing
        AdminStaffNumber.Text = i
        con.Close()

        con.Open()
        Dim Query2 As String

        Query2 = "select Count(*) from employee where userlevel = 'Information Desk Personnel'"
        com = New OdbcCommand(Query2, con)
        Dim i2 As Integer = com.ExecuteScalar()
        com = Nothing
        InfoDeskNumber.Text = i2
        con.Close()

        con.Open()
        Dim Query3 As String

        Query3 = "select Count(*) from employee"
        com = New OdbcCommand(Query3, con)
        Dim i3 As Integer = com.ExecuteScalar()
        com = Nothing
        TotalEmployeeNumber.Text = i3
        con.Close()

        con.Open()

        Dim Query4 As String

        Query4 = "SELECT firstname, username, userlevel, gender FROM employee"
        com = New OdbcCommand(Query4, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        EmployeeAccountList.DataSource = dt
        con.Close()

    End Sub
End Class