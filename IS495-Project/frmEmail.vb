﻿Option Strict On
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
            Dim EmailAttachment_FPath As String = ""
            Dim EmailAttachment_FPath2 As String = ""
            Dim CurStud As Student = GlobalVariables.StudentForEmail

            If (CurStud.Status = "Bridge") Then
                EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Bridged-Fall2018.docx")
                'set the body to read something about Bridged
                txtBody.Text = "Hello " + CurStud.First + " " + CurStud.Last + ", " + vbCrLf +
                    "We have reviewed your College of Business Major Application, and upon further Advisor review, you do not currently meet the requirements to be admitted to your degree program." + vbCrLf + "Please review the attachment for further instrucitons."

            ElseIf (CurStud.Status = "Admitted") Then
                If (CurStud.Majors.Contains("-")) Then
                    'this is a dual major, we need to attach two documents. One for the first 
                    While EmailAttachment_FPath2 = ""
                        If CurStud.Majors.Contains("Accounting (B.S.)") Then
                            'major is Accounting
                            If EmailAttachment_FPath = "" Then
                                EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-ACC.docx")
                            Else
                                EmailAttachment_FPath2 = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-ACC.docx")
                            End If
                        ElseIf CurStud.Majors.Contains("Accounting & Information Systems") Then
                            'major is Accounting & Information Systems
                            If EmailAttachment_FPath = "" Then
                                EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-ACC-IS.docx")
                            Else
                                EmailAttachment_FPath2 = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-ACC-IS.docx")
                            End If
                        ElseIf CurStud.Majors.Contains("Economics (B.A.)") Then
                            'major is economics ba
                            If EmailAttachment_FPath = "" Then
                                EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-ECON-BA.docx")
                            Else
                                EmailAttachment_FPath2 = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-ECON-BA.docx")
                            End If
                        ElseIf CurStud.Majors.Contains("Economics (B.S.)") Then
                            'major is economics bs
                            If EmailAttachment_FPath = "" Then
                                EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-ECON.docx")
                            Else
                                EmailAttachment_FPath2 = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-ECON.docx")
                            End If
                        ElseIf CurStud.Majors.Contains("Finance (B.S.)") Then
                            'major is finance
                            If EmailAttachment_FPath = "" Then
                                EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-FIN.docx")
                            Else
                                EmailAttachment_FPath2 = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-FIN.docx")
                            End If
                        ElseIf CurStud.Majors.Contains("General Business (B.S.)") Then
                            'major is General Business
                            If EmailAttachment_FPath = "" Then
                                EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-GB.docx")
                            Else
                                EmailAttachment_FPath2 = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-GB.docx")
                            End If
                        ElseIf CurStud.Majors.Contains("International Business (B.S.)") Then
                            'major is International Business
                            If EmailAttachment_FPath = "" Then
                                EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-IB.docx")
                            Else
                                EmailAttachment_FPath2 = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-IB.docx")
                            End If
                        ElseIf CurStud.Majors.Contains("Information Systems (B.S.)") Then
                            'major is Information systems
                            If EmailAttachment_FPath = "" Then
                                EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-IS.docx")
                            Else
                                EmailAttachment_FPath2 = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-IS.docx")
                            End If
                        ElseIf CurStud.Majors.Contains("Management (B.S.)") Then
                            'Major is Management
                            If EmailAttachment_FPath = "" Then
                                EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-MGT.docx")
                            Else
                                EmailAttachment_FPath2 = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-MGT.docx")
                            End If
                        ElseIf CurStud.Majors.Contains("Marketing (B.S.)") Then
                            'Major is Marketing
                            If EmailAttachment_FPath = "" Then
                                EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-MKT.docx")
                            Else
                                EmailAttachment_FPath2 = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-MKT.docx")
                            End If
                        End If
                    End While
                Else
                    If CurStud.Majors.Contains("Accounting (B.S.)") Then
                        EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-ACC.docx")

                    ElseIf CurStud.Majors.Contains("Accounting & Information Systems") Then
                        EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-ACC-IS.docx")

                    ElseIf CurStud.Majors.Contains("Economics (B.A.)") Then
                        EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-ECON-BA.docx")

                    ElseIf CurStud.Majors.Contains("Economics (B.S.)") Then
                        EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-ECON.docx")

                    ElseIf CurStud.Majors.Contains("Finance (B.S.)") Then
                        EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-FIN.docx")

                    ElseIf CurStud.Majors.Contains("General Business (B.S.)") Then
                        EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-GB.docx")

                    ElseIf CurStud.Majors.Contains("International Business (B.S.)") Then
                        EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-IB.docx")

                    ElseIf CurStud.Majors.Contains("Information Systems (B.S.)") Then
                        EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-IS.docx")

                    ElseIf CurStud.Majors.Contains("Management (B.S.)") Then
                        EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-MGT.docx")

                    ElseIf CurStud.Majors.Contains("Marketing (B.S.)") Then
                        EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-MKT.docx")

                    End If
                End If
            Else
                EmailAttachment_FPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Denied-Fall2018.docx")
                'Set the body to read somehting about Denied
                txtBody.Text = "Hello " + CurStud.First + " " + CurStud.Last + vbCrLf + "We have reviewed your Application to the Business Major within the UNR College of Business. Upon further Advisor review, we regret to inform you that you have not been admitted to your degree program, as you do not currently meet the admission criteria and/or or you are not an active student at the University." + vbCrLf + "Please see the emil attachment for more information"
            End If

            mail.Body = txtBody.Text
            mail.Attachments.Add(New Attachment(EmailAttachment_FPath))
            If EmailAttachment_FPath2 <> "" Then
                mail.Attachments.Add(New Attachment(EmailAttachment_FPath2))
            End If
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