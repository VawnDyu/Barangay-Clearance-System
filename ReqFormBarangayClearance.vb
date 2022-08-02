Imports $safeprojectname$.Data.Odbc

Public Class ReqFormBarangayClearance

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable
    Dim tempno As Integer

    Private Sub ReqFormBarangayClearance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Submit.Select()

        Dim num As String = "th"

        Dim day As Integer = Convert.ToInt16(DateTime.Now.ToString("dd"))
        Dim month As String = Convert.ToString(DateTime.Now.ToString("MMMM"))
        Dim year As String = Convert.ToString(DateTime.Now.ToString("yyyy"))

        Select Case day

            Case 1
                num = "st"
            Case 21
                num = "st"
            Case 31
                num = "st"
            Case 2
                num = "nd"
            Case 22
                num = "nd"
            Case 3
                num = "rd"
            Case 33
                num = "rd"

            Case Else
                num = "th"

                txtDate.Text = day & num & " day of " & month & " " & year
        End Select


        Dim datenow As DateTime = DateTime.Now.ToString("MMMM dd, yyyy")
        Dim validuntil As DateTime = datenow.AddYears(1)

        txtValidUntilDate.Text = validuntil.ToString("MMMM dd, yyyy")

        con = New OdbcConnection("DSN=mydatabase")

        con.Open()
        Dim Query2 As String
        Query2 = "SELECT * FROM barangay.barangayclearance"
        com = New OdbcCommand(Query2, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        ResidentDataList.DataSource = dt
        con.Close()

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

    Private Sub Category_Enter(sender As Object, e As EventArgs) Handles Category.Enter
        Category.Text = ""
        Category.ForeColor = Color.LightGray
        Category.LineIdleColor = Color.Gray
    End Sub

    Private Sub Category_Leave(sender As Object, e As EventArgs) Handles Category.Leave
        If Category.Text = "" Then
            Category.Text = "Category"
        End If
    End Sub

    Private Sub BCBNumber_Enter(sender As Object, e As EventArgs) Handles BCBNumber.Enter
        BCBNumber.Text = ""
        BCBNumber.ForeColor = Color.LightGray
        BCBNumber.LineIdleColor = Color.Gray
    End Sub

    Private Sub BCBNumber_Leave(sender As Object, e As EventArgs) Handles BCBNumber.Leave
        If BCBNumber.Text = "" Then
            BCBNumber.Text = "BCB Number"
        End If
    End Sub
    Private Sub BCControlNo_Enter(sender As Object, e As EventArgs) Handles BCControlNo.Enter
        BCControlNo.Text = ""
        BCControlNo.ForeColor = Color.LightGray
        BCControlNo.LineIdleColor = Color.Gray
    End Sub

    Private Sub BCControlNo_Leave(sender As Object, e As EventArgs) Handles BCControlNo.Leave
        If BCControlNo.Text = "" Then
            BCControlNo.Text = "B.C Control No."
        End If
    End Sub

    Private Sub ORNo_Enter(sender As Object, e As EventArgs) Handles ORNo.Enter
        ORNo.Text = ""
        ORNo.ForeColor = Color.LightGray
        ORNo.LineIdleColor = Color.Gray
    End Sub

    Private Sub ORNo_Leave(sender As Object, e As EventArgs) Handles ORNo.Leave
        If ORNo.Text = "" Then
            ORNo.Text = "OR No."
        End If
    End Sub

    Private Sub AmountPaid_Enter(sender As Object, e As EventArgs) Handles AmountPaid.Enter
        AmountPaid.Text = ""
        AmountPaid.ForeColor = Color.LightGray
        AmountPaid.LineIdleColor = Color.Gray
    End Sub

    Private Sub AmountPaid_Leave(sender As Object, e As EventArgs) Handles AmountPaid.Leave
        If AmountPaid.Text = "" Then
            AmountPaid.Text = "Amount Paid"
        End If
    End Sub

    Private Sub YearSeries_Enter(sender As Object, e As EventArgs) Handles YearSeries.Enter
        YearSeries.Text = ""
        YearSeries.ForeColor = Color.LightGray
        YearSeries.LineIdleColor = Color.Gray
    End Sub

    Private Sub YearSeries_Leave(sender As Object, e As EventArgs) Handles YearSeries.Leave
        If YearSeries.Text = "" Then
            YearSeries.Text = "Year"
        End If
    End Sub

    Private Sub PlateNo_Enter(sender As Object, e As EventArgs) Handles PlateNo.Enter
        PlateNo.Text = ""
        PlateNo.ForeColor = Color.LightGray
        PlateNo.LineIdleColor = Color.Gray
    End Sub

    Private Sub PlateNo_Leave(sender As Object, e As EventArgs) Handles PlateNo.Leave
        If PlateNo.Text = "" Then
            PlateNo.Text = "Plate No."
        End If
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        con = New OdbcConnection("DSN=mydatabase")


        If Purpose.Text = "Purpose" Then
            ErrorPurpose.Text = "Please fill up the requirement"
            ErrorPurpose.Visible = True
            Purpose.ForeColor = Color.LightCoral
            Purpose.LineIdleColor = Color.LightCoral
            Purpose.Text = ""
        End If

        If Category.Text = "Category" Then
            Category.ForeColor = Color.LightCoral
            Category.LineIdleColor = Color.LightCoral
            Category.Text = ""
        End If

        If BCBNumber.Text = "BCB Number" Then
            BCBNumber.ForeColor = Color.LightCoral
            BCBNumber.LineIdleColor = Color.LightCoral
            BCBNumber.Text = ""
        End If

        If BCControlNo.Text = "B.C Control No." Then
            BCControlNo.ForeColor = Color.LightCoral
            BCControlNo.LineIdleColor = Color.LightCoral
            BCControlNo.Text = ""
        End If

        If ORNo.Text = "OR No." Then
            ORNo.ForeColor = Color.LightCoral
            ORNo.LineIdleColor = Color.LightCoral
            ORNo.Text = ""
        End If

        If AmountPaid.Text = "Amount Paid" Then
            AmountPaid.ForeColor = Color.LightCoral
            AmountPaid.LineIdleColor = Color.LightCoral
            AmountPaid.Text = ""
        End If

        If YearSeries.Text = "Year" Then
            YearSeries.ForeColor = Color.LightCoral
            YearSeries.LineIdleColor = Color.LightCoral
            YearSeries.Text = ""
        End If

        If PlateNo.Text = "Plate No." Then
            PlateNo.ForeColor = Color.LightCoral
            PlateNo.LineIdleColor = Color.LightCoral
            PlateNo.Text = ""
        End If

        Dim READER As OdbcDataReader

        Dim QueryFind As String
        con.Open()
        QueryFind = "SELECT * from barangay.barangayclearance where firstname = '" & FirstName.Text & "' AND middlename = '" & MiddleName.Text & "' AND lastname = '" & LastName.Text & "' AND streetno = '" & StreetNo.Text & "' AND street = '" & Street.Text & "'"
        com = New OdbcCommand(QueryFind, con)

        READER = com.ExecuteReader

        Dim countFind As Integer
        countFind = 0
        While READER.Read
            countFind = countFind + 1
        End While

        If countFind = 1 Then

            Dim QueryUpdate As String

            QueryUpdate = "UPDATE barangay.barangayclearance set purpose = '" & Purpose.Text & "',category='" & Category.Text & "',bcbnumber='" & BCBNumber.Text & "',bccontrolno='" & BCControlNo.Text & "',orno='" & ORNo.Text & "',amountpaid='" & AmountPaid.Text & "',year='" & YearSeries.Text & "',plateno='" & PlateNo.Text & "' WHERE firstname = '" & FirstName.Text & "' AND middlename = '" & MiddleName.Text & "' AND lastname = '" & LastName.Text & "' AND streetno = '" & StreetNo.Text & "' AND street = '" & Street.Text & "'"

            com = New OdbcCommand(QueryUpdate, con)

            com.ExecuteNonQuery()

            Dim Query2 As String
            Query2 = "SELECT * FROM barangay.barangayclearance"
            com = New OdbcCommand(Query2, con)
            dt = New DataTable
            dt.Load(com.ExecuteReader)
            ResidentDataList.DataSource = dt

        Else

            If Purpose.Text <> "" And
                Purpose.Text <> "Purpose" And
                Category.Text <> "" And
                Category.Text <> "Category" And
                BCBNumber.Text <> "" And
                BCBNumber.Text <> "BCB Number" And
                BCControlNo.Text <> "" And
                BCControlNo.Text <> "B.C Control No." And
                ORNo.Text <> "" And
                ORNo.Text <> "OR No." And
                AmountPaid.Text <> "Amount Paid" And
                AmountPaid.Text <> "" And
                YearSeries.Text <> "" And
                YearSeries.Text <> "Year" And
                PlateNo.Text <> "Plate No." And
                PlateNo.Text <> "" Then
                con.Close()
                con.Open()
                Dim Query As String

                Query = "INSERT INTO barangay.barangayclearance (firstname,middlename,lastname,streetno,street,purpose,date,dateuntil,category,bcbnumber,bccontrolno,orno,amountpaid,year,plateno) VALUES ('" & FirstName.Text & "','" & MiddleName.Text & "','" & LastName.Text & "','" & StreetNo.Text & "','" & Street.Text & "','" & Purpose.Text & "','" & txtDate.Text & "','" & txtValidUntilDate.Text & "','" & Category.Text & "','" & BCBNumber.Text & "','" & BCControlNo.Text & "','" & ORNo.Text & "','" & AmountPaid.Text & "','" & YearSeries.Text & "','" & PlateNo.Text & "')"
                com = New OdbcCommand(Query, con)
                com.ExecuteNonQuery()
                con.Close()

                con = New OdbcConnection("DSN=mydatabase")


                con.Open()
                Dim Query2 As String
                Query2 = "SELECT * FROM barangay.barangayclearance"
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

    Private Sub ResidentDataList_CellClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles ResidentDataList.CellClick
        tempno = ResidentDataList.SelectedCells.Item(0).Value()
        FirstName.Text = ResidentDataList.SelectedCells.Item(1).Value.ToString()
        MiddleName.Text = ResidentDataList.SelectedCells.Item(2).Value.ToString()
        LastName.Text = ResidentDataList.SelectedCells.Item(3).Value.ToString()
        StreetNo.Text = ResidentDataList.SelectedCells.Item(4).Value.ToString()
        Street.Text = ResidentDataList.SelectedCells.Item(5).Value.ToString()
        Purpose.Text = ResidentDataList.SelectedCells.Item(6).Value.ToString()
        txtDate.Text = ResidentDataList.SelectedCells.Item(7).Value.ToString()
        txtValidUntilDate.Text = ResidentDataList.SelectedCells.Item(8).Value.ToString()
        Category.Text = ResidentDataList.SelectedCells.Item(9).Value.ToString()
        BCBNumber.Text = ResidentDataList.SelectedCells.Item(10).Value.ToString()
        BCControlNo.Text = ResidentDataList.SelectedCells.Item(11).Value.ToString()
        ORNo.Text = ResidentDataList.SelectedCells.Item(12).Value.ToString()
        AmountPaid.Text = ResidentDataList.SelectedCells.Item(13).Value.ToString()
        YearSeries.Text = ResidentDataList.SelectedCells.Item(14).Value.ToString()
        PlateNo.Text = ResidentDataList.SelectedCells.Item(15).Value.ToString
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim fcr As New Form()
        Form.Show()

        Form.CrystalReportViewer1.ReportSource = Application.StartupPath + "\CrystalReport2.rpt"
        Form.CrystalReportViewer1.SelectionFormula = "{barangayclearance1.no} = " & tempno & ""
        ' Form.CrystalReportViewer1.SelectionFormula = "{coi1.firstname} = '" & FirstName.Text.ToString() & "' and {col1.purpose} = '" & Purpose.Text.ToString() & "'"
        Form.CrystalReportViewer1.Refresh()
        Form.CrystalReportViewer1.RefreshReport()

    End Sub

End Class