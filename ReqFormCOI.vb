Imports $safeprojectname$.Data.Odbc

Public Class ReqFormCOI

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable
    Dim tempno As Integer

    Private Sub ReqFormCOI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Submit.Select()


        txtDate.Text = DateTime.Now.ToString("MMMM dd, yyy")

        con = New OdbcConnection("DSN=mydatabase")


        con.Open()
        Dim query As String
        query = "SELECT * FROM barangay.coi"
        com = New OdbcCommand(query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        ResidentDataList.DataSource = dt
        con.Close()

        Purpose.Text = "Purpose"
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        Me.Close()
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

    Private Sub Street_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Street.KeyPress
        e.Handled = True
    End Sub

    Private Sub StreetNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles StreetNo.KeyPress
        e.Handled = True
    End Sub

    Private Sub Purpose_Enter(sender As Object, e As EventArgs) Handles Purpose.Enter
        Purpose.Text = ""
        ErrorPurpose.Visible = False
        Purpose.ForeColor = Color.LightGray
        Purpose.LineIdleColor = Color.Gray
    End Sub

    Private Sub Purpose_Leave(sender As Object, e As EventArgs) Handles Purpose.Leave
        If Purpose.Text = "" Then
            Purpose.Text = "Purpose"
        End If
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        con = New OdbcConnection("DSN=mydatabase")

        Dim READER As OdbcDataReader

        Dim QueryFind As String
        con.Open()
        QueryFind = "SELECT * from barangay.coi where firstname = '" & FirstName.Text & "' AND middlename = '" & MiddleName.Text & "' AND lastname = '" & LastName.Text & "' AND streetno = '" & StreetNo.Text & "' AND street = '" & Street.Text & "'"
        com = New OdbcCommand(QueryFind, con)

        READER = com.ExecuteReader

        Dim countFind As Integer
        countFind = 0
        While READER.Read
            countFind = countFind + 1
        End While

        If countFind = 1 Then

            Dim QueryUpdate As String

            QueryUpdate = "UPDATE barangay.coi set purpose = '" & Purpose.Text & "' WHERE firstname = '" & FirstName.Text & "' AND middlename = '" & MiddleName.Text & "' AND lastname = '" & LastName.Text & "' AND streetno = '" & StreetNo.Text & "' AND street = '" & Street.Text & "'"

            com = New OdbcCommand(QueryUpdate, con)

            com.ExecuteNonQuery()

            Dim Query2 As String
            Query2 = "SELECT * FROM barangay.coi"
            com = New OdbcCommand(Query2, con)
            dt = New DataTable
            dt.Load(com.ExecuteReader)
            ResidentDataList.DataSource = dt

        Else

            If Purpose.Text <> "" And
                Purpose.Text <> "Purpose" Then
                con.Close()
                con.Open()
                Dim Query As String

                Query = "INSERT INTO barangay.coi (firstname,middlename,lastname,streetno,street,purpose,date) VALUES ('" & FirstName.Text & "','" & MiddleName.Text & "','" & LastName.Text & "','" & StreetNo.Text & "','" & Street.Text & "','" & Purpose.Text & "','" & txtDate.Text & "')"
                com = New OdbcCommand(Query, con)
                com.ExecuteNonQuery()
                con.Close()

                con = New OdbcConnection("DSN=mydatabase")


                con.Open()
                Dim Query2 As String
                Query2 = "SELECT * FROM barangay.coi"
                com = New OdbcCommand(Query2, con)
                dt = New DataTable
                dt.Load(com.ExecuteReader)
                ResidentDataList.DataSource = dt
                con.Close()



            Else
                ErrorPurpose.Text = "Please fill up the requirement"
                ErrorPurpose.Visible = True
                Purpose.ForeColor = Color.LightCoral
                Purpose.LineIdleColor = Color.LightCoral
                Purpose.Text = ""
            End If
        End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim fcr As New Form()
        Form.Show()

        Form.CrystalReportViewer1.ReportSource = Application.StartupPath + "\CrystalReport1.rpt"
        Form.CrystalReportViewer1.SelectionFormula = "{coi1.no} = " & tempno & ""
        ' Form.CrystalReportViewer1.SelectionFormula = "{coi1.firstname} = '" & FirstName.Text.ToString() & "' and {col1.purpose} = '" & Purpose.Text.ToString() & "'"
        Form.CrystalReportViewer1.Refresh()
        Form.CrystalReportViewer1.RefreshReport()

    End Sub

    Private Sub ResidentDataList_CellClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles ResidentDataList.CellClick
        tempno = ResidentDataList.SelectedCells.Item(0).Value()
        FirstName.Text = ResidentDataList.SelectedCells.Item(1).Value.ToString()
        MiddleName.Text = ResidentDataList.SelectedCells.Item(2).Value.ToString()
        LastName.Text = ResidentDataList.SelectedCells.Item(3).Value.ToString()
        StreetNo.Text = ResidentDataList.SelectedCells.Item(4).Value.ToString()
        Street.Text = ResidentDataList.SelectedCells.Item(5).Value.ToString()
        Purpose.Text = ResidentDataList.SelectedCells.Item(6).Value.ToString()
    End Sub

    Private Sub txtDate_OnValueChanged(sender As Object, e As EventArgs) Handles txtDate.OnValueChanged

    End Sub

End Class