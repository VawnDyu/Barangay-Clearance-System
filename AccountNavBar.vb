Imports $safeprojectname$.Data.Odbc

Public Class AccountNavBar

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable

    Private Sub BtnEmployeeAccount_Click(sender As Object, e As EventArgs) Handles BtnEmployeeAccount.Click

        BtnDashboard.Normalcolor = Color.FromArgb(24, 26, 35)
        BtnDashboard.OnHovercolor = Color.FromArgb(56, 144, 186)
        BtnDashboard.Enabled = True

        BtnAttendanceRecord.Normalcolor = Color.FromArgb(24, 26, 35)
        BtnAttendanceRecord.OnHovercolor = Color.FromArgb(56, 144, 186)
        BtnAttendanceRecord.Enabled = True
        With EmployeeAccount
            .TopLevel = False
            Admin.PanelHome.Controls.Add(EmployeeAccount)
            .BringToFront()
            .Show()
        End With

        BtnEmployeeAccount.Normalcolor = Color.FromArgb(56, 144, 186)
        BtnEmployeeAccount.OnHovercolor = Color.FromArgb(66, 154, 196)
        BtnEmployeeAccount.Enabled = False

    End Sub

    Private Sub BtnAddEmployee_Click(sender As Object, e As EventArgs) Handles BtnAddEmployee.Click
        AddEmployee.ShowDialog()
    End Sub

    Private Sub BtnSignOut_Click(sender As Object, e As EventArgs) Handles BtnSignOut.Click
        SignOutMessage.ShowDialog()
    End Sub

    Private Sub BtnAttendanceRecord_Click(sender As Object, e As EventArgs) Handles BtnAttendanceRecord.Click

        AttendanceRecord.btnAll.Select()

        con = New OdbcConnection("DSN=mydatabase")
        con.Open()
        Dim Query As String
        Query = "SELECT * FROM employeeattendance.attendance"
        com = New OdbcCommand(Query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        AttendanceRecord.AttendanceList.DataSource = dt

        con.Close()

        BtnEmployeeAccount.Normalcolor = Color.FromArgb(24, 26, 35)
        BtnEmployeeAccount.OnHovercolor = Color.FromArgb(56, 144, 186)
        BtnEmployeeAccount.Enabled = True

        BtnDashboard.Normalcolor = Color.FromArgb(24, 26, 35)
        BtnDashboard.OnHovercolor = Color.FromArgb(56, 144, 186)
        BtnDashboard.Enabled = True

        With AttendanceRecord
            .TopLevel = False
            Admin.PanelHome.Controls.Add(AttendanceRecord)
            .BringToFront()
            .Show()
        End With

        BtnAttendanceRecord.Normalcolor = Color.FromArgb(56, 144, 186)
        BtnAttendanceRecord.OnHovercolor = Color.FromArgb(66, 154, 196)
        BtnAttendanceRecord.Enabled = False

        '============================================================================================'

        AttendanceRecord.btnAll.BackColor = Color.FromArgb(76, 164, 206)
        AttendanceRecord.btnAll.Enabled = False

        AttendanceRecord.btnAdminStaff.BackColor = Color.FromArgb(24, 26, 35)
        AttendanceRecord.btnAdminStaff.Enabled = True

        AttendanceRecord.btnInfoDesk.BackColor = Color.FromArgb(24, 26, 35)
        AttendanceRecord.btnInfoDesk.Enabled = True




    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        With AdminDashboard
            .TopLevel = False
            Admin.PanelHome.Controls.Add(AdminDashboard)
            .BringToFront()
            .Show()
        End With

        BtnDashboard.Normalcolor = Color.FromArgb(56, 144, 186)
        BtnDashboard.OnHovercolor = Color.FromArgb(66, 154, 196)
        BtnDashboard.Enabled = False

        BtnEmployeeAccount.Normalcolor = Color.FromArgb(24, 26, 35)
        BtnEmployeeAccount.OnHovercolor = Color.FromArgb(56, 144, 186)
        BtnEmployeeAccount.Enabled = True

        BtnAttendanceRecord.Normalcolor = Color.FromArgb(24, 26, 35)
        BtnAttendanceRecord.OnHovercolor = Color.FromArgb(56, 144, 186)
        BtnAttendanceRecord.Enabled = True

        con = New OdbcConnection("DSN=mydatabase")

        con.Open()
        Dim Query As String

        Query = "select Count(*) from employee where userlevel = 'Admin Staff'"
        com = New OdbcCommand(Query, con)
        Dim i As Integer = com.ExecuteScalar()
        com = Nothing
        AdminDashboard.AdminStaffNumber.Text = i
        con.Close()

        con.Open()
        Dim Query2 As String

        Query2 = "select Count(*) from employee where userlevel = 'Information Desk Personnel'"
        com = New OdbcCommand(Query2, con)
        Dim i2 As Integer = com.ExecuteScalar()
        com = Nothing
        AdminDashboard.InfoDeskNumber.Text = i2
        con.Close()

        con.Open()
        Dim Query3 As String

        Query3 = "select Count(*) from employee"
        com = New OdbcCommand(Query3, con)
        Dim i3 As Integer = com.ExecuteScalar()
        com = Nothing
        AdminDashboard.TotalEmployeeNumber.Text = i3
        con.Close()
    End Sub
End Class