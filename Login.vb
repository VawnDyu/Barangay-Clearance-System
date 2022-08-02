Imports $safeprojectname$.Data.Odbc

Public Class Login

    Dim con As OdbcConnection
    Dim com As OdbcCommand

    Public temp As String
    Public tempname As String
    Public tempuserlevel As String

    Dim attempts As Integer = 1



    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Screen.AllScreens.Length = 2 Then
            Dim screen As Screen
            screen = screen.AllScreens(1)
            QueueingWindow.StartPosition = FormStartPosition.Manual
            QueueingWindow.Location = screen.Bounds.Location + New Point(100, 100)
            QueueingWindow.Show()
        End If


        BtnLogin.Select()
        Timer1.Start()

    End Sub

    Private Sub FormClose_Click(sender As Object, e As EventArgs) Handles FormClose.Click
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        End
    End Sub

    Private Sub Username_Enter(sender As Object, e As EventArgs) Handles Username.Enter
        Username.Text = ""
        Username.ForeColor = Color.FromArgb(76, 164, 206)


        'FOR VALIDATION MAKING DEFAULT'
        Username.LineIdleColor = Color.LightGray
        lblError.Visible = False



    End Sub

    Private Sub Username_Leave(sender As Object, e As EventArgs) Handles Username.Leave
        If Username.Text = "" Then
            Username.Text = "Username"

        End If
        Username.ForeColor = Color.LightGray
    End Sub

    Private Sub Password_Enter(sender As Object, e As EventArgs) Handles Password.Enter
        Password.Text = ""
        Password.ForeColor = Color.FromArgb(76, 164, 206)
        Password.isPassword = True

        'FOR VALIDATION MAKING DEFAULT'
        Password.LineIdleColor = Color.LightGray
        lblError.Visible = False
    End Sub

    Private Sub Password_Leave(sender As Object, e As EventArgs) Handles Password.Leave
        If Password.Text = "" Then
            Password.Text = "Password"
            Password.isPassword = False
        End If
        Password.ForeColor = Color.LightGray
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblDate.Text = DateTime.Now.ToString("MMM dd, yyy")
    End Sub

    Private Sub BtnLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnLogin.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginCommand()
        End If

        If e.KeyCode = Keys.Escape Then
            End
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        LoginCommand()
    End Sub


    Private Sub Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginCommand()
        End If
    End Sub

    Private Sub Username_KeyDown(sender As Object, e As KeyEventArgs) Handles Username.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoginCommand()
        End If
    End Sub




    Sub LoginCommand()
        BtnLogin.Select()
        Dim READER As OdbcDataReader

        If attempts = 5 Then
            Close()

        Else

            If Username.Text = "Username" And Password.Text = "Password" Then

                lblError.Text = "*Please input Username and Password*"
                lblError.Visible = True
                Username.LineIdleColor = Color.LightCoral
                Username.Text = ""
                Password.LineIdleColor = Color.LightCoral
                Password.Text = ""
                attempts = attempts + 1

            ElseIf Username.Text = "" And Password.Text = "" Then

                lblError.Text = "*Please input Username and Password*"
                lblError.Visible = True
                Username.LineIdleColor = Color.LightCoral
                Username.Text = ""
                Password.LineIdleColor = Color.LightCoral
                Password.Text = ""
                attempts = attempts + 1

            ElseIf Username.Text = "Username" And Password.Text = "" Then

                lblError.Text = "*Please input Username and Password*"
                lblError.Visible = True
                Username.LineIdleColor = Color.LightCoral
                Username.Text = ""
                Password.LineIdleColor = Color.LightCoral
                Password.Text = ""
                attempts = attempts + 1

            ElseIf Username.Text = "" And Password.Text = "Password" Then

                lblError.Text = "*Please input Username and Password*"
                lblError.Visible = True
                Username.LineIdleColor = Color.LightCoral
                Username.Text = ""
                Password.LineIdleColor = Color.LightCoral
                Password.Text = ""
                attempts = attempts + 1

            ElseIf Username.Text = "Username" And Password.Text <> "Password" Then
                lblError.Text = "*Please input Username*"
                lblError.Visible = True
                Username.LineIdleColor = Color.LightCoral
                Username.Text = ""
                attempts = attempts + 1

            ElseIf Password.Text = "Password" And Username.Text <> "Username" Then
                lblError.Text = "*Please input Password*"
                lblError.Visible = True
                Password.LineIdleColor = Color.LightCoral
                Password.Text = ""
                attempts = attempts + 1


            Else
                con = New OdbcConnection("DSN=mydatabase")
                Dim Query As String
                con.Open()
                Query = "SELECT * FROM employeeaccount.employee where username = '" & Username.Text & "' AND password = '" & Password.Text & "' AND userlevel = 'Admin Staff'"
                com = New OdbcCommand(Query, con)

                READER = com.ExecuteReader

                Dim count As Integer
                count = 0
                While READER.Read
                    count = count + 1
                End While

                If count = 1 Then

                    Dim Query2 As String

                    Query2 = "INSERT INTO employeeattendance.attendance (username,date,time_in,userlevel) VALUES ('" & Username.Text & "','" & lblDate.Text & "','" & lblTime.Text & "','Admin Staff')"

                    com = New OdbcCommand(Query2, con)
                    READER = com.ExecuteReader

                    temp = lblTime.Text
                    tempname = Username.Text
                    tempuserlevel = "Admin Staff"

                    Me.Hide()
                    AdminStaff.Show()

                Else
                    con.Close()
                    con.Open()
                    Query = "SELECT * FROM employeeaccount.employee where username = '" & Username.Text & "' AND password = '" & Password.Text & "' AND userlevel = 'Information Desk Personnel'"
                    com = New OdbcCommand(Query, con)
                    READER = com.ExecuteReader

                    count = 0

                    While READER.Read
                        count = count + 1
                    End While

                    If count = 1 Then
                        Dim Query2 As String

                        Query2 = "INSERT INTO employeeattendance.attendance (username,date,time_in,userlevel) VALUES ('" & Username.Text & "','" & lblDate.Text & "','" & lblTime.Text & "','Information Desk Personnel')"
                        com = New OdbcCommand(Query2, con)
                        READER = com.ExecuteReader

                        temp = lblTime.Text
                        tempname = Username.Text
                        tempuserlevel = "Information Desk Personnel"

                        infodeskpersonnel.Show()
                    Else
                        'ASDASDASDASD
                        con.Close()
                        con.Open()
                        Query = "SELECT * FROM employeeaccount.employee where username = '" & Username.Text & "' AND password = '" & Password.Text & "' AND userlevel = 'Head Admin'"
                        com = New OdbcCommand(Query, con)
                        READER = com.ExecuteReader

                        count = 0

                        While READER.Read
                            count = count + 1
                        End While

                        If count = 1 Then
                            Dim Query2 As String

                            Query2 = "INSERT INTO employeeattendance.attendance (username,date,time_in,userlevel) VALUES ('" & Username.Text & "','" & lblDate.Text & "','" & lblTime.Text & "','Head Admin')"
                            com = New OdbcCommand(Query2, con)
                            READER = com.ExecuteReader

                            temp = lblTime.Text
                            tempname = Username.Text
                            tempuserlevel = "Head Admin"

                            LoginAuth()
                            Admin.Show()
                            Me.Hide()
                            con.Close()

                        Else
                            lblError.Text = "*Username or Password are incorrect*"
                            lblError.Visible = True

                            Username.Text = ""
                            Password.Text = ""
                            Username.LineIdleColor = Color.LightCoral
                            Password.LineIdleColor = Color.LightCoral
                            attempts = attempts + 1
                        End If

                    End If
                End If

            End If
        End If
    End Sub



    Sub LoginAuth()
        Timer1.Start()

        With AdminDashboard
            .TopLevel = False
            Admin.PanelHome.Controls.Add(AdminDashboard)
            .BringToFront()
            .Show()
        End With


        Admin.btnACcount.color = Color.FromArgb(56, 144, 186) 'light blue
        Admin.btnQueue.color = Color.FromArgb(24, 26, 35) ' dark blue
        Admin.btnClearance.color = Color.FromArgb(24, 26, 35) ' dark blue

        AccountNavBar.BtnDashboard.Normalcolor = Color.FromArgb(76, 164, 206)
        AccountNavBar.BtnDashboard.OnHovercolor = Color.FromArgb(66, 154, 196)
        AccountNavBar.BtnDashboard.Enabled = False

        AccountNavBar.BtnEmployeeAccount.Normalcolor = Color.FromArgb(34, 36, 49)
        AccountNavBar.BtnEmployeeAccount.OnHovercolor = Color.FromArgb(24, 26, 39)
        AccountNavBar.BtnEmployeeAccount.Enabled = True

        AccountNavBar.BtnAttendanceRecord.Normalcolor = Color.FromArgb(34, 36, 49)
        AccountNavBar.BtnAttendanceRecord.OnHovercolor = Color.FromArgb(24, 26, 39)
        AccountNavBar.BtnAttendanceRecord.Enabled = True

        AccountNavBar.BtnSignOut.Normalcolor = Color.FromArgb(34, 36, 49)
        AccountNavBar.BtnSignOut.OnHovercolor = Color.LightCoral
        AccountNavBar.BtnSignOut.Enabled = True


    End Sub

End Class