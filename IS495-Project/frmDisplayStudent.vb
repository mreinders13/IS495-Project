Public Class frmDisplayStudent
    'Create a List of all students 
    Dim studentList As New List(Of Student)
    'set counter to 1 before loop begins
    Dim Counter As Int16 = 1
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
        'load the previous student 
        If (Counter - 1) > 0 Then
            Counter = Counter - 1
            lblStudentName.Text = "Student Name: " + studentList(Counter).First + " " + studentList(Counter).Last
            lblStudentNSHE.Text = "Student NSHE#: " + studentList(Counter).NSHE

        Else
            MessageBox.Show("This is the beginning of the list")

        End If
    End Sub

    Private Sub btnNextStudent_Click(sender As Object, e As EventArgs) Handles btnNextStudent.Click
        'load the next student
        If (Counter + 1) < studentList.Count Then
            Counter = Counter + 1
            lblStudentName.Text = "Student Name: " + studentList(Counter).First + " " + studentList(Counter).Last
            lblStudentNSHE.Text = "Student NSHE#: " + studentList(Counter).NSHE

        Else
            MessageBox.Show("End of List")

        End If
    End Sub

    Private Sub btnSaveData_Click(sender As Object, e As EventArgs) Handles btnSaveData.Click
        'view save dialog
        Dim result As DialogResult = SaveFileDialog.ShowDialog()
        'check filepath to save to
        If result = Windows.Forms.DialogResult.OK Then
            Dim csvFile As String = SaveFileDialog.FileName
            Dim saveCounter As Int16 = 0

            Dim outFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(csvFile, False)
            While saveCounter < studentList.Count
                outFile.WriteLine(studentList(saveCounter).Time.ToString() + "," + studentList(saveCounter).First.ToString() + "," + studentList(saveCounter).Last.ToString() + "," + studentList(saveCounter).NSHE.ToString() + "," + studentList(saveCounter).Phone.ToString() + "," + studentList(saveCounter).Email.ToString() + "," + studentList(saveCounter).Majors.ToString() + "," + studentList(saveCounter).InternationalBusiness.ToString() + "," + studentList(saveCounter).Regional.ToString() + "," + studentList(saveCounter).Acc201.ToString() + "," + studentList(saveCounter).Acc202.ToString() + "," + studentList(saveCounter).Econ102.ToString() + "," + studentList(saveCounter).Econ103.ToString() + "," + studentList(saveCounter).Econ261.ToString() + "," + studentList(saveCounter).Econ262.ToString() + "," + studentList(saveCounter).IS101.ToString() + "," + studentList(saveCounter).Math176.ToString() + "," + studentList(saveCounter).Mkt210.ToString() + "," + studentList(saveCounter).Econ102_2.ToString() + "," + studentList(saveCounter).Econ103_2.ToString() + "," + studentList(saveCounter).Econ261_2.ToString() + "," + studentList(saveCounter).Econ262_2.ToString() + "," + studentList(saveCounter).IS101_2.ToString() + "," + studentList(saveCounter).Math176_2.ToString() + "," + studentList(saveCounter).ToBeCompleted.ToString() + "," + studentList(saveCounter).GPA.ToString() + "," + studentList(saveCounter).AdditionalInfo.ToString() + "," + studentList(saveCounter).OtherInstitutions.ToString() + "," + studentList(saveCounter).TranscriptsSubmitted.ToString() + "," + studentList(saveCounter).TranscriptsUploaded.ToString() + "," + studentList(saveCounter).DeclarationDay.ToString() + "," + studentList(saveCounter).DeclarationDayConflicts.ToString() + "," + studentList(saveCounter).EmailConfirmation.ToString() + "," + studentList(saveCounter).Understand.ToString() + "," + studentList(saveCounter).FalseInfo.ToString() + "," + studentList(saveCounter).ChangeMajorPDF.ToString() + "," + studentList(saveCounter).Signature.ToString() + "," + studentList(saveCounter).AppDate.ToString() + "," + studentList(saveCounter).Browser.ToString() + "," + studentList(saveCounter).ipAddress.ToString() + "," + studentList(saveCounter).UniqueID.ToString() + "," + studentList(saveCounter).Location.ToString() + "," + studentList(saveCounter).Status.ToString())
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
                            var33, var34, var35, var36, var37, var38, var39, var40, var41, var42

                        Dim i = 0
                        For Each currentField In currentRow
                            If i = 0 Then
                                var1 = currentField
                            End If
                            If i = 1 Then
                                var2 = currentField
                            End If
                            If i = 2 Then
                                var3 = currentField
                            End If
                            If i = 3 Then
                                var4 = currentField
                            End If
                            If i = 4 Then
                                var5 = currentField
                            End If
                            If i = 5 Then
                                var6 = currentField
                            End If
                            If i = 6 Then
                                var7 = currentField
                            End If
                            If i = 7 Then
                                var8 = currentField
                            End If
                            If i = 8 Then
                                var9 = currentField
                            End If
                            If i = 9 Then
                                var10 = currentField
                            End If
                            If i = 10 Then
                                var11 = currentField
                            End If
                            If i = 11 Then
                                var12 = currentField
                            End If
                            If i = 12 Then
                                var13 = currentField
                            End If
                            If i = 13 Then
                                var14 = currentField
                            End If
                            If i = 14 Then
                                var15 = currentField
                            End If
                            If i = 15 Then
                                var16 = currentField
                            End If
                            If i = 16 Then
                                var17 = currentField
                            End If
                            If i = 17 Then
                                var18 = currentField
                            End If
                            If i = 18 Then
                                var19 = currentField
                            End If
                            If i = 19 Then
                                var20 = currentField
                            End If
                            If i = 20 Then
                                var21 = currentField
                            End If
                            If i = 21 Then
                                var22 = currentField
                            End If
                            If i = 22 Then
                                var23 = currentField
                            End If
                            If i = 23 Then
                                var24 = currentField
                            End If
                            If i = 24 Then
                                var25 = currentField
                            End If
                            If i = 25 Then
                                var26 = currentField
                            End If
                            If i = 26 Then
                                var27 = currentField
                            End If
                            If i = 27 Then
                                var28 = currentField
                            End If
                            If i = 28 Then
                                var29 = currentField
                            End If
                            If i = 29 Then
                                var30 = currentField
                            End If
                            If i = 30 Then
                                var31 = currentField
                            End If
                            If i = 31 Then
                                var32 = currentField
                            End If
                            If i = 32 Then
                                var33 = currentField
                            End If
                            If i = 33 Then
                                var34 = currentField
                            End If
                            If i = 34 Then
                                var35 = currentField
                            End If
                            If i = 35 Then
                                var36 = currentField
                            End If
                            If i = 36 Then
                                var37 = currentField
                            End If
                            If i = 37 Then
                                var38 = currentField
                            End If
                            If i = 38 Then
                                var39 = currentField
                            End If
                            If i = 39 Then
                                var40 = currentField
                            End If
                            If i = 40 Then
                                var41 = currentField
                            End If
                            If i = 41 Then
                                var42 = currentField
                            End If
                            i = i + 1
                        Next
                        'Done reading row values / Create the instance of Person
                        studentList.Add(New Student(var1, var2, var3, var4, var5, var6, var7, var8, var9, var10, var11,
                                                    var12, var13, var14, var15, var16, var17, var18, var19, var20, var21,
                                                    var22, var23, var24, var25, var26, var27, var28, var29, var30, var31,
                                                    var32, var33, var34, var35, var36, var37, var38, var39, var40, var41, var42))

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
        'Load values into the labels on the form
        lblStudentName.Text = "Student Name: " + studentList(Counter).First.ToString() + studentList(Counter).Last.ToString()
        lblStudentNSHE.Text = "Student NSHE#: " + studentList(Counter).NSHE
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        'Save Accept decision
        studentList(Counter).Status = "Accepted"
        'These are for verification if needed later, we can delete the booleans if they are unfit for the scope
        'DecisionAccept = True
        'DecisionDeny = False
        'DecisionBridge = False

    End Sub

    Private Sub btnBridge_Click(sender As Object, e As EventArgs) Handles btnBridge.Click
        'Save Bridge Decision
        studentList(Counter).Status = "Bridged"
        'These are for verification if needed later, we can delete the booleans if they are unfit for the scope
        'DecisionBridge = True
        'DecisionAccept = False
        'DecisionDeny = False

    End Sub

    Private Sub btnDeny_Click(sender As Object, e As EventArgs) Handles btnDeny.Click
        'Save Deny Decision 
        studentList(Counter).Status = "Denied"
        'These are for verification if needed later, we can delete the booleans if they are unfit for the scope
        'DecisionBridge = False
        'DecisionAccept = False
        'DecisionDeny = True


    End Sub
End Class
