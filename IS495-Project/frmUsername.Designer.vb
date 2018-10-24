<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsername
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnEntrySubmit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCurrentSemester = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.btnOpenFileDialog = New System.Windows.Forms.Button()
        Me.lblFilePath_Prompt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(73, 6)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(203, 20)
        Me.txtUsername.TabIndex = 0
        '
        'btnEntrySubmit
        '
        Me.btnEntrySubmit.Location = New System.Drawing.Point(12, 81)
        Me.btnEntrySubmit.Name = "btnEntrySubmit"
        Me.btnEntrySubmit.Size = New System.Drawing.Size(529, 23)
        Me.btnEntrySubmit.TabIndex = 1
        Me.btnEntrySubmit.Text = "Submit and Continue"
        Me.btnEntrySubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnEntrySubmit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(282, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Semester"
        '
        'txtCurrentSemester
        '
        Me.txtCurrentSemester.Location = New System.Drawing.Point(339, 6)
        Me.txtCurrentSemester.Name = "txtCurrentSemester"
        Me.txtCurrentSemester.Size = New System.Drawing.Size(203, 20)
        Me.txtCurrentSemester.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Username"
        '
        'btnOpenFileDialog
        '
        Me.btnOpenFileDialog.Location = New System.Drawing.Point(12, 32)
        Me.btnOpenFileDialog.Name = "btnOpenFileDialog"
        Me.btnOpenFileDialog.Size = New System.Drawing.Size(99, 23)
        Me.btnOpenFileDialog.TabIndex = 7
        Me.btnOpenFileDialog.Text = "Select a file"
        Me.btnOpenFileDialog.UseVisualStyleBackColor = True
        '
        'lblFilePath_Prompt
        '
        Me.lblFilePath_Prompt.AutoSize = True
        Me.lblFilePath_Prompt.Location = New System.Drawing.Point(117, 37)
        Me.lblFilePath_Prompt.Name = "lblFilePath_Prompt"
        Me.lblFilePath_Prompt.Size = New System.Drawing.Size(126, 13)
        Me.lblFilePath_Prompt.TabIndex = 8
        Me.lblFilePath_Prompt.Text = "No file currently selected."
        '
        'frmUsername
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 116)
        Me.Controls.Add(Me.lblFilePath_Prompt)
        Me.Controls.Add(Me.btnOpenFileDialog)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCurrentSemester)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEntrySubmit)
        Me.Controls.Add(Me.txtUsername)
        Me.Name = "frmUsername"
        Me.Text = "frmUsername"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnEntrySubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCurrentSemester As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ofdOpenFile As OpenFileDialog
    Friend WithEvents btnOpenFileDialog As Button
    Friend WithEvents lblFilePath_Prompt As Label
End Class
