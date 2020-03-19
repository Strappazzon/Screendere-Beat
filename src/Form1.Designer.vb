<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.UIDTextBox = New System.Windows.Forms.TextBox()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.UIDLabel = New System.Windows.Forms.Label()
        Me.UIDHelpLabel = New System.Windows.Forms.Label()
        Me.SoundChkBox = New System.Windows.Forms.CheckBox()
        Me.Tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PlayImage = New System.Windows.Forms.PictureBox()
        Me.AboutLabel = New System.Windows.Forms.Label()
        Me.ScreenshotsDirBtn = New System.Windows.Forms.Button()
        Me.UpdatesChkBox = New System.Windows.Forms.CheckBox()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UIDTextBox
        '
        Me.UIDTextBox.BackColor = System.Drawing.Color.Black
        Me.UIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UIDTextBox.Font = New System.Drawing.Font("MS Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UIDTextBox.ForeColor = System.Drawing.Color.White
        Me.UIDTextBox.Location = New System.Drawing.Point(12, 80)
        Me.UIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UIDTextBox.MaxLength = 12
        Me.UIDTextBox.Name = "UIDTextBox"
        Me.UIDTextBox.Size = New System.Drawing.Size(150, 23)
        Me.UIDTextBox.TabIndex = 2
        '
        'Logo
        '
        Me.Logo.BackColor = System.Drawing.Color.Transparent
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(12, 12)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(150, 30)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Logo.TabIndex = 1
        Me.Logo.TabStop = False
        '
        'UIDLabel
        '
        Me.UIDLabel.AutoSize = True
        Me.UIDLabel.BackColor = System.Drawing.Color.Transparent
        Me.UIDLabel.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UIDLabel.ForeColor = System.Drawing.Color.White
        Me.UIDLabel.Location = New System.Drawing.Point(12, 60)
        Me.UIDLabel.Name = "UIDLabel"
        Me.UIDLabel.Size = New System.Drawing.Size(98, 13)
        Me.UIDLabel.TabIndex = 0
        Me.UIDLabel.Text = "Your Steam ID"
        '
        'UIDHelpLabel
        '
        Me.UIDHelpLabel.AutoSize = True
        Me.UIDHelpLabel.BackColor = System.Drawing.Color.Transparent
        Me.UIDHelpLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UIDHelpLabel.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UIDHelpLabel.ForeColor = System.Drawing.Color.White
        Me.UIDHelpLabel.Location = New System.Drawing.Point(140, 60)
        Me.UIDHelpLabel.Name = "UIDHelpLabel"
        Me.UIDHelpLabel.Size = New System.Drawing.Size(28, 13)
        Me.UIDHelpLabel.TabIndex = 1
        Me.UIDHelpLabel.Text = "[?]"
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
        Me.SoundChkBox.Location = New System.Drawing.Point(13, 117)
        Me.SoundChkBox.Name = "SoundChkBox"
        Me.SoundChkBox.Size = New System.Drawing.Size(110, 17)
        Me.SoundChkBox.TabIndex = 4
        Me.SoundChkBox.Text = "Play a Sound"
        Me.Tooltip.SetToolTip(Me.SoundChkBox, "Play a sound when a screenshot is taken")
        Me.SoundChkBox.UseVisualStyleBackColor = False
        '
        'Tooltip
        '
        Me.Tooltip.AutoPopDelay = 5000
        Me.Tooltip.BackColor = System.Drawing.Color.Black
        Me.Tooltip.ForeColor = System.Drawing.Color.White
        Me.Tooltip.InitialDelay = 200
        Me.Tooltip.OwnerDraw = True
        Me.Tooltip.ReshowDelay = 100
        Me.Tooltip.UseAnimation = False
        Me.Tooltip.UseFading = False
        '
        'PlayImage
        '
        Me.PlayImage.BackColor = System.Drawing.Color.Transparent
        Me.PlayImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlayImage.Image = CType(resources.GetObject("PlayImage.Image"), System.Drawing.Image)
        Me.PlayImage.Location = New System.Drawing.Point(210, 50)
        Me.PlayImage.Name = "PlayImage"
        Me.PlayImage.Size = New System.Drawing.Size(50, 53)
        Me.PlayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PlayImage.TabIndex = 5
        Me.PlayImage.TabStop = False
        Me.Tooltip.SetToolTip(Me.PlayImage, "Play Hinedere Beat")
        '
        'AboutLabel
        '
        Me.AboutLabel.AutoSize = True
        Me.AboutLabel.BackColor = System.Drawing.Color.Transparent
        Me.AboutLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AboutLabel.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutLabel.ForeColor = System.Drawing.Color.White
        Me.AboutLabel.Location = New System.Drawing.Point(214, 22)
        Me.AboutLabel.Name = "AboutLabel"
        Me.AboutLabel.Size = New System.Drawing.Size(49, 13)
        Me.AboutLabel.TabIndex = 5
        Me.AboutLabel.Text = "v1.4.0"
        Me.Tooltip.SetToolTip(Me.AboutLabel, "About Screendere Beat")
        '
        'ScreenshotsDirBtn
        '
        Me.ScreenshotsDirBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ScreenshotsDirBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ScreenshotsDirBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ScreenshotsDirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ScreenshotsDirBtn.ForeColor = System.Drawing.Color.White
        Me.ScreenshotsDirBtn.Image = CType(resources.GetObject("ScreenshotsDirBtn.Image"), System.Drawing.Image)
        Me.ScreenshotsDirBtn.Location = New System.Drawing.Point(169, 80)
        Me.ScreenshotsDirBtn.Name = "ScreenshotsDirBtn"
        Me.ScreenshotsDirBtn.Size = New System.Drawing.Size(23, 23)
        Me.ScreenshotsDirBtn.TabIndex = 3
        Me.Tooltip.SetToolTip(Me.ScreenshotsDirBtn, "Open the screenshots folder")
        Me.ScreenshotsDirBtn.UseVisualStyleBackColor = False
        '
        'UpdatesChkBox
        '
        Me.UpdatesChkBox.AutoSize = True
        Me.UpdatesChkBox.BackColor = System.Drawing.Color.Transparent
        Me.UpdatesChkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UpdatesChkBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdatesChkBox.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdatesChkBox.ForeColor = System.Drawing.Color.White
        Me.UpdatesChkBox.Location = New System.Drawing.Point(143, 117)
        Me.UpdatesChkBox.Name = "UpdatesChkBox"
        Me.UpdatesChkBox.Size = New System.Drawing.Size(117, 17)
        Me.UpdatesChkBox.TabIndex = 6
        Me.UpdatesChkBox.Text = "Check Updates"
        Me.Tooltip.SetToolTip(Me.UpdatesChkBox, "Check for updates when you open Screendere Beat")
        Me.UpdatesChkBox.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(274, 146)
        Me.Controls.Add(Me.UpdatesChkBox)
        Me.Controls.Add(Me.ScreenshotsDirBtn)
        Me.Controls.Add(Me.AboutLabel)
        Me.Controls.Add(Me.PlayImage)
        Me.Controls.Add(Me.SoundChkBox)
        Me.Controls.Add(Me.UIDHelpLabel)
        Me.Controls.Add(Me.UIDLabel)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.UIDTextBox)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("MS Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Screendere Beat"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UIDTextBox As TextBox
    Friend WithEvents Logo As PictureBox
    Friend WithEvents UIDLabel As Label
    Friend WithEvents UIDHelpLabel As Label
    Friend WithEvents SoundChkBox As CheckBox
    Friend WithEvents Tooltip As ToolTip
    Friend WithEvents PlayImage As PictureBox
    Friend WithEvents AboutLabel As Label
    Friend WithEvents ScreenshotsDirBtn As Button
    Friend WithEvents UpdatesChkBox As CheckBox
End Class
