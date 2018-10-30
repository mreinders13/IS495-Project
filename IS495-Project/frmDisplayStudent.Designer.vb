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
        Me.lblComments.AutoSize = True
        Me.lblComments.Location = New System.Drawing.Point(12, 144)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(135, 17)
        Me.lblComments.TabIndex = 11
        Me.lblComments.Text = "Student Comments: "
        '
        'frmDisplayStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 638)
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
End Class
