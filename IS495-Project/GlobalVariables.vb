Public Class GlobalVariables
    Public Shared CurrentSemester As String = Nothing
    Public Shared SourceFilePath As String = Nothing

    Private Sub New()
    End Sub

    'Semester Stuff (Task 2.0)
    Public Shared ReadOnly Property GetCurrentSemester() As String
        Get
            Return CurrentSemester
        End Get
    End Property

    Public Shared Sub SetCurrentSemester(argCurrentSemester As String)
        CurrentSemester = argCurrentSemester
    End Sub

    'File Path stuff (Task 3.0)
    Public Shared ReadOnly Property GetSourceFilePath() As String
        Get
            Return SourceFilePath
        End Get
    End Property

    Public Shared Sub SetSourceFilePath(argSourceFilePath As String)
        SourceFilePath = argSourceFilePath
    End Sub
End Class
