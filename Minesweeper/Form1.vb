Public Class Form1
    Dim isFlagged(100) As Boolean
    Dim timesClicked(100) As Integer
    Dim modulator As Integer = 2
    Dim modResult As Integer
    Dim PictureBox(100) As PictureBox
    Dim isBomb(100) As Boolean
    Dim intBomb(100) As Integer
    Dim isNumber(100) As Boolean
    Dim bombsPlaced As Integer
    Dim canStart As Boolean
    Dim rnd As New Random
    Dim i(9) As Integer
    Dim picBox As String
    Dim bombCount As Integer = 0

    Sub RightClick(sender As Object, e As MouseEventArgs, pictureBox As PictureBox, timesClicked As Integer, isFlagged As Boolean, isNumber As Boolean)
        timesClicked = timesClicked + 1
        modResult = timesClicked Mod modulator

        If modResult = 1 Then
            isFlagged = True
        ElseIf modResult = 0 Then
            isFlagged = False
        End If

        If canStart = True Then
            If isNumber = False Then
                If e.Button = MouseButtons.Right And isFlagged = False Then
                    pictureBox.Image = My.Resources.flag_icon
                    isFlagged = True

                ElseIf e.Button = MouseButtons.Right And isFlagged = True Then
                    pictureBox.Image = Nothing
                    pictureBox.Refresh()
                    isFlagged = False
                End If
            End If
        End If
    End Sub

    Sub GenerateBomb()
        i(0) = rnd.Next(1, 101)
        System.Threading.Thread.Sleep(40)
        i(1) = rnd.Next(1, i(0))
        System.Threading.Thread.Sleep(40)
        i(2) = rnd.Next(i(1) + 1, 101)
        System.Threading.Thread.Sleep(40)
        i(3) = rnd.Next(1, i(2))
        System.Threading.Thread.Sleep(40)
        i(4) = rnd.Next(i(3) + 1, 101)
        System.Threading.Thread.Sleep(40)
        i(5) = rnd.Next(1, i(4))
        System.Threading.Thread.Sleep(40)
        i(6) = rnd.Next(i(5) + 1, 101)
        System.Threading.Thread.Sleep(40)
        i(7) = rnd.Next(1, i(6))
        System.Threading.Thread.Sleep(40)
        i(8) = rnd.Next(i(7) + 1, 101)
        System.Threading.Thread.Sleep(40)
        i(9) = rnd.Next(1, i(8))



        Label1.Text = i(0)
        Label2.Text = i(1)
        Label3.Text = i(2)
        Label4.Text = i(3)
        Label5.Text = i(4)
        Label10.Text = i(5)
        Label9.Text = i(6)
        Label8.Text = i(7)
        Label7.Text = i(8)
        Label6.Text = i(9)

        isBomb(i(0)) = True
        isBomb(i(1)) = True
        isBomb(i(2)) = True
        isBomb(i(3)) = True
        isBomb(i(4)) = True
        isBomb(i(5)) = True
        isBomb(i(6)) = True
        isBomb(i(7)) = True
        isBomb(i(8)) = True
        isBomb(i(9)) = True

        If isBomb(1) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(2) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(3) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(4) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(5) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(6) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(7) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(8) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(9) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(10) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(11) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(12) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(13) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(14) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(15) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(16) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(17) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(18) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(19) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(20) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(21) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(22) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(23) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(24) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(25) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(26) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(27) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(28) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(29) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(30) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(31) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(32) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(33) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(34) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(35) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(36) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(37) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(38) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(39) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(40) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(41) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(42) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(43) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(44) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(45) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(46) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(47) = True Then

            bombCount = bombCount + 1
        End If
        If isBomb(48) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(49) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(50) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(51) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(52) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(53) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(54) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(55) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(56) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(57) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(58) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(59) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(60) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(61) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(62) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(63) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(64) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(65) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(66) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(67) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(68) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(69) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(70) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(71) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(72) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(73) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(74) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(75) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(76) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(77) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(78) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(79) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(80) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(81) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(82) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(83) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(84) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(85) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(86) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(87) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(88) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(89) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(90) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(91) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(92) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(93) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(94) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(95) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(96) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(97) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(98) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(99) = True Then
            bombCount = bombCount + 1
        End If
        If isBomb(100) = True Then
            bombCount = bombCount + 1
        End If
        Label11.Text = bombCount
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit?", "Minesweeper", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        canStart = True
        GenerateBomb()
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(1) = timesClicked(1) + 1
        End If
        RightClick(sender, e, PictureBox1, timesClicked(1), isFlagged(1), isNumber(1))
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(2) = timesClicked(2) + 1
        End If
        RightClick(sender, e, PictureBox2, timesClicked(2), isFlagged(2), isNumber(2))
    End Sub

    Private Sub PictureBox3_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(3) = timesClicked(3) + 1
        End If
        RightClick(sender, e, PictureBox3, timesClicked(3), isFlagged(3), isNumber(3))
    End Sub

    Private Sub PictureBox4_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(4) = timesClicked(4) + 1
        End If
        RightClick(sender, e, PictureBox4, timesClicked(4), isFlagged(4), isNumber(4))
    End Sub

    Private Sub PictureBox5_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(5) = timesClicked(5) + 1
        End If
        RightClick(sender, e, PictureBox5, timesClicked(5), isFlagged(5), isNumber(5))
    End Sub

    Private Sub PictureBox6_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(6) = timesClicked(6) + 1
        End If
        RightClick(sender, e, PictureBox6, timesClicked(6), isFlagged(6), isNumber(6))
    End Sub
    Private Sub PictureBox7_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(7) = timesClicked(7) + 1
        End If
        RightClick(sender, e, PictureBox7, timesClicked(7), isFlagged(7), isNumber(7))
    End Sub

    Private Sub PictureBox8_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(8) = timesClicked(8) + 1
        End If
        RightClick(sender, e, PictureBox8, timesClicked(8), isFlagged(8), isNumber(8))
    End Sub

    Private Sub PictureBox9_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox9.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(9) = timesClicked(9) + 1
        End If
        RightClick(sender, e, PictureBox9, timesClicked(9), isFlagged(9), isNumber(9))
    End Sub

    Private Sub PictureBox10_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox10.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(10) = timesClicked(10) + 1
        End If
        RightClick(sender, e, PictureBox10, timesClicked(10), isFlagged(10), isNumber(10))
    End Sub

    Private Sub PictureBox11_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox11.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(11) = timesClicked(11) + 1
        End If
        RightClick(sender, e, PictureBox11, timesClicked(11), isFlagged(11), isNumber(11))
    End Sub

    Private Sub PictureBox12_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox12.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(12) = timesClicked(12) + 1
        End If
        RightClick(sender, e, PictureBox12, timesClicked(12), isFlagged(12), isNumber(12))
    End Sub

    Private Sub PictureBox13_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox13.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(13) = timesClicked(13) + 1
        End If
        RightClick(sender, e, PictureBox13, timesClicked(13), isFlagged(13), isNumber(13))
    End Sub

    Private Sub PictureBox14_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox14.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(14) = timesClicked(14) + 1
        End If
        RightClick(sender, e, PictureBox14, timesClicked(14), isFlagged(14), isNumber(14))
    End Sub

    Private Sub PictureBox15_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox15.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(15) = timesClicked(15) + 1
        End If
        RightClick(sender, e, PictureBox15, timesClicked(15), isFlagged(15), isNumber(15))
    End Sub

    Private Sub PictureBox16_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox16.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(16) = timesClicked(16) + 1
        End If
        RightClick(sender, e, PictureBox16, timesClicked(16), isFlagged(16), isNumber(16))
    End Sub

    Private Sub PictureBox17_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox17.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(17) = timesClicked(17) + 1
        End If
        RightClick(sender, e, PictureBox17, timesClicked(17), isFlagged(17), isNumber(17))
    End Sub

    Private Sub PictureBox18_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox18.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(18) = timesClicked(18) + 1
        End If
        RightClick(sender, e, PictureBox18, timesClicked(18), isFlagged(18), isNumber(18))
    End Sub

    Private Sub PictureBox19_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox19.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(19) = timesClicked(19) + 1
        End If
        RightClick(sender, e, PictureBox19, timesClicked(19), isFlagged(19), isNumber(19))
    End Sub

    Private Sub PictureBox20_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox20.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(20) = timesClicked(20) + 1
        End If
        RightClick(sender, e, PictureBox20, timesClicked(20), isFlagged(20), isNumber(20))
    End Sub
    Private Sub PictureBox21_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox21.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(21) = timesClicked(21) + 1
        End If
        RightClick(sender, e, PictureBox21, timesClicked(21), isFlagged(21), isNumber(21))
    End Sub
    Private Sub PictureBox22_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox22.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(22) = timesClicked(22) + 1
        End If
        RightClick(sender, e, PictureBox22, timesClicked(22), isFlagged(22), isNumber(22))
    End Sub
    Private Sub PictureBox23_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox23.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(23) = timesClicked(23) + 1
        End If
        RightClick(sender, e, PictureBox23, timesClicked(23), isFlagged(23), isNumber(23))
    End Sub
    Private Sub PictureBox24_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox24.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(24) = timesClicked(24) + 1
        End If
        RightClick(sender, e, PictureBox24, timesClicked(24), isFlagged(24), isNumber(24))
    End Sub
    Private Sub PictureBox25_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox25.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(25) = timesClicked(25) + 1
        End If
        RightClick(sender, e, PictureBox25, timesClicked(25), isFlagged(25), isNumber(25))
    End Sub
    Private Sub PictureBox26_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox26.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(26) = timesClicked(26) + 1
        End If
        RightClick(sender, e, PictureBox26, timesClicked(26), isFlagged(26), isNumber(26))
    End Sub
    Private Sub PictureBox27_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox27.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(27) = timesClicked(27) + 1
        End If
        RightClick(sender, e, PictureBox27, timesClicked(27), isFlagged(27), isNumber(27))
    End Sub
    Private Sub PictureBox28_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox28.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(28) = timesClicked(28) + 1
        End If
        RightClick(sender, e, PictureBox28, timesClicked(28), isFlagged(28), isNumber(28))
    End Sub
    Private Sub PictureBox29_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox29.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(29) = timesClicked(29) + 1
        End If
        RightClick(sender, e, PictureBox29, timesClicked(29), isFlagged(29), isNumber(29))
    End Sub
    Private Sub PictureBox30_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox30.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(30) = timesClicked(30) + 1
        End If
        RightClick(sender, e, PictureBox30, timesClicked(30), isFlagged(30), isNumber(30))
    End Sub
    Private Sub PictureBox31_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox31.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(31) = timesClicked(31) + 1
        End If
        RightClick(sender, e, PictureBox31, timesClicked(31), isFlagged(31), isNumber(31))
    End Sub
    Private Sub PictureBox32_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox32.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(32) = timesClicked(32) + 1
        End If
        RightClick(sender, e, PictureBox32, timesClicked(32), isFlagged(32), isNumber(32))
    End Sub
    Private Sub PictureBox33_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox33.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(33) = timesClicked(33) + 1
        End If
        RightClick(sender, e, PictureBox33, timesClicked(33), isFlagged(33), isNumber(33))
    End Sub
    Private Sub PictureBox34_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox34.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(34) = timesClicked(34) + 1
        End If
        RightClick(sender, e, PictureBox34, timesClicked(34), isFlagged(34), isNumber(34))
    End Sub
    Private Sub PictureBox35_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox35.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(35) = timesClicked(35) + 1
        End If
        RightClick(sender, e, PictureBox35, timesClicked(35), isFlagged(35), isNumber(35))
    End Sub
    Private Sub PictureBox36_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox36.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(36) = timesClicked(36) + 1
        End If
        RightClick(sender, e, PictureBox36, timesClicked(36), isFlagged(36), isNumber(36))
    End Sub
    Private Sub PictureBox37_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox37.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(37) = timesClicked(37) + 1
        End If
        RightClick(sender, e, PictureBox37, timesClicked(37), isFlagged(37), isNumber(37))
    End Sub
    Private Sub PictureBox38_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox38.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(38) = timesClicked(38) + 1
        End If
        RightClick(sender, e, PictureBox38, timesClicked(38), isFlagged(38), isNumber(38))
    End Sub
    Private Sub PictureBox39_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox39.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(39) = timesClicked(39) + 1
        End If
        RightClick(sender, e, PictureBox39, timesClicked(39), isFlagged(39), isNumber(39))
    End Sub
    Private Sub PictureBox40_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox40.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(40) = timesClicked(40) + 1
        End If
        RightClick(sender, e, PictureBox40, timesClicked(40), isFlagged(40), isNumber(40))
    End Sub
    Private Sub PictureBox41_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox41.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(41) = timesClicked(41) + 1
        End If
        RightClick(sender, e, PictureBox41, timesClicked(41), isFlagged(41), isNumber(41))
    End Sub
    Private Sub PictureBox42_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox42.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(42) = timesClicked(42) + 1
        End If
        RightClick(sender, e, PictureBox42, timesClicked(42), isFlagged(42), isNumber(42))
    End Sub
    Private Sub PictureBox43_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox43.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(43) = timesClicked(43) + 1
        End If
        RightClick(sender, e, PictureBox43, timesClicked(43), isFlagged(43), isNumber(43))
    End Sub
    Private Sub PictureBox44_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox44.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(44) = timesClicked(44) + 1
        End If
        RightClick(sender, e, PictureBox44, timesClicked(44), isFlagged(44), isNumber(44))
    End Sub
    Private Sub PictureBox45_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox45.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(45) = timesClicked(45) + 1
        End If
        RightClick(sender, e, PictureBox45, timesClicked(45), isFlagged(45), isNumber(45))
    End Sub
    Private Sub PictureBox46_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox46.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(46) = timesClicked(46) + 1
        End If
        RightClick(sender, e, PictureBox46, timesClicked(46), isFlagged(46), isNumber(46))
    End Sub
    Private Sub PictureBox47_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox47.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(47) = timesClicked(47) + 1
        End If
        RightClick(sender, e, PictureBox47, timesClicked(47), isFlagged(47), isNumber(47))
    End Sub
    Private Sub PictureBox48_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox48.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(48) = timesClicked(48) + 1
        End If
        RightClick(sender, e, PictureBox48, timesClicked(48), isFlagged(48), isNumber(48))
    End Sub
    Private Sub PictureBox49_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox49.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(49) = timesClicked(49) + 1
        End If
        RightClick(sender, e, PictureBox49, timesClicked(49), isFlagged(49), isNumber(49))
    End Sub
    Private Sub PictureBox50_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox50.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(50) = timesClicked(50) + 1
        End If
        RightClick(sender, e, PictureBox50, timesClicked(50), isFlagged(50), isNumber(50))
    End Sub
    Private Sub PictureBox51_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox51.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(51) = timesClicked(51) + 1
        End If
        RightClick(sender, e, PictureBox51, timesClicked(51), isFlagged(51), isNumber(51))
    End Sub
    Private Sub PictureBox52_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox52.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(52) = timesClicked(52) + 1
        End If
        RightClick(sender, e, PictureBox52, timesClicked(52), isFlagged(52), isNumber(52))
    End Sub
    Private Sub PictureBox53_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox53.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(53) = timesClicked(53) + 1
        End If
        RightClick(sender, e, PictureBox53, timesClicked(53), isFlagged(53), isNumber(53))
    End Sub
    Private Sub PictureBox54_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox54.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(54) = timesClicked(54) + 1
        End If
        RightClick(sender, e, PictureBox54, timesClicked(54), isFlagged(54), isNumber(54))
    End Sub
    Private Sub PictureBox55_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox55.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(55) = timesClicked(55) + 1
        End If
        RightClick(sender, e, PictureBox55, timesClicked(55), isFlagged(55), isNumber(55))
    End Sub
    Private Sub PictureBox56_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox56.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(56) = timesClicked(56) + 1
        End If
        RightClick(sender, e, PictureBox56, timesClicked(56), isFlagged(56), isNumber(56))
    End Sub
    Private Sub PictureBox57_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox57.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(57) = timesClicked(57) + 1
        End If
        RightClick(sender, e, PictureBox57, timesClicked(57), isFlagged(57), isNumber(57))
    End Sub
    Private Sub PictureBox58_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox58.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(58) = timesClicked(58) + 1
        End If
        RightClick(sender, e, PictureBox58, timesClicked(58), isFlagged(58), isNumber(58))
    End Sub
    Private Sub PictureBox59_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox59.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(59) = timesClicked(59) + 1
        End If
        RightClick(sender, e, PictureBox59, timesClicked(59), isFlagged(59), isNumber(59))
    End Sub
    Private Sub PictureBox60_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox60.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(60) = timesClicked(60) + 1
        End If
        RightClick(sender, e, PictureBox60, timesClicked(60), isFlagged(60), isNumber(60))
    End Sub
    Private Sub PictureBox61_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox61.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(61) = timesClicked(61) + 1
        End If
        RightClick(sender, e, PictureBox61, timesClicked(61), isFlagged(61), isNumber(61))
    End Sub
    Private Sub PictureBox62_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox62.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(62) = timesClicked(62) + 1
        End If
        RightClick(sender, e, PictureBox62, timesClicked(62), isFlagged(62), isNumber(62))
    End Sub
    Private Sub PictureBox63_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox63.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(63) = timesClicked(63) + 1
        End If
        RightClick(sender, e, PictureBox63, timesClicked(63), isFlagged(63), isNumber(63))
    End Sub
    Private Sub PictureBox64_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox64.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(64) = timesClicked(64) + 1
        End If
        RightClick(sender, e, PictureBox64, timesClicked(64), isFlagged(64), isNumber(64))
    End Sub
    Private Sub PictureBox65_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox65.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(65) = timesClicked(65) + 1
        End If
        RightClick(sender, e, PictureBox65, timesClicked(65), isFlagged(65), isNumber(65))
    End Sub
    Private Sub PictureBox66_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox66.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(66) = timesClicked(66) + 1
        End If
        RightClick(sender, e, PictureBox66, timesClicked(66), isFlagged(66), isNumber(66))
    End Sub
    Private Sub PictureBox67_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox67.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(67) = timesClicked(67) + 1
        End If
        RightClick(sender, e, PictureBox67, timesClicked(67), isFlagged(67), isNumber(67))
    End Sub
    Private Sub PictureBox68_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox68.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(68) = timesClicked(68) + 1
        End If
        RightClick(sender, e, PictureBox68, timesClicked(68), isFlagged(68), isNumber(68))
    End Sub
    Private Sub PictureBox69_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox69.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(69) = timesClicked(69) + 1
        End If
        RightClick(sender, e, PictureBox69, timesClicked(69), isFlagged(69), isNumber(69))
    End Sub
    Private Sub PictureBox70_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox70.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(70) = timesClicked(70) + 1
        End If
        RightClick(sender, e, PictureBox70, timesClicked(70), isFlagged(70), isNumber(70))
    End Sub
    Private Sub PictureBox71_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox71.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(71) = timesClicked(71) + 1
        End If
        RightClick(sender, e, PictureBox71, timesClicked(71), isFlagged(71), isNumber(71))
    End Sub
    Private Sub PictureBox72_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox72.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(72) = timesClicked(72) + 1
        End If
        RightClick(sender, e, PictureBox72, timesClicked(72), isFlagged(72), isNumber(72))
    End Sub
    Private Sub PictureBox73_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox73.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(73) = timesClicked(73) + 1
        End If
        RightClick(sender, e, PictureBox73, timesClicked(73), isFlagged(73), isNumber(73))
    End Sub
    Private Sub PictureBox74_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox74.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(74) = timesClicked(74) + 1
        End If
        RightClick(sender, e, PictureBox74, timesClicked(74), isFlagged(74), isNumber(74))
    End Sub
    Private Sub PictureBox75_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox75.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(75) = timesClicked(75) + 1
        End If
        RightClick(sender, e, PictureBox75, timesClicked(75), isFlagged(75), isNumber(75))
    End Sub
    Private Sub PictureBox76_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox76.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(76) = timesClicked(76) + 1
        End If
        RightClick(sender, e, PictureBox76, timesClicked(76), isFlagged(76), isNumber(76))
    End Sub
    Private Sub PictureBox77_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox77.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(77) = timesClicked(77) + 1
        End If
        RightClick(sender, e, PictureBox77, timesClicked(77), isFlagged(77), isNumber(77))
    End Sub
    Private Sub PictureBox78_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox78.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(78) = timesClicked(78) + 1
        End If
        RightClick(sender, e, PictureBox78, timesClicked(78), isFlagged(78), isNumber(78))
    End Sub
    Private Sub PictureBox79_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox79.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(79) = timesClicked(79) + 1
        End If
        RightClick(sender, e, PictureBox79, timesClicked(79), isFlagged(79), isNumber(79))
    End Sub
    Private Sub PictureBox80_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox80.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(80) = timesClicked(80) + 1
        End If
        RightClick(sender, e, PictureBox80, timesClicked(80), isFlagged(80), isNumber(80))
    End Sub
    Private Sub PictureBox81_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox81.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(81) = timesClicked(81) + 1
        End If
        RightClick(sender, e, PictureBox81, timesClicked(81), isFlagged(81), isNumber(81))
    End Sub
    Private Sub PictureBox82_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox82.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(82) = timesClicked(82) + 1
        End If
        RightClick(sender, e, PictureBox82, timesClicked(82), isFlagged(82), isNumber(82))
    End Sub
    Private Sub PictureBox83_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox83.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(83) = timesClicked(83) + 1
        End If
        RightClick(sender, e, PictureBox83, timesClicked(83), isFlagged(83), isNumber(83))
    End Sub
    Private Sub PictureBox84_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox84.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(84) = timesClicked(84) + 1
        End If
        RightClick(sender, e, PictureBox84, timesClicked(84), isFlagged(84), isNumber(84))
    End Sub
    Private Sub PictureBox85_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox85.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(85) = timesClicked(85) + 1
        End If
        RightClick(sender, e, PictureBox85, timesClicked(85), isFlagged(85), isNumber(85))
    End Sub
    Private Sub PictureBox86_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox86.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(86) = timesClicked(86) + 1
        End If
        RightClick(sender, e, PictureBox86, timesClicked(86), isFlagged(86), isNumber(86))
    End Sub
    Private Sub PictureBox87_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox87.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(87) = timesClicked(87) + 1
        End If
        RightClick(sender, e, PictureBox87, timesClicked(87), isFlagged(87), isNumber(87))
    End Sub
    Private Sub PictureBox88_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox88.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(88) = timesClicked(88) + 1
        End If
        RightClick(sender, e, PictureBox88, timesClicked(88), isFlagged(88), isNumber(88))
    End Sub
    Private Sub PictureBox89_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox89.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(89) = timesClicked(89) + 1
        End If
        RightClick(sender, e, PictureBox89, timesClicked(89), isFlagged(89), isNumber(89))
    End Sub
    Private Sub PictureBox90_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox90.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(90) = timesClicked(90) + 1
        End If
        RightClick(sender, e, PictureBox90, timesClicked(90), isFlagged(90), isNumber(90))
    End Sub
    Private Sub PictureBox91_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox91.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(91) = timesClicked(91) + 1
        End If
        RightClick(sender, e, PictureBox91, timesClicked(91), isFlagged(91), isNumber(91))
    End Sub
    Private Sub PictureBox92_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox92.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(92) = timesClicked(92) + 1
        End If
        RightClick(sender, e, PictureBox92, timesClicked(92), isFlagged(92), isNumber(92))
    End Sub
    Private Sub PictureBox93_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox93.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(93) = timesClicked(93) + 1
        End If
        RightClick(sender, e, PictureBox93, timesClicked(93), isFlagged(93), isNumber(93))
    End Sub
    Private Sub PictureBox94_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox94.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(94) = timesClicked(94) + 1
        End If
        RightClick(sender, e, PictureBox94, timesClicked(94), isFlagged(94), isNumber(94))
    End Sub
    Private Sub PictureBox95_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox95.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(95) = timesClicked(95) + 1
        End If
        RightClick(sender, e, PictureBox95, timesClicked(95), isFlagged(95), isNumber(95))
    End Sub
    Private Sub PictureBox96_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox96.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(96) = timesClicked(96) + 1
        End If
        RightClick(sender, e, PictureBox96, timesClicked(96), isFlagged(96), isNumber(96))
    End Sub
    Private Sub PictureBox97_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox97.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(97) = timesClicked(97) + 1
        End If
        RightClick(sender, e, PictureBox97, timesClicked(97), isFlagged(97), isNumber(97))
    End Sub
    Private Sub PictureBox98_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox98.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(98) = timesClicked(98) + 1
        End If
        RightClick(sender, e, PictureBox98, timesClicked(98), isFlagged(98), isNumber(98))
    End Sub
    Private Sub PictureBox99_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox99.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(99) = timesClicked(99) + 1
        End If
        RightClick(sender, e, PictureBox99, timesClicked(99), isFlagged(99), isNumber(99))
    End Sub
    Private Sub PictureBox100_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox100.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(100) = timesClicked(100) + 1
        End If
        RightClick(sender, e, PictureBox100, timesClicked(100), isFlagged(100), isNumber(100))
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Application.Restart()
        Me.Refresh()
    End Sub
End Class