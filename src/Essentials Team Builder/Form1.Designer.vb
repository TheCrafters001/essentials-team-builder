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
        pg_misc = New TabPage()
        pg_items = New TabPage()
        pg_pokemon = New TabPage()
        TabControl3 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        TabPage4 = New TabPage()
        TabPage5 = New TabPage()
        TabPage6 = New TabPage()
        livePreview_grp = New GroupBox()
        RichTextBox1 = New RichTextBox()
        editor_grp.SuspendLayout()
        editor_tab.SuspendLayout()
        pg_trainer.SuspendLayout()
        trainer_tab.SuspendLayout()
        pg_pokemon.SuspendLayout()
        TabControl3.SuspendLayout()
        livePreview_grp.SuspendLayout()
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
        trainer_tab.Controls.Add(pg_misc)
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
        pg_basic.Location = New Point(4, 24)
        pg_basic.Name = "pg_basic"
        pg_basic.Size = New Size(729, 475)
        pg_basic.TabIndex = 2
        pg_basic.Text = "Basic Info"
        pg_basic.UseVisualStyleBackColor = True
        ' 
        ' pg_misc
        ' 
        pg_misc.Location = New Point(4, 24)
        pg_misc.Name = "pg_misc"
        pg_misc.Padding = New Padding(3)
        pg_misc.Size = New Size(729, 475)
        pg_misc.TabIndex = 0
        pg_misc.Text = "Misc"
        pg_misc.UseVisualStyleBackColor = True
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
        ' livePreview_grp
        ' 
        livePreview_grp.Controls.Add(RichTextBox1)
        livePreview_grp.Location = New Point(775, 12)
        livePreview_grp.Name = "livePreview_grp"
        livePreview_grp.Size = New Size(461, 559)
        livePreview_grp.TabIndex = 1
        livePreview_grp.TabStop = False
        livePreview_grp.Text = "Live Preview"
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1248, 583)
        Controls.Add(livePreview_grp)
        Controls.Add(editor_grp)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        editor_grp.ResumeLayout(False)
        editor_tab.ResumeLayout(False)
        pg_trainer.ResumeLayout(False)
        trainer_tab.ResumeLayout(False)
        pg_pokemon.ResumeLayout(False)
        TabControl3.ResumeLayout(False)
        livePreview_grp.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents editor_grp As GroupBox
    Friend WithEvents editor_tab As TabControl
    Friend WithEvents pg_trainer As TabPage
    Friend WithEvents trainer_tab As TabControl
    Friend WithEvents pg_misc As TabPage
    Friend WithEvents pg_items As TabPage
    Friend WithEvents pg_pokemon As TabPage
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents livePreview_grp As GroupBox
    Friend WithEvents pg_basic As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
