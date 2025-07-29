<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminHome))
        MaintableLayout = New TableLayoutPanel()
        SideBarNav = New Panel()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        MaintableLayout.SuspendLayout()
        SideBarNav.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MaintableLayout
        ' 
        MaintableLayout.Anchor = AnchorStyles.None
        MaintableLayout.BackColor = Color.White
        MaintableLayout.ColumnCount = 2
        MaintableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 18.1619263F))
        MaintableLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 81.83807F))
        MaintableLayout.Controls.Add(SideBarNav, 0, 0)
        MaintableLayout.Location = New Point(0, 0)
        MaintableLayout.Name = "MaintableLayout"
        MaintableLayout.RowCount = 1
        MaintableLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        MaintableLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        MaintableLayout.Size = New Size(914, 538)
        MaintableLayout.TabIndex = 3
        ' 
        ' SideBarNav
        ' 
        SideBarNav.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        SideBarNav.Controls.Add(Panel1)
        SideBarNav.Dock = DockStyle.Left
        SideBarNav.Location = New Point(3, 3)
        SideBarNav.Name = "SideBarNav"
        SideBarNav.Size = New Size(160, 532)
        SideBarNav.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(-3, 128)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(163, 34)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(36, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 23)
        Label1.TabIndex = 1
        Label1.Text = "Dashboard"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(6, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(27, 27)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' AdminHome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(915, 538)
        Controls.Add(MaintableLayout)
        Name = "AdminHome"
        Text = "AdminHome"
        MaintableLayout.ResumeLayout(False)
        SideBarNav.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MaintableLayout As TableLayoutPanel
    Friend WithEvents SideBarNav As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
