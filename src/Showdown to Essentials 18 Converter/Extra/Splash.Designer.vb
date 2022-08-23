<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PleaseWait_LBL = New System.Windows.Forms.Label()
        Me.CopyrightLBL = New System.Windows.Forms.Label()
        Me.VersionLBL = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Showdown to Essentials is Loading..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 74)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(590, 333)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PleaseWait_LBL
        '
        Me.PleaseWait_LBL.AutoSize = True
        Me.PleaseWait_LBL.BackColor = System.Drawing.Color.Transparent
        Me.PleaseWait_LBL.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PleaseWait_LBL.Location = New System.Drawing.Point(14, 410)
        Me.PleaseWait_LBL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PleaseWait_LBL.Name = "PleaseWait_LBL"
        Me.PleaseWait_LBL.Size = New System.Drawing.Size(230, 30)
        Me.PleaseWait_LBL.TabIndex = 11
        Me.PleaseWait_LBL.Text = "Loading... Please Wait..."
        '
        'CopyrightLBL
        '
        Me.CopyrightLBL.AutoSize = True
        Me.CopyrightLBL.BackColor = System.Drawing.Color.Transparent
        Me.CopyrightLBL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CopyrightLBL.Location = New System.Drawing.Point(426, 410)
        Me.CopyrightLBL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CopyrightLBL.Name = "CopyrightLBL"
        Me.CopyrightLBL.Size = New System.Drawing.Size(178, 13)
        Me.CopyrightLBL.TabIndex = 10
        Me.CopyrightLBL.Text = "Copyright © TheCrafters001 2022"
        '
        'VersionLBL
        '
        Me.VersionLBL.AutoSize = True
        Me.VersionLBL.BackColor = System.Drawing.Color.Transparent
        Me.VersionLBL.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.VersionLBL.ForeColor = System.Drawing.Color.Black
        Me.VersionLBL.Location = New System.Drawing.Point(14, 46)
        Me.VersionLBL.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.VersionLBL.Name = "VersionLBL"
        Me.VersionLBL.Size = New System.Drawing.Size(111, 21)
        Me.VersionLBL.TabIndex = 9
        Me.VersionLBL.Text = "Version X.X.X.X"
        Me.VersionLBL.Visible = False
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 454)
        Me.ControlBox = False
        Me.Controls.Add(Me.PleaseWait_LBL)
        Me.Controls.Add(Me.CopyrightLBL)
        Me.Controls.Add(Me.VersionLBL)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Please Wait..."
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PleaseWait_LBL As Label
    Friend WithEvents CopyrightLBL As Label
    Friend WithEvents VersionLBL As Label
End Class
