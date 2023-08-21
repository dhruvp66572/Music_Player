Imports System.IO
Imports System.Drawing
Public Class Form1

    Dim path() As String
    Dim files() As String
    Private Sub open_btn_Click(sender As Object, e As EventArgs) Handles open_btn.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            'OpenFileDialog1.FileName = Nothing
            'OpenFileDialog1.Filter = "Song File(*.mp3;*.wav)|*.mp3;*.wav"
            files = OpenFileDialog1.FileNames
            path = OpenFileDialog1.FileNames

            For i = 0 To files.Length - 1
                ListBox1.Items.Add(files(i).Substring(22))
            Next
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        player.URL = path(ListBox1.SelectedIndex)
        player.Ctlcontrols.play()
        PictureBox1.Visible = True
        TrackBar1.Value = player.settings.volume
        Label2.Text = TrackBar1.Value & "%"
    End Sub

    Private Sub stop_btn_Click(sender As Object, e As EventArgs) Handles stop_btn.Click
        player.Ctlcontrols.stop()
        ProgressBar1.Value = 0
        PictureBox1.Visible = False
    End Sub

    Private Sub pause_btn_Click(sender As Object, e As EventArgs) Handles pause_btn.Click
        player.Ctlcontrols.pause()
        PictureBox1.Visible = False
    End Sub

    Private Sub Play_btn_Click(sender As Object, e As EventArgs) Handles Play_btn.Click
        player.Ctlcontrols.play()
        PictureBox1.Visible = True
    End Sub

    Private Sub next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then

            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
        End If
    End Sub

    Private Sub preview_btn_Click(sender As Object, e As EventArgs) Handles preview_btn.Click
        If ListBox1.SelectedIndex > 0 Then
            ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If player.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            ProgressBar1.Maximum = Int(player.Ctlcontrols.currentItem.duration)
            ProgressBar1.Value = Int(player.Ctlcontrols.currentPosition)
        End If



        Try
            Label3.Text = player.Ctlcontrols.currentPositionString
            Label4.Text = player.Ctlcontrols.currentItem.durationString

            If player.Ctlcontrols.currentPositionString = Label4.Text Then
                ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        player.settings.volume = TrackBar1.Value
        Label2.Text = TrackBar1.Value & "%"
    End Sub

    Private Sub ProgressBar1_MouseDown(sender As Object, e As MouseEventArgs) Handles ProgressBar1.MouseDown
        player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / ProgressBar1.Width
    End Sub


End Class
