Option Strict On
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
            ''Manually select file attachment
            'For Each filePath As String In OpenFileDialog1.FileNames
            '    If File.Exists(filePath) Then
            '        Dim fileName As String = Path.GetFileName(filePath)
            '        mail.Attachments.Add(New Attachment(filePath))
            '    End If
            'Next

            'This might help. Also there is a variable in the GlobalVariables class called StudentForEmail.
            'This new varaible will make it easier to reference the current student you are dealing with.
            'This is assuming we are going to deal with one student at a time, though.
            'I think realistically the program should just email each student all at once.
            'A little tedious to have the advisor log in for each potentially 100 or 200 students.
            'Unless maybe the email information is optional at the start of the program,
            'in which case the advisor may be able to individually click the email button one student at a time.
            Dim EmailAttachment_FPath As String
            Dim CurStud As Student = GlobalVariables.StudentForEmail

            If (CurStud.Status = "Bridge") Then
                EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Bridged-Fall2018.docx")
                'set the body to read something about Bridged
                mail.Body = "Hello " + CurStud.First + " " + CurStud.Last + ", " + vbCrLf +
                    "We have reviewed your College of Business Major Application, and upon further Advisor review, you do not currently meet the requirements to be admitted to your degree program." + vbCrLf + "Please review the attachment for further instrucitons."

            ElseIf (CurStud.Status = "Admitted") Then
                If (CurStud.Majors.Contains("Accounting")) Then
                    If (CurStud.Majors.Contains("Information Systems")) Then
                        EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-ACC-IS.docx")
                        'Set the body to read something about Accepted to Accounting
                    Else
                        EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-ACC.docx")
                        'Set the body to read something about Accepted to Accounting
                    End If

                Else
                    EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-Fall2018.docx")
                    'Set the body to read something about Accepted
                End If
            Else
                EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Denied-Fall2018.docx")
                'Set the body to read somehting about Denied
            End If

            mail.Attachments.Add(New Attachment(EmailAttachment_FPath))
            mail.IsBodyHtml = False
            Dim smtp As New SmtpClient()
            smtp.Host = "smtp.live.com"
            smtp.EnableSsl = True
            Dim NetworkCred As New NetworkCredential(txtEmail.Text.Trim(), txtPassword.Text.Trim())
            smtp.UseDefaultCredentials = True
            smtp.Credentials = NetworkCred
            smtp.Port = 587
            Try
                smtp.Send(mail)
                MessageBox.Show("Email sent.", "Message")
            Catch ex As Exception
                MessageBox.Show("The email was blocked by the connected networks firewall. Please contact your Network Administrator.")
            End Try



        End Using

        GlobalVariables.EmailStatus = True
    End Sub

    Private Sub frmEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSubject.Text = "College of Business Major Application "
        txtEmail.Text = GlobalVariables.EmailLogin
        txtPassword.Text = GlobalVariables.EmailPassword
        txtPassword.PasswordChar = CChar("*")

    End Sub
End Class