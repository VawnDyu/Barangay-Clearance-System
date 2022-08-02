Imports $safeprojectname$.Data.Odbc

Public Class AdminStaff

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblDate.Text = DateTime.Now.ToString("MMM dd, yyy")
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblName.Text = Login.tempname

        con = New OdbcConnection("DSN=mydatabase")
        con.Open()

        Dim Query As String

        Query = "SELECT * FROM barangay.residents"
        com = New OdbcCommand(Query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        Clearance.ResidentDataList.DataSource = dt
        con.Close()


        With ClearanceDashboard
            .TopLevel = False
            PanelHome.Controls.Add(ClearanceDashboard)
            .BringToFront()
            .Show()
        End With

        With ClearanceNavBar
            .TopLevel = False
            PanelNavBar.Controls.Add(ClearanceNavBar)
            .BringToFront()
            .Show()
        End With

        btnClearance.color = Color.FromArgb(56, 144, 186) ' light blue
        btnQueue.color = Color.FromArgb(24, 26, 35) ' dark blue

        ClearanceNavBar.btnClearanceDashboard.Normalcolor = Color.FromArgb(56, 144, 186)
        ClearanceNavBar.btnClearanceDashboard.OnHovercolor = Color.FromArgb(56, 144, 186)
        ClearanceNavBar.btnClearanceDashboard.Enabled = False

        ClearanceNavBar.btnAddResident.Normalcolor = Color.FromArgb(24, 26, 35)
        ClearanceNavBar.btnAddResident.OnHovercolor = Color.FromArgb(56, 144, 186)
        ClearanceNavBar.btnAddResident.Enabled = True

        ClearanceNavBar.btnClearance.Normalcolor = Color.FromArgb(24, 26, 35)
        ClearanceNavBar.btnClearance.OnHovercolor = Color.FromArgb(56, 144, 186)
        ClearanceNavBar.btnClearance.Enabled = True

        ClearanceNavBar.BtnSignOut.Normalcolor = Color.FromArgb(24, 26, 35)
        ClearanceNavBar.BtnSignOut.OnHovercolor = Color.LightCoral
        ClearanceNavBar.BtnSignOut.Enabled = True

    End Sub

    Private Sub btnClearance_Click(sender As Object, e As EventArgs) Handles btnClearance.Click
        con = New OdbcConnection("DSN=mydatabase")
        con.Open()

        Dim Query As String

        Query = "SELECT * FROM barangay.residents"
        com = New OdbcCommand(Query, con)
        dt = New DataTable
        dt.Load(com.ExecuteReader)
        Clearance.ResidentDataList.DataSource = dt
        con.Close()


        With ClearanceDashboard
            .TopLevel = False
            PanelHome.Controls.Add(ClearanceDashboard)
            .BringToFront()
            .Show()
        End With

        With ClearanceNavBar
            .TopLevel = False
            PanelNavBar.Controls.Add(ClearanceNavBar)
            .BringToFront()
            .Show()
        End With

        btnClearance.color = Color.FromArgb(56, 144, 186) ' light blue
        btnQueue.color = Color.FromArgb(24, 26, 35) ' dark blue

        ClearanceNavBar.btnClearanceDashboard.Normalcolor = Color.FromArgb(56, 144, 186)
        ClearanceNavBar.btnClearanceDashboard.OnHovercolor = Color.FromArgb(56, 144, 186)
        ClearanceNavBar.btnClearanceDashboard.Enabled = False

        ClearanceNavBar.btnAddResident.Normalcolor = Color.FromArgb(24, 26, 35)
        ClearanceNavBar.btnAddResident.OnHovercolor = Color.FromArgb(56, 144, 186)
        ClearanceNavBar.btnAddResident.Enabled = True

        ClearanceNavBar.btnClearance.Normalcolor = Color.FromArgb(24, 26, 35)
        ClearanceNavBar.btnClearance.OnHovercolor = Color.FromArgb(56, 144, 186)
        ClearanceNavBar.btnClearance.Enabled = True

        ClearanceNavBar.BtnSignOut.Normalcolor = Color.FromArgb(24, 26, 35)
        ClearanceNavBar.BtnSignOut.OnHovercolor = Color.LightCoral
        ClearanceNavBar.BtnSignOut.Enabled = True
    End Sub

    Private Sub btnQueue_Click(sender As Object, e As EventArgs) Handles btnQueue.Click
        With QueueNavBar
            .TopLevel = False
            PanelNavBar.Controls.Add(QueueNavBar)
            .BringToFront()
            .Show()
        End With

        With InfodeskDashboard
            .TopLevel = False
            PanelHome.Controls.Add(InfodeskDashboard)
            .BringToFront()
            .Show()
        End With
        btnQueue.color = Color.FromArgb(56, 144, 186) 'light blue
        btnClearance.color = Color.FromArgb(24, 26, 35) ' dark blue

        QueueNavBar.btnQueueDashboard.Normalcolor = Color.FromArgb(56, 144, 186)
        QueueNavBar.btnQueueDashboard.OnHovercolor = Color.FromArgb(56, 144, 186)
        QueueNavBar.btnQueueDashboard.Enabled = False
    End Sub
End Class