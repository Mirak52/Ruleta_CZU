Public Class Game
    Dim player As New Player

    Public WithEvents newButton As Windows.Forms.Button
    Private Sub Pool_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        createButtons()
        resetMoneyLeft()
        showPlayerStats()
        TipsView.Rows.Clear()
        TipsView.Columns.Add("tip", "Vsazeno na")
        TipsView.Columns.Add("money", "Peněz vsazeno")
    End Sub
    Private Function createButtons()
        Dim x As Integer
        Dim y As Integer
        Dim i As Integer = 1
        For y = 0 To 11
            For x = 0 To 2
                newButton = New Windows.Forms.Button
                newButton.Name = "bet_" & i
                newButton.Text = i
                newButton.BackColor = Color.Red
                If i Mod 2 = 0 Then
                    newButton.BackColor = Color.Black
                End If
                newButton.ForeColor = Color.White
                newButton.Height = 112
                newButton.Width = 110
                newButton.Font = New Font("Arial", 40, FontStyle.Bold)
                newButton.Top = 14 + x * 115
                newButton.Left = 188 + y * 114
                AddHandler newButton.Click, AddressOf ButtonClicked
                Me.Controls.Add(newButton)
                i = i + 1
            Next
        Next
        AddHandler Bet_0.Click, AddressOf ButtonClicked
    End Function
    Private Sub ButtonClicked(ByVal sender As Object, ByVal e As EventArgs)
        'MsgBox("You clicked: " + sender.name + vbCrLf & "Button name: " + sender.Text)
        Dim i As Integer = getTip()
        MakeTip(sender.text, i)

    End Sub
    Dim column As Integer = 0
    Private Function MakeTip(tip As String, tipMoney As Integer)
        Play.Visible = Visible
        Dim alreadyTiped As String = Nothing

        If column > 0 Then
            alreadyTiped = checkTips(tip)
        End If
        If Not IsNothing(alreadyTiped) Then
            TipsView.Rows(alreadyTiped).Cells(1).Value = TipsView.Rows(alreadyTiped).Cells(1).Value + tipMoney
        Else
            TipsView.Rows.Add(1)
            TipsView.Rows(column).Cells(0).Value = tip
            TipsView.Rows(column).Cells(1).Value = tipMoney
            column = column + 1
        End If
        player.moneyLeft = player.moneyLeft - tipMoney
        showPlayerStats()
        checkPlayerMoneyLeft()
    End Function

    Private Function checkPlayerMoneyLeft()
        If player.moneyLeft < 10 Then

        ElseIf player.moneyLeft < 50 Then

        ElseIf player.moneyLeft < 100 Then
        End If

    End Function

    Private Function checkTips(tip As String) As Object
        Dim i As Integer = 0
        For Each row As DataGridViewRow In TipsView.Rows
            If row.Cells(0).Value = tip Then
                Return i
            End If
            i = i + 1
        Next
        Return Nothing
    End Function

    Private Function getTip()
        If TenTip.Checked = True Then
            Return 10
        ElseIf FiftyTip.Checked = True Then
            Return 50
        End If
        Return 100
    End Function

    Private Function resetMoneyLeft()
        player.moneyLeft = player.money
    End Function

    Private Function showPlayerStats()
        MoneyL.Text = player.money
        MoneyLL.Text = player.moneyLeft
        WinL.Text = player.win
        LoseL.Text = player.lose
        TipsTen.Text = player.moneyLeft \ 10
        TipsFifty.Text = player.moneyLeft \ 50
        TipsHundred.Text = player.moneyLeft \ 100
    End Function

    Private Sub Play_Click(sender As Object, e As EventArgs) Handles Play.Click

    End Sub



    Private Sub EvenB_Click(sender As Object, e As EventArgs) Handles EvenB.Click

    End Sub
    Private Sub OddB_Click(sender As Object, e As EventArgs) Handles OddB.Click

    End Sub
    Private Sub FirstHalfB_Click(sender As Object, e As EventArgs) Handles FirstHalfB.Click

    End Sub
    Private Sub LastHalfB_Click(sender As Object, e As EventArgs) Handles LastHalfB.Click

    End Sub
    Private Sub BlackB_Click(sender As Object, e As EventArgs) Handles BlackB.Click

    End Sub
    Private Sub RedB_Click(sender As Object, e As EventArgs) Handles RedB.Click

    End Sub
End Class
