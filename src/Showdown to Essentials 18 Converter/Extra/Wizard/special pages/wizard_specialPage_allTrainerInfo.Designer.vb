<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wizard_specialPage_allTrainerInfo
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
        Me.wizardDescription_lbl = New System.Windows.Forms.Label()
        Me.wizardTitle_txt = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.trainerName_lbl = New System.Windows.Forms.Label()
        Me.trainerClass_lbl = New System.Windows.Forms.Label()
        Me.trainerExisting_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'wizardDescription_lbl
        '
        Me.wizardDescription_lbl.Location = New System.Drawing.Point(12, 35)
        Me.wizardDescription_lbl.Name = "wizardDescription_lbl"
        Me.wizardDescription_lbl.Size = New System.Drawing.Size(411, 31)
        Me.wizardDescription_lbl.TabIndex = 22
        Me.wizardDescription_lbl.Text = "Please review this information carefully, and make sure it is all correct."
        '
        'wizardTitle_txt
        '
        Me.wizardTitle_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wizardTitle_txt.Location = New System.Drawing.Point(12, 10)
        Me.wizardTitle_txt.Name = "wizardTitle_txt"
        Me.wizardTitle_txt.Size = New System.Drawing.Size(411, 25)
        Me.wizardTitle_txt.TabIndex = 21
        Me.wizardTitle_txt.Text = "Finished with Trainer Information!"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 275)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 20
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(76, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Next"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(3, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Back"
        '
        'trainerName_lbl
        '
        Me.trainerName_lbl.Location = New System.Drawing.Point(12, 66)
        Me.trainerName_lbl.Name = "trainerName_lbl"
        Me.trainerName_lbl.Size = New System.Drawing.Size(195, 13)
        Me.trainerName_lbl.TabIndex = 23
        Me.trainerName_lbl.Text = "Trainer Name: "
        '
        'trainerClass_lbl
        '
        Me.trainerClass_lbl.Location = New System.Drawing.Point(12, 79)
        Me.trainerClass_lbl.Name = "trainerClass_lbl"
        Me.trainerClass_lbl.Size = New System.Drawing.Size(195, 13)
        Me.trainerClass_lbl.TabIndex = 24
        Me.trainerClass_lbl.Text = "Trainer Class: "
        '
        'trainerExisting_lbl
        '
        Me.trainerExisting_lbl.Location = New System.Drawing.Point(12, 92)
        Me.trainerExisting_lbl.Name = "trainerExisting_lbl"
        Me.trainerExisting_lbl.Size = New System.Drawing.Size(195, 13)
        Me.trainerExisting_lbl.TabIndex = 25
        Me.trainerExisting_lbl.Text = "Trainer has Existing Battle: Y/N"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "This trainer uses items: Y/N"
        '
        'wizard_specialPage_allTrainerInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.trainerExisting_lbl)
        Me.Controls.Add(Me.trainerClass_lbl)
        Me.Controls.Add(Me.trainerName_lbl)
        Me.Controls.Add(Me.wizardDescription_lbl)
        Me.Controls.Add(Me.wizardTitle_txt)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "wizard_specialPage_allTrainerInfo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Trainer Information"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents wizardDescription_lbl As Label
    Friend WithEvents wizardTitle_txt As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents trainerName_lbl As Label
    Friend WithEvents trainerClass_lbl As Label
    Friend WithEvents trainerExisting_lbl As Label
    Friend WithEvents Label1 As Label
End Class
