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
        newPictureBox.Location = New Point(17, 17)
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
    Private radio(50) As RadioButton
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
                    .Width = 30
                    .Height = 20
                    .Name = Roulette(n)
                    .Left = x
                    .Top = y
                    .BackColor = Color.Transparent
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
        If r >= index + 37 Then
            Timer1.Enabled = False
            radio(n).Checked = False
            radio(index).Checked = True

        Else
            radio(n).Checked = False
            If n >= 36 Then
                n = 0
            Else
                n = n + 1
            End If
            r = r + 1
            radio(n).Checked = True
        End If
    End Sub
End Class