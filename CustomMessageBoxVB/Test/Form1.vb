Public Class Form1

    '//More Inf. https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.messagebox?view=windowsdesktop-6.0

    Public Sub New()
        InitializeComponent()
    End Sub

    '//-> Text-Only Message Box
    Private Sub btnMsgText_Click(sender As Object, e As EventArgs) Handles btnMsgText.Click
        labelDialogResult.Text = "Dialog Box Result"
        'It Is optional to save the Dialog Result,
        'use it when you need to know which button Or action the user selected,
        'And do a specific function/task according to the dialogue result.
        '-| For Example:
        Dim result As DialogResult = RJMessageBox.Show("This is an example of a Text-Only Message Box.")
        If result = DialogResult.OK Then
            labelDialogResult.Text = "You have selected the OK BUTTON"
        Else
            labelDialogResult.Text = "You have selected CANCEL"
        End If
        'Many times we only need to display a message box, without the need to retrieve the button Or action selected by the user.
        '-| For Example:
        'RJMessageBox.Show("This is an example of a Text-Only Message Box.");
    End Sub

    '//-> Text + Caption Message Box
    Private Sub btnMsgTextCaption1_Click(sender As Object, e As EventArgs) Handles btnMsgTextCaption1.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result As DialogResult = RJMessageBox.Show("This is an example of a Text + Caption Message Box.",
                                                       "Important Message")
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgTextCaption2_Click(sender As Object, e As EventArgs) Handles btnMsgTextCaption2.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = RJMessageBox.Show("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." & vbLf & vbLf & "Why do we use it?" & vbLf & vbLf & "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).",
                                       "System: Save Changes")
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub

    '//-> Buttons Message Box
    Private Sub btnMsgOk_Click(sender As Object, e As EventArgs) Handles btnMsgOk.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = RJMessageBox.Show("This is an example of an OK Button Message Box.",
                                       "OK Button",
                                       MessageBoxButtons.OK)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgOkCancel_Click(sender As Object, e As EventArgs) Handles btnMsgOkCancel.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = RJMessageBox.Show("This is an example of an OK, Cancel Button Message Box.",
                                       "OK-Cancel Button",
                                       MessageBoxButtons.OKCancel)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgAbortRetryIgnore_Click(sender As Object, e As EventArgs) Handles btnMsgAbortRetryIgnore.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = RJMessageBox.Show("This is an example of an Abort, Retry, Ignore Button Message Box.",
                                       "Abort-Retry-Ignore Button",
                                       MessageBoxButtons.AbortRetryIgnore)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgYesNo_Click(sender As Object, e As EventArgs) Handles btnMsgYesNo.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = RJMessageBox.Show("This is an example of an Yes, No Button Message Box.",
                                       "Yes-No Button",
                                       MessageBoxButtons.YesNo)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgYesNoCancel_Click(sender As Object, e As EventArgs) Handles btnMsgYesNoCancel.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = RJMessageBox.Show("This is an example of an Yes, No, Cancel Button Message Box.",
                                       "Yes-No-Cancel Button",
                                       MessageBoxButtons.YesNoCancel)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgRetryCancel_Click(sender As Object, e As EventArgs) Handles btnMsgRetryCancel.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = RJMessageBox.Show("This is an example of an Retry, Cancel Button Message Box.",
                                       "Retry-Cancel Button",
                                       MessageBoxButtons.RetryCancel)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub

    '//-> Icons Message Box
    Private Sub btnMsgQuestion_Click(sender As Object, e As EventArgs) Handles btnMsgQuestion.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = RJMessageBox.Show("This is an example of an Question Icon Message Box.",
                                       "Question Icon",
                                       MessageBoxButtons.OKCancel,
                                       MessageBoxIcon.Question)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgWarning_Click(sender As Object, e As EventArgs) Handles btnMsgWarning.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = RJMessageBox.Show("This is an example of an Warning-Exclamation Icon Message Box.",
                                       "Warning-Exclamation Icon",
                                       MessageBoxButtons.YesNoCancel,
                                       MessageBoxIcon.Warning)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgError_Click(sender As Object, e As EventArgs) Handles btnMsgError.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = RJMessageBox.Show("This is an example of an Error-Stop Icon Message Box.",
                                       "Error-Stop Icon",
                                       MessageBoxButtons.RetryCancel,
                                       MessageBoxIcon.Error)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgInformation_Click(sender As Object, e As EventArgs) Handles btnMsgInformation.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = RJMessageBox.Show("This is an example of an Information Icon Message Box.",
                                       "Information Icon",
                                       MessageBoxButtons.OK,
                                       MessageBoxIcon.Information)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub

    '//-> Default Button
    Private Sub btnMsgButton1_Click(sender As Object, e As EventArgs) Handles btnMsgButton1.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = RJMessageBox.Show("This is an example of a Message Box that sets Button1 as the Default Selected Button." & vbLf & "That is, pressing the Enter Key selects the Button1.",
                                       "Warning-Exclamation Icon",
                                       MessageBoxButtons.YesNoCancel,
                                       MessageBoxIcon.Warning,
                                       MessageBoxDefaultButton.Button1)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgButton2_Click(sender As Object, e As EventArgs) Handles btnMsgButton2.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = RJMessageBox.Show("This is an example of a Message Box that sets Button2 as the Default Selected Button." & vbLf & "That is, pressing the Enter Key selects the Button2.",
                                       "Warning-Exclamation Icon",
                                       MessageBoxButtons.RetryCancel,
                                       MessageBoxIcon.Information,
                                       MessageBoxDefaultButton.Button2)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub
    Private Sub btnMsgButton3_Click(sender As Object, e As EventArgs) Handles btnMsgButton3.Click
        labelDialogResult.Text = "Dialog Box Result"
        Dim result = RJMessageBox.Show("This is an example of a Message Box that sets Button3 as the Default Selected Button." & vbLf & "That is, pressing the Enter Key selects the Button3.",
                                       "Warning-Exclamation Icon",
                                       MessageBoxButtons.AbortRetryIgnore,
                                       MessageBoxIcon.[Error],
                                       MessageBoxDefaultButton.Button3)
        labelDialogResult.Text = result.ToString() & " Selected"
    End Sub

    '//Set Owner Object
    Private Sub Any()
        '-| IWin32Window owner:
        'Displays a message box in front of the specified object And with the other specified parameters.
        RJMessageBox.Show(Me, "Text")
        RJMessageBox.Show(Me, "Text", "Caption")
        RJMessageBox.Show(Me, "Text", "Caption", MessageBoxButtons.OKCancel)
        'Etc
    End Sub
End Class
