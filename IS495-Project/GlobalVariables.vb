Public Class GlobalVariables
    Public Shared CurrentSemester As String = Nothing
    Public Shared SourceFilePath As String = Nothing
    Public Shared CurrentUsername As String = Nothing
    Public Shared StudentStatus As String = Nothing
    Public Shared EmailStatus As String = Nothing
    Public Shared StudentEmail As String = Nothing
    Public Shared EmailLogin As String = Nothing
    Public Shared EmailPassword As String = Nothing

    Public Shared PDF_FilePath As String = Nothing


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

    'Username stuff (Task 1.0)
    Public Shared Sub SetCurrentUsername(argCurrentUsername As String)
        CurrentUsername = argCurrentUsername
    End Sub

    Public Shared ReadOnly Property GetCurrentUsername() As String
        Get
            Return CurrentUsername
        End Get
    End Property

    Public Shared Sub SetPDF_FilePath()
        Dim path As String = My.Application.Info.DirectoryPath
        Dim pdffile As String

        pdffile = IO.Path.Combine(path, "Declaration_Change_of_Plan_Major.pdf")

        PDF_FilePath = pdffile
    End Sub

    Public Shared ReadOnly Property GetPDF_FilePath() As String
        Get
            Return PDF_FilePath
        End Get
    End Property

    Public Shared Function RemoveCommas(sParam As String)
        Dim Result As String
        Result = sParam
        Result = Replace(Result, ",", " - ")
        'The part below ensures any fields that have Nothing in them, will have an empty string
        If Result = Nothing Then
            Result = ""
        End If
        Return Result
    End Function
End Class
