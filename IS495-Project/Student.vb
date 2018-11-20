Public Class Student
    Public Time As String
    Public First As String
    Public Last As String
    Public NSHE As String
    Public Phone As String
    Public Email As String
    Public Majors As String
    Public InternationalBusiness As String
    Public Regional As String
    Public Acc201 As String
    Public Acc202 As String
    Public Econ102 As String
    Public Econ103 As String
    Public Econ261 As String
    Public Econ262 As String
    Public IS101 As String
    Public Math176 As String
    Public Mkt210 As String
    Public Econ102_2 As String
    Public Econ103_2 As String
    Public Econ261_2 As String
    Public Econ262_2 As String
    Public IS101_2 As String
    Public Math176_2 As String
    Public ToBeCompleted As String
    Public GPA As String
    Public AdditionalInfo As String
    Public OtherInstitutions As String
    Public TranscriptsSubmitted As String
    Public TranscriptsUploaded As String
    Public DeclarationDay As String
    Public DeclarationDayConflicts As String
    Public EmailConfirmation As String
    Public Understand As String
    Public FalseInfo As String
    Public ChangeMajorPDF As String
    Public Signature As String
    Public AppDate As String
    Public Browser As String
    Public ipAddress As String
    Public UniqueID As String
    Public Location As String
    Public Status As String
    Public Semester As String
    Public Username As String
    Public AdvisorNotes As String

    Public Sub New(time As String, first As String, last As String, nSHE As String, phone As String, email As String, majors As String, internationalBusiness As String, regional As String, acc201 As String, acc202 As String, econ102 As String, econ103 As String, econ261 As String, econ262 As String, iS101 As String, math176 As String, mkt210 As String, econ102_2 As String, econ103_2 As String, econ261_2 As String, econ262_2 As String, iS101_2 As String, math176_2 As String, toBeCompleted As String, gPA As String, additionalInfo As String, otherInstitutions As String, transcriptsSubmitted As String, transcriptsUploaded As String, declarationDay As String, declarationDayConflicts As String, emailConfirmation As String, understand As String, falseInfo As String, changeMajorPDF As String, signature As String, appDate As String, browser As String, ipAddress As String, uniqueID As String, location As String, Optional status As String = "", Optional semester As String = "", Optional username As String = "", Optional AdvisorNotes As String = "")
        Me.Time = time
        Me.First = first
        Me.Last = last
        Me.NSHE = nSHE
        Me.Phone = phone
        Me.Email = email
        Me.Majors = majors
        Me.InternationalBusiness = internationalBusiness
        Me.Regional = regional
        Me.Acc201 = acc201
        Me.Acc202 = acc202
        Me.Econ102 = econ102
        Me.Econ103 = econ103
        Me.Econ261 = econ261
        Me.Econ262 = econ262
        Me.IS101 = iS101
        Me.Math176 = math176
        Me.Mkt210 = mkt210
        Me.Econ102_2 = econ102_2
        Me.Econ103_2 = econ103_2
        Me.Econ261_2 = econ261_2
        Me.Econ262_2 = econ262_2
        Me.IS101_2 = iS101_2
        Me.Math176_2 = math176_2
        Me.ToBeCompleted = toBeCompleted
        Me.GPA = gPA
        Me.AdditionalInfo = additionalInfo
        Me.OtherInstitutions = otherInstitutions
        Me.TranscriptsSubmitted = transcriptsSubmitted
        Me.TranscriptsUploaded = transcriptsUploaded
        Me.DeclarationDay = declarationDay
        Me.DeclarationDayConflicts = declarationDayConflicts
        Me.EmailConfirmation = emailConfirmation
        Me.Understand = understand
        Me.FalseInfo = falseInfo
        Me.ChangeMajorPDF = changeMajorPDF
        Me.Signature = signature
        Me.AppDate = appDate
        Me.Browser = browser
        Me.ipAddress = ipAddress
        Me.UniqueID = uniqueID
        Me.Location = location
        Me.Status = status
        Me.Semester = semester
        Me.Username = username
        Me.AdvisorNotes = AdvisorNotes
    End Sub
End Class
