<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wizard_pageThree
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
        Me.trainerItemsList_btn = New System.Windows.Forms.Button()
        Me.trainerItemsList_lstbox = New System.Windows.Forms.ListBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'wizardDescription_lbl
        '
        Me.wizardDescription_lbl.Location = New System.Drawing.Point(12, 35)
        Me.wizardDescription_lbl.Name = "wizardDescription_lbl"
        Me.wizardDescription_lbl.Size = New System.Drawing.Size(411, 31)
        Me.wizardDescription_lbl.TabIndex = 16
        Me.wizardDescription_lbl.Text = "Please enter the items you would like your trainer to use. Only add items if you " &
    "want your trainer to have items. (Such as potions)"
        '
        'wizardTitle_txt
        '
        Me.wizardTitle_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wizardTitle_txt.Location = New System.Drawing.Point(12, 10)
        Me.wizardTitle_txt.Name = "wizardTitle_txt"
        Me.wizardTitle_txt.Size = New System.Drawing.Size(411, 25)
        Me.wizardTitle_txt.TabIndex = 15
        Me.wizardTitle_txt.Text = "Trainer Information"
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
        Me.TableLayoutPanel1.TabIndex = 14
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
        'trainerItemsList_btn
        '
        Me.trainerItemsList_btn.Location = New System.Drawing.Point(12, 278)
        Me.trainerItemsList_btn.Name = "trainerItemsList_btn"
        Me.trainerItemsList_btn.Size = New System.Drawing.Size(259, 23)
        Me.trainerItemsList_btn.TabIndex = 1
        Me.trainerItemsList_btn.Text = "Add Item"
        Me.trainerItemsList_btn.UseVisualStyleBackColor = True
        '
        'trainerItemsList_lstbox
        '
        Me.trainerItemsList_lstbox.FormattingEnabled = True
        Me.trainerItemsList_lstbox.Location = New System.Drawing.Point(12, 69)
        Me.trainerItemsList_lstbox.Name = "trainerItemsList_lstbox"
        Me.trainerItemsList_lstbox.Size = New System.Drawing.Size(411, 199)
        Me.trainerItemsList_lstbox.TabIndex = 0
        '
        'wizard_pageThree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.trainerItemsList_lstbox)
        Me.Controls.Add(Me.trainerItemsList_btn)
        Me.Controls.Add(Me.wizardDescription_lbl)
        Me.Controls.Add(Me.wizardTitle_txt)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "wizard_pageThree"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trainer Information"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wizardDescription_lbl As Label
    Friend WithEvents wizardTitle_txt As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents trainerItemsList_btn As Button
    Friend WithEvents trainerItemsList_lstbox As ListBox
End Class
