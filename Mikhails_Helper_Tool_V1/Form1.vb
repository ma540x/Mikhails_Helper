Imports System.CodeDom
Imports System.ComponentModel
Imports System.Configuration
Imports System.Deployment.Application
Imports System.Drawing.Design
Imports System.Drawing.Text
Imports System.IO
Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Runtime.CompilerServices
Imports System.Runtime.Remoting.Messaging
Imports System.Runtime.Serialization
Imports System.Security.Policy
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.Win32
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core
Imports System.Diagnostics
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar







Public Class Form1


    Dim Pos As Point
    Private address As Object
    Private subject As Object()
    Public Property MyVersion As String
    Public Property lblVersion As Object
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer


    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown, DateLabel.MouseDown, Label1.MouseDown, DayLabel.MouseDown, TimeLabel.MouseDown, ampm_Label.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp, DateLabel.MouseUp, Label1.MouseUp, DayLabel.MouseUp, TimeLabel.MouseUp, ampm_Label.MouseUp
        drag = False
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove, DateLabel.MouseMove, Label1.MouseMove, DayLabel.MouseMove, TimeLabel.MouseMove, ampm_Label.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub




    Dim WithEvents aTimer As New System.Windows.Forms.Timer 'could have been done in the Designer

    Private Sub aTimer_Tick(ByVal sender As Object,
                            ByVal e As System.EventArgs) Handles aTimer.Tick
        'Label3.Text = DateTime.Now.ToString("hh:mm tt")
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        aTimer.Interval = 250
        aTimer.Start()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.Closing
        Me.WindowState = FormWindowState.Minimized
        e.Cancel = True
    End Sub

    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load


    '    '  If My.Application = True Then

    '    '   End If
    '    '

    '    ' Me.Show()
    '    ' Me.WindowState = FormWindowState.Normal
    '    NotifyIcon1.Visible = True


    '    ' If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
    '    'Dim ad As ApplicationDeployment = ApplicationDeployment.CurrentDeployment
    '    'End If



    '    ' DateLabel.Text = Date.Today.ToString("MM/dd/yyyy")
    '    ' DateLabel.Text = Date.Today.ToString("MMM dd")
    '    DateLabel.Text = Date.Today.ToString("MM/dd")
    '    ' "MMM ddd d HH:mm yyyy"
    '    DayLabel.Text = DateTime.Now.ToString("dddd")
    '    'DayLabel.Text = Date.Today.ToString("ddddd")
    '    DayLabel.Text = DayLabel.Text.ToUpper()
    '    '  ComboBox2.Text = "  QUICK LINKS"
    '    '  TimeLabel.Text = DateTime.Now.ToString("HH:mm")


    '    ITrack1ToolStripMenuItem.Text = My.Settings.iTrackKey1
    '    ITrack2ToolStripMenuItem.Text = My.Settings.iTrackKey2


    '    If My.Settings.iTrackKey1 = "TBD" Then
    '    Else
    '        ITrack1ToolStripMenuItem.Checked = True
    '    End If

    '    ' THIS IS TO DISPLAY VERSION NUMBERS
    '    ' TESTToolStripMenuItem.Text = "Current Version: " & Application.ProductVersion


    '    ' THIS IS TO DISPLAY PUBLISH VERION NUMBERS
    '    ' TESTToolStripMenuItem.Text = "Current Version: " & My.Application.Deployment.CurrentVersion.ToString()


    'End Sub




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


    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Convert_Button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

        TextBox1.Text = "DARP #"
        TextBox5.Text = "ITRACK #"

        Dim SecondForm As New Form2
        SecondForm.Show()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

        Dim ThirdForm As New Form3
        ThirdForm.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("https://darp-jira.att.com/projects/DARP/issues")
        TextBox1.Text = "DARP #"
        TextBox5.Text = "iTRACK #"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

        System.Diagnostics.Process.Start("https://ITRACK.web.att.com/secure/MyJiraHome.jspa")
        TextBox1.Text = "DARP #"
        TextBox5.Text = "ITRACK #"

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://itrack.web.att.com/projects/QEPHOTO?selectedItem=com.thed.zephyr.je%3Azephyr-tests-page#test-cycles-tab")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://itrack.web.att.com/secure/Dashboard.jspa?selectPageId=60323")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = "DARP #"
        TextBox5.Text = "iTRACK #"
        System.Diagnostics.Process.Start("C:\Windows\system32\calc.exe")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        System.Diagnostics.Process.Start("https://att.yourzephyr.com/flex/html5/release/5391")
        TextBox1.Text = "DARP #"
        TextBox5.Text = "iTRACK #"
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        ' If (TextBox5.Text = "" Or TextBox5.Text = "iTrack #") Then
        ' MessageBox.Show("Please enter an iTrack defect number.")
        ' ElseIf My.Settings.iTrackKey1 = "TBD" Then
        ' MessageBox.Show("Please set an iTrack KEY for your Project in Settings")
        ' Else
        ' End If

        If ITrack1ToolStripMenuItem.Checked = True AndAlso Not TextBox5.Text = "ITRACK #" Then
            '  System.Diagnostics.Process.Start("https://itrack.web.att.com/browse/" + TextBox5.Text)
            System.Diagnostics.Process.Start("https://itrack.web.att.com/browse/" + My.Settings.iTrackKey1 + "-" + TextBox5.Text)
        ElseIf ITrack1ToolStripMenuItem.Checked = True And TextBox5.Text = "iTrack #" Then
            MessageBox.Show("Please enter an iTrack defect number.")
        ElseIf ITrack2ToolStripMenuItem.Checked = True AndAlso Not TextBox5.Text = "iTrack #" Then
            System.Diagnostics.Process.Start("https://itrack.web.att.com/browse/" + My.Settings.iTrackKey2 + "-" + TextBox5.Text)
        ElseIf ITrack2ToolStripMenuItem.Checked = True And TextBox5.Text = "iTrack #" Then
            MessageBox.Show("Please enter an iTrack defect number.")
            ' Else MsgBox("Please select an iTrack project from the drop down")
            ' Else System.Diagnostics.Process.Start("https://itrack.web.att.com/browse/" + My.Settings.iTrackKey1 + "-" + TextBox5.Text)
        ElseIf (TextBox5.Text = "" Or TextBox5.Text = "ITRACK #") Then
            MessageBox.Show("Please enter an iTrack defect number.")
        Else

            MsgBox("Please perform the following.. " & vbNewLine & vbNewLine & "FIRST: set an ITRACK Key for your Project in Settings (Gear icon bottom left corner of the app)" & vbNewLine & vbNewLine & "SECOND: select a iTrack Key from the dropdown next to GO button " & vbNewLine & vbNewLine & "*** All this has to happen once ***" & vbNewLine & vbNewLine & "You can add up to 2 iTracks, you are able to switch between them on the fly next to the GO button. Enjoy!")
        End If

        TextBox5.Text = "ITRACK #"
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox5.MouseClick
        TextBox5.Text = ""
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        TextBox5.Text = "ITRACK #"
    End Sub


    Private Sub Button7_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.yourzephyr.com/flex/html5/")
        TextBox1.Text = "DARP #"
        TextBox5.Text = "ITRACK #"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        If (TextBox1.Text = "" Or TextBox1.Text = "DARP #") Then
            MessageBox.Show("Please enter a DARP defect number.")
        Else

            System.Diagnostics.Process.Start("https://darp-jira.att.com/browse/DARP-" + TextBox1.Text)

        End If
        TextBox1.Text = "DARP #"
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Text = ""
    End Sub

    Private Sub Button5_Enter(sender As Object, e As EventArgs)
        ' System.Diagnostics.Process.Start("Chrome", "https://itrack.web.att.com/browse/" + TextBox5.Text)
        '  TextBox5.Text = "iTrack #"
    End Sub

    Private Sub Button5_LostFocus(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_LostFocus(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_GotFocus(sender As Object, e As EventArgs)
        TextBox1.Text = "DARP #"
        TextBox5.Text = "ITRACK #"

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs)
        '  TimeLabel.Text = Format(Now, "yyyy-MM-dd hh:mm:ss")
        ' TimeLabel.Text = DateTime.Now.ToString("hh:mm tt")
        TimeLabel.Text = DateTime.Now.ToString("hh:mm").TrimStart("0"c)
        DayLabel.Text = DateTime.Now.ToString("dddd")
        DayLabel.Text = DayLabel.Text.ToUpper()
        ampm_Label.Text = DateTime.Now.ToString("tt")
        DateLabel.Text = Date.Today.ToString("MM/dd")
        '  TimeLabel.Text = TimeString

    End Sub

    Private Sub TimeLabel_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub ComboBox2_LostFocus(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_GotFocus(sender As Object, e As EventArgs)
        TextBox1.Text = "DARP #"
        TextBox5.Text = "ITRACK #"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

        Me.TopMost = False

        Dim Outl As Object
        Outl = CreateObject("Outlook.Application")
        If Outl IsNot Nothing Then
            Dim omsg As Object
            omsg = Outl.CreateItem(0)
            omsg.To = "g18290@att.com"
            'omsg.bcc = "yusuf@gmail.com"
            omsg.subject = "Device Request"
            omsg.body = "Hello," & vbNewLine & "I'd like to request the following:" & vbNewLine & vbNewLine

            omsg.Display(True) 'will display message to user
        End If


        Me.TopMost = True

    End Sub

    Private Sub Test2ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

        Me.TopMost = False

        Process.Start(String.Format("mailto:g18290@att.com?subject=Device%20Request&body=Hello,%0d%0aI'd%20like%20to%20request%20the%20following%20device(s)%20from%20Inventory:%0d%0a%0d%0aDevice:%0d%0aFirmware%20Version:%0d%0a%0d%0aThanks!"))

        Me.TopMost = True


    End Sub

    Private Sub Test3ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start(String.Format("mailto:g18290@att.com?subject=FOTA%20Request&body=Hello,%0d%0aI'd%20like%20to%20request%20FOTA%20to%20be%20pushed%20to%20the%20following:%0d%0a%0d%0aDevice:%0d%0aFirmware%20Version:%0d%0aCTN:%0d%0a%0d%0aThanks!"))

    End Sub

    Private Sub ManualFlashRequestToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start(String.Format("mailto:g18290@att.com?subject=Manual%20Flash%20Request&body=Hello,%0d%0aI'd%20like%20to%20request%20a%20manual%20flash%20with%20the%20following%20device(s)%20and%20FW:%0d%0a%0d%0aDevice:%0d%0aFirmware%20Version:%0d%0a%0aThanks!"))
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
        TextBox1.Text = "DARP #"
        TextBox5.Text = "ITRACK #"
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateLabel_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub RequestToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.TopMost = False

        Dim Outl As Object
        Outl = CreateObject("Outlook.Application")
        If Outl IsNot Nothing Then
            Dim omsg As Object
            omsg = Outl.CreateItem(0)
            omsg.To = "g18290@att.com"
            'omsg.bcc = "yusuf@gmail.com"
            omsg.subject = "My Inventory Check-out PDF Request"
            omsg.body = "Hello," & vbNewLine & "I'd like to request my Inventory Check-out PDF to be sent to me. " & vbNewLine & vbNewLine & "Thanks! " & vbNewLine & vbNewLine

            omsg.Display(True) 'will display message to user
        End If


        Me.TopMost = True
    End Sub

    Private Sub Label2_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub DayLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReadInventoryGuidelinesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/QE_Inventory_Guidelines.aspx")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

        If Me.TopMost = True Then
            Me.TopMost = False
        ElseIf Me.TopMost = False Then
            Me.TopMost = True

        End If


    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub SetITrackProjectToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Form5.Show()
    End Sub

    Private Sub EnableToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.TopMost = True
    End Sub

    Private Sub DisableToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.TopMost = False
    End Sub

    Private Sub Label1_DragEnter(sender As Object, e As DragEventArgs)

    End Sub

    Private Sub Label1_LostFocus(sender As Object, e As EventArgs)

    End Sub

    Private Sub TestToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub QETIMETRACKERToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://workspace.web.att.com/sites/QualityEngineering1/QE_Time_Tracking/Lists/QE%20Hours/AllItems.aspx")

    End Sub

    Private Sub STRHoursToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.quickbase.com/db/btin2gcna")
    End Sub

    Private Sub ADMINRIGHTSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://intranet.att.com/elrws/index.php")

    End Sub

    Private Sub IQBARToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://iqbar.web.att.com/")

    End Sub

    Private Sub LEASEROLLToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://desktop.it.att.com/Steps.aspx")

    End Sub

    Private Sub AODACCESSTOZEPHYRITRACKToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://aod.web.att.com/dashboard")
    End Sub

    Private Sub BUILDINGSECURITYCARDSACCESSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/cre/buildingsecurity/default.aspx")

    End Sub

    Private Sub MYLOGINSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://mylogins.cso.att.com/index.cfm")

    End Sub

    Private Sub SERVICEACTIVATIONORDERToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://saorder.sbc.com/Default.aspx")

    End Sub

    Private Sub VPNToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.e-access.att.com/iamportal-prod/rsauser/#/home")

    End Sub

    Private Sub ATTABBREVIATIONSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://glossary.web.att.com/home/show#/home")

    End Sub

    Private Sub ATTINSIDERToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://insider.att.com")

    End Sub



    Private Sub QEINVENTORYGUIDELINESToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/QE_Inventory_Guidelines.aspx")

    End Sub

    Private Sub RETURNLAPTOPSLABELToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://askget.web.att.com/depot/depot-logistics-return-device")
    End Sub

    Private Sub TESTERONBOARDINGToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/Onboarding.aspx")

    End Sub

    Private Sub WEBPHONEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://webphone.att.com/")

    End Sub

    Private Sub ITRACKATTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://itrack.web.att.com/browse")

    End Sub

    Private Sub ITRACKDARPToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://darp-jira.att.com/projects/DARP/issues")

    End Sub

    Private Sub ZEPHYRToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.yourzephyr.com/flex/html5/release/5391")

    End Sub

    Private Sub HELPDESKToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://servicedesk.it.att.com/toolkit/cdt")
    End Sub

    Private Sub KICCareATTPrepaidToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://kiccare.tdc.cingular.net/webcc/Access.html")
    End Sub

    Private Sub KOUCricketToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.e-access.att.com/cou/#/KOU/ack")
    End Sub

    Private Sub LABTICKETINGMOBILITYLABSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://labticketing.web.att.com/am/")
    End Sub

    Private Sub LABTICKETSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://support.labops.att.com/plugins/servlet/desk/portal/2")

    End Sub

    Private Sub MAGNUMTCETToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://intranet.att.com/project/magnum/")
    End Sub

    Private Sub MEETINGROOMSRESERVATIONSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.e-access.att.com/ywr/cart")

    End Sub

    Private Sub TELEGENCEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://atthva.workspaceair.com/catalog-portal/ui#/app-favorite")

    End Sub

    Private Sub BENEFITSMEDICALVISIONDENTALToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://saml.e-access.att.com/isam/sps/ATTIDPEntity/saml20/logininitial?RequestBinding=HTTPPost&PartnerId=saml.alight.com&Target=https://sso.alight.com/portal%3FpageCd%3DL_YOUR_HEALTH_MATTERS")
    End Sub

    Private Sub BOLTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://bolt.web.att.com/#!/")
    End Sub

    Private Sub CAPSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://caps.web.att.com/esm80/#/exp/dashboard")

    End Sub

    Private Sub COUToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://cou.web.att.com/app/#/COU/home")

    End Sub

    Private Sub ECORPToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://ecorplb.sbc.com/irj/portal")

    End Sub

    Private Sub FIDELITYToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://fidelity.com")

    End Sub

    Private Sub FIELDGLASSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://saml.e-access.att.com/isam/sps/ATTIDP/saml20/logininitial?RequestBinding=HTTPPost&PartnerId=https://www.fieldglass.com")

    End Sub

    Private Sub HRONESTOPToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.e-access.att.com/hronestop")
    End Sub

    Private Sub INFORTIMEOFFToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://mingle-portal.inforcloudsuite.com/ATT_PRD")

    End Sub

    Private Sub MOBILEIRONMYOWNToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://cou.web.att.com/app/#/BYOD/byodAction/home")
    End Sub

    Private Sub ONBOARDINGRESOURCESToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/Onboarding%20Resources%20(for%20Managers).aspx")
    End Sub

    Private Sub PLEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://PLE.WEB.ATT.COM/#/home")
    End Sub

    Private Sub PRISMToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://prism.techdev.att.com/request-ui/#/request-search")
    End Sub

    Private Sub SELFSERVICEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://itoselfservice.it.att.com/SelfService/browserWarning.jsf")
    End Sub

    Private Sub WEBSTRToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://cmpmdt.web.att.com/cmpm/main.cfm")
    End Sub

    Private Sub WEBSTRToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://cmpm.web.att.com/cmpm/#/supr/TimeReview")
    End Sub

    Private Sub WORKDAYToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles WORKDAYToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.myworkday.com/att/d/home.htmld")
    End Sub

    Private Sub CheckForUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/Mikhail%27s_Helper_Tool.aspx")

    End Sub

    Private Sub VysorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.vysor.io")
    End Sub

    Private Sub IMazingToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://imazing.com")
    End Sub

    'Private Sub ZIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZIPToolStripMenuItem.Click
    '    System.Diagnostics.Process.Start("https://www.7-zip.org/download.html")

    'End Sub

    Private Sub WinRarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.win-rar.com/download.html?&L=0")

    End Sub

    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://attperks.benefithub.com/")
    End Sub

    Private Sub USBToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/Shared%20Documents/Forms/AllItems.aspx?id=%2Fsites%2FCMAC%2FShared%20Documents%2FGeneral%2FGuides%2FUSB%20access%20request%20%2D%20ServiceNow%20guide%2Epdf&parent=%2Fsites%2FCMAC%2FShared%20Documents%2FGeneral%2FGuides")
    End Sub

    Private Sub VersionNumberToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ShareThisAppToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start(String.Format("mailto:?subject=Check%20out%20this%20app!&body=Hiya,%0d%0aCheck%20out%20this%20app:%20https://att.sharepoint.com/sites/CMAC/SitePages/Mikhail%27s_Helper_Tool.aspx%0d%0a%0d%0aThanks!"))

    End Sub

    Private Sub RSAApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        TextBox1.Text = "DARP #"
        TextBox5.Text = "ITRACK #"
        System.Diagnostics.Process.Start("https://darp-jira.att.com/projects/DARP/issues")
    End Sub

    Private Sub CalculateExecutionStatusToolStripMenuItem_Click(sender As Object, e As EventArgs)

        TextBox1.Text = "DARP #"
        TextBox5.Text = "ITRACK #"

        Dim SecondForm As New Form2
        SecondForm.Show()
    End Sub

    Private Sub CheckOnAutomationStatusToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TextBox1.Text = "DARP #"
        TextBox5.Text = "ITRACK #"
        System.Diagnostics.Process.Start("http://qeta-jenkins.web.att.com/")
    End Sub

    Private Sub CheckAutomationDevices5979ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://qeta-ws.web.att.com/DevServerScannedDevices")
    End Sub

    Private Sub QECMACWEBSITEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC")
    End Sub

    Private Sub AutomationHomepageToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/QETestAutomation")
    End Sub

    Private Sub AutomationInstallGuideToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/QETestAutomation/SitePages/Installation-Guides-And-other-Valuable-Links.aspx")
    End Sub

    Private Sub ProvideFeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start(String.Format("mailto:ma540x@att.com?subject=Feedback/Suggestions%20for%20Mikhails%20Helper%20Tool&body="))



    End Sub

    Private Sub MenuStrip5_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Public Sub ITrack1ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If ITrack1ToolStripMenuItem.Checked = True Then
            ITrack1ToolStripMenuItem.Checked = False
            ITrack2ToolStripMenuItem.Checked = True
        Else ITrack1ToolStripMenuItem.Checked = True
            ITrack2ToolStripMenuItem.Checked = False
        End If
    End Sub

    Public Sub ITrack2ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If ITrack2ToolStripMenuItem.Checked = True Then
            ITrack2ToolStripMenuItem.Checked = False
            ITrack1ToolStripMenuItem.Checked = True
        Else ITrack2ToolStripMenuItem.Checked = True
            ITrack1ToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub



    Private Sub MenuStrip5_VisibleChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub WORKLPLACESUPPORTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/etech/Workplace2020/Pages/Support.aspx")
    End Sub

    Private Sub MONTHLYHOURSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.miraclesalad.com/webtools/work_hours_per_month.php")
    End Sub

    Private Sub FIREWALLEXCEPTIONSEFORCToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.e-access.att.com/eforc/requestcenter/index.php")
    End Sub

    Private Sub STORAGEEXCEPTIONToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://attcomm.service-now.com/dlp_policy_excpt_sp?id=dlp_exception_request_home_page")
    End Sub

    Private Sub EXITPROCESSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://hronestop.web.att.com/group/hr-onestop/company-exit-process")
    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripComboBox1_TextUpdate(sender As Object, e As EventArgs)

    End Sub

    Private Sub RETURNLAPTOPSLABELToolStripMenuItem1_Click(sender As Object, e As EventArgs)

        System.Diagnostics.Process.Start("https://askget.web.att.com/depot/depot-logistics-return-device")

    End Sub

    Private Sub TESTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Current Version is: " & My.Application.Deployment.CurrentVersion.ToString())
        ' THIS IS TO DISPLAY PUBLISH VERION NUMBERS

    End Sub

    Private Sub STATUSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TextBox1.Text = "DARP #"
        TextBox5.Text = "ITRACK #"
    End Sub

    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs)
        TextBox1.Text = "DARP #"
        TextBox5.Text = "ITRACK #"
    End Sub





    Private Sub ESIMWAITINGCONFIGURATIONToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/eSIM_Waiting_Config.aspx")
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            Me.Hide()
            NotifyIcon1.BalloonTipText = "Helper App is still running.. Right click on the icon for quick links!"
            NotifyIcon1.ShowBalloonTip(300)
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AODACCESSTOZEPHYRITRACKToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://aod.web.att.com/dashboard")
    End Sub

    Private Sub BUILDINGSECURITYCARDSACCESSToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/cre/buildingsecurity/default.aspx")
    End Sub

    Private Sub MYLOGINSToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://mylogins.cso.att.com/index.cfm")
    End Sub

    Private Sub SERVICEACTIVATIONORDERToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://saorder.sbc.com/Default.aspx")
    End Sub

    Private Sub VPNToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.e-access.att.com/iamportal-prod/rsauser/#/home")
    End Sub

    Private Sub AUTOMATIONHOMEPAGEToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

        System.Diagnostics.Process.Start("http://qeta.web.att.com/")

    End Sub

    Private Sub AUTOMATIONINSTALLGUIDEToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/QETestAutomation/SitePages/Installation-Guides-And-other-Valuable-Links.aspx")

    End Sub

    Private Sub CHECKONAUTOMATIONSTATUSToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://qeta-jenkins.web.att.com/")
    End Sub

    Private Sub ATTPERKSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://attperks.benefithub.com/")
    End Sub

    Private Sub BENEFITSMEDICALVISIONDENTALToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://saml.e-access.att.com/isam/sps/ATTIDPEntity/saml20/logininitial?RequestBinding=HTTPPost&PartnerId=saml.alight.com&Target=https://sso.alight.com/portal%3FpageCd%3DL_YOUR_HEALTH_MATTERS")

    End Sub

    Private Sub BOLTToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://bolt.web.att.com/#!/")

    End Sub

    Private Sub CAPSToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://caps.web.att.com/esm80/#/exp/dashboard")

    End Sub

    Private Sub COUToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://cou.web.att.com/app/#/COU/home")

    End Sub

    Private Sub ECORPToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://ecorplb.sbc.com/irj/portal")

    End Sub

    Private Sub FIDELITYToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://fidelity.com")

    End Sub

    Private Sub HRONESTOPToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.e-access.att.com/hronestop")

    End Sub

    Private Sub INFORTIMEOFFToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://mingle-portal.inforcloudsuite.com/ATT_PRD")

    End Sub

    Private Sub MOBILEIRONMYOWNToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://cou.web.att.com/app/#/BYOD/byodAction/home")

    End Sub

    Private Sub ONBOARDINGRESOURCESToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/Onboarding%20Resources%20(for%20Managers).aspx")

    End Sub

    Private Sub PLEToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://PLE.WEB.ATT.COM/#/home")

    End Sub

    Private Sub PRISMToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://prism.techdev.att.com/request-ui/#/request-search")

    End Sub

    Private Sub SELFSERVICEToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://itoselfservice.it.att.com/SelfService/browserWarning.jsf")

    End Sub

    Private Sub WEBSTRToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://cmpmdt.web.att.com/cmpm/main.cfm")

    End Sub

    Private Sub WEBSTRManagerTimeApprovalToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://cmpm.web.att.com/cmpm/#/supr/TimeReview")

    End Sub


    Private Sub EXITPROCESSToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://hronestop.web.att.com/group/hr-onestop/company-exit-process")

    End Sub

    Private Sub QETIMETRACKERToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://workspace.web.att.com/sites/QualityEngineering1/QE_Time_Tracking/Lists/QE%20Hours/AllItems.aspx")

    End Sub

    Private Sub STRToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.quickbase.com/db/btin2gcna")

    End Sub

    Private Sub WORKHOURSPERMONTHToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.miraclesalad.com/webtools/work_hours_per_month.php")
    End Sub

    Private Sub ATTABBREVIATIONSToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://glossary.web.att.com/home/show#/home")

    End Sub

    Private Sub ATTINSIDERToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://insider.att.com")

    End Sub

    Private Sub ESIMWAITINGCONFIGURATIONToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/eSIM_Waiting_Config.aspx")

    End Sub

    Private Sub MOOSEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://moose.web.att.com")

    End Sub

    Private Sub QECMACHOMEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC")

    End Sub

    Private Sub QEINVENTORYGUIDELINESToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/QE_Inventory_Guidelines.aspx")

    End Sub

    Private Sub TESTERONBOARDINGToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/Onboarding.aspx")

    End Sub

    Private Sub WEBPHONEToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://webphone.att.com/")

    End Sub

    Private Sub ADMINRIGHTSToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://intranet.att.com/elrws/index.php")

    End Sub

    Private Sub IQBARToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://iqbar.web.att.com/")

    End Sub

    Private Sub LEASEROLLToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://desktop.it.att.com/Steps.aspx")

    End Sub

    Private Sub RETURNLAPTOPSLABELToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://askget.web.att.com/depot/depot-logistics-return-device")

    End Sub

    Private Sub FIREWALLEXCEPTIONSEFORCToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.e-access.att.com/eforc/requestcenter/index.php")

    End Sub

    Private Sub HELPDESKToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://servicedesk.it.att.com/toolkit/cdt")

    End Sub

    Private Sub KICCAREATTPrePaidToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://kiccare.tdc.cingular.net/webcc/Access.html")

    End Sub

    Private Sub KOUCricketToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.e-access.att.com/cou/#/KOU/ack")

    End Sub

    Private Sub LABTICKETINGMOBILITYLABSToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://labticketing.web.att.com/am/")

    End Sub

    Private Sub LABTICKETSToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://support.labops.att.com/plugins/servlet/desk/portal/2")

    End Sub

    Private Sub MAGNUMTCETToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://intranet.att.com/project/magnum/")

    End Sub

    Private Sub MEETINGROOMSRESERVATIONSToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.e-access.att.com/ywr/cart")

    End Sub

    Private Sub TELEGENCEToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://atthva.workspaceair.com/catalog-portal/ui#/app-favorite")

    End Sub

    Private Sub WORKPLACESUPPORTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/etech/Workplace2020/Pages/Support.aspx")

    End Sub

    Private Sub ITRACKATTToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://itrack.web.att.com/browse")

    End Sub

    Private Sub ITRACKDARPToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://darp-jira.att.com/projects/DARP/issues")

    End Sub

    Private Sub ZEPHYRToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.yourzephyr.com/flex/html5/release/5391")

    End Sub

    Private Sub ZIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZIPToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.7-zip.org/download.html")
    End Sub

    Private Sub IMAZINGToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://imazing.com/")
    End Sub

    Private Sub VYSORToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

        System.Diagnostics.Process.Start("https://www.vysor.io/")
    End Sub

    Private Sub WINRARToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

        System.Diagnostics.Process.Start("https://www.win-rar.com/download.html?&L=0")
    End Sub

    Private Sub TORCHToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://torch.web.att.com/ui/")
    End Sub

    Private Sub CheckOnProdAutomationDevicesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://qeta-ws.web.att.com/CiServer1ScannedDevices")
    End Sub

    Private Sub CheckOnAutomationStatusDevelopmentJenkinsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://qeta-jenkins.web.att.com/view/%20%20%20Test%20Script%20Development%20Farm/")
    End Sub

    Private Sub CheckOnAutomationDeviceFarmsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://qeta-ws.web.att.com/")
    End Sub

    Private Sub QUICKBASEREQUESTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://directv-9861.quickbase.com/db/bqemycpp4")
    End Sub

    Private Sub CATOWEBSITEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://accessibility.web.att.com/")
    End Sub


    Private Sub RSAToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("shell:appsFolder\RSASecurityLLC.RSASecurIDAuthenticate_1ze70x1yhyay8!App")
    End Sub

    Private Sub APPIUMINSPECTORToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            System.Diagnostics.Process.Start("C:\Program Files\Appium Inspector\Appium Inspector.exe")
        Catch ex As Exception
            MessageBox.Show("Inspector Not Found, Please install it into C:\Program Files\Appium Inspector directory!", "INSPECTOR NOT FOUND")

        End Try


    End Sub

    Private Sub APPIUMSERVERToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim loggedUser As String
        loggedUser = Environment.UserName
        'MessageBox.Show(loggedUser)

        Try
            System.Diagnostics.Process.Start("C:\Users\" + loggedUser + "\AppData\Local\Programs\Appium Server GUI\Appium Server GUI.exe")
        Catch ex As Exception
            MessageBox.Show("Appium Server Not Found, Please install it into C:\Users\%username%\AppData\Local\Programs\Appium Server GUI directory!", "APPIUM SERVER NOT FOUND")

        End Try




    End Sub

    Private Sub GITHUBREPOANDROMEDAToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://github.com/dashboard")
    End Sub

    Private Sub STARTINTELLIJIDEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim folderPath = "C:\Program Files\JetBrains"
        Dim filePath = Directory.GetFiles(folderPath,
                                  "idea64.exe",
                                  SearchOption.AllDirectories).FirstOrDefault()

        If filePath IsNot Nothing Then
            Process.Start(filePath)
        Else
            MessageBox.Show("Couldn't find IntelliJ installed in Program Files directory!")
        End If
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.ExitThread()

    End Sub

    Private Sub AUTOMATIONSHAREPOINTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/QETestAutomation")
    End Sub

    Private Sub AUTOMATIONCERTIFICATIONDEVICESToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://qeta-ws.web.att.com/CiServer1ScannedDevices")
    End Sub

    Private Sub CHECKAUTOMATIONDEVICES5979ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://qeta-ws.web.att.com/DevServerScannedDevices")
    End Sub

    Private Sub PASSWORDRESETSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://support.web.att.com/product/31")
    End Sub

    Private Sub SELFSERVICEPORTALToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://support.web.att.com/")
    End Sub

    Private Sub OFFICIALATTHOLIDAYSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://hronestop.web.att.com/documents/33859/b6f29151-3b89-b2c3-fb94-c79baa732780")
    End Sub

    Private Sub TesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://itoselfservice.it.att.com/SelfService/browserWarning.jsf")
    End Sub

    Private Sub TSSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://attcomm.service-now.com/now/nav/ui/classic/params/target/home.do")
    End Sub

    Private Sub USBEXCEPTIONToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/Shared%20Documents/Forms/AllItems.aspx?id=%2Fsites%2FCMAC%2FShared%20Documents%2FGeneral%2FGuides%2FUSB%20access%20request%20%2D%20ServiceNow%20guide%2Epdf&parent=%2Fsites%2FCMAC%2FShared%20Documents%2FGeneral%2FGuides")
    End Sub

    Private Sub DISKSHAREMANAGEMENTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://saresource.it.att.com/Default.aspx")
    End Sub

    Private Sub ReassignADeviceToAnotherTesterToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start(String.Format("mailto:g18290@att.com?subject=Please%20Reassign%20my%20Device%20to%20a%20different%20Tester&body=Hello,%0d%0aI'd%20like%20to%20request%20a%20that%20my%20below%20device(s)%20be%20reassigned%20to%20a%20different%20tester.%20I'm%20cc'ing%20them%20here%20for%20their%20awareness.%0d%0a%0d%0aDevice:%0d%0aTester:%20%0d%0a%0aThanks!"))
    End Sub

    Private Sub SendEmailToInventoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start(String.Format("mailto:g18290@att.com?subject=%20&body=Hello,%0d%0a%0d%0a%0aThanks!"))

    End Sub

    Private Sub FIELDGLASSToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://saml.e-access.att.com/isam/sps/ATTIDP/saml20/logininitial?RequestBinding=HTTPPost&PartnerId=https://www.fieldglass.com")
    End Sub


    Private Sub DHCPToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://eiss-dhcp.it.att.com/dhcpleaserequest.html")
    End Sub

    Private Sub ATTFOODTRUCKSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://www.bestfoodtrucks.com/lots/at-t-bothell")
    End Sub

    Private Sub AssetsCheckedOutToMeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://qe-inventory.web.att.com/account/view-assets#asset")
    End Sub

    Private Sub CheckOutNewAssetsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://qe-inventory.web.att.com/hardware?page=1&size=100&order=desc&sort=updated_at&search=")
    End Sub

    Private Sub SEARCHFORASPECIFICMODELNUMBERToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form6.Show()
    End Sub

    Private Sub REQUESTADEVICEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start(String.Format("mailto:g18290@att.com?subject=Device%20Request&body=Hello,%0d%0aI'd%20like%20to%20request%20the%20following%20device(s)%20from%20Inventory:%0d%0a%0d%0aDevice:%0d%0aFirmware%20Version:%0d%0a%0d%0aThanks!"))
    End Sub

    Private Sub REASSIGNDEVICEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start(String.Format("mailto:g18290@att.com?subject=Please%20Reassign%20my%20Device%20to%20a%20different%20Tester&body=Hello,%0d%0aI'd%20like%20to%20request%20a%20that%20my%20below%20device(s)%20be%20reassigned%20to%20a%20different%20tester.%20I'm%20cc'ing%20them%20here%20for%20their%20awareness.%0d%0a%0d%0aDevice:%0d%0aTester:%20%0d%0a%0aThanks!"))
    End Sub

    Private Sub SENDEMAILTOQEINVENTORYToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start(String.Format("mailto:g18290@att.com?subject=%20&body=Hello,%0d%0a%0d%0a%0aThanks!"))
    End Sub

    Private Sub FOTAREQUESTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start(String.Format("mailto:g18290@att.com?subject=FOTA%20Request&body=Hello,%0d%0aI'd%20like%20to%20request%20FOTA%20to%20be%20pushed%20to%20the%20following:%0d%0a%0d%0aDevice:%0d%0aFirmware%20Version:%0d%0aCTN:%0d%0a%0d%0aThanks!"))
    End Sub

    Private Sub MANUALFLASHREQUESTToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Process.Start(String.Format("mailto:g18290@att.com?subject=Manual%20Flash%20Request&body=Hello,%0d%0aI'd%20like%20to%20request%20a%20manual%20flash%20with%20the%20following%20device(s)%20and%20FW:%0d%0a%0d%0aDevice:%0d%0aFirmware%20Version:%0d%0a%0aThanks!"))
    End Sub

    Private Sub CALCULATEMANUALEXECUTIONToolStripMenuItem_Click(sender As Object, e As EventArgs)

        TextBox1.Text = "DARP #"
        TextBox5.Text = "ITRACK #"

        Dim SecondForm As New Form2
        SecondForm.Show()
    End Sub

    Private Sub CHECKONAUTOMATIONDEVICEFARMSHOMEPAGEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://qeta-ws.web.att.com/")
    End Sub

    Private Sub CHECKONAUTOMATIONDEVICESDEVOLPMENTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://qeta-ws.web.att.com/DevServerScannedDevices")
    End Sub

    Private Sub CHECKONAUTOMATIONDEVICESPRODUCTIONToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://qeta-ws.web.att.com/CiServer1ScannedDevices")
    End Sub

    Private Sub CHECKONAUTOMATIONSTATUSDEVELOPMENTJENKINSToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://qeta-jenkins.web.att.com/view/%20%20%20Test%20Script%20Development%20Farm/")
    End Sub

    Private Sub CHECKONAUTOMATIONSTATUSPRODUCITONJENKINSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TextBox1.Text = "DARP #"
        TextBox5.Text = "ITRACK #"
        System.Diagnostics.Process.Start("http://qeta-jenkins.web.att.com/")
    End Sub

    Private Sub QEINVENTORYGUIDELINESToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/QE_Inventory_Guidelines.aspx")
    End Sub
    Private Sub TEST3ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://qeta-jenkins.web.att.com/")
    End Sub

    Private Sub TEST4ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://qeta-jenkins.web.att.com/view/%20%20%20Test%20Script%20Development%20Farm/")
    End Sub

    'Private Sub TEST1ToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    System.Diagnostics.Process.Start("http://qeta-ws.web.att.com/")
    'End Sub

    Private Sub SEEALLCRICKETASSETSININVENTORYToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://qe-inventory.web.att.com/categories/4?page=1&size=100&order=desc&search=&sort=updated_at")
    End Sub

    Private Sub QEAssetManagerInfoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/Asset-manager.aspx")
    End Sub

    Private Sub ReadAssetSiteInfoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/Asset-manager.aspx")
    End Sub

    Private Sub SOFTWARECENTERToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try
            System.Diagnostics.Process.Start("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Configuration Manager\Configuration Manager\Software Center.lnk")
        Catch ex As Exception
            MessageBox.Show("Software Center Not Found!", "SOFTWARE CENTER NOT FOUND")

        End Try

    End Sub

    Private Sub ASKATTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASKATTToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://ask.web.att.com/")
    End Sub

    Private Sub ECAMHELPDESKFIELDGLASSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ECAMHELPDESKFIELDGLASSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://attonestop.custhelp.com/app/products/eCAM/p/2044")
    End Sub


    Private Sub SSQUICKREFERENCEGUIDEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://hronestop.web.att.com/documents/33859/fe149c72-f006-8258-64c1-ed606c896540")
    End Sub

    Private Sub NSSQUICKREFERENCEGUIDEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://hronestop.web.att.com/documents/33859/3507151/QRG_NSS_Sponsoring_Manager.pdf/cc95595a-26c7-3a30-4187-517c80bf3a91")
    End Sub

    Private Sub ADMINRIGHTSTEMPToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://intra5.web.att.com/elrws/tab.php?type=TAR")
    End Sub

    Private Sub ABOUTToolStripMenuItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ABOUTMIKHAILSHELPERToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If My.Application.IsNetworkDeployed Then
            'MsgBox(My.Application.Deployment.CurrentVersion.Revision.ToString())
            '  MsgBox(My.Application.Deployment.CurrentVersion.Revision)
            ' MsgBox(My.Application.Deployment.CurrentVersion.ToString())
            MsgBox("*** ABOUT MIKHAIL'S HELPER APP ***" & vbNewLine & vbNewLine & "This app is designed by Mikhail for fun in VB.NET" & vbNewLine & vbNewLine & "Hope this helps you in your daily tasks :)" & vbNewLine & vbNewLine & "Feel free to email me (ma540x@att.com) with any BUGS or SUGGESTIONS!" & vbNewLine & vbNewLine & "CURRENT VERSION INSTALLED IS: " & My.Application.Deployment.CurrentVersion.ToString())
        End If
    End Sub

    Private Sub SHAREPOINTSITEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/Mikhail%27s_Helper_Tool.aspx")
    End Sub

    Private Sub PROVIDEFEEDBACKToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Process.Start(String.Format("mailto:ma540x@att.com?subject=Feedback/Suggestions%20for%20Mikhails%20Helper%20Tool&body="))
    End Sub

    Private Sub SHARETHISAPPToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Process.Start(String.Format("mailto:?subject=Check%20out%20this%20app!&body=Hiya,%0d%0aCheck%20out%20this%20app:%20https://att.sharepoint.com/sites/CMAC/SitePages/Mikhail%27s_Helper_Tool.aspx%0d%0a%0d%0aThanks!"))


    End Sub

    Private Sub ATTSHAREPOINTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("https://att-my.sharepoint.com/my")
    End Sub

    Private Sub ToolStripSeparator117_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem8_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub SetITrackProjectToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles SetITrackProjectToolStripMenuItem1.Click
        Form5.Show()
    End Sub

    Private Sub AlwaysOnTOPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlwaysOnTOPToolStripMenuItem.Click

    End Sub

    Private Sub EnableToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EnableToolStripMenuItem.Click
        Me.TopMost = True
    End Sub

    Private Sub DisableToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DisableToolStripMenuItem.Click
        Me.TopMost = False
    End Sub

    Private Sub ProvideFeedbackToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ProvideFeedbackToolStripMenuItem.Click
        Process.Start(String.Format("mailto:ma540x@att.com?subject=Feedback%20on%20Mikhails%20Helper%20Tool&body="))
    End Sub

    Private Sub CheckForUpdateToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CheckForUpdateToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/Mikhail%27s_Helper_Tool.aspx")
    End Sub

    Private Sub ShareThisAppToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ShareThisAppToolStripMenuItem.Click
        Process.Start(String.Format("mailto:?subject=Check%20out%20this%20app!&body=Hiya,%0d%0aCheck%20out%20this%20app:%20https://att.sharepoint.com/sites/CMAC/SitePages/Mikhail%27s_Helper_Tool.aspx%0d%0a%0d%0aThanks!"))

    End Sub

    Private Sub VersionNumberToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles VersionNumberToolStripMenuItem.Click
        If My.Application.IsNetworkDeployed Then
            MsgBox("*** ABOUT MIKHAIL'S HELPER APP ***" & vbNewLine & vbNewLine & "This app is designed by Mikhail for fun in VB.NET" & vbNewLine & vbNewLine & "Hope this helps you in your daily tasks :)" & vbNewLine & vbNewLine & "Feel free to email me (ma540x@att.com) with any BUGS or SUGGESTIONS!" & vbNewLine & vbNewLine & "CURRENT VERSION INSTALLED IS: " & My.Application.Deployment.CurrentVersion.ToString())
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myApp As Process() = Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName)
        For Each app In myApp
            If app.Id <> Process.GetCurrentProcess.Id Then
                With app
                    .CloseMainWindow()
                End With
            End If
        Next


        NotifyIcon1.Visible = True

        DateLabel.Text = Date.Today.ToString("MM/dd")
        ' "MMM ddd d HH:mm yyyy"
        DayLabel.Text = DateTime.Now.ToString("dddd")
        'DayLabel.Text = Date.Today.ToString("ddddd")
        DayLabel.Text = DayLabel.Text.ToUpper()

        ITrack1ToolStripMenuItem.Text = My.Settings.iTrackKey1
        ITrack2ToolStripMenuItem.Text = My.Settings.iTrackKey2


        If My.Settings.iTrackKey1 = "TBD" Then
        Else
            ITrack1ToolStripMenuItem.Checked = True
        End If

    End Sub

    Private Sub Test2ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles Test2ToolStripMenuItem1.Click
        Process.Start(String.Format("mailto:g18290@att.com?subject=Device%20Request&body=Hello,%0d%0aI'd%20like%20to%20request%20the%20following%20device(s)%20from%20Inventory:%0d%0a%0d%0aDevice:%0d%0aFirmware%20Version:%0d%0a%0d%0aThanks!"))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click

    End Sub

    Private Sub AODACCESSTOZEPHYRITRACKToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles AODACCESSTOZEPHYRITRACKToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://aod.web.att.com/dashboard")

    End Sub

    Private Sub ADMINRIGHTSTEMPToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ADMINRIGHTSTEMPToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://intranet.att.com/elrws/index.php")
    End Sub

    Private Sub BUILDINGSECURITYCARDSACCESSToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles BUILDINGSECURITYCARDSACCESSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/cre/buildingsecurity/default.aspx")

    End Sub

    Private Sub MYLOGINSToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles MYLOGINSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://mylogins.cso.att.com/index.cfm")

    End Sub

    Private Sub PASSWORDRESETSToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PASSWORDRESETSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://support.web.att.com/product/31")

    End Sub

    Private Sub RSAToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RSAToolStripMenuItem.Click
        System.Diagnostics.Process.Start("shell:appsFolder\RSASecurityLLC.RSASecurIDAuthenticate_1ze70x1yhyay8!App")
    End Sub

    Private Sub SERVICEACTIVATIONORDERToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles SERVICEACTIVATIONORDERToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://saorder.sbc.com/Default.aspx")


    End Sub

    Private Sub SELFSERVICEPORTALToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SELFSERVICEPORTALToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://support.web.att.com/")
    End Sub

    Private Sub USBEXCEPTIONToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles USBEXCEPTIONToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/Shared%20Documents/Forms/AllItems.aspx?id=%2Fsites%2FCMAC%2FShared%20Documents%2FGeneral%2FGuides%2FUSB%20access%20request%20%2D%20ServiceNow%20guide%2Epdf&parent=%2Fsites%2FCMAC%2FShared%20Documents%2FGeneral%2FGuides")
    End Sub

    Private Sub VPNToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles VPNToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.e-access.att.com/iamportal-prod/rsauser/#/home")
    End Sub

    Private Sub AUTOMATIONSHAREPOINTToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AUTOMATIONSHAREPOINTToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/QETestAutomation")
    End Sub

    Private Sub AUTOMATIONINSTALLGUIDEToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles AUTOMATIONINSTALLGUIDEToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/QETestAutomation/SitePages/Installation-Guides-And-other-Valuable-Links.aspx")
    End Sub

    Private Sub TEST1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TEST1ToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://qeta-ws.web.att.com/")
    End Sub

    Private Sub CHECKAUTOMATIONDEVICES5979ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles CHECKAUTOMATIONDEVICES5979ToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("http://qeta-ws.web.att.com/DevServerScannedDevices")

    End Sub

    Private Sub AUTOMATIONCERTIFICATIONDEVICESToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AUTOMATIONCERTIFICATIONDEVICESToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://qeta-ws.web.att.com/CiServer1ScannedDevices")

    End Sub

    Private Sub TEST4ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TEST4ToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://qeta-jenkins.web.att.com/view/%20%20%20Test%20Script%20Development%20Farm/")
    End Sub

    Private Sub TEST3ToolStripMenuItem2_Click_1(sender As Object, e As EventArgs) Handles TEST3ToolStripMenuItem2.Click
        System.Diagnostics.Process.Start("http://qeta-jenkins.web.att.com/")

    End Sub

    Private Sub AUTOMATIONHOMEPAGEToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles AUTOMATIONHOMEPAGEToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/QETestAutomation")

    End Sub

    Private Sub GITHUBREPOANDROMEDAToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles GITHUBREPOANDROMEDAToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://github.com/dashboard")
    End Sub

    Private Sub APPIUMINSPECTORToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles APPIUMINSPECTORToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("C:\Program Files\Appium Inspector\Appium Inspector.exe")
        Catch ex As Exception
            MessageBox.Show("Inspector Not Found, Please install it into C:\Program Files\Appium Inspector directory!", "INSPECTOR NOT FOUND")

        End Try


    End Sub

    Private Sub APPIUMSERVERToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles APPIUMSERVERToolStripMenuItem.Click
        Dim loggedUser As String
        loggedUser = Environment.UserName
        'MessageBox.Show(loggedUser)

        Try
            System.Diagnostics.Process.Start("C:\Users\" + loggedUser + "\AppData\Local\Programs\Appium Server GUI\Appium Server GUI.exe")
        Catch ex As Exception
            MessageBox.Show("Appium Server Not Found, Please install it into C:\Users\%username%\AppData\Local\Programs\Appium Server GUI directory!", "APPIUM SERVER NOT FOUND")

        End Try

    End Sub

    Private Sub STARTINTELLIJIDEToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles STARTINTELLIJIDEToolStripMenuItem.Click
        Dim folderPath = "C:\Program Files\JetBrains"
        Dim filePath = Directory.GetFiles(folderPath,
                                  "idea64.exe",
                                  SearchOption.AllDirectories).FirstOrDefault()

        If filePath IsNot Nothing Then
            Process.Start(filePath)
        Else
            MessageBox.Show("Couldn't find IntelliJ installed in Program Files directory!")
        End If

    End Sub

    Private Sub ITRACKATTToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles ITRACKATTToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://itrack.web.att.com/browse")

    End Sub

    Private Sub ITRACKDARPToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles ITRACKDARPToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://darp-jira.att.com/projects/DARP/issues")

    End Sub

    Private Sub ZEPHYRToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles ZEPHYRToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.yourzephyr.com/flex/html5/release/5391")

    End Sub

    Private Sub ATTPERKSToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ATTPERKSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://attperks.benefithub.com/")

    End Sub

    Private Sub BENEFITSMEDICALVISIONDENTALToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles BENEFITSMEDICALVISIONDENTALToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://saml.e-access.att.com/isam/sps/ATTIDPEntity/saml20/logininitial?RequestBinding=HTTPPost&PartnerId=saml.alight.com&Target=https://sso.alight.com/portal%3FpageCd%3DL_YOUR_HEALTH_MATTERS")

    End Sub

    Private Sub BOLTToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles BOLTToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://bolt.web.att.com/#!/")
    End Sub

    Private Sub CAPSToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles CAPSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://caps.web.att.com/esm80/#/exp/dashboard")

    End Sub

    Private Sub COUToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles COUToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://cou.web.att.com/app/#/COU/home")
    End Sub

    Private Sub DHCPToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DHCPToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://eiss-dhcp.it.att.com/dhcpleaserequest.html")

    End Sub

    Private Sub DISKSHAREMANAGEMENTToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DISKSHAREMANAGEMENTToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://saresource.it.att.com/Default.aspx")

    End Sub

    Private Sub ECORPToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles ECORPToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://ecorplb.sbc.com/irj/portal")

    End Sub

    Private Sub FIDELITYToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles FIDELITYToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://fidelity.com")

    End Sub

    Private Sub FIELDGLASSToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles FIELDGLASSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://saml.e-access.att.com/isam/sps/ATTIDP/saml20/logininitial?RequestBinding=HTTPPost&PartnerId=https://www.fieldglass.com")

    End Sub

    Private Sub HRONESTOPToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles HRONESTOPToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.e-access.att.com/hronestop")

    End Sub

    Private Sub INFORTIMEOFFToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles INFORTIMEOFFToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://mingle-portal.inforcloudsuite.com/ATT_PRD")

    End Sub

    Private Sub MOBILEIRONMYOWNToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles MOBILEIRONMYOWNToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://cou.web.att.com/app/#/BYOD/byodAction/home")

    End Sub

    Private Sub ONBOARDINGRESOURCESToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles ONBOARDINGRESOURCESToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/Onboarding%20Resources%20(for%20Managers).aspx")

    End Sub

    Private Sub PLEToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles PLEToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://PLE.WEB.ATT.COM/#/home")

    End Sub

    Private Sub PRISMToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles PRISMToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://prism.techdev.att.com/request-ui/#/request-search")

    End Sub

    Private Sub QUICKBASEREQUESTToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles QUICKBASEREQUESTToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://directv-9861.quickbase.com/db/bqemycpp4")
    End Sub

    Private Sub SSQUICKREFERENCEGUIDEToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SSQUICKREFERENCEGUIDEToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://hronestop.web.att.com/documents/33859/fe149c72-f006-8258-64c1-ed606c896540")

    End Sub

    Private Sub NSSQUICKREFERENCEGUIDEToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NSSQUICKREFERENCEGUIDEToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://hronestop.web.att.com/documents/33859/3507151/QRG_NSS_Sponsoring_Manager.pdf/cc95595a-26c7-3a30-4187-517c80bf3a91")
    End Sub

    Private Sub ATTSHAREPOINTToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ATTSHAREPOINTToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att-my.sharepoint.com/my")
    End Sub

    Private Sub OFFICIALATTHOLIDAYSToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OFFICIALATTHOLIDAYSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://hronestop.web.att.com/documents/33859/b6f29151-3b89-b2c3-fb94-c79baa732780")
    End Sub

    Private Sub ATTABBREVIATIONSToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles ATTABBREVIATIONSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://glossary.web.att.com/home/show#/home")

    End Sub

    Private Sub ATTINSIDERToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles ATTINSIDERToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://insider.att.com")
    End Sub

    Private Sub CATOWEBSITEToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CATOWEBSITEToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://accessibility.web.att.com/")
    End Sub

    Private Sub ESIMWAITINGCONFIGURATIONToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles ESIMWAITINGCONFIGURATIONToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/eSIM_Waiting_Config.aspx")
    End Sub

    Private Sub ATTFOODTRUCKSToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ATTFOODTRUCKSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.bestfoodtrucks.com/lots/at-t-bothell")

    End Sub

    Private Sub MOOSEToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles MOOSEToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://moose.web.att.com")


    End Sub

    Private Sub QECMACHOMEToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles QECMACHOMEToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC")

    End Sub

    Private Sub QEINVENTORYGUIDELINESToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles QEINVENTORYGUIDELINESToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/QE_Inventory_Guidelines.aspx")
    End Sub

    Private Sub SOFTWARECENTERToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SOFTWARECENTERToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Microsoft Configuration Manager\Configuration Manager\Software Center.lnk")
        Catch ex As Exception
            MessageBox.Show("Software Center Not Found!", "SOFTWARE CENTER NOT FOUND")

        End Try

    End Sub

    Private Sub TESTERONBOARDINGToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles TESTERONBOARDINGToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/Onboarding.aspx")
    End Sub

    Private Sub WEBPHONEToolStripMenuItem_Click_2(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://webphone.att.com/")

    End Sub

    Private Sub QETIMETRACKERToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles QETIMETRACKERToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://workspace.web.att.com/sites/QualityEngineering1/QE_Time_Tracking/Lists/QE%20Hours/AllItems.aspx")
    End Sub

    Private Sub STRToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles STRToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.quickbase.com/db/btin2gcna")

    End Sub

    Private Sub WORKHOURSPERMONTHToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles WORKHOURSPERMONTHToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.calendar-12.com/working_days/2024")

    End Sub

    Private Sub AssetsCheckedOutToMeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AssetsCheckedOutToMeToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://qe-inventory.web.att.com/account/view-assets#asset")
    End Sub

    Private Sub SEARCHFORASPECIFICMODELNUMBERToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SEARCHFORASPECIFICMODELNUMBERToolStripMenuItem.Click
        Form6.Show()
    End Sub

    Private Sub CheckOutNewAssetsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CheckOutNewAssetsToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://qe-inventory.web.att.com/hardware?page=1&size=100&order=desc&sort=updated_at&search=")
    End Sub

    Private Sub SEEALLCRICKETASSETSININVENTORYToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SEEALLCRICKETASSETSININVENTORYToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://qe-inventory.web.att.com/categories/4?page=1&size=100&order=desc&search=&sort=updated_at")
    End Sub

    Private Sub REQUESTADEVICEToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles REQUESTADEVICEToolStripMenuItem.Click
        Process.Start(String.Format("mailto:g18290@att.com?subject=Device%20Request&body=Hello,%0d%0aI'd%20like%20to%20request%20the%20following%20device(s)%20from%20Inventory:%0d%0a%0d%0aDevice:%0d%0aFirmware%20Version:%0d%0a%0d%0aThanks!"))
    End Sub

    Private Sub FOTAREQUESTToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FOTAREQUESTToolStripMenuItem.Click
        Process.Start(String.Format("mailto:g18290@att.com?subject=FOTA%20Request&body=Hello,%0d%0aI'd%20like%20to%20request%20FOTA%20to%20be%20pushed%20to%20the%20following:%0d%0a%0d%0aDevice:%0d%0aFirmware%20Version:%0d%0aCTN:%0d%0a%0d%0aThanks!"))
    End Sub

    Private Sub REASSIGNDEVICEToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles REASSIGNDEVICEToolStripMenuItem.Click
        Process.Start(String.Format("mailto:g18290@att.com?subject=Please%20Reassign%20my%20Device%20to%20a%20different%20Tester&body=Hello,%0d%0aI'd%20like%20to%20request%20a%20that%20my%20below%20device(s)%20be%20reassigned%20to%20a%20different%20tester.%20I'm%20cc'ing%20them%20here%20for%20their%20awareness.%0d%0a%0d%0aDevice:%0d%0aTester:%20%0d%0a%0aThanks!"))

    End Sub

    Private Sub MANUALFLASHREQUESTToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles MANUALFLASHREQUESTToolStripMenuItem1.Click
        Process.Start(String.Format("mailto:g18290@att.com?subject=Manual%20Flash%20Request&body=Hello,%0d%0aI'd%20like%20to%20request%20a%20manual%20flash%20with%20the%20following%20device(s)%20and%20FW:%0d%0a%0d%0aDevice:%0d%0aFirmware%20Version:%0d%0a%0aThanks!"))
    End Sub

    Private Sub SENDEMAILTOQEINVENTORYToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SENDEMAILTOQEINVENTORYToolStripMenuItem.Click
        Process.Start(String.Format("mailto:g18290@att.com?subject=%20&body=Hello,%0d%0a%0d%0a%0aThanks!"))
    End Sub

    Private Sub QEAssetManagerInfoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles QEAssetManagerInfoToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/Asset-manager.aspx")
    End Sub

    Private Sub QEINVENTORYGUIDELINESToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles QEINVENTORYGUIDELINESToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/QE_Inventory_Guidelines.aspx")

    End Sub

    Private Sub ADMINRIGHTSToolStripMenuItem_Click_2(sender As Object, e As EventArgs)
        System.Diagnostics.Process.Start("http://intranet.att.com/elrws/index.php")


    End Sub

    Private Sub IQBARToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles IQBARToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://iqbar.web.att.com/Locations/Details/3")
    End Sub

    Private Sub LEASEROLLToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles LEASEROLLToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://iqsupport.att.com/")

    End Sub

    Private Sub RETURNLAPTOPSLABELToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles RETURNLAPTOPSLABELToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://askget.web.att.com/depot/depot-logistics-return-device")
    End Sub

    Private Sub TesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TesToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://itoselfservice.it.att.com/SelfService/browserWarning.jsf")

    End Sub

    Private Sub CALCULATEMANUALEXECUTIONToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CALCULATEMANUALEXECUTIONToolStripMenuItem.Click
        TextBox1.Text = "DARP #"
        TextBox5.Text = "ITRACK #"

        Dim SecondForm As New Form2
        SecondForm.Show()

    End Sub

    Private Sub FIREWALLEXCEPTIONSEFORCToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles FIREWALLEXCEPTIONSEFORCToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.e-access.att.com/eforc/requestcenter/index.php")

    End Sub

    Private Sub HELPDESKToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles HELPDESKToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://servicedesk.it.att.com/toolkit/cdt")

    End Sub

    Private Sub KICCAREATTPrePaidToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles KICCAREATTPrePaidToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://kiccare.tdc.cingular.net/webcc/Access.html")

    End Sub

    Private Sub KOUCricketToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles KOUCricketToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.e-access.att.com/cou/#/KOU/ack")

    End Sub

    Private Sub LABTICKETINGMOBILITYLABSToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles LABTICKETINGMOBILITYLABSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://labticketing.web.att.com/am/")
    End Sub

    Private Sub LABTICKETSToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles LABTICKETSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://support.labops.att.com/plugins/servlet/desk/portal/2")
    End Sub

    Private Sub MAGNUMTCETToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles MAGNUMTCETToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://intranet.att.com/project/magnum/")
    End Sub

    Private Sub MEETINGROOMSRESERVATIONSToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles MEETINGROOMSRESERVATIONSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://www.e-access.att.com/ywr/cart")

    End Sub

    Private Sub TELEGENCEToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles TELEGENCEToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://atthva.workspaceair.com/catalog-portal/ui#/app-favorite")
    End Sub

    Private Sub TORCHToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TORCHToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://torch.web.att.com/ui/")

    End Sub

    Private Sub TSSToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles TSSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://attcomm.service-now.com/now/nav/ui/classic/params/target/home.do")
    End Sub

    Private Sub WORKPLACESUPPORTToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles WORKPLACESUPPORTToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/etech/Workplace2020/Pages/Support.aspx")

    End Sub

    Private Sub ABOUTMIKHAILSHELPERToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ABOUTMIKHAILSHELPERToolStripMenuItem.Click
        If My.Application.IsNetworkDeployed Then
            'MsgBox(My.Application.Deployment.CurrentVersion.Revision.ToString())
            '  MsgBox(My.Application.Deployment.CurrentVersion.Revision)
            ' MsgBox(My.Application.Deployment.CurrentVersion.ToString())
            MsgBox("*** ABOUT MIKHAIL'S HELPER APP ***" & vbNewLine & vbNewLine & "This app is designed by Mikhail for fun in VB.NET" & vbNewLine & vbNewLine & "Hope this helps you in your daily tasks :)" & vbNewLine & vbNewLine & "Feel free to email me (ma540x@att.com) with any BUGS or SUGGESTIONS!" & vbNewLine & vbNewLine & "CURRENT VERSION INSTALLED IS: " & My.Application.Deployment.CurrentVersion.ToString())
        End If

    End Sub

    Private Sub PROVIDEFEEDBACKToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles PROVIDEFEEDBACKToolStripMenuItem1.Click
        Process.Start(String.Format("mailto:ma540x@att.com?subject=Feedback/Suggestions%20for%20Mikhails%20Helper%20Tool&body="))
    End Sub

    Private Sub SHAREPOINTSITEToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SHAREPOINTSITEToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/Mikhail%27s_Helper_Tool.aspx")

    End Sub

    Private Sub SHARETHISAPPToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles SHARETHISAPPToolStripMenuItem1.Click
        Process.Start(String.Format("mailto:?subject=Check%20out%20this%20app!&body=Hiya,%0d%0aCheck%20out%20this%20app:%20https://att.sharepoint.com/sites/CMAC/SitePages/Mikhail%27s_Helper_Tool.aspx%0d%0a%0d%0aThanks!"))


    End Sub

    Private Sub EXITToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Application.ExitThread()
    End Sub

    Private Sub WEBSTRToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles WEBSTRToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://cmpmdt.web.att.com/cmpm/main.cfm")

    End Sub

    Private Sub WEBSTRManagerTimeApprovalToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles WEBSTRManagerTimeApprovalToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://cmpm.web.att.com/cmpm/#/supr/TimeReview")

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        '  TimeLabel.Text = Format(Now, "yyyy-MM-dd hh:mm:ss")
        ' TimeLabel.Text = DateTime.Now.ToString("hh:mm tt")
        TimeLabel.Text = DateTime.Now.ToString("hh:mm").TrimStart("0"c)
        DayLabel.Text = DateTime.Now.ToString("dddd")
        DayLabel.Text = DayLabel.Text.ToUpper()
        ampm_Label.Text = DateTime.Now.ToString("tt")
        DateLabel.Text = Date.Today.ToString("MM/dd")
        '  TimeLabel.Text = TimeString

    End Sub

    Private Sub CalculateExecutionStatusToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CalculateExecutionStatusToolStripMenuItem.Click
        TextBox1.Text = "DARP #"
        TextBox5.Text = "ITRACK #"

        Dim SecondForm As New Form2
        SecondForm.Show()

    End Sub

    Private Sub CheckOnAutomationDeviceFarmsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CheckOnAutomationDeviceFarmsToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://qeta-ws.web.att.com/")

    End Sub

    Private Sub CheckAutomationDevices5979ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CheckAutomationDevices5979ToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://qeta-ws.web.att.com/DevServerScannedDevices")
    End Sub

    Private Sub CheckOnProdAutomationDevicesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CheckOnProdAutomationDevicesToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://qeta-ws.web.att.com/CiServer1ScannedDevices")
    End Sub

    Private Sub CheckOnAutomationStatusDevelopmentJenkinsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CheckOnAutomationStatusDevelopmentJenkinsToolStripMenuItem.Click
        System.Diagnostics.Process.Start("http://qeta-jenkins.web.att.com/view/%20%20%20Test%20Script%20Development%20Farm/")

    End Sub

    Private Sub CheckOnAutomationStatusToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CheckOnAutomationStatusToolStripMenuItem.Click
        TextBox1.Text = "DARP #"
        TextBox5.Text = "ITRACK #"
        System.Diagnostics.Process.Start("http://qeta-jenkins.web.att.com/")

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub Button7_Click_2(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("https://itrack.web.att.com/browse")
        TextBox1.Text = "DARP #"
        TextBox5.Text = "iTRACK #"
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        If (TextBox1.Text = "" Or TextBox1.Text = "DARP #") Then
            MessageBox.Show("Please enter a DARP defect number.")
        Else

            System.Diagnostics.Process.Start("https://darp-jira.att.com/browse/DARP-" + TextBox1.Text)

        End If
        TextBox1.Text = "DARP #"

    End Sub

    Private Sub Button5_Click_2(sender As Object, e As EventArgs) Handles Button5.Click
        ' If (TextBox5.Text = "" Or TextBox5.Text = "iTrack #") Then
        ' MessageBox.Show("Please enter an iTrack defect number.")
        ' ElseIf My.Settings.iTrackKey1 = "TBD" Then
        ' MessageBox.Show("Please set an iTrack KEY for your Project in Settings")
        ' Else
        ' End If

        If ITrack1ToolStripMenuItem.Checked = True AndAlso Not TextBox5.Text = "iTRACK #" AndAlso Not TextBox5.Text = "" Then
            '  System.Diagnostics.Process.Start("https://itrack.web.att.com/browse/" + TextBox5.Text)
            System.Diagnostics.Process.Start("https://itrack.web.att.com/browse/" + My.Settings.iTrackKey1 + "-" + TextBox5.Text)
        ElseIf ITrack1ToolStripMenuItem.Checked = True And TextBox5.Text = "iTRACK #" Then
            MessageBox.Show("Please enter an iTRACK defect number.")
        ElseIf ITrack2ToolStripMenuItem.Checked = True AndAlso Not TextBox5.Text = "iTRACK #" AndAlso Not TextBox5.Text = "" Then
            System.Diagnostics.Process.Start("https://itrack.web.att.com/browse/" + My.Settings.iTrackKey2 + "-" + TextBox5.Text)
        ElseIf ITrack2ToolStripMenuItem.Checked = True And TextBox5.Text = "iTRACK #" Then
            MessageBox.Show("Please enter an iTRACK defect number.")
            ' Else MsgBox("Please select an iTrack project from the drop down")
            ' Else System.Diagnostics.Process.Start("https://itrack.web.att.com/browse/" + My.Settings.iTrackKey1 + "-" + TextBox5.Text)
        ElseIf (TextBox5.Text = "" Or TextBox5.Text = "iTRACK #") Then
            MessageBox.Show("Please enter an iTRACK defect number.")
        Else

            MsgBox("Please perform the following.. " & vbNewLine & vbNewLine & "FIRST: set an ITRACK Key for your Project in Settings (Gear icon bottom left corner of the app)" & vbNewLine & vbNewLine & "SECOND: select a iTrack Key from the dropdown next to GO button " & vbNewLine & vbNewLine & "*** All this has to happen once ***" & vbNewLine & vbNewLine & "You can add up to 2 iTracks, you are able to switch between them on the fly next to the GO button. Enjoy!")
        End If

        TextBox5.Text = "iTRACK #"

    End Sub

    Private Sub ITrack1ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ITrack1ToolStripMenuItem.Click
        If ITrack1ToolStripMenuItem.Checked = True Then
            ITrack1ToolStripMenuItem.Checked = False
            ITrack2ToolStripMenuItem.Checked = True
        Else ITrack1ToolStripMenuItem.Checked = True
            ITrack2ToolStripMenuItem.Checked = False
        End If
    End Sub



    Private Sub ITrack2ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ITrack2ToolStripMenuItem.Click

        If ITrack2ToolStripMenuItem.Checked = True Then
            ITrack2ToolStripMenuItem.Checked = False
            ITrack1ToolStripMenuItem.Checked = True
        Else ITrack2ToolStripMenuItem.Checked = True
            ITrack1ToolStripMenuItem.Checked = False
        End If


    End Sub

    Private Sub TextBox5_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox5_GotFocus(sender As Object, e As EventArgs) Handles TextBox5.GotFocus
        TextBox5.Text = ""
        TextBox1.Text = "DARP #"
    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.Text = ""
        TextBox5.Text = "ITRACK #"
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter only numbers")
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Please enter only numbers")
        End If

    End Sub

    Private Sub STATUSToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles STATUSToolStripMenuItem.Click
        TextBox1.Text = "DARP #"
        TextBox5.Text = "iTRACK #"
    End Sub

    Private Sub TestToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles TestToolStripMenuItem1.Click
        TextBox1.Text = "DARP #"
        TextBox5.Text = "iTRACK #"
    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles Label1.Click
        TextBox1.Text = "DARP #"
        TextBox5.Text = "iTRACK #"
    End Sub

    Dim firstX As Integer
    Dim firstY As Integer
    Dim lbuttonDown As Boolean

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Me.TopMost = True Then
            Me.TopMost = False
        ElseIf Me.TopMost = False Then
            Me.TopMost = True

        End If

    End Sub

    Private Sub Test3ToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles Test3ToolStripMenuItem.Click
        Process.Start(String.Format("mailto:g18290@att.com?subject=FOTA%20Request&body=Hello,%0d%0aI'd%20like%20to%20request%20FOTA%20to%20be%20pushed%20to%20the%20following:%0d%0a%0d%0aDevice:%0d%0aFirmware%20Version:%0d%0aCTN:%0d%0a%0d%0aThanks!"))

    End Sub

    Private Sub ManualFlashRequestToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ManualFlashRequestToolStripMenuItem.Click
        Process.Start(String.Format("mailto:g18290@att.com?subject=Manual%20Flash%20Request&body=Hello,%0d%0aI'd%20like%20to%20request%20a%20manual%20flash%20with%20the%20following%20device(s)%20and%20FW:%0d%0a%0d%0aDevice:%0d%0aFirmware%20Version:%0d%0a%0aThanks!"))

    End Sub

    Private Sub ReassignADeviceToAnotherTesterToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReassignADeviceToAnotherTesterToolStripMenuItem.Click
        Process.Start(String.Format("mailto:g18290@att.com?subject=Please%20Reassign%20my%20Device%20to%20a%20different%20Tester&body=Hello,%0d%0aI'd%20like%20to%20request%20a%20that%20my%20below%20device(s)%20be%20reassigned%20to%20a%20different%20tester.%20I'm%20cc'ing%20them%20here%20for%20their%20awareness.%0d%0a%0d%0aDevice:%0d%0aTester:%20%0d%0a%0aThanks!"))

    End Sub

    Private Sub SendEmailToInventoryToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SendEmailToInventoryToolStripMenuItem.Click
        Process.Start(String.Format("mailto:g18290@att.com?subject=%20&body=Hello,%0d%0a%0d%0a%0aThanks!"))

    End Sub

    Private Sub ReadAssetSiteInfoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReadAssetSiteInfoToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/Asset-manager.aspx")
    End Sub

    Private Sub ReadInventoryGuidelinesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReadInventoryGuidelinesToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://att.sharepoint.com/sites/CMAC/SitePages/QE_Inventory_Guidelines.aspx")
    End Sub

    Private Sub EXITPROCESSToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles EXITPROCESSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://hronestop.web.att.com/group/hr-onestop/company-exit-process")
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub


    Private Sub STRTUTORIALSTIMEREPORTINGToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles STRTUTORIALSTIMEREPORTINGToolStripMenuItem1.Click
        System.Diagnostics.Process.Start("https://wiki.web.att.com/pages/viewpage.action?pageId=2178388367")
    End Sub

    Private Sub ITRACKTROUBLETICKETToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ITRACKTROUBLETICKETToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://itrack.web.att.com/secure/CreateIssue.jspa?issuetype=17&pid=51253")
    End Sub

    Private Sub MenuStrip3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip3.ItemClicked

    End Sub

    Private Sub EnabledToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnabledToolStripMenuItem.Click
        'Dim startupPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Startup)
        'Dim shortcutPath As String = Path.Combine(startupPath, "Mikhails_Helper_Tool_V1.lnk")
        MessageBox.Show("Setting this app to start with Windows")
        SetStartup()

    End Sub

    Private Sub DisabledToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisabledToolStripMenuItem.Click
        MessageBox.Show("Removing this app from starting with Windows")
        RemoveStartup()
    End Sub

    Private Sub SetStartup()
        Try
            Dim rk As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            rk.SetValue("MikhailsHelperTool", Application.ExecutablePath)
        Catch ex As Exception
            MessageBox.Show("Failed to set startup: " & ex.Message)
        End Try
    End Sub

    Private Sub RemoveStartup()
        Try
            Dim rk As RegistryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
            rk.DeleteValue("MikhailsHelperTool", False)
        Catch ex As Exception
            MessageBox.Show("Failed to remove startup: " & ex.Message)
        End Try
    End Sub

    Private Sub MYWEPHONEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MYWEPHONEToolStripMenuItem.Click

        Dim loggedUser As String
        loggedUser = Environment.UserName

        System.Diagnostics.Process.Start("https://webphone.att.com/cgi-bin/webphones.pl?id=" + loggedUser)
    End Sub

    Private Sub SEARCHWEBPHONEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEARCHWEBPHONEToolStripMenuItem.Click
        Form7.Show()
    End Sub

    Private Sub MYTEAMWEBPHONEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MYTEAMWEBPHONEToolStripMenuItem.Click

        Dim loggedUser As String
        loggedUser = Environment.UserName
        System.Diagnostics.Process.Start("https://webphone.att.com/cgi-bin/orglist.pl?id=" + loggedUser)
    End Sub

    Private Sub DONSTEAMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DONSTEAMToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://webphone.att.com/cgi-bin/orglist.pl?id=dw5119")
    End Sub

    Private Sub WORKSTATIONTICKETSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WORKSTATIONTICKETSToolStripMenuItem.Click
        System.Diagnostics.Process.Start("https://forms.office.com/pages/responsepage.aspx?id=HNdB57bGsEeAPA87MrB1Vri4hfA_j1ZKlXPagmypALNUMlA2MDMxWThYNEs4R09GNTFaTFNPOExLQy4u")
    End Sub
End Class

