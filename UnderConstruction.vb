Public Class UnderConstruction

    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        Me.Close()
    End Sub

    Private Sub BtnYes_KeyDown(sender As Object, e As KeyEventArgs) Handles BtnYes.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Close()
        End If

    End Sub
End Class