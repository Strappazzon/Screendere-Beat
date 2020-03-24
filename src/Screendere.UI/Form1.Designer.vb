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
        Me.UIDLabel = New System.Windows.Forms.Label()
        Me.UIDHelpLabel = New System.Windows.Forms.Label()
        Me.Tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PlayBtn = New System.Windows.Forms.Button()
        Me.AboutBtn = New System.Windows.Forms.Button()
        Me.SettingsBtn = New System.Windows.Forms.Button()
        Me.ScreenshotsDirBtn = New System.Windows.Forms.Button()
        Me.AboutLabel = New System.Windows.Forms.Label()
        Me.Logo = New System.Windows.Forms.PictureBox()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PlayBtn
        '
        Me.PlayBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.PlayBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.PlayBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PlayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayBtn.ForeColor = System.Drawing.Color.White
        Me.PlayBtn.Location = New System.Drawing.Point(198, 80)
        Me.PlayBtn.Name = "PlayBtn"
        Me.PlayBtn.Size = New System.Drawing.Size(52, 23)
        Me.PlayBtn.TabIndex = 7
        Me.PlayBtn.Text = "Play"
        Me.Tooltip.SetToolTip(Me.PlayBtn, "Play Hinedere Beat")
        Me.PlayBtn.UseVisualStyleBackColor = False
        '
        'AboutBtn
        '
        Me.AboutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.AboutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.AboutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboutBtn.Image = Global.Screendere.My.Resources.Resources.Info_Icon
        Me.AboutBtn.Location = New System.Drawing.Point(227, 50)
        Me.AboutBtn.Name = "AboutBtn"
        Me.AboutBtn.Size = New System.Drawing.Size(23, 23)
        Me.AboutBtn.TabIndex = 6
        Me.Tooltip.SetToolTip(Me.AboutBtn, "About Screendere Beat")
        Me.AboutBtn.UseVisualStyleBackColor = False
        '
        'SettingsBtn
        '
        Me.SettingsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.SettingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.SettingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsBtn.Image = Global.Screendere.My.Resources.Resources.Settings_Icon
        Me.SettingsBtn.Location = New System.Drawing.Point(198, 50)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Size = New System.Drawing.Size(23, 23)
        Me.SettingsBtn.TabIndex = 5
        Me.Tooltip.SetToolTip(Me.SettingsBtn, "Settings")
        Me.SettingsBtn.UseVisualStyleBackColor = False
        '
        'ScreenshotsDirBtn
        '
        Me.ScreenshotsDirBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ScreenshotsDirBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.ScreenshotsDirBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ScreenshotsDirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ScreenshotsDirBtn.Image = Global.Screendere.My.Resources.Resources.Folder_Icon
        Me.ScreenshotsDirBtn.Location = New System.Drawing.Point(169, 80)
        Me.ScreenshotsDirBtn.Name = "ScreenshotsDirBtn"
        Me.ScreenshotsDirBtn.Size = New System.Drawing.Size(23, 23)
        Me.ScreenshotsDirBtn.TabIndex = 3
        Me.Tooltip.SetToolTip(Me.ScreenshotsDirBtn, "Open the screenshots folder")
        Me.ScreenshotsDirBtn.UseVisualStyleBackColor = False
        '
        'AboutLabel
        '
        Me.AboutLabel.AutoSize = True
        Me.AboutLabel.BackColor = System.Drawing.Color.Transparent
        Me.AboutLabel.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutLabel.ForeColor = System.Drawing.Color.White
        Me.AboutLabel.Location = New System.Drawing.Point(208, 22)
        Me.AboutLabel.Name = "AboutLabel"
        Me.AboutLabel.Size = New System.Drawing.Size(49, 13)
        Me.AboutLabel.TabIndex = 4
        Me.AboutLabel.Text = "v1.5.0"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(262, 116)
        Me.Controls.Add(Me.PlayBtn)
        Me.Controls.Add(Me.AboutBtn)
        Me.Controls.Add(Me.SettingsBtn)
        Me.Controls.Add(Me.ScreenshotsDirBtn)
        Me.Controls.Add(Me.AboutLabel)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UIDTextBox As TextBox
    Friend WithEvents Logo As PictureBox
    Friend WithEvents UIDLabel As Label
    Friend WithEvents UIDHelpLabel As Label
    Friend WithEvents Tooltip As ToolTip
    Friend WithEvents AboutLabel As Label
    Friend WithEvents ScreenshotsDirBtn As Button
    Friend WithEvents SettingsBtn As Button
    Friend WithEvents AboutBtn As Button
    Friend WithEvents PlayBtn As Button
End Class
