Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        InputLabel.Text = "<Pilihan Product Anda>"

        If (RadioButton1.Checked = True) Then
            InputLabel.Text = RadioButton1.Text
        ElseIf (RadioButton2.Checked = True) Then
            InputLabel.Text = RadioButton2.Text
        ElseIf (RadioButton3.Checked = True) Then
            InputLabel.Text = RadioButton3.Text
        ElseIf (RadioButton4.Checked = True) Then
            InputLabel.Text = RadioButton4.Text
        End If


    End Sub
End Class
