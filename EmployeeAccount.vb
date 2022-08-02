Imports $safeprojectname$.Data.Odbc

Public Class EmployeeAccount

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable

    Public firstname As String

    Private Sub EmployeeAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con = New OdbcConnection("DSN=mydatabase")
        con.Open()

        Dim Query As String

        Query = "SELECT * FROM employeeaccount.employee"
        com = New OdbcCommand(Query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        EmployeeAccountList.DataSource = dt
        con.Close()

        ImgAll.BackColor = Color.FromArgb(56, 144, 186)
        TextAll.ForeColor = Color.FromArgb(56, 144, 186)
        ImgAll.Enabled = False

    End Sub

    Private Sub ImgAll_Click(sender As Object, e As EventArgs) Handles ImgAll.Click
        ImgAll.BackColor = Color.FromArgb(56, 144, 186)
        TextAll.ForeColor = Color.FromArgb(56, 144, 186)
        ImgAll.Enabled = False


        ImgAdminStaff.BackColor = Color.FromArgb(34, 36, 49)
        ImgInfoDesk.BackColor = Color.FromArgb(34, 36, 49)
        TextAdminStaff.ForeColor = Color.LightGray
        TextInfoDesk.ForeColor = Color.LightGray
        ImgAdminStaff.Enabled = True
        ImgInfoDesk.Enabled = True

        con = New OdbcConnection("DSN=mydatabase")
        con.Open()

        Dim Query As String

        Query = "SELECT * FROM employeeaccount.employee"
        com = New OdbcCommand(Query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        EmployeeAccountList.DataSource = dt
        con.Close()
    End Sub

    Private Sub ImgAdminStaff_Click(sender As Object, e As EventArgs) Handles ImgAdminStaff.Click
        ImgAdminStaff.BackColor = Color.FromArgb(56, 144, 186)
        TextAdminStaff.ForeColor = Color.FromArgb(56, 144, 186)
        ImgAdminStaff.Enabled = False

        ImgAll.BackColor = Color.FromArgb(34, 36, 49)
        ImgInfoDesk.BackColor = Color.FromArgb(34, 36, 49)
        TextAll.ForeColor = Color.LightGray
        TextInfoDesk.ForeColor = Color.LightGray
        ImgAll.Enabled = True
        ImgInfoDesk.Enabled = True

        con = New OdbcConnection("DSN=mydatabase")
        con.Open()

        Dim Query As String

        Query = "SELECT * FROM employeeaccount.employee where userlevel = 'Admin Staff'"
        com = New OdbcCommand(Query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        EmployeeAccountList.DataSource = dt
        con.Close()

    End Sub

    Private Sub ImgInfoDesk_Click(sender As Object, e As EventArgs) Handles ImgInfoDesk.Click
        ImgInfoDesk.BackColor = Color.FromArgb(56, 144, 186)
        TextInfoDesk.ForeColor = Color.FromArgb(56, 144, 186)
        ImgInfoDesk.Enabled = False

        ImgAdminStaff.BackColor = Color.FromArgb(34, 36, 49)
        ImgAll.BackColor = Color.FromArgb(34, 36, 49)
        TextAdminStaff.ForeColor = Color.LightGray
        TextAll.ForeColor = Color.LightGray
        ImgAdminStaff.Enabled = True
        ImgAll.Enabled = True

        con = New OdbcConnection("DSN=mydatabase")
        con.Open()

        Dim Query As String

        Query = "SELECT * FROM employeeaccount.employee where userlevel = 'Information Desk Personnel'"
        com = New OdbcCommand(Query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        EmployeeAccountList.DataSource = dt
        con.Close()

    End Sub

    Private Sub EmployeeAccountList_CellClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles EmployeeAccountList.CellClick

        firstname = EmployeeAccountList.SelectedCells.Item(0).Value.ToString()

        UpdateAccounts.FirstName.Text = EmployeeAccountList.SelectedCells.Item(0).Value.ToString()
        UpdateAccounts.MiddleName.Text = EmployeeAccountList.SelectedCells.Item(1).Value.ToString()
        UpdateAccounts.LastName.Text = EmployeeAccountList.SelectedCells.Item(2).Value.ToString()
        UpdateAccounts.Street.Text = EmployeeAccountList.SelectedCells.Item(3).Value.ToString()
        UpdateAccounts.Barangay.Text = EmployeeAccountList.SelectedCells.Item(4).Value.ToString()
        UpdateAccounts.City.Text = EmployeeAccountList.SelectedCells.Item(5).Value.ToString()
        UpdateAccounts.tempgender = EmployeeAccountList.SelectedCells.Item(6).Value.ToString()

        If UpdateAccounts.tempgender = "Male" Then
            UpdateAccounts.GenderMale.Enabled = False
            UpdateAccounts.GenderMale.BackColor = Color.FromArgb(56, 144, 186)
            UpdateAccounts.LabelMale.ForeColor = Color.FromArgb(56, 144, 186)

            UpdateAccounts.GenderFemale.Enabled = True
            UpdateAccounts.GenderFemale.BackColor = Color.FromArgb(34, 36, 49)
            UpdateAccounts.LabelFemale.ForeColor = Color.LightGray
        ElseIf UpdateAccounts.tempgender = "Female" Then
            UpdateAccounts.GenderFemale.Enabled = False
            UpdateAccounts.GenderFemale.BackColor = Color.PaleVioletRed
            UpdateAccounts.LabelFemale.ForeColor = Color.PaleVioletRed

            UpdateAccounts.GenderMale.Enabled = True
            UpdateAccounts.GenderMale.BackColor = Color.FromArgb(34, 36, 49)
            UpdateAccounts.LabelMale.ForeColor = Color.LightGray
        End If

        UpdateAccounts.Birthdate.Value = EmployeeAccountList.SelectedCells.Item(7).Value.ToString()

        UpdateAccounts.tempuserlevel = EmployeeAccountList.SelectedCells.Item(8).Value.ToString()

        If UpdateAccounts.tempuserlevel = "Admin Staff" Then
            UpdateAccounts.UserAdminStaff.Enabled = False
            UpdateAccounts.UserAdminStaff.BackColor = Color.FromArgb(56, 144, 186)
            UpdateAccounts.AdminStaff.ForeColor = Color.FromArgb(56, 144, 186)

            UpdateAccounts.UserInfoDesk.Enabled = True
            UpdateAccounts.UserInfoDesk.BackColor = Color.FromArgb(34, 36, 49)
            UpdateAccounts.InfoDesk.ForeColor = Color.LightGray

        ElseIf UpdateAccounts.tempuserlevel = "Information Desk Personnel" Then
            UpdateAccounts.UserInfoDesk.Enabled = False
            UpdateAccounts.UserInfoDesk.BackColor = Color.FromArgb(56, 144, 186)
            UpdateAccounts.InfoDesk.ForeColor = Color.FromArgb(56, 144, 186)

            UpdateAccounts.UserAdminStaff.Enabled = True
            UpdateAccounts.UserAdminStaff.BackColor = Color.FromArgb(34, 36, 49)
            UpdateAccounts.AdminStaff.ForeColor = Color.LightGray
        End If

        UpdateAccounts.Username.Text = EmployeeAccountList.SelectedCells.Item(9).Value.ToString()
    End Sub

    Private Sub ImgUpdate_Click(sender As Object, e As EventArgs) Handles ImgUpdate.Click
        UpdateAccounts.ShowDialog()
    End Sub

    Private Sub ImgDelete_Click(sender As Object, e As EventArgs) Handles ImgDelete.Click
        DeleteMessage.ShowDialog()
    End Sub

    Private Sub SearchBar_Enter(sender As Object, e As EventArgs) Handles SearchBar.Enter
        SearchBar.text = ""

        con = New OdbcConnection("DSN=mydatabase")

        con.Open()

        Dim Query As String

        Query = "SELECT * FROM employeeaccount.employee"
        com = New OdbcCommand(Query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        EmployeeAccountList.DataSource = dt
        con.Close()
    End Sub

    Private Sub SearchBar_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchBar.KeyDown
        If e.KeyCode = Keys.Escape Then
            SearchBar.text = ""
        End If

        If SearchBar.text = "" And e.KeyCode = Keys.Escape Then
            ImgUpdate.Select()
        End If
    End Sub

    Private Sub SearchBar_Leave(sender As Object, e As EventArgs) Handles SearchBar.Leave
        If SearchBar.text = "" Then
            SearchBar.text = "Search"

            con = New OdbcConnection("DSN=mydatabase")

            con.Open()

            Dim Query As String

            Query = "SELECT * FROM employeeaccount.employee"
            com = New OdbcCommand(Query, con)
            dt = New DataTable
            dt.Load(com.ExecuteReader)
            EmployeeAccountList.DataSource = dt
            con.Close()
        End If
    End Sub

    Private Sub SearchBar_OnTextChange(sender As Object, e As EventArgs) Handles SearchBar.OnTextChange
        Dim dv As New DataView(dt)
        dv.RowFilter = String.Format("firstname LIKE '%{0}%'", SearchBar.text)
        EmployeeAccountList.DataSource = dv

    End Sub

    Private Sub SearchRemoveAll_Click(sender As Object, e As EventArgs) Handles SearchRemoveAll.Click
        SearchBar.text = ""

        con = New OdbcConnection("DSN=mydatabase")

        con.Open()

        Dim Query As String

        Query = "SELECT * FROM employeeaccount.employee"
        com = New OdbcCommand(Query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        EmployeeAccountList.DataSource = dt
        con.Close()
    End Sub
End Class