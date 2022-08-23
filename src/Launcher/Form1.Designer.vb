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
        Me.v17_picBox = New System.Windows.Forms.PictureBox()
        Me.v18up_picBox = New System.Windows.Forms.PictureBox()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.fantool_lbl = New System.Windows.Forms.Label()
        CType(Me.v17_picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.v18up_picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'v17_picBox
        '
        Me.v17_picBox.Image = Global.Launcher.My.Resources.Resources.Essentials17Only
        Me.v17_picBox.Location = New System.Drawing.Point(12, 12)
        Me.v17_picBox.Name = "v17_picBox"
        Me.v17_picBox.Size = New System.Drawing.Size(198, 126)
        Me.v17_picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.v17_picBox.TabIndex = 0
        Me.v17_picBox.TabStop = False
        '
        'v18up_picBox
        '
        Me.v18up_picBox.Image = Global.Launcher.My.Resources.Resources.Essentials18to20
        Me.v18up_picBox.Location = New System.Drawing.Point(216, 12)
        Me.v18up_picBox.Name = "v18up_picBox"
        Me.v18up_picBox.Size = New System.Drawing.Size(198, 126)
        Me.v18up_picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.v18up_picBox.TabIndex = 1
        Me.v18up_picBox.TabStop = False
        '
        'close_btn
        '
        Me.close_btn.Location = New System.Drawing.Point(339, 144)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(75, 23)
        Me.close_btn.TabIndex = 2
        Me.close_btn.Text = "Close"
        Me.close_btn.UseVisualStyleBackColor = True
        '
        'fantool_lbl
        '
        Me.fantool_lbl.AutoSize = True
        Me.fantool_lbl.Location = New System.Drawing.Point(12, 141)
        Me.fantool_lbl.Name = "fantool_lbl"
        Me.fantool_lbl.Size = New System.Drawing.Size(201, 30)
        Me.fantool_lbl.TabIndex = 3
        Me.fantool_lbl.Text = "This is a fan-made tool." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "No Copyright Infringment indended."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 179)
        Me.Controls.Add(Me.fantool_lbl)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.v18up_picBox)
        Me.Controls.Add(Me.v17_picBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Click on a verson to sthart the tool."
        CType(Me.v17_picBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.v18up_picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents v17_picBox As PictureBox
    Friend WithEvents v18up_picBox As PictureBox
    Friend WithEvents close_btn As Button
    Friend WithEvents fantool_lbl As Label
End Class
