Imports $safeprojectname$.Data.Odbc

Public Class AttendanceRecord

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable

    Private Sub SearchBar_Enter(sender As Object, e As EventArgs) Handles SearchBar.Enter
        SearchBar.text = ""
    End Sub

    Private Sub SearchBar_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchBar.KeyDown
        If e.KeyCode = Keys.Escape Then
            SearchBar.text = ""
        End If

        If SearchBar.text = "" And e.KeyCode = Keys.Escape Then
            btnAll.Select()
        End If
    End Sub


    Private Sub SearchBar_OnTextChange(sender As Object, e As EventArgs) Handles SearchBar.OnTextChange
        Dim dv As New DataView(dt)
        dv.RowFilter = String.Format("username LIKE '%{0}%'", SearchBar.text)
        AttendanceList.DataSource = dv
    End Sub

    Private Sub SearchBar_Leave(sender As Object, e As EventArgs) Handles SearchBar.Leave
        If SearchBar.text = "" Then
            SearchBar.text = "Search"

            con = New OdbcConnection("DSN=mydatabase")

            con.Open()

            Dim Query As String

            Query = "SELECT * FROM employeeattendance.attendance"
            com = New OdbcCommand(Query, con)
            dt = New DataTable
            dt.Load(com.ExecuteReader)
            AttendanceList.DataSource = dt
            con.Close()
        End If
    End Sub


    Private Sub SearchRemoveAll_Click(sender As Object, e As EventArgs) Handles SearchRemoveAll.Click
        SearchBar.text = ""
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdminStaff.Click
        con = New OdbcConnection("DSN=mydatabase")

        btnAdminStaff.BackColor = Color.FromArgb(56, 144, 186)
        btnAdminStaff.color = Color.FromArgb(56, 144, 186)
        btnAdminStaff.Cursor = Cursors.Default

        con.Open()

        Dim Query As String

        Query = "SELECT * FROM employeeattendance.attendance WHERE userlevel = 'Admin Staff'"
        com = New OdbcCommand(Query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        AttendanceList.DataSource = dt
        con.Close()

        btnAll.BackColor = Color.FromArgb(24, 26, 35)
        btnAll.color = Color.FromArgb(24, 26, 35)
        btnAll.Enabled = True

        btnInfoDesk.BackColor = Color.FromArgb(24, 26, 35)
        btnInfoDesk.color = Color.FromArgb(24, 26, 35)
        btnInfoDesk.Cursor = Cursors.Hand

    End Sub

    Private Sub btnInfoDesk_Click(sender As Object, e As EventArgs) Handles btnInfoDesk.Click
        con = New OdbcConnection("DSN=mydatabase")

        btnInfoDesk.BackColor = Color.FromArgb(56, 144, 186)
        btnInfoDesk.color = Color.FromArgb(56, 144, 186)
        btnInfoDesk.Cursor = Cursors.Default

        con.Open()

        Dim Query As String

        Query = "SELECT * FROM employeeattendance.attendance WHERE userlevel = 'Information Desk Personnel'"
        com = New OdbcCommand(Query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        AttendanceList.DataSource = dt
        con.Close()

        btnAll.BackColor = Color.FromArgb(24, 26, 35)
        btnAll.color = Color.FromArgb(24, 26, 35)
        btnAll.Enabled = True

        btnAdminStaff.BackColor = Color.FromArgb(24, 26, 35)
        btnAdminStaff.color = Color.FromArgb(24, 26, 35)
        btnAdminStaff.Cursor = Cursors.Hand

    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        con = New OdbcConnection("DSN=mydatabase")

        btnAll.BackColor = Color.FromArgb(56, 144, 186)
        btnAll.color = Color.FromArgb(56, 144, 186)
        btnAll.Enabled = False

        con.Open()

        Dim Query As String

        Query = "SELECT * FROM employeeattendance.attendance"
        com = New OdbcCommand(Query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        AttendanceList.DataSource = dt
        con.Close()

        btnInfoDesk.BackColor = Color.FromArgb(24, 26, 35)
        btnInfoDesk.color = Color.FromArgb(24, 26, 35)
        btnInfoDesk.Enabled = True

        btnAdminStaff.BackColor = Color.FromArgb(24, 26, 35)
        btnAdminStaff.color = Color.FromArgb(24, 26, 35)
        btnAdminStaff.Enabled = True
    End Sub

    Private Sub DatePicker_onValueChanged(sender As Object, e As EventArgs) Handles DatePicker.onValueChanged
        con = New OdbcConnection("DSN=mydatabase")
        con.Open()

        Dim Query As String

        Query = "SELECT * FROM employeeattendance.attendance WHERE date = '" & DatePicker.Value.ToString("MMM dd, yyyy") & "'"
        com = New OdbcCommand(Query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        AttendanceList.DataSource = dt
        con.Close()

    End Sub

    Private Sub AttendanceRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatePicker.FormatCustom = "MMM dd, yyyy"
    End Sub
End Class