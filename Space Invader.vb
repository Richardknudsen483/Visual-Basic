#Region "variables"

    Dim controlLeft As Boolean
    Dim controlRight As Boolean
    Dim fire As Boolean
    Dim fire1 As Boolean
    Dim fire2 As Boolean
    Dim fire3 As Boolean
    Dim fire4 As Boolean
    Dim fire5 As Boolean

    Dim spaceInvader(11) As PictureBox
    Dim locations(11) As System.Drawing.Point
    Dim invaderShot(11) As Boolean
    Dim invaderShotLabel(11) As Label

    Dim moveSpaceInvader As Integer = 5
    Dim moveShip As Integer = 20
    Dim shotSpeed As Integer = 15
    Dim invaderShotSpeed As Integer = 5
    Dim whichInvader As Integer
    Dim complete As Integer
    Dim level As Integer = 1
    Dim score As Integer
    Dim ran As Integer

    Dim score1 As Integer = 10
    Dim score2 As Integer = 15
    Dim score3 As Integer = 24
    Dim score4 As Integer = 13
    Dim score5 As Integer = 5
    Dim name1 As String = "Bones"
    Dim name2 As String = "EL"
    Dim name3 As String = "Xay"
    Dim name4 As String = "Eddy"
    Dim name5 As String = "Chris"

#End Region

#Region "buttons"

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        lblGameTitle.Hide()
        btnStart.Hide()
        btnQuit.Hide()
        picDrone.Hide()
        picShip.Hide()
        gamePanel.Show()
        moveComp.Enabled = True
        moveComp.Start()
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

#End Region

#Region "timers"

    Private Sub moveComp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles moveComp.Tick
        If controlLeft = True Then
            spaceShip.Left = spaceShip.Left - moveShip
            resetShot.Left = resetShot.Left - moveShip

            If fire1 = False Then
                shot1.Left = shot1.Left - moveShip
            End If

            If fire2 = False Then
                shot2.Left = shot2.Left - moveShip
            End If

            If fire3 = False Then
                shot3.Left = shot3.Left - moveShip
            End If

            If fire4 = False Then
                shot4.Left = shot4.Left - moveShip
            End If

            If fire5 = False Then
                shot5.Left = shot5.Left - moveShip
            End If

            If spaceShip.Left < 0 Then
                spaceShip.Left = spaceShip.Left + moveShip
                resetShot.Left = resetShot.Left + moveShip
                If fire1 = False Then
                    shot1.Left = shot1.Left + moveShip
                End If

                If fire2 = False Then
                    shot2.Left = shot2.Left + moveShip
                End If

                If fire3 = False Then
                    shot3.Left = shot3.Left + moveShip
                End If

                If fire4 = False Then
                    shot4.Left = shot4.Left + moveShip
                End If

                If fire5 = False Then
                    shot5.Left = shot5.Left + moveShip
                End If

            End If
        End If

        If controlRight = True Then
            spaceShip.Left = spaceShip.Left + moveShip
            resetShot.Left = resetShot.Left + moveShip

            If fire1 = False Then
                shot1.Left = shot1.Left + moveShip
            End If

            If fire2 = False Then
                shot2.Left = shot2.Left + moveShip
            End If

            If fire3 = False Then
                shot3.Left = shot3.Left + moveShip
            End If

            If fire4 = False Then
                shot4.Left = shot4.Left + moveShip
            End If

            If fire5 = False Then
                shot5.Left = shot5.Left + moveShip
            End If

            If spaceShip.Left > Me.Width - spaceShip.Width Then
                spaceShip.Left = spaceShip.Left - moveShip
                resetShot.Left = resetShot.Left - moveShip

                If fire1 = False Then
                    shot1.Left = shot1.Left - moveShip
                End If

                If fire2 = False Then
                    shot2.Left = shot2.Left - moveShip
                End If

                If fire3 = False Then
                    shot3.Left = shot3.Left - moveShip
                End If

                If fire4 = False Then
                    shot4.Left = shot4.Left - moveShip
                End If

                If fire5 = False Then
                    shot5.Left = shot5.Left - moveShip
                End If
            End If
        End If


        moveInvader()
        If fire = True Then
            checkShot()
        End If
        moveShot()
        moveInvaderShots()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        sbPanel.Show()

    End Sub

#End Region

#Region "keyPresses"

    Private Sub moveCompLeft(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Left Then
            controlLeft = True
        End If

        If e.KeyValue = Keys.Right Then
            controlRight = True
        End If

        If e.KeyValue = Keys.A Then
            fire = True
        End If
    End Sub

    Private Sub moveCompStop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Left Then
            controlLeft = False
        End If

        If e.KeyValue = Keys.Right Then
            controlRight = False
        End If

        If e.KeyValue = Keys.A Then
            fire = False
        End If
    End Sub

#End Region

#Region "mySubs"

    Private Sub createInvaderArray()

        Dim i As Integer

        spaceInvader(0) = invader1
        spaceInvader(1) = invader2
        spaceInvader(2) = invader3
        spaceInvader(3) = invader4
        spaceInvader(4) = invader5
        spaceInvader(5) = invader6
        spaceInvader(6) = invader7
        spaceInvader(7) = invader8
        spaceInvader(8) = invader9
        spaceInvader(9) = invader10
        spaceInvader(10) = invader11
        spaceInvader(11) = invader12

        For i = 0 To 11
            locations(i) = spaceInvader(i).Location
        Next

    End Sub

    Private Sub createInvaderShotArray()

        invaderShotLabel(0) = invaderShot1
        invaderShotLabel(1) = invaderShot2
        invaderShotLabel(2) = invaderShot3
        invaderShotLabel(3) = invaderShot4
        invaderShotLabel(4) = invaderShot5
        invaderShotLabel(5) = invaderShot6
        invaderShotLabel(6) = invaderShot7
        invaderShotLabel(7) = invaderShot8
        invaderShotLabel(8) = invaderShot9
        invaderShotLabel(9) = invaderShot10
        invaderShotLabel(10) = invaderShot11
        invaderShotLabel(11) = invaderShot12

    End Sub

    Private Sub moveInvader()
        Dim i As Integer
        For i = 0 To 11
            spaceInvader(i).Left = spaceInvader(i).Left + moveSpaceInvader
            If invaderShot(i) = False Then
                invaderShotLabel(i).Left = invaderShotLabel(i).Left + moveSpaceInvader
            End If
            If spaceInvader(i).Bounds.IntersectsWith(spaceShip.Bounds) Then
                playerDead()
            End If
        Next

        If invader6.Left > Me.Width - invader6.Width Then
            moveSpaceInvader = moveSpaceInvader * -1
            For i = 0 To 11
                spaceInvader(i).Top = spaceInvader(i).Top + 25
                If invaderShot(i) = False Then
                    invaderShotLabel(i).Top = invaderShotLabel(i).Top + 25
                End If
            Next
        End If

        If invader1.Left < 0 Then
            moveSpaceInvader = moveSpaceInvader * -1
            For i = 0 To 11
                spaceInvader(i).Top = spaceInvader(i).Top + 25
                If invaderShot(i) = False Then
                    invaderShotLabel(i).Top = invaderShotLabel(i).Top + 25
                End If
            Next
        End If
    End Sub

    Private Sub checkShot()

        fire = False

        If fire1 = False Then
            fire1 = True
            shot1.Show()
            Exit Sub
        End If
        If fire2 = False Then
            fire2 = True
            shot2.Show()
            Exit Sub
        End If
        If fire3 = False Then
            fire3 = True
            shot3.Show()
            Exit Sub
        End If
        If fire4 = False Then
            fire4 = True
            shot4.Show()
            Exit Sub
        End If
        If fire5 = False Then
            fire5 = True
            shot5.Show()
            Exit Sub
        End If
    End Sub

    Private Sub moveShot()

        Dim i As Integer

        If fire1 = True Then
            shot1.Top = shot1.Top - shotSpeed
            For i = 0 To 11
                If shot1.Bounds.IntersectsWith(spaceInvader(i).Bounds) Then
                    whichInvader = i
                    shot1Hit()
                End If
            Next
            If shot1.Top < 0 Then
                shot1.Hide()
                fire1 = False
                shot1.Location = resetShot.Location
            End If
        End If

        If fire2 = True Then
            shot2.Top = shot2.Top - shotSpeed
            For i = 0 To 11
                If shot2.Bounds.IntersectsWith(spaceInvader(i).Bounds) Then
                    whichInvader = i
                    shot2Hit()
                End If
            Next
            If shot2.Top < 0 Then
                shot2.Hide()
                fire2 = False
                shot2.Location = resetShot.Location
            End If
        End If

        If fire3 = True Then
            shot3.Top = shot3.Top - shotSpeed
            For i = 0 To 11
                If shot3.Bounds.IntersectsWith(spaceInvader(i).Bounds) Then
                    whichInvader = i
                    shot3Hit()
                End If
            Next
            If shot3.Top < 0 Then
                shot3.Hide()
                fire3 = False
                shot3.Location = resetShot.Location
            End If
        End If

        If fire4 = True Then
            shot4.Top = shot4.Top - shotSpeed
            For i = 0 To 11
                If shot4.Bounds.IntersectsWith(spaceInvader(i).Bounds) Then
                    whichInvader = i
                    shot4Hit()
                End If
            Next
            If shot4.Top < 0 Then
                shot4.Hide()
                fire4 = False
                shot4.Location = resetShot.Location
            End If
        End If

        If fire5 = True Then
            shot5.Top = shot5.Top - shotSpeed
            For i = 0 To 11
                If shot5.Bounds.IntersectsWith(spaceInvader(i).Bounds) Then
                    whichInvader = i
                    shot5Hit()
                End If
            Next
            If shot5.Top < 0 Then
                shot5.Hide()
                fire5 = False
                shot5.Location = resetShot.Location
            End If
        End If

    End Sub

    Private Sub shot1Hit()
        fire1 = False
        shot1.Hide()
        shot1.Location = resetShot.Location
        spaceInvader(whichInvader).Top = spaceInvader(whichInvader).Top + 10000
        complete += 1
        If complete = 12 Then
            levelComplete()
        End If
        score = score + 1
        lblScore.Text = "Score: " & score
    End Sub

    Private Sub shot2Hit()
        fire2 = False
        shot2.Hide()
        shot2.Location = resetShot.Location
        spaceInvader(whichInvader).Top = spaceInvader(whichInvader).Top + 10000
        complete += 1
        If complete = 12 Then
            levelComplete()
        End If
        score = score + 1
        lblScore.Text = "Score: " & score
    End Sub

    Private Sub shot3Hit()
        fire3 = False
        shot3.Hide()
        shot3.Location = resetShot.Location
        spaceInvader(whichInvader).Top = spaceInvader(whichInvader).Top + 10000
        complete += 1
        If complete = 12 Then
            levelComplete()
        End If
        score = score + 1
        lblScore.Text = "Score: " & score
    End Sub

    Private Sub shot4Hit()
        fire4 = False
        shot4.Hide()
        shot4.Location = resetShot.Location
        spaceInvader(whichInvader).Top = spaceInvader(whichInvader).Top + 10000
        complete += 1
        If complete = 12 Then
            levelComplete()
        End If
        score = score + 1
        lblScore.Text = "Score: " & score
    End Sub

    Private Sub shot5Hit()
        fire5 = False
        shot5.Hide()
        shot5.Location = resetShot.Location
        spaceInvader(whichInvader).Top = spaceInvader(whichInvader).Top + 10000
        complete += 1
        If complete = 12 Then
            levelComplete()
        End If
        score = score + 1
        lblScore.Text = "Score: " & score
    End Sub

    Private Sub playerDead()

        moveComp.Stop()
        spaceShip.Image = Image.FromFile("fireball_001_71x100.gif")
        messageBox.Show()
        Timer1.Enabled = True
        Timer1.Start()

    End Sub

    Private Sub levelComplete()

        Dim i As Integer
        level = level + 1
        lblLevel.Text = "LEVEL " & level

        For i = 0 To 11
            spaceInvader(i).Location = locations(i)
        Next

        complete = 0
        shot1.Location = resetShot.Location
        shot2.Location = resetShot.Location
        shot3.Location = resetShot.Location
        shot4.Location = resetShot.Location
        shot5.Location = resetShot.Location

        If level > 1 Then
            moveSpaceInvader = 10
            moveShip = 15
        End If
        If level > 5 Then
            moveSpaceInvader = 15
            invaderShotSpeed = 10
        End If

    End Sub

    Private Sub moveInvaderShots()
        Dim i As Integer

        For i = 0 To 11
            If invaderShot(i) = False Then
                ran = CInt(Int((100 * Rnd()) + 1))
                If ran = 100 Then
                    invaderShot(i) = True
                    invaderShotLabel(i).Show()
                    If spaceInvader(i).Top > 1000 Then
                        invaderShot(i) = False
                        invaderShotLabel(i).Hide()
                    End If
                End If
            End If
        Next
        For i = 0 To 11
            If invaderShot(i) = True Then
                invaderShotLabel(i).Top = invaderShotLabel(i).Top + invaderShotSpeed
                If invaderShotLabel(i).Bounds.IntersectsWith(spaceShip.Bounds) Then
                    playerDead()
                End If
                If invaderShotLabel(i).Top > Me.Height Then
                    invaderShot(i) = False
                    invaderShotLabel(i).Hide()
                    invaderShotLabel(i).Location = spaceInvader(i).Location
                    invaderShotLabel(i).Top = invaderShotLabel(i).Top + 32
                    invaderShotLabel(i).Left = invaderShotLabel(i).Left + 32
                End If
            End If
        Next
    End Sub

    Private Sub scoreBoard()
        If score > score1 Then
            score5 = score4
            score4 = score3
            score3 = score2
            score2 = score1
            score1 = score
            name5 = name4
            name4 = name3
            name3 = name2
            name2 = name1
            name1 = txtName.Text
            lblName1.Text = name1
            lblName2.Text = name2
            lblName3.Text = name3
            lblName4.Text = name4
            lblName5.Text = name5
            lblScore1.Text = score1
            lblScore2.Text = score2
            lblScore3.Text = score3
            lblScore4.Text = score4
            lblScore5.Text = score5
        End If

        If score > score2 Then
            score5 = score4
            score4 = score3
            score3 = score2
            score2 = score
            name5 = name4
            name4 = name3
            name3 = name2
            name2 = txtName.Text
            lblName2.Text = name2
            lblName3.Text = name3
            lblName4.Text = name4
            lblName5.Text = name5
            lblScore2.Text = score2
            lblScore3.Text = score3
            lblScore4.Text = score4
            lblScore5.Text = score5
        End If

        If score > score3 Then
            score5 = score4
            score4 = score3
            score3 = score
            name5 = name4
            name4 = name3
            name3 = txtName.Text
            lblName3.Text = name3
            lblName4.Text = name4
            lblName5.Text = name5
            lblScore3.Text = score3
            lblScore4.Text = score4
            lblScore5.Text = score5
        End If

        If score > score4 Then
            score5 = score4
            score4 = score
            name5 = name4
            name4 = txtName.Text
            lblName4.Text = name4
            lblName5.Text = name5
            lblScore4.Text = score4
            lblScore5.Text = score5
        End If

        If score > score5 Then
            score5 = score
            name5 = txtName.Text
            lblName5.Text = name5
            lblScore5.Text = score5
        End If
    End Sub

#End Region

#Region "text boxes"

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown
        If e.KeyValue = Keys.Enter Then
            scoreBoard()
            lblName1.Show()
            lblName2.Show()
            lblName3.Show()
            lblName4.Show()
            lblName5.Show()
            lblScore1.Show()
            lblScore2.Show()
            lblScore3.Show()
            lblScore4.Show()
            lblScore5.Show()

        End If
    End Sub

#End Region

End Class
