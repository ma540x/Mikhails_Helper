Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form5


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' MsgBox("Hello " & My.Settings.ItrackKey)

        If (TextBox1.Text = "" Or TextBox1.Text = "<ENTER KEY HERE>") Then
            MessageBox.Show("Please enter your iTrack project KEY")
        Else
            My.Settings.iTrackKey1 = TextBox1.Text
            MsgBox("You have set your iTrack Project KEY#1 to:  " & My.Settings.iTrackKey1)
            Label6_Key.Text = My.Settings.iTrackKey1

        End If

        Form1.ITrack1ToolStripMenuItem.Text = My.Settings.iTrackKey1
        Form1.ITrack2ToolStripMenuItem.Text = My.Settings.iTrackKey2


    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox1_MouseClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("Chrome", "https://itrack.web.att.com/secure/project/BrowseProjects.jspa?s=view_projects")

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = "<ENTER KEY HERE>"
        TextBox2.Text = "<ENTER KEY HERE>"

        Label6_Key.Text = My.Settings.iTrackKey1
        Label7_Key.Text = My.Settings.iTrackKey2


    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = ""

        If (TextBox2.Text = "") Then
            TextBox2.Text = "<ENTER KEY HERE>"
        Else
        End If
    End Sub

    Private Sub Form5_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        TextBox1.Text = "<ENTER KEY HERE>"
        TextBox2.Text = "<ENTER KEY HERE>"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If (TextBox2.Text = "" Or TextBox2.Text = "<ENTER KEY HERE>") Then
            MessageBox.Show("Please enter your iTrack project KEY")
        Else
            My.Settings.iTrackKey2 = TextBox2.Text
            MsgBox("You have set your iTrack Project KEY#2 to:  " & My.Settings.iTrackKey2)
            Label7_Key.Text = My.Settings.iTrackKey2
        End If

        Form1.ITrack1ToolStripMenuItem.Text = My.Settings.iTrackKey1
        Form1.ITrack2ToolStripMenuItem.Text = My.Settings.iTrackKey2
    End Sub

    Private Sub Button1_GotFocus(sender As Object, e As EventArgs) Handles Button1.GotFocus

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Text = ""

        If (TextBox1.Text = "") Then
            TextBox1.Text = "<ENTER KEY HERE>"
        Else
        End If

    End Sub

    Private Sub Form5_MarginChanged(sender As Object, e As EventArgs) Handles Me.MarginChanged

    End Sub
End Class