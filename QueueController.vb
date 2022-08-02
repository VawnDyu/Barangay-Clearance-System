Imports $safeprojectname$.Data.Odbc

Public Class QueueController

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable

    Private Sub QueueController_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OdbcConnection("DSN=mydatabase")
        con.Open()

        Dim Query As String

        Query = "SELECT * FROM queue.window1"
        com = New OdbcCommand(Query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        Window1Queue.DataSource = dt
        con.Close()

        If Window1Queue.Rows.Count = 0 Then
            qDequeue.Enabled = False
            qVoid.Enabled = False
        Else
            qDequeue.Enabled = True
            qVoid.Enabled = True

        End If

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles qDequeue.Click
        con = New OdbcConnection("DSN=mydatabase")

        If Window1Queue.Rows.Count > 0 Then
            con.Open()
            Dim Query As String
            Query = "Delete from queue.window1 where queueno='" & Window1Queue.Rows(0).Cells(0).Value & "'"
            com = New OdbcCommand(Query, con)
            com.ExecuteNonQuery()
            con.Close()
        End If

        If Window1Queue.Rows.Count = 1 Then
            qDequeue.Enabled = False
            qVoid.Enabled = False
        End If

        con.Open()
        Dim Query2 As String
        Query2 = "SELECT * FROM queue.window1"
        com = New OdbcCommand(Query2, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        Window1Queue.DataSource = dt
        con.Close()

        con.Open()
        Dim Query3 As String
        Query3 = "SELECT * FROM queue.window1"
        com = New OdbcCommand(Query3, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        QueueingWindow.Window1Queue.DataSource = dt
        con.Close()


        If Window1Queue.Rows.Count > 0 Then
            QueueingWindow.Window1Queue.Rows(0).DefaultCellStyle.ForeColor = Color.LimeGreen
            QueueingWindow.Window1Queue.Rows(0).Selected = False
        Else
        End If

        DashboardUpdate()

    End Sub

    Private Sub qEnqueue_Click(sender As Object, e As EventArgs) Handles qEnqueue.Click


        QueueNumber.ShowDialog()

        If Window1Queue.Rows.Count > 0 Then
            QueueingWindow.Window1Queue.Rows(0).DefaultCellStyle.ForeColor = Color.LimeGreen
            QueueingWindow.Window1Queue.Rows(0).Selected = False
        End If
    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        con = New OdbcConnection("DSN=mydatabase")
        con.Open()
        Dim query As String
        query = "UPDATE queue.status set window1 = 'OFFLINE' where no = '1'"
        com = New OdbcCommand(query, con)
        com.ExecuteNonQuery()
        InfodeskDashboard.status1.ForeColor = Color.LightCoral
        WindowSelection.status1.ForeColor = Color.LightCoral
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
        com = New OdbcCommand(Query3, con)
        Dim statusa As String = com.ExecuteScalar()
        com = Nothing
        WindowSelection.status1.Text = statusa
        con.Close()
        '======================================================================'

        Me.Close()
        WindowSelection.Show()
    End Sub

    Private Sub qVoid_Click(sender As Object, e As EventArgs) Handles qVoid.Click


        If Window1Queue.Rows.Count = 1 Then
            qDequeue.Enabled = False
            qVoid.Enabled = False
        End If

        If Window1Queue.Rows.Count > 0 Then
            VoidMessage.ShowDialog()
        End If


    End Sub

    Private Sub BunifuFlatButton1_Click_1(sender As Object, e As EventArgs) Handles qCall.Click

        PlaySound()

    End Sub

    Sub PlaySound()
        Dim Mytone As New $safeprojectname$.Media.SoundPlayer


        Mytone.SoundLocation = "C:\Users\Vonne Dew Salig\Desktop\call.wav"
        Mytone.Load()
        Mytone.Play()

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