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
        Me.TextBoxGun = New System.Windows.Forms.TextBox()
        Me.TextBoxSonuc = New System.Windows.Forms.TextBox()
        Me.ButtonGoster = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxGun
        '
        Me.TextBoxGun.Location = New System.Drawing.Point(68, 43)
        Me.TextBoxGun.Name = "TextBoxGun"
        Me.TextBoxGun.Size = New System.Drawing.Size(145, 22)
        Me.TextBoxGun.TabIndex = 0
        '
        'TextBoxSonuc
        '
        Me.TextBoxSonuc.Location = New System.Drawing.Point(68, 121)
        Me.TextBoxSonuc.Name = "TextBoxSonuc"
        Me.TextBoxSonuc.Size = New System.Drawing.Size(145, 22)
        Me.TextBoxSonuc.TabIndex = 1
        '
        'ButtonGoster
        '
        Me.ButtonGoster.Location = New System.Drawing.Point(68, 71)
        Me.ButtonGoster.Name = "ButtonGoster"
        Me.ButtonGoster.Size = New System.Drawing.Size(90, 35)
        Me.ButtonGoster.TabIndex = 2
        Me.ButtonGoster.Text = "Göster"
        Me.ButtonGoster.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Günler:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sonuç:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 170)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonGoster)
        Me.Controls.Add(Me.TextBoxSonuc)
        Me.Controls.Add(Me.TextBoxGun)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxGun As TextBox
    Friend WithEvents TextBoxSonuc As TextBox
    Friend WithEvents ButtonGoster As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
