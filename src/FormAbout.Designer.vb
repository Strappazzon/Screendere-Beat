<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAbout))
        Me.AboutLabel = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.HomepageLabel = New System.Windows.Forms.Label()
        Me.Support = New System.Windows.Forms.Label()
        Me.ChangelogLabel = New System.Windows.Forms.Label()
        Me.LicenseLabel = New System.Windows.Forms.Label()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AboutLabel
        '
        Me.AboutLabel.AutoSize = True
        Me.AboutLabel.BackColor = System.Drawing.Color.Transparent
        Me.AboutLabel.ForeColor = System.Drawing.Color.White
        Me.AboutLabel.Location = New System.Drawing.Point(12, 50)
        Me.AboutLabel.Name = "AboutLabel"
        Me.AboutLabel.Size = New System.Drawing.Size(391, 90)
        Me.AboutLabel.TabIndex = 0
        Me.AboutLabel.Text = resources.GetString("AboutLabel.Text")
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(12, 12)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(150, 30)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.logo.TabIndex = 2
        Me.logo.TabStop = False
        '
        'HomepageLabel
        '
        Me.HomepageLabel.AutoSize = True
        Me.HomepageLabel.BackColor = System.Drawing.Color.Transparent
        Me.HomepageLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HomepageLabel.Font = New System.Drawing.Font("MS Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomepageLabel.ForeColor = System.Drawing.Color.White
        Me.HomepageLabel.Location = New System.Drawing.Point(14, 155)
        Me.HomepageLabel.Name = "HomepageLabel"
        Me.HomepageLabel.Size = New System.Drawing.Size(113, 12)
        Me.HomepageLabel.TabIndex = 3
        Me.HomepageLabel.Text = "> Official Website"
        '
        'Support
        '
        Me.Support.AutoSize = True
        Me.Support.BackColor = System.Drawing.Color.Transparent
        Me.Support.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Support.Font = New System.Drawing.Font("MS Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Support.ForeColor = System.Drawing.Color.White
        Me.Support.Location = New System.Drawing.Point(14, 175)
        Me.Support.Name = "Support"
        Me.Support.Size = New System.Drawing.Size(59, 12)
        Me.Support.TabIndex = 4
        Me.Support.Text = "> Support"
        '
        'ChangelogLabel
        '
        Me.ChangelogLabel.AutoSize = True
        Me.ChangelogLabel.BackColor = System.Drawing.Color.Transparent
        Me.ChangelogLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChangelogLabel.Font = New System.Drawing.Font("MS Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangelogLabel.ForeColor = System.Drawing.Color.White
        Me.ChangelogLabel.Location = New System.Drawing.Point(330, 155)
        Me.ChangelogLabel.Name = "ChangelogLabel"
        Me.ChangelogLabel.Size = New System.Drawing.Size(71, 12)
        Me.ChangelogLabel.TabIndex = 5
        Me.ChangelogLabel.Text = "Changelog <"
        '
        'LicenseLabel
        '
        Me.LicenseLabel.AutoSize = True
        Me.LicenseLabel.BackColor = System.Drawing.Color.Transparent
        Me.LicenseLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LicenseLabel.Font = New System.Drawing.Font("MS Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LicenseLabel.ForeColor = System.Drawing.Color.White
        Me.LicenseLabel.Location = New System.Drawing.Point(342, 175)
        Me.LicenseLabel.Name = "LicenseLabel"
        Me.LicenseLabel.Size = New System.Drawing.Size(59, 12)
        Me.LicenseLabel.TabIndex = 6
        Me.LicenseLabel.Text = "License <"
        '
        'FormAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(414, 201)
        Me.Controls.Add(Me.LicenseLabel)
        Me.Controls.Add(Me.ChangelogLabel)
        Me.Controls.Add(Me.Support)
        Me.Controls.Add(Me.HomepageLabel)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.AboutLabel)
        Me.Font = New System.Drawing.Font("MS Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAbout"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.TopMost = True
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AboutLabel As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents HomepageLabel As Label
    Friend WithEvents Support As Label
    Friend WithEvents ChangelogLabel As Label
    Friend WithEvents LicenseLabel As Label
End Class
