Public Class ViewHistoryForm
    Dim scheduled_task As String
    Dim table As New DataTable

    Private Sub ViewHistoryForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.KryptonManager.GlobalPaletteMode = My.Settings.PalletteSetting


        scheduled_task = MainForm.ScheduledTasksDataGridView.Rows(MainForm.ScheduledTasksDataGridView.SelectedRows.Item(0).Index).Cells(2).Value.ToString

        table = MainForm.m_master_control.GetFromATableAsDataTable("Log", {"*"}, {"Program_Name = '" & scheduled_task & "'"})

        Me.Text = "History of " + scheduled_task

        ViewHistoryLogDataGridView.DataSource = table.Copy()
        ViewHistoryLogDataGridView.AutoResizeColumns()
        ViewHistoryLogDataGridView.Refresh()

    End Sub

    Private Sub LogButtonSpecExportToPDF_Click(sender As System.Object, e As System.EventArgs) Handles LogButtonSpecExportToPDF.Click
        MainForm.exportToPDF(ViewHistoryLogDataGridView)
    End Sub
End Class
