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
        IVStatsNoteHeader_lbl = New Label()
        IVStatsNote_lbl = New Label()
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
        Button1 = New Button()
        lang_cmb = New ComboBox()
        lang_lbl = New Label()
        Label1 = New Label()
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
        resources.ApplyResources(editor_grp, "editor_grp")
        editor_grp.Name = "editor_grp"
        editor_grp.TabStop = False
        ' 
        ' editor_tab
        ' 
        editor_tab.Controls.Add(pg_trainer)
        editor_tab.Controls.Add(pg_pokemon)
        editor_tab.Controls.Add(pg_about)
        resources.ApplyResources(editor_tab, "editor_tab")
        editor_tab.Name = "editor_tab"
        editor_tab.SelectedIndex = 0
        ' 
        ' pg_trainer
        ' 
        pg_trainer.Controls.Add(trainer_tab)
        resources.ApplyResources(pg_trainer, "pg_trainer")
        pg_trainer.Name = "pg_trainer"
        pg_trainer.UseVisualStyleBackColor = True
        ' 
        ' trainer_tab
        ' 
        trainer_tab.Controls.Add(pg_basic)
        trainer_tab.Controls.Add(pg_items)
        resources.ApplyResources(trainer_tab, "trainer_tab")
        trainer_tab.Name = "trainer_tab"
        trainer_tab.SelectedIndex = 0
        ' 
        ' pg_basic
        ' 
        pg_basic.Controls.Add(IVStatsNoteHeader_lbl)
        pg_basic.Controls.Add(IVStatsNote_lbl)
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
        resources.ApplyResources(pg_basic, "pg_basic")
        pg_basic.Name = "pg_basic"
        pg_basic.UseVisualStyleBackColor = True
        ' 
        ' IVStatsNoteHeader_lbl
        ' 
        resources.ApplyResources(IVStatsNoteHeader_lbl, "IVStatsNoteHeader_lbl")
        IVStatsNoteHeader_lbl.ForeColor = Color.Red
        IVStatsNoteHeader_lbl.Name = "IVStatsNoteHeader_lbl"
        ' 
        ' IVStatsNote_lbl
        ' 
        resources.ApplyResources(IVStatsNote_lbl, "IVStatsNote_lbl")
        IVStatsNote_lbl.Name = "IVStatsNote_lbl"
        ' 
        ' battleTeamID_nbr
        ' 
        resources.ApplyResources(battleTeamID_nbr, "battleTeamID_nbr")
        battleTeamID_nbr.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        battleTeamID_nbr.Name = "battleTeamID_nbr"
        ' 
        ' Label2
        ' 
        resources.ApplyResources(Label2, "Label2")
        Label2.Name = "Label2"
        ' 
        ' properSpellingNote_lbl
        ' 
        resources.ApplyResources(properSpellingNote_lbl, "properSpellingNote_lbl")
        properSpellingNote_lbl.ForeColor = Color.Red
        properSpellingNote_lbl.Name = "properSpellingNote_lbl"
        ' 
        ' essData_lbl
        ' 
        resources.ApplyResources(essData_lbl, "essData_lbl")
        essData_lbl.Name = "essData_lbl"
        ' 
        ' allowSuperShiny_chk
        ' 
        resources.ApplyResources(allowSuperShiny_chk, "allowSuperShiny_chk")
        allowSuperShiny_chk.Name = "allowSuperShiny_chk"
        allowSuperShiny_chk.UseVisualStyleBackColor = True
        ' 
        ' loseTextQuotes_chkBox
        ' 
        resources.ApplyResources(loseTextQuotes_chkBox, "loseTextQuotes_chkBox")
        loseTextQuotes_chkBox.Name = "loseTextQuotes_chkBox"
        loseTextQuotes_chkBox.UseVisualStyleBackColor = True
        ' 
        ' useAbilityIndex_chkBox
        ' 
        resources.ApplyResources(useAbilityIndex_chkBox, "useAbilityIndex_chkBox")
        useAbilityIndex_chkBox.Name = "useAbilityIndex_chkBox"
        useAbilityIndex_chkBox.UseVisualStyleBackColor = True
        ' 
        ' existingBattle_chkBox
        ' 
        resources.ApplyResources(existingBattle_chkBox, "existingBattle_chkBox")
        existingBattle_chkBox.Name = "existingBattle_chkBox"
        existingBattle_chkBox.UseVisualStyleBackColor = True
        ' 
        ' customBallIDs_chkBox
        ' 
        resources.ApplyResources(customBallIDs_chkBox, "customBallIDs_chkBox")
        customBallIDs_chkBox.Checked = True
        customBallIDs_chkBox.CheckState = CheckState.Checked
        customBallIDs_chkBox.Name = "customBallIDs_chkBox"
        customBallIDs_chkBox.UseVisualStyleBackColor = True
        ' 
        ' essVersion_cmb
        ' 
        essVersion_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        essVersion_cmb.FormattingEnabled = True
        essVersion_cmb.Items.AddRange(New Object() {resources.GetString("essVersion_cmb.Items"), resources.GetString("essVersion_cmb.Items1"), resources.GetString("essVersion_cmb.Items2"), resources.GetString("essVersion_cmb.Items3"), resources.GetString("essVersion_cmb.Items4")})
        resources.ApplyResources(essVersion_cmb, "essVersion_cmb")
        essVersion_cmb.Name = "essVersion_cmb"
        ' 
        ' essVersion_lbl
        ' 
        resources.ApplyResources(essVersion_lbl, "essVersion_lbl")
        essVersion_lbl.Name = "essVersion_lbl"
        ' 
        ' battleTeamID_lbl
        ' 
        resources.ApplyResources(battleTeamID_lbl, "battleTeamID_lbl")
        battleTeamID_lbl.Name = "battleTeamID_lbl"
        ' 
        ' numPoké_lbl
        ' 
        resources.ApplyResources(numPoké_lbl, "numPoké_lbl")
        numPoké_lbl.Name = "numPoké_lbl"
        ' 
        ' numPoké_cmb
        ' 
        numPoké_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        numPoké_cmb.FormattingEnabled = True
        numPoké_cmb.Items.AddRange(New Object() {resources.GetString("numPoké_cmb.Items"), resources.GetString("numPoké_cmb.Items1"), resources.GetString("numPoké_cmb.Items2"), resources.GetString("numPoké_cmb.Items3"), resources.GetString("numPoké_cmb.Items4"), resources.GetString("numPoké_cmb.Items5")})
        resources.ApplyResources(numPoké_cmb, "numPoké_cmb")
        numPoké_cmb.Name = "numPoké_cmb"
        ' 
        ' loseText_lbl
        ' 
        resources.ApplyResources(loseText_lbl, "loseText_lbl")
        loseText_lbl.Name = "loseText_lbl"
        ' 
        ' loseText_txt
        ' 
        resources.ApplyResources(loseText_txt, "loseText_txt")
        loseText_txt.Name = "loseText_txt"
        ' 
        ' trainerType_txtBox
        ' 
        resources.ApplyResources(trainerType_txtBox, "trainerType_txtBox")
        trainerType_txtBox.Name = "trainerType_txtBox"
        ' 
        ' trainerType_lbl
        ' 
        resources.ApplyResources(trainerType_lbl, "trainerType_lbl")
        trainerType_lbl.Name = "trainerType_lbl"
        ' 
        ' trainerName_txtBox
        ' 
        resources.ApplyResources(trainerName_txtBox, "trainerName_txtBox")
        trainerName_txtBox.Name = "trainerName_txtBox"
        ' 
        ' trainerName_lbl
        ' 
        resources.ApplyResources(trainerName_lbl, "trainerName_lbl")
        trainerName_lbl.Name = "trainerName_lbl"
        ' 
        ' trainerInfoHeader_lbl
        ' 
        resources.ApplyResources(trainerInfoHeader_lbl, "trainerInfoHeader_lbl")
        trainerInfoHeader_lbl.Name = "trainerInfoHeader_lbl"
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
        resources.ApplyResources(pg_items, "pg_items")
        pg_items.Name = "pg_items"
        pg_items.UseVisualStyleBackColor = True
        ' 
        ' itemAddMaxElixir_btn
        ' 
        resources.ApplyResources(itemAddMaxElixir_btn, "itemAddMaxElixir_btn")
        itemAddMaxElixir_btn.Name = "itemAddMaxElixir_btn"
        itemAddMaxElixir_btn.UseVisualStyleBackColor = True
        ' 
        ' itemAddElixir_btn
        ' 
        resources.ApplyResources(itemAddElixir_btn, "itemAddElixir_btn")
        itemAddElixir_btn.Name = "itemAddElixir_btn"
        itemAddElixir_btn.UseVisualStyleBackColor = True
        ' 
        ' itemAddMaxEther_btn
        ' 
        resources.ApplyResources(itemAddMaxEther_btn, "itemAddMaxEther_btn")
        itemAddMaxEther_btn.Name = "itemAddMaxEther_btn"
        itemAddMaxEther_btn.UseVisualStyleBackColor = True
        ' 
        ' itemAddEther_btn
        ' 
        resources.ApplyResources(itemAddEther_btn, "itemAddEther_btn")
        itemAddEther_btn.Name = "itemAddEther_btn"
        itemAddEther_btn.UseVisualStyleBackColor = True
        ' 
        ' itemAddFullRestore_btn
        ' 
        resources.ApplyResources(itemAddFullRestore_btn, "itemAddFullRestore_btn")
        itemAddFullRestore_btn.Name = "itemAddFullRestore_btn"
        itemAddFullRestore_btn.UseVisualStyleBackColor = True
        ' 
        ' itemAddHyperPotion_btn
        ' 
        resources.ApplyResources(itemAddHyperPotion_btn, "itemAddHyperPotion_btn")
        itemAddHyperPotion_btn.Name = "itemAddHyperPotion_btn"
        itemAddHyperPotion_btn.UseVisualStyleBackColor = True
        ' 
        ' itemAddMaxPotion_btn
        ' 
        resources.ApplyResources(itemAddMaxPotion_btn, "itemAddMaxPotion_btn")
        itemAddMaxPotion_btn.Name = "itemAddMaxPotion_btn"
        itemAddMaxPotion_btn.UseVisualStyleBackColor = True
        ' 
        ' itemAddSuperPotion_btn
        ' 
        resources.ApplyResources(itemAddSuperPotion_btn, "itemAddSuperPotion_btn")
        itemAddSuperPotion_btn.Name = "itemAddSuperPotion_btn"
        itemAddSuperPotion_btn.UseVisualStyleBackColor = True
        ' 
        ' itemAddPotion_btn
        ' 
        resources.ApplyResources(itemAddPotion_btn, "itemAddPotion_btn")
        itemAddPotion_btn.Name = "itemAddPotion_btn"
        itemAddPotion_btn.UseVisualStyleBackColor = True
        ' 
        ' removeItem_btn
        ' 
        resources.ApplyResources(removeItem_btn, "removeItem_btn")
        removeItem_btn.Name = "removeItem_btn"
        removeItem_btn.UseVisualStyleBackColor = True
        ' 
        ' addItem_btn
        ' 
        resources.ApplyResources(addItem_btn, "addItem_btn")
        addItem_btn.Name = "addItem_btn"
        addItem_btn.UseVisualStyleBackColor = True
        ' 
        ' trainerItemsInfo_lbl
        ' 
        resources.ApplyResources(trainerItemsInfo_lbl, "trainerItemsInfo_lbl")
        trainerItemsInfo_lbl.Name = "trainerItemsInfo_lbl"
        ' 
        ' trainerItemsHeader_lbl
        ' 
        resources.ApplyResources(trainerItemsHeader_lbl, "trainerItemsHeader_lbl")
        trainerItemsHeader_lbl.Name = "trainerItemsHeader_lbl"
        ' 
        ' items_grp
        ' 
        items_grp.Controls.Add(items_lst)
        resources.ApplyResources(items_grp, "items_grp")
        items_grp.Name = "items_grp"
        items_grp.TabStop = False
        ' 
        ' items_lst
        ' 
        resources.ApplyResources(items_lst, "items_lst")
        items_lst.FormattingEnabled = True
        items_lst.Name = "items_lst"
        ' 
        ' pg_pokemon
        ' 
        pg_pokemon.Controls.Add(pkmnTabs_tab)
        resources.ApplyResources(pg_pokemon, "pg_pokemon")
        pg_pokemon.Name = "pg_pokemon"
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
        resources.ApplyResources(pkmnTabs_tab, "pkmnTabs_tab")
        pkmnTabs_tab.Multiline = True
        pkmnTabs_tab.Name = "pkmnTabs_tab"
        pkmnTabs_tab.SelectedIndex = 0
        ' 
        ' pg_pkmn1
        ' 
        pg_pkmn1.Controls.Add(pokemon1_grp)
        resources.ApplyResources(pg_pkmn1, "pg_pkmn1")
        pg_pkmn1.Name = "pg_pkmn1"
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
        resources.ApplyResources(pokemon1_grp, "pokemon1_grp")
        pokemon1_grp.Name = "pokemon1_grp"
        pokemon1_grp.TabStop = False
        ' 
        ' pokemon1Level_nbr
        ' 
        resources.ApplyResources(pokemon1Level_nbr, "pokemon1Level_nbr")
        pokemon1Level_nbr.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        pokemon1Level_nbr.Name = "pokemon1Level_nbr"
        pokemon1Level_nbr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' pokemon1Form_nbr
        ' 
        resources.ApplyResources(pokemon1Form_nbr, "pokemon1Form_nbr")
        pokemon1Form_nbr.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        pokemon1Form_nbr.Name = "pokemon1Form_nbr"
        ' 
        ' pokemon1Happiness_nbr
        ' 
        resources.ApplyResources(pokemon1Happiness_nbr, "pokemon1Happiness_nbr")
        pokemon1Happiness_nbr.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        pokemon1Happiness_nbr.Name = "pokemon1Happiness_nbr"
        pokemon1Happiness_nbr.Value = New Decimal(New Integer() {70, 0, 0, 0})
        ' 
        ' pokemon1Shadow_grp
        ' 
        pokemon1Shadow_grp.Controls.Add(pokemon1Shadow_rad)
        pokemon1Shadow_grp.Controls.Add(pokemon1NotShadow_rad)
        resources.ApplyResources(pokemon1Shadow_grp, "pokemon1Shadow_grp")
        pokemon1Shadow_grp.Name = "pokemon1Shadow_grp"
        pokemon1Shadow_grp.TabStop = False
        ' 
        ' pokemon1Shadow_rad
        ' 
        resources.ApplyResources(pokemon1Shadow_rad, "pokemon1Shadow_rad")
        pokemon1Shadow_rad.Name = "pokemon1Shadow_rad"
        pokemon1Shadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon1NotShadow_rad
        ' 
        resources.ApplyResources(pokemon1NotShadow_rad, "pokemon1NotShadow_rad")
        pokemon1NotShadow_rad.Checked = True
        pokemon1NotShadow_rad.Name = "pokemon1NotShadow_rad"
        pokemon1NotShadow_rad.TabStop = True
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
        resources.ApplyResources(pokemon1EVs_grp, "pokemon1EVs_grp")
        pokemon1EVs_grp.Name = "pokemon1EVs_grp"
        pokemon1EVs_grp.TabStop = False
        ' 
        ' pokemon1EVsDEF_txt
        ' 
        resources.ApplyResources(pokemon1EVsDEF_txt, "pokemon1EVsDEF_txt")
        pokemon1EVsDEF_txt.Name = "pokemon1EVsDEF_txt"
        ' 
        ' pokemon1EVsDEF_lbl
        ' 
        resources.ApplyResources(pokemon1EVsDEF_lbl, "pokemon1EVsDEF_lbl")
        pokemon1EVsDEF_lbl.Name = "pokemon1EVsDEF_lbl"
        ' 
        ' pokemon1EVsSPDEF_txt
        ' 
        resources.ApplyResources(pokemon1EVsSPDEF_txt, "pokemon1EVsSPDEF_txt")
        pokemon1EVsSPDEF_txt.Name = "pokemon1EVsSPDEF_txt"
        ' 
        ' pokemon1EVsSPDEF_lbl
        ' 
        resources.ApplyResources(pokemon1EVsSPDEF_lbl, "pokemon1EVsSPDEF_lbl")
        pokemon1EVsSPDEF_lbl.Name = "pokemon1EVsSPDEF_lbl"
        ' 
        ' pokemon1EVsSPATK_txt
        ' 
        resources.ApplyResources(pokemon1EVsSPATK_txt, "pokemon1EVsSPATK_txt")
        pokemon1EVsSPATK_txt.Name = "pokemon1EVsSPATK_txt"
        ' 
        ' pokemon1EVsSPATK_lbl
        ' 
        resources.ApplyResources(pokemon1EVsSPATK_lbl, "pokemon1EVsSPATK_lbl")
        pokemon1EVsSPATK_lbl.Name = "pokemon1EVsSPATK_lbl"
        ' 
        ' pokemon1EVsSPD_txt
        ' 
        resources.ApplyResources(pokemon1EVsSPD_txt, "pokemon1EVsSPD_txt")
        pokemon1EVsSPD_txt.Name = "pokemon1EVsSPD_txt"
        ' 
        ' pokemon1EVsSPD_lbl
        ' 
        resources.ApplyResources(pokemon1EVsSPD_lbl, "pokemon1EVsSPD_lbl")
        pokemon1EVsSPD_lbl.Name = "pokemon1EVsSPD_lbl"
        ' 
        ' pokemon1EVsATK_txt
        ' 
        resources.ApplyResources(pokemon1EVsATK_txt, "pokemon1EVsATK_txt")
        pokemon1EVsATK_txt.Name = "pokemon1EVsATK_txt"
        ' 
        ' pokemon1EVsATK_lbl
        ' 
        resources.ApplyResources(pokemon1EVsATK_lbl, "pokemon1EVsATK_lbl")
        pokemon1EVsATK_lbl.Name = "pokemon1EVsATK_lbl"
        ' 
        ' pokemon1EVsHP_txt
        ' 
        resources.ApplyResources(pokemon1EVsHP_txt, "pokemon1EVsHP_txt")
        pokemon1EVsHP_txt.Name = "pokemon1EVsHP_txt"
        ' 
        ' pokemon1EVsHP_lbl
        ' 
        resources.ApplyResources(pokemon1EVsHP_lbl, "pokemon1EVsHP_lbl")
        pokemon1EVsHP_lbl.Name = "pokemon1EVsHP_lbl"
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
        resources.ApplyResources(pokemon1IVs_grp, "pokemon1IVs_grp")
        pokemon1IVs_grp.Name = "pokemon1IVs_grp"
        pokemon1IVs_grp.TabStop = False
        ' 
        ' pokemon1RandomIVs_btn
        ' 
        resources.ApplyResources(pokemon1RandomIVs_btn, "pokemon1RandomIVs_btn")
        pokemon1RandomIVs_btn.Name = "pokemon1RandomIVs_btn"
        pokemon1RandomIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon1MaxIVs_btn
        ' 
        resources.ApplyResources(pokemon1MaxIVs_btn, "pokemon1MaxIVs_btn")
        pokemon1MaxIVs_btn.Name = "pokemon1MaxIVs_btn"
        pokemon1MaxIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon1IVsDEF_txt
        ' 
        resources.ApplyResources(pokemon1IVsDEF_txt, "pokemon1IVsDEF_txt")
        pokemon1IVsDEF_txt.Name = "pokemon1IVsDEF_txt"
        ' 
        ' pokemon1IVsDEF_lbl
        ' 
        resources.ApplyResources(pokemon1IVsDEF_lbl, "pokemon1IVsDEF_lbl")
        pokemon1IVsDEF_lbl.Name = "pokemon1IVsDEF_lbl"
        ' 
        ' pokemon1IVsSPDEF_txt
        ' 
        resources.ApplyResources(pokemon1IVsSPDEF_txt, "pokemon1IVsSPDEF_txt")
        pokemon1IVsSPDEF_txt.Name = "pokemon1IVsSPDEF_txt"
        ' 
        ' pokemon1IVsSPDEF_lbl
        ' 
        resources.ApplyResources(pokemon1IVsSPDEF_lbl, "pokemon1IVsSPDEF_lbl")
        pokemon1IVsSPDEF_lbl.Name = "pokemon1IVsSPDEF_lbl"
        ' 
        ' pokemon1IVsSPATK_txt
        ' 
        resources.ApplyResources(pokemon1IVsSPATK_txt, "pokemon1IVsSPATK_txt")
        pokemon1IVsSPATK_txt.Name = "pokemon1IVsSPATK_txt"
        ' 
        ' pokemon1IVsSPATK_lbl
        ' 
        resources.ApplyResources(pokemon1IVsSPATK_lbl, "pokemon1IVsSPATK_lbl")
        pokemon1IVsSPATK_lbl.Name = "pokemon1IVsSPATK_lbl"
        ' 
        ' pokemon1IVsSPD_txt
        ' 
        resources.ApplyResources(pokemon1IVsSPD_txt, "pokemon1IVsSPD_txt")
        pokemon1IVsSPD_txt.Name = "pokemon1IVsSPD_txt"
        ' 
        ' pokemon1IVsSPD_lbl
        ' 
        resources.ApplyResources(pokemon1IVsSPD_lbl, "pokemon1IVsSPD_lbl")
        pokemon1IVsSPD_lbl.Name = "pokemon1IVsSPD_lbl"
        ' 
        ' pokemon1IVsATK_txt
        ' 
        resources.ApplyResources(pokemon1IVsATK_txt, "pokemon1IVsATK_txt")
        pokemon1IVsATK_txt.Name = "pokemon1IVsATK_txt"
        ' 
        ' pokemon1IVsATK_lbl
        ' 
        resources.ApplyResources(pokemon1IVsATK_lbl, "pokemon1IVsATK_lbl")
        pokemon1IVsATK_lbl.Name = "pokemon1IVsATK_lbl"
        ' 
        ' pokemon1IVsHP_txt
        ' 
        resources.ApplyResources(pokemon1IVsHP_txt, "pokemon1IVsHP_txt")
        pokemon1IVsHP_txt.Name = "pokemon1IVsHP_txt"
        ' 
        ' pokemon1IVsHP_lbl
        ' 
        resources.ApplyResources(pokemon1IVsHP_lbl, "pokemon1IVsHP_lbl")
        pokemon1IVsHP_lbl.Name = "pokemon1IVsHP_lbl"
        ' 
        ' pokemon1PokeballID_cmb
        ' 
        pokemon1PokeballID_cmb.FormattingEnabled = True
        pokemon1PokeballID_cmb.Items.AddRange(New Object() {resources.GetString("pokemon1PokeballID_cmb.Items"), resources.GetString("pokemon1PokeballID_cmb.Items1"), resources.GetString("pokemon1PokeballID_cmb.Items2"), resources.GetString("pokemon1PokeballID_cmb.Items3"), resources.GetString("pokemon1PokeballID_cmb.Items4"), resources.GetString("pokemon1PokeballID_cmb.Items5"), resources.GetString("pokemon1PokeballID_cmb.Items6"), resources.GetString("pokemon1PokeballID_cmb.Items7"), resources.GetString("pokemon1PokeballID_cmb.Items8"), resources.GetString("pokemon1PokeballID_cmb.Items9"), resources.GetString("pokemon1PokeballID_cmb.Items10"), resources.GetString("pokemon1PokeballID_cmb.Items11"), resources.GetString("pokemon1PokeballID_cmb.Items12"), resources.GetString("pokemon1PokeballID_cmb.Items13"), resources.GetString("pokemon1PokeballID_cmb.Items14"), resources.GetString("pokemon1PokeballID_cmb.Items15"), resources.GetString("pokemon1PokeballID_cmb.Items16"), resources.GetString("pokemon1PokeballID_cmb.Items17"), resources.GetString("pokemon1PokeballID_cmb.Items18"), resources.GetString("pokemon1PokeballID_cmb.Items19"), resources.GetString("pokemon1PokeballID_cmb.Items20"), resources.GetString("pokemon1PokeballID_cmb.Items21"), resources.GetString("pokemon1PokeballID_cmb.Items22"), resources.GetString("pokemon1PokeballID_cmb.Items23"), resources.GetString("pokemon1PokeballID_cmb.Items24"), resources.GetString("pokemon1PokeballID_cmb.Items25")})
        resources.ApplyResources(pokemon1PokeballID_cmb, "pokemon1PokeballID_cmb")
        pokemon1PokeballID_cmb.Name = "pokemon1PokeballID_cmb"
        ' 
        ' pokemon1Ball_lbl
        ' 
        resources.ApplyResources(pokemon1Ball_lbl, "pokemon1Ball_lbl")
        pokemon1Ball_lbl.Name = "pokemon1Ball_lbl"
        ' 
        ' pokemon1Nickname_txtBox
        ' 
        resources.ApplyResources(pokemon1Nickname_txtBox, "pokemon1Nickname_txtBox")
        pokemon1Nickname_txtBox.Name = "pokemon1Nickname_txtBox"
        ' 
        ' pokemon1Nickname_lbl
        ' 
        resources.ApplyResources(pokemon1Nickname_lbl, "pokemon1Nickname_lbl")
        pokemon1Nickname_lbl.Name = "pokemon1Nickname_lbl"
        ' 
        ' pokemon1Happiness_lbl
        ' 
        resources.ApplyResources(pokemon1Happiness_lbl, "pokemon1Happiness_lbl")
        pokemon1Happiness_lbl.Name = "pokemon1Happiness_lbl"
        ' 
        ' pokemon1Nature_cmb
        ' 
        pokemon1Nature_cmb.FormattingEnabled = True
        pokemon1Nature_cmb.Items.AddRange(New Object() {resources.GetString("pokemon1Nature_cmb.Items"), resources.GetString("pokemon1Nature_cmb.Items1"), resources.GetString("pokemon1Nature_cmb.Items2"), resources.GetString("pokemon1Nature_cmb.Items3"), resources.GetString("pokemon1Nature_cmb.Items4"), resources.GetString("pokemon1Nature_cmb.Items5"), resources.GetString("pokemon1Nature_cmb.Items6"), resources.GetString("pokemon1Nature_cmb.Items7"), resources.GetString("pokemon1Nature_cmb.Items8"), resources.GetString("pokemon1Nature_cmb.Items9"), resources.GetString("pokemon1Nature_cmb.Items10"), resources.GetString("pokemon1Nature_cmb.Items11"), resources.GetString("pokemon1Nature_cmb.Items12"), resources.GetString("pokemon1Nature_cmb.Items13"), resources.GetString("pokemon1Nature_cmb.Items14"), resources.GetString("pokemon1Nature_cmb.Items15"), resources.GetString("pokemon1Nature_cmb.Items16"), resources.GetString("pokemon1Nature_cmb.Items17"), resources.GetString("pokemon1Nature_cmb.Items18"), resources.GetString("pokemon1Nature_cmb.Items19"), resources.GetString("pokemon1Nature_cmb.Items20"), resources.GetString("pokemon1Nature_cmb.Items21"), resources.GetString("pokemon1Nature_cmb.Items22"), resources.GetString("pokemon1Nature_cmb.Items23"), resources.GetString("pokemon1Nature_cmb.Items24"), resources.GetString("pokemon1Nature_cmb.Items25")})
        resources.ApplyResources(pokemon1Nature_cmb, "pokemon1Nature_cmb")
        pokemon1Nature_cmb.Name = "pokemon1Nature_cmb"
        ' 
        ' pokemon1Nature_lbl
        ' 
        resources.ApplyResources(pokemon1Nature_lbl, "pokemon1Nature_lbl")
        pokemon1Nature_lbl.Name = "pokemon1Nature_lbl"
        ' 
        ' pokemon1Shiny_grp
        ' 
        pokemon1Shiny_grp.Controls.Add(pokemon1SuperShiny_chkBox)
        pokemon1Shiny_grp.Controls.Add(pokemon1Shiny_rad)
        pokemon1Shiny_grp.Controls.Add(pokemon1NotShiny_rad)
        resources.ApplyResources(pokemon1Shiny_grp, "pokemon1Shiny_grp")
        pokemon1Shiny_grp.Name = "pokemon1Shiny_grp"
        pokemon1Shiny_grp.TabStop = False
        ' 
        ' pokemon1SuperShiny_chkBox
        ' 
        resources.ApplyResources(pokemon1SuperShiny_chkBox, "pokemon1SuperShiny_chkBox")
        pokemon1SuperShiny_chkBox.Name = "pokemon1SuperShiny_chkBox"
        pokemon1SuperShiny_chkBox.UseVisualStyleBackColor = True
        ' 
        ' pokemon1Shiny_rad
        ' 
        resources.ApplyResources(pokemon1Shiny_rad, "pokemon1Shiny_rad")
        pokemon1Shiny_rad.Name = "pokemon1Shiny_rad"
        pokemon1Shiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon1NotShiny_rad
        ' 
        resources.ApplyResources(pokemon1NotShiny_rad, "pokemon1NotShiny_rad")
        pokemon1NotShiny_rad.Checked = True
        pokemon1NotShiny_rad.Name = "pokemon1NotShiny_rad"
        pokemon1NotShiny_rad.TabStop = True
        pokemon1NotShiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon1Form_lbl
        ' 
        resources.ApplyResources(pokemon1Form_lbl, "pokemon1Form_lbl")
        pokemon1Form_lbl.Name = "pokemon1Form_lbl"
        ' 
        ' pokemon1Gender_cmb
        ' 
        pokemon1Gender_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        pokemon1Gender_cmb.FormattingEnabled = True
        pokemon1Gender_cmb.Items.AddRange(New Object() {resources.GetString("pokemon1Gender_cmb.Items"), resources.GetString("pokemon1Gender_cmb.Items1"), resources.GetString("pokemon1Gender_cmb.Items2")})
        resources.ApplyResources(pokemon1Gender_cmb, "pokemon1Gender_cmb")
        pokemon1Gender_cmb.Name = "pokemon1Gender_cmb"
        ' 
        ' pokemon1Gender_lbl
        ' 
        resources.ApplyResources(pokemon1Gender_lbl, "pokemon1Gender_lbl")
        pokemon1Gender_lbl.Name = "pokemon1Gender_lbl"
        ' 
        ' pokemon1Ability_cmb
        ' 
        pokemon1Ability_cmb.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource1"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource2"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource3"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource4"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource5"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource6"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource7"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource8"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource9"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource10"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource11"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource12"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource13"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource14"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource15"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource16"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource17"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource18"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource19"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource20"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource21"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource22"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource23"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource24"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource25"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource26"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource27"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource28"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource29"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource30"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource31"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource32"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource33"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource34"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource35"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource36"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource37"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource38"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource39"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource40"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource41"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource42"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource43"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource44"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource45"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource46"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource47"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource48"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource49"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource50"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource51"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource52"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource53"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource54"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource55"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource56"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource57"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource58"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource59"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource60"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource61"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource62"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource63"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource64"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource65"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource66"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource67"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource68"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource69"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource70"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource71"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource72"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource73"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource74"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource75"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource76"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource77"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource78"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource79"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource80"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource81"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource82"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource83"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource84"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource85"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource86"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource87"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource88"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource89"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource90"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource91"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource92"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource93"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource94"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource95"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource96"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource97"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource98"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource99"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource100"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource101"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource102"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource103"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource104"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource105"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource106"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource107"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource108"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource109"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource110"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource111"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource112"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource113"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource114"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource115"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource116"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource117"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource118"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource119"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource120"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource121"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource122"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource123"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource124"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource125"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource126"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource127"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource128"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource129"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource130"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource131"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource132"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource133"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource134"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource135"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource136"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource137"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource138"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource139"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource140"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource141"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource142"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource143"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource144"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource145"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource146"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource147"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource148"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource149"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource150"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource151"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource152"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource153"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource154"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource155"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource156"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource157"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource158"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource159"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource160"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource161"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource162"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource163"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource164"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource165"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource166"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource167"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource168"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource169"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource170"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource171"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource172"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource173"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource174"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource175"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource176"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource177"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource178"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource179"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource180"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource181"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource182"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource183"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource184"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource185"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource186"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource187"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource188"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource189"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource190"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource191"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource192"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource193"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource194"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource195"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource196"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource197"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource198"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource199"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource200"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource201"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource202"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource203"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource204"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource205"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource206"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource207"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource208"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource209"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource210"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource211"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource212"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource213"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource214"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource215"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource216"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource217"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource218"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource219"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource220"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource221"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource222"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource223"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource224"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource225"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource226"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource227"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource228"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource229"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource230"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource231"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource232"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource233"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource234"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource235"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource236"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource237"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource238"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource239"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource240"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource241"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource242"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource243"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource244"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource245"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource246"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource247"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource248"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource249"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource250"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource251"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource252"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource253"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource254"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource255"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource256"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource257"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource258"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource259"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource260"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource261"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource262"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource263"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource264"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource265"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource266"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource267"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource268"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource269"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource270"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource271"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource272"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource273"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource274"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource275"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource276"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource277"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource278"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource279"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource280"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource281"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource282"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource283"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource284"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource285"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource286"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource287"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource288"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource289"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource290"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource291"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource292"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource293"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource294"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource295"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource296"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource297"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource298"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource299"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource300"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource301"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource302"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource303"), resources.GetString("pokemon1Ability_cmb.AutoCompleteCustomSource304")})
        pokemon1Ability_cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon1Ability_cmb.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon1Ability_cmb.FormattingEnabled = True
        pokemon1Ability_cmb.Items.AddRange(New Object() {resources.GetString("pokemon1Ability_cmb.Items"), resources.GetString("pokemon1Ability_cmb.Items1"), resources.GetString("pokemon1Ability_cmb.Items2"), resources.GetString("pokemon1Ability_cmb.Items3"), resources.GetString("pokemon1Ability_cmb.Items4"), resources.GetString("pokemon1Ability_cmb.Items5"), resources.GetString("pokemon1Ability_cmb.Items6"), resources.GetString("pokemon1Ability_cmb.Items7"), resources.GetString("pokemon1Ability_cmb.Items8"), resources.GetString("pokemon1Ability_cmb.Items9"), resources.GetString("pokemon1Ability_cmb.Items10"), resources.GetString("pokemon1Ability_cmb.Items11"), resources.GetString("pokemon1Ability_cmb.Items12"), resources.GetString("pokemon1Ability_cmb.Items13"), resources.GetString("pokemon1Ability_cmb.Items14"), resources.GetString("pokemon1Ability_cmb.Items15"), resources.GetString("pokemon1Ability_cmb.Items16"), resources.GetString("pokemon1Ability_cmb.Items17"), resources.GetString("pokemon1Ability_cmb.Items18"), resources.GetString("pokemon1Ability_cmb.Items19"), resources.GetString("pokemon1Ability_cmb.Items20"), resources.GetString("pokemon1Ability_cmb.Items21"), resources.GetString("pokemon1Ability_cmb.Items22"), resources.GetString("pokemon1Ability_cmb.Items23"), resources.GetString("pokemon1Ability_cmb.Items24"), resources.GetString("pokemon1Ability_cmb.Items25"), resources.GetString("pokemon1Ability_cmb.Items26"), resources.GetString("pokemon1Ability_cmb.Items27"), resources.GetString("pokemon1Ability_cmb.Items28"), resources.GetString("pokemon1Ability_cmb.Items29"), resources.GetString("pokemon1Ability_cmb.Items30"), resources.GetString("pokemon1Ability_cmb.Items31"), resources.GetString("pokemon1Ability_cmb.Items32"), resources.GetString("pokemon1Ability_cmb.Items33"), resources.GetString("pokemon1Ability_cmb.Items34"), resources.GetString("pokemon1Ability_cmb.Items35"), resources.GetString("pokemon1Ability_cmb.Items36"), resources.GetString("pokemon1Ability_cmb.Items37"), resources.GetString("pokemon1Ability_cmb.Items38"), resources.GetString("pokemon1Ability_cmb.Items39"), resources.GetString("pokemon1Ability_cmb.Items40"), resources.GetString("pokemon1Ability_cmb.Items41"), resources.GetString("pokemon1Ability_cmb.Items42"), resources.GetString("pokemon1Ability_cmb.Items43"), resources.GetString("pokemon1Ability_cmb.Items44"), resources.GetString("pokemon1Ability_cmb.Items45"), resources.GetString("pokemon1Ability_cmb.Items46"), resources.GetString("pokemon1Ability_cmb.Items47"), resources.GetString("pokemon1Ability_cmb.Items48"), resources.GetString("pokemon1Ability_cmb.Items49"), resources.GetString("pokemon1Ability_cmb.Items50"), resources.GetString("pokemon1Ability_cmb.Items51"), resources.GetString("pokemon1Ability_cmb.Items52"), resources.GetString("pokemon1Ability_cmb.Items53"), resources.GetString("pokemon1Ability_cmb.Items54"), resources.GetString("pokemon1Ability_cmb.Items55"), resources.GetString("pokemon1Ability_cmb.Items56"), resources.GetString("pokemon1Ability_cmb.Items57"), resources.GetString("pokemon1Ability_cmb.Items58"), resources.GetString("pokemon1Ability_cmb.Items59"), resources.GetString("pokemon1Ability_cmb.Items60"), resources.GetString("pokemon1Ability_cmb.Items61"), resources.GetString("pokemon1Ability_cmb.Items62"), resources.GetString("pokemon1Ability_cmb.Items63"), resources.GetString("pokemon1Ability_cmb.Items64"), resources.GetString("pokemon1Ability_cmb.Items65"), resources.GetString("pokemon1Ability_cmb.Items66"), resources.GetString("pokemon1Ability_cmb.Items67"), resources.GetString("pokemon1Ability_cmb.Items68"), resources.GetString("pokemon1Ability_cmb.Items69"), resources.GetString("pokemon1Ability_cmb.Items70"), resources.GetString("pokemon1Ability_cmb.Items71"), resources.GetString("pokemon1Ability_cmb.Items72"), resources.GetString("pokemon1Ability_cmb.Items73"), resources.GetString("pokemon1Ability_cmb.Items74"), resources.GetString("pokemon1Ability_cmb.Items75"), resources.GetString("pokemon1Ability_cmb.Items76"), resources.GetString("pokemon1Ability_cmb.Items77"), resources.GetString("pokemon1Ability_cmb.Items78"), resources.GetString("pokemon1Ability_cmb.Items79"), resources.GetString("pokemon1Ability_cmb.Items80"), resources.GetString("pokemon1Ability_cmb.Items81"), resources.GetString("pokemon1Ability_cmb.Items82"), resources.GetString("pokemon1Ability_cmb.Items83"), resources.GetString("pokemon1Ability_cmb.Items84"), resources.GetString("pokemon1Ability_cmb.Items85"), resources.GetString("pokemon1Ability_cmb.Items86"), resources.GetString("pokemon1Ability_cmb.Items87"), resources.GetString("pokemon1Ability_cmb.Items88"), resources.GetString("pokemon1Ability_cmb.Items89"), resources.GetString("pokemon1Ability_cmb.Items90"), resources.GetString("pokemon1Ability_cmb.Items91"), resources.GetString("pokemon1Ability_cmb.Items92"), resources.GetString("pokemon1Ability_cmb.Items93"), resources.GetString("pokemon1Ability_cmb.Items94"), resources.GetString("pokemon1Ability_cmb.Items95"), resources.GetString("pokemon1Ability_cmb.Items96"), resources.GetString("pokemon1Ability_cmb.Items97"), resources.GetString("pokemon1Ability_cmb.Items98"), resources.GetString("pokemon1Ability_cmb.Items99"), resources.GetString("pokemon1Ability_cmb.Items100"), resources.GetString("pokemon1Ability_cmb.Items101"), resources.GetString("pokemon1Ability_cmb.Items102"), resources.GetString("pokemon1Ability_cmb.Items103"), resources.GetString("pokemon1Ability_cmb.Items104"), resources.GetString("pokemon1Ability_cmb.Items105"), resources.GetString("pokemon1Ability_cmb.Items106"), resources.GetString("pokemon1Ability_cmb.Items107"), resources.GetString("pokemon1Ability_cmb.Items108"), resources.GetString("pokemon1Ability_cmb.Items109"), resources.GetString("pokemon1Ability_cmb.Items110"), resources.GetString("pokemon1Ability_cmb.Items111"), resources.GetString("pokemon1Ability_cmb.Items112"), resources.GetString("pokemon1Ability_cmb.Items113"), resources.GetString("pokemon1Ability_cmb.Items114"), resources.GetString("pokemon1Ability_cmb.Items115"), resources.GetString("pokemon1Ability_cmb.Items116"), resources.GetString("pokemon1Ability_cmb.Items117"), resources.GetString("pokemon1Ability_cmb.Items118"), resources.GetString("pokemon1Ability_cmb.Items119"), resources.GetString("pokemon1Ability_cmb.Items120"), resources.GetString("pokemon1Ability_cmb.Items121"), resources.GetString("pokemon1Ability_cmb.Items122"), resources.GetString("pokemon1Ability_cmb.Items123"), resources.GetString("pokemon1Ability_cmb.Items124"), resources.GetString("pokemon1Ability_cmb.Items125"), resources.GetString("pokemon1Ability_cmb.Items126"), resources.GetString("pokemon1Ability_cmb.Items127"), resources.GetString("pokemon1Ability_cmb.Items128"), resources.GetString("pokemon1Ability_cmb.Items129"), resources.GetString("pokemon1Ability_cmb.Items130"), resources.GetString("pokemon1Ability_cmb.Items131"), resources.GetString("pokemon1Ability_cmb.Items132"), resources.GetString("pokemon1Ability_cmb.Items133"), resources.GetString("pokemon1Ability_cmb.Items134"), resources.GetString("pokemon1Ability_cmb.Items135"), resources.GetString("pokemon1Ability_cmb.Items136"), resources.GetString("pokemon1Ability_cmb.Items137"), resources.GetString("pokemon1Ability_cmb.Items138"), resources.GetString("pokemon1Ability_cmb.Items139"), resources.GetString("pokemon1Ability_cmb.Items140"), resources.GetString("pokemon1Ability_cmb.Items141"), resources.GetString("pokemon1Ability_cmb.Items142"), resources.GetString("pokemon1Ability_cmb.Items143"), resources.GetString("pokemon1Ability_cmb.Items144"), resources.GetString("pokemon1Ability_cmb.Items145"), resources.GetString("pokemon1Ability_cmb.Items146"), resources.GetString("pokemon1Ability_cmb.Items147"), resources.GetString("pokemon1Ability_cmb.Items148"), resources.GetString("pokemon1Ability_cmb.Items149"), resources.GetString("pokemon1Ability_cmb.Items150"), resources.GetString("pokemon1Ability_cmb.Items151"), resources.GetString("pokemon1Ability_cmb.Items152"), resources.GetString("pokemon1Ability_cmb.Items153"), resources.GetString("pokemon1Ability_cmb.Items154"), resources.GetString("pokemon1Ability_cmb.Items155"), resources.GetString("pokemon1Ability_cmb.Items156"), resources.GetString("pokemon1Ability_cmb.Items157"), resources.GetString("pokemon1Ability_cmb.Items158"), resources.GetString("pokemon1Ability_cmb.Items159"), resources.GetString("pokemon1Ability_cmb.Items160"), resources.GetString("pokemon1Ability_cmb.Items161"), resources.GetString("pokemon1Ability_cmb.Items162"), resources.GetString("pokemon1Ability_cmb.Items163"), resources.GetString("pokemon1Ability_cmb.Items164"), resources.GetString("pokemon1Ability_cmb.Items165"), resources.GetString("pokemon1Ability_cmb.Items166"), resources.GetString("pokemon1Ability_cmb.Items167"), resources.GetString("pokemon1Ability_cmb.Items168"), resources.GetString("pokemon1Ability_cmb.Items169"), resources.GetString("pokemon1Ability_cmb.Items170"), resources.GetString("pokemon1Ability_cmb.Items171"), resources.GetString("pokemon1Ability_cmb.Items172"), resources.GetString("pokemon1Ability_cmb.Items173"), resources.GetString("pokemon1Ability_cmb.Items174"), resources.GetString("pokemon1Ability_cmb.Items175"), resources.GetString("pokemon1Ability_cmb.Items176"), resources.GetString("pokemon1Ability_cmb.Items177"), resources.GetString("pokemon1Ability_cmb.Items178"), resources.GetString("pokemon1Ability_cmb.Items179"), resources.GetString("pokemon1Ability_cmb.Items180"), resources.GetString("pokemon1Ability_cmb.Items181"), resources.GetString("pokemon1Ability_cmb.Items182"), resources.GetString("pokemon1Ability_cmb.Items183"), resources.GetString("pokemon1Ability_cmb.Items184"), resources.GetString("pokemon1Ability_cmb.Items185"), resources.GetString("pokemon1Ability_cmb.Items186"), resources.GetString("pokemon1Ability_cmb.Items187"), resources.GetString("pokemon1Ability_cmb.Items188"), resources.GetString("pokemon1Ability_cmb.Items189"), resources.GetString("pokemon1Ability_cmb.Items190"), resources.GetString("pokemon1Ability_cmb.Items191"), resources.GetString("pokemon1Ability_cmb.Items192"), resources.GetString("pokemon1Ability_cmb.Items193"), resources.GetString("pokemon1Ability_cmb.Items194"), resources.GetString("pokemon1Ability_cmb.Items195"), resources.GetString("pokemon1Ability_cmb.Items196"), resources.GetString("pokemon1Ability_cmb.Items197"), resources.GetString("pokemon1Ability_cmb.Items198"), resources.GetString("pokemon1Ability_cmb.Items199"), resources.GetString("pokemon1Ability_cmb.Items200"), resources.GetString("pokemon1Ability_cmb.Items201"), resources.GetString("pokemon1Ability_cmb.Items202"), resources.GetString("pokemon1Ability_cmb.Items203"), resources.GetString("pokemon1Ability_cmb.Items204"), resources.GetString("pokemon1Ability_cmb.Items205"), resources.GetString("pokemon1Ability_cmb.Items206"), resources.GetString("pokemon1Ability_cmb.Items207"), resources.GetString("pokemon1Ability_cmb.Items208"), resources.GetString("pokemon1Ability_cmb.Items209"), resources.GetString("pokemon1Ability_cmb.Items210"), resources.GetString("pokemon1Ability_cmb.Items211"), resources.GetString("pokemon1Ability_cmb.Items212"), resources.GetString("pokemon1Ability_cmb.Items213"), resources.GetString("pokemon1Ability_cmb.Items214"), resources.GetString("pokemon1Ability_cmb.Items215"), resources.GetString("pokemon1Ability_cmb.Items216"), resources.GetString("pokemon1Ability_cmb.Items217"), resources.GetString("pokemon1Ability_cmb.Items218"), resources.GetString("pokemon1Ability_cmb.Items219"), resources.GetString("pokemon1Ability_cmb.Items220"), resources.GetString("pokemon1Ability_cmb.Items221"), resources.GetString("pokemon1Ability_cmb.Items222"), resources.GetString("pokemon1Ability_cmb.Items223"), resources.GetString("pokemon1Ability_cmb.Items224"), resources.GetString("pokemon1Ability_cmb.Items225"), resources.GetString("pokemon1Ability_cmb.Items226"), resources.GetString("pokemon1Ability_cmb.Items227"), resources.GetString("pokemon1Ability_cmb.Items228"), resources.GetString("pokemon1Ability_cmb.Items229"), resources.GetString("pokemon1Ability_cmb.Items230"), resources.GetString("pokemon1Ability_cmb.Items231"), resources.GetString("pokemon1Ability_cmb.Items232"), resources.GetString("pokemon1Ability_cmb.Items233"), resources.GetString("pokemon1Ability_cmb.Items234"), resources.GetString("pokemon1Ability_cmb.Items235"), resources.GetString("pokemon1Ability_cmb.Items236"), resources.GetString("pokemon1Ability_cmb.Items237"), resources.GetString("pokemon1Ability_cmb.Items238"), resources.GetString("pokemon1Ability_cmb.Items239"), resources.GetString("pokemon1Ability_cmb.Items240"), resources.GetString("pokemon1Ability_cmb.Items241"), resources.GetString("pokemon1Ability_cmb.Items242"), resources.GetString("pokemon1Ability_cmb.Items243"), resources.GetString("pokemon1Ability_cmb.Items244"), resources.GetString("pokemon1Ability_cmb.Items245"), resources.GetString("pokemon1Ability_cmb.Items246"), resources.GetString("pokemon1Ability_cmb.Items247"), resources.GetString("pokemon1Ability_cmb.Items248"), resources.GetString("pokemon1Ability_cmb.Items249"), resources.GetString("pokemon1Ability_cmb.Items250"), resources.GetString("pokemon1Ability_cmb.Items251"), resources.GetString("pokemon1Ability_cmb.Items252"), resources.GetString("pokemon1Ability_cmb.Items253"), resources.GetString("pokemon1Ability_cmb.Items254"), resources.GetString("pokemon1Ability_cmb.Items255"), resources.GetString("pokemon1Ability_cmb.Items256"), resources.GetString("pokemon1Ability_cmb.Items257"), resources.GetString("pokemon1Ability_cmb.Items258"), resources.GetString("pokemon1Ability_cmb.Items259"), resources.GetString("pokemon1Ability_cmb.Items260"), resources.GetString("pokemon1Ability_cmb.Items261"), resources.GetString("pokemon1Ability_cmb.Items262"), resources.GetString("pokemon1Ability_cmb.Items263"), resources.GetString("pokemon1Ability_cmb.Items264"), resources.GetString("pokemon1Ability_cmb.Items265"), resources.GetString("pokemon1Ability_cmb.Items266"), resources.GetString("pokemon1Ability_cmb.Items267"), resources.GetString("pokemon1Ability_cmb.Items268"), resources.GetString("pokemon1Ability_cmb.Items269"), resources.GetString("pokemon1Ability_cmb.Items270"), resources.GetString("pokemon1Ability_cmb.Items271"), resources.GetString("pokemon1Ability_cmb.Items272"), resources.GetString("pokemon1Ability_cmb.Items273"), resources.GetString("pokemon1Ability_cmb.Items274"), resources.GetString("pokemon1Ability_cmb.Items275"), resources.GetString("pokemon1Ability_cmb.Items276"), resources.GetString("pokemon1Ability_cmb.Items277"), resources.GetString("pokemon1Ability_cmb.Items278"), resources.GetString("pokemon1Ability_cmb.Items279"), resources.GetString("pokemon1Ability_cmb.Items280"), resources.GetString("pokemon1Ability_cmb.Items281"), resources.GetString("pokemon1Ability_cmb.Items282"), resources.GetString("pokemon1Ability_cmb.Items283"), resources.GetString("pokemon1Ability_cmb.Items284"), resources.GetString("pokemon1Ability_cmb.Items285"), resources.GetString("pokemon1Ability_cmb.Items286"), resources.GetString("pokemon1Ability_cmb.Items287"), resources.GetString("pokemon1Ability_cmb.Items288"), resources.GetString("pokemon1Ability_cmb.Items289"), resources.GetString("pokemon1Ability_cmb.Items290"), resources.GetString("pokemon1Ability_cmb.Items291"), resources.GetString("pokemon1Ability_cmb.Items292"), resources.GetString("pokemon1Ability_cmb.Items293"), resources.GetString("pokemon1Ability_cmb.Items294"), resources.GetString("pokemon1Ability_cmb.Items295"), resources.GetString("pokemon1Ability_cmb.Items296"), resources.GetString("pokemon1Ability_cmb.Items297"), resources.GetString("pokemon1Ability_cmb.Items298"), resources.GetString("pokemon1Ability_cmb.Items299"), resources.GetString("pokemon1Ability_cmb.Items300"), resources.GetString("pokemon1Ability_cmb.Items301"), resources.GetString("pokemon1Ability_cmb.Items302"), resources.GetString("pokemon1Ability_cmb.Items303"), resources.GetString("pokemon1Ability_cmb.Items304")})
        resources.ApplyResources(pokemon1Ability_cmb, "pokemon1Ability_cmb")
        pokemon1Ability_cmb.Name = "pokemon1Ability_cmb"
        ' 
        ' pokemon1Ability_lbl
        ' 
        resources.ApplyResources(pokemon1Ability_lbl, "pokemon1Ability_lbl")
        pokemon1Ability_lbl.Name = "pokemon1Ability_lbl"
        ' 
        ' pokemon1Moves_grp
        ' 
        pokemon1Moves_grp.Controls.Add(pokemon1Move4_txtBox)
        pokemon1Moves_grp.Controls.Add(pokemon1Move3_txtBox)
        pokemon1Moves_grp.Controls.Add(pokemon1Move2_txtBox)
        pokemon1Moves_grp.Controls.Add(pokemon1Move1_txtBox)
        resources.ApplyResources(pokemon1Moves_grp, "pokemon1Moves_grp")
        pokemon1Moves_grp.Name = "pokemon1Moves_grp"
        pokemon1Moves_grp.TabStop = False
        ' 
        ' pokemon1Move4_txtBox
        ' 
        resources.ApplyResources(pokemon1Move4_txtBox, "pokemon1Move4_txtBox")
        pokemon1Move4_txtBox.Name = "pokemon1Move4_txtBox"
        ' 
        ' pokemon1Move3_txtBox
        ' 
        resources.ApplyResources(pokemon1Move3_txtBox, "pokemon1Move3_txtBox")
        pokemon1Move3_txtBox.Name = "pokemon1Move3_txtBox"
        ' 
        ' pokemon1Move2_txtBox
        ' 
        resources.ApplyResources(pokemon1Move2_txtBox, "pokemon1Move2_txtBox")
        pokemon1Move2_txtBox.Name = "pokemon1Move2_txtBox"
        ' 
        ' pokemon1Move1_txtBox
        ' 
        resources.ApplyResources(pokemon1Move1_txtBox, "pokemon1Move1_txtBox")
        pokemon1Move1_txtBox.Name = "pokemon1Move1_txtBox"
        ' 
        ' pokemon1Level_lbl
        ' 
        resources.ApplyResources(pokemon1Level_lbl, "pokemon1Level_lbl")
        pokemon1Level_lbl.Name = "pokemon1Level_lbl"
        ' 
        ' pokemon1HeldItem_lbl
        ' 
        resources.ApplyResources(pokemon1HeldItem_lbl, "pokemon1HeldItem_lbl")
        pokemon1HeldItem_lbl.Name = "pokemon1HeldItem_lbl"
        ' 
        ' pokemon1HeldItem_txtBox
        ' 
        resources.ApplyResources(pokemon1HeldItem_txtBox, "pokemon1HeldItem_txtBox")
        pokemon1HeldItem_txtBox.Name = "pokemon1HeldItem_txtBox"
        ' 
        ' pokemon1Name_txtBox
        ' 
        pokemon1Name_txtBox.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource1"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource2"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource3"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource4"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource5"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource6"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource7"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource8"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource9"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource10"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource11"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource12"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource13"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource14"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource15"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource16"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource17"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource18"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource19"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource20"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource21"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource22"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource23"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource24"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource25"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource26"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource27"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource28"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource29"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource30"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource31"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource32"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource33"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource34"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource35"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource36"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource37"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource38"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource39"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource40"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource41"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource42"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource43"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource44"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource45"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource46"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource47"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource48"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource49"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource50"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource51"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource52"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource53"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource54"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource55"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource56"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource57"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource58"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource59"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource60"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource61"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource62"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource63"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource64"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource65"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource66"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource67"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource68"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource69"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource70"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource71"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource72"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource73"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource74"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource75"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource76"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource77"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource78"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource79"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource80"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource81"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource82"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource83"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource84"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource85"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource86"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource87"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource88"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource89"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource90"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource91"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource92"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource93"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource94"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource95"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource96"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource97"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource98"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource99"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource100"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource101"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource102"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource103"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource104"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource105"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource106"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource107"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource108"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource109"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource110"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource111"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource112"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource113"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource114"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource115"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource116"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource117"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource118"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource119"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource120"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource121"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource122"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource123"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource124"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource125"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource126"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource127"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource128"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource129"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource130"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource131"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource132"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource133"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource134"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource135"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource136"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource137"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource138"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource139"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource140"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource141"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource142"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource143"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource144"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource145"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource146"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource147"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource148"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource149"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource150"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource151"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource152"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource153"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource154"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource155"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource156"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource157"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource158"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource159"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource160"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource161"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource162"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource163"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource164"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource165"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource166"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource167"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource168"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource169"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource170"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource171"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource172"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource173"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource174"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource175"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource176"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource177"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource178"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource179"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource180"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource181"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource182"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource183"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource184"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource185"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource186"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource187"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource188"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource189"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource190"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource191"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource192"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource193"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource194"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource195"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource196"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource197"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource198"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource199"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource200"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource201"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource202"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource203"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource204"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource205"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource206"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource207"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource208"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource209"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource210"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource211"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource212"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource213"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource214"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource215"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource216"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource217"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource218"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource219"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource220"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource221"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource222"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource223"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource224"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource225"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource226"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource227"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource228"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource229"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource230"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource231"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource232"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource233"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource234"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource235"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource236"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource237"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource238"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource239"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource240"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource241"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource242"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource243"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource244"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource245"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource246"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource247"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource248"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource249"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource250"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource251"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource252"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource253"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource254"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource255"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource256"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource257"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource258"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource259"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource260"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource261"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource262"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource263"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource264"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource265"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource266"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource267"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource268"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource269"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource270"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource271"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource272"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource273"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource274"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource275"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource276"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource277"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource278"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource279"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource280"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource281"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource282"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource283"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource284"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource285"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource286"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource287"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource288"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource289"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource290"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource291"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource292"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource293"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource294"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource295"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource296"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource297"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource298"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource299"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource300"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource301"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource302"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource303"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource304"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource305"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource306"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource307"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource308"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource309"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource310"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource311"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource312"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource313"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource314"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource315"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource316"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource317"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource318"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource319"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource320"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource321"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource322"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource323"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource324"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource325"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource326"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource327"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource328"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource329"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource330"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource331"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource332"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource333"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource334"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource335"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource336"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource337"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource338"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource339"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource340"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource341"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource342"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource343"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource344"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource345"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource346"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource347"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource348"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource349"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource350"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource351"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource352"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource353"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource354"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource355"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource356"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource357"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource358"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource359"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource360"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource361"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource362"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource363"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource364"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource365"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource366"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource367"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource368"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource369"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource370"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource371"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource372"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource373"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource374"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource375"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource376"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource377"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource378"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource379"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource380"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource381"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource382"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource383"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource384"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource385"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource386"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource387"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource388"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource389"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource390"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource391"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource392"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource393"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource394"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource395"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource396"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource397"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource398"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource399"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource400"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource401"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource402"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource403"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource404"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource405"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource406"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource407"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource408"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource409"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource410"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource411"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource412"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource413"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource414"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource415"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource416"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource417"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource418"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource419"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource420"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource421"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource422"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource423"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource424"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource425"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource426"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource427"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource428"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource429"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource430"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource431"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource432"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource433"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource434"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource435"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource436"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource437"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource438"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource439"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource440"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource441"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource442"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource443"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource444"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource445"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource446"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource447"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource448"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource449"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource450"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource451"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource452"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource453"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource454"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource455"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource456"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource457"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource458"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource459"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource460"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource461"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource462"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource463"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource464"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource465"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource466"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource467"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource468"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource469"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource470"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource471"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource472"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource473"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource474"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource475"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource476"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource477"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource478"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource479"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource480"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource481"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource482"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource483"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource484"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource485"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource486"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource487"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource488"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource489"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource490"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource491"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource492"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource493"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource494"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource495"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource496"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource497"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource498"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource499"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource500"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource501"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource502"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource503"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource504"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource505"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource506"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource507"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource508"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource509"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource510"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource511"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource512"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource513"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource514"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource515"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource516"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource517"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource518"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource519"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource520"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource521"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource522"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource523"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource524"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource525"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource526"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource527"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource528"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource529"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource530"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource531"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource532"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource533"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource534"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource535"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource536"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource537"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource538"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource539"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource540"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource541"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource542"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource543"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource544"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource545"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource546"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource547"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource548"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource549"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource550"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource551"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource552"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource553"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource554"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource555"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource556"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource557"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource558"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource559"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource560"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource561"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource562"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource563"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource564"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource565"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource566"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource567"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource568"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource569"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource570"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource571"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource572"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource573"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource574"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource575"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource576"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource577"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource578"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource579"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource580"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource581"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource582"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource583"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource584"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource585"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource586"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource587"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource588"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource589"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource590"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource591"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource592"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource593"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource594"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource595"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource596"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource597"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource598"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource599"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource600"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource601"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource602"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource603"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource604"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource605"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource606"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource607"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource608"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource609"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource610"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource611"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource612"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource613"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource614"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource615"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource616"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource617"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource618"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource619"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource620"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource621"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource622"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource623"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource624"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource625"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource626"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource627"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource628"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource629"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource630"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource631"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource632"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource633"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource634"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource635"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource636"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource637"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource638"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource639"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource640"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource641"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource642"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource643"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource644"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource645"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource646"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource647"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource648"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource649"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource650"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource651"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource652"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource653"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource654"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource655"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource656"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource657"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource658"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource659"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource660"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource661"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource662"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource663"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource664"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource665"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource666"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource667"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource668"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource669"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource670"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource671"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource672"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource673"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource674"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource675"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource676"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource677"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource678"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource679"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource680"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource681"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource682"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource683"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource684"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource685"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource686"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource687"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource688"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource689"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource690"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource691"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource692"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource693"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource694"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource695"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource696"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource697"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource698"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource699"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource700"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource701"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource702"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource703"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource704"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource705"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource706"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource707"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource708"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource709"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource710"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource711"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource712"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource713"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource714"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource715"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource716"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource717"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource718"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource719"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource720"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource721"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource722"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource723"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource724"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource725"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource726"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource727"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource728"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource729"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource730"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource731"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource732"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource733"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource734"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource735"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource736"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource737"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource738"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource739"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource740"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource741"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource742"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource743"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource744"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource745"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource746"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource747"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource748"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource749"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource750"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource751"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource752"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource753"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource754"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource755"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource756"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource757"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource758"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource759"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource760"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource761"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource762"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource763"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource764"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource765"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource766"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource767"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource768"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource769"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource770"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource771"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource772"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource773"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource774"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource775"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource776"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource777"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource778"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource779"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource780"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource781"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource782"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource783"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource784"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource785"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource786"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource787"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource788"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource789"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource790"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource791"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource792"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource793"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource794"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource795"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource796"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource797"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource798"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource799"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource800"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource801"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource802"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource803"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource804"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource805"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource806"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource807"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource808"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource809"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource810"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource811"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource812"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource813"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource814"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource815"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource816"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource817"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource818"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource819"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource820"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource821"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource822"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource823"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource824"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource825"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource826"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource827"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource828"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource829"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource830"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource831"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource832"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource833"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource834"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource835"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource836"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource837"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource838"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource839"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource840"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource841"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource842"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource843"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource844"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource845"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource846"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource847"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource848"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource849"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource850"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource851"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource852"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource853"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource854"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource855"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource856"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource857"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource858"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource859"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource860"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource861"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource862"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource863"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource864"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource865"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource866"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource867"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource868"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource869"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource870"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource871"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource872"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource873"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource874"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource875"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource876"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource877"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource878"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource879"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource880"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource881"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource882"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource883"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource884"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource885"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource886"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource887"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource888"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource889"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource890"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource891"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource892"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource893"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource894"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource895"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource896"), resources.GetString("pokemon1Name_txtBox.AutoCompleteCustomSource897")})
        pokemon1Name_txtBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon1Name_txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        resources.ApplyResources(pokemon1Name_txtBox, "pokemon1Name_txtBox")
        pokemon1Name_txtBox.Name = "pokemon1Name_txtBox"
        ' 
        ' pokemon1Name_lbl
        ' 
        resources.ApplyResources(pokemon1Name_lbl, "pokemon1Name_lbl")
        pokemon1Name_lbl.Name = "pokemon1Name_lbl"
        ' 
        ' pg_pkmn2
        ' 
        pg_pkmn2.Controls.Add(pokemon2_grp)
        resources.ApplyResources(pg_pkmn2, "pg_pkmn2")
        pg_pkmn2.Name = "pg_pkmn2"
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
        resources.ApplyResources(pokemon2_grp, "pokemon2_grp")
        pokemon2_grp.Name = "pokemon2_grp"
        pokemon2_grp.TabStop = False
        ' 
        ' pokemon2Level_nbr
        ' 
        resources.ApplyResources(pokemon2Level_nbr, "pokemon2Level_nbr")
        pokemon2Level_nbr.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        pokemon2Level_nbr.Name = "pokemon2Level_nbr"
        pokemon2Level_nbr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' pokemon2Form_nbr
        ' 
        resources.ApplyResources(pokemon2Form_nbr, "pokemon2Form_nbr")
        pokemon2Form_nbr.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        pokemon2Form_nbr.Name = "pokemon2Form_nbr"
        ' 
        ' pokemon2Happiness_nbr
        ' 
        resources.ApplyResources(pokemon2Happiness_nbr, "pokemon2Happiness_nbr")
        pokemon2Happiness_nbr.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        pokemon2Happiness_nbr.Name = "pokemon2Happiness_nbr"
        pokemon2Happiness_nbr.Value = New Decimal(New Integer() {70, 0, 0, 0})
        ' 
        ' pokemon2Shadow_grp
        ' 
        pokemon2Shadow_grp.Controls.Add(pokemon2Shadow_rad)
        pokemon2Shadow_grp.Controls.Add(pokemon2NotShadow_rad)
        resources.ApplyResources(pokemon2Shadow_grp, "pokemon2Shadow_grp")
        pokemon2Shadow_grp.Name = "pokemon2Shadow_grp"
        pokemon2Shadow_grp.TabStop = False
        ' 
        ' pokemon2Shadow_rad
        ' 
        resources.ApplyResources(pokemon2Shadow_rad, "pokemon2Shadow_rad")
        pokemon2Shadow_rad.Name = "pokemon2Shadow_rad"
        pokemon2Shadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon2NotShadow_rad
        ' 
        resources.ApplyResources(pokemon2NotShadow_rad, "pokemon2NotShadow_rad")
        pokemon2NotShadow_rad.Checked = True
        pokemon2NotShadow_rad.Name = "pokemon2NotShadow_rad"
        pokemon2NotShadow_rad.TabStop = True
        pokemon2NotShadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon2Name_lbl
        ' 
        resources.ApplyResources(pokemon2Name_lbl, "pokemon2Name_lbl")
        pokemon2Name_lbl.Name = "pokemon2Name_lbl"
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
        resources.ApplyResources(pokemon2EVs_grp, "pokemon2EVs_grp")
        pokemon2EVs_grp.Name = "pokemon2EVs_grp"
        pokemon2EVs_grp.TabStop = False
        ' 
        ' pokemon2EVsDEF_txt
        ' 
        resources.ApplyResources(pokemon2EVsDEF_txt, "pokemon2EVsDEF_txt")
        pokemon2EVsDEF_txt.Name = "pokemon2EVsDEF_txt"
        ' 
        ' pokemon2EVsDEF_lbl
        ' 
        resources.ApplyResources(pokemon2EVsDEF_lbl, "pokemon2EVsDEF_lbl")
        pokemon2EVsDEF_lbl.Name = "pokemon2EVsDEF_lbl"
        ' 
        ' pokemon2EVsSPDEF_txt
        ' 
        resources.ApplyResources(pokemon2EVsSPDEF_txt, "pokemon2EVsSPDEF_txt")
        pokemon2EVsSPDEF_txt.Name = "pokemon2EVsSPDEF_txt"
        ' 
        ' pokemon2EVsSPDEF_lbl
        ' 
        resources.ApplyResources(pokemon2EVsSPDEF_lbl, "pokemon2EVsSPDEF_lbl")
        pokemon2EVsSPDEF_lbl.Name = "pokemon2EVsSPDEF_lbl"
        ' 
        ' pokemon2EVsSPATK_txt
        ' 
        resources.ApplyResources(pokemon2EVsSPATK_txt, "pokemon2EVsSPATK_txt")
        pokemon2EVsSPATK_txt.Name = "pokemon2EVsSPATK_txt"
        ' 
        ' pokemon2EVsSPATK_lbl
        ' 
        resources.ApplyResources(pokemon2EVsSPATK_lbl, "pokemon2EVsSPATK_lbl")
        pokemon2EVsSPATK_lbl.Name = "pokemon2EVsSPATK_lbl"
        ' 
        ' pokemon2EVsSPD_txt
        ' 
        resources.ApplyResources(pokemon2EVsSPD_txt, "pokemon2EVsSPD_txt")
        pokemon2EVsSPD_txt.Name = "pokemon2EVsSPD_txt"
        ' 
        ' pokemon2EVsSPD_lbl
        ' 
        resources.ApplyResources(pokemon2EVsSPD_lbl, "pokemon2EVsSPD_lbl")
        pokemon2EVsSPD_lbl.Name = "pokemon2EVsSPD_lbl"
        ' 
        ' pokemon2EVsATK_txt
        ' 
        resources.ApplyResources(pokemon2EVsATK_txt, "pokemon2EVsATK_txt")
        pokemon2EVsATK_txt.Name = "pokemon2EVsATK_txt"
        ' 
        ' pokemon2EVsATK_lbl
        ' 
        resources.ApplyResources(pokemon2EVsATK_lbl, "pokemon2EVsATK_lbl")
        pokemon2EVsATK_lbl.Name = "pokemon2EVsATK_lbl"
        ' 
        ' pokemon2EVsHP_txt
        ' 
        resources.ApplyResources(pokemon2EVsHP_txt, "pokemon2EVsHP_txt")
        pokemon2EVsHP_txt.Name = "pokemon2EVsHP_txt"
        ' 
        ' pokemon2EVsHP_lbl
        ' 
        resources.ApplyResources(pokemon2EVsHP_lbl, "pokemon2EVsHP_lbl")
        pokemon2EVsHP_lbl.Name = "pokemon2EVsHP_lbl"
        ' 
        ' pokemon2Name_txt
        ' 
        pokemon2Name_txt.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource1"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource2"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource3"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource4"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource5"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource6"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource7"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource8"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource9"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource10"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource11"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource12"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource13"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource14"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource15"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource16"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource17"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource18"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource19"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource20"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource21"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource22"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource23"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource24"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource25"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource26"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource27"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource28"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource29"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource30"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource31"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource32"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource33"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource34"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource35"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource36"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource37"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource38"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource39"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource40"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource41"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource42"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource43"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource44"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource45"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource46"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource47"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource48"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource49"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource50"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource51"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource52"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource53"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource54"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource55"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource56"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource57"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource58"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource59"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource60"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource61"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource62"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource63"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource64"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource65"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource66"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource67"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource68"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource69"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource70"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource71"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource72"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource73"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource74"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource75"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource76"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource77"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource78"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource79"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource80"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource81"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource82"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource83"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource84"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource85"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource86"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource87"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource88"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource89"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource90"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource91"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource92"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource93"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource94"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource95"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource96"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource97"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource98"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource99"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource100"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource101"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource102"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource103"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource104"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource105"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource106"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource107"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource108"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource109"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource110"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource111"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource112"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource113"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource114"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource115"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource116"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource117"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource118"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource119"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource120"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource121"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource122"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource123"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource124"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource125"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource126"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource127"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource128"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource129"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource130"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource131"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource132"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource133"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource134"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource135"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource136"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource137"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource138"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource139"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource140"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource141"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource142"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource143"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource144"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource145"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource146"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource147"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource148"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource149"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource150"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource151"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource152"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource153"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource154"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource155"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource156"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource157"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource158"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource159"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource160"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource161"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource162"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource163"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource164"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource165"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource166"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource167"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource168"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource169"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource170"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource171"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource172"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource173"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource174"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource175"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource176"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource177"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource178"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource179"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource180"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource181"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource182"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource183"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource184"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource185"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource186"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource187"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource188"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource189"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource190"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource191"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource192"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource193"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource194"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource195"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource196"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource197"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource198"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource199"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource200"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource201"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource202"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource203"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource204"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource205"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource206"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource207"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource208"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource209"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource210"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource211"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource212"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource213"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource214"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource215"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource216"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource217"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource218"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource219"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource220"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource221"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource222"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource223"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource224"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource225"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource226"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource227"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource228"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource229"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource230"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource231"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource232"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource233"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource234"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource235"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource236"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource237"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource238"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource239"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource240"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource241"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource242"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource243"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource244"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource245"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource246"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource247"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource248"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource249"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource250"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource251"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource252"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource253"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource254"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource255"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource256"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource257"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource258"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource259"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource260"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource261"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource262"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource263"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource264"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource265"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource266"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource267"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource268"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource269"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource270"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource271"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource272"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource273"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource274"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource275"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource276"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource277"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource278"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource279"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource280"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource281"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource282"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource283"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource284"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource285"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource286"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource287"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource288"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource289"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource290"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource291"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource292"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource293"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource294"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource295"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource296"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource297"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource298"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource299"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource300"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource301"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource302"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource303"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource304"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource305"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource306"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource307"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource308"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource309"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource310"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource311"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource312"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource313"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource314"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource315"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource316"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource317"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource318"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource319"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource320"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource321"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource322"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource323"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource324"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource325"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource326"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource327"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource328"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource329"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource330"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource331"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource332"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource333"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource334"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource335"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource336"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource337"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource338"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource339"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource340"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource341"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource342"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource343"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource344"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource345"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource346"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource347"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource348"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource349"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource350"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource351"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource352"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource353"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource354"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource355"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource356"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource357"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource358"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource359"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource360"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource361"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource362"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource363"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource364"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource365"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource366"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource367"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource368"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource369"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource370"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource371"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource372"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource373"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource374"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource375"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource376"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource377"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource378"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource379"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource380"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource381"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource382"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource383"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource384"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource385"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource386"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource387"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource388"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource389"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource390"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource391"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource392"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource393"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource394"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource395"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource396"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource397"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource398"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource399"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource400"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource401"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource402"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource403"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource404"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource405"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource406"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource407"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource408"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource409"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource410"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource411"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource412"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource413"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource414"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource415"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource416"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource417"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource418"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource419"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource420"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource421"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource422"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource423"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource424"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource425"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource426"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource427"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource428"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource429"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource430"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource431"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource432"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource433"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource434"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource435"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource436"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource437"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource438"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource439"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource440"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource441"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource442"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource443"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource444"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource445"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource446"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource447"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource448"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource449"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource450"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource451"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource452"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource453"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource454"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource455"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource456"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource457"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource458"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource459"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource460"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource461"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource462"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource463"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource464"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource465"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource466"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource467"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource468"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource469"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource470"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource471"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource472"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource473"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource474"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource475"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource476"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource477"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource478"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource479"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource480"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource481"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource482"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource483"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource484"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource485"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource486"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource487"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource488"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource489"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource490"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource491"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource492"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource493"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource494"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource495"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource496"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource497"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource498"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource499"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource500"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource501"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource502"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource503"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource504"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource505"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource506"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource507"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource508"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource509"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource510"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource511"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource512"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource513"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource514"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource515"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource516"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource517"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource518"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource519"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource520"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource521"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource522"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource523"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource524"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource525"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource526"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource527"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource528"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource529"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource530"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource531"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource532"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource533"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource534"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource535"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource536"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource537"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource538"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource539"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource540"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource541"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource542"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource543"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource544"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource545"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource546"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource547"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource548"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource549"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource550"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource551"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource552"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource553"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource554"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource555"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource556"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource557"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource558"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource559"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource560"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource561"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource562"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource563"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource564"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource565"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource566"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource567"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource568"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource569"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource570"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource571"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource572"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource573"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource574"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource575"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource576"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource577"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource578"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource579"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource580"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource581"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource582"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource583"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource584"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource585"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource586"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource587"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource588"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource589"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource590"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource591"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource592"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource593"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource594"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource595"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource596"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource597"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource598"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource599"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource600"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource601"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource602"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource603"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource604"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource605"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource606"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource607"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource608"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource609"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource610"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource611"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource612"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource613"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource614"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource615"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource616"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource617"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource618"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource619"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource620"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource621"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource622"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource623"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource624"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource625"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource626"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource627"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource628"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource629"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource630"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource631"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource632"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource633"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource634"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource635"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource636"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource637"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource638"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource639"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource640"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource641"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource642"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource643"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource644"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource645"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource646"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource647"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource648"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource649"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource650"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource651"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource652"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource653"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource654"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource655"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource656"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource657"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource658"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource659"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource660"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource661"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource662"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource663"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource664"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource665"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource666"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource667"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource668"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource669"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource670"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource671"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource672"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource673"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource674"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource675"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource676"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource677"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource678"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource679"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource680"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource681"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource682"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource683"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource684"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource685"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource686"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource687"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource688"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource689"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource690"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource691"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource692"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource693"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource694"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource695"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource696"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource697"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource698"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource699"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource700"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource701"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource702"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource703"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource704"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource705"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource706"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource707"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource708"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource709"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource710"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource711"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource712"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource713"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource714"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource715"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource716"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource717"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource718"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource719"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource720"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource721"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource722"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource723"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource724"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource725"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource726"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource727"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource728"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource729"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource730"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource731"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource732"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource733"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource734"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource735"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource736"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource737"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource738"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource739"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource740"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource741"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource742"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource743"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource744"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource745"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource746"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource747"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource748"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource749"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource750"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource751"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource752"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource753"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource754"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource755"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource756"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource757"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource758"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource759"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource760"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource761"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource762"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource763"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource764"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource765"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource766"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource767"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource768"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource769"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource770"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource771"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource772"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource773"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource774"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource775"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource776"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource777"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource778"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource779"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource780"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource781"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource782"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource783"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource784"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource785"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource786"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource787"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource788"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource789"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource790"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource791"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource792"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource793"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource794"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource795"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource796"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource797"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource798"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource799"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource800"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource801"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource802"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource803"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource804"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource805"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource806"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource807"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource808"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource809"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource810"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource811"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource812"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource813"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource814"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource815"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource816"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource817"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource818"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource819"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource820"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource821"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource822"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource823"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource824"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource825"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource826"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource827"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource828"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource829"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource830"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource831"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource832"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource833"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource834"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource835"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource836"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource837"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource838"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource839"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource840"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource841"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource842"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource843"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource844"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource845"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource846"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource847"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource848"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource849"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource850"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource851"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource852"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource853"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource854"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource855"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource856"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource857"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource858"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource859"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource860"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource861"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource862"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource863"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource864"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource865"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource866"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource867"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource868"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource869"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource870"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource871"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource872"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource873"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource874"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource875"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource876"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource877"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource878"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource879"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource880"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource881"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource882"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource883"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource884"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource885"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource886"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource887"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource888"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource889"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource890"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource891"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource892"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource893"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource894"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource895"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource896"), resources.GetString("pokemon2Name_txt.AutoCompleteCustomSource897")})
        pokemon2Name_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon2Name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource
        resources.ApplyResources(pokemon2Name_txt, "pokemon2Name_txt")
        pokemon2Name_txt.Name = "pokemon2Name_txt"
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
        resources.ApplyResources(pokemon2IVs_grp, "pokemon2IVs_grp")
        pokemon2IVs_grp.Name = "pokemon2IVs_grp"
        pokemon2IVs_grp.TabStop = False
        ' 
        ' pokemon2RandomIVs_btn
        ' 
        resources.ApplyResources(pokemon2RandomIVs_btn, "pokemon2RandomIVs_btn")
        pokemon2RandomIVs_btn.Name = "pokemon2RandomIVs_btn"
        pokemon2RandomIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon2MaxIVs_btn
        ' 
        resources.ApplyResources(pokemon2MaxIVs_btn, "pokemon2MaxIVs_btn")
        pokemon2MaxIVs_btn.Name = "pokemon2MaxIVs_btn"
        pokemon2MaxIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon2IVsDEF_txt
        ' 
        resources.ApplyResources(pokemon2IVsDEF_txt, "pokemon2IVsDEF_txt")
        pokemon2IVsDEF_txt.Name = "pokemon2IVsDEF_txt"
        ' 
        ' pokemon2IVsDEF_lbl
        ' 
        resources.ApplyResources(pokemon2IVsDEF_lbl, "pokemon2IVsDEF_lbl")
        pokemon2IVsDEF_lbl.Name = "pokemon2IVsDEF_lbl"
        ' 
        ' pokemon2IVsSPDEF_txt
        ' 
        resources.ApplyResources(pokemon2IVsSPDEF_txt, "pokemon2IVsSPDEF_txt")
        pokemon2IVsSPDEF_txt.Name = "pokemon2IVsSPDEF_txt"
        ' 
        ' pokemon2IVsSPDEF_lbl
        ' 
        resources.ApplyResources(pokemon2IVsSPDEF_lbl, "pokemon2IVsSPDEF_lbl")
        pokemon2IVsSPDEF_lbl.Name = "pokemon2IVsSPDEF_lbl"
        ' 
        ' pokemon2IVsSPATK_txt
        ' 
        resources.ApplyResources(pokemon2IVsSPATK_txt, "pokemon2IVsSPATK_txt")
        pokemon2IVsSPATK_txt.Name = "pokemon2IVsSPATK_txt"
        ' 
        ' pokemon2IVsSPATK_lbl
        ' 
        resources.ApplyResources(pokemon2IVsSPATK_lbl, "pokemon2IVsSPATK_lbl")
        pokemon2IVsSPATK_lbl.Name = "pokemon2IVsSPATK_lbl"
        ' 
        ' pokemon2IVsSPD_txt
        ' 
        resources.ApplyResources(pokemon2IVsSPD_txt, "pokemon2IVsSPD_txt")
        pokemon2IVsSPD_txt.Name = "pokemon2IVsSPD_txt"
        ' 
        ' pokemon2IVsSPD_lbl
        ' 
        resources.ApplyResources(pokemon2IVsSPD_lbl, "pokemon2IVsSPD_lbl")
        pokemon2IVsSPD_lbl.Name = "pokemon2IVsSPD_lbl"
        ' 
        ' pokemon2IVsATK_txt
        ' 
        resources.ApplyResources(pokemon2IVsATK_txt, "pokemon2IVsATK_txt")
        pokemon2IVsATK_txt.Name = "pokemon2IVsATK_txt"
        ' 
        ' pokemon2IVsATK_lbl
        ' 
        resources.ApplyResources(pokemon2IVsATK_lbl, "pokemon2IVsATK_lbl")
        pokemon2IVsATK_lbl.Name = "pokemon2IVsATK_lbl"
        ' 
        ' pokemon2IVsHP_txt
        ' 
        resources.ApplyResources(pokemon2IVsHP_txt, "pokemon2IVsHP_txt")
        pokemon2IVsHP_txt.Name = "pokemon2IVsHP_txt"
        ' 
        ' pokemon2IVsHP_lbl
        ' 
        resources.ApplyResources(pokemon2IVsHP_lbl, "pokemon2IVsHP_lbl")
        pokemon2IVsHP_lbl.Name = "pokemon2IVsHP_lbl"
        ' 
        ' pokemon2HeldItem_txt
        ' 
        resources.ApplyResources(pokemon2HeldItem_txt, "pokemon2HeldItem_txt")
        pokemon2HeldItem_txt.Name = "pokemon2HeldItem_txt"
        ' 
        ' pokemon2PokeballID_cmb
        ' 
        pokemon2PokeballID_cmb.FormattingEnabled = True
        pokemon2PokeballID_cmb.Items.AddRange(New Object() {resources.GetString("pokemon2PokeballID_cmb.Items"), resources.GetString("pokemon2PokeballID_cmb.Items1"), resources.GetString("pokemon2PokeballID_cmb.Items2"), resources.GetString("pokemon2PokeballID_cmb.Items3"), resources.GetString("pokemon2PokeballID_cmb.Items4"), resources.GetString("pokemon2PokeballID_cmb.Items5"), resources.GetString("pokemon2PokeballID_cmb.Items6"), resources.GetString("pokemon2PokeballID_cmb.Items7"), resources.GetString("pokemon2PokeballID_cmb.Items8"), resources.GetString("pokemon2PokeballID_cmb.Items9"), resources.GetString("pokemon2PokeballID_cmb.Items10"), resources.GetString("pokemon2PokeballID_cmb.Items11"), resources.GetString("pokemon2PokeballID_cmb.Items12"), resources.GetString("pokemon2PokeballID_cmb.Items13"), resources.GetString("pokemon2PokeballID_cmb.Items14"), resources.GetString("pokemon2PokeballID_cmb.Items15"), resources.GetString("pokemon2PokeballID_cmb.Items16"), resources.GetString("pokemon2PokeballID_cmb.Items17"), resources.GetString("pokemon2PokeballID_cmb.Items18"), resources.GetString("pokemon2PokeballID_cmb.Items19"), resources.GetString("pokemon2PokeballID_cmb.Items20"), resources.GetString("pokemon2PokeballID_cmb.Items21"), resources.GetString("pokemon2PokeballID_cmb.Items22"), resources.GetString("pokemon2PokeballID_cmb.Items23"), resources.GetString("pokemon2PokeballID_cmb.Items24"), resources.GetString("pokemon2PokeballID_cmb.Items25")})
        resources.ApplyResources(pokemon2PokeballID_cmb, "pokemon2PokeballID_cmb")
        pokemon2PokeballID_cmb.Name = "pokemon2PokeballID_cmb"
        ' 
        ' pokemon2HeldItem_lbl
        ' 
        resources.ApplyResources(pokemon2HeldItem_lbl, "pokemon2HeldItem_lbl")
        pokemon2HeldItem_lbl.Name = "pokemon2HeldItem_lbl"
        ' 
        ' pokemon2PokeBall_lbl
        ' 
        resources.ApplyResources(pokemon2PokeBall_lbl, "pokemon2PokeBall_lbl")
        pokemon2PokeBall_lbl.Name = "pokemon2PokeBall_lbl"
        ' 
        ' pokemon2Level_lbl
        ' 
        resources.ApplyResources(pokemon2Level_lbl, "pokemon2Level_lbl")
        pokemon2Level_lbl.Name = "pokemon2Level_lbl"
        ' 
        ' pokemon2Nickname_txt
        ' 
        resources.ApplyResources(pokemon2Nickname_txt, "pokemon2Nickname_txt")
        pokemon2Nickname_txt.Name = "pokemon2Nickname_txt"
        ' 
        ' pokemon2Nickname_lbl
        ' 
        resources.ApplyResources(pokemon2Nickname_lbl, "pokemon2Nickname_lbl")
        pokemon2Nickname_lbl.Name = "pokemon2Nickname_lbl"
        ' 
        ' pokemon2Moves_grp
        ' 
        pokemon2Moves_grp.Controls.Add(pokemon2Move4_txtBox)
        pokemon2Moves_grp.Controls.Add(pokemon2Move3_txtBox)
        pokemon2Moves_grp.Controls.Add(pokemon2Move2_txtBox)
        pokemon2Moves_grp.Controls.Add(pokemon2Move1_txtBox)
        resources.ApplyResources(pokemon2Moves_grp, "pokemon2Moves_grp")
        pokemon2Moves_grp.Name = "pokemon2Moves_grp"
        pokemon2Moves_grp.TabStop = False
        ' 
        ' pokemon2Move4_txtBox
        ' 
        resources.ApplyResources(pokemon2Move4_txtBox, "pokemon2Move4_txtBox")
        pokemon2Move4_txtBox.Name = "pokemon2Move4_txtBox"
        ' 
        ' pokemon2Move3_txtBox
        ' 
        resources.ApplyResources(pokemon2Move3_txtBox, "pokemon2Move3_txtBox")
        pokemon2Move3_txtBox.Name = "pokemon2Move3_txtBox"
        ' 
        ' pokemon2Move2_txtBox
        ' 
        resources.ApplyResources(pokemon2Move2_txtBox, "pokemon2Move2_txtBox")
        pokemon2Move2_txtBox.Name = "pokemon2Move2_txtBox"
        ' 
        ' pokemon2Move1_txtBox
        ' 
        resources.ApplyResources(pokemon2Move1_txtBox, "pokemon2Move1_txtBox")
        pokemon2Move1_txtBox.Name = "pokemon2Move1_txtBox"
        ' 
        ' pokemon2Ability_lbl
        ' 
        resources.ApplyResources(pokemon2Ability_lbl, "pokemon2Ability_lbl")
        pokemon2Ability_lbl.Name = "pokemon2Ability_lbl"
        ' 
        ' pokemon2Happiness_lbl
        ' 
        resources.ApplyResources(pokemon2Happiness_lbl, "pokemon2Happiness_lbl")
        pokemon2Happiness_lbl.Name = "pokemon2Happiness_lbl"
        ' 
        ' pokemon2Ability_cmb
        ' 
        pokemon2Ability_cmb.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource1"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource2"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource3"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource4"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource5"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource6"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource7"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource8"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource9"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource10"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource11"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource12"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource13"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource14"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource15"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource16"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource17"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource18"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource19"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource20"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource21"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource22"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource23"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource24"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource25"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource26"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource27"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource28"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource29"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource30"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource31"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource32"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource33"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource34"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource35"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource36"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource37"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource38"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource39"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource40"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource41"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource42"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource43"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource44"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource45"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource46"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource47"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource48"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource49"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource50"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource51"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource52"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource53"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource54"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource55"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource56"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource57"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource58"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource59"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource60"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource61"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource62"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource63"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource64"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource65"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource66"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource67"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource68"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource69"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource70"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource71"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource72"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource73"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource74"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource75"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource76"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource77"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource78"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource79"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource80"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource81"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource82"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource83"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource84"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource85"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource86"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource87"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource88"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource89"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource90"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource91"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource92"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource93"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource94"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource95"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource96"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource97"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource98"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource99"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource100"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource101"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource102"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource103"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource104"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource105"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource106"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource107"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource108"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource109"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource110"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource111"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource112"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource113"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource114"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource115"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource116"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource117"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource118"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource119"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource120"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource121"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource122"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource123"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource124"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource125"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource126"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource127"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource128"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource129"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource130"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource131"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource132"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource133"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource134"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource135"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource136"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource137"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource138"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource139"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource140"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource141"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource142"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource143"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource144"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource145"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource146"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource147"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource148"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource149"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource150"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource151"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource152"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource153"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource154"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource155"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource156"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource157"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource158"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource159"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource160"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource161"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource162"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource163"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource164"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource165"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource166"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource167"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource168"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource169"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource170"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource171"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource172"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource173"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource174"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource175"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource176"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource177"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource178"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource179"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource180"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource181"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource182"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource183"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource184"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource185"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource186"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource187"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource188"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource189"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource190"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource191"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource192"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource193"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource194"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource195"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource196"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource197"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource198"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource199"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource200"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource201"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource202"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource203"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource204"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource205"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource206"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource207"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource208"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource209"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource210"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource211"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource212"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource213"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource214"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource215"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource216"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource217"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource218"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource219"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource220"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource221"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource222"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource223"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource224"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource225"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource226"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource227"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource228"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource229"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource230"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource231"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource232"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource233"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource234"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource235"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource236"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource237"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource238"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource239"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource240"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource241"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource242"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource243"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource244"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource245"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource246"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource247"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource248"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource249"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource250"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource251"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource252"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource253"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource254"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource255"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource256"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource257"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource258"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource259"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource260"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource261"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource262"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource263"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource264"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource265"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource266"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource267"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource268"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource269"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource270"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource271"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource272"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource273"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource274"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource275"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource276"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource277"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource278"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource279"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource280"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource281"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource282"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource283"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource284"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource285"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource286"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource287"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource288"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource289"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource290"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource291"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource292"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource293"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource294"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource295"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource296"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource297"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource298"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource299"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource300"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource301"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource302"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource303"), resources.GetString("pokemon2Ability_cmb.AutoCompleteCustomSource304")})
        pokemon2Ability_cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon2Ability_cmb.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon2Ability_cmb.FormattingEnabled = True
        pokemon2Ability_cmb.Items.AddRange(New Object() {resources.GetString("pokemon2Ability_cmb.Items"), resources.GetString("pokemon2Ability_cmb.Items1"), resources.GetString("pokemon2Ability_cmb.Items2"), resources.GetString("pokemon2Ability_cmb.Items3"), resources.GetString("pokemon2Ability_cmb.Items4"), resources.GetString("pokemon2Ability_cmb.Items5"), resources.GetString("pokemon2Ability_cmb.Items6"), resources.GetString("pokemon2Ability_cmb.Items7"), resources.GetString("pokemon2Ability_cmb.Items8"), resources.GetString("pokemon2Ability_cmb.Items9"), resources.GetString("pokemon2Ability_cmb.Items10"), resources.GetString("pokemon2Ability_cmb.Items11"), resources.GetString("pokemon2Ability_cmb.Items12"), resources.GetString("pokemon2Ability_cmb.Items13"), resources.GetString("pokemon2Ability_cmb.Items14"), resources.GetString("pokemon2Ability_cmb.Items15"), resources.GetString("pokemon2Ability_cmb.Items16"), resources.GetString("pokemon2Ability_cmb.Items17"), resources.GetString("pokemon2Ability_cmb.Items18"), resources.GetString("pokemon2Ability_cmb.Items19"), resources.GetString("pokemon2Ability_cmb.Items20"), resources.GetString("pokemon2Ability_cmb.Items21"), resources.GetString("pokemon2Ability_cmb.Items22"), resources.GetString("pokemon2Ability_cmb.Items23"), resources.GetString("pokemon2Ability_cmb.Items24"), resources.GetString("pokemon2Ability_cmb.Items25"), resources.GetString("pokemon2Ability_cmb.Items26"), resources.GetString("pokemon2Ability_cmb.Items27"), resources.GetString("pokemon2Ability_cmb.Items28"), resources.GetString("pokemon2Ability_cmb.Items29"), resources.GetString("pokemon2Ability_cmb.Items30"), resources.GetString("pokemon2Ability_cmb.Items31"), resources.GetString("pokemon2Ability_cmb.Items32"), resources.GetString("pokemon2Ability_cmb.Items33"), resources.GetString("pokemon2Ability_cmb.Items34"), resources.GetString("pokemon2Ability_cmb.Items35"), resources.GetString("pokemon2Ability_cmb.Items36"), resources.GetString("pokemon2Ability_cmb.Items37"), resources.GetString("pokemon2Ability_cmb.Items38"), resources.GetString("pokemon2Ability_cmb.Items39"), resources.GetString("pokemon2Ability_cmb.Items40"), resources.GetString("pokemon2Ability_cmb.Items41"), resources.GetString("pokemon2Ability_cmb.Items42"), resources.GetString("pokemon2Ability_cmb.Items43"), resources.GetString("pokemon2Ability_cmb.Items44"), resources.GetString("pokemon2Ability_cmb.Items45"), resources.GetString("pokemon2Ability_cmb.Items46"), resources.GetString("pokemon2Ability_cmb.Items47"), resources.GetString("pokemon2Ability_cmb.Items48"), resources.GetString("pokemon2Ability_cmb.Items49"), resources.GetString("pokemon2Ability_cmb.Items50"), resources.GetString("pokemon2Ability_cmb.Items51"), resources.GetString("pokemon2Ability_cmb.Items52"), resources.GetString("pokemon2Ability_cmb.Items53"), resources.GetString("pokemon2Ability_cmb.Items54"), resources.GetString("pokemon2Ability_cmb.Items55"), resources.GetString("pokemon2Ability_cmb.Items56"), resources.GetString("pokemon2Ability_cmb.Items57"), resources.GetString("pokemon2Ability_cmb.Items58"), resources.GetString("pokemon2Ability_cmb.Items59"), resources.GetString("pokemon2Ability_cmb.Items60"), resources.GetString("pokemon2Ability_cmb.Items61"), resources.GetString("pokemon2Ability_cmb.Items62"), resources.GetString("pokemon2Ability_cmb.Items63"), resources.GetString("pokemon2Ability_cmb.Items64"), resources.GetString("pokemon2Ability_cmb.Items65"), resources.GetString("pokemon2Ability_cmb.Items66"), resources.GetString("pokemon2Ability_cmb.Items67"), resources.GetString("pokemon2Ability_cmb.Items68"), resources.GetString("pokemon2Ability_cmb.Items69"), resources.GetString("pokemon2Ability_cmb.Items70"), resources.GetString("pokemon2Ability_cmb.Items71"), resources.GetString("pokemon2Ability_cmb.Items72"), resources.GetString("pokemon2Ability_cmb.Items73"), resources.GetString("pokemon2Ability_cmb.Items74"), resources.GetString("pokemon2Ability_cmb.Items75"), resources.GetString("pokemon2Ability_cmb.Items76"), resources.GetString("pokemon2Ability_cmb.Items77"), resources.GetString("pokemon2Ability_cmb.Items78"), resources.GetString("pokemon2Ability_cmb.Items79"), resources.GetString("pokemon2Ability_cmb.Items80"), resources.GetString("pokemon2Ability_cmb.Items81"), resources.GetString("pokemon2Ability_cmb.Items82"), resources.GetString("pokemon2Ability_cmb.Items83"), resources.GetString("pokemon2Ability_cmb.Items84"), resources.GetString("pokemon2Ability_cmb.Items85"), resources.GetString("pokemon2Ability_cmb.Items86"), resources.GetString("pokemon2Ability_cmb.Items87"), resources.GetString("pokemon2Ability_cmb.Items88"), resources.GetString("pokemon2Ability_cmb.Items89"), resources.GetString("pokemon2Ability_cmb.Items90"), resources.GetString("pokemon2Ability_cmb.Items91"), resources.GetString("pokemon2Ability_cmb.Items92"), resources.GetString("pokemon2Ability_cmb.Items93"), resources.GetString("pokemon2Ability_cmb.Items94"), resources.GetString("pokemon2Ability_cmb.Items95"), resources.GetString("pokemon2Ability_cmb.Items96"), resources.GetString("pokemon2Ability_cmb.Items97"), resources.GetString("pokemon2Ability_cmb.Items98"), resources.GetString("pokemon2Ability_cmb.Items99"), resources.GetString("pokemon2Ability_cmb.Items100"), resources.GetString("pokemon2Ability_cmb.Items101"), resources.GetString("pokemon2Ability_cmb.Items102"), resources.GetString("pokemon2Ability_cmb.Items103"), resources.GetString("pokemon2Ability_cmb.Items104"), resources.GetString("pokemon2Ability_cmb.Items105"), resources.GetString("pokemon2Ability_cmb.Items106"), resources.GetString("pokemon2Ability_cmb.Items107"), resources.GetString("pokemon2Ability_cmb.Items108"), resources.GetString("pokemon2Ability_cmb.Items109"), resources.GetString("pokemon2Ability_cmb.Items110"), resources.GetString("pokemon2Ability_cmb.Items111"), resources.GetString("pokemon2Ability_cmb.Items112"), resources.GetString("pokemon2Ability_cmb.Items113"), resources.GetString("pokemon2Ability_cmb.Items114"), resources.GetString("pokemon2Ability_cmb.Items115"), resources.GetString("pokemon2Ability_cmb.Items116"), resources.GetString("pokemon2Ability_cmb.Items117"), resources.GetString("pokemon2Ability_cmb.Items118"), resources.GetString("pokemon2Ability_cmb.Items119"), resources.GetString("pokemon2Ability_cmb.Items120"), resources.GetString("pokemon2Ability_cmb.Items121"), resources.GetString("pokemon2Ability_cmb.Items122"), resources.GetString("pokemon2Ability_cmb.Items123"), resources.GetString("pokemon2Ability_cmb.Items124"), resources.GetString("pokemon2Ability_cmb.Items125"), resources.GetString("pokemon2Ability_cmb.Items126"), resources.GetString("pokemon2Ability_cmb.Items127"), resources.GetString("pokemon2Ability_cmb.Items128"), resources.GetString("pokemon2Ability_cmb.Items129"), resources.GetString("pokemon2Ability_cmb.Items130"), resources.GetString("pokemon2Ability_cmb.Items131"), resources.GetString("pokemon2Ability_cmb.Items132"), resources.GetString("pokemon2Ability_cmb.Items133"), resources.GetString("pokemon2Ability_cmb.Items134"), resources.GetString("pokemon2Ability_cmb.Items135"), resources.GetString("pokemon2Ability_cmb.Items136"), resources.GetString("pokemon2Ability_cmb.Items137"), resources.GetString("pokemon2Ability_cmb.Items138"), resources.GetString("pokemon2Ability_cmb.Items139"), resources.GetString("pokemon2Ability_cmb.Items140"), resources.GetString("pokemon2Ability_cmb.Items141"), resources.GetString("pokemon2Ability_cmb.Items142"), resources.GetString("pokemon2Ability_cmb.Items143"), resources.GetString("pokemon2Ability_cmb.Items144"), resources.GetString("pokemon2Ability_cmb.Items145"), resources.GetString("pokemon2Ability_cmb.Items146"), resources.GetString("pokemon2Ability_cmb.Items147"), resources.GetString("pokemon2Ability_cmb.Items148"), resources.GetString("pokemon2Ability_cmb.Items149"), resources.GetString("pokemon2Ability_cmb.Items150"), resources.GetString("pokemon2Ability_cmb.Items151"), resources.GetString("pokemon2Ability_cmb.Items152"), resources.GetString("pokemon2Ability_cmb.Items153"), resources.GetString("pokemon2Ability_cmb.Items154"), resources.GetString("pokemon2Ability_cmb.Items155"), resources.GetString("pokemon2Ability_cmb.Items156"), resources.GetString("pokemon2Ability_cmb.Items157"), resources.GetString("pokemon2Ability_cmb.Items158"), resources.GetString("pokemon2Ability_cmb.Items159"), resources.GetString("pokemon2Ability_cmb.Items160"), resources.GetString("pokemon2Ability_cmb.Items161"), resources.GetString("pokemon2Ability_cmb.Items162"), resources.GetString("pokemon2Ability_cmb.Items163"), resources.GetString("pokemon2Ability_cmb.Items164"), resources.GetString("pokemon2Ability_cmb.Items165"), resources.GetString("pokemon2Ability_cmb.Items166"), resources.GetString("pokemon2Ability_cmb.Items167"), resources.GetString("pokemon2Ability_cmb.Items168"), resources.GetString("pokemon2Ability_cmb.Items169"), resources.GetString("pokemon2Ability_cmb.Items170"), resources.GetString("pokemon2Ability_cmb.Items171"), resources.GetString("pokemon2Ability_cmb.Items172"), resources.GetString("pokemon2Ability_cmb.Items173"), resources.GetString("pokemon2Ability_cmb.Items174"), resources.GetString("pokemon2Ability_cmb.Items175"), resources.GetString("pokemon2Ability_cmb.Items176"), resources.GetString("pokemon2Ability_cmb.Items177"), resources.GetString("pokemon2Ability_cmb.Items178"), resources.GetString("pokemon2Ability_cmb.Items179"), resources.GetString("pokemon2Ability_cmb.Items180"), resources.GetString("pokemon2Ability_cmb.Items181"), resources.GetString("pokemon2Ability_cmb.Items182"), resources.GetString("pokemon2Ability_cmb.Items183"), resources.GetString("pokemon2Ability_cmb.Items184"), resources.GetString("pokemon2Ability_cmb.Items185"), resources.GetString("pokemon2Ability_cmb.Items186"), resources.GetString("pokemon2Ability_cmb.Items187"), resources.GetString("pokemon2Ability_cmb.Items188"), resources.GetString("pokemon2Ability_cmb.Items189"), resources.GetString("pokemon2Ability_cmb.Items190"), resources.GetString("pokemon2Ability_cmb.Items191"), resources.GetString("pokemon2Ability_cmb.Items192"), resources.GetString("pokemon2Ability_cmb.Items193"), resources.GetString("pokemon2Ability_cmb.Items194"), resources.GetString("pokemon2Ability_cmb.Items195"), resources.GetString("pokemon2Ability_cmb.Items196"), resources.GetString("pokemon2Ability_cmb.Items197"), resources.GetString("pokemon2Ability_cmb.Items198"), resources.GetString("pokemon2Ability_cmb.Items199"), resources.GetString("pokemon2Ability_cmb.Items200"), resources.GetString("pokemon2Ability_cmb.Items201"), resources.GetString("pokemon2Ability_cmb.Items202"), resources.GetString("pokemon2Ability_cmb.Items203"), resources.GetString("pokemon2Ability_cmb.Items204"), resources.GetString("pokemon2Ability_cmb.Items205"), resources.GetString("pokemon2Ability_cmb.Items206"), resources.GetString("pokemon2Ability_cmb.Items207"), resources.GetString("pokemon2Ability_cmb.Items208"), resources.GetString("pokemon2Ability_cmb.Items209"), resources.GetString("pokemon2Ability_cmb.Items210"), resources.GetString("pokemon2Ability_cmb.Items211"), resources.GetString("pokemon2Ability_cmb.Items212"), resources.GetString("pokemon2Ability_cmb.Items213"), resources.GetString("pokemon2Ability_cmb.Items214"), resources.GetString("pokemon2Ability_cmb.Items215"), resources.GetString("pokemon2Ability_cmb.Items216"), resources.GetString("pokemon2Ability_cmb.Items217"), resources.GetString("pokemon2Ability_cmb.Items218"), resources.GetString("pokemon2Ability_cmb.Items219"), resources.GetString("pokemon2Ability_cmb.Items220"), resources.GetString("pokemon2Ability_cmb.Items221"), resources.GetString("pokemon2Ability_cmb.Items222"), resources.GetString("pokemon2Ability_cmb.Items223"), resources.GetString("pokemon2Ability_cmb.Items224"), resources.GetString("pokemon2Ability_cmb.Items225"), resources.GetString("pokemon2Ability_cmb.Items226"), resources.GetString("pokemon2Ability_cmb.Items227"), resources.GetString("pokemon2Ability_cmb.Items228"), resources.GetString("pokemon2Ability_cmb.Items229"), resources.GetString("pokemon2Ability_cmb.Items230"), resources.GetString("pokemon2Ability_cmb.Items231"), resources.GetString("pokemon2Ability_cmb.Items232"), resources.GetString("pokemon2Ability_cmb.Items233"), resources.GetString("pokemon2Ability_cmb.Items234"), resources.GetString("pokemon2Ability_cmb.Items235"), resources.GetString("pokemon2Ability_cmb.Items236"), resources.GetString("pokemon2Ability_cmb.Items237"), resources.GetString("pokemon2Ability_cmb.Items238"), resources.GetString("pokemon2Ability_cmb.Items239"), resources.GetString("pokemon2Ability_cmb.Items240"), resources.GetString("pokemon2Ability_cmb.Items241"), resources.GetString("pokemon2Ability_cmb.Items242"), resources.GetString("pokemon2Ability_cmb.Items243"), resources.GetString("pokemon2Ability_cmb.Items244"), resources.GetString("pokemon2Ability_cmb.Items245"), resources.GetString("pokemon2Ability_cmb.Items246"), resources.GetString("pokemon2Ability_cmb.Items247"), resources.GetString("pokemon2Ability_cmb.Items248"), resources.GetString("pokemon2Ability_cmb.Items249"), resources.GetString("pokemon2Ability_cmb.Items250"), resources.GetString("pokemon2Ability_cmb.Items251"), resources.GetString("pokemon2Ability_cmb.Items252"), resources.GetString("pokemon2Ability_cmb.Items253"), resources.GetString("pokemon2Ability_cmb.Items254"), resources.GetString("pokemon2Ability_cmb.Items255"), resources.GetString("pokemon2Ability_cmb.Items256"), resources.GetString("pokemon2Ability_cmb.Items257"), resources.GetString("pokemon2Ability_cmb.Items258"), resources.GetString("pokemon2Ability_cmb.Items259"), resources.GetString("pokemon2Ability_cmb.Items260"), resources.GetString("pokemon2Ability_cmb.Items261"), resources.GetString("pokemon2Ability_cmb.Items262"), resources.GetString("pokemon2Ability_cmb.Items263"), resources.GetString("pokemon2Ability_cmb.Items264"), resources.GetString("pokemon2Ability_cmb.Items265"), resources.GetString("pokemon2Ability_cmb.Items266"), resources.GetString("pokemon2Ability_cmb.Items267"), resources.GetString("pokemon2Ability_cmb.Items268"), resources.GetString("pokemon2Ability_cmb.Items269"), resources.GetString("pokemon2Ability_cmb.Items270"), resources.GetString("pokemon2Ability_cmb.Items271"), resources.GetString("pokemon2Ability_cmb.Items272"), resources.GetString("pokemon2Ability_cmb.Items273"), resources.GetString("pokemon2Ability_cmb.Items274"), resources.GetString("pokemon2Ability_cmb.Items275"), resources.GetString("pokemon2Ability_cmb.Items276"), resources.GetString("pokemon2Ability_cmb.Items277"), resources.GetString("pokemon2Ability_cmb.Items278"), resources.GetString("pokemon2Ability_cmb.Items279"), resources.GetString("pokemon2Ability_cmb.Items280"), resources.GetString("pokemon2Ability_cmb.Items281"), resources.GetString("pokemon2Ability_cmb.Items282"), resources.GetString("pokemon2Ability_cmb.Items283"), resources.GetString("pokemon2Ability_cmb.Items284"), resources.GetString("pokemon2Ability_cmb.Items285"), resources.GetString("pokemon2Ability_cmb.Items286"), resources.GetString("pokemon2Ability_cmb.Items287"), resources.GetString("pokemon2Ability_cmb.Items288"), resources.GetString("pokemon2Ability_cmb.Items289"), resources.GetString("pokemon2Ability_cmb.Items290"), resources.GetString("pokemon2Ability_cmb.Items291"), resources.GetString("pokemon2Ability_cmb.Items292"), resources.GetString("pokemon2Ability_cmb.Items293"), resources.GetString("pokemon2Ability_cmb.Items294"), resources.GetString("pokemon2Ability_cmb.Items295"), resources.GetString("pokemon2Ability_cmb.Items296"), resources.GetString("pokemon2Ability_cmb.Items297"), resources.GetString("pokemon2Ability_cmb.Items298"), resources.GetString("pokemon2Ability_cmb.Items299"), resources.GetString("pokemon2Ability_cmb.Items300"), resources.GetString("pokemon2Ability_cmb.Items301"), resources.GetString("pokemon2Ability_cmb.Items302"), resources.GetString("pokemon2Ability_cmb.Items303"), resources.GetString("pokemon2Ability_cmb.Items304")})
        resources.ApplyResources(pokemon2Ability_cmb, "pokemon2Ability_cmb")
        pokemon2Ability_cmb.Name = "pokemon2Ability_cmb"
        ' 
        ' pokemon2Nature_cmb
        ' 
        pokemon2Nature_cmb.FormattingEnabled = True
        pokemon2Nature_cmb.Items.AddRange(New Object() {resources.GetString("pokemon2Nature_cmb.Items"), resources.GetString("pokemon2Nature_cmb.Items1"), resources.GetString("pokemon2Nature_cmb.Items2"), resources.GetString("pokemon2Nature_cmb.Items3"), resources.GetString("pokemon2Nature_cmb.Items4"), resources.GetString("pokemon2Nature_cmb.Items5"), resources.GetString("pokemon2Nature_cmb.Items6"), resources.GetString("pokemon2Nature_cmb.Items7"), resources.GetString("pokemon2Nature_cmb.Items8"), resources.GetString("pokemon2Nature_cmb.Items9"), resources.GetString("pokemon2Nature_cmb.Items10"), resources.GetString("pokemon2Nature_cmb.Items11"), resources.GetString("pokemon2Nature_cmb.Items12"), resources.GetString("pokemon2Nature_cmb.Items13"), resources.GetString("pokemon2Nature_cmb.Items14"), resources.GetString("pokemon2Nature_cmb.Items15"), resources.GetString("pokemon2Nature_cmb.Items16"), resources.GetString("pokemon2Nature_cmb.Items17"), resources.GetString("pokemon2Nature_cmb.Items18"), resources.GetString("pokemon2Nature_cmb.Items19"), resources.GetString("pokemon2Nature_cmb.Items20"), resources.GetString("pokemon2Nature_cmb.Items21"), resources.GetString("pokemon2Nature_cmb.Items22"), resources.GetString("pokemon2Nature_cmb.Items23"), resources.GetString("pokemon2Nature_cmb.Items24"), resources.GetString("pokemon2Nature_cmb.Items25")})
        resources.ApplyResources(pokemon2Nature_cmb, "pokemon2Nature_cmb")
        pokemon2Nature_cmb.Name = "pokemon2Nature_cmb"
        ' 
        ' pokemon2Gender_lbl
        ' 
        resources.ApplyResources(pokemon2Gender_lbl, "pokemon2Gender_lbl")
        pokemon2Gender_lbl.Name = "pokemon2Gender_lbl"
        ' 
        ' pokemon2Nature_lbl
        ' 
        resources.ApplyResources(pokemon2Nature_lbl, "pokemon2Nature_lbl")
        pokemon2Nature_lbl.Name = "pokemon2Nature_lbl"
        ' 
        ' pokemon2Gender_cmb
        ' 
        pokemon2Gender_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        pokemon2Gender_cmb.FormattingEnabled = True
        pokemon2Gender_cmb.Items.AddRange(New Object() {resources.GetString("pokemon2Gender_cmb.Items"), resources.GetString("pokemon2Gender_cmb.Items1"), resources.GetString("pokemon2Gender_cmb.Items2")})
        resources.ApplyResources(pokemon2Gender_cmb, "pokemon2Gender_cmb")
        pokemon2Gender_cmb.Name = "pokemon2Gender_cmb"
        ' 
        ' pokemon2Shiny_grp
        ' 
        pokemon2Shiny_grp.Controls.Add(pokemon2SuperShiny_chkBox)
        pokemon2Shiny_grp.Controls.Add(pokemon2Shiny_rad)
        pokemon2Shiny_grp.Controls.Add(pokemon2NotShiny_rad)
        resources.ApplyResources(pokemon2Shiny_grp, "pokemon2Shiny_grp")
        pokemon2Shiny_grp.Name = "pokemon2Shiny_grp"
        pokemon2Shiny_grp.TabStop = False
        ' 
        ' pokemon2SuperShiny_chkBox
        ' 
        resources.ApplyResources(pokemon2SuperShiny_chkBox, "pokemon2SuperShiny_chkBox")
        pokemon2SuperShiny_chkBox.Name = "pokemon2SuperShiny_chkBox"
        pokemon2SuperShiny_chkBox.UseVisualStyleBackColor = True
        ' 
        ' pokemon2Shiny_rad
        ' 
        resources.ApplyResources(pokemon2Shiny_rad, "pokemon2Shiny_rad")
        pokemon2Shiny_rad.Name = "pokemon2Shiny_rad"
        pokemon2Shiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon2NotShiny_rad
        ' 
        resources.ApplyResources(pokemon2NotShiny_rad, "pokemon2NotShiny_rad")
        pokemon2NotShiny_rad.Checked = True
        pokemon2NotShiny_rad.Name = "pokemon2NotShiny_rad"
        pokemon2NotShiny_rad.TabStop = True
        pokemon2NotShiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon2Form_lbl
        ' 
        resources.ApplyResources(pokemon2Form_lbl, "pokemon2Form_lbl")
        pokemon2Form_lbl.Name = "pokemon2Form_lbl"
        ' 
        ' pg_pkmn3
        ' 
        pg_pkmn3.Controls.Add(pokemon3_grp)
        resources.ApplyResources(pg_pkmn3, "pg_pkmn3")
        pg_pkmn3.Name = "pg_pkmn3"
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
        resources.ApplyResources(pokemon3_grp, "pokemon3_grp")
        pokemon3_grp.Name = "pokemon3_grp"
        pokemon3_grp.TabStop = False
        ' 
        ' pokemon3Level_nbr
        ' 
        resources.ApplyResources(pokemon3Level_nbr, "pokemon3Level_nbr")
        pokemon3Level_nbr.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        pokemon3Level_nbr.Name = "pokemon3Level_nbr"
        pokemon3Level_nbr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' pokemon3Form_nbr
        ' 
        resources.ApplyResources(pokemon3Form_nbr, "pokemon3Form_nbr")
        pokemon3Form_nbr.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        pokemon3Form_nbr.Name = "pokemon3Form_nbr"
        ' 
        ' pokemon3Happiness_nbr
        ' 
        resources.ApplyResources(pokemon3Happiness_nbr, "pokemon3Happiness_nbr")
        pokemon3Happiness_nbr.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        pokemon3Happiness_nbr.Name = "pokemon3Happiness_nbr"
        pokemon3Happiness_nbr.Value = New Decimal(New Integer() {70, 0, 0, 0})
        ' 
        ' pokemon3Shadow_grp
        ' 
        pokemon3Shadow_grp.Controls.Add(pokemon3Shadow_rad)
        pokemon3Shadow_grp.Controls.Add(pokemon3NotShadow_rad)
        resources.ApplyResources(pokemon3Shadow_grp, "pokemon3Shadow_grp")
        pokemon3Shadow_grp.Name = "pokemon3Shadow_grp"
        pokemon3Shadow_grp.TabStop = False
        ' 
        ' pokemon3Shadow_rad
        ' 
        resources.ApplyResources(pokemon3Shadow_rad, "pokemon3Shadow_rad")
        pokemon3Shadow_rad.Name = "pokemon3Shadow_rad"
        pokemon3Shadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon3NotShadow_rad
        ' 
        resources.ApplyResources(pokemon3NotShadow_rad, "pokemon3NotShadow_rad")
        pokemon3NotShadow_rad.Checked = True
        pokemon3NotShadow_rad.Name = "pokemon3NotShadow_rad"
        pokemon3NotShadow_rad.TabStop = True
        pokemon3NotShadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon3Name_lbl
        ' 
        resources.ApplyResources(pokemon3Name_lbl, "pokemon3Name_lbl")
        pokemon3Name_lbl.Name = "pokemon3Name_lbl"
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
        resources.ApplyResources(pokemon3EVs_grp, "pokemon3EVs_grp")
        pokemon3EVs_grp.Name = "pokemon3EVs_grp"
        pokemon3EVs_grp.TabStop = False
        ' 
        ' pokemon3EVsDEF_txt
        ' 
        resources.ApplyResources(pokemon3EVsDEF_txt, "pokemon3EVsDEF_txt")
        pokemon3EVsDEF_txt.Name = "pokemon3EVsDEF_txt"
        ' 
        ' pokemon3EVsDEF_lbl
        ' 
        resources.ApplyResources(pokemon3EVsDEF_lbl, "pokemon3EVsDEF_lbl")
        pokemon3EVsDEF_lbl.Name = "pokemon3EVsDEF_lbl"
        ' 
        ' pokemon3EVsSPDEF_txt
        ' 
        resources.ApplyResources(pokemon3EVsSPDEF_txt, "pokemon3EVsSPDEF_txt")
        pokemon3EVsSPDEF_txt.Name = "pokemon3EVsSPDEF_txt"
        ' 
        ' pokemon3EVsSPDEF_lbl
        ' 
        resources.ApplyResources(pokemon3EVsSPDEF_lbl, "pokemon3EVsSPDEF_lbl")
        pokemon3EVsSPDEF_lbl.Name = "pokemon3EVsSPDEF_lbl"
        ' 
        ' pokemon3EVsSPATK_txt
        ' 
        resources.ApplyResources(pokemon3EVsSPATK_txt, "pokemon3EVsSPATK_txt")
        pokemon3EVsSPATK_txt.Name = "pokemon3EVsSPATK_txt"
        ' 
        ' pokemon3EVsSPATK_lbl
        ' 
        resources.ApplyResources(pokemon3EVsSPATK_lbl, "pokemon3EVsSPATK_lbl")
        pokemon3EVsSPATK_lbl.Name = "pokemon3EVsSPATK_lbl"
        ' 
        ' pokemon3EVsSPD_txt
        ' 
        resources.ApplyResources(pokemon3EVsSPD_txt, "pokemon3EVsSPD_txt")
        pokemon3EVsSPD_txt.Name = "pokemon3EVsSPD_txt"
        ' 
        ' pokemon3EVsSPD_lbl
        ' 
        resources.ApplyResources(pokemon3EVsSPD_lbl, "pokemon3EVsSPD_lbl")
        pokemon3EVsSPD_lbl.Name = "pokemon3EVsSPD_lbl"
        ' 
        ' pokemon3EVsATK_txt
        ' 
        resources.ApplyResources(pokemon3EVsATK_txt, "pokemon3EVsATK_txt")
        pokemon3EVsATK_txt.Name = "pokemon3EVsATK_txt"
        ' 
        ' pokemon3EVsATK_lbl
        ' 
        resources.ApplyResources(pokemon3EVsATK_lbl, "pokemon3EVsATK_lbl")
        pokemon3EVsATK_lbl.Name = "pokemon3EVsATK_lbl"
        ' 
        ' pokemon3EVsHP_txt
        ' 
        resources.ApplyResources(pokemon3EVsHP_txt, "pokemon3EVsHP_txt")
        pokemon3EVsHP_txt.Name = "pokemon3EVsHP_txt"
        ' 
        ' pokemon3EVsHP_lbl
        ' 
        resources.ApplyResources(pokemon3EVsHP_lbl, "pokemon3EVsHP_lbl")
        pokemon3EVsHP_lbl.Name = "pokemon3EVsHP_lbl"
        ' 
        ' pokemon3Name_txt
        ' 
        pokemon3Name_txt.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource1"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource2"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource3"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource4"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource5"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource6"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource7"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource8"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource9"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource10"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource11"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource12"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource13"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource14"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource15"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource16"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource17"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource18"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource19"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource20"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource21"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource22"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource23"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource24"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource25"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource26"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource27"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource28"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource29"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource30"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource31"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource32"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource33"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource34"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource35"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource36"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource37"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource38"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource39"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource40"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource41"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource42"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource43"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource44"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource45"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource46"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource47"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource48"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource49"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource50"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource51"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource52"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource53"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource54"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource55"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource56"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource57"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource58"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource59"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource60"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource61"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource62"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource63"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource64"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource65"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource66"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource67"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource68"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource69"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource70"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource71"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource72"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource73"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource74"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource75"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource76"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource77"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource78"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource79"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource80"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource81"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource82"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource83"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource84"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource85"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource86"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource87"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource88"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource89"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource90"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource91"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource92"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource93"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource94"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource95"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource96"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource97"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource98"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource99"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource100"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource101"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource102"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource103"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource104"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource105"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource106"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource107"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource108"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource109"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource110"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource111"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource112"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource113"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource114"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource115"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource116"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource117"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource118"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource119"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource120"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource121"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource122"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource123"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource124"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource125"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource126"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource127"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource128"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource129"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource130"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource131"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource132"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource133"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource134"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource135"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource136"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource137"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource138"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource139"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource140"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource141"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource142"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource143"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource144"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource145"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource146"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource147"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource148"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource149"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource150"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource151"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource152"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource153"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource154"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource155"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource156"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource157"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource158"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource159"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource160"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource161"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource162"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource163"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource164"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource165"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource166"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource167"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource168"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource169"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource170"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource171"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource172"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource173"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource174"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource175"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource176"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource177"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource178"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource179"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource180"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource181"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource182"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource183"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource184"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource185"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource186"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource187"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource188"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource189"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource190"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource191"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource192"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource193"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource194"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource195"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource196"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource197"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource198"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource199"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource200"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource201"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource202"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource203"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource204"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource205"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource206"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource207"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource208"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource209"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource210"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource211"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource212"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource213"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource214"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource215"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource216"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource217"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource218"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource219"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource220"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource221"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource222"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource223"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource224"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource225"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource226"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource227"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource228"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource229"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource230"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource231"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource232"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource233"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource234"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource235"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource236"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource237"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource238"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource239"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource240"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource241"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource242"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource243"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource244"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource245"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource246"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource247"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource248"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource249"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource250"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource251"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource252"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource253"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource254"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource255"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource256"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource257"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource258"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource259"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource260"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource261"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource262"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource263"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource264"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource265"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource266"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource267"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource268"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource269"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource270"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource271"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource272"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource273"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource274"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource275"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource276"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource277"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource278"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource279"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource280"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource281"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource282"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource283"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource284"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource285"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource286"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource287"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource288"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource289"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource290"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource291"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource292"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource293"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource294"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource295"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource296"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource297"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource298"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource299"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource300"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource301"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource302"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource303"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource304"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource305"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource306"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource307"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource308"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource309"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource310"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource311"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource312"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource313"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource314"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource315"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource316"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource317"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource318"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource319"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource320"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource321"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource322"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource323"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource324"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource325"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource326"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource327"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource328"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource329"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource330"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource331"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource332"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource333"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource334"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource335"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource336"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource337"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource338"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource339"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource340"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource341"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource342"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource343"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource344"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource345"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource346"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource347"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource348"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource349"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource350"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource351"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource352"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource353"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource354"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource355"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource356"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource357"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource358"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource359"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource360"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource361"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource362"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource363"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource364"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource365"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource366"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource367"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource368"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource369"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource370"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource371"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource372"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource373"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource374"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource375"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource376"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource377"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource378"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource379"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource380"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource381"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource382"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource383"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource384"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource385"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource386"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource387"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource388"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource389"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource390"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource391"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource392"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource393"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource394"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource395"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource396"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource397"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource398"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource399"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource400"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource401"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource402"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource403"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource404"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource405"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource406"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource407"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource408"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource409"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource410"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource411"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource412"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource413"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource414"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource415"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource416"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource417"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource418"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource419"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource420"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource421"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource422"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource423"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource424"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource425"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource426"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource427"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource428"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource429"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource430"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource431"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource432"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource433"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource434"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource435"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource436"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource437"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource438"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource439"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource440"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource441"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource442"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource443"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource444"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource445"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource446"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource447"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource448"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource449"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource450"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource451"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource452"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource453"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource454"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource455"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource456"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource457"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource458"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource459"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource460"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource461"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource462"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource463"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource464"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource465"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource466"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource467"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource468"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource469"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource470"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource471"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource472"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource473"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource474"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource475"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource476"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource477"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource478"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource479"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource480"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource481"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource482"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource483"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource484"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource485"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource486"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource487"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource488"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource489"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource490"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource491"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource492"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource493"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource494"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource495"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource496"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource497"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource498"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource499"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource500"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource501"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource502"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource503"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource504"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource505"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource506"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource507"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource508"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource509"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource510"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource511"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource512"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource513"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource514"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource515"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource516"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource517"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource518"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource519"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource520"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource521"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource522"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource523"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource524"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource525"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource526"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource527"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource528"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource529"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource530"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource531"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource532"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource533"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource534"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource535"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource536"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource537"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource538"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource539"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource540"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource541"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource542"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource543"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource544"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource545"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource546"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource547"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource548"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource549"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource550"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource551"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource552"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource553"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource554"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource555"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource556"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource557"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource558"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource559"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource560"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource561"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource562"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource563"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource564"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource565"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource566"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource567"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource568"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource569"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource570"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource571"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource572"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource573"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource574"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource575"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource576"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource577"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource578"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource579"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource580"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource581"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource582"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource583"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource584"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource585"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource586"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource587"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource588"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource589"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource590"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource591"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource592"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource593"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource594"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource595"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource596"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource597"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource598"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource599"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource600"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource601"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource602"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource603"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource604"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource605"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource606"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource607"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource608"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource609"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource610"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource611"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource612"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource613"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource614"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource615"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource616"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource617"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource618"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource619"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource620"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource621"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource622"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource623"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource624"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource625"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource626"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource627"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource628"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource629"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource630"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource631"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource632"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource633"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource634"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource635"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource636"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource637"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource638"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource639"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource640"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource641"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource642"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource643"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource644"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource645"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource646"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource647"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource648"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource649"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource650"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource651"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource652"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource653"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource654"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource655"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource656"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource657"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource658"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource659"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource660"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource661"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource662"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource663"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource664"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource665"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource666"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource667"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource668"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource669"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource670"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource671"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource672"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource673"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource674"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource675"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource676"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource677"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource678"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource679"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource680"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource681"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource682"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource683"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource684"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource685"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource686"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource687"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource688"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource689"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource690"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource691"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource692"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource693"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource694"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource695"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource696"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource697"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource698"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource699"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource700"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource701"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource702"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource703"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource704"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource705"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource706"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource707"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource708"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource709"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource710"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource711"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource712"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource713"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource714"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource715"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource716"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource717"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource718"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource719"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource720"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource721"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource722"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource723"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource724"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource725"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource726"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource727"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource728"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource729"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource730"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource731"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource732"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource733"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource734"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource735"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource736"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource737"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource738"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource739"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource740"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource741"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource742"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource743"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource744"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource745"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource746"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource747"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource748"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource749"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource750"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource751"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource752"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource753"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource754"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource755"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource756"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource757"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource758"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource759"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource760"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource761"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource762"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource763"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource764"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource765"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource766"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource767"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource768"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource769"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource770"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource771"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource772"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource773"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource774"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource775"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource776"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource777"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource778"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource779"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource780"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource781"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource782"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource783"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource784"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource785"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource786"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource787"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource788"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource789"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource790"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource791"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource792"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource793"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource794"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource795"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource796"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource797"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource798"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource799"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource800"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource801"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource802"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource803"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource804"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource805"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource806"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource807"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource808"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource809"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource810"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource811"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource812"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource813"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource814"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource815"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource816"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource817"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource818"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource819"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource820"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource821"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource822"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource823"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource824"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource825"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource826"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource827"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource828"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource829"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource830"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource831"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource832"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource833"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource834"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource835"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource836"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource837"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource838"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource839"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource840"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource841"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource842"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource843"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource844"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource845"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource846"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource847"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource848"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource849"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource850"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource851"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource852"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource853"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource854"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource855"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource856"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource857"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource858"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource859"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource860"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource861"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource862"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource863"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource864"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource865"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource866"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource867"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource868"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource869"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource870"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource871"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource872"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource873"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource874"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource875"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource876"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource877"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource878"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource879"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource880"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource881"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource882"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource883"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource884"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource885"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource886"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource887"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource888"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource889"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource890"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource891"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource892"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource893"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource894"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource895"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource896"), resources.GetString("pokemon3Name_txt.AutoCompleteCustomSource897")})
        pokemon3Name_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon3Name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource
        resources.ApplyResources(pokemon3Name_txt, "pokemon3Name_txt")
        pokemon3Name_txt.Name = "pokemon3Name_txt"
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
        resources.ApplyResources(pokemon3IVs_grp, "pokemon3IVs_grp")
        pokemon3IVs_grp.Name = "pokemon3IVs_grp"
        pokemon3IVs_grp.TabStop = False
        ' 
        ' pokemon3RandomIVs_btn
        ' 
        resources.ApplyResources(pokemon3RandomIVs_btn, "pokemon3RandomIVs_btn")
        pokemon3RandomIVs_btn.Name = "pokemon3RandomIVs_btn"
        pokemon3RandomIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon3MaxIVs_btn
        ' 
        resources.ApplyResources(pokemon3MaxIVs_btn, "pokemon3MaxIVs_btn")
        pokemon3MaxIVs_btn.Name = "pokemon3MaxIVs_btn"
        pokemon3MaxIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon3IVsDEF_txt
        ' 
        resources.ApplyResources(pokemon3IVsDEF_txt, "pokemon3IVsDEF_txt")
        pokemon3IVsDEF_txt.Name = "pokemon3IVsDEF_txt"
        ' 
        ' pokemon3IVsDEF_lbl
        ' 
        resources.ApplyResources(pokemon3IVsDEF_lbl, "pokemon3IVsDEF_lbl")
        pokemon3IVsDEF_lbl.Name = "pokemon3IVsDEF_lbl"
        ' 
        ' pokemon3IVsSPDEF_txt
        ' 
        resources.ApplyResources(pokemon3IVsSPDEF_txt, "pokemon3IVsSPDEF_txt")
        pokemon3IVsSPDEF_txt.Name = "pokemon3IVsSPDEF_txt"
        ' 
        ' pokemon3IVsSPDEF_lbl
        ' 
        resources.ApplyResources(pokemon3IVsSPDEF_lbl, "pokemon3IVsSPDEF_lbl")
        pokemon3IVsSPDEF_lbl.Name = "pokemon3IVsSPDEF_lbl"
        ' 
        ' pokemon3IVsSPATK_txt
        ' 
        resources.ApplyResources(pokemon3IVsSPATK_txt, "pokemon3IVsSPATK_txt")
        pokemon3IVsSPATK_txt.Name = "pokemon3IVsSPATK_txt"
        ' 
        ' pokemon3IVsSPATK_lbl
        ' 
        resources.ApplyResources(pokemon3IVsSPATK_lbl, "pokemon3IVsSPATK_lbl")
        pokemon3IVsSPATK_lbl.Name = "pokemon3IVsSPATK_lbl"
        ' 
        ' pokemon3IVsSPD_txt
        ' 
        resources.ApplyResources(pokemon3IVsSPD_txt, "pokemon3IVsSPD_txt")
        pokemon3IVsSPD_txt.Name = "pokemon3IVsSPD_txt"
        ' 
        ' pokemon3IVsSPD_lbl
        ' 
        resources.ApplyResources(pokemon3IVsSPD_lbl, "pokemon3IVsSPD_lbl")
        pokemon3IVsSPD_lbl.Name = "pokemon3IVsSPD_lbl"
        ' 
        ' pokemon3IVsATK_txt
        ' 
        resources.ApplyResources(pokemon3IVsATK_txt, "pokemon3IVsATK_txt")
        pokemon3IVsATK_txt.Name = "pokemon3IVsATK_txt"
        ' 
        ' pokemon3IVsATK_lbl
        ' 
        resources.ApplyResources(pokemon3IVsATK_lbl, "pokemon3IVsATK_lbl")
        pokemon3IVsATK_lbl.Name = "pokemon3IVsATK_lbl"
        ' 
        ' pokemon3IVsHP_txt
        ' 
        resources.ApplyResources(pokemon3IVsHP_txt, "pokemon3IVsHP_txt")
        pokemon3IVsHP_txt.Name = "pokemon3IVsHP_txt"
        ' 
        ' pokemon3IVsHP_lbl
        ' 
        resources.ApplyResources(pokemon3IVsHP_lbl, "pokemon3IVsHP_lbl")
        pokemon3IVsHP_lbl.Name = "pokemon3IVsHP_lbl"
        ' 
        ' pokemon3HeldItem_txt
        ' 
        resources.ApplyResources(pokemon3HeldItem_txt, "pokemon3HeldItem_txt")
        pokemon3HeldItem_txt.Name = "pokemon3HeldItem_txt"
        ' 
        ' pokemon3PokeballID_cmb
        ' 
        pokemon3PokeballID_cmb.FormattingEnabled = True
        pokemon3PokeballID_cmb.Items.AddRange(New Object() {resources.GetString("pokemon3PokeballID_cmb.Items"), resources.GetString("pokemon3PokeballID_cmb.Items1"), resources.GetString("pokemon3PokeballID_cmb.Items2"), resources.GetString("pokemon3PokeballID_cmb.Items3"), resources.GetString("pokemon3PokeballID_cmb.Items4"), resources.GetString("pokemon3PokeballID_cmb.Items5"), resources.GetString("pokemon3PokeballID_cmb.Items6"), resources.GetString("pokemon3PokeballID_cmb.Items7"), resources.GetString("pokemon3PokeballID_cmb.Items8"), resources.GetString("pokemon3PokeballID_cmb.Items9"), resources.GetString("pokemon3PokeballID_cmb.Items10"), resources.GetString("pokemon3PokeballID_cmb.Items11"), resources.GetString("pokemon3PokeballID_cmb.Items12"), resources.GetString("pokemon3PokeballID_cmb.Items13"), resources.GetString("pokemon3PokeballID_cmb.Items14"), resources.GetString("pokemon3PokeballID_cmb.Items15"), resources.GetString("pokemon3PokeballID_cmb.Items16"), resources.GetString("pokemon3PokeballID_cmb.Items17"), resources.GetString("pokemon3PokeballID_cmb.Items18"), resources.GetString("pokemon3PokeballID_cmb.Items19"), resources.GetString("pokemon3PokeballID_cmb.Items20"), resources.GetString("pokemon3PokeballID_cmb.Items21"), resources.GetString("pokemon3PokeballID_cmb.Items22"), resources.GetString("pokemon3PokeballID_cmb.Items23"), resources.GetString("pokemon3PokeballID_cmb.Items24"), resources.GetString("pokemon3PokeballID_cmb.Items25")})
        resources.ApplyResources(pokemon3PokeballID_cmb, "pokemon3PokeballID_cmb")
        pokemon3PokeballID_cmb.Name = "pokemon3PokeballID_cmb"
        ' 
        ' pokemon3HeldItem_lbl
        ' 
        resources.ApplyResources(pokemon3HeldItem_lbl, "pokemon3HeldItem_lbl")
        pokemon3HeldItem_lbl.Name = "pokemon3HeldItem_lbl"
        ' 
        ' pokemon3PokeBall_lbl
        ' 
        resources.ApplyResources(pokemon3PokeBall_lbl, "pokemon3PokeBall_lbl")
        pokemon3PokeBall_lbl.Name = "pokemon3PokeBall_lbl"
        ' 
        ' pokemon3Level_lbl
        ' 
        resources.ApplyResources(pokemon3Level_lbl, "pokemon3Level_lbl")
        pokemon3Level_lbl.Name = "pokemon3Level_lbl"
        ' 
        ' pokemon3Nickname_txt
        ' 
        resources.ApplyResources(pokemon3Nickname_txt, "pokemon3Nickname_txt")
        pokemon3Nickname_txt.Name = "pokemon3Nickname_txt"
        ' 
        ' pokemon3Nickname_lbl
        ' 
        resources.ApplyResources(pokemon3Nickname_lbl, "pokemon3Nickname_lbl")
        pokemon3Nickname_lbl.Name = "pokemon3Nickname_lbl"
        ' 
        ' pokemon3Moves_grp
        ' 
        pokemon3Moves_grp.Controls.Add(pokemon3Move4_txtBox)
        pokemon3Moves_grp.Controls.Add(pokemon3Move3_txtBox)
        pokemon3Moves_grp.Controls.Add(pokemon3Move2_txtBox)
        pokemon3Moves_grp.Controls.Add(pokemon3Move1_txtBox)
        resources.ApplyResources(pokemon3Moves_grp, "pokemon3Moves_grp")
        pokemon3Moves_grp.Name = "pokemon3Moves_grp"
        pokemon3Moves_grp.TabStop = False
        ' 
        ' pokemon3Move4_txtBox
        ' 
        resources.ApplyResources(pokemon3Move4_txtBox, "pokemon3Move4_txtBox")
        pokemon3Move4_txtBox.Name = "pokemon3Move4_txtBox"
        ' 
        ' pokemon3Move3_txtBox
        ' 
        resources.ApplyResources(pokemon3Move3_txtBox, "pokemon3Move3_txtBox")
        pokemon3Move3_txtBox.Name = "pokemon3Move3_txtBox"
        ' 
        ' pokemon3Move2_txtBox
        ' 
        resources.ApplyResources(pokemon3Move2_txtBox, "pokemon3Move2_txtBox")
        pokemon3Move2_txtBox.Name = "pokemon3Move2_txtBox"
        ' 
        ' pokemon3Move1_txtBox
        ' 
        resources.ApplyResources(pokemon3Move1_txtBox, "pokemon3Move1_txtBox")
        pokemon3Move1_txtBox.Name = "pokemon3Move1_txtBox"
        ' 
        ' pokemon3Ability_lbl
        ' 
        resources.ApplyResources(pokemon3Ability_lbl, "pokemon3Ability_lbl")
        pokemon3Ability_lbl.Name = "pokemon3Ability_lbl"
        ' 
        ' pokemon3Happiness_lbl
        ' 
        resources.ApplyResources(pokemon3Happiness_lbl, "pokemon3Happiness_lbl")
        pokemon3Happiness_lbl.Name = "pokemon3Happiness_lbl"
        ' 
        ' pokemon3Ability_cmb
        ' 
        pokemon3Ability_cmb.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource1"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource2"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource3"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource4"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource5"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource6"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource7"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource8"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource9"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource10"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource11"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource12"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource13"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource14"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource15"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource16"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource17"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource18"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource19"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource20"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource21"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource22"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource23"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource24"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource25"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource26"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource27"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource28"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource29"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource30"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource31"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource32"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource33"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource34"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource35"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource36"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource37"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource38"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource39"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource40"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource41"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource42"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource43"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource44"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource45"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource46"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource47"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource48"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource49"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource50"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource51"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource52"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource53"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource54"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource55"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource56"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource57"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource58"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource59"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource60"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource61"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource62"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource63"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource64"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource65"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource66"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource67"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource68"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource69"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource70"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource71"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource72"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource73"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource74"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource75"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource76"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource77"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource78"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource79"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource80"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource81"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource82"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource83"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource84"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource85"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource86"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource87"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource88"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource89"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource90"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource91"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource92"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource93"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource94"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource95"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource96"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource97"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource98"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource99"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource100"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource101"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource102"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource103"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource104"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource105"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource106"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource107"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource108"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource109"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource110"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource111"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource112"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource113"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource114"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource115"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource116"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource117"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource118"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource119"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource120"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource121"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource122"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource123"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource124"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource125"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource126"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource127"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource128"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource129"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource130"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource131"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource132"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource133"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource134"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource135"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource136"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource137"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource138"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource139"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource140"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource141"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource142"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource143"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource144"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource145"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource146"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource147"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource148"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource149"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource150"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource151"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource152"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource153"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource154"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource155"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource156"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource157"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource158"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource159"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource160"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource161"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource162"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource163"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource164"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource165"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource166"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource167"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource168"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource169"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource170"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource171"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource172"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource173"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource174"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource175"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource176"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource177"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource178"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource179"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource180"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource181"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource182"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource183"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource184"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource185"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource186"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource187"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource188"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource189"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource190"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource191"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource192"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource193"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource194"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource195"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource196"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource197"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource198"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource199"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource200"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource201"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource202"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource203"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource204"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource205"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource206"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource207"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource208"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource209"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource210"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource211"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource212"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource213"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource214"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource215"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource216"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource217"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource218"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource219"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource220"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource221"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource222"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource223"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource224"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource225"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource226"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource227"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource228"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource229"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource230"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource231"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource232"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource233"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource234"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource235"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource236"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource237"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource238"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource239"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource240"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource241"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource242"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource243"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource244"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource245"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource246"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource247"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource248"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource249"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource250"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource251"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource252"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource253"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource254"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource255"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource256"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource257"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource258"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource259"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource260"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource261"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource262"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource263"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource264"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource265"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource266"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource267"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource268"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource269"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource270"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource271"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource272"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource273"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource274"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource275"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource276"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource277"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource278"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource279"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource280"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource281"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource282"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource283"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource284"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource285"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource286"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource287"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource288"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource289"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource290"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource291"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource292"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource293"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource294"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource295"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource296"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource297"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource298"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource299"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource300"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource301"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource302"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource303"), resources.GetString("pokemon3Ability_cmb.AutoCompleteCustomSource304")})
        pokemon3Ability_cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon3Ability_cmb.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon3Ability_cmb.FormattingEnabled = True
        pokemon3Ability_cmb.Items.AddRange(New Object() {resources.GetString("pokemon3Ability_cmb.Items"), resources.GetString("pokemon3Ability_cmb.Items1"), resources.GetString("pokemon3Ability_cmb.Items2"), resources.GetString("pokemon3Ability_cmb.Items3"), resources.GetString("pokemon3Ability_cmb.Items4"), resources.GetString("pokemon3Ability_cmb.Items5"), resources.GetString("pokemon3Ability_cmb.Items6"), resources.GetString("pokemon3Ability_cmb.Items7"), resources.GetString("pokemon3Ability_cmb.Items8"), resources.GetString("pokemon3Ability_cmb.Items9"), resources.GetString("pokemon3Ability_cmb.Items10"), resources.GetString("pokemon3Ability_cmb.Items11"), resources.GetString("pokemon3Ability_cmb.Items12"), resources.GetString("pokemon3Ability_cmb.Items13"), resources.GetString("pokemon3Ability_cmb.Items14"), resources.GetString("pokemon3Ability_cmb.Items15"), resources.GetString("pokemon3Ability_cmb.Items16"), resources.GetString("pokemon3Ability_cmb.Items17"), resources.GetString("pokemon3Ability_cmb.Items18"), resources.GetString("pokemon3Ability_cmb.Items19"), resources.GetString("pokemon3Ability_cmb.Items20"), resources.GetString("pokemon3Ability_cmb.Items21"), resources.GetString("pokemon3Ability_cmb.Items22"), resources.GetString("pokemon3Ability_cmb.Items23"), resources.GetString("pokemon3Ability_cmb.Items24"), resources.GetString("pokemon3Ability_cmb.Items25"), resources.GetString("pokemon3Ability_cmb.Items26"), resources.GetString("pokemon3Ability_cmb.Items27"), resources.GetString("pokemon3Ability_cmb.Items28"), resources.GetString("pokemon3Ability_cmb.Items29"), resources.GetString("pokemon3Ability_cmb.Items30"), resources.GetString("pokemon3Ability_cmb.Items31"), resources.GetString("pokemon3Ability_cmb.Items32"), resources.GetString("pokemon3Ability_cmb.Items33"), resources.GetString("pokemon3Ability_cmb.Items34"), resources.GetString("pokemon3Ability_cmb.Items35"), resources.GetString("pokemon3Ability_cmb.Items36"), resources.GetString("pokemon3Ability_cmb.Items37"), resources.GetString("pokemon3Ability_cmb.Items38"), resources.GetString("pokemon3Ability_cmb.Items39"), resources.GetString("pokemon3Ability_cmb.Items40"), resources.GetString("pokemon3Ability_cmb.Items41"), resources.GetString("pokemon3Ability_cmb.Items42"), resources.GetString("pokemon3Ability_cmb.Items43"), resources.GetString("pokemon3Ability_cmb.Items44"), resources.GetString("pokemon3Ability_cmb.Items45"), resources.GetString("pokemon3Ability_cmb.Items46"), resources.GetString("pokemon3Ability_cmb.Items47"), resources.GetString("pokemon3Ability_cmb.Items48"), resources.GetString("pokemon3Ability_cmb.Items49"), resources.GetString("pokemon3Ability_cmb.Items50"), resources.GetString("pokemon3Ability_cmb.Items51"), resources.GetString("pokemon3Ability_cmb.Items52"), resources.GetString("pokemon3Ability_cmb.Items53"), resources.GetString("pokemon3Ability_cmb.Items54"), resources.GetString("pokemon3Ability_cmb.Items55"), resources.GetString("pokemon3Ability_cmb.Items56"), resources.GetString("pokemon3Ability_cmb.Items57"), resources.GetString("pokemon3Ability_cmb.Items58"), resources.GetString("pokemon3Ability_cmb.Items59"), resources.GetString("pokemon3Ability_cmb.Items60"), resources.GetString("pokemon3Ability_cmb.Items61"), resources.GetString("pokemon3Ability_cmb.Items62"), resources.GetString("pokemon3Ability_cmb.Items63"), resources.GetString("pokemon3Ability_cmb.Items64"), resources.GetString("pokemon3Ability_cmb.Items65"), resources.GetString("pokemon3Ability_cmb.Items66"), resources.GetString("pokemon3Ability_cmb.Items67"), resources.GetString("pokemon3Ability_cmb.Items68"), resources.GetString("pokemon3Ability_cmb.Items69"), resources.GetString("pokemon3Ability_cmb.Items70"), resources.GetString("pokemon3Ability_cmb.Items71"), resources.GetString("pokemon3Ability_cmb.Items72"), resources.GetString("pokemon3Ability_cmb.Items73"), resources.GetString("pokemon3Ability_cmb.Items74"), resources.GetString("pokemon3Ability_cmb.Items75"), resources.GetString("pokemon3Ability_cmb.Items76"), resources.GetString("pokemon3Ability_cmb.Items77"), resources.GetString("pokemon3Ability_cmb.Items78"), resources.GetString("pokemon3Ability_cmb.Items79"), resources.GetString("pokemon3Ability_cmb.Items80"), resources.GetString("pokemon3Ability_cmb.Items81"), resources.GetString("pokemon3Ability_cmb.Items82"), resources.GetString("pokemon3Ability_cmb.Items83"), resources.GetString("pokemon3Ability_cmb.Items84"), resources.GetString("pokemon3Ability_cmb.Items85"), resources.GetString("pokemon3Ability_cmb.Items86"), resources.GetString("pokemon3Ability_cmb.Items87"), resources.GetString("pokemon3Ability_cmb.Items88"), resources.GetString("pokemon3Ability_cmb.Items89"), resources.GetString("pokemon3Ability_cmb.Items90"), resources.GetString("pokemon3Ability_cmb.Items91"), resources.GetString("pokemon3Ability_cmb.Items92"), resources.GetString("pokemon3Ability_cmb.Items93"), resources.GetString("pokemon3Ability_cmb.Items94"), resources.GetString("pokemon3Ability_cmb.Items95"), resources.GetString("pokemon3Ability_cmb.Items96"), resources.GetString("pokemon3Ability_cmb.Items97"), resources.GetString("pokemon3Ability_cmb.Items98"), resources.GetString("pokemon3Ability_cmb.Items99"), resources.GetString("pokemon3Ability_cmb.Items100"), resources.GetString("pokemon3Ability_cmb.Items101"), resources.GetString("pokemon3Ability_cmb.Items102"), resources.GetString("pokemon3Ability_cmb.Items103"), resources.GetString("pokemon3Ability_cmb.Items104"), resources.GetString("pokemon3Ability_cmb.Items105"), resources.GetString("pokemon3Ability_cmb.Items106"), resources.GetString("pokemon3Ability_cmb.Items107"), resources.GetString("pokemon3Ability_cmb.Items108"), resources.GetString("pokemon3Ability_cmb.Items109"), resources.GetString("pokemon3Ability_cmb.Items110"), resources.GetString("pokemon3Ability_cmb.Items111"), resources.GetString("pokemon3Ability_cmb.Items112"), resources.GetString("pokemon3Ability_cmb.Items113"), resources.GetString("pokemon3Ability_cmb.Items114"), resources.GetString("pokemon3Ability_cmb.Items115"), resources.GetString("pokemon3Ability_cmb.Items116"), resources.GetString("pokemon3Ability_cmb.Items117"), resources.GetString("pokemon3Ability_cmb.Items118"), resources.GetString("pokemon3Ability_cmb.Items119"), resources.GetString("pokemon3Ability_cmb.Items120"), resources.GetString("pokemon3Ability_cmb.Items121"), resources.GetString("pokemon3Ability_cmb.Items122"), resources.GetString("pokemon3Ability_cmb.Items123"), resources.GetString("pokemon3Ability_cmb.Items124"), resources.GetString("pokemon3Ability_cmb.Items125"), resources.GetString("pokemon3Ability_cmb.Items126"), resources.GetString("pokemon3Ability_cmb.Items127"), resources.GetString("pokemon3Ability_cmb.Items128"), resources.GetString("pokemon3Ability_cmb.Items129"), resources.GetString("pokemon3Ability_cmb.Items130"), resources.GetString("pokemon3Ability_cmb.Items131"), resources.GetString("pokemon3Ability_cmb.Items132"), resources.GetString("pokemon3Ability_cmb.Items133"), resources.GetString("pokemon3Ability_cmb.Items134"), resources.GetString("pokemon3Ability_cmb.Items135"), resources.GetString("pokemon3Ability_cmb.Items136"), resources.GetString("pokemon3Ability_cmb.Items137"), resources.GetString("pokemon3Ability_cmb.Items138"), resources.GetString("pokemon3Ability_cmb.Items139"), resources.GetString("pokemon3Ability_cmb.Items140"), resources.GetString("pokemon3Ability_cmb.Items141"), resources.GetString("pokemon3Ability_cmb.Items142"), resources.GetString("pokemon3Ability_cmb.Items143"), resources.GetString("pokemon3Ability_cmb.Items144"), resources.GetString("pokemon3Ability_cmb.Items145"), resources.GetString("pokemon3Ability_cmb.Items146"), resources.GetString("pokemon3Ability_cmb.Items147"), resources.GetString("pokemon3Ability_cmb.Items148"), resources.GetString("pokemon3Ability_cmb.Items149"), resources.GetString("pokemon3Ability_cmb.Items150"), resources.GetString("pokemon3Ability_cmb.Items151"), resources.GetString("pokemon3Ability_cmb.Items152"), resources.GetString("pokemon3Ability_cmb.Items153"), resources.GetString("pokemon3Ability_cmb.Items154"), resources.GetString("pokemon3Ability_cmb.Items155"), resources.GetString("pokemon3Ability_cmb.Items156"), resources.GetString("pokemon3Ability_cmb.Items157"), resources.GetString("pokemon3Ability_cmb.Items158"), resources.GetString("pokemon3Ability_cmb.Items159"), resources.GetString("pokemon3Ability_cmb.Items160"), resources.GetString("pokemon3Ability_cmb.Items161"), resources.GetString("pokemon3Ability_cmb.Items162"), resources.GetString("pokemon3Ability_cmb.Items163"), resources.GetString("pokemon3Ability_cmb.Items164"), resources.GetString("pokemon3Ability_cmb.Items165"), resources.GetString("pokemon3Ability_cmb.Items166"), resources.GetString("pokemon3Ability_cmb.Items167"), resources.GetString("pokemon3Ability_cmb.Items168"), resources.GetString("pokemon3Ability_cmb.Items169"), resources.GetString("pokemon3Ability_cmb.Items170"), resources.GetString("pokemon3Ability_cmb.Items171"), resources.GetString("pokemon3Ability_cmb.Items172"), resources.GetString("pokemon3Ability_cmb.Items173"), resources.GetString("pokemon3Ability_cmb.Items174"), resources.GetString("pokemon3Ability_cmb.Items175"), resources.GetString("pokemon3Ability_cmb.Items176"), resources.GetString("pokemon3Ability_cmb.Items177"), resources.GetString("pokemon3Ability_cmb.Items178"), resources.GetString("pokemon3Ability_cmb.Items179"), resources.GetString("pokemon3Ability_cmb.Items180"), resources.GetString("pokemon3Ability_cmb.Items181"), resources.GetString("pokemon3Ability_cmb.Items182"), resources.GetString("pokemon3Ability_cmb.Items183"), resources.GetString("pokemon3Ability_cmb.Items184"), resources.GetString("pokemon3Ability_cmb.Items185"), resources.GetString("pokemon3Ability_cmb.Items186"), resources.GetString("pokemon3Ability_cmb.Items187"), resources.GetString("pokemon3Ability_cmb.Items188"), resources.GetString("pokemon3Ability_cmb.Items189"), resources.GetString("pokemon3Ability_cmb.Items190"), resources.GetString("pokemon3Ability_cmb.Items191"), resources.GetString("pokemon3Ability_cmb.Items192"), resources.GetString("pokemon3Ability_cmb.Items193"), resources.GetString("pokemon3Ability_cmb.Items194"), resources.GetString("pokemon3Ability_cmb.Items195"), resources.GetString("pokemon3Ability_cmb.Items196"), resources.GetString("pokemon3Ability_cmb.Items197"), resources.GetString("pokemon3Ability_cmb.Items198"), resources.GetString("pokemon3Ability_cmb.Items199"), resources.GetString("pokemon3Ability_cmb.Items200"), resources.GetString("pokemon3Ability_cmb.Items201"), resources.GetString("pokemon3Ability_cmb.Items202"), resources.GetString("pokemon3Ability_cmb.Items203"), resources.GetString("pokemon3Ability_cmb.Items204"), resources.GetString("pokemon3Ability_cmb.Items205"), resources.GetString("pokemon3Ability_cmb.Items206"), resources.GetString("pokemon3Ability_cmb.Items207"), resources.GetString("pokemon3Ability_cmb.Items208"), resources.GetString("pokemon3Ability_cmb.Items209"), resources.GetString("pokemon3Ability_cmb.Items210"), resources.GetString("pokemon3Ability_cmb.Items211"), resources.GetString("pokemon3Ability_cmb.Items212"), resources.GetString("pokemon3Ability_cmb.Items213"), resources.GetString("pokemon3Ability_cmb.Items214"), resources.GetString("pokemon3Ability_cmb.Items215"), resources.GetString("pokemon3Ability_cmb.Items216"), resources.GetString("pokemon3Ability_cmb.Items217"), resources.GetString("pokemon3Ability_cmb.Items218"), resources.GetString("pokemon3Ability_cmb.Items219"), resources.GetString("pokemon3Ability_cmb.Items220"), resources.GetString("pokemon3Ability_cmb.Items221"), resources.GetString("pokemon3Ability_cmb.Items222"), resources.GetString("pokemon3Ability_cmb.Items223"), resources.GetString("pokemon3Ability_cmb.Items224"), resources.GetString("pokemon3Ability_cmb.Items225"), resources.GetString("pokemon3Ability_cmb.Items226"), resources.GetString("pokemon3Ability_cmb.Items227"), resources.GetString("pokemon3Ability_cmb.Items228"), resources.GetString("pokemon3Ability_cmb.Items229"), resources.GetString("pokemon3Ability_cmb.Items230"), resources.GetString("pokemon3Ability_cmb.Items231"), resources.GetString("pokemon3Ability_cmb.Items232"), resources.GetString("pokemon3Ability_cmb.Items233"), resources.GetString("pokemon3Ability_cmb.Items234"), resources.GetString("pokemon3Ability_cmb.Items235"), resources.GetString("pokemon3Ability_cmb.Items236"), resources.GetString("pokemon3Ability_cmb.Items237"), resources.GetString("pokemon3Ability_cmb.Items238"), resources.GetString("pokemon3Ability_cmb.Items239"), resources.GetString("pokemon3Ability_cmb.Items240"), resources.GetString("pokemon3Ability_cmb.Items241"), resources.GetString("pokemon3Ability_cmb.Items242"), resources.GetString("pokemon3Ability_cmb.Items243"), resources.GetString("pokemon3Ability_cmb.Items244"), resources.GetString("pokemon3Ability_cmb.Items245"), resources.GetString("pokemon3Ability_cmb.Items246"), resources.GetString("pokemon3Ability_cmb.Items247"), resources.GetString("pokemon3Ability_cmb.Items248"), resources.GetString("pokemon3Ability_cmb.Items249"), resources.GetString("pokemon3Ability_cmb.Items250"), resources.GetString("pokemon3Ability_cmb.Items251"), resources.GetString("pokemon3Ability_cmb.Items252"), resources.GetString("pokemon3Ability_cmb.Items253"), resources.GetString("pokemon3Ability_cmb.Items254"), resources.GetString("pokemon3Ability_cmb.Items255"), resources.GetString("pokemon3Ability_cmb.Items256"), resources.GetString("pokemon3Ability_cmb.Items257"), resources.GetString("pokemon3Ability_cmb.Items258"), resources.GetString("pokemon3Ability_cmb.Items259"), resources.GetString("pokemon3Ability_cmb.Items260"), resources.GetString("pokemon3Ability_cmb.Items261"), resources.GetString("pokemon3Ability_cmb.Items262"), resources.GetString("pokemon3Ability_cmb.Items263"), resources.GetString("pokemon3Ability_cmb.Items264"), resources.GetString("pokemon3Ability_cmb.Items265"), resources.GetString("pokemon3Ability_cmb.Items266"), resources.GetString("pokemon3Ability_cmb.Items267"), resources.GetString("pokemon3Ability_cmb.Items268"), resources.GetString("pokemon3Ability_cmb.Items269"), resources.GetString("pokemon3Ability_cmb.Items270"), resources.GetString("pokemon3Ability_cmb.Items271"), resources.GetString("pokemon3Ability_cmb.Items272"), resources.GetString("pokemon3Ability_cmb.Items273"), resources.GetString("pokemon3Ability_cmb.Items274"), resources.GetString("pokemon3Ability_cmb.Items275"), resources.GetString("pokemon3Ability_cmb.Items276"), resources.GetString("pokemon3Ability_cmb.Items277"), resources.GetString("pokemon3Ability_cmb.Items278"), resources.GetString("pokemon3Ability_cmb.Items279"), resources.GetString("pokemon3Ability_cmb.Items280"), resources.GetString("pokemon3Ability_cmb.Items281"), resources.GetString("pokemon3Ability_cmb.Items282"), resources.GetString("pokemon3Ability_cmb.Items283"), resources.GetString("pokemon3Ability_cmb.Items284"), resources.GetString("pokemon3Ability_cmb.Items285"), resources.GetString("pokemon3Ability_cmb.Items286"), resources.GetString("pokemon3Ability_cmb.Items287"), resources.GetString("pokemon3Ability_cmb.Items288"), resources.GetString("pokemon3Ability_cmb.Items289"), resources.GetString("pokemon3Ability_cmb.Items290"), resources.GetString("pokemon3Ability_cmb.Items291"), resources.GetString("pokemon3Ability_cmb.Items292"), resources.GetString("pokemon3Ability_cmb.Items293"), resources.GetString("pokemon3Ability_cmb.Items294"), resources.GetString("pokemon3Ability_cmb.Items295"), resources.GetString("pokemon3Ability_cmb.Items296"), resources.GetString("pokemon3Ability_cmb.Items297"), resources.GetString("pokemon3Ability_cmb.Items298"), resources.GetString("pokemon3Ability_cmb.Items299"), resources.GetString("pokemon3Ability_cmb.Items300"), resources.GetString("pokemon3Ability_cmb.Items301"), resources.GetString("pokemon3Ability_cmb.Items302"), resources.GetString("pokemon3Ability_cmb.Items303"), resources.GetString("pokemon3Ability_cmb.Items304")})
        resources.ApplyResources(pokemon3Ability_cmb, "pokemon3Ability_cmb")
        pokemon3Ability_cmb.Name = "pokemon3Ability_cmb"
        ' 
        ' pokemon3Nature_cmb
        ' 
        pokemon3Nature_cmb.FormattingEnabled = True
        pokemon3Nature_cmb.Items.AddRange(New Object() {resources.GetString("pokemon3Nature_cmb.Items"), resources.GetString("pokemon3Nature_cmb.Items1"), resources.GetString("pokemon3Nature_cmb.Items2"), resources.GetString("pokemon3Nature_cmb.Items3"), resources.GetString("pokemon3Nature_cmb.Items4"), resources.GetString("pokemon3Nature_cmb.Items5"), resources.GetString("pokemon3Nature_cmb.Items6"), resources.GetString("pokemon3Nature_cmb.Items7"), resources.GetString("pokemon3Nature_cmb.Items8"), resources.GetString("pokemon3Nature_cmb.Items9"), resources.GetString("pokemon3Nature_cmb.Items10"), resources.GetString("pokemon3Nature_cmb.Items11"), resources.GetString("pokemon3Nature_cmb.Items12"), resources.GetString("pokemon3Nature_cmb.Items13"), resources.GetString("pokemon3Nature_cmb.Items14"), resources.GetString("pokemon3Nature_cmb.Items15"), resources.GetString("pokemon3Nature_cmb.Items16"), resources.GetString("pokemon3Nature_cmb.Items17"), resources.GetString("pokemon3Nature_cmb.Items18"), resources.GetString("pokemon3Nature_cmb.Items19"), resources.GetString("pokemon3Nature_cmb.Items20"), resources.GetString("pokemon3Nature_cmb.Items21"), resources.GetString("pokemon3Nature_cmb.Items22"), resources.GetString("pokemon3Nature_cmb.Items23"), resources.GetString("pokemon3Nature_cmb.Items24"), resources.GetString("pokemon3Nature_cmb.Items25")})
        resources.ApplyResources(pokemon3Nature_cmb, "pokemon3Nature_cmb")
        pokemon3Nature_cmb.Name = "pokemon3Nature_cmb"
        ' 
        ' pokemon3Gender_lbl
        ' 
        resources.ApplyResources(pokemon3Gender_lbl, "pokemon3Gender_lbl")
        pokemon3Gender_lbl.Name = "pokemon3Gender_lbl"
        ' 
        ' pokemon3Nature_lbl
        ' 
        resources.ApplyResources(pokemon3Nature_lbl, "pokemon3Nature_lbl")
        pokemon3Nature_lbl.Name = "pokemon3Nature_lbl"
        ' 
        ' pokemon3Gender_cmb
        ' 
        pokemon3Gender_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        pokemon3Gender_cmb.FormattingEnabled = True
        pokemon3Gender_cmb.Items.AddRange(New Object() {resources.GetString("pokemon3Gender_cmb.Items"), resources.GetString("pokemon3Gender_cmb.Items1"), resources.GetString("pokemon3Gender_cmb.Items2")})
        resources.ApplyResources(pokemon3Gender_cmb, "pokemon3Gender_cmb")
        pokemon3Gender_cmb.Name = "pokemon3Gender_cmb"
        ' 
        ' pokemon3Shiny_grp
        ' 
        pokemon3Shiny_grp.Controls.Add(pokemon3SuperShiny_chkBox)
        pokemon3Shiny_grp.Controls.Add(pokemon3Shiny_rad)
        pokemon3Shiny_grp.Controls.Add(pokemon3NotShiny_rad)
        resources.ApplyResources(pokemon3Shiny_grp, "pokemon3Shiny_grp")
        pokemon3Shiny_grp.Name = "pokemon3Shiny_grp"
        pokemon3Shiny_grp.TabStop = False
        ' 
        ' pokemon3SuperShiny_chkBox
        ' 
        resources.ApplyResources(pokemon3SuperShiny_chkBox, "pokemon3SuperShiny_chkBox")
        pokemon3SuperShiny_chkBox.Name = "pokemon3SuperShiny_chkBox"
        pokemon3SuperShiny_chkBox.UseVisualStyleBackColor = True
        ' 
        ' pokemon3Shiny_rad
        ' 
        resources.ApplyResources(pokemon3Shiny_rad, "pokemon3Shiny_rad")
        pokemon3Shiny_rad.Name = "pokemon3Shiny_rad"
        pokemon3Shiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon3NotShiny_rad
        ' 
        resources.ApplyResources(pokemon3NotShiny_rad, "pokemon3NotShiny_rad")
        pokemon3NotShiny_rad.Checked = True
        pokemon3NotShiny_rad.Name = "pokemon3NotShiny_rad"
        pokemon3NotShiny_rad.TabStop = True
        pokemon3NotShiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon3Form_lbl
        ' 
        resources.ApplyResources(pokemon3Form_lbl, "pokemon3Form_lbl")
        pokemon3Form_lbl.Name = "pokemon3Form_lbl"
        ' 
        ' pg_pkmn4
        ' 
        pg_pkmn4.Controls.Add(pokemon4_grp)
        resources.ApplyResources(pg_pkmn4, "pg_pkmn4")
        pg_pkmn4.Name = "pg_pkmn4"
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
        resources.ApplyResources(pokemon4_grp, "pokemon4_grp")
        pokemon4_grp.Name = "pokemon4_grp"
        pokemon4_grp.TabStop = False
        ' 
        ' pokemon4Level_nbr
        ' 
        resources.ApplyResources(pokemon4Level_nbr, "pokemon4Level_nbr")
        pokemon4Level_nbr.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        pokemon4Level_nbr.Name = "pokemon4Level_nbr"
        pokemon4Level_nbr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' pokemon4Form_nbr
        ' 
        resources.ApplyResources(pokemon4Form_nbr, "pokemon4Form_nbr")
        pokemon4Form_nbr.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        pokemon4Form_nbr.Name = "pokemon4Form_nbr"
        ' 
        ' pokemon4Happiness_nbr
        ' 
        resources.ApplyResources(pokemon4Happiness_nbr, "pokemon4Happiness_nbr")
        pokemon4Happiness_nbr.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        pokemon4Happiness_nbr.Name = "pokemon4Happiness_nbr"
        pokemon4Happiness_nbr.Value = New Decimal(New Integer() {70, 0, 0, 0})
        ' 
        ' pokemon4Shadow_grp
        ' 
        pokemon4Shadow_grp.Controls.Add(pokemon4Shadow_rad)
        pokemon4Shadow_grp.Controls.Add(pokemon4NotShadow_rad)
        resources.ApplyResources(pokemon4Shadow_grp, "pokemon4Shadow_grp")
        pokemon4Shadow_grp.Name = "pokemon4Shadow_grp"
        pokemon4Shadow_grp.TabStop = False
        ' 
        ' pokemon4Shadow_rad
        ' 
        resources.ApplyResources(pokemon4Shadow_rad, "pokemon4Shadow_rad")
        pokemon4Shadow_rad.Name = "pokemon4Shadow_rad"
        pokemon4Shadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon4NotShadow_rad
        ' 
        resources.ApplyResources(pokemon4NotShadow_rad, "pokemon4NotShadow_rad")
        pokemon4NotShadow_rad.Checked = True
        pokemon4NotShadow_rad.Name = "pokemon4NotShadow_rad"
        pokemon4NotShadow_rad.TabStop = True
        pokemon4NotShadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon4Name_lbl
        ' 
        resources.ApplyResources(pokemon4Name_lbl, "pokemon4Name_lbl")
        pokemon4Name_lbl.Name = "pokemon4Name_lbl"
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
        resources.ApplyResources(pokemon4EVs_grp, "pokemon4EVs_grp")
        pokemon4EVs_grp.Name = "pokemon4EVs_grp"
        pokemon4EVs_grp.TabStop = False
        ' 
        ' pokemon4EVsDEF_txt
        ' 
        resources.ApplyResources(pokemon4EVsDEF_txt, "pokemon4EVsDEF_txt")
        pokemon4EVsDEF_txt.Name = "pokemon4EVsDEF_txt"
        ' 
        ' pokemon4EVsDEF_lbl
        ' 
        resources.ApplyResources(pokemon4EVsDEF_lbl, "pokemon4EVsDEF_lbl")
        pokemon4EVsDEF_lbl.Name = "pokemon4EVsDEF_lbl"
        ' 
        ' pokemon4EVsSPDEF_txt
        ' 
        resources.ApplyResources(pokemon4EVsSPDEF_txt, "pokemon4EVsSPDEF_txt")
        pokemon4EVsSPDEF_txt.Name = "pokemon4EVsSPDEF_txt"
        ' 
        ' pokemon4EVsSPDEF_lbl
        ' 
        resources.ApplyResources(pokemon4EVsSPDEF_lbl, "pokemon4EVsSPDEF_lbl")
        pokemon4EVsSPDEF_lbl.Name = "pokemon4EVsSPDEF_lbl"
        ' 
        ' pokemon4EVsSPATK_txt
        ' 
        resources.ApplyResources(pokemon4EVsSPATK_txt, "pokemon4EVsSPATK_txt")
        pokemon4EVsSPATK_txt.Name = "pokemon4EVsSPATK_txt"
        ' 
        ' pokemon4EVsSPATK_lbl
        ' 
        resources.ApplyResources(pokemon4EVsSPATK_lbl, "pokemon4EVsSPATK_lbl")
        pokemon4EVsSPATK_lbl.Name = "pokemon4EVsSPATK_lbl"
        ' 
        ' pokemon4EVsSPD_txt
        ' 
        resources.ApplyResources(pokemon4EVsSPD_txt, "pokemon4EVsSPD_txt")
        pokemon4EVsSPD_txt.Name = "pokemon4EVsSPD_txt"
        ' 
        ' pokemon4EVsSPD_lbl
        ' 
        resources.ApplyResources(pokemon4EVsSPD_lbl, "pokemon4EVsSPD_lbl")
        pokemon4EVsSPD_lbl.Name = "pokemon4EVsSPD_lbl"
        ' 
        ' pokemon4EVsATK_txt
        ' 
        resources.ApplyResources(pokemon4EVsATK_txt, "pokemon4EVsATK_txt")
        pokemon4EVsATK_txt.Name = "pokemon4EVsATK_txt"
        ' 
        ' pokemon4EVsATK_lbl
        ' 
        resources.ApplyResources(pokemon4EVsATK_lbl, "pokemon4EVsATK_lbl")
        pokemon4EVsATK_lbl.Name = "pokemon4EVsATK_lbl"
        ' 
        ' pokemon4EVsHP_txt
        ' 
        resources.ApplyResources(pokemon4EVsHP_txt, "pokemon4EVsHP_txt")
        pokemon4EVsHP_txt.Name = "pokemon4EVsHP_txt"
        ' 
        ' pokemon4EVsHP_lbl
        ' 
        resources.ApplyResources(pokemon4EVsHP_lbl, "pokemon4EVsHP_lbl")
        pokemon4EVsHP_lbl.Name = "pokemon4EVsHP_lbl"
        ' 
        ' pokemon4Name_txt
        ' 
        pokemon4Name_txt.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource1"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource2"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource3"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource4"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource5"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource6"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource7"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource8"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource9"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource10"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource11"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource12"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource13"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource14"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource15"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource16"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource17"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource18"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource19"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource20"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource21"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource22"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource23"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource24"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource25"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource26"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource27"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource28"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource29"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource30"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource31"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource32"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource33"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource34"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource35"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource36"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource37"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource38"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource39"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource40"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource41"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource42"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource43"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource44"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource45"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource46"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource47"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource48"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource49"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource50"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource51"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource52"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource53"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource54"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource55"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource56"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource57"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource58"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource59"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource60"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource61"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource62"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource63"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource64"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource65"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource66"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource67"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource68"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource69"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource70"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource71"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource72"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource73"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource74"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource75"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource76"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource77"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource78"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource79"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource80"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource81"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource82"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource83"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource84"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource85"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource86"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource87"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource88"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource89"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource90"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource91"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource92"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource93"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource94"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource95"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource96"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource97"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource98"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource99"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource100"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource101"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource102"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource103"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource104"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource105"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource106"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource107"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource108"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource109"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource110"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource111"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource112"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource113"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource114"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource115"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource116"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource117"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource118"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource119"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource120"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource121"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource122"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource123"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource124"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource125"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource126"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource127"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource128"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource129"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource130"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource131"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource132"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource133"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource134"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource135"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource136"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource137"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource138"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource139"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource140"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource141"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource142"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource143"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource144"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource145"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource146"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource147"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource148"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource149"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource150"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource151"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource152"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource153"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource154"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource155"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource156"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource157"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource158"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource159"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource160"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource161"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource162"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource163"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource164"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource165"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource166"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource167"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource168"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource169"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource170"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource171"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource172"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource173"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource174"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource175"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource176"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource177"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource178"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource179"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource180"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource181"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource182"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource183"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource184"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource185"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource186"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource187"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource188"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource189"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource190"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource191"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource192"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource193"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource194"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource195"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource196"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource197"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource198"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource199"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource200"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource201"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource202"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource203"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource204"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource205"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource206"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource207"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource208"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource209"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource210"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource211"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource212"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource213"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource214"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource215"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource216"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource217"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource218"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource219"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource220"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource221"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource222"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource223"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource224"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource225"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource226"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource227"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource228"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource229"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource230"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource231"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource232"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource233"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource234"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource235"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource236"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource237"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource238"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource239"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource240"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource241"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource242"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource243"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource244"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource245"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource246"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource247"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource248"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource249"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource250"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource251"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource252"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource253"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource254"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource255"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource256"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource257"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource258"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource259"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource260"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource261"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource262"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource263"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource264"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource265"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource266"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource267"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource268"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource269"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource270"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource271"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource272"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource273"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource274"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource275"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource276"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource277"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource278"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource279"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource280"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource281"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource282"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource283"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource284"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource285"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource286"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource287"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource288"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource289"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource290"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource291"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource292"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource293"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource294"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource295"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource296"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource297"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource298"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource299"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource300"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource301"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource302"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource303"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource304"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource305"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource306"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource307"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource308"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource309"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource310"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource311"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource312"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource313"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource314"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource315"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource316"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource317"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource318"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource319"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource320"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource321"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource322"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource323"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource324"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource325"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource326"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource327"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource328"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource329"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource330"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource331"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource332"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource333"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource334"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource335"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource336"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource337"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource338"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource339"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource340"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource341"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource342"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource343"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource344"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource345"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource346"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource347"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource348"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource349"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource350"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource351"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource352"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource353"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource354"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource355"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource356"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource357"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource358"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource359"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource360"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource361"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource362"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource363"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource364"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource365"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource366"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource367"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource368"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource369"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource370"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource371"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource372"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource373"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource374"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource375"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource376"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource377"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource378"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource379"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource380"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource381"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource382"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource383"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource384"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource385"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource386"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource387"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource388"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource389"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource390"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource391"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource392"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource393"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource394"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource395"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource396"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource397"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource398"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource399"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource400"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource401"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource402"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource403"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource404"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource405"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource406"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource407"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource408"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource409"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource410"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource411"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource412"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource413"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource414"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource415"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource416"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource417"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource418"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource419"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource420"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource421"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource422"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource423"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource424"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource425"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource426"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource427"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource428"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource429"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource430"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource431"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource432"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource433"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource434"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource435"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource436"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource437"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource438"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource439"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource440"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource441"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource442"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource443"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource444"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource445"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource446"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource447"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource448"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource449"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource450"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource451"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource452"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource453"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource454"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource455"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource456"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource457"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource458"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource459"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource460"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource461"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource462"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource463"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource464"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource465"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource466"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource467"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource468"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource469"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource470"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource471"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource472"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource473"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource474"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource475"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource476"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource477"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource478"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource479"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource480"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource481"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource482"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource483"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource484"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource485"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource486"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource487"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource488"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource489"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource490"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource491"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource492"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource493"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource494"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource495"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource496"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource497"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource498"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource499"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource500"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource501"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource502"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource503"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource504"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource505"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource506"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource507"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource508"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource509"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource510"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource511"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource512"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource513"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource514"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource515"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource516"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource517"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource518"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource519"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource520"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource521"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource522"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource523"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource524"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource525"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource526"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource527"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource528"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource529"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource530"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource531"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource532"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource533"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource534"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource535"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource536"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource537"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource538"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource539"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource540"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource541"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource542"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource543"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource544"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource545"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource546"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource547"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource548"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource549"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource550"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource551"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource552"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource553"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource554"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource555"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource556"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource557"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource558"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource559"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource560"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource561"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource562"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource563"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource564"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource565"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource566"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource567"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource568"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource569"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource570"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource571"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource572"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource573"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource574"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource575"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource576"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource577"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource578"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource579"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource580"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource581"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource582"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource583"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource584"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource585"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource586"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource587"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource588"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource589"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource590"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource591"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource592"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource593"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource594"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource595"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource596"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource597"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource598"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource599"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource600"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource601"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource602"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource603"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource604"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource605"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource606"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource607"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource608"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource609"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource610"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource611"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource612"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource613"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource614"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource615"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource616"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource617"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource618"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource619"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource620"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource621"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource622"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource623"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource624"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource625"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource626"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource627"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource628"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource629"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource630"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource631"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource632"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource633"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource634"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource635"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource636"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource637"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource638"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource639"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource640"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource641"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource642"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource643"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource644"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource645"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource646"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource647"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource648"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource649"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource650"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource651"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource652"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource653"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource654"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource655"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource656"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource657"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource658"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource659"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource660"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource661"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource662"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource663"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource664"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource665"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource666"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource667"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource668"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource669"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource670"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource671"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource672"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource673"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource674"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource675"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource676"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource677"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource678"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource679"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource680"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource681"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource682"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource683"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource684"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource685"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource686"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource687"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource688"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource689"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource690"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource691"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource692"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource693"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource694"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource695"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource696"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource697"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource698"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource699"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource700"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource701"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource702"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource703"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource704"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource705"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource706"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource707"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource708"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource709"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource710"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource711"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource712"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource713"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource714"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource715"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource716"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource717"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource718"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource719"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource720"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource721"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource722"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource723"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource724"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource725"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource726"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource727"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource728"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource729"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource730"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource731"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource732"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource733"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource734"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource735"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource736"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource737"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource738"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource739"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource740"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource741"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource742"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource743"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource744"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource745"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource746"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource747"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource748"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource749"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource750"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource751"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource752"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource753"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource754"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource755"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource756"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource757"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource758"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource759"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource760"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource761"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource762"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource763"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource764"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource765"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource766"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource767"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource768"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource769"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource770"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource771"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource772"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource773"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource774"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource775"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource776"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource777"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource778"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource779"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource780"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource781"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource782"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource783"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource784"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource785"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource786"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource787"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource788"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource789"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource790"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource791"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource792"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource793"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource794"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource795"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource796"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource797"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource798"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource799"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource800"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource801"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource802"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource803"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource804"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource805"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource806"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource807"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource808"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource809"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource810"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource811"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource812"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource813"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource814"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource815"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource816"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource817"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource818"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource819"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource820"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource821"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource822"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource823"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource824"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource825"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource826"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource827"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource828"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource829"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource830"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource831"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource832"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource833"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource834"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource835"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource836"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource837"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource838"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource839"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource840"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource841"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource842"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource843"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource844"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource845"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource846"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource847"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource848"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource849"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource850"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource851"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource852"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource853"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource854"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource855"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource856"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource857"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource858"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource859"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource860"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource861"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource862"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource863"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource864"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource865"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource866"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource867"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource868"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource869"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource870"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource871"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource872"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource873"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource874"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource875"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource876"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource877"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource878"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource879"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource880"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource881"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource882"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource883"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource884"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource885"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource886"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource887"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource888"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource889"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource890"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource891"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource892"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource893"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource894"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource895"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource896"), resources.GetString("pokemon4Name_txt.AutoCompleteCustomSource897")})
        pokemon4Name_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon4Name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource
        resources.ApplyResources(pokemon4Name_txt, "pokemon4Name_txt")
        pokemon4Name_txt.Name = "pokemon4Name_txt"
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
        resources.ApplyResources(pokemon4IVs_grp, "pokemon4IVs_grp")
        pokemon4IVs_grp.Name = "pokemon4IVs_grp"
        pokemon4IVs_grp.TabStop = False
        ' 
        ' pokemon4RandomIVs_btn
        ' 
        resources.ApplyResources(pokemon4RandomIVs_btn, "pokemon4RandomIVs_btn")
        pokemon4RandomIVs_btn.Name = "pokemon4RandomIVs_btn"
        pokemon4RandomIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon4MaxIVs_btn
        ' 
        resources.ApplyResources(pokemon4MaxIVs_btn, "pokemon4MaxIVs_btn")
        pokemon4MaxIVs_btn.Name = "pokemon4MaxIVs_btn"
        pokemon4MaxIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon4IVsDEF_txt
        ' 
        resources.ApplyResources(pokemon4IVsDEF_txt, "pokemon4IVsDEF_txt")
        pokemon4IVsDEF_txt.Name = "pokemon4IVsDEF_txt"
        ' 
        ' pokemon4IVsDEF_lbl
        ' 
        resources.ApplyResources(pokemon4IVsDEF_lbl, "pokemon4IVsDEF_lbl")
        pokemon4IVsDEF_lbl.Name = "pokemon4IVsDEF_lbl"
        ' 
        ' pokemon4IVsSPDEF_txt
        ' 
        resources.ApplyResources(pokemon4IVsSPDEF_txt, "pokemon4IVsSPDEF_txt")
        pokemon4IVsSPDEF_txt.Name = "pokemon4IVsSPDEF_txt"
        ' 
        ' pokemon4IVsSPDEF_lbl
        ' 
        resources.ApplyResources(pokemon4IVsSPDEF_lbl, "pokemon4IVsSPDEF_lbl")
        pokemon4IVsSPDEF_lbl.Name = "pokemon4IVsSPDEF_lbl"
        ' 
        ' pokemon4IVsSPATK_txt
        ' 
        resources.ApplyResources(pokemon4IVsSPATK_txt, "pokemon4IVsSPATK_txt")
        pokemon4IVsSPATK_txt.Name = "pokemon4IVsSPATK_txt"
        ' 
        ' pokemon4IVsSPATK_lbl
        ' 
        resources.ApplyResources(pokemon4IVsSPATK_lbl, "pokemon4IVsSPATK_lbl")
        pokemon4IVsSPATK_lbl.Name = "pokemon4IVsSPATK_lbl"
        ' 
        ' pokemon4IVsSPD_txt
        ' 
        resources.ApplyResources(pokemon4IVsSPD_txt, "pokemon4IVsSPD_txt")
        pokemon4IVsSPD_txt.Name = "pokemon4IVsSPD_txt"
        ' 
        ' pokemon4IVsSPD_lbl
        ' 
        resources.ApplyResources(pokemon4IVsSPD_lbl, "pokemon4IVsSPD_lbl")
        pokemon4IVsSPD_lbl.Name = "pokemon4IVsSPD_lbl"
        ' 
        ' pokemon4IVsATK_txt
        ' 
        resources.ApplyResources(pokemon4IVsATK_txt, "pokemon4IVsATK_txt")
        pokemon4IVsATK_txt.Name = "pokemon4IVsATK_txt"
        ' 
        ' pokemon4IVsATK_lbl
        ' 
        resources.ApplyResources(pokemon4IVsATK_lbl, "pokemon4IVsATK_lbl")
        pokemon4IVsATK_lbl.Name = "pokemon4IVsATK_lbl"
        ' 
        ' pokemon4IVsHP_txt
        ' 
        resources.ApplyResources(pokemon4IVsHP_txt, "pokemon4IVsHP_txt")
        pokemon4IVsHP_txt.Name = "pokemon4IVsHP_txt"
        ' 
        ' pokemon4IVsHP_lbl
        ' 
        resources.ApplyResources(pokemon4IVsHP_lbl, "pokemon4IVsHP_lbl")
        pokemon4IVsHP_lbl.Name = "pokemon4IVsHP_lbl"
        ' 
        ' pokemon4HeldItem_txt
        ' 
        resources.ApplyResources(pokemon4HeldItem_txt, "pokemon4HeldItem_txt")
        pokemon4HeldItem_txt.Name = "pokemon4HeldItem_txt"
        ' 
        ' pokemon4PokeballID_cmb
        ' 
        pokemon4PokeballID_cmb.FormattingEnabled = True
        pokemon4PokeballID_cmb.Items.AddRange(New Object() {resources.GetString("pokemon4PokeballID_cmb.Items"), resources.GetString("pokemon4PokeballID_cmb.Items1"), resources.GetString("pokemon4PokeballID_cmb.Items2"), resources.GetString("pokemon4PokeballID_cmb.Items3"), resources.GetString("pokemon4PokeballID_cmb.Items4"), resources.GetString("pokemon4PokeballID_cmb.Items5"), resources.GetString("pokemon4PokeballID_cmb.Items6"), resources.GetString("pokemon4PokeballID_cmb.Items7"), resources.GetString("pokemon4PokeballID_cmb.Items8"), resources.GetString("pokemon4PokeballID_cmb.Items9"), resources.GetString("pokemon4PokeballID_cmb.Items10"), resources.GetString("pokemon4PokeballID_cmb.Items11"), resources.GetString("pokemon4PokeballID_cmb.Items12"), resources.GetString("pokemon4PokeballID_cmb.Items13"), resources.GetString("pokemon4PokeballID_cmb.Items14"), resources.GetString("pokemon4PokeballID_cmb.Items15"), resources.GetString("pokemon4PokeballID_cmb.Items16"), resources.GetString("pokemon4PokeballID_cmb.Items17"), resources.GetString("pokemon4PokeballID_cmb.Items18"), resources.GetString("pokemon4PokeballID_cmb.Items19"), resources.GetString("pokemon4PokeballID_cmb.Items20"), resources.GetString("pokemon4PokeballID_cmb.Items21"), resources.GetString("pokemon4PokeballID_cmb.Items22"), resources.GetString("pokemon4PokeballID_cmb.Items23"), resources.GetString("pokemon4PokeballID_cmb.Items24"), resources.GetString("pokemon4PokeballID_cmb.Items25")})
        resources.ApplyResources(pokemon4PokeballID_cmb, "pokemon4PokeballID_cmb")
        pokemon4PokeballID_cmb.Name = "pokemon4PokeballID_cmb"
        ' 
        ' pokemon4HeldItem_lbl
        ' 
        resources.ApplyResources(pokemon4HeldItem_lbl, "pokemon4HeldItem_lbl")
        pokemon4HeldItem_lbl.Name = "pokemon4HeldItem_lbl"
        ' 
        ' pokemon4PokeBall_lbl
        ' 
        resources.ApplyResources(pokemon4PokeBall_lbl, "pokemon4PokeBall_lbl")
        pokemon4PokeBall_lbl.Name = "pokemon4PokeBall_lbl"
        ' 
        ' pokemon4Level_lbl
        ' 
        resources.ApplyResources(pokemon4Level_lbl, "pokemon4Level_lbl")
        pokemon4Level_lbl.Name = "pokemon4Level_lbl"
        ' 
        ' pokemon4Nickname_txt
        ' 
        resources.ApplyResources(pokemon4Nickname_txt, "pokemon4Nickname_txt")
        pokemon4Nickname_txt.Name = "pokemon4Nickname_txt"
        ' 
        ' pokemon4Nickname_lbl
        ' 
        resources.ApplyResources(pokemon4Nickname_lbl, "pokemon4Nickname_lbl")
        pokemon4Nickname_lbl.Name = "pokemon4Nickname_lbl"
        ' 
        ' pokemon4Moves_grp
        ' 
        pokemon4Moves_grp.Controls.Add(pokemon4Move4_txtBox)
        pokemon4Moves_grp.Controls.Add(pokemon4Move3_txtBox)
        pokemon4Moves_grp.Controls.Add(pokemon4Move2_txtBox)
        pokemon4Moves_grp.Controls.Add(pokemon4Move1_txtBox)
        resources.ApplyResources(pokemon4Moves_grp, "pokemon4Moves_grp")
        pokemon4Moves_grp.Name = "pokemon4Moves_grp"
        pokemon4Moves_grp.TabStop = False
        ' 
        ' pokemon4Move4_txtBox
        ' 
        resources.ApplyResources(pokemon4Move4_txtBox, "pokemon4Move4_txtBox")
        pokemon4Move4_txtBox.Name = "pokemon4Move4_txtBox"
        ' 
        ' pokemon4Move3_txtBox
        ' 
        resources.ApplyResources(pokemon4Move3_txtBox, "pokemon4Move3_txtBox")
        pokemon4Move3_txtBox.Name = "pokemon4Move3_txtBox"
        ' 
        ' pokemon4Move2_txtBox
        ' 
        resources.ApplyResources(pokemon4Move2_txtBox, "pokemon4Move2_txtBox")
        pokemon4Move2_txtBox.Name = "pokemon4Move2_txtBox"
        ' 
        ' pokemon4Move1_txtBox
        ' 
        resources.ApplyResources(pokemon4Move1_txtBox, "pokemon4Move1_txtBox")
        pokemon4Move1_txtBox.Name = "pokemon4Move1_txtBox"
        ' 
        ' pokemon4Ability_lbl
        ' 
        resources.ApplyResources(pokemon4Ability_lbl, "pokemon4Ability_lbl")
        pokemon4Ability_lbl.Name = "pokemon4Ability_lbl"
        ' 
        ' pokemon4Happiness_lbl
        ' 
        resources.ApplyResources(pokemon4Happiness_lbl, "pokemon4Happiness_lbl")
        pokemon4Happiness_lbl.Name = "pokemon4Happiness_lbl"
        ' 
        ' pokemon4Ability_cmb
        ' 
        pokemon4Ability_cmb.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource1"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource2"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource3"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource4"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource5"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource6"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource7"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource8"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource9"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource10"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource11"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource12"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource13"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource14"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource15"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource16"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource17"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource18"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource19"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource20"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource21"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource22"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource23"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource24"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource25"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource26"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource27"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource28"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource29"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource30"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource31"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource32"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource33"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource34"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource35"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource36"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource37"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource38"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource39"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource40"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource41"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource42"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource43"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource44"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource45"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource46"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource47"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource48"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource49"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource50"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource51"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource52"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource53"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource54"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource55"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource56"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource57"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource58"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource59"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource60"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource61"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource62"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource63"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource64"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource65"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource66"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource67"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource68"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource69"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource70"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource71"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource72"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource73"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource74"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource75"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource76"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource77"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource78"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource79"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource80"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource81"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource82"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource83"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource84"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource85"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource86"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource87"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource88"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource89"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource90"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource91"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource92"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource93"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource94"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource95"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource96"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource97"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource98"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource99"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource100"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource101"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource102"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource103"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource104"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource105"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource106"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource107"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource108"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource109"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource110"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource111"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource112"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource113"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource114"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource115"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource116"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource117"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource118"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource119"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource120"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource121"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource122"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource123"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource124"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource125"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource126"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource127"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource128"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource129"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource130"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource131"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource132"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource133"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource134"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource135"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource136"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource137"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource138"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource139"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource140"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource141"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource142"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource143"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource144"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource145"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource146"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource147"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource148"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource149"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource150"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource151"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource152"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource153"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource154"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource155"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource156"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource157"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource158"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource159"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource160"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource161"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource162"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource163"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource164"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource165"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource166"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource167"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource168"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource169"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource170"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource171"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource172"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource173"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource174"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource175"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource176"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource177"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource178"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource179"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource180"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource181"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource182"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource183"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource184"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource185"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource186"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource187"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource188"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource189"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource190"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource191"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource192"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource193"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource194"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource195"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource196"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource197"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource198"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource199"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource200"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource201"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource202"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource203"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource204"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource205"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource206"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource207"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource208"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource209"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource210"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource211"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource212"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource213"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource214"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource215"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource216"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource217"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource218"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource219"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource220"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource221"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource222"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource223"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource224"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource225"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource226"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource227"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource228"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource229"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource230"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource231"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource232"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource233"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource234"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource235"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource236"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource237"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource238"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource239"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource240"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource241"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource242"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource243"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource244"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource245"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource246"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource247"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource248"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource249"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource250"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource251"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource252"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource253"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource254"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource255"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource256"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource257"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource258"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource259"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource260"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource261"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource262"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource263"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource264"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource265"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource266"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource267"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource268"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource269"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource270"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource271"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource272"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource273"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource274"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource275"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource276"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource277"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource278"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource279"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource280"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource281"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource282"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource283"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource284"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource285"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource286"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource287"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource288"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource289"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource290"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource291"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource292"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource293"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource294"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource295"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource296"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource297"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource298"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource299"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource300"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource301"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource302"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource303"), resources.GetString("pokemon4Ability_cmb.AutoCompleteCustomSource304")})
        pokemon4Ability_cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon4Ability_cmb.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon4Ability_cmb.FormattingEnabled = True
        pokemon4Ability_cmb.Items.AddRange(New Object() {resources.GetString("pokemon4Ability_cmb.Items"), resources.GetString("pokemon4Ability_cmb.Items1"), resources.GetString("pokemon4Ability_cmb.Items2"), resources.GetString("pokemon4Ability_cmb.Items3"), resources.GetString("pokemon4Ability_cmb.Items4"), resources.GetString("pokemon4Ability_cmb.Items5"), resources.GetString("pokemon4Ability_cmb.Items6"), resources.GetString("pokemon4Ability_cmb.Items7"), resources.GetString("pokemon4Ability_cmb.Items8"), resources.GetString("pokemon4Ability_cmb.Items9"), resources.GetString("pokemon4Ability_cmb.Items10"), resources.GetString("pokemon4Ability_cmb.Items11"), resources.GetString("pokemon4Ability_cmb.Items12"), resources.GetString("pokemon4Ability_cmb.Items13"), resources.GetString("pokemon4Ability_cmb.Items14"), resources.GetString("pokemon4Ability_cmb.Items15"), resources.GetString("pokemon4Ability_cmb.Items16"), resources.GetString("pokemon4Ability_cmb.Items17"), resources.GetString("pokemon4Ability_cmb.Items18"), resources.GetString("pokemon4Ability_cmb.Items19"), resources.GetString("pokemon4Ability_cmb.Items20"), resources.GetString("pokemon4Ability_cmb.Items21"), resources.GetString("pokemon4Ability_cmb.Items22"), resources.GetString("pokemon4Ability_cmb.Items23"), resources.GetString("pokemon4Ability_cmb.Items24"), resources.GetString("pokemon4Ability_cmb.Items25"), resources.GetString("pokemon4Ability_cmb.Items26"), resources.GetString("pokemon4Ability_cmb.Items27"), resources.GetString("pokemon4Ability_cmb.Items28"), resources.GetString("pokemon4Ability_cmb.Items29"), resources.GetString("pokemon4Ability_cmb.Items30"), resources.GetString("pokemon4Ability_cmb.Items31"), resources.GetString("pokemon4Ability_cmb.Items32"), resources.GetString("pokemon4Ability_cmb.Items33"), resources.GetString("pokemon4Ability_cmb.Items34"), resources.GetString("pokemon4Ability_cmb.Items35"), resources.GetString("pokemon4Ability_cmb.Items36"), resources.GetString("pokemon4Ability_cmb.Items37"), resources.GetString("pokemon4Ability_cmb.Items38"), resources.GetString("pokemon4Ability_cmb.Items39"), resources.GetString("pokemon4Ability_cmb.Items40"), resources.GetString("pokemon4Ability_cmb.Items41"), resources.GetString("pokemon4Ability_cmb.Items42"), resources.GetString("pokemon4Ability_cmb.Items43"), resources.GetString("pokemon4Ability_cmb.Items44"), resources.GetString("pokemon4Ability_cmb.Items45"), resources.GetString("pokemon4Ability_cmb.Items46"), resources.GetString("pokemon4Ability_cmb.Items47"), resources.GetString("pokemon4Ability_cmb.Items48"), resources.GetString("pokemon4Ability_cmb.Items49"), resources.GetString("pokemon4Ability_cmb.Items50"), resources.GetString("pokemon4Ability_cmb.Items51"), resources.GetString("pokemon4Ability_cmb.Items52"), resources.GetString("pokemon4Ability_cmb.Items53"), resources.GetString("pokemon4Ability_cmb.Items54"), resources.GetString("pokemon4Ability_cmb.Items55"), resources.GetString("pokemon4Ability_cmb.Items56"), resources.GetString("pokemon4Ability_cmb.Items57"), resources.GetString("pokemon4Ability_cmb.Items58"), resources.GetString("pokemon4Ability_cmb.Items59"), resources.GetString("pokemon4Ability_cmb.Items60"), resources.GetString("pokemon4Ability_cmb.Items61"), resources.GetString("pokemon4Ability_cmb.Items62"), resources.GetString("pokemon4Ability_cmb.Items63"), resources.GetString("pokemon4Ability_cmb.Items64"), resources.GetString("pokemon4Ability_cmb.Items65"), resources.GetString("pokemon4Ability_cmb.Items66"), resources.GetString("pokemon4Ability_cmb.Items67"), resources.GetString("pokemon4Ability_cmb.Items68"), resources.GetString("pokemon4Ability_cmb.Items69"), resources.GetString("pokemon4Ability_cmb.Items70"), resources.GetString("pokemon4Ability_cmb.Items71"), resources.GetString("pokemon4Ability_cmb.Items72"), resources.GetString("pokemon4Ability_cmb.Items73"), resources.GetString("pokemon4Ability_cmb.Items74"), resources.GetString("pokemon4Ability_cmb.Items75"), resources.GetString("pokemon4Ability_cmb.Items76"), resources.GetString("pokemon4Ability_cmb.Items77"), resources.GetString("pokemon4Ability_cmb.Items78"), resources.GetString("pokemon4Ability_cmb.Items79"), resources.GetString("pokemon4Ability_cmb.Items80"), resources.GetString("pokemon4Ability_cmb.Items81"), resources.GetString("pokemon4Ability_cmb.Items82"), resources.GetString("pokemon4Ability_cmb.Items83"), resources.GetString("pokemon4Ability_cmb.Items84"), resources.GetString("pokemon4Ability_cmb.Items85"), resources.GetString("pokemon4Ability_cmb.Items86"), resources.GetString("pokemon4Ability_cmb.Items87"), resources.GetString("pokemon4Ability_cmb.Items88"), resources.GetString("pokemon4Ability_cmb.Items89"), resources.GetString("pokemon4Ability_cmb.Items90"), resources.GetString("pokemon4Ability_cmb.Items91"), resources.GetString("pokemon4Ability_cmb.Items92"), resources.GetString("pokemon4Ability_cmb.Items93"), resources.GetString("pokemon4Ability_cmb.Items94"), resources.GetString("pokemon4Ability_cmb.Items95"), resources.GetString("pokemon4Ability_cmb.Items96"), resources.GetString("pokemon4Ability_cmb.Items97"), resources.GetString("pokemon4Ability_cmb.Items98"), resources.GetString("pokemon4Ability_cmb.Items99"), resources.GetString("pokemon4Ability_cmb.Items100"), resources.GetString("pokemon4Ability_cmb.Items101"), resources.GetString("pokemon4Ability_cmb.Items102"), resources.GetString("pokemon4Ability_cmb.Items103"), resources.GetString("pokemon4Ability_cmb.Items104"), resources.GetString("pokemon4Ability_cmb.Items105"), resources.GetString("pokemon4Ability_cmb.Items106"), resources.GetString("pokemon4Ability_cmb.Items107"), resources.GetString("pokemon4Ability_cmb.Items108"), resources.GetString("pokemon4Ability_cmb.Items109"), resources.GetString("pokemon4Ability_cmb.Items110"), resources.GetString("pokemon4Ability_cmb.Items111"), resources.GetString("pokemon4Ability_cmb.Items112"), resources.GetString("pokemon4Ability_cmb.Items113"), resources.GetString("pokemon4Ability_cmb.Items114"), resources.GetString("pokemon4Ability_cmb.Items115"), resources.GetString("pokemon4Ability_cmb.Items116"), resources.GetString("pokemon4Ability_cmb.Items117"), resources.GetString("pokemon4Ability_cmb.Items118"), resources.GetString("pokemon4Ability_cmb.Items119"), resources.GetString("pokemon4Ability_cmb.Items120"), resources.GetString("pokemon4Ability_cmb.Items121"), resources.GetString("pokemon4Ability_cmb.Items122"), resources.GetString("pokemon4Ability_cmb.Items123"), resources.GetString("pokemon4Ability_cmb.Items124"), resources.GetString("pokemon4Ability_cmb.Items125"), resources.GetString("pokemon4Ability_cmb.Items126"), resources.GetString("pokemon4Ability_cmb.Items127"), resources.GetString("pokemon4Ability_cmb.Items128"), resources.GetString("pokemon4Ability_cmb.Items129"), resources.GetString("pokemon4Ability_cmb.Items130"), resources.GetString("pokemon4Ability_cmb.Items131"), resources.GetString("pokemon4Ability_cmb.Items132"), resources.GetString("pokemon4Ability_cmb.Items133"), resources.GetString("pokemon4Ability_cmb.Items134"), resources.GetString("pokemon4Ability_cmb.Items135"), resources.GetString("pokemon4Ability_cmb.Items136"), resources.GetString("pokemon4Ability_cmb.Items137"), resources.GetString("pokemon4Ability_cmb.Items138"), resources.GetString("pokemon4Ability_cmb.Items139"), resources.GetString("pokemon4Ability_cmb.Items140"), resources.GetString("pokemon4Ability_cmb.Items141"), resources.GetString("pokemon4Ability_cmb.Items142"), resources.GetString("pokemon4Ability_cmb.Items143"), resources.GetString("pokemon4Ability_cmb.Items144"), resources.GetString("pokemon4Ability_cmb.Items145"), resources.GetString("pokemon4Ability_cmb.Items146"), resources.GetString("pokemon4Ability_cmb.Items147"), resources.GetString("pokemon4Ability_cmb.Items148"), resources.GetString("pokemon4Ability_cmb.Items149"), resources.GetString("pokemon4Ability_cmb.Items150"), resources.GetString("pokemon4Ability_cmb.Items151"), resources.GetString("pokemon4Ability_cmb.Items152"), resources.GetString("pokemon4Ability_cmb.Items153"), resources.GetString("pokemon4Ability_cmb.Items154"), resources.GetString("pokemon4Ability_cmb.Items155"), resources.GetString("pokemon4Ability_cmb.Items156"), resources.GetString("pokemon4Ability_cmb.Items157"), resources.GetString("pokemon4Ability_cmb.Items158"), resources.GetString("pokemon4Ability_cmb.Items159"), resources.GetString("pokemon4Ability_cmb.Items160"), resources.GetString("pokemon4Ability_cmb.Items161"), resources.GetString("pokemon4Ability_cmb.Items162"), resources.GetString("pokemon4Ability_cmb.Items163"), resources.GetString("pokemon4Ability_cmb.Items164"), resources.GetString("pokemon4Ability_cmb.Items165"), resources.GetString("pokemon4Ability_cmb.Items166"), resources.GetString("pokemon4Ability_cmb.Items167"), resources.GetString("pokemon4Ability_cmb.Items168"), resources.GetString("pokemon4Ability_cmb.Items169"), resources.GetString("pokemon4Ability_cmb.Items170"), resources.GetString("pokemon4Ability_cmb.Items171"), resources.GetString("pokemon4Ability_cmb.Items172"), resources.GetString("pokemon4Ability_cmb.Items173"), resources.GetString("pokemon4Ability_cmb.Items174"), resources.GetString("pokemon4Ability_cmb.Items175"), resources.GetString("pokemon4Ability_cmb.Items176"), resources.GetString("pokemon4Ability_cmb.Items177"), resources.GetString("pokemon4Ability_cmb.Items178"), resources.GetString("pokemon4Ability_cmb.Items179"), resources.GetString("pokemon4Ability_cmb.Items180"), resources.GetString("pokemon4Ability_cmb.Items181"), resources.GetString("pokemon4Ability_cmb.Items182"), resources.GetString("pokemon4Ability_cmb.Items183"), resources.GetString("pokemon4Ability_cmb.Items184"), resources.GetString("pokemon4Ability_cmb.Items185"), resources.GetString("pokemon4Ability_cmb.Items186"), resources.GetString("pokemon4Ability_cmb.Items187"), resources.GetString("pokemon4Ability_cmb.Items188"), resources.GetString("pokemon4Ability_cmb.Items189"), resources.GetString("pokemon4Ability_cmb.Items190"), resources.GetString("pokemon4Ability_cmb.Items191"), resources.GetString("pokemon4Ability_cmb.Items192"), resources.GetString("pokemon4Ability_cmb.Items193"), resources.GetString("pokemon4Ability_cmb.Items194"), resources.GetString("pokemon4Ability_cmb.Items195"), resources.GetString("pokemon4Ability_cmb.Items196"), resources.GetString("pokemon4Ability_cmb.Items197"), resources.GetString("pokemon4Ability_cmb.Items198"), resources.GetString("pokemon4Ability_cmb.Items199"), resources.GetString("pokemon4Ability_cmb.Items200"), resources.GetString("pokemon4Ability_cmb.Items201"), resources.GetString("pokemon4Ability_cmb.Items202"), resources.GetString("pokemon4Ability_cmb.Items203"), resources.GetString("pokemon4Ability_cmb.Items204"), resources.GetString("pokemon4Ability_cmb.Items205"), resources.GetString("pokemon4Ability_cmb.Items206"), resources.GetString("pokemon4Ability_cmb.Items207"), resources.GetString("pokemon4Ability_cmb.Items208"), resources.GetString("pokemon4Ability_cmb.Items209"), resources.GetString("pokemon4Ability_cmb.Items210"), resources.GetString("pokemon4Ability_cmb.Items211"), resources.GetString("pokemon4Ability_cmb.Items212"), resources.GetString("pokemon4Ability_cmb.Items213"), resources.GetString("pokemon4Ability_cmb.Items214"), resources.GetString("pokemon4Ability_cmb.Items215"), resources.GetString("pokemon4Ability_cmb.Items216"), resources.GetString("pokemon4Ability_cmb.Items217"), resources.GetString("pokemon4Ability_cmb.Items218"), resources.GetString("pokemon4Ability_cmb.Items219"), resources.GetString("pokemon4Ability_cmb.Items220"), resources.GetString("pokemon4Ability_cmb.Items221"), resources.GetString("pokemon4Ability_cmb.Items222"), resources.GetString("pokemon4Ability_cmb.Items223"), resources.GetString("pokemon4Ability_cmb.Items224"), resources.GetString("pokemon4Ability_cmb.Items225"), resources.GetString("pokemon4Ability_cmb.Items226"), resources.GetString("pokemon4Ability_cmb.Items227"), resources.GetString("pokemon4Ability_cmb.Items228"), resources.GetString("pokemon4Ability_cmb.Items229"), resources.GetString("pokemon4Ability_cmb.Items230"), resources.GetString("pokemon4Ability_cmb.Items231"), resources.GetString("pokemon4Ability_cmb.Items232"), resources.GetString("pokemon4Ability_cmb.Items233"), resources.GetString("pokemon4Ability_cmb.Items234"), resources.GetString("pokemon4Ability_cmb.Items235"), resources.GetString("pokemon4Ability_cmb.Items236"), resources.GetString("pokemon4Ability_cmb.Items237"), resources.GetString("pokemon4Ability_cmb.Items238"), resources.GetString("pokemon4Ability_cmb.Items239"), resources.GetString("pokemon4Ability_cmb.Items240"), resources.GetString("pokemon4Ability_cmb.Items241"), resources.GetString("pokemon4Ability_cmb.Items242"), resources.GetString("pokemon4Ability_cmb.Items243"), resources.GetString("pokemon4Ability_cmb.Items244"), resources.GetString("pokemon4Ability_cmb.Items245"), resources.GetString("pokemon4Ability_cmb.Items246"), resources.GetString("pokemon4Ability_cmb.Items247"), resources.GetString("pokemon4Ability_cmb.Items248"), resources.GetString("pokemon4Ability_cmb.Items249"), resources.GetString("pokemon4Ability_cmb.Items250"), resources.GetString("pokemon4Ability_cmb.Items251"), resources.GetString("pokemon4Ability_cmb.Items252"), resources.GetString("pokemon4Ability_cmb.Items253"), resources.GetString("pokemon4Ability_cmb.Items254"), resources.GetString("pokemon4Ability_cmb.Items255"), resources.GetString("pokemon4Ability_cmb.Items256"), resources.GetString("pokemon4Ability_cmb.Items257"), resources.GetString("pokemon4Ability_cmb.Items258"), resources.GetString("pokemon4Ability_cmb.Items259"), resources.GetString("pokemon4Ability_cmb.Items260"), resources.GetString("pokemon4Ability_cmb.Items261"), resources.GetString("pokemon4Ability_cmb.Items262"), resources.GetString("pokemon4Ability_cmb.Items263"), resources.GetString("pokemon4Ability_cmb.Items264"), resources.GetString("pokemon4Ability_cmb.Items265"), resources.GetString("pokemon4Ability_cmb.Items266"), resources.GetString("pokemon4Ability_cmb.Items267"), resources.GetString("pokemon4Ability_cmb.Items268"), resources.GetString("pokemon4Ability_cmb.Items269"), resources.GetString("pokemon4Ability_cmb.Items270"), resources.GetString("pokemon4Ability_cmb.Items271"), resources.GetString("pokemon4Ability_cmb.Items272"), resources.GetString("pokemon4Ability_cmb.Items273"), resources.GetString("pokemon4Ability_cmb.Items274"), resources.GetString("pokemon4Ability_cmb.Items275"), resources.GetString("pokemon4Ability_cmb.Items276"), resources.GetString("pokemon4Ability_cmb.Items277"), resources.GetString("pokemon4Ability_cmb.Items278"), resources.GetString("pokemon4Ability_cmb.Items279"), resources.GetString("pokemon4Ability_cmb.Items280"), resources.GetString("pokemon4Ability_cmb.Items281"), resources.GetString("pokemon4Ability_cmb.Items282"), resources.GetString("pokemon4Ability_cmb.Items283"), resources.GetString("pokemon4Ability_cmb.Items284"), resources.GetString("pokemon4Ability_cmb.Items285"), resources.GetString("pokemon4Ability_cmb.Items286"), resources.GetString("pokemon4Ability_cmb.Items287"), resources.GetString("pokemon4Ability_cmb.Items288"), resources.GetString("pokemon4Ability_cmb.Items289"), resources.GetString("pokemon4Ability_cmb.Items290"), resources.GetString("pokemon4Ability_cmb.Items291"), resources.GetString("pokemon4Ability_cmb.Items292"), resources.GetString("pokemon4Ability_cmb.Items293"), resources.GetString("pokemon4Ability_cmb.Items294"), resources.GetString("pokemon4Ability_cmb.Items295"), resources.GetString("pokemon4Ability_cmb.Items296"), resources.GetString("pokemon4Ability_cmb.Items297"), resources.GetString("pokemon4Ability_cmb.Items298"), resources.GetString("pokemon4Ability_cmb.Items299"), resources.GetString("pokemon4Ability_cmb.Items300"), resources.GetString("pokemon4Ability_cmb.Items301"), resources.GetString("pokemon4Ability_cmb.Items302"), resources.GetString("pokemon4Ability_cmb.Items303"), resources.GetString("pokemon4Ability_cmb.Items304")})
        resources.ApplyResources(pokemon4Ability_cmb, "pokemon4Ability_cmb")
        pokemon4Ability_cmb.Name = "pokemon4Ability_cmb"
        ' 
        ' pokemon4Nature_cmb
        ' 
        pokemon4Nature_cmb.FormattingEnabled = True
        pokemon4Nature_cmb.Items.AddRange(New Object() {resources.GetString("pokemon4Nature_cmb.Items"), resources.GetString("pokemon4Nature_cmb.Items1"), resources.GetString("pokemon4Nature_cmb.Items2"), resources.GetString("pokemon4Nature_cmb.Items3"), resources.GetString("pokemon4Nature_cmb.Items4"), resources.GetString("pokemon4Nature_cmb.Items5"), resources.GetString("pokemon4Nature_cmb.Items6"), resources.GetString("pokemon4Nature_cmb.Items7"), resources.GetString("pokemon4Nature_cmb.Items8"), resources.GetString("pokemon4Nature_cmb.Items9"), resources.GetString("pokemon4Nature_cmb.Items10"), resources.GetString("pokemon4Nature_cmb.Items11"), resources.GetString("pokemon4Nature_cmb.Items12"), resources.GetString("pokemon4Nature_cmb.Items13"), resources.GetString("pokemon4Nature_cmb.Items14"), resources.GetString("pokemon4Nature_cmb.Items15"), resources.GetString("pokemon4Nature_cmb.Items16"), resources.GetString("pokemon4Nature_cmb.Items17"), resources.GetString("pokemon4Nature_cmb.Items18"), resources.GetString("pokemon4Nature_cmb.Items19"), resources.GetString("pokemon4Nature_cmb.Items20"), resources.GetString("pokemon4Nature_cmb.Items21"), resources.GetString("pokemon4Nature_cmb.Items22"), resources.GetString("pokemon4Nature_cmb.Items23"), resources.GetString("pokemon4Nature_cmb.Items24"), resources.GetString("pokemon4Nature_cmb.Items25")})
        resources.ApplyResources(pokemon4Nature_cmb, "pokemon4Nature_cmb")
        pokemon4Nature_cmb.Name = "pokemon4Nature_cmb"
        ' 
        ' pokemon4Gender_lbl
        ' 
        resources.ApplyResources(pokemon4Gender_lbl, "pokemon4Gender_lbl")
        pokemon4Gender_lbl.Name = "pokemon4Gender_lbl"
        ' 
        ' pokemon4Nature_lbl
        ' 
        resources.ApplyResources(pokemon4Nature_lbl, "pokemon4Nature_lbl")
        pokemon4Nature_lbl.Name = "pokemon4Nature_lbl"
        ' 
        ' pokemon4Gender_cmb
        ' 
        pokemon4Gender_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        pokemon4Gender_cmb.FormattingEnabled = True
        pokemon4Gender_cmb.Items.AddRange(New Object() {resources.GetString("pokemon4Gender_cmb.Items"), resources.GetString("pokemon4Gender_cmb.Items1"), resources.GetString("pokemon4Gender_cmb.Items2")})
        resources.ApplyResources(pokemon4Gender_cmb, "pokemon4Gender_cmb")
        pokemon4Gender_cmb.Name = "pokemon4Gender_cmb"
        ' 
        ' pokemon4Shiny_grp
        ' 
        pokemon4Shiny_grp.Controls.Add(pokemon4SuperShiny_chkBox)
        pokemon4Shiny_grp.Controls.Add(pokemon4Shiny_rad)
        pokemon4Shiny_grp.Controls.Add(pokemon4NotShiny_rad)
        resources.ApplyResources(pokemon4Shiny_grp, "pokemon4Shiny_grp")
        pokemon4Shiny_grp.Name = "pokemon4Shiny_grp"
        pokemon4Shiny_grp.TabStop = False
        ' 
        ' pokemon4SuperShiny_chkBox
        ' 
        resources.ApplyResources(pokemon4SuperShiny_chkBox, "pokemon4SuperShiny_chkBox")
        pokemon4SuperShiny_chkBox.Name = "pokemon4SuperShiny_chkBox"
        pokemon4SuperShiny_chkBox.UseVisualStyleBackColor = True
        ' 
        ' pokemon4Shiny_rad
        ' 
        resources.ApplyResources(pokemon4Shiny_rad, "pokemon4Shiny_rad")
        pokemon4Shiny_rad.Name = "pokemon4Shiny_rad"
        pokemon4Shiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon4NotShiny_rad
        ' 
        resources.ApplyResources(pokemon4NotShiny_rad, "pokemon4NotShiny_rad")
        pokemon4NotShiny_rad.Checked = True
        pokemon4NotShiny_rad.Name = "pokemon4NotShiny_rad"
        pokemon4NotShiny_rad.TabStop = True
        pokemon4NotShiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon4Form_lbl
        ' 
        resources.ApplyResources(pokemon4Form_lbl, "pokemon4Form_lbl")
        pokemon4Form_lbl.Name = "pokemon4Form_lbl"
        ' 
        ' pg_pkmn5
        ' 
        pg_pkmn5.Controls.Add(pokemon5_grp)
        resources.ApplyResources(pg_pkmn5, "pg_pkmn5")
        pg_pkmn5.Name = "pg_pkmn5"
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
        resources.ApplyResources(pokemon5_grp, "pokemon5_grp")
        pokemon5_grp.Name = "pokemon5_grp"
        pokemon5_grp.TabStop = False
        ' 
        ' pokemon5Level_nbr
        ' 
        resources.ApplyResources(pokemon5Level_nbr, "pokemon5Level_nbr")
        pokemon5Level_nbr.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        pokemon5Level_nbr.Name = "pokemon5Level_nbr"
        pokemon5Level_nbr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' pokemon5Form_nbr
        ' 
        resources.ApplyResources(pokemon5Form_nbr, "pokemon5Form_nbr")
        pokemon5Form_nbr.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        pokemon5Form_nbr.Name = "pokemon5Form_nbr"
        ' 
        ' pokemon5Happiness_nbr
        ' 
        resources.ApplyResources(pokemon5Happiness_nbr, "pokemon5Happiness_nbr")
        pokemon5Happiness_nbr.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        pokemon5Happiness_nbr.Name = "pokemon5Happiness_nbr"
        pokemon5Happiness_nbr.Value = New Decimal(New Integer() {70, 0, 0, 0})
        ' 
        ' pokemon5Shadow_grp
        ' 
        pokemon5Shadow_grp.Controls.Add(pokemon5Shadow_rad)
        pokemon5Shadow_grp.Controls.Add(pokemon5NotShadow_rad)
        resources.ApplyResources(pokemon5Shadow_grp, "pokemon5Shadow_grp")
        pokemon5Shadow_grp.Name = "pokemon5Shadow_grp"
        pokemon5Shadow_grp.TabStop = False
        ' 
        ' pokemon5Shadow_rad
        ' 
        resources.ApplyResources(pokemon5Shadow_rad, "pokemon5Shadow_rad")
        pokemon5Shadow_rad.Name = "pokemon5Shadow_rad"
        pokemon5Shadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon5NotShadow_rad
        ' 
        resources.ApplyResources(pokemon5NotShadow_rad, "pokemon5NotShadow_rad")
        pokemon5NotShadow_rad.Checked = True
        pokemon5NotShadow_rad.Name = "pokemon5NotShadow_rad"
        pokemon5NotShadow_rad.TabStop = True
        pokemon5NotShadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon5Name_lbl
        ' 
        resources.ApplyResources(pokemon5Name_lbl, "pokemon5Name_lbl")
        pokemon5Name_lbl.Name = "pokemon5Name_lbl"
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
        resources.ApplyResources(pokemon5EVs_grp, "pokemon5EVs_grp")
        pokemon5EVs_grp.Name = "pokemon5EVs_grp"
        pokemon5EVs_grp.TabStop = False
        ' 
        ' pokemon5EVsDEF_txt
        ' 
        resources.ApplyResources(pokemon5EVsDEF_txt, "pokemon5EVsDEF_txt")
        pokemon5EVsDEF_txt.Name = "pokemon5EVsDEF_txt"
        ' 
        ' pokemon5EVsDEF_lbl
        ' 
        resources.ApplyResources(pokemon5EVsDEF_lbl, "pokemon5EVsDEF_lbl")
        pokemon5EVsDEF_lbl.Name = "pokemon5EVsDEF_lbl"
        ' 
        ' pokemon5EVsSPDEF_txt
        ' 
        resources.ApplyResources(pokemon5EVsSPDEF_txt, "pokemon5EVsSPDEF_txt")
        pokemon5EVsSPDEF_txt.Name = "pokemon5EVsSPDEF_txt"
        ' 
        ' pokemon5EVsSPDEF_lbl
        ' 
        resources.ApplyResources(pokemon5EVsSPDEF_lbl, "pokemon5EVsSPDEF_lbl")
        pokemon5EVsSPDEF_lbl.Name = "pokemon5EVsSPDEF_lbl"
        ' 
        ' pokemon5EVsSPATK_txt
        ' 
        resources.ApplyResources(pokemon5EVsSPATK_txt, "pokemon5EVsSPATK_txt")
        pokemon5EVsSPATK_txt.Name = "pokemon5EVsSPATK_txt"
        ' 
        ' pokemon5EVsSPATK_lbl
        ' 
        resources.ApplyResources(pokemon5EVsSPATK_lbl, "pokemon5EVsSPATK_lbl")
        pokemon5EVsSPATK_lbl.Name = "pokemon5EVsSPATK_lbl"
        ' 
        ' pokemon5EVsSPD_txt
        ' 
        resources.ApplyResources(pokemon5EVsSPD_txt, "pokemon5EVsSPD_txt")
        pokemon5EVsSPD_txt.Name = "pokemon5EVsSPD_txt"
        ' 
        ' pokemon5EVsSPD_lbl
        ' 
        resources.ApplyResources(pokemon5EVsSPD_lbl, "pokemon5EVsSPD_lbl")
        pokemon5EVsSPD_lbl.Name = "pokemon5EVsSPD_lbl"
        ' 
        ' pokemon5EVsATK_txt
        ' 
        resources.ApplyResources(pokemon5EVsATK_txt, "pokemon5EVsATK_txt")
        pokemon5EVsATK_txt.Name = "pokemon5EVsATK_txt"
        ' 
        ' pokemon5EVsATK_lbl
        ' 
        resources.ApplyResources(pokemon5EVsATK_lbl, "pokemon5EVsATK_lbl")
        pokemon5EVsATK_lbl.Name = "pokemon5EVsATK_lbl"
        ' 
        ' pokemon5EVsHP_txt
        ' 
        resources.ApplyResources(pokemon5EVsHP_txt, "pokemon5EVsHP_txt")
        pokemon5EVsHP_txt.Name = "pokemon5EVsHP_txt"
        ' 
        ' pokemon5EVsHP_lbl
        ' 
        resources.ApplyResources(pokemon5EVsHP_lbl, "pokemon5EVsHP_lbl")
        pokemon5EVsHP_lbl.Name = "pokemon5EVsHP_lbl"
        ' 
        ' pokemon5Name_txt
        ' 
        pokemon5Name_txt.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource1"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource2"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource3"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource4"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource5"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource6"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource7"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource8"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource9"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource10"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource11"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource12"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource13"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource14"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource15"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource16"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource17"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource18"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource19"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource20"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource21"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource22"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource23"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource24"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource25"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource26"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource27"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource28"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource29"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource30"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource31"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource32"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource33"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource34"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource35"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource36"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource37"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource38"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource39"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource40"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource41"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource42"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource43"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource44"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource45"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource46"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource47"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource48"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource49"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource50"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource51"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource52"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource53"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource54"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource55"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource56"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource57"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource58"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource59"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource60"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource61"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource62"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource63"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource64"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource65"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource66"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource67"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource68"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource69"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource70"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource71"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource72"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource73"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource74"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource75"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource76"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource77"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource78"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource79"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource80"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource81"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource82"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource83"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource84"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource85"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource86"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource87"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource88"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource89"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource90"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource91"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource92"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource93"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource94"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource95"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource96"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource97"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource98"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource99"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource100"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource101"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource102"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource103"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource104"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource105"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource106"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource107"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource108"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource109"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource110"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource111"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource112"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource113"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource114"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource115"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource116"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource117"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource118"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource119"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource120"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource121"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource122"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource123"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource124"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource125"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource126"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource127"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource128"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource129"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource130"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource131"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource132"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource133"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource134"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource135"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource136"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource137"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource138"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource139"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource140"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource141"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource142"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource143"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource144"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource145"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource146"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource147"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource148"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource149"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource150"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource151"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource152"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource153"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource154"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource155"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource156"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource157"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource158"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource159"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource160"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource161"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource162"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource163"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource164"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource165"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource166"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource167"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource168"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource169"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource170"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource171"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource172"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource173"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource174"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource175"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource176"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource177"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource178"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource179"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource180"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource181"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource182"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource183"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource184"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource185"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource186"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource187"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource188"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource189"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource190"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource191"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource192"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource193"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource194"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource195"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource196"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource197"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource198"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource199"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource200"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource201"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource202"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource203"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource204"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource205"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource206"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource207"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource208"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource209"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource210"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource211"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource212"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource213"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource214"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource215"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource216"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource217"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource218"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource219"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource220"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource221"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource222"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource223"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource224"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource225"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource226"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource227"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource228"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource229"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource230"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource231"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource232"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource233"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource234"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource235"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource236"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource237"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource238"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource239"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource240"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource241"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource242"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource243"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource244"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource245"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource246"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource247"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource248"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource249"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource250"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource251"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource252"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource253"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource254"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource255"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource256"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource257"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource258"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource259"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource260"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource261"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource262"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource263"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource264"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource265"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource266"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource267"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource268"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource269"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource270"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource271"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource272"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource273"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource274"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource275"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource276"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource277"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource278"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource279"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource280"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource281"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource282"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource283"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource284"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource285"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource286"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource287"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource288"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource289"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource290"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource291"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource292"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource293"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource294"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource295"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource296"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource297"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource298"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource299"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource300"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource301"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource302"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource303"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource304"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource305"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource306"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource307"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource308"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource309"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource310"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource311"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource312"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource313"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource314"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource315"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource316"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource317"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource318"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource319"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource320"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource321"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource322"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource323"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource324"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource325"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource326"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource327"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource328"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource329"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource330"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource331"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource332"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource333"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource334"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource335"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource336"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource337"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource338"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource339"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource340"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource341"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource342"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource343"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource344"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource345"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource346"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource347"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource348"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource349"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource350"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource351"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource352"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource353"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource354"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource355"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource356"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource357"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource358"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource359"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource360"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource361"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource362"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource363"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource364"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource365"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource366"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource367"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource368"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource369"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource370"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource371"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource372"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource373"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource374"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource375"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource376"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource377"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource378"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource379"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource380"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource381"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource382"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource383"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource384"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource385"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource386"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource387"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource388"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource389"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource390"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource391"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource392"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource393"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource394"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource395"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource396"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource397"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource398"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource399"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource400"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource401"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource402"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource403"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource404"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource405"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource406"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource407"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource408"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource409"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource410"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource411"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource412"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource413"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource414"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource415"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource416"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource417"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource418"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource419"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource420"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource421"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource422"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource423"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource424"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource425"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource426"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource427"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource428"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource429"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource430"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource431"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource432"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource433"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource434"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource435"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource436"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource437"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource438"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource439"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource440"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource441"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource442"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource443"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource444"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource445"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource446"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource447"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource448"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource449"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource450"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource451"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource452"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource453"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource454"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource455"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource456"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource457"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource458"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource459"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource460"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource461"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource462"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource463"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource464"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource465"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource466"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource467"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource468"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource469"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource470"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource471"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource472"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource473"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource474"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource475"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource476"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource477"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource478"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource479"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource480"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource481"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource482"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource483"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource484"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource485"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource486"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource487"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource488"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource489"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource490"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource491"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource492"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource493"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource494"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource495"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource496"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource497"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource498"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource499"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource500"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource501"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource502"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource503"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource504"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource505"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource506"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource507"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource508"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource509"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource510"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource511"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource512"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource513"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource514"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource515"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource516"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource517"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource518"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource519"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource520"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource521"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource522"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource523"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource524"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource525"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource526"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource527"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource528"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource529"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource530"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource531"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource532"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource533"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource534"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource535"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource536"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource537"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource538"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource539"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource540"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource541"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource542"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource543"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource544"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource545"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource546"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource547"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource548"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource549"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource550"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource551"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource552"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource553"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource554"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource555"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource556"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource557"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource558"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource559"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource560"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource561"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource562"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource563"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource564"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource565"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource566"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource567"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource568"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource569"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource570"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource571"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource572"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource573"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource574"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource575"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource576"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource577"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource578"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource579"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource580"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource581"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource582"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource583"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource584"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource585"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource586"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource587"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource588"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource589"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource590"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource591"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource592"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource593"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource594"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource595"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource596"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource597"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource598"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource599"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource600"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource601"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource602"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource603"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource604"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource605"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource606"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource607"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource608"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource609"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource610"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource611"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource612"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource613"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource614"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource615"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource616"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource617"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource618"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource619"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource620"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource621"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource622"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource623"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource624"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource625"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource626"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource627"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource628"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource629"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource630"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource631"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource632"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource633"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource634"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource635"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource636"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource637"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource638"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource639"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource640"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource641"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource642"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource643"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource644"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource645"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource646"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource647"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource648"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource649"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource650"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource651"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource652"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource653"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource654"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource655"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource656"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource657"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource658"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource659"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource660"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource661"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource662"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource663"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource664"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource665"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource666"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource667"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource668"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource669"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource670"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource671"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource672"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource673"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource674"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource675"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource676"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource677"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource678"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource679"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource680"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource681"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource682"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource683"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource684"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource685"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource686"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource687"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource688"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource689"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource690"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource691"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource692"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource693"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource694"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource695"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource696"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource697"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource698"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource699"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource700"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource701"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource702"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource703"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource704"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource705"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource706"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource707"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource708"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource709"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource710"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource711"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource712"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource713"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource714"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource715"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource716"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource717"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource718"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource719"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource720"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource721"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource722"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource723"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource724"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource725"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource726"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource727"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource728"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource729"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource730"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource731"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource732"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource733"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource734"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource735"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource736"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource737"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource738"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource739"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource740"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource741"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource742"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource743"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource744"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource745"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource746"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource747"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource748"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource749"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource750"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource751"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource752"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource753"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource754"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource755"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource756"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource757"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource758"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource759"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource760"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource761"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource762"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource763"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource764"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource765"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource766"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource767"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource768"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource769"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource770"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource771"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource772"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource773"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource774"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource775"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource776"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource777"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource778"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource779"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource780"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource781"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource782"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource783"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource784"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource785"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource786"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource787"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource788"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource789"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource790"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource791"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource792"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource793"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource794"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource795"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource796"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource797"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource798"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource799"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource800"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource801"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource802"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource803"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource804"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource805"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource806"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource807"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource808"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource809"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource810"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource811"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource812"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource813"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource814"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource815"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource816"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource817"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource818"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource819"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource820"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource821"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource822"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource823"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource824"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource825"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource826"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource827"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource828"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource829"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource830"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource831"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource832"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource833"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource834"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource835"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource836"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource837"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource838"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource839"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource840"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource841"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource842"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource843"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource844"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource845"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource846"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource847"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource848"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource849"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource850"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource851"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource852"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource853"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource854"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource855"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource856"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource857"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource858"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource859"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource860"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource861"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource862"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource863"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource864"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource865"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource866"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource867"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource868"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource869"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource870"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource871"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource872"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource873"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource874"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource875"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource876"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource877"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource878"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource879"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource880"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource881"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource882"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource883"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource884"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource885"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource886"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource887"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource888"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource889"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource890"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource891"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource892"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource893"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource894"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource895"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource896"), resources.GetString("pokemon5Name_txt.AutoCompleteCustomSource897")})
        pokemon5Name_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon5Name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource
        resources.ApplyResources(pokemon5Name_txt, "pokemon5Name_txt")
        pokemon5Name_txt.Name = "pokemon5Name_txt"
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
        resources.ApplyResources(pokemon5IVs_grp, "pokemon5IVs_grp")
        pokemon5IVs_grp.Name = "pokemon5IVs_grp"
        pokemon5IVs_grp.TabStop = False
        ' 
        ' pokemon5RandomIVs_btn
        ' 
        resources.ApplyResources(pokemon5RandomIVs_btn, "pokemon5RandomIVs_btn")
        pokemon5RandomIVs_btn.Name = "pokemon5RandomIVs_btn"
        pokemon5RandomIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon5MaxIVs_btn
        ' 
        resources.ApplyResources(pokemon5MaxIVs_btn, "pokemon5MaxIVs_btn")
        pokemon5MaxIVs_btn.Name = "pokemon5MaxIVs_btn"
        pokemon5MaxIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon5IVsDEF_txt
        ' 
        resources.ApplyResources(pokemon5IVsDEF_txt, "pokemon5IVsDEF_txt")
        pokemon5IVsDEF_txt.Name = "pokemon5IVsDEF_txt"
        ' 
        ' pokemon5IVsDEF_lbl
        ' 
        resources.ApplyResources(pokemon5IVsDEF_lbl, "pokemon5IVsDEF_lbl")
        pokemon5IVsDEF_lbl.Name = "pokemon5IVsDEF_lbl"
        ' 
        ' pokemon5IVsSPDEF_txt
        ' 
        resources.ApplyResources(pokemon5IVsSPDEF_txt, "pokemon5IVsSPDEF_txt")
        pokemon5IVsSPDEF_txt.Name = "pokemon5IVsSPDEF_txt"
        ' 
        ' pokemon5IVsSPDEF_lbl
        ' 
        resources.ApplyResources(pokemon5IVsSPDEF_lbl, "pokemon5IVsSPDEF_lbl")
        pokemon5IVsSPDEF_lbl.Name = "pokemon5IVsSPDEF_lbl"
        ' 
        ' pokemon5IVsSPATK_txt
        ' 
        resources.ApplyResources(pokemon5IVsSPATK_txt, "pokemon5IVsSPATK_txt")
        pokemon5IVsSPATK_txt.Name = "pokemon5IVsSPATK_txt"
        ' 
        ' pokemon5IVsSPATK_lbl
        ' 
        resources.ApplyResources(pokemon5IVsSPATK_lbl, "pokemon5IVsSPATK_lbl")
        pokemon5IVsSPATK_lbl.Name = "pokemon5IVsSPATK_lbl"
        ' 
        ' pokemon5IVsSPD_txt
        ' 
        resources.ApplyResources(pokemon5IVsSPD_txt, "pokemon5IVsSPD_txt")
        pokemon5IVsSPD_txt.Name = "pokemon5IVsSPD_txt"
        ' 
        ' pokemon5IVsSPD_lbl
        ' 
        resources.ApplyResources(pokemon5IVsSPD_lbl, "pokemon5IVsSPD_lbl")
        pokemon5IVsSPD_lbl.Name = "pokemon5IVsSPD_lbl"
        ' 
        ' pokemon5IVsATK_txt
        ' 
        resources.ApplyResources(pokemon5IVsATK_txt, "pokemon5IVsATK_txt")
        pokemon5IVsATK_txt.Name = "pokemon5IVsATK_txt"
        ' 
        ' pokemon5IVsATK_lbl
        ' 
        resources.ApplyResources(pokemon5IVsATK_lbl, "pokemon5IVsATK_lbl")
        pokemon5IVsATK_lbl.Name = "pokemon5IVsATK_lbl"
        ' 
        ' pokemon5IVsHP_txt
        ' 
        resources.ApplyResources(pokemon5IVsHP_txt, "pokemon5IVsHP_txt")
        pokemon5IVsHP_txt.Name = "pokemon5IVsHP_txt"
        ' 
        ' pokemon5IVsHP_lbl
        ' 
        resources.ApplyResources(pokemon5IVsHP_lbl, "pokemon5IVsHP_lbl")
        pokemon5IVsHP_lbl.Name = "pokemon5IVsHP_lbl"
        ' 
        ' pokemon5HeldItem_txt
        ' 
        resources.ApplyResources(pokemon5HeldItem_txt, "pokemon5HeldItem_txt")
        pokemon5HeldItem_txt.Name = "pokemon5HeldItem_txt"
        ' 
        ' pokemon5PokeballID_cmb
        ' 
        pokemon5PokeballID_cmb.FormattingEnabled = True
        pokemon5PokeballID_cmb.Items.AddRange(New Object() {resources.GetString("pokemon5PokeballID_cmb.Items"), resources.GetString("pokemon5PokeballID_cmb.Items1"), resources.GetString("pokemon5PokeballID_cmb.Items2"), resources.GetString("pokemon5PokeballID_cmb.Items3"), resources.GetString("pokemon5PokeballID_cmb.Items4"), resources.GetString("pokemon5PokeballID_cmb.Items5"), resources.GetString("pokemon5PokeballID_cmb.Items6"), resources.GetString("pokemon5PokeballID_cmb.Items7"), resources.GetString("pokemon5PokeballID_cmb.Items8"), resources.GetString("pokemon5PokeballID_cmb.Items9"), resources.GetString("pokemon5PokeballID_cmb.Items10"), resources.GetString("pokemon5PokeballID_cmb.Items11"), resources.GetString("pokemon5PokeballID_cmb.Items12"), resources.GetString("pokemon5PokeballID_cmb.Items13"), resources.GetString("pokemon5PokeballID_cmb.Items14"), resources.GetString("pokemon5PokeballID_cmb.Items15"), resources.GetString("pokemon5PokeballID_cmb.Items16"), resources.GetString("pokemon5PokeballID_cmb.Items17"), resources.GetString("pokemon5PokeballID_cmb.Items18"), resources.GetString("pokemon5PokeballID_cmb.Items19"), resources.GetString("pokemon5PokeballID_cmb.Items20"), resources.GetString("pokemon5PokeballID_cmb.Items21"), resources.GetString("pokemon5PokeballID_cmb.Items22"), resources.GetString("pokemon5PokeballID_cmb.Items23"), resources.GetString("pokemon5PokeballID_cmb.Items24"), resources.GetString("pokemon5PokeballID_cmb.Items25")})
        resources.ApplyResources(pokemon5PokeballID_cmb, "pokemon5PokeballID_cmb")
        pokemon5PokeballID_cmb.Name = "pokemon5PokeballID_cmb"
        ' 
        ' pokemon5HeldItem_lbl
        ' 
        resources.ApplyResources(pokemon5HeldItem_lbl, "pokemon5HeldItem_lbl")
        pokemon5HeldItem_lbl.Name = "pokemon5HeldItem_lbl"
        ' 
        ' pokemon5PokeBall_lbl
        ' 
        resources.ApplyResources(pokemon5PokeBall_lbl, "pokemon5PokeBall_lbl")
        pokemon5PokeBall_lbl.Name = "pokemon5PokeBall_lbl"
        ' 
        ' pokemon5Level_lbl
        ' 
        resources.ApplyResources(pokemon5Level_lbl, "pokemon5Level_lbl")
        pokemon5Level_lbl.Name = "pokemon5Level_lbl"
        ' 
        ' pokemon5Nickname_txt
        ' 
        resources.ApplyResources(pokemon5Nickname_txt, "pokemon5Nickname_txt")
        pokemon5Nickname_txt.Name = "pokemon5Nickname_txt"
        ' 
        ' pokemon5Nickname_lbl
        ' 
        resources.ApplyResources(pokemon5Nickname_lbl, "pokemon5Nickname_lbl")
        pokemon5Nickname_lbl.Name = "pokemon5Nickname_lbl"
        ' 
        ' pokemon5Moves_grp
        ' 
        pokemon5Moves_grp.Controls.Add(pokemon5Move4_txt)
        pokemon5Moves_grp.Controls.Add(pokemon5Move3_txt)
        pokemon5Moves_grp.Controls.Add(pokemon5Move2_txt)
        pokemon5Moves_grp.Controls.Add(pokemon5Move1_txt)
        resources.ApplyResources(pokemon5Moves_grp, "pokemon5Moves_grp")
        pokemon5Moves_grp.Name = "pokemon5Moves_grp"
        pokemon5Moves_grp.TabStop = False
        ' 
        ' pokemon5Move4_txt
        ' 
        resources.ApplyResources(pokemon5Move4_txt, "pokemon5Move4_txt")
        pokemon5Move4_txt.Name = "pokemon5Move4_txt"
        ' 
        ' pokemon5Move3_txt
        ' 
        resources.ApplyResources(pokemon5Move3_txt, "pokemon5Move3_txt")
        pokemon5Move3_txt.Name = "pokemon5Move3_txt"
        ' 
        ' pokemon5Move2_txt
        ' 
        resources.ApplyResources(pokemon5Move2_txt, "pokemon5Move2_txt")
        pokemon5Move2_txt.Name = "pokemon5Move2_txt"
        ' 
        ' pokemon5Move1_txt
        ' 
        resources.ApplyResources(pokemon5Move1_txt, "pokemon5Move1_txt")
        pokemon5Move1_txt.Name = "pokemon5Move1_txt"
        ' 
        ' pokemon5Ability_lbl
        ' 
        resources.ApplyResources(pokemon5Ability_lbl, "pokemon5Ability_lbl")
        pokemon5Ability_lbl.Name = "pokemon5Ability_lbl"
        ' 
        ' pokemon5Happiness_lbl
        ' 
        resources.ApplyResources(pokemon5Happiness_lbl, "pokemon5Happiness_lbl")
        pokemon5Happiness_lbl.Name = "pokemon5Happiness_lbl"
        ' 
        ' pokemon5Ability_cmb
        ' 
        pokemon5Ability_cmb.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource1"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource2"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource3"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource4"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource5"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource6"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource7"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource8"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource9"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource10"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource11"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource12"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource13"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource14"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource15"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource16"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource17"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource18"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource19"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource20"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource21"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource22"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource23"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource24"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource25"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource26"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource27"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource28"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource29"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource30"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource31"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource32"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource33"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource34"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource35"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource36"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource37"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource38"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource39"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource40"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource41"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource42"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource43"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource44"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource45"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource46"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource47"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource48"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource49"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource50"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource51"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource52"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource53"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource54"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource55"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource56"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource57"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource58"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource59"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource60"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource61"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource62"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource63"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource64"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource65"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource66"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource67"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource68"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource69"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource70"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource71"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource72"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource73"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource74"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource75"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource76"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource77"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource78"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource79"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource80"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource81"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource82"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource83"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource84"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource85"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource86"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource87"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource88"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource89"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource90"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource91"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource92"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource93"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource94"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource95"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource96"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource97"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource98"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource99"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource100"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource101"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource102"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource103"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource104"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource105"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource106"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource107"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource108"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource109"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource110"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource111"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource112"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource113"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource114"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource115"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource116"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource117"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource118"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource119"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource120"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource121"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource122"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource123"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource124"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource125"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource126"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource127"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource128"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource129"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource130"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource131"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource132"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource133"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource134"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource135"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource136"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource137"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource138"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource139"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource140"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource141"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource142"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource143"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource144"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource145"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource146"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource147"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource148"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource149"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource150"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource151"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource152"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource153"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource154"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource155"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource156"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource157"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource158"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource159"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource160"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource161"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource162"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource163"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource164"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource165"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource166"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource167"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource168"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource169"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource170"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource171"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource172"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource173"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource174"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource175"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource176"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource177"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource178"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource179"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource180"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource181"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource182"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource183"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource184"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource185"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource186"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource187"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource188"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource189"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource190"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource191"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource192"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource193"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource194"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource195"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource196"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource197"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource198"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource199"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource200"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource201"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource202"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource203"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource204"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource205"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource206"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource207"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource208"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource209"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource210"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource211"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource212"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource213"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource214"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource215"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource216"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource217"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource218"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource219"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource220"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource221"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource222"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource223"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource224"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource225"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource226"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource227"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource228"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource229"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource230"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource231"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource232"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource233"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource234"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource235"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource236"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource237"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource238"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource239"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource240"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource241"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource242"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource243"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource244"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource245"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource246"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource247"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource248"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource249"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource250"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource251"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource252"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource253"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource254"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource255"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource256"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource257"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource258"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource259"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource260"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource261"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource262"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource263"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource264"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource265"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource266"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource267"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource268"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource269"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource270"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource271"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource272"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource273"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource274"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource275"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource276"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource277"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource278"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource279"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource280"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource281"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource282"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource283"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource284"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource285"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource286"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource287"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource288"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource289"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource290"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource291"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource292"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource293"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource294"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource295"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource296"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource297"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource298"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource299"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource300"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource301"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource302"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource303"), resources.GetString("pokemon5Ability_cmb.AutoCompleteCustomSource304")})
        pokemon5Ability_cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon5Ability_cmb.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon5Ability_cmb.FormattingEnabled = True
        pokemon5Ability_cmb.Items.AddRange(New Object() {resources.GetString("pokemon5Ability_cmb.Items"), resources.GetString("pokemon5Ability_cmb.Items1"), resources.GetString("pokemon5Ability_cmb.Items2"), resources.GetString("pokemon5Ability_cmb.Items3"), resources.GetString("pokemon5Ability_cmb.Items4"), resources.GetString("pokemon5Ability_cmb.Items5"), resources.GetString("pokemon5Ability_cmb.Items6"), resources.GetString("pokemon5Ability_cmb.Items7"), resources.GetString("pokemon5Ability_cmb.Items8"), resources.GetString("pokemon5Ability_cmb.Items9"), resources.GetString("pokemon5Ability_cmb.Items10"), resources.GetString("pokemon5Ability_cmb.Items11"), resources.GetString("pokemon5Ability_cmb.Items12"), resources.GetString("pokemon5Ability_cmb.Items13"), resources.GetString("pokemon5Ability_cmb.Items14"), resources.GetString("pokemon5Ability_cmb.Items15"), resources.GetString("pokemon5Ability_cmb.Items16"), resources.GetString("pokemon5Ability_cmb.Items17"), resources.GetString("pokemon5Ability_cmb.Items18"), resources.GetString("pokemon5Ability_cmb.Items19"), resources.GetString("pokemon5Ability_cmb.Items20"), resources.GetString("pokemon5Ability_cmb.Items21"), resources.GetString("pokemon5Ability_cmb.Items22"), resources.GetString("pokemon5Ability_cmb.Items23"), resources.GetString("pokemon5Ability_cmb.Items24"), resources.GetString("pokemon5Ability_cmb.Items25"), resources.GetString("pokemon5Ability_cmb.Items26"), resources.GetString("pokemon5Ability_cmb.Items27"), resources.GetString("pokemon5Ability_cmb.Items28"), resources.GetString("pokemon5Ability_cmb.Items29"), resources.GetString("pokemon5Ability_cmb.Items30"), resources.GetString("pokemon5Ability_cmb.Items31"), resources.GetString("pokemon5Ability_cmb.Items32"), resources.GetString("pokemon5Ability_cmb.Items33"), resources.GetString("pokemon5Ability_cmb.Items34"), resources.GetString("pokemon5Ability_cmb.Items35"), resources.GetString("pokemon5Ability_cmb.Items36"), resources.GetString("pokemon5Ability_cmb.Items37"), resources.GetString("pokemon5Ability_cmb.Items38"), resources.GetString("pokemon5Ability_cmb.Items39"), resources.GetString("pokemon5Ability_cmb.Items40"), resources.GetString("pokemon5Ability_cmb.Items41"), resources.GetString("pokemon5Ability_cmb.Items42"), resources.GetString("pokemon5Ability_cmb.Items43"), resources.GetString("pokemon5Ability_cmb.Items44"), resources.GetString("pokemon5Ability_cmb.Items45"), resources.GetString("pokemon5Ability_cmb.Items46"), resources.GetString("pokemon5Ability_cmb.Items47"), resources.GetString("pokemon5Ability_cmb.Items48"), resources.GetString("pokemon5Ability_cmb.Items49"), resources.GetString("pokemon5Ability_cmb.Items50"), resources.GetString("pokemon5Ability_cmb.Items51"), resources.GetString("pokemon5Ability_cmb.Items52"), resources.GetString("pokemon5Ability_cmb.Items53"), resources.GetString("pokemon5Ability_cmb.Items54"), resources.GetString("pokemon5Ability_cmb.Items55"), resources.GetString("pokemon5Ability_cmb.Items56"), resources.GetString("pokemon5Ability_cmb.Items57"), resources.GetString("pokemon5Ability_cmb.Items58"), resources.GetString("pokemon5Ability_cmb.Items59"), resources.GetString("pokemon5Ability_cmb.Items60"), resources.GetString("pokemon5Ability_cmb.Items61"), resources.GetString("pokemon5Ability_cmb.Items62"), resources.GetString("pokemon5Ability_cmb.Items63"), resources.GetString("pokemon5Ability_cmb.Items64"), resources.GetString("pokemon5Ability_cmb.Items65"), resources.GetString("pokemon5Ability_cmb.Items66"), resources.GetString("pokemon5Ability_cmb.Items67"), resources.GetString("pokemon5Ability_cmb.Items68"), resources.GetString("pokemon5Ability_cmb.Items69"), resources.GetString("pokemon5Ability_cmb.Items70"), resources.GetString("pokemon5Ability_cmb.Items71"), resources.GetString("pokemon5Ability_cmb.Items72"), resources.GetString("pokemon5Ability_cmb.Items73"), resources.GetString("pokemon5Ability_cmb.Items74"), resources.GetString("pokemon5Ability_cmb.Items75"), resources.GetString("pokemon5Ability_cmb.Items76"), resources.GetString("pokemon5Ability_cmb.Items77"), resources.GetString("pokemon5Ability_cmb.Items78"), resources.GetString("pokemon5Ability_cmb.Items79"), resources.GetString("pokemon5Ability_cmb.Items80"), resources.GetString("pokemon5Ability_cmb.Items81"), resources.GetString("pokemon5Ability_cmb.Items82"), resources.GetString("pokemon5Ability_cmb.Items83"), resources.GetString("pokemon5Ability_cmb.Items84"), resources.GetString("pokemon5Ability_cmb.Items85"), resources.GetString("pokemon5Ability_cmb.Items86"), resources.GetString("pokemon5Ability_cmb.Items87"), resources.GetString("pokemon5Ability_cmb.Items88"), resources.GetString("pokemon5Ability_cmb.Items89"), resources.GetString("pokemon5Ability_cmb.Items90"), resources.GetString("pokemon5Ability_cmb.Items91"), resources.GetString("pokemon5Ability_cmb.Items92"), resources.GetString("pokemon5Ability_cmb.Items93"), resources.GetString("pokemon5Ability_cmb.Items94"), resources.GetString("pokemon5Ability_cmb.Items95"), resources.GetString("pokemon5Ability_cmb.Items96"), resources.GetString("pokemon5Ability_cmb.Items97"), resources.GetString("pokemon5Ability_cmb.Items98"), resources.GetString("pokemon5Ability_cmb.Items99"), resources.GetString("pokemon5Ability_cmb.Items100"), resources.GetString("pokemon5Ability_cmb.Items101"), resources.GetString("pokemon5Ability_cmb.Items102"), resources.GetString("pokemon5Ability_cmb.Items103"), resources.GetString("pokemon5Ability_cmb.Items104"), resources.GetString("pokemon5Ability_cmb.Items105"), resources.GetString("pokemon5Ability_cmb.Items106"), resources.GetString("pokemon5Ability_cmb.Items107"), resources.GetString("pokemon5Ability_cmb.Items108"), resources.GetString("pokemon5Ability_cmb.Items109"), resources.GetString("pokemon5Ability_cmb.Items110"), resources.GetString("pokemon5Ability_cmb.Items111"), resources.GetString("pokemon5Ability_cmb.Items112"), resources.GetString("pokemon5Ability_cmb.Items113"), resources.GetString("pokemon5Ability_cmb.Items114"), resources.GetString("pokemon5Ability_cmb.Items115"), resources.GetString("pokemon5Ability_cmb.Items116"), resources.GetString("pokemon5Ability_cmb.Items117"), resources.GetString("pokemon5Ability_cmb.Items118"), resources.GetString("pokemon5Ability_cmb.Items119"), resources.GetString("pokemon5Ability_cmb.Items120"), resources.GetString("pokemon5Ability_cmb.Items121"), resources.GetString("pokemon5Ability_cmb.Items122"), resources.GetString("pokemon5Ability_cmb.Items123"), resources.GetString("pokemon5Ability_cmb.Items124"), resources.GetString("pokemon5Ability_cmb.Items125"), resources.GetString("pokemon5Ability_cmb.Items126"), resources.GetString("pokemon5Ability_cmb.Items127"), resources.GetString("pokemon5Ability_cmb.Items128"), resources.GetString("pokemon5Ability_cmb.Items129"), resources.GetString("pokemon5Ability_cmb.Items130"), resources.GetString("pokemon5Ability_cmb.Items131"), resources.GetString("pokemon5Ability_cmb.Items132"), resources.GetString("pokemon5Ability_cmb.Items133"), resources.GetString("pokemon5Ability_cmb.Items134"), resources.GetString("pokemon5Ability_cmb.Items135"), resources.GetString("pokemon5Ability_cmb.Items136"), resources.GetString("pokemon5Ability_cmb.Items137"), resources.GetString("pokemon5Ability_cmb.Items138"), resources.GetString("pokemon5Ability_cmb.Items139"), resources.GetString("pokemon5Ability_cmb.Items140"), resources.GetString("pokemon5Ability_cmb.Items141"), resources.GetString("pokemon5Ability_cmb.Items142"), resources.GetString("pokemon5Ability_cmb.Items143"), resources.GetString("pokemon5Ability_cmb.Items144"), resources.GetString("pokemon5Ability_cmb.Items145"), resources.GetString("pokemon5Ability_cmb.Items146"), resources.GetString("pokemon5Ability_cmb.Items147"), resources.GetString("pokemon5Ability_cmb.Items148"), resources.GetString("pokemon5Ability_cmb.Items149"), resources.GetString("pokemon5Ability_cmb.Items150"), resources.GetString("pokemon5Ability_cmb.Items151"), resources.GetString("pokemon5Ability_cmb.Items152"), resources.GetString("pokemon5Ability_cmb.Items153"), resources.GetString("pokemon5Ability_cmb.Items154"), resources.GetString("pokemon5Ability_cmb.Items155"), resources.GetString("pokemon5Ability_cmb.Items156"), resources.GetString("pokemon5Ability_cmb.Items157"), resources.GetString("pokemon5Ability_cmb.Items158"), resources.GetString("pokemon5Ability_cmb.Items159"), resources.GetString("pokemon5Ability_cmb.Items160"), resources.GetString("pokemon5Ability_cmb.Items161"), resources.GetString("pokemon5Ability_cmb.Items162"), resources.GetString("pokemon5Ability_cmb.Items163"), resources.GetString("pokemon5Ability_cmb.Items164"), resources.GetString("pokemon5Ability_cmb.Items165"), resources.GetString("pokemon5Ability_cmb.Items166"), resources.GetString("pokemon5Ability_cmb.Items167"), resources.GetString("pokemon5Ability_cmb.Items168"), resources.GetString("pokemon5Ability_cmb.Items169"), resources.GetString("pokemon5Ability_cmb.Items170"), resources.GetString("pokemon5Ability_cmb.Items171"), resources.GetString("pokemon5Ability_cmb.Items172"), resources.GetString("pokemon5Ability_cmb.Items173"), resources.GetString("pokemon5Ability_cmb.Items174"), resources.GetString("pokemon5Ability_cmb.Items175"), resources.GetString("pokemon5Ability_cmb.Items176"), resources.GetString("pokemon5Ability_cmb.Items177"), resources.GetString("pokemon5Ability_cmb.Items178"), resources.GetString("pokemon5Ability_cmb.Items179"), resources.GetString("pokemon5Ability_cmb.Items180"), resources.GetString("pokemon5Ability_cmb.Items181"), resources.GetString("pokemon5Ability_cmb.Items182"), resources.GetString("pokemon5Ability_cmb.Items183"), resources.GetString("pokemon5Ability_cmb.Items184"), resources.GetString("pokemon5Ability_cmb.Items185"), resources.GetString("pokemon5Ability_cmb.Items186"), resources.GetString("pokemon5Ability_cmb.Items187"), resources.GetString("pokemon5Ability_cmb.Items188"), resources.GetString("pokemon5Ability_cmb.Items189"), resources.GetString("pokemon5Ability_cmb.Items190"), resources.GetString("pokemon5Ability_cmb.Items191"), resources.GetString("pokemon5Ability_cmb.Items192"), resources.GetString("pokemon5Ability_cmb.Items193"), resources.GetString("pokemon5Ability_cmb.Items194"), resources.GetString("pokemon5Ability_cmb.Items195"), resources.GetString("pokemon5Ability_cmb.Items196"), resources.GetString("pokemon5Ability_cmb.Items197"), resources.GetString("pokemon5Ability_cmb.Items198"), resources.GetString("pokemon5Ability_cmb.Items199"), resources.GetString("pokemon5Ability_cmb.Items200"), resources.GetString("pokemon5Ability_cmb.Items201"), resources.GetString("pokemon5Ability_cmb.Items202"), resources.GetString("pokemon5Ability_cmb.Items203"), resources.GetString("pokemon5Ability_cmb.Items204"), resources.GetString("pokemon5Ability_cmb.Items205"), resources.GetString("pokemon5Ability_cmb.Items206"), resources.GetString("pokemon5Ability_cmb.Items207"), resources.GetString("pokemon5Ability_cmb.Items208"), resources.GetString("pokemon5Ability_cmb.Items209"), resources.GetString("pokemon5Ability_cmb.Items210"), resources.GetString("pokemon5Ability_cmb.Items211"), resources.GetString("pokemon5Ability_cmb.Items212"), resources.GetString("pokemon5Ability_cmb.Items213"), resources.GetString("pokemon5Ability_cmb.Items214"), resources.GetString("pokemon5Ability_cmb.Items215"), resources.GetString("pokemon5Ability_cmb.Items216"), resources.GetString("pokemon5Ability_cmb.Items217"), resources.GetString("pokemon5Ability_cmb.Items218"), resources.GetString("pokemon5Ability_cmb.Items219"), resources.GetString("pokemon5Ability_cmb.Items220"), resources.GetString("pokemon5Ability_cmb.Items221"), resources.GetString("pokemon5Ability_cmb.Items222"), resources.GetString("pokemon5Ability_cmb.Items223"), resources.GetString("pokemon5Ability_cmb.Items224"), resources.GetString("pokemon5Ability_cmb.Items225"), resources.GetString("pokemon5Ability_cmb.Items226"), resources.GetString("pokemon5Ability_cmb.Items227"), resources.GetString("pokemon5Ability_cmb.Items228"), resources.GetString("pokemon5Ability_cmb.Items229"), resources.GetString("pokemon5Ability_cmb.Items230"), resources.GetString("pokemon5Ability_cmb.Items231"), resources.GetString("pokemon5Ability_cmb.Items232"), resources.GetString("pokemon5Ability_cmb.Items233"), resources.GetString("pokemon5Ability_cmb.Items234"), resources.GetString("pokemon5Ability_cmb.Items235"), resources.GetString("pokemon5Ability_cmb.Items236"), resources.GetString("pokemon5Ability_cmb.Items237"), resources.GetString("pokemon5Ability_cmb.Items238"), resources.GetString("pokemon5Ability_cmb.Items239"), resources.GetString("pokemon5Ability_cmb.Items240"), resources.GetString("pokemon5Ability_cmb.Items241"), resources.GetString("pokemon5Ability_cmb.Items242"), resources.GetString("pokemon5Ability_cmb.Items243"), resources.GetString("pokemon5Ability_cmb.Items244"), resources.GetString("pokemon5Ability_cmb.Items245"), resources.GetString("pokemon5Ability_cmb.Items246"), resources.GetString("pokemon5Ability_cmb.Items247"), resources.GetString("pokemon5Ability_cmb.Items248"), resources.GetString("pokemon5Ability_cmb.Items249"), resources.GetString("pokemon5Ability_cmb.Items250"), resources.GetString("pokemon5Ability_cmb.Items251"), resources.GetString("pokemon5Ability_cmb.Items252"), resources.GetString("pokemon5Ability_cmb.Items253"), resources.GetString("pokemon5Ability_cmb.Items254"), resources.GetString("pokemon5Ability_cmb.Items255"), resources.GetString("pokemon5Ability_cmb.Items256"), resources.GetString("pokemon5Ability_cmb.Items257"), resources.GetString("pokemon5Ability_cmb.Items258"), resources.GetString("pokemon5Ability_cmb.Items259"), resources.GetString("pokemon5Ability_cmb.Items260"), resources.GetString("pokemon5Ability_cmb.Items261"), resources.GetString("pokemon5Ability_cmb.Items262"), resources.GetString("pokemon5Ability_cmb.Items263"), resources.GetString("pokemon5Ability_cmb.Items264"), resources.GetString("pokemon5Ability_cmb.Items265"), resources.GetString("pokemon5Ability_cmb.Items266"), resources.GetString("pokemon5Ability_cmb.Items267"), resources.GetString("pokemon5Ability_cmb.Items268"), resources.GetString("pokemon5Ability_cmb.Items269"), resources.GetString("pokemon5Ability_cmb.Items270"), resources.GetString("pokemon5Ability_cmb.Items271"), resources.GetString("pokemon5Ability_cmb.Items272"), resources.GetString("pokemon5Ability_cmb.Items273"), resources.GetString("pokemon5Ability_cmb.Items274"), resources.GetString("pokemon5Ability_cmb.Items275"), resources.GetString("pokemon5Ability_cmb.Items276"), resources.GetString("pokemon5Ability_cmb.Items277"), resources.GetString("pokemon5Ability_cmb.Items278"), resources.GetString("pokemon5Ability_cmb.Items279"), resources.GetString("pokemon5Ability_cmb.Items280"), resources.GetString("pokemon5Ability_cmb.Items281"), resources.GetString("pokemon5Ability_cmb.Items282"), resources.GetString("pokemon5Ability_cmb.Items283"), resources.GetString("pokemon5Ability_cmb.Items284"), resources.GetString("pokemon5Ability_cmb.Items285"), resources.GetString("pokemon5Ability_cmb.Items286"), resources.GetString("pokemon5Ability_cmb.Items287"), resources.GetString("pokemon5Ability_cmb.Items288"), resources.GetString("pokemon5Ability_cmb.Items289"), resources.GetString("pokemon5Ability_cmb.Items290"), resources.GetString("pokemon5Ability_cmb.Items291"), resources.GetString("pokemon5Ability_cmb.Items292"), resources.GetString("pokemon5Ability_cmb.Items293"), resources.GetString("pokemon5Ability_cmb.Items294"), resources.GetString("pokemon5Ability_cmb.Items295"), resources.GetString("pokemon5Ability_cmb.Items296"), resources.GetString("pokemon5Ability_cmb.Items297"), resources.GetString("pokemon5Ability_cmb.Items298"), resources.GetString("pokemon5Ability_cmb.Items299"), resources.GetString("pokemon5Ability_cmb.Items300"), resources.GetString("pokemon5Ability_cmb.Items301"), resources.GetString("pokemon5Ability_cmb.Items302"), resources.GetString("pokemon5Ability_cmb.Items303"), resources.GetString("pokemon5Ability_cmb.Items304")})
        resources.ApplyResources(pokemon5Ability_cmb, "pokemon5Ability_cmb")
        pokemon5Ability_cmb.Name = "pokemon5Ability_cmb"
        ' 
        ' pokemon5Nature_cmb
        ' 
        pokemon5Nature_cmb.FormattingEnabled = True
        pokemon5Nature_cmb.Items.AddRange(New Object() {resources.GetString("pokemon5Nature_cmb.Items"), resources.GetString("pokemon5Nature_cmb.Items1"), resources.GetString("pokemon5Nature_cmb.Items2"), resources.GetString("pokemon5Nature_cmb.Items3"), resources.GetString("pokemon5Nature_cmb.Items4"), resources.GetString("pokemon5Nature_cmb.Items5"), resources.GetString("pokemon5Nature_cmb.Items6"), resources.GetString("pokemon5Nature_cmb.Items7"), resources.GetString("pokemon5Nature_cmb.Items8"), resources.GetString("pokemon5Nature_cmb.Items9"), resources.GetString("pokemon5Nature_cmb.Items10"), resources.GetString("pokemon5Nature_cmb.Items11"), resources.GetString("pokemon5Nature_cmb.Items12"), resources.GetString("pokemon5Nature_cmb.Items13"), resources.GetString("pokemon5Nature_cmb.Items14"), resources.GetString("pokemon5Nature_cmb.Items15"), resources.GetString("pokemon5Nature_cmb.Items16"), resources.GetString("pokemon5Nature_cmb.Items17"), resources.GetString("pokemon5Nature_cmb.Items18"), resources.GetString("pokemon5Nature_cmb.Items19"), resources.GetString("pokemon5Nature_cmb.Items20"), resources.GetString("pokemon5Nature_cmb.Items21"), resources.GetString("pokemon5Nature_cmb.Items22"), resources.GetString("pokemon5Nature_cmb.Items23"), resources.GetString("pokemon5Nature_cmb.Items24"), resources.GetString("pokemon5Nature_cmb.Items25")})
        resources.ApplyResources(pokemon5Nature_cmb, "pokemon5Nature_cmb")
        pokemon5Nature_cmb.Name = "pokemon5Nature_cmb"
        ' 
        ' pokemon5Gender_lbl
        ' 
        resources.ApplyResources(pokemon5Gender_lbl, "pokemon5Gender_lbl")
        pokemon5Gender_lbl.Name = "pokemon5Gender_lbl"
        ' 
        ' pokemon5Nature_lbl
        ' 
        resources.ApplyResources(pokemon5Nature_lbl, "pokemon5Nature_lbl")
        pokemon5Nature_lbl.Name = "pokemon5Nature_lbl"
        ' 
        ' pokemon5Gender_cmb
        ' 
        pokemon5Gender_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        pokemon5Gender_cmb.FormattingEnabled = True
        pokemon5Gender_cmb.Items.AddRange(New Object() {resources.GetString("pokemon5Gender_cmb.Items"), resources.GetString("pokemon5Gender_cmb.Items1"), resources.GetString("pokemon5Gender_cmb.Items2")})
        resources.ApplyResources(pokemon5Gender_cmb, "pokemon5Gender_cmb")
        pokemon5Gender_cmb.Name = "pokemon5Gender_cmb"
        ' 
        ' pokemon5Shiny_grp
        ' 
        pokemon5Shiny_grp.Controls.Add(pokemon5SuperShiny_chkBox)
        pokemon5Shiny_grp.Controls.Add(pokemon5Shiny_rad)
        pokemon5Shiny_grp.Controls.Add(pokemon5NotShiny_rad)
        resources.ApplyResources(pokemon5Shiny_grp, "pokemon5Shiny_grp")
        pokemon5Shiny_grp.Name = "pokemon5Shiny_grp"
        pokemon5Shiny_grp.TabStop = False
        ' 
        ' pokemon5SuperShiny_chkBox
        ' 
        resources.ApplyResources(pokemon5SuperShiny_chkBox, "pokemon5SuperShiny_chkBox")
        pokemon5SuperShiny_chkBox.Name = "pokemon5SuperShiny_chkBox"
        pokemon5SuperShiny_chkBox.UseVisualStyleBackColor = True
        ' 
        ' pokemon5Shiny_rad
        ' 
        resources.ApplyResources(pokemon5Shiny_rad, "pokemon5Shiny_rad")
        pokemon5Shiny_rad.Name = "pokemon5Shiny_rad"
        pokemon5Shiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon5NotShiny_rad
        ' 
        resources.ApplyResources(pokemon5NotShiny_rad, "pokemon5NotShiny_rad")
        pokemon5NotShiny_rad.Checked = True
        pokemon5NotShiny_rad.Name = "pokemon5NotShiny_rad"
        pokemon5NotShiny_rad.TabStop = True
        pokemon5NotShiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon5Form_lbl
        ' 
        resources.ApplyResources(pokemon5Form_lbl, "pokemon5Form_lbl")
        pokemon5Form_lbl.Name = "pokemon5Form_lbl"
        ' 
        ' pg_pkmn6
        ' 
        pg_pkmn6.Controls.Add(pokemon6_grp)
        resources.ApplyResources(pg_pkmn6, "pg_pkmn6")
        pg_pkmn6.Name = "pg_pkmn6"
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
        resources.ApplyResources(pokemon6_grp, "pokemon6_grp")
        pokemon6_grp.Name = "pokemon6_grp"
        pokemon6_grp.TabStop = False
        ' 
        ' pokemon6Level_nbr
        ' 
        resources.ApplyResources(pokemon6Level_nbr, "pokemon6Level_nbr")
        pokemon6Level_nbr.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        pokemon6Level_nbr.Name = "pokemon6Level_nbr"
        pokemon6Level_nbr.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' pokemon6Form_nbr
        ' 
        resources.ApplyResources(pokemon6Form_nbr, "pokemon6Form_nbr")
        pokemon6Form_nbr.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        pokemon6Form_nbr.Name = "pokemon6Form_nbr"
        ' 
        ' pokemon6Happiness_nbr
        ' 
        resources.ApplyResources(pokemon6Happiness_nbr, "pokemon6Happiness_nbr")
        pokemon6Happiness_nbr.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        pokemon6Happiness_nbr.Name = "pokemon6Happiness_nbr"
        pokemon6Happiness_nbr.Value = New Decimal(New Integer() {70, 0, 0, 0})
        ' 
        ' pokemon6Shadow_grp
        ' 
        pokemon6Shadow_grp.Controls.Add(pokemon6Shadow_rad)
        pokemon6Shadow_grp.Controls.Add(pokemon6NotShadow_rad)
        resources.ApplyResources(pokemon6Shadow_grp, "pokemon6Shadow_grp")
        pokemon6Shadow_grp.Name = "pokemon6Shadow_grp"
        pokemon6Shadow_grp.TabStop = False
        ' 
        ' pokemon6Shadow_rad
        ' 
        resources.ApplyResources(pokemon6Shadow_rad, "pokemon6Shadow_rad")
        pokemon6Shadow_rad.Name = "pokemon6Shadow_rad"
        pokemon6Shadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon6NotShadow_rad
        ' 
        resources.ApplyResources(pokemon6NotShadow_rad, "pokemon6NotShadow_rad")
        pokemon6NotShadow_rad.Checked = True
        pokemon6NotShadow_rad.Name = "pokemon6NotShadow_rad"
        pokemon6NotShadow_rad.TabStop = True
        pokemon6NotShadow_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon6Name_lbl
        ' 
        resources.ApplyResources(pokemon6Name_lbl, "pokemon6Name_lbl")
        pokemon6Name_lbl.Name = "pokemon6Name_lbl"
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
        resources.ApplyResources(pokemon6EVs_grp, "pokemon6EVs_grp")
        pokemon6EVs_grp.Name = "pokemon6EVs_grp"
        pokemon6EVs_grp.TabStop = False
        ' 
        ' pokemon6EVsDEF_txt
        ' 
        resources.ApplyResources(pokemon6EVsDEF_txt, "pokemon6EVsDEF_txt")
        pokemon6EVsDEF_txt.Name = "pokemon6EVsDEF_txt"
        ' 
        ' pokemon6EVsDEF_lbl
        ' 
        resources.ApplyResources(pokemon6EVsDEF_lbl, "pokemon6EVsDEF_lbl")
        pokemon6EVsDEF_lbl.Name = "pokemon6EVsDEF_lbl"
        ' 
        ' pokemon6EVsSPDEF_txt
        ' 
        resources.ApplyResources(pokemon6EVsSPDEF_txt, "pokemon6EVsSPDEF_txt")
        pokemon6EVsSPDEF_txt.Name = "pokemon6EVsSPDEF_txt"
        ' 
        ' pokemon6EVsSPDEF_lbl
        ' 
        resources.ApplyResources(pokemon6EVsSPDEF_lbl, "pokemon6EVsSPDEF_lbl")
        pokemon6EVsSPDEF_lbl.Name = "pokemon6EVsSPDEF_lbl"
        ' 
        ' pokemon6EVsSPATK_txt
        ' 
        resources.ApplyResources(pokemon6EVsSPATK_txt, "pokemon6EVsSPATK_txt")
        pokemon6EVsSPATK_txt.Name = "pokemon6EVsSPATK_txt"
        ' 
        ' pokemon6EVsSPATK_lbl
        ' 
        resources.ApplyResources(pokemon6EVsSPATK_lbl, "pokemon6EVsSPATK_lbl")
        pokemon6EVsSPATK_lbl.Name = "pokemon6EVsSPATK_lbl"
        ' 
        ' pokemon6EVsSPD_txt
        ' 
        resources.ApplyResources(pokemon6EVsSPD_txt, "pokemon6EVsSPD_txt")
        pokemon6EVsSPD_txt.Name = "pokemon6EVsSPD_txt"
        ' 
        ' pokemon6EVsSPD_lbl
        ' 
        resources.ApplyResources(pokemon6EVsSPD_lbl, "pokemon6EVsSPD_lbl")
        pokemon6EVsSPD_lbl.Name = "pokemon6EVsSPD_lbl"
        ' 
        ' pokemon6EVsATK_txt
        ' 
        resources.ApplyResources(pokemon6EVsATK_txt, "pokemon6EVsATK_txt")
        pokemon6EVsATK_txt.Name = "pokemon6EVsATK_txt"
        ' 
        ' pokemon6EVsATK_lbl
        ' 
        resources.ApplyResources(pokemon6EVsATK_lbl, "pokemon6EVsATK_lbl")
        pokemon6EVsATK_lbl.Name = "pokemon6EVsATK_lbl"
        ' 
        ' pokemon6EVsHP_txt
        ' 
        resources.ApplyResources(pokemon6EVsHP_txt, "pokemon6EVsHP_txt")
        pokemon6EVsHP_txt.Name = "pokemon6EVsHP_txt"
        ' 
        ' pokemon6EVsHP_lbl
        ' 
        resources.ApplyResources(pokemon6EVsHP_lbl, "pokemon6EVsHP_lbl")
        pokemon6EVsHP_lbl.Name = "pokemon6EVsHP_lbl"
        ' 
        ' pokemon6Name_txt
        ' 
        pokemon6Name_txt.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource1"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource2"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource3"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource4"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource5"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource6"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource7"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource8"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource9"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource10"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource11"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource12"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource13"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource14"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource15"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource16"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource17"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource18"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource19"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource20"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource21"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource22"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource23"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource24"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource25"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource26"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource27"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource28"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource29"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource30"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource31"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource32"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource33"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource34"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource35"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource36"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource37"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource38"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource39"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource40"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource41"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource42"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource43"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource44"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource45"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource46"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource47"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource48"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource49"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource50"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource51"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource52"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource53"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource54"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource55"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource56"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource57"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource58"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource59"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource60"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource61"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource62"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource63"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource64"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource65"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource66"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource67"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource68"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource69"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource70"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource71"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource72"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource73"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource74"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource75"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource76"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource77"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource78"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource79"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource80"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource81"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource82"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource83"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource84"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource85"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource86"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource87"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource88"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource89"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource90"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource91"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource92"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource93"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource94"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource95"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource96"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource97"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource98"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource99"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource100"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource101"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource102"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource103"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource104"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource105"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource106"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource107"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource108"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource109"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource110"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource111"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource112"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource113"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource114"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource115"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource116"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource117"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource118"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource119"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource120"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource121"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource122"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource123"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource124"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource125"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource126"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource127"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource128"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource129"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource130"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource131"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource132"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource133"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource134"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource135"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource136"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource137"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource138"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource139"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource140"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource141"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource142"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource143"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource144"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource145"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource146"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource147"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource148"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource149"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource150"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource151"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource152"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource153"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource154"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource155"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource156"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource157"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource158"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource159"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource160"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource161"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource162"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource163"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource164"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource165"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource166"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource167"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource168"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource169"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource170"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource171"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource172"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource173"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource174"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource175"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource176"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource177"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource178"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource179"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource180"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource181"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource182"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource183"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource184"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource185"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource186"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource187"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource188"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource189"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource190"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource191"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource192"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource193"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource194"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource195"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource196"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource197"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource198"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource199"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource200"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource201"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource202"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource203"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource204"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource205"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource206"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource207"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource208"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource209"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource210"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource211"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource212"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource213"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource214"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource215"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource216"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource217"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource218"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource219"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource220"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource221"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource222"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource223"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource224"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource225"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource226"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource227"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource228"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource229"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource230"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource231"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource232"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource233"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource234"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource235"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource236"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource237"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource238"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource239"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource240"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource241"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource242"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource243"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource244"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource245"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource246"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource247"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource248"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource249"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource250"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource251"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource252"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource253"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource254"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource255"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource256"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource257"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource258"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource259"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource260"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource261"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource262"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource263"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource264"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource265"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource266"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource267"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource268"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource269"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource270"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource271"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource272"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource273"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource274"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource275"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource276"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource277"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource278"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource279"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource280"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource281"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource282"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource283"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource284"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource285"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource286"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource287"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource288"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource289"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource290"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource291"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource292"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource293"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource294"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource295"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource296"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource297"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource298"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource299"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource300"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource301"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource302"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource303"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource304"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource305"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource306"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource307"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource308"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource309"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource310"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource311"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource312"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource313"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource314"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource315"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource316"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource317"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource318"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource319"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource320"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource321"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource322"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource323"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource324"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource325"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource326"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource327"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource328"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource329"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource330"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource331"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource332"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource333"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource334"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource335"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource336"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource337"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource338"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource339"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource340"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource341"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource342"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource343"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource344"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource345"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource346"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource347"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource348"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource349"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource350"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource351"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource352"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource353"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource354"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource355"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource356"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource357"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource358"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource359"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource360"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource361"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource362"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource363"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource364"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource365"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource366"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource367"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource368"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource369"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource370"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource371"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource372"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource373"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource374"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource375"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource376"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource377"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource378"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource379"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource380"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource381"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource382"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource383"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource384"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource385"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource386"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource387"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource388"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource389"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource390"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource391"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource392"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource393"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource394"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource395"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource396"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource397"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource398"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource399"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource400"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource401"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource402"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource403"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource404"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource405"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource406"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource407"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource408"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource409"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource410"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource411"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource412"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource413"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource414"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource415"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource416"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource417"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource418"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource419"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource420"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource421"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource422"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource423"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource424"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource425"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource426"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource427"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource428"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource429"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource430"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource431"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource432"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource433"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource434"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource435"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource436"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource437"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource438"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource439"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource440"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource441"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource442"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource443"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource444"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource445"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource446"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource447"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource448"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource449"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource450"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource451"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource452"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource453"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource454"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource455"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource456"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource457"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource458"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource459"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource460"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource461"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource462"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource463"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource464"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource465"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource466"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource467"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource468"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource469"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource470"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource471"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource472"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource473"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource474"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource475"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource476"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource477"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource478"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource479"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource480"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource481"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource482"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource483"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource484"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource485"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource486"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource487"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource488"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource489"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource490"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource491"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource492"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource493"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource494"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource495"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource496"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource497"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource498"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource499"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource500"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource501"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource502"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource503"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource504"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource505"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource506"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource507"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource508"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource509"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource510"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource511"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource512"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource513"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource514"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource515"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource516"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource517"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource518"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource519"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource520"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource521"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource522"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource523"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource524"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource525"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource526"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource527"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource528"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource529"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource530"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource531"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource532"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource533"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource534"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource535"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource536"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource537"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource538"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource539"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource540"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource541"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource542"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource543"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource544"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource545"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource546"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource547"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource548"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource549"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource550"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource551"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource552"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource553"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource554"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource555"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource556"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource557"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource558"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource559"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource560"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource561"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource562"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource563"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource564"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource565"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource566"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource567"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource568"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource569"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource570"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource571"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource572"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource573"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource574"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource575"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource576"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource577"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource578"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource579"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource580"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource581"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource582"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource583"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource584"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource585"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource586"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource587"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource588"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource589"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource590"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource591"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource592"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource593"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource594"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource595"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource596"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource597"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource598"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource599"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource600"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource601"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource602"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource603"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource604"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource605"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource606"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource607"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource608"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource609"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource610"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource611"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource612"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource613"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource614"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource615"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource616"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource617"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource618"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource619"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource620"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource621"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource622"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource623"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource624"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource625"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource626"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource627"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource628"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource629"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource630"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource631"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource632"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource633"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource634"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource635"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource636"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource637"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource638"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource639"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource640"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource641"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource642"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource643"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource644"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource645"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource646"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource647"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource648"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource649"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource650"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource651"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource652"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource653"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource654"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource655"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource656"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource657"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource658"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource659"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource660"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource661"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource662"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource663"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource664"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource665"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource666"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource667"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource668"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource669"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource670"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource671"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource672"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource673"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource674"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource675"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource676"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource677"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource678"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource679"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource680"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource681"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource682"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource683"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource684"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource685"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource686"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource687"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource688"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource689"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource690"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource691"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource692"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource693"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource694"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource695"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource696"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource697"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource698"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource699"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource700"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource701"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource702"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource703"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource704"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource705"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource706"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource707"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource708"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource709"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource710"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource711"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource712"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource713"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource714"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource715"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource716"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource717"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource718"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource719"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource720"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource721"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource722"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource723"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource724"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource725"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource726"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource727"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource728"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource729"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource730"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource731"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource732"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource733"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource734"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource735"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource736"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource737"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource738"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource739"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource740"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource741"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource742"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource743"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource744"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource745"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource746"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource747"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource748"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource749"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource750"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource751"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource752"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource753"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource754"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource755"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource756"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource757"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource758"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource759"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource760"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource761"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource762"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource763"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource764"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource765"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource766"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource767"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource768"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource769"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource770"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource771"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource772"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource773"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource774"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource775"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource776"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource777"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource778"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource779"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource780"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource781"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource782"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource783"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource784"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource785"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource786"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource787"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource788"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource789"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource790"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource791"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource792"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource793"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource794"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource795"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource796"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource797"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource798"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource799"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource800"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource801"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource802"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource803"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource804"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource805"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource806"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource807"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource808"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource809"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource810"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource811"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource812"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource813"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource814"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource815"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource816"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource817"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource818"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource819"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource820"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource821"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource822"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource823"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource824"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource825"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource826"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource827"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource828"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource829"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource830"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource831"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource832"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource833"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource834"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource835"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource836"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource837"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource838"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource839"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource840"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource841"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource842"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource843"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource844"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource845"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource846"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource847"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource848"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource849"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource850"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource851"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource852"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource853"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource854"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource855"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource856"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource857"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource858"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource859"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource860"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource861"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource862"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource863"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource864"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource865"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource866"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource867"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource868"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource869"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource870"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource871"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource872"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource873"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource874"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource875"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource876"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource877"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource878"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource879"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource880"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource881"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource882"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource883"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource884"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource885"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource886"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource887"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource888"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource889"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource890"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource891"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource892"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource893"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource894"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource895"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource896"), resources.GetString("pokemon6Name_txt.AutoCompleteCustomSource897")})
        pokemon6Name_txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon6Name_txt.AutoCompleteSource = AutoCompleteSource.CustomSource
        resources.ApplyResources(pokemon6Name_txt, "pokemon6Name_txt")
        pokemon6Name_txt.Name = "pokemon6Name_txt"
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
        resources.ApplyResources(pokemon6IVs_grp, "pokemon6IVs_grp")
        pokemon6IVs_grp.Name = "pokemon6IVs_grp"
        pokemon6IVs_grp.TabStop = False
        ' 
        ' pokemon6RandomIVs_btn
        ' 
        resources.ApplyResources(pokemon6RandomIVs_btn, "pokemon6RandomIVs_btn")
        pokemon6RandomIVs_btn.Name = "pokemon6RandomIVs_btn"
        pokemon6RandomIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon6MaxIVs_btn
        ' 
        resources.ApplyResources(pokemon6MaxIVs_btn, "pokemon6MaxIVs_btn")
        pokemon6MaxIVs_btn.Name = "pokemon6MaxIVs_btn"
        pokemon6MaxIVs_btn.UseVisualStyleBackColor = True
        ' 
        ' pokemon6IVsDEF_txt
        ' 
        resources.ApplyResources(pokemon6IVsDEF_txt, "pokemon6IVsDEF_txt")
        pokemon6IVsDEF_txt.Name = "pokemon6IVsDEF_txt"
        ' 
        ' pokemon6IVsDEF_lbl
        ' 
        resources.ApplyResources(pokemon6IVsDEF_lbl, "pokemon6IVsDEF_lbl")
        pokemon6IVsDEF_lbl.Name = "pokemon6IVsDEF_lbl"
        ' 
        ' pokemon6IVsSPDEF_txt
        ' 
        resources.ApplyResources(pokemon6IVsSPDEF_txt, "pokemon6IVsSPDEF_txt")
        pokemon6IVsSPDEF_txt.Name = "pokemon6IVsSPDEF_txt"
        ' 
        ' pokemon6IVsSPDEF_lbl
        ' 
        resources.ApplyResources(pokemon6IVsSPDEF_lbl, "pokemon6IVsSPDEF_lbl")
        pokemon6IVsSPDEF_lbl.Name = "pokemon6IVsSPDEF_lbl"
        ' 
        ' pokemon6IVsSPATK_txt
        ' 
        resources.ApplyResources(pokemon6IVsSPATK_txt, "pokemon6IVsSPATK_txt")
        pokemon6IVsSPATK_txt.Name = "pokemon6IVsSPATK_txt"
        ' 
        ' pokemon6IVsSPATK_lbl
        ' 
        resources.ApplyResources(pokemon6IVsSPATK_lbl, "pokemon6IVsSPATK_lbl")
        pokemon6IVsSPATK_lbl.Name = "pokemon6IVsSPATK_lbl"
        ' 
        ' pokemon6IVsSPD_txt
        ' 
        resources.ApplyResources(pokemon6IVsSPD_txt, "pokemon6IVsSPD_txt")
        pokemon6IVsSPD_txt.Name = "pokemon6IVsSPD_txt"
        ' 
        ' pokemon6IVsSPD_lbl
        ' 
        resources.ApplyResources(pokemon6IVsSPD_lbl, "pokemon6IVsSPD_lbl")
        pokemon6IVsSPD_lbl.Name = "pokemon6IVsSPD_lbl"
        ' 
        ' pokemon6IVsATK_txt
        ' 
        resources.ApplyResources(pokemon6IVsATK_txt, "pokemon6IVsATK_txt")
        pokemon6IVsATK_txt.Name = "pokemon6IVsATK_txt"
        ' 
        ' pokemon6IVsATK_lbl
        ' 
        resources.ApplyResources(pokemon6IVsATK_lbl, "pokemon6IVsATK_lbl")
        pokemon6IVsATK_lbl.Name = "pokemon6IVsATK_lbl"
        ' 
        ' pokemon6IVsHP_txt
        ' 
        resources.ApplyResources(pokemon6IVsHP_txt, "pokemon6IVsHP_txt")
        pokemon6IVsHP_txt.Name = "pokemon6IVsHP_txt"
        ' 
        ' pokemon6IVsHP_lbl
        ' 
        resources.ApplyResources(pokemon6IVsHP_lbl, "pokemon6IVsHP_lbl")
        pokemon6IVsHP_lbl.Name = "pokemon6IVsHP_lbl"
        ' 
        ' pokemon6HeldItem_txt
        ' 
        resources.ApplyResources(pokemon6HeldItem_txt, "pokemon6HeldItem_txt")
        pokemon6HeldItem_txt.Name = "pokemon6HeldItem_txt"
        ' 
        ' pokemon6PokeballID_cmb
        ' 
        pokemon6PokeballID_cmb.FormattingEnabled = True
        pokemon6PokeballID_cmb.Items.AddRange(New Object() {resources.GetString("pokemon6PokeballID_cmb.Items"), resources.GetString("pokemon6PokeballID_cmb.Items1"), resources.GetString("pokemon6PokeballID_cmb.Items2"), resources.GetString("pokemon6PokeballID_cmb.Items3"), resources.GetString("pokemon6PokeballID_cmb.Items4"), resources.GetString("pokemon6PokeballID_cmb.Items5"), resources.GetString("pokemon6PokeballID_cmb.Items6"), resources.GetString("pokemon6PokeballID_cmb.Items7"), resources.GetString("pokemon6PokeballID_cmb.Items8"), resources.GetString("pokemon6PokeballID_cmb.Items9"), resources.GetString("pokemon6PokeballID_cmb.Items10"), resources.GetString("pokemon6PokeballID_cmb.Items11"), resources.GetString("pokemon6PokeballID_cmb.Items12"), resources.GetString("pokemon6PokeballID_cmb.Items13"), resources.GetString("pokemon6PokeballID_cmb.Items14"), resources.GetString("pokemon6PokeballID_cmb.Items15"), resources.GetString("pokemon6PokeballID_cmb.Items16"), resources.GetString("pokemon6PokeballID_cmb.Items17"), resources.GetString("pokemon6PokeballID_cmb.Items18"), resources.GetString("pokemon6PokeballID_cmb.Items19"), resources.GetString("pokemon6PokeballID_cmb.Items20"), resources.GetString("pokemon6PokeballID_cmb.Items21"), resources.GetString("pokemon6PokeballID_cmb.Items22"), resources.GetString("pokemon6PokeballID_cmb.Items23"), resources.GetString("pokemon6PokeballID_cmb.Items24"), resources.GetString("pokemon6PokeballID_cmb.Items25")})
        resources.ApplyResources(pokemon6PokeballID_cmb, "pokemon6PokeballID_cmb")
        pokemon6PokeballID_cmb.Name = "pokemon6PokeballID_cmb"
        ' 
        ' pokemon6HeldItem_lbl
        ' 
        resources.ApplyResources(pokemon6HeldItem_lbl, "pokemon6HeldItem_lbl")
        pokemon6HeldItem_lbl.Name = "pokemon6HeldItem_lbl"
        ' 
        ' pokemon6Pokeball_lbl
        ' 
        resources.ApplyResources(pokemon6Pokeball_lbl, "pokemon6Pokeball_lbl")
        pokemon6Pokeball_lbl.Name = "pokemon6Pokeball_lbl"
        ' 
        ' pokemon6Level_lbl
        ' 
        resources.ApplyResources(pokemon6Level_lbl, "pokemon6Level_lbl")
        pokemon6Level_lbl.Name = "pokemon6Level_lbl"
        ' 
        ' pokemon6Nickname_txt
        ' 
        resources.ApplyResources(pokemon6Nickname_txt, "pokemon6Nickname_txt")
        pokemon6Nickname_txt.Name = "pokemon6Nickname_txt"
        ' 
        ' pokemon6Nickname_lbl
        ' 
        resources.ApplyResources(pokemon6Nickname_lbl, "pokemon6Nickname_lbl")
        pokemon6Nickname_lbl.Name = "pokemon6Nickname_lbl"
        ' 
        ' pokemon6Moves_grp
        ' 
        pokemon6Moves_grp.Controls.Add(pokemon6Move4_txt)
        pokemon6Moves_grp.Controls.Add(pokemon6Move3_txt)
        pokemon6Moves_grp.Controls.Add(pokemon6Move2_txt)
        pokemon6Moves_grp.Controls.Add(pokemon6Move1_txt)
        resources.ApplyResources(pokemon6Moves_grp, "pokemon6Moves_grp")
        pokemon6Moves_grp.Name = "pokemon6Moves_grp"
        pokemon6Moves_grp.TabStop = False
        ' 
        ' pokemon6Move4_txt
        ' 
        resources.ApplyResources(pokemon6Move4_txt, "pokemon6Move4_txt")
        pokemon6Move4_txt.Name = "pokemon6Move4_txt"
        ' 
        ' pokemon6Move3_txt
        ' 
        resources.ApplyResources(pokemon6Move3_txt, "pokemon6Move3_txt")
        pokemon6Move3_txt.Name = "pokemon6Move3_txt"
        ' 
        ' pokemon6Move2_txt
        ' 
        resources.ApplyResources(pokemon6Move2_txt, "pokemon6Move2_txt")
        pokemon6Move2_txt.Name = "pokemon6Move2_txt"
        ' 
        ' pokemon6Move1_txt
        ' 
        resources.ApplyResources(pokemon6Move1_txt, "pokemon6Move1_txt")
        pokemon6Move1_txt.Name = "pokemon6Move1_txt"
        ' 
        ' pokemon6Ability_lbl
        ' 
        resources.ApplyResources(pokemon6Ability_lbl, "pokemon6Ability_lbl")
        pokemon6Ability_lbl.Name = "pokemon6Ability_lbl"
        ' 
        ' pokemon6Happiness_lbl
        ' 
        resources.ApplyResources(pokemon6Happiness_lbl, "pokemon6Happiness_lbl")
        pokemon6Happiness_lbl.Name = "pokemon6Happiness_lbl"
        ' 
        ' pokemon6Ability_cmb
        ' 
        pokemon6Ability_cmb.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource1"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource2"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource3"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource4"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource5"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource6"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource7"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource8"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource9"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource10"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource11"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource12"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource13"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource14"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource15"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource16"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource17"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource18"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource19"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource20"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource21"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource22"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource23"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource24"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource25"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource26"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource27"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource28"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource29"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource30"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource31"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource32"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource33"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource34"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource35"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource36"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource37"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource38"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource39"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource40"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource41"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource42"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource43"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource44"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource45"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource46"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource47"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource48"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource49"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource50"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource51"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource52"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource53"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource54"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource55"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource56"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource57"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource58"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource59"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource60"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource61"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource62"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource63"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource64"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource65"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource66"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource67"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource68"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource69"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource70"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource71"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource72"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource73"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource74"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource75"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource76"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource77"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource78"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource79"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource80"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource81"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource82"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource83"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource84"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource85"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource86"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource87"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource88"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource89"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource90"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource91"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource92"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource93"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource94"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource95"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource96"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource97"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource98"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource99"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource100"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource101"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource102"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource103"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource104"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource105"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource106"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource107"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource108"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource109"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource110"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource111"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource112"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource113"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource114"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource115"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource116"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource117"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource118"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource119"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource120"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource121"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource122"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource123"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource124"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource125"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource126"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource127"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource128"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource129"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource130"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource131"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource132"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource133"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource134"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource135"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource136"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource137"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource138"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource139"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource140"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource141"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource142"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource143"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource144"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource145"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource146"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource147"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource148"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource149"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource150"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource151"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource152"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource153"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource154"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource155"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource156"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource157"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource158"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource159"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource160"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource161"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource162"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource163"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource164"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource165"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource166"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource167"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource168"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource169"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource170"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource171"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource172"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource173"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource174"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource175"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource176"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource177"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource178"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource179"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource180"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource181"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource182"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource183"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource184"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource185"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource186"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource187"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource188"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource189"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource190"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource191"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource192"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource193"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource194"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource195"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource196"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource197"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource198"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource199"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource200"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource201"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource202"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource203"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource204"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource205"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource206"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource207"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource208"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource209"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource210"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource211"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource212"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource213"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource214"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource215"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource216"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource217"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource218"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource219"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource220"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource221"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource222"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource223"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource224"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource225"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource226"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource227"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource228"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource229"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource230"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource231"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource232"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource233"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource234"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource235"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource236"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource237"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource238"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource239"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource240"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource241"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource242"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource243"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource244"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource245"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource246"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource247"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource248"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource249"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource250"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource251"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource252"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource253"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource254"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource255"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource256"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource257"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource258"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource259"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource260"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource261"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource262"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource263"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource264"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource265"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource266"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource267"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource268"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource269"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource270"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource271"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource272"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource273"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource274"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource275"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource276"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource277"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource278"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource279"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource280"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource281"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource282"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource283"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource284"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource285"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource286"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource287"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource288"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource289"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource290"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource291"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource292"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource293"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource294"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource295"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource296"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource297"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource298"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource299"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource300"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource301"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource302"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource303"), resources.GetString("pokemon6Ability_cmb.AutoCompleteCustomSource304")})
        pokemon6Ability_cmb.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pokemon6Ability_cmb.AutoCompleteSource = AutoCompleteSource.CustomSource
        pokemon6Ability_cmb.FormattingEnabled = True
        pokemon6Ability_cmb.Items.AddRange(New Object() {resources.GetString("pokemon6Ability_cmb.Items"), resources.GetString("pokemon6Ability_cmb.Items1"), resources.GetString("pokemon6Ability_cmb.Items2"), resources.GetString("pokemon6Ability_cmb.Items3"), resources.GetString("pokemon6Ability_cmb.Items4"), resources.GetString("pokemon6Ability_cmb.Items5"), resources.GetString("pokemon6Ability_cmb.Items6"), resources.GetString("pokemon6Ability_cmb.Items7"), resources.GetString("pokemon6Ability_cmb.Items8"), resources.GetString("pokemon6Ability_cmb.Items9"), resources.GetString("pokemon6Ability_cmb.Items10"), resources.GetString("pokemon6Ability_cmb.Items11"), resources.GetString("pokemon6Ability_cmb.Items12"), resources.GetString("pokemon6Ability_cmb.Items13"), resources.GetString("pokemon6Ability_cmb.Items14"), resources.GetString("pokemon6Ability_cmb.Items15"), resources.GetString("pokemon6Ability_cmb.Items16"), resources.GetString("pokemon6Ability_cmb.Items17"), resources.GetString("pokemon6Ability_cmb.Items18"), resources.GetString("pokemon6Ability_cmb.Items19"), resources.GetString("pokemon6Ability_cmb.Items20"), resources.GetString("pokemon6Ability_cmb.Items21"), resources.GetString("pokemon6Ability_cmb.Items22"), resources.GetString("pokemon6Ability_cmb.Items23"), resources.GetString("pokemon6Ability_cmb.Items24"), resources.GetString("pokemon6Ability_cmb.Items25"), resources.GetString("pokemon6Ability_cmb.Items26"), resources.GetString("pokemon6Ability_cmb.Items27"), resources.GetString("pokemon6Ability_cmb.Items28"), resources.GetString("pokemon6Ability_cmb.Items29"), resources.GetString("pokemon6Ability_cmb.Items30"), resources.GetString("pokemon6Ability_cmb.Items31"), resources.GetString("pokemon6Ability_cmb.Items32"), resources.GetString("pokemon6Ability_cmb.Items33"), resources.GetString("pokemon6Ability_cmb.Items34"), resources.GetString("pokemon6Ability_cmb.Items35"), resources.GetString("pokemon6Ability_cmb.Items36"), resources.GetString("pokemon6Ability_cmb.Items37"), resources.GetString("pokemon6Ability_cmb.Items38"), resources.GetString("pokemon6Ability_cmb.Items39"), resources.GetString("pokemon6Ability_cmb.Items40"), resources.GetString("pokemon6Ability_cmb.Items41"), resources.GetString("pokemon6Ability_cmb.Items42"), resources.GetString("pokemon6Ability_cmb.Items43"), resources.GetString("pokemon6Ability_cmb.Items44"), resources.GetString("pokemon6Ability_cmb.Items45"), resources.GetString("pokemon6Ability_cmb.Items46"), resources.GetString("pokemon6Ability_cmb.Items47"), resources.GetString("pokemon6Ability_cmb.Items48"), resources.GetString("pokemon6Ability_cmb.Items49"), resources.GetString("pokemon6Ability_cmb.Items50"), resources.GetString("pokemon6Ability_cmb.Items51"), resources.GetString("pokemon6Ability_cmb.Items52"), resources.GetString("pokemon6Ability_cmb.Items53"), resources.GetString("pokemon6Ability_cmb.Items54"), resources.GetString("pokemon6Ability_cmb.Items55"), resources.GetString("pokemon6Ability_cmb.Items56"), resources.GetString("pokemon6Ability_cmb.Items57"), resources.GetString("pokemon6Ability_cmb.Items58"), resources.GetString("pokemon6Ability_cmb.Items59"), resources.GetString("pokemon6Ability_cmb.Items60"), resources.GetString("pokemon6Ability_cmb.Items61"), resources.GetString("pokemon6Ability_cmb.Items62"), resources.GetString("pokemon6Ability_cmb.Items63"), resources.GetString("pokemon6Ability_cmb.Items64"), resources.GetString("pokemon6Ability_cmb.Items65"), resources.GetString("pokemon6Ability_cmb.Items66"), resources.GetString("pokemon6Ability_cmb.Items67"), resources.GetString("pokemon6Ability_cmb.Items68"), resources.GetString("pokemon6Ability_cmb.Items69"), resources.GetString("pokemon6Ability_cmb.Items70"), resources.GetString("pokemon6Ability_cmb.Items71"), resources.GetString("pokemon6Ability_cmb.Items72"), resources.GetString("pokemon6Ability_cmb.Items73"), resources.GetString("pokemon6Ability_cmb.Items74"), resources.GetString("pokemon6Ability_cmb.Items75"), resources.GetString("pokemon6Ability_cmb.Items76"), resources.GetString("pokemon6Ability_cmb.Items77"), resources.GetString("pokemon6Ability_cmb.Items78"), resources.GetString("pokemon6Ability_cmb.Items79"), resources.GetString("pokemon6Ability_cmb.Items80"), resources.GetString("pokemon6Ability_cmb.Items81"), resources.GetString("pokemon6Ability_cmb.Items82"), resources.GetString("pokemon6Ability_cmb.Items83"), resources.GetString("pokemon6Ability_cmb.Items84"), resources.GetString("pokemon6Ability_cmb.Items85"), resources.GetString("pokemon6Ability_cmb.Items86"), resources.GetString("pokemon6Ability_cmb.Items87"), resources.GetString("pokemon6Ability_cmb.Items88"), resources.GetString("pokemon6Ability_cmb.Items89"), resources.GetString("pokemon6Ability_cmb.Items90"), resources.GetString("pokemon6Ability_cmb.Items91"), resources.GetString("pokemon6Ability_cmb.Items92"), resources.GetString("pokemon6Ability_cmb.Items93"), resources.GetString("pokemon6Ability_cmb.Items94"), resources.GetString("pokemon6Ability_cmb.Items95"), resources.GetString("pokemon6Ability_cmb.Items96"), resources.GetString("pokemon6Ability_cmb.Items97"), resources.GetString("pokemon6Ability_cmb.Items98"), resources.GetString("pokemon6Ability_cmb.Items99"), resources.GetString("pokemon6Ability_cmb.Items100"), resources.GetString("pokemon6Ability_cmb.Items101"), resources.GetString("pokemon6Ability_cmb.Items102"), resources.GetString("pokemon6Ability_cmb.Items103"), resources.GetString("pokemon6Ability_cmb.Items104"), resources.GetString("pokemon6Ability_cmb.Items105"), resources.GetString("pokemon6Ability_cmb.Items106"), resources.GetString("pokemon6Ability_cmb.Items107"), resources.GetString("pokemon6Ability_cmb.Items108"), resources.GetString("pokemon6Ability_cmb.Items109"), resources.GetString("pokemon6Ability_cmb.Items110"), resources.GetString("pokemon6Ability_cmb.Items111"), resources.GetString("pokemon6Ability_cmb.Items112"), resources.GetString("pokemon6Ability_cmb.Items113"), resources.GetString("pokemon6Ability_cmb.Items114"), resources.GetString("pokemon6Ability_cmb.Items115"), resources.GetString("pokemon6Ability_cmb.Items116"), resources.GetString("pokemon6Ability_cmb.Items117"), resources.GetString("pokemon6Ability_cmb.Items118"), resources.GetString("pokemon6Ability_cmb.Items119"), resources.GetString("pokemon6Ability_cmb.Items120"), resources.GetString("pokemon6Ability_cmb.Items121"), resources.GetString("pokemon6Ability_cmb.Items122"), resources.GetString("pokemon6Ability_cmb.Items123"), resources.GetString("pokemon6Ability_cmb.Items124"), resources.GetString("pokemon6Ability_cmb.Items125"), resources.GetString("pokemon6Ability_cmb.Items126"), resources.GetString("pokemon6Ability_cmb.Items127"), resources.GetString("pokemon6Ability_cmb.Items128"), resources.GetString("pokemon6Ability_cmb.Items129"), resources.GetString("pokemon6Ability_cmb.Items130"), resources.GetString("pokemon6Ability_cmb.Items131"), resources.GetString("pokemon6Ability_cmb.Items132"), resources.GetString("pokemon6Ability_cmb.Items133"), resources.GetString("pokemon6Ability_cmb.Items134"), resources.GetString("pokemon6Ability_cmb.Items135"), resources.GetString("pokemon6Ability_cmb.Items136"), resources.GetString("pokemon6Ability_cmb.Items137"), resources.GetString("pokemon6Ability_cmb.Items138"), resources.GetString("pokemon6Ability_cmb.Items139"), resources.GetString("pokemon6Ability_cmb.Items140"), resources.GetString("pokemon6Ability_cmb.Items141"), resources.GetString("pokemon6Ability_cmb.Items142"), resources.GetString("pokemon6Ability_cmb.Items143"), resources.GetString("pokemon6Ability_cmb.Items144"), resources.GetString("pokemon6Ability_cmb.Items145"), resources.GetString("pokemon6Ability_cmb.Items146"), resources.GetString("pokemon6Ability_cmb.Items147"), resources.GetString("pokemon6Ability_cmb.Items148"), resources.GetString("pokemon6Ability_cmb.Items149"), resources.GetString("pokemon6Ability_cmb.Items150"), resources.GetString("pokemon6Ability_cmb.Items151"), resources.GetString("pokemon6Ability_cmb.Items152"), resources.GetString("pokemon6Ability_cmb.Items153"), resources.GetString("pokemon6Ability_cmb.Items154"), resources.GetString("pokemon6Ability_cmb.Items155"), resources.GetString("pokemon6Ability_cmb.Items156"), resources.GetString("pokemon6Ability_cmb.Items157"), resources.GetString("pokemon6Ability_cmb.Items158"), resources.GetString("pokemon6Ability_cmb.Items159"), resources.GetString("pokemon6Ability_cmb.Items160"), resources.GetString("pokemon6Ability_cmb.Items161"), resources.GetString("pokemon6Ability_cmb.Items162"), resources.GetString("pokemon6Ability_cmb.Items163"), resources.GetString("pokemon6Ability_cmb.Items164"), resources.GetString("pokemon6Ability_cmb.Items165"), resources.GetString("pokemon6Ability_cmb.Items166"), resources.GetString("pokemon6Ability_cmb.Items167"), resources.GetString("pokemon6Ability_cmb.Items168"), resources.GetString("pokemon6Ability_cmb.Items169"), resources.GetString("pokemon6Ability_cmb.Items170"), resources.GetString("pokemon6Ability_cmb.Items171"), resources.GetString("pokemon6Ability_cmb.Items172"), resources.GetString("pokemon6Ability_cmb.Items173"), resources.GetString("pokemon6Ability_cmb.Items174"), resources.GetString("pokemon6Ability_cmb.Items175"), resources.GetString("pokemon6Ability_cmb.Items176"), resources.GetString("pokemon6Ability_cmb.Items177"), resources.GetString("pokemon6Ability_cmb.Items178"), resources.GetString("pokemon6Ability_cmb.Items179"), resources.GetString("pokemon6Ability_cmb.Items180"), resources.GetString("pokemon6Ability_cmb.Items181"), resources.GetString("pokemon6Ability_cmb.Items182"), resources.GetString("pokemon6Ability_cmb.Items183"), resources.GetString("pokemon6Ability_cmb.Items184"), resources.GetString("pokemon6Ability_cmb.Items185"), resources.GetString("pokemon6Ability_cmb.Items186"), resources.GetString("pokemon6Ability_cmb.Items187"), resources.GetString("pokemon6Ability_cmb.Items188"), resources.GetString("pokemon6Ability_cmb.Items189"), resources.GetString("pokemon6Ability_cmb.Items190"), resources.GetString("pokemon6Ability_cmb.Items191"), resources.GetString("pokemon6Ability_cmb.Items192"), resources.GetString("pokemon6Ability_cmb.Items193"), resources.GetString("pokemon6Ability_cmb.Items194"), resources.GetString("pokemon6Ability_cmb.Items195"), resources.GetString("pokemon6Ability_cmb.Items196"), resources.GetString("pokemon6Ability_cmb.Items197"), resources.GetString("pokemon6Ability_cmb.Items198"), resources.GetString("pokemon6Ability_cmb.Items199"), resources.GetString("pokemon6Ability_cmb.Items200"), resources.GetString("pokemon6Ability_cmb.Items201"), resources.GetString("pokemon6Ability_cmb.Items202"), resources.GetString("pokemon6Ability_cmb.Items203"), resources.GetString("pokemon6Ability_cmb.Items204"), resources.GetString("pokemon6Ability_cmb.Items205"), resources.GetString("pokemon6Ability_cmb.Items206"), resources.GetString("pokemon6Ability_cmb.Items207"), resources.GetString("pokemon6Ability_cmb.Items208"), resources.GetString("pokemon6Ability_cmb.Items209"), resources.GetString("pokemon6Ability_cmb.Items210"), resources.GetString("pokemon6Ability_cmb.Items211"), resources.GetString("pokemon6Ability_cmb.Items212"), resources.GetString("pokemon6Ability_cmb.Items213"), resources.GetString("pokemon6Ability_cmb.Items214"), resources.GetString("pokemon6Ability_cmb.Items215"), resources.GetString("pokemon6Ability_cmb.Items216"), resources.GetString("pokemon6Ability_cmb.Items217"), resources.GetString("pokemon6Ability_cmb.Items218"), resources.GetString("pokemon6Ability_cmb.Items219"), resources.GetString("pokemon6Ability_cmb.Items220"), resources.GetString("pokemon6Ability_cmb.Items221"), resources.GetString("pokemon6Ability_cmb.Items222"), resources.GetString("pokemon6Ability_cmb.Items223"), resources.GetString("pokemon6Ability_cmb.Items224"), resources.GetString("pokemon6Ability_cmb.Items225"), resources.GetString("pokemon6Ability_cmb.Items226"), resources.GetString("pokemon6Ability_cmb.Items227"), resources.GetString("pokemon6Ability_cmb.Items228"), resources.GetString("pokemon6Ability_cmb.Items229"), resources.GetString("pokemon6Ability_cmb.Items230"), resources.GetString("pokemon6Ability_cmb.Items231"), resources.GetString("pokemon6Ability_cmb.Items232"), resources.GetString("pokemon6Ability_cmb.Items233"), resources.GetString("pokemon6Ability_cmb.Items234"), resources.GetString("pokemon6Ability_cmb.Items235"), resources.GetString("pokemon6Ability_cmb.Items236"), resources.GetString("pokemon6Ability_cmb.Items237"), resources.GetString("pokemon6Ability_cmb.Items238"), resources.GetString("pokemon6Ability_cmb.Items239"), resources.GetString("pokemon6Ability_cmb.Items240"), resources.GetString("pokemon6Ability_cmb.Items241"), resources.GetString("pokemon6Ability_cmb.Items242"), resources.GetString("pokemon6Ability_cmb.Items243"), resources.GetString("pokemon6Ability_cmb.Items244"), resources.GetString("pokemon6Ability_cmb.Items245"), resources.GetString("pokemon6Ability_cmb.Items246"), resources.GetString("pokemon6Ability_cmb.Items247"), resources.GetString("pokemon6Ability_cmb.Items248"), resources.GetString("pokemon6Ability_cmb.Items249"), resources.GetString("pokemon6Ability_cmb.Items250"), resources.GetString("pokemon6Ability_cmb.Items251"), resources.GetString("pokemon6Ability_cmb.Items252"), resources.GetString("pokemon6Ability_cmb.Items253"), resources.GetString("pokemon6Ability_cmb.Items254"), resources.GetString("pokemon6Ability_cmb.Items255"), resources.GetString("pokemon6Ability_cmb.Items256"), resources.GetString("pokemon6Ability_cmb.Items257"), resources.GetString("pokemon6Ability_cmb.Items258"), resources.GetString("pokemon6Ability_cmb.Items259"), resources.GetString("pokemon6Ability_cmb.Items260"), resources.GetString("pokemon6Ability_cmb.Items261"), resources.GetString("pokemon6Ability_cmb.Items262"), resources.GetString("pokemon6Ability_cmb.Items263"), resources.GetString("pokemon6Ability_cmb.Items264"), resources.GetString("pokemon6Ability_cmb.Items265"), resources.GetString("pokemon6Ability_cmb.Items266"), resources.GetString("pokemon6Ability_cmb.Items267"), resources.GetString("pokemon6Ability_cmb.Items268"), resources.GetString("pokemon6Ability_cmb.Items269"), resources.GetString("pokemon6Ability_cmb.Items270"), resources.GetString("pokemon6Ability_cmb.Items271"), resources.GetString("pokemon6Ability_cmb.Items272"), resources.GetString("pokemon6Ability_cmb.Items273"), resources.GetString("pokemon6Ability_cmb.Items274"), resources.GetString("pokemon6Ability_cmb.Items275"), resources.GetString("pokemon6Ability_cmb.Items276"), resources.GetString("pokemon6Ability_cmb.Items277"), resources.GetString("pokemon6Ability_cmb.Items278"), resources.GetString("pokemon6Ability_cmb.Items279"), resources.GetString("pokemon6Ability_cmb.Items280"), resources.GetString("pokemon6Ability_cmb.Items281"), resources.GetString("pokemon6Ability_cmb.Items282"), resources.GetString("pokemon6Ability_cmb.Items283"), resources.GetString("pokemon6Ability_cmb.Items284"), resources.GetString("pokemon6Ability_cmb.Items285"), resources.GetString("pokemon6Ability_cmb.Items286"), resources.GetString("pokemon6Ability_cmb.Items287"), resources.GetString("pokemon6Ability_cmb.Items288"), resources.GetString("pokemon6Ability_cmb.Items289"), resources.GetString("pokemon6Ability_cmb.Items290"), resources.GetString("pokemon6Ability_cmb.Items291"), resources.GetString("pokemon6Ability_cmb.Items292"), resources.GetString("pokemon6Ability_cmb.Items293"), resources.GetString("pokemon6Ability_cmb.Items294"), resources.GetString("pokemon6Ability_cmb.Items295"), resources.GetString("pokemon6Ability_cmb.Items296"), resources.GetString("pokemon6Ability_cmb.Items297"), resources.GetString("pokemon6Ability_cmb.Items298"), resources.GetString("pokemon6Ability_cmb.Items299"), resources.GetString("pokemon6Ability_cmb.Items300"), resources.GetString("pokemon6Ability_cmb.Items301"), resources.GetString("pokemon6Ability_cmb.Items302"), resources.GetString("pokemon6Ability_cmb.Items303"), resources.GetString("pokemon6Ability_cmb.Items304")})
        resources.ApplyResources(pokemon6Ability_cmb, "pokemon6Ability_cmb")
        pokemon6Ability_cmb.Name = "pokemon6Ability_cmb"
        ' 
        ' pokemon6Nature_cmb
        ' 
        pokemon6Nature_cmb.FormattingEnabled = True
        pokemon6Nature_cmb.Items.AddRange(New Object() {resources.GetString("pokemon6Nature_cmb.Items"), resources.GetString("pokemon6Nature_cmb.Items1"), resources.GetString("pokemon6Nature_cmb.Items2"), resources.GetString("pokemon6Nature_cmb.Items3"), resources.GetString("pokemon6Nature_cmb.Items4"), resources.GetString("pokemon6Nature_cmb.Items5"), resources.GetString("pokemon6Nature_cmb.Items6"), resources.GetString("pokemon6Nature_cmb.Items7"), resources.GetString("pokemon6Nature_cmb.Items8"), resources.GetString("pokemon6Nature_cmb.Items9"), resources.GetString("pokemon6Nature_cmb.Items10"), resources.GetString("pokemon6Nature_cmb.Items11"), resources.GetString("pokemon6Nature_cmb.Items12"), resources.GetString("pokemon6Nature_cmb.Items13"), resources.GetString("pokemon6Nature_cmb.Items14"), resources.GetString("pokemon6Nature_cmb.Items15"), resources.GetString("pokemon6Nature_cmb.Items16"), resources.GetString("pokemon6Nature_cmb.Items17"), resources.GetString("pokemon6Nature_cmb.Items18"), resources.GetString("pokemon6Nature_cmb.Items19"), resources.GetString("pokemon6Nature_cmb.Items20"), resources.GetString("pokemon6Nature_cmb.Items21"), resources.GetString("pokemon6Nature_cmb.Items22"), resources.GetString("pokemon6Nature_cmb.Items23"), resources.GetString("pokemon6Nature_cmb.Items24"), resources.GetString("pokemon6Nature_cmb.Items25")})
        resources.ApplyResources(pokemon6Nature_cmb, "pokemon6Nature_cmb")
        pokemon6Nature_cmb.Name = "pokemon6Nature_cmb"
        ' 
        ' pokemon6Gender_lbl
        ' 
        resources.ApplyResources(pokemon6Gender_lbl, "pokemon6Gender_lbl")
        pokemon6Gender_lbl.Name = "pokemon6Gender_lbl"
        ' 
        ' pokemon6Nature_lbl
        ' 
        resources.ApplyResources(pokemon6Nature_lbl, "pokemon6Nature_lbl")
        pokemon6Nature_lbl.Name = "pokemon6Nature_lbl"
        ' 
        ' pokemon6Gender_cmb
        ' 
        pokemon6Gender_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        pokemon6Gender_cmb.FormattingEnabled = True
        pokemon6Gender_cmb.Items.AddRange(New Object() {resources.GetString("pokemon6Gender_cmb.Items"), resources.GetString("pokemon6Gender_cmb.Items1"), resources.GetString("pokemon6Gender_cmb.Items2")})
        resources.ApplyResources(pokemon6Gender_cmb, "pokemon6Gender_cmb")
        pokemon6Gender_cmb.Name = "pokemon6Gender_cmb"
        ' 
        ' pokemon6Shiny_grp
        ' 
        pokemon6Shiny_grp.Controls.Add(pokemon6SuperShiny_chkBox)
        pokemon6Shiny_grp.Controls.Add(pokemon6Shiny_rad)
        pokemon6Shiny_grp.Controls.Add(pokemon6NotShiny_rad)
        resources.ApplyResources(pokemon6Shiny_grp, "pokemon6Shiny_grp")
        pokemon6Shiny_grp.Name = "pokemon6Shiny_grp"
        pokemon6Shiny_grp.TabStop = False
        ' 
        ' pokemon6SuperShiny_chkBox
        ' 
        resources.ApplyResources(pokemon6SuperShiny_chkBox, "pokemon6SuperShiny_chkBox")
        pokemon6SuperShiny_chkBox.Name = "pokemon6SuperShiny_chkBox"
        pokemon6SuperShiny_chkBox.UseVisualStyleBackColor = True
        ' 
        ' pokemon6Shiny_rad
        ' 
        resources.ApplyResources(pokemon6Shiny_rad, "pokemon6Shiny_rad")
        pokemon6Shiny_rad.Name = "pokemon6Shiny_rad"
        pokemon6Shiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon6NotShiny_rad
        ' 
        resources.ApplyResources(pokemon6NotShiny_rad, "pokemon6NotShiny_rad")
        pokemon6NotShiny_rad.Checked = True
        pokemon6NotShiny_rad.Name = "pokemon6NotShiny_rad"
        pokemon6NotShiny_rad.TabStop = True
        pokemon6NotShiny_rad.UseVisualStyleBackColor = True
        ' 
        ' pokemon6Form_lbl
        ' 
        resources.ApplyResources(pokemon6Form_lbl, "pokemon6Form_lbl")
        pokemon6Form_lbl.Name = "pokemon6Form_lbl"
        ' 
        ' pg_about
        ' 
        pg_about.Controls.Add(Button1)
        pg_about.Controls.Add(lang_cmb)
        pg_about.Controls.Add(lang_lbl)
        pg_about.Controls.Add(Label1)
        pg_about.Controls.Add(licenseText_lbl)
        pg_about.Controls.Add(PictureBox1)
        pg_about.Controls.Add(aboutInfo_lbl)
        pg_about.Controls.Add(copyright_lbl)
        pg_about.Controls.Add(aboutHeaderAuthor_lbl)
        resources.ApplyResources(pg_about, "pg_about")
        pg_about.Name = "pg_about"
        pg_about.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        resources.ApplyResources(Button1, "Button1")
        Button1.Name = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lang_cmb
        ' 
        lang_cmb.DropDownStyle = ComboBoxStyle.DropDownList
        lang_cmb.FormattingEnabled = True
        lang_cmb.Items.AddRange(New Object() {resources.GetString("lang_cmb.Items"), resources.GetString("lang_cmb.Items1")})
        resources.ApplyResources(lang_cmb, "lang_cmb")
        lang_cmb.Name = "lang_cmb"
        ' 
        ' lang_lbl
        ' 
        resources.ApplyResources(lang_lbl, "lang_lbl")
        lang_lbl.Name = "lang_lbl"
        ' 
        ' Label1
        ' 
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        ' 
        ' licenseText_lbl
        ' 
        resources.ApplyResources(licenseText_lbl, "licenseText_lbl")
        licenseText_lbl.Name = "licenseText_lbl"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ETB_LOGO_FULL_BLACK
        resources.ApplyResources(PictureBox1, "PictureBox1")
        PictureBox1.Name = "PictureBox1"
        PictureBox1.TabStop = False
        ' 
        ' aboutInfo_lbl
        ' 
        resources.ApplyResources(aboutInfo_lbl, "aboutInfo_lbl")
        aboutInfo_lbl.Name = "aboutInfo_lbl"
        ' 
        ' copyright_lbl
        ' 
        resources.ApplyResources(copyright_lbl, "copyright_lbl")
        copyright_lbl.Name = "copyright_lbl"
        ' 
        ' aboutHeaderAuthor_lbl
        ' 
        resources.ApplyResources(aboutHeaderAuthor_lbl, "aboutHeaderAuthor_lbl")
        aboutHeaderAuthor_lbl.Name = "aboutHeaderAuthor_lbl"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {GeneratePreviewToolStripMenuItem})
        resources.ApplyResources(MenuStrip1, "MenuStrip1")
        MenuStrip1.Name = "MenuStrip1"
        ' 
        ' GeneratePreviewToolStripMenuItem
        ' 
        GeneratePreviewToolStripMenuItem.Name = "GeneratePreviewToolStripMenuItem"
        resources.ApplyResources(GeneratePreviewToolStripMenuItem, "GeneratePreviewToolStripMenuItem")
        ' 
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(editor_grp)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        Name = "Form1"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents lang_cmb As ComboBox
    Friend WithEvents lang_lbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents IVStatsNoteHeader_lbl As Label
    Friend WithEvents IVStatsNote_lbl As Label
End Class
