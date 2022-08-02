Imports $safeprojectname$.Data.Odbc

Public Class Clearance

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable

    Public firstname As String


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
            ReqFormCOI.ShowDialog()


    End Sub

    Private Sub Clearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OdbcConnection("DSN=mydatabase")


        con.Open()
        Dim query As String
        Query = "SELECT * FROM barangay.residents"
        com = New OdbcCommand(Query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        ResidentDataList.DataSource = dt
        con.Close()

        BunifuFlatButton1.Select()
    End Sub

    Private Sub ResidentDataList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ResidentDataList.CellClick


        ReqFormBarangayID.FirstName.Text = ResidentDataList.SelectedCells.Item(1).Value.ToString()
        ReqFormBarangayID.MiddleName.Text = ResidentDataList.SelectedCells.Item(2).Value.ToString()
        ReqFormBarangayID.LastName.Text = ResidentDataList.SelectedCells.Item(3).Value.ToString()
        ReqFormBarangayID.StreetNo.Text = ResidentDataList.SelectedCells.Item(4).Value.ToString()
        ReqFormBarangayID.Street.Text = ResidentDataList.SelectedCells.Item(5).Value.ToString()

        '============================================================='

        ReqFormCOI.FirstName.Text = ResidentDataList.SelectedCells.Item(1).Value.ToString()
        ReqFormCOI.MiddleName.Text = ResidentDataList.SelectedCells.Item(2).Value.ToString()
        ReqFormCOI.LastName.Text = ResidentDataList.SelectedCells.Item(3).Value.ToString()
        ReqFormCOI.StreetNo.Text = ResidentDataList.SelectedCells.Item(4).Value.ToString()
        ReqFormCOI.Street.Text = ResidentDataList.SelectedCells.Item(5).Value.ToString()

        '=============================================================

        ReqFormBarangayClearance.FirstName.Text = ResidentDataList.SelectedCells.Item(1).Value.ToString()
        ReqFormBarangayClearance.MiddleName.Text = ResidentDataList.SelectedCells.Item(2).Value.ToString()
        ReqFormBarangayClearance.LastName.Text = ResidentDataList.SelectedCells.Item(3).Value.ToString()
        ReqFormBarangayClearance.StreetNo.Text = ResidentDataList.SelectedCells.Item(4).Value.ToString()
        ReqFormBarangayClearance.Street.Text = ResidentDataList.SelectedCells.Item(5).Value.ToString()


        firstname = ResidentDataList.SelectedCells.Item(1).Value.ToString

        UpdateResidentData.tempresidentno = ResidentDataList.SelectedCells.Item(0).Value.ToString()
        UpdateResidentData.FirstName.Text = ResidentDataList.SelectedCells.Item(1).Value.ToString()
        UpdateResidentData.MiddleName.Text = ResidentDataList.SelectedCells.Item(2).Value.ToString()
        UpdateResidentData.LastName.Text = ResidentDataList.SelectedCells.Item(3).Value.ToString()
        UpdateResidentData.StreetNo.Text = ResidentDataList.SelectedCells.Item(4).Value.ToString()
        UpdateResidentData.Street.Text = ResidentDataList.SelectedCells.Item(5).Value.ToString()
        UpdateResidentData.tempgender = ResidentDataList.SelectedCells.Item(6).Value.ToString()

        If UpdateResidentData.tempgender = "Male" Then
            UpdateResidentData.GenderMale.Enabled = False
            UpdateResidentData.GenderMale.BackColor = Color.FromArgb(76, 164, 206)
            UpdateResidentData.LabelMale.ForeColor = Color.FromArgb(76, 164, 206)

            UpdateResidentData.GenderFemale.Enabled = True
            UpdateResidentData.GenderFemale.BackColor = Color.FromArgb(34, 36, 49)
            UpdateResidentData.LabelFemale.ForeColor = Color.LightGray
        ElseIf UpdateResidentData.tempgender = "Female" Then
            UpdateResidentData.GenderFemale.Enabled = False
            UpdateResidentData.GenderFemale.BackColor = Color.PaleVioletRed
            UpdateResidentData.LabelFemale.ForeColor = Color.PaleVioletRed

            UpdateResidentData.GenderMale.Enabled = True
            UpdateResidentData.GenderMale.BackColor = Color.FromArgb(34, 36, 49)
            UpdateResidentData.LabelMale.ForeColor = Color.LightGray
        End If

        UpdateResidentData.Birthdate.Value = ResidentDataList.SelectedCells.Item(7).Value.ToString()

        UpdateResidentData.tempcivilstatus = ResidentDataList.SelectedCells.Item(8).Value.ToString()

        If UpdateResidentData.tempcivilstatus = "Single" Then
            UpdateResidentData.StatusSingle.Enabled = False
            UpdateResidentData.StatusSingle.BackColor = Color.FromArgb(76, 164, 206)
            UpdateResidentData.lblSingle.ForeColor = Color.FromArgb(76, 164, 206)

            UpdateResidentData.StatusMarried.Enabled = True
            UpdateResidentData.StatusMarried.BackColor = Color.FromArgb(34, 36, 49)
            UpdateResidentData.lblMarried.ForeColor = Color.LightGray

        ElseIf UpdateResidentData.tempcivilstatus = "Married" Then
            UpdateResidentData.StatusMarried.Enabled = False
            UpdateResidentData.StatusMarried.BackColor = Color.FromArgb(76, 164, 206)
            UpdateResidentData.lblMarried.ForeColor = Color.FromArgb(76, 164, 206)

            UpdateResidentData.StatusSingle.Enabled = True
            UpdateResidentData.StatusSingle.BackColor = Color.FromArgb(34, 36, 49)
            UpdateResidentData.lblSingle.ForeColor = Color.LightGray
        End If

        UpdateResidentData.tempvoterstatus = ResidentDataList.SelectedCells.Item(9).Value.ToString()

        If UpdateResidentData.tempvoterstatus = "Registered" Then
            UpdateResidentData.btnYes.Enabled = False
            UpdateResidentData.btnYes.BackColor = Color.FromArgb(76, 164, 206)
            UpdateResidentData.LabelRegistered.ForeColor = Color.FromArgb(76, 164, 206)

            UpdateResidentData.btnNo.Enabled = True
            UpdateResidentData.btnNo.BackColor = Color.FromArgb(34, 36, 49)
            UpdateResidentData.LabelNotRegistered.ForeColor = Color.LightGray

        ElseIf UpdateResidentData.tempvoterstatus = "Not Registered" Then
            UpdateResidentData.btnNo.Enabled = False
            UpdateResidentData.btnNo.BackColor = Color.FromArgb(76, 164, 206)
            UpdateResidentData.LabelNotRegistered.ForeColor = Color.FromArgb(76, 164, 206)

            UpdateResidentData.btnYes.Enabled = True
            UpdateResidentData.btnYes.BackColor = Color.FromArgb(34, 36, 49)
            UpdateResidentData.LabelRegistered.ForeColor = Color.LightGray
        End If

        UpdateResidentData.ContactNumber.Text = ResidentDataList.SelectedCells.Item(10).Value.ToString
    End Sub

    Private Sub ImgUpdate_Click(sender As Object, e As EventArgs) Handles ImgUpdate.Click
        UpdateResidentData.ShowDialog()
    End Sub


    Private Sub ImgDelete_Click(sender As Object, e As EventArgs) Handles ImgDelete.Click
        DeleteMessageAdminStaff.ShowDialog()
    End Sub


    Private Sub SearchBar_Enter(sender As Object, e As EventArgs) Handles SearchBar.Enter
        SearchBar.text = ""

        con = New OdbcConnection("DSN=mydatabase")


        con.Open()
        Dim query As String
        query = "SELECT * FROM barangay.residents"
        com = New OdbcCommand(query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        ResidentDataList.DataSource = dt
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

            Query = "SELECT * FROM barangay.residents"
            com = New OdbcCommand(Query, con)
            dt = New DataTable
            dt.Load(com.ExecuteReader)
            ResidentDataList.DataSource = dt
            con.Close()
        End If
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        ReqFormBarangayClearance.ShowDialog()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        ReqFormBarangayID.ShowDialog()
    End Sub

    Private Sub SearchBar_OnTextChange(sender As Object, e As EventArgs) Handles SearchBar.OnTextChange
        Dim dv As New DataView(dt)
        dv.RowFilter = String.Format("firstname LIKE '%{0}%'", SearchBar.text)
        ResidentDataList.DataSource = dv
    End Sub

    Private Sub SearchRemoveAll_Click(sender As Object, e As EventArgs) Handles SearchRemoveAll.Click
        SearchBar.text = ""

        con = New OdbcConnection("DSN=mydatabase")


        con.Open()
        Dim query As String
        query = "SELECT * FROM barangay.residents"
        com = New OdbcCommand(query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        ResidentDataList.DataSource = dt
        con.Close()
    End Sub
End Class