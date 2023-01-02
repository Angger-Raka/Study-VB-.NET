Public Class frCheckBox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""

        If (CheckBox1.Checked = True) Then
            TextBox1.Text = TextBox1.Text + CheckBox1.Text + vbCrLf
        End If
        If (CheckBox2.Checked = True) Then
            TextBox1.Text = TextBox1.Text + CheckBox2.Text + vbCrLf
        End If
        If (CheckBox3.Checked = True) Then
            TextBox1.Text = TextBox1.Text + CheckBox3.Text + vbCrLf
        End If
        If (CheckBox4.Checked = True) Then
            TextBox1.Text = TextBox1.Text + CheckBox4.Text + vbCrLf
        End If
        If (CheckBox5.Checked = True) Then
            TextBox1.Text = TextBox1.Text + CheckBox5.Text + vbCrLf
        End If
    End Sub

    Private Sub frCheckBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
