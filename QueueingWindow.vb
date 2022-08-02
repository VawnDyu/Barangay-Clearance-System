Imports $safeprojectname$.Data.Odbc

Public Class QueueingWindow

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable
    Dim timer As New Timer()


    Private Sub QueueingWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        timer.Interval = 100
        Timer1.Start()


        con = New OdbcConnection("DSN=mydatabase")

        con.Open()
        Dim Query2 As String
        Query2 = "SELECT * FROM queue.window1"
        com = New OdbcCommand(Query2, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        Window1Queue.DataSource = dt
        con.Close()

        If Window1Queue.Rows.Count > 0 Then
            Window1Queue.Rows(0).DefaultCellStyle.ForeColor = Color.LimeGreen
            Window1Queue.Rows(0).Selected = False
        End If


        con.Open()
        Dim Query3 As String
        Query3 = "SELECT * FROM queue.window2"
        com = New OdbcCommand(Query3, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        Window2Queue.DataSource = dt
        con.Close()

        If Window2Queue.Rows.Count > 0 Then
            Window2Queue.Rows(0).DefaultCellStyle.ForeColor = Color.LimeGreen
            Window2Queue.Rows(0).Selected = False
        End If


        con.Open()
        Dim Query4 As String
        Query4 = "SELECT * FROM queue.window3"
        com = New OdbcCommand(Query4, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        Window3Queue.DataSource = dt
        con.Close()

        If Window3Queue.Rows.Count > 0 Then
            Window3Queue.Rows(0).DefaultCellStyle.ForeColor = Color.LimeGreen
            Window3Queue.Rows(0).Selected = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Update()
    End Sub

    Public Sub Update()
        con = New OdbcConnection("DSN=mydatabase")

        con.Open()
        Dim Query2 As String
        Query2 = "SELECT * FROM queue.window1"
        com = New OdbcCommand(Query2, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        Window1Queue.DataSource = dt
        con.Close()

        If Window1Queue.Rows.Count > 0 Then
            Window1Queue.Rows(0).DefaultCellStyle.ForeColor = Color.LimeGreen
            Window1Queue.Rows(0).Selected = False
        End If


        con.Open()
        Dim Query3 As String
        Query3 = "SELECT * FROM queue.window2"
        com = New OdbcCommand(Query3, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        Window2Queue.DataSource = dt
        con.Close()

        If Window2Queue.Rows.Count > 0 Then
            Window2Queue.Rows(0).DefaultCellStyle.ForeColor = Color.LimeGreen
            Window2Queue.Rows(0).Selected = False
        End If


        con.Open()
        Dim Query4 As String
        Query4 = "SELECT * FROM queue.window3"
        com = New OdbcCommand(Query4, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        Window3Queue.DataSource = dt
        con.Close()

        If Window3Queue.Rows.Count > 0 Then
            Window3Queue.Rows(0).DefaultCellStyle.ForeColor = Color.LimeGreen
            Window3Queue.Rows(0).Selected = False
        End If
    End Sub
End Class