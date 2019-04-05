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

        Randomize()
        value = CInt(Int((37 * Rnd()) - 1))
        For Each row As Integer In roulette
            If row = value Then
                index = r
            End If
            r = r + 1
        Next
        r = 0
        Timer1.Enabled = True
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
        If r >= index + 111 Then
            Timer1.Enabled = False
            radio(n).Checked = False
            radio(index).Checked = True
            Back.Show()
            MsgBox("Vyhrálo číslo " + value.ToString + " pojďme se mrknout co to pro tebe znamená")

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

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Game.Show()
        'Do příště musím upravit aby se refreshnula stránka.. pravděpodobně spustit reset code
    End Sub
End Class