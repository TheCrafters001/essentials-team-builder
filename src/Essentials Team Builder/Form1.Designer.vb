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
        editor_grp = New GroupBox()
        editor_tab = New TabControl()
        pg_trainer = New TabPage()
        trainer_tab = New TabControl()
        pg_basic = New TabPage()
        essVersion_cmb = New ComboBox()
        essVersion_lbl = New Label()
        battleTeamID_txtBox = New TextBox()
        battleTeamID_lbl = New Label()
        numPoké_lbl = New Label()
        numPoké_cmb = New ComboBox()
        loseText_lbl = New Label()
        loseText_txt = New TextBox()
        trainerType_txtBox = New TextBox()
        trainerType_lbl = New Label()
        trainerName_txtBox = New TextBox()
        trainerName_lbl = New Label()
        trainerInfoHeader_lbl = New Label()
        pg_items = New TabPage()
        pg_pokemon = New TabPage()
        TabControl3 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        TabPage4 = New TabPage()
        TabPage5 = New TabPage()
        TabPage6 = New TabPage()
        preview_grp = New GroupBox()
        RichTextBox1 = New RichTextBox()
        updatePreview_btn = New Button()
        properSpellingNote_lbl = New Label()
        allowSuperShiny_chk = New CheckBox()
        loseTextQuotes_chkBox = New CheckBox()
        useAbilityIndex_chkBox = New CheckBox()
        existingBattle_chkBox = New CheckBox()
        customBallIDs_chkBox = New CheckBox()
        Label1 = New Label()
        editor_grp.SuspendLayout()
        editor_tab.SuspendLayout()
        pg_trainer.SuspendLayout()
        trainer_tab.SuspendLayout()
        pg_basic.SuspendLayout()
        pg_pokemon.SuspendLayout()
        TabControl3.SuspendLayout()
        preview_grp.SuspendLayout()
        SuspendLayout()
        ' 
        ' editor_grp
        ' 
        editor_grp.Controls.Add(editor_tab)
        editor_grp.Location = New Point(12, 12)
        editor_grp.Name = "editor_grp"
        editor_grp.Size = New Size(757, 559)
        editor_grp.TabIndex = 0
        editor_grp.TabStop = False
        editor_grp.Text = "Editor"
        ' 
        ' editor_tab
        ' 
        editor_tab.Controls.Add(pg_trainer)
        editor_tab.Controls.Add(pg_pokemon)
        editor_tab.Dock = DockStyle.Fill
        editor_tab.Location = New Point(3, 19)
        editor_tab.Name = "editor_tab"
        editor_tab.SelectedIndex = 0
        editor_tab.Size = New Size(751, 537)
        editor_tab.TabIndex = 0
        ' 
        ' pg_trainer
        ' 
        pg_trainer.Controls.Add(trainer_tab)
        pg_trainer.Location = New Point(4, 24)
        pg_trainer.Name = "pg_trainer"
        pg_trainer.Padding = New Padding(3)
        pg_trainer.Size = New Size(743, 509)
        pg_trainer.TabIndex = 0
        pg_trainer.Text = "Trainer"
        pg_trainer.UseVisualStyleBackColor = True
        ' 
        ' trainer_tab
        ' 
        trainer_tab.Controls.Add(pg_basic)
        trainer_tab.Controls.Add(pg_items)
        trainer_tab.Dock = DockStyle.Fill
        trainer_tab.Location = New Point(3, 3)
        trainer_tab.Name = "trainer_tab"
        trainer_tab.SelectedIndex = 0
        trainer_tab.Size = New Size(737, 503)
        trainer_tab.TabIndex = 0
        ' 
        ' pg_basic
        ' 
        pg_basic.Controls.Add(Label1)
        pg_basic.Controls.Add(allowSuperShiny_chk)
        pg_basic.Controls.Add(loseTextQuotes_chkBox)
        pg_basic.Controls.Add(useAbilityIndex_chkBox)
        pg_basic.Controls.Add(existingBattle_chkBox)
        pg_basic.Controls.Add(customBallIDs_chkBox)
        pg_basic.Controls.Add(essVersion_cmb)
        pg_basic.Controls.Add(essVersion_lbl)
        pg_basic.Controls.Add(battleTeamID_txtBox)
        pg_basic.Controls.Add(battleTeamID_lbl)
        pg_basic.Controls.Add(numPoké_lbl)
        pg_basic.Controls.Add(numPoké_cmb)
        pg_basic.Controls.Add(loseText_lbl)
        pg_basic.Controls.Add(loseText_txt)
        pg_basic.Controls.Add(trainerType_txtBox)
        pg_basic.Controls.Add(trainerType_lbl)
        pg_basic.Controls.Add(trainerName_txtBox)
        pg_basic.Controls.Add(trainerName_lbl)
        pg_basic.Controls.Add(trainerInfoHeader_lbl)
        pg_basic.Location = New Point(4, 24)
        pg_basic.Name = "pg_basic"
        pg_basic.Size = New Size(729, 475)
        pg_basic.TabIndex = 2
        pg_basic.Text = "Basic Info"
        pg_basic.UseVisualStyleBackColor = True
        ' 
        ' essVersion_cmb
        ' 
        essVersion_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        essVersion_cmb.FormattingEnabled = True
        essVersion_cmb.Items.AddRange(New Object() {"Essentials 17", "Essentials 18", "Essentials 19", "Essentials 20", "Essentials 21"})
        essVersion_cmb.Location = New Point(8, 184)
        essVersion_cmb.Name = "essVersion_cmb"
        essVersion_cmb.Size = New Size(168, 23)
        essVersion_cmb.TabIndex = 23
        ' 
        ' essVersion_lbl
        ' 
        essVersion_lbl.AutoSize = True
        essVersion_lbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        essVersion_lbl.Location = New Point(8, 164)
        essVersion_lbl.Name = "essVersion_lbl"
        essVersion_lbl.Size = New Size(118, 17)
        essVersion_lbl.TabIndex = 22
        essVersion_lbl.Text = "Essentials Version"
        ' 
        ' battleTeamID_txtBox
        ' 
        battleTeamID_txtBox.Enabled = False
        battleTeamID_txtBox.Location = New Point(8, 92)
        battleTeamID_txtBox.MaxLength = 25
        battleTeamID_txtBox.Name = "battleTeamID_txtBox"
        battleTeamID_txtBox.PlaceholderText = "3"
        battleTeamID_txtBox.Size = New Size(168, 23)
        battleTeamID_txtBox.TabIndex = 19
        ' 
        ' battleTeamID_lbl
        ' 
        battleTeamID_lbl.AutoSize = True
        battleTeamID_lbl.Enabled = False
        battleTeamID_lbl.Location = New Point(8, 76)
        battleTeamID_lbl.Name = "battleTeamID_lbl"
        battleTeamID_lbl.Size = New Size(190, 15)
        battleTeamID_lbl.TabIndex = 20
        battleTeamID_lbl.Text = "Battle Team ID (Must be a number)"
        ' 
        ' numPoké_lbl
        ' 
        numPoké_lbl.AutoSize = True
        numPoké_lbl.Location = New Point(530, 34)
        numPoké_lbl.Name = "numPoké_lbl"
        numPoké_lbl.Size = New Size(119, 15)
        numPoké_lbl.TabIndex = 21
        numPoké_lbl.Text = "Number of Pokémon"
        ' 
        ' numPoké_cmb
        ' 
        numPoké_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        numPoké_cmb.FormattingEnabled = True
        numPoké_cmb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        numPoké_cmb.Location = New Point(530, 50)
        numPoké_cmb.Name = "numPoké_cmb"
        numPoké_cmb.Size = New Size(168, 23)
        numPoké_cmb.TabIndex = 18
        ' 
        ' loseText_lbl
        ' 
        loseText_lbl.AutoSize = True
        loseText_lbl.Location = New Point(356, 34)
        loseText_lbl.Name = "loseText_lbl"
        loseText_lbl.Size = New Size(55, 15)
        loseText_lbl.TabIndex = 17
        loseText_lbl.Text = "Lose Text"
        ' 
        ' loseText_txt
        ' 
        loseText_txt.Location = New Point(356, 50)
        loseText_txt.MaxLength = 255
        loseText_txt.Name = "loseText_txt"
        loseText_txt.PlaceholderText = "Oh dear, it seems I have lost..."
        loseText_txt.Size = New Size(168, 23)
        loseText_txt.TabIndex = 16
        ' 
        ' trainerType_txtBox
        ' 
        trainerType_txtBox.Location = New Point(182, 50)
        trainerType_txtBox.MaxLength = 25
        trainerType_txtBox.Name = "trainerType_txtBox"
        trainerType_txtBox.PlaceholderText = "RIVAL"
        trainerType_txtBox.Size = New Size(168, 23)
        trainerType_txtBox.TabIndex = 8
        ' 
        ' trainerType_lbl
        ' 
        trainerType_lbl.AutoSize = True
        trainerType_lbl.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        trainerType_lbl.Location = New Point(182, 34)
        trainerType_lbl.Name = "trainerType_lbl"
        trainerType_lbl.Size = New Size(175, 13)
        trainerType_lbl.TabIndex = 9
        trainerType_lbl.Text = "Trainer Type (See trainertypes.txt)"
        ' 
        ' trainerName_txtBox
        ' 
        trainerName_txtBox.Location = New Point(8, 50)
        trainerName_txtBox.Name = "trainerName_txtBox"
        trainerName_txtBox.PlaceholderText = "Rosa"
        trainerName_txtBox.Size = New Size(168, 23)
        trainerName_txtBox.TabIndex = 2
        ' 
        ' trainerName_lbl
        ' 
        trainerName_lbl.AutoSize = True
        trainerName_lbl.Location = New Point(8, 32)
        trainerName_lbl.Name = "trainerName_lbl"
        trainerName_lbl.Size = New Size(77, 15)
        trainerName_lbl.TabIndex = 1
        trainerName_lbl.Text = "Trainer Name"
        ' 
        ' trainerInfoHeader_lbl
        ' 
        trainerInfoHeader_lbl.AutoSize = True
        trainerInfoHeader_lbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        trainerInfoHeader_lbl.Location = New Point(3, 0)
        trainerInfoHeader_lbl.Name = "trainerInfoHeader_lbl"
        trainerInfoHeader_lbl.Size = New Size(239, 32)
        trainerInfoHeader_lbl.TabIndex = 0
        trainerInfoHeader_lbl.Text = "Trainer Information"
        ' 
        ' pg_items
        ' 
        pg_items.Location = New Point(4, 24)
        pg_items.Name = "pg_items"
        pg_items.Padding = New Padding(3)
        pg_items.Size = New Size(729, 475)
        pg_items.TabIndex = 1
        pg_items.Text = "Items"
        pg_items.UseVisualStyleBackColor = True
        ' 
        ' pg_pokemon
        ' 
        pg_pokemon.Controls.Add(TabControl3)
        pg_pokemon.Location = New Point(4, 24)
        pg_pokemon.Name = "pg_pokemon"
        pg_pokemon.Padding = New Padding(3)
        pg_pokemon.Size = New Size(743, 509)
        pg_pokemon.TabIndex = 1
        pg_pokemon.Text = "Pokémon"
        pg_pokemon.UseVisualStyleBackColor = True
        ' 
        ' TabControl3
        ' 
        TabControl3.Controls.Add(TabPage1)
        TabControl3.Controls.Add(TabPage2)
        TabControl3.Controls.Add(TabPage3)
        TabControl3.Controls.Add(TabPage4)
        TabControl3.Controls.Add(TabPage5)
        TabControl3.Controls.Add(TabPage6)
        TabControl3.Dock = DockStyle.Fill
        TabControl3.Location = New Point(3, 3)
        TabControl3.Name = "TabControl3"
        TabControl3.SelectedIndex = 0
        TabControl3.Size = New Size(737, 503)
        TabControl3.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Size = New Size(729, 475)
        TabPage1.TabIndex = 2
        TabPage1.Text = "Pokémon 1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(729, 475)
        TabPage2.TabIndex = 3
        TabPage2.Text = "Pokémon 2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(729, 475)
        TabPage3.TabIndex = 4
        TabPage3.Text = "Pokémon 3"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(729, 475)
        TabPage4.TabIndex = 5
        TabPage4.Text = "Pokémon 4"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' TabPage5
        ' 
        TabPage5.Location = New Point(4, 24)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3)
        TabPage5.Size = New Size(729, 475)
        TabPage5.TabIndex = 0
        TabPage5.Text = "Pokémon 5"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' TabPage6
        ' 
        TabPage6.Location = New Point(4, 24)
        TabPage6.Name = "TabPage6"
        TabPage6.Padding = New Padding(3)
        TabPage6.Size = New Size(729, 475)
        TabPage6.TabIndex = 1
        TabPage6.Text = "Pokémon 6"
        TabPage6.UseVisualStyleBackColor = True
        ' 
        ' preview_grp
        ' 
        preview_grp.Controls.Add(RichTextBox1)
        preview_grp.Location = New Point(775, 12)
        preview_grp.Name = "preview_grp"
        preview_grp.Size = New Size(461, 559)
        preview_grp.TabIndex = 1
        preview_grp.TabStop = False
        preview_grp.Text = "Preview"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Dock = DockStyle.Fill
        RichTextBox1.Location = New Point(3, 19)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(455, 537)
        RichTextBox1.TabIndex = 0
        RichTextBox1.Text = ""
        ' 
        ' updatePreview_btn
        ' 
        updatePreview_btn.Location = New Point(1045, 2)
        updatePreview_btn.Name = "updatePreview_btn"
        updatePreview_btn.Size = New Size(191, 23)
        updatePreview_btn.TabIndex = 2
        updatePreview_btn.Text = "Update Preview/Generate Team"
        updatePreview_btn.UseVisualStyleBackColor = True
        ' 
        ' properSpellingNote_lbl
        ' 
        properSpellingNote_lbl.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        properSpellingNote_lbl.AutoSize = True
        properSpellingNote_lbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        properSpellingNote_lbl.ForeColor = Color.Red
        properSpellingNote_lbl.Location = New Point(12, 567)
        properSpellingNote_lbl.Name = "properSpellingNote_lbl"
        properSpellingNote_lbl.Size = New Size(192, 15)
        properSpellingNote_lbl.TabIndex = 24
        properSpellingNote_lbl.Text = "Note: Proper spelling IS required."
        ' 
        ' allowSuperShiny_chk
        ' 
        allowSuperShiny_chk.AutoSize = True
        allowSuperShiny_chk.Location = New Point(164, 249)
        allowSuperShiny_chk.Name = "allowSuperShiny_chk"
        allowSuperShiny_chk.Size = New Size(129, 34)
        allowSuperShiny_chk.TabIndex = 28
        allowSuperShiny_chk.Text = "Allow Super Shinies" & vbCrLf & "(Essentials 21)"
        allowSuperShiny_chk.UseVisualStyleBackColor = True
        ' 
        ' loseTextQuotes_chkBox
        ' 
        loseTextQuotes_chkBox.AutoSize = True
        loseTextQuotes_chkBox.Location = New Point(8, 249)
        loseTextQuotes_chkBox.Name = "loseTextQuotes_chkBox"
        loseTextQuotes_chkBox.Size = New Size(154, 34)
        loseTextQuotes_chkBox.TabIndex = 27
        loseTextQuotes_chkBox.Text = "Add Quotes to Lose Text" & vbCrLf & "(Essentials 19)"
        loseTextQuotes_chkBox.UseVisualStyleBackColor = True
        ' 
        ' useAbilityIndex_chkBox
        ' 
        useAbilityIndex_chkBox.AutoSize = True
        useAbilityIndex_chkBox.Checked = True
        useAbilityIndex_chkBox.CheckState = CheckState.Checked
        useAbilityIndex_chkBox.Enabled = False
        useAbilityIndex_chkBox.Location = New Point(493, 213)
        useAbilityIndex_chkBox.Name = "useAbilityIndex_chkBox"
        useAbilityIndex_chkBox.Size = New Size(203, 34)
        useAbilityIndex_chkBox.TabIndex = 26
        useAbilityIndex_chkBox.Text = "Use AbilityIndex instead of Ability" & vbCrLf & "(Essentials 19, 20)"
        useAbilityIndex_chkBox.UseVisualStyleBackColor = True
        ' 
        ' existingBattle_chkBox
        ' 
        existingBattle_chkBox.AutoSize = True
        existingBattle_chkBox.Location = New Point(8, 213)
        existingBattle_chkBox.Name = "existingBattle_chkBox"
        existingBattle_chkBox.Size = New Size(270, 34)
        existingBattle_chkBox.TabIndex = 24
        existingBattle_chkBox.Text = "Check this box if this NPC already has a team, " & vbCrLf & "then enter the Battle Team ID above."
        existingBattle_chkBox.UseVisualStyleBackColor = True
        ' 
        ' customBallIDs_chkBox
        ' 
        customBallIDs_chkBox.AutoSize = True
        customBallIDs_chkBox.Checked = True
        customBallIDs_chkBox.CheckState = CheckState.Checked
        customBallIDs_chkBox.Location = New Point(284, 213)
        customBallIDs_chkBox.Name = "customBallIDs_chkBox"
        customBallIDs_chkBox.Size = New Size(203, 19)
        customBallIDs_chkBox.TabIndex = 25
        customBallIDs_chkBox.Text = "Allow use of Custom Pokéball IDs"
        customBallIDs_chkBox.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 132)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 32)
        Label1.TabIndex = 29
        Label1.Text = "Essentials Data"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1248, 583)
        Controls.Add(properSpellingNote_lbl)
        Controls.Add(updatePreview_btn)
        Controls.Add(preview_grp)
        Controls.Add(editor_grp)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Essentials Team Editor"
        editor_grp.ResumeLayout(False)
        editor_tab.ResumeLayout(False)
        pg_trainer.ResumeLayout(False)
        trainer_tab.ResumeLayout(False)
        pg_basic.ResumeLayout(False)
        pg_basic.PerformLayout()
        pg_pokemon.ResumeLayout(False)
        TabControl3.ResumeLayout(False)
        preview_grp.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents editor_grp As GroupBox
    Friend WithEvents editor_tab As TabControl
    Friend WithEvents pg_trainer As TabPage
    Friend WithEvents trainer_tab As TabControl
    Friend WithEvents pg_items As TabPage
    Friend WithEvents pg_pokemon As TabPage
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents preview_grp As GroupBox
    Friend WithEvents pg_basic As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents trainerInfoHeader_lbl As Label
    Friend WithEvents updatePreview_btn As Button
    Friend WithEvents trainerName_lbl As Label
    Friend WithEvents trainerName_txtBox As TextBox
    Friend WithEvents trainerType_txtBox As TextBox
    Friend WithEvents trainerType_lbl As Label
    Friend WithEvents loseText_lbl As Label
    Friend WithEvents loseText_txt As TextBox
    Friend WithEvents battleTeamID_txtBox As TextBox
    Friend WithEvents battleTeamID_lbl As Label
    Friend WithEvents numPoké_lbl As Label
    Friend WithEvents numPoké_cmb As ComboBox
    Friend WithEvents essVersion_cmb As ComboBox
    Friend WithEvents essVersion_lbl As Label
    Friend WithEvents properSpellingNote_lbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents allowSuperShiny_chk As CheckBox
    Friend WithEvents loseTextQuotes_chkBox As CheckBox
    Friend WithEvents useAbilityIndex_chkBox As CheckBox
    Friend WithEvents existingBattle_chkBox As CheckBox
    Friend WithEvents customBallIDs_chkBox As CheckBox
End Class
