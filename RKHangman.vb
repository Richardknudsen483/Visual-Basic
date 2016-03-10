Dim Word As String                  'will hold the word to be guessed
    Dim wordLength As Integer           'will hold the lengh of the word
    Dim char1 As String                 'will hold the first letter of the word
    Dim char2 As String                 'will hold the second letter of the wordd
    Dim char3 As String                 'will hold the third letter of the word
    Dim char4 As String                 'will hold the fourth letter of the word
    Dim char5 As String                 'will hold the fifth letter of the word
    Dim char6 As String                 'will hold the sixth letter of the word
    Dim gameStarted As Boolean = False  'will switch to True when the user clicks on play button
    Dim rightTrys As Integer            'will hold the number of right guessed letters
    Dim wrongTrys As Integer            'will hold the number of wrong guessed letters

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clearLetters()
        hideCharacterLength()
    End Sub

    Public Sub drawHanger()
        Dim pnt As Graphics
        pnt = Me.CreateGraphics
        Dim pencil As New Pen(Color.Black, 2)
        pnt.DrawLine(pencil, 46, 434, 115, 394)
        pnt.DrawLine(pencil, 115, 394, 184, 434)
        pnt.DrawLine(pencil, 115, 394, 115, 220)
        pnt.DrawLine(pencil, 115, 220, 250, 220)
        pnt.DrawLine(pencil, 250, 220, 250, 250)
    End Sub

    Public Sub resetGame()
        lblWrongGuesses.Text = ""
        Dim pnt As Graphics
        pnt = Me.CreateGraphics
        'pnt.Clear(Color.Grey)
        btnPlay.Visible = True

    End Sub

    Public Sub clearLetters()
        letter1.Text = ""
        letter2.Text = ""
        letter3.Text = ""
        letter4.Text = ""
        letter5.Text = ""
        letter6.Text = ""
    End Sub

    Public Sub checkForWinner()
        If rightTrys = wordLength Then
            MsgBox("You Won")
            resetGame()
        End If
    End Sub

    Public Sub StartDrawingWhenLosing(ByVal trys As Integer)
        Dim pnt As Graphics
        pnt = Me.CreateGraphics
        Dim pencil As New Pen(Color.Black, 2)
        If trys = 1 Then
            pnt.DrawEllipse(pencil, 228, 250, 40, 40)
        ElseIf trys = 2 Then
            pnt.DrawLine(pencil, 248, 290, 248, 370)
        ElseIf trys = 3 Then
            pnt.DrawLine(pencil, 248, 315, 213, 293)
        ElseIf trys = 4 Then
            pnt.DrawLine(pencil, 248, 315, 283, 293)
        ElseIf trys = 5 Then
            pnt.DrawLine(pencil, 248, 369, 213, 391)
        ElseIf trys = 6 Then
            pnt.DrawLine(pencil, 248, 369, 283, 391)
            TextBox1.Clear()
            Try
                letter1.Text = char1
                letter2.Text = char2
                letter3.Text = char3
                letter4.Text = char4
                letter5.Text = char5
                letter6.Text = char6
            Catch ex As Exception
            End Try
            MsgBox("You Lose")
            resetGame()
        End If
    End Sub

    Public Sub AssignLetters()
        If wordLength = 2 Then
            char1 = Word.Chars(0).ToString.ToUpper
            char2 = Word.Chars(1).ToString.ToUpper
        ElseIf wordLength = 3 Then
            char1 = Word.Chars(0).ToString.ToUpper
            char2 = Word.Chars(1).ToString.ToUpper
            char3 = Word.Chars(2).ToString.ToUpper
        ElseIf wordLength = 4 Then
            char1 = Word.Chars(0).ToString.ToUpper
            char2 = Word.Chars(1).ToString.ToUpper
            char3 = Word.Chars(2).ToString.ToUpper
            char4 = Word.Chars(3).ToString.ToUpper
        ElseIf wordLength = 5 Then
            char1 = Word.Chars(0).ToString.ToUpper
            char2 = Word.Chars(1).ToString.ToUpper
            char3 = Word.Chars(2).ToString.ToUpper
            char4 = Word.Chars(3).ToString.ToUpper
            char5 = Word.Chars(4).ToString.ToUpper
        ElseIf wordLength = 6 Then
            char1 = Word.Chars(0).ToString.ToUpper
            char2 = Word.Chars(1).ToString.ToUpper
            char3 = Word.Chars(2).ToString.ToUpper
            char4 = Word.Chars(3).ToString.ToUpper
            char5 = Word.Chars(4).ToString.ToUpper
            char6 = Word.Chars(5).ToString.ToUpper
        End If
    End Sub

    Public Sub hideCharacterLength()
        Line1.Visible = False
        Line2.Visible = False
        Line3.Visible = False
        Line4.Visible = False
        Line5.Visible = False
        Line6.Visible = False
    End Sub

    Public Sub ShowLength(ByVal VisibleLines As Integer)
        hideCharacterLength()
        If VisibleLines = 1 Then
            Line1.Visible = True
        ElseIf VisibleLines = 2 Then
            Line1.Visible = True
            Line2.Visible = True
        ElseIf VisibleLines = 3 Then
            Line1.Visible = True
            Line2.Visible = True
            Line3.Visible = True
        ElseIf VisibleLines = 4 Then
            Line1.Visible = True
            Line2.Visible = True
            Line3.Visible = True
            Line4.Visible = True
        ElseIf VisibleLines = 5 Then
            Line1.Visible = True
            Line2.Visible = True
            Line3.Visible = True
            Line4.Visible = True
            Line5.Visible = True
        ElseIf VisibleLines = 6 Then
            Line1.Visible = True
            Line2.Visible = True
            Line3.Visible = True
            Line4.Visible = True
            Line5.Visible = True
            Line6.Visible = True
        End If
    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        char1 = ""
        char2 = ""
        char3 = ""
        char4 = ""
        char5 = ""
        char6 = ""
        drawHanger()
        Dim number As Integer
        Randomize()
        number = Int(Rnd() * ListBox1.Items.Count - 1) + 1
        Word = ListBox1.Items(number)
        wordLength = Word.Length
        ShowLength(Word.Length)
        clearLetters()
        AssignLetters()
        TextBox1.Focus()
        rightTrys = 0
        wrongTrys = 0
        lblWrongGuesses.Text = "Wrong Guesses: "
        gameStarted = True
        btnPlay.Visible = False


    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If gameStarted = True Then
            If TextBox1.Text = "" Then
            Else
                If TextBox1.Text.ToUpper = char1 And letter1.Text = "" And char1 <> "" Then
                    letter1.Text = char1
                    rightTrys += 1
                    checkForWinner()
                ElseIf TextBox1.Text.ToUpper = char2 And letter2.Text = "" And char2 <> "" Then
                    letter2.Text = char2
                    rightTrys += 1
                    checkForWinner()
                ElseIf TextBox1.Text.ToUpper = char3 And letter3.Text = "" And char3 <> "" Then
                    letter3.Text = char3
                    rightTrys += 1
                    checkForWinner()
                ElseIf TextBox1.Text.ToUpper = char4 And letter4.Text = "" And char4 <> "" Then
                    letter4.Text = char4
                    rightTrys += 1
                    checkForWinner()
                ElseIf TextBox1.Text.ToUpper = char5 And letter5.Text = "" And char5 <> "" Then
                    letter5.Text = char5
                    rightTrys += 1
                    checkForWinner()
                ElseIf TextBox1.Text.ToUpper = char6 And letter6.Text = "" And char6 <> "" Then
                    letter6.Text = char6
                    rightTrys += 1
                    checkForWinner()
                Else
                    wrongTrys += 1
                    StartDrawingWhenLosing(wrongTrys)
                    lblWrongGuesses.Text = lblWrongGuesses.Text & " " & TextBox1.Text
                End If
            End If
        Else
        End If
        TextBox1.Text = ""


    End Sub
