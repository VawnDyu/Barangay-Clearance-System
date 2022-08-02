Imports $safeprojectname$.Data.Odbc

Public Class SignOutMessage

    Dim con As OdbcConnection
    Dim com As OdbcCommand

    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        Yes()
    End Sub

    Private Sub BtnYes_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnYes.KeyDown
        If e.KeyCode = Keys.Enter Then
            Yes()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Me.Close()
    End Sub

    Sub Yes()
        con = New OdbcConnection("DSN=mydatabase")

        Dim Query As String
        con.Open()
        Query = "UPDATE employeeattendance.attendance SET time_out = '" & lblTime.Text & "' where time_in = '" & Login.temp & "' AND userlevel = '" & Login.tempuserlevel & "'"
        com = New OdbcCommand(Query, con)
        com.ExecuteNonQuery()
        con.Close()


        Me.Close()

        If Login.tempuserlevel = "Head Admin" Then
            Admin.Hide()
        ElseIf Login.tempuserlevel = "Admin Staff" Then
            AdminStaff.Hide()
        ElseIf Login.tempuserlevel = "Information Desk Personnel" Then
            infodeskpersonnel.Hide()
        End If




        Login.Show()

        Login.Username.Text = "Username"
        Login.Password.isPassword = False
        Login.Password.Text = "Password"
    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub AdminStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub


End Class