<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wizard_p1_pageOne
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
        Me.wizardDescription_lbl = New System.Windows.Forms.Label()
        Me.wizardTitle_txt = New System.Windows.Forms.Label()
        Me.pokemonOneItem_txtBox = New System.Windows.Forms.TextBox()
        Me.item_lbl = New System.Windows.Forms.Label()
        Me.pokemonOneName_txtBox = New System.Windows.Forms.TextBox()
        Me.pokemonOneName_lbl = New System.Windows.Forms.Label()
        Me.pokemonOneLvl_txtBox = New System.Windows.Forms.TextBox()
        Me.pokemonOneLvl_lbl = New System.Windows.Forms.Label()
        Me.pokemonOneGender_lbl = New System.Windows.Forms.Label()
        Me.pokemonOneGender_cmb = New System.Windows.Forms.ComboBox()
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
        Me.Cancel_Button.Text = "Back"
        '
        'wizardDescription_lbl
        '
        Me.wizardDescription_lbl.Location = New System.Drawing.Point(12, 34)
        Me.wizardDescription_lbl.Name = "wizardDescription_lbl"
        Me.wizardDescription_lbl.Size = New System.Drawing.Size(411, 31)
        Me.wizardDescription_lbl.TabIndex = 21
        Me.wizardDescription_lbl.Text = "Please enter some information below about the first Pokemon this trainer should u" &
    "se."
        '
        'wizardTitle_txt
        '
        Me.wizardTitle_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wizardTitle_txt.Location = New System.Drawing.Point(12, 9)
        Me.wizardTitle_txt.Name = "wizardTitle_txt"
        Me.wizardTitle_txt.Size = New System.Drawing.Size(411, 25)
        Me.wizardTitle_txt.TabIndex = 20
        Me.wizardTitle_txt.Text = "Pokemon 1"
        '
        'pokemonOneItem_txtBox
        '
        Me.pokemonOneItem_txtBox.Location = New System.Drawing.Point(15, 120)
        Me.pokemonOneItem_txtBox.Name = "pokemonOneItem_txtBox"
        Me.pokemonOneItem_txtBox.Size = New System.Drawing.Size(141, 20)
        Me.pokemonOneItem_txtBox.TabIndex = 24
        '
        'item_lbl
        '
        Me.item_lbl.AutoSize = True
        Me.item_lbl.Location = New System.Drawing.Point(12, 104)
        Me.item_lbl.Name = "item_lbl"
        Me.item_lbl.Size = New System.Drawing.Size(52, 13)
        Me.item_lbl.TabIndex = 25
        Me.item_lbl.Text = "Held Item"
        '
        'pokemonOneName_txtBox
        '
        Me.pokemonOneName_txtBox.Location = New System.Drawing.Point(15, 81)
        Me.pokemonOneName_txtBox.Name = "pokemonOneName_txtBox"
        Me.pokemonOneName_txtBox.Size = New System.Drawing.Size(141, 20)
        Me.pokemonOneName_txtBox.TabIndex = 23
        '
        'pokemonOneName_lbl
        '
        Me.pokemonOneName_lbl.AutoSize = True
        Me.pokemonOneName_lbl.Location = New System.Drawing.Point(12, 65)
        Me.pokemonOneName_lbl.Name = "pokemonOneName_lbl"
        Me.pokemonOneName_lbl.Size = New System.Drawing.Size(83, 13)
        Me.pokemonOneName_lbl.TabIndex = 22
        Me.pokemonOneName_lbl.Text = "Pokémon Name"
        '
        'pokemonOneLvl_txtBox
        '
        Me.pokemonOneLvl_txtBox.Location = New System.Drawing.Point(16, 159)
        Me.pokemonOneLvl_txtBox.MaxLength = 3
        Me.pokemonOneLvl_txtBox.Name = "pokemonOneLvl_txtBox"
        Me.pokemonOneLvl_txtBox.Size = New System.Drawing.Size(140, 20)
        Me.pokemonOneLvl_txtBox.TabIndex = 26
        '
        'pokemonOneLvl_lbl
        '
        Me.pokemonOneLvl_lbl.AutoSize = True
        Me.pokemonOneLvl_lbl.Location = New System.Drawing.Point(13, 143)
        Me.pokemonOneLvl_lbl.Name = "pokemonOneLvl_lbl"
        Me.pokemonOneLvl_lbl.Size = New System.Drawing.Size(83, 13)
        Me.pokemonOneLvl_lbl.TabIndex = 27
        Me.pokemonOneLvl_lbl.Text = "Level (Max 100)"
        '
        'pokemonOneGender_lbl
        '
        Me.pokemonOneGender_lbl.AutoSize = True
        Me.pokemonOneGender_lbl.Location = New System.Drawing.Point(13, 182)
        Me.pokemonOneGender_lbl.Name = "pokemonOneGender_lbl"
        Me.pokemonOneGender_lbl.Size = New System.Drawing.Size(90, 13)
        Me.pokemonOneGender_lbl.TabIndex = 28
        Me.pokemonOneGender_lbl.Text = "Pokémon Gender"
        '
        'pokemonOneGender_cmb
        '
        Me.pokemonOneGender_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pokemonOneGender_cmb.FormattingEnabled = True
        Me.pokemonOneGender_cmb.Items.AddRange(New Object() {"male", "female", "(random)"})
        Me.pokemonOneGender_cmb.Location = New System.Drawing.Point(16, 198)
        Me.pokemonOneGender_cmb.Name = "pokemonOneGender_cmb"
        Me.pokemonOneGender_cmb.Size = New System.Drawing.Size(140, 21)
        Me.pokemonOneGender_cmb.TabIndex = 29
        '
        'wizard_p1_pageOne
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.pokemonOneGender_lbl)
        Me.Controls.Add(Me.pokemonOneGender_cmb)
        Me.Controls.Add(Me.pokemonOneLvl_txtBox)
        Me.Controls.Add(Me.pokemonOneLvl_lbl)
        Me.Controls.Add(Me.pokemonOneItem_txtBox)
        Me.Controls.Add(Me.item_lbl)
        Me.Controls.Add(Me.pokemonOneName_txtBox)
        Me.Controls.Add(Me.pokemonOneName_lbl)
        Me.Controls.Add(Me.wizardDescription_lbl)
        Me.Controls.Add(Me.wizardTitle_txt)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "wizard_p1_pageOne"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pokemon 1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents wizardDescription_lbl As Label
    Friend WithEvents wizardTitle_txt As Label
    Friend WithEvents pokemonOneItem_txtBox As TextBox
    Friend WithEvents item_lbl As Label
    Friend WithEvents pokemonOneName_txtBox As TextBox
    Friend WithEvents pokemonOneName_lbl As Label
    Friend WithEvents pokemonOneLvl_txtBox As TextBox
    Friend WithEvents pokemonOneLvl_lbl As Label
    Friend WithEvents pokemonOneGender_lbl As Label
    Friend WithEvents pokemonOneGender_cmb As ComboBox
End Class
