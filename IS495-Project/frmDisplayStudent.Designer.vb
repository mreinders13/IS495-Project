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
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.lblStudentNSHE = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnDeny = New System.Windows.Forms.Button()
        Me.btnBridge = New System.Windows.Forms.Button()
        Me.btnNextStudent = New System.Windows.Forms.Button()
        Me.btnPrevStudent = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSaveData
        '
        Me.btnSaveData.Location = New System.Drawing.Point(163, 318)
        Me.btnSaveData.Name = "btnSaveData"
        Me.btnSaveData.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveData.TabIndex = 0
        Me.btnSaveData.Text = "Save"
        Me.btnSaveData.UseVisualStyleBackColor = True
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(9, 7)
        Me.lblStudentName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(81, 13)
        Me.lblStudentName.TabIndex = 1
        Me.lblStudentName.Text = "Student Name: "
        '
        'lblStudentNSHE
        '
        Me.lblStudentNSHE.AutoSize = True
        Me.lblStudentNSHE.Location = New System.Drawing.Point(9, 29)
        Me.lblStudentNSHE.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudentNSHE.Name = "lblStudentNSHE"
        Me.lblStudentNSHE.Size = New System.Drawing.Size(90, 13)
        Me.lblStudentNSHE.TabIndex = 2
        Me.lblStudentNSHE.Text = "Student NSHE#: "
        '
        'btnAccept
        '
        Me.btnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert
        Me.btnAccept.Location = New System.Drawing.Point(80, 280)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 3
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnDeny
        '
        Me.btnDeny.Location = New System.Drawing.Point(246, 280)
        Me.btnDeny.Name = "btnDeny"
        Me.btnDeny.Size = New System.Drawing.Size(75, 23)
        Me.btnDeny.TabIndex = 4
        Me.btnDeny.Text = "Deny"
        Me.btnDeny.UseVisualStyleBackColor = True
        '
        'btnBridge
        '
        Me.btnBridge.Location = New System.Drawing.Point(163, 280)
        Me.btnBridge.Name = "btnBridge"
        Me.btnBridge.Size = New System.Drawing.Size(75, 23)
        Me.btnBridge.TabIndex = 5
        Me.btnBridge.Text = "Bridge"
        Me.btnBridge.UseVisualStyleBackColor = True
        '
        'btnNextStudent
        '
        Me.btnNextStudent.Location = New System.Drawing.Point(382, 485)
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
        'frmDisplayStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 518)
        Me.Controls.Add(Me.btnPrevStudent)
        Me.Controls.Add(Me.btnNextStudent)
        Me.Controls.Add(Me.btnBridge)
        Me.Controls.Add(Me.btnDeny)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.lblStudentNSHE)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.btnSaveData)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmDisplayStudent"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSaveData As Button
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblStudentNSHE As Label
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnDeny As Button
    Friend WithEvents btnBridge As Button
    Friend WithEvents btnNextStudent As Button
    Friend WithEvents btnPrevStudent As Button
End Class
