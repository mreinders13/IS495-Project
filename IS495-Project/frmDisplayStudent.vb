Option Strict On
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.xml
Imports System.IO

Public Class frmDisplayStudent
    'Create a List of all students 
    Dim studentList As New List(Of Student)
    'set counter to 1 before loop begins
    Dim Counter As Integer = 0

    'This is used to keep track of the count of decisions made.
    Dim Num_of_Dec_Made As Integer = 0

    '----------------------------------------------------------------------------------------------------------------
    'Start of Callable Methods.
    Public Sub RefreshStudentLabels(argCurrentStudent As Integer)
        Dim CurStud As Integer = argCurrentStudent

        lblName.Text = "Student Name: " + studentList(CurStud).First + " " + studentList(CurStud).Last
        lblNSHE.Text = "Student NSHE#: " + studentList(CurStud).NSHE
        lblGPA.Text = "Student GPA: " + studentList(CurStud).GPA
        'Check if there is a dual major or just one-------------------------
        If (studentList(CurStud).Majors.Contains(" - ")) Then
            lblMajor.Text = "Dual Major:" + vbCrLf + studentList(CurStud).Majors.Replace(" - ", vbCrLf)
        Else
            lblMajor.Text = "Student Major: " + vbCrLf + studentList(CurStud).Majors
        End If
        'End dual major check
        lblInternationalBusiness.Text = "International Business: " + studentList(CurStud).InternationalBusiness
        lblComments.Text = "Student Comments: " + studentList(CurStud).AdditionalInfo
        lblACC201.Text = "ACC201: " + studentList(CurStud).Acc201
        lblACC202.Text = "ACC202: " + studentList(CurStud).Acc202
        lblECON102.Text = "ECON102: " + studentList(CurStud).Econ102
        lblECON103.Text = "ECON103: " + studentList(CurStud).Econ103
        lblECON261.Text = "ECON261: " + studentList(CurStud).Econ261
        lblECON262.Text = "ECON262: " + studentList(CurStud).Econ262
        lblIS101.Text = "IS101: " + studentList(CurStud).IS101
        lblMATH176.Text = "MATH176: " + studentList(CurStud).Math176
        lblMKT210.Text = "MKT210: " + studentList(CurStud).Mkt210
        txtAdvisorNotes.Text = studentList(CurStud).AdvisorNotes

        lblDecision.Text = "Decision: " + studentList(CurStud).Status
        lblReviewedBy.Text = "Reviewed By: " + studentList(CurStud).Username
        lblReviewDate.Text = "Review Date: " + studentList(CurStud).DecisionTimeStamp
        lblMajorFormSigned.Text = "Major Form Signed: " + studentList(CurStud).MajorFormedSigned
        lblBridgePermission.Text = "Bridge Permission Granted" + studentList(CurStud).BridgePermission


        GlobalVariables.StudentEmail = studentList(CurStud).Email
        GlobalVariables.Major = studentList(CurStud).Majors
    End Sub

    Public Sub SetStudentStatus(argStatus As String)
        If studentList(Counter).Status = "" Then
            Num_of_Dec_Made += 1
        End If
        studentList(Counter).Status = argStatus
        studentList(Counter).Semester = GlobalVariables.CurrentSemester
        studentList(Counter).Username = GlobalVariables.CurrentUsername
        studentList(Counter).DecisionTimeStamp = System.DateTime.Now.ToShortDateString()

        RefreshStudentLabels(Counter)
        CheckIfAllDecisionsMade()
    End Sub
    'I Think it might be a good idea to get rid of lblDecisionMade and also this DecisionMadeMessage() Function
    Public Function DecisionMadeMessage(argCurrentStudent As Integer) As String
        Dim CurStud As Student = studentList(argCurrentStudent)
        Dim Message As String

        Message = "This Decision has already been made by " + CurStud.Username + " for " + CurStud.Semester +
            ControlChars.NewLine + CurStud.First + " " + CurStud.Last + " was " + CurStud.Status + "."

        Return Message
    End Function

    Public Sub MADE_StatusSettings()
        btnAccept.Enabled = False
        btnBridge.Enabled = False
        btnDeny.Enabled = False
        'lblDecisionMade.Visible = True
        btnPrintPDF.Enabled = True
    End Sub

    Public Sub UNMADE_StatusSettings()
        btnAccept.Enabled = True
        btnDeny.Enabled = True
        btnBridge.Enabled = True
        'lblDecisionMade.Visible = False
        btnPrintPDF.Enabled = False
    End Sub
    Public Sub CheckIfAllDecisionsMade()
        If Num_of_Dec_Made = studentList.Count - 1 Then
            Dim result As Integer
            result = MessageBox.Show(
                text:="All students have been given a status. Would you like to export the data?",
                buttons:=MessageBoxButtons.YesNo,
                caption:="All student Decisions completed.")

            If (result = DialogResult.Yes) Then
                ExportData_Method()
            ElseIf (result = DialogResult.No) Then
                btnExportData.Visible = True
            End If
        End If
    End Sub

    Public Sub ExportData_Method()
        'view save dialog
        Dim result As DialogResult = SaveFileDialog.ShowDialog()
        'check filepath to save to. If user doesnt specify .csv, save as .csv 
        If result = Windows.Forms.DialogResult.OK Then
            Dim csvFile As String = SaveFileDialog.FileName
            Dim Extension As String = Path.GetExtension(csvFile)
            If (Extension <> ".csv") Then
                csvFile = csvFile + ".csv"
            End If

            Dim saveCounter As Integer = 0

            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)
            While saveCounter < studentList.Count
                Dim CurStud = studentList(saveCounter)
                outFile.WriteLine(
                    CurStud.Username + "," +
                    CurStud.DecisionTimeStamp + "," +
                    CurStud.Status + "," +
                    CurStud.BridgePermission + "," +
                    CurStud.MajorFormedSigned + "," +
                    CurStud.AdvisorNotes + "," +
                    CurStud.First + "," +
                    CurStud.Last + "," +
                    CurStud.NSHE + "," +
                    CurStud.Phone + "," +
                    CurStud.Email + "," +
                    CurStud.AppDate + "," +
                    CurStud.Majors + ",")
                saveCounter += 1
            End While
            outFile.Close()

            Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MessageBox.Show("Exported Successful")
            Application.Exit()
        End If
    End Sub

    'End of Callable Methods.
    '----------------------------------------------------------------------------------------------------------------

    Private Sub btnPrevStudent_Click(sender As Object, e As EventArgs) Handles btnPrevStudent.Click
        'Could create code that checks if a checkmark is checked on first page to Display Students without decision only. Skips the Students with decision var not equal to nothing
        'load the previous student 
        If (Counter - 1) > 0 Then
            Counter = Counter - 1

            RefreshStudentLabels(Counter)

            'Check if a Decision has already been made and Set Buttons/Labels Accordingly
            If (studentList(Counter).Status <> "") Then
                MADE_StatusSettings()
                If (studentList(Counter).Status = "Not Admitted") Then
                    btnPrintPDF.Enabled = False
                End If
                'lblDecisionMade.Text = DecisionMadeMessage(Counter)
            Else
                UNMADE_StatusSettings()
            End If

        Else
            MessageBox.Show("This is the beginning of the list")
        End If
    End Sub

    Private Sub btnNextStudent_Click(sender As Object, e As EventArgs) Handles btnNextStudent.Click
        'load the next student
        If (Counter + 1) < studentList.Count Then
            Counter = Counter + 1

            RefreshStudentLabels(Counter)

            'Check if a Decision has already been made and Set Buttons/Labels Accordingly
            If (studentList(Counter).Status.ToString() <> "") Then
                MADE_StatusSettings()
                If (studentList(Counter).Status = "Not Admitted") Then
                    btnPrintPDF.Enabled = False
                End If
                'lblDecisionMade.Text = DecisionMadeMessage(Counter)
            Else
                UNMADE_StatusSettings()
            End If

        Else
            MessageBox.Show("End of List")
        End If
    End Sub

    Private Sub btnSaveData_Click(sender As Object, e As EventArgs) Handles btnSaveData.Click
        'view save dialog
        Dim result As DialogResult = SaveFileDialog.ShowDialog()
        'check filepath to save to. If user doesnt specify .csv, save as .csv 
        If result = Windows.Forms.DialogResult.OK Then
            Dim csvFile As String = SaveFileDialog.FileName
            Dim Extension As String = Path.GetExtension(csvFile)
            If (Extension <> ".csv") Then
                csvFile = csvFile + ".csv"
            End If

            Dim saveCounter As Integer = 0

            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)
            While saveCounter < studentList.Count
                outFile.WriteLine(studentList(saveCounter).Time.ToString() + "," + studentList(saveCounter).First.ToString() + "," + studentList(saveCounter).Last.ToString() + "," + studentList(saveCounter).NSHE.ToString() + "," + studentList(saveCounter).Phone.ToString() + "," + studentList(saveCounter).Email.ToString() + "," + studentList(saveCounter).Majors.ToString() + "," + studentList(saveCounter).InternationalBusiness.ToString() + "," + studentList(saveCounter).Regional.ToString() + "," + studentList(saveCounter).Acc201.ToString() + "," + studentList(saveCounter).Acc202.ToString() + "," + studentList(saveCounter).Econ102.ToString() + "," + studentList(saveCounter).Econ103.ToString() + "," + studentList(saveCounter).Econ261.ToString() + "," + studentList(saveCounter).Econ262.ToString() + "," + studentList(saveCounter).IS101.ToString() + "," + studentList(saveCounter).Math176.ToString() + "," + studentList(saveCounter).Mkt210.ToString() + "," + studentList(saveCounter).Econ102_2.ToString() + "," + studentList(saveCounter).Econ103_2.ToString() + "," + studentList(saveCounter).Econ261_2.ToString() + "," + studentList(saveCounter).Econ262_2.ToString() + "," + studentList(saveCounter).IS101_2.ToString() + "," + studentList(saveCounter).Math176_2.ToString() + "," + studentList(saveCounter).ToBeCompleted.ToString() + "," + studentList(saveCounter).GPA.ToString() + "," + studentList(saveCounter).AdditionalInfo.ToString() + "," + studentList(saveCounter).OtherInstitutions.ToString() + "," + studentList(saveCounter).TranscriptsSubmitted.ToString() + "," + studentList(saveCounter).TranscriptsUploaded.ToString() + "," + studentList(saveCounter).DeclarationDay.ToString() + "," + studentList(saveCounter).DeclarationDayConflicts.ToString() + "," + studentList(saveCounter).EmailConfirmation.ToString() + "," + studentList(saveCounter).Understand.ToString() + "," + studentList(saveCounter).FalseInfo.ToString() + "," + studentList(saveCounter).ChangeMajorPDF.ToString() + "," + studentList(saveCounter).Signature.ToString() + "," + studentList(saveCounter).AppDate.ToString() + "," + studentList(saveCounter).Browser.ToString() + "," + studentList(saveCounter).ipAddress.ToString() + "," + studentList(saveCounter).UniqueID.ToString() + "," + studentList(saveCounter).Location.ToString() + "," + studentList(saveCounter).Status.ToString() + "," + studentList(saveCounter).Semester.ToString() + "," + studentList(saveCounter).Username.ToString() + "," + studentList(saveCounter).AdvisorNotes.ToString() + "," + studentList(saveCounter).DecisionTimeStamp.ToString() + "," + studentList(saveCounter).MajorFormedSigned + "," + studentList(saveCounter).BridgePermission)
                saveCounter += 1
            End While
            outFile.Close()

            Console.WriteLine(My.Computer.FileSystem.ReadAllText(csvFile))
            MessageBox.Show("Save Successful")
            Application.Exit()
        End If
    End Sub

    Private Sub frmDisplayStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loop for reading csv 
        Try
            Using MyReader As New Microsoft.VisualBasic.
                    FileIO.TextFieldParser(
                      GlobalVariables.SourceFilePath)
                MyReader.TextFieldType = FileIO.FieldType.Delimited
                MyReader.SetDelimiters(",")

                Dim currentRow As String()

                While Not MyReader.EndOfData
                    Try
                        currentRow = MyReader.ReadFields()
                        Dim currentField As String
                        Dim Constructor_List As New List(Of String)

                        'Stores each cell in Constructor_List.
                        Dim i = 0
                        For Each currentField In currentRow
                            Constructor_List.Insert(i, GlobalVariables.RemoveCommas(currentField))
                            i += 1
                        Next

                        'This ensures there there are 49 strings in Constructor_List.
                        Do While (Constructor_List.Count < 49)
                            Constructor_List.Add("")
                        Loop

                        'This "New Student()" will only work if there are 49 string in Constructor_List.
                        studentList.Add(New Student(
                                        time:=Constructor_List(0),
                                        first:=Constructor_List(1),
                                        last:=Constructor_List(2),
                                        nSHE:=Constructor_List(3),
                                        phone:=Constructor_List(4),
                                        email:=Constructor_List(5),
                                        majors:=Constructor_List(6),
                                        internationalBusiness:=Constructor_List(7),
                                        regional:=Constructor_List(8),
                                        acc201:=Constructor_List(9),
                                        acc202:=Constructor_List(10),
                                        econ102:=Constructor_List(11),
                                        econ103:=Constructor_List(12),
                                        econ261:=Constructor_List(13),
                                        econ262:=Constructor_List(14),
                                        iS101:=Constructor_List(15),
                                        math176:=Constructor_List(16),
                                        mkt210:=Constructor_List(17),
                                        econ102_2:=Constructor_List(18),
                                        econ103_2:=Constructor_List(19),
                                        econ261_2:=Constructor_List(20),
                                        econ262_2:=Constructor_List(21),
                                        iS101_2:=Constructor_List(22),
                                        math176_2:=Constructor_List(23),
                                        toBeCompleted:=Constructor_List(24),
                                        gPA:=Constructor_List(25),
                                        additionalInfo:=Constructor_List(26),
                                        otherInstitutions:=Constructor_List(27),
                                        transcriptsSubmitted:=Constructor_List(28),
                                        transcriptsUploaded:=Constructor_List(29),
                                        declarationDay:=Constructor_List(30),
                                        declarationDayConflicts:=Constructor_List(31),
                                        emailConfirmation:=Constructor_List(32),
                                        understand:=Constructor_List(33),
                                        falseInfo:=Constructor_List(34),
                                        changeMajorPDF:=Constructor_List(35),
                                        signature:=Constructor_List(36),
                                        appDate:=Constructor_List(37),
                                        browser:=Constructor_List(38),
                                        ipAddress:=Constructor_List(39),
                                        uniqueID:=Constructor_List(40),
                                        location:=Constructor_List(41),
                                        status:=Constructor_List(42),
                                        semester:=Constructor_List(43),
                                        username:=Constructor_List(44),
                                        advisorNotes:=Constructor_List(45),
                                        DecisionTimeStamp:=Constructor_List(46),
                                        majorFormSigned:=Constructor_List(47),
                                        bridgePermission:=Constructor_List(48)))

                        'If a decision is made, then increment Num_of_Dec_Made
                        If (Constructor_List(42) <> "" And Constructor_List(42) <> "Decision") Then
                            Num_of_Dec_Made += 1
                        End If

                    Catch ex As Microsoft.VisualBasic.
                                FileIO.MalformedLineException
                        MsgBox("Line " & ex.Message &
                        "is not valid and will be skipped.")
                    End Try
                End While
            End Using
            ' For debugging.
            Me.Text = Text.Length.ToString

        Catch ex As Exception

            ' Report an error.
            Me.Text = "Error"

        End Try

        '***We could/should create an if statement to check if the first variables are column names or actual data
        If (studentList(Counter).Time = "Time") Then
            'studentList(Counter).Username = "Reviewed By"
            'studentList(Counter).DecisionTimeStamp = "Review Date"
            'studentList(Counter).Status = "Decision"
            'studentList(Counter).BridgePermission = "Bridge Permission Granted"
            'studentList(Counter).MajorFormedSigned = "Major Form Signed"
            'studentList(Counter).AdvisorNotes = "Advisor Notes"
            'studentList(Counter).Semester = "Semester"

            Counter += 1
        End If

        'Load values into the labels on the form
        RefreshStudentLabels(Counter)

        'May be able to create an if statement that checks if status has a value. 
        'If so Then the accept/deny/bridge buttons could be disabled??
        If (studentList(Counter).Status <> "") Then
            MADE_StatusSettings()
            If (studentList(Counter).Status = "Not Admitted") Then
                btnPrintPDF.Enabled = False
            End If
            'lblDecisionMade.Text = DecisionMadeMessage(Counter)
        Else
            UNMADE_StatusSettings()
        End If
        btnExportData.Visible = False
        CheckIfAllDecisionsMade()
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        'Save Accept decision
        SetStudentStatus("Admitted")
        btnPrintPDF.Enabled = True
        'GlobalVariables.StudentStatus = "Accepted"
    End Sub

    Private Sub btnBridge_Click(sender As Object, e As EventArgs) Handles btnBridge.Click
        'Save Bridge Decision
        SetStudentStatus("Bridge")
        btnPrintPDF.Enabled = True
        'GlobalVariables.StudentStatus = "Bridged"
    End Sub

    Private Sub btnDeny_Click(sender As Object, e As EventArgs) Handles btnDeny.Click
        'Save Deny Decision 
        SetStudentStatus("Not Admitted")
        btnPrintPDF.Enabled = False
        'GlobalVariables.StudentStatus = "Denied"
    End Sub

    Private Sub btnPrintPDF_Click(sender As Object, e As EventArgs) Handles btnPrintPDF.Click
        GlobalVariables.SetPDF_FilePath()
        Dim PDF_FilePath = GlobalVariables.GetPDF_FilePath
        'Get the student submitted pdf provided by the data
        Dim submittedPDF As String = studentList(Counter).ChangeMajorPDF
        'get the file extension to check in if statment 
        Dim Extension As String = Path.GetExtension(submittedPDF)
        If (Extension = ".pdf") Then
            'check for dual major
            If studentList(Counter).Majors.Contains("-") Then
                'The student is requesting a dual major

                If studentList(Counter).Majors.Contains("Accounting") Then
                    'check for accounting major as one of the majors
                    MessageBox.Show("This is a Accounting and something else double major")
                    'Conditions to create two seperate PDF's
                End If
            Else
                'Not a Dual Major
            End If
            'To See File Path
            MessageBox.Show(text:="This is a valid PDF File Path: " + submittedPDF, caption:="PDF Filepath Valid")
            'To Test File Path
            'Process.Start(PDF_FilePath)
            'Print the file
            Dim PrintPDF As New ProcessStartInfo
            '--------------Automatially Open for review if pdf correct----------------------
            PrintPDF.UseShellExecute = True
            PrintPDF.Verb = "OPEN"
            PrintPDF.WindowStyle = ProcessWindowStyle.Hidden
            PrintPDF.FileName = submittedPDF 'fileName is a string parameter
            Process.Start(PrintPDF)

        Else
            If studentList(Counter).Majors.Contains("-") Then
                'check for accounting major in dual major
                If studentList(Counter).Majors.Contains("Accounting") Then
                    MessageBox.Show("This is a Accounting and something else double major")
                End If
            End If
            Dim signature As String = studentList(Counter).Signature
            'To See File Path
            MessageBox.Show("A generated PDF will open in Adobe." & vbCrLf & "Please import the signature found in the following file location: " + signature.ToString())

            'Open ofdSignature so the user can choose the correct signatiure to upload, then set the StudentList.Signarure variable to the OFD result
            'ofdSignature.ShowDialog()
            'Dim SignatureResult As String = ofdSignature.FileName
            'studentList(Counter).Signature = SignatureResult

            'User opens SFD to select where they wish to save the PDF
            sfdSavePDF.ShowDialog()
            Dim newFile As String
            Dim extNewFile As String
            newFile = sfdSavePDF.FileName
            extNewFile = Path.GetExtension(newFile)
            'add pdf extension if the user doesnt
            If (extNewFile <> ".pdf") Then
                newFile = sfdSavePDF.FileName + ".pdf"
            End If

            '-----------------------------Auto-Populate the PDF with Students information-------------------------------------------------
            'set ofd and svd variables
            Dim pdfTemplate As String = GlobalVariables.PDF_FilePath


            'set PdfReader and PdfStamper from iTextSharp
            Dim pdfReader As New PdfReader(pdfTemplate)
            Dim pdfStamper As New PdfStamper(pdfReader, New FileStream(newFile, FileMode.Create))

            'Setup pdf fields variables
            Dim pdfFormFields As AcroFields = pdfStamper.AcroFields
            pdfFormFields.SetField("Name", studentList(Counter).First + " " + studentList(Counter).Last)
            pdfFormFields.SetField("NSHE", studentList(Counter).NSHE)
            pdfFormFields.SetField("StudentSignature", signature)
            pdfFormFields.SetField("Date", studentList(Counter).AppDate)
            pdfFormFields.SetField("StudentAthlete", "studentList(Counter).athelete")
            pdfFormFields.SetField("Change", "No")
            pdfFormFields.SetField("Add", "Yes")
            pdfFormFields.SetField("Remove", "No")
            pdfFormFields.SetField("PlanRequested", studentList(Counter).Majors)
            pdfFormFields.SetField("CatelogYear", studentList(Counter).Semester)
            pdfFormFields.SetField("Subplan", "N/A")
            pdfFormFields.SetField("NewAdvisor", "N/A")
            pdfFormFields.SetField("AdvisorDateSigned", System.DateTime.Today.ToString())
            pdfFormFields.SetField("Approved", "Yes")
            pdfFormFields.SetField("Denied", "No")
            pdfFormFields.SetField("Evaluator", studentList(Counter).Username)
            pdfFormFields.SetField("EvaluationDate", studentList(Counter).DecisionTimeStamp)

            pdfStamper.FormFlattening = False

            ' close the pdf
            pdfStamper.Close()

            'Open File in Adobe for User to import Signature, review and Print
            Dim PrintPDF As New ProcessStartInfo

            PrintPDF.UseShellExecute = True
            PrintPDF.Verb = "OPEN"
            PrintPDF.WindowStyle = ProcessWindowStyle.Hidden
            PrintPDF.FileName = newFile 'fileName is a string parameter
            Process.Start(PrintPDF)

        End If
    End Sub

    Private Sub txtAdvisorNotes_TextChanged(sender As Object, e As EventArgs) Handles txtAdvisorNotes.TextChanged
        studentList(Counter).AdvisorNotes = txtAdvisorNotes.Text
    End Sub

    Private Sub btnExportData_Click(sender As Object, e As EventArgs) Handles btnExportData.Click
        ExportData_Method()
    End Sub

    Private Sub btnEmailStudent_Click(sender As Object, e As EventArgs) Handles btnEmailStudent.Click
        frmEmail.txtTo.Text = GlobalVariables.StudentEmail
        'GlobalVariables.SetEmailAttachment_FilePath()

        GlobalVariables.StudentForEmail = studentList(Counter)
        If GlobalVariables.EmailLogin = Nothing Then
            frmEmailLogin.Show()
        Else
            frmEmail.Show()
        End If
    End Sub

End Class
