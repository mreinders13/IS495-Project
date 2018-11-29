Option Strict On
Public Class frmEmailLogin
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        GlobalVariables.EmailLogin = txtEmailLogin.Text
        GlobalVariables.EmailPassword = txtEmailPassword.Text
        frmEmail.Show()
        Me.Close()
    End Sub

    Private Sub frmEmailLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmailPassword.PasswordChar = CChar("*")
    End Sub
End Class