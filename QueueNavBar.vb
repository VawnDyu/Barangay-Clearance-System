Public Class QueueNavBar

    Private Sub btnQueueController_Click(sender As Object, e As EventArgs) Handles btnQueueController.Click
        WindowSelection.Show()
    End Sub

    Private Sub btnQueueWindow_Click(sender As Object, e As EventArgs) Handles btnQueueWindow.Click


            Dim screen As Screen
            screen = screen.AllScreens(1)
            QueueingWindow.StartPosition = FormStartPosition.Manual
            QueueingWindow.Location = screen.Bounds.Location + New Point(100, 100)

            QueueingWindow.Show()
            WindowSelection.Show()
    End Sub

    Private Sub BtnSignOut_Click(sender As Object, e As EventArgs) Handles BtnSignOut.Click
        SignOutMessage.Show()
    End Sub
End Class