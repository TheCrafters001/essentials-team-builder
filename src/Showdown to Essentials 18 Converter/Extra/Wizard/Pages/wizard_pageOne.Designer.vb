<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wizard_pageOne
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.wizardTitle_txt = New System.Windows.Forms.Label()
        Me.wizardDescription_lbl = New System.Windows.Forms.Label()
        Me.trainerType_lbl = New System.Windows.Forms.Label()
        Me.trainerType_txtBox = New System.Windows.Forms.TextBox()
        Me.trainerName_lbl = New System.Windows.Forms.Label()
        Me.trainerName_txtBox = New System.Windows.Forms.TextBox()
        Me.existingBattle_chkBox = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
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
        Me.Cancel_Button.Text = "Cancel"
        '
        'wizardTitle_txt
        '
        Me.wizardTitle_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wizardTitle_txt.Location = New System.Drawing.Point(12, 9)
        Me.wizardTitle_txt.Name = "wizardTitle_txt"
        Me.wizardTitle_txt.Size = New System.Drawing.Size(411, 25)
        Me.wizardTitle_txt.TabIndex = 3
        Me.wizardTitle_txt.Text = "Trainer Information"
        '
        'wizardDescription_lbl
        '
        Me.wizardDescription_lbl.Location = New System.Drawing.Point(12, 34)
        Me.wizardDescription_lbl.Name = "wizardDescription_lbl"
        Me.wizardDescription_lbl.Size = New System.Drawing.Size(411, 31)
        Me.wizardDescription_lbl.TabIndex = 4
        Me.wizardDescription_lbl.Text = "Please enter the trainer name and the class for your trainer." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The trainer class " &
    "can be found in PBS\trainertypes.txt"
        '
        'trainerType_lbl
        '
        Me.trainerType_lbl.AutoSize = True
        Me.trainerType_lbl.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trainerType_lbl.Location = New System.Drawing.Point(12, 97)
        Me.trainerType_lbl.Name = "trainerType_lbl"
        Me.trainerType_lbl.Size = New System.Drawing.Size(68, 13)
        Me.trainerType_lbl.TabIndex = 11
        Me.trainerType_lbl.Text = "Trainer Type"
        '
        'trainerType_txtBox
        '
        Me.trainerType_txtBox.Location = New System.Drawing.Point(89, 94)
        Me.trainerType_txtBox.MaxLength = 25
        Me.trainerType_txtBox.Name = "trainerType_txtBox"
        Me.trainerType_txtBox.Size = New System.Drawing.Size(334, 20)
        Me.trainerType_txtBox.TabIndex = 10
        '
        'trainerName_lbl
        '
        Me.trainerName_lbl.AutoSize = True
        Me.trainerName_lbl.Location = New System.Drawing.Point(12, 71)
        Me.trainerName_lbl.Name = "trainerName_lbl"
        Me.trainerName_lbl.Size = New System.Drawing.Size(71, 13)
        Me.trainerName_lbl.TabIndex = 9
        Me.trainerName_lbl.Text = "Trainer Name"
        '
        'trainerName_txtBox
        '
        Me.trainerName_txtBox.Location = New System.Drawing.Point(89, 68)
        Me.trainerName_txtBox.MaxLength = 25
        Me.trainerName_txtBox.Name = "trainerName_txtBox"
        Me.trainerName_txtBox.Size = New System.Drawing.Size(334, 20)
        Me.trainerName_txtBox.TabIndex = 8
        '
        'existingBattle_chkBox
        '
        Me.existingBattle_chkBox.Location = New System.Drawing.Point(12, 120)
        Me.existingBattle_chkBox.Name = "existingBattle_chkBox"
        Me.existingBattle_chkBox.Size = New System.Drawing.Size(411, 30)
        Me.existingBattle_chkBox.TabIndex = 12
        Me.existingBattle_chkBox.Text = "If you have made a team for this trainer before, check this."
        Me.existingBattle_chkBox.UseVisualStyleBackColor = True
        '
        'wizard_pageOne
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.existingBattle_chkBox)
        Me.Controls.Add(Me.trainerType_lbl)
        Me.Controls.Add(Me.trainerType_txtBox)
        Me.Controls.Add(Me.trainerName_lbl)
        Me.Controls.Add(Me.trainerName_txtBox)
        Me.Controls.Add(Me.wizardDescription_lbl)
        Me.Controls.Add(Me.wizardTitle_txt)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "wizard_pageOne"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trainer Information"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents wizardTitle_txt As Label
    Friend WithEvents wizardDescription_lbl As Label
    Friend WithEvents trainerType_lbl As Label
    Friend WithEvents trainerType_txtBox As TextBox
    Friend WithEvents trainerName_lbl As Label
    Friend WithEvents trainerName_txtBox As TextBox
    Friend WithEvents existingBattle_chkBox As CheckBox
End Class
