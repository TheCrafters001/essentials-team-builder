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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pg_Trainer = New System.Windows.Forms.TabPage()
        Me.pg_POne = New System.Windows.Forms.TabPage()
        Me.pg_PTwo = New System.Windows.Forms.TabPage()
        Me.pg_PThree = New System.Windows.Forms.TabPage()
        Me.pg_PFour = New System.Windows.Forms.TabPage()
        Me.pg_PFive = New System.Windows.Forms.TabPage()
        Me.pg_PSix = New System.Windows.Forms.TabPage()
        Me.pg_About = New System.Windows.Forms.TabPage()
        Me.aboutText_lbl = New System.Windows.Forms.Label()
        Me.gnuGPL3_picBox = New System.Windows.Forms.PictureBox()
        Me.aboutAuthor_lbl = New System.Windows.Forms.Label()
        Me.aboutTitle_lbl = New System.Windows.Forms.Label()
        Me.Logo_picBox = New System.Windows.Forms.PictureBox()
        Me.pg_Output = New System.Windows.Forms.TabPage()
        Me.trainerInfoTitle_lbl = New System.Windows.Forms.Label()
        Me.trainerName_txtBox = New System.Windows.Forms.TextBox()
        Me.trainerName_lbl = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.pg_Trainer.SuspendLayout()
        Me.pg_About.SuspendLayout()
        CType(Me.gnuGPL3_picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Logo_picBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'pg_POne
        '
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
        Me.pg_PTwo.Location = New System.Drawing.Point(4, 22)
        Me.pg_PTwo.Name = "pg_PTwo"
        Me.pg_PTwo.Size = New System.Drawing.Size(752, 511)
        Me.pg_PTwo.TabIndex = 2
        Me.pg_PTwo.Text = "Pokémon 2"
        Me.pg_PTwo.UseVisualStyleBackColor = True
        '
        'pg_PThree
        '
        Me.pg_PThree.Location = New System.Drawing.Point(4, 22)
        Me.pg_PThree.Name = "pg_PThree"
        Me.pg_PThree.Size = New System.Drawing.Size(752, 511)
        Me.pg_PThree.TabIndex = 3
        Me.pg_PThree.Text = "Pokémon 3"
        Me.pg_PThree.UseVisualStyleBackColor = True
        '
        'pg_PFour
        '
        Me.pg_PFour.Location = New System.Drawing.Point(4, 22)
        Me.pg_PFour.Name = "pg_PFour"
        Me.pg_PFour.Size = New System.Drawing.Size(752, 511)
        Me.pg_PFour.TabIndex = 4
        Me.pg_PFour.Text = "Pokémon 4"
        Me.pg_PFour.UseVisualStyleBackColor = True
        '
        'pg_PFive
        '
        Me.pg_PFive.Location = New System.Drawing.Point(4, 22)
        Me.pg_PFive.Name = "pg_PFive"
        Me.pg_PFive.Size = New System.Drawing.Size(752, 511)
        Me.pg_PFive.TabIndex = 5
        Me.pg_PFive.Text = "Pokémon 5"
        Me.pg_PFive.UseVisualStyleBackColor = True
        '
        'pg_PSix
        '
        Me.pg_PSix.Location = New System.Drawing.Point(4, 22)
        Me.pg_PSix.Name = "pg_PSix"
        Me.pg_PSix.Size = New System.Drawing.Size(752, 511)
        Me.pg_PSix.TabIndex = 6
        Me.pg_PSix.Text = "Pokémon 6"
        Me.pg_PSix.UseVisualStyleBackColor = True
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
        'pg_Output
        '
        Me.pg_Output.Location = New System.Drawing.Point(4, 22)
        Me.pg_Output.Name = "pg_Output"
        Me.pg_Output.Size = New System.Drawing.Size(752, 511)
        Me.pg_Output.TabIndex = 8
        Me.pg_Output.Text = "Output"
        Me.pg_Output.UseVisualStyleBackColor = True
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
        'trainerName_txtBox
        '
        Me.trainerName_txtBox.Location = New System.Drawing.Point(6, 55)
        Me.trainerName_txtBox.MaxLength = 25
        Me.trainerName_txtBox.Name = "trainerName_txtBox"
        Me.trainerName_txtBox.Size = New System.Drawing.Size(127, 22)
        Me.trainerName_txtBox.TabIndex = 1
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
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.pg_Trainer.ResumeLayout(False)
        Me.pg_Trainer.PerformLayout()
        Me.pg_About.ResumeLayout(False)
        Me.pg_About.PerformLayout()
        CType(Me.gnuGPL3_picBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Logo_picBox, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
