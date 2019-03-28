<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
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

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Money = New System.Windows.Forms.Label()
        Me.Tips = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TenCredit = New System.Windows.Forms.RadioButton()
        Me.TipsHundred = New System.Windows.Forms.Label()
        Me.TipsFifty = New System.Windows.Forms.Label()
        Me.TipsTen = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Play = New System.Windows.Forms.Button()
        CType(Me.Tips, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Tips
        '
        Me.Tips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tips.Location = New System.Drawing.Point(1439, 12)
        Me.Tips.Name = "Tips"
        Me.Tips.RowTemplate.Height = 24
        Me.Tips.Size = New System.Drawing.Size(448, 744)
        Me.Tips.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.TenCredit)
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
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(150, 115)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(188, 42)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.Text = "100 Korun"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(150, 76)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(170, 42)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "50 Korun"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TenCredit
        '
        Me.TenCredit.AutoSize = True
        Me.TenCredit.Checked = True
        Me.TenCredit.Location = New System.Drawing.Point(150, 35)
        Me.TenCredit.Name = "TenCredit"
        Me.TenCredit.Size = New System.Drawing.Size(170, 42)
        Me.TenCredit.TabIndex = 0
        Me.TenCredit.TabStop = True
        Me.TenCredit.Text = "10 Korun"
        Me.TenCredit.UseVisualStyleBackColor = True
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 502)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 38)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(319, 560)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 38)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "0"
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.Ruleta_CZU.My.Resources.Resources.ruleta
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1416, 449)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Play
        '
        Me.Play.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Play.ForeColor = System.Drawing.Color.White
        Me.Play.Location = New System.Drawing.Point(837, 486)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(591, 166)
        Me.Play.TabIndex = 12
        Me.Play.Text = "HRÁT"
        Me.Play.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1974, 804)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Tips)
        Me.Controls.Add(Me.Money)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "MainMenu"
        CType(Me.Tips, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Money As Label
    Friend WithEvents Tips As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents TenCredit As RadioButton
    Friend WithEvents TipsTen As Label
    Friend WithEvents TipsFifty As Label
    Friend WithEvents TipsHundred As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Play As Button
End Class
