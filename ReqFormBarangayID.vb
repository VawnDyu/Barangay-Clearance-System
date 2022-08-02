Imports $safeprojectname$.Data.Odbc

Public Class ReqFormBarangayID

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable
    Dim tempno As Integer

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
    End Sub

    Private Sub ReqFormBarangayID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Submit.Select()

        txtDate.Text = DateTime.Now.ToString("MMMM dd, yyy")

        con = New OdbcConnection("DSN=mydatabase")

        con.Open()
        Dim query As String
        query = "SELECT * FROM barangay.barangayid"
        com = New OdbcCommand(query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        ResidentDataList.DataSource = dt
        con.Close()

        PCTNo.Text = "PCT No."
        IDNo.Text = "I.D No."
        GFirstName.Text = "First Name"
        GMiddleName.Text = "Middle Name"
        GLastName.Text = "Last Name"
        GStreetNo.Text = "Street No."
        GStreet.Text = "Street"
        GContactNo.Text = "Contact No."


    End Sub

    Private Sub txtDate_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles txtDate.KeyPress
        e.Handled = True
    End Sub

    Private Sub FirstName_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles FirstName.KeyPress
        e.Handled = True
    End Sub

    Private Sub MiddleName_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles MiddleName.KeyPress
        e.Handled = True
    End Sub


    Private Sub LastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles LastName.KeyPress
        e.Handled = True
    End Sub

    Private Sub Street_Enter(sender As Object, e As EventArgs) Handles Street.Enter
        PanelColor.BackColor = Color.FromArgb(76, 164, 206)
    End Sub
    Private Sub Street_Leave(sender As Object, e As EventArgs) Handles Street.Leave
        PanelColor.BackColor = Color.Gray
    End Sub

    Private Sub Street_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Street.KeyPress
        e.Handled = True
    End Sub

    Private Sub StreetNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StreetNo.KeyPress
        e.Handled = True
    End Sub

    Private Sub PCTNo_Enter(sender As Object, e As EventArgs) Handles PCTNo.Enter
        PCTNo.Text = ""
        PCTNo.ForeColor = Color.LightGray
        PCTNo.LineIdleColor = Color.Gray
    End Sub

    Private Sub PCTNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PCTNo.KeyPress
        Dim allowedChars As String = "123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PCTNo_Leave(sender As Object, e As EventArgs) Handles PCTNo.Leave
        If PCTNo.Text = "" Then
            PCTNo.Text = "PCT No."
        End If
    End Sub

    Private Sub IDNo_Enter(sender As Object, e As EventArgs) Handles IDNo.Enter
        IDNo.Text = ""
        IDNo.ForeColor = Color.LightGray
        IDNo.LineIdleColor = Color.Gray
    End Sub

    Private Sub IDNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDNo.KeyPress
        Dim allowedChars As String = "123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub IDNo_Leave(sender As Object, e As EventArgs) Handles IDNo.Leave
        If IDNo.Text = "" Then
            IDNo.Text = "I.D No."
        End If
    End Sub

    Private Sub GFirstName_Enter(sender As Object, e As EventArgs) Handles GFirstName.Enter
        GFirstName.Text = ""
        GFirstName.ForeColor = Color.LightGray
        GFirstName.LineIdleColor = Color.Gray
    End Sub

    Private Sub GFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GFirstName.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz. "
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub GFirstName_Leave(sender As Object, e As EventArgs) Handles GFirstName.Leave
        If GFirstName.Text = "" Then
            GFirstName.Text = "First Name"
        End If
    End Sub

    Private Sub GMiddleName_Enter(sender As Object, e As EventArgs) Handles GMiddleName.Enter
        GMiddleName.Text = ""
        GMiddleName.ForeColor = Color.LightGray
        GMiddleName.LineIdleColor = Color.Gray
    End Sub

    Private Sub GMiddleName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GMiddleName.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz. "
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub GMiddleName_Leave(sender As Object, e As EventArgs) Handles GMiddleName.Leave
        If GMiddleName.Text = "" Then
            GMiddleName.Text = "Middle Name"
        End If
    End Sub

    Private Sub GLastName_Enter(sender As Object, e As EventArgs) Handles GLastName.Enter
        GLastName.Text = ""
        GLastName.ForeColor = Color.LightGray
        GLastName.LineIdleColor = Color.Gray
    End Sub

    Private Sub GLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GLastName.KeyPress
        Dim allowedChars As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz. "
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub GLastName_Leave(sender As Object, e As EventArgs) Handles GLastName.Leave
        If GLastName.Text = "" Then
            GLastName.Text = "Last Name"
        End If
    End Sub

    Private Sub GStreetNo_Enter(sender As Object, e As EventArgs) Handles GStreetNo.Enter
        GStreetNo.Text = ""
        GStreetNo.ForeColor = Color.LightGray
        GStreetNo.LineIdleColor = Color.Gray
    End Sub

    Private Sub GStreetNo_Leave(sender As Object, e As EventArgs) Handles GStreetNo.Leave
        If GStreetNo.Text = "" Then
            GStreetNo.Text = "Street No."
        End If
    End Sub

    Private Sub GStreet_Enter(sender As Object, e As EventArgs) Handles GStreet.Enter
        GStreet.Text = ""
        GStreet.ForeColor = Color.LightGray
        PanelColor2.BackColor = Color.FromArgb(76, 164, 206)
    End Sub

    Private Sub GStreet_Leave(sender As Object, e As EventArgs) Handles GStreet.Leave
        If GStreet.Text = "" Then
            GStreet.Text = "Street"
        End If
        PanelColor2.BackColor = Color.Gray
    End Sub

    Private Sub GContactNo_Enter(sender As Object, e As EventArgs) Handles GContactNo.Enter
        GContactNo.Text = ""
        GContactNo.ForeColor = Color.LightGray
        PanelColor3.BackColor = Color.Gray
    End Sub

    Private Sub GContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles GContactNo.KeyPress
        Dim allowedChars As String = "123456789"
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            If Not e.KeyChar = Chr(Keys.Back) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub GContactNo_Leave(sender As Object, e As EventArgs) Handles GContactNo.Leave
        If GContactNo.Text = "" Then
            GContactNo.Text = "Contact No."
        End If
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        con = New OdbcConnection("DSN=mydatabase")


        If PCTNo.Text = "PCT No." Then
            PCTNo.ForeColor = Color.LightCoral
            PCTNo.LineIdleColor = Color.LightCoral
            PCTNo.Text = ""
        End If

        If IDNo.Text = "I.D No." Then
            IDNo.ForeColor = Color.LightCoral
            IDNo.LineIdleColor = Color.LightCoral
            IDNo.Text = ""
        End If

        If GFirstName.Text = "First Name" Then
            GFirstName.ForeColor = Color.LightCoral
            GFirstName.LineIdleColor = Color.LightCoral
            GFirstName.Text = ""
        End If

        If GMiddleName.Text = "Middle Name" Then
            GMiddleName.ForeColor = Color.LightCoral
            GMiddleName.LineIdleColor = Color.LightCoral
            GMiddleName.Text = ""
        End If

        If GLastName.Text = "Last Name" Then
            GLastName.ForeColor = Color.LightCoral
            GLastName.LineIdleColor = Color.LightCoral
            GLastName.Text = ""
        End If

        If GStreetNo.Text = "Street No." Then
            GStreetNo.ForeColor = Color.LightCoral
            GStreetNo.LineIdleColor = Color.LightCoral
            GStreetNo.Text = ""
        End If

        If GStreet.Text = "Street" Then
            GStreet.ForeColor = Color.LightCoral
            PanelColor2.BackColor = Color.LightCoral
            GStreet.Text = ""
        End If

        If GContactNo.Text = "Contact No." Then
            GContactNo.ForeColor = Color.LightCoral
            PanelColor3.BackColor = Color.LightCoral
            GContactNo.Text = ""
        End If

        Dim READER As OdbcDataReader

        Dim QueryFind As String
        con.Open()
        QueryFind = "SELECT * from barangay.barangayid where firstname = '" & FirstName.Text & "' AND middlename = '" & MiddleName.Text & "' AND lastname = '" & LastName.Text & "' AND streetno = '" & StreetNo.Text & "' AND street = '" & Street.Text & "'"
        com = New OdbcCommand(QueryFind, con)

        READER = com.ExecuteReader

        Dim countFind As Integer
        countFind = 0
        While READER.Read
            countFind = countFind + 1
        End While

        If countFind = 1 Then

            Dim QueryUpdate As String

            QueryUpdate = "UPDATE barangay.barangayid set pctno = '" & PCTNo.Text & "',idno='" & IDNo.Text & "',gfirstname='" & GFirstName.Text & "',gmiddlename='" & GMiddleName.Text & "',glastname='" & GLastName.Text & "',gstreetno='" & GStreetNo.Text & "',gstreet='" & GStreet.Text & "' WHERE firstname = '" & FirstName.Text & "' AND middlename = '" & MiddleName.Text & "' AND lastname = '" & LastName.Text & "' AND streetno = '" & StreetNo.Text & "' AND street = '" & Street.Text & "'"

            com = New OdbcCommand(QueryUpdate, con)

            com.ExecuteNonQuery()

            Dim Query2 As String
            Query2 = "SELECT * FROM barangay.barangayid"
            com = New OdbcCommand(Query2, con)
            dt = New DataTable
            dt.Load(com.ExecuteReader)
            ResidentDataList.DataSource = dt

        Else

            If PCTNo.Text <> "PCT No." And
                PCTNo.Text <> "" And
                IDNo.Text <> "I.D No." And
                IDNo.Text <> "" And
                GFirstName.Text <> "First Name" And
                GFirstName.Text <> "" And
                GMiddleName.Text <> "Middle Name" And
                GMiddleName.Text <> "" And
                GLastName.Text <> "Last Name" And
                GLastName.Text <> "" And
                GStreetNo.Text <> "Street No." And
                GStreetNo.Text <> "" And
                GStreet.Text <> "Street" And
                GStreet.Text <> "" Then
                con.Close()
                con.Open()
                Dim Query As String

                Query = "INSERT INTO barangay.barangayid (firstname,middlename,lastname,streetno,street,pctno,idno,gfirstname,gmiddlename,glastname,gstreetno,gstreet,gcontactno,date) VALUES ('" & FirstName.Text & "','" & MiddleName.Text & "','" & LastName.Text & "','" & StreetNo.Text & "','" & Street.Text & "','" & PCTNo.Text & "','" & IDNo.Text & "','" & GFirstName.Text & "','" & GMiddleName.Text & "','" & GLastName.Text & "','" & GStreetNo.Text & "','" & GStreet.Text & "','" & GContactNo.Text & "','" & txtDate.Text & "')"
                com = New OdbcCommand(Query, con)
                com.ExecuteNonQuery()
                con.Close()

                con = New OdbcConnection("DSN=mydatabase")


                con.Open()
                Dim Query2 As String
                Query2 = "SELECT * FROM barangay.barangayid"
                com = New OdbcCommand(Query2, con)
                dt = New DataTable
                dt.Load(com.ExecuteReader)
                ResidentDataList.DataSource = dt
                con.Close()

            Else
                MessageBox.Show("Error")

            End If
        End If

    End Sub

    Private Sub ResidentDataList_CellClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles ResidentDataList.CellClick
        tempno = ResidentDataList.SelectedCells.Item(0).Value()
        FirstName.Text = ResidentDataList.SelectedCells.Item(1).Value.ToString()
        MiddleName.Text = ResidentDataList.SelectedCells.Item(2).Value.ToString()
        LastName.Text = ResidentDataList.SelectedCells.Item(3).Value.ToString()
        StreetNo.Text = ResidentDataList.SelectedCells.Item(4).Value.ToString()
        Street.Text = ResidentDataList.SelectedCells.Item(5).Value.ToString()
        PCTNo.Text = ResidentDataList.SelectedCells.Item(6).Value.ToString()
        IDNo.Text = ResidentDataList.SelectedCells.Item(7).Value.ToString()
        GFirstName.Text = ResidentDataList.SelectedCells.Item(8).Value.ToString()
        GMiddleName.Text = ResidentDataList.SelectedCells.Item(9).Value.ToString()
        GLastName.Text = ResidentDataList.SelectedCells.Item(10).Value.ToString()
        GStreetNo.Text = ResidentDataList.SelectedCells.Item(11).Value.ToString()
        GStreet.Text = ResidentDataList.SelectedCells.Item(12).Value.ToString()
        GContactNo.Text = ResidentDataList.SelectedCells.Item(13).Value.ToString()
        txtDate.Text = ResidentDataList.SelectedCells.Item(14).Value.ToString()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim fcr As New Form()
        Form.Show()

        Form.CrystalReportViewer1.ReportSource = Application.StartupPath + "\CrystalReport3.rpt"
        Form.CrystalReportViewer1.SelectionFormula = "{barangayid1.no} = " & tempno & ""
        ' Form.CrystalReportViewer1.SelectionFormula = "{coi1.firstname} = '" & FirstName.Text.ToString() & "' and {col1.purpose} = '" & Purpose.Text.ToString() & "'"
        Form.CrystalReportViewer1.Refresh()
        Form.CrystalReportViewer1.RefreshReport()

    End Sub
End Class