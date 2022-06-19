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
        Me.PleaseWait_LBL = New System.Windows.Forms.Label()
        Me.CopyrightLBL = New System.Windows.Forms.Label()
        Me.VersionLBL = New System.Windows.Forms.Label()
        Me.EasyHTML_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PleaseWait_LBL
        '
        Me.PleaseWait_LBL.AutoSize = True
        Me.PleaseWait_LBL.BackColor = System.Drawing.Color.Transparent
        Me.PleaseWait_LBL.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PleaseWait_LBL.Location = New System.Drawing.Point(12, 353)
        Me.PleaseWait_LBL.Name = "PleaseWait_LBL"
        Me.PleaseWait_LBL.Size = New System.Drawing.Size(230, 30)
        Me.PleaseWait_LBL.TabIndex = 7
        Me.PleaseWait_LBL.Text = "Loading... Please Wait..."
        '
        'CopyrightLBL
        '
        Me.CopyrightLBL.AutoSize = True
        Me.CopyrightLBL.BackColor = System.Drawing.Color.Transparent
        Me.CopyrightLBL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyrightLBL.Location = New System.Drawing.Point(520, 370)
        Me.CopyrightLBL.Name = "CopyrightLBL"
        Me.CopyrightLBL.Size = New System.Drawing.Size(178, 13)
        Me.CopyrightLBL.TabIndex = 6
        Me.CopyrightLBL.Text = "Copyright © TheCrafters001 20XX"
        '
        'VersionLBL
        '
        Me.VersionLBL.AutoSize = True
        Me.VersionLBL.BackColor = System.Drawing.Color.Transparent
        Me.VersionLBL.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLBL.ForeColor = System.Drawing.Color.Black
        Me.VersionLBL.Location = New System.Drawing.Point(16, 46)
        Me.VersionLBL.Name = "VersionLBL"
        Me.VersionLBL.Size = New System.Drawing.Size(111, 21)
        Me.VersionLBL.TabIndex = 5
        Me.VersionLBL.Text = "Version X.X.X.X"
        '
        'EasyHTML_lbl
        '
        Me.EasyHTML_lbl.AutoSize = True
        Me.EasyHTML_lbl.BackColor = System.Drawing.Color.Transparent
        Me.EasyHTML_lbl.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EasyHTML_lbl.ForeColor = System.Drawing.Color.Black
        Me.EasyHTML_lbl.Location = New System.Drawing.Point(12, 9)
        Me.EasyHTML_lbl.Name = "EasyHTML_lbl"
        Me.EasyHTML_lbl.Size = New System.Drawing.Size(424, 37)
        Me.EasyHTML_lbl.TabIndex = 4
        Me.EasyHTML_lbl.Text = "Showdown to Essentials Converter"
        '
        'New_Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Launcher.My.Resources.Resources.Thumbnail_19_New
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(710, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.PleaseWait_LBL)
        Me.Controls.Add(Me.CopyrightLBL)
        Me.Controls.Add(Me.VersionLBL)
        Me.Controls.Add(Me.EasyHTML_lbl)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "New_Splash"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New_Splash"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PleaseWait_LBL As Label
    Friend WithEvents CopyrightLBL As Label
    Friend WithEvents VersionLBL As Label
    Friend WithEvents EasyHTML_lbl As Label
End Class
