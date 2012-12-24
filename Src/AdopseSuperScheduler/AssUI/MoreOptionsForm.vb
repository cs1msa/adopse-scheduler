Public Class MoreOptionsForm

    Private Sub MoreOptionsForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        KryptonManager.GlobalPaletteMode = My.Settings.PalletteSetting
        'checks if Exe or Service has been chosen from NewTask form
        'if so, it shows a choice of how many minutes will the program remain open
        If (NewTaskForm.ExecutableCheckButton.Checked = True Or _
                        NewTaskForm.ServiceCheckButton.Checked = True) Then

            TimeOpenGroupBox.Visible = True
        Else
            TimeOpenGroupBox.Visible = False
        End If

    End Sub

    Private Sub MoreOptionsOKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoreOptionsOKButton.Click
        Me.Close()
    End Sub
End Class
