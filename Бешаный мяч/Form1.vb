Public Class Form1
    Dim x, y, a As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            Timer3.Enabled = False
        Else
            Timer1.Enabled = True
            Timer2.Enabled = True
            Timer3.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Timer1.Interval <> 1 Then
            Timer1.Interval = Timer1.Interval - 1
            Timer2.Interval = Timer2.Interval - 1
        End If
        ' Движение по вертикали при y=1 - движется вниз, при 2 - вверх
        If PictureBox1.Top <= 0 Then
            y = 1
            Timer1.Interval = 30
            Timer2.Interval = 30
        End If
        If PictureBox1.Top >= ((Me.Height - 39) - PictureBox1.Size.Height) Then
            y = 2
            Timer1.Interval = 30
            Timer2.Interval = 30
        End If

        Select Case y
            Case 1
                PictureBox1.Top = PictureBox1.Top + 3
            Case 2
                PictureBox1.Top = PictureBox1.Top - 3
            Case Else
                y = Int(Rnd() * 2) + 1
        End Select
        Label1.Text = Timer1.Interval & ", " & Timer2.Interval
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'движение по горизонтали
        If PictureBox1.Left <= 0 Then
            x = 1
            Timer1.Interval = 30
            Timer2.Interval = 30
        End If
        If PictureBox1.Left >= (Me.Width - 17) - PictureBox1.Size.Width Then
            x = 2
            Timer1.Interval = 30
            Timer2.Interval = 30
        End If

        Select Case x
            Case 1
                PictureBox1.Left = PictureBox1.Left + 3
            Case 2
                PictureBox1.Left = PictureBox1.Left - 3
            Case Else
                x = Int(Rnd() * 2) + 1
        End Select
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        'Уменьшатся или увеличиватся при а=1 увеличивается, при 2 - уменьшается
        If PictureBox1.Size.Height < 30 Then
            a = 1
        End If
        If PictureBox1.Size.Height > 100 Or PictureBox1.Top <= 0 Then
            a = 2
        End If
        Select Case a
            Case 1
                PictureBox1.Height = PictureBox1.Height + 2
                PictureBox1.Width = PictureBox1.Width + 2
            Case 2
                PictureBox1.Height = PictureBox1.Height - 2
                PictureBox1.Width = PictureBox1.Width - 2
            Case Else
                a = 1
        End Select
    End Sub
End Class
