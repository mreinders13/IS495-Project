Public Class frmUsername
    Private Sub btnEntrySubmit_Click(sender As Object, e As EventArgs) Handles btnEntrySubmit.Click
        Dim SemesterCurr As String = txtCurrentSemester.Text

        GlobalVariables.SetCurrentSemester(SemesterCurr)
    End Sub
End Class