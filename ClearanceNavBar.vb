Imports $safeprojectname$.Data.Odbc

Public Class ClearanceNavBar

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable

    Private Sub btnAddResident_Click(sender As Object, e As EventArgs) Handles btnAddResident.Click
        AddResident.ShowDialog()
    End Sub

    Private Sub btnClearanceDashboard_Click(sender As Object, e As EventArgs) Handles btnClearanceDashboard.Click

        con.Open()
        Dim Query As String

        Query = "select Count(*) from barangay.residents where voterstatus = 'Registered'"
        com = New OdbcCommand(Query, con)
        Dim i As Integer = com.ExecuteScalar()
        com = Nothing
        ClearanceDashboard.RegisteredVoters.Text = i
        con.Close()


        con.Open()
        Dim Query2 As String

        Query2 = "select Count(*) from barangay.residents where voterstatus = 'Not Registered'"
        com = New OdbcCommand(Query2, con)
        Dim i2 As Integer = com.ExecuteScalar()
        com = Nothing
        ClearanceDashboard.NonRegisteredVoters.Text = i2
        con.Close()

        con.Open()
        Dim Query3 As String

        Query3 = "select Count(*) from barangay.residents"
        com = New OdbcCommand(Query3, con)
        Dim i3 As Integer = com.ExecuteScalar()
        com = Nothing
        ClearanceDashboard.TotalRegisteredResidents.Text = i3
        con.Close()

        With ClearanceDashboard
            .TopLevel = False
            Admin.PanelHome.Controls.Add(ClearanceDashboard)
            .BringToFront()
            .Show()
        End With

        If Login.tempuserlevel = "Admin Staff" Then
            With ClearanceDashboard
                .TopLevel = False
                AdminStaff.PanelHome.Controls.Add(ClearanceDashboard)
                .BringToFront()
                .Show()
            End With
        End If

        btnClearanceDashboard.Normalcolor = Color.FromArgb(56, 144, 186)
        btnClearanceDashboard.OnHovercolor = Color.FromArgb(56, 144, 186)
        btnClearanceDashboard.Enabled = False

        btnClearance.Normalcolor = Color.FromArgb(24, 26, 35)
        btnClearance.OnHovercolor = Color.FromArgb(56, 144, 186)
        btnClearance.Enabled = True '


    End Sub

    Private Sub btnClearance_Click(sender As Object, e As EventArgs) Handles btnClearance.Click
        con = New OdbcConnection("DSN=mydatabase")

        With Clearance
            .TopLevel = False
            Admin.PanelHome.Controls.Add(Clearance)
            .BringToFront()
            .Show()
        End With

        If Login.tempuserlevel = "Admin Staff" Then
            With Clearance
                .TopLevel = False
                AdminStaff.PanelHome.Controls.Add(Clearance)
                .BringToFront()
                .Show()
            End With
        End If

        con.Open()

        Dim Query As String

        Query = "SELECT * FROM barangay.residents"
        com = New OdbcCommand(Query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        Clearance.ResidentDataList.DataSource = dt
        con.Close()

        btnClearance.Normalcolor = Color.FromArgb(56, 144, 186)
        btnClearance.OnHovercolor = Color.FromArgb(56, 144, 186)
        btnClearance.Enabled = False

        btnClearanceDashboard.Normalcolor = Color.FromArgb(24, 26, 35)
        btnClearanceDashboard.OnHovercolor = Color.FromArgb(56, 144, 186)
        btnClearanceDashboard.Enabled = True

    End Sub

    Private Sub BtnSignOut_Click(sender As Object, e As EventArgs) Handles BtnSignOut.Click
        SignOutMessage.ShowDialog()
    End Sub
End Class