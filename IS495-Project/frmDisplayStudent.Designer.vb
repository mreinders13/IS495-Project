<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDisplayStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSaveData = New System.Windows.Forms.Button()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNSHE = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnDeny = New System.Windows.Forms.Button()
        Me.btnBridge = New System.Windows.Forms.Button()
        Me.btnNextStudent = New System.Windows.Forms.Button()
        Me.btnPrevStudent = New System.Windows.Forms.Button()
        Me.lblGPA = New System.Windows.Forms.Label()
        Me.lblMajor = New System.Windows.Forms.Label()
        Me.lblInternationalBusiness = New System.Windows.Forms.Label()
        Me.lblComments = New System.Windows.Forms.Label()
        Me.lblACC201 = New System.Windows.Forms.Label()
        Me.lblACC202 = New System.Windows.Forms.Label()
        Me.lblECON102 = New System.Windows.Forms.Label()
        Me.lblECON103 = New System.Windows.Forms.Label()
        Me.lblECON261 = New System.Windows.Forms.Label()
        Me.lblECON262 = New System.Windows.Forms.Label()
        Me.lblIS101 = New System.Windows.Forms.Label()
        Me.lblMATH176 = New System.Windows.Forms.Label()
        Me.lblMKT210 = New System.Windows.Forms.Label()
        Me.btnPrintPDF = New System.Windows.Forms.Button()
        Me.ofdSignature = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSavePDF = New System.Windows.Forms.SaveFileDialog()
        Me.txtAdvisorNotes = New System.Windows.Forms.TextBox()
        Me.LblAdvisorNotes = New System.Windows.Forms.Label()
        Me.btnEmailStudent = New System.Windows.Forms.Button()
        Me.btnExportData = New System.Windows.Forms.Button()
        Me.lblDecision = New System.Windows.Forms.Label()
        Me.lblReviewedBy = New System.Windows.Forms.Label()
        Me.lblReviewDate = New System.Windows.Forms.Label()
        Me.lblMajorFormSigned = New System.Windows.Forms.Label()
        Me.lblBridgePermission = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSaveData
        '
        Me.btnSaveData.Location = New System.Drawing.Point(261, 644)
        Me.btnSaveData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSaveData.Name = "btnSaveData"
        Me.btnSaveData.Size = New System.Drawing.Size(100, 28)
        Me.btnSaveData.TabIndex = 0
        Me.btnSaveData.Text = "Save"
        Me.btnSaveData.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(15, 11)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(106, 17)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Student Name: "
        '
        'lblNSHE
        '
        Me.lblNSHE.AutoSize = True
        Me.lblNSHE.Location = New System.Drawing.Point(15, 37)
        Me.lblNSHE.Name = "lblNSHE"
        Me.lblNSHE.Size = New System.Drawing.Size(115, 17)
        Me.lblNSHE.TabIndex = 2
        Me.lblNSHE.Text = "Student NSHE#: "
        '
        'btnAccept
        '
        Me.btnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert
        Me.btnAccept.Location = New System.Drawing.Point(24, 387)
        Me.btnAccept.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(100, 28)
        Me.btnAccept.TabIndex = 3
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnDeny
        '
        Me.btnDeny.Location = New System.Drawing.Point(240, 387)
        Me.btnDeny.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDeny.Name = "btnDeny"
        Me.btnDeny.Size = New System.Drawing.Size(100, 28)
        Me.btnDeny.TabIndex = 4
        Me.btnDeny.Text = "Deny"
        Me.btnDeny.UseVisualStyleBackColor = True
        '
        'btnBridge
        '
        Me.btnBridge.Location = New System.Drawing.Point(132, 387)
        Me.btnBridge.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBridge.Name = "btnBridge"
        Me.btnBridge.Size = New System.Drawing.Size(100, 28)
        Me.btnBridge.TabIndex = 5
        Me.btnBridge.Text = "Bridge"
        Me.btnBridge.UseVisualStyleBackColor = True
        '
        'btnNextStudent
        '
        Me.btnNextStudent.Location = New System.Drawing.Point(624, 644)
        Me.btnNextStudent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNextStudent.Name = "btnNextStudent"
        Me.btnNextStudent.Size = New System.Drawing.Size(125, 28)
        Me.btnNextStudent.TabIndex = 6
        Me.btnNextStudent.Text = "Next Student"
        Me.btnNextStudent.UseVisualStyleBackColor = True
        '
        'btnPrevStudent
        '
        Me.btnPrevStudent.Location = New System.Drawing.Point(13, 644)
        Me.btnPrevStudent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPrevStudent.Name = "btnPrevStudent"
        Me.btnPrevStudent.Size = New System.Drawing.Size(125, 28)
        Me.btnPrevStudent.TabIndex = 7
        Me.btnPrevStudent.Text = "Prev. Student"
        Me.btnPrevStudent.UseVisualStyleBackColor = True
        '
        'lblGPA
        '
        Me.lblGPA.AutoSize = True
        Me.lblGPA.Location = New System.Drawing.Point(15, 63)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(98, 17)
        Me.lblGPA.TabIndex = 8
        Me.lblGPA.Text = "Student GPA: "
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Location = New System.Drawing.Point(15, 89)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(104, 17)
        Me.lblMajor.TabIndex = 9
        Me.lblMajor.Text = "Student Major: "
        '
        'lblInternationalBusiness
        '
        Me.lblInternationalBusiness.AutoSize = True
        Me.lblInternationalBusiness.Location = New System.Drawing.Point(12, 164)
        Me.lblInternationalBusiness.Name = "lblInternationalBusiness"
        Me.lblInternationalBusiness.Size = New System.Drawing.Size(155, 17)
        Me.lblInternationalBusiness.TabIndex = 10
        Me.lblInternationalBusiness.Text = "International Business: "
        '
        'lblComments
        '
        Me.lblComments.Location = New System.Drawing.Point(9, 194)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(305, 79)
        Me.lblComments.TabIndex = 11
        Me.lblComments.Text = "Student Comments: "
        '
        'lblACC201
        '
        Me.lblACC201.Location = New System.Drawing.Point(373, 11)
        Me.lblACC201.Name = "lblACC201"
        Me.lblACC201.Size = New System.Drawing.Size(380, 16)
        Me.lblACC201.TabIndex = 12
        Me.lblACC201.Text = "ACC201: "
        '
        'lblACC202
        '
        Me.lblACC202.Location = New System.Drawing.Point(373, 48)
        Me.lblACC202.Name = "lblACC202"
        Me.lblACC202.Size = New System.Drawing.Size(380, 16)
        Me.lblACC202.TabIndex = 13
        Me.lblACC202.Text = "ACC202: "
        '
        'lblECON102
        '
        Me.lblECON102.Location = New System.Drawing.Point(373, 85)
        Me.lblECON102.Name = "lblECON102"
        Me.lblECON102.Size = New System.Drawing.Size(380, 16)
        Me.lblECON102.TabIndex = 14
        Me.lblECON102.Text = "ECON102: "
        '
        'lblECON103
        '
        Me.lblECON103.Location = New System.Drawing.Point(373, 122)
        Me.lblECON103.Name = "lblECON103"
        Me.lblECON103.Size = New System.Drawing.Size(380, 16)
        Me.lblECON103.TabIndex = 15
        Me.lblECON103.Text = "ECON103: "
        '
        'lblECON261
        '
        Me.lblECON261.Location = New System.Drawing.Point(373, 159)
        Me.lblECON261.Name = "lblECON261"
        Me.lblECON261.Size = New System.Drawing.Size(380, 16)
        Me.lblECON261.TabIndex = 16
        Me.lblECON261.Text = "ECON261: "
        '
        'lblECON262
        '
        Me.lblECON262.Location = New System.Drawing.Point(373, 196)
        Me.lblECON262.Name = "lblECON262"
        Me.lblECON262.Size = New System.Drawing.Size(380, 16)
        Me.lblECON262.TabIndex = 17
        Me.lblECON262.Text = "ECON262: "
        '
        'lblIS101
        '
        Me.lblIS101.Location = New System.Drawing.Point(373, 233)
        Me.lblIS101.Name = "lblIS101"
        Me.lblIS101.Size = New System.Drawing.Size(380, 16)
        Me.lblIS101.TabIndex = 18
        Me.lblIS101.Text = "IS101: "
        '
        'lblMATH176
        '
        Me.lblMATH176.Location = New System.Drawing.Point(373, 270)
        Me.lblMATH176.Name = "lblMATH176"
        Me.lblMATH176.Size = New System.Drawing.Size(380, 16)
        Me.lblMATH176.TabIndex = 19
        Me.lblMATH176.Text = "MATH176: "
        '
        'lblMKT210
        '
        Me.lblMKT210.Location = New System.Drawing.Point(373, 306)
        Me.lblMKT210.Name = "lblMKT210"
        Me.lblMKT210.Size = New System.Drawing.Size(380, 16)
        Me.lblMKT210.TabIndex = 20
        Me.lblMKT210.Text = "MKT210: "
        '
        'btnPrintPDF
        '
        Me.btnPrintPDF.Location = New System.Drawing.Point(56, 423)
        Me.btnPrintPDF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPrintPDF.Name = "btnPrintPDF"
        Me.btnPrintPDF.Size = New System.Drawing.Size(100, 28)
        Me.btnPrintPDF.TabIndex = 22
        Me.btnPrintPDF.Text = "Print PDF"
        Me.btnPrintPDF.UseVisualStyleBackColor = True
        '
        'txtAdvisorNotes
        '
        Me.txtAdvisorNotes.Location = New System.Drawing.Point(16, 301)
        Me.txtAdvisorNotes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAdvisorNotes.Multiline = True
        Me.txtAdvisorNotes.Name = "txtAdvisorNotes"
        Me.txtAdvisorNotes.Size = New System.Drawing.Size(332, 78)
        Me.txtAdvisorNotes.TabIndex = 24
        '
        'LblAdvisorNotes
        '
        Me.LblAdvisorNotes.AutoSize = True
        Me.LblAdvisorNotes.Location = New System.Drawing.Point(13, 281)
        Me.LblAdvisorNotes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAdvisorNotes.Name = "LblAdvisorNotes"
        Me.LblAdvisorNotes.Size = New System.Drawing.Size(96, 17)
        Me.LblAdvisorNotes.TabIndex = 25
        Me.LblAdvisorNotes.Text = "Advisor Notes"
        '
        'btnEmailStudent
        '
        Me.btnEmailStudent.Location = New System.Drawing.Point(164, 423)
        Me.btnEmailStudent.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEmailStudent.Name = "btnEmailStudent"
        Me.btnEmailStudent.Size = New System.Drawing.Size(152, 28)
        Me.btnEmailStudent.TabIndex = 27
        Me.btnEmailStudent.Text = "Email Student"
        Me.btnEmailStudent.UseVisualStyleBackColor = True
        '
        'btnExportData
        '
        Me.btnExportData.Location = New System.Drawing.Point(369, 644)
        Me.btnExportData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExportData.Name = "btnExportData"
        Me.btnExportData.Size = New System.Drawing.Size(181, 28)
        Me.btnExportData.TabIndex = 28
        Me.btnExportData.Text = "Export Data for MS BI"
        Me.btnExportData.UseVisualStyleBackColor = True
        '
        'lblDecision
        '
        Me.lblDecision.AutoSize = True
        Me.lblDecision.Location = New System.Drawing.Point(149, 481)
        Me.lblDecision.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDecision.Name = "lblDecision"
        Me.lblDecision.Size = New System.Drawing.Size(66, 17)
        Me.lblDecision.TabIndex = 30
        Me.lblDecision.Text = "Decision:"
        '
        'lblReviewedBy
        '
        Me.lblReviewedBy.AutoSize = True
        Me.lblReviewedBy.Location = New System.Drawing.Point(120, 507)
        Me.lblReviewedBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReviewedBy.Name = "lblReviewedBy"
        Me.lblReviewedBy.Size = New System.Drawing.Size(93, 17)
        Me.lblReviewedBy.TabIndex = 31
        Me.lblReviewedBy.Text = "Reviewed By:"
        '
        'lblReviewDate
        '
        Me.lblReviewDate.AutoSize = True
        Me.lblReviewDate.Location = New System.Drawing.Point(121, 532)
        Me.lblReviewDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReviewDate.Name = "lblReviewDate"
        Me.lblReviewDate.Size = New System.Drawing.Size(91, 17)
        Me.lblReviewDate.TabIndex = 32
        Me.lblReviewDate.Text = "Review Date:"
        '
        'lblMajorFormSigned
        '
        Me.lblMajorFormSigned.AutoSize = True
        Me.lblMajorFormSigned.Location = New System.Drawing.Point(86, 558)
        Me.lblMajorFormSigned.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMajorFormSigned.Name = "lblMajorFormSigned"
        Me.lblMajorFormSigned.Size = New System.Drawing.Size(131, 17)
        Me.lblMajorFormSigned.TabIndex = 33
        Me.lblMajorFormSigned.Text = "Major Form Signed:"
        '
        'lblBridgePermission
        '
        Me.lblBridgePermission.AutoSize = True
        Me.lblBridgePermission.Location = New System.Drawing.Point(38, 584)
        Me.lblBridgePermission.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBridgePermission.Name = "lblBridgePermission"
        Me.lblBridgePermission.Size = New System.Drawing.Size(182, 17)
        Me.lblBridgePermission.TabIndex = 34
        Me.lblBridgePermission.Text = "Bridge Permission Granted:"
        '
        'frmDisplayStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 685)
        Me.Controls.Add(Me.lblBridgePermission)
        Me.Controls.Add(Me.lblMajorFormSigned)
        Me.Controls.Add(Me.lblReviewDate)
        Me.Controls.Add(Me.lblReviewedBy)
        Me.Controls.Add(Me.lblDecision)
        Me.Controls.Add(Me.btnExportData)
        Me.Controls.Add(Me.btnEmailStudent)
        Me.Controls.Add(Me.LblAdvisorNotes)
        Me.Controls.Add(Me.txtAdvisorNotes)
        Me.Controls.Add(Me.btnPrintPDF)
        Me.Controls.Add(Me.lblMKT210)
        Me.Controls.Add(Me.lblMATH176)
        Me.Controls.Add(Me.lblIS101)
        Me.Controls.Add(Me.lblECON262)
        Me.Controls.Add(Me.lblECON261)
        Me.Controls.Add(Me.lblECON103)
        Me.Controls.Add(Me.lblECON102)
        Me.Controls.Add(Me.lblACC202)
        Me.Controls.Add(Me.lblACC201)
        Me.Controls.Add(Me.lblComments)
        Me.Controls.Add(Me.lblInternationalBusiness)
        Me.Controls.Add(Me.lblMajor)
        Me.Controls.Add(Me.lblGPA)
        Me.Controls.Add(Me.btnPrevStudent)
        Me.Controls.Add(Me.btnNextStudent)
        Me.Controls.Add(Me.btnBridge)
        Me.Controls.Add(Me.btnDeny)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.lblNSHE)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnSaveData)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmDisplayStudent"
        Me.Text = "Student Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSaveData As Button
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents lblName As Label
    Friend WithEvents lblNSHE As Label
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnDeny As Button
    Friend WithEvents btnBridge As Button
    Friend WithEvents btnNextStudent As Button
    Friend WithEvents btnPrevStudent As Button
    Friend WithEvents lblGPA As Label
    Friend WithEvents lblMajor As Label
    Friend WithEvents lblInternationalBusiness As Label
    Friend WithEvents lblComments As Label
    Friend WithEvents lblACC201 As Label
    Friend WithEvents lblACC202 As Label
    Friend WithEvents lblECON102 As Label
    Friend WithEvents lblECON103 As Label
    Friend WithEvents lblECON261 As Label
    Friend WithEvents lblECON262 As Label
    Friend WithEvents lblIS101 As Label
    Friend WithEvents lblMATH176 As Label
    Friend WithEvents lblMKT210 As Label
    Friend WithEvents lblDecisionMade As Label
    Friend WithEvents btnPrintPDF As Button
    Friend WithEvents ofdSignature As OpenFileDialog
    Friend WithEvents sfdSavePDF As SaveFileDialog
    Friend WithEvents txtAdvisorNotes As TextBox
    Friend WithEvents LblAdvisorNotes As Label
    Friend WithEvents btnEmailStudent As Button
    Friend WithEvents btnExportData As Button
    Friend WithEvents lblDecision As Label
    Friend WithEvents lblReviewedBy As Label
    Friend WithEvents lblReviewDate As Label
    Friend WithEvents lblMajorFormSigned As Label
    Friend WithEvents lblBridgePermission As Label
End Class
