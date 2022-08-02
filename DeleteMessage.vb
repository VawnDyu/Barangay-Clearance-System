Imports $safeprojectname$.Data.Odbc

Public Class DeleteMessage

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable

    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        Yes()
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Me.Close()
    End Sub

    Private Sub BtnYes_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnYes.KeyDown
        If e.KeyCode = Keys.Enter Then
            Yes()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Sub Yes()
        con = New OdbcConnection("DSN=mydatabase")

        con.Open()
        com = New OdbcCommand("Delete from employeeaccount.employee where firstname='" & EmployeeAccount.firstname & "'", con)
        com.ExecuteNonQuery()
        con.Close()

        con.Open()
        com = New OdbcCommand("SELECT * FROM employeeaccount.employee", con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        EmployeeAccount.EmployeeAccountList.DataSource = dt
        con.Close()
        Me.Close()
    End Sub

End Class