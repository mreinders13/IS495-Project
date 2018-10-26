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
        Me.SuspendLayout()
        '
        'btnSaveData
        '
        Me.btnSaveData.Location = New System.Drawing.Point(217, 392)
        Me.btnSaveData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSaveData.Name = "btnSaveData"
        Me.btnSaveData.Size = New System.Drawing.Size(100, 28)
        Me.btnSaveData.TabIndex = 0
        Me.btnSaveData.Text = "Save"
        Me.btnSaveData.UseVisualStyleBackColor = True
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Location = New System.Drawing.Point(12, 9)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(106, 17)
        Me.lblStudentName.TabIndex = 1
        Me.lblStudentName.Text = "Student Name: "
        '
        'lblStudentNSHE
        '
        Me.lblStudentNSHE.AutoSize = True
        Me.lblStudentNSHE.Location = New System.Drawing.Point(12, 36)
        Me.lblStudentNSHE.Name = "lblStudentNSHE"
        Me.lblStudentNSHE.Size = New System.Drawing.Size(115, 17)
        Me.lblStudentNSHE.TabIndex = 2
        Me.lblStudentNSHE.Text = "Student NSHE#: "
        '
        'frmDisplayStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 638)
        Me.Controls.Add(Me.lblStudentNSHE)
        Me.Controls.Add(Me.lblStudentName)
        Me.Controls.Add(Me.btnSaveData)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmDisplayStudent"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSaveData As Button
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents lblStudentName As Label
    Friend WithEvents lblStudentNSHE As Label
End Class
