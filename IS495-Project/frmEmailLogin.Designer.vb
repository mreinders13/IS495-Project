<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmailLogin
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
        Me.lblEmailLogin = New System.Windows.Forms.Label()
        Me.txtEmailLogin = New System.Windows.Forms.TextBox()
        Me.txtEmailPassword = New System.Windows.Forms.TextBox()
        Me.lblEmailPassword = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEmailLogin
        '
        Me.lblEmailLogin.AutoSize = True
        Me.lblEmailLogin.Location = New System.Drawing.Point(12, 19)
        Me.lblEmailLogin.Name = "lblEmailLogin"
        Me.lblEmailLogin.Size = New System.Drawing.Size(35, 13)
        Me.lblEmailLogin.TabIndex = 0
        Me.lblEmailLogin.Text = "Email:"
        '
        'txtEmailLogin
        '
        Me.txtEmailLogin.Location = New System.Drawing.Point(53, 12)
        Me.txtEmailLogin.Name = "txtEmailLogin"
        Me.txtEmailLogin.Size = New System.Drawing.Size(145, 20)
        Me.txtEmailLogin.TabIndex = 1
        '
        'txtEmailPassword
        '
        Me.txtEmailPassword.Location = New System.Drawing.Point(266, 12)
        Me.txtEmailPassword.Name = "txtEmailPassword"
        Me.txtEmailPassword.Size = New System.Drawing.Size(145, 20)
        Me.txtEmailPassword.TabIndex = 3
        '
        'lblEmailPassword
        '
        Me.lblEmailPassword.AutoSize = True
        Me.lblEmailPassword.Location = New System.Drawing.Point(204, 19)
        Me.lblEmailPassword.Name = "lblEmailPassword"
        Me.lblEmailPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblEmailPassword.TabIndex = 2
        Me.lblEmailPassword.Text = "Password:"
        '
        'btnContinue
        '
        Me.btnContinue.Location = New System.Drawing.Point(155, 38)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(137, 23)
        Me.btnContinue.TabIndex = 4
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'frmEmailLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 76)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtEmailPassword)
        Me.Controls.Add(Me.lblEmailPassword)
        Me.Controls.Add(Me.txtEmailLogin)
        Me.Controls.Add(Me.lblEmailLogin)
        Me.Name = "frmEmailLogin"
        Me.Text = "Email Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEmailLogin As Label
    Friend WithEvents txtEmailLogin As TextBox
    Friend WithEvents txtEmailPassword As TextBox
    Friend WithEvents lblEmailPassword As Label
    Friend WithEvents btnContinue As Button
End Class
