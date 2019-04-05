<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
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

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.Money = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HundredTip = New System.Windows.Forms.RadioButton()
        Me.FiftyTip = New System.Windows.Forms.RadioButton()
        Me.TenTip = New System.Windows.Forms.RadioButton()
        Me.TipsHundred = New System.Windows.Forms.Label()
        Me.TipsFifty = New System.Windows.Forms.Label()
        Me.TipsTen = New System.Windows.Forms.Label()
        Me.MoneyL = New System.Windows.Forms.Label()
        Me.MoneyLL = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Play = New System.Windows.Forms.Button()
        Me.WinL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoseL = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuccessL = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Bet_0 = New System.Windows.Forms.Button()
        Me.FirstHalfB = New System.Windows.Forms.Button()
        Me.EvenB = New System.Windows.Forms.Button()
        Me.BlackB = New System.Windows.Forms.Button()
        Me.OddB = New System.Windows.Forms.Button()
        Me.LastHalfB = New System.Windows.Forms.Button()
        Me.RedB = New System.Windows.Forms.Button()
        Me.TipsView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TipsView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Money
        '
        Me.Money.AutoSize = True
        Me.Money.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Money.Location = New System.Drawing.Point(5, 502)
        Me.Money.Name = "Money"
        Me.Money.Size = New System.Drawing.Size(126, 38)
        Me.Money.TabIndex = 2
        Me.Money.Text = "Peníze:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.HundredTip)
        Me.GroupBox1.Controls.Add(Me.FiftyTip)
        Me.GroupBox1.Controls.Add(Me.TenTip)
        Me.GroupBox1.Controls.Add(Me.TipsHundred)
        Me.GroupBox1.Controls.Add(Me.TipsFifty)
        Me.GroupBox1.Controls.Add(Me.TipsTen)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(456, 467)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(356, 185)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sázky"
        '
        'HundredTip
        '
        Me.HundredTip.AutoSize = True
        Me.HundredTip.Location = New System.Drawing.Point(150, 115)
        Me.HundredTip.Name = "HundredTip"
        Me.HundredTip.Size = New System.Drawing.Size(188, 42)
        Me.HundredTip.TabIndex = 2
        Me.HundredTip.Text = "100 Korun"
        Me.HundredTip.UseVisualStyleBackColor = True
        '
        'FiftyTip
        '
        Me.FiftyTip.AutoSize = True
        Me.FiftyTip.Location = New System.Drawing.Point(150, 76)
        Me.FiftyTip.Name = "FiftyTip"
        Me.FiftyTip.Size = New System.Drawing.Size(170, 42)
        Me.FiftyTip.TabIndex = 1
        Me.FiftyTip.Text = "50 Korun"
        Me.FiftyTip.UseVisualStyleBackColor = True
        '
        'TenTip
        '
        Me.TenTip.AutoSize = True
        Me.TenTip.Checked = True
        Me.TenTip.Location = New System.Drawing.Point(150, 35)
        Me.TenTip.Name = "TenTip"
        Me.TenTip.Size = New System.Drawing.Size(170, 42)
        Me.TenTip.TabIndex = 0
        Me.TenTip.TabStop = True
        Me.TenTip.Text = "10 Korun"
        Me.TenTip.UseVisualStyleBackColor = True
        '
        'TipsHundred
        '
        Me.TipsHundred.AutoSize = True
        Me.TipsHundred.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TipsHundred.Location = New System.Drawing.Point(17, 115)
        Me.TipsHundred.Name = "TipsHundred"
        Me.TipsHundred.Size = New System.Drawing.Size(71, 38)
        Me.TipsHundred.TabIndex = 8
        Me.TipsHundred.Text = "100"
        '
        'TipsFifty
        '
        Me.TipsFifty.AutoSize = True
        Me.TipsFifty.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TipsFifty.Location = New System.Drawing.Point(17, 76)
        Me.TipsFifty.Name = "TipsFifty"
        Me.TipsFifty.Size = New System.Drawing.Size(53, 38)
        Me.TipsFifty.TabIndex = 7
        Me.TipsFifty.Text = "50"
        Me.TipsFifty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TipsTen
        '
        Me.TipsTen.AutoSize = True
        Me.TipsTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TipsTen.Location = New System.Drawing.Point(17, 37)
        Me.TipsTen.Name = "TipsTen"
        Me.TipsTen.Size = New System.Drawing.Size(53, 38)
        Me.TipsTen.TabIndex = 6
        Me.TipsTen.Text = "10"
        '
        'MoneyL
        '
        Me.MoneyL.AutoSize = True
        Me.MoneyL.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.MoneyL.Location = New System.Drawing.Point(319, 502)
        Me.MoneyL.Name = "MoneyL"
        Me.MoneyL.Size = New System.Drawing.Size(35, 38)
        Me.MoneyL.TabIndex = 9
        Me.MoneyL.Text = "0"
        '
        'MoneyLL
        '
        Me.MoneyLL.AutoSize = True
        Me.MoneyLL.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.MoneyLL.Location = New System.Drawing.Point(319, 560)
        Me.MoneyLL.Name = "MoneyLL"
        Me.MoneyLL.Size = New System.Drawing.Size(35, 38)
        Me.MoneyLL.TabIndex = 11
        Me.MoneyLL.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 560)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(298, 38)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Kolik můžeš vsadit:"
        '
        'Play
        '
        Me.Play.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Play.ForeColor = System.Drawing.Color.White
        Me.Play.Location = New System.Drawing.Point(837, 486)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(715, 166)
        Me.Play.TabIndex = 12
        Me.Play.Text = "HRÁT"
        Me.Play.UseVisualStyleBackColor = False
        Me.Play.Visible = False
        '
        'WinL
        '
        Me.WinL.AutoSize = True
        Me.WinL.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.WinL.Location = New System.Drawing.Point(319, 614)
        Me.WinL.Name = "WinL"
        Me.WinL.Size = New System.Drawing.Size(35, 38)
        Me.WinL.TabIndex = 14
        Me.WinL.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 614)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 38)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Počet výher"
        '
        'LoseL
        '
        Me.LoseL.AutoSize = True
        Me.LoseL.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LoseL.Location = New System.Drawing.Point(319, 668)
        Me.LoseL.Name = "LoseL"
        Me.LoseL.Size = New System.Drawing.Size(35, 38)
        Me.LoseL.TabIndex = 16
        Me.LoseL.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 668)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 38)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Počet proher"
        '
        'SuccessL
        '
        Me.SuccessL.AutoSize = True
        Me.SuccessL.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.SuccessL.Location = New System.Drawing.Point(319, 718)
        Me.SuccessL.Name = "SuccessL"
        Me.SuccessL.Size = New System.Drawing.Size(0, 38)
        Me.SuccessL.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 718)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(314, 38)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Procenta uspěšnosti"
        '
        'Bet_0
        '
        Me.Bet_0.BackColor = System.Drawing.Color.DarkGreen
        Me.Bet_0.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, CType(238, Byte))
        Me.Bet_0.ForeColor = System.Drawing.Color.White
        Me.Bet_0.Location = New System.Drawing.Point(12, 12)
        Me.Bet_0.Name = "Bet_0"
        Me.Bet_0.Size = New System.Drawing.Size(173, 345)
        Me.Bet_0.TabIndex = 21
        Me.Bet_0.Text = "0"
        Me.Bet_0.UseVisualStyleBackColor = False
        '
        'FirstHalfB
        '
        Me.FirstHalfB.BackColor = System.Drawing.Color.DarkGreen
        Me.FirstHalfB.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FirstHalfB.ForeColor = System.Drawing.SystemColors.Window
        Me.FirstHalfB.Location = New System.Drawing.Point(189, 358)
        Me.FirstHalfB.Name = "FirstHalfB"
        Me.FirstHalfB.Size = New System.Drawing.Size(224, 103)
        Me.FirstHalfB.TabIndex = 22
        Me.FirstHalfB.Text = "1-18"
        Me.FirstHalfB.UseVisualStyleBackColor = False
        '
        'EvenB
        '
        Me.EvenB.BackColor = System.Drawing.Color.DarkGreen
        Me.EvenB.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.EvenB.ForeColor = System.Drawing.Color.White
        Me.EvenB.Location = New System.Drawing.Point(414, 358)
        Me.EvenB.Name = "EvenB"
        Me.EvenB.Size = New System.Drawing.Size(223, 103)
        Me.EvenB.TabIndex = 22
        Me.EvenB.Text = "SUDÁ"
        Me.EvenB.UseVisualStyleBackColor = False
        '
        'BlackB
        '
        Me.BlackB.BackColor = System.Drawing.Color.Black
        Me.BlackB.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BlackB.ForeColor = System.Drawing.Color.White
        Me.BlackB.Location = New System.Drawing.Point(872, 358)
        Me.BlackB.Name = "BlackB"
        Me.BlackB.Size = New System.Drawing.Size(223, 103)
        Me.BlackB.TabIndex = 22
        Me.BlackB.Text = "ČERNÁ"
        Me.BlackB.UseVisualStyleBackColor = False
        '
        'OddB
        '
        Me.OddB.BackColor = System.Drawing.Color.DarkGreen
        Me.OddB.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.OddB.ForeColor = System.Drawing.Color.White
        Me.OddB.Location = New System.Drawing.Point(1101, 358)
        Me.OddB.Name = "OddB"
        Me.OddB.Size = New System.Drawing.Size(223, 103)
        Me.OddB.TabIndex = 22
        Me.OddB.Text = "LICHÁ"
        Me.OddB.UseVisualStyleBackColor = False
        '
        'LastHalfB
        '
        Me.LastHalfB.BackColor = System.Drawing.Color.DarkGreen
        Me.LastHalfB.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LastHalfB.ForeColor = System.Drawing.Color.White
        Me.LastHalfB.Location = New System.Drawing.Point(1330, 358)
        Me.LastHalfB.Name = "LastHalfB"
        Me.LastHalfB.Size = New System.Drawing.Size(222, 103)
        Me.LastHalfB.TabIndex = 22
        Me.LastHalfB.Text = "19-36"
        Me.LastHalfB.UseVisualStyleBackColor = False
        '
        'RedB
        '
        Me.RedB.BackColor = System.Drawing.Color.Red
        Me.RedB.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RedB.ForeColor = System.Drawing.Color.White
        Me.RedB.Location = New System.Drawing.Point(643, 358)
        Me.RedB.Name = "RedB"
        Me.RedB.Size = New System.Drawing.Size(223, 103)
        Me.RedB.TabIndex = 22
        Me.RedB.Text = "ČERVENÁ"
        Me.RedB.UseVisualStyleBackColor = False
        '
        'TipsView
        '
        Me.TipsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.TipsView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.TipsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TipsView.Location = New System.Drawing.Point(1561, 13)
        Me.TipsView.Name = "TipsView"
        Me.TipsView.RowTemplate.Height = 24
        Me.TipsView.Size = New System.Drawing.Size(228, 639)
        Me.TipsView.TabIndex = 23
        '
        'Game
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1801, 804)
        Me.Controls.Add(Me.TipsView)
        Me.Controls.Add(Me.LastHalfB)
        Me.Controls.Add(Me.OddB)
        Me.Controls.Add(Me.RedB)
        Me.Controls.Add(Me.BlackB)
        Me.Controls.Add(Me.EvenB)
        Me.Controls.Add(Me.FirstHalfB)
        Me.Controls.Add(Me.Bet_0)
        Me.Controls.Add(Me.SuccessL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LoseL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.WinL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.MoneyLL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MoneyL)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Money)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TipsView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Money As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents HundredTip As RadioButton
    Friend WithEvents TenTip As RadioButton
    Friend WithEvents TipsTen As Label
    Friend WithEvents TipsFifty As Label
    Friend WithEvents TipsHundred As Label
    Friend WithEvents MoneyL As Label
    Friend WithEvents MoneyLL As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Play As Button
    Friend WithEvents WinL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LoseL As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SuccessL As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Bet_0 As Button
    Friend WithEvents FirstHalfB As Button
    Friend WithEvents EvenB As Button
    Friend WithEvents BlackB As Button
    Friend WithEvents OddB As Button
    Friend WithEvents LastHalfB As Button
    Friend WithEvents RedB As Button
    Friend WithEvents TipsView As DataGridView
    Friend WithEvents FiftyTip As RadioButton
End Class
