<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPage
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
        TableLayoutPanelRoot = New TableLayoutPanel()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        CreateAccLabel = New Label()
        Button1 = New Button()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        TableLayoutPanelRoot.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanelRoot
        ' 
        TableLayoutPanelRoot.Anchor = AnchorStyles.None
        TableLayoutPanelRoot.ColumnCount = 2
        TableLayoutPanelRoot.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 60.50328F))
        TableLayoutPanelRoot.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 39.49672F))
        TableLayoutPanelRoot.Controls.Add(Panel1, 0, 0)
        TableLayoutPanelRoot.Controls.Add(Panel2, 1, 0)
        TableLayoutPanelRoot.Location = New Point(1, 0)
        TableLayoutPanelRoot.Name = "TableLayoutPanelRoot"
        TableLayoutPanelRoot.RowCount = 1
        TableLayoutPanelRoot.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanelRoot.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanelRoot.Size = New Size(914, 538)
        TableLayoutPanelRoot.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonHighlight
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Font = New Font("Microsoft Sans Serif", 8.25F)
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(547, 532)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DodgerBlue
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(547, 85)
        Panel3.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(101, 30)
        Label7.Name = "Label7"
        Label7.RightToLeft = RightToLeft.No
        Label7.Size = New Size(416, 25)
        Label7.TabIndex = 0
        Label7.Text = "College of Information Technology Education"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.CITELogo
        PictureBox1.Location = New Point(24, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(71, 76)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.golden_2_1024x721
        PictureBox2.Location = New Point(-27, 44)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(651, 541)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = SystemColors.MenuHighlight
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(CreateAccLabel)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label1)
        Panel2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(556, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(355, 532)
        Panel2.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(22, 139)
        Label6.Name = "Label6"
        Label6.Size = New Size(260, 25)
        Label6.TabIndex = 8
        Label6.Text = "Login to access your account!"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(199, 462)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 21)
        Label5.TabIndex = 7
        Label5.Text = "Forgot Password?"
        ' 
        ' CreateAccLabel
        ' 
        CreateAccLabel.AutoSize = True
        CreateAccLabel.Cursor = Cursors.Hand
        CreateAccLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CreateAccLabel.Location = New Point(22, 462)
        CreateAccLabel.Name = "CreateAccLabel"
        CreateAccLabel.Size = New Size(122, 21)
        CreateAccLabel.TabIndex = 6
        CreateAccLabel.Text = "Create Account?"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DodgerBlue
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(22, 407)
        Button1.Name = "Button1"
        Button1.Size = New Size(312, 42)
        Button1.TabIndex = 5
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(22, 290)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 21)
        Label3.TabIndex = 4
        Label3.Text = "Password:"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.WhiteSmoke
        TextBox2.Cursor = Cursors.IBeam
        TextBox2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(22, 323)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(310, 35)
        TextBox2.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(20, 188)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 21)
        Label2.TabIndex = 2
        Label2.Text = "Username:"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.WhiteSmoke
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(20, 216)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(312, 35)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(20, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 30)
        Label1.TabIndex = 0
        Label1.Text = "Welcome Back!"
        ' 
        ' LoginPage
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(915, 538)
        Controls.Add(TableLayoutPanelRoot)
        Name = "LoginPage"
        Text = "LoginPage"
        TableLayoutPanelRoot.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanelRoot As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CreateAccLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
End Class
