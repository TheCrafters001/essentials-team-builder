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
        Me.sidebar = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.trainerBtnPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.logoPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrainerInfoPanel = New System.Windows.Forms.Panel()
        Me.Pokemon = New System.Windows.Forms.Panel()
        Me.sidebar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.trainerBtnPanel.SuspendLayout()
        Me.logoPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'sidebar
        '
        Me.sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.sidebar.Controls.Add(Me.Panel1)
        Me.sidebar.Controls.Add(Me.trainerBtnPanel)
        Me.sidebar.Controls.Add(Me.logoPanel)
        Me.sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebar.ForeColor = System.Drawing.Color.White
        Me.sidebar.Location = New System.Drawing.Point(0, 0)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Size = New System.Drawing.Size(217, 534)
        Me.sidebar.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 136)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(217, 54)
        Me.Panel1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 54)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Pokemon"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'trainerBtnPanel
        '
        Me.trainerBtnPanel.Controls.Add(Me.Label2)
        Me.trainerBtnPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.trainerBtnPanel.Location = New System.Drawing.Point(0, 82)
        Me.trainerBtnPanel.Name = "trainerBtnPanel"
        Me.trainerBtnPanel.Size = New System.Drawing.Size(217, 54)
        Me.trainerBtnPanel.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 54)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Trainer"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'logoPanel
        '
        Me.logoPanel.BackColor = System.Drawing.Color.Transparent
        Me.logoPanel.Controls.Add(Me.Label1)
        Me.logoPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.logoPanel.Location = New System.Drawing.Point(0, 0)
        Me.logoPanel.Name = "logoPanel"
        Me.logoPanel.Size = New System.Drawing.Size(217, 82)
        Me.logoPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 82)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LOGO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrainerInfoPanel
        '
        Me.TrainerInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TrainerInfoPanel.Location = New System.Drawing.Point(217, 0)
        Me.TrainerInfoPanel.Name = "TrainerInfoPanel"
        Me.TrainerInfoPanel.Size = New System.Drawing.Size(583, 534)
        Me.TrainerInfoPanel.TabIndex = 1
        '
        'Pokemon
        '
        Me.Pokemon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pokemon.Location = New System.Drawing.Point(217, 0)
        Me.Pokemon.Name = "Pokemon"
        Me.Pokemon.Size = New System.Drawing.Size(583, 534)
        Me.Pokemon.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 534)
        Me.Controls.Add(Me.Pokemon)
        Me.Controls.Add(Me.TrainerInfoPanel)
        Me.Controls.Add(Me.sidebar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.sidebar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.trainerBtnPanel.ResumeLayout(False)
        Me.logoPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sidebar As Panel
    Friend WithEvents logoPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents trainerBtnPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TrainerInfoPanel As Panel
    Friend WithEvents Pokemon As Panel
End Class
