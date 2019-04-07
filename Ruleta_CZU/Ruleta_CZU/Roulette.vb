Public Class Roulette
    Dim value As Integer = 0
    Dim index As Integer = 0

    Public WithEvents newPictureBox As Windows.Forms.PictureBox

    Private Sub Roulette_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createRoulette()
        newPictureBox = New Windows.Forms.PictureBox
        newPictureBox.Image = Ruleta_CZU.My.Resources.Resources.kolo
        newPictureBox.Width = 700
        newPictureBox.Height = 700
        newPictureBox.Location = New Point(12, 12)
        Me.Controls.Add(newPictureBox)
    End Sub
    Dim roulette = New Integer() {0, 32, 15, 19, 4, 21, 2, 25, 17, 34, 6, 27, 13, 36, 11, 30, 8, 23, 10, 5, 24, 16, 33, 1, 20, 14, 31, 9, 22, 18, 29, 7, 28, 12, 35, 3, 26}
    Private radio(37) As RadioButton
    Private Sub createRoulette()
        Dim x As Integer
        Dim y As Integer
        Dim n As Integer = 0
        For alfa = 0 To 2 * 3.141592 Step 2 * 3.141592 / 37
            x = 350 + 240 * Math.Cos(alfa)
            y = 350 + 240 * Math.Sin(alfa)
            If n < 37 Then
                radio(n) = New RadioButton
                With radio(n)
                    .Parent = Me
                    .Width = 13
                    .Height = 20
                    .Name = Roulette(n)
                    .Left = x
                    .Top = y
                    If n = 0 Then
                        .Checked = True
                    End If
                End With
            End If
            n = n + 1
        Next alfa

    End Sub
    Dim n As Integer = 0
    Dim r As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '111
        If r >= index + 111 Then
            Timer1.Enabled = False
            radio(n).Checked = False
            radio(n).BackColor = Color.White
            radio(index).Checked = True
            radio(index).BackColor = Color.Yellow

            Back.Show()
            MsgBox("Vyhrálo číslo " + value.ToString + " pojďme se mrknout co to pro tebe znamená")
            showTipResults()
        Else
            radio(n).BackColor = Color.White
            radio(n).Checked = False
            If n >= 36 Then
                n = 0
                Timer1.Interval = Timer1.Interval + 5
            Else
                n = n + 1
            End If
            r = r + 1
            Timer1.Interval = Timer1.Interval + 1
            radio(n).Checked = True
            radio(n).BackColor = Color.Yellow
        End If
    End Sub
    Public Sub startRoulette()
        Win.Hide()
        Lose.Hide()
        Randomize()
        value = CInt(Int((37 * Rnd()) + 0))
        r = 0
        For Each row As Integer In roulette
            If row = value Then
                index = r
            End If
            r = r + 1
        Next
        r = 0
        n = 0
        Timer1.Enabled = True
    End Sub
    Private Sub showTipResults()
        Dim bool As Boolean
        Dim winMoney As Integer = 0
        Dim loseMoney As Integer = 0
        For Each row As DataGridViewRow In Game.TipsView.Rows
            bool = True
            If row.Cells(0).Value = value.ToString Then
                Game.player.win = Game.player.win + 1
                winMoney = winMoney + row.Cells(1).Value * 35
                bool = False
            End If
            If row.Cells(0).Value = "SUDÁ" And roulette(index) Mod 2 = 0 Then
                winMoney = winMoney + row.Cells(1).Value
                Game.player.win = Game.player.win + 1
                bool = False
            End If
            If row.Cells(0).Value = "LICHÁ" And roulette(index) Mod 2 > 0 Then
                bool = False
                Game.player.win = Game.player.win + 1
                winMoney = winMoney + row.Cells(1).Value
            End If
            If row.Cells(0).Value = "ČERVENÁ" And index Mod 2 > 0 Then
                winMoney = winMoney + row.Cells(1).Value
                Game.player.win = Game.player.win + 1
                bool = False
            End If
            If row.Cells(0).Value = "ČERNÁ" And index Mod 2 = 0 Then
                bool = False
                Game.player.win = Game.player.win + 1
                winMoney = winMoney + row.Cells(1).Value
            End If
            If row.Cells(0).Value = "1-18" And roulette(index) < 19 Then
                bool = False
                Game.player.win = Game.player.win + 1
                winMoney = winMoney + row.Cells(1).Value
            End If
            If row.Cells(0).Value = "19-36" And roulette(index) > 18 Then
                bool = False
                Game.player.win = Game.player.win + 1
                winMoney = winMoney + row.Cells(1).Value
            End If
            If bool Then
                If row.Cells(0).Value = Nothing Then
                Else
                    Game.player.lose = Game.player.lose + 1
                    loseMoney = loseMoney + row.Cells(1).Value
                End If
            End If
        Next
        Win.Visible = Visible
        Win.Text = "Vyhrál si: " + winMoney.ToString
        Lose.Visible = Visible
        Lose.Text = "Prohrál si: " + loseMoney.ToString
        Game.player.money = Game.player.money + winMoney - loseMoney
    End Sub
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        radio(index).Checked = False
        radio(index).BackColor = Color.White
        Back.Hide()
        Game.Show()
        Game.freshStart()

    End Sub
End Class