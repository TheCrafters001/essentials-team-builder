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
        Me.convertersList = New System.Windows.Forms.ListBox()
        Me.logo_picBox = New System.Windows.Forms.PictureBox()
        Me.ProSeperator1 = New Launcher.ProSeperator()
        Me.alert_lbl = New Launcher.BonfireLabel()
        Me.convertersInfo_txt = New Launcher.BonfireLabel()
        Me.launch_btn = New Launcher.ProBasicButton()
        Me.cancel_btn = New Launcher.ProBasicButton()
        CType(Me.logo_picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'convertersList
        '
        Me.convertersList.FormattingEnabled = True
        Me.convertersList.ItemHeight = 15
        Me.convertersList.Location = New System.Drawing.Point(12, 12)
        Me.convertersList.Name = "convertersList"
        Me.convertersList.Size = New System.Drawing.Size(184, 304)
        Me.convertersList.TabIndex = 0
        '
        'logo_picBox
        '
        Me.logo_picBox.Location = New System.Drawing.Point(202, 12)
        Me.logo_picBox.Name = "logo_picBox"
        Me.logo_picBox.Size = New System.Drawing.Size(252, 127)
        Me.logo_picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logo_picBox.TabIndex = 2
        Me.logo_picBox.TabStop = False
        '
        'ProSeperator1
        '
        Me.ProSeperator1.LineColor = System.Drawing.Color.Silver
        Me.ProSeperator1.Location = New System.Drawing.Point(12, 322)
        Me.ProSeperator1.Name = "ProSeperator1"
        Me.ProSeperator1.Size = New System.Drawing.Size(442, 9)
        Me.ProSeperator1.TabIndex = 4
        Me.ProSeperator1.Text = "ProSeperator1"
        '
        'alert_lbl
        '
        Me.alert_lbl.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.alert_lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.alert_lbl.Location = New System.Drawing.Point(12, 334)
        Me.alert_lbl.Name = "alert_lbl"
        Me.alert_lbl.Size = New System.Drawing.Size(184, 107)
        Me.alert_lbl.TabIndex = 5
        Me.alert_lbl.Text = "This is a non-profit fan-made tool. No copyright infringements intended. Please s" &
    "upport the official games!"
        '
        'convertersInfo_txt
        '
        Me.convertersInfo_txt.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.convertersInfo_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.convertersInfo_txt.Location = New System.Drawing.Point(202, 142)
        Me.convertersInfo_txt.Name = "convertersInfo_txt"
        Me.convertersInfo_txt.Size = New System.Drawing.Size(252, 177)
        Me.convertersInfo_txt.TabIndex = 6
        Me.convertersInfo_txt.Text = "Select a version on the left to get started." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "<--------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'launch_btn
        '
        Me.launch_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.launch_btn.Enabled = False
        Me.launch_btn.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.launch_btn.Image = Nothing
        Me.launch_btn.Location = New System.Drawing.Point(285, 337)
        Me.launch_btn.Name = "launch_btn"
        Me.launch_btn.Scheme = Launcher.ProBasicButton.ColorScheme.White
        Me.launch_btn.Size = New System.Drawing.Size(169, 101)
        Me.launch_btn.TabIndex = 7
        Me.launch_btn.Text = "LAUNCH!"
        Me.launch_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cancel_btn
        '
        Me.cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancel_btn.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cancel_btn.Image = Nothing
        Me.cancel_btn.Location = New System.Drawing.Point(195, 388)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Scheme = Launcher.ProBasicButton.ColorScheme.White
        Me.cancel_btn.Size = New System.Drawing.Size(84, 50)
        Me.cancel_btn.TabIndex = 8
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 450)
        Me.Controls.Add(Me.cancel_btn)
        Me.Controls.Add(Me.launch_btn)
        Me.Controls.Add(Me.convertersInfo_txt)
        Me.Controls.Add(Me.alert_lbl)
        Me.Controls.Add(Me.ProSeperator1)
        Me.Controls.Add(Me.logo_picBox)
        Me.Controls.Add(Me.convertersList)
        Me.Name = "Form1"
        Me.Text = "Showdown to Essentials Converter - Launcher"
        CType(Me.logo_picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents convertersList As ListBox
    Friend WithEvents logo_picBox As PictureBox
    Friend WithEvents ProSeperator1 As ProSeperator
    Friend WithEvents alert_lbl As BonfireLabel
    Friend WithEvents convertersInfo_txt As BonfireLabel
    Friend WithEvents launch_btn As ProBasicButton
    Friend WithEvents cancel_btn As ProBasicButton
End Class
