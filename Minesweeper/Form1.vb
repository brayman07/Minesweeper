Public Class Form1
    Dim isFlagged(100) As Boolean
    Dim timesClicked(100) As Integer
    Dim modulator As Integer = 2
    Dim modResult As Integer
    Sub RightClick(sender As Object, e As MouseEventArgs, pictureBox As PictureBox, timesClicked As Integer, isFlagged As Boolean)
        timesClicked = timesClicked + 1
        modResult = timesClicked Mod modulator

        If modResult = 1 Then
            isFlagged = True
        ElseIf modResult = 0 Then
            isFlagged = False
        End If
        If e.Button = MouseButtons.Right And isFlagged = False Then
            pictureBox.Image = My.Resources.flag_icon
            isFlagged = True

        ElseIf e.Button = MouseButtons.Right And isFlagged = True Then
            pictureBox.Image = Nothing
            pictureBox.Refresh()
            isFlagged = False
        End If

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Are you sure you want to exit?", "Minesweeper", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(0) = timesClicked(0) + 1
        End If
        RightClick(sender, e, PictureBox1, timesClicked(0), isFlagged(0))
    End Sub

    Private Sub PictureBox2_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(1) = timesClicked(1) + 1
        End If
        RightClick(sender, e, PictureBox2, timesClicked(1), isFlagged(1))
    End Sub

    Private Sub PictureBox3_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(2) = timesClicked(2) + 1
        End If
        RightClick(sender, e, PictureBox3, timesClicked(2), isFlagged(2))
    End Sub

    Private Sub PictureBox4_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(3) = timesClicked(3) + 1
        End If
        RightClick(sender, e, PictureBox4, timesClicked(3), isFlagged(3))
    End Sub

    Private Sub PictureBox5_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(4) = timesClicked(4) + 1
        End If
        RightClick(sender, e, PictureBox5, timesClicked(4), isFlagged(4))
    End Sub

    Private Sub PictureBox6_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(5) = timesClicked(5) + 1
        End If
        RightClick(sender, e, PictureBox6, timesClicked(5), isFlagged(5))
    End Sub
    Private Sub PictureBox7_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(6) = timesClicked(6) + 1
        End If
        RightClick(sender, e, PictureBox7, timesClicked(6), isFlagged(6))
    End Sub

    Private Sub PictureBox8_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(7) = timesClicked(7) + 1
        End If
        RightClick(sender, e, PictureBox8, timesClicked(7), isFlagged(7))
    End Sub

    Private Sub PictureBox9_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox9.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(8) = timesClicked(8) + 1
        End If
        RightClick(sender, e, PictureBox9, timesClicked(8), isFlagged(8))
    End Sub

    Private Sub PictureBox10_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox10.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(9) = timesClicked(9) + 1
        End If
        RightClick(sender, e, PictureBox10, timesClicked(9), isFlagged(9))
    End Sub

    Private Sub PictureBox11_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox11.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(10) = timesClicked(10) + 1
        End If
        RightClick(sender, e, PictureBox11, timesClicked(10), isFlagged(10))
    End Sub

    Private Sub PictureBox12_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox12.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(11) = timesClicked(11) + 1
        End If
        RightClick(sender, e, PictureBox12, timesClicked(11), isFlagged(11))
    End Sub

    Private Sub PictureBox13_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox13.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(12) = timesClicked(12) + 1
        End If
        RightClick(sender, e, PictureBox13, timesClicked(12), isFlagged(12))
    End Sub

    Private Sub PictureBox14_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox14.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(13) = timesClicked(13) + 1
        End If
        RightClick(sender, e, PictureBox14, timesClicked(13), isFlagged(13))
    End Sub

    Private Sub PictureBox15_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox15.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(15) = timesClicked(15) + 1
        End If
        RightClick(sender, e, PictureBox15, timesClicked(15), isFlagged(15))
    End Sub

    Private Sub PictureBox16_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox16.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(16) = timesClicked(16) + 1
        End If
        RightClick(sender, e, PictureBox16, timesClicked(16), isFlagged(16))
    End Sub

    Private Sub PictureBox17_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox17.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(17) = timesClicked(17) + 1
        End If
        RightClick(sender, e, PictureBox17, timesClicked(17), isFlagged(17))
    End Sub

    Private Sub PictureBox18_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox18.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(18) = timesClicked(18) + 1
        End If
        RightClick(sender, e, PictureBox18, timesClicked(18), isFlagged(18))
    End Sub

    Private Sub PictureBox19_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox19.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(19) = timesClicked(19) + 1
        End If
        RightClick(sender, e, PictureBox19, timesClicked(19), isFlagged(19))
    End Sub

    Private Sub PictureBox20_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox20.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(20) = timesClicked(20) + 1
        End If
        RightClick(sender, e, PictureBox20, timesClicked(20), isFlagged(20))
    End Sub
    Private Sub PictureBox21_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox21.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(21) = timesClicked(21) + 1
        End If
        RightClick(sender, e, PictureBox21, timesClicked(21), isFlagged(21))
    End Sub
    Private Sub PictureBox22_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox22.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(22) = timesClicked(22) + 1
        End If
        RightClick(sender, e, PictureBox22, timesClicked(22), isFlagged(22))
    End Sub
    Private Sub PictureBox23_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox23.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(23) = timesClicked(23) + 1
        End If
        RightClick(sender, e, PictureBox23, timesClicked(23), isFlagged(23))
    End Sub
    Private Sub PictureBox24_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox24.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(24) = timesClicked(24) + 1
        End If
        RightClick(sender, e, PictureBox24, timesClicked(24), isFlagged(24))
    End Sub
    Private Sub PictureBox25_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox25.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(25) = timesClicked(25) + 1
        End If
        RightClick(sender, e, PictureBox25, timesClicked(25), isFlagged(25))
    End Sub
    Private Sub PictureBox26_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox26.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(26) = timesClicked(26) + 1
        End If
        RightClick(sender, e, PictureBox26, timesClicked(26), isFlagged(26))
    End Sub
    Private Sub PictureBox27_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox27.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(27) = timesClicked(27) + 1
        End If
        RightClick(sender, e, PictureBox27, timesClicked(27), isFlagged(27))
    End Sub
    Private Sub PictureBox28_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox28.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(28) = timesClicked(28) + 1
        End If
        RightClick(sender, e, PictureBox28, timesClicked(28), isFlagged(28))
    End Sub
    Private Sub PictureBox29_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox29.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(29) = timesClicked(29) + 1
        End If
        RightClick(sender, e, PictureBox29, timesClicked(29), isFlagged(29))
    End Sub
    Private Sub PictureBox30_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox30.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(30) = timesClicked(30) + 1
        End If
        RightClick(sender, e, PictureBox30, timesClicked(30), isFlagged(30))
    End Sub
    Private Sub PictureBox31_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox31.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(31) = timesClicked(31) + 1
        End If
        RightClick(sender, e, PictureBox31, timesClicked(31), isFlagged(31))
    End Sub
    Private Sub PictureBox32_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox32.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(32) = timesClicked(32) + 1
        End If
        RightClick(sender, e, PictureBox32, timesClicked(32), isFlagged(32))
    End Sub
    Private Sub PictureBox33_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox33.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(33) = timesClicked(33) + 1
        End If
        RightClick(sender, e, PictureBox33, timesClicked(33), isFlagged(33))
    End Sub
    Private Sub PictureBox34_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox34.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(34) = timesClicked(34) + 1
        End If
        RightClick(sender, e, PictureBox34, timesClicked(34), isFlagged(34))
    End Sub
    Private Sub PictureBox35_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox35.MouseDown
        If e.Button = MouseButtons.Right Then
            timesClicked(35) = timesClicked(35) + 1
        End If
        RightClick(sender, e, PictureBox35, timesClicked(35), isFlagged(35))
    End Sub

End Class