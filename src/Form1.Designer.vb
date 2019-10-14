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
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.aboutVersion = New System.Windows.Forms.PictureBox()
        Me.UIDLabel = New System.Windows.Forms.Label()
        Me.UIDHelpLabel = New System.Windows.Forms.Label()
        Me.SoundChkBox = New System.Windows.Forms.CheckBox()
        Me.Tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PlayImage = New System.Windows.Forms.PictureBox()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aboutVersion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(150, 30)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.logo.TabIndex = 1
        Me.logo.TabStop = False
        '
        'aboutVersion
        '
        Me.aboutVersion.BackColor = System.Drawing.Color.Transparent
        Me.aboutVersion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aboutVersion.Image = CType(resources.GetObject("aboutVersion.Image"), System.Drawing.Image)
        Me.aboutVersion.Location = New System.Drawing.Point(230, 22)
        Me.aboutVersion.Name = "aboutVersion"
        Me.aboutVersion.Size = New System.Drawing.Size(41, 10)
        Me.aboutVersion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.aboutVersion.TabIndex = 2
        Me.aboutVersion.TabStop = False
        Me.Tooltip.SetToolTip(Me.aboutVersion, "About Screendere Beat")
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
        Me.SoundChkBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SoundChkBox.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoundChkBox.ForeColor = System.Drawing.Color.White
        Me.SoundChkBox.Location = New System.Drawing.Point(13, 120)
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
        Me.PlayImage.Location = New System.Drawing.Point(220, 50)
        Me.PlayImage.Name = "PlayImage"
        Me.PlayImage.Size = New System.Drawing.Size(50, 53)
        Me.PlayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PlayImage.TabIndex = 5
        Me.PlayImage.TabStop = False
        Me.Tooltip.SetToolTip(Me.PlayImage, "Play Hinedere Beat")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(284, 146)
        Me.Controls.Add(Me.PlayImage)
        Me.Controls.Add(Me.SoundChkBox)
        Me.Controls.Add(Me.UIDHelpLabel)
        Me.Controls.Add(Me.UIDLabel)
        Me.Controls.Add(Me.aboutVersion)
        Me.Controls.Add(Me.logo)
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
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aboutVersion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UIDTextBox As TextBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents aboutVersion As PictureBox
    Friend WithEvents UIDLabel As Label
    Friend WithEvents UIDHelpLabel As Label
    Friend WithEvents SoundChkBox As CheckBox
    Friend WithEvents Tooltip As ToolTip
    Friend WithEvents PlayImage As PictureBox
End Class
