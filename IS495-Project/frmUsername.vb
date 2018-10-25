Public Class frmUsername
    Private Sub btnEntrySubmit_Click(sender As Object, e As EventArgs) Handles btnEntrySubmit.Click
        If GlobalVariables.GetSourceFilePath IsNot Nothing Then
            Dim Semester As String = txtCurrentSemester.Text

            GlobalVariables.SetCurrentSemester(Semester)

            If GlobalVariables.GetCurrentSemester <> "" Then
                Dim Username As String = txtUsername.Text

                GlobalVariables.SetCurrentUsername(Username)

                If GlobalVariables.GetCurrentUsername <> "" Then
                    Dim frm2 = New frmDisplayStudent
                    frm2.Show()
                Else
                    MessageBox.Show("Please provide username.")
                End If
            Else
                MessageBox.Show("Please provide the semester that you will be working with.")
            End If
        Else
            MessageBox.Show("Please select the file you will be working with.")
        End If
    End Sub

    Private Sub btnOpenFileDialog_Click(sender As Object, e As EventArgs) Handles btnOpenFileDialog.Click
        Dim Result As DialogResult = ofdOpenFile.ShowDialog()

        If Result = Windows.Forms.DialogResult.OK Then
            Dim FilePath As String = ofdOpenFile.FileName

            GlobalVariables.SetSourceFilePath(FilePath)

            lblFilePath_Prompt.Text = System.Convert.ToString(GlobalVariables.GetSourceFilePath)
        End If
    End Sub
End Class