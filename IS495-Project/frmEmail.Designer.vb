<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmail
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
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblBody = New System.Windows.Forms.Label()
        Me.lblAttachment = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.lnkAttach = New System.Windows.Forms.LinkLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(85, 12)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(249, 20)
        Me.txtTo.TabIndex = 0
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(85, 38)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(249, 20)
        Me.txtSubject.TabIndex = 1
        '
        'txtBody
        '
        Me.txtBody.Location = New System.Drawing.Point(85, 64)
        Me.txtBody.MinimumSize = New System.Drawing.Size(4, 40)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(249, 126)
        Me.txtBody.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(85, 224)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(249, 20)
        Me.txtEmail.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(85, 250)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(249, 20)
        Me.txtPassword.TabIndex = 4
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(12, 19)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 5
        Me.lblTo.Text = "To:"
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(12, 45)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(46, 13)
        Me.lblSubject.TabIndex = 6
        Me.lblSubject.Text = "Subject:"
        '
        'lblBody
        '
        Me.lblBody.AutoSize = True
        Me.lblBody.Location = New System.Drawing.Point(12, 71)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.Size = New System.Drawing.Size(34, 13)
        Me.lblBody.TabIndex = 7
        Me.lblBody.Text = "Body:"
        '
        'lblAttachment
        '
        Me.lblAttachment.AutoSize = True
        Me.lblAttachment.Location = New System.Drawing.Point(12, 193)
        Me.lblAttachment.Name = "lblAttachment"
        Me.lblAttachment.Size = New System.Drawing.Size(64, 13)
        Me.lblAttachment.TabIndex = 9
        Me.lblAttachment.Text = "Attachment:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 231)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 257)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 11
        Me.lblPassword.Text = "Password:"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(85, 284)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(111, 23)
        Me.btnSend.TabIndex = 12
        Me.btnSend.Text = "Send Email"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'lnkAttach
        '
        Me.lnkAttach.AutoSize = True
        Me.lnkAttach.Location = New System.Drawing.Point(82, 193)
        Me.lnkAttach.Name = "lnkAttach"
        Me.lnkAttach.Size = New System.Drawing.Size(61, 13)
        Me.lnkAttach.TabIndex = 13
        Me.lnkAttach.TabStop = True
        Me.lnkAttach.Text = "Attachment"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 319)
        Me.Controls.Add(Me.lnkAttach)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblAttachment)
        Me.Controls.Add(Me.lblBody)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.lblTo)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtBody)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtTo)
        Me.Name = "frmEmail"
        Me.Text = "Email Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTo As TextBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents txtBody As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblTo As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblBody As Label
    Friend WithEvents lblAttachment As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnSend As Button
    Friend WithEvents lnkAttach As LinkLabel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
