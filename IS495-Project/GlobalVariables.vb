Option Strict On
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
    Public Shared Major As String = Nothing
    Public Shared EmailAttachment_FilePath As String = Nothing

    Public Shared StudentForEmail As Student = Nothing


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
        'Dim path As String = My.Application.Info.DirectoryPath
        Dim pdffile As String

        pdffile = Application.StartupPath.Replace("IS495-Project\bin\Debug", "IS495-Project\bin\Templates\Declaration_Change_of_Plan_Major.pdf")
        'pdffile = Application.StartupPath.Replace("Is495-Project\bin\Release", "IS495-Project\bin\Release\Templates\Declaration_Change_of_Plan_Major.pdf")

        PDF_FilePath = pdffile
    End Sub
    Public Shared ReadOnly Property GetPDF_FilePath() As String
        Get
            Return PDF_FilePath
        End Get
    End Property
    'Public Shared Sub SetEmailAttachment_FilePath()
    '    Dim emailPath As String
    '    If Major = "Accounting" And StudentStatus = "Admitted" Then
    '        emailPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-ACC.docx")
    '    ElseIf StudentStatus = "Admitted" Then
    '        emailPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Accepted-Fall2018.docx")
    '    ElseIf StudentStatus = "Bridged" Then
    '        emailPath = Application.StartupPath.Replace("IS495-Project\bin\Debug", "Templates\Bridged-Fall2018.docx")
    '    End If

    'End Sub
    'Public Shared ReadOnly Property GetEmailAttachment_FilePath() As String
    '    Get
    '        Return EmailAttachment_FilePath
    '    End Get
    'End Property

    Public Shared Function RemoveCommas(sParam As String) As String
        Dim Result As String
        Result = sParam
        Result = Replace(Result, ",", " - ")
        'The part below ensures any fields that have Nothing in them, will have an empty string
        If Result = Nothing Then
            Result = ""
        End If
        Return Result
    End Function
    'Put the Generic emails in ...\IS495-Project\IS495-Project\bin\Debug
    'Then pass the filename. It will return the filepath.
    Public Shared Function GetFilePath_ByFileName(argFileName As String) As String
        Dim path As String = My.Application.Info.DirectoryPath
        Dim FileName As String = argFileName
        Dim FullFilePath As String

        FullFilePath = IO.Path.Combine(path, FileName)

        Return FullFilePath
    End Function
End Class
