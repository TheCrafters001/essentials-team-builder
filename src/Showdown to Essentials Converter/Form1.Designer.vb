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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pg_Trainer = New System.Windows.Forms.TabPage()
        Me.trainerName_lbl = New System.Windows.Forms.Label()
        Me.trainerName_txtBox = New System.Windows.Forms.TextBox()
        Me.trainerInfoTitle_lbl = New System.Windows.Forms.Label()
        Me.pg_POne = New System.Windows.Forms.TabPage()
        Me.pg_PTwo = New System.Windows.Forms.TabPage()
        Me.pg_PThree = New System.Windows.Forms.TabPage()
        Me.pg_PFour = New System.Windows.Forms.TabPage()
        Me.pg_PFive = New System.Windows.Forms.TabPage()
        Me.pg_PSix = New System.Windows.Forms.TabPage()
        Me.pg_Output = New System.Windows.Forms.TabPage()
        Me.pg_About = New System.Windows.Forms.TabPage()
        Me.aboutText_lbl = New System.Windows.Forms.Label()
        Me.gnuGPL3_picBox = New System.Windows.Forms.PictureBox()
        Me.aboutAuthor_lbl = New System.Windows.Forms.Label()
        Me.aboutTitle_lbl = New System.Windows.Forms.Label()
        Me.Logo_picBox = New System.Windows.Forms.PictureBox()
        Me.existingBattle_chkBox = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.battleTeamID_lbl = New System.Windows.Forms.Label()
        Me.battleTeamID_txtBox = New System.Windows.Forms.TextBox()
        Me.trainerType_lbl = New System.Windows.Forms.Label()
        Me.trainerType_txtBox = New System.Windows.Forms.TextBox()
        Me.trainerItems_grp = New System.Windows.Forms.GroupBox()
        Me.trainerUsesItems_chkBox = New System.Windows.Forms.CheckBox()
        Me.numPoké_cmb = New System.Windows.Forms.ComboBox()
        Me.numPoké_lbl = New System.Windows.Forms.Label()
        Me.properSpellingNote_lbl = New System.Windows.Forms.Label()
        Me.itemOne_txtBox = New System.Windows.Forms.TextBox()
        Me.itemTwo_txtBox = New System.Windows.Forms.TextBox()
        Me.itemThree_txtBox = New System.Windows.Forms.TextBox()
        Me.itemFour_txtBox = New System.Windows.Forms.TextBox()
        Me.itemFive_txtBox = New System.Windows.Forms.TextBox()
        Me.itemSix_txtBox = New System.Windows.Forms.TextBox()
        Me.itemSeven_txtBox = New System.Windows.Forms.TextBox()
        Me.itemEight_txtBox = New System.Windows.Forms.TextBox()
        Me.outputBox_rchBox = New System.Windows.Forms.RichTextBox()
        Me.generate_btn = New System.Windows.Forms.Button()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.multiOutput_chkBox = New System.Windows.Forms.CheckBox()
        Me.codeExporter_dialog = New System.Windows.Forms.SaveFileDialog()
        Me.pokemonOne_grp = New System.Windows.Forms.GroupBox()
        Me.pokemonTwo_grp = New System.Windows.Forms.GroupBox()
        Me.pokemonThree_grp = New System.Windows.Forms.GroupBox()
        Me.pokemonFour_grp = New System.Windows.Forms.GroupBox()
        Me.pokemonFive_grp = New System.Windows.Forms.GroupBox()
        Me.pokemonSix_grp = New System.Windows.Forms.GroupBox()
        Me.TabControl1.SuspendLayout()
        Me.pg_Trainer.SuspendLayout()
        Me.pg_POne.SuspendLayout()
        Me.pg_PTwo.SuspendLayout()
        Me.pg_PThree.SuspendLayout()
        Me.pg_PFour.SuspendLayout()
        Me.pg_PFive.SuspendLayout()
        Me.pg_PSix.SuspendLayout()
        Me.pg_Output.SuspendLayout()
        Me.pg_About.SuspendLayout()
        CType(Me.gnuGPL3_picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo_picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.trainerItems_grp.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pg_Trainer)
        Me.TabControl1.Controls.Add(Me.pg_POne)
        Me.TabControl1.Controls.Add(Me.pg_PTwo)
        Me.TabControl1.Controls.Add(Me.pg_PThree)
        Me.TabControl1.Controls.Add(Me.pg_PFour)
        Me.TabControl1.Controls.Add(Me.pg_PFive)
        Me.TabControl1.Controls.Add(Me.pg_PSix)
        Me.TabControl1.Controls.Add(Me.pg_Output)
        Me.TabControl1.Controls.Add(Me.pg_About)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 537)
        Me.TabControl1.TabIndex = 1
        '
        'pg_Trainer
        '
        Me.pg_Trainer.Controls.Add(Me.properSpellingNote_lbl)
        Me.pg_Trainer.Controls.Add(Me.numPoké_lbl)
        Me.pg_Trainer.Controls.Add(Me.numPoké_cmb)
        Me.pg_Trainer.Controls.Add(Me.trainerUsesItems_chkBox)
        Me.pg_Trainer.Controls.Add(Me.trainerItems_grp)
        Me.pg_Trainer.Controls.Add(Me.trainerType_lbl)
        Me.pg_Trainer.Controls.Add(Me.trainerType_txtBox)
        Me.pg_Trainer.Controls.Add(Me.battleTeamID_lbl)
        Me.pg_Trainer.Controls.Add(Me.battleTeamID_txtBox)
        Me.pg_Trainer.Controls.Add(Me.existingBattle_chkBox)
        Me.pg_Trainer.Controls.Add(Me.trainerName_lbl)
        Me.pg_Trainer.Controls.Add(Me.trainerName_txtBox)
        Me.pg_Trainer.Controls.Add(Me.trainerInfoTitle_lbl)
        Me.pg_Trainer.Location = New System.Drawing.Point(4, 22)
        Me.pg_Trainer.Name = "pg_Trainer"
        Me.pg_Trainer.Padding = New System.Windows.Forms.Padding(3)
        Me.pg_Trainer.Size = New System.Drawing.Size(752, 511)
        Me.pg_Trainer.TabIndex = 0
        Me.pg_Trainer.Text = "Trainer Info"
        Me.pg_Trainer.UseVisualStyleBackColor = True
        '
        'trainerName_lbl
        '
        Me.trainerName_lbl.AutoSize = True
        Me.trainerName_lbl.Location = New System.Drawing.Point(6, 39)
        Me.trainerName_lbl.Name = "trainerName_lbl"
        Me.trainerName_lbl.Size = New System.Drawing.Size(74, 13)
        Me.trainerName_lbl.TabIndex = 2
        Me.trainerName_lbl.Text = "Trainer Name"
        '
        'trainerName_txtBox
        '
        Me.trainerName_txtBox.Location = New System.Drawing.Point(6, 55)
        Me.trainerName_txtBox.MaxLength = 25
        Me.trainerName_txtBox.Name = "trainerName_txtBox"
        Me.trainerName_txtBox.Size = New System.Drawing.Size(127, 22)
        Me.trainerName_txtBox.TabIndex = 1
        '
        'trainerInfoTitle_lbl
        '
        Me.trainerInfoTitle_lbl.AutoSize = True
        Me.trainerInfoTitle_lbl.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trainerInfoTitle_lbl.Location = New System.Drawing.Point(6, 3)
        Me.trainerInfoTitle_lbl.Name = "trainerInfoTitle_lbl"
        Me.trainerInfoTitle_lbl.Size = New System.Drawing.Size(127, 30)
        Me.trainerInfoTitle_lbl.TabIndex = 0
        Me.trainerInfoTitle_lbl.Text = "Trainer Info"
        '
        'pg_POne
        '
        Me.pg_POne.Controls.Add(Me.pokemonOne_grp)
        Me.pg_POne.Location = New System.Drawing.Point(4, 22)
        Me.pg_POne.Name = "pg_POne"
        Me.pg_POne.Padding = New System.Windows.Forms.Padding(3)
        Me.pg_POne.Size = New System.Drawing.Size(752, 511)
        Me.pg_POne.TabIndex = 1
        Me.pg_POne.Text = "Pokémon 1"
        Me.pg_POne.UseVisualStyleBackColor = True
        '
        'pg_PTwo
        '
        Me.pg_PTwo.Controls.Add(Me.pokemonTwo_grp)
        Me.pg_PTwo.Location = New System.Drawing.Point(4, 22)
        Me.pg_PTwo.Name = "pg_PTwo"
        Me.pg_PTwo.Size = New System.Drawing.Size(752, 511)
        Me.pg_PTwo.TabIndex = 2
        Me.pg_PTwo.Text = "Pokémon 2"
        Me.pg_PTwo.UseVisualStyleBackColor = True
        '
        'pg_PThree
        '
        Me.pg_PThree.Controls.Add(Me.pokemonThree_grp)
        Me.pg_PThree.Location = New System.Drawing.Point(4, 22)
        Me.pg_PThree.Name = "pg_PThree"
        Me.pg_PThree.Size = New System.Drawing.Size(752, 511)
        Me.pg_PThree.TabIndex = 3
        Me.pg_PThree.Text = "Pokémon 3"
        Me.pg_PThree.UseVisualStyleBackColor = True
        '
        'pg_PFour
        '
        Me.pg_PFour.Controls.Add(Me.pokemonFour_grp)
        Me.pg_PFour.Location = New System.Drawing.Point(4, 22)
        Me.pg_PFour.Name = "pg_PFour"
        Me.pg_PFour.Size = New System.Drawing.Size(752, 511)
        Me.pg_PFour.TabIndex = 4
        Me.pg_PFour.Text = "Pokémon 4"
        Me.pg_PFour.UseVisualStyleBackColor = True
        '
        'pg_PFive
        '
        Me.pg_PFive.Controls.Add(Me.pokemonFive_grp)
        Me.pg_PFive.Location = New System.Drawing.Point(4, 22)
        Me.pg_PFive.Name = "pg_PFive"
        Me.pg_PFive.Size = New System.Drawing.Size(752, 511)
        Me.pg_PFive.TabIndex = 5
        Me.pg_PFive.Text = "Pokémon 5"
        Me.pg_PFive.UseVisualStyleBackColor = True
        '
        'pg_PSix
        '
        Me.pg_PSix.Controls.Add(Me.pokemonSix_grp)
        Me.pg_PSix.Location = New System.Drawing.Point(4, 22)
        Me.pg_PSix.Name = "pg_PSix"
        Me.pg_PSix.Size = New System.Drawing.Size(752, 511)
        Me.pg_PSix.TabIndex = 6
        Me.pg_PSix.Text = "Pokémon 6"
        Me.pg_PSix.UseVisualStyleBackColor = True
        '
        'pg_Output
        '
        Me.pg_Output.Controls.Add(Me.multiOutput_chkBox)
        Me.pg_Output.Controls.Add(Me.save_btn)
        Me.pg_Output.Controls.Add(Me.generate_btn)
        Me.pg_Output.Controls.Add(Me.outputBox_rchBox)
        Me.pg_Output.Location = New System.Drawing.Point(4, 22)
        Me.pg_Output.Name = "pg_Output"
        Me.pg_Output.Size = New System.Drawing.Size(752, 511)
        Me.pg_Output.TabIndex = 8
        Me.pg_Output.Text = "Output"
        Me.pg_Output.UseVisualStyleBackColor = True
        '
        'pg_About
        '
        Me.pg_About.Controls.Add(Me.aboutText_lbl)
        Me.pg_About.Controls.Add(Me.gnuGPL3_picBox)
        Me.pg_About.Controls.Add(Me.aboutAuthor_lbl)
        Me.pg_About.Controls.Add(Me.aboutTitle_lbl)
        Me.pg_About.Controls.Add(Me.Logo_picBox)
        Me.pg_About.Location = New System.Drawing.Point(4, 22)
        Me.pg_About.Name = "pg_About"
        Me.pg_About.Size = New System.Drawing.Size(752, 511)
        Me.pg_About.TabIndex = 7
        Me.pg_About.Text = "About"
        Me.pg_About.UseVisualStyleBackColor = True
        '
        'aboutText_lbl
        '
        Me.aboutText_lbl.Location = New System.Drawing.Point(9, 174)
        Me.aboutText_lbl.Name = "aboutText_lbl"
        Me.aboutText_lbl.Size = New System.Drawing.Size(737, 263)
        Me.aboutText_lbl.TabIndex = 9
        Me.aboutText_lbl.Text = resources.GetString("aboutText_lbl.Text")
        '
        'gnuGPL3_picBox
        '
        Me.gnuGPL3_picBox.Image = Global.Showdown_to_Essentials_Converter.My.Resources.Resources.gplv3_with_text_136x68
        Me.gnuGPL3_picBox.Location = New System.Drawing.Point(610, 440)
        Me.gnuGPL3_picBox.Name = "gnuGPL3_picBox"
        Me.gnuGPL3_picBox.Size = New System.Drawing.Size(136, 68)
        Me.gnuGPL3_picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.gnuGPL3_picBox.TabIndex = 8
        Me.gnuGPL3_picBox.TabStop = False
        '
        'aboutAuthor_lbl
        '
        Me.aboutAuthor_lbl.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutAuthor_lbl.Location = New System.Drawing.Point(6, 142)
        Me.aboutAuthor_lbl.Name = "aboutAuthor_lbl"
        Me.aboutAuthor_lbl.Size = New System.Drawing.Size(740, 32)
        Me.aboutAuthor_lbl.TabIndex = 7
        Me.aboutAuthor_lbl.Text = "By TheCrafters001"
        Me.aboutAuthor_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'aboutTitle_lbl
        '
        Me.aboutTitle_lbl.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutTitle_lbl.Location = New System.Drawing.Point(6, 110)
        Me.aboutTitle_lbl.Name = "aboutTitle_lbl"
        Me.aboutTitle_lbl.Size = New System.Drawing.Size(740, 32)
        Me.aboutTitle_lbl.TabIndex = 6
        Me.aboutTitle_lbl.Text = "Pokémon Showdown to Pokémon Essentials Converter"
        Me.aboutTitle_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Logo_picBox
        '
        Me.Logo_picBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.Logo_picBox.Image = Global.Showdown_to_Essentials_Converter.My.Resources.Resources.Showdown_to_Essentials_Logo
        Me.Logo_picBox.Location = New System.Drawing.Point(0, 0)
        Me.Logo_picBox.Name = "Logo_picBox"
        Me.Logo_picBox.Size = New System.Drawing.Size(752, 101)
        Me.Logo_picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Logo_picBox.TabIndex = 5
        Me.Logo_picBox.TabStop = False
        '
        'existingBattle_chkBox
        '
        Me.existingBattle_chkBox.AutoSize = True
        Me.existingBattle_chkBox.Location = New System.Drawing.Point(139, 57)
        Me.existingBattle_chkBox.Name = "existingBattle_chkBox"
        Me.existingBattle_chkBox.Size = New System.Drawing.Size(262, 17)
        Me.existingBattle_chkBox.TabIndex = 3
        Me.existingBattle_chkBox.Text = "This team is for a NPC that already has a team."
        Me.existingBattle_chkBox.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'battleTeamID_lbl
        '
        Me.battleTeamID_lbl.AutoSize = True
        Me.battleTeamID_lbl.Location = New System.Drawing.Point(6, 161)
        Me.battleTeamID_lbl.Name = "battleTeamID_lbl"
        Me.battleTeamID_lbl.Size = New System.Drawing.Size(182, 13)
        Me.battleTeamID_lbl.TabIndex = 5
        Me.battleTeamID_lbl.Text = "Battle Team ID (Must be a number)"
        '
        'battleTeamID_txtBox
        '
        Me.battleTeamID_txtBox.Location = New System.Drawing.Point(6, 177)
        Me.battleTeamID_txtBox.MaxLength = 25
        Me.battleTeamID_txtBox.Name = "battleTeamID_txtBox"
        Me.battleTeamID_txtBox.Size = New System.Drawing.Size(127, 22)
        Me.battleTeamID_txtBox.TabIndex = 4
        '
        'trainerType_lbl
        '
        Me.trainerType_lbl.AutoSize = True
        Me.trainerType_lbl.Location = New System.Drawing.Point(6, 80)
        Me.trainerType_lbl.Name = "trainerType_lbl"
        Me.trainerType_lbl.Size = New System.Drawing.Size(198, 13)
        Me.trainerType_lbl.TabIndex = 7
        Me.trainerType_lbl.Text = "Trainer Type (Refer to trainertypes.txt)"
        '
        'trainerType_txtBox
        '
        Me.trainerType_txtBox.Location = New System.Drawing.Point(6, 96)
        Me.trainerType_txtBox.MaxLength = 25
        Me.trainerType_txtBox.Name = "trainerType_txtBox"
        Me.trainerType_txtBox.Size = New System.Drawing.Size(127, 22)
        Me.trainerType_txtBox.TabIndex = 6
        '
        'trainerItems_grp
        '
        Me.trainerItems_grp.Controls.Add(Me.itemEight_txtBox)
        Me.trainerItems_grp.Controls.Add(Me.itemSeven_txtBox)
        Me.trainerItems_grp.Controls.Add(Me.itemSix_txtBox)
        Me.trainerItems_grp.Controls.Add(Me.itemFive_txtBox)
        Me.trainerItems_grp.Controls.Add(Me.itemFour_txtBox)
        Me.trainerItems_grp.Controls.Add(Me.itemThree_txtBox)
        Me.trainerItems_grp.Controls.Add(Me.itemTwo_txtBox)
        Me.trainerItems_grp.Controls.Add(Me.itemOne_txtBox)
        Me.trainerItems_grp.Location = New System.Drawing.Point(533, 29)
        Me.trainerItems_grp.Name = "trainerItems_grp"
        Me.trainerItems_grp.Size = New System.Drawing.Size(213, 476)
        Me.trainerItems_grp.TabIndex = 8
        Me.trainerItems_grp.TabStop = False
        Me.trainerItems_grp.Text = "Items"
        '
        'trainerUsesItems_chkBox
        '
        Me.trainerUsesItems_chkBox.AutoSize = True
        Me.trainerUsesItems_chkBox.Location = New System.Drawing.Point(533, 6)
        Me.trainerUsesItems_chkBox.Name = "trainerUsesItems_chkBox"
        Me.trainerUsesItems_chkBox.Size = New System.Drawing.Size(140, 17)
        Me.trainerUsesItems_chkBox.TabIndex = 9
        Me.trainerUsesItems_chkBox.Text = "This trainer uses items"
        Me.trainerUsesItems_chkBox.UseVisualStyleBackColor = True
        '
        'numPoké_cmb
        '
        Me.numPoké_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.numPoké_cmb.FormattingEnabled = True
        Me.numPoké_cmb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.numPoké_cmb.Location = New System.Drawing.Point(6, 137)
        Me.numPoké_cmb.Name = "numPoké_cmb"
        Me.numPoké_cmb.Size = New System.Drawing.Size(127, 21)
        Me.numPoké_cmb.TabIndex = 10
        '
        'numPoké_lbl
        '
        Me.numPoké_lbl.AutoSize = True
        Me.numPoké_lbl.Location = New System.Drawing.Point(6, 121)
        Me.numPoké_lbl.Name = "numPoké_lbl"
        Me.numPoké_lbl.Size = New System.Drawing.Size(113, 13)
        Me.numPoké_lbl.TabIndex = 11
        Me.numPoké_lbl.Text = "Number of Pokémon"
        '
        'properSpellingNote_lbl
        '
        Me.properSpellingNote_lbl.AutoSize = True
        Me.properSpellingNote_lbl.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.properSpellingNote_lbl.Location = New System.Drawing.Point(7, 485)
        Me.properSpellingNote_lbl.Name = "properSpellingNote_lbl"
        Me.properSpellingNote_lbl.Size = New System.Drawing.Size(241, 20)
        Me.properSpellingNote_lbl.TabIndex = 12
        Me.properSpellingNote_lbl.Text = "Note: Proper spelling IS required."
        '
        'itemOne_txtBox
        '
        Me.itemOne_txtBox.Location = New System.Drawing.Point(6, 26)
        Me.itemOne_txtBox.Name = "itemOne_txtBox"
        Me.itemOne_txtBox.Size = New System.Drawing.Size(201, 22)
        Me.itemOne_txtBox.TabIndex = 0
        '
        'itemTwo_txtBox
        '
        Me.itemTwo_txtBox.Location = New System.Drawing.Point(6, 54)
        Me.itemTwo_txtBox.Name = "itemTwo_txtBox"
        Me.itemTwo_txtBox.Size = New System.Drawing.Size(201, 22)
        Me.itemTwo_txtBox.TabIndex = 1
        '
        'itemThree_txtBox
        '
        Me.itemThree_txtBox.Location = New System.Drawing.Point(6, 82)
        Me.itemThree_txtBox.Name = "itemThree_txtBox"
        Me.itemThree_txtBox.Size = New System.Drawing.Size(201, 22)
        Me.itemThree_txtBox.TabIndex = 2
        '
        'itemFour_txtBox
        '
        Me.itemFour_txtBox.Location = New System.Drawing.Point(6, 110)
        Me.itemFour_txtBox.Name = "itemFour_txtBox"
        Me.itemFour_txtBox.Size = New System.Drawing.Size(201, 22)
        Me.itemFour_txtBox.TabIndex = 3
        '
        'itemFive_txtBox
        '
        Me.itemFive_txtBox.Location = New System.Drawing.Point(6, 138)
        Me.itemFive_txtBox.Name = "itemFive_txtBox"
        Me.itemFive_txtBox.Size = New System.Drawing.Size(201, 22)
        Me.itemFive_txtBox.TabIndex = 4
        '
        'itemSix_txtBox
        '
        Me.itemSix_txtBox.Location = New System.Drawing.Point(6, 166)
        Me.itemSix_txtBox.Name = "itemSix_txtBox"
        Me.itemSix_txtBox.Size = New System.Drawing.Size(201, 22)
        Me.itemSix_txtBox.TabIndex = 5
        '
        'itemSeven_txtBox
        '
        Me.itemSeven_txtBox.Location = New System.Drawing.Point(6, 194)
        Me.itemSeven_txtBox.Name = "itemSeven_txtBox"
        Me.itemSeven_txtBox.Size = New System.Drawing.Size(201, 22)
        Me.itemSeven_txtBox.TabIndex = 6
        '
        'itemEight_txtBox
        '
        Me.itemEight_txtBox.Location = New System.Drawing.Point(6, 222)
        Me.itemEight_txtBox.Name = "itemEight_txtBox"
        Me.itemEight_txtBox.Size = New System.Drawing.Size(201, 22)
        Me.itemEight_txtBox.TabIndex = 7
        '
        'outputBox_rchBox
        '
        Me.outputBox_rchBox.DetectUrls = False
        Me.outputBox_rchBox.Location = New System.Drawing.Point(3, 3)
        Me.outputBox_rchBox.Name = "outputBox_rchBox"
        Me.outputBox_rchBox.ReadOnly = True
        Me.outputBox_rchBox.Size = New System.Drawing.Size(746, 476)
        Me.outputBox_rchBox.TabIndex = 0
        Me.outputBox_rchBox.Text = ""
        '
        'generate_btn
        '
        Me.generate_btn.Location = New System.Drawing.Point(674, 485)
        Me.generate_btn.Name = "generate_btn"
        Me.generate_btn.Size = New System.Drawing.Size(75, 23)
        Me.generate_btn.TabIndex = 1
        Me.generate_btn.Text = "Generate"
        Me.generate_btn.UseVisualStyleBackColor = True
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(593, 485)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(75, 23)
        Me.save_btn.TabIndex = 2
        Me.save_btn.Text = "Save"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'multiOutput_chkBox
        '
        Me.multiOutput_chkBox.AutoSize = True
        Me.multiOutput_chkBox.Location = New System.Drawing.Point(3, 489)
        Me.multiOutput_chkBox.Name = "multiOutput_chkBox"
        Me.multiOutput_chkBox.Size = New System.Drawing.Size(169, 17)
        Me.multiOutput_chkBox.TabIndex = 3
        Me.multiOutput_chkBox.Text = "Multi Output (Experimental)"
        Me.multiOutput_chkBox.UseVisualStyleBackColor = True
        '
        'codeExporter_dialog
        '
        Me.codeExporter_dialog.CheckFileExists = True
        Me.codeExporter_dialog.FileName = "GeneratedTrainers.txt"
        Me.codeExporter_dialog.Filter = "Text Document (*.txt)|*.txt"
        '
        'pokemonOne_grp
        '
        Me.pokemonOne_grp.Location = New System.Drawing.Point(6, 6)
        Me.pokemonOne_grp.Name = "pokemonOne_grp"
        Me.pokemonOne_grp.Size = New System.Drawing.Size(740, 499)
        Me.pokemonOne_grp.TabIndex = 0
        Me.pokemonOne_grp.TabStop = False
        Me.pokemonOne_grp.Text = "Pokémon 1"
        '
        'pokemonTwo_grp
        '
        Me.pokemonTwo_grp.Location = New System.Drawing.Point(6, 6)
        Me.pokemonTwo_grp.Name = "pokemonTwo_grp"
        Me.pokemonTwo_grp.Size = New System.Drawing.Size(740, 499)
        Me.pokemonTwo_grp.TabIndex = 1
        Me.pokemonTwo_grp.TabStop = False
        Me.pokemonTwo_grp.Text = "Pokémon 2"
        '
        'pokemonThree_grp
        '
        Me.pokemonThree_grp.Location = New System.Drawing.Point(6, 6)
        Me.pokemonThree_grp.Name = "pokemonThree_grp"
        Me.pokemonThree_grp.Size = New System.Drawing.Size(740, 499)
        Me.pokemonThree_grp.TabIndex = 1
        Me.pokemonThree_grp.TabStop = False
        Me.pokemonThree_grp.Text = "Pokémon 3"
        '
        'pokemonFour_grp
        '
        Me.pokemonFour_grp.Location = New System.Drawing.Point(6, 6)
        Me.pokemonFour_grp.Name = "pokemonFour_grp"
        Me.pokemonFour_grp.Size = New System.Drawing.Size(740, 499)
        Me.pokemonFour_grp.TabIndex = 1
        Me.pokemonFour_grp.TabStop = False
        Me.pokemonFour_grp.Text = "Pokémon 4"
        '
        'pokemonFive_grp
        '
        Me.pokemonFive_grp.Location = New System.Drawing.Point(6, 6)
        Me.pokemonFive_grp.Name = "pokemonFive_grp"
        Me.pokemonFive_grp.Size = New System.Drawing.Size(740, 499)
        Me.pokemonFive_grp.TabIndex = 1
        Me.pokemonFive_grp.TabStop = False
        Me.pokemonFive_grp.Text = "Pokémon 5"
        '
        'pokemonSix_grp
        '
        Me.pokemonSix_grp.Location = New System.Drawing.Point(6, 6)
        Me.pokemonSix_grp.Name = "pokemonSix_grp"
        Me.pokemonSix_grp.Size = New System.Drawing.Size(740, 499)
        Me.pokemonSix_grp.TabIndex = 1
        Me.pokemonSix_grp.TabStop = False
        Me.pokemonSix_grp.Text = "Pokémon 6"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Showdown to Essentials Converter"
        Me.TabControl1.ResumeLayout(False)
        Me.pg_Trainer.ResumeLayout(False)
        Me.pg_Trainer.PerformLayout()
        Me.pg_POne.ResumeLayout(False)
        Me.pg_PTwo.ResumeLayout(False)
        Me.pg_PThree.ResumeLayout(False)
        Me.pg_PFour.ResumeLayout(False)
        Me.pg_PFive.ResumeLayout(False)
        Me.pg_PSix.ResumeLayout(False)
        Me.pg_Output.ResumeLayout(False)
        Me.pg_Output.PerformLayout()
        Me.pg_About.ResumeLayout(False)
        Me.pg_About.PerformLayout()
        CType(Me.gnuGPL3_picBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo_picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.trainerItems_grp.ResumeLayout(False)
        Me.trainerItems_grp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents pg_Trainer As TabPage
    Friend WithEvents pg_POne As TabPage
    Friend WithEvents pg_PTwo As TabPage
    Friend WithEvents pg_PThree As TabPage
    Friend WithEvents pg_PFour As TabPage
    Friend WithEvents pg_PFive As TabPage
    Friend WithEvents pg_PSix As TabPage
    Friend WithEvents pg_About As TabPage
    Friend WithEvents trainerName_lbl As Label
    Friend WithEvents trainerName_txtBox As TextBox
    Friend WithEvents trainerInfoTitle_lbl As Label
    Friend WithEvents pg_Output As TabPage
    Friend WithEvents aboutText_lbl As Label
    Friend WithEvents gnuGPL3_picBox As PictureBox
    Friend WithEvents aboutAuthor_lbl As Label
    Friend WithEvents aboutTitle_lbl As Label
    Friend WithEvents Logo_picBox As PictureBox
    Friend WithEvents existingBattle_chkBox As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents battleTeamID_lbl As Label
    Friend WithEvents battleTeamID_txtBox As TextBox
    Friend WithEvents trainerType_lbl As Label
    Friend WithEvents trainerType_txtBox As TextBox
    Friend WithEvents trainerUsesItems_chkBox As CheckBox
    Friend WithEvents trainerItems_grp As GroupBox
    Friend WithEvents numPoké_lbl As Label
    Friend WithEvents numPoké_cmb As ComboBox
    Friend WithEvents properSpellingNote_lbl As Label
    Friend WithEvents itemEight_txtBox As TextBox
    Friend WithEvents itemSeven_txtBox As TextBox
    Friend WithEvents itemSix_txtBox As TextBox
    Friend WithEvents itemFive_txtBox As TextBox
    Friend WithEvents itemFour_txtBox As TextBox
    Friend WithEvents itemThree_txtBox As TextBox
    Friend WithEvents itemTwo_txtBox As TextBox
    Friend WithEvents itemOne_txtBox As TextBox
    Friend WithEvents multiOutput_chkBox As CheckBox
    Friend WithEvents save_btn As Button
    Friend WithEvents generate_btn As Button
    Friend WithEvents outputBox_rchBox As RichTextBox
    Friend WithEvents codeExporter_dialog As SaveFileDialog
    Friend WithEvents pokemonOne_grp As GroupBox
    Friend WithEvents pokemonTwo_grp As GroupBox
    Friend WithEvents pokemonThree_grp As GroupBox
    Friend WithEvents pokemonFour_grp As GroupBox
    Friend WithEvents pokemonFive_grp As GroupBox
    Friend WithEvents pokemonSix_grp As GroupBox
End Class
