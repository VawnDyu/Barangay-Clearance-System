Imports $safeprojectname$.Data.Odbc

Public Class VoidMessage3

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable

    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        Yes()
        Me.Close()
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Me.Close()
    End Sub

    Private Sub BtnYes_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnYes.KeyDown
        If e.KeyCode = Keys.Enter Then
            Yes()
            Me.Close()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Sub Yes()
        con = New OdbcConnection("DSN=mydatabase")

        If QueueController3.Window3Queue.Rows.Count > 0 Then
            con.Open()
            Dim Query As String
            Query = "Delete from queue.window3 where queueno='" & QueueController3.Window3Queue.SelectedRows(0).Cells(0).Value & "'"
            com = New OdbcCommand(Query, con)
            com.ExecuteNonQuery()
            con.Close()
        End If

        If QueueController3.Window3Queue.Rows.Count = 1 Then
            QueueController3.qDequeue.Enabled = False
            QueueController3.qVoid.Enabled = False
        End If

        con.Open()
        Dim Query2 As String
        Query2 = "SELECT * FROM queue.window3"
        com = New OdbcCommand(Query2, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        QueueController3.Window3Queue.DataSource = dt
        con.Close()

        con.Open()
        Dim Query3 As String
        Query3 = "SELECT * FROM queue.window3"
        com = New OdbcCommand(Query3, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        QueueingWindow.Window3Queue.DataSource = dt
        con.Close()


        If QueueController3.Window3Queue.Rows.Count > 0 Then
            QueueingWindow.Window3Queue.Rows(0).DefaultCellStyle.ForeColor = Color.LimeGreen
            QueueingWindow.Window3Queue.Rows(0).Selected = False
        Else
        End If

        DashboardUpdate()
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