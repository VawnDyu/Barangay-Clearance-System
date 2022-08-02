Imports $safeprojectname$.Data.Odbc

Public Class Admin

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblDate.Text = DateTime.Now.ToString("MMM dd, yyy")
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblUser.Text = Login.tempname

        Timer1.Start()

        With AdminDashboard
            .TopLevel = False
            PanelHome.Controls.Add(AdminDashboard)
            .BringToFront()
            .Show()
        End With

        With AccountNavBar
            .TopLevel = False
            PanelNavBar.Controls.Add(AccountNavBar)
            .BringToFront()
            .Show()
        End With


        btnACcount.color = Color.FromArgb(56, 144, 186) 'light blue
        btnQueue.color = Color.FromArgb(24, 26, 35) ' dark blue
        btnClearance.color = Color.FromArgb(24, 26, 35) ' dark blue

        AccountNavBar.BtnDashboard.Normalcolor = Color.FromArgb(56, 144, 186)
        AccountNavBar.BtnDashboard.OnHovercolor = Color.FromArgb(56, 144, 186)
        AccountNavBar.BtnDashboard.Enabled = False

        AccountNavBar.BtnEmployeeAccount.Normalcolor = Color.FromArgb(24, 26, 35)
        AccountNavBar.BtnEmployeeAccount.OnHovercolor = Color.FromArgb(56, 144, 186)
        AccountNavBar.BtnEmployeeAccount.Enabled = True

        AccountNavBar.BtnAttendanceRecord.Normalcolor = Color.FromArgb(24, 26, 35)
        AccountNavBar.BtnAttendanceRecord.OnHovercolor = Color.FromArgb(56, 144, 186)
        AccountNavBar.BtnAttendanceRecord.Enabled = True

        AccountNavBar.BtnSignOut.Normalcolor = Color.FromArgb(24, 26, 35)
        AccountNavBar.BtnSignOut.OnHovercolor = Color.LightCoral
        AccountNavBar.BtnSignOut.Enabled = True
    End Sub

    Private Sub btnACcount_Click(sender As Object, e As EventArgs) Handles btnACcount.Click
        With AccountNavBar
            .TopLevel = False
            PanelNavBar.Controls.Add(AccountNavBar)
            .BringToFront()
            .Show()
        End With

        With AdminDashboard
            .TopLevel = False
            PanelHome.Controls.Add(AdminDashboard)
            .BringToFront()
            .Show()
        End With

        btnACcount.color = Color.FromArgb(56, 144, 186) 'light blue
        btnQueue.color = Color.FromArgb(24, 26, 35) ' dark blue
        btnClearance.color = Color.FromArgb(24, 26, 35) ' dark blue

        AccountNavBar.BtnDashboard.Normalcolor = Color.FromArgb(56, 144, 186)
        AccountNavBar.BtnDashboard.OnHovercolor = Color.FromArgb(56, 144, 186)
        AccountNavBar.BtnDashboard.Enabled = False

        AccountNavBar.BtnEmployeeAccount.Normalcolor = Color.FromArgb(24, 26, 35)
        AccountNavBar.BtnEmployeeAccount.OnHovercolor = Color.FromArgb(56, 144, 186)
        AccountNavBar.BtnEmployeeAccount.Enabled = True

        AccountNavBar.BtnAttendanceRecord.Normalcolor = Color.FromArgb(24, 26, 35)
        AccountNavBar.BtnAttendanceRecord.OnHovercolor = Color.FromArgb(56, 144, 186)
        AccountNavBar.BtnAttendanceRecord.Enabled = True
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
        btnACcount.color = Color.FromArgb(24, 26, 35) ' dark blue
        btnClearance.color = Color.FromArgb(24, 26, 35) ' dark blue

        QueueNavBar.btnQueueDashboard.Normalcolor = Color.FromArgb(56, 144, 186)
        QueueNavBar.btnQueueDashboard.OnHovercolor = Color.FromArgb(56, 144, 186)
        QueueNavBar.btnQueueDashboard.Enabled = False

    End Sub

    Private Sub btnClearance_Click(sender As Object, e As EventArgs) Handles btnClearance.Click
        With ClearanceNavBar
            .TopLevel = False
            PanelNavBar.Controls.Add(ClearanceNavBar)
            .BringToFront()
            .Show()
        End With

        With ClearanceDashboard
            .TopLevel = False
            PanelHome.Controls.Add(ClearanceDashboard)
            .BringToFront()
            .Show()
        End With

        btnClearance.color = Color.FromArgb(56, 144, 186) 'light blue
        btnQueue.color = Color.FromArgb(24, 26, 35) ' dark blue
        btnACcount.color = Color.FromArgb(24, 26, 35) ' dark blue

        ClearanceNavBar.btnClearanceDashboard.Normalcolor = Color.FromArgb(56, 144, 186)
        ClearanceNavBar.btnClearanceDashboard.OnHovercolor = Color.FromArgb(56, 144, 186)
        ClearanceNavBar.btnClearanceDashboard.Enabled = False

        ClearanceNavBar.btnClearance.Normalcolor = Color.FromArgb(24, 26, 35)
        ClearanceNavBar.btnClearance.OnHovercolor = Color.FromArgb(56, 144, 186)
        ClearanceNavBar.btnClearance.Enabled = True
    End Sub
End Class