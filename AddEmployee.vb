Imports $safeprojectname$.Data.Odbc

Public Class AddEmployee

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable

    Dim tempfirstname As String
    Dim tempmiddlename As String
    Dim templastname As String
    Dim tempstreet As String
    Dim tempbarangay As String
    Dim tempCity As String
    Dim tempgender As String
    Dim tempbirthdate As String
    Dim tempuserlevel As String
    Dim tempusername As String
    Dim temppassword As String

    'FIRST NAME COLOR CHANGE'
    Private Sub FirstName_Enter(sender As Object, e As EventArgs) Handles FirstName.Enter
        FirstName.Text = ""
        FirstName.ForeColor = Color.FromArgb(76, 164, 206)
        ErrorFullName.Visible = False
    End Sub

    Private Sub FirstName_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles FirstName.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz,. "
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FirstName_Leave(sender As Object, e As EventArgs) Handles FirstName.Leave
        FirstName.ForeColor = Color.LightGray
        If FirstName.Text = "" Then
            FirstName.Text = "First Name"
        End If
    End Sub
    'MIDDLE NAME COLOR CHANGE'
    Private Sub MiddleName_Enter(sender As Object, e As EventArgs) Handles MiddleName.Enter
        MiddleName.Text = ""
        MiddleName.ForeColor = Color.FromArgb(76, 164, 206)
        ErrorFullName.Visible = False
    End Sub

    Private Sub MiddleName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MiddleName.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz,. "
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub MiddleName_Leave(sender As Object, e As EventArgs) Handles MiddleName.Leave
        MiddleName.ForeColor = Color.LightGray
        If MiddleName.Text = "" Then
            MiddleName.Text = "Middle Name"
        End If
    End Sub
    'LAST NAME COLOR CHANGE'
    Private Sub LastName_Enter(sender As Object, e As EventArgs) Handles LastName.Enter
        LastName.Text = ""
        LastName.ForeColor = Color.FromArgb(76, 164, 206)
        ErrorFullName.Visible = False
    End Sub

    Private Sub LastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LastName.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz,. "
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub LastName_Leave(sender As Object, e As EventArgs) Handles LastName.Leave
        LastName.ForeColor = Color.LightGray
        If LastName.Text = "" Then
            LastName.Text = "Last Name"
        End If
    End Sub

    Private Sub Street_Enter(sender As Object, e As EventArgs) Handles Street.Enter
        Street.Text = ""
        Street.ForeColor = Color.FromArgb(76, 164, 206)
        ErrorAddress.Visible = False
    End Sub

    Private Sub Street_Leave(sender As Object, e As EventArgs) Handles Street.Leave
        Street.ForeColor = Color.LightGray
        If Street.Text = "" Then
            Street.Text = "Street"
        End If
    End Sub

    Private Sub Barangay_Enter(sender As Object, e As EventArgs) Handles Barangay.Enter
        Barangay.Text = ""
        Barangay.ForeColor = Color.FromArgb(76, 164, 206)
        ErrorAddress.Visible = False
    End Sub

    Private Sub Barangay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Barangay.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz,. "
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Barangay_Leave(sender As Object, e As EventArgs) Handles Barangay.Leave
        Barangay.ForeColor = Color.LightGray
        If Barangay.Text = "" Then
            Barangay.Text = "Barangay"
        End If
    End Sub

    Private Sub City_Enter(sender As Object, e As EventArgs) Handles City.Enter
        City.Text = ""
        City.ForeColor = Color.FromArgb(76, 164, 206)
        ErrorAddress.Visible = False
    End Sub

    Private Sub City_KeyPress(sender As Object, e As KeyPressEventArgs) Handles City.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz,. "
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub City_Leave(sender As Object, e As EventArgs) Handles City.Leave
        City.ForeColor = Color.LightGray
        If City.Text = "" Then
            City.Text = "City"
        End If
    End Sub


    Private Sub GenderMale_Click(sender As Object, e As EventArgs) Handles GenderMale.Click
        GenderMale.Enabled = False 'disables the button when clicked
        GenderMale.BackColor = Color.FromArgb(76, 164, 206) 'changes the color to blue when clicked
        GenderFemale.BackColor = Color.FromArgb(34, 36, 49) 'defaults the color of the other button
        LabelMale.ForeColor = Color.FromArgb(76, 164, 206) 'changes the color of the label'
        LabelFemale.ForeColor = Color.LightGray 'defaults the color of the other label
        GenderFemale.Enabled = True 'enables the other button to be able to click
        tempgender = "Male"
        ErrorGender.Visible = False
    End Sub

    Private Sub GenderFemale_Click(sender As Object, e As EventArgs) Handles GenderFemale.Click
        GenderFemale.Enabled = False
        GenderFemale.BackColor = Color.PaleVioletRed
        GenderMale.BackColor = Color.FromArgb(34, 36, 49)
        LabelFemale.ForeColor = Color.PaleVioletRed
        LabelMale.ForeColor = Color.LightGray
        GenderMale.Enabled = True
        tempgender = "Female"
        ErrorGender.Visible = False
    End Sub

    Private Sub Birthdate_onValueChanged(sender As Object, e As EventArgs) Handles Birthdate.onValueChanged
        Dim yr As Integer = DateDiff(DateInterval.Year, Birthdate.Value, Now)
        Dim month As Integer = DateDiff(DateInterval.Month, Birthdate.Value, Now) Mod 12
        Dim day As Integer = DateDiff(DateInterval.Day, Birthdate.Value, Now) Mod 30 - 10
        Age.Text = (yr & " Years, " & month & " Months")
    End Sub

    Private Sub UserAdminStaff_Click(sender As Object, e As EventArgs) Handles UserAdminStaff.Click
        UserAdminStaff.Enabled = False
        UserAdminStaff.BackColor = Color.FromArgb(76, 164, 206)
        UserInfoDesk.BackColor = Color.FromArgb(34, 36, 49)
        AdminStaff.ForeColor = Color.FromArgb(76, 164, 206)
        InfoDesk.ForeColor = Color.LightGray
        UserInfoDesk.Enabled = True
        tempuserlevel = "Admin Staff"
        ErrorUserLevel.Visible = False
    End Sub

    Private Sub UserInfoDesk_Click(sender As Object, e As EventArgs) Handles UserInfoDesk.Click
        UserInfoDesk.Enabled = False
        UserInfoDesk.BackColor = Color.FromArgb(76, 164, 206)
        UserAdminStaff.BackColor = Color.FromArgb(34, 36, 49)
        InfoDesk.ForeColor = Color.FromArgb(76, 164, 206)
        AdminStaff.ForeColor = Color.LightGray
        UserAdminStaff.Enabled = True
        tempuserlevel = "Information Desk Personnel"
        ErrorUserLevel.Visible = False
    End Sub

    Private Sub Username_Enter(sender As Object, e As EventArgs) Handles Username.Enter
        Username.Text = ""
        Username.ForeColor = Color.FromArgb(76, 164, 206)
        ErrorAccount.Visible = False
    End Sub

    Private Sub Username_Leave(sender As Object, e As EventArgs) Handles Username.Leave
        Username.ForeColor = Color.LightGray
        If Username.Text = "" Then
            Username.Text = "Username"
        End If
    End Sub

    Private Sub Password_Enter(sender As Object, e As EventArgs) Handles Password.Enter
        Password.Text = ""
        Password.ForeColor = Color.FromArgb(76, 164, 206)
        ErrorAccount.Visible = False
        Password.isPassword = True
    End Sub

    Private Sub Password_Leave(sender As Object, e As EventArgs) Handles Password.Leave
        Password.ForeColor = Color.LightGray
        If Password.Text = "" Then
            Password.Text = "Password"
            Password.isPassword = False
        End If
    End Sub

    Private Sub ConfirmPassword_Enter(sender As Object, e As EventArgs) Handles ConfirmPassword.Enter
        ConfirmPassword.Text = ""
        ConfirmPassword.ForeColor = Color.FromArgb(76, 164, 206)
        ErrorAccount.Visible = False
        ConfirmPassword.isPassword = True
    End Sub

    Private Sub ConfirmPassword_KeyDown(sender As Object, e As Windows.Forms.KeyEventArgs) Handles ConfirmPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Add()
        End If
    End Sub

    Private Sub ConfirmPassword_Leave(sender As Object, e As EventArgs) Handles ConfirmPassword.Leave
        ConfirmPassword.ForeColor = Color.LightGray
        If ConfirmPassword.Text = "" Then
            ConfirmPassword.Text = "Confirm Password"
            ConfirmPassword.isPassword = False
        End If

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Add()
    End Sub

    Private Sub Submit_KeyDown(sender As Object, e As KeyEventArgs) Handles Submit.KeyDown
        If e.KeyCode = Keys.Enter Then
            Add()
        End If
    End Sub

    Private Sub FormClose_Click(sender As Object, e As EventArgs) Handles FormClose.Click
        Close()
    End Sub

    Private Sub AddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Submit.Select()

        FirstName.Text = "First Name"
        MiddleName.Text = "Middle Name"
        LastName.Text = "Last Name"
        Street.Text = "Street"
        Barangay.Text = "Barangay"
        City.Text = "City"

        GenderMale.BackColor = Color.FromArgb(34, 36, 49)
        LabelMale.ForeColor = Color.LightGray
        GenderMale.Enabled = True

        GenderFemale.BackColor = Color.FromArgb(34, 36, 49)
        LabelFemale.ForeColor = Color.LightGray
        GenderFemale.Enabled = True

        Birthdate.Value = "25/12/2000"

        UserAdminStaff.BackColor = Color.FromArgb(34, 36, 49)
        AdminStaff.ForeColor = Color.LightGray
        UserAdminStaff.Enabled = True

        UserInfoDesk.BackColor = Color.FromArgb(34, 36, 49)
        InfoDesk.ForeColor = Color.LightGray
        UserInfoDesk.Enabled = True

        Username.Text = "Username"

        Password.Text = "Password"
        Password.isPassword = False

        ConfirmPassword.Text = "Confirm Password"
        ConfirmPassword.isPassword = False





    End Sub



    Sub Add()
        tempfirstname = FirstName.Text
        tempmiddlename = MiddleName.Text
        templastname = LastName.Text
        tempstreet = Street.Text
        tempbarangay = Barangay.Text
        tempCity = City.Text
        tempbirthdate = Birthdate.Value
        tempusername = Username.Text
        temppassword = Password.Text

        Try

            If FirstName.Text = "First Name" Or
                MiddleName.Text = "Middle Name" Or
                LastName.Text = "Last Name" Then

                ErrorFullName.Text = "Please fill up all the requirements"
                ErrorFullName.Visible = True
            End If

            If Street.Text = "Street" Or
                    Barangay.Text = "Barangay" Or
                    City.Text = "City" Then

                ErrorAddress.Text = "Please fill up all the requirements"
                ErrorAddress.Visible = True
            End If

            If GenderFemale.Enabled = True And
                    GenderMale.Enabled = True Then

                ErrorGender.Text = "Please select your gender"
                ErrorGender.Visible = True

            End If

            If UserAdminStaff.Enabled = True And
                    UserInfoDesk.Enabled = True Then

                ErrorUserLevel.Text = "Please select User-Level"
                ErrorUserLevel.Visible = True
            End If

            If Username.Text = "Username" Or
                    Password.Text = "Password" Or
                    ConfirmPassword.Text = "Confirm Password" Then

                ErrorAccount.Text = "Please fill up all the requirements"
                ErrorAccount.Visible = True
            ElseIf Password.Text <> ConfirmPassword.Text Then

                ErrorAccount.Text = "Password and Confirm Password is not match"
                ErrorAccount.Visible = True
            End If



            If tempfirstname <> "First Name" And
                tempmiddlename <> "Middle Name" And
                templastname <> "Last Name" And
                tempstreet <> "Street" And
                tempbarangay <> "Barangay" And
                tempCity <> "City" And
                tempgender <> "" And
                tempuserlevel <> "" And
                tempusername <> "Username" And
                temppassword <> "Password" And
                Password.Text = ConfirmPassword.Text Then

                con = New OdbcConnection("DSN=mydatabase")
                con.Open()
                Dim Query As String

                Query = ("INSERT INTO employeeaccount.employee (firstname,middlename,lastname,street,barangay,city,gender,birthdate,userlevel,username,password) VALUES ('" & tempfirstname & "','" & tempmiddlename & "','" & templastname & "','" & tempstreet & "','" & tempbarangay & "','" & tempCity & "','" & tempgender & "','" & tempbirthdate & "','" & tempuserlevel & "','" & tempusername & "','" & temppassword & "')")

                com = New OdbcCommand(Query, con)
                com.ExecuteNonQuery()
                con.Close()

                con.Open()
                com = New OdbcCommand("SELECT * FROM employeeaccount.employee", con)
                dt = New DataTable
                dt.Load(com.ExecuteReader)
                EmployeeAccount.EmployeeAccountList.DataSource = dt
                con.Close()
                Close()

            End If

        Catch ex As OdbcException
            ErrorAccount.Text = "'" & Username.Text & "' is already taken."
            ErrorAccount.Visible = True
        End Try

    End Sub

End Class