<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNotification
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
        Me.ThumbnailBox = New System.Windows.Forms.PictureBox()
        Me.GameTitleLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ThumbnailBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ThumbnailBox
        '
        Me.ThumbnailBox.BackColor = System.Drawing.Color.Transparent
        Me.ThumbnailBox.Location = New System.Drawing.Point(5, 5)
        Me.ThumbnailBox.Name = "ThumbnailBox"
        Me.ThumbnailBox.Size = New System.Drawing.Size(85, 45)
        Me.ThumbnailBox.TabIndex = 0
        Me.ThumbnailBox.TabStop = False
        '
        'GameTitleLabel
        '
        Me.GameTitleLabel.AutoSize = True
        Me.GameTitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.GameTitleLabel.Font = New System.Drawing.Font("MS Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameTitleLabel.ForeColor = System.Drawing.Color.White
        Me.GameTitleLabel.Location = New System.Drawing.Point(95, 10)
        Me.GameTitleLabel.Name = "GameTitleLabel"
        Me.GameTitleLabel.Size = New System.Drawing.Size(111, 15)
        Me.GameTitleLabel.TabIndex = 0
        Me.GameTitleLabel.Text = "Hinedere Beat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(95, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Screenshot saved"
        '
        'FormNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(240, 74)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GameTitleLabel)
        Me.Controls.Add(Me.ThumbnailBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormNotification"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormNotification"
        Me.TopMost = True
        CType(Me.ThumbnailBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ThumbnailBox As PictureBox
    Friend WithEvents GameTitleLabel As Label
    Friend WithEvents Label1 As Label
End Class
