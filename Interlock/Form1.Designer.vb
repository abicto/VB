<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EntryMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EngineTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnginePurposeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EngineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PartCategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScheduleMonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntryMasterToolStripMenuItem, Me.ScheduleMonitoringToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1260, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EntryMasterToolStripMenuItem
        '
        Me.EntryMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EngineTypeToolStripMenuItem, Me.EnginePurposeToolStripMenuItem, Me.EngineToolStripMenuItem, Me.ToolStripSeparator1, Me.PartCategoriesToolStripMenuItem, Me.PartToolStripMenuItem})
        Me.EntryMasterToolStripMenuItem.Image = Global.Interlock.My.Resources.Resources.checkbox_pen_outline
        Me.EntryMasterToolStripMenuItem.Name = "EntryMasterToolStripMenuItem"
        Me.EntryMasterToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.EntryMasterToolStripMenuItem.Text = "Entry Master"
        '
        'EngineTypeToolStripMenuItem
        '
        Me.EngineTypeToolStripMenuItem.Name = "EngineTypeToolStripMenuItem"
        Me.EngineTypeToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.EngineTypeToolStripMenuItem.Text = "Engine Type"
        '
        'EnginePurposeToolStripMenuItem
        '
        Me.EnginePurposeToolStripMenuItem.Name = "EnginePurposeToolStripMenuItem"
        Me.EnginePurposeToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.EnginePurposeToolStripMenuItem.Text = "Engine Purpose"
        '
        'EngineToolStripMenuItem
        '
        Me.EngineToolStripMenuItem.Name = "EngineToolStripMenuItem"
        Me.EngineToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.EngineToolStripMenuItem.Text = "Engine"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(153, 6)
        '
        'PartCategoriesToolStripMenuItem
        '
        Me.PartCategoriesToolStripMenuItem.Name = "PartCategoriesToolStripMenuItem"
        Me.PartCategoriesToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.PartCategoriesToolStripMenuItem.Text = "Part Categories"
        '
        'PartToolStripMenuItem
        '
        Me.PartToolStripMenuItem.Name = "PartToolStripMenuItem"
        Me.PartToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.PartToolStripMenuItem.Text = "Part"
        '
        'ScheduleMonitoringToolStripMenuItem
        '
        Me.ScheduleMonitoringToolStripMenuItem.Image = Global.Interlock.My.Resources.Resources.presentation_outline
        Me.ScheduleMonitoringToolStripMenuItem.Name = "ScheduleMonitoringToolStripMenuItem"
        Me.ScheduleMonitoringToolStripMenuItem.Size = New System.Drawing.Size(146, 20)
        Me.ScheduleMonitoringToolStripMenuItem.Text = "Schedule Monitoring"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Image = Global.Interlock.My.Resources.Resources.pie_chart_outline
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 656)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(1260, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(129, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1260, 678)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EntryMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EngineTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnginePurposeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EngineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PartCategoriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScheduleMonitoringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
End Class
