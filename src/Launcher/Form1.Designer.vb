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
        close_btn = New Button()
        fantool_lbl = New Label()
        ste18_btn = New Button()
        ste17_btn = New Button()
        SuspendLayout()
        ' 
        ' close_btn
        ' 
        close_btn.Location = New Point(339, 144)
        close_btn.Name = "close_btn"
        close_btn.Size = New Size(75, 23)
        close_btn.TabIndex = 2
        close_btn.Text = "Close"
        close_btn.UseVisualStyleBackColor = True
        ' 
        ' fantool_lbl
        ' 
        fantool_lbl.AutoSize = True
        fantool_lbl.Location = New Point(12, 141)
        fantool_lbl.Name = "fantool_lbl"
        fantool_lbl.Size = New Size(201, 30)
        fantool_lbl.TabIndex = 3
        fantool_lbl.Text = "This is a fan-made tool." & vbCrLf & "No Copyright Infringment indended."
        ' 
        ' ste18_btn
        ' 
        ste18_btn.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        ste18_btn.Location = New Point(216, 12)
        ste18_btn.Name = "ste18_btn"
        ste18_btn.Size = New Size(198, 126)
        ste18_btn.TabIndex = 4
        ste18_btn.Text = "Showdown to Essentials 18-21"
        ste18_btn.UseVisualStyleBackColor = True
        ' 
        ' ste17_btn
        ' 
        ste17_btn.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        ste17_btn.Location = New Point(12, 12)
        ste17_btn.Name = "ste17_btn"
        ste17_btn.Size = New Size(198, 126)
        ste17_btn.TabIndex = 5
        ste17_btn.Text = "Showdown to Essentials 17" & vbCrLf & "(Unsupported)"
        ste17_btn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(426, 179)
        Controls.Add(ste17_btn)
        Controls.Add(ste18_btn)
        Controls.Add(fantool_lbl)
        Controls.Add(close_btn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Select a Version"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents close_btn As Button
    Friend WithEvents fantool_lbl As Label
    Friend WithEvents ste18_btn As Button
    Friend WithEvents ste17_btn As Button
End Class
