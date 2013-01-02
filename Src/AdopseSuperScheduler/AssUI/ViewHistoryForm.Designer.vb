<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewHistoryForm
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewHistoryForm))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.LogHeaderGroup = New ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup()
        Me.LogButtonSpecExportToPDF = New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup()
        Me.ViewHistoryLogDataGridView = New ComponentFactory.Krypton.Toolkit.KryptonDataGridView()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        CType(Me.LogHeaderGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogHeaderGroup.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LogHeaderGroup.Panel.SuspendLayout()
        Me.LogHeaderGroup.SuspendLayout()
        CType(Me.ViewHistoryLogDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.LogHeaderGroup)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Size = New System.Drawing.Size(612, 354)
        Me.KryptonPanel.TabIndex = 0
        '
        'LogHeaderGroup
        '
        Me.LogHeaderGroup.ButtonSpecs.AddRange(New ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup() {Me.LogButtonSpecExportToPDF})
        Me.LogHeaderGroup.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogHeaderGroup.HeaderVisibleSecondary = False
        Me.LogHeaderGroup.Location = New System.Drawing.Point(0, 0)
        Me.LogHeaderGroup.Name = "LogHeaderGroup"
        '
        'LogHeaderGroup.Panel
        '
        Me.LogHeaderGroup.Panel.Controls.Add(Me.ViewHistoryLogDataGridView)
        Me.LogHeaderGroup.Size = New System.Drawing.Size(612, 354)
        Me.LogHeaderGroup.TabIndex = 1
        Me.LogHeaderGroup.ValuesPrimary.Heading = "Log"
        Me.LogHeaderGroup.ValuesPrimary.Image = Global.AssUI.My.Resources.Resources.logIcon
        '
        'LogButtonSpecExportToPDF
        '
        Me.LogButtonSpecExportToPDF.Image = Global.AssUI.My.Resources.Resources.exportToPDFicon
        Me.LogButtonSpecExportToPDF.ToolTipBody = "Export to PDF"
        Me.LogButtonSpecExportToPDF.ToolTipTitle = "Export to PDF"
        Me.LogButtonSpecExportToPDF.UniqueName = "A9F07FE678CB4C4657B37E40141FE193"
        '
        'ViewHistoryLogDataGridView
        '
        Me.ViewHistoryLogDataGridView.AllowUserToAddRows = False
        Me.ViewHistoryLogDataGridView.AllowUserToDeleteRows = False
        Me.ViewHistoryLogDataGridView.AllowUserToOrderColumns = True
        Me.ViewHistoryLogDataGridView.AllowUserToResizeRows = False
        Me.ViewHistoryLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ViewHistoryLogDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewHistoryLogDataGridView.GridStyles.Style = ComponentFactory.Krypton.Toolkit.DataGridViewStyle.Sheet
        Me.ViewHistoryLogDataGridView.GridStyles.StyleBackground = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundSheet
        Me.ViewHistoryLogDataGridView.GridStyles.StyleColumn = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.ViewHistoryLogDataGridView.GridStyles.StyleDataCells = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.ViewHistoryLogDataGridView.GridStyles.StyleRow = ComponentFactory.Krypton.Toolkit.GridStyle.Sheet
        Me.ViewHistoryLogDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.ViewHistoryLogDataGridView.Name = "ViewHistoryLogDataGridView"
        Me.ViewHistoryLogDataGridView.ReadOnly = True
        Me.ViewHistoryLogDataGridView.RowHeadersVisible = False
        Me.ViewHistoryLogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewHistoryLogDataGridView.Size = New System.Drawing.Size(610, 315)
        Me.ViewHistoryLogDataGridView.TabIndex = 0
        '
        'KryptonManager
        '
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalOffice2003
        '
        'ViewHistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 354)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewHistoryForm"
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem
        Me.Text = "History of "
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        CType(Me.LogHeaderGroup.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogHeaderGroup.Panel.ResumeLayout(False)
        CType(Me.LogHeaderGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LogHeaderGroup.ResumeLayout(False)
        CType(Me.ViewHistoryLogDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents LogHeaderGroup As ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup
    Friend WithEvents LogButtonSpecExportToPDF As ComponentFactory.Krypton.Toolkit.ButtonSpecHeaderGroup
    Friend WithEvents ViewHistoryLogDataGridView As ComponentFactory.Krypton.Toolkit.KryptonDataGridView
End Class
