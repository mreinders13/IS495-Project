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
        Me.lblDecisionMade = New System.Windows.Forms.Label()
        Me.btnPrintPDF = New System.Windows.Forms.Button()
        Me.ofdSignature = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSavePDF = New System.Windows.Forms.SaveFileDialog()
        Me.txtAdvisorNotes = New System.Windows.Forms.TextBox()
        Me.LblAdvisorNotes = New System.Windows.Forms.Label()
        Me.btnEmailStudent = New System.Windows.Forms.Button()
        Me.btnExportData = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSaveData
        '
        Me.btnSaveData.Location = New System.Drawing.Point(520, 292)
        Me.btnSaveData.Name = "btnSaveData"
        Me.btnSaveData.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveData.TabIndex = 0
        Me.btnSaveData.Text = "Save"
        Me.btnSaveData.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(9, 7)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(81, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Student Name: "
        '
        'lblNSHE
        '
        Me.lblNSHE.AutoSize = True
        Me.lblNSHE.Location = New System.Drawing.Point(9, 29)
        Me.lblNSHE.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNSHE.Name = "lblNSHE"
        Me.lblNSHE.Size = New System.Drawing.Size(90, 13)
        Me.lblNSHE.TabIndex = 2
        Me.lblNSHE.Text = "Student NSHE#: "
        '
        'btnAccept
        '
        Me.btnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert
        Me.btnAccept.Location = New System.Drawing.Point(15, 292)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 3
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnDeny
        '
        Me.btnDeny.Location = New System.Drawing.Point(181, 292)
        Me.btnDeny.Name = "btnDeny"
        Me.btnDeny.Size = New System.Drawing.Size(75, 23)
        Me.btnDeny.TabIndex = 4
        Me.btnDeny.Text = "Deny"
        Me.btnDeny.UseVisualStyleBackColor = True
        '
        'btnBridge
        '
        Me.btnBridge.Location = New System.Drawing.Point(98, 292)
        Me.btnBridge.Name = "btnBridge"
        Me.btnBridge.Size = New System.Drawing.Size(75, 23)
        Me.btnBridge.TabIndex = 5
        Me.btnBridge.Text = "Bridge"
        Me.btnBridge.UseVisualStyleBackColor = True
        '
        'btnNextStudent
        '
        Me.btnNextStudent.Location = New System.Drawing.Point(264, 485)
        Me.btnNextStudent.Name = "btnNextStudent"
        Me.btnNextStudent.Size = New System.Drawing.Size(94, 23)
        Me.btnNextStudent.TabIndex = 6
        Me.btnNextStudent.Text = "Next Student"
        Me.btnNextStudent.UseVisualStyleBackColor = True
        '
        'btnPrevStudent
        '
        Me.btnPrevStudent.Location = New System.Drawing.Point(11, 485)
        Me.btnPrevStudent.Name = "btnPrevStudent"
        Me.btnPrevStudent.Size = New System.Drawing.Size(94, 23)
        Me.btnPrevStudent.TabIndex = 7
        Me.btnPrevStudent.Text = "Prev. Student"
        Me.btnPrevStudent.UseVisualStyleBackColor = True
        '
        'lblGPA
        '
        Me.lblGPA.AutoSize = True
        Me.lblGPA.Location = New System.Drawing.Point(9, 51)
        Me.lblGPA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(75, 13)
        Me.lblGPA.TabIndex = 8
        Me.lblGPA.Text = "Student GPA: "
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Location = New System.Drawing.Point(9, 73)
        Me.lblMajor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(79, 13)
        Me.lblMajor.TabIndex = 9
        Me.lblMajor.Text = "Student Major: "
        '
        'lblInternationalBusiness
        '
        Me.lblInternationalBusiness.AutoSize = True
        Me.lblInternationalBusiness.Location = New System.Drawing.Point(9, 96)
        Me.lblInternationalBusiness.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInternationalBusiness.Name = "lblInternationalBusiness"
        Me.lblInternationalBusiness.Size = New System.Drawing.Size(116, 13)
        Me.lblInternationalBusiness.TabIndex = 10
        Me.lblInternationalBusiness.Text = "International Business: "
        '
        'lblComments
        '
        Me.lblComments.Location = New System.Drawing.Point(9, 117)
        Me.lblComments.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(229, 64)
        Me.lblComments.TabIndex = 11
        Me.lblComments.Text = "Student Comments: "
        '
        'lblACC201
        '
        Me.lblACC201.Location = New System.Drawing.Point(261, 11)
        Me.lblACC201.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblACC201.Name = "lblACC201"
        Me.lblACC201.Size = New System.Drawing.Size(273, 63)
        Me.lblACC201.TabIndex = 12
        Me.lblACC201.Text = "ACC201: "
        '
        'lblACC202
        '
        Me.lblACC202.Location = New System.Drawing.Point(261, 29)
        Me.lblACC202.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblACC202.Name = "lblACC202"
        Me.lblACC202.Size = New System.Drawing.Size(273, 63)
        Me.lblACC202.TabIndex = 13
        Me.lblACC202.Text = "ACC202: "
        '
        'lblECON102
        '
        Me.lblECON102.Location = New System.Drawing.Point(261, 51)
        Me.lblECON102.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblECON102.Name = "lblECON102"
        Me.lblECON102.Size = New System.Drawing.Size(282, 63)
        Me.lblECON102.TabIndex = 14
        Me.lblECON102.Text = "ECON102: "
        '
        'lblECON103
        '
        Me.lblECON103.Location = New System.Drawing.Point(261, 73)
        Me.lblECON103.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblECON103.Name = "lblECON103"
        Me.lblECON103.Size = New System.Drawing.Size(282, 63)
        Me.lblECON103.TabIndex = 15
        Me.lblECON103.Text = "ECON103: "
        '
        'lblECON261
        '
        Me.lblECON261.Location = New System.Drawing.Point(261, 98)
        Me.lblECON261.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblECON261.Name = "lblECON261"
        Me.lblECON261.Size = New System.Drawing.Size(282, 63)
        Me.lblECON261.TabIndex = 16
        Me.lblECON261.Text = "ECON261: "
        '
        'lblECON262
        '
        Me.lblECON262.Location = New System.Drawing.Point(261, 119)
        Me.lblECON262.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblECON262.Name = "lblECON262"
        Me.lblECON262.Size = New System.Drawing.Size(282, 63)
        Me.lblECON262.TabIndex = 17
        Me.lblECON262.Text = "ECON262: "
        '
        'lblIS101
        '
        Me.lblIS101.Location = New System.Drawing.Point(261, 144)
        Me.lblIS101.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIS101.Name = "lblIS101"
        Me.lblIS101.Size = New System.Drawing.Size(262, 63)
        Me.lblIS101.TabIndex = 18
        Me.lblIS101.Text = "IS101: "
        '
        'lblMATH176
        '
        Me.lblMATH176.Location = New System.Drawing.Point(261, 166)
        Me.lblMATH176.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMATH176.Name = "lblMATH176"
        Me.lblMATH176.Size = New System.Drawing.Size(282, 63)
        Me.lblMATH176.TabIndex = 19
        Me.lblMATH176.Text = "MATH176: "
        '
        'lblMKT210
        '
        Me.lblMKT210.Location = New System.Drawing.Point(261, 188)
        Me.lblMKT210.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMKT210.Name = "lblMKT210"
        Me.lblMKT210.Size = New System.Drawing.Size(274, 63)
        Me.lblMKT210.TabIndex = 20
        Me.lblMKT210.Text = "MKT210: "
        '
        'lblDecisionMade
        '
        Me.lblDecisionMade.AutoSize = True
        Me.lblDecisionMade.Location = New System.Drawing.Point(13, 318)
        Me.lblDecisionMade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDecisionMade.Name = "lblDecisionMade"
        Me.lblDecisionMade.Size = New System.Drawing.Size(196, 13)
        Me.lblDecisionMade.TabIndex = 21
        Me.lblDecisionMade.Text = "This decision has already been made by"
        '
        'btnPrintPDF
        '
        Me.btnPrintPDF.Location = New System.Drawing.Point(520, 321)
        Me.btnPrintPDF.Name = "btnPrintPDF"
        Me.btnPrintPDF.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintPDF.TabIndex = 22
        Me.btnPrintPDF.Text = "Print PDF"
        Me.btnPrintPDF.UseVisualStyleBackColor = True
        '
        'txtAdvisorNotes
        '
        Me.txtAdvisorNotes.Location = New System.Drawing.Point(11, 210)
        Me.txtAdvisorNotes.Multiline = True
        Me.txtAdvisorNotes.Name = "txtAdvisorNotes"
        Me.txtAdvisorNotes.Size = New System.Drawing.Size(223, 64)
        Me.txtAdvisorNotes.TabIndex = 24
        '
        'LblAdvisorNotes
        '
        Me.LblAdvisorNotes.AutoSize = True
        Me.LblAdvisorNotes.Location = New System.Drawing.Point(12, 188)
        Me.LblAdvisorNotes.Name = "LblAdvisorNotes"
        Me.LblAdvisorNotes.Size = New System.Drawing.Size(73, 13)
        Me.LblAdvisorNotes.TabIndex = 25
        Me.LblAdvisorNotes.Text = "Advisor Notes"
        '
        'btnEmailStudent
        '
        Me.btnEmailStudent.Location = New System.Drawing.Point(481, 350)
        Me.btnEmailStudent.Name = "btnEmailStudent"
        Me.btnEmailStudent.Size = New System.Drawing.Size(114, 23)
        Me.btnEmailStudent.TabIndex = 27
        Me.btnEmailStudent.Text = "Email Student"
        Me.btnEmailStudent.UseVisualStyleBackColor = True
        '
        'btnExportData
        '
        Me.btnExportData.Location = New System.Drawing.Point(459, 379)
        Me.btnExportData.Name = "btnExportData"
        Me.btnExportData.Size = New System.Drawing.Size(136, 23)
        Me.btnExportData.TabIndex = 28
        Me.btnExportData.Text = "Export Data for MS BI"
        Me.btnExportData.UseVisualStyleBackColor = True
        '
        'frmDisplayStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 518)
        Me.Controls.Add(Me.btnExportData)
        Me.Controls.Add(Me.btnEmailStudent)
        Me.Controls.Add(Me.LblAdvisorNotes)
        Me.Controls.Add(Me.txtAdvisorNotes)
        Me.Controls.Add(Me.btnPrintPDF)
        Me.Controls.Add(Me.lblDecisionMade)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
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
End Class
