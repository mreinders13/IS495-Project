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
    Dim Counter As Int16 = 0
    'status variables
    'Dim Status, Accepted, Denied, Bridged As String
    'Dim DecisionAccept, DecisionDeny, DecisionBridge As Boolean


    'I had something more like this in mind to keep track of the status. (Steven)
    'Public Enum Status
    '    Accepted
    '    Denied
    '    Bridged
    'End Enum

    'We should include the comments that students give in the interface.
    'I remember the Client saying he only needed to see the FullName, NSHEID, and Comments.

    Private Sub btnPrevStudent_Click(sender As Object, e As EventArgs) Handles btnPrevStudent.Click
        'Could create code that checks if a checkmark is checked on first page to Display Students without decision only. Skips the Students with decision var not equal to nothing
        'load the previous student 
        If (Counter - 1) > 0 Then
            Counter = Counter - 1
            lblName.Text = "Student Name: " + studentList(Counter).First + " " + studentList(Counter).Last
            lblNSHE.Text = "Student NSHE#: " + studentList(Counter).NSHE
            lblGPA.Text = "Student GPA: " + studentList(Counter).GPA
            lblMajor.Text = "Student Major: " + studentList(Counter).Majors
            lblInternationalBusiness.Text = "International Business: " + studentList(Counter).InternationalBusiness
            lblComments.Text = "Student Comments: " + studentList(Counter).AdditionalInfo
            lblACC201.Text = "ACC201: " + studentList(Counter).Acc201
            lblACC202.Text = "ACC202: " + studentList(Counter).Acc202
            lblECON102.Text = "ECON102: " + studentList(Counter).Econ102
            lblECON103.Text = "ECON103: " + studentList(Counter).Econ103
            lblECON261.Text = "ECON261: " + studentList(Counter).Econ261
            lblECON262.Text = "ECON262: " + studentList(Counter).Econ262
            lblIS101.Text = "IS101: " + studentList(Counter).IS101
            lblMATH176.Text = "MATH176: " + studentList(Counter).Math176
            lblMKT210.Text = "MKT210: " + studentList(Counter).Mkt210
            'Check if a Decision has already been made and Set Buttons/Labels Accordingly
            If (studentList(Counter).Status.ToString() <> "") Then
                btnAccept.Enabled = False
                btnBridge.Enabled = False
                btnDeny.Enabled = False
                lblDecisionMade.Visible = True
                lblDecisionMade.Text = "This Decision has already been made by " + studentList(Counter).Username + " for " + studentList(Counter).Semester
            Else
                btnAccept.Enabled = True
                btnDeny.Enabled = True
                btnBridge.Enabled = True
                lblDecisionMade.Visible = False
            End If

        Else
            MessageBox.Show("This is the beginning of the list")

        End If
    End Sub

    Private Sub btnNextStudent_Click(sender As Object, e As EventArgs) Handles btnNextStudent.Click
        'load the next student
        If (Counter + 1) < studentList.Count Then
            Counter = Counter + 1
            lblName.Text = "Student Name: " + studentList(Counter).First + " " + studentList(Counter).Last
            lblNSHE.Text = "Student NSHE#: " + studentList(Counter).NSHE
            lblGPA.Text = "Student GPA: " + studentList(Counter).GPA
            lblMajor.Text = "Student Major: " + studentList(Counter).Majors
            lblInternationalBusiness.Text = "International Business: " + studentList(Counter).InternationalBusiness
            lblComments.Text = "Student Comments: " + studentList(Counter).AdditionalInfo
            lblACC201.Text = "ACC201: " + studentList(Counter).Acc201
            lblACC202.Text = "ACC202: " + studentList(Counter).Acc202
            lblECON102.Text = "ECON102: " + studentList(Counter).Econ102
            lblECON103.Text = "ECON103: " + studentList(Counter).Econ103
            lblECON261.Text = "ECON261: " + studentList(Counter).Econ261
            lblECON262.Text = "ECON262: " + studentList(Counter).Econ262
            lblIS101.Text = "IS101: " + studentList(Counter).IS101
            lblMATH176.Text = "MATH176: " + studentList(Counter).Math176
            lblMKT210.Text = "MKT210: " + studentList(Counter).Mkt210
            'Check if a Decision has already been made and Set Buttons/Labels Accordingly
            If (studentList(Counter).Status.ToString() <> "") Then
                btnAccept.Enabled = False
                btnBridge.Enabled = False
                btnDeny.Enabled = False
                lblDecisionMade.Visible = True
                btnPrintPDF.Enabled = True
                lblDecisionMade.Text = "This Decision has already been made by " + studentList(Counter).Username + " for " + studentList(Counter).Semester
            Else
                btnAccept.Enabled = True
                btnDeny.Enabled = True
                btnBridge.Enabled = True
                lblDecisionMade.Visible = False
                btnPrintPDF.Enabled = False
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

            Dim saveCounter As Int16 = 0

            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)
            While saveCounter < studentList.Count
                outFile.WriteLine(studentList(saveCounter).Time.ToString() + "," + studentList(saveCounter).First.ToString() + "," + studentList(saveCounter).Last.ToString() + "," + studentList(saveCounter).NSHE.ToString() + "," + studentList(saveCounter).Phone.ToString() + "," + studentList(saveCounter).Email.ToString() + "," + studentList(saveCounter).Majors.ToString() + "," + studentList(saveCounter).InternationalBusiness.ToString() + "," + studentList(saveCounter).Regional.ToString() + "," + studentList(saveCounter).Acc201.ToString() + "," + studentList(saveCounter).Acc202.ToString() + "," + studentList(saveCounter).Econ102.ToString() + "," + studentList(saveCounter).Econ103.ToString() + "," + studentList(saveCounter).Econ261.ToString() + "," + studentList(saveCounter).Econ262.ToString() + "," + studentList(saveCounter).IS101.ToString() + "," + studentList(saveCounter).Math176.ToString() + "," + studentList(saveCounter).Mkt210.ToString() + "," + studentList(saveCounter).Econ102_2.ToString() + "," + studentList(saveCounter).Econ103_2.ToString() + "," + studentList(saveCounter).Econ261_2.ToString() + "," + studentList(saveCounter).Econ262_2.ToString() + "," + studentList(saveCounter).IS101_2.ToString() + "," + studentList(saveCounter).Math176_2.ToString() + "," + studentList(saveCounter).ToBeCompleted.ToString() + "," + studentList(saveCounter).GPA.ToString() + "," + studentList(saveCounter).AdditionalInfo.ToString() + "," + studentList(saveCounter).OtherInstitutions.ToString() + "," + studentList(saveCounter).TranscriptsSubmitted.ToString() + "," + studentList(saveCounter).TranscriptsUploaded.ToString() + "," + studentList(saveCounter).DeclarationDay.ToString() + "," + studentList(saveCounter).DeclarationDayConflicts.ToString() + "," + studentList(saveCounter).EmailConfirmation.ToString() + "," + studentList(saveCounter).Understand.ToString() + "," + studentList(saveCounter).FalseInfo.ToString() + "," + studentList(saveCounter).ChangeMajorPDF.ToString() + "," + studentList(saveCounter).Signature.ToString() + "," + studentList(saveCounter).AppDate.ToString() + "," + studentList(saveCounter).Browser.ToString() + "," + studentList(saveCounter).ipAddress.ToString() + "," + studentList(saveCounter).UniqueID.ToString() + "," + studentList(saveCounter).Location.ToString() + "," + studentList(saveCounter).Status.ToString() + "," + studentList(saveCounter).Semester.ToString() + "," + studentList(saveCounter).Username.ToString())
                saveCounter = saveCounter + 1
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
                        Dim var1, var2, var3, var4, var5, var6, var7, var8, var9, var10, var11, var12, var13, var14, var15, var16, var17,
                            var18, var19, var20, var21, var22, var23, var24, var25, var26, var27, var28, var29, var30, var31, var32,
                            var33, var34, var35, var36, var37, var38, var39, var40, var41, var42, var43, var44, var45
                        var8 = ""
                        var9 = ""
                        var19 = ""
                        var20 = ""
                        var21 = ""
                        var22 = ""
                        var23 = ""
                        var24 = ""
                        var29 = ""
                        var30 = ""
                        var36 = ""
                        var37 = ""
                        var43 = ""
                        var44 = ""
                        var45 = ""
                        'I was wondering if we could make the above an array with 45 indexes.
                        'The the For Each loop could be condensed to something more like.
                        '
                        '   For Each currentField In currentRow
                        '       Array(i) = GlobalVariables.RemoveCommas(currentField)
                        '       i += 1
                        '   Next
                        '
                        'We would have to adjust the Student Constructor below, though.
                        'Something like
                        '
                        '   StudentList.Add(New Student(Array(0), Array(1), ... )
                        '
                        Dim i = 0
                        For Each currentField In currentRow
                            If i = 0 Then
                                var1 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 1 Then
                                var2 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 2 Then
                                var3 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 3 Then
                                var4 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 4 Then
                                var5 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 5 Then
                                var6 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 6 Then
                                var7 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 7 Then
                                var8 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 8 Then
                                var9 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 9 Then
                                var10 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 10 Then
                                var11 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 11 Then
                                var12 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 12 Then
                                var13 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 13 Then
                                var14 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 14 Then
                                var15 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 15 Then
                                var16 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 16 Then
                                var17 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 17 Then
                                var18 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 18 Then
                                var19 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 19 Then
                                var20 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 20 Then
                                var21 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 21 Then
                                var22 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 22 Then
                                var23 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 23 Then
                                var24 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 24 Then
                                var25 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 25 Then
                                var26 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 26 Then
                                var27 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 27 Then
                                var28 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 28 Then
                                var29 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 29 Then
                                var30 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 30 Then
                                var31 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 31 Then
                                var32 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 32 Then
                                var33 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 33 Then
                                var34 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 34 Then
                                var35 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 35 Then
                                var36 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 36 Then
                                var37 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 37 Then
                                var38 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 38 Then
                                var39 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 39 Then
                                var40 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 40 Then
                                var41 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 41 Then
                                var42 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 42 Then
                                var43 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 43 Then
                                var44 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            If i = 44 Then
                                var45 = GlobalVariables.RemoveCommas(currentField)
                            End If
                            i = i + 1
                        Next


                        'Done reading row values / Create the instance of Person
                        studentList.Add(New Student(var1, var2, var3, var4, var5, var6, var7, var8, var9, var10, var11,
                                                    var12, var13, var14, var15, var16, var17, var18, var19, var20, var21,
                                                    var22, var23, var24, var25, var26, var27, var28, var29, var30, var31,
                                                    var32, var33, var34, var35, var36, var37, var38, var39, var40, var41, var42, var43, var44, var45))

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
            Counter = Counter + 1
        End If
        'Load values into the labels on the form
        lblName.Text = "Student Name: " + studentList(Counter).First.ToString() + studentList(Counter).Last.ToString()
        lblNSHE.Text = "Student NSHE#: " + studentList(Counter).NSHE
        lblGPA.Text = "Student GPA: " + studentList(Counter).GPA
        lblMajor.Text = "Student Major: " + studentList(Counter).Majors
        lblInternationalBusiness.Text = "International Business: " + studentList(Counter).InternationalBusiness
        lblComments.Text = "Student Comments: " + studentList(Counter).AdditionalInfo
        lblACC201.Text = "ACC201: " + studentList(Counter).Acc201
        lblACC202.Text = "ACC202: " + studentList(Counter).Acc202
        lblECON102.Text = "ECON102: " + studentList(Counter).Econ102
        lblECON103.Text = "ECON103: " + studentList(Counter).Econ103
        lblECON261.Text = "ECON261: " + studentList(Counter).Econ261
        lblECON262.Text = "ECON262: " + studentList(Counter).Econ262
        lblIS101.Text = "IS101: " + studentList(Counter).IS101
        lblMATH176.Text = "MATH176: " + studentList(Counter).Math176
        lblMKT210.Text = "MKT210: " + studentList(Counter).Mkt210
        'May be able to create an if statement that checks if status has a value. 
        'If so Then the accept/deny/bridge buttons could be disabled??
        If (studentList(Counter).Status.ToString() <> "") Then
            btnAccept.Enabled = False
            btnBridge.Enabled = False
            btnDeny.Enabled = False
            btnPrintPDF.Enabled = True
            lblDecisionMade.Visible = True
            lblDecisionMade.Text = "This Decision has already been made by " + studentList(Counter).Username + " for " + studentList(Counter).Semester

        Else
                btnAccept.Enabled = True
            btnDeny.Enabled = True
            btnBridge.Enabled = True
            btnPrintPDF.Enabled = False
            lblDecisionMade.Visible = False
        End If
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        'Save Accept decision
        studentList(Counter).Status = "Accepted"
        studentList(Counter).Semester = GlobalVariables.CurrentSemester
        studentList(Counter).Username = GlobalVariables.CurrentUsername
        btnPrintPDF.Enabled = True

        'These are for verification if needed later, we can delete the booleans if they are unfit for the scope
        'DecisionAccept = True
        'DecisionDeny = False
        'DecisionBridge = False

    End Sub

    Private Sub btnBridge_Click(sender As Object, e As EventArgs) Handles btnBridge.Click
        'Save Bridge Decision
        studentList(Counter).Status = "Bridged"
        studentList(Counter).Semester = GlobalVariables.CurrentSemester
        studentList(Counter).Username = GlobalVariables.CurrentUsername
        btnPrintPDF.Enabled = True
        'These are for verification if needed later, we can delete the booleans if they are unfit for the scope
        'DecisionBridge = True
        'DecisionAccept = False
        'DecisionDeny = False

    End Sub

    Private Sub btnDeny_Click(sender As Object, e As EventArgs) Handles btnDeny.Click
        'Save Deny Decision 
        studentList(Counter).Status = "Denied"
        studentList(Counter).Semester = GlobalVariables.CurrentSemester
        studentList(Counter).Username = GlobalVariables.CurrentUsername
        btnPrintPDF.Enabled = False
        'These are for verification if needed later, we can delete the booleans if they are unfit for the scope
        'DecisionBridge = False
        'DecisionAccept = False
        'DecisionDeny = True


    End Sub

    Private Sub btnPrintPDF_Click(sender As Object, e As EventArgs) Handles btnPrintPDF.Click
        GlobalVariables.SetPDF_FilePath()
        Dim PDF_FilePath = GlobalVariables.GetPDF_FilePath
        'Get the student submitted pdf provided by the data
        Dim submittedPDF As String = studentList(Counter).ChangeMajorPDF
        'get the file extension to check in if statment 
        Dim Extension As String = Path.GetExtension(submittedPDF)
        If (Extension = ".pdf") Then

            'To See File Path
            MessageBox.Show(text:="This is a valid PDF File Path: " + submittedPDF, caption:="PDF Filepath Valid")
            'To Test File Path
            'Process.Start(PDF_FilePath)
            'Print the file
            Dim PrintPDF As New ProcessStartInfo
            PrintPDF.UseShellExecute = True
            PrintPDF.Verb = "print"
            PrintPDF.WindowStyle = ProcessWindowStyle.Hidden
            PrintPDF.FileName = submittedPDF 'fileName is a string parameter
            Process.Start(PrintPDF)

        Else
            'To See File Path
            MessageBox.Show(text:="Please click OK to select the Students Signature to be used in the Major PDF Form" + submittedPDF, caption:="Generate New PDF: Please select a Signature")

            'Open ofdSignature so the user can choose the correct signatiure to upload, then set the StudentList.Signarure variable to the OFD result
            ofdSignature.ShowDialog()
            Dim SignatureResult As String = ofdSignature.FileName
            studentList(Counter).Signature = SignatureResult

            'User opens SFD to select where they wish to save the PDF
            sfdSavePDF.ShowDialog()
            Dim newFile As String = sfdSavePDF.FileName

            '-----------------------------Auto-Populate the PDF with Students information-------------------------------------------------
            'set ofd and svd variables
            Dim pdfTemplate As String = GlobalVariables.PDF_FilePath
            Dim signature As String = SignatureResult

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
            pdfFormFields.SetField("EvaluationDate", "studentList(Counter).decisionTimeStamp")

            pdfStamper.FormFlattening = True

            ' close the pdf
            pdfStamper.Close()



        End If
    End Sub
End Class
