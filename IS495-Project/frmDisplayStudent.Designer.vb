﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.SuspendLayout()
        '
        'btnSaveData
        '
        Me.btnSaveData.Location = New System.Drawing.Point(217, 391)
        Me.btnSaveData.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveData.Name = "btnSaveData"
        Me.btnSaveData.Size = New System.Drawing.Size(100, 28)
        Me.btnSaveData.TabIndex = 0
        Me.btnSaveData.Text = "Save"
        Me.btnSaveData.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(106, 17)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Student Name: "
        '
        'lblNSHE
        '
        Me.lblNSHE.AutoSize = True
        Me.lblNSHE.Location = New System.Drawing.Point(12, 36)
        Me.lblNSHE.Name = "lblNSHE"
        Me.lblNSHE.Size = New System.Drawing.Size(115, 17)
        Me.lblNSHE.TabIndex = 2
        Me.lblNSHE.Text = "Student NSHE#: "
        '
        'btnAccept
        '
        Me.btnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert
        Me.btnAccept.Location = New System.Drawing.Point(107, 345)
        Me.btnAccept.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(100, 28)
        Me.btnAccept.TabIndex = 3
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnDeny
        '
        Me.btnDeny.Location = New System.Drawing.Point(328, 345)
        Me.btnDeny.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDeny.Name = "btnDeny"
        Me.btnDeny.Size = New System.Drawing.Size(100, 28)
        Me.btnDeny.TabIndex = 4
        Me.btnDeny.Text = "Deny"
        Me.btnDeny.UseVisualStyleBackColor = True
        '
        'btnBridge
        '
        Me.btnBridge.Location = New System.Drawing.Point(217, 345)
        Me.btnBridge.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBridge.Name = "btnBridge"
        Me.btnBridge.Size = New System.Drawing.Size(100, 28)
        Me.btnBridge.TabIndex = 5
        Me.btnBridge.Text = "Bridge"
        Me.btnBridge.UseVisualStyleBackColor = True
        '
        'btnNextStudent
        '
        Me.btnNextStudent.Location = New System.Drawing.Point(509, 597)
        Me.btnNextStudent.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNextStudent.Name = "btnNextStudent"
        Me.btnNextStudent.Size = New System.Drawing.Size(125, 28)
        Me.btnNextStudent.TabIndex = 6
        Me.btnNextStudent.Text = "Next Student"
        Me.btnNextStudent.UseVisualStyleBackColor = True
        '
        'btnPrevStudent
        '
        Me.btnPrevStudent.Location = New System.Drawing.Point(15, 597)
        Me.btnPrevStudent.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrevStudent.Name = "btnPrevStudent"
        Me.btnPrevStudent.Size = New System.Drawing.Size(125, 28)
        Me.btnPrevStudent.TabIndex = 7
        Me.btnPrevStudent.Text = "Prev. Student"
        Me.btnPrevStudent.UseVisualStyleBackColor = True
        '
        'lblGPA
        '
        Me.lblGPA.AutoSize = True
        Me.lblGPA.Location = New System.Drawing.Point(12, 63)
        Me.lblGPA.Name = "lblGPA"
        Me.lblGPA.Size = New System.Drawing.Size(98, 17)
        Me.lblGPA.TabIndex = 8
        Me.lblGPA.Text = "Student GPA: "
        '
        'lblMajor
        '
        Me.lblMajor.AutoSize = True
        Me.lblMajor.Location = New System.Drawing.Point(12, 90)
        Me.lblMajor.Name = "lblMajor"
        Me.lblMajor.Size = New System.Drawing.Size(104, 17)
        Me.lblMajor.TabIndex = 9
        Me.lblMajor.Text = "Student Major: "
        '
        'lblInternationalBusiness
        '
        Me.lblInternationalBusiness.AutoSize = True
        Me.lblInternationalBusiness.Location = New System.Drawing.Point(12, 118)
        Me.lblInternationalBusiness.Name = "lblInternationalBusiness"
        Me.lblInternationalBusiness.Size = New System.Drawing.Size(155, 17)
        Me.lblInternationalBusiness.TabIndex = 10
        Me.lblInternationalBusiness.Text = "International Business: "
        '
        'lblComments
        '
        Me.lblComments.Location = New System.Drawing.Point(12, 144)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(305, 79)
        Me.lblComments.TabIndex = 11
        Me.lblComments.Text = "Student Comments: "
        '
        'lblACC201
        '
        Me.lblACC201.AutoSize = True
        Me.lblACC201.Location = New System.Drawing.Point(348, 13)
        Me.lblACC201.Name = "lblACC201"
        Me.lblACC201.Size = New System.Drawing.Size(67, 17)
        Me.lblACC201.TabIndex = 12
        Me.lblACC201.Text = "ACC201: "
        '
        'lblACC202
        '
        Me.lblACC202.AutoSize = True
        Me.lblACC202.Location = New System.Drawing.Point(348, 36)
        Me.lblACC202.Name = "lblACC202"
        Me.lblACC202.Size = New System.Drawing.Size(67, 17)
        Me.lblACC202.TabIndex = 13
        Me.lblACC202.Text = "ACC202: "
        '
        'lblECON102
        '
        Me.lblECON102.AutoSize = True
        Me.lblECON102.Location = New System.Drawing.Point(348, 63)
        Me.lblECON102.Name = "lblECON102"
        Me.lblECON102.Size = New System.Drawing.Size(79, 17)
        Me.lblECON102.TabIndex = 14
        Me.lblECON102.Text = "ECON102: "
        '
        'lblECON103
        '
        Me.lblECON103.AutoSize = True
        Me.lblECON103.Location = New System.Drawing.Point(348, 80)
        Me.lblECON103.Name = "lblECON103"
        Me.lblECON103.Size = New System.Drawing.Size(79, 17)
        Me.lblECON103.TabIndex = 15
        Me.lblECON103.Text = "ECON103: "
        '
        'lblECON261
        '
        Me.lblECON261.AutoSize = True
        Me.lblECON261.Location = New System.Drawing.Point(348, 97)
        Me.lblECON261.Name = "lblECON261"
        Me.lblECON261.Size = New System.Drawing.Size(79, 17)
        Me.lblECON261.TabIndex = 16
        Me.lblECON261.Text = "ECON261: "
        '
        'lblECON262
        '
        Me.lblECON262.AutoSize = True
        Me.lblECON262.Location = New System.Drawing.Point(348, 114)
        Me.lblECON262.Name = "lblECON262"
        Me.lblECON262.Size = New System.Drawing.Size(79, 17)
        Me.lblECON262.TabIndex = 17
        Me.lblECON262.Text = "ECON262: "
        '
        'lblIS101
        '
        Me.lblIS101.AutoSize = True
        Me.lblIS101.Location = New System.Drawing.Point(351, 144)
        Me.lblIS101.Name = "lblIS101"
        Me.lblIS101.Size = New System.Drawing.Size(52, 17)
        Me.lblIS101.TabIndex = 18
        Me.lblIS101.Text = "IS101: "
        '
        'lblMATH176
        '
        Me.lblMATH176.AutoSize = True
        Me.lblMATH176.Location = New System.Drawing.Point(348, 178)
        Me.lblMATH176.Name = "lblMATH176"
        Me.lblMATH176.Size = New System.Drawing.Size(79, 17)
        Me.lblMATH176.TabIndex = 19
        Me.lblMATH176.Text = "MATH176: "
        '
        'lblMKT210
        '
        Me.lblMKT210.AutoSize = True
        Me.lblMKT210.Location = New System.Drawing.Point(348, 206)
        Me.lblMKT210.Name = "lblMKT210"
        Me.lblMKT210.Size = New System.Drawing.Size(69, 17)
        Me.lblMKT210.TabIndex = 20
        Me.lblMKT210.Text = "MKT210: "
        '
        'frmDisplayStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 638)
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
        Me.Text = "Form1"
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
End Class
