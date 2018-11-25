Public Class frmEmailLogin
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        GlobalVariables.EmailLogin = txtEmailLogin.Text
        GlobalVariables.EmailPassword = txtEmailPassword.Text
        frmEmail.Show()
        Me.Close()
    End Sub
End Class