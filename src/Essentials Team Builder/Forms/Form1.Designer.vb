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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        editor_grp = New GroupBox()
        editor_tab = New TabControl()
        pg_trainer = New TabPage()
        trainer_tab = New TabControl()
        pg_basic = New TabPage()
        battleTeamID_nbr = New NumericUpDown()
        Label2 = New Label()
        properSpellingNote_lbl = New Label()
        essData_lbl = New Label()
        allowSuperShiny_chk = New CheckBox()
        loseTextQuotes_chkBox = New CheckBox()
        useAbilityIndex_chkBox = New CheckBox()
        existingBattle_chkBox = New CheckBox()
        customBallIDs_chkBox = New CheckBox()
        essVersion_cmb = New ComboBox()
        essVersion_lbl = New Label()
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
        itemAddMaxElixir_btn = New Button()
        itemAddElixir_btn = New Button()
        itemAddMaxEther_btn = New Button()
        itemAddEther_btn = New Button()
        itemAddFullRestore_btn = New Button()
        itemAddHyperPotion_btn = New Button()
        itemAddMaxPotion_btn = New Button()
        itemAddSuperPotion_btn = New Button()
        itemAddPotion_btn = New Button()
        removeItem_btn = New Button()
        addItem_btn = New Button()
        trainerItemsInfo_lbl = New Label()
        trainerItemsHeader_lbl = New Label()
        items_grp = New GroupBox()
        items_lst = New ListBox()
        pg_pokemon = New TabPage()
        pkmnTabs_tab = New TabControl()
        pg_pkmn1 = New TabPage()
        pokemon1_grp = New GroupBox()
        pokemon1Level_nbr = New NumericUpDown()
        pokemon1Form_nbr = New NumericUpDown()
        pokemon1Happiness_nbr = New NumericUpDown()
        pokemon1Shadow_grp = New GroupBox()
        pokemon1Shadow_rad = New RadioButton()
        pokemon1NotShadow_rad = New RadioButton()
        pokemon1EVs_grp = New GroupBox()
        pokemon1EVsDEF_txt = New TextBox()
        pokemon1EVsDEF_lbl = New Label()
        pokemon1EVsSPDEF_txt = New TextBox()
        pokemon1EVsSPDEF_lbl = New Label()
        pokemon1EVsSPATK_txt = New TextBox()
        pokemon1EVsSPATK_lbl = New Label()
        pokemon1EVsSPD_txt = New TextBox()
        pokemon1EVsSPD_lbl = New Label()
        pokemon1EVsATK_txt = New TextBox()
        pokemon1EVsATK_lbl = New Label()
        pokemon1EVsHP_txt = New TextBox()
        pokemon1EVsHP_lbl = New Label()
        pokemon1IVs_grp = New GroupBox()
        pokemon1RandomIVs_btn = New Button()
        pokemon1MaxIVs_btn = New Button()
        pokemon1IVsDEF_txt = New TextBox()
        pokemon1IVsDEF_lbl = New Label()
        pokemon1IVsSPDEF_txt = New TextBox()
        pokemon1IVsSPDEF_lbl = New Label()
        pokemon1IVsSPATK_txt = New TextBox()
        pokemon1IVsSPATK_lbl = New Label()
        pokemon1IVsSPD_txt = New TextBox()
        pokemon1IVsSPD_lbl = New Label()
        pokemon1IVsATK_txt = New TextBox()
        pokemon1IVsATK_lbl = New Label()
        pokemon1IVsHP_txt = New TextBox()
        pokemon1IVsHP_lbl = New Label()
        pokemon1PokeballID_cmb = New ComboBox()
        pokemon1Ball_lbl = New Label()
        pokemon1Nickname_txtBox = New TextBox()
        pokemon1Nickname_lbl = New Label()
        pokemon1Happiness_lbl = New Label()
        pokemon1Nature_cmb = New ComboBox()
        pokemon1Nature_lbl = New Label()
        pokemon1Shiny_grp = New GroupBox()
        pokemon1SuperShiny_chkBox = New CheckBox()
        pokemon1Shiny_rad = New RadioButton()
        pokemon1NotShiny_rad = New RadioButton()
        pokemon1Form_lbl = New Label()
        pokemon1Gender_cmb = New ComboBox()
        pokemon1Gender_lbl = New Label()
        pokemon1Ability_cmb = New ComboBox()
        pokemon1Ability_lbl = New Label()
        pokemon1Moves_grp = New GroupBox()
        pokemon1Move4_txtBox = New TextBox()
        pokemon1Move3_txtBox = New TextBox()
        pokemon1Move2_txtBox = New TextBox()
        pokemon1Move1_txtBox = New TextBox()
        pokemon1Level_lbl = New Label()
        pokemon1HeldItem_lbl = New Label()
        pokemon1HeldItem_txtBox = New TextBox()
        pokemon1Name_txtBox = New TextBox()
        pokemon1Name_lbl = New Label()
        pg_pkmn2 = New TabPage()
        pokemon2_grp = New GroupBox()
        pokemon2Level_nbr = New NumericUpDown()
        pokemon2Form_nbr = New NumericUpDown()
        pokemon2Happiness_nbr = New NumericUpDown()
        pokemon2Shadow_grp = New GroupBox()
        pokemon2Shadow_rad = New RadioButton()
        pokemon2NotShadow_rad = New RadioButton()
        pokemon2Name_lbl = New Label()
        pokemon2EVs_grp = New GroupBox()
        pokemon2EVsDEF_txt = New TextBox()
        pokemon2EVsDEF_lbl = New Label()
        pokemon2EVsSPDEF_txt = New TextBox()
        pokemon2EVsSPDEF_lbl = New Label()
        pokemon2EVsSPATK_txt = New TextBox()
        pokemon2EVsSPATK_lbl = New Label()
        pokemon2EVsSPD_txt = New TextBox()
        pokemon2EVsSPD_lbl = New Label()
        pokemon2EVsATK_txt = New TextBox()
        pokemon2EVsATK_lbl = New Label()
        pokemon2EVsHP_txt = New TextBox()
        pokemon2EVsHP_lbl = New Label()
        pokemon2Name_txt = New TextBox()
        pokemon2IVs_grp = New GroupBox()
        pokemon2RandomIVs_btn = New Button()
        pokemon2MaxIVs_btn = New Button()
        pokemon2IVsDEF_txt = New TextBox()
        pokemon2IVsDEF_lbl = New Label()
        pokemon2IVsSPDEF_txt = New TextBox()
        pokemon2IVsSPDEF_lbl = New Label()
        pokemon2IVsSPATK_txt = New TextBox()
        pokemon2IVsSPATK_lbl = New Label()
        pokemon2IVsSPD_txt = New TextBox()
        pokemon2IVsSPD_lbl = New Label()
        pokemon2IVsATK_txt = New TextBox()
        pokemon2IVsATK_lbl = New Label()
        pokemon2IVsHP_txt = New TextBox()
        pokemon2IVsHP_lbl = New Label()
        pokemon2HeldItem_txt = New TextBox()
        pokemon2PokeballID_cmb = New ComboBox()
        pokemon2HeldItem_lbl = New Label()
        pokemon2PokeBall_lbl = New Label()
        pokemon2Level_lbl = New Label()
        pokemon2Nickname_txt = New TextBox()
        pokemon2Nickname_lbl = New Label()
        pokemon2Moves_grp = New GroupBox()
        pokemon2Move4_txtBox = New TextBox()
        pokemon2Move3_txtBox = New TextBox()
        pokemon2Move2_txtBox = New TextBox()
        pokemon2Move1_txtBox = New TextBox()
        pokemon2Ability_lbl = New Label()
        pokemon2Happiness_lbl = New Label()
        pokemon2Ability_cmb = New ComboBox()
        pokemon2Nature_cmb = New ComboBox()
        pokemon2Gender_lbl = New Label()
        pokemon2Nature_lbl = New Label()
        pokemon2Gender_cmb = New ComboBox()
        pokemon2Shiny_grp = New GroupBox()
        pokemon2SuperShiny_chkBox = New CheckBox()
        pokemon2Shiny_rad = New RadioButton()
        pokemon2NotShiny_rad = New RadioButton()
        pokemon2Form_lbl = New Label()
        pg_pkmn3 = New TabPage()
        pokemon3_grp = New GroupBox()
        pokemon3Level_nbr = New NumericUpDown()
        pokemon3Form_nbr = New NumericUpDown()
        pokemon3Happiness_nbr = New NumericUpDown()
        pokemon3Shadow_grp = New GroupBox()
        pokemon3Shadow_rad = New RadioButton()
        pokemon3NotShadow_rad = New RadioButton()
        pokemon3Name_lbl = New Label()
        pokemon3EVs_grp = New GroupBox()
        pokemon3EVsDEF_txt = New TextBox()
        pokemon3EVsDEF_lbl = New Label()
        pokemon3EVsSPDEF_txt = New TextBox()
        pokemon3EVsSPDEF_lbl = New Label()
        pokemon3EVsSPATK_txt = New TextBox()
        pokemon3EVsSPATK_lbl = New Label()
        pokemon3EVsSPD_txt = New TextBox()
        pokemon3EVsSPD_lbl = New Label()
        pokemon3EVsATK_txt = New TextBox()
        pokemon3EVsATK_lbl = New Label()
        pokemon3EVsHP_txt = New TextBox()
        pokemon3EVsHP_lbl = New Label()
        pokemon3Name_txt = New TextBox()
        pokemon3IVs_grp = New GroupBox()
        pokemon3RandomIVs_btn = New Button()
        pokemon3MaxIVs_btn = New Button()
        pokemon3IVsDEF_txt = New TextBox()
        pokemon3IVsDEF_lbl = New Label()
        pokemon3IVsSPDEF_txt = New TextBox()
        pokemon3IVsSPDEF_lbl = New Label()
        pokemon3IVsSPATK_txt = New TextBox()
        pokemon3IVsSPATK_lbl = New Label()
        pokemon3IVsSPD_txt = New TextBox()
        pokemon3IVsSPD_lbl = New Label()
        pokemon3IVsATK_txt = New TextBox()
        pokemon3IVsATK_lbl = New Label()
        pokemon3IVsHP_txt = New TextBox()
        pokemon3IVsHP_lbl = New Label()
        pokemon3HeldItem_txt = New TextBox()
        pokemon3PokeballID_cmb = New ComboBox()
        pokemon3HeldItem_lbl = New Label()
        pokemon3PokeBall_lbl = New Label()
        pokemon3Level_lbl = New Label()
        pokemon3Nickname_txt = New TextBox()
        pokemon3Nickname_lbl = New Label()
        pokemon3Moves_grp = New GroupBox()
        pokemon3Move4_txtBox = New TextBox()
        pokemon3Move3_txtBox = New TextBox()
        pokemon3Move2_txtBox = New TextBox()
        pokemon3Move1_txtBox = New TextBox()
        pokemon3Ability_lbl = New Label()
        pokemon3Happiness_lbl = New Label()
        pokemon3Ability_cmb = New ComboBox()
        pokemon3Nature_cmb = New ComboBox()
        pokemon3Gender_lbl = New Label()
        pokemon3Nature_lbl = New Label()
        pokemon3Gender_cmb = New ComboBox()
        pokemon3Shiny_grp = New GroupBox()
        pokemon3SuperShiny_chkBox = New CheckBox()
        pokemon3Shiny_rad = New RadioButton()
        pokemon3NotShiny_rad = New RadioButton()
        pokemon3Form_lbl = New Label()
        pg_pkmn4 = New TabPage()
        pokemon4_grp = New GroupBox()
        pokemon4Level_nbr = New NumericUpDown()
        pokemon4Form_nbr = New NumericUpDown()
        pokemon4Happiness_nbr = New NumericUpDown()
        pokemon4Shadow_grp = New GroupBox()
        pokemon4Shadow_rad = New RadioButton()
        pokemon4NotShadow_rad = New RadioButton()
        pokemon4Name_lbl = New Label()
        pokemon4EVs_grp = New GroupBox()
        pokemon4EVsDEF_txt = New TextBox()
        pokemon4EVsDEF_lbl = New Label()
        pokemon4EVsSPDEF_txt = New TextBox()
        pokemon4EVsSPDEF_lbl = New Label()
        pokemon4EVsSPATK_txt = New TextBox()
        pokemon4EVsSPATK_lbl = New Label()
        pokemon4EVsSPD_txt = New TextBox()
        pokemon4EVsSPD_lbl = New Label()
        pokemon4EVsATK_txt = New TextBox()
        pokemon4EVsATK_lbl = New Label()
        pokemon4EVsHP_txt = New TextBox()
        pokemon4EVsHP_lbl = New Label()
        pokemon4Name_txt = New TextBox()
        pokemon4IVs_grp = New GroupBox()
        pokemon4RandomIVs_btn = New Button()
        pokemon4MaxIVs_btn = New Button()
        pokemon4IVsDEF_txt = New TextBox()
        pokemon4IVsDEF_lbl = New Label()
        pokemon4IVsSPDEF_txt = New TextBox()
        pokemon4IVsSPDEF_lbl = New Label()
        pokemon4IVsSPATK_txt = New TextBox()
        pokemon4IVsSPATK_lbl = New Label()
        pokemon4IVsSPD_txt = New TextBox()
        pokemon4IVsSPD_lbl = New Label()
        pokemon4IVsATK_txt = New TextBox()
        pokemon4IVsATK_lbl = New Label()
        pokemon4IVsHP_txt = New TextBox()
        pokemon4IVsHP_lbl = New Label()
        pokemon4HeldItem_txt = New TextBox()
        pokemon4PokeballID_cmb = New ComboBox()
        pokemon4HeldItem_lbl = New Label()
        pokemon4PokeBall_lbl = New Label()
        pokemon4Level_lbl = New Label()
        pokemon4Nickname_txt = New TextBox()
        pokemon4Nickname_lbl = New Label()
        pokemon4Moves_grp = New GroupBox()
        pokemon4Move4_txtBox = New TextBox()
        pokemon4Move3_txtBox = New TextBox()
        pokemon4Move2_txtBox = New TextBox()
        pokemon4Move1_txtBox = New TextBox()
        pokemon4Ability_lbl = New Label()
        pokemon4Happiness_lbl = New Label()
        pokemon4Ability_cmb = New ComboBox()
        pokemon4Nature_cmb = New ComboBox()
        pokemon4Gender_lbl = New Label()
        pokemon4Nature_lbl = New Label()
        pokemon4Gender_cmb = New ComboBox()
        pokemon4Shiny_grp = New GroupBox()
        pokemon4SuperShiny_chkBox = New CheckBox()
        pokemon4Shiny_rad = New RadioButton()
        pokemon4NotShiny_rad = New RadioButton()
        pokemon4Form_lbl = New Label()
        pg_pkmn5 = New TabPage()
        pokemon5_grp = New GroupBox()
        pokemon5Level_nbr = New NumericUpDown()
        pokemon5Form_nbr = New NumericUpDown()
        pokemon5Happiness_nbr = New NumericUpDown()
        pokemon5Shadow_grp = New GroupBox()
        pokemon5Shadow_rad = New RadioButton()
        pokemon5NotShadow_rad = New RadioButton()
        pokemon5Name_lbl = New Label()
        pokemon5EVs_grp = New GroupBox()
        pokemon5EVsDEF_txt = New TextBox()
        pokemon5EVsDEF_lbl = New Label()
        pokemon5EVsSPDEF_txt = New TextBox()
        pokemon5EVsSPDEF_lbl = New Label()
        pokemon5EVsSPATK_txt = New TextBox()
        pokemon5EVsSPATK_lbl = New Label()
        pokemon5EVsSPD_txt = New TextBox()
        pokemon5EVsSPD_lbl = New Label()
        pokemon5EVsATK_txt = New TextBox()
        pokemon5EVsATK_lbl = New Label()
        pokemon5EVsHP_txt = New TextBox()
        pokemon5EVsHP_lbl = New Label()
        pokemon5Name_txt = New TextBox()
        pokemon5IVs_grp = New GroupBox()
        pokemon5RandomIVs_btn = New Button()
        pokemon5MaxIVs_btn = New Button()
        pokemon5IVsDEF_txt = New TextBox()
        pokemon5IVsDEF_lbl = New Label()
        pokemon5IVsSPDEF_txt = New TextBox()
        pokemon5IVsSPDEF_lbl = New Label()
        pokemon5IVsSPATK_txt = New TextBox()
        pokemon5IVsSPATK_lbl = New Label()
        pokemon5IVsSPD_txt = New TextBox()
        pokemon5IVsSPD_lbl = New Label()
        pokemon5IVsATK_txt = New TextBox()
        pokemon5IVsATK_lbl = New Label()
        pokemon5IVsHP_txt = New TextBox()
        pokemon5IVsHP_lbl = New Label()
        pokemon5HeldItem_txt = New TextBox()
        pokemon5PokeballID_cmb = New ComboBox()
        pokemon5HeldItem_lbl = New Label()
        pokemon5PokeBall_lbl = New Label()
        pokemon5Level_lbl = New Label()
        pokemon5Nickname_txt = New TextBox()
        pokemon5Nickname_lbl = New Label()
        pokemon5Moves_grp = New GroupBox()
        pokemon5Move4_txt = New TextBox()
        pokemon5Move3_txt = New TextBox()
        pokemon5Move2_txt = New TextBox()
        pokemon5Move1_txt = New TextBox()
        pokemon5Ability_lbl = New Label()
        pokemon5Happiness_lbl = New Label()
        pokemon5Ability_cmb = New ComboBox()
        pokemon5Nature_cmb = New ComboBox()
        pokemon5Gender_lbl = New Label()
        pokemon5Nature_lbl = New Label()
        pokemon5Gender_cmb = New ComboBox()
        pokemon5Shiny_grp = New GroupBox()
        pokemon5SuperShiny_chkBox = New CheckBox()
        pokemon5Shiny_rad = New RadioButton()
        pokemon5NotShiny_rad = New RadioButton()
        pokemon5Form_lbl = New Label()
        pg_pkmn6 = New TabPage()
        pokemon6_grp = New GroupBox()
        pokemon6Level_nbr = New NumericUpDown()
        pokemon6Form_nbr = New NumericUpDown()
        pokemon6Happiness_nbr = New NumericUpDown()
        pokemon6Shadow_grp = New GroupBox()
        pokemon6Shadow_rad = New RadioButton()
        pokemon6NotShadow_rad = New RadioButton()
        pokemon6Name_lbl = New Label()
        pokemon6EVs_grp = New GroupBox()
        pokemon6EVsDEF_txt = New TextBox()
        pokemon6EVsDEF_lbl = New Label()
        pokemon6EVsSPDEF_txt = New TextBox()
        pokemon6EVsSPDEF_lbl = New Label()
        pokemon6EVsSPATK_txt = New TextBox()
        pokemon6EVsSPATK_lbl = New Label()
        pokemon6EVsSPD_txt = New TextBox()
        pokemon6EVsSPD_lbl = New Label()
        pokemon6EVsATK_txt = New TextBox()
        pokemon6EVsATK_lbl = New Label()
        pokemon6EVsHP_txt = New TextBox()
        pokemon6EVsHP_lbl = New Label()
        pokemon6Name_txt = New TextBox()
        pokemon6IVs_grp = New GroupBox()
        pokemon6RandomIVs_btn = New Button()
        pokemon6MaxIVs_btn = New Button()
        pokemon6IVsDEF_txt = New TextBox()
        pokemon6IVsDEF_lbl = New Label()
        pokemon6IVsSPDEF_txt = New TextBox()
        pokemon6IVsSPDEF_lbl = New Label()
        pokemon6IVsSPATK_txt = New TextBox()
        pokemon6IVsSPATK_lbl = New Label()
        pokemon6IVsSPD_txt = New TextBox()
        pokemon6IVsSPD_lbl = New Label()
        pokemon6IVsATK_txt = New TextBox()
        pokemon6IVsATK_lbl = New Label()
        pokemon6IVsHP_txt = New TextBox()
        pokemon6IVsHP_lbl = New Label()
        pokemon6HeldItem_txt = New TextBox()
        pokemon6PokeballID_cmb = New ComboBox()
        pokemon6HeldItem_lbl = New Label()
        pokemon6Pokeball_lbl = New Label()
        pokemon6Level_lbl = New Label()
        pokemon6Nickname_txt = New TextBox()
        pokemon6Nickname_lbl = New Label()
        pokemon6Moves_grp = New GroupBox()
        pokemon6Move4_txt = New TextBox()
        pokemon6Move3_txt = New TextBox()
        pokemon6Move2_txt = New TextBox()
        pokemon6Move1_txt = New TextBox()
        pokemon6Ability_lbl = New Label()
        pokemon6Happiness_lbl = New Label()
        pokemon6Ability_cmb = New ComboBox()
        pokemon6Nature_cmb = New ComboBox()
        pokemon6Gender_lbl = New Label()
        pokemon6Nature_lbl = New Label()
        pokemon6Gender_cmb = New ComboBox()
        pokemon6Shiny_grp = New GroupBox()
        pokemon6SuperShiny_chkBox = New CheckBox()
        pokemon6Shiny_rad = New RadioButton()
        pokemon6NotShiny_rad = New RadioButton()
        pokemon6Form_lbl = New Label()
        pg_about = New TabPage()
        Label1 = New Label()
        thirdPartyLicenses_btn = New Button()
        licenseText_lbl = New Label()
        PictureBox1 = New PictureBox()
        aboutInfo_lbl = New Label()
        copyright_lbl = New Label()
        aboutHeaderAuthor_lbl = New Label()
        MenuStrip1 = New MenuStrip()
        GeneratePreviewToolStripMenuItem = New ToolStripMenuItem()
        editor_grp.SuspendLayout()
        editor_tab.SuspendLayout()
        pg_trainer.SuspendLayout()
        trainer_tab.SuspendLayout()
        pg_basic.SuspendLayout()
        CType(battleTeamID_nbr, ComponentModel.ISupportInitialize).BeginInit()
        pg_items.SuspendLayout()
        items_grp.SuspendLayout()
        pg_pokemon.SuspendLayout()
        pkmnTabs_tab.SuspendLayout()
        pg_pkmn1.SuspendLayout()
        pokemon1_grp.SuspendLayout()
        CType(pokemon1Level_nbr, ComponentModel.ISupportInitialize).BeginInit()
        CType(pokemon1Form_nbr, ComponentModel.ISupportInitialize).BeginInit()
        CType(pokemon1Happiness_nbr, ComponentModel.ISupportInitialize).BeginInit()
        pokemon1Shadow_grp.SuspendLayout()
        pokemon1EVs_grp.SuspendLayout()
        pokemon1IVs_grp.SuspendLayout()
        pokemon1Shiny_grp.SuspendLayout()
        pokemon1Moves_grp.SuspendLayout()
        pg_pkmn2.SuspendLayout()
        pokemon2_grp.SuspendLayout()
        CType(pokemon2Level_nbr, ComponentModel.ISupportInitialize).BeginInit()
        CType(pokemon2Form_nbr, ComponentModel.ISupportInitialize).BeginInit()
        CType(pokemon2Happiness_nbr, ComponentModel.ISupportInitialize).BeginInit()
        pokemon2Shadow_grp.SuspendLayout()
        pokemon2EVs_grp.SuspendLayout()
        pokemon2IVs_grp.SuspendLayout()
        pokemon2Moves_grp.SuspendLayout()
        pokemon2Shiny_grp.SuspendLayout()
        pg_pkmn3.SuspendLayout()
        pokemon3_grp.SuspendLayout()
        CType(pokemon3Level_nbr, ComponentModel.ISupportInitialize).BeginInit()
        CType(pokemon3Form_nbr, ComponentModel.ISupportInitialize).BeginInit()
        CType(pokemon3Happiness_nbr, ComponentModel.ISupportInitialize).BeginInit()
        pokemon3Shadow_grp.SuspendLayout()
        pokemon3EVs_grp.SuspendLayout()
        pokemon3IVs_grp.SuspendLayout()
        pokemon3Moves_grp.SuspendLayout()
        pokemon3Shiny_grp.SuspendLayout()
        pg_pkmn4.SuspendLayout()
        pokemon4_grp.SuspendLayout()
        CType(pokemon4Level_nbr, ComponentModel.ISupportInitialize).BeginInit()
        CType(pokemon4Form_nbr, ComponentModel.ISupportInitialize).BeginInit()
        CType(pokemon4Happiness_nbr, ComponentModel.ISupportInitialize).BeginInit()
        pokemon4Shadow_grp.SuspendLayout()
        pokemon4EVs_grp.SuspendLayout()
        pokemon4IVs_grp.SuspendLayout()
        pokemon4Moves_grp.SuspendLayout()
        pokemon4Shiny_grp.SuspendLayout()
        pg_pkmn5.SuspendLayout()
        pokemon5_grp.SuspendLayout()
        CType(pokemon5Level_nbr, ComponentModel.ISupportInitialize).BeginInit()
        CType(pokemon5Form_nbr, ComponentModel.ISupportInitialize).BeginInit()
        CType(pokemon5Happiness_nbr, ComponentModel.ISupportInitialize).BeginInit()
        pokemon5Shadow_grp.SuspendLayout()
        pokemon5EVs_grp.SuspendLayout()
        pokemon5IVs_grp.SuspendLayout()
        pokemon5Moves_grp.SuspendLayout()
        pokemon5Shiny_grp.SuspendLayout()
        pg_pkmn6.SuspendLayout()
        pokemon6_grp.SuspendLayout()
        CType(pokemon6Level_nbr, ComponentModel.ISupportInitialize).BeginInit()
        CType(pokemon6Form_nbr, ComponentModel.ISupportInitialize).BeginInit()
        CType(pokemon6Happiness_nbr, ComponentModel.ISupportInitialize).BeginInit()
        pokemon6Shadow_grp.SuspendLayout()
        pokemon6EVs_grp.SuspendLayout()
        pokemon6IVs_grp.SuspendLayout()
        pokemon6Moves_grp.SuspendLayout()
        pokemon6Shiny_grp.SuspendLayout()
        pg_about.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' editor_grp
        ' 
        editor_grp.Controls.Add(editor_tab)
        editor_grp.Location = New Point(12, 27)
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
        editor_tab.Controls.Add(pg_about)
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
        pg_basic.Controls.Add(battleTeamID_nbr)
        pg_basic.Controls.Add(Label2)
        pg_basic.Controls.Add(properSpellingNote_lbl)
        pg_basic.Controls.Add(essData_lbl)
        pg_basic.Controls.Add(allowSuperShiny_chk)
        pg_basic.Controls.Add(loseTextQuotes_chkBox)
        pg_basic.Controls.Add(useAbilityIndex_chkBox)
        pg_basic.Controls.Add(existingBattle_chkBox)
        pg_basic.Controls.Add(customBallIDs_chkBox)
        pg_basic.Controls.Add(essVersion_cmb)
        pg_basic.Controls.Add(essVersion_lbl)
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
        ' battleTeamID_nbr
        ' 
        battleTeamID_nbr.Enabled = False
        battleTeamID_nbr.Location = New Point(8, 94)
        battleTeamID_nbr.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        battleTeamID_nbr.Name = "battleTeamID_nbr"
        battleTeamID_nbr.Size = New Size(168, 23)
        battleTeamID_nbr.TabIndex = 32
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(3, 443)
        Label2.Name = "Label2"
        Label2.Size = New Size(723, 32)
        Label2.TabIndex = 31
        Label2.Text = "Moves and Items MUST be one word. (ie: Fire Blast = FireBlast). Leave IVs and EVs 0 if you don't want to set them, or don't know how to use them."
        ' 
        ' properSpellingNote_lbl
        ' 
        properSpellingNote_lbl.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        properSpellingNote_lbl.AutoSize = True
        properSpellingNote_lbl.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        properSpellingNote_lbl.ForeColor = Color.Red
        properSpellingNote_lbl.Location = New Point(3, 428)
        properSpellingNote_lbl.Name = "properSpellingNote_lbl"
        properSpellingNote_lbl.Size = New Size(192, 15)
        properSpellingNote_lbl.TabIndex = 30
        properSpellingNote_lbl.Text = "Note: Proper spelling IS required."
        ' 
        ' essData_lbl
        ' 
        essData_lbl.AutoSize = True
        essData_lbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        essData_lbl.Location = New Point(3, 132)
        essData_lbl.Name = "essData_lbl"
        essData_lbl.Size = New Size(184, 32)
        essData_lbl.TabIndex = 29
        essData_lbl.Text = "Essentials Data"
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
        useAbilityIndex_chkBox.Enabled = False
        useAbilityIndex_chkBox.Location = New Point(493, 213)
        useAbilityIndex_chkBox.Name = "useAbilityIndex_chkBox"
        useAbilityIndex_chkBox.Size = New Size(203, 34)
        useAbilityIndex_chkBox.TabIndex = 26
        useAbilityIndex_chkBox.Text = "Use AbilityIndex instead of Ability" & vbCrLf & "(Essentials 19+)"
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
        essVersion_lbl.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        essVersion_lbl.Location = New Point(8, 164)
        essVersion_lbl.Name = "essVersion_lbl"
        essVersion_lbl.Size = New Size(118, 17)
        essVersion_lbl.TabIndex = 22
        essVersion_lbl.Text = "Essentials Version"
        ' 
        ' battleTeamID_lbl
        ' 
        battleTeamID_lbl.AutoSize = True
        battleTeamID_lbl.Enabled = False
        battleTeamID_lbl.Location = New Point(8, 76)
        battleTeamID_lbl.Name = "battleTeamID_lbl"
        battleTeamID_lbl.Size = New Size(82, 15)
        battleTeamID_lbl.TabIndex = 20
        battleTeamID_lbl.Text = "Battle Team ID"
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
        trainerType_lbl.Font = New Font("Segoe UI", 8.25F)
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
        trainerInfoHeader_lbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        trainerInfoHeader_lbl.Location = New Point(3, 0)
        trainerInfoHeader_lbl.Name = "trainerInfoHeader_lbl"
        trainerInfoHeader_lbl.Size = New Size(239, 32)
        trainerInfoHeader_lbl.TabIndex = 0
        trainerInfoHeader_lbl.Text = "Trainer Information"
        ' 
        ' pg_items
        ' 
        pg_items.Controls.Add(itemAddMaxElixir_btn)
        pg_items.Controls.Add(itemAddElixir_btn)
        pg_items.Controls.Add(itemAddMaxEther_btn)
        pg_items.Controls.Add(itemAddEther_btn)
        pg_items.Controls.Add(itemAddFullRestore_btn)
        pg_items.Controls.Add(itemAddHyperPotion_btn)
        pg_items.Controls.Add(itemAddMaxPotion_btn)
        pg_items.Controls.Add(itemAddSuperPotion_btn)
        pg_items.Controls.Add(itemAddPotion_btn)
        pg_items.Controls.Add(removeItem_btn)
        pg_items.Controls.Add(addItem_btn)
        pg_items.Controls.Add(trainerItemsInfo_lbl)
        pg_items.Controls.Add(trainerItemsHeader_lbl)
        pg_items.Controls.Add(items_grp)
        pg_items.Location = New Point(4, 24)
        pg_items.Name = "pg_items"
        pg_items.Padding = New Padding(3)
        pg_items.Size = New Size(729, 475)
        pg_items.TabIndex = 1
        pg_items.Text = "Items"
        pg_items.UseVisualStyleBackColor = True
        ' 
        ' itemAddMaxElixir_btn
        ' 
        itemAddMaxElixir_btn.Location = New Point(500, 198)
        itemAddMaxElixir_btn.Name = "itemAddMaxElixir_btn"
        itemAddMaxElixir_btn.Size = New Size(75, 47)
        itemAddMaxElixir_btn.TabIndex = 13
        itemAddMaxElixir_btn.Text = "Add Max Elixir"
        itemAddMaxElixir_btn.UseVisualStyleBackColor = True
        ' 
        ' itemAddElixir_btn
        ' 
        itemAddElixir_btn.Location = New Point(257, 198)
        itemAddElixir_btn.Name = "itemAddElixir_btn"
        itemAddElixir_btn.Size = New Size(75, 47)
        itemAddElixir_btn.TabIndex = 12
        itemAddElixir_btn.Text = "Add Elixir"
        itemAddElixir_btn.UseVisualStyleBackColor = True
        ' 
        ' itemAddMaxEther_btn
        ' 
        itemAddMaxEther_btn.Location = New Point(500, 145)
        itemAddMaxEther_btn.Name = "itemAddMaxEther_btn"
        itemAddMaxEther_btn.Size = New Size(75, 47)
        itemAddMaxEther_btn.TabIndex = 11
        itemAddMaxEther_btn.Text = "Add Max Ether"
        itemAddMaxEther_btn.UseVisualStyleBackColor = True
        ' 
        ' itemAddEther_btn
        ' 
        itemAddEther_btn.Location = New Point(257, 145)
        itemAddEther_btn.Name = "itemAddEther_btn"
        itemAddEther_btn.Size = New Size(75, 47)
        itemAddEther_btn.TabIndex = 10
        itemAddEther_btn.Text = "Add Ether"
        itemAddEther_btn.UseVisualStyleBackColor = True
        ' 
        ' itemAddFullRestore_btn
        ' 
        itemAddFullRestore_btn.Location = New Point(581, 92)
        itemAddFullRestore_btn.Name = "itemAddFullRestore_btn"
        itemAddFullRestore_btn.Size = New Size(75, 47)
        itemAddFullRestore_btn.TabIndex = 9
        itemAddFullRestore_btn.Text = "Add Full Restore"
        itemAddFullRestore_btn.UseVisualStyleBackColor = True
        ' 
        ' itemAddHyperPotion_btn
        ' 
        itemAddHyperPotion_btn.Location = New Point(419, 92)
        itemAddHyperPotion_btn.Name = "itemAddHyperPotion_btn"
        itemAddHyperPotion_btn.Size = New Size(75, 47)
        itemAddHyperPotion_btn.TabIndex = 8
        itemAddHyperPotion_btn.Text = "Add Hyper Potion"
        itemAddHyperPotion_btn.UseVisualStyleBackColor = True
        ' 
        ' itemAddMaxPotion_btn
        ' 
        itemAddMaxPotion_btn.Location = New Point(500, 92)
        itemAddMaxPotion_btn.Name = "itemAddMaxPotion_btn"
        itemAddMaxPotion_btn.Size = New Size(75, 47)
        itemAddMaxPotion_btn.TabIndex = 7
        itemAddMaxPotion_btn.Text = "Add Max Potion"
        itemAddMaxPotion_btn.UseVisualStyleBackColor = True
        ' 
        ' itemAddSuperPotion_btn
        ' 
        itemAddSuperPotion_btn.Location = New Point(338, 92)
        itemAddSuperPotion_btn.Name = "itemAddSuperPotion_btn"
        itemAddSuperPotion_btn.Size = New Size(75, 47)
        itemAddSuperPotion_btn.TabIndex = 6
        itemAddSuperPotion_btn.Text = "Add Super Potion"
        itemAddSuperPotion_btn.UseVisualStyleBackColor = True
        ' 
        ' itemAddPotion_btn
        ' 
        itemAddPotion_btn.Location = New Point(257, 92)
        itemAddPotion_btn.Name = "itemAddPotion_btn"
        itemAddPotion_btn.Size = New Size(75, 47)
        itemAddPotion_btn.TabIndex = 5
        itemAddPotion_btn.Text = "Add Potion"
        itemAddPotion_btn.UseVisualStyleBackColor = True
        ' 
        ' removeItem_btn
        ' 
        removeItem_btn.Location = New Point(3, 302)
        removeItem_btn.Name = "removeItem_btn"
        removeItem_btn.Size = New Size(248, 23)
        removeItem_btn.TabIndex = 4
        removeItem_btn.Text = "Remove Item"
        removeItem_btn.UseVisualStyleBackColor = True
        ' 
        ' addItem_btn
        ' 
        addItem_btn.Location = New Point(3, 273)
        addItem_btn.Name = "addItem_btn"
        addItem_btn.Size = New Size(248, 23)
        addItem_btn.TabIndex = 3
        addItem_btn.Text = "Add Item"
        addItem_btn.UseVisualStyleBackColor = True
        ' 
        ' trainerItemsInfo_lbl
        ' 
        trainerItemsInfo_lbl.Location = New Point(257, 38)
        trainerItemsInfo_lbl.Name = "trainerItemsInfo_lbl"
        trainerItemsInfo_lbl.Size = New Size(466, 51)
        trainerItemsInfo_lbl.TabIndex = 2
        trainerItemsInfo_lbl.Text = resources.GetString("trainerItemsInfo_lbl.Text")
        ' 
        ' trainerItemsHeader_lbl
        ' 
        trainerItemsHeader_lbl.AutoSize = True
        trainerItemsHeader_lbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        trainerItemsHeader_lbl.Location = New Point(257, 6)
        trainerItemsHeader_lbl.Name = "trainerItemsHeader_lbl"
        trainerItemsHeader_lbl.Size = New Size(164, 32)
        trainerItemsHeader_lbl.TabIndex = 1
        trainerItemsHeader_lbl.Text = "Trainer Items"
        ' 
        ' items_grp
        ' 
        items_grp.Controls.Add(items_lst)
        items_grp.Location = New Point(6, 6)
        items_grp.Name = "items_grp"
        items_grp.Size = New Size(245, 261)
        items_grp.TabIndex = 0
        items_grp.TabStop = False
        items_grp.Text = "Items"
        ' 
        ' items_lst
        ' 
        items_lst.Dock = DockStyle.Fill
        items_lst.FormattingEnabled = True
        items_lst.ItemHeight = 15
        items_lst.Location = New Point(3, 19)
        items_lst.Name = "items_lst"
        items_lst.Size = New Size(239, 239)
        items_lst.TabIndex = 0
        ' 
        ' pg_pokemon
        ' 
        pg_pokemon.Controls.Add(pkmnTabs_tab)
        pg_pokemon.Location = New Point(4, 24)
        pg_pokemon.Name = "pg_pokemon"
        pg_pokemon.Padding = New Padding(3)
        pg_pokemon.Size = New Size(743, 509)
        pg_pokemon.TabIndex = 1
        pg_pokemon.Text = "Pokémon"
        pg_pokemon.UseVisualStyleBackColor = True
        ' 
        ' pkmnTabs_tab
        ' 
        pkmnTabs_tab.Controls.Add(pg_pkmn1)
        pkmnTabs_tab.Controls.Add(pg_pkmn2)
        pkmnTabs_tab.Controls.Add(pg_pkmn3)
        pkmnTabs_tab.Controls.Add(pg_pkmn4)
        pkmnTabs_tab.Controls.Add(pg_pkmn5)
        pkmnTabs_tab.Controls.Add(pg_pkmn6)
        pkmnTabs_tab.Dock = DockStyle.Fill
        pkmnTabs_tab.Location = New Point(3, 3)
        pkmnTabs_tab.Multiline = True
        pkmnTabs_tab.Name = "pkmnTabs_tab"
        pkmnTabs_tab.SelectedIndex = 0
        pkmnTabs_tab.Size = New Size(737, 503)
        pkmnTabs_tab.TabIndex = 0
        ' 
        ' pg_pkmn1
        ' 
        pg_pkmn1.Controls.Add(pokemon1_grp)
        pg_pkmn1.Location = New Point(4, 24)
        pg_pkmn1.Name = "pg_pkmn1"
        pg_pkmn1.Padding = New Padding(3)
        pg_pkmn1.Size = New Size(729, 475)
        pg_pkmn1.TabIndex = 2
        pg_pkmn1.Text = "Pokémon 1"
        pg_pkmn1.UseVisualStyleBackColor = True
        ' 
        ' pokemon1_grp
        ' 
        pokemon1_grp.Controls.Add(pokemon1Level_nbr)
        pokemon1_grp.Controls.Add(pokemon1Form_nbr)
        pokemon1_grp.Controls.Add(pokemon1Happiness_nbr)
        pokemon1_grp.Controls.Add(pokemon1Shadow_grp)
        pokemon1_grp.Controls.Add(pokemon1EVs_grp)
        pokemon1_grp.Controls.Add(pokemon1IVs_grp)
        pokemon1_grp.Controls.Add(pokemon1PokeballID_cmb)
        pokemon1_grp.Controls.Add(pokemon1Ball_lbl)
        pokemon1_grp.Controls.Add(pokemon1Nickname_txtBox)
        pokemon1_grp.Controls.Add(pokemon1Nickname_lbl)
        pokemon1_grp.Controls.Add(pokemon1Happiness_lbl)
        pokemon1_grp.Controls.Add(pokemon1Nature_cmb)
        pokemon1_grp.Controls.Add(pokemon1Nature_lbl)
        pokemon1_grp.Controls.Add(pokemon1Shiny_grp)
        pokemon1_grp.Controls.Add(pokemon1Form_lbl)
        pokemon1_grp.Controls.Add(pokemon1Gender_cmb)
        pokemon1_grp.Controls.Add(pokemon1Gender_lbl)
        pokemon1_grp.Controls.Add(pokemon1Ability_cmb)
        pokemon1_grp.Controls.Add(pokemon1Ability_lbl)
        pokemon1_grp.Controls.Add(pokemon1Moves_grp)
        pokemon1_grp.Controls.Add(pokemon1Level_lbl)
        pokemon1_grp.Controls.Add(pokemon1HeldItem_lbl)
        pokemon1_grp.Controls.Add(pokemon1HeldItem_txtBox)
        pokemon1_grp.Controls.Add(pokemon1Name_txtBox)
        pokemon1_grp.Controls.Add(pokemon1Name_lbl)
        pokemon1_grp.Dock = DockStyle.Fill
        pokemon1_grp.Location = New Point(3, 3)
        pokemon1_grp.Name = "pokemon1_grp"
        pokemon1_grp.Size = New Size(723, 469)
        pokemon1_grp.TabIndex = 0
        pokemon1_grp.TabStop = False
        pokemon1_grp.Text = "Pokémon 1"
        ' 
        ' pokemon1Level_nbr
        ' 
        pokemon1Level_nbr.Location = New Point(298, 37)
        pokemon1Level_nbr.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        pokemon1Level_nbr.Name = "pokemon1Level_nbr"
        pokemon1Level_nbr.Size = New Size(140, 23)
        pokemon1Level_nbr.TabIndex = 33
        pokemon1Level_nbr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' pokemon1Form_nbr
        ' 
        pokemon1Form_nbr.Location = New Point(298, 80)
        pokemon1Form_nbr.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        pokemon1Form_nbr.Name = "pokemon1Form_nbr"
        pokemon1Form_nbr.Size = New Size(140, 23)
        pokemon1Form_nbr.TabIndex = 32
        ' 
        ' pokemon1Happiness_nbr
        ' 
        pokemon1Happiness_nbr.Location = New Point(152, 124)
        pokemon1Happiness_nbr.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        pokemon1Happiness_nbr.Name = "pokemon1Happiness_nbr"
        pokemon1Happiness_nbr.Size = New Size(140, 23)
        pokemon1Happiness_nbr.TabIndex = 31
        pokemon1Happiness_nbr.Value = New Decimal(New Integer() {70, 0, 0, 0})
        ' 
        ' pokemon1Shadow_grp
        ' 
        pokemon1Shadow_grp.Controls.Add(pokemon1Shadow_rad)
        pokemon1Shadow_grp.Controls.Add(pokemon1NotShadow_rad)
        pokemon1Shadow_grp.Location = New Point(444, 198)
        pokemon1Shadow_grp.Name = "pokemon1Shadow_grp"
        pokemon1Shadow_grp.Size = New Size(273, 82)
        pokemon1Shadow_grp.TabIndex = 30
        pokemon1Shadow_grp.TabStop = False
        pokemon1Shadow_grp.Text = "Shadow"
        ' 
        ' pokemon1Shadow_rad
        ' 
        pokemon1Shadow_rad.AutoSize = True
        pokemon1Shadow_rad.Location = New Point(6, 47)
        pokemon1Shadow_rad.Name = "pokemon1Shadow_rad"
        pokemon1Shadow_rad.Size = New Size(67, 19)
        pokemon1Shadow_rad.TabIndex = 1
        pokemon1Shadow_rad.Text = "Shadow"
        pokemon1Shadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon1NotShadow_rad
        ' 
        pokemon1NotShadow_rad.AutoSize = True
        pokemon1NotShadow_rad.Checked = True
        pokemon1NotShadow_rad.Location = New Point(6, 22)
        pokemon1NotShadow_rad.Name = "pokemon1NotShadow_rad"
        pokemon1NotShadow_rad.Size = New Size(90, 19)
        pokemon1NotShadow_rad.TabIndex = 0
        pokemon1NotShadow_rad.TabStop = True
        pokemon1NotShadow_rad.Text = "Not Shadow"
        pokemon1NotShadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon1EVs_grp
        ' 
        pokemon1EVs_grp.Controls.Add(pokemon1EVsDEF_txt)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsDEF_lbl)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsSPDEF_txt)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsSPDEF_lbl)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsSPATK_txt)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsSPATK_lbl)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsSPD_txt)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsSPD_lbl)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsATK_txt)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsATK_lbl)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsHP_txt)
        pokemon1EVs_grp.Controls.Add(pokemon1EVsHP_lbl)
        pokemon1EVs_grp.Location = New Point(324, 154)
        pokemon1EVs_grp.Name = "pokemon1EVs_grp"
        pokemon1EVs_grp.Size = New Size(114, 156)
        pokemon1EVs_grp.TabIndex = 29
        pokemon1EVs_grp.TabStop = False
        pokemon1EVs_grp.Text = "EVs"
        ' 
        ' pokemon1EVsDEF_txt
        ' 
        pokemon1EVsDEF_txt.Location = New Point(6, 125)
        pokemon1EVsDEF_txt.MaxLength = 3
        pokemon1EVsDEF_txt.Name = "pokemon1EVsDEF_txt"
        pokemon1EVsDEF_txt.Size = New Size(44, 23)
        pokemon1EVsDEF_txt.TabIndex = 11
        pokemon1EVsDEF_txt.Text = "0"
        ' 
        ' pokemon1EVsDEF_lbl
        ' 
        pokemon1EVsDEF_lbl.AutoSize = True
        pokemon1EVsDEF_lbl.Location = New Point(14, 107)
        pokemon1EVsDEF_lbl.Name = "pokemon1EVsDEF_lbl"
        pokemon1EVsDEF_lbl.Size = New Size(27, 15)
        pokemon1EVsDEF_lbl.TabIndex = 10
        pokemon1EVsDEF_lbl.Text = "DEF"
        ' 
        ' pokemon1EVsSPDEF_txt
        ' 
        pokemon1EVsSPDEF_txt.Location = New Point(55, 125)
        pokemon1EVsSPDEF_txt.MaxLength = 3
        pokemon1EVsSPDEF_txt.Name = "pokemon1EVsSPDEF_txt"
        pokemon1EVsSPDEF_txt.Size = New Size(44, 23)
        pokemon1EVsSPDEF_txt.TabIndex = 9
        pokemon1EVsSPDEF_txt.Text = "0"
        ' 
        ' pokemon1EVsSPDEF_lbl
        ' 
        pokemon1EVsSPDEF_lbl.AutoSize = True
        pokemon1EVsSPDEF_lbl.Location = New Point(55, 109)
        pokemon1EVsSPDEF_lbl.Name = "pokemon1EVsSPDEF_lbl"
        pokemon1EVsSPDEF_lbl.Size = New Size(40, 15)
        pokemon1EVsSPDEF_lbl.TabIndex = 8
        pokemon1EVsSPDEF_lbl.Text = "SPDEF"
        ' 
        ' pokemon1EVsSPATK_txt
        ' 
        pokemon1EVsSPATK_txt.Location = New Point(55, 81)
        pokemon1EVsSPATK_txt.MaxLength = 3
        pokemon1EVsSPATK_txt.Name = "pokemon1EVsSPATK_txt"
        pokemon1EVsSPATK_txt.Size = New Size(44, 23)
        pokemon1EVsSPATK_txt.TabIndex = 7
        pokemon1EVsSPATK_txt.Text = "0"
        ' 
        ' pokemon1EVsSPATK_lbl
        ' 
        pokemon1EVsSPATK_lbl.AutoSize = True
        pokemon1EVsSPATK_lbl.Location = New Point(56, 65)
        pokemon1EVsSPATK_lbl.Name = "pokemon1EVsSPATK_lbl"
        pokemon1EVsSPATK_lbl.Size = New Size(39, 15)
        pokemon1EVsSPATK_lbl.TabIndex = 6
        pokemon1EVsSPATK_lbl.Text = "SPATK"
        ' 
        ' pokemon1EVsSPD_txt
        ' 
        pokemon1EVsSPD_txt.Location = New Point(55, 37)
        pokemon1EVsSPD_txt.MaxLength = 3
        pokemon1EVsSPD_txt.Name = "pokemon1EVsSPD_txt"
        pokemon1EVsSPD_txt.Size = New Size(44, 23)
        pokemon1EVsSPD_txt.TabIndex = 5
        pokemon1EVsSPD_txt.Text = "0"
        ' 
        ' pokemon1EVsSPD_lbl
        ' 
        pokemon1EVsSPD_lbl.AutoSize = True
        pokemon1EVsSPD_lbl.Location = New Point(63, 21)
        pokemon1EVsSPD_lbl.Name = "pokemon1EVsSPD_lbl"
        pokemon1EVsSPD_lbl.Size = New Size(28, 15)
        pokemon1EVsSPD_lbl.TabIndex = 4
        pokemon1EVsSPD_lbl.Text = "SPD"
        ' 
        ' pokemon1EVsATK_txt
        ' 
        pokemon1EVsATK_txt.Location = New Point(6, 81)
        pokemon1EVsATK_txt.MaxLength = 3
        pokemon1EVsATK_txt.Name = "pokemon1EVsATK_txt"
        pokemon1EVsATK_txt.Size = New Size(44, 23)
        pokemon1EVsATK_txt.TabIndex = 3
        pokemon1EVsATK_txt.Text = "0"
        ' 
        ' pokemon1EVsATK_lbl
        ' 
        pokemon1EVsATK_lbl.AutoSize = True
        pokemon1EVsATK_lbl.Location = New Point(14, 63)
        pokemon1EVsATK_lbl.Name = "pokemon1EVsATK_lbl"
        pokemon1EVsATK_lbl.Size = New Size(27, 15)
        pokemon1EVsATK_lbl.TabIndex = 2
        pokemon1EVsATK_lbl.Text = "ATK"
        ' 
        ' pokemon1EVsHP_txt
        ' 
        pokemon1EVsHP_txt.Location = New Point(6, 37)
        pokemon1EVsHP_txt.MaxLength = 3
        pokemon1EVsHP_txt.Name = "pokemon1EVsHP_txt"
        pokemon1EVsHP_txt.Size = New Size(44, 23)
        pokemon1EVsHP_txt.TabIndex = 1
        pokemon1EVsHP_txt.Text = "0"
        ' 
        ' pokemon1EVsHP_lbl
        ' 
        pokemon1EVsHP_lbl.AutoSize = True
        pokemon1EVsHP_lbl.Location = New Point(16, 19)
        pokemon1EVsHP_lbl.Name = "pokemon1EVsHP_lbl"
        pokemon1EVsHP_lbl.Size = New Size(23, 15)
        pokemon1EVsHP_lbl.TabIndex = 0
        pokemon1EVsHP_lbl.Text = "HP"
        ' 
        ' pokemon1IVs_grp
        ' 
        pokemon1IVs_grp.Controls.Add(pokemon1RandomIVs_btn)
        pokemon1IVs_grp.Controls.Add(pokemon1MaxIVs_btn)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsDEF_txt)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsDEF_lbl)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsSPDEF_txt)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsSPDEF_lbl)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsSPATK_txt)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsSPATK_lbl)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsSPD_txt)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsSPD_lbl)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsATK_txt)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsATK_lbl)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsHP_txt)
        pokemon1IVs_grp.Controls.Add(pokemon1IVsHP_lbl)
        pokemon1IVs_grp.Location = New Point(204, 154)
        pokemon1IVs_grp.Name = "pokemon1IVs_grp"
        pokemon1IVs_grp.Size = New Size(114, 188)
        pokemon1IVs_grp.TabIndex = 28
        pokemon1IVs_grp.TabStop = False
        pokemon1IVs_grp.Text = "IVs (Max 31 Each)"
        ' 
        ' pokemon1RandomIVs_btn
        ' 
        pokemon1RandomIVs_btn.Location = New Point(57, 152)
        pokemon1RandomIVs_btn.Name = "pokemon1RandomIVs_btn"
        pokemon1RandomIVs_btn.Size = New Size(44, 23)
        pokemon1RandomIVs_btn.TabIndex = 15
        pokemon1RandomIVs_btn.Text = "Rand"
        pokemon1RandomIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon1MaxIVs_btn
        ' 
        pokemon1MaxIVs_btn.Location = New Point(7, 152)
        pokemon1MaxIVs_btn.Name = "pokemon1MaxIVs_btn"
        pokemon1MaxIVs_btn.Size = New Size(44, 23)
        pokemon1MaxIVs_btn.TabIndex = 14
        pokemon1MaxIVs_btn.Text = "Max"
        pokemon1MaxIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon1IVsDEF_txt
        ' 
        pokemon1IVsDEF_txt.Location = New Point(7, 123)
        pokemon1IVsDEF_txt.MaxLength = 3
        pokemon1IVsDEF_txt.Name = "pokemon1IVsDEF_txt"
        pokemon1IVsDEF_txt.Size = New Size(44, 23)
        pokemon1IVsDEF_txt.TabIndex = 13
        pokemon1IVsDEF_txt.Text = "0"
        ' 
        ' pokemon1IVsDEF_lbl
        ' 
        pokemon1IVsDEF_lbl.AutoSize = True
        pokemon1IVsDEF_lbl.Location = New Point(18, 105)
        pokemon1IVsDEF_lbl.Name = "pokemon1IVsDEF_lbl"
        pokemon1IVsDEF_lbl.Size = New Size(27, 15)
        pokemon1IVsDEF_lbl.TabIndex = 12
        pokemon1IVsDEF_lbl.Text = "DEF"
        ' 
        ' pokemon1IVsSPDEF_txt
        ' 
        pokemon1IVsSPDEF_txt.Location = New Point(57, 123)
        pokemon1IVsSPDEF_txt.MaxLength = 3
        pokemon1IVsSPDEF_txt.Name = "pokemon1IVsSPDEF_txt"
        pokemon1IVsSPDEF_txt.Size = New Size(44, 23)
        pokemon1IVsSPDEF_txt.TabIndex = 9
        pokemon1IVsSPDEF_txt.Text = "0"
        ' 
        ' pokemon1IVsSPDEF_lbl
        ' 
        pokemon1IVsSPDEF_lbl.AutoSize = True
        pokemon1IVsSPDEF_lbl.Location = New Point(59, 105)
        pokemon1IVsSPDEF_lbl.Name = "pokemon1IVsSPDEF_lbl"
        pokemon1IVsSPDEF_lbl.Size = New Size(40, 15)
        pokemon1IVsSPDEF_lbl.TabIndex = 8
        pokemon1IVsSPDEF_lbl.Text = "SPDEF"
        ' 
        ' pokemon1IVsSPATK_txt
        ' 
        pokemon1IVsSPATK_txt.Location = New Point(57, 79)
        pokemon1IVsSPATK_txt.MaxLength = 3
        pokemon1IVsSPATK_txt.Name = "pokemon1IVsSPATK_txt"
        pokemon1IVsSPATK_txt.Size = New Size(44, 23)
        pokemon1IVsSPATK_txt.TabIndex = 7
        pokemon1IVsSPATK_txt.Text = "0"
        ' 
        ' pokemon1IVsSPATK_lbl
        ' 
        pokemon1IVsSPATK_lbl.AutoSize = True
        pokemon1IVsSPATK_lbl.Location = New Point(59, 61)
        pokemon1IVsSPATK_lbl.Name = "pokemon1IVsSPATK_lbl"
        pokemon1IVsSPATK_lbl.Size = New Size(39, 15)
        pokemon1IVsSPATK_lbl.TabIndex = 6
        pokemon1IVsSPATK_lbl.Text = "SPATK"
        ' 
        ' pokemon1IVsSPD_txt
        ' 
        pokemon1IVsSPD_txt.Location = New Point(57, 35)
        pokemon1IVsSPD_txt.MaxLength = 3
        pokemon1IVsSPD_txt.Name = "pokemon1IVsSPD_txt"
        pokemon1IVsSPD_txt.Size = New Size(44, 23)
        pokemon1IVsSPD_txt.TabIndex = 5
        pokemon1IVsSPD_txt.Text = "0"
        ' 
        ' pokemon1IVsSPD_lbl
        ' 
        pokemon1IVsSPD_lbl.AutoSize = True
        pokemon1IVsSPD_lbl.Location = New Point(65, 17)
        pokemon1IVsSPD_lbl.Name = "pokemon1IVsSPD_lbl"
        pokemon1IVsSPD_lbl.Size = New Size(28, 15)
        pokemon1IVsSPD_lbl.TabIndex = 4
        pokemon1IVsSPD_lbl.Text = "SPD"
        ' 
        ' pokemon1IVsATK_txt
        ' 
        pokemon1IVsATK_txt.Location = New Point(7, 79)
        pokemon1IVsATK_txt.MaxLength = 3
        pokemon1IVsATK_txt.Name = "pokemon1IVsATK_txt"
        pokemon1IVsATK_txt.Size = New Size(44, 23)
        pokemon1IVsATK_txt.TabIndex = 3
        pokemon1IVsATK_txt.Text = "0"
        ' 
        ' pokemon1IVsATK_lbl
        ' 
        pokemon1IVsATK_lbl.AutoSize = True
        pokemon1IVsATK_lbl.Location = New Point(18, 61)
        pokemon1IVsATK_lbl.Name = "pokemon1IVsATK_lbl"
        pokemon1IVsATK_lbl.Size = New Size(27, 15)
        pokemon1IVsATK_lbl.TabIndex = 2
        pokemon1IVsATK_lbl.Text = "ATK"
        ' 
        ' pokemon1IVsHP_txt
        ' 
        pokemon1IVsHP_txt.Location = New Point(7, 35)
        pokemon1IVsHP_txt.MaxLength = 3
        pokemon1IVsHP_txt.Name = "pokemon1IVsHP_txt"
        pokemon1IVsHP_txt.Size = New Size(44, 23)
        pokemon1IVsHP_txt.TabIndex = 1
        pokemon1IVsHP_txt.Text = "0"
        ' 
        ' pokemon1IVsHP_lbl
        ' 
        pokemon1IVsHP_lbl.AutoSize = True
        pokemon1IVsHP_lbl.Location = New Point(18, 19)
        pokemon1IVsHP_lbl.Name = "pokemon1IVsHP_lbl"
        pokemon1IVsHP_lbl.Size = New Size(23, 15)
        pokemon1IVsHP_lbl.TabIndex = 0
        pokemon1IVsHP_lbl.Text = "HP"
        ' 
        ' pokemon1PokeballID_cmb
        ' 
        pokemon1PokeballID_cmb.FormattingEnabled = True
        pokemon1PokeballID_cmb.Items.AddRange(New Object() {"POKEBALL", "GREATBALL", "SAFARIBALL", "ULTRABALL", "MASTERBALL", "NETBALL", "DIVEBALL", "NESTBALL", "REPEATBALL", "TIMERBALL", "LUXURYBALL", "PREMIERBALL", "DUSKBALL", "HEALBALL", "QUICKBALL", "CHERISHBALL", "FASTBALL", "LEVELBALL", "LUREBALL", "HEAVYBALL", "LOVEBALL", "FRIENDBALL", "MOONBALL", "SPORTBALL", "DREAMBALL", "BEASTBALL"})
        pokemon1PokeballID_cmb.Location = New Point(6, 169)
        pokemon1PokeballID_cmb.Name = "pokemon1PokeballID_cmb"
        pokemon1PokeballID_cmb.Size = New Size(140, 23)
        pokemon1PokeballID_cmb.TabIndex = 21
        ' 
        ' pokemon1Ball_lbl
        ' 
        pokemon1Ball_lbl.AutoSize = True
        pokemon1Ball_lbl.Location = New Point(8, 151)
        pokemon1Ball_lbl.Name = "pokemon1Ball_lbl"
        pokemon1Ball_lbl.Size = New Size(52, 15)
        pokemon1Ball_lbl.TabIndex = 20
        pokemon1Ball_lbl.Text = "PokéBall"
        ' 
        ' pokemon1Nickname_txtBox
        ' 
        pokemon1Nickname_txtBox.Location = New Point(298, 125)
        pokemon1Nickname_txtBox.Name = "pokemon1Nickname_txtBox"
        pokemon1Nickname_txtBox.PlaceholderText = "Bloom"
        pokemon1Nickname_txtBox.Size = New Size(140, 23)
        pokemon1Nickname_txtBox.TabIndex = 19
        ' 
        ' pokemon1Nickname_lbl
        ' 
        pokemon1Nickname_lbl.AutoSize = True
        pokemon1Nickname_lbl.Location = New Point(298, 107)
        pokemon1Nickname_lbl.Name = "pokemon1Nickname_lbl"
        pokemon1Nickname_lbl.Size = New Size(61, 15)
        pokemon1Nickname_lbl.TabIndex = 18
        pokemon1Nickname_lbl.Text = "Nickname"
        ' 
        ' pokemon1Happiness_lbl
        ' 
        pokemon1Happiness_lbl.AutoSize = True
        pokemon1Happiness_lbl.Location = New Point(152, 107)
        pokemon1Happiness_lbl.Name = "pokemon1Happiness_lbl"
        pokemon1Happiness_lbl.Size = New Size(62, 15)
        pokemon1Happiness_lbl.TabIndex = 16
        pokemon1Happiness_lbl.Text = "Happiness"
        ' 
        ' pokemon1Nature_cmb
        ' 
        pokemon1Nature_cmb.FormattingEnabled = True
        pokemon1Nature_cmb.Items.AddRange(New Object() {"(random)", "HARDY", "LONELY", "BRAVE", "ADAMANT", "NAUGHTY", "BOLD", "DOCILE", "RELAXED", "IMPISH", "LAX", "MODEST", "MILD", "SERIOUS", "QUIET", "RASH", "CALM", "GENTLE", "SASSY", "BASHFUL", "CAREFUL", "TIMID", "HASTY", "JOLLY", "NAIVE", "QUIRKY"})
        pokemon1Nature_cmb.Location = New Point(6, 125)
        pokemon1Nature_cmb.Name = "pokemon1Nature_cmb"
        pokemon1Nature_cmb.Size = New Size(140, 23)
        pokemon1Nature_cmb.TabIndex = 15
        ' 
        ' pokemon1Nature_lbl
        ' 
        pokemon1Nature_lbl.AutoSize = True
        pokemon1Nature_lbl.Location = New Point(6, 107)
        pokemon1Nature_lbl.Name = "pokemon1Nature_lbl"
        pokemon1Nature_lbl.Size = New Size(43, 15)
        pokemon1Nature_lbl.TabIndex = 14
        pokemon1Nature_lbl.Text = "Nature"
        ' 
        ' pokemon1Shiny_grp
        ' 
        pokemon1Shiny_grp.Controls.Add(pokemon1SuperShiny_chkBox)
        pokemon1Shiny_grp.Controls.Add(pokemon1Shiny_rad)
        pokemon1Shiny_grp.Controls.Add(pokemon1NotShiny_rad)
        pokemon1Shiny_grp.Location = New Point(444, 110)
        pokemon1Shiny_grp.Name = "pokemon1Shiny_grp"
        pokemon1Shiny_grp.Size = New Size(273, 82)
        pokemon1Shiny_grp.TabIndex = 13
        pokemon1Shiny_grp.TabStop = False
        pokemon1Shiny_grp.Text = "Shiny"
        ' 
        ' pokemon1SuperShiny_chkBox
        ' 
        pokemon1SuperShiny_chkBox.AutoSize = True
        pokemon1SuperShiny_chkBox.Enabled = False
        pokemon1SuperShiny_chkBox.Location = New Point(66, 47)
        pokemon1SuperShiny_chkBox.Name = "pokemon1SuperShiny_chkBox"
        pokemon1SuperShiny_chkBox.Size = New Size(88, 19)
        pokemon1SuperShiny_chkBox.TabIndex = 2
        pokemon1SuperShiny_chkBox.Text = "Super Shiny"
        pokemon1SuperShiny_chkBox.UseVisualStyleBackColor = True
        ' 
        ' pokemon1Shiny_rad
        ' 
        pokemon1Shiny_rad.AutoSize = True
        pokemon1Shiny_rad.Location = New Point(6, 47)
        pokemon1Shiny_rad.Name = "pokemon1Shiny_rad"
        pokemon1Shiny_rad.Size = New Size(54, 19)
        pokemon1Shiny_rad.TabIndex = 1
        pokemon1Shiny_rad.Text = "Shiny"
        pokemon1Shiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon1NotShiny_rad
        ' 
        pokemon1NotShiny_rad.AutoSize = True
        pokemon1NotShiny_rad.Checked = True
        pokemon1NotShiny_rad.Location = New Point(6, 22)
        pokemon1NotShiny_rad.Name = "pokemon1NotShiny_rad"
        pokemon1NotShiny_rad.Size = New Size(77, 19)
        pokemon1NotShiny_rad.TabIndex = 0
        pokemon1NotShiny_rad.TabStop = True
        pokemon1NotShiny_rad.Text = "Not Shiny"
        pokemon1NotShiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon1Form_lbl
        ' 
        pokemon1Form_lbl.AutoSize = True
        pokemon1Form_lbl.Location = New Point(298, 63)
        pokemon1Form_lbl.Name = "pokemon1Form_lbl"
        pokemon1Form_lbl.Size = New Size(35, 15)
        pokemon1Form_lbl.TabIndex = 11
        pokemon1Form_lbl.Text = "Form"
        ' 
        ' pokemon1Gender_cmb
        ' 
        pokemon1Gender_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        pokemon1Gender_cmb.FormattingEnabled = True
        pokemon1Gender_cmb.Items.AddRange(New Object() {"Male", "Female", "Random"})
        pokemon1Gender_cmb.Location = New Point(152, 81)
        pokemon1Gender_cmb.Name = "pokemon1Gender_cmb"
        pokemon1Gender_cmb.Size = New Size(140, 23)
        pokemon1Gender_cmb.TabIndex = 10
        ' 
        ' pokemon1Gender_lbl
        ' 
        pokemon1Gender_lbl.AutoSize = True
        pokemon1Gender_lbl.Location = New Point(152, 63)
        pokemon1Gender_lbl.Name = "pokemon1Gender_lbl"
        pokemon1Gender_lbl.Size = New Size(45, 15)
        pokemon1Gender_lbl.TabIndex = 9
        pokemon1Gender_lbl.Text = "Gender"
        ' 
        ' pokemon1Ability_cmb
        ' 
        pokemon1Ability_cmb.AutoCompleteCustomSource.AddRange(New String() {"Aerilate", "Aftermath", "Air Lock", "Analytic", "Anger Point", "Anger Shell", "Anticipation", "Arena Trap", "Armor Tail", "Aroma Veil", "As One - Unnerve Chilling Neigh", "As One - Unnerve Grim Neigh", "Aura Break", "Bad Dreams", "Ball Fetch", "Battery", "Battle Armor", "Battle Bond", "Beads of Ruin", "Beast Boost", "Berserk", "Big Pecks", "Blaze", "Bulletproof", "Cheek Pouch", "Chilling Neigh", "Chlorophyll", "Clear Body", "Cloud Nine", "Color Change", "Comatose", "Commander", "Competitive", "Compoundeyes", "Contrary", "Corrosion", "Costar", "Cotton Down", "Cud Chew", "Curious Medicine", "Cursed Body", "Cute Charm", "Damp", "Dancer", "Dark Aura", "Dauntless Shield", "Dazzling", "Defeatist", "Defiant", "Delta Stream", "Desolate Land", "Disguise", "Download", "Dragon's Maw", "Drizzle", "Drought", "Dry Skin", "Early Bird", "Earth Eater", "Effect Spore", "Electric Surge", "Electromorphosis", "Embody Aspect - Cornerstone Mask", "Embody Aspect - Hearthflame Mask", "Embody Aspect - Teal Mask", "Embody Aspect - Wellspring Mask", "Emergency Exit", "Fairy Aura", "Filter", "Flame Body", "Flare Boost", "Flash Fire", "Flower Gift", "Flower Veil", "Fluffy", "Forecast", "Forewarn", "Friend Guard", "Frisk", "Full Metal Body", "Fur Coat", "Gale Wings", "Galvanize", "Gluttony", "Good as Gold", "Gooey", "Gorilla Tactics", "Grass Pelt", "Grassy Surge", "Grim Neigh", "Guard Dog", "Gulp Missile", "Guts", "Hadron Engine", "Harvest", "Healer", "Heatproof", "Heavy Metal", "Honey Gather", "Hospitality", "Huge Power", "Hunger Switch", "Hustle", "Hydration", "Hyper Cutter", "Ice Body", "Ice Face", "Ice Scales", "Illuminate", "Illusion", "Immunity", "Imposter", "Infiltrator", "Innards Out", "Inner Focus", "Insomnia", "Intimidate", "Intrepid Sword", "Iron Barbs", "Iron Fist", "Justified", "Keen Eye", "Klutz", "Leaf Guard", "Levitate", "Libero", "Light Metal", "Lightning Rod", "Limber", "Lingering Aroma", "Liquid Ooze", "Liquid Voice", "Long Reach", "Magic Bounce", "Magic Guard", "Magician", "Magma Armor", "Magnet Pull", "Marvel Scale", "Mega Launcher", "Merciless", "Mimicry", "Mind's Eye", "Minus", "Mirror Armor", "Misty Surge", "Mold Breaker", "Moody", "Motor Drive", "Moxie", "Multiscale", "Multitype", "Mummy", "Mycelium Might", "Natural Cure", "Neuroforce", "Neutralizing Gas", "No Guard", "Normalize", "Oblivious", "Opportunist", "Orichalcum Pulse", "Overcoat", "Overgrow", "Own Tempo", "Parental Bond", "Pastel Veil", "Perish Body", "Pickpocket", "Pickup", "Pixilate", "Plus", "Poison Heal", "Poison Point", "Poison Touch", "Power Construct", "Power of Alchemy", "Power Spot", "Prankster", "Pressure", "Primordial Sea", "Prism Armor", "Propeller Tail", "Protean", "Protosynthesis", "Psychic Surge", "Punk Rock", "Pure Power", "Purifying Salt", "Quark Drive", "Queenly Majesty", "Quick Draw", "Quick Feet", "Rain Dish", "Rattled", "Receiver", "Reckless", "Refrigerate", "Regenerator", "Ripen", "Rivalry", "RKS System", "Rock Head", "Rocky Payload", "Rough Skin", "Run Away", "Sand Force", "Sand Rush", "Sand Spit", "Sand Stream", "Sand Veil", "Sap Sipper", "Schooling", "Scrappy", "Screen Cleaner", "Seed Sower", "Serene Grace", "Shadow Shield", "Shadow Tag", "Sharpness", "Shed Skin", "Sheer Force", "Shell Armor", "Shield Dust", "Shields Down", "Simple", "Skill Link", "Slow Start", "Slush Rush", "Sniper", "Snow Cloak", "Snow Warning", "Solar Power", "Solid Rock", "Soul-Heart", "Soundproof", "Speed Boost", "Stakeout", "Stall", "Stalwart", "Stamina", "Stance Change", "Static", "Steadfast", "Steam Engine", "Steelworker", "Steely Spirit", "Stench", "Sticky Hold", "Storm Drain", "Strong Jaw", "Sturdy", "Suction Cups", "Super Luck", "Supersweet Syrup", "Supreme Overlord", "Surge Surfer", "Swarm", "Sweet Veil", "Swift Swim", "Sword of Ruin", "Symbiosis", "Synchronize", "Tablets of Ruin", "Tangled Feet", "Tangling Hair", "Technician", "Telepathy", "Teravolt", "Thermal Exchange", "Thick Fat", "Tinted Lens", "Torrent", "Tough Claws", "Toxic Boost", "Toxic Chain", "Toxic Debris", "Trace", "Transistor", "Triage", "Truant", "Turboblaze", "Unaware", "Unburden", "Unnerve", "Unseen Fist", "Vessel of Ruin", "Victory Star", "Vital Spirit", "Volt Absorb", "Wandering Spirit", "Water Absorb", "Water Bubble", "Water Compaction", "Water Veil", "Weak Armor", "Well-Baked Body", "White Smoke", "Wimp Out", "Wind Power", "Wind Rider", "Wonder Guard", "Wonder Skin ", "Zen Mode", "Zero to Hero"})
        pokemon1Ability_cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon1Ability_cmb.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon1Ability_cmb.FormattingEnabled = True
        pokemon1Ability_cmb.Items.AddRange(New Object() {"Aerilate", "Aftermath", "Air Lock", "Analytic", "Anger Point", "Anger Shell", "Anticipation", "Arena Trap", "Armor Tail", "Aroma Veil", "As One - Unnerve Chilling Neigh", "As One - Unnerve Grim Neigh", "Aura Break", "Bad Dreams", "Ball Fetch", "Battery", "Battle Armor", "Battle Bond", "Beads of Ruin", "Beast Boost", "Berserk", "Big Pecks", "Blaze", "Bulletproof", "Cheek Pouch", "Chilling Neigh", "Chlorophyll", "Clear Body", "Cloud Nine", "Color Change", "Comatose", "Commander", "Competitive", "Compoundeyes", "Contrary", "Corrosion", "Costar", "Cotton Down", "Cud Chew", "Curious Medicine", "Cursed Body", "Cute Charm", "Damp", "Dancer", "Dark Aura", "Dauntless Shield", "Dazzling", "Defeatist", "Defiant", "Delta Stream", "Desolate Land", "Disguise", "Download", "Dragon's Maw", "Drizzle", "Drought", "Dry Skin", "Early Bird", "Earth Eater", "Effect Spore", "Electric Surge", "Electromorphosis", "Embody Aspect - Cornerstone Mask", "Embody Aspect - Hearthflame Mask", "Embody Aspect - Teal Mask", "Embody Aspect - Wellspring Mask", "Emergency Exit", "Fairy Aura", "Filter", "Flame Body", "Flare Boost", "Flash Fire", "Flower Gift", "Flower Veil", "Fluffy", "Forecast", "Forewarn", "Friend Guard", "Frisk", "Full Metal Body", "Fur Coat", "Gale Wings", "Galvanize", "Gluttony", "Good as Gold", "Gooey", "Gorilla Tactics", "Grass Pelt", "Grassy Surge", "Grim Neigh", "Guard Dog", "Gulp Missile", "Guts", "Hadron Engine", "Harvest", "Healer", "Heatproof", "Heavy Metal", "Honey Gather", "Hospitality", "Huge Power", "Hunger Switch", "Hustle", "Hydration", "Hyper Cutter", "Ice Body", "Ice Face", "Ice Scales", "Illuminate", "Illusion", "Immunity", "Imposter", "Infiltrator", "Innards Out", "Inner Focus", "Insomnia", "Intimidate", "Intrepid Sword", "Iron Barbs", "Iron Fist", "Justified", "Keen Eye", "Klutz", "Leaf Guard", "Levitate", "Libero", "Light Metal", "Lightning Rod", "Limber", "Lingering Aroma", "Liquid Ooze", "Liquid Voice", "Long Reach", "Magic Bounce", "Magic Guard", "Magician", "Magma Armor", "Magnet Pull", "Marvel Scale", "Mega Launcher", "Merciless", "Mimicry", "Mind's Eye", "Minus", "Mirror Armor", "Misty Surge", "Mold Breaker", "Moody", "Motor Drive", "Moxie", "Multiscale", "Multitype", "Mummy", "Mycelium Might", "Natural Cure", "Neuroforce", "Neutralizing Gas", "No Guard", "Normalize", "Oblivious", "Opportunist", "Orichalcum Pulse", "Overcoat", "Overgrow", "Own Tempo", "Parental Bond", "Pastel Veil", "Perish Body", "Pickpocket", "Pickup", "Pixilate", "Plus", "Poison Heal", "Poison Point", "Poison Touch", "Power Construct", "Power of Alchemy", "Power Spot", "Prankster", "Pressure", "Primordial Sea", "Prism Armor", "Propeller Tail", "Protean", "Protosynthesis", "Psychic Surge", "Punk Rock", "Pure Power", "Purifying Salt", "Quark Drive", "Queenly Majesty", "Quick Draw", "Quick Feet", "Rain Dish", "Rattled", "Receiver", "Reckless", "Refrigerate", "Regenerator", "Ripen", "Rivalry", "RKS System", "Rock Head", "Rocky Payload", "Rough Skin", "Run Away", "Sand Force", "Sand Rush", "Sand Spit", "Sand Stream", "Sand Veil", "Sap Sipper", "Schooling", "Scrappy", "Screen Cleaner", "Seed Sower", "Serene Grace", "Shadow Shield", "Shadow Tag", "Sharpness", "Shed Skin", "Sheer Force", "Shell Armor", "Shield Dust", "Shields Down", "Simple", "Skill Link", "Slow Start", "Slush Rush", "Sniper", "Snow Cloak", "Snow Warning", "Solar Power", "Solid Rock", "Soul-Heart", "Soundproof", "Speed Boost", "Stakeout", "Stall", "Stalwart", "Stamina", "Stance Change", "Static", "Steadfast", "Steam Engine", "Steelworker", "Steely Spirit", "Stench", "Sticky Hold", "Storm Drain", "Strong Jaw", "Sturdy", "Suction Cups", "Super Luck", "Supersweet Syrup", "Supreme Overlord", "Surge Surfer", "Swarm", "Sweet Veil", "Swift Swim", "Sword of Ruin", "Symbiosis", "Synchronize", "Tablets of Ruin", "Tangled Feet", "Tangling Hair", "Technician", "Telepathy", "Teravolt", "Thermal Exchange", "Thick Fat", "Tinted Lens", "Torrent", "Tough Claws", "Toxic Boost", "Toxic Chain", "Toxic Debris", "Trace", "Transistor", "Triage", "Truant", "Turboblaze", "Unaware", "Unburden", "Unnerve", "Unseen Fist", "Vessel of Ruin", "Victory Star", "Vital Spirit", "Volt Absorb", "Wandering Spirit", "Water Absorb", "Water Bubble", "Water Compaction", "Water Veil", "Weak Armor", "Well-Baked Body", "White Smoke", "Wimp Out", "Wind Power", "Wind Rider", "Wonder Guard", "Wonder Skin ", "Zen Mode", "Zero to Hero"})
        pokemon1Ability_cmb.Location = New Point(6, 81)
        pokemon1Ability_cmb.Name = "pokemon1Ability_cmb"
        pokemon1Ability_cmb.Size = New Size(140, 23)
        pokemon1Ability_cmb.TabIndex = 8
        ' 
        ' pokemon1Ability_lbl
        ' 
        pokemon1Ability_lbl.AutoSize = True
        pokemon1Ability_lbl.Location = New Point(6, 63)
        pokemon1Ability_lbl.Name = "pokemon1Ability_lbl"
        pokemon1Ability_lbl.Size = New Size(41, 15)
        pokemon1Ability_lbl.TabIndex = 7
        pokemon1Ability_lbl.Text = "Ability"
        ' 
        ' pokemon1Moves_grp
        ' 
        pokemon1Moves_grp.Controls.Add(pokemon1Move4_txtBox)
        pokemon1Moves_grp.Controls.Add(pokemon1Move3_txtBox)
        pokemon1Moves_grp.Controls.Add(pokemon1Move2_txtBox)
        pokemon1Moves_grp.Controls.Add(pokemon1Move1_txtBox)
        pokemon1Moves_grp.Location = New Point(444, 22)
        pokemon1Moves_grp.Name = "pokemon1Moves_grp"
        pokemon1Moves_grp.Size = New Size(273, 82)
        pokemon1Moves_grp.TabIndex = 6
        pokemon1Moves_grp.TabStop = False
        pokemon1Moves_grp.Text = "Moves"
        ' 
        ' pokemon1Move4_txtBox
        ' 
        pokemon1Move4_txtBox.Location = New Point(132, 51)
        pokemon1Move4_txtBox.Name = "pokemon1Move4_txtBox"
        pokemon1Move4_txtBox.PlaceholderText = "Move 4"
        pokemon1Move4_txtBox.Size = New Size(120, 23)
        pokemon1Move4_txtBox.TabIndex = 3
        ' 
        ' pokemon1Move3_txtBox
        ' 
        pokemon1Move3_txtBox.Location = New Point(6, 51)
        pokemon1Move3_txtBox.Name = "pokemon1Move3_txtBox"
        pokemon1Move3_txtBox.PlaceholderText = "Move 3"
        pokemon1Move3_txtBox.Size = New Size(120, 23)
        pokemon1Move3_txtBox.TabIndex = 2
        ' 
        ' pokemon1Move2_txtBox
        ' 
        pokemon1Move2_txtBox.Location = New Point(132, 22)
        pokemon1Move2_txtBox.Name = "pokemon1Move2_txtBox"
        pokemon1Move2_txtBox.PlaceholderText = "Move 2"
        pokemon1Move2_txtBox.Size = New Size(120, 23)
        pokemon1Move2_txtBox.TabIndex = 1
        ' 
        ' pokemon1Move1_txtBox
        ' 
        pokemon1Move1_txtBox.Location = New Point(6, 22)
        pokemon1Move1_txtBox.Name = "pokemon1Move1_txtBox"
        pokemon1Move1_txtBox.PlaceholderText = "Move 1"
        pokemon1Move1_txtBox.Size = New Size(120, 23)
        pokemon1Move1_txtBox.TabIndex = 0
        ' 
        ' pokemon1Level_lbl
        ' 
        pokemon1Level_lbl.AutoSize = True
        pokemon1Level_lbl.Location = New Point(298, 19)
        pokemon1Level_lbl.Name = "pokemon1Level_lbl"
        pokemon1Level_lbl.Size = New Size(34, 15)
        pokemon1Level_lbl.TabIndex = 4
        pokemon1Level_lbl.Text = "Level"
        ' 
        ' pokemon1HeldItem_lbl
        ' 
        pokemon1HeldItem_lbl.AutoSize = True
        pokemon1HeldItem_lbl.Location = New Point(152, 19)
        pokemon1HeldItem_lbl.Name = "pokemon1HeldItem_lbl"
        pokemon1HeldItem_lbl.Size = New Size(59, 15)
        pokemon1HeldItem_lbl.TabIndex = 3
        pokemon1HeldItem_lbl.Text = "Held Item"
        ' 
        ' pokemon1HeldItem_txtBox
        ' 
        pokemon1HeldItem_txtBox.Location = New Point(152, 37)
        pokemon1HeldItem_txtBox.Name = "pokemon1HeldItem_txtBox"
        pokemon1HeldItem_txtBox.PlaceholderText = "FocusSash"
        pokemon1HeldItem_txtBox.Size = New Size(140, 23)
        pokemon1HeldItem_txtBox.TabIndex = 2
        ' 
        ' pokemon1Name_txtBox
        ' 
        pokemon1Name_txtBox.AutoCompleteCustomSource.AddRange(New String() {"BULBASAUR", "IVYSAUR", "VENUSAUR", "CHARMANDER", "CHARMELEON", "CHARIZARD", "SQUIRTLE", "WARTORTLE", "BLASTOISE", "CATERPIE", "METAPOD", "BUTTERFREE", "WEEDLE", "KAKUNA", "BEEDRILL", "PIDGEY", "PIDGEOTTO", "PIDGEOT", "RATTATA", "RATICATE", "SPEAROW", "FEAROW", "EKANS", "ARBOK", "PIKACHU", "RAICHU", "SANDSHREW", "SANDSLASH", "NIDORANfE", "NIDORINA", "NIDOQUEEN", "NIDORANmA", "NIDORINO", "NIDOKING", "CLEFAIRY", "CLEFABLE", "VULPIX", "NINETALES", "JIGGLYPUFF", "WIGGLYTUFF", "ZUBAT", "GOLBAT", "ODDISH", "GLOOM", "VILEPLUME", "PARAS", "PARASECT", "VENONAT", "VENOMOTH", "DIGLETT", "DUGTRIO", "MEOWTH", "PERSIAN", "PSYDUCK", "GOLDUCK", "MANKEY", "PRIMEAPE", "GROWLITHE", "ARCANINE", "POLIWAG", "POLIWHIRL", "POLIWRATH", "ABRA", "KADABRA", "ALAKAZAM", "MACHOP", "MACHOKE", "MACHAMP", "BELLSPROUT", "WEEPINBELL", "VICTREEBEL", "TENTACOOL", "TENTACRUEL", "GEODUDE", "GRAVELER", "GOLEM", "PONYTA", "RAPIDASH", "SLOWPOKE", "SLOWBRO", "MAGNEMITE", "MAGNETON", "FARFETCHD", "DODUO", "DODRIO", "SEEL", "DEWGONG", "GRIMER", "MUK", "SHELLDER", "CLOYSTER", "GASTLY", "HAUNTER", "GENGAR", "ONIX", "DROWZEE", "HYPNO", "KRABBY", "KINGLER", "VOLTORB", "ELECTRODE", "EXEGGCUTE", "EXEGGUTOR", "CUBONE", "MAROWAK", "HITMONLEE", "HITMONCHAN", "LICKITUNG", "KOFFING", "WEEZING", "RHYHORN", "RHYDON", "CHANSEY", "TANGELA", "KANGASKHAN", "HORSEA", "SEADRA", "GOLDEEN", "SEAKING", "STARYU", "STARMIE", "MRMIME", "SCYTHER", "JYNX", "ELECTABUZZ", "MAGMAR", "PINSIR", "TAUROS", "MAGIKARP", "GYARADOS", "LAPRAS", "DITTO", "EEVEE", "VAPOREON", "JOLTEON", "FLAREON", "PORYGON", "OMANYTE", "OMASTAR", "KABUTO", "KABUTOPS", "AERODACTYL", "SNORLAX", "ARTICUNO", "ZAPDOS", "MOLTRES", "DRATINI", "DRAGONAIR", "DRAGONITE", "MEWTWO", "MEW", "CHIKORITA", "BAYLEEF", "MEGANIUM", "CYNDAQUIL", "QUILAVA", "TYPHLOSION", "TOTODILE", "CROCONAW", "FERALIGATR", "SENTRET", "FURRET", "HOOTHOOT", "NOCTOWL", "LEDYBA", "LEDIAN", "SPINARAK", "ARIADOS", "CROBAT", "CHINCHOU", "LANTURN", "PICHU", "CLEFFA", "IGGLYBUFF", "TOGEPI", "TOGETIC", "NATU", "XATU", "MAREEP", "FLAAFFY", "AMPHAROS", "BELLOSSOM", "MARILL", "AZUMARILL", "SUDOWOODO", "POLITOED", "HOPPIP", "SKIPLOOM", "JUMPLUFF", "AIPOM", "SUNKERN", "SUNFLORA", "YANMA", "WOOPER", "QUAGSIRE", "ESPEON", "UMBREON", "MURKROW", "SLOWKING", "MISDREAVUS", "UNOWN", "WOBBUFFET", "GIRAFARIG", "PINECO", "FORRETRESS", "DUNSPARCE", "GLIGAR", "STEELIX", "SNUBBULL", "GRANBULL", "QWILFISH", "SCIZOR", "SHUCKLE", "HERACROSS", "SNEASEL", "TEDDIURSA", "URSARING", "SLUGMA", "MAGCARGO", "SWINUB", "PILOSWINE", "CORSOLA", "REMORAID", "OCTILLERY", "DELIBIRD", "MANTINE", "SKARMORY", "HOUNDOUR", "HOUNDOOM", "KINGDRA", "PHANPY", "DONPHAN", "PORYGON2", "STANTLER", "SMEARGLE", "TYROGUE", "HITMONTOP", "SMOOCHUM", "ELEKID", "MAGBY", "MILTANK", "BLISSEY", "RAIKOU", "ENTEI", "SUICUNE", "LARVITAR", "PUPITAR", "TYRANITAR", "LUGIA", "HO-OH", "CELEBI", "TREECKO", "GROVYLE", "SCEPTILE", "TORCHIC", "COMBUSKEN", "BLAZIKEN", "MUDKIP", "MARSHTOMP", "SWAMPERT", "POOCHYENA", "MIGHTYENA", "ZIGZAGOON", "LINOONE", "WURMPLE", "SILCOON", "BEAUTIFLY", "CASCOON", "DUSTOX", "LOTAD", "LOMBRE", "LUDICOLO", "SEEDOT", "NUZLEAF", "SHIFTRY", "TAILLOW", "SWELLOW", "WINGULL", "PELIPPER", "RALTS", "KIRLIA", "GARDEVOIR", "SURSKIT", "MASQUERAIN", "SHROOMISH", "BRELOOM", "SLAKOTH", "VIGOROTH", "SLAKING", "NINCADA", "NINJASK", "SHEDINJA", "WHISMUR", "LOUDRED", "EXPLOUD", "MAKUHITA", "HARIYAMA", "AZURILL", "NOSEPASS", "SKITTY", "DELCATTY", "SABLEYE", "MAWILE", "ARON", "LAIRON", "AGGRON", "MEDITITE", "MEDICHAM", "ELECTRIKE", "MANECTRIC", "PLUSLE", "MINUN", "VOLBEAT", "ILLUMISE", "ROSELIA", "GULPIN", "SWALOT", "CARVANHA", "SHARPEDO", "WAILMER", "WAILORD", "NUMEL", "CAMERUPT", "TORKOAL", "SPOINK", "GRUMPIG", "SPINDA", "TRAPINCH", "VIBRAVA", "FLYGON", "CACNEA", "CACTURNE", "SWABLU", "ALTARIA", "ZANGOOSE", "SEVIPER", "LUNATONE", "SOLROCK", "BARBOACH", "WHISCASH", "CORPHISH", "CRAWDAUNT", "BALTOY", "CLAYDOL", "LILEEP", "CRADILY", "ANORITH", "ARMALDO", "FEEBAS", "MILOTIC", "CASTFORM", "KECLEON", "SHUPPET", "BANETTE", "DUSKULL", "DUSCLOPS", "TROPIUS", "CHIMECHO", "ABSOL", "WYNAUT", "SNORUNT", "GLALIE", "SPHEAL", "SEALEO", "WALREIN", "CLAMPERL", "HUNTAIL", "GOREBYSS", "RELICANTH", "LUVDISC", "BAGON", "SHELGON", "SALAMENCE", "BELDUM", "METANG", "METAGROSS", "REGIROCK", "REGICE", "REGISTEEL", "LATIAS", "LATIOS", "KYOGRE", "GROUDON", "RAYQUAZA", "JIRACHI", "DEOXYS", "TURTWIG", "GROTLE", "TORTERRA", "CHIMCHAR", "MONFERNO", "INFERNAPE", "PIPLUP", "PRINPLUP", "EMPOLEON", "STARLY", "STARAVIA", "STARAPTOR", "BIDOOF", "BIBAREL", "KRICKETOT", "KRICKETUNE", "SHINX", "LUXIO", "LUXRAY", "BUDEW", "ROSERADE", "CRANIDOS", "RAMPARDOS", "SHIELDON", "BASTIODON", "BURMY", "WORMADAM", "MOTHIM", "COMBEE", "VESPIQUEN", "PACHIRISU", "BUIZEL", "FLOATZEL", "CHERUBI", "CHERRIM", "SHELLOS", "GASTRODON", "AMBIPOM", "DRIFLOON", "DRIFBLIM", "BUNEARY", "LOPUNNY", "MISMAGIUS", "HONCHKROW", "GLAMEOW", "PURUGLY", "CHINGLING", "STUNKY", "SKUNTANK", "BRONZOR", "BRONZONG", "BONSLY", "MIMEJR", "HAPPINY", "CHATOT", "SPIRITOMB", "GIBLE", "GABITE", "GARCHOMP", "MUNCHLAX", "RIOLU", "LUCARIO", "HIPPOPOTAS", "HIPPOWDON", "SKORUPI", "DRAPION", "CROAGUNK", "TOXICROAK", "CARNIVINE", "FINNEON", "LUMINEON", "MANTYKE", "SNOVER", "ABOMASNOW", "WEAVILE", "MAGNEZONE", "LICKILICKY", "RHYPERIOR", "TANGROWTH", "ELECTIVIRE", "MAGMORTAR", "TOGEKISS", "YANMEGA", "LEAFEON", "GLACEON", "GLISCOR", "MAMOSWINE", "PORYGON-Z", "GALLADE", "PROBOPASS", "DUSKNOIR", "FROSLASS", "ROTOM", "UXIE", "MESPRIT", "AZELF", "DIALGA", "PALKIA", "HEATRAN", "REGIGIGAS", "GIRATINA", "CRESSELIA", "PHIONE", "MANAPHY", "DARKRAI", "SHAYMIN", "ARCEUS", "VICTINI", "SNIVY", "SERVINE", "SERPERIOR", "TEPIG", "PIGNITE", "EMBOAR", "OSHAWOTT", "DEWOTT", "SAMUROTT", "PATRAT", "WATCHOG", "LILLIPUP", "HERDIER", "STOUTLAND", "PURRLOIN", "LIEPARD", "PANSAGE", "SIMISAGE", "PANSEAR", "SIMISEAR", "PANPOUR", "SIMIPOUR", "MUNNA", "MUSHARNA", "PIDOVE", "TRANQUILL", "UNFEZANT", "BLITZLE", "ZEBSTRIKA", "ROGGENROLA", "BOLDORE", "GIGALITH", "WOOBAT", "SWOOBAT", "DRILBUR", "EXCADRILL", "AUDINO", "TIMBURR", "GURDURR", "CONKELDURR", "TYMPOLE", "PALPITOAD", "SEISMITOAD", "THROH", "SAWK", "SEWADDLE", "SWADLOON", "LEAVANNY", "VENIPEDE", "WHIRLIPEDE", "SCOLIPEDE", "COTTONEE", "WHIMSICOTT", "PETILIL", "LILLIGANT", "BASCULIN", "SANDILE", "KROKOROK", "KROOKODILE", "DARUMAKA", "DARMANITAN", "MARACTUS", "DWEBBLE", "CRUSTLE", "SCRAGGY", "SCRAFTY", "SIGILYPH", "YAMASK", "COFAGRIGUS", "TIRTOUGA", "CARRACOSTA", "ARCHEN", "ARCHEOPS", "TRUBBISH", "GARBODOR", "ZORUA", "ZOROARK", "MINCCINO", "CINCCINO", "GOTHITA", "GOTHORITA", "GOTHITELLE", "SOLOSIS", "DUOSION", "REUNICLUS", "DUCKLETT", "SWANNA", "VANILLITE", "VANILLISH", "VANILLUXE", "DEERLING", "SAWSBUCK", "EMOLGA", "KARRABLAST", "ESCAVALIER", "FOONGUS", "AMOONGUSS", "FRILLISH", "JELLICENT", "ALOMOMOLA", "JOLTIK", "GALVANTULA", "FERROSEED", "FERROTHORN", "KLINK", "KLANG", "KLINKLANG", "TYNAMO", "EELEKTRIK", "EELEKTROSS", "ELGYEM", "BEHEEYEM", "LITWICK", "LAMPENT", "CHANDELURE", "AXEW", "FRAXURE", "HAXORUS", "CUBCHOO", "BEARTIC", "CRYOGONAL", "SHELMET", "ACCELGOR", "STUNFISK", "MIENFOO", "MIENSHAO", "DRUDDIGON", "GOLETT", "GOLURK", "PAWNIARD", "BISHARP", "BOUFFALANT", "RUFFLET", "BRAVIARY", "VULLABY", "MANDIBUZZ", "HEATMOR", "DURANT", "DEINO", "ZWEILOUS", "HYDREIGON", "LARVESTA", "VOLCARONA", "COBALION", "TERRAKION", "VIRIZION", "TORNADUS", "THUNDURUS", "RESHIRAM", "ZEKROM", "LANDORUS", "KYUREM", "KELDEO", "MELOETTA", "GENESECT", "CHESPIN", "QUILLADIN", "CHESNAUGHT", "FENNEKIN", "BRAIXEN", "DELPHOX", "FROAKIE", "FROGADIER", "GRENINJA", "BUNNELBY", "DIGGERSBY", "FLETCHLING", "FLETCHINDER", "TALONFLAME", "SCATTERBUG", "SPEWPA", "VIVILLON", "LITLEO", "PYROAR", "FLABEBE", "FLOETTE", "FLORGES", "SKIDDO", "GOGOAT", "PANCHAM", "PANGORO", "FURFROU", "ESPURR", "MEOWSTIC", "HONEDGE", "DOUBLADE", "AEGISLASH", "SPRITZEE", "AROMATISSE", "SWIRLIX", "SLURPUFF", "INKAY", "MALAMAR", "BINACLE", "BARBARACLE", "SKRELP", "DRAGALGE", "CLAUNCHER", "CLAWITZER", "HELIOPTILE", "HELIOLISK", "TYRUNT", "TYRANTRUM", "AMAURA", "AURORUS", "SYLVEON", "HAWLUCHA", "DEDENNE", "CARBINK", "GOOMY", "SLIGGOO", "GOODRA", "KLEFKI", "PHANTUMP", "TREVENANT", "PUMPKABOO", "GOURGEIST", "BERGMITE", "AVALUGG", "NOIBAT", "NOIVERN", "XERNEAS", "YVELTAL", "ZYGARDE", "DIANCIE", "HOOPA", "VOLCANION", "ROWLET", "DARTRIX", "DECIDUEYE", "LITTEN", "TORRACAT", "INCINEROAR", "POPPLIO", "BRIONNE", "PRIMARINA", "PIKIPEK", "TRUMBEAK", "TOUCANNON", "YUNGOOS", "GUMSHOOS", "GRUBBIN", "CHARJABUG", "VIKAVOLT", "CRABRAWLER", "CRABOMINABLE", "ORICORIO", "CUTIEFLY", "RIBOMBEE", "ROCKRUFF", "LYCANROC", "WISHIWASHI", "MAREANIE", "TOXAPEX", "MUDBRAY", "MUDSDALE", "DEWPIDER", "ARAQUANID", "FOMANTIS", "LURANTIS", "MORELULL", "SHIINOTIC", "SALANDIT", "SALAZZLE", "STUFFUL", "BEWEAR", "BOUNSWEET", "STEENEE", "TSAREENA", "COMFEY", "ORANGURU", "PASSIMIAN", "WIMPOD", "GOLISOPOD", "SANDYGAST", "PALOSSAND", "PYUKUMUKU", "TYPENULL", "SILVALLY", "MINIOR", "KOMALA", "TURTONATOR", "TOGEDEMARU", "MIMIKYU", "BRUXISH", "DRAMPA", "DHELMISE", "JANGMO-O", "HAKAMO-O", "KOMMO-O", "TAPUKOKO", "TAPULELE", "TAPUBULU", "TAPUFINI", "COSMOG", "COSMOEM", "SOLGALEO", "LUNALA", "NIHILEGO", "BUZZWOLE", "PHEROMOSA", "XURKITREE", "CELESTEELA", "KARTANA", "GUZZLORD", "NECROZMA", "MAGEARNA", "MARSHADOW", "POIPOLE", "NAGANADEL", "STAKATAKA", "BLACEPHALON", "ZERAORA", "MELTAN", "MELMETAL", "GROOKEY", "THWACKEY", "RILLABOOM", "SCORBUNNY", "RABOOT", "CINDERACE", "SOBBLE", "DRIZZILE", "INTELEON", "SKWOVET", "GREEDENT", "ROOKIDEE", "CORVISQUIRE", "CORVIKNIGHT", "BLIPBUG", "DOTTLER", "ORBEETLE", "NICKIT", "THIEVUL", "GOSSIFLEUR", "ELDEGOSS", "WOOLOO", "DUBWOOL", "CHEWTLE", "DREDNAW", "YAMPER", "BOLTUND", "ROLYCOLY", "CARKOL", "COALOSSAL", "APPLIN", "FLAPPLE", "APPLETUN", "SILICOBRA", "SANDACONDA", "CRAMORANT", "ARROKUDA", "BARRASKEWDA", "TOXEL", "TOXTRICITY", "SIZZLIPEDE", "CENTISKORCH", "CLOBBOPUS", "GRAPPLOCT", "SINISTEA", "POLTEAGEIST", "HATENNA", "HATTREM", "HATTERENE", "IMPIDIMP", "MORGREM", "GRIMMSNARL", "OBSTAGOON", "PERRSERKER", "CURSOLA", "SIRFETCHD", "MRRIME", "RUNERIGUS", "MILCERY", "ALCREMIE", "FALINKS", "PINCURCHIN", "SNOM", "FROSMOTH", "STONJOURNER", "EISCUE", "INDEEDEE", "MORPEKO", "CUFANT", "COPPERAJAH", "DRACOZOLT", "ARCTOZOLT", "DRACOVISH", "ARCTOVISH", "DURALUDON", "DREEPY", "DRAKLOAK", "DRAGAPULT", "ZACIAN", "ZAMAZENTA", "ETERNATUS", "KUBFU", "URSHIFU", "ZARUDE", "REGIELEKI", "REGIDRAGO", "GLASTRIER", "SPECTRIER", "CALYREX"})
        pokemon1Name_txtBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon1Name_txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon1Name_txtBox.Location = New Point(6, 37)
        pokemon1Name_txtBox.Name = "pokemon1Name_txtBox"
        pokemon1Name_txtBox.PlaceholderText = "Bulbasaur"
        pokemon1Name_txtBox.Size = New Size(140, 23)
        pokemon1Name_txtBox.TabIndex = 1
        ' 
        ' pokemon1Name_lbl
        ' 
        pokemon1Name_lbl.AutoSize = True
        pokemon1Name_lbl.Location = New Point(6, 19)
        pokemon1Name_lbl.Name = "pokemon1Name_lbl"
        pokemon1Name_lbl.Size = New Size(93, 15)
        pokemon1Name_lbl.TabIndex = 0
        pokemon1Name_lbl.Text = "Pokémon Name"
        ' 
        ' pg_pkmn2
        ' 
        pg_pkmn2.Controls.Add(pokemon2_grp)
        pg_pkmn2.Location = New Point(4, 24)
        pg_pkmn2.Name = "pg_pkmn2"
        pg_pkmn2.Padding = New Padding(3)
        pg_pkmn2.Size = New Size(729, 475)
        pg_pkmn2.TabIndex = 3
        pg_pkmn2.Text = "Pokémon 2"
        pg_pkmn2.UseVisualStyleBackColor = True
        ' 
        ' pokemon2_grp
        ' 
        pokemon2_grp.Controls.Add(pokemon2Level_nbr)
        pokemon2_grp.Controls.Add(pokemon2Form_nbr)
        pokemon2_grp.Controls.Add(pokemon2Happiness_nbr)
        pokemon2_grp.Controls.Add(pokemon2Shadow_grp)
        pokemon2_grp.Controls.Add(pokemon2Name_lbl)
        pokemon2_grp.Controls.Add(pokemon2EVs_grp)
        pokemon2_grp.Controls.Add(pokemon2Name_txt)
        pokemon2_grp.Controls.Add(pokemon2IVs_grp)
        pokemon2_grp.Controls.Add(pokemon2HeldItem_txt)
        pokemon2_grp.Controls.Add(pokemon2PokeballID_cmb)
        pokemon2_grp.Controls.Add(pokemon2HeldItem_lbl)
        pokemon2_grp.Controls.Add(pokemon2PokeBall_lbl)
        pokemon2_grp.Controls.Add(pokemon2Level_lbl)
        pokemon2_grp.Controls.Add(pokemon2Nickname_txt)
        pokemon2_grp.Controls.Add(pokemon2Nickname_lbl)
        pokemon2_grp.Controls.Add(pokemon2Moves_grp)
        pokemon2_grp.Controls.Add(pokemon2Ability_lbl)
        pokemon2_grp.Controls.Add(pokemon2Happiness_lbl)
        pokemon2_grp.Controls.Add(pokemon2Ability_cmb)
        pokemon2_grp.Controls.Add(pokemon2Nature_cmb)
        pokemon2_grp.Controls.Add(pokemon2Gender_lbl)
        pokemon2_grp.Controls.Add(pokemon2Nature_lbl)
        pokemon2_grp.Controls.Add(pokemon2Gender_cmb)
        pokemon2_grp.Controls.Add(pokemon2Shiny_grp)
        pokemon2_grp.Controls.Add(pokemon2Form_lbl)
        pokemon2_grp.Dock = DockStyle.Fill
        pokemon2_grp.Location = New Point(3, 3)
        pokemon2_grp.Name = "pokemon2_grp"
        pokemon2_grp.Size = New Size(723, 469)
        pokemon2_grp.TabIndex = 0
        pokemon2_grp.TabStop = False
        pokemon2_grp.Text = "Pokémon 2"
        ' 
        ' pokemon2Level_nbr
        ' 
        pokemon2Level_nbr.Location = New Point(298, 37)
        pokemon2Level_nbr.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        pokemon2Level_nbr.Name = "pokemon2Level_nbr"
        pokemon2Level_nbr.Size = New Size(140, 23)
        pokemon2Level_nbr.TabIndex = 58
        pokemon2Level_nbr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' pokemon2Form_nbr
        ' 
        pokemon2Form_nbr.Location = New Point(298, 80)
        pokemon2Form_nbr.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        pokemon2Form_nbr.Name = "pokemon2Form_nbr"
        pokemon2Form_nbr.Size = New Size(140, 23)
        pokemon2Form_nbr.TabIndex = 57
        ' 
        ' pokemon2Happiness_nbr
        ' 
        pokemon2Happiness_nbr.Location = New Point(152, 124)
        pokemon2Happiness_nbr.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        pokemon2Happiness_nbr.Name = "pokemon2Happiness_nbr"
        pokemon2Happiness_nbr.Size = New Size(140, 23)
        pokemon2Happiness_nbr.TabIndex = 56
        pokemon2Happiness_nbr.Value = New Decimal(New Integer() {70, 0, 0, 0})
        ' 
        ' pokemon2Shadow_grp
        ' 
        pokemon2Shadow_grp.Controls.Add(pokemon2Shadow_rad)
        pokemon2Shadow_grp.Controls.Add(pokemon2NotShadow_rad)
        pokemon2Shadow_grp.Location = New Point(444, 198)
        pokemon2Shadow_grp.Name = "pokemon2Shadow_grp"
        pokemon2Shadow_grp.Size = New Size(273, 82)
        pokemon2Shadow_grp.TabIndex = 55
        pokemon2Shadow_grp.TabStop = False
        pokemon2Shadow_grp.Text = "Shadow"
        ' 
        ' pokemon2Shadow_rad
        ' 
        pokemon2Shadow_rad.AutoSize = True
        pokemon2Shadow_rad.Location = New Point(6, 47)
        pokemon2Shadow_rad.Name = "pokemon2Shadow_rad"
        pokemon2Shadow_rad.Size = New Size(67, 19)
        pokemon2Shadow_rad.TabIndex = 1
        pokemon2Shadow_rad.Text = "Shadow"
        pokemon2Shadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon2NotShadow_rad
        ' 
        pokemon2NotShadow_rad.AutoSize = True
        pokemon2NotShadow_rad.Checked = True
        pokemon2NotShadow_rad.Location = New Point(6, 22)
        pokemon2NotShadow_rad.Name = "pokemon2NotShadow_rad"
        pokemon2NotShadow_rad.Size = New Size(90, 19)
        pokemon2NotShadow_rad.TabIndex = 0
        pokemon2NotShadow_rad.TabStop = True
        pokemon2NotShadow_rad.Text = "Not Shadow"
        pokemon2NotShadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon2Name_lbl
        ' 
        pokemon2Name_lbl.AutoSize = True
        pokemon2Name_lbl.Location = New Point(6, 19)
        pokemon2Name_lbl.Name = "pokemon2Name_lbl"
        pokemon2Name_lbl.Size = New Size(93, 15)
        pokemon2Name_lbl.TabIndex = 31
        pokemon2Name_lbl.Text = "Pokémon Name"
        ' 
        ' pokemon2EVs_grp
        ' 
        pokemon2EVs_grp.Controls.Add(pokemon2EVsDEF_txt)
        pokemon2EVs_grp.Controls.Add(pokemon2EVsDEF_lbl)
        pokemon2EVs_grp.Controls.Add(pokemon2EVsSPDEF_txt)
        pokemon2EVs_grp.Controls.Add(pokemon2EVsSPDEF_lbl)
        pokemon2EVs_grp.Controls.Add(pokemon2EVsSPATK_txt)
        pokemon2EVs_grp.Controls.Add(pokemon2EVsSPATK_lbl)
        pokemon2EVs_grp.Controls.Add(pokemon2EVsSPD_txt)
        pokemon2EVs_grp.Controls.Add(pokemon2EVsSPD_lbl)
        pokemon2EVs_grp.Controls.Add(pokemon2EVsATK_txt)
        pokemon2EVs_grp.Controls.Add(pokemon2EVsATK_lbl)
        pokemon2EVs_grp.Controls.Add(pokemon2EVsHP_txt)
        pokemon2EVs_grp.Controls.Add(pokemon2EVsHP_lbl)
        pokemon2EVs_grp.Location = New Point(324, 154)
        pokemon2EVs_grp.Name = "pokemon2EVs_grp"
        pokemon2EVs_grp.Size = New Size(114, 156)
        pokemon2EVs_grp.TabIndex = 54
        pokemon2EVs_grp.TabStop = False
        pokemon2EVs_grp.Text = "EVs"
        ' 
        ' pokemon2EVsDEF_txt
        ' 
        pokemon2EVsDEF_txt.Location = New Point(6, 125)
        pokemon2EVsDEF_txt.MaxLength = 3
        pokemon2EVsDEF_txt.Name = "pokemon2EVsDEF_txt"
        pokemon2EVsDEF_txt.Size = New Size(44, 23)
        pokemon2EVsDEF_txt.TabIndex = 11
        pokemon2EVsDEF_txt.Text = "0"
        ' 
        ' pokemon2EVsDEF_lbl
        ' 
        pokemon2EVsDEF_lbl.AutoSize = True
        pokemon2EVsDEF_lbl.Location = New Point(14, 107)
        pokemon2EVsDEF_lbl.Name = "pokemon2EVsDEF_lbl"
        pokemon2EVsDEF_lbl.Size = New Size(27, 15)
        pokemon2EVsDEF_lbl.TabIndex = 10
        pokemon2EVsDEF_lbl.Text = "DEF"
        ' 
        ' pokemon2EVsSPDEF_txt
        ' 
        pokemon2EVsSPDEF_txt.Location = New Point(55, 125)
        pokemon2EVsSPDEF_txt.MaxLength = 3
        pokemon2EVsSPDEF_txt.Name = "pokemon2EVsSPDEF_txt"
        pokemon2EVsSPDEF_txt.Size = New Size(44, 23)
        pokemon2EVsSPDEF_txt.TabIndex = 9
        pokemon2EVsSPDEF_txt.Text = "0"
        ' 
        ' pokemon2EVsSPDEF_lbl
        ' 
        pokemon2EVsSPDEF_lbl.AutoSize = True
        pokemon2EVsSPDEF_lbl.Location = New Point(55, 109)
        pokemon2EVsSPDEF_lbl.Name = "pokemon2EVsSPDEF_lbl"
        pokemon2EVsSPDEF_lbl.Size = New Size(40, 15)
        pokemon2EVsSPDEF_lbl.TabIndex = 8
        pokemon2EVsSPDEF_lbl.Text = "SPDEF"
        ' 
        ' pokemon2EVsSPATK_txt
        ' 
        pokemon2EVsSPATK_txt.Location = New Point(55, 81)
        pokemon2EVsSPATK_txt.MaxLength = 3
        pokemon2EVsSPATK_txt.Name = "pokemon2EVsSPATK_txt"
        pokemon2EVsSPATK_txt.Size = New Size(44, 23)
        pokemon2EVsSPATK_txt.TabIndex = 7
        pokemon2EVsSPATK_txt.Text = "0"
        ' 
        ' pokemon2EVsSPATK_lbl
        ' 
        pokemon2EVsSPATK_lbl.AutoSize = True
        pokemon2EVsSPATK_lbl.Location = New Point(56, 65)
        pokemon2EVsSPATK_lbl.Name = "pokemon2EVsSPATK_lbl"
        pokemon2EVsSPATK_lbl.Size = New Size(39, 15)
        pokemon2EVsSPATK_lbl.TabIndex = 6
        pokemon2EVsSPATK_lbl.Text = "SPATK"
        ' 
        ' pokemon2EVsSPD_txt
        ' 
        pokemon2EVsSPD_txt.Location = New Point(55, 37)
        pokemon2EVsSPD_txt.MaxLength = 3
        pokemon2EVsSPD_txt.Name = "pokemon2EVsSPD_txt"
        pokemon2EVsSPD_txt.Size = New Size(44, 23)
        pokemon2EVsSPD_txt.TabIndex = 5
        pokemon2EVsSPD_txt.Text = "0"
        ' 
        ' pokemon2EVsSPD_lbl
        ' 
        pokemon2EVsSPD_lbl.AutoSize = True
        pokemon2EVsSPD_lbl.Location = New Point(63, 21)
        pokemon2EVsSPD_lbl.Name = "pokemon2EVsSPD_lbl"
        pokemon2EVsSPD_lbl.Size = New Size(28, 15)
        pokemon2EVsSPD_lbl.TabIndex = 4
        pokemon2EVsSPD_lbl.Text = "SPD"
        ' 
        ' pokemon2EVsATK_txt
        ' 
        pokemon2EVsATK_txt.Location = New Point(6, 81)
        pokemon2EVsATK_txt.MaxLength = 3
        pokemon2EVsATK_txt.Name = "pokemon2EVsATK_txt"
        pokemon2EVsATK_txt.Size = New Size(44, 23)
        pokemon2EVsATK_txt.TabIndex = 3
        pokemon2EVsATK_txt.Text = "0"
        ' 
        ' pokemon2EVsATK_lbl
        ' 
        pokemon2EVsATK_lbl.AutoSize = True
        pokemon2EVsATK_lbl.Location = New Point(14, 63)
        pokemon2EVsATK_lbl.Name = "pokemon2EVsATK_lbl"
        pokemon2EVsATK_lbl.Size = New Size(27, 15)
        pokemon2EVsATK_lbl.TabIndex = 2
        pokemon2EVsATK_lbl.Text = "ATK"
        ' 
        ' pokemon2EVsHP_txt
        ' 
        pokemon2EVsHP_txt.Location = New Point(6, 37)
        pokemon2EVsHP_txt.MaxLength = 3
        pokemon2EVsHP_txt.Name = "pokemon2EVsHP_txt"
        pokemon2EVsHP_txt.Size = New Size(44, 23)
        pokemon2EVsHP_txt.TabIndex = 1
        pokemon2EVsHP_txt.Text = "0"
        ' 
        ' pokemon2EVsHP_lbl
        ' 
        pokemon2EVsHP_lbl.AutoSize = True
        pokemon2EVsHP_lbl.Location = New Point(16, 19)
        pokemon2EVsHP_lbl.Name = "pokemon2EVsHP_lbl"
        pokemon2EVsHP_lbl.Size = New Size(23, 15)
        pokemon2EVsHP_lbl.TabIndex = 0
        pokemon2EVsHP_lbl.Text = "HP"
        ' 
        ' pokemon2Name_txt
        ' 
        pokemon2Name_txt.AutoCompleteCustomSource.AddRange(New String() {"BULBASAUR", "IVYSAUR", "VENUSAUR", "CHARMANDER", "CHARMELEON", "CHARIZARD", "SQUIRTLE", "WARTORTLE", "BLASTOISE", "CATERPIE", "METAPOD", "BUTTERFREE", "WEEDLE", "KAKUNA", "BEEDRILL", "PIDGEY", "PIDGEOTTO", "PIDGEOT", "RATTATA", "RATICATE", "SPEAROW", "FEAROW", "EKANS", "ARBOK", "PIKACHU", "RAICHU", "SANDSHREW", "SANDSLASH", "NIDORANfE", "NIDORINA", "NIDOQUEEN", "NIDORANmA", "NIDORINO", "NIDOKING", "CLEFAIRY", "CLEFABLE", "VULPIX", "NINETALES", "JIGGLYPUFF", "WIGGLYTUFF", "ZUBAT", "GOLBAT", "ODDISH", "GLOOM", "VILEPLUME", "PARAS", "PARASECT", "VENONAT", "VENOMOTH", "DIGLETT", "DUGTRIO", "MEOWTH", "PERSIAN", "PSYDUCK", "GOLDUCK", "MANKEY", "PRIMEAPE", "GROWLITHE", "ARCANINE", "POLIWAG", "POLIWHIRL", "POLIWRATH", "ABRA", "KADABRA", "ALAKAZAM", "MACHOP", "MACHOKE", "MACHAMP", "BELLSPROUT", "WEEPINBELL", "VICTREEBEL", "TENTACOOL", "TENTACRUEL", "GEODUDE", "GRAVELER", "GOLEM", "PONYTA", "RAPIDASH", "SLOWPOKE", "SLOWBRO", "MAGNEMITE", "MAGNETON", "FARFETCHD", "DODUO", "DODRIO", "SEEL", "DEWGONG", "GRIMER", "MUK", "SHELLDER", "CLOYSTER", "GASTLY", "HAUNTER", "GENGAR", "ONIX", "DROWZEE", "HYPNO", "KRABBY", "KINGLER", "VOLTORB", "ELECTRODE", "EXEGGCUTE", "EXEGGUTOR", "CUBONE", "MAROWAK", "HITMONLEE", "HITMONCHAN", "LICKITUNG", "KOFFING", "WEEZING", "RHYHORN", "RHYDON", "CHANSEY", "TANGELA", "KANGASKHAN", "HORSEA", "SEADRA", "GOLDEEN", "SEAKING", "STARYU", "STARMIE", "MRMIME", "SCYTHER", "JYNX", "ELECTABUZZ", "MAGMAR", "PINSIR", "TAUROS", "MAGIKARP", "GYARADOS", "LAPRAS", "DITTO", "EEVEE", "VAPOREON", "JOLTEON", "FLAREON", "PORYGON", "OMANYTE", "OMASTAR", "KABUTO", "KABUTOPS", "AERODACTYL", "SNORLAX", "ARTICUNO", "ZAPDOS", "MOLTRES", "DRATINI", "DRAGONAIR", "DRAGONITE", "MEWTWO", "MEW", "CHIKORITA", "BAYLEEF", "MEGANIUM", "CYNDAQUIL", "QUILAVA", "TYPHLOSION", "TOTODILE", "CROCONAW", "FERALIGATR", "SENTRET", "FURRET", "HOOTHOOT", "NOCTOWL", "LEDYBA", "LEDIAN", "SPINARAK", "ARIADOS", "CROBAT", "CHINCHOU", "LANTURN", "PICHU", "CLEFFA", "IGGLYBUFF", "TOGEPI", "TOGETIC", "NATU", "XATU", "MAREEP", "FLAAFFY", "AMPHAROS", "BELLOSSOM", "MARILL", "AZUMARILL", "SUDOWOODO", "POLITOED", "HOPPIP", "SKIPLOOM", "JUMPLUFF", "AIPOM", "SUNKERN", "SUNFLORA", "YANMA", "WOOPER", "QUAGSIRE", "ESPEON", "UMBREON", "MURKROW", "SLOWKING", "MISDREAVUS", "UNOWN", "WOBBUFFET", "GIRAFARIG", "PINECO", "FORRETRESS", "DUNSPARCE", "GLIGAR", "STEELIX", "SNUBBULL", "GRANBULL", "QWILFISH", "SCIZOR", "SHUCKLE", "HERACROSS", "SNEASEL", "TEDDIURSA", "URSARING", "SLUGMA", "MAGCARGO", "SWINUB", "PILOSWINE", "CORSOLA", "REMORAID", "OCTILLERY", "DELIBIRD", "MANTINE", "SKARMORY", "HOUNDOUR", "HOUNDOOM", "KINGDRA", "PHANPY", "DONPHAN", "PORYGON2", "STANTLER", "SMEARGLE", "TYROGUE", "HITMONTOP", "SMOOCHUM", "ELEKID", "MAGBY", "MILTANK", "BLISSEY", "RAIKOU", "ENTEI", "SUICUNE", "LARVITAR", "PUPITAR", "TYRANITAR", "LUGIA", "HO-OH", "CELEBI", "TREECKO", "GROVYLE", "SCEPTILE", "TORCHIC", "COMBUSKEN", "BLAZIKEN", "MUDKIP", "MARSHTOMP", "SWAMPERT", "POOCHYENA", "MIGHTYENA", "ZIGZAGOON", "LINOONE", "WURMPLE", "SILCOON", "BEAUTIFLY", "CASCOON", "DUSTOX", "LOTAD", "LOMBRE", "LUDICOLO", "SEEDOT", "NUZLEAF", "SHIFTRY", "TAILLOW", "SWELLOW", "WINGULL", "PELIPPER", "RALTS", "KIRLIA", "GARDEVOIR", "SURSKIT", "MASQUERAIN", "SHROOMISH", "BRELOOM", "SLAKOTH", "VIGOROTH", "SLAKING", "NINCADA", "NINJASK", "SHEDINJA", "WHISMUR", "LOUDRED", "EXPLOUD", "MAKUHITA", "HARIYAMA", "AZURILL", "NOSEPASS", "SKITTY", "DELCATTY", "SABLEYE", "MAWILE", "ARON", "LAIRON", "AGGRON", "MEDITITE", "MEDICHAM", "ELECTRIKE", "MANECTRIC", "PLUSLE", "MINUN", "VOLBEAT", "ILLUMISE", "ROSELIA", "GULPIN", "SWALOT", "CARVANHA", "SHARPEDO", "WAILMER", "WAILORD", "NUMEL", "CAMERUPT", "TORKOAL", "SPOINK", "GRUMPIG", "SPINDA", "TRAPINCH", "VIBRAVA", "FLYGON", "CACNEA", "CACTURNE", "SWABLU", "ALTARIA", "ZANGOOSE", "SEVIPER", "LUNATONE", "SOLROCK", "BARBOACH", "WHISCASH", "CORPHISH", "CRAWDAUNT", "BALTOY", "CLAYDOL", "LILEEP", "CRADILY", "ANORITH", "ARMALDO", "FEEBAS", "MILOTIC", "CASTFORM", "KECLEON", "SHUPPET", "BANETTE", "DUSKULL", "DUSCLOPS", "TROPIUS", "CHIMECHO", "ABSOL", "WYNAUT", "SNORUNT", "GLALIE", "SPHEAL", "SEALEO", "WALREIN", "CLAMPERL", "HUNTAIL", "GOREBYSS", "RELICANTH", "LUVDISC", "BAGON", "SHELGON", "SALAMENCE", "BELDUM", "METANG", "METAGROSS", "REGIROCK", "REGICE", "REGISTEEL", "LATIAS", "LATIOS", "KYOGRE", "GROUDON", "RAYQUAZA", "JIRACHI", "DEOXYS", "TURTWIG", "GROTLE", "TORTERRA", "CHIMCHAR", "MONFERNO", "INFERNAPE", "PIPLUP", "PRINPLUP", "EMPOLEON", "STARLY", "STARAVIA", "STARAPTOR", "BIDOOF", "BIBAREL", "KRICKETOT", "KRICKETUNE", "SHINX", "LUXIO", "LUXRAY", "BUDEW", "ROSERADE", "CRANIDOS", "RAMPARDOS", "SHIELDON", "BASTIODON", "BURMY", "WORMADAM", "MOTHIM", "COMBEE", "VESPIQUEN", "PACHIRISU", "BUIZEL", "FLOATZEL", "CHERUBI", "CHERRIM", "SHELLOS", "GASTRODON", "AMBIPOM", "DRIFLOON", "DRIFBLIM", "BUNEARY", "LOPUNNY", "MISMAGIUS", "HONCHKROW", "GLAMEOW", "PURUGLY", "CHINGLING", "STUNKY", "SKUNTANK", "BRONZOR", "BRONZONG", "BONSLY", "MIMEJR", "HAPPINY", "CHATOT", "SPIRITOMB", "GIBLE", "GABITE", "GARCHOMP", "MUNCHLAX", "RIOLU", "LUCARIO", "HIPPOPOTAS", "HIPPOWDON", "SKORUPI", "DRAPION", "CROAGUNK", "TOXICROAK", "CARNIVINE", "FINNEON", "LUMINEON", "MANTYKE", "SNOVER", "ABOMASNOW", "WEAVILE", "MAGNEZONE", "LICKILICKY", "RHYPERIOR", "TANGROWTH", "ELECTIVIRE", "MAGMORTAR", "TOGEKISS", "YANMEGA", "LEAFEON", "GLACEON", "GLISCOR", "MAMOSWINE", "PORYGON-Z", "GALLADE", "PROBOPASS", "DUSKNOIR", "FROSLASS", "ROTOM", "UXIE", "MESPRIT", "AZELF", "DIALGA", "PALKIA", "HEATRAN", "REGIGIGAS", "GIRATINA", "CRESSELIA", "PHIONE", "MANAPHY", "DARKRAI", "SHAYMIN", "ARCEUS", "VICTINI", "SNIVY", "SERVINE", "SERPERIOR", "TEPIG", "PIGNITE", "EMBOAR", "OSHAWOTT", "DEWOTT", "SAMUROTT", "PATRAT", "WATCHOG", "LILLIPUP", "HERDIER", "STOUTLAND", "PURRLOIN", "LIEPARD", "PANSAGE", "SIMISAGE", "PANSEAR", "SIMISEAR", "PANPOUR", "SIMIPOUR", "MUNNA", "MUSHARNA", "PIDOVE", "TRANQUILL", "UNFEZANT", "BLITZLE", "ZEBSTRIKA", "ROGGENROLA", "BOLDORE", "GIGALITH", "WOOBAT", "SWOOBAT", "DRILBUR", "EXCADRILL", "AUDINO", "TIMBURR", "GURDURR", "CONKELDURR", "TYMPOLE", "PALPITOAD", "SEISMITOAD", "THROH", "SAWK", "SEWADDLE", "SWADLOON", "LEAVANNY", "VENIPEDE", "WHIRLIPEDE", "SCOLIPEDE", "COTTONEE", "WHIMSICOTT", "PETILIL", "LILLIGANT", "BASCULIN", "SANDILE", "KROKOROK", "KROOKODILE", "DARUMAKA", "DARMANITAN", "MARACTUS", "DWEBBLE", "CRUSTLE", "SCRAGGY", "SCRAFTY", "SIGILYPH", "YAMASK", "COFAGRIGUS", "TIRTOUGA", "CARRACOSTA", "ARCHEN", "ARCHEOPS", "TRUBBISH", "GARBODOR", "ZORUA", "ZOROARK", "MINCCINO", "CINCCINO", "GOTHITA", "GOTHORITA", "GOTHITELLE", "SOLOSIS", "DUOSION", "REUNICLUS", "DUCKLETT", "SWANNA", "VANILLITE", "VANILLISH", "VANILLUXE", "DEERLING", "SAWSBUCK", "EMOLGA", "KARRABLAST", "ESCAVALIER", "FOONGUS", "AMOONGUSS", "FRILLISH", "JELLICENT", "ALOMOMOLA", "JOLTIK", "GALVANTULA", "FERROSEED", "FERROTHORN", "KLINK", "KLANG", "KLINKLANG", "TYNAMO", "EELEKTRIK", "EELEKTROSS", "ELGYEM", "BEHEEYEM", "LITWICK", "LAMPENT", "CHANDELURE", "AXEW", "FRAXURE", "HAXORUS", "CUBCHOO", "BEARTIC", "CRYOGONAL", "SHELMET", "ACCELGOR", "STUNFISK", "MIENFOO", "MIENSHAO", "DRUDDIGON", "GOLETT", "GOLURK", "PAWNIARD", "BISHARP", "BOUFFALANT", "RUFFLET", "BRAVIARY", "VULLABY", "MANDIBUZZ", "HEATMOR", "DURANT", "DEINO", "ZWEILOUS", "HYDREIGON", "LARVESTA", "VOLCARONA", "COBALION", "TERRAKION", "VIRIZION", "TORNADUS", "THUNDURUS", "RESHIRAM", "ZEKROM", "LANDORUS", "KYUREM", "KELDEO", "MELOETTA", "GENESECT", "CHESPIN", "QUILLADIN", "CHESNAUGHT", "FENNEKIN", "BRAIXEN", "DELPHOX", "FROAKIE", "FROGADIER", "GRENINJA", "BUNNELBY", "DIGGERSBY", "FLETCHLING", "FLETCHINDER", "TALONFLAME", "SCATTERBUG", "SPEWPA", "VIVILLON", "LITLEO", "PYROAR", "FLABEBE", "FLOETTE", "FLORGES", "SKIDDO", "GOGOAT", "PANCHAM", "PANGORO", "FURFROU", "ESPURR", "MEOWSTIC", "HONEDGE", "DOUBLADE", "AEGISLASH", "SPRITZEE", "AROMATISSE", "SWIRLIX", "SLURPUFF", "INKAY", "MALAMAR", "BINACLE", "BARBARACLE", "SKRELP", "DRAGALGE", "CLAUNCHER", "CLAWITZER", "HELIOPTILE", "HELIOLISK", "TYRUNT", "TYRANTRUM", "AMAURA", "AURORUS", "SYLVEON", "HAWLUCHA", "DEDENNE", "CARBINK", "GOOMY", "SLIGGOO", "GOODRA", "KLEFKI", "PHANTUMP", "TREVENANT", "PUMPKABOO", "GOURGEIST", "BERGMITE", "AVALUGG", "NOIBAT", "NOIVERN", "XERNEAS", "YVELTAL", "ZYGARDE", "DIANCIE", "HOOPA", "VOLCANION", "ROWLET", "DARTRIX", "DECIDUEYE", "LITTEN", "TORRACAT", "INCINEROAR", "POPPLIO", "BRIONNE", "PRIMARINA", "PIKIPEK", "TRUMBEAK", "TOUCANNON", "YUNGOOS", "GUMSHOOS", "GRUBBIN", "CHARJABUG", "VIKAVOLT", "CRABRAWLER", "CRABOMINABLE", "ORICORIO", "CUTIEFLY", "RIBOMBEE", "ROCKRUFF", "LYCANROC", "WISHIWASHI", "MAREANIE", "TOXAPEX", "MUDBRAY", "MUDSDALE", "DEWPIDER", "ARAQUANID", "FOMANTIS", "LURANTIS", "MORELULL", "SHIINOTIC", "SALANDIT", "SALAZZLE", "STUFFUL", "BEWEAR", "BOUNSWEET", "STEENEE", "TSAREENA", "COMFEY", "ORANGURU", "PASSIMIAN", "WIMPOD", "GOLISOPOD", "SANDYGAST", "PALOSSAND", "PYUKUMUKU", "TYPENULL", "SILVALLY", "MINIOR", "KOMALA", "TURTONATOR", "TOGEDEMARU", "MIMIKYU", "BRUXISH", "DRAMPA", "DHELMISE", "JANGMO-O", "HAKAMO-O", "KOMMO-O", "TAPUKOKO", "TAPULELE", "TAPUBULU", "TAPUFINI", "COSMOG", "COSMOEM", "SOLGALEO", "LUNALA", "NIHILEGO", "BUZZWOLE", "PHEROMOSA", "XURKITREE", "CELESTEELA", "KARTANA", "GUZZLORD", "NECROZMA", "MAGEARNA", "MARSHADOW", "POIPOLE", "NAGANADEL", "STAKATAKA", "BLACEPHALON", "ZERAORA", "MELTAN", "MELMETAL", "GROOKEY", "THWACKEY", "RILLABOOM", "SCORBUNNY", "RABOOT", "CINDERACE", "SOBBLE", "DRIZZILE", "INTELEON", "SKWOVET", "GREEDENT", "ROOKIDEE", "CORVISQUIRE", "CORVIKNIGHT", "BLIPBUG", "DOTTLER", "ORBEETLE", "NICKIT", "THIEVUL", "GOSSIFLEUR", "ELDEGOSS", "WOOLOO", "DUBWOOL", "CHEWTLE", "DREDNAW", "YAMPER", "BOLTUND", "ROLYCOLY", "CARKOL", "COALOSSAL", "APPLIN", "FLAPPLE", "APPLETUN", "SILICOBRA", "SANDACONDA", "CRAMORANT", "ARROKUDA", "BARRASKEWDA", "TOXEL", "TOXTRICITY", "SIZZLIPEDE", "CENTISKORCH", "CLOBBOPUS", "GRAPPLOCT", "SINISTEA", "POLTEAGEIST", "HATENNA", "HATTREM", "HATTERENE", "IMPIDIMP", "MORGREM", "GRIMMSNARL", "OBSTAGOON", "PERRSERKER", "CURSOLA", "SIRFETCHD", "MRRIME", "RUNERIGUS", "MILCERY", "ALCREMIE", "FALINKS", "PINCURCHIN", "SNOM", "FROSMOTH", "STONJOURNER", "EISCUE", "INDEEDEE", "MORPEKO", "CUFANT", "COPPERAJAH", "DRACOZOLT", "ARCTOZOLT", "DRACOVISH", "ARCTOVISH", "DURALUDON", "DREEPY", "DRAKLOAK", "DRAGAPULT", "ZACIAN", "ZAMAZENTA", "ETERNATUS", "KUBFU", "URSHIFU", "ZARUDE", "REGIELEKI", "REGIDRAGO", "GLASTRIER", "SPECTRIER", "CALYREX"})
        pokemon2Name_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon2Name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon2Name_txt.Location = New Point(6, 37)
        pokemon2Name_txt.Name = "pokemon2Name_txt"
        pokemon2Name_txt.PlaceholderText = "Bulbasaur"
        pokemon2Name_txt.Size = New Size(140, 23)
        pokemon2Name_txt.TabIndex = 32
        ' 
        ' pokemon2IVs_grp
        ' 
        pokemon2IVs_grp.Controls.Add(pokemon2RandomIVs_btn)
        pokemon2IVs_grp.Controls.Add(pokemon2MaxIVs_btn)
        pokemon2IVs_grp.Controls.Add(pokemon2IVsDEF_txt)
        pokemon2IVs_grp.Controls.Add(pokemon2IVsDEF_lbl)
        pokemon2IVs_grp.Controls.Add(pokemon2IVsSPDEF_txt)
        pokemon2IVs_grp.Controls.Add(pokemon2IVsSPDEF_lbl)
        pokemon2IVs_grp.Controls.Add(pokemon2IVsSPATK_txt)
        pokemon2IVs_grp.Controls.Add(pokemon2IVsSPATK_lbl)
        pokemon2IVs_grp.Controls.Add(pokemon2IVsSPD_txt)
        pokemon2IVs_grp.Controls.Add(pokemon2IVsSPD_lbl)
        pokemon2IVs_grp.Controls.Add(pokemon2IVsATK_txt)
        pokemon2IVs_grp.Controls.Add(pokemon2IVsATK_lbl)
        pokemon2IVs_grp.Controls.Add(pokemon2IVsHP_txt)
        pokemon2IVs_grp.Controls.Add(pokemon2IVsHP_lbl)
        pokemon2IVs_grp.Location = New Point(204, 154)
        pokemon2IVs_grp.Name = "pokemon2IVs_grp"
        pokemon2IVs_grp.Size = New Size(114, 188)
        pokemon2IVs_grp.TabIndex = 53
        pokemon2IVs_grp.TabStop = False
        pokemon2IVs_grp.Text = "IVs (Max 31 Each)"
        ' 
        ' pokemon2RandomIVs_btn
        ' 
        pokemon2RandomIVs_btn.Location = New Point(57, 152)
        pokemon2RandomIVs_btn.Name = "pokemon2RandomIVs_btn"
        pokemon2RandomIVs_btn.Size = New Size(44, 23)
        pokemon2RandomIVs_btn.TabIndex = 15
        pokemon2RandomIVs_btn.Text = "Rand"
        pokemon2RandomIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon2MaxIVs_btn
        ' 
        pokemon2MaxIVs_btn.Location = New Point(7, 152)
        pokemon2MaxIVs_btn.Name = "pokemon2MaxIVs_btn"
        pokemon2MaxIVs_btn.Size = New Size(44, 23)
        pokemon2MaxIVs_btn.TabIndex = 14
        pokemon2MaxIVs_btn.Text = "Max"
        pokemon2MaxIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon2IVsDEF_txt
        ' 
        pokemon2IVsDEF_txt.Location = New Point(7, 123)
        pokemon2IVsDEF_txt.MaxLength = 3
        pokemon2IVsDEF_txt.Name = "pokemon2IVsDEF_txt"
        pokemon2IVsDEF_txt.Size = New Size(44, 23)
        pokemon2IVsDEF_txt.TabIndex = 13
        pokemon2IVsDEF_txt.Text = "0"
        ' 
        ' pokemon2IVsDEF_lbl
        ' 
        pokemon2IVsDEF_lbl.AutoSize = True
        pokemon2IVsDEF_lbl.Location = New Point(18, 105)
        pokemon2IVsDEF_lbl.Name = "pokemon2IVsDEF_lbl"
        pokemon2IVsDEF_lbl.Size = New Size(27, 15)
        pokemon2IVsDEF_lbl.TabIndex = 12
        pokemon2IVsDEF_lbl.Text = "DEF"
        ' 
        ' pokemon2IVsSPDEF_txt
        ' 
        pokemon2IVsSPDEF_txt.Location = New Point(57, 123)
        pokemon2IVsSPDEF_txt.MaxLength = 3
        pokemon2IVsSPDEF_txt.Name = "pokemon2IVsSPDEF_txt"
        pokemon2IVsSPDEF_txt.Size = New Size(44, 23)
        pokemon2IVsSPDEF_txt.TabIndex = 9
        pokemon2IVsSPDEF_txt.Text = "0"
        ' 
        ' pokemon2IVsSPDEF_lbl
        ' 
        pokemon2IVsSPDEF_lbl.AutoSize = True
        pokemon2IVsSPDEF_lbl.Location = New Point(59, 105)
        pokemon2IVsSPDEF_lbl.Name = "pokemon2IVsSPDEF_lbl"
        pokemon2IVsSPDEF_lbl.Size = New Size(40, 15)
        pokemon2IVsSPDEF_lbl.TabIndex = 8
        pokemon2IVsSPDEF_lbl.Text = "SPDEF"
        ' 
        ' pokemon2IVsSPATK_txt
        ' 
        pokemon2IVsSPATK_txt.Location = New Point(57, 79)
        pokemon2IVsSPATK_txt.MaxLength = 3
        pokemon2IVsSPATK_txt.Name = "pokemon2IVsSPATK_txt"
        pokemon2IVsSPATK_txt.Size = New Size(44, 23)
        pokemon2IVsSPATK_txt.TabIndex = 7
        pokemon2IVsSPATK_txt.Text = "0"
        ' 
        ' pokemon2IVsSPATK_lbl
        ' 
        pokemon2IVsSPATK_lbl.AutoSize = True
        pokemon2IVsSPATK_lbl.Location = New Point(59, 61)
        pokemon2IVsSPATK_lbl.Name = "pokemon2IVsSPATK_lbl"
        pokemon2IVsSPATK_lbl.Size = New Size(39, 15)
        pokemon2IVsSPATK_lbl.TabIndex = 6
        pokemon2IVsSPATK_lbl.Text = "SPATK"
        ' 
        ' pokemon2IVsSPD_txt
        ' 
        pokemon2IVsSPD_txt.Location = New Point(57, 35)
        pokemon2IVsSPD_txt.MaxLength = 3
        pokemon2IVsSPD_txt.Name = "pokemon2IVsSPD_txt"
        pokemon2IVsSPD_txt.Size = New Size(44, 23)
        pokemon2IVsSPD_txt.TabIndex = 5
        pokemon2IVsSPD_txt.Text = "0"
        ' 
        ' pokemon2IVsSPD_lbl
        ' 
        pokemon2IVsSPD_lbl.AutoSize = True
        pokemon2IVsSPD_lbl.Location = New Point(65, 17)
        pokemon2IVsSPD_lbl.Name = "pokemon2IVsSPD_lbl"
        pokemon2IVsSPD_lbl.Size = New Size(28, 15)
        pokemon2IVsSPD_lbl.TabIndex = 4
        pokemon2IVsSPD_lbl.Text = "SPD"
        ' 
        ' pokemon2IVsATK_txt
        ' 
        pokemon2IVsATK_txt.Location = New Point(7, 79)
        pokemon2IVsATK_txt.MaxLength = 3
        pokemon2IVsATK_txt.Name = "pokemon2IVsATK_txt"
        pokemon2IVsATK_txt.Size = New Size(44, 23)
        pokemon2IVsATK_txt.TabIndex = 3
        pokemon2IVsATK_txt.Text = "0"
        ' 
        ' pokemon2IVsATK_lbl
        ' 
        pokemon2IVsATK_lbl.AutoSize = True
        pokemon2IVsATK_lbl.Location = New Point(18, 61)
        pokemon2IVsATK_lbl.Name = "pokemon2IVsATK_lbl"
        pokemon2IVsATK_lbl.Size = New Size(27, 15)
        pokemon2IVsATK_lbl.TabIndex = 2
        pokemon2IVsATK_lbl.Text = "ATK"
        ' 
        ' pokemon2IVsHP_txt
        ' 
        pokemon2IVsHP_txt.Location = New Point(7, 35)
        pokemon2IVsHP_txt.MaxLength = 3
        pokemon2IVsHP_txt.Name = "pokemon2IVsHP_txt"
        pokemon2IVsHP_txt.Size = New Size(44, 23)
        pokemon2IVsHP_txt.TabIndex = 1
        pokemon2IVsHP_txt.Text = "0"
        ' 
        ' pokemon2IVsHP_lbl
        ' 
        pokemon2IVsHP_lbl.AutoSize = True
        pokemon2IVsHP_lbl.Location = New Point(18, 19)
        pokemon2IVsHP_lbl.Name = "pokemon2IVsHP_lbl"
        pokemon2IVsHP_lbl.Size = New Size(23, 15)
        pokemon2IVsHP_lbl.TabIndex = 0
        pokemon2IVsHP_lbl.Text = "HP"
        ' 
        ' pokemon2HeldItem_txt
        ' 
        pokemon2HeldItem_txt.Location = New Point(152, 37)
        pokemon2HeldItem_txt.Name = "pokemon2HeldItem_txt"
        pokemon2HeldItem_txt.PlaceholderText = "FocusSash"
        pokemon2HeldItem_txt.Size = New Size(140, 23)
        pokemon2HeldItem_txt.TabIndex = 33
        ' 
        ' pokemon2PokeballID_cmb
        ' 
        pokemon2PokeballID_cmb.FormattingEnabled = True
        pokemon2PokeballID_cmb.Items.AddRange(New Object() {"POKEBALL", "GREATBALL", "SAFARIBALL", "ULTRABALL", "MASTERBALL", "NETBALL", "DIVEBALL", "NESTBALL", "REPEATBALL", "TIMERBALL", "LUXURYBALL", "PREMIERBALL", "DUSKBALL", "HEALBALL", "QUICKBALL", "CHERISHBALL", "FASTBALL", "LEVELBALL", "LUREBALL", "HEAVYBALL", "LOVEBALL", "FRIENDBALL", "MOONBALL", "SPORTBALL", "DREAMBALL", "BEASTBALL"})
        pokemon2PokeballID_cmb.Location = New Point(6, 169)
        pokemon2PokeballID_cmb.Name = "pokemon2PokeballID_cmb"
        pokemon2PokeballID_cmb.Size = New Size(140, 23)
        pokemon2PokeballID_cmb.TabIndex = 52
        ' 
        ' pokemon2HeldItem_lbl
        ' 
        pokemon2HeldItem_lbl.AutoSize = True
        pokemon2HeldItem_lbl.Location = New Point(152, 19)
        pokemon2HeldItem_lbl.Name = "pokemon2HeldItem_lbl"
        pokemon2HeldItem_lbl.Size = New Size(59, 15)
        pokemon2HeldItem_lbl.TabIndex = 34
        pokemon2HeldItem_lbl.Text = "Held Item"
        ' 
        ' pokemon2PokeBall_lbl
        ' 
        pokemon2PokeBall_lbl.AutoSize = True
        pokemon2PokeBall_lbl.Location = New Point(8, 151)
        pokemon2PokeBall_lbl.Name = "pokemon2PokeBall_lbl"
        pokemon2PokeBall_lbl.Size = New Size(52, 15)
        pokemon2PokeBall_lbl.TabIndex = 51
        pokemon2PokeBall_lbl.Text = "PokéBall"
        ' 
        ' pokemon2Level_lbl
        ' 
        pokemon2Level_lbl.AutoSize = True
        pokemon2Level_lbl.Location = New Point(298, 19)
        pokemon2Level_lbl.Name = "pokemon2Level_lbl"
        pokemon2Level_lbl.Size = New Size(34, 15)
        pokemon2Level_lbl.TabIndex = 35
        pokemon2Level_lbl.Text = "Level"
        ' 
        ' pokemon2Nickname_txt
        ' 
        pokemon2Nickname_txt.Location = New Point(298, 125)
        pokemon2Nickname_txt.Name = "pokemon2Nickname_txt"
        pokemon2Nickname_txt.PlaceholderText = "Bloom"
        pokemon2Nickname_txt.Size = New Size(140, 23)
        pokemon2Nickname_txt.TabIndex = 50
        ' 
        ' pokemon2Nickname_lbl
        ' 
        pokemon2Nickname_lbl.AutoSize = True
        pokemon2Nickname_lbl.Location = New Point(298, 107)
        pokemon2Nickname_lbl.Name = "pokemon2Nickname_lbl"
        pokemon2Nickname_lbl.Size = New Size(61, 15)
        pokemon2Nickname_lbl.TabIndex = 49
        pokemon2Nickname_lbl.Text = "Nickname"
        ' 
        ' pokemon2Moves_grp
        ' 
        pokemon2Moves_grp.Controls.Add(pokemon2Move4_txtBox)
        pokemon2Moves_grp.Controls.Add(pokemon2Move3_txtBox)
        pokemon2Moves_grp.Controls.Add(pokemon2Move2_txtBox)
        pokemon2Moves_grp.Controls.Add(pokemon2Move1_txtBox)
        pokemon2Moves_grp.Location = New Point(444, 22)
        pokemon2Moves_grp.Name = "pokemon2Moves_grp"
        pokemon2Moves_grp.Size = New Size(273, 82)
        pokemon2Moves_grp.TabIndex = 37
        pokemon2Moves_grp.TabStop = False
        pokemon2Moves_grp.Text = "Moves"
        ' 
        ' pokemon2Move4_txtBox
        ' 
        pokemon2Move4_txtBox.Location = New Point(132, 51)
        pokemon2Move4_txtBox.Name = "pokemon2Move4_txtBox"
        pokemon2Move4_txtBox.PlaceholderText = "Move 4"
        pokemon2Move4_txtBox.Size = New Size(120, 23)
        pokemon2Move4_txtBox.TabIndex = 3
        ' 
        ' pokemon2Move3_txtBox
        ' 
        pokemon2Move3_txtBox.Location = New Point(6, 51)
        pokemon2Move3_txtBox.Name = "pokemon2Move3_txtBox"
        pokemon2Move3_txtBox.PlaceholderText = "Move 3"
        pokemon2Move3_txtBox.Size = New Size(120, 23)
        pokemon2Move3_txtBox.TabIndex = 2
        ' 
        ' pokemon2Move2_txtBox
        ' 
        pokemon2Move2_txtBox.Location = New Point(132, 22)
        pokemon2Move2_txtBox.Name = "pokemon2Move2_txtBox"
        pokemon2Move2_txtBox.PlaceholderText = "Move 2"
        pokemon2Move2_txtBox.Size = New Size(120, 23)
        pokemon2Move2_txtBox.TabIndex = 1
        ' 
        ' pokemon2Move1_txtBox
        ' 
        pokemon2Move1_txtBox.Location = New Point(6, 22)
        pokemon2Move1_txtBox.Name = "pokemon2Move1_txtBox"
        pokemon2Move1_txtBox.PlaceholderText = "Move 1"
        pokemon2Move1_txtBox.Size = New Size(120, 23)
        pokemon2Move1_txtBox.TabIndex = 0
        ' 
        ' pokemon2Ability_lbl
        ' 
        pokemon2Ability_lbl.AutoSize = True
        pokemon2Ability_lbl.Location = New Point(6, 63)
        pokemon2Ability_lbl.Name = "pokemon2Ability_lbl"
        pokemon2Ability_lbl.Size = New Size(41, 15)
        pokemon2Ability_lbl.TabIndex = 38
        pokemon2Ability_lbl.Text = "Ability"
        ' 
        ' pokemon2Happiness_lbl
        ' 
        pokemon2Happiness_lbl.AutoSize = True
        pokemon2Happiness_lbl.Location = New Point(152, 107)
        pokemon2Happiness_lbl.Name = "pokemon2Happiness_lbl"
        pokemon2Happiness_lbl.Size = New Size(62, 15)
        pokemon2Happiness_lbl.TabIndex = 47
        pokemon2Happiness_lbl.Text = "Happiness"
        ' 
        ' pokemon2Ability_cmb
        ' 
        pokemon2Ability_cmb.AutoCompleteCustomSource.AddRange(New String() {"Aerilate", "Aftermath", "Air Lock", "Analytic", "Anger Point", "Anger Shell", "Anticipation", "Arena Trap", "Armor Tail", "Aroma Veil", "As One - Unnerve Chilling Neigh", "As One - Unnerve Grim Neigh", "Aura Break", "Bad Dreams", "Ball Fetch", "Battery", "Battle Armor", "Battle Bond", "Beads of Ruin", "Beast Boost", "Berserk", "Big Pecks", "Blaze", "Bulletproof", "Cheek Pouch", "Chilling Neigh", "Chlorophyll", "Clear Body", "Cloud Nine", "Color Change", "Comatose", "Commander", "Competitive", "Compoundeyes", "Contrary", "Corrosion", "Costar", "Cotton Down", "Cud Chew", "Curious Medicine", "Cursed Body", "Cute Charm", "Damp", "Dancer", "Dark Aura", "Dauntless Shield", "Dazzling", "Defeatist", "Defiant", "Delta Stream", "Desolate Land", "Disguise", "Download", "Dragon's Maw", "Drizzle", "Drought", "Dry Skin", "Early Bird", "Earth Eater", "Effect Spore", "Electric Surge", "Electromorphosis", "Embody Aspect - Cornerstone Mask", "Embody Aspect - Hearthflame Mask", "Embody Aspect - Teal Mask", "Embody Aspect - Wellspring Mask", "Emergency Exit", "Fairy Aura", "Filter", "Flame Body", "Flare Boost", "Flash Fire", "Flower Gift", "Flower Veil", "Fluffy", "Forecast", "Forewarn", "Friend Guard", "Frisk", "Full Metal Body", "Fur Coat", "Gale Wings", "Galvanize", "Gluttony", "Good as Gold", "Gooey", "Gorilla Tactics", "Grass Pelt", "Grassy Surge", "Grim Neigh", "Guard Dog", "Gulp Missile", "Guts", "Hadron Engine", "Harvest", "Healer", "Heatproof", "Heavy Metal", "Honey Gather", "Hospitality", "Huge Power", "Hunger Switch", "Hustle", "Hydration", "Hyper Cutter", "Ice Body", "Ice Face", "Ice Scales", "Illuminate", "Illusion", "Immunity", "Imposter", "Infiltrator", "Innards Out", "Inner Focus", "Insomnia", "Intimidate", "Intrepid Sword", "Iron Barbs", "Iron Fist", "Justified", "Keen Eye", "Klutz", "Leaf Guard", "Levitate", "Libero", "Light Metal", "Lightning Rod", "Limber", "Lingering Aroma", "Liquid Ooze", "Liquid Voice", "Long Reach", "Magic Bounce", "Magic Guard", "Magician", "Magma Armor", "Magnet Pull", "Marvel Scale", "Mega Launcher", "Merciless", "Mimicry", "Mind's Eye", "Minus", "Mirror Armor", "Misty Surge", "Mold Breaker", "Moody", "Motor Drive", "Moxie", "Multiscale", "Multitype", "Mummy", "Mycelium Might", "Natural Cure", "Neuroforce", "Neutralizing Gas", "No Guard", "Normalize", "Oblivious", "Opportunist", "Orichalcum Pulse", "Overcoat", "Overgrow", "Own Tempo", "Parental Bond", "Pastel Veil", "Perish Body", "Pickpocket", "Pickup", "Pixilate", "Plus", "Poison Heal", "Poison Point", "Poison Touch", "Power Construct", "Power of Alchemy", "Power Spot", "Prankster", "Pressure", "Primordial Sea", "Prism Armor", "Propeller Tail", "Protean", "Protosynthesis", "Psychic Surge", "Punk Rock", "Pure Power", "Purifying Salt", "Quark Drive", "Queenly Majesty", "Quick Draw", "Quick Feet", "Rain Dish", "Rattled", "Receiver", "Reckless", "Refrigerate", "Regenerator", "Ripen", "Rivalry", "RKS System", "Rock Head", "Rocky Payload", "Rough Skin", "Run Away", "Sand Force", "Sand Rush", "Sand Spit", "Sand Stream", "Sand Veil", "Sap Sipper", "Schooling", "Scrappy", "Screen Cleaner", "Seed Sower", "Serene Grace", "Shadow Shield", "Shadow Tag", "Sharpness", "Shed Skin", "Sheer Force", "Shell Armor", "Shield Dust", "Shields Down", "Simple", "Skill Link", "Slow Start", "Slush Rush", "Sniper", "Snow Cloak", "Snow Warning", "Solar Power", "Solid Rock", "Soul-Heart", "Soundproof", "Speed Boost", "Stakeout", "Stall", "Stalwart", "Stamina", "Stance Change", "Static", "Steadfast", "Steam Engine", "Steelworker", "Steely Spirit", "Stench", "Sticky Hold", "Storm Drain", "Strong Jaw", "Sturdy", "Suction Cups", "Super Luck", "Supersweet Syrup", "Supreme Overlord", "Surge Surfer", "Swarm", "Sweet Veil", "Swift Swim", "Sword of Ruin", "Symbiosis", "Synchronize", "Tablets of Ruin", "Tangled Feet", "Tangling Hair", "Technician", "Telepathy", "Teravolt", "Thermal Exchange", "Thick Fat", "Tinted Lens", "Torrent", "Tough Claws", "Toxic Boost", "Toxic Chain", "Toxic Debris", "Trace", "Transistor", "Triage", "Truant", "Turboblaze", "Unaware", "Unburden", "Unnerve", "Unseen Fist", "Vessel of Ruin", "Victory Star", "Vital Spirit", "Volt Absorb", "Wandering Spirit", "Water Absorb", "Water Bubble", "Water Compaction", "Water Veil", "Weak Armor", "Well-Baked Body", "White Smoke", "Wimp Out", "Wind Power", "Wind Rider", "Wonder Guard", "Wonder Skin ", "Zen Mode", "Zero to Hero"})
        pokemon2Ability_cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon2Ability_cmb.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon2Ability_cmb.FormattingEnabled = True
        pokemon2Ability_cmb.Items.AddRange(New Object() {"Aerilate", "Aftermath", "Air Lock", "Analytic", "Anger Point", "Anger Shell", "Anticipation", "Arena Trap", "Armor Tail", "Aroma Veil", "As One - Unnerve Chilling Neigh", "As One - Unnerve Grim Neigh", "Aura Break", "Bad Dreams", "Ball Fetch", "Battery", "Battle Armor", "Battle Bond", "Beads of Ruin", "Beast Boost", "Berserk", "Big Pecks", "Blaze", "Bulletproof", "Cheek Pouch", "Chilling Neigh", "Chlorophyll", "Clear Body", "Cloud Nine", "Color Change", "Comatose", "Commander", "Competitive", "Compoundeyes", "Contrary", "Corrosion", "Costar", "Cotton Down", "Cud Chew", "Curious Medicine", "Cursed Body", "Cute Charm", "Damp", "Dancer", "Dark Aura", "Dauntless Shield", "Dazzling", "Defeatist", "Defiant", "Delta Stream", "Desolate Land", "Disguise", "Download", "Dragon's Maw", "Drizzle", "Drought", "Dry Skin", "Early Bird", "Earth Eater", "Effect Spore", "Electric Surge", "Electromorphosis", "Embody Aspect - Cornerstone Mask", "Embody Aspect - Hearthflame Mask", "Embody Aspect - Teal Mask", "Embody Aspect - Wellspring Mask", "Emergency Exit", "Fairy Aura", "Filter", "Flame Body", "Flare Boost", "Flash Fire", "Flower Gift", "Flower Veil", "Fluffy", "Forecast", "Forewarn", "Friend Guard", "Frisk", "Full Metal Body", "Fur Coat", "Gale Wings", "Galvanize", "Gluttony", "Good as Gold", "Gooey", "Gorilla Tactics", "Grass Pelt", "Grassy Surge", "Grim Neigh", "Guard Dog", "Gulp Missile", "Guts", "Hadron Engine", "Harvest", "Healer", "Heatproof", "Heavy Metal", "Honey Gather", "Hospitality", "Huge Power", "Hunger Switch", "Hustle", "Hydration", "Hyper Cutter", "Ice Body", "Ice Face", "Ice Scales", "Illuminate", "Illusion", "Immunity", "Imposter", "Infiltrator", "Innards Out", "Inner Focus", "Insomnia", "Intimidate", "Intrepid Sword", "Iron Barbs", "Iron Fist", "Justified", "Keen Eye", "Klutz", "Leaf Guard", "Levitate", "Libero", "Light Metal", "Lightning Rod", "Limber", "Lingering Aroma", "Liquid Ooze", "Liquid Voice", "Long Reach", "Magic Bounce", "Magic Guard", "Magician", "Magma Armor", "Magnet Pull", "Marvel Scale", "Mega Launcher", "Merciless", "Mimicry", "Mind's Eye", "Minus", "Mirror Armor", "Misty Surge", "Mold Breaker", "Moody", "Motor Drive", "Moxie", "Multiscale", "Multitype", "Mummy", "Mycelium Might", "Natural Cure", "Neuroforce", "Neutralizing Gas", "No Guard", "Normalize", "Oblivious", "Opportunist", "Orichalcum Pulse", "Overcoat", "Overgrow", "Own Tempo", "Parental Bond", "Pastel Veil", "Perish Body", "Pickpocket", "Pickup", "Pixilate", "Plus", "Poison Heal", "Poison Point", "Poison Touch", "Power Construct", "Power of Alchemy", "Power Spot", "Prankster", "Pressure", "Primordial Sea", "Prism Armor", "Propeller Tail", "Protean", "Protosynthesis", "Psychic Surge", "Punk Rock", "Pure Power", "Purifying Salt", "Quark Drive", "Queenly Majesty", "Quick Draw", "Quick Feet", "Rain Dish", "Rattled", "Receiver", "Reckless", "Refrigerate", "Regenerator", "Ripen", "Rivalry", "RKS System", "Rock Head", "Rocky Payload", "Rough Skin", "Run Away", "Sand Force", "Sand Rush", "Sand Spit", "Sand Stream", "Sand Veil", "Sap Sipper", "Schooling", "Scrappy", "Screen Cleaner", "Seed Sower", "Serene Grace", "Shadow Shield", "Shadow Tag", "Sharpness", "Shed Skin", "Sheer Force", "Shell Armor", "Shield Dust", "Shields Down", "Simple", "Skill Link", "Slow Start", "Slush Rush", "Sniper", "Snow Cloak", "Snow Warning", "Solar Power", "Solid Rock", "Soul-Heart", "Soundproof", "Speed Boost", "Stakeout", "Stall", "Stalwart", "Stamina", "Stance Change", "Static", "Steadfast", "Steam Engine", "Steelworker", "Steely Spirit", "Stench", "Sticky Hold", "Storm Drain", "Strong Jaw", "Sturdy", "Suction Cups", "Super Luck", "Supersweet Syrup", "Supreme Overlord", "Surge Surfer", "Swarm", "Sweet Veil", "Swift Swim", "Sword of Ruin", "Symbiosis", "Synchronize", "Tablets of Ruin", "Tangled Feet", "Tangling Hair", "Technician", "Telepathy", "Teravolt", "Thermal Exchange", "Thick Fat", "Tinted Lens", "Torrent", "Tough Claws", "Toxic Boost", "Toxic Chain", "Toxic Debris", "Trace", "Transistor", "Triage", "Truant", "Turboblaze", "Unaware", "Unburden", "Unnerve", "Unseen Fist", "Vessel of Ruin", "Victory Star", "Vital Spirit", "Volt Absorb", "Wandering Spirit", "Water Absorb", "Water Bubble", "Water Compaction", "Water Veil", "Weak Armor", "Well-Baked Body", "White Smoke", "Wimp Out", "Wind Power", "Wind Rider", "Wonder Guard", "Wonder Skin ", "Zen Mode", "Zero to Hero"})
        pokemon2Ability_cmb.Location = New Point(6, 81)
        pokemon2Ability_cmb.Name = "pokemon2Ability_cmb"
        pokemon2Ability_cmb.Size = New Size(140, 23)
        pokemon2Ability_cmb.TabIndex = 39
        ' 
        ' pokemon2Nature_cmb
        ' 
        pokemon2Nature_cmb.FormattingEnabled = True
        pokemon2Nature_cmb.Items.AddRange(New Object() {"(random)", "HARDY", "LONELY", "BRAVE", "ADAMANT", "NAUGHTY", "BOLD", "DOCILE", "RELAXED", "IMPISH", "LAX", "MODEST", "MILD", "SERIOUS", "QUIET", "RASH", "CALM", "GENTLE", "SASSY", "BASHFUL", "CAREFUL", "TIMID", "HASTY", "JOLLY", "NAIVE", "QUIRKY"})
        pokemon2Nature_cmb.Location = New Point(6, 125)
        pokemon2Nature_cmb.Name = "pokemon2Nature_cmb"
        pokemon2Nature_cmb.Size = New Size(140, 23)
        pokemon2Nature_cmb.TabIndex = 46
        ' 
        ' pokemon2Gender_lbl
        ' 
        pokemon2Gender_lbl.AutoSize = True
        pokemon2Gender_lbl.Location = New Point(152, 63)
        pokemon2Gender_lbl.Name = "pokemon2Gender_lbl"
        pokemon2Gender_lbl.Size = New Size(45, 15)
        pokemon2Gender_lbl.TabIndex = 40
        pokemon2Gender_lbl.Text = "Gender"
        ' 
        ' pokemon2Nature_lbl
        ' 
        pokemon2Nature_lbl.AutoSize = True
        pokemon2Nature_lbl.Location = New Point(6, 107)
        pokemon2Nature_lbl.Name = "pokemon2Nature_lbl"
        pokemon2Nature_lbl.Size = New Size(43, 15)
        pokemon2Nature_lbl.TabIndex = 45
        pokemon2Nature_lbl.Text = "Nature"
        ' 
        ' pokemon2Gender_cmb
        ' 
        pokemon2Gender_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        pokemon2Gender_cmb.FormattingEnabled = True
        pokemon2Gender_cmb.Items.AddRange(New Object() {"Male", "Female", "Random"})
        pokemon2Gender_cmb.Location = New Point(152, 81)
        pokemon2Gender_cmb.Name = "pokemon2Gender_cmb"
        pokemon2Gender_cmb.Size = New Size(140, 23)
        pokemon2Gender_cmb.TabIndex = 41
        ' 
        ' pokemon2Shiny_grp
        ' 
        pokemon2Shiny_grp.Controls.Add(pokemon2SuperShiny_chkBox)
        pokemon2Shiny_grp.Controls.Add(pokemon2Shiny_rad)
        pokemon2Shiny_grp.Controls.Add(pokemon2NotShiny_rad)
        pokemon2Shiny_grp.Location = New Point(444, 110)
        pokemon2Shiny_grp.Name = "pokemon2Shiny_grp"
        pokemon2Shiny_grp.Size = New Size(273, 82)
        pokemon2Shiny_grp.TabIndex = 44
        pokemon2Shiny_grp.TabStop = False
        pokemon2Shiny_grp.Text = "Shiny"
        ' 
        ' pokemon2SuperShiny_chkBox
        ' 
        pokemon2SuperShiny_chkBox.AutoSize = True
        pokemon2SuperShiny_chkBox.Enabled = False
        pokemon2SuperShiny_chkBox.Location = New Point(66, 47)
        pokemon2SuperShiny_chkBox.Name = "pokemon2SuperShiny_chkBox"
        pokemon2SuperShiny_chkBox.Size = New Size(88, 19)
        pokemon2SuperShiny_chkBox.TabIndex = 2
        pokemon2SuperShiny_chkBox.Text = "Super Shiny"
        pokemon2SuperShiny_chkBox.UseVisualStyleBackColor = True
        ' 
        ' pokemon2Shiny_rad
        ' 
        pokemon2Shiny_rad.AutoSize = True
        pokemon2Shiny_rad.Location = New Point(6, 47)
        pokemon2Shiny_rad.Name = "pokemon2Shiny_rad"
        pokemon2Shiny_rad.Size = New Size(54, 19)
        pokemon2Shiny_rad.TabIndex = 1
        pokemon2Shiny_rad.Text = "Shiny"
        pokemon2Shiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon2NotShiny_rad
        ' 
        pokemon2NotShiny_rad.AutoSize = True
        pokemon2NotShiny_rad.Checked = True
        pokemon2NotShiny_rad.Location = New Point(6, 22)
        pokemon2NotShiny_rad.Name = "pokemon2NotShiny_rad"
        pokemon2NotShiny_rad.Size = New Size(77, 19)
        pokemon2NotShiny_rad.TabIndex = 0
        pokemon2NotShiny_rad.TabStop = True
        pokemon2NotShiny_rad.Text = "Not Shiny"
        pokemon2NotShiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon2Form_lbl
        ' 
        pokemon2Form_lbl.AutoSize = True
        pokemon2Form_lbl.Location = New Point(298, 63)
        pokemon2Form_lbl.Name = "pokemon2Form_lbl"
        pokemon2Form_lbl.Size = New Size(35, 15)
        pokemon2Form_lbl.TabIndex = 42
        pokemon2Form_lbl.Text = "Form"
        ' 
        ' pg_pkmn3
        ' 
        pg_pkmn3.Controls.Add(pokemon3_grp)
        pg_pkmn3.Location = New Point(4, 24)
        pg_pkmn3.Name = "pg_pkmn3"
        pg_pkmn3.Padding = New Padding(3)
        pg_pkmn3.Size = New Size(729, 475)
        pg_pkmn3.TabIndex = 4
        pg_pkmn3.Text = "Pokémon 3"
        pg_pkmn3.UseVisualStyleBackColor = True
        ' 
        ' pokemon3_grp
        ' 
        pokemon3_grp.Controls.Add(pokemon3Level_nbr)
        pokemon3_grp.Controls.Add(pokemon3Form_nbr)
        pokemon3_grp.Controls.Add(pokemon3Happiness_nbr)
        pokemon3_grp.Controls.Add(pokemon3Shadow_grp)
        pokemon3_grp.Controls.Add(pokemon3Name_lbl)
        pokemon3_grp.Controls.Add(pokemon3EVs_grp)
        pokemon3_grp.Controls.Add(pokemon3Name_txt)
        pokemon3_grp.Controls.Add(pokemon3IVs_grp)
        pokemon3_grp.Controls.Add(pokemon3HeldItem_txt)
        pokemon3_grp.Controls.Add(pokemon3PokeballID_cmb)
        pokemon3_grp.Controls.Add(pokemon3HeldItem_lbl)
        pokemon3_grp.Controls.Add(pokemon3PokeBall_lbl)
        pokemon3_grp.Controls.Add(pokemon3Level_lbl)
        pokemon3_grp.Controls.Add(pokemon3Nickname_txt)
        pokemon3_grp.Controls.Add(pokemon3Nickname_lbl)
        pokemon3_grp.Controls.Add(pokemon3Moves_grp)
        pokemon3_grp.Controls.Add(pokemon3Ability_lbl)
        pokemon3_grp.Controls.Add(pokemon3Happiness_lbl)
        pokemon3_grp.Controls.Add(pokemon3Ability_cmb)
        pokemon3_grp.Controls.Add(pokemon3Nature_cmb)
        pokemon3_grp.Controls.Add(pokemon3Gender_lbl)
        pokemon3_grp.Controls.Add(pokemon3Nature_lbl)
        pokemon3_grp.Controls.Add(pokemon3Gender_cmb)
        pokemon3_grp.Controls.Add(pokemon3Shiny_grp)
        pokemon3_grp.Controls.Add(pokemon3Form_lbl)
        pokemon3_grp.Dock = DockStyle.Fill
        pokemon3_grp.Location = New Point(3, 3)
        pokemon3_grp.Name = "pokemon3_grp"
        pokemon3_grp.Size = New Size(723, 469)
        pokemon3_grp.TabIndex = 0
        pokemon3_grp.TabStop = False
        pokemon3_grp.Text = "Pokémon 3"
        ' 
        ' pokemon3Level_nbr
        ' 
        pokemon3Level_nbr.Location = New Point(298, 37)
        pokemon3Level_nbr.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        pokemon3Level_nbr.Name = "pokemon3Level_nbr"
        pokemon3Level_nbr.Size = New Size(140, 23)
        pokemon3Level_nbr.TabIndex = 83
        pokemon3Level_nbr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' pokemon3Form_nbr
        ' 
        pokemon3Form_nbr.Location = New Point(298, 80)
        pokemon3Form_nbr.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        pokemon3Form_nbr.Name = "pokemon3Form_nbr"
        pokemon3Form_nbr.Size = New Size(140, 23)
        pokemon3Form_nbr.TabIndex = 82
        ' 
        ' pokemon3Happiness_nbr
        ' 
        pokemon3Happiness_nbr.Location = New Point(152, 124)
        pokemon3Happiness_nbr.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        pokemon3Happiness_nbr.Name = "pokemon3Happiness_nbr"
        pokemon3Happiness_nbr.Size = New Size(140, 23)
        pokemon3Happiness_nbr.TabIndex = 81
        pokemon3Happiness_nbr.Value = New Decimal(New Integer() {70, 0, 0, 0})
        ' 
        ' pokemon3Shadow_grp
        ' 
        pokemon3Shadow_grp.Controls.Add(pokemon3Shadow_rad)
        pokemon3Shadow_grp.Controls.Add(pokemon3NotShadow_rad)
        pokemon3Shadow_grp.Location = New Point(444, 198)
        pokemon3Shadow_grp.Name = "pokemon3Shadow_grp"
        pokemon3Shadow_grp.Size = New Size(273, 82)
        pokemon3Shadow_grp.TabIndex = 80
        pokemon3Shadow_grp.TabStop = False
        pokemon3Shadow_grp.Text = "Shadow"
        ' 
        ' pokemon3Shadow_rad
        ' 
        pokemon3Shadow_rad.AutoSize = True
        pokemon3Shadow_rad.Location = New Point(6, 47)
        pokemon3Shadow_rad.Name = "pokemon3Shadow_rad"
        pokemon3Shadow_rad.Size = New Size(67, 19)
        pokemon3Shadow_rad.TabIndex = 1
        pokemon3Shadow_rad.Text = "Shadow"
        pokemon3Shadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon3NotShadow_rad
        ' 
        pokemon3NotShadow_rad.AutoSize = True
        pokemon3NotShadow_rad.Checked = True
        pokemon3NotShadow_rad.Location = New Point(6, 22)
        pokemon3NotShadow_rad.Name = "pokemon3NotShadow_rad"
        pokemon3NotShadow_rad.Size = New Size(90, 19)
        pokemon3NotShadow_rad.TabIndex = 0
        pokemon3NotShadow_rad.TabStop = True
        pokemon3NotShadow_rad.Text = "Not Shadow"
        pokemon3NotShadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon3Name_lbl
        ' 
        pokemon3Name_lbl.AutoSize = True
        pokemon3Name_lbl.Location = New Point(6, 19)
        pokemon3Name_lbl.Name = "pokemon3Name_lbl"
        pokemon3Name_lbl.Size = New Size(93, 15)
        pokemon3Name_lbl.TabIndex = 56
        pokemon3Name_lbl.Text = "Pokémon Name"
        ' 
        ' pokemon3EVs_grp
        ' 
        pokemon3EVs_grp.Controls.Add(pokemon3EVsDEF_txt)
        pokemon3EVs_grp.Controls.Add(pokemon3EVsDEF_lbl)
        pokemon3EVs_grp.Controls.Add(pokemon3EVsSPDEF_txt)
        pokemon3EVs_grp.Controls.Add(pokemon3EVsSPDEF_lbl)
        pokemon3EVs_grp.Controls.Add(pokemon3EVsSPATK_txt)
        pokemon3EVs_grp.Controls.Add(pokemon3EVsSPATK_lbl)
        pokemon3EVs_grp.Controls.Add(pokemon3EVsSPD_txt)
        pokemon3EVs_grp.Controls.Add(pokemon3EVsSPD_lbl)
        pokemon3EVs_grp.Controls.Add(pokemon3EVsATK_txt)
        pokemon3EVs_grp.Controls.Add(pokemon3EVsATK_lbl)
        pokemon3EVs_grp.Controls.Add(pokemon3EVsHP_txt)
        pokemon3EVs_grp.Controls.Add(pokemon3EVsHP_lbl)
        pokemon3EVs_grp.Location = New Point(324, 154)
        pokemon3EVs_grp.Name = "pokemon3EVs_grp"
        pokemon3EVs_grp.Size = New Size(114, 156)
        pokemon3EVs_grp.TabIndex = 79
        pokemon3EVs_grp.TabStop = False
        pokemon3EVs_grp.Text = "EVs"
        ' 
        ' pokemon3EVsDEF_txt
        ' 
        pokemon3EVsDEF_txt.Location = New Point(6, 125)
        pokemon3EVsDEF_txt.MaxLength = 3
        pokemon3EVsDEF_txt.Name = "pokemon3EVsDEF_txt"
        pokemon3EVsDEF_txt.Size = New Size(44, 23)
        pokemon3EVsDEF_txt.TabIndex = 11
        pokemon3EVsDEF_txt.Text = "0"
        ' 
        ' pokemon3EVsDEF_lbl
        ' 
        pokemon3EVsDEF_lbl.AutoSize = True
        pokemon3EVsDEF_lbl.Location = New Point(14, 107)
        pokemon3EVsDEF_lbl.Name = "pokemon3EVsDEF_lbl"
        pokemon3EVsDEF_lbl.Size = New Size(27, 15)
        pokemon3EVsDEF_lbl.TabIndex = 10
        pokemon3EVsDEF_lbl.Text = "DEF"
        ' 
        ' pokemon3EVsSPDEF_txt
        ' 
        pokemon3EVsSPDEF_txt.Location = New Point(55, 125)
        pokemon3EVsSPDEF_txt.MaxLength = 3
        pokemon3EVsSPDEF_txt.Name = "pokemon3EVsSPDEF_txt"
        pokemon3EVsSPDEF_txt.Size = New Size(44, 23)
        pokemon3EVsSPDEF_txt.TabIndex = 9
        pokemon3EVsSPDEF_txt.Text = "0"
        ' 
        ' pokemon3EVsSPDEF_lbl
        ' 
        pokemon3EVsSPDEF_lbl.AutoSize = True
        pokemon3EVsSPDEF_lbl.Location = New Point(55, 109)
        pokemon3EVsSPDEF_lbl.Name = "pokemon3EVsSPDEF_lbl"
        pokemon3EVsSPDEF_lbl.Size = New Size(40, 15)
        pokemon3EVsSPDEF_lbl.TabIndex = 8
        pokemon3EVsSPDEF_lbl.Text = "SPDEF"
        ' 
        ' pokemon3EVsSPATK_txt
        ' 
        pokemon3EVsSPATK_txt.Location = New Point(55, 81)
        pokemon3EVsSPATK_txt.MaxLength = 3
        pokemon3EVsSPATK_txt.Name = "pokemon3EVsSPATK_txt"
        pokemon3EVsSPATK_txt.Size = New Size(44, 23)
        pokemon3EVsSPATK_txt.TabIndex = 7
        pokemon3EVsSPATK_txt.Text = "0"
        ' 
        ' pokemon3EVsSPATK_lbl
        ' 
        pokemon3EVsSPATK_lbl.AutoSize = True
        pokemon3EVsSPATK_lbl.Location = New Point(56, 65)
        pokemon3EVsSPATK_lbl.Name = "pokemon3EVsSPATK_lbl"
        pokemon3EVsSPATK_lbl.Size = New Size(39, 15)
        pokemon3EVsSPATK_lbl.TabIndex = 6
        pokemon3EVsSPATK_lbl.Text = "SPATK"
        ' 
        ' pokemon3EVsSPD_txt
        ' 
        pokemon3EVsSPD_txt.Location = New Point(55, 37)
        pokemon3EVsSPD_txt.MaxLength = 3
        pokemon3EVsSPD_txt.Name = "pokemon3EVsSPD_txt"
        pokemon3EVsSPD_txt.Size = New Size(44, 23)
        pokemon3EVsSPD_txt.TabIndex = 5
        pokemon3EVsSPD_txt.Text = "0"
        ' 
        ' pokemon3EVsSPD_lbl
        ' 
        pokemon3EVsSPD_lbl.AutoSize = True
        pokemon3EVsSPD_lbl.Location = New Point(63, 21)
        pokemon3EVsSPD_lbl.Name = "pokemon3EVsSPD_lbl"
        pokemon3EVsSPD_lbl.Size = New Size(28, 15)
        pokemon3EVsSPD_lbl.TabIndex = 4
        pokemon3EVsSPD_lbl.Text = "SPD"
        ' 
        ' pokemon3EVsATK_txt
        ' 
        pokemon3EVsATK_txt.Location = New Point(6, 81)
        pokemon3EVsATK_txt.MaxLength = 3
        pokemon3EVsATK_txt.Name = "pokemon3EVsATK_txt"
        pokemon3EVsATK_txt.Size = New Size(44, 23)
        pokemon3EVsATK_txt.TabIndex = 3
        pokemon3EVsATK_txt.Text = "0"
        ' 
        ' pokemon3EVsATK_lbl
        ' 
        pokemon3EVsATK_lbl.AutoSize = True
        pokemon3EVsATK_lbl.Location = New Point(14, 63)
        pokemon3EVsATK_lbl.Name = "pokemon3EVsATK_lbl"
        pokemon3EVsATK_lbl.Size = New Size(27, 15)
        pokemon3EVsATK_lbl.TabIndex = 2
        pokemon3EVsATK_lbl.Text = "ATK"
        ' 
        ' pokemon3EVsHP_txt
        ' 
        pokemon3EVsHP_txt.Location = New Point(6, 37)
        pokemon3EVsHP_txt.MaxLength = 3
        pokemon3EVsHP_txt.Name = "pokemon3EVsHP_txt"
        pokemon3EVsHP_txt.Size = New Size(44, 23)
        pokemon3EVsHP_txt.TabIndex = 1
        pokemon3EVsHP_txt.Text = "0"
        ' 
        ' pokemon3EVsHP_lbl
        ' 
        pokemon3EVsHP_lbl.AutoSize = True
        pokemon3EVsHP_lbl.Location = New Point(16, 19)
        pokemon3EVsHP_lbl.Name = "pokemon3EVsHP_lbl"
        pokemon3EVsHP_lbl.Size = New Size(23, 15)
        pokemon3EVsHP_lbl.TabIndex = 0
        pokemon3EVsHP_lbl.Text = "HP"
        ' 
        ' pokemon3Name_txt
        ' 
        pokemon3Name_txt.AutoCompleteCustomSource.AddRange(New String() {"BULBASAUR", "IVYSAUR", "VENUSAUR", "CHARMANDER", "CHARMELEON", "CHARIZARD", "SQUIRTLE", "WARTORTLE", "BLASTOISE", "CATERPIE", "METAPOD", "BUTTERFREE", "WEEDLE", "KAKUNA", "BEEDRILL", "PIDGEY", "PIDGEOTTO", "PIDGEOT", "RATTATA", "RATICATE", "SPEAROW", "FEAROW", "EKANS", "ARBOK", "PIKACHU", "RAICHU", "SANDSHREW", "SANDSLASH", "NIDORANfE", "NIDORINA", "NIDOQUEEN", "NIDORANmA", "NIDORINO", "NIDOKING", "CLEFAIRY", "CLEFABLE", "VULPIX", "NINETALES", "JIGGLYPUFF", "WIGGLYTUFF", "ZUBAT", "GOLBAT", "ODDISH", "GLOOM", "VILEPLUME", "PARAS", "PARASECT", "VENONAT", "VENOMOTH", "DIGLETT", "DUGTRIO", "MEOWTH", "PERSIAN", "PSYDUCK", "GOLDUCK", "MANKEY", "PRIMEAPE", "GROWLITHE", "ARCANINE", "POLIWAG", "POLIWHIRL", "POLIWRATH", "ABRA", "KADABRA", "ALAKAZAM", "MACHOP", "MACHOKE", "MACHAMP", "BELLSPROUT", "WEEPINBELL", "VICTREEBEL", "TENTACOOL", "TENTACRUEL", "GEODUDE", "GRAVELER", "GOLEM", "PONYTA", "RAPIDASH", "SLOWPOKE", "SLOWBRO", "MAGNEMITE", "MAGNETON", "FARFETCHD", "DODUO", "DODRIO", "SEEL", "DEWGONG", "GRIMER", "MUK", "SHELLDER", "CLOYSTER", "GASTLY", "HAUNTER", "GENGAR", "ONIX", "DROWZEE", "HYPNO", "KRABBY", "KINGLER", "VOLTORB", "ELECTRODE", "EXEGGCUTE", "EXEGGUTOR", "CUBONE", "MAROWAK", "HITMONLEE", "HITMONCHAN", "LICKITUNG", "KOFFING", "WEEZING", "RHYHORN", "RHYDON", "CHANSEY", "TANGELA", "KANGASKHAN", "HORSEA", "SEADRA", "GOLDEEN", "SEAKING", "STARYU", "STARMIE", "MRMIME", "SCYTHER", "JYNX", "ELECTABUZZ", "MAGMAR", "PINSIR", "TAUROS", "MAGIKARP", "GYARADOS", "LAPRAS", "DITTO", "EEVEE", "VAPOREON", "JOLTEON", "FLAREON", "PORYGON", "OMANYTE", "OMASTAR", "KABUTO", "KABUTOPS", "AERODACTYL", "SNORLAX", "ARTICUNO", "ZAPDOS", "MOLTRES", "DRATINI", "DRAGONAIR", "DRAGONITE", "MEWTWO", "MEW", "CHIKORITA", "BAYLEEF", "MEGANIUM", "CYNDAQUIL", "QUILAVA", "TYPHLOSION", "TOTODILE", "CROCONAW", "FERALIGATR", "SENTRET", "FURRET", "HOOTHOOT", "NOCTOWL", "LEDYBA", "LEDIAN", "SPINARAK", "ARIADOS", "CROBAT", "CHINCHOU", "LANTURN", "PICHU", "CLEFFA", "IGGLYBUFF", "TOGEPI", "TOGETIC", "NATU", "XATU", "MAREEP", "FLAAFFY", "AMPHAROS", "BELLOSSOM", "MARILL", "AZUMARILL", "SUDOWOODO", "POLITOED", "HOPPIP", "SKIPLOOM", "JUMPLUFF", "AIPOM", "SUNKERN", "SUNFLORA", "YANMA", "WOOPER", "QUAGSIRE", "ESPEON", "UMBREON", "MURKROW", "SLOWKING", "MISDREAVUS", "UNOWN", "WOBBUFFET", "GIRAFARIG", "PINECO", "FORRETRESS", "DUNSPARCE", "GLIGAR", "STEELIX", "SNUBBULL", "GRANBULL", "QWILFISH", "SCIZOR", "SHUCKLE", "HERACROSS", "SNEASEL", "TEDDIURSA", "URSARING", "SLUGMA", "MAGCARGO", "SWINUB", "PILOSWINE", "CORSOLA", "REMORAID", "OCTILLERY", "DELIBIRD", "MANTINE", "SKARMORY", "HOUNDOUR", "HOUNDOOM", "KINGDRA", "PHANPY", "DONPHAN", "PORYGON2", "STANTLER", "SMEARGLE", "TYROGUE", "HITMONTOP", "SMOOCHUM", "ELEKID", "MAGBY", "MILTANK", "BLISSEY", "RAIKOU", "ENTEI", "SUICUNE", "LARVITAR", "PUPITAR", "TYRANITAR", "LUGIA", "HO-OH", "CELEBI", "TREECKO", "GROVYLE", "SCEPTILE", "TORCHIC", "COMBUSKEN", "BLAZIKEN", "MUDKIP", "MARSHTOMP", "SWAMPERT", "POOCHYENA", "MIGHTYENA", "ZIGZAGOON", "LINOONE", "WURMPLE", "SILCOON", "BEAUTIFLY", "CASCOON", "DUSTOX", "LOTAD", "LOMBRE", "LUDICOLO", "SEEDOT", "NUZLEAF", "SHIFTRY", "TAILLOW", "SWELLOW", "WINGULL", "PELIPPER", "RALTS", "KIRLIA", "GARDEVOIR", "SURSKIT", "MASQUERAIN", "SHROOMISH", "BRELOOM", "SLAKOTH", "VIGOROTH", "SLAKING", "NINCADA", "NINJASK", "SHEDINJA", "WHISMUR", "LOUDRED", "EXPLOUD", "MAKUHITA", "HARIYAMA", "AZURILL", "NOSEPASS", "SKITTY", "DELCATTY", "SABLEYE", "MAWILE", "ARON", "LAIRON", "AGGRON", "MEDITITE", "MEDICHAM", "ELECTRIKE", "MANECTRIC", "PLUSLE", "MINUN", "VOLBEAT", "ILLUMISE", "ROSELIA", "GULPIN", "SWALOT", "CARVANHA", "SHARPEDO", "WAILMER", "WAILORD", "NUMEL", "CAMERUPT", "TORKOAL", "SPOINK", "GRUMPIG", "SPINDA", "TRAPINCH", "VIBRAVA", "FLYGON", "CACNEA", "CACTURNE", "SWABLU", "ALTARIA", "ZANGOOSE", "SEVIPER", "LUNATONE", "SOLROCK", "BARBOACH", "WHISCASH", "CORPHISH", "CRAWDAUNT", "BALTOY", "CLAYDOL", "LILEEP", "CRADILY", "ANORITH", "ARMALDO", "FEEBAS", "MILOTIC", "CASTFORM", "KECLEON", "SHUPPET", "BANETTE", "DUSKULL", "DUSCLOPS", "TROPIUS", "CHIMECHO", "ABSOL", "WYNAUT", "SNORUNT", "GLALIE", "SPHEAL", "SEALEO", "WALREIN", "CLAMPERL", "HUNTAIL", "GOREBYSS", "RELICANTH", "LUVDISC", "BAGON", "SHELGON", "SALAMENCE", "BELDUM", "METANG", "METAGROSS", "REGIROCK", "REGICE", "REGISTEEL", "LATIAS", "LATIOS", "KYOGRE", "GROUDON", "RAYQUAZA", "JIRACHI", "DEOXYS", "TURTWIG", "GROTLE", "TORTERRA", "CHIMCHAR", "MONFERNO", "INFERNAPE", "PIPLUP", "PRINPLUP", "EMPOLEON", "STARLY", "STARAVIA", "STARAPTOR", "BIDOOF", "BIBAREL", "KRICKETOT", "KRICKETUNE", "SHINX", "LUXIO", "LUXRAY", "BUDEW", "ROSERADE", "CRANIDOS", "RAMPARDOS", "SHIELDON", "BASTIODON", "BURMY", "WORMADAM", "MOTHIM", "COMBEE", "VESPIQUEN", "PACHIRISU", "BUIZEL", "FLOATZEL", "CHERUBI", "CHERRIM", "SHELLOS", "GASTRODON", "AMBIPOM", "DRIFLOON", "DRIFBLIM", "BUNEARY", "LOPUNNY", "MISMAGIUS", "HONCHKROW", "GLAMEOW", "PURUGLY", "CHINGLING", "STUNKY", "SKUNTANK", "BRONZOR", "BRONZONG", "BONSLY", "MIMEJR", "HAPPINY", "CHATOT", "SPIRITOMB", "GIBLE", "GABITE", "GARCHOMP", "MUNCHLAX", "RIOLU", "LUCARIO", "HIPPOPOTAS", "HIPPOWDON", "SKORUPI", "DRAPION", "CROAGUNK", "TOXICROAK", "CARNIVINE", "FINNEON", "LUMINEON", "MANTYKE", "SNOVER", "ABOMASNOW", "WEAVILE", "MAGNEZONE", "LICKILICKY", "RHYPERIOR", "TANGROWTH", "ELECTIVIRE", "MAGMORTAR", "TOGEKISS", "YANMEGA", "LEAFEON", "GLACEON", "GLISCOR", "MAMOSWINE", "PORYGON-Z", "GALLADE", "PROBOPASS", "DUSKNOIR", "FROSLASS", "ROTOM", "UXIE", "MESPRIT", "AZELF", "DIALGA", "PALKIA", "HEATRAN", "REGIGIGAS", "GIRATINA", "CRESSELIA", "PHIONE", "MANAPHY", "DARKRAI", "SHAYMIN", "ARCEUS", "VICTINI", "SNIVY", "SERVINE", "SERPERIOR", "TEPIG", "PIGNITE", "EMBOAR", "OSHAWOTT", "DEWOTT", "SAMUROTT", "PATRAT", "WATCHOG", "LILLIPUP", "HERDIER", "STOUTLAND", "PURRLOIN", "LIEPARD", "PANSAGE", "SIMISAGE", "PANSEAR", "SIMISEAR", "PANPOUR", "SIMIPOUR", "MUNNA", "MUSHARNA", "PIDOVE", "TRANQUILL", "UNFEZANT", "BLITZLE", "ZEBSTRIKA", "ROGGENROLA", "BOLDORE", "GIGALITH", "WOOBAT", "SWOOBAT", "DRILBUR", "EXCADRILL", "AUDINO", "TIMBURR", "GURDURR", "CONKELDURR", "TYMPOLE", "PALPITOAD", "SEISMITOAD", "THROH", "SAWK", "SEWADDLE", "SWADLOON", "LEAVANNY", "VENIPEDE", "WHIRLIPEDE", "SCOLIPEDE", "COTTONEE", "WHIMSICOTT", "PETILIL", "LILLIGANT", "BASCULIN", "SANDILE", "KROKOROK", "KROOKODILE", "DARUMAKA", "DARMANITAN", "MARACTUS", "DWEBBLE", "CRUSTLE", "SCRAGGY", "SCRAFTY", "SIGILYPH", "YAMASK", "COFAGRIGUS", "TIRTOUGA", "CARRACOSTA", "ARCHEN", "ARCHEOPS", "TRUBBISH", "GARBODOR", "ZORUA", "ZOROARK", "MINCCINO", "CINCCINO", "GOTHITA", "GOTHORITA", "GOTHITELLE", "SOLOSIS", "DUOSION", "REUNICLUS", "DUCKLETT", "SWANNA", "VANILLITE", "VANILLISH", "VANILLUXE", "DEERLING", "SAWSBUCK", "EMOLGA", "KARRABLAST", "ESCAVALIER", "FOONGUS", "AMOONGUSS", "FRILLISH", "JELLICENT", "ALOMOMOLA", "JOLTIK", "GALVANTULA", "FERROSEED", "FERROTHORN", "KLINK", "KLANG", "KLINKLANG", "TYNAMO", "EELEKTRIK", "EELEKTROSS", "ELGYEM", "BEHEEYEM", "LITWICK", "LAMPENT", "CHANDELURE", "AXEW", "FRAXURE", "HAXORUS", "CUBCHOO", "BEARTIC", "CRYOGONAL", "SHELMET", "ACCELGOR", "STUNFISK", "MIENFOO", "MIENSHAO", "DRUDDIGON", "GOLETT", "GOLURK", "PAWNIARD", "BISHARP", "BOUFFALANT", "RUFFLET", "BRAVIARY", "VULLABY", "MANDIBUZZ", "HEATMOR", "DURANT", "DEINO", "ZWEILOUS", "HYDREIGON", "LARVESTA", "VOLCARONA", "COBALION", "TERRAKION", "VIRIZION", "TORNADUS", "THUNDURUS", "RESHIRAM", "ZEKROM", "LANDORUS", "KYUREM", "KELDEO", "MELOETTA", "GENESECT", "CHESPIN", "QUILLADIN", "CHESNAUGHT", "FENNEKIN", "BRAIXEN", "DELPHOX", "FROAKIE", "FROGADIER", "GRENINJA", "BUNNELBY", "DIGGERSBY", "FLETCHLING", "FLETCHINDER", "TALONFLAME", "SCATTERBUG", "SPEWPA", "VIVILLON", "LITLEO", "PYROAR", "FLABEBE", "FLOETTE", "FLORGES", "SKIDDO", "GOGOAT", "PANCHAM", "PANGORO", "FURFROU", "ESPURR", "MEOWSTIC", "HONEDGE", "DOUBLADE", "AEGISLASH", "SPRITZEE", "AROMATISSE", "SWIRLIX", "SLURPUFF", "INKAY", "MALAMAR", "BINACLE", "BARBARACLE", "SKRELP", "DRAGALGE", "CLAUNCHER", "CLAWITZER", "HELIOPTILE", "HELIOLISK", "TYRUNT", "TYRANTRUM", "AMAURA", "AURORUS", "SYLVEON", "HAWLUCHA", "DEDENNE", "CARBINK", "GOOMY", "SLIGGOO", "GOODRA", "KLEFKI", "PHANTUMP", "TREVENANT", "PUMPKABOO", "GOURGEIST", "BERGMITE", "AVALUGG", "NOIBAT", "NOIVERN", "XERNEAS", "YVELTAL", "ZYGARDE", "DIANCIE", "HOOPA", "VOLCANION", "ROWLET", "DARTRIX", "DECIDUEYE", "LITTEN", "TORRACAT", "INCINEROAR", "POPPLIO", "BRIONNE", "PRIMARINA", "PIKIPEK", "TRUMBEAK", "TOUCANNON", "YUNGOOS", "GUMSHOOS", "GRUBBIN", "CHARJABUG", "VIKAVOLT", "CRABRAWLER", "CRABOMINABLE", "ORICORIO", "CUTIEFLY", "RIBOMBEE", "ROCKRUFF", "LYCANROC", "WISHIWASHI", "MAREANIE", "TOXAPEX", "MUDBRAY", "MUDSDALE", "DEWPIDER", "ARAQUANID", "FOMANTIS", "LURANTIS", "MORELULL", "SHIINOTIC", "SALANDIT", "SALAZZLE", "STUFFUL", "BEWEAR", "BOUNSWEET", "STEENEE", "TSAREENA", "COMFEY", "ORANGURU", "PASSIMIAN", "WIMPOD", "GOLISOPOD", "SANDYGAST", "PALOSSAND", "PYUKUMUKU", "TYPENULL", "SILVALLY", "MINIOR", "KOMALA", "TURTONATOR", "TOGEDEMARU", "MIMIKYU", "BRUXISH", "DRAMPA", "DHELMISE", "JANGMO-O", "HAKAMO-O", "KOMMO-O", "TAPUKOKO", "TAPULELE", "TAPUBULU", "TAPUFINI", "COSMOG", "COSMOEM", "SOLGALEO", "LUNALA", "NIHILEGO", "BUZZWOLE", "PHEROMOSA", "XURKITREE", "CELESTEELA", "KARTANA", "GUZZLORD", "NECROZMA", "MAGEARNA", "MARSHADOW", "POIPOLE", "NAGANADEL", "STAKATAKA", "BLACEPHALON", "ZERAORA", "MELTAN", "MELMETAL", "GROOKEY", "THWACKEY", "RILLABOOM", "SCORBUNNY", "RABOOT", "CINDERACE", "SOBBLE", "DRIZZILE", "INTELEON", "SKWOVET", "GREEDENT", "ROOKIDEE", "CORVISQUIRE", "CORVIKNIGHT", "BLIPBUG", "DOTTLER", "ORBEETLE", "NICKIT", "THIEVUL", "GOSSIFLEUR", "ELDEGOSS", "WOOLOO", "DUBWOOL", "CHEWTLE", "DREDNAW", "YAMPER", "BOLTUND", "ROLYCOLY", "CARKOL", "COALOSSAL", "APPLIN", "FLAPPLE", "APPLETUN", "SILICOBRA", "SANDACONDA", "CRAMORANT", "ARROKUDA", "BARRASKEWDA", "TOXEL", "TOXTRICITY", "SIZZLIPEDE", "CENTISKORCH", "CLOBBOPUS", "GRAPPLOCT", "SINISTEA", "POLTEAGEIST", "HATENNA", "HATTREM", "HATTERENE", "IMPIDIMP", "MORGREM", "GRIMMSNARL", "OBSTAGOON", "PERRSERKER", "CURSOLA", "SIRFETCHD", "MRRIME", "RUNERIGUS", "MILCERY", "ALCREMIE", "FALINKS", "PINCURCHIN", "SNOM", "FROSMOTH", "STONJOURNER", "EISCUE", "INDEEDEE", "MORPEKO", "CUFANT", "COPPERAJAH", "DRACOZOLT", "ARCTOZOLT", "DRACOVISH", "ARCTOVISH", "DURALUDON", "DREEPY", "DRAKLOAK", "DRAGAPULT", "ZACIAN", "ZAMAZENTA", "ETERNATUS", "KUBFU", "URSHIFU", "ZARUDE", "REGIELEKI", "REGIDRAGO", "GLASTRIER", "SPECTRIER", "CALYREX"})
        pokemon3Name_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon3Name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon3Name_txt.Location = New Point(6, 37)
        pokemon3Name_txt.Name = "pokemon3Name_txt"
        pokemon3Name_txt.PlaceholderText = "Bulbasaur"
        pokemon3Name_txt.Size = New Size(140, 23)
        pokemon3Name_txt.TabIndex = 57
        ' 
        ' pokemon3IVs_grp
        ' 
        pokemon3IVs_grp.Controls.Add(pokemon3RandomIVs_btn)
        pokemon3IVs_grp.Controls.Add(pokemon3MaxIVs_btn)
        pokemon3IVs_grp.Controls.Add(pokemon3IVsDEF_txt)
        pokemon3IVs_grp.Controls.Add(pokemon3IVsDEF_lbl)
        pokemon3IVs_grp.Controls.Add(pokemon3IVsSPDEF_txt)
        pokemon3IVs_grp.Controls.Add(pokemon3IVsSPDEF_lbl)
        pokemon3IVs_grp.Controls.Add(pokemon3IVsSPATK_txt)
        pokemon3IVs_grp.Controls.Add(pokemon3IVsSPATK_lbl)
        pokemon3IVs_grp.Controls.Add(pokemon3IVsSPD_txt)
        pokemon3IVs_grp.Controls.Add(pokemon3IVsSPD_lbl)
        pokemon3IVs_grp.Controls.Add(pokemon3IVsATK_txt)
        pokemon3IVs_grp.Controls.Add(pokemon3IVsATK_lbl)
        pokemon3IVs_grp.Controls.Add(pokemon3IVsHP_txt)
        pokemon3IVs_grp.Controls.Add(pokemon3IVsHP_lbl)
        pokemon3IVs_grp.Location = New Point(204, 154)
        pokemon3IVs_grp.Name = "pokemon3IVs_grp"
        pokemon3IVs_grp.Size = New Size(114, 188)
        pokemon3IVs_grp.TabIndex = 78
        pokemon3IVs_grp.TabStop = False
        pokemon3IVs_grp.Text = "IVs (Max 31 Each)"
        ' 
        ' pokemon3RandomIVs_btn
        ' 
        pokemon3RandomIVs_btn.Location = New Point(57, 152)
        pokemon3RandomIVs_btn.Name = "pokemon3RandomIVs_btn"
        pokemon3RandomIVs_btn.Size = New Size(44, 23)
        pokemon3RandomIVs_btn.TabIndex = 15
        pokemon3RandomIVs_btn.Text = "Rand"
        pokemon3RandomIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon3MaxIVs_btn
        ' 
        pokemon3MaxIVs_btn.Location = New Point(7, 152)
        pokemon3MaxIVs_btn.Name = "pokemon3MaxIVs_btn"
        pokemon3MaxIVs_btn.Size = New Size(44, 23)
        pokemon3MaxIVs_btn.TabIndex = 14
        pokemon3MaxIVs_btn.Text = "Max"
        pokemon3MaxIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon3IVsDEF_txt
        ' 
        pokemon3IVsDEF_txt.Location = New Point(7, 123)
        pokemon3IVsDEF_txt.MaxLength = 3
        pokemon3IVsDEF_txt.Name = "pokemon3IVsDEF_txt"
        pokemon3IVsDEF_txt.Size = New Size(44, 23)
        pokemon3IVsDEF_txt.TabIndex = 13
        pokemon3IVsDEF_txt.Text = "0"
        ' 
        ' pokemon3IVsDEF_lbl
        ' 
        pokemon3IVsDEF_lbl.AutoSize = True
        pokemon3IVsDEF_lbl.Location = New Point(18, 105)
        pokemon3IVsDEF_lbl.Name = "pokemon3IVsDEF_lbl"
        pokemon3IVsDEF_lbl.Size = New Size(27, 15)
        pokemon3IVsDEF_lbl.TabIndex = 12
        pokemon3IVsDEF_lbl.Text = "DEF"
        ' 
        ' pokemon3IVsSPDEF_txt
        ' 
        pokemon3IVsSPDEF_txt.Location = New Point(57, 123)
        pokemon3IVsSPDEF_txt.MaxLength = 3
        pokemon3IVsSPDEF_txt.Name = "pokemon3IVsSPDEF_txt"
        pokemon3IVsSPDEF_txt.Size = New Size(44, 23)
        pokemon3IVsSPDEF_txt.TabIndex = 9
        pokemon3IVsSPDEF_txt.Text = "0"
        ' 
        ' pokemon3IVsSPDEF_lbl
        ' 
        pokemon3IVsSPDEF_lbl.AutoSize = True
        pokemon3IVsSPDEF_lbl.Location = New Point(59, 105)
        pokemon3IVsSPDEF_lbl.Name = "pokemon3IVsSPDEF_lbl"
        pokemon3IVsSPDEF_lbl.Size = New Size(40, 15)
        pokemon3IVsSPDEF_lbl.TabIndex = 8
        pokemon3IVsSPDEF_lbl.Text = "SPDEF"
        ' 
        ' pokemon3IVsSPATK_txt
        ' 
        pokemon3IVsSPATK_txt.Location = New Point(57, 79)
        pokemon3IVsSPATK_txt.MaxLength = 3
        pokemon3IVsSPATK_txt.Name = "pokemon3IVsSPATK_txt"
        pokemon3IVsSPATK_txt.Size = New Size(44, 23)
        pokemon3IVsSPATK_txt.TabIndex = 7
        pokemon3IVsSPATK_txt.Text = "0"
        ' 
        ' pokemon3IVsSPATK_lbl
        ' 
        pokemon3IVsSPATK_lbl.AutoSize = True
        pokemon3IVsSPATK_lbl.Location = New Point(59, 61)
        pokemon3IVsSPATK_lbl.Name = "pokemon3IVsSPATK_lbl"
        pokemon3IVsSPATK_lbl.Size = New Size(39, 15)
        pokemon3IVsSPATK_lbl.TabIndex = 6
        pokemon3IVsSPATK_lbl.Text = "SPATK"
        ' 
        ' pokemon3IVsSPD_txt
        ' 
        pokemon3IVsSPD_txt.Location = New Point(57, 35)
        pokemon3IVsSPD_txt.MaxLength = 3
        pokemon3IVsSPD_txt.Name = "pokemon3IVsSPD_txt"
        pokemon3IVsSPD_txt.Size = New Size(44, 23)
        pokemon3IVsSPD_txt.TabIndex = 5
        pokemon3IVsSPD_txt.Text = "0"
        ' 
        ' pokemon3IVsSPD_lbl
        ' 
        pokemon3IVsSPD_lbl.AutoSize = True
        pokemon3IVsSPD_lbl.Location = New Point(65, 17)
        pokemon3IVsSPD_lbl.Name = "pokemon3IVsSPD_lbl"
        pokemon3IVsSPD_lbl.Size = New Size(28, 15)
        pokemon3IVsSPD_lbl.TabIndex = 4
        pokemon3IVsSPD_lbl.Text = "SPD"
        ' 
        ' pokemon3IVsATK_txt
        ' 
        pokemon3IVsATK_txt.Location = New Point(7, 79)
        pokemon3IVsATK_txt.MaxLength = 3
        pokemon3IVsATK_txt.Name = "pokemon3IVsATK_txt"
        pokemon3IVsATK_txt.Size = New Size(44, 23)
        pokemon3IVsATK_txt.TabIndex = 3
        pokemon3IVsATK_txt.Text = "0"
        ' 
        ' pokemon3IVsATK_lbl
        ' 
        pokemon3IVsATK_lbl.AutoSize = True
        pokemon3IVsATK_lbl.Location = New Point(18, 61)
        pokemon3IVsATK_lbl.Name = "pokemon3IVsATK_lbl"
        pokemon3IVsATK_lbl.Size = New Size(27, 15)
        pokemon3IVsATK_lbl.TabIndex = 2
        pokemon3IVsATK_lbl.Text = "ATK"
        ' 
        ' pokemon3IVsHP_txt
        ' 
        pokemon3IVsHP_txt.Location = New Point(7, 35)
        pokemon3IVsHP_txt.MaxLength = 3
        pokemon3IVsHP_txt.Name = "pokemon3IVsHP_txt"
        pokemon3IVsHP_txt.Size = New Size(44, 23)
        pokemon3IVsHP_txt.TabIndex = 1
        pokemon3IVsHP_txt.Text = "0"
        ' 
        ' pokemon3IVsHP_lbl
        ' 
        pokemon3IVsHP_lbl.AutoSize = True
        pokemon3IVsHP_lbl.Location = New Point(18, 19)
        pokemon3IVsHP_lbl.Name = "pokemon3IVsHP_lbl"
        pokemon3IVsHP_lbl.Size = New Size(23, 15)
        pokemon3IVsHP_lbl.TabIndex = 0
        pokemon3IVsHP_lbl.Text = "HP"
        ' 
        ' pokemon3HeldItem_txt
        ' 
        pokemon3HeldItem_txt.Location = New Point(152, 37)
        pokemon3HeldItem_txt.Name = "pokemon3HeldItem_txt"
        pokemon3HeldItem_txt.PlaceholderText = "FocusSash"
        pokemon3HeldItem_txt.Size = New Size(140, 23)
        pokemon3HeldItem_txt.TabIndex = 58
        ' 
        ' pokemon3PokeballID_cmb
        ' 
        pokemon3PokeballID_cmb.FormattingEnabled = True
        pokemon3PokeballID_cmb.Items.AddRange(New Object() {"POKEBALL", "GREATBALL", "SAFARIBALL", "ULTRABALL", "MASTERBALL", "NETBALL", "DIVEBALL", "NESTBALL", "REPEATBALL", "TIMERBALL", "LUXURYBALL", "PREMIERBALL", "DUSKBALL", "HEALBALL", "QUICKBALL", "CHERISHBALL", "FASTBALL", "LEVELBALL", "LUREBALL", "HEAVYBALL", "LOVEBALL", "FRIENDBALL", "MOONBALL", "SPORTBALL", "DREAMBALL", "BEASTBALL"})
        pokemon3PokeballID_cmb.Location = New Point(6, 169)
        pokemon3PokeballID_cmb.Name = "pokemon3PokeballID_cmb"
        pokemon3PokeballID_cmb.Size = New Size(140, 23)
        pokemon3PokeballID_cmb.TabIndex = 77
        ' 
        ' pokemon3HeldItem_lbl
        ' 
        pokemon3HeldItem_lbl.AutoSize = True
        pokemon3HeldItem_lbl.Location = New Point(152, 19)
        pokemon3HeldItem_lbl.Name = "pokemon3HeldItem_lbl"
        pokemon3HeldItem_lbl.Size = New Size(59, 15)
        pokemon3HeldItem_lbl.TabIndex = 59
        pokemon3HeldItem_lbl.Text = "Held Item"
        ' 
        ' pokemon3PokeBall_lbl
        ' 
        pokemon3PokeBall_lbl.AutoSize = True
        pokemon3PokeBall_lbl.Location = New Point(8, 151)
        pokemon3PokeBall_lbl.Name = "pokemon3PokeBall_lbl"
        pokemon3PokeBall_lbl.Size = New Size(52, 15)
        pokemon3PokeBall_lbl.TabIndex = 76
        pokemon3PokeBall_lbl.Text = "PokéBall"
        ' 
        ' pokemon3Level_lbl
        ' 
        pokemon3Level_lbl.AutoSize = True
        pokemon3Level_lbl.Location = New Point(298, 19)
        pokemon3Level_lbl.Name = "pokemon3Level_lbl"
        pokemon3Level_lbl.Size = New Size(34, 15)
        pokemon3Level_lbl.TabIndex = 60
        pokemon3Level_lbl.Text = "Level"
        ' 
        ' pokemon3Nickname_txt
        ' 
        pokemon3Nickname_txt.Location = New Point(298, 125)
        pokemon3Nickname_txt.Name = "pokemon3Nickname_txt"
        pokemon3Nickname_txt.PlaceholderText = "Bloom"
        pokemon3Nickname_txt.Size = New Size(140, 23)
        pokemon3Nickname_txt.TabIndex = 75
        ' 
        ' pokemon3Nickname_lbl
        ' 
        pokemon3Nickname_lbl.AutoSize = True
        pokemon3Nickname_lbl.Location = New Point(298, 107)
        pokemon3Nickname_lbl.Name = "pokemon3Nickname_lbl"
        pokemon3Nickname_lbl.Size = New Size(61, 15)
        pokemon3Nickname_lbl.TabIndex = 74
        pokemon3Nickname_lbl.Text = "Nickname"
        ' 
        ' pokemon3Moves_grp
        ' 
        pokemon3Moves_grp.Controls.Add(pokemon3Move4_txtBox)
        pokemon3Moves_grp.Controls.Add(pokemon3Move3_txtBox)
        pokemon3Moves_grp.Controls.Add(pokemon3Move2_txtBox)
        pokemon3Moves_grp.Controls.Add(pokemon3Move1_txtBox)
        pokemon3Moves_grp.Location = New Point(444, 22)
        pokemon3Moves_grp.Name = "pokemon3Moves_grp"
        pokemon3Moves_grp.Size = New Size(273, 82)
        pokemon3Moves_grp.TabIndex = 62
        pokemon3Moves_grp.TabStop = False
        pokemon3Moves_grp.Text = "Moves"
        ' 
        ' pokemon3Move4_txtBox
        ' 
        pokemon3Move4_txtBox.Location = New Point(132, 51)
        pokemon3Move4_txtBox.Name = "pokemon3Move4_txtBox"
        pokemon3Move4_txtBox.PlaceholderText = "Move 4"
        pokemon3Move4_txtBox.Size = New Size(120, 23)
        pokemon3Move4_txtBox.TabIndex = 3
        ' 
        ' pokemon3Move3_txtBox
        ' 
        pokemon3Move3_txtBox.Location = New Point(6, 51)
        pokemon3Move3_txtBox.Name = "pokemon3Move3_txtBox"
        pokemon3Move3_txtBox.PlaceholderText = "Move 3"
        pokemon3Move3_txtBox.Size = New Size(120, 23)
        pokemon3Move3_txtBox.TabIndex = 2
        ' 
        ' pokemon3Move2_txtBox
        ' 
        pokemon3Move2_txtBox.Location = New Point(132, 22)
        pokemon3Move2_txtBox.Name = "pokemon3Move2_txtBox"
        pokemon3Move2_txtBox.PlaceholderText = "Move 2"
        pokemon3Move2_txtBox.Size = New Size(120, 23)
        pokemon3Move2_txtBox.TabIndex = 1
        ' 
        ' pokemon3Move1_txtBox
        ' 
        pokemon3Move1_txtBox.Location = New Point(6, 22)
        pokemon3Move1_txtBox.Name = "pokemon3Move1_txtBox"
        pokemon3Move1_txtBox.PlaceholderText = "Move 1"
        pokemon3Move1_txtBox.Size = New Size(120, 23)
        pokemon3Move1_txtBox.TabIndex = 0
        ' 
        ' pokemon3Ability_lbl
        ' 
        pokemon3Ability_lbl.AutoSize = True
        pokemon3Ability_lbl.Location = New Point(6, 63)
        pokemon3Ability_lbl.Name = "pokemon3Ability_lbl"
        pokemon3Ability_lbl.Size = New Size(41, 15)
        pokemon3Ability_lbl.TabIndex = 63
        pokemon3Ability_lbl.Text = "Ability"
        ' 
        ' pokemon3Happiness_lbl
        ' 
        pokemon3Happiness_lbl.AutoSize = True
        pokemon3Happiness_lbl.Location = New Point(152, 107)
        pokemon3Happiness_lbl.Name = "pokemon3Happiness_lbl"
        pokemon3Happiness_lbl.Size = New Size(62, 15)
        pokemon3Happiness_lbl.TabIndex = 72
        pokemon3Happiness_lbl.Text = "Happiness"
        ' 
        ' pokemon3Ability_cmb
        ' 
        pokemon3Ability_cmb.AutoCompleteCustomSource.AddRange(New String() {"Aerilate", "Aftermath", "Air Lock", "Analytic", "Anger Point", "Anger Shell", "Anticipation", "Arena Trap", "Armor Tail", "Aroma Veil", "As One - Unnerve Chilling Neigh", "As One - Unnerve Grim Neigh", "Aura Break", "Bad Dreams", "Ball Fetch", "Battery", "Battle Armor", "Battle Bond", "Beads of Ruin", "Beast Boost", "Berserk", "Big Pecks", "Blaze", "Bulletproof", "Cheek Pouch", "Chilling Neigh", "Chlorophyll", "Clear Body", "Cloud Nine", "Color Change", "Comatose", "Commander", "Competitive", "Compoundeyes", "Contrary", "Corrosion", "Costar", "Cotton Down", "Cud Chew", "Curious Medicine", "Cursed Body", "Cute Charm", "Damp", "Dancer", "Dark Aura", "Dauntless Shield", "Dazzling", "Defeatist", "Defiant", "Delta Stream", "Desolate Land", "Disguise", "Download", "Dragon's Maw", "Drizzle", "Drought", "Dry Skin", "Early Bird", "Earth Eater", "Effect Spore", "Electric Surge", "Electromorphosis", "Embody Aspect - Cornerstone Mask", "Embody Aspect - Hearthflame Mask", "Embody Aspect - Teal Mask", "Embody Aspect - Wellspring Mask", "Emergency Exit", "Fairy Aura", "Filter", "Flame Body", "Flare Boost", "Flash Fire", "Flower Gift", "Flower Veil", "Fluffy", "Forecast", "Forewarn", "Friend Guard", "Frisk", "Full Metal Body", "Fur Coat", "Gale Wings", "Galvanize", "Gluttony", "Good as Gold", "Gooey", "Gorilla Tactics", "Grass Pelt", "Grassy Surge", "Grim Neigh", "Guard Dog", "Gulp Missile", "Guts", "Hadron Engine", "Harvest", "Healer", "Heatproof", "Heavy Metal", "Honey Gather", "Hospitality", "Huge Power", "Hunger Switch", "Hustle", "Hydration", "Hyper Cutter", "Ice Body", "Ice Face", "Ice Scales", "Illuminate", "Illusion", "Immunity", "Imposter", "Infiltrator", "Innards Out", "Inner Focus", "Insomnia", "Intimidate", "Intrepid Sword", "Iron Barbs", "Iron Fist", "Justified", "Keen Eye", "Klutz", "Leaf Guard", "Levitate", "Libero", "Light Metal", "Lightning Rod", "Limber", "Lingering Aroma", "Liquid Ooze", "Liquid Voice", "Long Reach", "Magic Bounce", "Magic Guard", "Magician", "Magma Armor", "Magnet Pull", "Marvel Scale", "Mega Launcher", "Merciless", "Mimicry", "Mind's Eye", "Minus", "Mirror Armor", "Misty Surge", "Mold Breaker", "Moody", "Motor Drive", "Moxie", "Multiscale", "Multitype", "Mummy", "Mycelium Might", "Natural Cure", "Neuroforce", "Neutralizing Gas", "No Guard", "Normalize", "Oblivious", "Opportunist", "Orichalcum Pulse", "Overcoat", "Overgrow", "Own Tempo", "Parental Bond", "Pastel Veil", "Perish Body", "Pickpocket", "Pickup", "Pixilate", "Plus", "Poison Heal", "Poison Point", "Poison Touch", "Power Construct", "Power of Alchemy", "Power Spot", "Prankster", "Pressure", "Primordial Sea", "Prism Armor", "Propeller Tail", "Protean", "Protosynthesis", "Psychic Surge", "Punk Rock", "Pure Power", "Purifying Salt", "Quark Drive", "Queenly Majesty", "Quick Draw", "Quick Feet", "Rain Dish", "Rattled", "Receiver", "Reckless", "Refrigerate", "Regenerator", "Ripen", "Rivalry", "RKS System", "Rock Head", "Rocky Payload", "Rough Skin", "Run Away", "Sand Force", "Sand Rush", "Sand Spit", "Sand Stream", "Sand Veil", "Sap Sipper", "Schooling", "Scrappy", "Screen Cleaner", "Seed Sower", "Serene Grace", "Shadow Shield", "Shadow Tag", "Sharpness", "Shed Skin", "Sheer Force", "Shell Armor", "Shield Dust", "Shields Down", "Simple", "Skill Link", "Slow Start", "Slush Rush", "Sniper", "Snow Cloak", "Snow Warning", "Solar Power", "Solid Rock", "Soul-Heart", "Soundproof", "Speed Boost", "Stakeout", "Stall", "Stalwart", "Stamina", "Stance Change", "Static", "Steadfast", "Steam Engine", "Steelworker", "Steely Spirit", "Stench", "Sticky Hold", "Storm Drain", "Strong Jaw", "Sturdy", "Suction Cups", "Super Luck", "Supersweet Syrup", "Supreme Overlord", "Surge Surfer", "Swarm", "Sweet Veil", "Swift Swim", "Sword of Ruin", "Symbiosis", "Synchronize", "Tablets of Ruin", "Tangled Feet", "Tangling Hair", "Technician", "Telepathy", "Teravolt", "Thermal Exchange", "Thick Fat", "Tinted Lens", "Torrent", "Tough Claws", "Toxic Boost", "Toxic Chain", "Toxic Debris", "Trace", "Transistor", "Triage", "Truant", "Turboblaze", "Unaware", "Unburden", "Unnerve", "Unseen Fist", "Vessel of Ruin", "Victory Star", "Vital Spirit", "Volt Absorb", "Wandering Spirit", "Water Absorb", "Water Bubble", "Water Compaction", "Water Veil", "Weak Armor", "Well-Baked Body", "White Smoke", "Wimp Out", "Wind Power", "Wind Rider", "Wonder Guard", "Wonder Skin ", "Zen Mode", "Zero to Hero"})
        pokemon3Ability_cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon3Ability_cmb.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon3Ability_cmb.FormattingEnabled = True
        pokemon3Ability_cmb.Items.AddRange(New Object() {"Aerilate", "Aftermath", "Air Lock", "Analytic", "Anger Point", "Anger Shell", "Anticipation", "Arena Trap", "Armor Tail", "Aroma Veil", "As One - Unnerve Chilling Neigh", "As One - Unnerve Grim Neigh", "Aura Break", "Bad Dreams", "Ball Fetch", "Battery", "Battle Armor", "Battle Bond", "Beads of Ruin", "Beast Boost", "Berserk", "Big Pecks", "Blaze", "Bulletproof", "Cheek Pouch", "Chilling Neigh", "Chlorophyll", "Clear Body", "Cloud Nine", "Color Change", "Comatose", "Commander", "Competitive", "Compoundeyes", "Contrary", "Corrosion", "Costar", "Cotton Down", "Cud Chew", "Curious Medicine", "Cursed Body", "Cute Charm", "Damp", "Dancer", "Dark Aura", "Dauntless Shield", "Dazzling", "Defeatist", "Defiant", "Delta Stream", "Desolate Land", "Disguise", "Download", "Dragon's Maw", "Drizzle", "Drought", "Dry Skin", "Early Bird", "Earth Eater", "Effect Spore", "Electric Surge", "Electromorphosis", "Embody Aspect - Cornerstone Mask", "Embody Aspect - Hearthflame Mask", "Embody Aspect - Teal Mask", "Embody Aspect - Wellspring Mask", "Emergency Exit", "Fairy Aura", "Filter", "Flame Body", "Flare Boost", "Flash Fire", "Flower Gift", "Flower Veil", "Fluffy", "Forecast", "Forewarn", "Friend Guard", "Frisk", "Full Metal Body", "Fur Coat", "Gale Wings", "Galvanize", "Gluttony", "Good as Gold", "Gooey", "Gorilla Tactics", "Grass Pelt", "Grassy Surge", "Grim Neigh", "Guard Dog", "Gulp Missile", "Guts", "Hadron Engine", "Harvest", "Healer", "Heatproof", "Heavy Metal", "Honey Gather", "Hospitality", "Huge Power", "Hunger Switch", "Hustle", "Hydration", "Hyper Cutter", "Ice Body", "Ice Face", "Ice Scales", "Illuminate", "Illusion", "Immunity", "Imposter", "Infiltrator", "Innards Out", "Inner Focus", "Insomnia", "Intimidate", "Intrepid Sword", "Iron Barbs", "Iron Fist", "Justified", "Keen Eye", "Klutz", "Leaf Guard", "Levitate", "Libero", "Light Metal", "Lightning Rod", "Limber", "Lingering Aroma", "Liquid Ooze", "Liquid Voice", "Long Reach", "Magic Bounce", "Magic Guard", "Magician", "Magma Armor", "Magnet Pull", "Marvel Scale", "Mega Launcher", "Merciless", "Mimicry", "Mind's Eye", "Minus", "Mirror Armor", "Misty Surge", "Mold Breaker", "Moody", "Motor Drive", "Moxie", "Multiscale", "Multitype", "Mummy", "Mycelium Might", "Natural Cure", "Neuroforce", "Neutralizing Gas", "No Guard", "Normalize", "Oblivious", "Opportunist", "Orichalcum Pulse", "Overcoat", "Overgrow", "Own Tempo", "Parental Bond", "Pastel Veil", "Perish Body", "Pickpocket", "Pickup", "Pixilate", "Plus", "Poison Heal", "Poison Point", "Poison Touch", "Power Construct", "Power of Alchemy", "Power Spot", "Prankster", "Pressure", "Primordial Sea", "Prism Armor", "Propeller Tail", "Protean", "Protosynthesis", "Psychic Surge", "Punk Rock", "Pure Power", "Purifying Salt", "Quark Drive", "Queenly Majesty", "Quick Draw", "Quick Feet", "Rain Dish", "Rattled", "Receiver", "Reckless", "Refrigerate", "Regenerator", "Ripen", "Rivalry", "RKS System", "Rock Head", "Rocky Payload", "Rough Skin", "Run Away", "Sand Force", "Sand Rush", "Sand Spit", "Sand Stream", "Sand Veil", "Sap Sipper", "Schooling", "Scrappy", "Screen Cleaner", "Seed Sower", "Serene Grace", "Shadow Shield", "Shadow Tag", "Sharpness", "Shed Skin", "Sheer Force", "Shell Armor", "Shield Dust", "Shields Down", "Simple", "Skill Link", "Slow Start", "Slush Rush", "Sniper", "Snow Cloak", "Snow Warning", "Solar Power", "Solid Rock", "Soul-Heart", "Soundproof", "Speed Boost", "Stakeout", "Stall", "Stalwart", "Stamina", "Stance Change", "Static", "Steadfast", "Steam Engine", "Steelworker", "Steely Spirit", "Stench", "Sticky Hold", "Storm Drain", "Strong Jaw", "Sturdy", "Suction Cups", "Super Luck", "Supersweet Syrup", "Supreme Overlord", "Surge Surfer", "Swarm", "Sweet Veil", "Swift Swim", "Sword of Ruin", "Symbiosis", "Synchronize", "Tablets of Ruin", "Tangled Feet", "Tangling Hair", "Technician", "Telepathy", "Teravolt", "Thermal Exchange", "Thick Fat", "Tinted Lens", "Torrent", "Tough Claws", "Toxic Boost", "Toxic Chain", "Toxic Debris", "Trace", "Transistor", "Triage", "Truant", "Turboblaze", "Unaware", "Unburden", "Unnerve", "Unseen Fist", "Vessel of Ruin", "Victory Star", "Vital Spirit", "Volt Absorb", "Wandering Spirit", "Water Absorb", "Water Bubble", "Water Compaction", "Water Veil", "Weak Armor", "Well-Baked Body", "White Smoke", "Wimp Out", "Wind Power", "Wind Rider", "Wonder Guard", "Wonder Skin ", "Zen Mode", "Zero to Hero"})
        pokemon3Ability_cmb.Location = New Point(6, 81)
        pokemon3Ability_cmb.Name = "pokemon3Ability_cmb"
        pokemon3Ability_cmb.Size = New Size(140, 23)
        pokemon3Ability_cmb.TabIndex = 64
        ' 
        ' pokemon3Nature_cmb
        ' 
        pokemon3Nature_cmb.FormattingEnabled = True
        pokemon3Nature_cmb.Items.AddRange(New Object() {"(random)", "HARDY", "LONELY", "BRAVE", "ADAMANT", "NAUGHTY", "BOLD", "DOCILE", "RELAXED", "IMPISH", "LAX", "MODEST", "MILD", "SERIOUS", "QUIET", "RASH", "CALM", "GENTLE", "SASSY", "BASHFUL", "CAREFUL", "TIMID", "HASTY", "JOLLY", "NAIVE", "QUIRKY"})
        pokemon3Nature_cmb.Location = New Point(6, 125)
        pokemon3Nature_cmb.Name = "pokemon3Nature_cmb"
        pokemon3Nature_cmb.Size = New Size(140, 23)
        pokemon3Nature_cmb.TabIndex = 71
        ' 
        ' pokemon3Gender_lbl
        ' 
        pokemon3Gender_lbl.AutoSize = True
        pokemon3Gender_lbl.Location = New Point(152, 63)
        pokemon3Gender_lbl.Name = "pokemon3Gender_lbl"
        pokemon3Gender_lbl.Size = New Size(45, 15)
        pokemon3Gender_lbl.TabIndex = 65
        pokemon3Gender_lbl.Text = "Gender"
        ' 
        ' pokemon3Nature_lbl
        ' 
        pokemon3Nature_lbl.AutoSize = True
        pokemon3Nature_lbl.Location = New Point(6, 107)
        pokemon3Nature_lbl.Name = "pokemon3Nature_lbl"
        pokemon3Nature_lbl.Size = New Size(43, 15)
        pokemon3Nature_lbl.TabIndex = 70
        pokemon3Nature_lbl.Text = "Nature"
        ' 
        ' pokemon3Gender_cmb
        ' 
        pokemon3Gender_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        pokemon3Gender_cmb.FormattingEnabled = True
        pokemon3Gender_cmb.Items.AddRange(New Object() {"Male", "Female", "Random"})
        pokemon3Gender_cmb.Location = New Point(152, 81)
        pokemon3Gender_cmb.Name = "pokemon3Gender_cmb"
        pokemon3Gender_cmb.Size = New Size(140, 23)
        pokemon3Gender_cmb.TabIndex = 66
        ' 
        ' pokemon3Shiny_grp
        ' 
        pokemon3Shiny_grp.Controls.Add(pokemon3SuperShiny_chkBox)
        pokemon3Shiny_grp.Controls.Add(pokemon3Shiny_rad)
        pokemon3Shiny_grp.Controls.Add(pokemon3NotShiny_rad)
        pokemon3Shiny_grp.Location = New Point(444, 110)
        pokemon3Shiny_grp.Name = "pokemon3Shiny_grp"
        pokemon3Shiny_grp.Size = New Size(273, 82)
        pokemon3Shiny_grp.TabIndex = 69
        pokemon3Shiny_grp.TabStop = False
        pokemon3Shiny_grp.Text = "Shiny"
        ' 
        ' pokemon3SuperShiny_chkBox
        ' 
        pokemon3SuperShiny_chkBox.AutoSize = True
        pokemon3SuperShiny_chkBox.Enabled = False
        pokemon3SuperShiny_chkBox.Location = New Point(66, 47)
        pokemon3SuperShiny_chkBox.Name = "pokemon3SuperShiny_chkBox"
        pokemon3SuperShiny_chkBox.Size = New Size(88, 19)
        pokemon3SuperShiny_chkBox.TabIndex = 2
        pokemon3SuperShiny_chkBox.Text = "Super Shiny"
        pokemon3SuperShiny_chkBox.UseVisualStyleBackColor = True
        ' 
        ' pokemon3Shiny_rad
        ' 
        pokemon3Shiny_rad.AutoSize = True
        pokemon3Shiny_rad.Location = New Point(6, 47)
        pokemon3Shiny_rad.Name = "pokemon3Shiny_rad"
        pokemon3Shiny_rad.Size = New Size(54, 19)
        pokemon3Shiny_rad.TabIndex = 1
        pokemon3Shiny_rad.Text = "Shiny"
        pokemon3Shiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon3NotShiny_rad
        ' 
        pokemon3NotShiny_rad.AutoSize = True
        pokemon3NotShiny_rad.Checked = True
        pokemon3NotShiny_rad.Location = New Point(6, 22)
        pokemon3NotShiny_rad.Name = "pokemon3NotShiny_rad"
        pokemon3NotShiny_rad.Size = New Size(77, 19)
        pokemon3NotShiny_rad.TabIndex = 0
        pokemon3NotShiny_rad.TabStop = True
        pokemon3NotShiny_rad.Text = "Not Shiny"
        pokemon3NotShiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon3Form_lbl
        ' 
        pokemon3Form_lbl.AutoSize = True
        pokemon3Form_lbl.Location = New Point(298, 63)
        pokemon3Form_lbl.Name = "pokemon3Form_lbl"
        pokemon3Form_lbl.Size = New Size(35, 15)
        pokemon3Form_lbl.TabIndex = 67
        pokemon3Form_lbl.Text = "Form"
        ' 
        ' pg_pkmn4
        ' 
        pg_pkmn4.Controls.Add(pokemon4_grp)
        pg_pkmn4.Location = New Point(4, 24)
        pg_pkmn4.Name = "pg_pkmn4"
        pg_pkmn4.Padding = New Padding(3)
        pg_pkmn4.Size = New Size(729, 475)
        pg_pkmn4.TabIndex = 5
        pg_pkmn4.Text = "Pokémon 4"
        pg_pkmn4.UseVisualStyleBackColor = True
        ' 
        ' pokemon4_grp
        ' 
        pokemon4_grp.Controls.Add(pokemon4Level_nbr)
        pokemon4_grp.Controls.Add(pokemon4Form_nbr)
        pokemon4_grp.Controls.Add(pokemon4Happiness_nbr)
        pokemon4_grp.Controls.Add(pokemon4Shadow_grp)
        pokemon4_grp.Controls.Add(pokemon4Name_lbl)
        pokemon4_grp.Controls.Add(pokemon4EVs_grp)
        pokemon4_grp.Controls.Add(pokemon4Name_txt)
        pokemon4_grp.Controls.Add(pokemon4IVs_grp)
        pokemon4_grp.Controls.Add(pokemon4HeldItem_txt)
        pokemon4_grp.Controls.Add(pokemon4PokeballID_cmb)
        pokemon4_grp.Controls.Add(pokemon4HeldItem_lbl)
        pokemon4_grp.Controls.Add(pokemon4PokeBall_lbl)
        pokemon4_grp.Controls.Add(pokemon4Level_lbl)
        pokemon4_grp.Controls.Add(pokemon4Nickname_txt)
        pokemon4_grp.Controls.Add(pokemon4Nickname_lbl)
        pokemon4_grp.Controls.Add(pokemon4Moves_grp)
        pokemon4_grp.Controls.Add(pokemon4Ability_lbl)
        pokemon4_grp.Controls.Add(pokemon4Happiness_lbl)
        pokemon4_grp.Controls.Add(pokemon4Ability_cmb)
        pokemon4_grp.Controls.Add(pokemon4Nature_cmb)
        pokemon4_grp.Controls.Add(pokemon4Gender_lbl)
        pokemon4_grp.Controls.Add(pokemon4Nature_lbl)
        pokemon4_grp.Controls.Add(pokemon4Gender_cmb)
        pokemon4_grp.Controls.Add(pokemon4Shiny_grp)
        pokemon4_grp.Controls.Add(pokemon4Form_lbl)
        pokemon4_grp.Dock = DockStyle.Fill
        pokemon4_grp.Location = New Point(3, 3)
        pokemon4_grp.Name = "pokemon4_grp"
        pokemon4_grp.Size = New Size(723, 469)
        pokemon4_grp.TabIndex = 0
        pokemon4_grp.TabStop = False
        pokemon4_grp.Text = "Pokémon 4"
        ' 
        ' pokemon4Level_nbr
        ' 
        pokemon4Level_nbr.Location = New Point(298, 37)
        pokemon4Level_nbr.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        pokemon4Level_nbr.Name = "pokemon4Level_nbr"
        pokemon4Level_nbr.Size = New Size(140, 23)
        pokemon4Level_nbr.TabIndex = 83
        pokemon4Level_nbr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' pokemon4Form_nbr
        ' 
        pokemon4Form_nbr.Location = New Point(298, 80)
        pokemon4Form_nbr.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        pokemon4Form_nbr.Name = "pokemon4Form_nbr"
        pokemon4Form_nbr.Size = New Size(140, 23)
        pokemon4Form_nbr.TabIndex = 82
        ' 
        ' pokemon4Happiness_nbr
        ' 
        pokemon4Happiness_nbr.Location = New Point(152, 124)
        pokemon4Happiness_nbr.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        pokemon4Happiness_nbr.Name = "pokemon4Happiness_nbr"
        pokemon4Happiness_nbr.Size = New Size(140, 23)
        pokemon4Happiness_nbr.TabIndex = 81
        pokemon4Happiness_nbr.Value = New Decimal(New Integer() {70, 0, 0, 0})
        ' 
        ' pokemon4Shadow_grp
        ' 
        pokemon4Shadow_grp.Controls.Add(pokemon4Shadow_rad)
        pokemon4Shadow_grp.Controls.Add(pokemon4NotShadow_rad)
        pokemon4Shadow_grp.Location = New Point(444, 198)
        pokemon4Shadow_grp.Name = "pokemon4Shadow_grp"
        pokemon4Shadow_grp.Size = New Size(273, 82)
        pokemon4Shadow_grp.TabIndex = 80
        pokemon4Shadow_grp.TabStop = False
        pokemon4Shadow_grp.Text = "Shadow"
        ' 
        ' pokemon4Shadow_rad
        ' 
        pokemon4Shadow_rad.AutoSize = True
        pokemon4Shadow_rad.Location = New Point(6, 47)
        pokemon4Shadow_rad.Name = "pokemon4Shadow_rad"
        pokemon4Shadow_rad.Size = New Size(67, 19)
        pokemon4Shadow_rad.TabIndex = 1
        pokemon4Shadow_rad.Text = "Shadow"
        pokemon4Shadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon4NotShadow_rad
        ' 
        pokemon4NotShadow_rad.AutoSize = True
        pokemon4NotShadow_rad.Checked = True
        pokemon4NotShadow_rad.Location = New Point(6, 22)
        pokemon4NotShadow_rad.Name = "pokemon4NotShadow_rad"
        pokemon4NotShadow_rad.Size = New Size(90, 19)
        pokemon4NotShadow_rad.TabIndex = 0
        pokemon4NotShadow_rad.TabStop = True
        pokemon4NotShadow_rad.Text = "Not Shadow"
        pokemon4NotShadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon4Name_lbl
        ' 
        pokemon4Name_lbl.AutoSize = True
        pokemon4Name_lbl.Location = New Point(6, 19)
        pokemon4Name_lbl.Name = "pokemon4Name_lbl"
        pokemon4Name_lbl.Size = New Size(93, 15)
        pokemon4Name_lbl.TabIndex = 56
        pokemon4Name_lbl.Text = "Pokémon Name"
        ' 
        ' pokemon4EVs_grp
        ' 
        pokemon4EVs_grp.Controls.Add(pokemon4EVsDEF_txt)
        pokemon4EVs_grp.Controls.Add(pokemon4EVsDEF_lbl)
        pokemon4EVs_grp.Controls.Add(pokemon4EVsSPDEF_txt)
        pokemon4EVs_grp.Controls.Add(pokemon4EVsSPDEF_lbl)
        pokemon4EVs_grp.Controls.Add(pokemon4EVsSPATK_txt)
        pokemon4EVs_grp.Controls.Add(pokemon4EVsSPATK_lbl)
        pokemon4EVs_grp.Controls.Add(pokemon4EVsSPD_txt)
        pokemon4EVs_grp.Controls.Add(pokemon4EVsSPD_lbl)
        pokemon4EVs_grp.Controls.Add(pokemon4EVsATK_txt)
        pokemon4EVs_grp.Controls.Add(pokemon4EVsATK_lbl)
        pokemon4EVs_grp.Controls.Add(pokemon4EVsHP_txt)
        pokemon4EVs_grp.Controls.Add(pokemon4EVsHP_lbl)
        pokemon4EVs_grp.Location = New Point(324, 154)
        pokemon4EVs_grp.Name = "pokemon4EVs_grp"
        pokemon4EVs_grp.Size = New Size(114, 156)
        pokemon4EVs_grp.TabIndex = 79
        pokemon4EVs_grp.TabStop = False
        pokemon4EVs_grp.Text = "EVs"
        ' 
        ' pokemon4EVsDEF_txt
        ' 
        pokemon4EVsDEF_txt.Location = New Point(6, 125)
        pokemon4EVsDEF_txt.MaxLength = 3
        pokemon4EVsDEF_txt.Name = "pokemon4EVsDEF_txt"
        pokemon4EVsDEF_txt.Size = New Size(44, 23)
        pokemon4EVsDEF_txt.TabIndex = 11
        pokemon4EVsDEF_txt.Text = "0"
        ' 
        ' pokemon4EVsDEF_lbl
        ' 
        pokemon4EVsDEF_lbl.AutoSize = True
        pokemon4EVsDEF_lbl.Location = New Point(14, 107)
        pokemon4EVsDEF_lbl.Name = "pokemon4EVsDEF_lbl"
        pokemon4EVsDEF_lbl.Size = New Size(27, 15)
        pokemon4EVsDEF_lbl.TabIndex = 10
        pokemon4EVsDEF_lbl.Text = "DEF"
        ' 
        ' pokemon4EVsSPDEF_txt
        ' 
        pokemon4EVsSPDEF_txt.Location = New Point(55, 125)
        pokemon4EVsSPDEF_txt.MaxLength = 3
        pokemon4EVsSPDEF_txt.Name = "pokemon4EVsSPDEF_txt"
        pokemon4EVsSPDEF_txt.Size = New Size(44, 23)
        pokemon4EVsSPDEF_txt.TabIndex = 9
        pokemon4EVsSPDEF_txt.Text = "0"
        ' 
        ' pokemon4EVsSPDEF_lbl
        ' 
        pokemon4EVsSPDEF_lbl.AutoSize = True
        pokemon4EVsSPDEF_lbl.Location = New Point(55, 109)
        pokemon4EVsSPDEF_lbl.Name = "pokemon4EVsSPDEF_lbl"
        pokemon4EVsSPDEF_lbl.Size = New Size(40, 15)
        pokemon4EVsSPDEF_lbl.TabIndex = 8
        pokemon4EVsSPDEF_lbl.Text = "SPDEF"
        ' 
        ' pokemon4EVsSPATK_txt
        ' 
        pokemon4EVsSPATK_txt.Location = New Point(55, 81)
        pokemon4EVsSPATK_txt.MaxLength = 3
        pokemon4EVsSPATK_txt.Name = "pokemon4EVsSPATK_txt"
        pokemon4EVsSPATK_txt.Size = New Size(44, 23)
        pokemon4EVsSPATK_txt.TabIndex = 7
        pokemon4EVsSPATK_txt.Text = "0"
        ' 
        ' pokemon4EVsSPATK_lbl
        ' 
        pokemon4EVsSPATK_lbl.AutoSize = True
        pokemon4EVsSPATK_lbl.Location = New Point(56, 65)
        pokemon4EVsSPATK_lbl.Name = "pokemon4EVsSPATK_lbl"
        pokemon4EVsSPATK_lbl.Size = New Size(39, 15)
        pokemon4EVsSPATK_lbl.TabIndex = 6
        pokemon4EVsSPATK_lbl.Text = "SPATK"
        ' 
        ' pokemon4EVsSPD_txt
        ' 
        pokemon4EVsSPD_txt.Location = New Point(55, 37)
        pokemon4EVsSPD_txt.MaxLength = 3
        pokemon4EVsSPD_txt.Name = "pokemon4EVsSPD_txt"
        pokemon4EVsSPD_txt.Size = New Size(44, 23)
        pokemon4EVsSPD_txt.TabIndex = 5
        pokemon4EVsSPD_txt.Text = "0"
        ' 
        ' pokemon4EVsSPD_lbl
        ' 
        pokemon4EVsSPD_lbl.AutoSize = True
        pokemon4EVsSPD_lbl.Location = New Point(63, 21)
        pokemon4EVsSPD_lbl.Name = "pokemon4EVsSPD_lbl"
        pokemon4EVsSPD_lbl.Size = New Size(28, 15)
        pokemon4EVsSPD_lbl.TabIndex = 4
        pokemon4EVsSPD_lbl.Text = "SPD"
        ' 
        ' pokemon4EVsATK_txt
        ' 
        pokemon4EVsATK_txt.Location = New Point(6, 81)
        pokemon4EVsATK_txt.MaxLength = 3
        pokemon4EVsATK_txt.Name = "pokemon4EVsATK_txt"
        pokemon4EVsATK_txt.Size = New Size(44, 23)
        pokemon4EVsATK_txt.TabIndex = 3
        pokemon4EVsATK_txt.Text = "0"
        ' 
        ' pokemon4EVsATK_lbl
        ' 
        pokemon4EVsATK_lbl.AutoSize = True
        pokemon4EVsATK_lbl.Location = New Point(14, 63)
        pokemon4EVsATK_lbl.Name = "pokemon4EVsATK_lbl"
        pokemon4EVsATK_lbl.Size = New Size(27, 15)
        pokemon4EVsATK_lbl.TabIndex = 2
        pokemon4EVsATK_lbl.Text = "ATK"
        ' 
        ' pokemon4EVsHP_txt
        ' 
        pokemon4EVsHP_txt.Location = New Point(6, 37)
        pokemon4EVsHP_txt.MaxLength = 3
        pokemon4EVsHP_txt.Name = "pokemon4EVsHP_txt"
        pokemon4EVsHP_txt.Size = New Size(44, 23)
        pokemon4EVsHP_txt.TabIndex = 1
        pokemon4EVsHP_txt.Text = "0"
        ' 
        ' pokemon4EVsHP_lbl
        ' 
        pokemon4EVsHP_lbl.AutoSize = True
        pokemon4EVsHP_lbl.Location = New Point(16, 19)
        pokemon4EVsHP_lbl.Name = "pokemon4EVsHP_lbl"
        pokemon4EVsHP_lbl.Size = New Size(23, 15)
        pokemon4EVsHP_lbl.TabIndex = 0
        pokemon4EVsHP_lbl.Text = "HP"
        ' 
        ' pokemon4Name_txt
        ' 
        pokemon4Name_txt.AutoCompleteCustomSource.AddRange(New String() {"BULBASAUR", "IVYSAUR", "VENUSAUR", "CHARMANDER", "CHARMELEON", "CHARIZARD", "SQUIRTLE", "WARTORTLE", "BLASTOISE", "CATERPIE", "METAPOD", "BUTTERFREE", "WEEDLE", "KAKUNA", "BEEDRILL", "PIDGEY", "PIDGEOTTO", "PIDGEOT", "RATTATA", "RATICATE", "SPEAROW", "FEAROW", "EKANS", "ARBOK", "PIKACHU", "RAICHU", "SANDSHREW", "SANDSLASH", "NIDORANfE", "NIDORINA", "NIDOQUEEN", "NIDORANmA", "NIDORINO", "NIDOKING", "CLEFAIRY", "CLEFABLE", "VULPIX", "NINETALES", "JIGGLYPUFF", "WIGGLYTUFF", "ZUBAT", "GOLBAT", "ODDISH", "GLOOM", "VILEPLUME", "PARAS", "PARASECT", "VENONAT", "VENOMOTH", "DIGLETT", "DUGTRIO", "MEOWTH", "PERSIAN", "PSYDUCK", "GOLDUCK", "MANKEY", "PRIMEAPE", "GROWLITHE", "ARCANINE", "POLIWAG", "POLIWHIRL", "POLIWRATH", "ABRA", "KADABRA", "ALAKAZAM", "MACHOP", "MACHOKE", "MACHAMP", "BELLSPROUT", "WEEPINBELL", "VICTREEBEL", "TENTACOOL", "TENTACRUEL", "GEODUDE", "GRAVELER", "GOLEM", "PONYTA", "RAPIDASH", "SLOWPOKE", "SLOWBRO", "MAGNEMITE", "MAGNETON", "FARFETCHD", "DODUO", "DODRIO", "SEEL", "DEWGONG", "GRIMER", "MUK", "SHELLDER", "CLOYSTER", "GASTLY", "HAUNTER", "GENGAR", "ONIX", "DROWZEE", "HYPNO", "KRABBY", "KINGLER", "VOLTORB", "ELECTRODE", "EXEGGCUTE", "EXEGGUTOR", "CUBONE", "MAROWAK", "HITMONLEE", "HITMONCHAN", "LICKITUNG", "KOFFING", "WEEZING", "RHYHORN", "RHYDON", "CHANSEY", "TANGELA", "KANGASKHAN", "HORSEA", "SEADRA", "GOLDEEN", "SEAKING", "STARYU", "STARMIE", "MRMIME", "SCYTHER", "JYNX", "ELECTABUZZ", "MAGMAR", "PINSIR", "TAUROS", "MAGIKARP", "GYARADOS", "LAPRAS", "DITTO", "EEVEE", "VAPOREON", "JOLTEON", "FLAREON", "PORYGON", "OMANYTE", "OMASTAR", "KABUTO", "KABUTOPS", "AERODACTYL", "SNORLAX", "ARTICUNO", "ZAPDOS", "MOLTRES", "DRATINI", "DRAGONAIR", "DRAGONITE", "MEWTWO", "MEW", "CHIKORITA", "BAYLEEF", "MEGANIUM", "CYNDAQUIL", "QUILAVA", "TYPHLOSION", "TOTODILE", "CROCONAW", "FERALIGATR", "SENTRET", "FURRET", "HOOTHOOT", "NOCTOWL", "LEDYBA", "LEDIAN", "SPINARAK", "ARIADOS", "CROBAT", "CHINCHOU", "LANTURN", "PICHU", "CLEFFA", "IGGLYBUFF", "TOGEPI", "TOGETIC", "NATU", "XATU", "MAREEP", "FLAAFFY", "AMPHAROS", "BELLOSSOM", "MARILL", "AZUMARILL", "SUDOWOODO", "POLITOED", "HOPPIP", "SKIPLOOM", "JUMPLUFF", "AIPOM", "SUNKERN", "SUNFLORA", "YANMA", "WOOPER", "QUAGSIRE", "ESPEON", "UMBREON", "MURKROW", "SLOWKING", "MISDREAVUS", "UNOWN", "WOBBUFFET", "GIRAFARIG", "PINECO", "FORRETRESS", "DUNSPARCE", "GLIGAR", "STEELIX", "SNUBBULL", "GRANBULL", "QWILFISH", "SCIZOR", "SHUCKLE", "HERACROSS", "SNEASEL", "TEDDIURSA", "URSARING", "SLUGMA", "MAGCARGO", "SWINUB", "PILOSWINE", "CORSOLA", "REMORAID", "OCTILLERY", "DELIBIRD", "MANTINE", "SKARMORY", "HOUNDOUR", "HOUNDOOM", "KINGDRA", "PHANPY", "DONPHAN", "PORYGON2", "STANTLER", "SMEARGLE", "TYROGUE", "HITMONTOP", "SMOOCHUM", "ELEKID", "MAGBY", "MILTANK", "BLISSEY", "RAIKOU", "ENTEI", "SUICUNE", "LARVITAR", "PUPITAR", "TYRANITAR", "LUGIA", "HO-OH", "CELEBI", "TREECKO", "GROVYLE", "SCEPTILE", "TORCHIC", "COMBUSKEN", "BLAZIKEN", "MUDKIP", "MARSHTOMP", "SWAMPERT", "POOCHYENA", "MIGHTYENA", "ZIGZAGOON", "LINOONE", "WURMPLE", "SILCOON", "BEAUTIFLY", "CASCOON", "DUSTOX", "LOTAD", "LOMBRE", "LUDICOLO", "SEEDOT", "NUZLEAF", "SHIFTRY", "TAILLOW", "SWELLOW", "WINGULL", "PELIPPER", "RALTS", "KIRLIA", "GARDEVOIR", "SURSKIT", "MASQUERAIN", "SHROOMISH", "BRELOOM", "SLAKOTH", "VIGOROTH", "SLAKING", "NINCADA", "NINJASK", "SHEDINJA", "WHISMUR", "LOUDRED", "EXPLOUD", "MAKUHITA", "HARIYAMA", "AZURILL", "NOSEPASS", "SKITTY", "DELCATTY", "SABLEYE", "MAWILE", "ARON", "LAIRON", "AGGRON", "MEDITITE", "MEDICHAM", "ELECTRIKE", "MANECTRIC", "PLUSLE", "MINUN", "VOLBEAT", "ILLUMISE", "ROSELIA", "GULPIN", "SWALOT", "CARVANHA", "SHARPEDO", "WAILMER", "WAILORD", "NUMEL", "CAMERUPT", "TORKOAL", "SPOINK", "GRUMPIG", "SPINDA", "TRAPINCH", "VIBRAVA", "FLYGON", "CACNEA", "CACTURNE", "SWABLU", "ALTARIA", "ZANGOOSE", "SEVIPER", "LUNATONE", "SOLROCK", "BARBOACH", "WHISCASH", "CORPHISH", "CRAWDAUNT", "BALTOY", "CLAYDOL", "LILEEP", "CRADILY", "ANORITH", "ARMALDO", "FEEBAS", "MILOTIC", "CASTFORM", "KECLEON", "SHUPPET", "BANETTE", "DUSKULL", "DUSCLOPS", "TROPIUS", "CHIMECHO", "ABSOL", "WYNAUT", "SNORUNT", "GLALIE", "SPHEAL", "SEALEO", "WALREIN", "CLAMPERL", "HUNTAIL", "GOREBYSS", "RELICANTH", "LUVDISC", "BAGON", "SHELGON", "SALAMENCE", "BELDUM", "METANG", "METAGROSS", "REGIROCK", "REGICE", "REGISTEEL", "LATIAS", "LATIOS", "KYOGRE", "GROUDON", "RAYQUAZA", "JIRACHI", "DEOXYS", "TURTWIG", "GROTLE", "TORTERRA", "CHIMCHAR", "MONFERNO", "INFERNAPE", "PIPLUP", "PRINPLUP", "EMPOLEON", "STARLY", "STARAVIA", "STARAPTOR", "BIDOOF", "BIBAREL", "KRICKETOT", "KRICKETUNE", "SHINX", "LUXIO", "LUXRAY", "BUDEW", "ROSERADE", "CRANIDOS", "RAMPARDOS", "SHIELDON", "BASTIODON", "BURMY", "WORMADAM", "MOTHIM", "COMBEE", "VESPIQUEN", "PACHIRISU", "BUIZEL", "FLOATZEL", "CHERUBI", "CHERRIM", "SHELLOS", "GASTRODON", "AMBIPOM", "DRIFLOON", "DRIFBLIM", "BUNEARY", "LOPUNNY", "MISMAGIUS", "HONCHKROW", "GLAMEOW", "PURUGLY", "CHINGLING", "STUNKY", "SKUNTANK", "BRONZOR", "BRONZONG", "BONSLY", "MIMEJR", "HAPPINY", "CHATOT", "SPIRITOMB", "GIBLE", "GABITE", "GARCHOMP", "MUNCHLAX", "RIOLU", "LUCARIO", "HIPPOPOTAS", "HIPPOWDON", "SKORUPI", "DRAPION", "CROAGUNK", "TOXICROAK", "CARNIVINE", "FINNEON", "LUMINEON", "MANTYKE", "SNOVER", "ABOMASNOW", "WEAVILE", "MAGNEZONE", "LICKILICKY", "RHYPERIOR", "TANGROWTH", "ELECTIVIRE", "MAGMORTAR", "TOGEKISS", "YANMEGA", "LEAFEON", "GLACEON", "GLISCOR", "MAMOSWINE", "PORYGON-Z", "GALLADE", "PROBOPASS", "DUSKNOIR", "FROSLASS", "ROTOM", "UXIE", "MESPRIT", "AZELF", "DIALGA", "PALKIA", "HEATRAN", "REGIGIGAS", "GIRATINA", "CRESSELIA", "PHIONE", "MANAPHY", "DARKRAI", "SHAYMIN", "ARCEUS", "VICTINI", "SNIVY", "SERVINE", "SERPERIOR", "TEPIG", "PIGNITE", "EMBOAR", "OSHAWOTT", "DEWOTT", "SAMUROTT", "PATRAT", "WATCHOG", "LILLIPUP", "HERDIER", "STOUTLAND", "PURRLOIN", "LIEPARD", "PANSAGE", "SIMISAGE", "PANSEAR", "SIMISEAR", "PANPOUR", "SIMIPOUR", "MUNNA", "MUSHARNA", "PIDOVE", "TRANQUILL", "UNFEZANT", "BLITZLE", "ZEBSTRIKA", "ROGGENROLA", "BOLDORE", "GIGALITH", "WOOBAT", "SWOOBAT", "DRILBUR", "EXCADRILL", "AUDINO", "TIMBURR", "GURDURR", "CONKELDURR", "TYMPOLE", "PALPITOAD", "SEISMITOAD", "THROH", "SAWK", "SEWADDLE", "SWADLOON", "LEAVANNY", "VENIPEDE", "WHIRLIPEDE", "SCOLIPEDE", "COTTONEE", "WHIMSICOTT", "PETILIL", "LILLIGANT", "BASCULIN", "SANDILE", "KROKOROK", "KROOKODILE", "DARUMAKA", "DARMANITAN", "MARACTUS", "DWEBBLE", "CRUSTLE", "SCRAGGY", "SCRAFTY", "SIGILYPH", "YAMASK", "COFAGRIGUS", "TIRTOUGA", "CARRACOSTA", "ARCHEN", "ARCHEOPS", "TRUBBISH", "GARBODOR", "ZORUA", "ZOROARK", "MINCCINO", "CINCCINO", "GOTHITA", "GOTHORITA", "GOTHITELLE", "SOLOSIS", "DUOSION", "REUNICLUS", "DUCKLETT", "SWANNA", "VANILLITE", "VANILLISH", "VANILLUXE", "DEERLING", "SAWSBUCK", "EMOLGA", "KARRABLAST", "ESCAVALIER", "FOONGUS", "AMOONGUSS", "FRILLISH", "JELLICENT", "ALOMOMOLA", "JOLTIK", "GALVANTULA", "FERROSEED", "FERROTHORN", "KLINK", "KLANG", "KLINKLANG", "TYNAMO", "EELEKTRIK", "EELEKTROSS", "ELGYEM", "BEHEEYEM", "LITWICK", "LAMPENT", "CHANDELURE", "AXEW", "FRAXURE", "HAXORUS", "CUBCHOO", "BEARTIC", "CRYOGONAL", "SHELMET", "ACCELGOR", "STUNFISK", "MIENFOO", "MIENSHAO", "DRUDDIGON", "GOLETT", "GOLURK", "PAWNIARD", "BISHARP", "BOUFFALANT", "RUFFLET", "BRAVIARY", "VULLABY", "MANDIBUZZ", "HEATMOR", "DURANT", "DEINO", "ZWEILOUS", "HYDREIGON", "LARVESTA", "VOLCARONA", "COBALION", "TERRAKION", "VIRIZION", "TORNADUS", "THUNDURUS", "RESHIRAM", "ZEKROM", "LANDORUS", "KYUREM", "KELDEO", "MELOETTA", "GENESECT", "CHESPIN", "QUILLADIN", "CHESNAUGHT", "FENNEKIN", "BRAIXEN", "DELPHOX", "FROAKIE", "FROGADIER", "GRENINJA", "BUNNELBY", "DIGGERSBY", "FLETCHLING", "FLETCHINDER", "TALONFLAME", "SCATTERBUG", "SPEWPA", "VIVILLON", "LITLEO", "PYROAR", "FLABEBE", "FLOETTE", "FLORGES", "SKIDDO", "GOGOAT", "PANCHAM", "PANGORO", "FURFROU", "ESPURR", "MEOWSTIC", "HONEDGE", "DOUBLADE", "AEGISLASH", "SPRITZEE", "AROMATISSE", "SWIRLIX", "SLURPUFF", "INKAY", "MALAMAR", "BINACLE", "BARBARACLE", "SKRELP", "DRAGALGE", "CLAUNCHER", "CLAWITZER", "HELIOPTILE", "HELIOLISK", "TYRUNT", "TYRANTRUM", "AMAURA", "AURORUS", "SYLVEON", "HAWLUCHA", "DEDENNE", "CARBINK", "GOOMY", "SLIGGOO", "GOODRA", "KLEFKI", "PHANTUMP", "TREVENANT", "PUMPKABOO", "GOURGEIST", "BERGMITE", "AVALUGG", "NOIBAT", "NOIVERN", "XERNEAS", "YVELTAL", "ZYGARDE", "DIANCIE", "HOOPA", "VOLCANION", "ROWLET", "DARTRIX", "DECIDUEYE", "LITTEN", "TORRACAT", "INCINEROAR", "POPPLIO", "BRIONNE", "PRIMARINA", "PIKIPEK", "TRUMBEAK", "TOUCANNON", "YUNGOOS", "GUMSHOOS", "GRUBBIN", "CHARJABUG", "VIKAVOLT", "CRABRAWLER", "CRABOMINABLE", "ORICORIO", "CUTIEFLY", "RIBOMBEE", "ROCKRUFF", "LYCANROC", "WISHIWASHI", "MAREANIE", "TOXAPEX", "MUDBRAY", "MUDSDALE", "DEWPIDER", "ARAQUANID", "FOMANTIS", "LURANTIS", "MORELULL", "SHIINOTIC", "SALANDIT", "SALAZZLE", "STUFFUL", "BEWEAR", "BOUNSWEET", "STEENEE", "TSAREENA", "COMFEY", "ORANGURU", "PASSIMIAN", "WIMPOD", "GOLISOPOD", "SANDYGAST", "PALOSSAND", "PYUKUMUKU", "TYPENULL", "SILVALLY", "MINIOR", "KOMALA", "TURTONATOR", "TOGEDEMARU", "MIMIKYU", "BRUXISH", "DRAMPA", "DHELMISE", "JANGMO-O", "HAKAMO-O", "KOMMO-O", "TAPUKOKO", "TAPULELE", "TAPUBULU", "TAPUFINI", "COSMOG", "COSMOEM", "SOLGALEO", "LUNALA", "NIHILEGO", "BUZZWOLE", "PHEROMOSA", "XURKITREE", "CELESTEELA", "KARTANA", "GUZZLORD", "NECROZMA", "MAGEARNA", "MARSHADOW", "POIPOLE", "NAGANADEL", "STAKATAKA", "BLACEPHALON", "ZERAORA", "MELTAN", "MELMETAL", "GROOKEY", "THWACKEY", "RILLABOOM", "SCORBUNNY", "RABOOT", "CINDERACE", "SOBBLE", "DRIZZILE", "INTELEON", "SKWOVET", "GREEDENT", "ROOKIDEE", "CORVISQUIRE", "CORVIKNIGHT", "BLIPBUG", "DOTTLER", "ORBEETLE", "NICKIT", "THIEVUL", "GOSSIFLEUR", "ELDEGOSS", "WOOLOO", "DUBWOOL", "CHEWTLE", "DREDNAW", "YAMPER", "BOLTUND", "ROLYCOLY", "CARKOL", "COALOSSAL", "APPLIN", "FLAPPLE", "APPLETUN", "SILICOBRA", "SANDACONDA", "CRAMORANT", "ARROKUDA", "BARRASKEWDA", "TOXEL", "TOXTRICITY", "SIZZLIPEDE", "CENTISKORCH", "CLOBBOPUS", "GRAPPLOCT", "SINISTEA", "POLTEAGEIST", "HATENNA", "HATTREM", "HATTERENE", "IMPIDIMP", "MORGREM", "GRIMMSNARL", "OBSTAGOON", "PERRSERKER", "CURSOLA", "SIRFETCHD", "MRRIME", "RUNERIGUS", "MILCERY", "ALCREMIE", "FALINKS", "PINCURCHIN", "SNOM", "FROSMOTH", "STONJOURNER", "EISCUE", "INDEEDEE", "MORPEKO", "CUFANT", "COPPERAJAH", "DRACOZOLT", "ARCTOZOLT", "DRACOVISH", "ARCTOVISH", "DURALUDON", "DREEPY", "DRAKLOAK", "DRAGAPULT", "ZACIAN", "ZAMAZENTA", "ETERNATUS", "KUBFU", "URSHIFU", "ZARUDE", "REGIELEKI", "REGIDRAGO", "GLASTRIER", "SPECTRIER", "CALYREX"})
        pokemon4Name_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon4Name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon4Name_txt.Location = New Point(6, 37)
        pokemon4Name_txt.Name = "pokemon4Name_txt"
        pokemon4Name_txt.PlaceholderText = "Bulbasaur"
        pokemon4Name_txt.Size = New Size(140, 23)
        pokemon4Name_txt.TabIndex = 57
        ' 
        ' pokemon4IVs_grp
        ' 
        pokemon4IVs_grp.Controls.Add(pokemon4RandomIVs_btn)
        pokemon4IVs_grp.Controls.Add(pokemon4MaxIVs_btn)
        pokemon4IVs_grp.Controls.Add(pokemon4IVsDEF_txt)
        pokemon4IVs_grp.Controls.Add(pokemon4IVsDEF_lbl)
        pokemon4IVs_grp.Controls.Add(pokemon4IVsSPDEF_txt)
        pokemon4IVs_grp.Controls.Add(pokemon4IVsSPDEF_lbl)
        pokemon4IVs_grp.Controls.Add(pokemon4IVsSPATK_txt)
        pokemon4IVs_grp.Controls.Add(pokemon4IVsSPATK_lbl)
        pokemon4IVs_grp.Controls.Add(pokemon4IVsSPD_txt)
        pokemon4IVs_grp.Controls.Add(pokemon4IVsSPD_lbl)
        pokemon4IVs_grp.Controls.Add(pokemon4IVsATK_txt)
        pokemon4IVs_grp.Controls.Add(pokemon4IVsATK_lbl)
        pokemon4IVs_grp.Controls.Add(pokemon4IVsHP_txt)
        pokemon4IVs_grp.Controls.Add(pokemon4IVsHP_lbl)
        pokemon4IVs_grp.Location = New Point(204, 154)
        pokemon4IVs_grp.Name = "pokemon4IVs_grp"
        pokemon4IVs_grp.Size = New Size(114, 188)
        pokemon4IVs_grp.TabIndex = 78
        pokemon4IVs_grp.TabStop = False
        pokemon4IVs_grp.Text = "IVs (Max 31 Each)"
        ' 
        ' pokemon4RandomIVs_btn
        ' 
        pokemon4RandomIVs_btn.Location = New Point(57, 152)
        pokemon4RandomIVs_btn.Name = "pokemon4RandomIVs_btn"
        pokemon4RandomIVs_btn.Size = New Size(44, 23)
        pokemon4RandomIVs_btn.TabIndex = 15
        pokemon4RandomIVs_btn.Text = "Rand"
        pokemon4RandomIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon4MaxIVs_btn
        ' 
        pokemon4MaxIVs_btn.Location = New Point(7, 152)
        pokemon4MaxIVs_btn.Name = "pokemon4MaxIVs_btn"
        pokemon4MaxIVs_btn.Size = New Size(44, 23)
        pokemon4MaxIVs_btn.TabIndex = 14
        pokemon4MaxIVs_btn.Text = "Max"
        pokemon4MaxIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon4IVsDEF_txt
        ' 
        pokemon4IVsDEF_txt.Location = New Point(7, 123)
        pokemon4IVsDEF_txt.MaxLength = 3
        pokemon4IVsDEF_txt.Name = "pokemon4IVsDEF_txt"
        pokemon4IVsDEF_txt.Size = New Size(44, 23)
        pokemon4IVsDEF_txt.TabIndex = 13
        pokemon4IVsDEF_txt.Text = "0"
        ' 
        ' pokemon4IVsDEF_lbl
        ' 
        pokemon4IVsDEF_lbl.AutoSize = True
        pokemon4IVsDEF_lbl.Location = New Point(18, 105)
        pokemon4IVsDEF_lbl.Name = "pokemon4IVsDEF_lbl"
        pokemon4IVsDEF_lbl.Size = New Size(27, 15)
        pokemon4IVsDEF_lbl.TabIndex = 12
        pokemon4IVsDEF_lbl.Text = "DEF"
        ' 
        ' pokemon4IVsSPDEF_txt
        ' 
        pokemon4IVsSPDEF_txt.Location = New Point(57, 123)
        pokemon4IVsSPDEF_txt.MaxLength = 3
        pokemon4IVsSPDEF_txt.Name = "pokemon4IVsSPDEF_txt"
        pokemon4IVsSPDEF_txt.Size = New Size(44, 23)
        pokemon4IVsSPDEF_txt.TabIndex = 9
        pokemon4IVsSPDEF_txt.Text = "0"
        ' 
        ' pokemon4IVsSPDEF_lbl
        ' 
        pokemon4IVsSPDEF_lbl.AutoSize = True
        pokemon4IVsSPDEF_lbl.Location = New Point(59, 105)
        pokemon4IVsSPDEF_lbl.Name = "pokemon4IVsSPDEF_lbl"
        pokemon4IVsSPDEF_lbl.Size = New Size(40, 15)
        pokemon4IVsSPDEF_lbl.TabIndex = 8
        pokemon4IVsSPDEF_lbl.Text = "SPDEF"
        ' 
        ' pokemon4IVsSPATK_txt
        ' 
        pokemon4IVsSPATK_txt.Location = New Point(57, 79)
        pokemon4IVsSPATK_txt.MaxLength = 3
        pokemon4IVsSPATK_txt.Name = "pokemon4IVsSPATK_txt"
        pokemon4IVsSPATK_txt.Size = New Size(44, 23)
        pokemon4IVsSPATK_txt.TabIndex = 7
        pokemon4IVsSPATK_txt.Text = "0"
        ' 
        ' pokemon4IVsSPATK_lbl
        ' 
        pokemon4IVsSPATK_lbl.AutoSize = True
        pokemon4IVsSPATK_lbl.Location = New Point(59, 61)
        pokemon4IVsSPATK_lbl.Name = "pokemon4IVsSPATK_lbl"
        pokemon4IVsSPATK_lbl.Size = New Size(39, 15)
        pokemon4IVsSPATK_lbl.TabIndex = 6
        pokemon4IVsSPATK_lbl.Text = "SPATK"
        ' 
        ' pokemon4IVsSPD_txt
        ' 
        pokemon4IVsSPD_txt.Location = New Point(57, 35)
        pokemon4IVsSPD_txt.MaxLength = 3
        pokemon4IVsSPD_txt.Name = "pokemon4IVsSPD_txt"
        pokemon4IVsSPD_txt.Size = New Size(44, 23)
        pokemon4IVsSPD_txt.TabIndex = 5
        pokemon4IVsSPD_txt.Text = "0"
        ' 
        ' pokemon4IVsSPD_lbl
        ' 
        pokemon4IVsSPD_lbl.AutoSize = True
        pokemon4IVsSPD_lbl.Location = New Point(65, 17)
        pokemon4IVsSPD_lbl.Name = "pokemon4IVsSPD_lbl"
        pokemon4IVsSPD_lbl.Size = New Size(28, 15)
        pokemon4IVsSPD_lbl.TabIndex = 4
        pokemon4IVsSPD_lbl.Text = "SPD"
        ' 
        ' pokemon4IVsATK_txt
        ' 
        pokemon4IVsATK_txt.Location = New Point(7, 79)
        pokemon4IVsATK_txt.MaxLength = 3
        pokemon4IVsATK_txt.Name = "pokemon4IVsATK_txt"
        pokemon4IVsATK_txt.Size = New Size(44, 23)
        pokemon4IVsATK_txt.TabIndex = 3
        pokemon4IVsATK_txt.Text = "0"
        ' 
        ' pokemon4IVsATK_lbl
        ' 
        pokemon4IVsATK_lbl.AutoSize = True
        pokemon4IVsATK_lbl.Location = New Point(18, 61)
        pokemon4IVsATK_lbl.Name = "pokemon4IVsATK_lbl"
        pokemon4IVsATK_lbl.Size = New Size(27, 15)
        pokemon4IVsATK_lbl.TabIndex = 2
        pokemon4IVsATK_lbl.Text = "ATK"
        ' 
        ' pokemon4IVsHP_txt
        ' 
        pokemon4IVsHP_txt.Location = New Point(7, 35)
        pokemon4IVsHP_txt.MaxLength = 3
        pokemon4IVsHP_txt.Name = "pokemon4IVsHP_txt"
        pokemon4IVsHP_txt.Size = New Size(44, 23)
        pokemon4IVsHP_txt.TabIndex = 1
        pokemon4IVsHP_txt.Text = "0"
        ' 
        ' pokemon4IVsHP_lbl
        ' 
        pokemon4IVsHP_lbl.AutoSize = True
        pokemon4IVsHP_lbl.Location = New Point(18, 19)
        pokemon4IVsHP_lbl.Name = "pokemon4IVsHP_lbl"
        pokemon4IVsHP_lbl.Size = New Size(23, 15)
        pokemon4IVsHP_lbl.TabIndex = 0
        pokemon4IVsHP_lbl.Text = "HP"
        ' 
        ' pokemon4HeldItem_txt
        ' 
        pokemon4HeldItem_txt.Location = New Point(152, 37)
        pokemon4HeldItem_txt.Name = "pokemon4HeldItem_txt"
        pokemon4HeldItem_txt.PlaceholderText = "FocusSash"
        pokemon4HeldItem_txt.Size = New Size(140, 23)
        pokemon4HeldItem_txt.TabIndex = 58
        ' 
        ' pokemon4PokeballID_cmb
        ' 
        pokemon4PokeballID_cmb.FormattingEnabled = True
        pokemon4PokeballID_cmb.Items.AddRange(New Object() {"POKEBALL", "GREATBALL", "SAFARIBALL", "ULTRABALL", "MASTERBALL", "NETBALL", "DIVEBALL", "NESTBALL", "REPEATBALL", "TIMERBALL", "LUXURYBALL", "PREMIERBALL", "DUSKBALL", "HEALBALL", "QUICKBALL", "CHERISHBALL", "FASTBALL", "LEVELBALL", "LUREBALL", "HEAVYBALL", "LOVEBALL", "FRIENDBALL", "MOONBALL", "SPORTBALL", "DREAMBALL", "BEASTBALL"})
        pokemon4PokeballID_cmb.Location = New Point(6, 169)
        pokemon4PokeballID_cmb.Name = "pokemon4PokeballID_cmb"
        pokemon4PokeballID_cmb.Size = New Size(140, 23)
        pokemon4PokeballID_cmb.TabIndex = 77
        ' 
        ' pokemon4HeldItem_lbl
        ' 
        pokemon4HeldItem_lbl.AutoSize = True
        pokemon4HeldItem_lbl.Location = New Point(152, 19)
        pokemon4HeldItem_lbl.Name = "pokemon4HeldItem_lbl"
        pokemon4HeldItem_lbl.Size = New Size(59, 15)
        pokemon4HeldItem_lbl.TabIndex = 59
        pokemon4HeldItem_lbl.Text = "Held Item"
        ' 
        ' pokemon4PokeBall_lbl
        ' 
        pokemon4PokeBall_lbl.AutoSize = True
        pokemon4PokeBall_lbl.Location = New Point(8, 151)
        pokemon4PokeBall_lbl.Name = "pokemon4PokeBall_lbl"
        pokemon4PokeBall_lbl.Size = New Size(52, 15)
        pokemon4PokeBall_lbl.TabIndex = 76
        pokemon4PokeBall_lbl.Text = "PokéBall"
        ' 
        ' pokemon4Level_lbl
        ' 
        pokemon4Level_lbl.AutoSize = True
        pokemon4Level_lbl.Location = New Point(298, 19)
        pokemon4Level_lbl.Name = "pokemon4Level_lbl"
        pokemon4Level_lbl.Size = New Size(34, 15)
        pokemon4Level_lbl.TabIndex = 60
        pokemon4Level_lbl.Text = "Level"
        ' 
        ' pokemon4Nickname_txt
        ' 
        pokemon4Nickname_txt.Location = New Point(298, 125)
        pokemon4Nickname_txt.Name = "pokemon4Nickname_txt"
        pokemon4Nickname_txt.PlaceholderText = "Bloom"
        pokemon4Nickname_txt.Size = New Size(140, 23)
        pokemon4Nickname_txt.TabIndex = 75
        ' 
        ' pokemon4Nickname_lbl
        ' 
        pokemon4Nickname_lbl.AutoSize = True
        pokemon4Nickname_lbl.Location = New Point(298, 107)
        pokemon4Nickname_lbl.Name = "pokemon4Nickname_lbl"
        pokemon4Nickname_lbl.Size = New Size(61, 15)
        pokemon4Nickname_lbl.TabIndex = 74
        pokemon4Nickname_lbl.Text = "Nickname"
        ' 
        ' pokemon4Moves_grp
        ' 
        pokemon4Moves_grp.Controls.Add(pokemon4Move4_txtBox)
        pokemon4Moves_grp.Controls.Add(pokemon4Move3_txtBox)
        pokemon4Moves_grp.Controls.Add(pokemon4Move2_txtBox)
        pokemon4Moves_grp.Controls.Add(pokemon4Move1_txtBox)
        pokemon4Moves_grp.Location = New Point(444, 22)
        pokemon4Moves_grp.Name = "pokemon4Moves_grp"
        pokemon4Moves_grp.Size = New Size(273, 82)
        pokemon4Moves_grp.TabIndex = 62
        pokemon4Moves_grp.TabStop = False
        pokemon4Moves_grp.Text = "Moves"
        ' 
        ' pokemon4Move4_txtBox
        ' 
        pokemon4Move4_txtBox.Location = New Point(132, 51)
        pokemon4Move4_txtBox.Name = "pokemon4Move4_txtBox"
        pokemon4Move4_txtBox.PlaceholderText = "Move 4"
        pokemon4Move4_txtBox.Size = New Size(120, 23)
        pokemon4Move4_txtBox.TabIndex = 3
        ' 
        ' pokemon4Move3_txtBox
        ' 
        pokemon4Move3_txtBox.Location = New Point(6, 51)
        pokemon4Move3_txtBox.Name = "pokemon4Move3_txtBox"
        pokemon4Move3_txtBox.PlaceholderText = "Move 3"
        pokemon4Move3_txtBox.Size = New Size(120, 23)
        pokemon4Move3_txtBox.TabIndex = 2
        ' 
        ' pokemon4Move2_txtBox
        ' 
        pokemon4Move2_txtBox.Location = New Point(132, 22)
        pokemon4Move2_txtBox.Name = "pokemon4Move2_txtBox"
        pokemon4Move2_txtBox.PlaceholderText = "Move 2"
        pokemon4Move2_txtBox.Size = New Size(120, 23)
        pokemon4Move2_txtBox.TabIndex = 1
        ' 
        ' pokemon4Move1_txtBox
        ' 
        pokemon4Move1_txtBox.Location = New Point(6, 22)
        pokemon4Move1_txtBox.Name = "pokemon4Move1_txtBox"
        pokemon4Move1_txtBox.PlaceholderText = "Move 1"
        pokemon4Move1_txtBox.Size = New Size(120, 23)
        pokemon4Move1_txtBox.TabIndex = 0
        ' 
        ' pokemon4Ability_lbl
        ' 
        pokemon4Ability_lbl.AutoSize = True
        pokemon4Ability_lbl.Location = New Point(6, 63)
        pokemon4Ability_lbl.Name = "pokemon4Ability_lbl"
        pokemon4Ability_lbl.Size = New Size(41, 15)
        pokemon4Ability_lbl.TabIndex = 63
        pokemon4Ability_lbl.Text = "Ability"
        ' 
        ' pokemon4Happiness_lbl
        ' 
        pokemon4Happiness_lbl.AutoSize = True
        pokemon4Happiness_lbl.Location = New Point(152, 107)
        pokemon4Happiness_lbl.Name = "pokemon4Happiness_lbl"
        pokemon4Happiness_lbl.Size = New Size(62, 15)
        pokemon4Happiness_lbl.TabIndex = 72
        pokemon4Happiness_lbl.Text = "Happiness"
        ' 
        ' pokemon4Ability_cmb
        ' 
        pokemon4Ability_cmb.AutoCompleteCustomSource.AddRange(New String() {"Aerilate", "Aftermath", "Air Lock", "Analytic", "Anger Point", "Anger Shell", "Anticipation", "Arena Trap", "Armor Tail", "Aroma Veil", "As One - Unnerve Chilling Neigh", "As One - Unnerve Grim Neigh", "Aura Break", "Bad Dreams", "Ball Fetch", "Battery", "Battle Armor", "Battle Bond", "Beads of Ruin", "Beast Boost", "Berserk", "Big Pecks", "Blaze", "Bulletproof", "Cheek Pouch", "Chilling Neigh", "Chlorophyll", "Clear Body", "Cloud Nine", "Color Change", "Comatose", "Commander", "Competitive", "Compoundeyes", "Contrary", "Corrosion", "Costar", "Cotton Down", "Cud Chew", "Curious Medicine", "Cursed Body", "Cute Charm", "Damp", "Dancer", "Dark Aura", "Dauntless Shield", "Dazzling", "Defeatist", "Defiant", "Delta Stream", "Desolate Land", "Disguise", "Download", "Dragon's Maw", "Drizzle", "Drought", "Dry Skin", "Early Bird", "Earth Eater", "Effect Spore", "Electric Surge", "Electromorphosis", "Embody Aspect - Cornerstone Mask", "Embody Aspect - Hearthflame Mask", "Embody Aspect - Teal Mask", "Embody Aspect - Wellspring Mask", "Emergency Exit", "Fairy Aura", "Filter", "Flame Body", "Flare Boost", "Flash Fire", "Flower Gift", "Flower Veil", "Fluffy", "Forecast", "Forewarn", "Friend Guard", "Frisk", "Full Metal Body", "Fur Coat", "Gale Wings", "Galvanize", "Gluttony", "Good as Gold", "Gooey", "Gorilla Tactics", "Grass Pelt", "Grassy Surge", "Grim Neigh", "Guard Dog", "Gulp Missile", "Guts", "Hadron Engine", "Harvest", "Healer", "Heatproof", "Heavy Metal", "Honey Gather", "Hospitality", "Huge Power", "Hunger Switch", "Hustle", "Hydration", "Hyper Cutter", "Ice Body", "Ice Face", "Ice Scales", "Illuminate", "Illusion", "Immunity", "Imposter", "Infiltrator", "Innards Out", "Inner Focus", "Insomnia", "Intimidate", "Intrepid Sword", "Iron Barbs", "Iron Fist", "Justified", "Keen Eye", "Klutz", "Leaf Guard", "Levitate", "Libero", "Light Metal", "Lightning Rod", "Limber", "Lingering Aroma", "Liquid Ooze", "Liquid Voice", "Long Reach", "Magic Bounce", "Magic Guard", "Magician", "Magma Armor", "Magnet Pull", "Marvel Scale", "Mega Launcher", "Merciless", "Mimicry", "Mind's Eye", "Minus", "Mirror Armor", "Misty Surge", "Mold Breaker", "Moody", "Motor Drive", "Moxie", "Multiscale", "Multitype", "Mummy", "Mycelium Might", "Natural Cure", "Neuroforce", "Neutralizing Gas", "No Guard", "Normalize", "Oblivious", "Opportunist", "Orichalcum Pulse", "Overcoat", "Overgrow", "Own Tempo", "Parental Bond", "Pastel Veil", "Perish Body", "Pickpocket", "Pickup", "Pixilate", "Plus", "Poison Heal", "Poison Point", "Poison Touch", "Power Construct", "Power of Alchemy", "Power Spot", "Prankster", "Pressure", "Primordial Sea", "Prism Armor", "Propeller Tail", "Protean", "Protosynthesis", "Psychic Surge", "Punk Rock", "Pure Power", "Purifying Salt", "Quark Drive", "Queenly Majesty", "Quick Draw", "Quick Feet", "Rain Dish", "Rattled", "Receiver", "Reckless", "Refrigerate", "Regenerator", "Ripen", "Rivalry", "RKS System", "Rock Head", "Rocky Payload", "Rough Skin", "Run Away", "Sand Force", "Sand Rush", "Sand Spit", "Sand Stream", "Sand Veil", "Sap Sipper", "Schooling", "Scrappy", "Screen Cleaner", "Seed Sower", "Serene Grace", "Shadow Shield", "Shadow Tag", "Sharpness", "Shed Skin", "Sheer Force", "Shell Armor", "Shield Dust", "Shields Down", "Simple", "Skill Link", "Slow Start", "Slush Rush", "Sniper", "Snow Cloak", "Snow Warning", "Solar Power", "Solid Rock", "Soul-Heart", "Soundproof", "Speed Boost", "Stakeout", "Stall", "Stalwart", "Stamina", "Stance Change", "Static", "Steadfast", "Steam Engine", "Steelworker", "Steely Spirit", "Stench", "Sticky Hold", "Storm Drain", "Strong Jaw", "Sturdy", "Suction Cups", "Super Luck", "Supersweet Syrup", "Supreme Overlord", "Surge Surfer", "Swarm", "Sweet Veil", "Swift Swim", "Sword of Ruin", "Symbiosis", "Synchronize", "Tablets of Ruin", "Tangled Feet", "Tangling Hair", "Technician", "Telepathy", "Teravolt", "Thermal Exchange", "Thick Fat", "Tinted Lens", "Torrent", "Tough Claws", "Toxic Boost", "Toxic Chain", "Toxic Debris", "Trace", "Transistor", "Triage", "Truant", "Turboblaze", "Unaware", "Unburden", "Unnerve", "Unseen Fist", "Vessel of Ruin", "Victory Star", "Vital Spirit", "Volt Absorb", "Wandering Spirit", "Water Absorb", "Water Bubble", "Water Compaction", "Water Veil", "Weak Armor", "Well-Baked Body", "White Smoke", "Wimp Out", "Wind Power", "Wind Rider", "Wonder Guard", "Wonder Skin ", "Zen Mode", "Zero to Hero"})
        pokemon4Ability_cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon4Ability_cmb.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon4Ability_cmb.FormattingEnabled = True
        pokemon4Ability_cmb.Items.AddRange(New Object() {"Aerilate", "Aftermath", "Air Lock", "Analytic", "Anger Point", "Anger Shell", "Anticipation", "Arena Trap", "Armor Tail", "Aroma Veil", "As One - Unnerve Chilling Neigh", "As One - Unnerve Grim Neigh", "Aura Break", "Bad Dreams", "Ball Fetch", "Battery", "Battle Armor", "Battle Bond", "Beads of Ruin", "Beast Boost", "Berserk", "Big Pecks", "Blaze", "Bulletproof", "Cheek Pouch", "Chilling Neigh", "Chlorophyll", "Clear Body", "Cloud Nine", "Color Change", "Comatose", "Commander", "Competitive", "Compoundeyes", "Contrary", "Corrosion", "Costar", "Cotton Down", "Cud Chew", "Curious Medicine", "Cursed Body", "Cute Charm", "Damp", "Dancer", "Dark Aura", "Dauntless Shield", "Dazzling", "Defeatist", "Defiant", "Delta Stream", "Desolate Land", "Disguise", "Download", "Dragon's Maw", "Drizzle", "Drought", "Dry Skin", "Early Bird", "Earth Eater", "Effect Spore", "Electric Surge", "Electromorphosis", "Embody Aspect - Cornerstone Mask", "Embody Aspect - Hearthflame Mask", "Embody Aspect - Teal Mask", "Embody Aspect - Wellspring Mask", "Emergency Exit", "Fairy Aura", "Filter", "Flame Body", "Flare Boost", "Flash Fire", "Flower Gift", "Flower Veil", "Fluffy", "Forecast", "Forewarn", "Friend Guard", "Frisk", "Full Metal Body", "Fur Coat", "Gale Wings", "Galvanize", "Gluttony", "Good as Gold", "Gooey", "Gorilla Tactics", "Grass Pelt", "Grassy Surge", "Grim Neigh", "Guard Dog", "Gulp Missile", "Guts", "Hadron Engine", "Harvest", "Healer", "Heatproof", "Heavy Metal", "Honey Gather", "Hospitality", "Huge Power", "Hunger Switch", "Hustle", "Hydration", "Hyper Cutter", "Ice Body", "Ice Face", "Ice Scales", "Illuminate", "Illusion", "Immunity", "Imposter", "Infiltrator", "Innards Out", "Inner Focus", "Insomnia", "Intimidate", "Intrepid Sword", "Iron Barbs", "Iron Fist", "Justified", "Keen Eye", "Klutz", "Leaf Guard", "Levitate", "Libero", "Light Metal", "Lightning Rod", "Limber", "Lingering Aroma", "Liquid Ooze", "Liquid Voice", "Long Reach", "Magic Bounce", "Magic Guard", "Magician", "Magma Armor", "Magnet Pull", "Marvel Scale", "Mega Launcher", "Merciless", "Mimicry", "Mind's Eye", "Minus", "Mirror Armor", "Misty Surge", "Mold Breaker", "Moody", "Motor Drive", "Moxie", "Multiscale", "Multitype", "Mummy", "Mycelium Might", "Natural Cure", "Neuroforce", "Neutralizing Gas", "No Guard", "Normalize", "Oblivious", "Opportunist", "Orichalcum Pulse", "Overcoat", "Overgrow", "Own Tempo", "Parental Bond", "Pastel Veil", "Perish Body", "Pickpocket", "Pickup", "Pixilate", "Plus", "Poison Heal", "Poison Point", "Poison Touch", "Power Construct", "Power of Alchemy", "Power Spot", "Prankster", "Pressure", "Primordial Sea", "Prism Armor", "Propeller Tail", "Protean", "Protosynthesis", "Psychic Surge", "Punk Rock", "Pure Power", "Purifying Salt", "Quark Drive", "Queenly Majesty", "Quick Draw", "Quick Feet", "Rain Dish", "Rattled", "Receiver", "Reckless", "Refrigerate", "Regenerator", "Ripen", "Rivalry", "RKS System", "Rock Head", "Rocky Payload", "Rough Skin", "Run Away", "Sand Force", "Sand Rush", "Sand Spit", "Sand Stream", "Sand Veil", "Sap Sipper", "Schooling", "Scrappy", "Screen Cleaner", "Seed Sower", "Serene Grace", "Shadow Shield", "Shadow Tag", "Sharpness", "Shed Skin", "Sheer Force", "Shell Armor", "Shield Dust", "Shields Down", "Simple", "Skill Link", "Slow Start", "Slush Rush", "Sniper", "Snow Cloak", "Snow Warning", "Solar Power", "Solid Rock", "Soul-Heart", "Soundproof", "Speed Boost", "Stakeout", "Stall", "Stalwart", "Stamina", "Stance Change", "Static", "Steadfast", "Steam Engine", "Steelworker", "Steely Spirit", "Stench", "Sticky Hold", "Storm Drain", "Strong Jaw", "Sturdy", "Suction Cups", "Super Luck", "Supersweet Syrup", "Supreme Overlord", "Surge Surfer", "Swarm", "Sweet Veil", "Swift Swim", "Sword of Ruin", "Symbiosis", "Synchronize", "Tablets of Ruin", "Tangled Feet", "Tangling Hair", "Technician", "Telepathy", "Teravolt", "Thermal Exchange", "Thick Fat", "Tinted Lens", "Torrent", "Tough Claws", "Toxic Boost", "Toxic Chain", "Toxic Debris", "Trace", "Transistor", "Triage", "Truant", "Turboblaze", "Unaware", "Unburden", "Unnerve", "Unseen Fist", "Vessel of Ruin", "Victory Star", "Vital Spirit", "Volt Absorb", "Wandering Spirit", "Water Absorb", "Water Bubble", "Water Compaction", "Water Veil", "Weak Armor", "Well-Baked Body", "White Smoke", "Wimp Out", "Wind Power", "Wind Rider", "Wonder Guard", "Wonder Skin ", "Zen Mode", "Zero to Hero"})
        pokemon4Ability_cmb.Location = New Point(6, 81)
        pokemon4Ability_cmb.Name = "pokemon4Ability_cmb"
        pokemon4Ability_cmb.Size = New Size(140, 23)
        pokemon4Ability_cmb.TabIndex = 64
        ' 
        ' pokemon4Nature_cmb
        ' 
        pokemon4Nature_cmb.FormattingEnabled = True
        pokemon4Nature_cmb.Items.AddRange(New Object() {"(random)", "HARDY", "LONELY", "BRAVE", "ADAMANT", "NAUGHTY", "BOLD", "DOCILE", "RELAXED", "IMPISH", "LAX", "MODEST", "MILD", "SERIOUS", "QUIET", "RASH", "CALM", "GENTLE", "SASSY", "BASHFUL", "CAREFUL", "TIMID", "HASTY", "JOLLY", "NAIVE", "QUIRKY"})
        pokemon4Nature_cmb.Location = New Point(6, 125)
        pokemon4Nature_cmb.Name = "pokemon4Nature_cmb"
        pokemon4Nature_cmb.Size = New Size(140, 23)
        pokemon4Nature_cmb.TabIndex = 71
        ' 
        ' pokemon4Gender_lbl
        ' 
        pokemon4Gender_lbl.AutoSize = True
        pokemon4Gender_lbl.Location = New Point(152, 63)
        pokemon4Gender_lbl.Name = "pokemon4Gender_lbl"
        pokemon4Gender_lbl.Size = New Size(45, 15)
        pokemon4Gender_lbl.TabIndex = 65
        pokemon4Gender_lbl.Text = "Gender"
        ' 
        ' pokemon4Nature_lbl
        ' 
        pokemon4Nature_lbl.AutoSize = True
        pokemon4Nature_lbl.Location = New Point(6, 107)
        pokemon4Nature_lbl.Name = "pokemon4Nature_lbl"
        pokemon4Nature_lbl.Size = New Size(43, 15)
        pokemon4Nature_lbl.TabIndex = 70
        pokemon4Nature_lbl.Text = "Nature"
        ' 
        ' pokemon4Gender_cmb
        ' 
        pokemon4Gender_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        pokemon4Gender_cmb.FormattingEnabled = True
        pokemon4Gender_cmb.Items.AddRange(New Object() {"Male", "Female", "Random"})
        pokemon4Gender_cmb.Location = New Point(152, 81)
        pokemon4Gender_cmb.Name = "pokemon4Gender_cmb"
        pokemon4Gender_cmb.Size = New Size(140, 23)
        pokemon4Gender_cmb.TabIndex = 66
        ' 
        ' pokemon4Shiny_grp
        ' 
        pokemon4Shiny_grp.Controls.Add(pokemon4SuperShiny_chkBox)
        pokemon4Shiny_grp.Controls.Add(pokemon4Shiny_rad)
        pokemon4Shiny_grp.Controls.Add(pokemon4NotShiny_rad)
        pokemon4Shiny_grp.Location = New Point(444, 110)
        pokemon4Shiny_grp.Name = "pokemon4Shiny_grp"
        pokemon4Shiny_grp.Size = New Size(273, 82)
        pokemon4Shiny_grp.TabIndex = 69
        pokemon4Shiny_grp.TabStop = False
        pokemon4Shiny_grp.Text = "Shiny"
        ' 
        ' pokemon4SuperShiny_chkBox
        ' 
        pokemon4SuperShiny_chkBox.AutoSize = True
        pokemon4SuperShiny_chkBox.Enabled = False
        pokemon4SuperShiny_chkBox.Location = New Point(66, 47)
        pokemon4SuperShiny_chkBox.Name = "pokemon4SuperShiny_chkBox"
        pokemon4SuperShiny_chkBox.Size = New Size(88, 19)
        pokemon4SuperShiny_chkBox.TabIndex = 2
        pokemon4SuperShiny_chkBox.Text = "Super Shiny"
        pokemon4SuperShiny_chkBox.UseVisualStyleBackColor = True
        ' 
        ' pokemon4Shiny_rad
        ' 
        pokemon4Shiny_rad.AutoSize = True
        pokemon4Shiny_rad.Location = New Point(6, 47)
        pokemon4Shiny_rad.Name = "pokemon4Shiny_rad"
        pokemon4Shiny_rad.Size = New Size(54, 19)
        pokemon4Shiny_rad.TabIndex = 1
        pokemon4Shiny_rad.Text = "Shiny"
        pokemon4Shiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon4NotShiny_rad
        ' 
        pokemon4NotShiny_rad.AutoSize = True
        pokemon4NotShiny_rad.Checked = True
        pokemon4NotShiny_rad.Location = New Point(6, 22)
        pokemon4NotShiny_rad.Name = "pokemon4NotShiny_rad"
        pokemon4NotShiny_rad.Size = New Size(77, 19)
        pokemon4NotShiny_rad.TabIndex = 0
        pokemon4NotShiny_rad.TabStop = True
        pokemon4NotShiny_rad.Text = "Not Shiny"
        pokemon4NotShiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon4Form_lbl
        ' 
        pokemon4Form_lbl.AutoSize = True
        pokemon4Form_lbl.Location = New Point(298, 63)
        pokemon4Form_lbl.Name = "pokemon4Form_lbl"
        pokemon4Form_lbl.Size = New Size(35, 15)
        pokemon4Form_lbl.TabIndex = 67
        pokemon4Form_lbl.Text = "Form"
        ' 
        ' pg_pkmn5
        ' 
        pg_pkmn5.Controls.Add(pokemon5_grp)
        pg_pkmn5.Location = New Point(4, 24)
        pg_pkmn5.Name = "pg_pkmn5"
        pg_pkmn5.Padding = New Padding(3)
        pg_pkmn5.Size = New Size(729, 475)
        pg_pkmn5.TabIndex = 0
        pg_pkmn5.Text = "Pokémon 5"
        pg_pkmn5.UseVisualStyleBackColor = True
        ' 
        ' pokemon5_grp
        ' 
        pokemon5_grp.Controls.Add(pokemon5Level_nbr)
        pokemon5_grp.Controls.Add(pokemon5Form_nbr)
        pokemon5_grp.Controls.Add(pokemon5Happiness_nbr)
        pokemon5_grp.Controls.Add(pokemon5Shadow_grp)
        pokemon5_grp.Controls.Add(pokemon5Name_lbl)
        pokemon5_grp.Controls.Add(pokemon5EVs_grp)
        pokemon5_grp.Controls.Add(pokemon5Name_txt)
        pokemon5_grp.Controls.Add(pokemon5IVs_grp)
        pokemon5_grp.Controls.Add(pokemon5HeldItem_txt)
        pokemon5_grp.Controls.Add(pokemon5PokeballID_cmb)
        pokemon5_grp.Controls.Add(pokemon5HeldItem_lbl)
        pokemon5_grp.Controls.Add(pokemon5PokeBall_lbl)
        pokemon5_grp.Controls.Add(pokemon5Level_lbl)
        pokemon5_grp.Controls.Add(pokemon5Nickname_txt)
        pokemon5_grp.Controls.Add(pokemon5Nickname_lbl)
        pokemon5_grp.Controls.Add(pokemon5Moves_grp)
        pokemon5_grp.Controls.Add(pokemon5Ability_lbl)
        pokemon5_grp.Controls.Add(pokemon5Happiness_lbl)
        pokemon5_grp.Controls.Add(pokemon5Ability_cmb)
        pokemon5_grp.Controls.Add(pokemon5Nature_cmb)
        pokemon5_grp.Controls.Add(pokemon5Gender_lbl)
        pokemon5_grp.Controls.Add(pokemon5Nature_lbl)
        pokemon5_grp.Controls.Add(pokemon5Gender_cmb)
        pokemon5_grp.Controls.Add(pokemon5Shiny_grp)
        pokemon5_grp.Controls.Add(pokemon5Form_lbl)
        pokemon5_grp.Dock = DockStyle.Fill
        pokemon5_grp.Location = New Point(3, 3)
        pokemon5_grp.Name = "pokemon5_grp"
        pokemon5_grp.Size = New Size(723, 469)
        pokemon5_grp.TabIndex = 0
        pokemon5_grp.TabStop = False
        pokemon5_grp.Text = "Pokémon 5"
        ' 
        ' pokemon5Level_nbr
        ' 
        pokemon5Level_nbr.Location = New Point(298, 37)
        pokemon5Level_nbr.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        pokemon5Level_nbr.Name = "pokemon5Level_nbr"
        pokemon5Level_nbr.Size = New Size(140, 23)
        pokemon5Level_nbr.TabIndex = 83
        pokemon5Level_nbr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' pokemon5Form_nbr
        ' 
        pokemon5Form_nbr.Location = New Point(298, 80)
        pokemon5Form_nbr.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        pokemon5Form_nbr.Name = "pokemon5Form_nbr"
        pokemon5Form_nbr.Size = New Size(140, 23)
        pokemon5Form_nbr.TabIndex = 82
        ' 
        ' pokemon5Happiness_nbr
        ' 
        pokemon5Happiness_nbr.Location = New Point(152, 124)
        pokemon5Happiness_nbr.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        pokemon5Happiness_nbr.Name = "pokemon5Happiness_nbr"
        pokemon5Happiness_nbr.Size = New Size(140, 23)
        pokemon5Happiness_nbr.TabIndex = 81
        pokemon5Happiness_nbr.Value = New Decimal(New Integer() {70, 0, 0, 0})
        ' 
        ' pokemon5Shadow_grp
        ' 
        pokemon5Shadow_grp.Controls.Add(pokemon5Shadow_rad)
        pokemon5Shadow_grp.Controls.Add(pokemon5NotShadow_rad)
        pokemon5Shadow_grp.Location = New Point(444, 198)
        pokemon5Shadow_grp.Name = "pokemon5Shadow_grp"
        pokemon5Shadow_grp.Size = New Size(273, 82)
        pokemon5Shadow_grp.TabIndex = 80
        pokemon5Shadow_grp.TabStop = False
        pokemon5Shadow_grp.Text = "Shadow"
        ' 
        ' pokemon5Shadow_rad
        ' 
        pokemon5Shadow_rad.AutoSize = True
        pokemon5Shadow_rad.Location = New Point(6, 47)
        pokemon5Shadow_rad.Name = "pokemon5Shadow_rad"
        pokemon5Shadow_rad.Size = New Size(67, 19)
        pokemon5Shadow_rad.TabIndex = 1
        pokemon5Shadow_rad.Text = "Shadow"
        pokemon5Shadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon5NotShadow_rad
        ' 
        pokemon5NotShadow_rad.AutoSize = True
        pokemon5NotShadow_rad.Checked = True
        pokemon5NotShadow_rad.Location = New Point(6, 22)
        pokemon5NotShadow_rad.Name = "pokemon5NotShadow_rad"
        pokemon5NotShadow_rad.Size = New Size(90, 19)
        pokemon5NotShadow_rad.TabIndex = 0
        pokemon5NotShadow_rad.TabStop = True
        pokemon5NotShadow_rad.Text = "Not Shadow"
        pokemon5NotShadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon5Name_lbl
        ' 
        pokemon5Name_lbl.AutoSize = True
        pokemon5Name_lbl.Location = New Point(6, 19)
        pokemon5Name_lbl.Name = "pokemon5Name_lbl"
        pokemon5Name_lbl.Size = New Size(93, 15)
        pokemon5Name_lbl.TabIndex = 56
        pokemon5Name_lbl.Text = "Pokémon Name"
        ' 
        ' pokemon5EVs_grp
        ' 
        pokemon5EVs_grp.Controls.Add(pokemon5EVsDEF_txt)
        pokemon5EVs_grp.Controls.Add(pokemon5EVsDEF_lbl)
        pokemon5EVs_grp.Controls.Add(pokemon5EVsSPDEF_txt)
        pokemon5EVs_grp.Controls.Add(pokemon5EVsSPDEF_lbl)
        pokemon5EVs_grp.Controls.Add(pokemon5EVsSPATK_txt)
        pokemon5EVs_grp.Controls.Add(pokemon5EVsSPATK_lbl)
        pokemon5EVs_grp.Controls.Add(pokemon5EVsSPD_txt)
        pokemon5EVs_grp.Controls.Add(pokemon5EVsSPD_lbl)
        pokemon5EVs_grp.Controls.Add(pokemon5EVsATK_txt)
        pokemon5EVs_grp.Controls.Add(pokemon5EVsATK_lbl)
        pokemon5EVs_grp.Controls.Add(pokemon5EVsHP_txt)
        pokemon5EVs_grp.Controls.Add(pokemon5EVsHP_lbl)
        pokemon5EVs_grp.Location = New Point(324, 154)
        pokemon5EVs_grp.Name = "pokemon5EVs_grp"
        pokemon5EVs_grp.Size = New Size(114, 156)
        pokemon5EVs_grp.TabIndex = 79
        pokemon5EVs_grp.TabStop = False
        pokemon5EVs_grp.Text = "EVs"
        ' 
        ' pokemon5EVsDEF_txt
        ' 
        pokemon5EVsDEF_txt.Location = New Point(6, 125)
        pokemon5EVsDEF_txt.MaxLength = 3
        pokemon5EVsDEF_txt.Name = "pokemon5EVsDEF_txt"
        pokemon5EVsDEF_txt.Size = New Size(44, 23)
        pokemon5EVsDEF_txt.TabIndex = 11
        pokemon5EVsDEF_txt.Text = "0"
        ' 
        ' pokemon5EVsDEF_lbl
        ' 
        pokemon5EVsDEF_lbl.AutoSize = True
        pokemon5EVsDEF_lbl.Location = New Point(14, 107)
        pokemon5EVsDEF_lbl.Name = "pokemon5EVsDEF_lbl"
        pokemon5EVsDEF_lbl.Size = New Size(27, 15)
        pokemon5EVsDEF_lbl.TabIndex = 10
        pokemon5EVsDEF_lbl.Text = "DEF"
        ' 
        ' pokemon5EVsSPDEF_txt
        ' 
        pokemon5EVsSPDEF_txt.Location = New Point(55, 125)
        pokemon5EVsSPDEF_txt.MaxLength = 3
        pokemon5EVsSPDEF_txt.Name = "pokemon5EVsSPDEF_txt"
        pokemon5EVsSPDEF_txt.Size = New Size(44, 23)
        pokemon5EVsSPDEF_txt.TabIndex = 9
        pokemon5EVsSPDEF_txt.Text = "0"
        ' 
        ' pokemon5EVsSPDEF_lbl
        ' 
        pokemon5EVsSPDEF_lbl.AutoSize = True
        pokemon5EVsSPDEF_lbl.Location = New Point(55, 109)
        pokemon5EVsSPDEF_lbl.Name = "pokemon5EVsSPDEF_lbl"
        pokemon5EVsSPDEF_lbl.Size = New Size(40, 15)
        pokemon5EVsSPDEF_lbl.TabIndex = 8
        pokemon5EVsSPDEF_lbl.Text = "SPDEF"
        ' 
        ' pokemon5EVsSPATK_txt
        ' 
        pokemon5EVsSPATK_txt.Location = New Point(55, 81)
        pokemon5EVsSPATK_txt.MaxLength = 3
        pokemon5EVsSPATK_txt.Name = "pokemon5EVsSPATK_txt"
        pokemon5EVsSPATK_txt.Size = New Size(44, 23)
        pokemon5EVsSPATK_txt.TabIndex = 7
        pokemon5EVsSPATK_txt.Text = "0"
        ' 
        ' pokemon5EVsSPATK_lbl
        ' 
        pokemon5EVsSPATK_lbl.AutoSize = True
        pokemon5EVsSPATK_lbl.Location = New Point(56, 65)
        pokemon5EVsSPATK_lbl.Name = "pokemon5EVsSPATK_lbl"
        pokemon5EVsSPATK_lbl.Size = New Size(39, 15)
        pokemon5EVsSPATK_lbl.TabIndex = 6
        pokemon5EVsSPATK_lbl.Text = "SPATK"
        ' 
        ' pokemon5EVsSPD_txt
        ' 
        pokemon5EVsSPD_txt.Location = New Point(55, 37)
        pokemon5EVsSPD_txt.MaxLength = 3
        pokemon5EVsSPD_txt.Name = "pokemon5EVsSPD_txt"
        pokemon5EVsSPD_txt.Size = New Size(44, 23)
        pokemon5EVsSPD_txt.TabIndex = 5
        pokemon5EVsSPD_txt.Text = "0"
        ' 
        ' pokemon5EVsSPD_lbl
        ' 
        pokemon5EVsSPD_lbl.AutoSize = True
        pokemon5EVsSPD_lbl.Location = New Point(63, 21)
        pokemon5EVsSPD_lbl.Name = "pokemon5EVsSPD_lbl"
        pokemon5EVsSPD_lbl.Size = New Size(28, 15)
        pokemon5EVsSPD_lbl.TabIndex = 4
        pokemon5EVsSPD_lbl.Text = "SPD"
        ' 
        ' pokemon5EVsATK_txt
        ' 
        pokemon5EVsATK_txt.Location = New Point(6, 81)
        pokemon5EVsATK_txt.MaxLength = 3
        pokemon5EVsATK_txt.Name = "pokemon5EVsATK_txt"
        pokemon5EVsATK_txt.Size = New Size(44, 23)
        pokemon5EVsATK_txt.TabIndex = 3
        pokemon5EVsATK_txt.Text = "0"
        ' 
        ' pokemon5EVsATK_lbl
        ' 
        pokemon5EVsATK_lbl.AutoSize = True
        pokemon5EVsATK_lbl.Location = New Point(14, 63)
        pokemon5EVsATK_lbl.Name = "pokemon5EVsATK_lbl"
        pokemon5EVsATK_lbl.Size = New Size(27, 15)
        pokemon5EVsATK_lbl.TabIndex = 2
        pokemon5EVsATK_lbl.Text = "ATK"
        ' 
        ' pokemon5EVsHP_txt
        ' 
        pokemon5EVsHP_txt.Location = New Point(6, 37)
        pokemon5EVsHP_txt.MaxLength = 3
        pokemon5EVsHP_txt.Name = "pokemon5EVsHP_txt"
        pokemon5EVsHP_txt.Size = New Size(44, 23)
        pokemon5EVsHP_txt.TabIndex = 1
        pokemon5EVsHP_txt.Text = "0"
        ' 
        ' pokemon5EVsHP_lbl
        ' 
        pokemon5EVsHP_lbl.AutoSize = True
        pokemon5EVsHP_lbl.Location = New Point(16, 19)
        pokemon5EVsHP_lbl.Name = "pokemon5EVsHP_lbl"
        pokemon5EVsHP_lbl.Size = New Size(23, 15)
        pokemon5EVsHP_lbl.TabIndex = 0
        pokemon5EVsHP_lbl.Text = "HP"
        ' 
        ' pokemon5Name_txt
        ' 
        pokemon5Name_txt.AutoCompleteCustomSource.AddRange(New String() {"BULBASAUR", "IVYSAUR", "VENUSAUR", "CHARMANDER", "CHARMELEON", "CHARIZARD", "SQUIRTLE", "WARTORTLE", "BLASTOISE", "CATERPIE", "METAPOD", "BUTTERFREE", "WEEDLE", "KAKUNA", "BEEDRILL", "PIDGEY", "PIDGEOTTO", "PIDGEOT", "RATTATA", "RATICATE", "SPEAROW", "FEAROW", "EKANS", "ARBOK", "PIKACHU", "RAICHU", "SANDSHREW", "SANDSLASH", "NIDORANfE", "NIDORINA", "NIDOQUEEN", "NIDORANmA", "NIDORINO", "NIDOKING", "CLEFAIRY", "CLEFABLE", "VULPIX", "NINETALES", "JIGGLYPUFF", "WIGGLYTUFF", "ZUBAT", "GOLBAT", "ODDISH", "GLOOM", "VILEPLUME", "PARAS", "PARASECT", "VENONAT", "VENOMOTH", "DIGLETT", "DUGTRIO", "MEOWTH", "PERSIAN", "PSYDUCK", "GOLDUCK", "MANKEY", "PRIMEAPE", "GROWLITHE", "ARCANINE", "POLIWAG", "POLIWHIRL", "POLIWRATH", "ABRA", "KADABRA", "ALAKAZAM", "MACHOP", "MACHOKE", "MACHAMP", "BELLSPROUT", "WEEPINBELL", "VICTREEBEL", "TENTACOOL", "TENTACRUEL", "GEODUDE", "GRAVELER", "GOLEM", "PONYTA", "RAPIDASH", "SLOWPOKE", "SLOWBRO", "MAGNEMITE", "MAGNETON", "FARFETCHD", "DODUO", "DODRIO", "SEEL", "DEWGONG", "GRIMER", "MUK", "SHELLDER", "CLOYSTER", "GASTLY", "HAUNTER", "GENGAR", "ONIX", "DROWZEE", "HYPNO", "KRABBY", "KINGLER", "VOLTORB", "ELECTRODE", "EXEGGCUTE", "EXEGGUTOR", "CUBONE", "MAROWAK", "HITMONLEE", "HITMONCHAN", "LICKITUNG", "KOFFING", "WEEZING", "RHYHORN", "RHYDON", "CHANSEY", "TANGELA", "KANGASKHAN", "HORSEA", "SEADRA", "GOLDEEN", "SEAKING", "STARYU", "STARMIE", "MRMIME", "SCYTHER", "JYNX", "ELECTABUZZ", "MAGMAR", "PINSIR", "TAUROS", "MAGIKARP", "GYARADOS", "LAPRAS", "DITTO", "EEVEE", "VAPOREON", "JOLTEON", "FLAREON", "PORYGON", "OMANYTE", "OMASTAR", "KABUTO", "KABUTOPS", "AERODACTYL", "SNORLAX", "ARTICUNO", "ZAPDOS", "MOLTRES", "DRATINI", "DRAGONAIR", "DRAGONITE", "MEWTWO", "MEW", "CHIKORITA", "BAYLEEF", "MEGANIUM", "CYNDAQUIL", "QUILAVA", "TYPHLOSION", "TOTODILE", "CROCONAW", "FERALIGATR", "SENTRET", "FURRET", "HOOTHOOT", "NOCTOWL", "LEDYBA", "LEDIAN", "SPINARAK", "ARIADOS", "CROBAT", "CHINCHOU", "LANTURN", "PICHU", "CLEFFA", "IGGLYBUFF", "TOGEPI", "TOGETIC", "NATU", "XATU", "MAREEP", "FLAAFFY", "AMPHAROS", "BELLOSSOM", "MARILL", "AZUMARILL", "SUDOWOODO", "POLITOED", "HOPPIP", "SKIPLOOM", "JUMPLUFF", "AIPOM", "SUNKERN", "SUNFLORA", "YANMA", "WOOPER", "QUAGSIRE", "ESPEON", "UMBREON", "MURKROW", "SLOWKING", "MISDREAVUS", "UNOWN", "WOBBUFFET", "GIRAFARIG", "PINECO", "FORRETRESS", "DUNSPARCE", "GLIGAR", "STEELIX", "SNUBBULL", "GRANBULL", "QWILFISH", "SCIZOR", "SHUCKLE", "HERACROSS", "SNEASEL", "TEDDIURSA", "URSARING", "SLUGMA", "MAGCARGO", "SWINUB", "PILOSWINE", "CORSOLA", "REMORAID", "OCTILLERY", "DELIBIRD", "MANTINE", "SKARMORY", "HOUNDOUR", "HOUNDOOM", "KINGDRA", "PHANPY", "DONPHAN", "PORYGON2", "STANTLER", "SMEARGLE", "TYROGUE", "HITMONTOP", "SMOOCHUM", "ELEKID", "MAGBY", "MILTANK", "BLISSEY", "RAIKOU", "ENTEI", "SUICUNE", "LARVITAR", "PUPITAR", "TYRANITAR", "LUGIA", "HO-OH", "CELEBI", "TREECKO", "GROVYLE", "SCEPTILE", "TORCHIC", "COMBUSKEN", "BLAZIKEN", "MUDKIP", "MARSHTOMP", "SWAMPERT", "POOCHYENA", "MIGHTYENA", "ZIGZAGOON", "LINOONE", "WURMPLE", "SILCOON", "BEAUTIFLY", "CASCOON", "DUSTOX", "LOTAD", "LOMBRE", "LUDICOLO", "SEEDOT", "NUZLEAF", "SHIFTRY", "TAILLOW", "SWELLOW", "WINGULL", "PELIPPER", "RALTS", "KIRLIA", "GARDEVOIR", "SURSKIT", "MASQUERAIN", "SHROOMISH", "BRELOOM", "SLAKOTH", "VIGOROTH", "SLAKING", "NINCADA", "NINJASK", "SHEDINJA", "WHISMUR", "LOUDRED", "EXPLOUD", "MAKUHITA", "HARIYAMA", "AZURILL", "NOSEPASS", "SKITTY", "DELCATTY", "SABLEYE", "MAWILE", "ARON", "LAIRON", "AGGRON", "MEDITITE", "MEDICHAM", "ELECTRIKE", "MANECTRIC", "PLUSLE", "MINUN", "VOLBEAT", "ILLUMISE", "ROSELIA", "GULPIN", "SWALOT", "CARVANHA", "SHARPEDO", "WAILMER", "WAILORD", "NUMEL", "CAMERUPT", "TORKOAL", "SPOINK", "GRUMPIG", "SPINDA", "TRAPINCH", "VIBRAVA", "FLYGON", "CACNEA", "CACTURNE", "SWABLU", "ALTARIA", "ZANGOOSE", "SEVIPER", "LUNATONE", "SOLROCK", "BARBOACH", "WHISCASH", "CORPHISH", "CRAWDAUNT", "BALTOY", "CLAYDOL", "LILEEP", "CRADILY", "ANORITH", "ARMALDO", "FEEBAS", "MILOTIC", "CASTFORM", "KECLEON", "SHUPPET", "BANETTE", "DUSKULL", "DUSCLOPS", "TROPIUS", "CHIMECHO", "ABSOL", "WYNAUT", "SNORUNT", "GLALIE", "SPHEAL", "SEALEO", "WALREIN", "CLAMPERL", "HUNTAIL", "GOREBYSS", "RELICANTH", "LUVDISC", "BAGON", "SHELGON", "SALAMENCE", "BELDUM", "METANG", "METAGROSS", "REGIROCK", "REGICE", "REGISTEEL", "LATIAS", "LATIOS", "KYOGRE", "GROUDON", "RAYQUAZA", "JIRACHI", "DEOXYS", "TURTWIG", "GROTLE", "TORTERRA", "CHIMCHAR", "MONFERNO", "INFERNAPE", "PIPLUP", "PRINPLUP", "EMPOLEON", "STARLY", "STARAVIA", "STARAPTOR", "BIDOOF", "BIBAREL", "KRICKETOT", "KRICKETUNE", "SHINX", "LUXIO", "LUXRAY", "BUDEW", "ROSERADE", "CRANIDOS", "RAMPARDOS", "SHIELDON", "BASTIODON", "BURMY", "WORMADAM", "MOTHIM", "COMBEE", "VESPIQUEN", "PACHIRISU", "BUIZEL", "FLOATZEL", "CHERUBI", "CHERRIM", "SHELLOS", "GASTRODON", "AMBIPOM", "DRIFLOON", "DRIFBLIM", "BUNEARY", "LOPUNNY", "MISMAGIUS", "HONCHKROW", "GLAMEOW", "PURUGLY", "CHINGLING", "STUNKY", "SKUNTANK", "BRONZOR", "BRONZONG", "BONSLY", "MIMEJR", "HAPPINY", "CHATOT", "SPIRITOMB", "GIBLE", "GABITE", "GARCHOMP", "MUNCHLAX", "RIOLU", "LUCARIO", "HIPPOPOTAS", "HIPPOWDON", "SKORUPI", "DRAPION", "CROAGUNK", "TOXICROAK", "CARNIVINE", "FINNEON", "LUMINEON", "MANTYKE", "SNOVER", "ABOMASNOW", "WEAVILE", "MAGNEZONE", "LICKILICKY", "RHYPERIOR", "TANGROWTH", "ELECTIVIRE", "MAGMORTAR", "TOGEKISS", "YANMEGA", "LEAFEON", "GLACEON", "GLISCOR", "MAMOSWINE", "PORYGON-Z", "GALLADE", "PROBOPASS", "DUSKNOIR", "FROSLASS", "ROTOM", "UXIE", "MESPRIT", "AZELF", "DIALGA", "PALKIA", "HEATRAN", "REGIGIGAS", "GIRATINA", "CRESSELIA", "PHIONE", "MANAPHY", "DARKRAI", "SHAYMIN", "ARCEUS", "VICTINI", "SNIVY", "SERVINE", "SERPERIOR", "TEPIG", "PIGNITE", "EMBOAR", "OSHAWOTT", "DEWOTT", "SAMUROTT", "PATRAT", "WATCHOG", "LILLIPUP", "HERDIER", "STOUTLAND", "PURRLOIN", "LIEPARD", "PANSAGE", "SIMISAGE", "PANSEAR", "SIMISEAR", "PANPOUR", "SIMIPOUR", "MUNNA", "MUSHARNA", "PIDOVE", "TRANQUILL", "UNFEZANT", "BLITZLE", "ZEBSTRIKA", "ROGGENROLA", "BOLDORE", "GIGALITH", "WOOBAT", "SWOOBAT", "DRILBUR", "EXCADRILL", "AUDINO", "TIMBURR", "GURDURR", "CONKELDURR", "TYMPOLE", "PALPITOAD", "SEISMITOAD", "THROH", "SAWK", "SEWADDLE", "SWADLOON", "LEAVANNY", "VENIPEDE", "WHIRLIPEDE", "SCOLIPEDE", "COTTONEE", "WHIMSICOTT", "PETILIL", "LILLIGANT", "BASCULIN", "SANDILE", "KROKOROK", "KROOKODILE", "DARUMAKA", "DARMANITAN", "MARACTUS", "DWEBBLE", "CRUSTLE", "SCRAGGY", "SCRAFTY", "SIGILYPH", "YAMASK", "COFAGRIGUS", "TIRTOUGA", "CARRACOSTA", "ARCHEN", "ARCHEOPS", "TRUBBISH", "GARBODOR", "ZORUA", "ZOROARK", "MINCCINO", "CINCCINO", "GOTHITA", "GOTHORITA", "GOTHITELLE", "SOLOSIS", "DUOSION", "REUNICLUS", "DUCKLETT", "SWANNA", "VANILLITE", "VANILLISH", "VANILLUXE", "DEERLING", "SAWSBUCK", "EMOLGA", "KARRABLAST", "ESCAVALIER", "FOONGUS", "AMOONGUSS", "FRILLISH", "JELLICENT", "ALOMOMOLA", "JOLTIK", "GALVANTULA", "FERROSEED", "FERROTHORN", "KLINK", "KLANG", "KLINKLANG", "TYNAMO", "EELEKTRIK", "EELEKTROSS", "ELGYEM", "BEHEEYEM", "LITWICK", "LAMPENT", "CHANDELURE", "AXEW", "FRAXURE", "HAXORUS", "CUBCHOO", "BEARTIC", "CRYOGONAL", "SHELMET", "ACCELGOR", "STUNFISK", "MIENFOO", "MIENSHAO", "DRUDDIGON", "GOLETT", "GOLURK", "PAWNIARD", "BISHARP", "BOUFFALANT", "RUFFLET", "BRAVIARY", "VULLABY", "MANDIBUZZ", "HEATMOR", "DURANT", "DEINO", "ZWEILOUS", "HYDREIGON", "LARVESTA", "VOLCARONA", "COBALION", "TERRAKION", "VIRIZION", "TORNADUS", "THUNDURUS", "RESHIRAM", "ZEKROM", "LANDORUS", "KYUREM", "KELDEO", "MELOETTA", "GENESECT", "CHESPIN", "QUILLADIN", "CHESNAUGHT", "FENNEKIN", "BRAIXEN", "DELPHOX", "FROAKIE", "FROGADIER", "GRENINJA", "BUNNELBY", "DIGGERSBY", "FLETCHLING", "FLETCHINDER", "TALONFLAME", "SCATTERBUG", "SPEWPA", "VIVILLON", "LITLEO", "PYROAR", "FLABEBE", "FLOETTE", "FLORGES", "SKIDDO", "GOGOAT", "PANCHAM", "PANGORO", "FURFROU", "ESPURR", "MEOWSTIC", "HONEDGE", "DOUBLADE", "AEGISLASH", "SPRITZEE", "AROMATISSE", "SWIRLIX", "SLURPUFF", "INKAY", "MALAMAR", "BINACLE", "BARBARACLE", "SKRELP", "DRAGALGE", "CLAUNCHER", "CLAWITZER", "HELIOPTILE", "HELIOLISK", "TYRUNT", "TYRANTRUM", "AMAURA", "AURORUS", "SYLVEON", "HAWLUCHA", "DEDENNE", "CARBINK", "GOOMY", "SLIGGOO", "GOODRA", "KLEFKI", "PHANTUMP", "TREVENANT", "PUMPKABOO", "GOURGEIST", "BERGMITE", "AVALUGG", "NOIBAT", "NOIVERN", "XERNEAS", "YVELTAL", "ZYGARDE", "DIANCIE", "HOOPA", "VOLCANION", "ROWLET", "DARTRIX", "DECIDUEYE", "LITTEN", "TORRACAT", "INCINEROAR", "POPPLIO", "BRIONNE", "PRIMARINA", "PIKIPEK", "TRUMBEAK", "TOUCANNON", "YUNGOOS", "GUMSHOOS", "GRUBBIN", "CHARJABUG", "VIKAVOLT", "CRABRAWLER", "CRABOMINABLE", "ORICORIO", "CUTIEFLY", "RIBOMBEE", "ROCKRUFF", "LYCANROC", "WISHIWASHI", "MAREANIE", "TOXAPEX", "MUDBRAY", "MUDSDALE", "DEWPIDER", "ARAQUANID", "FOMANTIS", "LURANTIS", "MORELULL", "SHIINOTIC", "SALANDIT", "SALAZZLE", "STUFFUL", "BEWEAR", "BOUNSWEET", "STEENEE", "TSAREENA", "COMFEY", "ORANGURU", "PASSIMIAN", "WIMPOD", "GOLISOPOD", "SANDYGAST", "PALOSSAND", "PYUKUMUKU", "TYPENULL", "SILVALLY", "MINIOR", "KOMALA", "TURTONATOR", "TOGEDEMARU", "MIMIKYU", "BRUXISH", "DRAMPA", "DHELMISE", "JANGMO-O", "HAKAMO-O", "KOMMO-O", "TAPUKOKO", "TAPULELE", "TAPUBULU", "TAPUFINI", "COSMOG", "COSMOEM", "SOLGALEO", "LUNALA", "NIHILEGO", "BUZZWOLE", "PHEROMOSA", "XURKITREE", "CELESTEELA", "KARTANA", "GUZZLORD", "NECROZMA", "MAGEARNA", "MARSHADOW", "POIPOLE", "NAGANADEL", "STAKATAKA", "BLACEPHALON", "ZERAORA", "MELTAN", "MELMETAL", "GROOKEY", "THWACKEY", "RILLABOOM", "SCORBUNNY", "RABOOT", "CINDERACE", "SOBBLE", "DRIZZILE", "INTELEON", "SKWOVET", "GREEDENT", "ROOKIDEE", "CORVISQUIRE", "CORVIKNIGHT", "BLIPBUG", "DOTTLER", "ORBEETLE", "NICKIT", "THIEVUL", "GOSSIFLEUR", "ELDEGOSS", "WOOLOO", "DUBWOOL", "CHEWTLE", "DREDNAW", "YAMPER", "BOLTUND", "ROLYCOLY", "CARKOL", "COALOSSAL", "APPLIN", "FLAPPLE", "APPLETUN", "SILICOBRA", "SANDACONDA", "CRAMORANT", "ARROKUDA", "BARRASKEWDA", "TOXEL", "TOXTRICITY", "SIZZLIPEDE", "CENTISKORCH", "CLOBBOPUS", "GRAPPLOCT", "SINISTEA", "POLTEAGEIST", "HATENNA", "HATTREM", "HATTERENE", "IMPIDIMP", "MORGREM", "GRIMMSNARL", "OBSTAGOON", "PERRSERKER", "CURSOLA", "SIRFETCHD", "MRRIME", "RUNERIGUS", "MILCERY", "ALCREMIE", "FALINKS", "PINCURCHIN", "SNOM", "FROSMOTH", "STONJOURNER", "EISCUE", "INDEEDEE", "MORPEKO", "CUFANT", "COPPERAJAH", "DRACOZOLT", "ARCTOZOLT", "DRACOVISH", "ARCTOVISH", "DURALUDON", "DREEPY", "DRAKLOAK", "DRAGAPULT", "ZACIAN", "ZAMAZENTA", "ETERNATUS", "KUBFU", "URSHIFU", "ZARUDE", "REGIELEKI", "REGIDRAGO", "GLASTRIER", "SPECTRIER", "CALYREX"})
        pokemon5Name_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon5Name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon5Name_txt.Location = New Point(6, 37)
        pokemon5Name_txt.Name = "pokemon5Name_txt"
        pokemon5Name_txt.PlaceholderText = "Bulbasaur"
        pokemon5Name_txt.Size = New Size(140, 23)
        pokemon5Name_txt.TabIndex = 57
        ' 
        ' pokemon5IVs_grp
        ' 
        pokemon5IVs_grp.Controls.Add(pokemon5RandomIVs_btn)
        pokemon5IVs_grp.Controls.Add(pokemon5MaxIVs_btn)
        pokemon5IVs_grp.Controls.Add(pokemon5IVsDEF_txt)
        pokemon5IVs_grp.Controls.Add(pokemon5IVsDEF_lbl)
        pokemon5IVs_grp.Controls.Add(pokemon5IVsSPDEF_txt)
        pokemon5IVs_grp.Controls.Add(pokemon5IVsSPDEF_lbl)
        pokemon5IVs_grp.Controls.Add(pokemon5IVsSPATK_txt)
        pokemon5IVs_grp.Controls.Add(pokemon5IVsSPATK_lbl)
        pokemon5IVs_grp.Controls.Add(pokemon5IVsSPD_txt)
        pokemon5IVs_grp.Controls.Add(pokemon5IVsSPD_lbl)
        pokemon5IVs_grp.Controls.Add(pokemon5IVsATK_txt)
        pokemon5IVs_grp.Controls.Add(pokemon5IVsATK_lbl)
        pokemon5IVs_grp.Controls.Add(pokemon5IVsHP_txt)
        pokemon5IVs_grp.Controls.Add(pokemon5IVsHP_lbl)
        pokemon5IVs_grp.Location = New Point(204, 154)
        pokemon5IVs_grp.Name = "pokemon5IVs_grp"
        pokemon5IVs_grp.Size = New Size(114, 188)
        pokemon5IVs_grp.TabIndex = 78
        pokemon5IVs_grp.TabStop = False
        pokemon5IVs_grp.Text = "IVs (Max 31 Each)"
        ' 
        ' pokemon5RandomIVs_btn
        ' 
        pokemon5RandomIVs_btn.Location = New Point(57, 152)
        pokemon5RandomIVs_btn.Name = "pokemon5RandomIVs_btn"
        pokemon5RandomIVs_btn.Size = New Size(44, 23)
        pokemon5RandomIVs_btn.TabIndex = 15
        pokemon5RandomIVs_btn.Text = "Rand"
        pokemon5RandomIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon5MaxIVs_btn
        ' 
        pokemon5MaxIVs_btn.Location = New Point(7, 152)
        pokemon5MaxIVs_btn.Name = "pokemon5MaxIVs_btn"
        pokemon5MaxIVs_btn.Size = New Size(44, 23)
        pokemon5MaxIVs_btn.TabIndex = 14
        pokemon5MaxIVs_btn.Text = "Max"
        pokemon5MaxIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon5IVsDEF_txt
        ' 
        pokemon5IVsDEF_txt.Location = New Point(7, 123)
        pokemon5IVsDEF_txt.MaxLength = 3
        pokemon5IVsDEF_txt.Name = "pokemon5IVsDEF_txt"
        pokemon5IVsDEF_txt.Size = New Size(44, 23)
        pokemon5IVsDEF_txt.TabIndex = 13
        pokemon5IVsDEF_txt.Text = "0"
        ' 
        ' pokemon5IVsDEF_lbl
        ' 
        pokemon5IVsDEF_lbl.AutoSize = True
        pokemon5IVsDEF_lbl.Location = New Point(18, 105)
        pokemon5IVsDEF_lbl.Name = "pokemon5IVsDEF_lbl"
        pokemon5IVsDEF_lbl.Size = New Size(27, 15)
        pokemon5IVsDEF_lbl.TabIndex = 12
        pokemon5IVsDEF_lbl.Text = "DEF"
        ' 
        ' pokemon5IVsSPDEF_txt
        ' 
        pokemon5IVsSPDEF_txt.Location = New Point(57, 123)
        pokemon5IVsSPDEF_txt.MaxLength = 3
        pokemon5IVsSPDEF_txt.Name = "pokemon5IVsSPDEF_txt"
        pokemon5IVsSPDEF_txt.Size = New Size(44, 23)
        pokemon5IVsSPDEF_txt.TabIndex = 9
        pokemon5IVsSPDEF_txt.Text = "0"
        ' 
        ' pokemon5IVsSPDEF_lbl
        ' 
        pokemon5IVsSPDEF_lbl.AutoSize = True
        pokemon5IVsSPDEF_lbl.Location = New Point(59, 105)
        pokemon5IVsSPDEF_lbl.Name = "pokemon5IVsSPDEF_lbl"
        pokemon5IVsSPDEF_lbl.Size = New Size(40, 15)
        pokemon5IVsSPDEF_lbl.TabIndex = 8
        pokemon5IVsSPDEF_lbl.Text = "SPDEF"
        ' 
        ' pokemon5IVsSPATK_txt
        ' 
        pokemon5IVsSPATK_txt.Location = New Point(57, 79)
        pokemon5IVsSPATK_txt.MaxLength = 3
        pokemon5IVsSPATK_txt.Name = "pokemon5IVsSPATK_txt"
        pokemon5IVsSPATK_txt.Size = New Size(44, 23)
        pokemon5IVsSPATK_txt.TabIndex = 7
        pokemon5IVsSPATK_txt.Text = "0"
        ' 
        ' pokemon5IVsSPATK_lbl
        ' 
        pokemon5IVsSPATK_lbl.AutoSize = True
        pokemon5IVsSPATK_lbl.Location = New Point(59, 61)
        pokemon5IVsSPATK_lbl.Name = "pokemon5IVsSPATK_lbl"
        pokemon5IVsSPATK_lbl.Size = New Size(39, 15)
        pokemon5IVsSPATK_lbl.TabIndex = 6
        pokemon5IVsSPATK_lbl.Text = "SPATK"
        ' 
        ' pokemon5IVsSPD_txt
        ' 
        pokemon5IVsSPD_txt.Location = New Point(57, 35)
        pokemon5IVsSPD_txt.MaxLength = 3
        pokemon5IVsSPD_txt.Name = "pokemon5IVsSPD_txt"
        pokemon5IVsSPD_txt.Size = New Size(44, 23)
        pokemon5IVsSPD_txt.TabIndex = 5
        pokemon5IVsSPD_txt.Text = "0"
        ' 
        ' pokemon5IVsSPD_lbl
        ' 
        pokemon5IVsSPD_lbl.AutoSize = True
        pokemon5IVsSPD_lbl.Location = New Point(65, 17)
        pokemon5IVsSPD_lbl.Name = "pokemon5IVsSPD_lbl"
        pokemon5IVsSPD_lbl.Size = New Size(28, 15)
        pokemon5IVsSPD_lbl.TabIndex = 4
        pokemon5IVsSPD_lbl.Text = "SPD"
        ' 
        ' pokemon5IVsATK_txt
        ' 
        pokemon5IVsATK_txt.Location = New Point(7, 79)
        pokemon5IVsATK_txt.MaxLength = 3
        pokemon5IVsATK_txt.Name = "pokemon5IVsATK_txt"
        pokemon5IVsATK_txt.Size = New Size(44, 23)
        pokemon5IVsATK_txt.TabIndex = 3
        pokemon5IVsATK_txt.Text = "0"
        ' 
        ' pokemon5IVsATK_lbl
        ' 
        pokemon5IVsATK_lbl.AutoSize = True
        pokemon5IVsATK_lbl.Location = New Point(18, 61)
        pokemon5IVsATK_lbl.Name = "pokemon5IVsATK_lbl"
        pokemon5IVsATK_lbl.Size = New Size(27, 15)
        pokemon5IVsATK_lbl.TabIndex = 2
        pokemon5IVsATK_lbl.Text = "ATK"
        ' 
        ' pokemon5IVsHP_txt
        ' 
        pokemon5IVsHP_txt.Location = New Point(7, 35)
        pokemon5IVsHP_txt.MaxLength = 3
        pokemon5IVsHP_txt.Name = "pokemon5IVsHP_txt"
        pokemon5IVsHP_txt.Size = New Size(44, 23)
        pokemon5IVsHP_txt.TabIndex = 1
        pokemon5IVsHP_txt.Text = "0"
        ' 
        ' pokemon5IVsHP_lbl
        ' 
        pokemon5IVsHP_lbl.AutoSize = True
        pokemon5IVsHP_lbl.Location = New Point(18, 19)
        pokemon5IVsHP_lbl.Name = "pokemon5IVsHP_lbl"
        pokemon5IVsHP_lbl.Size = New Size(23, 15)
        pokemon5IVsHP_lbl.TabIndex = 0
        pokemon5IVsHP_lbl.Text = "HP"
        ' 
        ' pokemon5HeldItem_txt
        ' 
        pokemon5HeldItem_txt.Location = New Point(152, 37)
        pokemon5HeldItem_txt.Name = "pokemon5HeldItem_txt"
        pokemon5HeldItem_txt.PlaceholderText = "FocusSash"
        pokemon5HeldItem_txt.Size = New Size(140, 23)
        pokemon5HeldItem_txt.TabIndex = 58
        ' 
        ' pokemon5PokeballID_cmb
        ' 
        pokemon5PokeballID_cmb.FormattingEnabled = True
        pokemon5PokeballID_cmb.Items.AddRange(New Object() {"POKEBALL", "GREATBALL", "SAFARIBALL", "ULTRABALL", "MASTERBALL", "NETBALL", "DIVEBALL", "NESTBALL", "REPEATBALL", "TIMERBALL", "LUXURYBALL", "PREMIERBALL", "DUSKBALL", "HEALBALL", "QUICKBALL", "CHERISHBALL", "FASTBALL", "LEVELBALL", "LUREBALL", "HEAVYBALL", "LOVEBALL", "FRIENDBALL", "MOONBALL", "SPORTBALL", "DREAMBALL", "BEASTBALL"})
        pokemon5PokeballID_cmb.Location = New Point(6, 169)
        pokemon5PokeballID_cmb.Name = "pokemon5PokeballID_cmb"
        pokemon5PokeballID_cmb.Size = New Size(140, 23)
        pokemon5PokeballID_cmb.TabIndex = 77
        ' 
        ' pokemon5HeldItem_lbl
        ' 
        pokemon5HeldItem_lbl.AutoSize = True
        pokemon5HeldItem_lbl.Location = New Point(152, 19)
        pokemon5HeldItem_lbl.Name = "pokemon5HeldItem_lbl"
        pokemon5HeldItem_lbl.Size = New Size(59, 15)
        pokemon5HeldItem_lbl.TabIndex = 59
        pokemon5HeldItem_lbl.Text = "Held Item"
        ' 
        ' pokemon5PokeBall_lbl
        ' 
        pokemon5PokeBall_lbl.AutoSize = True
        pokemon5PokeBall_lbl.Location = New Point(8, 151)
        pokemon5PokeBall_lbl.Name = "pokemon5PokeBall_lbl"
        pokemon5PokeBall_lbl.Size = New Size(52, 15)
        pokemon5PokeBall_lbl.TabIndex = 76
        pokemon5PokeBall_lbl.Text = "PokéBall"
        ' 
        ' pokemon5Level_lbl
        ' 
        pokemon5Level_lbl.AutoSize = True
        pokemon5Level_lbl.Location = New Point(298, 19)
        pokemon5Level_lbl.Name = "pokemon5Level_lbl"
        pokemon5Level_lbl.Size = New Size(34, 15)
        pokemon5Level_lbl.TabIndex = 60
        pokemon5Level_lbl.Text = "Level"
        ' 
        ' pokemon5Nickname_txt
        ' 
        pokemon5Nickname_txt.Location = New Point(298, 125)
        pokemon5Nickname_txt.Name = "pokemon5Nickname_txt"
        pokemon5Nickname_txt.PlaceholderText = "Bloom"
        pokemon5Nickname_txt.Size = New Size(140, 23)
        pokemon5Nickname_txt.TabIndex = 75
        ' 
        ' pokemon5Nickname_lbl
        ' 
        pokemon5Nickname_lbl.AutoSize = True
        pokemon5Nickname_lbl.Location = New Point(298, 107)
        pokemon5Nickname_lbl.Name = "pokemon5Nickname_lbl"
        pokemon5Nickname_lbl.Size = New Size(61, 15)
        pokemon5Nickname_lbl.TabIndex = 74
        pokemon5Nickname_lbl.Text = "Nickname"
        ' 
        ' pokemon5Moves_grp
        ' 
        pokemon5Moves_grp.Controls.Add(pokemon5Move4_txt)
        pokemon5Moves_grp.Controls.Add(pokemon5Move3_txt)
        pokemon5Moves_grp.Controls.Add(pokemon5Move2_txt)
        pokemon5Moves_grp.Controls.Add(pokemon5Move1_txt)
        pokemon5Moves_grp.Location = New Point(444, 22)
        pokemon5Moves_grp.Name = "pokemon5Moves_grp"
        pokemon5Moves_grp.Size = New Size(273, 82)
        pokemon5Moves_grp.TabIndex = 62
        pokemon5Moves_grp.TabStop = False
        pokemon5Moves_grp.Text = "Moves"
        ' 
        ' pokemon5Move4_txt
        ' 
        pokemon5Move4_txt.Location = New Point(132, 51)
        pokemon5Move4_txt.Name = "pokemon5Move4_txt"
        pokemon5Move4_txt.PlaceholderText = "Move 4"
        pokemon5Move4_txt.Size = New Size(120, 23)
        pokemon5Move4_txt.TabIndex = 3
        ' 
        ' pokemon5Move3_txt
        ' 
        pokemon5Move3_txt.Location = New Point(6, 51)
        pokemon5Move3_txt.Name = "pokemon5Move3_txt"
        pokemon5Move3_txt.PlaceholderText = "Move 3"
        pokemon5Move3_txt.Size = New Size(120, 23)
        pokemon5Move3_txt.TabIndex = 2
        ' 
        ' pokemon5Move2_txt
        ' 
        pokemon5Move2_txt.Location = New Point(132, 22)
        pokemon5Move2_txt.Name = "pokemon5Move2_txt"
        pokemon5Move2_txt.PlaceholderText = "Move 2"
        pokemon5Move2_txt.Size = New Size(120, 23)
        pokemon5Move2_txt.TabIndex = 1
        ' 
        ' pokemon5Move1_txt
        ' 
        pokemon5Move1_txt.Location = New Point(6, 22)
        pokemon5Move1_txt.Name = "pokemon5Move1_txt"
        pokemon5Move1_txt.PlaceholderText = "Move 1"
        pokemon5Move1_txt.Size = New Size(120, 23)
        pokemon5Move1_txt.TabIndex = 0
        ' 
        ' pokemon5Ability_lbl
        ' 
        pokemon5Ability_lbl.AutoSize = True
        pokemon5Ability_lbl.Location = New Point(6, 63)
        pokemon5Ability_lbl.Name = "pokemon5Ability_lbl"
        pokemon5Ability_lbl.Size = New Size(41, 15)
        pokemon5Ability_lbl.TabIndex = 63
        pokemon5Ability_lbl.Text = "Ability"
        ' 
        ' pokemon5Happiness_lbl
        ' 
        pokemon5Happiness_lbl.AutoSize = True
        pokemon5Happiness_lbl.Location = New Point(152, 107)
        pokemon5Happiness_lbl.Name = "pokemon5Happiness_lbl"
        pokemon5Happiness_lbl.Size = New Size(62, 15)
        pokemon5Happiness_lbl.TabIndex = 72
        pokemon5Happiness_lbl.Text = "Happiness"
        ' 
        ' pokemon5Ability_cmb
        ' 
        pokemon5Ability_cmb.AutoCompleteCustomSource.AddRange(New String() {"Aerilate", "Aftermath", "Air Lock", "Analytic", "Anger Point", "Anger Shell", "Anticipation", "Arena Trap", "Armor Tail", "Aroma Veil", "As One - Unnerve Chilling Neigh", "As One - Unnerve Grim Neigh", "Aura Break", "Bad Dreams", "Ball Fetch", "Battery", "Battle Armor", "Battle Bond", "Beads of Ruin", "Beast Boost", "Berserk", "Big Pecks", "Blaze", "Bulletproof", "Cheek Pouch", "Chilling Neigh", "Chlorophyll", "Clear Body", "Cloud Nine", "Color Change", "Comatose", "Commander", "Competitive", "Compoundeyes", "Contrary", "Corrosion", "Costar", "Cotton Down", "Cud Chew", "Curious Medicine", "Cursed Body", "Cute Charm", "Damp", "Dancer", "Dark Aura", "Dauntless Shield", "Dazzling", "Defeatist", "Defiant", "Delta Stream", "Desolate Land", "Disguise", "Download", "Dragon's Maw", "Drizzle", "Drought", "Dry Skin", "Early Bird", "Earth Eater", "Effect Spore", "Electric Surge", "Electromorphosis", "Embody Aspect - Cornerstone Mask", "Embody Aspect - Hearthflame Mask", "Embody Aspect - Teal Mask", "Embody Aspect - Wellspring Mask", "Emergency Exit", "Fairy Aura", "Filter", "Flame Body", "Flare Boost", "Flash Fire", "Flower Gift", "Flower Veil", "Fluffy", "Forecast", "Forewarn", "Friend Guard", "Frisk", "Full Metal Body", "Fur Coat", "Gale Wings", "Galvanize", "Gluttony", "Good as Gold", "Gooey", "Gorilla Tactics", "Grass Pelt", "Grassy Surge", "Grim Neigh", "Guard Dog", "Gulp Missile", "Guts", "Hadron Engine", "Harvest", "Healer", "Heatproof", "Heavy Metal", "Honey Gather", "Hospitality", "Huge Power", "Hunger Switch", "Hustle", "Hydration", "Hyper Cutter", "Ice Body", "Ice Face", "Ice Scales", "Illuminate", "Illusion", "Immunity", "Imposter", "Infiltrator", "Innards Out", "Inner Focus", "Insomnia", "Intimidate", "Intrepid Sword", "Iron Barbs", "Iron Fist", "Justified", "Keen Eye", "Klutz", "Leaf Guard", "Levitate", "Libero", "Light Metal", "Lightning Rod", "Limber", "Lingering Aroma", "Liquid Ooze", "Liquid Voice", "Long Reach", "Magic Bounce", "Magic Guard", "Magician", "Magma Armor", "Magnet Pull", "Marvel Scale", "Mega Launcher", "Merciless", "Mimicry", "Mind's Eye", "Minus", "Mirror Armor", "Misty Surge", "Mold Breaker", "Moody", "Motor Drive", "Moxie", "Multiscale", "Multitype", "Mummy", "Mycelium Might", "Natural Cure", "Neuroforce", "Neutralizing Gas", "No Guard", "Normalize", "Oblivious", "Opportunist", "Orichalcum Pulse", "Overcoat", "Overgrow", "Own Tempo", "Parental Bond", "Pastel Veil", "Perish Body", "Pickpocket", "Pickup", "Pixilate", "Plus", "Poison Heal", "Poison Point", "Poison Touch", "Power Construct", "Power of Alchemy", "Power Spot", "Prankster", "Pressure", "Primordial Sea", "Prism Armor", "Propeller Tail", "Protean", "Protosynthesis", "Psychic Surge", "Punk Rock", "Pure Power", "Purifying Salt", "Quark Drive", "Queenly Majesty", "Quick Draw", "Quick Feet", "Rain Dish", "Rattled", "Receiver", "Reckless", "Refrigerate", "Regenerator", "Ripen", "Rivalry", "RKS System", "Rock Head", "Rocky Payload", "Rough Skin", "Run Away", "Sand Force", "Sand Rush", "Sand Spit", "Sand Stream", "Sand Veil", "Sap Sipper", "Schooling", "Scrappy", "Screen Cleaner", "Seed Sower", "Serene Grace", "Shadow Shield", "Shadow Tag", "Sharpness", "Shed Skin", "Sheer Force", "Shell Armor", "Shield Dust", "Shields Down", "Simple", "Skill Link", "Slow Start", "Slush Rush", "Sniper", "Snow Cloak", "Snow Warning", "Solar Power", "Solid Rock", "Soul-Heart", "Soundproof", "Speed Boost", "Stakeout", "Stall", "Stalwart", "Stamina", "Stance Change", "Static", "Steadfast", "Steam Engine", "Steelworker", "Steely Spirit", "Stench", "Sticky Hold", "Storm Drain", "Strong Jaw", "Sturdy", "Suction Cups", "Super Luck", "Supersweet Syrup", "Supreme Overlord", "Surge Surfer", "Swarm", "Sweet Veil", "Swift Swim", "Sword of Ruin", "Symbiosis", "Synchronize", "Tablets of Ruin", "Tangled Feet", "Tangling Hair", "Technician", "Telepathy", "Teravolt", "Thermal Exchange", "Thick Fat", "Tinted Lens", "Torrent", "Tough Claws", "Toxic Boost", "Toxic Chain", "Toxic Debris", "Trace", "Transistor", "Triage", "Truant", "Turboblaze", "Unaware", "Unburden", "Unnerve", "Unseen Fist", "Vessel of Ruin", "Victory Star", "Vital Spirit", "Volt Absorb", "Wandering Spirit", "Water Absorb", "Water Bubble", "Water Compaction", "Water Veil", "Weak Armor", "Well-Baked Body", "White Smoke", "Wimp Out", "Wind Power", "Wind Rider", "Wonder Guard", "Wonder Skin ", "Zen Mode", "Zero to Hero"})
        pokemon5Ability_cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon5Ability_cmb.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon5Ability_cmb.FormattingEnabled = True
        pokemon5Ability_cmb.Items.AddRange(New Object() {"Aerilate", "Aftermath", "Air Lock", "Analytic", "Anger Point", "Anger Shell", "Anticipation", "Arena Trap", "Armor Tail", "Aroma Veil", "As One - Unnerve Chilling Neigh", "As One - Unnerve Grim Neigh", "Aura Break", "Bad Dreams", "Ball Fetch", "Battery", "Battle Armor", "Battle Bond", "Beads of Ruin", "Beast Boost", "Berserk", "Big Pecks", "Blaze", "Bulletproof", "Cheek Pouch", "Chilling Neigh", "Chlorophyll", "Clear Body", "Cloud Nine", "Color Change", "Comatose", "Commander", "Competitive", "Compoundeyes", "Contrary", "Corrosion", "Costar", "Cotton Down", "Cud Chew", "Curious Medicine", "Cursed Body", "Cute Charm", "Damp", "Dancer", "Dark Aura", "Dauntless Shield", "Dazzling", "Defeatist", "Defiant", "Delta Stream", "Desolate Land", "Disguise", "Download", "Dragon's Maw", "Drizzle", "Drought", "Dry Skin", "Early Bird", "Earth Eater", "Effect Spore", "Electric Surge", "Electromorphosis", "Embody Aspect - Cornerstone Mask", "Embody Aspect - Hearthflame Mask", "Embody Aspect - Teal Mask", "Embody Aspect - Wellspring Mask", "Emergency Exit", "Fairy Aura", "Filter", "Flame Body", "Flare Boost", "Flash Fire", "Flower Gift", "Flower Veil", "Fluffy", "Forecast", "Forewarn", "Friend Guard", "Frisk", "Full Metal Body", "Fur Coat", "Gale Wings", "Galvanize", "Gluttony", "Good as Gold", "Gooey", "Gorilla Tactics", "Grass Pelt", "Grassy Surge", "Grim Neigh", "Guard Dog", "Gulp Missile", "Guts", "Hadron Engine", "Harvest", "Healer", "Heatproof", "Heavy Metal", "Honey Gather", "Hospitality", "Huge Power", "Hunger Switch", "Hustle", "Hydration", "Hyper Cutter", "Ice Body", "Ice Face", "Ice Scales", "Illuminate", "Illusion", "Immunity", "Imposter", "Infiltrator", "Innards Out", "Inner Focus", "Insomnia", "Intimidate", "Intrepid Sword", "Iron Barbs", "Iron Fist", "Justified", "Keen Eye", "Klutz", "Leaf Guard", "Levitate", "Libero", "Light Metal", "Lightning Rod", "Limber", "Lingering Aroma", "Liquid Ooze", "Liquid Voice", "Long Reach", "Magic Bounce", "Magic Guard", "Magician", "Magma Armor", "Magnet Pull", "Marvel Scale", "Mega Launcher", "Merciless", "Mimicry", "Mind's Eye", "Minus", "Mirror Armor", "Misty Surge", "Mold Breaker", "Moody", "Motor Drive", "Moxie", "Multiscale", "Multitype", "Mummy", "Mycelium Might", "Natural Cure", "Neuroforce", "Neutralizing Gas", "No Guard", "Normalize", "Oblivious", "Opportunist", "Orichalcum Pulse", "Overcoat", "Overgrow", "Own Tempo", "Parental Bond", "Pastel Veil", "Perish Body", "Pickpocket", "Pickup", "Pixilate", "Plus", "Poison Heal", "Poison Point", "Poison Touch", "Power Construct", "Power of Alchemy", "Power Spot", "Prankster", "Pressure", "Primordial Sea", "Prism Armor", "Propeller Tail", "Protean", "Protosynthesis", "Psychic Surge", "Punk Rock", "Pure Power", "Purifying Salt", "Quark Drive", "Queenly Majesty", "Quick Draw", "Quick Feet", "Rain Dish", "Rattled", "Receiver", "Reckless", "Refrigerate", "Regenerator", "Ripen", "Rivalry", "RKS System", "Rock Head", "Rocky Payload", "Rough Skin", "Run Away", "Sand Force", "Sand Rush", "Sand Spit", "Sand Stream", "Sand Veil", "Sap Sipper", "Schooling", "Scrappy", "Screen Cleaner", "Seed Sower", "Serene Grace", "Shadow Shield", "Shadow Tag", "Sharpness", "Shed Skin", "Sheer Force", "Shell Armor", "Shield Dust", "Shields Down", "Simple", "Skill Link", "Slow Start", "Slush Rush", "Sniper", "Snow Cloak", "Snow Warning", "Solar Power", "Solid Rock", "Soul-Heart", "Soundproof", "Speed Boost", "Stakeout", "Stall", "Stalwart", "Stamina", "Stance Change", "Static", "Steadfast", "Steam Engine", "Steelworker", "Steely Spirit", "Stench", "Sticky Hold", "Storm Drain", "Strong Jaw", "Sturdy", "Suction Cups", "Super Luck", "Supersweet Syrup", "Supreme Overlord", "Surge Surfer", "Swarm", "Sweet Veil", "Swift Swim", "Sword of Ruin", "Symbiosis", "Synchronize", "Tablets of Ruin", "Tangled Feet", "Tangling Hair", "Technician", "Telepathy", "Teravolt", "Thermal Exchange", "Thick Fat", "Tinted Lens", "Torrent", "Tough Claws", "Toxic Boost", "Toxic Chain", "Toxic Debris", "Trace", "Transistor", "Triage", "Truant", "Turboblaze", "Unaware", "Unburden", "Unnerve", "Unseen Fist", "Vessel of Ruin", "Victory Star", "Vital Spirit", "Volt Absorb", "Wandering Spirit", "Water Absorb", "Water Bubble", "Water Compaction", "Water Veil", "Weak Armor", "Well-Baked Body", "White Smoke", "Wimp Out", "Wind Power", "Wind Rider", "Wonder Guard", "Wonder Skin ", "Zen Mode", "Zero to Hero"})
        pokemon5Ability_cmb.Location = New Point(6, 81)
        pokemon5Ability_cmb.Name = "pokemon5Ability_cmb"
        pokemon5Ability_cmb.Size = New Size(140, 23)
        pokemon5Ability_cmb.TabIndex = 64
        ' 
        ' pokemon5Nature_cmb
        ' 
        pokemon5Nature_cmb.FormattingEnabled = True
        pokemon5Nature_cmb.Items.AddRange(New Object() {"(random)", "HARDY", "LONELY", "BRAVE", "ADAMANT", "NAUGHTY", "BOLD", "DOCILE", "RELAXED", "IMPISH", "LAX", "MODEST", "MILD", "SERIOUS", "QUIET", "RASH", "CALM", "GENTLE", "SASSY", "BASHFUL", "CAREFUL", "TIMID", "HASTY", "JOLLY", "NAIVE", "QUIRKY"})
        pokemon5Nature_cmb.Location = New Point(6, 125)
        pokemon5Nature_cmb.Name = "pokemon5Nature_cmb"
        pokemon5Nature_cmb.Size = New Size(140, 23)
        pokemon5Nature_cmb.TabIndex = 71
        ' 
        ' pokemon5Gender_lbl
        ' 
        pokemon5Gender_lbl.AutoSize = True
        pokemon5Gender_lbl.Location = New Point(152, 63)
        pokemon5Gender_lbl.Name = "pokemon5Gender_lbl"
        pokemon5Gender_lbl.Size = New Size(45, 15)
        pokemon5Gender_lbl.TabIndex = 65
        pokemon5Gender_lbl.Text = "Gender"
        ' 
        ' pokemon5Nature_lbl
        ' 
        pokemon5Nature_lbl.AutoSize = True
        pokemon5Nature_lbl.Location = New Point(6, 107)
        pokemon5Nature_lbl.Name = "pokemon5Nature_lbl"
        pokemon5Nature_lbl.Size = New Size(43, 15)
        pokemon5Nature_lbl.TabIndex = 70
        pokemon5Nature_lbl.Text = "Nature"
        ' 
        ' pokemon5Gender_cmb
        ' 
        pokemon5Gender_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        pokemon5Gender_cmb.FormattingEnabled = True
        pokemon5Gender_cmb.Items.AddRange(New Object() {"Male", "Female", "Random"})
        pokemon5Gender_cmb.Location = New Point(152, 81)
        pokemon5Gender_cmb.Name = "pokemon5Gender_cmb"
        pokemon5Gender_cmb.Size = New Size(140, 23)
        pokemon5Gender_cmb.TabIndex = 66
        ' 
        ' pokemon5Shiny_grp
        ' 
        pokemon5Shiny_grp.Controls.Add(pokemon5SuperShiny_chkBox)
        pokemon5Shiny_grp.Controls.Add(pokemon5Shiny_rad)
        pokemon5Shiny_grp.Controls.Add(pokemon5NotShiny_rad)
        pokemon5Shiny_grp.Location = New Point(444, 110)
        pokemon5Shiny_grp.Name = "pokemon5Shiny_grp"
        pokemon5Shiny_grp.Size = New Size(273, 82)
        pokemon5Shiny_grp.TabIndex = 69
        pokemon5Shiny_grp.TabStop = False
        pokemon5Shiny_grp.Text = "Shiny"
        ' 
        ' pokemon5SuperShiny_chkBox
        ' 
        pokemon5SuperShiny_chkBox.AutoSize = True
        pokemon5SuperShiny_chkBox.Enabled = False
        pokemon5SuperShiny_chkBox.Location = New Point(66, 47)
        pokemon5SuperShiny_chkBox.Name = "pokemon5SuperShiny_chkBox"
        pokemon5SuperShiny_chkBox.Size = New Size(88, 19)
        pokemon5SuperShiny_chkBox.TabIndex = 2
        pokemon5SuperShiny_chkBox.Text = "Super Shiny"
        pokemon5SuperShiny_chkBox.UseVisualStyleBackColor = True
        ' 
        ' pokemon5Shiny_rad
        ' 
        pokemon5Shiny_rad.AutoSize = True
        pokemon5Shiny_rad.Location = New Point(6, 47)
        pokemon5Shiny_rad.Name = "pokemon5Shiny_rad"
        pokemon5Shiny_rad.Size = New Size(54, 19)
        pokemon5Shiny_rad.TabIndex = 1
        pokemon5Shiny_rad.Text = "Shiny"
        pokemon5Shiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon5NotShiny_rad
        ' 
        pokemon5NotShiny_rad.AutoSize = True
        pokemon5NotShiny_rad.Checked = True
        pokemon5NotShiny_rad.Location = New Point(6, 22)
        pokemon5NotShiny_rad.Name = "pokemon5NotShiny_rad"
        pokemon5NotShiny_rad.Size = New Size(77, 19)
        pokemon5NotShiny_rad.TabIndex = 0
        pokemon5NotShiny_rad.TabStop = True
        pokemon5NotShiny_rad.Text = "Not Shiny"
        pokemon5NotShiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon5Form_lbl
        ' 
        pokemon5Form_lbl.AutoSize = True
        pokemon5Form_lbl.Location = New Point(298, 63)
        pokemon5Form_lbl.Name = "pokemon5Form_lbl"
        pokemon5Form_lbl.Size = New Size(35, 15)
        pokemon5Form_lbl.TabIndex = 67
        pokemon5Form_lbl.Text = "Form"
        ' 
        ' pg_pkmn6
        ' 
        pg_pkmn6.Controls.Add(pokemon6_grp)
        pg_pkmn6.Location = New Point(4, 24)
        pg_pkmn6.Name = "pg_pkmn6"
        pg_pkmn6.Padding = New Padding(3)
        pg_pkmn6.Size = New Size(729, 475)
        pg_pkmn6.TabIndex = 1
        pg_pkmn6.Text = "Pokémon 6"
        pg_pkmn6.UseVisualStyleBackColor = True
        ' 
        ' pokemon6_grp
        ' 
        pokemon6_grp.Controls.Add(pokemon6Level_nbr)
        pokemon6_grp.Controls.Add(pokemon6Form_nbr)
        pokemon6_grp.Controls.Add(pokemon6Happiness_nbr)
        pokemon6_grp.Controls.Add(pokemon6Shadow_grp)
        pokemon6_grp.Controls.Add(pokemon6Name_lbl)
        pokemon6_grp.Controls.Add(pokemon6EVs_grp)
        pokemon6_grp.Controls.Add(pokemon6Name_txt)
        pokemon6_grp.Controls.Add(pokemon6IVs_grp)
        pokemon6_grp.Controls.Add(pokemon6HeldItem_txt)
        pokemon6_grp.Controls.Add(pokemon6PokeballID_cmb)
        pokemon6_grp.Controls.Add(pokemon6HeldItem_lbl)
        pokemon6_grp.Controls.Add(pokemon6Pokeball_lbl)
        pokemon6_grp.Controls.Add(pokemon6Level_lbl)
        pokemon6_grp.Controls.Add(pokemon6Nickname_txt)
        pokemon6_grp.Controls.Add(pokemon6Nickname_lbl)
        pokemon6_grp.Controls.Add(pokemon6Moves_grp)
        pokemon6_grp.Controls.Add(pokemon6Ability_lbl)
        pokemon6_grp.Controls.Add(pokemon6Happiness_lbl)
        pokemon6_grp.Controls.Add(pokemon6Ability_cmb)
        pokemon6_grp.Controls.Add(pokemon6Nature_cmb)
        pokemon6_grp.Controls.Add(pokemon6Gender_lbl)
        pokemon6_grp.Controls.Add(pokemon6Nature_lbl)
        pokemon6_grp.Controls.Add(pokemon6Gender_cmb)
        pokemon6_grp.Controls.Add(pokemon6Shiny_grp)
        pokemon6_grp.Controls.Add(pokemon6Form_lbl)
        pokemon6_grp.Dock = DockStyle.Fill
        pokemon6_grp.Location = New Point(3, 3)
        pokemon6_grp.Name = "pokemon6_grp"
        pokemon6_grp.Size = New Size(723, 469)
        pokemon6_grp.TabIndex = 0
        pokemon6_grp.TabStop = False
        pokemon6_grp.Text = "Pokémon 6"
        ' 
        ' pokemon6Level_nbr
        ' 
        pokemon6Level_nbr.Location = New Point(298, 37)
        pokemon6Level_nbr.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        pokemon6Level_nbr.Name = "pokemon6Level_nbr"
        pokemon6Level_nbr.Size = New Size(140, 23)
        pokemon6Level_nbr.TabIndex = 83
        pokemon6Level_nbr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' pokemon6Form_nbr
        ' 
        pokemon6Form_nbr.Location = New Point(298, 80)
        pokemon6Form_nbr.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        pokemon6Form_nbr.Name = "pokemon6Form_nbr"
        pokemon6Form_nbr.Size = New Size(140, 23)
        pokemon6Form_nbr.TabIndex = 82
        ' 
        ' pokemon6Happiness_nbr
        ' 
        pokemon6Happiness_nbr.Location = New Point(152, 124)
        pokemon6Happiness_nbr.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        pokemon6Happiness_nbr.Name = "pokemon6Happiness_nbr"
        pokemon6Happiness_nbr.Size = New Size(140, 23)
        pokemon6Happiness_nbr.TabIndex = 81
        pokemon6Happiness_nbr.Value = New Decimal(New Integer() {70, 0, 0, 0})
        ' 
        ' pokemon6Shadow_grp
        ' 
        pokemon6Shadow_grp.Controls.Add(pokemon6Shadow_rad)
        pokemon6Shadow_grp.Controls.Add(pokemon6NotShadow_rad)
        pokemon6Shadow_grp.Location = New Point(444, 198)
        pokemon6Shadow_grp.Name = "pokemon6Shadow_grp"
        pokemon6Shadow_grp.Size = New Size(273, 82)
        pokemon6Shadow_grp.TabIndex = 80
        pokemon6Shadow_grp.TabStop = False
        pokemon6Shadow_grp.Text = "Shadow"
        ' 
        ' pokemon6Shadow_rad
        ' 
        pokemon6Shadow_rad.AutoSize = True
        pokemon6Shadow_rad.Location = New Point(6, 47)
        pokemon6Shadow_rad.Name = "pokemon6Shadow_rad"
        pokemon6Shadow_rad.Size = New Size(67, 19)
        pokemon6Shadow_rad.TabIndex = 1
        pokemon6Shadow_rad.Text = "Shadow"
        pokemon6Shadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon6NotShadow_rad
        ' 
        pokemon6NotShadow_rad.AutoSize = True
        pokemon6NotShadow_rad.Checked = True
        pokemon6NotShadow_rad.Location = New Point(6, 22)
        pokemon6NotShadow_rad.Name = "pokemon6NotShadow_rad"
        pokemon6NotShadow_rad.Size = New Size(90, 19)
        pokemon6NotShadow_rad.TabIndex = 0
        pokemon6NotShadow_rad.TabStop = True
        pokemon6NotShadow_rad.Text = "Not Shadow"
        pokemon6NotShadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon6Name_lbl
        ' 
        pokemon6Name_lbl.AutoSize = True
        pokemon6Name_lbl.Location = New Point(6, 19)
        pokemon6Name_lbl.Name = "pokemon6Name_lbl"
        pokemon6Name_lbl.Size = New Size(93, 15)
        pokemon6Name_lbl.TabIndex = 56
        pokemon6Name_lbl.Text = "Pokémon Name"
        ' 
        ' pokemon6EVs_grp
        ' 
        pokemon6EVs_grp.Controls.Add(pokemon6EVsDEF_txt)
        pokemon6EVs_grp.Controls.Add(pokemon6EVsDEF_lbl)
        pokemon6EVs_grp.Controls.Add(pokemon6EVsSPDEF_txt)
        pokemon6EVs_grp.Controls.Add(pokemon6EVsSPDEF_lbl)
        pokemon6EVs_grp.Controls.Add(pokemon6EVsSPATK_txt)
        pokemon6EVs_grp.Controls.Add(pokemon6EVsSPATK_lbl)
        pokemon6EVs_grp.Controls.Add(pokemon6EVsSPD_txt)
        pokemon6EVs_grp.Controls.Add(pokemon6EVsSPD_lbl)
        pokemon6EVs_grp.Controls.Add(pokemon6EVsATK_txt)
        pokemon6EVs_grp.Controls.Add(pokemon6EVsATK_lbl)
        pokemon6EVs_grp.Controls.Add(pokemon6EVsHP_txt)
        pokemon6EVs_grp.Controls.Add(pokemon6EVsHP_lbl)
        pokemon6EVs_grp.Location = New Point(324, 154)
        pokemon6EVs_grp.Name = "pokemon6EVs_grp"
        pokemon6EVs_grp.Size = New Size(114, 156)
        pokemon6EVs_grp.TabIndex = 79
        pokemon6EVs_grp.TabStop = False
        pokemon6EVs_grp.Text = "EVs"
        ' 
        ' pokemon6EVsDEF_txt
        ' 
        pokemon6EVsDEF_txt.Location = New Point(6, 125)
        pokemon6EVsDEF_txt.MaxLength = 3
        pokemon6EVsDEF_txt.Name = "pokemon6EVsDEF_txt"
        pokemon6EVsDEF_txt.Size = New Size(44, 23)
        pokemon6EVsDEF_txt.TabIndex = 11
        pokemon6EVsDEF_txt.Text = "0"
        ' 
        ' pokemon6EVsDEF_lbl
        ' 
        pokemon6EVsDEF_lbl.AutoSize = True
        pokemon6EVsDEF_lbl.Location = New Point(14, 107)
        pokemon6EVsDEF_lbl.Name = "pokemon6EVsDEF_lbl"
        pokemon6EVsDEF_lbl.Size = New Size(27, 15)
        pokemon6EVsDEF_lbl.TabIndex = 10
        pokemon6EVsDEF_lbl.Text = "DEF"
        ' 
        ' pokemon6EVsSPDEF_txt
        ' 
        pokemon6EVsSPDEF_txt.Location = New Point(55, 125)
        pokemon6EVsSPDEF_txt.MaxLength = 3
        pokemon6EVsSPDEF_txt.Name = "pokemon6EVsSPDEF_txt"
        pokemon6EVsSPDEF_txt.Size = New Size(44, 23)
        pokemon6EVsSPDEF_txt.TabIndex = 9
        pokemon6EVsSPDEF_txt.Text = "0"
        ' 
        ' pokemon6EVsSPDEF_lbl
        ' 
        pokemon6EVsSPDEF_lbl.AutoSize = True
        pokemon6EVsSPDEF_lbl.Location = New Point(55, 109)
        pokemon6EVsSPDEF_lbl.Name = "pokemon6EVsSPDEF_lbl"
        pokemon6EVsSPDEF_lbl.Size = New Size(40, 15)
        pokemon6EVsSPDEF_lbl.TabIndex = 8
        pokemon6EVsSPDEF_lbl.Text = "SPDEF"
        ' 
        ' pokemon6EVsSPATK_txt
        ' 
        pokemon6EVsSPATK_txt.Location = New Point(55, 81)
        pokemon6EVsSPATK_txt.MaxLength = 3
        pokemon6EVsSPATK_txt.Name = "pokemon6EVsSPATK_txt"
        pokemon6EVsSPATK_txt.Size = New Size(44, 23)
        pokemon6EVsSPATK_txt.TabIndex = 7
        pokemon6EVsSPATK_txt.Text = "0"
        ' 
        ' pokemon6EVsSPATK_lbl
        ' 
        pokemon6EVsSPATK_lbl.AutoSize = True
        pokemon6EVsSPATK_lbl.Location = New Point(56, 65)
        pokemon6EVsSPATK_lbl.Name = "pokemon6EVsSPATK_lbl"
        pokemon6EVsSPATK_lbl.Size = New Size(39, 15)
        pokemon6EVsSPATK_lbl.TabIndex = 6
        pokemon6EVsSPATK_lbl.Text = "SPATK"
        ' 
        ' pokemon6EVsSPD_txt
        ' 
        pokemon6EVsSPD_txt.Location = New Point(55, 37)
        pokemon6EVsSPD_txt.MaxLength = 3
        pokemon6EVsSPD_txt.Name = "pokemon6EVsSPD_txt"
        pokemon6EVsSPD_txt.Size = New Size(44, 23)
        pokemon6EVsSPD_txt.TabIndex = 5
        pokemon6EVsSPD_txt.Text = "0"
        ' 
        ' pokemon6EVsSPD_lbl
        ' 
        pokemon6EVsSPD_lbl.AutoSize = True
        pokemon6EVsSPD_lbl.Location = New Point(63, 21)
        pokemon6EVsSPD_lbl.Name = "pokemon6EVsSPD_lbl"
        pokemon6EVsSPD_lbl.Size = New Size(28, 15)
        pokemon6EVsSPD_lbl.TabIndex = 4
        pokemon6EVsSPD_lbl.Text = "SPD"
        ' 
        ' pokemon6EVsATK_txt
        ' 
        pokemon6EVsATK_txt.Location = New Point(6, 81)
        pokemon6EVsATK_txt.MaxLength = 3
        pokemon6EVsATK_txt.Name = "pokemon6EVsATK_txt"
        pokemon6EVsATK_txt.Size = New Size(44, 23)
        pokemon6EVsATK_txt.TabIndex = 3
        pokemon6EVsATK_txt.Text = "0"
        ' 
        ' pokemon6EVsATK_lbl
        ' 
        pokemon6EVsATK_lbl.AutoSize = True
        pokemon6EVsATK_lbl.Location = New Point(14, 63)
        pokemon6EVsATK_lbl.Name = "pokemon6EVsATK_lbl"
        pokemon6EVsATK_lbl.Size = New Size(27, 15)
        pokemon6EVsATK_lbl.TabIndex = 2
        pokemon6EVsATK_lbl.Text = "ATK"
        ' 
        ' pokemon6EVsHP_txt
        ' 
        pokemon6EVsHP_txt.Location = New Point(6, 37)
        pokemon6EVsHP_txt.MaxLength = 3
        pokemon6EVsHP_txt.Name = "pokemon6EVsHP_txt"
        pokemon6EVsHP_txt.Size = New Size(44, 23)
        pokemon6EVsHP_txt.TabIndex = 1
        pokemon6EVsHP_txt.Text = "0"
        ' 
        ' pokemon6EVsHP_lbl
        ' 
        pokemon6EVsHP_lbl.AutoSize = True
        pokemon6EVsHP_lbl.Location = New Point(16, 19)
        pokemon6EVsHP_lbl.Name = "pokemon6EVsHP_lbl"
        pokemon6EVsHP_lbl.Size = New Size(23, 15)
        pokemon6EVsHP_lbl.TabIndex = 0
        pokemon6EVsHP_lbl.Text = "HP"
        ' 
        ' pokemon6Name_txt
        ' 
        pokemon6Name_txt.AutoCompleteCustomSource.AddRange(New String() {"BULBASAUR", "IVYSAUR", "VENUSAUR", "CHARMANDER", "CHARMELEON", "CHARIZARD", "SQUIRTLE", "WARTORTLE", "BLASTOISE", "CATERPIE", "METAPOD", "BUTTERFREE", "WEEDLE", "KAKUNA", "BEEDRILL", "PIDGEY", "PIDGEOTTO", "PIDGEOT", "RATTATA", "RATICATE", "SPEAROW", "FEAROW", "EKANS", "ARBOK", "PIKACHU", "RAICHU", "SANDSHREW", "SANDSLASH", "NIDORANfE", "NIDORINA", "NIDOQUEEN", "NIDORANmA", "NIDORINO", "NIDOKING", "CLEFAIRY", "CLEFABLE", "VULPIX", "NINETALES", "JIGGLYPUFF", "WIGGLYTUFF", "ZUBAT", "GOLBAT", "ODDISH", "GLOOM", "VILEPLUME", "PARAS", "PARASECT", "VENONAT", "VENOMOTH", "DIGLETT", "DUGTRIO", "MEOWTH", "PERSIAN", "PSYDUCK", "GOLDUCK", "MANKEY", "PRIMEAPE", "GROWLITHE", "ARCANINE", "POLIWAG", "POLIWHIRL", "POLIWRATH", "ABRA", "KADABRA", "ALAKAZAM", "MACHOP", "MACHOKE", "MACHAMP", "BELLSPROUT", "WEEPINBELL", "VICTREEBEL", "TENTACOOL", "TENTACRUEL", "GEODUDE", "GRAVELER", "GOLEM", "PONYTA", "RAPIDASH", "SLOWPOKE", "SLOWBRO", "MAGNEMITE", "MAGNETON", "FARFETCHD", "DODUO", "DODRIO", "SEEL", "DEWGONG", "GRIMER", "MUK", "SHELLDER", "CLOYSTER", "GASTLY", "HAUNTER", "GENGAR", "ONIX", "DROWZEE", "HYPNO", "KRABBY", "KINGLER", "VOLTORB", "ELECTRODE", "EXEGGCUTE", "EXEGGUTOR", "CUBONE", "MAROWAK", "HITMONLEE", "HITMONCHAN", "LICKITUNG", "KOFFING", "WEEZING", "RHYHORN", "RHYDON", "CHANSEY", "TANGELA", "KANGASKHAN", "HORSEA", "SEADRA", "GOLDEEN", "SEAKING", "STARYU", "STARMIE", "MRMIME", "SCYTHER", "JYNX", "ELECTABUZZ", "MAGMAR", "PINSIR", "TAUROS", "MAGIKARP", "GYARADOS", "LAPRAS", "DITTO", "EEVEE", "VAPOREON", "JOLTEON", "FLAREON", "PORYGON", "OMANYTE", "OMASTAR", "KABUTO", "KABUTOPS", "AERODACTYL", "SNORLAX", "ARTICUNO", "ZAPDOS", "MOLTRES", "DRATINI", "DRAGONAIR", "DRAGONITE", "MEWTWO", "MEW", "CHIKORITA", "BAYLEEF", "MEGANIUM", "CYNDAQUIL", "QUILAVA", "TYPHLOSION", "TOTODILE", "CROCONAW", "FERALIGATR", "SENTRET", "FURRET", "HOOTHOOT", "NOCTOWL", "LEDYBA", "LEDIAN", "SPINARAK", "ARIADOS", "CROBAT", "CHINCHOU", "LANTURN", "PICHU", "CLEFFA", "IGGLYBUFF", "TOGEPI", "TOGETIC", "NATU", "XATU", "MAREEP", "FLAAFFY", "AMPHAROS", "BELLOSSOM", "MARILL", "AZUMARILL", "SUDOWOODO", "POLITOED", "HOPPIP", "SKIPLOOM", "JUMPLUFF", "AIPOM", "SUNKERN", "SUNFLORA", "YANMA", "WOOPER", "QUAGSIRE", "ESPEON", "UMBREON", "MURKROW", "SLOWKING", "MISDREAVUS", "UNOWN", "WOBBUFFET", "GIRAFARIG", "PINECO", "FORRETRESS", "DUNSPARCE", "GLIGAR", "STEELIX", "SNUBBULL", "GRANBULL", "QWILFISH", "SCIZOR", "SHUCKLE", "HERACROSS", "SNEASEL", "TEDDIURSA", "URSARING", "SLUGMA", "MAGCARGO", "SWINUB", "PILOSWINE", "CORSOLA", "REMORAID", "OCTILLERY", "DELIBIRD", "MANTINE", "SKARMORY", "HOUNDOUR", "HOUNDOOM", "KINGDRA", "PHANPY", "DONPHAN", "PORYGON2", "STANTLER", "SMEARGLE", "TYROGUE", "HITMONTOP", "SMOOCHUM", "ELEKID", "MAGBY", "MILTANK", "BLISSEY", "RAIKOU", "ENTEI", "SUICUNE", "LARVITAR", "PUPITAR", "TYRANITAR", "LUGIA", "HO-OH", "CELEBI", "TREECKO", "GROVYLE", "SCEPTILE", "TORCHIC", "COMBUSKEN", "BLAZIKEN", "MUDKIP", "MARSHTOMP", "SWAMPERT", "POOCHYENA", "MIGHTYENA", "ZIGZAGOON", "LINOONE", "WURMPLE", "SILCOON", "BEAUTIFLY", "CASCOON", "DUSTOX", "LOTAD", "LOMBRE", "LUDICOLO", "SEEDOT", "NUZLEAF", "SHIFTRY", "TAILLOW", "SWELLOW", "WINGULL", "PELIPPER", "RALTS", "KIRLIA", "GARDEVOIR", "SURSKIT", "MASQUERAIN", "SHROOMISH", "BRELOOM", "SLAKOTH", "VIGOROTH", "SLAKING", "NINCADA", "NINJASK", "SHEDINJA", "WHISMUR", "LOUDRED", "EXPLOUD", "MAKUHITA", "HARIYAMA", "AZURILL", "NOSEPASS", "SKITTY", "DELCATTY", "SABLEYE", "MAWILE", "ARON", "LAIRON", "AGGRON", "MEDITITE", "MEDICHAM", "ELECTRIKE", "MANECTRIC", "PLUSLE", "MINUN", "VOLBEAT", "ILLUMISE", "ROSELIA", "GULPIN", "SWALOT", "CARVANHA", "SHARPEDO", "WAILMER", "WAILORD", "NUMEL", "CAMERUPT", "TORKOAL", "SPOINK", "GRUMPIG", "SPINDA", "TRAPINCH", "VIBRAVA", "FLYGON", "CACNEA", "CACTURNE", "SWABLU", "ALTARIA", "ZANGOOSE", "SEVIPER", "LUNATONE", "SOLROCK", "BARBOACH", "WHISCASH", "CORPHISH", "CRAWDAUNT", "BALTOY", "CLAYDOL", "LILEEP", "CRADILY", "ANORITH", "ARMALDO", "FEEBAS", "MILOTIC", "CASTFORM", "KECLEON", "SHUPPET", "BANETTE", "DUSKULL", "DUSCLOPS", "TROPIUS", "CHIMECHO", "ABSOL", "WYNAUT", "SNORUNT", "GLALIE", "SPHEAL", "SEALEO", "WALREIN", "CLAMPERL", "HUNTAIL", "GOREBYSS", "RELICANTH", "LUVDISC", "BAGON", "SHELGON", "SALAMENCE", "BELDUM", "METANG", "METAGROSS", "REGIROCK", "REGICE", "REGISTEEL", "LATIAS", "LATIOS", "KYOGRE", "GROUDON", "RAYQUAZA", "JIRACHI", "DEOXYS", "TURTWIG", "GROTLE", "TORTERRA", "CHIMCHAR", "MONFERNO", "INFERNAPE", "PIPLUP", "PRINPLUP", "EMPOLEON", "STARLY", "STARAVIA", "STARAPTOR", "BIDOOF", "BIBAREL", "KRICKETOT", "KRICKETUNE", "SHINX", "LUXIO", "LUXRAY", "BUDEW", "ROSERADE", "CRANIDOS", "RAMPARDOS", "SHIELDON", "BASTIODON", "BURMY", "WORMADAM", "MOTHIM", "COMBEE", "VESPIQUEN", "PACHIRISU", "BUIZEL", "FLOATZEL", "CHERUBI", "CHERRIM", "SHELLOS", "GASTRODON", "AMBIPOM", "DRIFLOON", "DRIFBLIM", "BUNEARY", "LOPUNNY", "MISMAGIUS", "HONCHKROW", "GLAMEOW", "PURUGLY", "CHINGLING", "STUNKY", "SKUNTANK", "BRONZOR", "BRONZONG", "BONSLY", "MIMEJR", "HAPPINY", "CHATOT", "SPIRITOMB", "GIBLE", "GABITE", "GARCHOMP", "MUNCHLAX", "RIOLU", "LUCARIO", "HIPPOPOTAS", "HIPPOWDON", "SKORUPI", "DRAPION", "CROAGUNK", "TOXICROAK", "CARNIVINE", "FINNEON", "LUMINEON", "MANTYKE", "SNOVER", "ABOMASNOW", "WEAVILE", "MAGNEZONE", "LICKILICKY", "RHYPERIOR", "TANGROWTH", "ELECTIVIRE", "MAGMORTAR", "TOGEKISS", "YANMEGA", "LEAFEON", "GLACEON", "GLISCOR", "MAMOSWINE", "PORYGON-Z", "GALLADE", "PROBOPASS", "DUSKNOIR", "FROSLASS", "ROTOM", "UXIE", "MESPRIT", "AZELF", "DIALGA", "PALKIA", "HEATRAN", "REGIGIGAS", "GIRATINA", "CRESSELIA", "PHIONE", "MANAPHY", "DARKRAI", "SHAYMIN", "ARCEUS", "VICTINI", "SNIVY", "SERVINE", "SERPERIOR", "TEPIG", "PIGNITE", "EMBOAR", "OSHAWOTT", "DEWOTT", "SAMUROTT", "PATRAT", "WATCHOG", "LILLIPUP", "HERDIER", "STOUTLAND", "PURRLOIN", "LIEPARD", "PANSAGE", "SIMISAGE", "PANSEAR", "SIMISEAR", "PANPOUR", "SIMIPOUR", "MUNNA", "MUSHARNA", "PIDOVE", "TRANQUILL", "UNFEZANT", "BLITZLE", "ZEBSTRIKA", "ROGGENROLA", "BOLDORE", "GIGALITH", "WOOBAT", "SWOOBAT", "DRILBUR", "EXCADRILL", "AUDINO", "TIMBURR", "GURDURR", "CONKELDURR", "TYMPOLE", "PALPITOAD", "SEISMITOAD", "THROH", "SAWK", "SEWADDLE", "SWADLOON", "LEAVANNY", "VENIPEDE", "WHIRLIPEDE", "SCOLIPEDE", "COTTONEE", "WHIMSICOTT", "PETILIL", "LILLIGANT", "BASCULIN", "SANDILE", "KROKOROK", "KROOKODILE", "DARUMAKA", "DARMANITAN", "MARACTUS", "DWEBBLE", "CRUSTLE", "SCRAGGY", "SCRAFTY", "SIGILYPH", "YAMASK", "COFAGRIGUS", "TIRTOUGA", "CARRACOSTA", "ARCHEN", "ARCHEOPS", "TRUBBISH", "GARBODOR", "ZORUA", "ZOROARK", "MINCCINO", "CINCCINO", "GOTHITA", "GOTHORITA", "GOTHITELLE", "SOLOSIS", "DUOSION", "REUNICLUS", "DUCKLETT", "SWANNA", "VANILLITE", "VANILLISH", "VANILLUXE", "DEERLING", "SAWSBUCK", "EMOLGA", "KARRABLAST", "ESCAVALIER", "FOONGUS", "AMOONGUSS", "FRILLISH", "JELLICENT", "ALOMOMOLA", "JOLTIK", "GALVANTULA", "FERROSEED", "FERROTHORN", "KLINK", "KLANG", "KLINKLANG", "TYNAMO", "EELEKTRIK", "EELEKTROSS", "ELGYEM", "BEHEEYEM", "LITWICK", "LAMPENT", "CHANDELURE", "AXEW", "FRAXURE", "HAXORUS", "CUBCHOO", "BEARTIC", "CRYOGONAL", "SHELMET", "ACCELGOR", "STUNFISK", "MIENFOO", "MIENSHAO", "DRUDDIGON", "GOLETT", "GOLURK", "PAWNIARD", "BISHARP", "BOUFFALANT", "RUFFLET", "BRAVIARY", "VULLABY", "MANDIBUZZ", "HEATMOR", "DURANT", "DEINO", "ZWEILOUS", "HYDREIGON", "LARVESTA", "VOLCARONA", "COBALION", "TERRAKION", "VIRIZION", "TORNADUS", "THUNDURUS", "RESHIRAM", "ZEKROM", "LANDORUS", "KYUREM", "KELDEO", "MELOETTA", "GENESECT", "CHESPIN", "QUILLADIN", "CHESNAUGHT", "FENNEKIN", "BRAIXEN", "DELPHOX", "FROAKIE", "FROGADIER", "GRENINJA", "BUNNELBY", "DIGGERSBY", "FLETCHLING", "FLETCHINDER", "TALONFLAME", "SCATTERBUG", "SPEWPA", "VIVILLON", "LITLEO", "PYROAR", "FLABEBE", "FLOETTE", "FLORGES", "SKIDDO", "GOGOAT", "PANCHAM", "PANGORO", "FURFROU", "ESPURR", "MEOWSTIC", "HONEDGE", "DOUBLADE", "AEGISLASH", "SPRITZEE", "AROMATISSE", "SWIRLIX", "SLURPUFF", "INKAY", "MALAMAR", "BINACLE", "BARBARACLE", "SKRELP", "DRAGALGE", "CLAUNCHER", "CLAWITZER", "HELIOPTILE", "HELIOLISK", "TYRUNT", "TYRANTRUM", "AMAURA", "AURORUS", "SYLVEON", "HAWLUCHA", "DEDENNE", "CARBINK", "GOOMY", "SLIGGOO", "GOODRA", "KLEFKI", "PHANTUMP", "TREVENANT", "PUMPKABOO", "GOURGEIST", "BERGMITE", "AVALUGG", "NOIBAT", "NOIVERN", "XERNEAS", "YVELTAL", "ZYGARDE", "DIANCIE", "HOOPA", "VOLCANION", "ROWLET", "DARTRIX", "DECIDUEYE", "LITTEN", "TORRACAT", "INCINEROAR", "POPPLIO", "BRIONNE", "PRIMARINA", "PIKIPEK", "TRUMBEAK", "TOUCANNON", "YUNGOOS", "GUMSHOOS", "GRUBBIN", "CHARJABUG", "VIKAVOLT", "CRABRAWLER", "CRABOMINABLE", "ORICORIO", "CUTIEFLY", "RIBOMBEE", "ROCKRUFF", "LYCANROC", "WISHIWASHI", "MAREANIE", "TOXAPEX", "MUDBRAY", "MUDSDALE", "DEWPIDER", "ARAQUANID", "FOMANTIS", "LURANTIS", "MORELULL", "SHIINOTIC", "SALANDIT", "SALAZZLE", "STUFFUL", "BEWEAR", "BOUNSWEET", "STEENEE", "TSAREENA", "COMFEY", "ORANGURU", "PASSIMIAN", "WIMPOD", "GOLISOPOD", "SANDYGAST", "PALOSSAND", "PYUKUMUKU", "TYPENULL", "SILVALLY", "MINIOR", "KOMALA", "TURTONATOR", "TOGEDEMARU", "MIMIKYU", "BRUXISH", "DRAMPA", "DHELMISE", "JANGMO-O", "HAKAMO-O", "KOMMO-O", "TAPUKOKO", "TAPULELE", "TAPUBULU", "TAPUFINI", "COSMOG", "COSMOEM", "SOLGALEO", "LUNALA", "NIHILEGO", "BUZZWOLE", "PHEROMOSA", "XURKITREE", "CELESTEELA", "KARTANA", "GUZZLORD", "NECROZMA", "MAGEARNA", "MARSHADOW", "POIPOLE", "NAGANADEL", "STAKATAKA", "BLACEPHALON", "ZERAORA", "MELTAN", "MELMETAL", "GROOKEY", "THWACKEY", "RILLABOOM", "SCORBUNNY", "RABOOT", "CINDERACE", "SOBBLE", "DRIZZILE", "INTELEON", "SKWOVET", "GREEDENT", "ROOKIDEE", "CORVISQUIRE", "CORVIKNIGHT", "BLIPBUG", "DOTTLER", "ORBEETLE", "NICKIT", "THIEVUL", "GOSSIFLEUR", "ELDEGOSS", "WOOLOO", "DUBWOOL", "CHEWTLE", "DREDNAW", "YAMPER", "BOLTUND", "ROLYCOLY", "CARKOL", "COALOSSAL", "APPLIN", "FLAPPLE", "APPLETUN", "SILICOBRA", "SANDACONDA", "CRAMORANT", "ARROKUDA", "BARRASKEWDA", "TOXEL", "TOXTRICITY", "SIZZLIPEDE", "CENTISKORCH", "CLOBBOPUS", "GRAPPLOCT", "SINISTEA", "POLTEAGEIST", "HATENNA", "HATTREM", "HATTERENE", "IMPIDIMP", "MORGREM", "GRIMMSNARL", "OBSTAGOON", "PERRSERKER", "CURSOLA", "SIRFETCHD", "MRRIME", "RUNERIGUS", "MILCERY", "ALCREMIE", "FALINKS", "PINCURCHIN", "SNOM", "FROSMOTH", "STONJOURNER", "EISCUE", "INDEEDEE", "MORPEKO", "CUFANT", "COPPERAJAH", "DRACOZOLT", "ARCTOZOLT", "DRACOVISH", "ARCTOVISH", "DURALUDON", "DREEPY", "DRAKLOAK", "DRAGAPULT", "ZACIAN", "ZAMAZENTA", "ETERNATUS", "KUBFU", "URSHIFU", "ZARUDE", "REGIELEKI", "REGIDRAGO", "GLASTRIER", "SPECTRIER", "CALYREX"})
        pokemon6Name_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon6Name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon6Name_txt.Location = New Point(6, 37)
        pokemon6Name_txt.Name = "pokemon6Name_txt"
        pokemon6Name_txt.PlaceholderText = "Bulbasaur"
        pokemon6Name_txt.Size = New Size(140, 23)
        pokemon6Name_txt.TabIndex = 57
        ' 
        ' pokemon6IVs_grp
        ' 
        pokemon6IVs_grp.Controls.Add(pokemon6RandomIVs_btn)
        pokemon6IVs_grp.Controls.Add(pokemon6MaxIVs_btn)
        pokemon6IVs_grp.Controls.Add(pokemon6IVsDEF_txt)
        pokemon6IVs_grp.Controls.Add(pokemon6IVsDEF_lbl)
        pokemon6IVs_grp.Controls.Add(pokemon6IVsSPDEF_txt)
        pokemon6IVs_grp.Controls.Add(pokemon6IVsSPDEF_lbl)
        pokemon6IVs_grp.Controls.Add(pokemon6IVsSPATK_txt)
        pokemon6IVs_grp.Controls.Add(pokemon6IVsSPATK_lbl)
        pokemon6IVs_grp.Controls.Add(pokemon6IVsSPD_txt)
        pokemon6IVs_grp.Controls.Add(pokemon6IVsSPD_lbl)
        pokemon6IVs_grp.Controls.Add(pokemon6IVsATK_txt)
        pokemon6IVs_grp.Controls.Add(pokemon6IVsATK_lbl)
        pokemon6IVs_grp.Controls.Add(pokemon6IVsHP_txt)
        pokemon6IVs_grp.Controls.Add(pokemon6IVsHP_lbl)
        pokemon6IVs_grp.Location = New Point(204, 154)
        pokemon6IVs_grp.Name = "pokemon6IVs_grp"
        pokemon6IVs_grp.Size = New Size(114, 188)
        pokemon6IVs_grp.TabIndex = 78
        pokemon6IVs_grp.TabStop = False
        pokemon6IVs_grp.Text = "IVs (Max 31 Each)"
        ' 
        ' pokemon6RandomIVs_btn
        ' 
        pokemon6RandomIVs_btn.Location = New Point(57, 152)
        pokemon6RandomIVs_btn.Name = "pokemon6RandomIVs_btn"
        pokemon6RandomIVs_btn.Size = New Size(44, 23)
        pokemon6RandomIVs_btn.TabIndex = 15
        pokemon6RandomIVs_btn.Text = "Rand"
        pokemon6RandomIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon6MaxIVs_btn
        ' 
        pokemon6MaxIVs_btn.Location = New Point(7, 152)
        pokemon6MaxIVs_btn.Name = "pokemon6MaxIVs_btn"
        pokemon6MaxIVs_btn.Size = New Size(44, 23)
        pokemon6MaxIVs_btn.TabIndex = 14
        pokemon6MaxIVs_btn.Text = "Max"
        pokemon6MaxIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon6IVsDEF_txt
        ' 
        pokemon6IVsDEF_txt.Location = New Point(7, 123)
        pokemon6IVsDEF_txt.MaxLength = 3
        pokemon6IVsDEF_txt.Name = "pokemon6IVsDEF_txt"
        pokemon6IVsDEF_txt.Size = New Size(44, 23)
        pokemon6IVsDEF_txt.TabIndex = 13
        pokemon6IVsDEF_txt.Text = "0"
        ' 
        ' pokemon6IVsDEF_lbl
        ' 
        pokemon6IVsDEF_lbl.AutoSize = True
        pokemon6IVsDEF_lbl.Location = New Point(18, 105)
        pokemon6IVsDEF_lbl.Name = "pokemon6IVsDEF_lbl"
        pokemon6IVsDEF_lbl.Size = New Size(27, 15)
        pokemon6IVsDEF_lbl.TabIndex = 12
        pokemon6IVsDEF_lbl.Text = "DEF"
        ' 
        ' pokemon6IVsSPDEF_txt
        ' 
        pokemon6IVsSPDEF_txt.Location = New Point(57, 123)
        pokemon6IVsSPDEF_txt.MaxLength = 3
        pokemon6IVsSPDEF_txt.Name = "pokemon6IVsSPDEF_txt"
        pokemon6IVsSPDEF_txt.Size = New Size(44, 23)
        pokemon6IVsSPDEF_txt.TabIndex = 9
        pokemon6IVsSPDEF_txt.Text = "0"
        ' 
        ' pokemon6IVsSPDEF_lbl
        ' 
        pokemon6IVsSPDEF_lbl.AutoSize = True
        pokemon6IVsSPDEF_lbl.Location = New Point(59, 105)
        pokemon6IVsSPDEF_lbl.Name = "pokemon6IVsSPDEF_lbl"
        pokemon6IVsSPDEF_lbl.Size = New Size(40, 15)
        pokemon6IVsSPDEF_lbl.TabIndex = 8
        pokemon6IVsSPDEF_lbl.Text = "SPDEF"
        ' 
        ' pokemon6IVsSPATK_txt
        ' 
        pokemon6IVsSPATK_txt.Location = New Point(57, 79)
        pokemon6IVsSPATK_txt.MaxLength = 3
        pokemon6IVsSPATK_txt.Name = "pokemon6IVsSPATK_txt"
        pokemon6IVsSPATK_txt.Size = New Size(44, 23)
        pokemon6IVsSPATK_txt.TabIndex = 7
        pokemon6IVsSPATK_txt.Text = "0"
        ' 
        ' pokemon6IVsSPATK_lbl
        ' 
        pokemon6IVsSPATK_lbl.AutoSize = True
        pokemon6IVsSPATK_lbl.Location = New Point(59, 61)
        pokemon6IVsSPATK_lbl.Name = "pokemon6IVsSPATK_lbl"
        pokemon6IVsSPATK_lbl.Size = New Size(39, 15)
        pokemon6IVsSPATK_lbl.TabIndex = 6
        pokemon6IVsSPATK_lbl.Text = "SPATK"
        ' 
        ' pokemon6IVsSPD_txt
        ' 
        pokemon6IVsSPD_txt.Location = New Point(57, 35)
        pokemon6IVsSPD_txt.MaxLength = 3
        pokemon6IVsSPD_txt.Name = "pokemon6IVsSPD_txt"
        pokemon6IVsSPD_txt.Size = New Size(44, 23)
        pokemon6IVsSPD_txt.TabIndex = 5
        pokemon6IVsSPD_txt.Text = "0"
        ' 
        ' pokemon6IVsSPD_lbl
        ' 
        pokemon6IVsSPD_lbl.AutoSize = True
        pokemon6IVsSPD_lbl.Location = New Point(65, 17)
        pokemon6IVsSPD_lbl.Name = "pokemon6IVsSPD_lbl"
        pokemon6IVsSPD_lbl.Size = New Size(28, 15)
        pokemon6IVsSPD_lbl.TabIndex = 4
        pokemon6IVsSPD_lbl.Text = "SPD"
        ' 
        ' pokemon6IVsATK_txt
        ' 
        pokemon6IVsATK_txt.Location = New Point(7, 79)
        pokemon6IVsATK_txt.MaxLength = 3
        pokemon6IVsATK_txt.Name = "pokemon6IVsATK_txt"
        pokemon6IVsATK_txt.Size = New Size(44, 23)
        pokemon6IVsATK_txt.TabIndex = 3
        pokemon6IVsATK_txt.Text = "0"
        ' 
        ' pokemon6IVsATK_lbl
        ' 
        pokemon6IVsATK_lbl.AutoSize = True
        pokemon6IVsATK_lbl.Location = New Point(18, 61)
        pokemon6IVsATK_lbl.Name = "pokemon6IVsATK_lbl"
        pokemon6IVsATK_lbl.Size = New Size(27, 15)
        pokemon6IVsATK_lbl.TabIndex = 2
        pokemon6IVsATK_lbl.Text = "ATK"
        ' 
        ' pokemon6IVsHP_txt
        ' 
        pokemon6IVsHP_txt.Location = New Point(7, 35)
        pokemon6IVsHP_txt.MaxLength = 3
        pokemon6IVsHP_txt.Name = "pokemon6IVsHP_txt"
        pokemon6IVsHP_txt.Size = New Size(44, 23)
        pokemon6IVsHP_txt.TabIndex = 1
        pokemon6IVsHP_txt.Text = "0"
        ' 
        ' pokemon6IVsHP_lbl
        ' 
        pokemon6IVsHP_lbl.AutoSize = True
        pokemon6IVsHP_lbl.Location = New Point(18, 19)
        pokemon6IVsHP_lbl.Name = "pokemon6IVsHP_lbl"
        pokemon6IVsHP_lbl.Size = New Size(23, 15)
        pokemon6IVsHP_lbl.TabIndex = 0
        pokemon6IVsHP_lbl.Text = "HP"
        ' 
        ' pokemon6HeldItem_txt
        ' 
        pokemon6HeldItem_txt.Location = New Point(152, 37)
        pokemon6HeldItem_txt.Name = "pokemon6HeldItem_txt"
        pokemon6HeldItem_txt.PlaceholderText = "FocusSash"
        pokemon6HeldItem_txt.Size = New Size(140, 23)
        pokemon6HeldItem_txt.TabIndex = 58
        ' 
        ' pokemon6PokeballID_cmb
        ' 
        pokemon6PokeballID_cmb.FormattingEnabled = True
        pokemon6PokeballID_cmb.Items.AddRange(New Object() {"POKEBALL", "GREATBALL", "SAFARIBALL", "ULTRABALL", "MASTERBALL", "NETBALL", "DIVEBALL", "NESTBALL", "REPEATBALL", "TIMERBALL", "LUXURYBALL", "PREMIERBALL", "DUSKBALL", "HEALBALL", "QUICKBALL", "CHERISHBALL", "FASTBALL", "LEVELBALL", "LUREBALL", "HEAVYBALL", "LOVEBALL", "FRIENDBALL", "MOONBALL", "SPORTBALL", "DREAMBALL", "BEASTBALL"})
        pokemon6PokeballID_cmb.Location = New Point(6, 169)
        pokemon6PokeballID_cmb.Name = "pokemon6PokeballID_cmb"
        pokemon6PokeballID_cmb.Size = New Size(140, 23)
        pokemon6PokeballID_cmb.TabIndex = 77
        ' 
        ' pokemon6HeldItem_lbl
        ' 
        pokemon6HeldItem_lbl.AutoSize = True
        pokemon6HeldItem_lbl.Location = New Point(152, 19)
        pokemon6HeldItem_lbl.Name = "pokemon6HeldItem_lbl"
        pokemon6HeldItem_lbl.Size = New Size(59, 15)
        pokemon6HeldItem_lbl.TabIndex = 59
        pokemon6HeldItem_lbl.Text = "Held Item"
        ' 
        ' pokemon6Pokeball_lbl
        ' 
        pokemon6Pokeball_lbl.AutoSize = True
        pokemon6Pokeball_lbl.Location = New Point(8, 151)
        pokemon6Pokeball_lbl.Name = "pokemon6Pokeball_lbl"
        pokemon6Pokeball_lbl.Size = New Size(52, 15)
        pokemon6Pokeball_lbl.TabIndex = 76
        pokemon6Pokeball_lbl.Text = "PokéBall"
        ' 
        ' pokemon6Level_lbl
        ' 
        pokemon6Level_lbl.AutoSize = True
        pokemon6Level_lbl.Location = New Point(298, 19)
        pokemon6Level_lbl.Name = "pokemon6Level_lbl"
        pokemon6Level_lbl.Size = New Size(34, 15)
        pokemon6Level_lbl.TabIndex = 60
        pokemon6Level_lbl.Text = "Level"
        ' 
        ' pokemon6Nickname_txt
        ' 
        pokemon6Nickname_txt.Location = New Point(298, 125)
        pokemon6Nickname_txt.Name = "pokemon6Nickname_txt"
        pokemon6Nickname_txt.PlaceholderText = "Bloom"
        pokemon6Nickname_txt.Size = New Size(140, 23)
        pokemon6Nickname_txt.TabIndex = 75
        ' 
        ' pokemon6Nickname_lbl
        ' 
        pokemon6Nickname_lbl.AutoSize = True
        pokemon6Nickname_lbl.Location = New Point(298, 107)
        pokemon6Nickname_lbl.Name = "pokemon6Nickname_lbl"
        pokemon6Nickname_lbl.Size = New Size(61, 15)
        pokemon6Nickname_lbl.TabIndex = 74
        pokemon6Nickname_lbl.Text = "Nickname"
        ' 
        ' pokemon6Moves_grp
        ' 
        pokemon6Moves_grp.Controls.Add(pokemon6Move4_txt)
        pokemon6Moves_grp.Controls.Add(pokemon6Move3_txt)
        pokemon6Moves_grp.Controls.Add(pokemon6Move2_txt)
        pokemon6Moves_grp.Controls.Add(pokemon6Move1_txt)
        pokemon6Moves_grp.Location = New Point(444, 22)
        pokemon6Moves_grp.Name = "pokemon6Moves_grp"
        pokemon6Moves_grp.Size = New Size(273, 82)
        pokemon6Moves_grp.TabIndex = 62
        pokemon6Moves_grp.TabStop = False
        pokemon6Moves_grp.Text = "Moves"
        ' 
        ' pokemon6Move4_txt
        ' 
        pokemon6Move4_txt.Location = New Point(132, 51)
        pokemon6Move4_txt.Name = "pokemon6Move4_txt"
        pokemon6Move4_txt.PlaceholderText = "Move 4"
        pokemon6Move4_txt.Size = New Size(120, 23)
        pokemon6Move4_txt.TabIndex = 3
        ' 
        ' pokemon6Move3_txt
        ' 
        pokemon6Move3_txt.Location = New Point(6, 51)
        pokemon6Move3_txt.Name = "pokemon6Move3_txt"
        pokemon6Move3_txt.PlaceholderText = "Move 3"
        pokemon6Move3_txt.Size = New Size(120, 23)
        pokemon6Move3_txt.TabIndex = 2
        ' 
        ' pokemon6Move2_txt
        ' 
        pokemon6Move2_txt.Location = New Point(132, 22)
        pokemon6Move2_txt.Name = "pokemon6Move2_txt"
        pokemon6Move2_txt.PlaceholderText = "Move 2"
        pokemon6Move2_txt.Size = New Size(120, 23)
        pokemon6Move2_txt.TabIndex = 1
        ' 
        ' pokemon6Move1_txt
        ' 
        pokemon6Move1_txt.Location = New Point(6, 22)
        pokemon6Move1_txt.Name = "pokemon6Move1_txt"
        pokemon6Move1_txt.PlaceholderText = "Move 1"
        pokemon6Move1_txt.Size = New Size(120, 23)
        pokemon6Move1_txt.TabIndex = 0
        ' 
        ' pokemon6Ability_lbl
        ' 
        pokemon6Ability_lbl.AutoSize = True
        pokemon6Ability_lbl.Location = New Point(6, 63)
        pokemon6Ability_lbl.Name = "pokemon6Ability_lbl"
        pokemon6Ability_lbl.Size = New Size(41, 15)
        pokemon6Ability_lbl.TabIndex = 63
        pokemon6Ability_lbl.Text = "Ability"
        ' 
        ' pokemon6Happiness_lbl
        ' 
        pokemon6Happiness_lbl.AutoSize = True
        pokemon6Happiness_lbl.Location = New Point(152, 107)
        pokemon6Happiness_lbl.Name = "pokemon6Happiness_lbl"
        pokemon6Happiness_lbl.Size = New Size(62, 15)
        pokemon6Happiness_lbl.TabIndex = 72
        pokemon6Happiness_lbl.Text = "Happiness"
        ' 
        ' pokemon6Ability_cmb
        ' 
        pokemon6Ability_cmb.AutoCompleteCustomSource.AddRange(New String() {"Aerilate", "Aftermath", "Air Lock", "Analytic", "Anger Point", "Anger Shell", "Anticipation", "Arena Trap", "Armor Tail", "Aroma Veil", "As One - Unnerve Chilling Neigh", "As One - Unnerve Grim Neigh", "Aura Break", "Bad Dreams", "Ball Fetch", "Battery", "Battle Armor", "Battle Bond", "Beads of Ruin", "Beast Boost", "Berserk", "Big Pecks", "Blaze", "Bulletproof", "Cheek Pouch", "Chilling Neigh", "Chlorophyll", "Clear Body", "Cloud Nine", "Color Change", "Comatose", "Commander", "Competitive", "Compoundeyes", "Contrary", "Corrosion", "Costar", "Cotton Down", "Cud Chew", "Curious Medicine", "Cursed Body", "Cute Charm", "Damp", "Dancer", "Dark Aura", "Dauntless Shield", "Dazzling", "Defeatist", "Defiant", "Delta Stream", "Desolate Land", "Disguise", "Download", "Dragon's Maw", "Drizzle", "Drought", "Dry Skin", "Early Bird", "Earth Eater", "Effect Spore", "Electric Surge", "Electromorphosis", "Embody Aspect - Cornerstone Mask", "Embody Aspect - Hearthflame Mask", "Embody Aspect - Teal Mask", "Embody Aspect - Wellspring Mask", "Emergency Exit", "Fairy Aura", "Filter", "Flame Body", "Flare Boost", "Flash Fire", "Flower Gift", "Flower Veil", "Fluffy", "Forecast", "Forewarn", "Friend Guard", "Frisk", "Full Metal Body", "Fur Coat", "Gale Wings", "Galvanize", "Gluttony", "Good as Gold", "Gooey", "Gorilla Tactics", "Grass Pelt", "Grassy Surge", "Grim Neigh", "Guard Dog", "Gulp Missile", "Guts", "Hadron Engine", "Harvest", "Healer", "Heatproof", "Heavy Metal", "Honey Gather", "Hospitality", "Huge Power", "Hunger Switch", "Hustle", "Hydration", "Hyper Cutter", "Ice Body", "Ice Face", "Ice Scales", "Illuminate", "Illusion", "Immunity", "Imposter", "Infiltrator", "Innards Out", "Inner Focus", "Insomnia", "Intimidate", "Intrepid Sword", "Iron Barbs", "Iron Fist", "Justified", "Keen Eye", "Klutz", "Leaf Guard", "Levitate", "Libero", "Light Metal", "Lightning Rod", "Limber", "Lingering Aroma", "Liquid Ooze", "Liquid Voice", "Long Reach", "Magic Bounce", "Magic Guard", "Magician", "Magma Armor", "Magnet Pull", "Marvel Scale", "Mega Launcher", "Merciless", "Mimicry", "Mind's Eye", "Minus", "Mirror Armor", "Misty Surge", "Mold Breaker", "Moody", "Motor Drive", "Moxie", "Multiscale", "Multitype", "Mummy", "Mycelium Might", "Natural Cure", "Neuroforce", "Neutralizing Gas", "No Guard", "Normalize", "Oblivious", "Opportunist", "Orichalcum Pulse", "Overcoat", "Overgrow", "Own Tempo", "Parental Bond", "Pastel Veil", "Perish Body", "Pickpocket", "Pickup", "Pixilate", "Plus", "Poison Heal", "Poison Point", "Poison Touch", "Power Construct", "Power of Alchemy", "Power Spot", "Prankster", "Pressure", "Primordial Sea", "Prism Armor", "Propeller Tail", "Protean", "Protosynthesis", "Psychic Surge", "Punk Rock", "Pure Power", "Purifying Salt", "Quark Drive", "Queenly Majesty", "Quick Draw", "Quick Feet", "Rain Dish", "Rattled", "Receiver", "Reckless", "Refrigerate", "Regenerator", "Ripen", "Rivalry", "RKS System", "Rock Head", "Rocky Payload", "Rough Skin", "Run Away", "Sand Force", "Sand Rush", "Sand Spit", "Sand Stream", "Sand Veil", "Sap Sipper", "Schooling", "Scrappy", "Screen Cleaner", "Seed Sower", "Serene Grace", "Shadow Shield", "Shadow Tag", "Sharpness", "Shed Skin", "Sheer Force", "Shell Armor", "Shield Dust", "Shields Down", "Simple", "Skill Link", "Slow Start", "Slush Rush", "Sniper", "Snow Cloak", "Snow Warning", "Solar Power", "Solid Rock", "Soul-Heart", "Soundproof", "Speed Boost", "Stakeout", "Stall", "Stalwart", "Stamina", "Stance Change", "Static", "Steadfast", "Steam Engine", "Steelworker", "Steely Spirit", "Stench", "Sticky Hold", "Storm Drain", "Strong Jaw", "Sturdy", "Suction Cups", "Super Luck", "Supersweet Syrup", "Supreme Overlord", "Surge Surfer", "Swarm", "Sweet Veil", "Swift Swim", "Sword of Ruin", "Symbiosis", "Synchronize", "Tablets of Ruin", "Tangled Feet", "Tangling Hair", "Technician", "Telepathy", "Teravolt", "Thermal Exchange", "Thick Fat", "Tinted Lens", "Torrent", "Tough Claws", "Toxic Boost", "Toxic Chain", "Toxic Debris", "Trace", "Transistor", "Triage", "Truant", "Turboblaze", "Unaware", "Unburden", "Unnerve", "Unseen Fist", "Vessel of Ruin", "Victory Star", "Vital Spirit", "Volt Absorb", "Wandering Spirit", "Water Absorb", "Water Bubble", "Water Compaction", "Water Veil", "Weak Armor", "Well-Baked Body", "White Smoke", "Wimp Out", "Wind Power", "Wind Rider", "Wonder Guard", "Wonder Skin ", "Zen Mode", "Zero to Hero"})
        pokemon6Ability_cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon6Ability_cmb.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon6Ability_cmb.FormattingEnabled = True
        pokemon6Ability_cmb.Items.AddRange(New Object() {"Aerilate", "Aftermath", "Air Lock", "Analytic", "Anger Point", "Anger Shell", "Anticipation", "Arena Trap", "Armor Tail", "Aroma Veil", "As One - Unnerve Chilling Neigh", "As One - Unnerve Grim Neigh", "Aura Break", "Bad Dreams", "Ball Fetch", "Battery", "Battle Armor", "Battle Bond", "Beads of Ruin", "Beast Boost", "Berserk", "Big Pecks", "Blaze", "Bulletproof", "Cheek Pouch", "Chilling Neigh", "Chlorophyll", "Clear Body", "Cloud Nine", "Color Change", "Comatose", "Commander", "Competitive", "Compoundeyes", "Contrary", "Corrosion", "Costar", "Cotton Down", "Cud Chew", "Curious Medicine", "Cursed Body", "Cute Charm", "Damp", "Dancer", "Dark Aura", "Dauntless Shield", "Dazzling", "Defeatist", "Defiant", "Delta Stream", "Desolate Land", "Disguise", "Download", "Dragon's Maw", "Drizzle", "Drought", "Dry Skin", "Early Bird", "Earth Eater", "Effect Spore", "Electric Surge", "Electromorphosis", "Embody Aspect - Cornerstone Mask", "Embody Aspect - Hearthflame Mask", "Embody Aspect - Teal Mask", "Embody Aspect - Wellspring Mask", "Emergency Exit", "Fairy Aura", "Filter", "Flame Body", "Flare Boost", "Flash Fire", "Flower Gift", "Flower Veil", "Fluffy", "Forecast", "Forewarn", "Friend Guard", "Frisk", "Full Metal Body", "Fur Coat", "Gale Wings", "Galvanize", "Gluttony", "Good as Gold", "Gooey", "Gorilla Tactics", "Grass Pelt", "Grassy Surge", "Grim Neigh", "Guard Dog", "Gulp Missile", "Guts", "Hadron Engine", "Harvest", "Healer", "Heatproof", "Heavy Metal", "Honey Gather", "Hospitality", "Huge Power", "Hunger Switch", "Hustle", "Hydration", "Hyper Cutter", "Ice Body", "Ice Face", "Ice Scales", "Illuminate", "Illusion", "Immunity", "Imposter", "Infiltrator", "Innards Out", "Inner Focus", "Insomnia", "Intimidate", "Intrepid Sword", "Iron Barbs", "Iron Fist", "Justified", "Keen Eye", "Klutz", "Leaf Guard", "Levitate", "Libero", "Light Metal", "Lightning Rod", "Limber", "Lingering Aroma", "Liquid Ooze", "Liquid Voice", "Long Reach", "Magic Bounce", "Magic Guard", "Magician", "Magma Armor", "Magnet Pull", "Marvel Scale", "Mega Launcher", "Merciless", "Mimicry", "Mind's Eye", "Minus", "Mirror Armor", "Misty Surge", "Mold Breaker", "Moody", "Motor Drive", "Moxie", "Multiscale", "Multitype", "Mummy", "Mycelium Might", "Natural Cure", "Neuroforce", "Neutralizing Gas", "No Guard", "Normalize", "Oblivious", "Opportunist", "Orichalcum Pulse", "Overcoat", "Overgrow", "Own Tempo", "Parental Bond", "Pastel Veil", "Perish Body", "Pickpocket", "Pickup", "Pixilate", "Plus", "Poison Heal", "Poison Point", "Poison Touch", "Power Construct", "Power of Alchemy", "Power Spot", "Prankster", "Pressure", "Primordial Sea", "Prism Armor", "Propeller Tail", "Protean", "Protosynthesis", "Psychic Surge", "Punk Rock", "Pure Power", "Purifying Salt", "Quark Drive", "Queenly Majesty", "Quick Draw", "Quick Feet", "Rain Dish", "Rattled", "Receiver", "Reckless", "Refrigerate", "Regenerator", "Ripen", "Rivalry", "RKS System", "Rock Head", "Rocky Payload", "Rough Skin", "Run Away", "Sand Force", "Sand Rush", "Sand Spit", "Sand Stream", "Sand Veil", "Sap Sipper", "Schooling", "Scrappy", "Screen Cleaner", "Seed Sower", "Serene Grace", "Shadow Shield", "Shadow Tag", "Sharpness", "Shed Skin", "Sheer Force", "Shell Armor", "Shield Dust", "Shields Down", "Simple", "Skill Link", "Slow Start", "Slush Rush", "Sniper", "Snow Cloak", "Snow Warning", "Solar Power", "Solid Rock", "Soul-Heart", "Soundproof", "Speed Boost", "Stakeout", "Stall", "Stalwart", "Stamina", "Stance Change", "Static", "Steadfast", "Steam Engine", "Steelworker", "Steely Spirit", "Stench", "Sticky Hold", "Storm Drain", "Strong Jaw", "Sturdy", "Suction Cups", "Super Luck", "Supersweet Syrup", "Supreme Overlord", "Surge Surfer", "Swarm", "Sweet Veil", "Swift Swim", "Sword of Ruin", "Symbiosis", "Synchronize", "Tablets of Ruin", "Tangled Feet", "Tangling Hair", "Technician", "Telepathy", "Teravolt", "Thermal Exchange", "Thick Fat", "Tinted Lens", "Torrent", "Tough Claws", "Toxic Boost", "Toxic Chain", "Toxic Debris", "Trace", "Transistor", "Triage", "Truant", "Turboblaze", "Unaware", "Unburden", "Unnerve", "Unseen Fist", "Vessel of Ruin", "Victory Star", "Vital Spirit", "Volt Absorb", "Wandering Spirit", "Water Absorb", "Water Bubble", "Water Compaction", "Water Veil", "Weak Armor", "Well-Baked Body", "White Smoke", "Wimp Out", "Wind Power", "Wind Rider", "Wonder Guard", "Wonder Skin ", "Zen Mode", "Zero to Hero"})
        pokemon6Ability_cmb.Location = New Point(6, 81)
        pokemon6Ability_cmb.Name = "pokemon6Ability_cmb"
        pokemon6Ability_cmb.Size = New Size(140, 23)
        pokemon6Ability_cmb.TabIndex = 64
        ' 
        ' pokemon6Nature_cmb
        ' 
        pokemon6Nature_cmb.FormattingEnabled = True
        pokemon6Nature_cmb.Items.AddRange(New Object() {"(random)", "HARDY", "LONELY", "BRAVE", "ADAMANT", "NAUGHTY", "BOLD", "DOCILE", "RELAXED", "IMPISH", "LAX", "MODEST", "MILD", "SERIOUS", "QUIET", "RASH", "CALM", "GENTLE", "SASSY", "BASHFUL", "CAREFUL", "TIMID", "HASTY", "JOLLY", "NAIVE", "QUIRKY"})
        pokemon6Nature_cmb.Location = New Point(6, 125)
        pokemon6Nature_cmb.Name = "pokemon6Nature_cmb"
        pokemon6Nature_cmb.Size = New Size(140, 23)
        pokemon6Nature_cmb.TabIndex = 71
        ' 
        ' pokemon6Gender_lbl
        ' 
        pokemon6Gender_lbl.AutoSize = True
        pokemon6Gender_lbl.Location = New Point(152, 63)
        pokemon6Gender_lbl.Name = "pokemon6Gender_lbl"
        pokemon6Gender_lbl.Size = New Size(45, 15)
        pokemon6Gender_lbl.TabIndex = 65
        pokemon6Gender_lbl.Text = "Gender"
        ' 
        ' pokemon6Nature_lbl
        ' 
        pokemon6Nature_lbl.AutoSize = True
        pokemon6Nature_lbl.Location = New Point(6, 107)
        pokemon6Nature_lbl.Name = "pokemon6Nature_lbl"
        pokemon6Nature_lbl.Size = New Size(43, 15)
        pokemon6Nature_lbl.TabIndex = 70
        pokemon6Nature_lbl.Text = "Nature"
        ' 
        ' pokemon6Gender_cmb
        ' 
        pokemon6Gender_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        pokemon6Gender_cmb.FormattingEnabled = True
        pokemon6Gender_cmb.Items.AddRange(New Object() {"Male", "Female", "Random"})
        pokemon6Gender_cmb.Location = New Point(152, 81)
        pokemon6Gender_cmb.Name = "pokemon6Gender_cmb"
        pokemon6Gender_cmb.Size = New Size(140, 23)
        pokemon6Gender_cmb.TabIndex = 66
        ' 
        ' pokemon6Shiny_grp
        ' 
        pokemon6Shiny_grp.Controls.Add(pokemon6SuperShiny_chkBox)
        pokemon6Shiny_grp.Controls.Add(pokemon6Shiny_rad)
        pokemon6Shiny_grp.Controls.Add(pokemon6NotShiny_rad)
        pokemon6Shiny_grp.Location = New Point(444, 110)
        pokemon6Shiny_grp.Name = "pokemon6Shiny_grp"
        pokemon6Shiny_grp.Size = New Size(273, 82)
        pokemon6Shiny_grp.TabIndex = 69
        pokemon6Shiny_grp.TabStop = False
        pokemon6Shiny_grp.Text = "Shiny"
        ' 
        ' pokemon6SuperShiny_chkBox
        ' 
        pokemon6SuperShiny_chkBox.AutoSize = True
        pokemon6SuperShiny_chkBox.Enabled = False
        pokemon6SuperShiny_chkBox.Location = New Point(66, 47)
        pokemon6SuperShiny_chkBox.Name = "pokemon6SuperShiny_chkBox"
        pokemon6SuperShiny_chkBox.Size = New Size(88, 19)
        pokemon6SuperShiny_chkBox.TabIndex = 2
        pokemon6SuperShiny_chkBox.Text = "Super Shiny"
        pokemon6SuperShiny_chkBox.UseVisualStyleBackColor = True
        ' 
        ' pokemon6Shiny_rad
        ' 
        pokemon6Shiny_rad.AutoSize = True
        pokemon6Shiny_rad.Location = New Point(6, 47)
        pokemon6Shiny_rad.Name = "pokemon6Shiny_rad"
        pokemon6Shiny_rad.Size = New Size(54, 19)
        pokemon6Shiny_rad.TabIndex = 1
        pokemon6Shiny_rad.Text = "Shiny"
        pokemon6Shiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon6NotShiny_rad
        ' 
        pokemon6NotShiny_rad.AutoSize = True
        pokemon6NotShiny_rad.Checked = True
        pokemon6NotShiny_rad.Location = New Point(6, 22)
        pokemon6NotShiny_rad.Name = "pokemon6NotShiny_rad"
        pokemon6NotShiny_rad.Size = New Size(77, 19)
        pokemon6NotShiny_rad.TabIndex = 0
        pokemon6NotShiny_rad.TabStop = True
        pokemon6NotShiny_rad.Text = "Not Shiny"
        pokemon6NotShiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon6Form_lbl
        ' 
        pokemon6Form_lbl.AutoSize = True
        pokemon6Form_lbl.Location = New Point(298, 63)
        pokemon6Form_lbl.Name = "pokemon6Form_lbl"
        pokemon6Form_lbl.Size = New Size(35, 15)
        pokemon6Form_lbl.TabIndex = 67
        pokemon6Form_lbl.Text = "Form"
        ' 
        ' pg_about
        ' 
        pg_about.Controls.Add(Label1)
        pg_about.Controls.Add(thirdPartyLicenses_btn)
        pg_about.Controls.Add(licenseText_lbl)
        pg_about.Controls.Add(PictureBox1)
        pg_about.Controls.Add(aboutInfo_lbl)
        pg_about.Controls.Add(copyright_lbl)
        pg_about.Controls.Add(aboutHeaderAuthor_lbl)
        pg_about.Location = New Point(4, 24)
        pg_about.Name = "pg_about"
        pg_about.Size = New Size(743, 509)
        pg_about.TabIndex = 2
        pg_about.Text = "About"
        pg_about.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(513, 354)
        Label1.Name = "Label1"
        Label1.Size = New Size(227, 126)
        Label1.TabIndex = 7
        Label1.Text = resources.GetString("Label1.Text")
        ' 
        ' thirdPartyLicenses_btn
        ' 
        thirdPartyLicenses_btn.Location = New Point(513, 483)
        thirdPartyLicenses_btn.Name = "thirdPartyLicenses_btn"
        thirdPartyLicenses_btn.Size = New Size(227, 23)
        thirdPartyLicenses_btn.TabIndex = 6
        thirdPartyLicenses_btn.Text = "Third-Party Licenses"
        thirdPartyLicenses_btn.UseVisualStyleBackColor = True
        ' 
        ' licenseText_lbl
        ' 
        licenseText_lbl.Location = New Point(3, 159)
        licenseText_lbl.Name = "licenseText_lbl"
        licenseText_lbl.Size = New Size(504, 335)
        licenseText_lbl.TabIndex = 5
        licenseText_lbl.Text = resources.GetString("licenseText_lbl.Text")
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ETB_LOGO_FULL_BLACK
        PictureBox1.Location = New Point(3, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(300, 150)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' aboutInfo_lbl
        ' 
        aboutInfo_lbl.Location = New Point(309, 41)
        aboutInfo_lbl.Name = "aboutInfo_lbl"
        aboutInfo_lbl.Size = New Size(431, 80)
        aboutInfo_lbl.TabIndex = 3
        aboutInfo_lbl.Text = resources.GetString("aboutInfo_lbl.Text")
        ' 
        ' copyright_lbl
        ' 
        copyright_lbl.AutoSize = True
        copyright_lbl.Location = New Point(3, 494)
        copyright_lbl.Name = "copyright_lbl"
        copyright_lbl.Size = New Size(60, 15)
        copyright_lbl.TabIndex = 2
        copyright_lbl.Text = "Copyright"
        ' 
        ' aboutHeaderAuthor_lbl
        ' 
        aboutHeaderAuthor_lbl.AutoSize = True
        aboutHeaderAuthor_lbl.Font = New Font("Segoe UI", 15.75F)
        aboutHeaderAuthor_lbl.Location = New Point(309, 6)
        aboutHeaderAuthor_lbl.Name = "aboutHeaderAuthor_lbl"
        aboutHeaderAuthor_lbl.Size = New Size(180, 30)
        aboutHeaderAuthor_lbl.TabIndex = 1
        aboutHeaderAuthor_lbl.Text = "By TheCrafters001"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {GeneratePreviewToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(779, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' GeneratePreviewToolStripMenuItem
        ' 
        GeneratePreviewToolStripMenuItem.Name = "GeneratePreviewToolStripMenuItem"
        GeneratePreviewToolStripMenuItem.Size = New Size(112, 20)
        GeneratePreviewToolStripMenuItem.Text = "Generate/Preview"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(779, 595)
        Controls.Add(editor_grp)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Essentials Team Editor"
        editor_grp.ResumeLayout(False)
        editor_tab.ResumeLayout(False)
        pg_trainer.ResumeLayout(False)
        trainer_tab.ResumeLayout(False)
        pg_basic.ResumeLayout(False)
        pg_basic.PerformLayout()
        CType(battleTeamID_nbr, ComponentModel.ISupportInitialize).EndInit()
        pg_items.ResumeLayout(False)
        pg_items.PerformLayout()
        items_grp.ResumeLayout(False)
        pg_pokemon.ResumeLayout(False)
        pkmnTabs_tab.ResumeLayout(False)
        pg_pkmn1.ResumeLayout(False)
        pokemon1_grp.ResumeLayout(False)
        pokemon1_grp.PerformLayout()
        CType(pokemon1Level_nbr, ComponentModel.ISupportInitialize).EndInit()
        CType(pokemon1Form_nbr, ComponentModel.ISupportInitialize).EndInit()
        CType(pokemon1Happiness_nbr, ComponentModel.ISupportInitialize).EndInit()
        pokemon1Shadow_grp.ResumeLayout(False)
        pokemon1Shadow_grp.PerformLayout()
        pokemon1EVs_grp.ResumeLayout(False)
        pokemon1EVs_grp.PerformLayout()
        pokemon1IVs_grp.ResumeLayout(False)
        pokemon1IVs_grp.PerformLayout()
        pokemon1Shiny_grp.ResumeLayout(False)
        pokemon1Shiny_grp.PerformLayout()
        pokemon1Moves_grp.ResumeLayout(False)
        pokemon1Moves_grp.PerformLayout()
        pg_pkmn2.ResumeLayout(False)
        pokemon2_grp.ResumeLayout(False)
        pokemon2_grp.PerformLayout()
        CType(pokemon2Level_nbr, ComponentModel.ISupportInitialize).EndInit()
        CType(pokemon2Form_nbr, ComponentModel.ISupportInitialize).EndInit()
        CType(pokemon2Happiness_nbr, ComponentModel.ISupportInitialize).EndInit()
        pokemon2Shadow_grp.ResumeLayout(False)
        pokemon2Shadow_grp.PerformLayout()
        pokemon2EVs_grp.ResumeLayout(False)
        pokemon2EVs_grp.PerformLayout()
        pokemon2IVs_grp.ResumeLayout(False)
        pokemon2IVs_grp.PerformLayout()
        pokemon2Moves_grp.ResumeLayout(False)
        pokemon2Moves_grp.PerformLayout()
        pokemon2Shiny_grp.ResumeLayout(False)
        pokemon2Shiny_grp.PerformLayout()
        pg_pkmn3.ResumeLayout(False)
        pokemon3_grp.ResumeLayout(False)
        pokemon3_grp.PerformLayout()
        CType(pokemon3Level_nbr, ComponentModel.ISupportInitialize).EndInit()
        CType(pokemon3Form_nbr, ComponentModel.ISupportInitialize).EndInit()
        CType(pokemon3Happiness_nbr, ComponentModel.ISupportInitialize).EndInit()
        pokemon3Shadow_grp.ResumeLayout(False)
        pokemon3Shadow_grp.PerformLayout()
        pokemon3EVs_grp.ResumeLayout(False)
        pokemon3EVs_grp.PerformLayout()
        pokemon3IVs_grp.ResumeLayout(False)
        pokemon3IVs_grp.PerformLayout()
        pokemon3Moves_grp.ResumeLayout(False)
        pokemon3Moves_grp.PerformLayout()
        pokemon3Shiny_grp.ResumeLayout(False)
        pokemon3Shiny_grp.PerformLayout()
        pg_pkmn4.ResumeLayout(False)
        pokemon4_grp.ResumeLayout(False)
        pokemon4_grp.PerformLayout()
        CType(pokemon4Level_nbr, ComponentModel.ISupportInitialize).EndInit()
        CType(pokemon4Form_nbr, ComponentModel.ISupportInitialize).EndInit()
        CType(pokemon4Happiness_nbr, ComponentModel.ISupportInitialize).EndInit()
        pokemon4Shadow_grp.ResumeLayout(False)
        pokemon4Shadow_grp.PerformLayout()
        pokemon4EVs_grp.ResumeLayout(False)
        pokemon4EVs_grp.PerformLayout()
        pokemon4IVs_grp.ResumeLayout(False)
        pokemon4IVs_grp.PerformLayout()
        pokemon4Moves_grp.ResumeLayout(False)
        pokemon4Moves_grp.PerformLayout()
        pokemon4Shiny_grp.ResumeLayout(False)
        pokemon4Shiny_grp.PerformLayout()
        pg_pkmn5.ResumeLayout(False)
        pokemon5_grp.ResumeLayout(False)
        pokemon5_grp.PerformLayout()
        CType(pokemon5Level_nbr, ComponentModel.ISupportInitialize).EndInit()
        CType(pokemon5Form_nbr, ComponentModel.ISupportInitialize).EndInit()
        CType(pokemon5Happiness_nbr, ComponentModel.ISupportInitialize).EndInit()
        pokemon5Shadow_grp.ResumeLayout(False)
        pokemon5Shadow_grp.PerformLayout()
        pokemon5EVs_grp.ResumeLayout(False)
        pokemon5EVs_grp.PerformLayout()
        pokemon5IVs_grp.ResumeLayout(False)
        pokemon5IVs_grp.PerformLayout()
        pokemon5Moves_grp.ResumeLayout(False)
        pokemon5Moves_grp.PerformLayout()
        pokemon5Shiny_grp.ResumeLayout(False)
        pokemon5Shiny_grp.PerformLayout()
        pg_pkmn6.ResumeLayout(False)
        pokemon6_grp.ResumeLayout(False)
        pokemon6_grp.PerformLayout()
        CType(pokemon6Level_nbr, ComponentModel.ISupportInitialize).EndInit()
        CType(pokemon6Form_nbr, ComponentModel.ISupportInitialize).EndInit()
        CType(pokemon6Happiness_nbr, ComponentModel.ISupportInitialize).EndInit()
        pokemon6Shadow_grp.ResumeLayout(False)
        pokemon6Shadow_grp.PerformLayout()
        pokemon6EVs_grp.ResumeLayout(False)
        pokemon6EVs_grp.PerformLayout()
        pokemon6IVs_grp.ResumeLayout(False)
        pokemon6IVs_grp.PerformLayout()
        pokemon6Moves_grp.ResumeLayout(False)
        pokemon6Moves_grp.PerformLayout()
        pokemon6Shiny_grp.ResumeLayout(False)
        pokemon6Shiny_grp.PerformLayout()
        pg_about.ResumeLayout(False)
        pg_about.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents editor_grp As GroupBox
    Friend WithEvents editor_tab As TabControl
    Friend WithEvents pg_trainer As TabPage
    Friend WithEvents trainer_tab As TabControl
    Friend WithEvents pg_items As TabPage
    Friend WithEvents pg_pokemon As TabPage
    Friend WithEvents pkmnTabs_tab As TabControl
    Friend WithEvents pg_pkmn5 As TabPage
    Friend WithEvents pg_pkmn6 As TabPage
    Friend WithEvents pg_basic As TabPage
    Friend WithEvents pg_pkmn1 As TabPage
    Friend WithEvents pg_pkmn2 As TabPage
    Friend WithEvents pg_pkmn3 As TabPage
    Friend WithEvents pg_pkmn4 As TabPage
    Friend WithEvents trainerInfoHeader_lbl As Label
    Friend WithEvents trainerName_lbl As Label
    Friend WithEvents trainerName_txtBox As TextBox
    Friend WithEvents trainerType_txtBox As TextBox
    Friend WithEvents trainerType_lbl As Label
    Friend WithEvents loseText_lbl As Label
    Friend WithEvents loseText_txt As TextBox
    Friend WithEvents battleTeamID_lbl As Label
    Friend WithEvents numPoké_lbl As Label
    Friend WithEvents numPoké_cmb As ComboBox
    Friend WithEvents essVersion_cmb As ComboBox
    Friend WithEvents essVersion_lbl As Label
    Friend WithEvents essData_lbl As Label
    Friend WithEvents allowSuperShiny_chk As CheckBox
    Friend WithEvents loseTextQuotes_chkBox As CheckBox
    Friend WithEvents useAbilityIndex_chkBox As CheckBox
    Friend WithEvents existingBattle_chkBox As CheckBox
    Friend WithEvents customBallIDs_chkBox As CheckBox
    Friend WithEvents pokemon2_grp As GroupBox
    Friend WithEvents pokemon3_grp As GroupBox
    Friend WithEvents pokemon4_grp As GroupBox
    Friend WithEvents pokemon5_grp As GroupBox
    Friend WithEvents pokemon1_grp As GroupBox
    Friend WithEvents pokemon6_grp As GroupBox
    Friend WithEvents pokemon1Name_lbl As Label
    Friend WithEvents pokemon1Name_txtBox As TextBox
    Friend WithEvents pokemon1HeldItem_lbl As Label
    Friend WithEvents pokemon1HeldItem_txtBox As TextBox
    Friend WithEvents pokemon1Level_lbl As Label
    Friend WithEvents pokemon1Moves_grp As GroupBox
    Friend WithEvents pokemon1Move4_txtBox As TextBox
    Friend WithEvents pokemon1Move3_txtBox As TextBox
    Friend WithEvents pokemon1Move2_txtBox As TextBox
    Friend WithEvents pokemon1Move1_txtBox As TextBox
    Friend WithEvents pokemon1Ability_cmb As ComboBox
    Friend WithEvents pokemon1Ability_lbl As Label
    Friend WithEvents pokemon1Gender_cmb As ComboBox
    Friend WithEvents pokemon1Gender_lbl As Label
    Friend WithEvents pokemon1Form_lbl As Label
    Friend WithEvents pokemon1Shiny_grp As GroupBox
    Friend WithEvents pokemon1SuperShiny_chkBox As CheckBox
    Friend WithEvents pokemon1Shiny_rad As RadioButton
    Friend WithEvents pokemon1NotShiny_rad As RadioButton
    Friend WithEvents pokemon1Nature_lbl As Label
    Friend WithEvents pokemon1Nature_cmb As ComboBox
    Friend WithEvents pokemon1Happiness_lbl As Label
    Friend WithEvents pokemon1Nickname_txtBox As TextBox
    Friend WithEvents pokemon1Nickname_lbl As Label
    Friend WithEvents pokemon1Ball_lbl As Label
    Friend WithEvents pokemon1PokeballID_cmb As ComboBox
    Friend WithEvents pokemon1IVs_grp As GroupBox
    Friend WithEvents pokemon1RandomIVs_btn As Button
    Friend WithEvents pokemon1MaxIVs_btn As Button
    Friend WithEvents pokemon1IVsDEF_txt As TextBox
    Friend WithEvents pokemon1IVsDEF_lbl As Label
    Friend WithEvents pokemon1IVsSPDEF_txt As TextBox
    Friend WithEvents pokemon1IVsSPDEF_lbl As Label
    Friend WithEvents pokemon1IVsSPATK_txt As TextBox
    Friend WithEvents pokemon1IVsSPATK_lbl As Label
    Friend WithEvents pokemon1IVsSPD_txt As TextBox
    Friend WithEvents pokemon1IVsSPD_lbl As Label
    Friend WithEvents pokemon1IVsATK_txt As TextBox
    Friend WithEvents pokemon1IVsATK_lbl As Label
    Friend WithEvents pokemon1IVsHP_txt As TextBox
    Friend WithEvents pokemon1IVsHP_lbl As Label
    Friend WithEvents pokemon1EVs_grp As GroupBox
    Friend WithEvents pokemon1EVsDEF_txt As TextBox
    Friend WithEvents pokemon1EVsDEF_lbl As Label
    Friend WithEvents pokemon1EVsSPDEF_txt As TextBox
    Friend WithEvents pokemon1EVsSPDEF_lbl As Label
    Friend WithEvents pokemon1EVsSPATK_txt As TextBox
    Friend WithEvents pokemon1EVsSPATK_lbl As Label
    Friend WithEvents pokemon1EVsSPD_txt As TextBox
    Friend WithEvents pokemon1EVsSPD_lbl As Label
    Friend WithEvents pokemon1EVsATK_txt As TextBox
    Friend WithEvents pokemon1EVsATK_lbl As Label
    Friend WithEvents pokemon1EVsHP_txt As TextBox
    Friend WithEvents pokemon1EVsHP_lbl As Label
    Friend WithEvents pg_about As TabPage
    Friend WithEvents copyright_lbl As Label
    Friend WithEvents aboutHeaderAuthor_lbl As Label
    Friend WithEvents aboutInfo_lbl As Label
    Friend WithEvents pokemon1Shadow_grp As GroupBox
    Friend WithEvents pokemon1Shadow_rad As RadioButton
    Friend WithEvents pokemon1NotShadow_rad As RadioButton
    Friend WithEvents pokemon2Shadow_grp As GroupBox
    Friend WithEvents pokemon2Shadow_rad As RadioButton
    Friend WithEvents pokemon2NotShadow_rad As RadioButton
    Friend WithEvents pokemon2Name_lbl As Label
    Friend WithEvents pokemon2EVs_grp As GroupBox
    Friend WithEvents pokemon2EVsDEF_txt As TextBox
    Friend WithEvents pokemon2EVsDEF_lbl As Label
    Friend WithEvents pokemon2EVsSPDEF_txt As TextBox
    Friend WithEvents pokemon2EVsSPDEF_lbl As Label
    Friend WithEvents pokemon2EVsSPATK_txt As TextBox
    Friend WithEvents pokemon2EVsSPATK_lbl As Label
    Friend WithEvents pokemon2EVsSPD_txt As TextBox
    Friend WithEvents pokemon2EVsSPD_lbl As Label
    Friend WithEvents pokemon2EVsATK_txt As TextBox
    Friend WithEvents pokemon2EVsATK_lbl As Label
    Friend WithEvents pokemon2EVsHP_txt As TextBox
    Friend WithEvents pokemon2EVsHP_lbl As Label
    Friend WithEvents pokemon2Name_txt As TextBox
    Friend WithEvents pokemon2IVs_grp As GroupBox
    Friend WithEvents pokemon2RandomIVs_btn As Button
    Friend WithEvents pokemon2MaxIVs_btn As Button
    Friend WithEvents pokemon2IVsDEF_txt As TextBox
    Friend WithEvents pokemon2IVsDEF_lbl As Label
    Friend WithEvents pokemon2IVsSPDEF_txt As TextBox
    Friend WithEvents pokemon2IVsSPDEF_lbl As Label
    Friend WithEvents pokemon2IVsSPATK_txt As TextBox
    Friend WithEvents pokemon2IVsSPATK_lbl As Label
    Friend WithEvents pokemon2IVsSPD_txt As TextBox
    Friend WithEvents pokemon2IVsSPD_lbl As Label
    Friend WithEvents pokemon2IVsATK_txt As TextBox
    Friend WithEvents pokemon2IVsATK_lbl As Label
    Friend WithEvents pokemon2IVsHP_txt As TextBox
    Friend WithEvents pokemon2IVsHP_lbl As Label
    Friend WithEvents pokemon2HeldItem_txt As TextBox
    Friend WithEvents pokemon2PokeballID_cmb As ComboBox
    Friend WithEvents pokemon2HeldItem_lbl As Label
    Friend WithEvents pokemon2PokeBall_lbl As Label
    Friend WithEvents pokemon2Level_lbl As Label
    Friend WithEvents pokemon2Nickname_txt As TextBox
    Friend WithEvents pokemon2Nickname_lbl As Label
    Friend WithEvents pokemon2Moves_grp As GroupBox
    Friend WithEvents pokemon2Move4_txtBox As TextBox
    Friend WithEvents pokemon2Move3_txtBox As TextBox
    Friend WithEvents pokemon2Move2_txtBox As TextBox
    Friend WithEvents pokemon2Move1_txtBox As TextBox
    Friend WithEvents pokemon2Ability_lbl As Label
    Friend WithEvents pokemon2Happiness_lbl As Label
    Friend WithEvents pokemon2Ability_cmb As ComboBox
    Friend WithEvents pokemon2Nature_cmb As ComboBox
    Friend WithEvents pokemon2Gender_lbl As Label
    Friend WithEvents pokemon2Nature_lbl As Label
    Friend WithEvents pokemon2Gender_cmb As ComboBox
    Friend WithEvents pokemon2Shiny_grp As GroupBox
    Friend WithEvents pokemon2SuperShiny_chkBox As CheckBox
    Friend WithEvents pokemon2Shiny_rad As RadioButton
    Friend WithEvents pokemon2NotShiny_rad As RadioButton
    Friend WithEvents pokemon2Form_lbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents properSpellingNote_lbl As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GeneratePreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pokemon3Shadow_grp As GroupBox
    Friend WithEvents pokemon3Shadow_rad As RadioButton
    Friend WithEvents pokemon3NotShadow_rad As RadioButton
    Friend WithEvents pokemon3Name_lbl As Label
    Friend WithEvents pokemon3EVs_grp As GroupBox
    Friend WithEvents pokemon3EVsDEF_txt As TextBox
    Friend WithEvents pokemon3EVsDEF_lbl As Label
    Friend WithEvents pokemon3EVsSPDEF_txt As TextBox
    Friend WithEvents pokemon3EVsSPDEF_lbl As Label
    Friend WithEvents pokemon3EVsSPATK_txt As TextBox
    Friend WithEvents pokemon3EVsSPATK_lbl As Label
    Friend WithEvents pokemon3EVsSPD_txt As TextBox
    Friend WithEvents pokemon3EVsSPD_lbl As Label
    Friend WithEvents pokemon3EVsATK_txt As TextBox
    Friend WithEvents pokemon3EVsATK_lbl As Label
    Friend WithEvents pokemon3EVsHP_txt As TextBox
    Friend WithEvents pokemon3EVsHP_lbl As Label
    Friend WithEvents pokemon3Name_txt As TextBox
    Friend WithEvents pokemon3IVs_grp As GroupBox
    Friend WithEvents pokemon3RandomIVs_btn As Button
    Friend WithEvents pokemon3MaxIVs_btn As Button
    Friend WithEvents pokemon3IVsDEF_txt As TextBox
    Friend WithEvents pokemon3IVsDEF_lbl As Label
    Friend WithEvents pokemon3IVsSPDEF_txt As TextBox
    Friend WithEvents pokemon3IVsSPDEF_lbl As Label
    Friend WithEvents pokemon3IVsSPATK_txt As TextBox
    Friend WithEvents pokemon3IVsSPATK_lbl As Label
    Friend WithEvents pokemon3IVsSPD_txt As TextBox
    Friend WithEvents pokemon3IVsSPD_lbl As Label
    Friend WithEvents pokemon3IVsATK_txt As TextBox
    Friend WithEvents pokemon3IVsATK_lbl As Label
    Friend WithEvents pokemon3IVsHP_txt As TextBox
    Friend WithEvents pokemon3IVsHP_lbl As Label
    Friend WithEvents pokemon3HeldItem_txt As TextBox
    Friend WithEvents pokemon3PokeballID_cmb As ComboBox
    Friend WithEvents pokemon3HeldItem_lbl As Label
    Friend WithEvents pokemon3PokeBall_lbl As Label
    Friend WithEvents pokemon3Level_lbl As Label
    Friend WithEvents pokemon3Nickname_txt As TextBox
    Friend WithEvents pokemon3Nickname_lbl As Label
    Friend WithEvents pokemon3Moves_grp As GroupBox
    Friend WithEvents pokemon3Move4_txtBox As TextBox
    Friend WithEvents pokemon3Move3_txtBox As TextBox
    Friend WithEvents pokemon3Move2_txtBox As TextBox
    Friend WithEvents pokemon3Move1_txtBox As TextBox
    Friend WithEvents pokemon3Ability_lbl As Label
    Friend WithEvents pokemon3Happiness_lbl As Label
    Friend WithEvents pokemon3Ability_cmb As ComboBox
    Friend WithEvents pokemon3Nature_cmb As ComboBox
    Friend WithEvents pokemon3Gender_lbl As Label
    Friend WithEvents pokemon3Nature_lbl As Label
    Friend WithEvents pokemon3Gender_cmb As ComboBox
    Friend WithEvents pokemon3Shiny_grp As GroupBox
    Friend WithEvents pokemon3SuperShiny_chkBox As CheckBox
    Friend WithEvents pokemon3Shiny_rad As RadioButton
    Friend WithEvents pokemon3NotShiny_rad As RadioButton
    Friend WithEvents pokemon3Form_lbl As Label
    Friend WithEvents pokemon4Shadow_grp As GroupBox
    Friend WithEvents pokemon4Shadow_rad As RadioButton
    Friend WithEvents pokemon4NotShadow_rad As RadioButton
    Friend WithEvents pokemon4Name_lbl As Label
    Friend WithEvents pokemon4EVs_grp As GroupBox
    Friend WithEvents pokemon4EVsDEF_txt As TextBox
    Friend WithEvents pokemon4EVsDEF_lbl As Label
    Friend WithEvents pokemon4EVsSPDEF_txt As TextBox
    Friend WithEvents pokemon4EVsSPDEF_lbl As Label
    Friend WithEvents pokemon4EVsSPATK_txt As TextBox
    Friend WithEvents pokemon4EVsSPATK_lbl As Label
    Friend WithEvents pokemon4EVsSPD_txt As TextBox
    Friend WithEvents pokemon4EVsSPD_lbl As Label
    Friend WithEvents pokemon4EVsATK_txt As TextBox
    Friend WithEvents pokemon4EVsATK_lbl As Label
    Friend WithEvents pokemon4EVsHP_txt As TextBox
    Friend WithEvents pokemon4EVsHP_lbl As Label
    Friend WithEvents pokemon4Name_txt As TextBox
    Friend WithEvents pokemon4IVs_grp As GroupBox
    Friend WithEvents pokemon4RandomIVs_btn As Button
    Friend WithEvents pokemon4MaxIVs_btn As Button
    Friend WithEvents pokemon4IVsDEF_txt As TextBox
    Friend WithEvents pokemon4IVsDEF_lbl As Label
    Friend WithEvents pokemon4IVsSPDEF_txt As TextBox
    Friend WithEvents pokemon4IVsSPDEF_lbl As Label
    Friend WithEvents pokemon4IVsSPATK_txt As TextBox
    Friend WithEvents pokemon4IVsSPATK_lbl As Label
    Friend WithEvents pokemon4IVsSPD_txt As TextBox
    Friend WithEvents pokemon4IVsSPD_lbl As Label
    Friend WithEvents pokemon4IVsATK_txt As TextBox
    Friend WithEvents pokemon4IVsATK_lbl As Label
    Friend WithEvents pokemon4IVsHP_txt As TextBox
    Friend WithEvents pokemon4IVsHP_lbl As Label
    Friend WithEvents pokemon4HeldItem_txt As TextBox
    Friend WithEvents pokemon4PokeballID_cmb As ComboBox
    Friend WithEvents pokemon4HeldItem_lbl As Label
    Friend WithEvents pokemon4PokeBall_lbl As Label
    Friend WithEvents pokemon4Level_lbl As Label
    Friend WithEvents pokemon4Nickname_txt As TextBox
    Friend WithEvents pokemon4Nickname_lbl As Label
    Friend WithEvents pokemon4Moves_grp As GroupBox
    Friend WithEvents pokemon4Move4_txtBox As TextBox
    Friend WithEvents pokemon4Move3_txtBox As TextBox
    Friend WithEvents pokemon4Move2_txtBox As TextBox
    Friend WithEvents pokemon4Move1_txtBox As TextBox
    Friend WithEvents pokemon4Ability_lbl As Label
    Friend WithEvents pokemon4Happiness_lbl As Label
    Friend WithEvents pokemon4Ability_cmb As ComboBox
    Friend WithEvents pokemon4Nature_cmb As ComboBox
    Friend WithEvents pokemon4Gender_lbl As Label
    Friend WithEvents pokemon4Nature_lbl As Label
    Friend WithEvents pokemon4Gender_cmb As ComboBox
    Friend WithEvents pokemon4Shiny_grp As GroupBox
    Friend WithEvents pokemon4SuperShiny_chkBox As CheckBox
    Friend WithEvents pokemon4Shiny_rad As RadioButton
    Friend WithEvents pokemon4NotShiny_rad As RadioButton
    Friend WithEvents pokemon4Form_lbl As Label
    Friend WithEvents pokemon5Shadow_grp As GroupBox
    Friend WithEvents pokemon5Shadow_rad As RadioButton
    Friend WithEvents pokemon5NotShadow_rad As RadioButton
    Friend WithEvents pokemon5Name_lbl As Label
    Friend WithEvents pokemon5EVs_grp As GroupBox
    Friend WithEvents pokemon5EVsDEF_txt As TextBox
    Friend WithEvents pokemon5EVsDEF_lbl As Label
    Friend WithEvents pokemon5EVsSPDEF_txt As TextBox
    Friend WithEvents pokemon5EVsSPDEF_lbl As Label
    Friend WithEvents pokemon5EVsSPATK_txt As TextBox
    Friend WithEvents pokemon5EVsSPATK_lbl As Label
    Friend WithEvents pokemon5EVsSPD_txt As TextBox
    Friend WithEvents pokemon5EVsSPD_lbl As Label
    Friend WithEvents pokemon5EVsATK_txt As TextBox
    Friend WithEvents pokemon5EVsATK_lbl As Label
    Friend WithEvents pokemon5EVsHP_txt As TextBox
    Friend WithEvents pokemon5EVsHP_lbl As Label
    Friend WithEvents pokemon5Name_txt As TextBox
    Friend WithEvents pokemon5IVs_grp As GroupBox
    Friend WithEvents pokemon5RandomIVs_btn As Button
    Friend WithEvents pokemon5MaxIVs_btn As Button
    Friend WithEvents pokemon5IVsDEF_txt As TextBox
    Friend WithEvents pokemon5IVsDEF_lbl As Label
    Friend WithEvents pokemon5IVsSPDEF_txt As TextBox
    Friend WithEvents pokemon5IVsSPDEF_lbl As Label
    Friend WithEvents pokemon5IVsSPATK_txt As TextBox
    Friend WithEvents pokemon5IVsSPATK_lbl As Label
    Friend WithEvents pokemon5IVsSPD_txt As TextBox
    Friend WithEvents pokemon5IVsSPD_lbl As Label
    Friend WithEvents pokemon5IVsATK_txt As TextBox
    Friend WithEvents pokemon5IVsATK_lbl As Label
    Friend WithEvents pokemon5IVsHP_txt As TextBox
    Friend WithEvents pokemon5IVsHP_lbl As Label
    Friend WithEvents pokemon5HeldItem_txt As TextBox
    Friend WithEvents pokemon5PokeballID_cmb As ComboBox
    Friend WithEvents pokemon5HeldItem_lbl As Label
    Friend WithEvents pokemon5PokeBall_lbl As Label
    Friend WithEvents pokemon5Level_lbl As Label
    Friend WithEvents pokemon5Nickname_txt As TextBox
    Friend WithEvents pokemon5Nickname_lbl As Label
    Friend WithEvents pokemon5Moves_grp As GroupBox
    Friend WithEvents pokemon5Move4_txt As TextBox
    Friend WithEvents pokemon5Move3_txt As TextBox
    Friend WithEvents pokemon5Move2_txt As TextBox
    Friend WithEvents pokemon5Move1_txt As TextBox
    Friend WithEvents pokemon5Ability_lbl As Label
    Friend WithEvents pokemon5Happiness_lbl As Label
    Friend WithEvents pokemon5Ability_cmb As ComboBox
    Friend WithEvents pokemon5Nature_cmb As ComboBox
    Friend WithEvents pokemon5Gender_lbl As Label
    Friend WithEvents pokemon5Nature_lbl As Label
    Friend WithEvents pokemon5Gender_cmb As ComboBox
    Friend WithEvents pokemon5Shiny_grp As GroupBox
    Friend WithEvents pokemon5SuperShiny_chkBox As CheckBox
    Friend WithEvents pokemon5Shiny_rad As RadioButton
    Friend WithEvents pokemon5NotShiny_rad As RadioButton
    Friend WithEvents pokemon5Form_lbl As Label
    Friend WithEvents pokemon6Shadow_grp As GroupBox
    Friend WithEvents pokemon6Shadow_rad As RadioButton
    Friend WithEvents pokemon6NotShadow_rad As RadioButton
    Friend WithEvents pokemon6Name_lbl As Label
    Friend WithEvents pokemon6EVs_grp As GroupBox
    Friend WithEvents pokemon6EVsDEF_txt As TextBox
    Friend WithEvents pokemon6EVsDEF_lbl As Label
    Friend WithEvents pokemon6EVsSPDEF_txt As TextBox
    Friend WithEvents pokemon6EVsSPDEF_lbl As Label
    Friend WithEvents pokemon6EVsSPATK_txt As TextBox
    Friend WithEvents pokemon6EVsSPATK_lbl As Label
    Friend WithEvents pokemon6EVsSPD_txt As TextBox
    Friend WithEvents pokemon6EVsSPD_lbl As Label
    Friend WithEvents pokemon6EVsATK_txt As TextBox
    Friend WithEvents pokemon6EVsATK_lbl As Label
    Friend WithEvents pokemon6EVsHP_txt As TextBox
    Friend WithEvents pokemon6EVsHP_lbl As Label
    Friend WithEvents pokemon6Name_txt As TextBox
    Friend WithEvents pokemon6IVs_grp As GroupBox
    Friend WithEvents pokemon6RandomIVs_btn As Button
    Friend WithEvents pokemon6MaxIVs_btn As Button
    Friend WithEvents pokemon6IVsDEF_txt As TextBox
    Friend WithEvents pokemon6IVsDEF_lbl As Label
    Friend WithEvents pokemon6IVsSPDEF_txt As TextBox
    Friend WithEvents pokemon6IVsSPDEF_lbl As Label
    Friend WithEvents pokemon6IVsSPATK_txt As TextBox
    Friend WithEvents pokemon6IVsSPATK_lbl As Label
    Friend WithEvents pokemon6IVsSPD_txt As TextBox
    Friend WithEvents pokemon6IVsSPD_lbl As Label
    Friend WithEvents pokemon6IVsATK_txt As TextBox
    Friend WithEvents pokemon6IVsATK_lbl As Label
    Friend WithEvents pokemon6IVsHP_txt As TextBox
    Friend WithEvents pokemon6IVsHP_lbl As Label
    Friend WithEvents pokemon6HeldItem_txt As TextBox
    Friend WithEvents pokemon6PokeballID_cmb As ComboBox
    Friend WithEvents pokemon6HeldItem_lbl As Label
    Friend WithEvents pokemon6Pokeball_lbl As Label
    Friend WithEvents pokemon6Level_lbl As Label
    Friend WithEvents pokemon6Nickname_txt As TextBox
    Friend WithEvents pokemon6Nickname_lbl As Label
    Friend WithEvents pokemon6Moves_grp As GroupBox
    Friend WithEvents pokemon6Move4_txt As TextBox
    Friend WithEvents pokemon6Move3_txt As TextBox
    Friend WithEvents pokemon6Move2_txt As TextBox
    Friend WithEvents pokemon6Move1_txt As TextBox
    Friend WithEvents pokemon6Ability_lbl As Label
    Friend WithEvents pokemon6Happiness_lbl As Label
    Friend WithEvents pokemon6Ability_cmb As ComboBox
    Friend WithEvents pokemon6Nature_cmb As ComboBox
    Friend WithEvents pokemon6Gender_lbl As Label
    Friend WithEvents pokemon6Nature_lbl As Label
    Friend WithEvents pokemon6Gender_cmb As ComboBox
    Friend WithEvents pokemon6Shiny_grp As GroupBox
    Friend WithEvents pokemon6SuperShiny_chkBox As CheckBox
    Friend WithEvents pokemon6Shiny_rad As RadioButton
    Friend WithEvents pokemon6NotShiny_rad As RadioButton
    Friend WithEvents pokemon6Form_lbl As Label
    Friend WithEvents pokemon1Level_nbr As NumericUpDown
    Friend WithEvents pokemon1Form_nbr As NumericUpDown
    Friend WithEvents pokemon1Happiness_nbr As NumericUpDown
    Friend WithEvents pokemon2Level_nbr As NumericUpDown
    Friend WithEvents pokemon2Form_nbr As NumericUpDown
    Friend WithEvents pokemon2Happiness_nbr As NumericUpDown
    Friend WithEvents pokemon3Level_nbr As NumericUpDown
    Friend WithEvents pokemon3Form_nbr As NumericUpDown
    Friend WithEvents pokemon3Happiness_nbr As NumericUpDown
    Friend WithEvents pokemon4Level_nbr As NumericUpDown
    Friend WithEvents pokemon4Form_nbr As NumericUpDown
    Friend WithEvents pokemon4Happiness_nbr As NumericUpDown
    Friend WithEvents pokemon5Level_nbr As NumericUpDown
    Friend WithEvents pokemon5Form_nbr As NumericUpDown
    Friend WithEvents pokemon5Happiness_nbr As NumericUpDown
    Friend WithEvents pokemon6Level_nbr As NumericUpDown
    Friend WithEvents pokemon6Form_nbr As NumericUpDown
    Friend WithEvents pokemon6Happiness_nbr As NumericUpDown
    Friend WithEvents battleTeamID_nbr As NumericUpDown
    Friend WithEvents items_grp As GroupBox
    Friend WithEvents items_lst As ListBox
    Friend WithEvents trainerItemsHeader_lbl As Label
    Friend WithEvents trainerItemsInfo_lbl As Label
    Friend WithEvents removeItem_btn As Button
    Friend WithEvents addItem_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents itemAddEther_btn As Button
    Friend WithEvents itemAddFullRestore_btn As Button
    Friend WithEvents itemAddHyperPotion_btn As Button
    Friend WithEvents itemAddMaxPotion_btn As Button
    Friend WithEvents itemAddSuperPotion_btn As Button
    Friend WithEvents itemAddPotion_btn As Button
    Friend WithEvents itemAddMaxElixir_btn As Button
    Friend WithEvents itemAddElixir_btn As Button
    Friend WithEvents itemAddMaxEther_btn As Button
    Friend WithEvents licenseText_lbl As Label
    Friend WithEvents thirdPartyLicenses_btn As Button
    Friend WithEvents Label1 As Label
End Class
