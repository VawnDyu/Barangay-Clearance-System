Imports $safeprojectname$.Data.Odbc

Public Class infodeskpersonnel

    Dim con As OdbcConnection
    Dim com As OdbcCommand
    Dim dt As DataTable

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt")
        lblDate.Text = DateTime.Now.ToString("MMM dd, yyy")
    End Sub

    Private Sub InfoDeskPersonnel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblName.Text = Login.tempname

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

        QueueNavBar.btnQueueDashboard.Normalcolor = Color.FromArgb(56, 144, 186)
        QueueNavBar.btnQueueDashboard.OnHovercolor = Color.FromArgb(56, 144, 186)
        QueueNavBar.btnQueueDashboard.Enabled = False
    End Sub
End Class