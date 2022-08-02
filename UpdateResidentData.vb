Imports $safeprojectname$.Data.Odbc

Public Class UpdateResidentData

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable

    Public tempresidentno As String
    Dim tempfirstname As String
    Dim tempmiddlename As String
    Dim templastname As String
    Dim tempstreetno As String
    Dim tempstreet As String
    Public tempgender As String
    Dim tempbirthdate As String
    Public tempcivilstatus As String
    Public tempvoterstatus As String
    Dim tempcontactnumber As String


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

    Private Sub StatusSingle_Click(sender As Object, e As EventArgs) Handles StatusSingle.Click
        StatusSingle.Enabled = False
        StatusSingle.BackColor = Color.FromArgb(76, 164, 206)
        StatusMarried.BackColor = Color.FromArgb(34, 36, 49)
        lblSingle.ForeColor = Color.FromArgb(76, 164, 206)
        lblMarried.ForeColor = Color.LightGray
        StatusMarried.Enabled = True
        tempcivilstatus = "Single"
        ErrorCivilStatus.Visible = False
    End Sub

    Private Sub StatusMarried_Click(sender As Object, e As EventArgs) Handles StatusMarried.Click
        StatusMarried.Enabled = False
        StatusMarried.BackColor = Color.FromArgb(76, 164, 206)
        StatusSingle.BackColor = Color.FromArgb(34, 36, 49)
        lblMarried.ForeColor = Color.FromArgb(76, 164, 206)
        lblSingle.ForeColor = Color.LightGray
        StatusSingle.Enabled = True
        tempcivilstatus = "Married"
        ErrorCivilStatus.Visible = False
    End Sub

    Private Sub FormClose_Click(sender As Object, e As EventArgs) Handles FormClose.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Update_Command()
    End Sub

    Sub Update_Command()

        tempfirstname = FirstName.Text
        tempmiddlename = MiddleName.Text
        templastname = LastName.Text
        tempstreetno = StreetNo.Text
        tempstreet = Street.Text
        tempbirthdate = Birthdate.Value
        tempcontactnumber = ContactNumber.Text

        Try


            If FirstName.Text = "First Name" Or
                MiddleName.Text = "Middle Name" Or
                LastName.Text = "Last Name" Then

                ErrorFullName.Text = "Please fill up all the requirements"
                ErrorFullName.Visible = True
            End If

            If StreetNo.Text = "Street No." And
                Street.Text = "Street" Then

                ErrorAddress.Text = "Please fill up all the requirements"
                ErrorAddress.Visible = True
            End If

            If GenderFemale.Enabled = True And
                    GenderMale.Enabled = True Then

                ErrorGender.Text = "Please select your gender"
                ErrorGender.Visible = True

            End If

            If StatusSingle.Enabled = True And
                    StatusMarried.Enabled = True Then

                ErrorCivilStatus.Text = "Please select User-Level"
                ErrorCivilStatus.Visible = True
            End If

            If btnYes.Enabled = True And
                btnNo.Enabled = True Then

                ErrorVoterStatus.Text = "Please select your Voter Status"
                ErrorVoterStatus.Visible = True
            End If

            If ContactNumber.Text = "Contact Number" Then

                ErrorContactNumber.Text = "Please input valid Number"
                ErrorContactNumber.Visible = True

                If ContactNumber.TextLength < 11 Then

                    ErrorContactNumber.Text = "Please input valid Number"
                    ErrorContactNumber.Visible = True

                End If
            End If

            If tempfirstname <> "First Name" And
                tempmiddlename <> "Middle Name" And
                templastname <> "Last Name" And
                tempstreetno <> "Street No." And
                tempstreet <> "Street" And
                tempgender <> "" And
                tempcivilstatus <> "" And
                tempvoterstatus <> "" And
                tempcontactnumber <> "Contact Number" And
                ContactNumber.TextLength = 11 Then

                con = New OdbcConnection("DSN=mydatabase")
                con.Open()
                Dim Query As String

                Query = "UPDATE barangay.residents set firstname='" & tempfirstname & "',middlename ='" & tempmiddlename & "',lastname='" & templastname & "',streetno='" & tempstreetno & "',street='" & tempstreet & "',gender='" & tempgender & "',birthdate='" & tempbirthdate & "',civilstatus='" & tempcivilstatus & "',voterstatus='" & tempvoterstatus & "',contactnumber='" & tempcontactnumber & "' WHERE residentno='" & tempresidentno & "'"


                com = New OdbcCommand(Query, con)
                com.ExecuteNonQuery()
                con.Close()

                con.Open()
                com = New OdbcCommand("SELECT * FROM barangay.residents", con)
                dt = New DataTable
                dt.Load(com.ExecuteReader)
                Clearance.ResidentDataList.DataSource = dt
                con.Close()
                Close()
            End If

        Catch ex As OdbcException
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        btnYes.Enabled = False 'disables the button when clicked
        btnYes.BackColor = Color.FromArgb(76, 164, 206) 'changes the color to blue when clicked
        btnNo.BackColor = Color.FromArgb(34, 36, 49) 'defaults the color of the other button
        LabelRegistered.ForeColor = Color.FromArgb(76, 164, 206) 'changes the color of the label'
        LabelNotRegistered.ForeColor = Color.LightGray 'defaults the color of the other label
        btnNo.Enabled = True 'enables the other button to be able to click
        tempvoterstatus = "Registered"
        ErrorVoterStatus.Visible = False
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        btnNo.Enabled = False 'disables the button when clicked
        btnNo.BackColor = Color.FromArgb(76, 164, 206) 'changes the color to blue when clicked
        btnYes.BackColor = Color.FromArgb(34, 36, 49) 'defaults the color of the other button
        LabelNotRegistered.ForeColor = Color.FromArgb(76, 164, 206) 'changes the color of the label'
        LabelRegistered.ForeColor = Color.LightGray 'defaults the color of the other label
        btnYes.Enabled = True 'enables the other button to be able to click
        tempvoterstatus = "Not Registered"
        ErrorVoterStatus.Visible = False
    End Sub

    Private Sub ContactNumber_Enter(sender As Object, e As EventArgs) Handles ContactNumber.Enter
        ContactNumber.Text = ""
        ContactNumber.ForeColor = Color.FromArgb(76, 164, 206)
        ErrorContactNumber.Visible = False
    End Sub

    Private Sub ContactNumber_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles ContactNumber.KeyPress
        Dim allowedChars As String = "1234567890"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ContactNumber_Leave(sender As Object, e As EventArgs) Handles ContactNumber.Leave
        ContactNumber.ForeColor = Color.LightGray
        If ContactNumber.Text = "" Then
            ContactNumber.Text = "Contact Number"
        End If
    End Sub

    Private Sub UpdateResidentData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Submit.Select()
    End Sub

    Private Sub StreetNo_Enter(sender As Object, e As EventArgs) Handles StreetNo.Enter
        StreetNo.Text = ""
    End Sub

    Private Sub StreetNo_Leave(sender As Object, e As EventArgs) Handles StreetNo.Leave
        If StreetNo.Text = "" Then
            StreetNo.Text = "Street No."
        End If
    End Sub
End Class