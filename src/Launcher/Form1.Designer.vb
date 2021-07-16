<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.convertersList = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.convertersInfo_txt = New System.Windows.Forms.Label()
        Me.launchSelected_btn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exit_btn
        '
        Me.exit_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exit_btn.Location = New System.Drawing.Point(198, 347)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(75, 23)
        Me.exit_btn.TabIndex = 2
        Me.exit_btn.Text = "Cancel"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(12, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 57)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "This is a non-profit fan-made tool. No copyright infringements intended. Please s" &
    "upport the official games!"
        '
        'convertersList
        '
        Me.convertersList.FormattingEnabled = True
        Me.convertersList.Location = New System.Drawing.Point(12, 12)
        Me.convertersList.Name = "convertersList"
        Me.convertersList.Size = New System.Drawing.Size(177, 290)
        Me.convertersList.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(195, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 91)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'convertersInfo_txt
        '
        Me.convertersInfo_txt.Location = New System.Drawing.Point(195, 106)
        Me.convertersInfo_txt.Name = "convertersInfo_txt"
        Me.convertersInfo_txt.Size = New System.Drawing.Size(202, 196)
        Me.convertersInfo_txt.TabIndex = 7
        Me.convertersInfo_txt.Text = "Select a version on the left to get started." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<--------------"
        '
        'launchSelected_btn
        '
        Me.launchSelected_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.launchSelected_btn.Location = New System.Drawing.Point(279, 347)
        Me.launchSelected_btn.Name = "launchSelected_btn"
        Me.launchSelected_btn.Size = New System.Drawing.Size(118, 23)
        Me.launchSelected_btn.TabIndex = 8
        Me.launchSelected_btn.Text = "Launch"
        Me.launchSelected_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 382)
        Me.Controls.Add(Me.launchSelected_btn)
        Me.Controls.Add(Me.convertersInfo_txt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.convertersList)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exit_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Showdown to Essnetials Converter"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents exit_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents convertersList As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents convertersInfo_txt As Label
    Friend WithEvents launchSelected_btn As Button
End Class
