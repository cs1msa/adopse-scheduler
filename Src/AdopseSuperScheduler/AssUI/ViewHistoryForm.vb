Public Class ViewHistoryForm
    Dim scheduled_task As String
    Dim table As New DataTable

    Private Sub ViewHistoryForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.KryptonManager.GlobalPaletteMode = My.Settings.PalletteSetting


        scheduled_task = MainForm.ScheduledTasksDataGridView.Rows(MainForm.ScheduledTasksDataGridView.SelectedRows.Item(0).Index).Cells(2).Value.ToString

        table = MainForm.m_master_control.GetFromATableAsDataTable("Log", {"*"}, {"Program_Name = '" & scheduled_task & "'"})

        ViewHistoryLogDataGridView.DataSource = table.Copy()
        ViewHistoryLogDataGridView.AutoResizeColumns()

        'changes the language according to the user's choice
        changeLanguageViewHistoryForm(My.Settings.LanguageFlag)

    End Sub

    'changes the language according to the user's choice
    Private Sub changeLanguageViewHistoryForm(ByVal lang As String)

        Dim dictionary As New List(Of String)
        Select Case My.Settings.LanguageFlag
            Case "Greek"
                dictionary = MainForm.getGreekDictionary()
            Case "English"
                dictionary = MainForm.getEnglishDictionary()
        End Select

        ViewHistoryHeaderGroup.ValuesPrimary.Heading = dictionary(20)
        With ViewHistoryLogDataGridView
            .Columns(0).HeaderText = dictionary(21)
            .Columns(1).HeaderText = dictionary(22)
            .Columns(2).HeaderText = dictionary(11)
            .Columns(3).HeaderText = dictionary(18)
            .AutoResizeColumns()
        End With

        Me.Text = dictionary(90) + scheduled_task

    End Sub

    Private Sub LogButtonSpecExportToPDF_Click(sender As System.Object, e As System.EventArgs) Handles LogButtonSpecExportToPDF.Click
        MainForm.exportToPDF(ViewHistoryLogDataGridView)
    End Sub
End Class
