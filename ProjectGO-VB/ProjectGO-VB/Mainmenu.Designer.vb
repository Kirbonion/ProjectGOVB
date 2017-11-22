<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mainmenu
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
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ButtonStatistics = New System.Windows.Forms.Button()
        Me.ButtonSettings = New System.Windows.Forms.Button()
        Me.ButtonLoadGame = New System.Windows.Forms.Button()
        Me.ButtonJoinGame = New System.Windows.Forms.Button()
        Me.PanelLeft.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelLeft.Controls.Add(Me.Panel4)
        Me.PanelLeft.Controls.Add(Me.Panel3)
        Me.PanelLeft.Controls.Add(Me.Button5)
        Me.PanelLeft.Controls.Add(Me.ButtonStatistics)
        Me.PanelLeft.Controls.Add(Me.ButtonSettings)
        Me.PanelLeft.Controls.Add(Me.ButtonLoadGame)
        Me.PanelLeft.Controls.Add(Me.ButtonJoinGame)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(178, 768)
        Me.PanelLeft.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(178, 74)
        Me.Panel4.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 74)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ProjectGO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(168, 74)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 56)
        Me.Panel3.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(0, 712)
        Me.Button5.Margin = New System.Windows.Forms.Padding(0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(178, 56)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Exit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ButtonStatistics
        '
        Me.ButtonStatistics.FlatAppearance.BorderSize = 0
        Me.ButtonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStatistics.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStatistics.Location = New System.Drawing.Point(0, 242)
        Me.ButtonStatistics.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonStatistics.Name = "ButtonStatistics"
        Me.ButtonStatistics.Size = New System.Drawing.Size(178, 56)
        Me.ButtonStatistics.TabIndex = 3
        Me.ButtonStatistics.Text = "Statistics"
        Me.ButtonStatistics.UseVisualStyleBackColor = True
        '
        'ButtonSettings
        '
        Me.ButtonSettings.FlatAppearance.BorderSize = 0
        Me.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSettings.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSettings.Location = New System.Drawing.Point(0, 186)
        Me.ButtonSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonSettings.Name = "ButtonSettings"
        Me.ButtonSettings.Size = New System.Drawing.Size(178, 56)
        Me.ButtonSettings.TabIndex = 2
        Me.ButtonSettings.Text = "Settings"
        Me.ButtonSettings.UseVisualStyleBackColor = True
        '
        'ButtonLoadGame
        '
        Me.ButtonLoadGame.FlatAppearance.BorderSize = 0
        Me.ButtonLoadGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLoadGame.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLoadGame.Location = New System.Drawing.Point(0, 130)
        Me.ButtonLoadGame.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonLoadGame.Name = "ButtonLoadGame"
        Me.ButtonLoadGame.Size = New System.Drawing.Size(178, 56)
        Me.ButtonLoadGame.TabIndex = 1
        Me.ButtonLoadGame.Text = "Load Game"
        Me.ButtonLoadGame.UseVisualStyleBackColor = True
        '
        'ButtonJoinGame
        '
        Me.ButtonJoinGame.FlatAppearance.BorderSize = 0
        Me.ButtonJoinGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonJoinGame.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonJoinGame.Location = New System.Drawing.Point(0, 74)
        Me.ButtonJoinGame.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonJoinGame.Name = "ButtonJoinGame"
        Me.ButtonJoinGame.Size = New System.Drawing.Size(178, 56)
        Me.ButtonJoinGame.TabIndex = 0
        Me.ButtonJoinGame.Text = "Join Game"
        Me.ButtonJoinGame.UseVisualStyleBackColor = True
        '
        'Mainmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.PanelLeft)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Mainmenu"
        Me.Text = "ProjectGO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelLeft.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLeft As Panel
    Friend WithEvents ButtonJoinGame As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ButtonStatistics As Button
    Friend WithEvents ButtonSettings As Button
    Friend WithEvents ButtonLoadGame As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
