Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pesanan As String
        Dim i As Integer

        pesanan = ""
        For i = 1 To ListBox1.SelectedItems.Count
            pesanan = pesanan + ListBox1.SelectedItems.Item(i - 1) + vbCrLf
        Next
        TextBox1.Text = pesanan
    End Sub
End Class
