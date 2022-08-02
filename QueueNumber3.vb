Imports $safeprojectname$.Data.Odbc

Public Class QueueNumber3

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable


    Private Sub qEnqueue_Click(sender As Object, e As EventArgs) Handles qEnqueue.Click
        Me.Close()
        con = New OdbcConnection("DSN=mydatabase")
        con.Open()

        Dim digit As Integer
        Dim result As String
        Dim Query As String

        Query = "SELECT MAX(queueno) FROM queue.window3"

        com = New OdbcCommand(Query, con)
        result = com.ExecuteScalar.ToString()

        If String.IsNullOrEmpty(result) Then
            result = "C000"
            BunifuCustomLabel1.Text = result
        End If

        result = result.Substring(1)
        Int32.TryParse(result, digit)
        digit = digit + 1
        result = "C" + digit.ToString("D3")
        BunifuCustomLabel1.Text = result
        con.Close()

        con.Open()
        Dim Query2 As String
        Query2 = "INSERT INTO queue.window3 (queueno) VALUES ('" & result & "')"
        com = New OdbcCommand(Query2, con)
        com.ExecuteNonQuery()
        con.Close()

        con.Open()

        Dim Query3 As String

        Query3 = "SELECT * FROM queue.window3"
        com = New OdbcCommand(Query3, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        QueueingWindow.Window3Queue.DataSource = dt
        con.Close()
        con.Open()
        Dim Query4 As String

        Query4 = "SELECT * FROM queue.window3"
        com = New OdbcCommand(Query4, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        QueueController3.Window3Queue.DataSource = dt
        con.Close()

        If QueueController3.Window3Queue.Rows.Count > 0 Then
            QueueController3.qDequeue.Enabled = True
            QueueController3.qVoid.Enabled = True
        End If
        QueueingWindow.Window3Queue.Rows(0).DefaultCellStyle.ForeColor = Color.LimeGreen
        QueueingWindow.Window3Queue.Rows(0).Selected = False

        DashboardUpdate()
    End Sub

    Private Sub QueueNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OdbcConnection("DSN=mydatabase")
        con.Open()
        Dim digit As Integer
        Dim result As String
        Dim Query As String

        Query = "SELECT MAX(queueno) FROM queue.window3"

        com = New OdbcCommand(Query, con)
        result = com.ExecuteScalar.ToString()
        con.Close()

        If String.IsNullOrEmpty(result) Then
            result = "C000"
            BunifuCustomLabel1.Text = result
        End If

        result = result.Substring(1)
        Int32.TryParse(result, digit)
        digit = digit + 1
        result = "C" + digit.ToString("D3")
        BunifuCustomLabel1.Text = result
        con.Close()


        con.Open()

        Dim Query3 As String

        Query3 = "SELECT * FROM queue.window3"
        com = New OdbcCommand(Query3, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        QueueingWindow.Window3Queue.DataSource = dt
        con.Close()

        con.Open()
        Dim Query4 As String

        Query4 = "SELECT * FROM queue.window3"
        com = New OdbcCommand(Query4, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        QueueController3.Window3Queue.DataSource = dt
        con.Close()

        If QueueingWindow.Window3Queue.Rows.Count > 0 Then
            QueueingWindow.Window3Queue.Rows(0).DefaultCellStyle.ForeColor = Color.LimeGreen
            QueueingWindow.Window3Queue.Rows(0).Selected = False
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
    End Sub

    Sub DashboardUpdate()


        con.Open()
        Dim Query As String

        Query = "select Count(*) from queue.window1"
        com = New OdbcCommand(Query, con)
        Dim i As Integer = com.ExecuteScalar()
        com = Nothing
        InfodeskDashboard.Window1Number.Text = i
        con.Close()

        con.Open()
        Dim Query2 As String

        Query2 = "select Count(*) from queue.window2"
        com = New OdbcCommand(Query2, con)
        Dim i2 As Integer = com.ExecuteScalar()
        com = Nothing
        InfodeskDashboard.Window2Number.Text = i2
        con.Close()

        con.Open()
        Dim Query3 As String

        Query3 = "select Count(*) from queue.window3"
        com = New OdbcCommand(Query3, con)
        Dim i3 As Integer = com.ExecuteScalar()
        com = Nothing
        InfodeskDashboard.Window3Number.Text = i3
        con.Close()
    End Sub
End Class