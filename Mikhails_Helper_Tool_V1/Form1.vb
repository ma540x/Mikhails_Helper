Imports System.Text.RegularExpressions

Public Class Form1


    Dim WithEvents aTimer As New System.Windows.Forms.Timer 'could have been done in the Designer

    Private Sub aTimer_Tick(ByVal sender As Object,
                            ByVal e As System.EventArgs) Handles aTimer.Tick
        Label3.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub Form1_Shown(ByVal sender As Object,
                            ByVal e As System.EventArgs) Handles Me.Shown
        aTimer.Interval = 250
        aTimer.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://labqc1.eng.mobilephone.net:8080/qcbin")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateLabel.Text = Date.Today.ToString("MMM dd, yyyy")
        Label1.Text = Date.Today.ToString("ddddd")
        ' ComboBox1.Text = "  Drop Down"


    End Sub

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub


    Private Sub DateLabel_Click(sender As Object, e As EventArgs) Handles DateLabel.Click

    End Sub

    Private Sub TimeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter numbers only")
        End If

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter numbers only")
        End If

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://www.google.com", "Chrome")
        ' NavigateWebURL("http://www.google.com", "Firefox") '// safari Firefox chrome etc

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "CHROME" Then
            System.Diagnostics.Process.Start("Chrome", "http://www.google.com")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "FIREFOX" Then
            System.Diagnostics.Process.Start("Firefox", "http://www.google.com")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "MICROSOFT EDGE" Then
            System.Diagnostics.Process.Start("msedge.exe", "http://www.google.com")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "QC (SPE)" Then
            System.Diagnostics.Process.Start("iexplore", "http://labqc2.eng.mobilephone.net:8080/qcbin/start_a.jsp")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "QC (TPR)" Then
            System.Diagnostics.Process.Start("iexplore", "http://labqc2.eng.mobilephone.net:8080/qcbin/start_a.jsp")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "MOOSE" Then
            System.Diagnostics.Process.Start("http://moose.web.att.com")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "BOLT" Then
            System.Diagnostics.Process.Start("http://bolt.web.att.com/#!/")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "WEBSTR" Then
            System.Diagnostics.Process.Start("Chrome", "https://cmpmdt.web.att.com/cmpm/main.cfm")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "PRISM" Then
            System.Diagnostics.Process.Start("http://prism.techdev.att.com/request-ui/#/request-search")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "ECORP" Then
            System.Diagnostics.Process.Start("iexplore", "https://ecorplb.sbc.com/irj/portal")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "JIRA (ALIGN)" Then
            System.Diagnostics.Process.Start("Firefox", "https://att.agilecraft.com")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "JIRA (ITRACK)" Then
            System.Diagnostics.Process.Start("Firefox", "https://itrack.web.att.com/projects/CDEX")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "PLE" Then
            System.Diagnostics.Process.Start("http://PLE.WEB.ATT.COM/#/home")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "FIDELITY" Then
            System.Diagnostics.Process.Start("http://fidelity.com")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "QE TSPACE" Then
            System.Diagnostics.Process.Start("https://tspace.web.att.com/communities/service/html/communitystart?communityUuid=3a6b50aa-7147-4b08-82c1-f52a4557850f")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "GOOGLE DRIVE" Then
            System.Diagnostics.Process.Start("https://drive.google.com/drive/u/0/my-drive")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "QE TIME TRACKER" Then
            System.Diagnostics.Process.Start("https://workspace.web.att.com/sites/QualityEngineering1/QE_Time_Tracking/Lists/QE%20Hours/AllItems.aspx")
            ComboBox1.SelectedIndex = -1
        End If


        If ComboBox1.Text = "LAB TICKETS (QC DOWN)" Then
            System.Diagnostics.Process.Start("https://support.labops.att.com/plugins/servlet/desk/portal/2")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "LAB TICKETING (MOBILITY LABS)" Then
            System.Diagnostics.Process.Start("https://labticketing.web.att.com/am/")
            ComboBox1.SelectedIndex = -1
        End If


        If ComboBox1.Text = "HELPDESK" Then
            System.Diagnostics.Process.Start("http://servicedesk.it.att.com/toolkit/cdt")
            ComboBox1.SelectedIndex = -1
        End If


        If ComboBox1.Text = "HR ONESTOP" Then
            System.Diagnostics.Process.Start("https://www.e-access.att.com/hronestop")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "MOTS SEARCH" Then
            System.Diagnostics.Process.Start("https://mots.web.att.com/")
            ComboBox1.SelectedIndex = -1
        End If


        If ComboBox1.Text = "AT&T PERKS" Then
            System.Diagnostics.Process.Start("https://attperks.benefithub.com/")
            ComboBox1.SelectedIndex = -1
        End If


        If ComboBox1.Text = "MOBILEIRON (MYOWN)" Then
            System.Diagnostics.Process.Start("https://cou.web.att.com/app/#/BYOD/byodAction/home")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "COU" Then
            System.Diagnostics.Process.Start("https://cou.web.att.com/app/#/COU/home")
            ComboBox1.SelectedIndex = -1
        End If


        If ComboBox1.Text = "AT&T INSIDER" Then
            System.Diagnostics.Process.Start("https://insider.att.com")
            ComboBox1.SelectedIndex = -1
        End If


        If ComboBox1.Text = "WEBPHONE" Then
            System.Diagnostics.Process.Start("http://webphone.att.com/")
            ComboBox1.SelectedIndex = -1
        End If


        If ComboBox1.Text = "AT&T ABBREVIATIONS/DEFINITIONS" Then
            System.Diagnostics.Process.Start("http://glossary.web.att.com/home/show")
            ComboBox1.SelectedIndex = -1
        End If


        If ComboBox1.Text = "ITRACK" Then
            System.Diagnostics.Process.Start("https://itrack.web.att.com/browse")
            ComboBox1.SelectedIndex = -1
        End If



        If ComboBox1.Text = "FIELDGLASS" Then
            System.Diagnostics.Process.Start("https://saml.e-access.att.com/isam/sps/ATTIDP/saml20/logininitial?RequestBinding=HTTPPost&PartnerId=https://www.fieldglass.com")
            ComboBox1.SelectedIndex = -1
        End If


        If ComboBox1.Text = "CAPS" Then
            System.Diagnostics.Process.Start("https://caps.web.att.com/esm80/#/exp/dashboard")
            ComboBox1.SelectedIndex = -1
        End If


        If ComboBox1.Text = "BENEFITS (MEDICAL/VISION/DENTAL)" Then
            System.Diagnostics.Process.Start("https://saml.e-access.att.com/isam/sps/ATTIDPEntity/saml20/logininitial?RequestBinding=HTTPPost&PartnerId=saml.alight.com&Target=https://sso.alight.com/portal%3FpageCd%3DL_YOUR_HEALTH_MATTERS")
            ComboBox1.SelectedIndex = -1
        End If


        If ComboBox1.Text = "SELF SERVICE" Then
            System.Diagnostics.Process.Start("https://itoselfservice.it.att.com/SelfService/browserWarning.jsf")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "IQ BAR" Then
            System.Diagnostics.Process.Start("http://iqbar.web.att.com/")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "LEASE ROLL" Then
            System.Diagnostics.Process.Start("http://desktop.it.att.com/Steps.aspx")
            ComboBox1.SelectedIndex = -1
        End If

        If ComboBox1.Text = "MAGNUM (TCET)" Then
            System.Diagnostics.Process.Start("http://intranet.att.com/project/magnum/")
            ComboBox1.SelectedIndex = -1
        End If






    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Convert_Button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Dim SecondForm As New Form2
        SecondForm.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

        Dim ThirdForm As New Form3
        ThirdForm.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FourthForm As New Form4
        FourthForm.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        System.Diagnostics.Process.Start("https://itrack.web.att.com/secure/Dashboard.jspa?selectPageId=60143")


    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("https://itrack.web.att.com/projects/QEPHOTO?selectedItem=com.thed.zephyr.je%3Azephyr-tests-page#test-cycles-tab")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        System.Diagnostics.Process.Start("https://itrack.web.att.com/secure/Dashboard.jspa?selectPageId=60323")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        System.Diagnostics.Process.Start("C:\Windows\system32\calc.exe")
    End Sub
End Class
