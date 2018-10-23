Public Class GlobalVariables
    Public Shared CurrentSemester As String = Nothing
    Private Sub New()
    End Sub

    Public Shared ReadOnly Property GetCurrentSemester() As String
        Get
            Return CurrentSemester
        End Get
    End Property

    Public Shared Sub SetCurrentSemester(argCurrentSemester As String)
        CurrentSemester = argCurrentSemester
    End Sub
End Class
