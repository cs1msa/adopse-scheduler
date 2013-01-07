Public Class MoreOptionsForm

    Private Sub MoreOptionsForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        KryptonManager.GlobalPaletteMode = My.Settings.PalletteSetting

        'checks if Exe has been chosen from NewTask form
        'if so, it shows a choice of how many minutes will the program remain open
        If (NewTaskForm.ExecutableCheckButton.Checked = True) Then
            TimeOpenGroupBox.Visible = True
        Else
            TimeOpenGroupBox.Visible = False
        End If

        'changes the language according to the user's choice
        changeLanguageMoreOptionsForm(My.Settings.LanguageFlag)
        EndAtDateTimePicker.MinDate = Today
    End Sub

    'changes the language according to the user's choice
    Private Sub changeLanguageMoreOptionsForm(ByVal lang As String)

        Dim dictionary As New List(Of String)
        Select Case My.Settings.LanguageFlag
            Case "Greek"
                dictionary = MainForm.getGreekDictionary()
            Case "English"
                dictionary = MainForm.getEnglishDictionary()
        End Select


        '========================== MORE OPTIONS FORM ========================================
        With Me
            .Text = dictionary(51)

            .SetEndDateGroupBox.Values.Heading = dictionary(53)
            .NeverEndRadioButton.Text = dictionary(54)
            .EndAtRadioButton.Text = dictionary(57)

            With .TaskMissedGroupBox.Values
                .Heading = dictionary(58)
                .Description = dictionary(59)
            End With

            .RunWhenPcOpensRadioButton.Text = dictionary(60)
            .DisplayDialogAskingRadioButton.Text = dictionary(61)
            .DoNothingRadioButton.Text = dictionary(62)

            .DescriptionGroupBox.Values.Heading = dictionary(63)

            .StateGroupBox.Values.Heading = dictionary(17)
            .ActiveRadioButton.Text = dictionary(64)
            .InactiveRadioButton.Text = dictionary(65)

            .TimeOpenGroupBox.Values.Heading = dictionary(66)

            With .KryptonLabel1
                .Text = dictionary(67)
                .Values.ExtraText = dictionary(68)
            End With
        End With
        'END========================== MORE OPTIONS FORM =====================================

    End Sub

    Private Sub MoreOptionsOKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoreOptionsOKButton.Click
        Me.Close()
    End Sub
End Class
