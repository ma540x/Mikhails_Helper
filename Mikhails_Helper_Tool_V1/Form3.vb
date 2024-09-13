Imports System.Text.RegularExpressions

Public Class Form3
    Private Sub Clear_Button_Click(sender As Object, e As EventArgs) Handles Clear_Button.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Select()
    End Sub

    Private Sub Convert_Button_Click(sender As Object, e As EventArgs) Handles Convert_Button.Click

        If (TextBox1.Text = "") Then
            MessageBox.Show("Please enter DEFECT values to convert to QC format")
        End If

        'TextBox2.Text = TextBox1.Text.Replace("Hello", "").Trim()
        ' TextBox2.Text3 = TextBox1.Text.Append("*")
        '  TextBox2.Text = "*" & TextBox1.Text & "* OR"



        '    If InStr(TextBox2.Text, " ") > 0 Then
        ' MessageBox.Show("STRING HAS SPACES")
        '  End If

        ' If TextBox1.Text.Contains("SM") Then
        '  MessageBox.Show("Contains with SM")
        '   'TextBox2.Text = "*" & TextBox1.Text & "* OR"
        ' End If

        '   If TextBox1.Text.StartsWith("SM") Then
        'MessageBox.Show("Starts with SM")
        '  End If

        'Dim strMyString As String
        ' strMyString = TextBox1.Text

        'TextBox2.Text = TextBox1.Text
        ' TextBox2.Text = TextBox1.Text.Split(" "c)(0)




        ' Dim value As String = TextBox1.Text
        ' Dim selected As String = ""
        ' Dim selectedValues As String() = value.Split("\r")

        ' For i As Integer = 0 To selectedValues.Length - 1 - 1
        '     selected += selectedValues(i).Split(" "c)(selectedValues(i).Split(" "c).Length - 2) & ","
        ' Next

        'TextBox2.Text = selected.TrimEnd(","c)

        Dim str As String = TextBox1.Text
        str = Regex.Replace(str, "\t\n\r", "")
        'MessageBox.Show(str)
        TextBox2.Text = str




        ' If strMyString.Contains("SM-") OrElse strMyString.Contains("LG-") Then
        'TextBox2.Text = "*" & TextBox1.Text & "* OR"
        ' MessageBox.Show("DETECTED SOMETHING")
        '  End If

        '  If TextBox2.Text <> String.Empty Then
        '  Clipboard.SetText(TextBox2.Text)
        '   End If



    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Select()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer


    Private Sub Form3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If TextBox2.Text <> String.Empty Then
            Clipboard.SetText(TextBox2.Text)
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            MessageBox.Show("Please enter DEVICE values to convert to QC format")
        End If



        ' Dim str As String = TextBox1.Text
        'Dim insStr As String = "* OR *" 'space
        'Dim strRes As String = str.Insert(7, insStr) '5th position
        'TextBox2.Text = strRes



        ' Dim sample As String = TextBox1.Text

        '  Dim insertData As String = " OR * "
        '  Dim marker As String = "SM"
        ''  Dim insertPos As Integer = sample.IndexOf(marker)
        '  If insertPos >= 0 Then
        '  sample = sample.Insert(insertPos, insertData)
        '  End If
        '  TextBox2.Text = sample



        ' Dim str As String = TextBox1.Text

        ' For Each S As Char In str
        ' Dim insStr As String = "* OR *"
        ' Dim strRes As String = str.Insert(0, insStr) '5th position
        '  TextBox2.Text = strRes
        '  Next



        '  Dim value As String = TextBox1.Text

        ' Start at zero and proceed until final index.
        '   For i As Integer = 0 To value.Length - 1
        ' Get character from string.
        ' Dim c As Char = value(i)

        ' Test and display character.
        '  If c = "s" Then
        ' Dim insStr As String = "* OR *"
        'Dim strRes As String = Str.Insert(0, insStr) '5th position
        '  TextBox2.Text = strRes
        '   Else
        '    Console.WriteLine(c)
        '    End If
        '  Next


    End Sub
End Class