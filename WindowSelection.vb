Imports $safeprojectname$.Data.Odbc

Public Class WindowSelection

    Dim con As OdbcConnection
    Dim com As OdbcCommand

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Private Sub btnWindow1_Click(sender As Object, e As EventArgs) Handles btnWindow1.Click
        con = New OdbcConnection("DSN=mydatabase")
        con.Open()
        Dim query As String
        query = "UPDATE queue.status set window1 = 'ONLINE' where no = '1'"
        com = New OdbcCommand(query, con)
        com.ExecuteNonQuery()
        InfodeskDashboard.status1.ForeColor = Color.SeaGreen
        status1.ForeColor = Color.SeaGreen
        con.Close()

        con.Open()
        Dim Query2 As String

        Query2 = "SELECT window1 from queue.status"
        com = New OdbcCommand(Query2, con)
        Dim status As String = com.ExecuteScalar()
        com = Nothing
        InfodeskDashboard.status1.Text = status
        con.Close()

        con.Open()
        Dim Query3 As String

        Query3 = "SELECT window1 from queue.status"
        com = New OdbcCommand(Query2, con)
        Dim statusa As String = com.ExecuteScalar()
        com = Nothing
        status1.Text = statusa
        con.Close()


        '==========================================================='

        Me.Close()
        QueueController.ShowDialog()



    End Sub

    Private Sub btnWindow2_Click(sender As Object, e As EventArgs) Handles btnWindow2.Click
        con = New OdbcConnection("DSN=mydatabase")
        con.Open()
        Dim query As String
        query = "UPDATE queue.status set window2 = 'ONLINE' where no = '1'"
        com = New OdbcCommand(query, con)
        com.ExecuteNonQuery()
        InfodeskDashboard.status2.ForeColor = Color.SeaGreen
        status2.ForeColor = Color.SeaGreen
        con.Close()

        con.Open()
        Dim Query2 As String

        Query2 = "SELECT window2 from queue.status"
        com = New OdbcCommand(Query2, con)
        Dim status As String = com.ExecuteScalar()
        com = Nothing
        InfodeskDashboard.status2.Text = status
        con.Close()

        con.Open()
        Dim Query3 As String

        Query3 = "SELECT window2 from queue.status"
        com = New OdbcCommand(Query2, con)
        Dim statusa As String = com.ExecuteScalar()
        com = Nothing
        status2.Text = statusa
        con.Close()


        '==========================================================='


        Me.Close()
        QueueController2.ShowDialog()

    End Sub

    Private Sub btnWindow3_Click(sender As Object, e As EventArgs) Handles btnWindow3.Click
        con = New OdbcConnection("DSN=mydatabase")
        con.Open()
        Dim query As String
        query = "UPDATE queue.status set window3 = 'ONLINE' where no = '1'"
        com = New OdbcCommand(query, con)
        com.ExecuteNonQuery()
        InfodeskDashboard.status3.ForeColor = Color.SeaGreen
        status3.ForeColor = Color.SeaGreen
        con.Close()

        con.Open()
        Dim Query2 As String

        Query2 = "SELECT window3 from queue.status"
        com = New OdbcCommand(Query2, con)
        Dim status As String = com.ExecuteScalar()
        com = Nothing
        InfodeskDashboard.status3.Text = status
        con.Close()

        con.Open()
        Dim Query3 As String

        Query3 = "SELECT window3 from queue.status"
        com = New OdbcCommand(Query2, con)
        Dim statusa As String = com.ExecuteScalar()
        com = Nothing
        status3.Text = statusa
        con.Close()


        '==========================================================='

        Me.Close()
        QueueController3.ShowDialog()

    End Sub

    Private Sub WindowSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OdbcConnection("DSN=mydatabase")

        con.Open()
        Dim Query1 As String

        Query1 = "SELECT window1 from queue.status"
        com = New OdbcCommand(Query1, con)
        Dim statusa As String = com.ExecuteScalar()
        com = Nothing
        status1.Text = statusa
        con.Close()

        con.Open()
        Dim Query2 As String

        Query2 = "SELECT window2 from queue.status"
        com = New OdbcCommand(Query2, con)
        Dim statusb As String = com.ExecuteScalar()
        com = Nothing
        status2.Text = statusb
        con.Close()

        con.Open()
        Dim Query3 As String

        Query3 = "SELECT window3 from queue.status"
        com = New OdbcCommand(Query3, con)
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