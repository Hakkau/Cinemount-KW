Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2

    Private Sub Label3_MouseClick(sender As Object, e As MouseEventArgs) Handles Label3.MouseClick
        MessageBox.Show("Silahkan Pilih Jam dan Kursi")
    End Sub

    Private Sub Label3_MouseHover(sender As Object, e As EventArgs) Handles Label3.MouseHover
        ToolTip1.SetToolTip(Label1, "Klik 2 kali untuk memilih jam")
        ToolTip1.SetToolTip(Label2, "Klik 2 kali untuk memilih jam")
        ToolTip1.SetToolTip(Label3, "Klik 2 kali untuk memilih jam")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Label5.Click
        Dim time = DirectCast(sender, Label)
        time.BackColor = Color.White
    End Sub

    Private Sub Label5_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Label4.MouseDoubleClick, Label5.MouseDoubleClick
        Dim time = DirectCast(sender, Label)
        time.BackColor = Color.Gray
    End Sub
End Class