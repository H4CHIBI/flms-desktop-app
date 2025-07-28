<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SideBarMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MaintableLayout = New TableLayoutPanel()
        SideBarNav = New Panel()
        MaintableLayout.SuspendLayout()
        SuspendLayout()
        ' 
        ' MaintableLayout
        ' 
        MaintableLayout.Anchor = AnchorStyles.None
        MaintableLayout.ColumnCount = 2
        MaintableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 8.315099F))
        MaintableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 91.6849F))
        MaintableLayout.Controls.Add(SideBarNav, 0, 0)
        MaintableLayout.Location = New Point(0, 0)
        MaintableLayout.Name = "MaintableLayout"
        MaintableLayout.RowCount = 1
        MaintableLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        MaintableLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        MaintableLayout.Size = New Size(914, 538)
        MaintableLayout.TabIndex = 2
        ' 
        ' SideBarNav
        ' 
        SideBarNav.BackColor = SystemColors.ButtonHighlight
        SideBarNav.Dock = DockStyle.Left
        SideBarNav.Location = New Point(3, 3)
        SideBarNav.Name = "SideBarNav"
        SideBarNav.Size = New Size(70, 532)
        SideBarNav.TabIndex = 0
        ' 
        ' SideBarMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(915, 538)
        Controls.Add(MaintableLayout)
        Name = "SideBarMenu"
        Text = "SideBarMenu"
        MaintableLayout.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents MaintableLayout As TableLayoutPanel
    Friend WithEvents SideBarNav As Panel
End Class
