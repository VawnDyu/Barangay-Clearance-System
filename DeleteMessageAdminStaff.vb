Imports $safeprojectname$.Data.Odbc

Public Class DeleteMessageAdminStaff

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
        com = New OdbcCommand("Delete from barangay.residents where firstname='" & Clearance.firstname & "'", con)
        com.ExecuteNonQuery()
        con.Close()


        con.Open()
        com = New OdbcCommand("SELECT * FROM barangay.residents", con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        Clearance.ResidentDataList.DataSource = dt
        con.Close()
        Me.Close()

    End Sub

End Class