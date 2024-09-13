Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If (TextBox1.Text = "" Or TextBox1.Text = "Enter Model Number") Then
            MessageBox.Show("Please enter a Model Number before searching")
        Else

            System.Diagnostics.Process.Start("http://qe-inventory.web.att.com/hardware?page=1&size=500&order=asc&sort=model&search=" + TextBox1.Text)

        End If
        TextBox1.Text = ""
        Me.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.AcceptButton = Button1
        Button1.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class