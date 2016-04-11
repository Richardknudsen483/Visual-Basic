 'Boolean variables are stored as 16-bit (2-byte) numbers, but they can only be True or False.
    Dim currentPair As Boolean

    'Byte variables are stored as unsigned 8-bit (1-byte) numbers ranging in value from 0 through 255.
    Dim random, currentPlayer, firstPick, secondPick As Byte

    Private Sub resetBoard()

        lblScore1.Text = "0"
        lblScore2.Text = "0"
        random = 0
        firstPick = 0
        secondPick = 0
        currentPair = False
        pic1.Image = Nothing
        pic2.Image = Nothing
        pic3.Image = Nothing
        pic4.Image = Nothing
        pic5.Image = Nothing
        pic6.Image = Nothing
        pic7.Image = Nothing
        pic8.Image = Nothing
        pic9.Image = Nothing
        pic10.Image = Nothing
        pic11.Image = Nothing
        pic12.Image = Nothing
        pic1.Enabled = True
        pic2.Enabled = True
        pic3.Enabled = True
        pic4.Enabled = True
        pic5.Enabled = True
        pic6.Enabled = True
        pic7.Enabled = True
        pic8.Enabled = True
        pic9.Enabled = True
        pic10.Enabled = True
        pic11.Enabled = True
        pic12.Enabled = True

    End Sub

    Private Sub initialize()

        lblScore1.Text = "0"
        lblScore2.Text = "0"
        currentPair = False
        random = 0
        currentPlayer = 0
        firstPick = 0
        secondPick = 0

    End Sub

    Public Function checkForMatch()

        Dim one, two As Byte

        If firstPick = 1 Or firstPick = 3 Then
            one = 1
        End If

        If secondPick = 1 Or secondPick = 3 Then
            two = 1
        End If

        If firstPick = 2 Or firstPick = 4 Then
            one = 2
        End If

        If secondPick = 2 Or secondPick = 4 Then
            two = 2
        End If

        If firstPick = 5 Or firstPick = 12 Then
            one = 4
        End If

        If secondPick = 5 Or secondPick = 12 Then
            two = 4
        End If

        If firstPick = 6 Or firstPick = 11 Then
            one = 6
        End If

        If secondPick = 6 Or secondPick = 11 Then
            two = 6
        End If

        If firstPick = 7 Or firstPick = 10 Then
            one = 3
        End If

        If secondPick = 7 Or secondPick = 10 Then
            two = 3
        End If

        If firstPick = 8 Or firstPick = 9 Then
            one = 5
        End If

        If secondPick = 8 Or secondPick = 9 Then
            two = 5
        End If

        If one = two Then
            firstPick = 0
            secondPick = 0
            currentPair = False
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub clearPictures()

        Select Case firstPick
            Case 1
                pic1.Image = Nothing
                pic1.Enabled = True
            Case 2
                pic2.Image = Nothing
                pic2.Enabled = True
            Case 3
                pic3.Image = Nothing
                pic3.Enabled = True
            Case 4
                pic4.Image = Nothing
                pic4.Enabled = True
            Case 5
                pic5.Image = Nothing
                pic5.Enabled = True
            Case 6
                pic6.Image = Nothing
                pic6.Enabled = True
            Case 7
                pic7.Image = Nothing
                pic7.Enabled = True
            Case 8
                pic8.Image = Nothing
                pic8.Enabled = True
            Case 9
                pic9.Image = Nothing
                pic9.Enabled = True
            Case 10
                pic10.Image = Nothing
                pic10.Enabled = True
            Case 11
                pic11.Image = Nothing
                pic11.Enabled = True
            Case 12
                pic12.Image = Nothing
                pic12.Enabled = True
        End Select

        Select Case secondPick
            Case 1
                pic1.Image = Nothing
                pic1.Enabled = True
            Case 2
                pic2.Image = Nothing
                pic2.Enabled = True
            Case 3
                pic3.Image = Nothing
                pic3.Enabled = True
            Case 4
                pic4.Image = Nothing
                pic4.Enabled = True
            Case 5
                pic5.Image = Nothing
                pic5.Enabled = True
            Case 6
                pic6.Image = Nothing
                pic6.Enabled = True
            Case 6
                pic6.Image = Nothing
                pic6.Enabled = True
            Case 7
                pic7.Image = Nothing
                pic7.Enabled = True
            Case 8
                pic8.Image = Nothing
                pic8.Enabled = True
            Case 9
                pic9.Image = Nothing
                pic9.Enabled = True
            Case 10
                pic10.Image = Nothing
                pic10.Enabled = True
            Case 11
                pic11.Image = Nothing
                pic11.Enabled = True
            Case 12
                pic12.Image = Nothing
                pic12.Enabled = True
        End Select

        firstPick = 0
        secondPick = 0
        currentPair = False

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'On form load, declare all the variable values
        initialize()

    End Sub

    Private Sub btnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestart.Click
        'Reset the game
        resetBoard()

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 9. 
        random = CInt(Int((9 * Rnd()) + 1))

        If random < 4 Then
            MsgBox("Player 1 Goes First")
            currentPlayer = "1"
        Else
            MsgBox("Player 2 Goes First")
            currentPlayer = "2"
        End If
    End Sub

    Private Sub pic1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic1.Click

        pic1.Image = Image.FromFile("C:\Users\stu287483\Downloads\100gb.png")

        Select Case currentPlayer
            Case 1
                If currentPair = True Then
                    secondPick = 1
                    If checkForMatch() = True Then
                        lblScore1.Text += 1
                        pic1.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic1.Enabled = False
                    currentPair = True
                    firstPick = 1

                End If
            Case 2
                If currentPair = True Then
                    secondPick = 1
                    If checkForMatch() = True Then
                        lblScore2.Text += 1
                        pic1.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic1.Enabled = False
                    currentPair = True
                    firstPick = 1

                End If

        End Select

    End Sub

    Private Sub pic2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic2.Click

        pic2.Image = Image.FromFile("C:\Users\stu287483\Downloads\ATL.png")

        Select Case currentPlayer
            Case 1
                If currentPair = True Then
                    secondPick = 2
                    If checkForMatch() = True Then
                        lblScore1.Text += 1
                        pic2.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic2.Enabled = False
                    currentPair = True
                    firstPick = 2

                End If
            Case 2
                If currentPair = True Then
                    secondPick = 2
                    If checkForMatch() = True Then
                        lblScore2.Text += 1
                        pic2.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic2.Enabled = False
                    currentPair = True
                    firstPick = 2

                End If

        End Select
    End Sub

    Private Sub pic3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic3.Click

        pic3.Image = Image.FromFile("C:\Users\stu287483\Downloads\Broncoslogo.png")

        Select Case currentPlayer
            Case 1
                If currentPair = True Then
                    secondPick = 3
                    If checkForMatch() = True Then
                        lblScore1.Text += 1
                        pic3.Enabled = False
                        firstPick = 0
                        secondPick = 0
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic3.Enabled = False
                    currentPair = True
                    firstPick = 3

                End If
            Case 2
                If currentPair = True Then
                    secondPick = 3
                    If checkForMatch() = True Then
                        lblScore2.Text += 1
                        pic3.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic3.Enabled = False
                    currentPair = True
                    firstPick = 3

                End If

        End Select

    End Sub

    Private Sub pic4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic4.Click

        pic4.Image = Image.FromFile("C:\Users\stu287483\Downloads\BUF.png")

        Select Case currentPlayer
            Case 1
                If currentPair = True Then
                    secondPick = 4
                    If checkForMatch() = True Then
                        lblScore1.Text += 1
                        pic4.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic4.Enabled = False
                    currentPair = True
                    firstPick = 4

                End If
            Case 2
                If currentPair = True Then
                    secondPick = 4
                    If checkForMatch() = True Then
                        lblScore2.Text += 1
                        pic4.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic4.Enabled = False
                    currentPair = True
                    firstPick = 4

                End If

        End Select

    End Sub

    Private Sub pic5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic5.Click

        pic5.Image = Image.FromFile("C:\Users\stu287483\Downloads\CHI.png")

        Select Case currentPlayer
            Case 1
                If currentPair = True Then
                    secondPick = 5
                    If checkForMatch() = True Then
                        lblScore1.Text += 1
                        pic5.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic5.Enabled = False
                    currentPair = True
                    firstPick = 5

                End If
            Case 2
                If currentPair = True Then
                    secondPick = 5
                    If checkForMatch() = True Then
                        lblScore2.Text += 1
                        pic5.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic5.Enabled = False
                    currentPair = True
                    firstPick = 5

                End If

        End Select

    End Sub

    Private Sub pic6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic6.Click

        pic6.Image = Image.FromFile("C:\Users\stu287483\Downloads\CIN.png")

        Select Case currentPlayer
            Case 1
                If currentPair = True Then
                    secondPick = 6
                    If checkForMatch() = True Then
                        lblScore1.Text += 1
                        pic6.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic6.Enabled = False
                    currentPair = True
                    firstPick = 6

                End If
            Case 2
                If currentPair = True Then
                    secondPick = 6
                    If checkForMatch() = True Then
                        lblScore2.Text += 1
                        pic6.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic6.Enabled = False
                    currentPair = True
                    firstPick = 6

                End If

        End Select
    End Sub

    Private Sub pic7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic7.Click

        pic7.Image = Image.FromFile("C:\Users\stu287483\Downloads\100gb.png")

        Select Case currentPlayer
            Case 1
                If currentPair = True Then
                    secondPick = 7
                    If checkForMatch() = True Then
                        lblScore1.Text += 1
                        pic7.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic7.Enabled = False
                    currentPair = True
                    firstPick = 7

                End If
            Case 2
                If currentPair = True Then
                    secondPick = 7
                    If checkForMatch() = True Then
                        lblScore2.Text += 1
                        pic7.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic7.Enabled = False
                    currentPair = True
                    firstPick = 7

                End If

        End Select
    End Sub

    Private Sub pic8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic8.Click

        pic8.Image = Image.FromFile("C:\Users\stu287483\Downloads\ATL.png")

        Select Case currentPlayer
            Case 1
                If currentPair = True Then
                    secondPick = 8
                    If checkForMatch() = True Then
                        lblScore1.Text += 1
                        pic8.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic8.Enabled = False
                    currentPair = True
                    firstPick = 8

                End If
            Case 2
                If currentPair = True Then
                    secondPick = 8
                    If checkForMatch() = True Then
                        lblScore2.Text += 1
                        pic8.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic8.Enabled = False
                    currentPair = True
                    firstPick = 8

                End If

        End Select
    End Sub

    Private Sub pic9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic9.Click

        pic9.Image = Image.FromFile("C:\Users\stu287483\Downloads\Broncoslogo.png")

        Select Case currentPlayer
            Case 1
                If currentPair = True Then
                    secondPick = 9
                    If checkForMatch() = True Then
                        lblScore1.Text += 1
                        pic9.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic9.Enabled = False
                    currentPair = True
                    firstPick = 9

                End If
            Case 2
                If currentPair = True Then
                    secondPick = 9
                    If checkForMatch() = True Then
                        lblScore2.Text += 1
                        pic9.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic9.Enabled = False
                    currentPair = True
                    firstPick = 9

                End If

        End Select
    End Sub

    Private Sub pic10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic10.Click

        pic10.Image = Image.FromFile("C:\Users\stu287483\Downloads\BUF.png")

        Select Case currentPlayer
            Case 1
                If currentPair = True Then
                    secondPick = 10
                    If checkForMatch() = True Then
                        lblScore1.Text += 1
                        pic10.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic10.Enabled = False
                    currentPair = True
                    firstPick = 10

                End If
            Case 2
                If currentPair = True Then
                    secondPick = 10
                    If checkForMatch() = True Then
                        lblScore2.Text += 1
                        pic10.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic10.Enabled = False
                    currentPair = True
                    firstPick = 10

                End If

        End Select
    End Sub

    Private Sub pic11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic11.Click

        pic11.Image = Image.FromFile("C:\Users\stu287483\Downloads\CHI.png")

        Select Case currentPlayer
            Case 1
                If currentPair = True Then
                    secondPick = 11
                    If checkForMatch() = True Then
                        lblScore1.Text += 1
                        pic11.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic11.Enabled = False
                    currentPair = True
                    firstPick = 11

                End If
            Case 2
                If currentPair = True Then
                    secondPick = 11
                    If checkForMatch() = True Then
                        lblScore2.Text += 1
                        pic11.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic11.Enabled = False
                    currentPair = True
                    firstPick = 11

                End If

        End Select
    End Sub

    Private Sub pic12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic12.Click

        pic12.Image = Image.FromFile("C:\Users\stu287483\Downloads\CIN.png")

        Select Case currentPlayer
            Case 1
                If currentPair = True Then
                    secondPick = 12
                    If checkForMatch() = True Then
                        lblScore1.Text += 1
                        pic12.Enabled = False
                    Else
                        currentPlayer = 2
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic12.Enabled = False
                    currentPair = True
                    firstPick = 12

                End If
            Case 2
                If currentPair = True Then
                    secondPick = 12
                    If checkForMatch() = True Then
                        lblScore2.Text += 1
                        pic12.Enabled = False
                    Else
                        currentPlayer = 1
                        MsgBox("No Match, Player " & currentPlayer.ToString() & " 's turn")
                        clearPictures()
                    End If
                Else
                    pic12.Enabled = False
                    currentPair = True
                    firstPick = 12

                End If

        End Select
    End Sub
End Class
