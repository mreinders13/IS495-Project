Imports System.IO
Imports System.Net
Imports System.Net.Mail

Public Class frmEmail
    Private Sub lnkAttach_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAttach.LinkClicked
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub openFileDialog1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        For Each filePath As String In OpenFileDialog1.FileNames
            If File.Exists(filePath) Then
                Dim fileName As String = Path.GetFileName(filePath)
                lnkAttach.Text += fileName + Environment.NewLine
            End If
        Next
    End Sub

    Private Sub btnSend_Click(sender As System.Object, e As System.EventArgs) Handles btnSend.Click
        Using mail As New MailMessage(txtEmail.Text.Trim(), txtTo.Text.Trim())
            mail.Subject = txtSubject.Text
            mail.Body = txtBody.Text
            For Each filePath As String In OpenFileDialog1.FileNames
                If File.Exists(filePath) Then
                    Dim fileName As String = Path.GetFileName(filePath)
                    mail.Attachments.Add(New Attachment(filePath))
                End If
            Next
            mail.IsBodyHtml = False
            Dim smtp As New SmtpClient()
            smtp.Host = "smtp.gmail.com"
            smtp.EnableSsl = True
            Dim NetworkCred As New NetworkCredential(txtEmail.Text.Trim(), txtPassword.Text.Trim())
            smtp.UseDefaultCredentials = True
            smtp.Credentials = NetworkCred
            smtp.Port = 465
            smtp.Send(mail)
            MessageBox.Show("Email sent.", "Message")
        End Using

        GlobalVariables.EmailStatus = "Student has been emailed"
    End Sub

    Private Sub frmEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSubject.Text = "College of Business Major Application "
        txtEmail.Text = GlobalVariables.EmailLogin
        txtPassword.Text = GlobalVariables.EmailPassword

    End Sub
End Class