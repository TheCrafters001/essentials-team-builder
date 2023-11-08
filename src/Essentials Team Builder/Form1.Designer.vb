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
        essData_lbl = New Label()
        allowSuperShiny_chk = New CheckBox()
        loseTextQuotes_chkBox = New CheckBox()
        useAbilityIndex_chkBox = New CheckBox()
        existingBattle_chkBox = New CheckBox()
        customBallIDs_chkBox = New CheckBox()
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
        pg_pkmn1 = New TabPage()
        pokemon1_grp = New GroupBox()
        pokemon1HeldItem_lbl = New Label()
        pokemon1HeldItem_txtBox = New TextBox()
        pokemon1Name_txtBox = New TextBox()
        pokemon1Name_lbl = New Label()
        pg_pkmn2 = New TabPage()
        pokemon2_grp = New GroupBox()
        pg_pkmn3 = New TabPage()
        pokemon3_grp = New GroupBox()
        pg_pkmn4 = New TabPage()
        pokemon4_grp = New GroupBox()
        pg_pkmn5 = New TabPage()
        pokemon5_grp = New GroupBox()
        pg_pkmn6 = New TabPage()
        pokemon6_grp = New GroupBox()
        preview_grp = New GroupBox()
        preview_rtb = New RichTextBox()
        updatePreview_btn = New Button()
        properSpellingNote_lbl = New Label()
        Label2 = New Label()
        pokemon1Level_lbl = New Label()
        pokemon1Level_txtBox = New TextBox()
        editor_grp.SuspendLayout()
        editor_tab.SuspendLayout()
        pg_trainer.SuspendLayout()
        trainer_tab.SuspendLayout()
        pg_basic.SuspendLayout()
        pg_pokemon.SuspendLayout()
        TabControl3.SuspendLayout()
        pg_pkmn1.SuspendLayout()
        pokemon1_grp.SuspendLayout()
        pg_pkmn2.SuspendLayout()
        pg_pkmn3.SuspendLayout()
        pg_pkmn4.SuspendLayout()
        pg_pkmn5.SuspendLayout()
        pg_pkmn6.SuspendLayout()
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
        pg_basic.Controls.Add(essData_lbl)
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
        ' essData_lbl
        ' 
        essData_lbl.AutoSize = True
        essData_lbl.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
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
        TabControl3.Controls.Add(pg_pkmn1)
        TabControl3.Controls.Add(pg_pkmn2)
        TabControl3.Controls.Add(pg_pkmn3)
        TabControl3.Controls.Add(pg_pkmn4)
        TabControl3.Controls.Add(pg_pkmn5)
        TabControl3.Controls.Add(pg_pkmn6)
        TabControl3.Dock = DockStyle.Fill
        TabControl3.Location = New Point(3, 3)
        TabControl3.Multiline = True
        TabControl3.Name = "TabControl3"
        TabControl3.SelectedIndex = 0
        TabControl3.Size = New Size(737, 503)
        TabControl3.TabIndex = 0
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
        pokemon1_grp.Controls.Add(pokemon1Level_txtBox)
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
        pokemon2_grp.Dock = DockStyle.Fill
        pokemon2_grp.Location = New Point(3, 3)
        pokemon2_grp.Name = "pokemon2_grp"
        pokemon2_grp.Size = New Size(723, 469)
        pokemon2_grp.TabIndex = 0
        pokemon2_grp.TabStop = False
        pokemon2_grp.Text = "Pokémon 2"
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
        pokemon3_grp.Dock = DockStyle.Fill
        pokemon3_grp.Location = New Point(3, 3)
        pokemon3_grp.Name = "pokemon3_grp"
        pokemon3_grp.Size = New Size(723, 469)
        pokemon3_grp.TabIndex = 0
        pokemon3_grp.TabStop = False
        pokemon3_grp.Text = "Pokémon 3"
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
        pokemon4_grp.Dock = DockStyle.Fill
        pokemon4_grp.Location = New Point(3, 3)
        pokemon4_grp.Name = "pokemon4_grp"
        pokemon4_grp.Size = New Size(723, 469)
        pokemon4_grp.TabIndex = 0
        pokemon4_grp.TabStop = False
        pokemon4_grp.Text = "Pokémon 4"
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
        pokemon5_grp.Dock = DockStyle.Fill
        pokemon5_grp.Location = New Point(3, 3)
        pokemon5_grp.Name = "pokemon5_grp"
        pokemon5_grp.Size = New Size(723, 469)
        pokemon5_grp.TabIndex = 0
        pokemon5_grp.TabStop = False
        pokemon5_grp.Text = "Pokémon 5"
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
        pokemon6_grp.Dock = DockStyle.Fill
        pokemon6_grp.Location = New Point(3, 3)
        pokemon6_grp.Name = "pokemon6_grp"
        pokemon6_grp.Size = New Size(723, 469)
        pokemon6_grp.TabIndex = 0
        pokemon6_grp.TabStop = False
        pokemon6_grp.Text = "Pokémon 6"
        ' 
        ' preview_grp
        ' 
        preview_grp.Controls.Add(preview_rtb)
        preview_grp.Location = New Point(775, 12)
        preview_grp.Name = "preview_grp"
        preview_grp.Size = New Size(461, 559)
        preview_grp.TabIndex = 1
        preview_grp.TabStop = False
        preview_grp.Text = "Preview"
        ' 
        ' preview_rtb
        ' 
        preview_rtb.Dock = DockStyle.Fill
        preview_rtb.Location = New Point(3, 19)
        preview_rtb.Name = "preview_rtb"
        preview_rtb.ReadOnly = True
        preview_rtb.Size = New Size(455, 537)
        preview_rtb.TabIndex = 0
        preview_rtb.Text = ""
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(210, 567)
        Label2.Name = "Label2"
        Label2.Size = New Size(772, 15)
        Label2.TabIndex = 25
        Label2.Text = "Moves and Items MUST be one word. (ie: Fire Blast = FireBlast). Leave IVs and EVs 0 if you don't want to set them, or don't know how to use them."
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
        ' pokemon1Level_txtBox
        ' 
        pokemon1Level_txtBox.Location = New Point(298, 37)
        pokemon1Level_txtBox.MaxLength = 3
        pokemon1Level_txtBox.Name = "pokemon1Level_txtBox"
        pokemon1Level_txtBox.PlaceholderText = "100"
        pokemon1Level_txtBox.Size = New Size(140, 23)
        pokemon1Level_txtBox.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1248, 583)
        Controls.Add(Label2)
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
        pg_pkmn1.ResumeLayout(False)
        pokemon1_grp.ResumeLayout(False)
        pokemon1_grp.PerformLayout()
        pg_pkmn2.ResumeLayout(False)
        pg_pkmn3.ResumeLayout(False)
        pg_pkmn4.ResumeLayout(False)
        pg_pkmn5.ResumeLayout(False)
        pg_pkmn6.ResumeLayout(False)
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
    Friend WithEvents pg_pkmn5 As TabPage
    Friend WithEvents pg_pkmn6 As TabPage
    Friend WithEvents preview_grp As GroupBox
    Friend WithEvents pg_basic As TabPage
    Friend WithEvents pg_pkmn1 As TabPage
    Friend WithEvents pg_pkmn2 As TabPage
    Friend WithEvents pg_pkmn3 As TabPage
    Friend WithEvents pg_pkmn4 As TabPage
    Friend WithEvents preview_rtb As RichTextBox
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
    Friend WithEvents Label2 As Label
    Friend WithEvents pokemon1Level_txtBox As TextBox
    Friend WithEvents pokemon1Level_lbl As Label
End Class
