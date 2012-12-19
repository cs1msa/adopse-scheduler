Imports ComponentFactory.Krypton.Toolkit
Imports AssLogic
Imports CompletIT.Windows.Forms.Export.Pdf
Imports CompletIT.Windows.Forms.Export



Public Class MainForm

    Dim m_master_control As ALMasterControl

    Private _widthLeftRight As Integer
    Private _heightUpDown As Integer

    Private Sub ButtonSpecHeaderGroup1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpecHeaderGroup1.Click
        ''Suspend layout changes until all splitter properties have been updated
        KryptonSplitContainer1.SuspendLayout()

        ''Is the left header group currently expanded?
        If (KryptonSplitContainer1.FixedPanel = FixedPanel.None) Then

            '' Make the left panel of the splitter fixed in size
            KryptonSplitContainer1.FixedPanel = FixedPanel.Panel1
            KryptonSplitContainer1.IsSplitterFixed = True

            '' Remember the current height of the header group
            _widthLeftRight = NavigateHeaderGroup.Width

            ''We have not changed the orientation of the header yet, so the width of 
            '' the splitter panel is going to be the height of the collapsed header group
            Dim newWidth As Integer
            newWidth = NavigateHeaderGroup.PreferredSize.Height

            '' Make the header group fixed just as the new height
            KryptonSplitContainer1.Panel1MinSize = newWidth
            KryptonSplitContainer1.SplitterDistance = newWidth

            ''Change header to be vertical and button to near edge
            NavigateHeaderGroup.HeaderPositionPrimary = VisualOrientation.Right
            NavigateHeaderGroup.ButtonSpecs(0).Edge = PaletteRelativeEdgeAlign.Near

        Else

            ''Make the bottom panel not-fixed in size anymore
            KryptonSplitContainer1.FixedPanel = FixedPanel.None
            KryptonSplitContainer1.IsSplitterFixed = False

            '' Put back the minimise size to the original
            KryptonSplitContainer1.Panel1MinSize = 25

            '' Calculate the correct splitter we want to put back
            KryptonSplitContainer1.SplitterDistance = _widthLeftRight

            '' Change header to be horizontal and button to far edge
            NavigateHeaderGroup.HeaderPositionPrimary = VisualOrientation.Top
            NavigateHeaderGroup.ButtonSpecs(0).Edge = PaletteRelativeEdgeAlign.Far


        End If

        KryptonSplitContainer1.ResumeLayout()
    End Sub

    Private Sub ButtonSpecHeaderGroup2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSpecHeaderGroup2.Click
        ''Suspend layout changes until all splitter properties have been updated
        KryptonSplitContainer2.SuspendLayout()

        '' Is the bottom right header group currently expanded?
        If (KryptonSplitContainer2.FixedPanel = FixedPanel.None) Then

            ''Make the bottom panel of the splitter fixed in size
            KryptonSplitContainer2.FixedPanel = FixedPanel.Panel2
            KryptonSplitContainer2.IsSplitterFixed = True

            ''Remember the current height of the header group (to restore later)
            _heightUpDown = LogHeaderGroup.Height

            ''Find the new height to use for the header group
            Dim newHeight As Integer
            newHeight = LogHeaderGroup.PreferredSize.Height

            ''Make the header group fixed to the new height
            KryptonSplitContainer2.Panel2MinSize = newHeight
            KryptonSplitContainer2.SplitterDistance = KryptonSplitContainer2.Height

        Else

            ''Make the bottom panel not-fixed in size anymore
            KryptonSplitContainer2.FixedPanel = FixedPanel.None
            KryptonSplitContainer2.IsSplitterFixed = False

            ''Put back the minimise size to the original
            KryptonSplitContainer2.Panel2MinSize = 100

            ''Calculate the correct splitter we want to put back
            KryptonSplitContainer2.SplitterDistance = KryptonSplitContainer2.Height - _heightUpDown - KryptonSplitContainer2.SplitterWidth
        End If

        KryptonSplitContainer2.ResumeLayout()
    End Sub

    Private Sub KryptonButton1_Click(sender As System.Object, e As System.EventArgs) Handles AddTaskButton.Click
        NewTaskForm.ShowDialog()
    End Sub


    'expands the tree view nodes Task and History on startup
    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        m_master_control = New ALMasterControl()
        m_master_control.Init()
        NewTaskForm.SetMasterControl(m_master_control)
        NavigationTreeView.Nodes(0).Expand()
        NavigationTreeView.Nodes(1).Expand()
        Timer.Start()
    End Sub

    'changes the default action of the X button
    'instead of closing the programm it hides it in the tray
    Private Sub MainForm_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub ShowToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Me.Close() doesn't work because 
        'it is captured by the FormCLosing event
        System.Windows.Forms.Application.Exit()
        TrayIcon.Dispose()

    End Sub

    Private Sub TrayIcon_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles TrayIcon.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        'Me.Close() doesn't work because 
        'it is captured by the FormCLosing event
        System.Windows.Forms.Application.Exit()
        TrayIcon.Dispose()
    End Sub

    Private Sub LogButtonSpecExportToPDF_Click(sender As System.Object, e As System.EventArgs) Handles LogButtonSpecExportToPDF.Click
        'You can export any DataGridView control, no matter managed or not by the extension
        Dim pdfExporter As DGVEPdfExporter = New DGVEPdfExporter()
        Dim dialog As DGVEBaseExportSettingsEditorForm = DGVEExportSettingsEditorFormBuilder.CreateWrappingForm(pdfExporter)
        dialog.Settings = New DGVEPdfExportSettings()
        If (DialogResult.OK <> dialog.ShowDialog()) Then
            Return
        End If

        AddHandler pdfExporter.ExportFailed, AddressOf exporter_ExportFailed
        pdfExporter.Export(LogDataGridView, dialog.Settings)
    End Sub

    Private Sub exporter_ExportFailed(ByVal sender As Object, ByVal e As CompletIT.Windows.Forms.Export.ExportFailedEventArgs)
        'Show message box with the occured exception 
        MessageBox.Show(e.Exception.Message)
    End Sub

    Private Sub Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Timer.Tick
        m_master_control.ProgramLoop()

    End Sub

End Class
