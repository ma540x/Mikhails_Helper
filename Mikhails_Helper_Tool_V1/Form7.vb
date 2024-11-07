Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("Please enter the ATTUID before searching")
        Else
            System.Diagnostics.Process.Start("https://webphone.att.com/cgi-bin/webphones.pl?id=" + TextBox1.Text)
        End If
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox2.Text = "") Then
            MessageBox.Show("Please enter the First Name before searching")
        Else
            System.Diagnostics.Process.Start("https://webphone.att.com/cgi-bin/webphone.pl?par=first%3D" + TextBox2.Text + "&type=&src_pg=home")
        End If
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox3.Text = "") Then
            MessageBox.Show("Please enter the Last Name before searching")
        Else
            System.Diagnostics.Process.Start("https://webphone.att.com/cgi-bin/webphone.pl?par=last%3D" + TextBox3.Text + "&type=&src_pg=home")
        End If
        TextBox3.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (TextBox4.Text = "") Then
            MessageBox.Show("Please enter email address searching")
        Else
            System.Diagnostics.Process.Start("https://webphone.att.com/cgi-bin/webphone.pl?par=pmail%3D" + TextBox4.Text + "*%7Cpmail%3D" + TextBox4.Text + "&type=&src_pg=home")
        End If
        TextBox4.Text = ""
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class