Public Class Form2

    Dim mynumber As Double
    Private Property mynumber2 As Double
    Private Property mynumber3 As Double
    Private Property mynumber4 As Double

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label4.Text = ""

    End Sub


    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer


    Private Sub Form2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter numbers only")
        End If

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter numbers only")
        End If

    End Sub
    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter numbers only")
        End If

    End Sub
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter numbers only")
        End If

    End Sub
    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter numbers only")
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox5.Text = "") Or (TextBox4.Text = "") Or (TextBox7.Text = "") Then

            MessageBox.Show("Please enter all values")

            ' TextBox3.Text = "TBD"
        Else
            mynumber2 = ((Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox5.Text) + Val(TextBox4.Text)))
            mynumber3 = ((Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox5.Text) + Val(TextBox4.Text) + Val(TextBox7.Text)))
            mynumber4 = mynumber2 / mynumber3
        End If


        If (TextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox5.Text = "") Or (TextBox4.Text = "") Or (TextBox7.Text = "") Then


        Else
            mynumber = Val(TextBox1.Text) / (Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox5.Text)) * 100
            'Label3.Text = String.Format("{0:0.0} %", mynumber)

            'TextBox3.Text = "PERCENT COMPLETE:  " + String.Format("{0:#0.#%}", mynumber4) + Environment.NewLine + "PASS RATE:  " + String.Format("{0:0.0}%", mynumber)
            TextBox3.Text = "CYCLE COMPLETE:  " + String.Format("{0:#0%}", mynumber4) + Environment.NewLine + "PASS RATE:  " + String.Format("{0:0.0}%", mynumber)

            Label4.Text = mynumber3

        End If

        If TextBox3.Text <> String.Empty Then
            Clipboard.SetText(TextBox3.Text)
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox7.Text = ""
        TextBox5.Text = ""

        TextBox3.Text = ""
        Label4.Text = ""

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class