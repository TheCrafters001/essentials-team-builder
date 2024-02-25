<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThirdPartyLicenses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ThirdPartyLicenses))
        close_btn = New Button()
        licenses_rchTxt = New RichTextBox()
        SuspendLayout()
        ' 
        ' close_btn
        ' 
        close_btn.Location = New Point(483, 415)
        close_btn.Name = "close_btn"
        close_btn.Size = New Size(75, 23)
        close_btn.TabIndex = 0
        close_btn.Text = "Close"
        close_btn.UseVisualStyleBackColor = True
        ' 
        ' licenses_rchTxt
        ' 
        licenses_rchTxt.BorderStyle = BorderStyle.None
        licenses_rchTxt.Location = New Point(12, 12)
        licenses_rchTxt.Name = "licenses_rchTxt"
        licenses_rchTxt.ReadOnly = True
        licenses_rchTxt.Size = New Size(546, 397)
        licenses_rchTxt.TabIndex = 1
        licenses_rchTxt.Text = resources.GetString("licenses_rchTxt.Text")
        ' 
        ' ThirdPartyLicenses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(570, 450)
        Controls.Add(licenses_rchTxt)
        Controls.Add(close_btn)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "ThirdPartyLicenses"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Third-Party Licenses"
        ResumeLayout(False)
    End Sub

    Friend WithEvents close_btn As Button
    Friend WithEvents licenses_rchTxt As RichTextBox
End Class
