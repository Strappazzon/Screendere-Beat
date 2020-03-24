<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSettings
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
        Me.ScreenshotLabel = New System.Windows.Forms.Label()
        Me.UpdatesChkBox = New System.Windows.Forms.CheckBox()
        Me.SoundChkBox = New System.Windows.Forms.CheckBox()
        Me.ScreendereLabel = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.NotificationChkBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ScreenshotLabel
        '
        Me.ScreenshotLabel.AutoSize = True
        Me.ScreenshotLabel.BackColor = System.Drawing.Color.Transparent
        Me.ScreenshotLabel.ForeColor = System.Drawing.Color.White
        Me.ScreenshotLabel.Location = New System.Drawing.Point(14, 14)
        Me.ScreenshotLabel.Name = "ScreenshotLabel"
        Me.ScreenshotLabel.Size = New System.Drawing.Size(215, 15)
        Me.ScreenshotLabel.TabIndex = 0
        Me.ScreenshotLabel.Text = "When a screenshot is taken"
        '
        'UpdatesChkBox
        '
        Me.UpdatesChkBox.AutoSize = True
        Me.UpdatesChkBox.BackColor = System.Drawing.Color.Transparent
        Me.UpdatesChkBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdatesChkBox.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdatesChkBox.ForeColor = System.Drawing.Color.White
        Me.UpdatesChkBox.Location = New System.Drawing.Point(22, 131)
        Me.UpdatesChkBox.Name = "UpdatesChkBox"
        Me.UpdatesChkBox.Size = New System.Drawing.Size(145, 17)
        Me.UpdatesChkBox.TabIndex = 4
        Me.UpdatesChkBox.Text = "Check for Updates"
        Me.UpdatesChkBox.UseVisualStyleBackColor = False
        '
        'SoundChkBox
        '
        Me.SoundChkBox.AutoSize = True
        Me.SoundChkBox.BackColor = System.Drawing.Color.Transparent
        Me.SoundChkBox.Checked = True
        Me.SoundChkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SoundChkBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SoundChkBox.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoundChkBox.ForeColor = System.Drawing.Color.White
        Me.SoundChkBox.Location = New System.Drawing.Point(22, 45)
        Me.SoundChkBox.Name = "SoundChkBox"
        Me.SoundChkBox.Size = New System.Drawing.Size(110, 17)
        Me.SoundChkBox.TabIndex = 1
        Me.SoundChkBox.Text = "Play a Sound"
        Me.SoundChkBox.UseVisualStyleBackColor = False
        '
        'ScreendereLabel
        '
        Me.ScreendereLabel.AutoSize = True
        Me.ScreendereLabel.BackColor = System.Drawing.Color.Transparent
        Me.ScreendereLabel.ForeColor = System.Drawing.Color.White
        Me.ScreendereLabel.Location = New System.Drawing.Point(14, 100)
        Me.ScreendereLabel.Name = "ScreendereLabel"
        Me.ScreendereLabel.Size = New System.Drawing.Size(263, 15)
        Me.ScreendereLabel.TabIndex = 3
        Me.ScreendereLabel.Text = "When Screendere Beat is launched"
        '
        'CloseBtn
        '
        Me.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.ForeColor = System.Drawing.Color.White
        Me.CloseBtn.Location = New System.Drawing.Point(227, 156)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(60, 23)
        Me.CloseBtn.TabIndex = 5
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'NotificationChkBox
        '
        Me.NotificationChkBox.AutoSize = True
        Me.NotificationChkBox.BackColor = System.Drawing.Color.Transparent
        Me.NotificationChkBox.Checked = True
        Me.NotificationChkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NotificationChkBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NotificationChkBox.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotificationChkBox.ForeColor = System.Drawing.Color.White
        Me.NotificationChkBox.Location = New System.Drawing.Point(22, 70)
        Me.NotificationChkBox.Name = "NotificationChkBox"
        Me.NotificationChkBox.Size = New System.Drawing.Size(180, 17)
        Me.NotificationChkBox.TabIndex = 2
        Me.NotificationChkBox.Text = "Display a notification"
        Me.NotificationChkBox.UseVisualStyleBackColor = False
        '
        'FormSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(299, 191)
        Me.Controls.Add(Me.NotificationChkBox)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.ScreendereLabel)
        Me.Controls.Add(Me.UpdatesChkBox)
        Me.Controls.Add(Me.SoundChkBox)
        Me.Controls.Add(Me.ScreenshotLabel)
        Me.Font = New System.Drawing.Font("MS Gothic", 11.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSettings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ScreenshotLabel As Label
    Friend WithEvents UpdatesChkBox As CheckBox
    Friend WithEvents SoundChkBox As CheckBox
    Friend WithEvents ScreendereLabel As Label
    Friend WithEvents CloseBtn As Button
    Friend WithEvents NotificationChkBox As CheckBox
End Class
