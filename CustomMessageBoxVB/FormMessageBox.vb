Imports System.Runtime.InteropServices

Public Class FormMessageBox
    Private _primaryColor As Color = Color.CornflowerBlue
    Private _borderSize As Integer = 2

    Public Property PrimaryColor As Color
        Get
            Return _primaryColor
        End Get
        Set(value As Color)
            _primaryColor = value
            Me.BackColor = PrimaryColor
            Me.panelTitleBar.BackColor = PrimaryColor
        End Set
    End Property

    Public Sub New(text As String)
        InitializeComponent()
        InitializeItems()
        Me.PrimaryColor = _primaryColor
        Me.labelMessage.Text = text
        Me.labelCaption.Text = ""
        SetFormSize()
        SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1)
    End Sub

    Public Sub New(text As String, caption As String)
        InitializeComponent()
        InitializeItems()
        Me.PrimaryColor = _primaryColor
        Me.labelMessage.Text = text
        Me.labelCaption.Text = caption
        SetFormSize()
        SetButtons(MessageBoxButtons.OK, MessageBoxDefaultButton.Button1)
    End Sub

    Public Sub New(text As String, caption As String, buttons As MessageBoxButtons)
        InitializeComponent()
        InitializeItems()
        Me.PrimaryColor = _primaryColor
        Me.labelMessage.Text = text
        Me.labelCaption.Text = caption
        SetFormSize()
        SetButtons(buttons, MessageBoxDefaultButton.Button1)
    End Sub

    Public Sub New(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon)
        InitializeComponent()
        InitializeItems()
        Me.PrimaryColor = _primaryColor
        Me.labelMessage.Text = text
        Me.labelCaption.Text = caption
        SetFormSize()
        SetButtons(buttons, MessageBoxDefaultButton.Button1)
        SetIcon(icon)
    End Sub

    Public Sub New(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton)
        InitializeComponent()
        InitializeItems()
        Me.PrimaryColor = _primaryColor
        Me.labelMessage.Text = text
        Me.labelCaption.Text = caption
        SetFormSize()
        SetButtons(buttons, defaultButton)
        SetIcon(icon)
    End Sub

    Private Sub InitializeItems()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Padding = New Padding(_borderSize)
        Me.labelMessage.MaximumSize = New Size(550, 0)
        Me.btnClose.DialogResult = DialogResult.Cancel
        Me.button1.DialogResult = DialogResult.OK
        Me.button1.Visible = False
        Me.button2.Visible = False
        Me.button3.Visible = False
    End Sub

    Private Sub SetFormSize()
        Dim widht As Integer = Me.labelMessage.Width + Me.pictureBoxIcon.Width + Me.panelBody.Padding.Left
        Dim height As Integer = Me.panelTitleBar.Height + Me.labelMessage.Height + Me.panelButtons.Height + Me.panelBody.Padding.Top
        Me.Size = New Size(widht, height)
    End Sub

    Private Sub SetButtons(buttons As MessageBoxButtons, defaultButton As MessageBoxDefaultButton)
        Dim xCenter As Integer = (Me.panelButtons.Width - button1.Width) / 2
        Dim yCenter As Integer = (Me.panelButtons.Height - button1.Height) / 2

        Select Case buttons
            Case MessageBoxButtons.OK
                button1.Visible = True
                button1.Location = New Point(xCenter, yCenter)
                button1.Text = "Ok"
                button1.DialogResult = DialogResult.OK
                SetDefaultButton(defaultButton)
            Case MessageBoxButtons.OKCancel
                button1.Visible = True
                button1.Location = New Point(xCenter - (button1.Width / 2) - 5, yCenter)
                button1.Text = "Ok"
                button1.DialogResult = DialogResult.OK
                button2.Visible = True
                button2.Location = New Point(xCenter + (button2.Width / 2) + 5, yCenter)
                button2.Text = "Cancel"
                button2.DialogResult = DialogResult.Cancel
                button2.BackColor = Color.DimGray

                If defaultButton <> MessageBoxDefaultButton.Button3 Then
                    SetDefaultButton(defaultButton)
                Else
                    SetDefaultButton(MessageBoxDefaultButton.Button1)
                End If

            Case MessageBoxButtons.RetryCancel
                button1.Visible = True
                button1.Location = New Point(xCenter - (button1.Width / 2) - 5, yCenter)
                button1.Text = "Retry"
                button1.DialogResult = DialogResult.Retry
                button2.Visible = True
                button2.Location = New Point(xCenter + (button2.Width / 2) + 5, yCenter)
                button2.Text = "Cancel"
                button2.DialogResult = DialogResult.Cancel
                button2.BackColor = Color.DimGray

                If defaultButton <> MessageBoxDefaultButton.Button3 Then
                    SetDefaultButton(defaultButton)
                Else
                    SetDefaultButton(MessageBoxDefaultButton.Button1)
                End If

            Case MessageBoxButtons.YesNo
                button1.Visible = True
                button1.Location = New Point(xCenter - (button1.Width / 2) - 5, yCenter)
                button1.Text = "Yes"
                button1.DialogResult = DialogResult.Yes
                button2.Visible = True
                button2.Location = New Point(xCenter + (button2.Width / 2) + 5, yCenter)
                button2.Text = "No"
                button2.DialogResult = DialogResult.No
                button2.BackColor = Color.IndianRed

                If defaultButton <> MessageBoxDefaultButton.Button3 Then
                    SetDefaultButton(defaultButton)
                Else
                    SetDefaultButton(MessageBoxDefaultButton.Button1)
                End If

            Case MessageBoxButtons.YesNoCancel
                button1.Visible = True
                button1.Location = New Point(xCenter - button1.Width - 5, yCenter)
                button1.Text = "Yes"
                button1.DialogResult = DialogResult.Yes
                button2.Visible = True
                button2.Location = New Point(xCenter, yCenter)
                button2.Text = "No"
                button2.DialogResult = DialogResult.No
                button2.BackColor = Color.IndianRed
                button3.Visible = True
                button3.Location = New Point(xCenter + button2.Width + 5, yCenter)
                button3.Text = "Cancel"
                button3.DialogResult = DialogResult.Cancel
                button3.BackColor = Color.DimGray
                SetDefaultButton(defaultButton)
            Case MessageBoxButtons.AbortRetryIgnore
                button1.Visible = True
                button1.Location = New Point(xCenter - button1.Width - 5, yCenter)
                button1.Text = "Abort"
                button1.DialogResult = DialogResult.Abort
                button1.BackColor = Color.Goldenrod
                button2.Visible = True
                button2.Location = New Point(xCenter, yCenter)
                button2.Text = "Retry"
                button2.DialogResult = DialogResult.Retry
                button3.Visible = True
                button3.Location = New Point(xCenter + button2.Width + 5, yCenter)
                button3.Text = "Ignore"
                button3.DialogResult = DialogResult.Ignore
                button3.BackColor = Color.IndianRed
                SetDefaultButton(defaultButton)
        End Select
    End Sub

    Private Sub SetDefaultButton(defaultButton As MessageBoxDefaultButton)
        Select Case defaultButton
            Case MessageBoxDefaultButton.Button1
                button1.[Select]()
                button1.ForeColor = Color.White
                button1.Font = New Font(button1.Font, FontStyle.Underline)
            Case MessageBoxDefaultButton.Button2
                button2.[Select]()
                button2.ForeColor = Color.White
                button2.Font = New Font(button2.Font, FontStyle.Underline)
            Case MessageBoxDefaultButton.Button3
                button3.[Select]()
                button3.ForeColor = Color.White
                button3.Font = New Font(button3.Font, FontStyle.Underline)
        End Select
    End Sub

    Private Sub SetIcon(icon As MessageBoxIcon)
        Select Case icon
            Case MessageBoxIcon.Error
                Me.pictureBoxIcon.Image = My.Resources._error
                PrimaryColor = Color.FromArgb(224, 79, 95)
                Me.btnClose.FlatAppearance.MouseOverBackColor = Color.Crimson
            Case MessageBoxIcon.Information
                Me.pictureBoxIcon.Image = My.Resources.information
                PrimaryColor = Color.FromArgb(38, 191, 166)
            Case MessageBoxIcon.Question
                Me.pictureBoxIcon.Image = My.Resources.question
                PrimaryColor = Color.FromArgb(10, 119, 232)
            Case MessageBoxIcon.Exclamation
                Me.pictureBoxIcon.Image = My.Resources.exclamation
                PrimaryColor = Color.FromArgb(255, 140, 0)
            Case MessageBoxIcon.None
                Me.pictureBoxIcon.Image = My.Resources.chat
                PrimaryColor = Color.CornflowerBlue
        End Select
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As System.IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    Private Sub panelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112, &HF012, 0)
    End Sub
End Class