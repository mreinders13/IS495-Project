<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblMichaelHendrickReinders = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblChrisName = New System.Windows.Forms.Label()
        Me.lblJenTruong = New System.Windows.Forms.Label()
        Me.btnOpenProj = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMichaelHendrickReinders
        '
        Me.lblMichaelHendrickReinders.AutoSize = True
        Me.lblMichaelHendrickReinders.Location = New System.Drawing.Point(10, 11)
        Me.lblMichaelHendrickReinders.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMichaelHendrickReinders.Name = "lblMichaelHendrickReinders"
        Me.lblMichaelHendrickReinders.Size = New System.Drawing.Size(138, 13)
        Me.lblMichaelHendrickReinders.TabIndex = 0
        Me.lblMichaelHendrickReinders.Text = "Michael Hendrick Reinders "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Steven Rubio"
        '
        'lblChrisName
        '
        Me.lblChrisName.AutoSize = True
        Me.lblChrisName.Location = New System.Drawing.Point(12, 51)
        Me.lblChrisName.Name = "lblChrisName"
        Me.lblChrisName.Size = New System.Drawing.Size(116, 13)
        Me.lblChrisName.TabIndex = 2
        Me.lblChrisName.Text = "Christopher Edison Lee"
        '
        'lblJenTruong
        '
        Me.lblJenTruong.AutoSize = True
        Me.lblJenTruong.Location = New System.Drawing.Point(13, 78)
        Me.lblJenTruong.Name = "lblJenTruong"
        Me.lblJenTruong.Size = New System.Drawing.Size(81, 13)
        Me.lblJenTruong.TabIndex = 3
        Me.lblJenTruong.Text = "Jennifer Truong"
        '
        'btnOpenProj
        '
        Me.btnOpenProj.Location = New System.Drawing.Point(52, 128)
        Me.btnOpenProj.Name = "btnOpenProj"
        Me.btnOpenProj.Size = New System.Drawing.Size(440, 90)
        Me.btnOpenProj.TabIndex = 4
        Me.btnOpenProj.Text = "GO TO PROJECT"
        Me.btnOpenProj.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.btnOpenProj)
        Me.Controls.Add(Me.lblJenTruong)
        Me.Controls.Add(Me.lblChrisName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMichaelHendrickReinders)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMichaelHendrickReinders As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblChrisName As Label
    Friend WithEvents lblJenTruong As Label
    Friend WithEvents btnOpenProj As Button
End Class
