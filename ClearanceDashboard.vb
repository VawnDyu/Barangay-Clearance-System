Imports $safeprojectname$.Data.Odbc

Public Class ClearanceDashboard

    Dim con As OdbcConnection
    Dim com As OdbcCommand


    Private Sub ClearanceDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OdbcConnection("DSN=mydatabase")


        con.Open()
        Dim Query As String

        Query = "select Count(*) from barangay.residents where voterstatus = 'Registered'"
        com = New OdbcCommand(Query, con)
        Dim i As Integer = com.ExecuteScalar()
        com = Nothing
        RegisteredVoters.Text = i
        con.Close()


        con.Open()
        Dim Query2 As String

        Query2 = "select Count(*) from barangay.residents where voterstatus = 'Not Registered'"
        com = New OdbcCommand(Query2, con)
        Dim i2 As Integer = com.ExecuteScalar()
        com = Nothing
        NonRegisteredVoters.Text = i2
        con.Close()

        con.Open()
        Dim Query3 As String

        Query3 = "select Count(*) from barangay.residents"
        com = New OdbcCommand(Query3, con)
        Dim i3 As Integer = com.ExecuteScalar()
        com = Nothing
        TotalRegisteredResidents.Text = i3
        con.Close()

    End Sub
End Class