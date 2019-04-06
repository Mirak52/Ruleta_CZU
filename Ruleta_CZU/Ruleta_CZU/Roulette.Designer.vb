<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Roulette
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Roulette))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Back = New System.Windows.Forms.Button()
        Me.Win = New System.Windows.Forms.Label()
        Me.Lose = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 40
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Back.ForeColor = System.Drawing.Color.White
        Me.Back.Location = New System.Drawing.Point(1157, 637)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(715, 166)
        Me.Back.TabIndex = 13
        Me.Back.TabStop = False
        Me.Back.Text = "ZPĚT"
        Me.Back.UseVisualStyleBackColor = False
        Me.Back.Visible = False
        '
        'Win
        '
        Me.Win.AutoSize = True
        Me.Win.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Win.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Win.Location = New System.Drawing.Point(1157, 206)
        Me.Win.Name = "Win"
        Me.Win.Size = New System.Drawing.Size(295, 95)
        Me.Win.TabIndex = 14
        Me.Win.Text = "Label1"
        Me.Win.Visible = False
        '
        'Lose
        '
        Me.Lose.AutoSize = True
        Me.Lose.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Lose.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Lose.Location = New System.Drawing.Point(1157, 349)
        Me.Lose.Name = "Lose"
        Me.Lose.Size = New System.Drawing.Size(295, 95)
        Me.Lose.TabIndex = 15
        Me.Lose.Text = "Label2"
        Me.Lose.Visible = False
        '
        'Roulette
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1884, 815)
        Me.Controls.Add(Me.Lose)
        Me.Controls.Add(Me.Win)
        Me.Controls.Add(Me.Back)
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Roulette"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roulette"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Back As Button
    Friend WithEvents Win As Label
    Friend WithEvents Lose As Label
End Class
