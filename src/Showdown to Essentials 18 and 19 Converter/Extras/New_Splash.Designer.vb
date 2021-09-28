<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Splash
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
        Me.ApplicationTitle = New Showdown_to_Essentials_18_and_19_Converter.BonfireLabelHeader()
        Me.Version = New Showdown_to_Essentials_18_and_19_Converter.BonfireLabelHeader()
        Me.Copyright = New Showdown_to_Essentials_18_and_19_Converter.BonfireLabel()
        Me.BonfireLabelHeader1 = New Showdown_to_Essentials_18_and_19_Converter.BonfireLabelHeader()
        Me.SuspendLayout()
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.AutoSize = True
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ApplicationTitle.Location = New System.Drawing.Point(12, 9)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(64, 25)
        Me.ApplicationTitle.TabIndex = 0
        Me.ApplicationTitle.Text = "Title"
        '
        'Version
        '
        Me.Version.AutoSize = True
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Version.Location = New System.Drawing.Point(12, 34)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(207, 17)
        Me.Version.TabIndex = 1
        Me.Version.Text = "Version {0}.{1}.{2}.{3}"
        '
        'Copyright
        '
        Me.Copyright.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Copyright.AutoSize = True
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Copyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.Copyright.Location = New System.Drawing.Point(476, 368)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(205, 13)
        Me.Copyright.TabIndex = 2
        Me.Copyright.Text = "Copyright © TheCrafters001 20XX"
        '
        'BonfireLabelHeader1
        '
        Me.BonfireLabelHeader1.AutoSize = True
        Me.BonfireLabelHeader1.BackColor = System.Drawing.Color.Transparent
        Me.BonfireLabelHeader1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BonfireLabelHeader1.Location = New System.Drawing.Point(12, 364)
        Me.BonfireLabelHeader1.Name = "BonfireLabelHeader1"
        Me.BonfireLabelHeader1.Size = New System.Drawing.Size(194, 17)
        Me.BonfireLabelHeader1.TabIndex = 3
        Me.BonfireLabelHeader1.Text = "Loading... Please Wait..."
        '
        'New_Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Showdown_to_Essentials_18_and_19_Converter.My.Resources.Resources.Thumbnail_19_New
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(693, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.BonfireLabelHeader1)
        Me.Controls.Add(Me.Copyright)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.ApplicationTitle)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "New_Splash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ApplicationTitle As BonfireLabelHeader
    Friend WithEvents Version As BonfireLabelHeader
    Friend WithEvents Copyright As BonfireLabel
    Friend WithEvents BonfireLabelHeader1 As BonfireLabelHeader
End Class
