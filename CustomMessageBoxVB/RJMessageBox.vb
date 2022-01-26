Public MustInherit Class RJMessageBox

    Public Shared Function Show(text As String) As DialogResult
        Dim result As DialogResult
        Using msgForm = New FormMessageBox(text)
            result = msgForm.ShowDialog()
        End Using
        Return result
    End Function

    Public Shared Function Show(text As String, caption As String) As DialogResult
        Dim result As DialogResult
        Using msgForm = New FormMessageBox(text, caption)
            result = msgForm.ShowDialog()
        End Using
        Return result
    End Function

    Public Shared Function Show(text As String, caption As String, buttons As MessageBoxButtons) As DialogResult
        Dim result As DialogResult
        Using msgForm = New FormMessageBox(text, caption, buttons)
            result = msgForm.ShowDialog()
        End Using
        Return result
    End Function

    Public Shared Function Show(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon) As DialogResult
        Dim result As DialogResult
        Using msgForm = New FormMessageBox(text, caption, buttons, icon)
            result = msgForm.ShowDialog()
        End Using
        Return result
    End Function

    Public Shared Function Show(text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton) As DialogResult
        Dim result As DialogResult
        Using msgForm = New FormMessageBox(text, caption, buttons, icon, defaultButton)
            result = msgForm.ShowDialog()
        End Using
        Return result
    End Function

    '-> IWin32Window Owner
    '   Displays a message box in front of the specified object And with the other specified parameters.
    '   An implementation of IWin32Window that will own the modal dialog box.*/
    Public Shared Function Show(owner As IWin32Window, text As String) As DialogResult
        Dim result As DialogResult
        Using msgForm = New FormMessageBox(text)
            result = msgForm.ShowDialog(owner)
        End Using
        Return result
    End Function

    Public Shared Function Show(owner As IWin32Window, text As String, caption As String) As DialogResult
        Dim result As DialogResult
        Using msgForm = New FormMessageBox(text, caption)
            result = msgForm.ShowDialog(owner)
        End Using
        Return result
    End Function

    Public Shared Function Show(owner As IWin32Window, text As String, caption As String, buttons As MessageBoxButtons) As DialogResult
        Dim result As DialogResult
        Using msgForm = New FormMessageBox(text, caption, buttons)
            result = msgForm.ShowDialog(owner)
        End Using
        Return result
    End Function

    Public Shared Function Show(owner As IWin32Window, text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon) As DialogResult
        Dim result As DialogResult
        Using msgForm = New FormMessageBox(text, caption, buttons, icon)
            result = msgForm.ShowDialog(owner)
        End Using
        Return result
    End Function

    Public Shared Function Show(owner As IWin32Window, text As String, caption As String, buttons As MessageBoxButtons, icon As MessageBoxIcon, defaultButton As MessageBoxDefaultButton) As DialogResult
        Dim result As DialogResult
        Using msgForm = New FormMessageBox(text, caption, buttons, icon, defaultButton)
            result = msgForm.ShowDialog(owner)
        End Using
        Return result
    End Function
End Class
