Imports $safeprojectname$.Data.Odbc

Public Class InfodeskDashboard

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable

    Private Sub InfodeskDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OdbcConnection("DSN=mydatabase")


        con.Open()
        Dim Query As String

        Query = "select Count(*) from queue.window1"
        com = New OdbcCommand(Query, con)
        Dim i As Integer = com.ExecuteScalar()
        com = Nothing
        Window1Number.Text = i
        con.Close()

        con.Open()
        Dim Query2 As String

        Query2 = "select Count(*) from queue.window2"
        com = New OdbcCommand(Query2, con)
        Dim i2 As Integer = com.ExecuteScalar()
        com = Nothing
        Window2Number.Text = i2
        con.Close()

        con.Open()
        Dim Query3 As String

        Query3 = "select Count(*) from queue.window3"
        com = New OdbcCommand(Query3, con)
        Dim i3 As Integer = com.ExecuteScalar()
        com = Nothing
        Window3Number.Text = i3
        con.Close()



        con.Open()
        Dim Query4 As String

        Query4 = "SELECT window1 from queue.status"
        com = New OdbcCommand(Query4, con)
        Dim status As String = com.ExecuteScalar()
        com = Nothing
        status1.Text = status
        con.Close()

        con.Open()
        Dim Query5 As String

        Query5 = "SELECT window1 from queue.status"
        com = New OdbcCommand(Query5, con)
        Dim statusb As String = com.ExecuteScalar()
        com = Nothing
        status2.Text = statusb
        con.Close()

        con.Open()
        Dim Query6 As String

        Query6 = "SELECT window1 from queue.status"
        com = New OdbcCommand(Query6, con)
        Dim statusc As String = com.ExecuteScalar()
        com = Nothing
        status3.Text = statusc
        con.Close()

        If status1.Text = "OFFLINE" Then
            status1.ForeColor = Color.LightCoral
        End If

        If status2.Text = "OFFLINE" Then
            status2.ForeColor = Color.LightCoral
        End If

        If status3.Text = "OFFLINE" Then
            status3.ForeColor = Color.LightCoral
        End If

        If status1.Text = "ONLINE" Then
            status1.ForeColor = Color.SeaGreen
        End If

        If status2.Text = "ONLINE" Then
            status2.ForeColor = Color.SeaGreen
        End If

        If status3.Text = "ONLINE" Then
            status3.ForeColor = Color.SeaGreen
        End If
    End Sub
End Class