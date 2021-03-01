<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode64 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("设置游戏目录")
        Dim TreeNode65 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("设置", New System.Windows.Forms.TreeNode() {TreeNode64})
        Dim TreeNode66 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("禁用设置 (禁用|解禁)")
        Dim TreeNode67 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("禁用清单 (修改清单|手动模式)")
        Dim TreeNode68 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("常规禁用 (IFEO+ACL)", New System.Windows.Forms.TreeNode() {TreeNode66, TreeNode67})
        Dim TreeNode69 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("拦截设置 (注册|卸载|启停)")
        Dim TreeNode70 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("拦截清单 (修改清单)")
        Dim TreeNode71 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("驱动拦截 (vLimit)", New System.Windows.Forms.TreeNode() {TreeNode69, TreeNode70})
        Dim TreeNode72 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("后台模式")
        Dim TreeNode73 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("chkdsk磁盘检查")
        Dim TreeNode74 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("修复文件权限")
        Dim TreeNode75 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("精简客户端")
        Dim TreeNode76 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Win10自动维护")
        Dim TreeNode77 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("重置游戏配置文件")
        Dim TreeNode78 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("卸载DNF")
        Dim TreeNode79 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("蓝屏")
        Dim TreeNode80 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("扩展功能", New System.Windows.Forms.TreeNode() {TreeNode72, TreeNode73, TreeNode74, TreeNode75, TreeNode76, TreeNode77, TreeNode78, TreeNode79})
        Dim TreeNode81 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("软件更新")
        Dim TreeNode82 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("联系我们&提交建议")
        Dim TreeNode83 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("赞助开发者")
        Dim TreeNode84 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("其他功能(更新+联系+赞助)", New System.Windows.Forms.TreeNode() {TreeNode81, TreeNode82, TreeNode83})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Log = New System.Windows.Forms.TextBox()
        Me.gGamePath = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tDNFPath = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tv = New System.Windows.Forms.TreeView()
        Me.gNList = New System.Windows.Forms.GroupBox()
        Me.NList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NListMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.添加插件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改插件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改禁用方式ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IFEO或ACLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.仅IFEOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.仅ACLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.刷新ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gNormal = New System.Windows.Forms.GroupBox()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gNormalInfo = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.gDList = New System.Windows.Forms.GroupBox()
        Me.DList = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DLisMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.添加拦截ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除拦截ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.修改AltitudeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.引用常规禁用的清单ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gDriver = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tDRStatus = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tDSStatus = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tDFStatus = New System.Windows.Forms.TextBox()
        Me.tDPath = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gHello = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.gExtraInfo = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.gExtra_chkdsk = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.gExtra_takeown = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.gExtra_trim = New System.Windows.Forms.GroupBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox13 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.gExtra_Win10MTC = New System.Windows.Forms.GroupBox()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.gExtra_DNFCFG = New System.Windows.Forms.GroupBox()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.gExtra_Purge = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.gExtra_BSOD = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.gExtra_Background = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Background_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Background_Icon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.gOther_Update = New System.Windows.Forms.GroupBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.gOther_Contact = New System.Windows.Forms.GroupBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.gOther_Donate = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.gDriverInfo = New System.Windows.Forms.GroupBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.gGamePath.SuspendLayout()
        Me.gNList.SuspendLayout()
        CType(Me.NList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NListMenu.SuspendLayout()
        Me.gNormal.SuspendLayout()
        Me.gNormalInfo.SuspendLayout()
        Me.gDList.SuspendLayout()
        CType(Me.DList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DLisMenu.SuspendLayout()
        Me.gDriver.SuspendLayout()
        Me.gHello.SuspendLayout()
        Me.gExtraInfo.SuspendLayout()
        Me.gExtra_chkdsk.SuspendLayout()
        Me.gExtra_takeown.SuspendLayout()
        Me.gExtra_trim.SuspendLayout()
        Me.gExtra_Win10MTC.SuspendLayout()
        Me.gExtra_DNFCFG.SuspendLayout()
        Me.gExtra_Purge.SuspendLayout()
        Me.gExtra_BSOD.SuspendLayout()
        Me.gExtra_Background.SuspendLayout()
        Me.gOther_Update.SuspendLayout()
        Me.gOther_Contact.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gOther_Donate.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gDriverInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Log
        '
        Me.Log.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Log.Location = New System.Drawing.Point(248, 380)
        Me.Log.Multiline = True
        Me.Log.Name = "Log"
        Me.Log.ReadOnly = True
        Me.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Log.Size = New System.Drawing.Size(532, 81)
        Me.Log.TabIndex = 1
        Me.Log.WordWrap = False
        '
        'gGamePath
        '
        Me.gGamePath.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gGamePath.Controls.Add(Me.Button2)
        Me.gGamePath.Controls.Add(Me.Button1)
        Me.gGamePath.Controls.Add(Me.Label2)
        Me.gGamePath.Controls.Add(Me.tDNFPath)
        Me.gGamePath.Controls.Add(Me.Label1)
        Me.gGamePath.Location = New System.Drawing.Point(248, 12)
        Me.gGamePath.Name = "gGamePath"
        Me.gGamePath.Size = New System.Drawing.Size(532, 362)
        Me.gGamePath.TabIndex = 6
        Me.gGamePath.TabStop = False
        Me.gGamePath.Text = "设置游戏路径"
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(6, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(520, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "手动选择"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(6, 59)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(520, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "自动查找"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(311, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "说明：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "①游戏路径为游戏主目录，如：E:\WeGay\地上城与鬼剑士" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "②软件默认会记录最后一次设置的游戏路径"
        '
        'tDNFPath
        '
        Me.tDNFPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tDNFPath.Location = New System.Drawing.Point(6, 32)
        Me.tDNFPath.Name = "tDNFPath"
        Me.tDNFPath.Size = New System.Drawing.Size(520, 21)
        Me.tDNFPath.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DNF游戏路径"
        '
        'tv
        '
        Me.tv.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tv.Location = New System.Drawing.Point(12, 12)
        Me.tv.Name = "tv"
        TreeNode64.Name = "节点1"
        TreeNode64.Text = "设置游戏目录"
        TreeNode65.Name = "节点0"
        TreeNode65.Text = "设置"
        TreeNode66.Name = "节点3"
        TreeNode66.Text = "禁用设置 (禁用|解禁)"
        TreeNode67.Name = "节点4"
        TreeNode67.Text = "禁用清单 (修改清单|手动模式)"
        TreeNode68.Name = "节点2"
        TreeNode68.Text = "常规禁用 (IFEO+ACL)"
        TreeNode69.Name = "节点6"
        TreeNode69.Text = "拦截设置 (注册|卸载|启停)"
        TreeNode70.Name = "节点7"
        TreeNode70.Text = "拦截清单 (修改清单)"
        TreeNode71.Name = "节点5"
        TreeNode71.Text = "驱动拦截 (vLimit)"
        TreeNode72.Name = "节点9"
        TreeNode72.Text = "后台模式"
        TreeNode73.Name = "节点10"
        TreeNode73.Text = "chkdsk磁盘检查"
        TreeNode74.Name = "节点11"
        TreeNode74.Text = "修复文件权限"
        TreeNode75.Name = "节点13"
        TreeNode75.Text = "精简客户端"
        TreeNode76.Name = "节点14"
        TreeNode76.Text = "Win10自动维护"
        TreeNode77.Name = "节点16"
        TreeNode77.Text = "重置游戏配置文件"
        TreeNode78.Name = "节点17"
        TreeNode78.Text = "卸载DNF"
        TreeNode79.Name = "节点18"
        TreeNode79.Text = "蓝屏"
        TreeNode80.Name = "节点8"
        TreeNode80.Text = "扩展功能"
        TreeNode81.Name = "节点1"
        TreeNode81.Text = "软件更新"
        TreeNode82.Name = "节点2"
        TreeNode82.Text = "联系我们&提交建议"
        TreeNode83.Name = "节点3"
        TreeNode83.Text = "赞助开发者"
        TreeNode84.Name = "节点0"
        TreeNode84.Text = "其他功能(更新+联系+赞助)"
        Me.tv.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode65, TreeNode68, TreeNode71, TreeNode80, TreeNode84})
        Me.tv.Size = New System.Drawing.Size(230, 449)
        Me.tv.TabIndex = 7
        '
        'gNList
        '
        Me.gNList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gNList.Controls.Add(Me.NList)
        Me.gNList.Controls.Add(Me.Label3)
        Me.gNList.Location = New System.Drawing.Point(248, 12)
        Me.gNList.Name = "gNList"
        Me.gNList.Size = New System.Drawing.Size(532, 362)
        Me.gNList.TabIndex = 7
        Me.gNList.TabStop = False
        Me.gNList.Text = "常规禁用清单"
        '
        'NList
        '
        Me.NList.AllowUserToAddRows = False
        Me.NList.AllowUserToDeleteRows = False
        Me.NList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column6, Me.Column4, Me.Column5, Me.Column2})
        Me.NList.ContextMenuStrip = Me.NListMenu
        Me.NList.Location = New System.Drawing.Point(6, 20)
        Me.NList.MultiSelect = False
        Me.NList.Name = "NList"
        Me.NList.ReadOnly = True
        Me.NList.RowHeadersVisible = False
        Me.NList.RowTemplate.Height = 23
        Me.NList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.NList.Size = New System.Drawing.Size(520, 288)
        Me.NList.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.HeaderText = "插件名称"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "插件状态"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "禁用方式"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column6.Width = 80
        '
        'Column4
        '
        Me.Column4.HeaderText = "IFEO操作"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "ACL操作"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column5.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "插件路径"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'NListMenu
        '
        Me.NListMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.添加插件ToolStripMenuItem, Me.修改插件ToolStripMenuItem, Me.修改禁用方式ToolStripMenuItem, Me.刷新ToolStripMenuItem})
        Me.NListMenu.Name = "NListMenu"
        Me.NListMenu.Size = New System.Drawing.Size(149, 92)
        '
        '添加插件ToolStripMenuItem
        '
        Me.添加插件ToolStripMenuItem.Name = "添加插件ToolStripMenuItem"
        Me.添加插件ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.添加插件ToolStripMenuItem.Text = "添加插件"
        '
        '修改插件ToolStripMenuItem
        '
        Me.修改插件ToolStripMenuItem.Name = "修改插件ToolStripMenuItem"
        Me.修改插件ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.修改插件ToolStripMenuItem.Text = "删除插件"
        '
        '修改禁用方式ToolStripMenuItem
        '
        Me.修改禁用方式ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IFEO或ACLToolStripMenuItem, Me.仅IFEOToolStripMenuItem, Me.仅ACLToolStripMenuItem})
        Me.修改禁用方式ToolStripMenuItem.Name = "修改禁用方式ToolStripMenuItem"
        Me.修改禁用方式ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.修改禁用方式ToolStripMenuItem.Text = "修改禁用方式"
        '
        'IFEO或ACLToolStripMenuItem
        '
        Me.IFEO或ACLToolStripMenuItem.Name = "IFEO或ACLToolStripMenuItem"
        Me.IFEO或ACLToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.IFEO或ACLToolStripMenuItem.Text = "IFEO或ACL"
        '
        '仅IFEOToolStripMenuItem
        '
        Me.仅IFEOToolStripMenuItem.Name = "仅IFEOToolStripMenuItem"
        Me.仅IFEOToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.仅IFEOToolStripMenuItem.Text = "仅IFEO"
        '
        '仅ACLToolStripMenuItem
        '
        Me.仅ACLToolStripMenuItem.Name = "仅ACLToolStripMenuItem"
        Me.仅ACLToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.仅ACLToolStripMenuItem.Text = "仅ACL"
        '
        '刷新ToolStripMenuItem
        '
        Me.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem"
        Me.刷新ToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.刷新ToolStripMenuItem.Text = "刷新"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(287, 48)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "说明：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "①常规禁用基于IFEO及ACL禁用(相关词汇不懂情百度)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "②可分别对插件进行IFEO禁用及ACL禁用" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "③右键刷新、新增、删除、修改"
        '
        'gNormal
        '
        Me.gNormal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gNormal.Controls.Add(Me.Button29)
        Me.gNormal.Controls.Add(Me.Button28)
        Me.gNormal.Controls.Add(Me.Button4)
        Me.gNormal.Controls.Add(Me.Button3)
        Me.gNormal.Controls.Add(Me.Label4)
        Me.gNormal.Location = New System.Drawing.Point(248, 12)
        Me.gNormal.Name = "gNormal"
        Me.gNormal.Size = New System.Drawing.Size(532, 362)
        Me.gNormal.TabIndex = 8
        Me.gNormal.TabStop = False
        Me.gNormal.Text = "禁用设置"
        '
        'Button29
        '
        Me.Button29.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button29.Location = New System.Drawing.Point(6, 78)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(520, 23)
        Me.Button29.TabIndex = 6
        Me.Button29.Text = "重置现有清单为默认清单"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'Button28
        '
        Me.Button28.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button28.Location = New System.Drawing.Point(6, 107)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(520, 23)
        Me.Button28.TabIndex = 5
        Me.Button28.Text = "Win10未能转换部分或所有标识引用 解决方法"
        Me.Button28.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(6, 49)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(520, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "一键还原"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(6, 20)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(520, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "一键禁用"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(281, 48)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "说明：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "①一键禁用：用适用绝大多数人的方案禁用插件" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "②一键恢复：将所有清单内插件还原" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "③重置清单为默认清单：清除现有清单，重置为默认"
        '
        'gNormalInfo
        '
        Me.gNormalInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gNormalInfo.Controls.Add(Me.TextBox1)
        Me.gNormalInfo.Location = New System.Drawing.Point(248, 12)
        Me.gNormalInfo.Name = "gNormalInfo"
        Me.gNormalInfo.Size = New System.Drawing.Size(532, 362)
        Me.gNormalInfo.TabIndex = 9
        Me.gNormalInfo.TabStop = False
        Me.gNormalInfo.Text = "常规禁用说明"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(8, 20)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(518, 336)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'gDList
        '
        Me.gDList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gDList.Controls.Add(Me.DList)
        Me.gDList.Controls.Add(Me.Label5)
        Me.gDList.Location = New System.Drawing.Point(248, 12)
        Me.gDList.Name = "gDList"
        Me.gDList.Size = New System.Drawing.Size(532, 362)
        Me.gDList.TabIndex = 8
        Me.gDList.TabStop = False
        Me.gDList.Text = "驱动拦截清单(当前)"
        '
        'DList
        '
        Me.DList.AllowUserToAddRows = False
        Me.DList.AllowUserToDeleteRows = False
        Me.DList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.DList.ContextMenuStrip = Me.DLisMenu
        Me.DList.Location = New System.Drawing.Point(6, 20)
        Me.DList.MultiSelect = False
        Me.DList.Name = "DList"
        Me.DList.ReadOnly = True
        Me.DList.RowHeadersVisible = False
        Me.DList.RowTemplate.Height = 23
        Me.DList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DList.Size = New System.Drawing.Size(520, 288)
        Me.DList.TabIndex = 3
        '
        'Column7
        '
        Me.Column7.HeaderText = "拦截目标"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "拦截方式"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "指定父进程"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "文件路径"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'DLisMenu
        '
        Me.DLisMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.添加拦截ToolStripMenuItem, Me.删除拦截ToolStripMenuItem, Me.修改AltitudeToolStripMenuItem, Me.引用常规禁用的清单ToolStripMenuItem})
        Me.DLisMenu.Name = "NListMenu"
        Me.DLisMenu.Size = New System.Drawing.Size(185, 92)
        '
        '添加拦截ToolStripMenuItem
        '
        Me.添加拦截ToolStripMenuItem.Name = "添加拦截ToolStripMenuItem"
        Me.添加拦截ToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.添加拦截ToolStripMenuItem.Text = "添加拦截"
        '
        '删除拦截ToolStripMenuItem
        '
        Me.删除拦截ToolStripMenuItem.Name = "删除拦截ToolStripMenuItem"
        Me.删除拦截ToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.删除拦截ToolStripMenuItem.Text = "删除拦截"
        '
        '修改AltitudeToolStripMenuItem
        '
        Me.修改AltitudeToolStripMenuItem.Name = "修改AltitudeToolStripMenuItem"
        Me.修改AltitudeToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.修改AltitudeToolStripMenuItem.Text = "修改Altitude"
        '
        '引用常规禁用的清单ToolStripMenuItem
        '
        Me.引用常规禁用的清单ToolStripMenuItem.Name = "引用常规禁用的清单ToolStripMenuItem"
        Me.引用常规禁用的清单ToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.引用常规禁用的清单ToolStripMenuItem.Text = "引用常规禁用的清单"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(335, 48)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "说明：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "①驱动拦截基于Windows内核驱动，对exe及dll的载入进行拦截" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "②如遇蓝屏，请提供DMP文件进行分析，或者放弃使用此功能" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "③右键新增、删除、修" &
    "改、引用"
        '
        'gDriver
        '
        Me.gDriver.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gDriver.Controls.Add(Me.Button10)
        Me.gDriver.Controls.Add(Me.Button9)
        Me.gDriver.Controls.Add(Me.Button8)
        Me.gDriver.Controls.Add(Me.Button7)
        Me.gDriver.Controls.Add(Me.Button5)
        Me.gDriver.Controls.Add(Me.Label10)
        Me.gDriver.Controls.Add(Me.tDRStatus)
        Me.gDriver.Controls.Add(Me.Label9)
        Me.gDriver.Controls.Add(Me.tDSStatus)
        Me.gDriver.Controls.Add(Me.Label8)
        Me.gDriver.Controls.Add(Me.tDFStatus)
        Me.gDriver.Controls.Add(Me.tDPath)
        Me.gDriver.Controls.Add(Me.Label7)
        Me.gDriver.Controls.Add(Me.Button6)
        Me.gDriver.Controls.Add(Me.Label6)
        Me.gDriver.Location = New System.Drawing.Point(248, 12)
        Me.gDriver.Name = "gDriver"
        Me.gDriver.Size = New System.Drawing.Size(532, 362)
        Me.gDriver.TabIndex = 9
        Me.gDriver.TabStop = False
        Me.gDriver.Text = "拦截设置"
        '
        'Button10
        '
        Me.Button10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.Location = New System.Drawing.Point(6, 274)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(520, 23)
        Me.Button10.TabIndex = 16
        Me.Button10.Text = "删除所有文件"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.Location = New System.Drawing.Point(6, 245)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(520, 23)
        Me.Button9.TabIndex = 15
        Me.Button9.Text = "卸载驱动服务"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.Location = New System.Drawing.Point(6, 216)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(520, 23)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "停止驱动服务"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.Location = New System.Drawing.Point(6, 187)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(520, 23)
        Me.Button7.TabIndex = 13
        Me.Button7.Text = "启动驱动服务"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(6, 158)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(520, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "注册驱动服务"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 104)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 12)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "运行状态"
        '
        'tDRStatus
        '
        Me.tDRStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tDRStatus.Location = New System.Drawing.Point(110, 101)
        Me.tDRStatus.Name = "tDRStatus"
        Me.tDRStatus.ReadOnly = True
        Me.tDRStatus.Size = New System.Drawing.Size(416, 21)
        Me.tDRStatus.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "服务状态"
        '
        'tDSStatus
        '
        Me.tDSStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tDSStatus.Location = New System.Drawing.Point(110, 74)
        Me.tDSStatus.Name = "tDSStatus"
        Me.tDSStatus.ReadOnly = True
        Me.tDSStatus.Size = New System.Drawing.Size(416, 21)
        Me.tDSStatus.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "文件状态"
        '
        'tDFStatus
        '
        Me.tDFStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tDFStatus.Location = New System.Drawing.Point(110, 47)
        Me.tDFStatus.Name = "tDFStatus"
        Me.tDFStatus.ReadOnly = True
        Me.tDFStatus.Size = New System.Drawing.Size(416, 21)
        Me.tDFStatus.TabIndex = 6
        '
        'tDPath
        '
        Me.tDPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tDPath.Location = New System.Drawing.Point(110, 20)
        Me.tDPath.Name = "tDPath"
        Me.tDPath.ReadOnly = True
        Me.tDPath.Size = New System.Drawing.Size(416, 21)
        Me.tDPath.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "驱动文件"
        '
        'Button6
        '
        Me.Button6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(6, 129)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(520, 23)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "检测驱动状态"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 311)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(209, 36)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "说明：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "①启用驱动：设置拦截清单>注册>启动" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "②停用驱动：停止>卸载"
        '
        'gHello
        '
        Me.gHello.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gHello.Controls.Add(Me.TextBox2)
        Me.gHello.Location = New System.Drawing.Point(248, 12)
        Me.gHello.Name = "gHello"
        Me.gHello.Size = New System.Drawing.Size(532, 362)
        Me.gHello.TabIndex = 10
        Me.gHello.TabStop = False
        Me.gHello.Text = "说明文档"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(8, 20)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox2.Size = New System.Drawing.Size(518, 336)
        Me.TextBox2.TabIndex = 0
        '
        'gExtraInfo
        '
        Me.gExtraInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gExtraInfo.Controls.Add(Me.TextBox3)
        Me.gExtraInfo.Location = New System.Drawing.Point(248, 12)
        Me.gExtraInfo.Name = "gExtraInfo"
        Me.gExtraInfo.Size = New System.Drawing.Size(532, 362)
        Me.gExtraInfo.TabIndex = 11
        Me.gExtraInfo.TabStop = False
        Me.gExtraInfo.Text = "扩展功能"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(8, 20)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox3.Size = New System.Drawing.Size(518, 336)
        Me.TextBox3.TabIndex = 0
        Me.TextBox3.Text = resources.GetString("TextBox3.Text")
        '
        'gExtra_chkdsk
        '
        Me.gExtra_chkdsk.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gExtra_chkdsk.Controls.Add(Me.Label11)
        Me.gExtra_chkdsk.Controls.Add(Me.Button13)
        Me.gExtra_chkdsk.Controls.Add(Me.Button12)
        Me.gExtra_chkdsk.Controls.Add(Me.Button11)
        Me.gExtra_chkdsk.Location = New System.Drawing.Point(248, 12)
        Me.gExtra_chkdsk.Name = "gExtra_chkdsk"
        Me.gExtra_chkdsk.Size = New System.Drawing.Size(532, 362)
        Me.gExtra_chkdsk.TabIndex = 12
        Me.gExtra_chkdsk.TabStop = False
        Me.gExtra_chkdsk.Text = "chkdsk磁盘检查"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 300)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(401, 48)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "说明：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "①chkdsk磁盘检查可以实现逻辑坏道修复、文件修复、重建NTFS索引等功能" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "②基于chkdsk /f参数" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "③检查系统盘必须重启，检查游戏盘必须关闭" &
    "所有句柄（强制关闭）"
        '
        'Button13
        '
        Me.Button13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button13.Location = New System.Drawing.Point(6, 74)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(520, 23)
        Me.Button13.TabIndex = 3
        Me.Button13.Text = "同时检查系统盘与游戏盘"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button12.Location = New System.Drawing.Point(6, 47)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(520, 23)
        Me.Button12.TabIndex = 2
        Me.Button12.Text = "仅检查游戏盘"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button11.Location = New System.Drawing.Point(6, 20)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(520, 23)
        Me.Button11.TabIndex = 1
        Me.Button11.Text = "仅检查系统盘"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'gExtra_takeown
        '
        Me.gExtra_takeown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gExtra_takeown.Controls.Add(Me.TextBox4)
        Me.gExtra_takeown.Controls.Add(Me.Label12)
        Me.gExtra_takeown.Controls.Add(Me.Button14)
        Me.gExtra_takeown.Location = New System.Drawing.Point(248, 12)
        Me.gExtra_takeown.Name = "gExtra_takeown"
        Me.gExtra_takeown.Size = New System.Drawing.Size(532, 362)
        Me.gExtra_takeown.TabIndex = 13
        Me.gExtra_takeown.TabStop = False
        Me.gExtra_takeown.Text = "修复文件权限"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Location = New System.Drawing.Point(8, 20)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox4.Size = New System.Drawing.Size(518, 248)
        Me.TextBox4.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 300)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(455, 48)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "说明：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "①修复文件权限功能会删除ACL所有现有权限，并添加Everyone:Allow的访问权" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "②如上述修复失败，则会先使用系统takeown软件获取目标所有" &
    "权，再尝试执行步骤①" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "③如步骤②依旧失败，则可能需要手动修复权限"
        '
        'Button14
        '
        Me.Button14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button14.Location = New System.Drawing.Point(6, 274)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(520, 23)
        Me.Button14.TabIndex = 3
        Me.Button14.Text = "修复文件权限"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'gExtra_trim
        '
        Me.gExtra_trim.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gExtra_trim.Controls.Add(Me.CheckBox14)
        Me.gExtra_trim.Controls.Add(Me.CheckBox13)
        Me.gExtra_trim.Controls.Add(Me.CheckBox12)
        Me.gExtra_trim.Controls.Add(Me.CheckBox11)
        Me.gExtra_trim.Controls.Add(Me.CheckBox10)
        Me.gExtra_trim.Controls.Add(Me.CheckBox9)
        Me.gExtra_trim.Controls.Add(Me.TextBox5)
        Me.gExtra_trim.Controls.Add(Me.Label13)
        Me.gExtra_trim.Controls.Add(Me.Button15)
        Me.gExtra_trim.Location = New System.Drawing.Point(248, 12)
        Me.gExtra_trim.Name = "gExtra_trim"
        Me.gExtra_trim.Size = New System.Drawing.Size(532, 362)
        Me.gExtra_trim.TabIndex = 14
        Me.gExtra_trim.TabStop = False
        Me.gExtra_trim.Text = "精简客户端"
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Checked = True
        Me.CheckBox14.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox14.Location = New System.Drawing.Point(266, 57)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(204, 16)
        Me.CheckBox14.TabIndex = 11
        Me.CheckBox14.Text = "冗余文件（配置文件夹冗余文件）"
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'CheckBox13
        '
        Me.CheckBox13.AutoSize = True
        Me.CheckBox13.Checked = True
        Me.CheckBox13.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox13.Location = New System.Drawing.Point(266, 37)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(174, 16)
        Me.CheckBox13.TabIndex = 10
        Me.CheckBox13.Text = "调试文件（CrashDNF2.cra）"
        Me.CheckBox13.UseVisualStyleBackColor = True
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Checked = True
        Me.CheckBox12.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox12.Location = New System.Drawing.Point(266, 17)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(180, 16)
        Me.CheckBox12.TabIndex = 9
        Me.CheckBox12.Text = "日志文件（log、dat等文件）"
        Me.CheckBox12.UseVisualStyleBackColor = True
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Checked = True
        Me.CheckBox11.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox11.Location = New System.Drawing.Point(11, 57)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(222, 16)
        Me.CheckBox11.TabIndex = 8
        Me.CheckBox11.Text = "TGuard临时文件（TGuard、TP_Temp）"
        Me.CheckBox11.UseVisualStyleBackColor = True
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Checked = True
        Me.CheckBox10.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox10.Location = New System.Drawing.Point(11, 37)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(222, 16)
        Me.CheckBox10.TabIndex = 7
        Me.CheckBox10.Text = "附加组件（components、EXPlugins）"
        Me.CheckBox10.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Checked = True
        Me.CheckBox9.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox9.Location = New System.Drawing.Point(11, 17)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(168, 16)
        Me.CheckBox9.TabIndex = 6
        Me.CheckBox9.Text = "更新安装包（tgppatches）"
        Me.CheckBox9.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(11, 81)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox5.Size = New System.Drawing.Size(515, 187)
        Me.TextBox5.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 300)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(305, 36)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "说明：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "①此功能将删除各类更新及安装包" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "②点击""精简客户端后""，将立即删除上述文件且无法恢复"
        '
        'Button15
        '
        Me.Button15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button15.Location = New System.Drawing.Point(6, 274)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(520, 23)
        Me.Button15.TabIndex = 3
        Me.Button15.Text = "精简客户端"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'gExtra_Win10MTC
        '
        Me.gExtra_Win10MTC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gExtra_Win10MTC.Controls.Add(Me.Button18)
        Me.gExtra_Win10MTC.Controls.Add(Me.Button17)
        Me.gExtra_Win10MTC.Controls.Add(Me.TextBox7)
        Me.gExtra_Win10MTC.Controls.Add(Me.Label16)
        Me.gExtra_Win10MTC.Controls.Add(Me.TextBox6)
        Me.gExtra_Win10MTC.Controls.Add(Me.Label15)
        Me.gExtra_Win10MTC.Controls.Add(Me.Label14)
        Me.gExtra_Win10MTC.Controls.Add(Me.Button16)
        Me.gExtra_Win10MTC.Location = New System.Drawing.Point(248, 12)
        Me.gExtra_Win10MTC.Name = "gExtra_Win10MTC"
        Me.gExtra_Win10MTC.Size = New System.Drawing.Size(532, 362)
        Me.gExtra_Win10MTC.TabIndex = 15
        Me.gExtra_Win10MTC.TabStop = False
        Me.gExtra_Win10MTC.Text = "Win10自动维护"
        '
        'Button18
        '
        Me.Button18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button18.Location = New System.Drawing.Point(6, 134)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(520, 23)
        Me.Button18.TabIndex = 10
        Me.Button18.Text = "恢复"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button17.Location = New System.Drawing.Point(6, 105)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(520, 23)
        Me.Button17.TabIndex = 9
        Me.Button17.Text = "禁用"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.Location = New System.Drawing.Point(195, 49)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(331, 21)
        Me.TextBox7.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 12)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "自动维护"
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.Location = New System.Drawing.Point(195, 20)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(331, 21)
        Me.TextBox6.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 12)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "系统版本"
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 300)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(497, 48)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "说明：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "①通过禁用Win10自动维护功能来避免DNF长时间挂机诱发的蓝屏，对系统运行速度有负面影响" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "②注册表为HKLM\SOFTWARE\Microsoft\" &
    "Windows NT\CurrentVersion\Schedule\Maintenance" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "③键为MaintenanceDisabled，值DWORD:1禁" &
    "用"
        '
        'Button16
        '
        Me.Button16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button16.Location = New System.Drawing.Point(6, 76)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(520, 23)
        Me.Button16.TabIndex = 3
        Me.Button16.Text = "检测状态"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'gExtra_DNFCFG
        '
        Me.gExtra_DNFCFG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gExtra_DNFCFG.Controls.Add(Me.Button20)
        Me.gExtra_DNFCFG.Controls.Add(Me.TextBox9)
        Me.gExtra_DNFCFG.Controls.Add(Me.Label18)
        Me.gExtra_DNFCFG.Controls.Add(Me.Label19)
        Me.gExtra_DNFCFG.Controls.Add(Me.Button21)
        Me.gExtra_DNFCFG.Location = New System.Drawing.Point(248, 12)
        Me.gExtra_DNFCFG.Name = "gExtra_DNFCFG"
        Me.gExtra_DNFCFG.Size = New System.Drawing.Size(532, 362)
        Me.gExtra_DNFCFG.TabIndex = 16
        Me.gExtra_DNFCFG.TabStop = False
        Me.gExtra_DNFCFG.Text = "重置游戏配置文件"
        '
        'Button20
        '
        Me.Button20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button20.Location = New System.Drawing.Point(6, 105)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(520, 23)
        Me.Button20.TabIndex = 9
        Me.Button20.Text = "重置"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.Location = New System.Drawing.Point(195, 20)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(331, 21)
        Me.TextBox9.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 12)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "游戏配置文件"
        '
        'Label19
        '
        Me.Label19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 300)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(257, 36)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "说明：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "①通过删除游戏配置文件，以恢复DNF默认设置" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "②可解决登录即中断、黑屏、频道无响应等问题"
        '
        'Button21
        '
        Me.Button21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button21.Location = New System.Drawing.Point(6, 76)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(520, 23)
        Me.Button21.TabIndex = 3
        Me.Button21.Text = "查找配置文件"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'gExtra_Purge
        '
        Me.gExtra_Purge.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gExtra_Purge.Controls.Add(Me.Label17)
        Me.gExtra_Purge.Controls.Add(Me.Button22)
        Me.gExtra_Purge.Controls.Add(Me.Button23)
        Me.gExtra_Purge.Location = New System.Drawing.Point(248, 12)
        Me.gExtra_Purge.Name = "gExtra_Purge"
        Me.gExtra_Purge.Size = New System.Drawing.Size(532, 362)
        Me.gExtra_Purge.TabIndex = 17
        Me.gExtra_Purge.TabStop = False
        Me.gExtra_Purge.Text = "卸载DNF"
        '
        'Label17
        '
        Me.Label17.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 300)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 24)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "说明：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "①阿拉德再见"
        '
        'Button22
        '
        Me.Button22.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button22.Location = New System.Drawing.Point(6, 47)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(520, 23)
        Me.Button22.TabIndex = 2
        Me.Button22.Text = "强制删除DNF文件目录"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button23.Location = New System.Drawing.Point(6, 20)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(520, 23)
        Me.Button23.TabIndex = 1
        Me.Button23.Text = "使用游戏自带卸载程序卸载DNF"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'gExtra_BSOD
        '
        Me.gExtra_BSOD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gExtra_BSOD.Controls.Add(Me.Label20)
        Me.gExtra_BSOD.Controls.Add(Me.Button24)
        Me.gExtra_BSOD.Location = New System.Drawing.Point(248, 12)
        Me.gExtra_BSOD.Name = "gExtra_BSOD"
        Me.gExtra_BSOD.Size = New System.Drawing.Size(532, 362)
        Me.gExtra_BSOD.TabIndex = 18
        Me.gExtra_BSOD.TabStop = False
        Me.gExtra_BSOD.Text = "蓝屏"
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 300)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(293, 48)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "说明：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "①强迫症、钢精、营养人专属蓝屏方案，点一个蓝一个" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "②点击即蓝" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "③无后悔药"
        '
        'Button24
        '
        Me.Button24.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button24.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button24.Location = New System.Drawing.Point(6, 20)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(520, 266)
        Me.Button24.TabIndex = 1
        Me.Button24.Text = "让蓝屏来的更猛烈些吧"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'gExtra_Background
        '
        Me.gExtra_Background.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gExtra_Background.Controls.Add(Me.LinkLabel1)
        Me.gExtra_Background.Controls.Add(Me.ComboBox1)
        Me.gExtra_Background.Controls.Add(Me.CheckBox8)
        Me.gExtra_Background.Controls.Add(Me.CheckBox7)
        Me.gExtra_Background.Controls.Add(Me.Button19)
        Me.gExtra_Background.Controls.Add(Me.CheckBox5)
        Me.gExtra_Background.Controls.Add(Me.CheckBox4)
        Me.gExtra_Background.Controls.Add(Me.TextBox8)
        Me.gExtra_Background.Controls.Add(Me.Label22)
        Me.gExtra_Background.Controls.Add(Me.CheckBox3)
        Me.gExtra_Background.Controls.Add(Me.CheckBox2)
        Me.gExtra_Background.Controls.Add(Me.CheckBox1)
        Me.gExtra_Background.Controls.Add(Me.Label21)
        Me.gExtra_Background.Location = New System.Drawing.Point(248, 12)
        Me.gExtra_Background.Name = "gExtra_Background"
        Me.gExtra_Background.Size = New System.Drawing.Size(532, 362)
        Me.gExtra_Background.TabIndex = 19
        Me.gExtra_Background.TabStop = False
        Me.gExtra_Background.Text = "后台模式"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"模式A：提权冻结(单开限定)", "模式B：替换运行"})
        Me.ComboBox1.Location = New System.Drawing.Point(308, 160)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(218, 20)
        Me.ComboBox1.TabIndex = 15
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(8, 162)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(294, 16)
        Me.CheckBox8.TabIndex = 14
        Me.CheckBox8.Text = "自动限制SGuard服务（AntiCheatExpert Service）"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Location = New System.Drawing.Point(8, 140)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(156, 16)
        Me.CheckBox7.TabIndex = 13
        Me.CheckBox7.Text = "自动关闭TesService服务"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(6, 267)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(520, 23)
        Me.Button19.TabIndex = 12
        Me.Button19.Text = "Button19"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(8, 245)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(96, 16)
        Me.CheckBox5.TabIndex = 11
        Me.CheckBox5.Text = "设置开机启动"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(8, 223)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox4.TabIndex = 10
        Me.CheckBox4.Text = "弹出通知"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(101, 20)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(45, 21)
        Me.TextBox8.TabIndex = 9
        Me.TextBox8.Text = "5"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(89, 12)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "扫描件间隔(秒)"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(8, 118)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(210, 16)
        Me.CheckBox3.TabIndex = 7
        Me.CheckBox3.Text = "自动关闭TGuard服务（TGuardSvc）"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(8, 96)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(252, 16)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.Text = "游戏运行60秒后，自动结束GameLoader.exe"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(8, 74)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(234, 16)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "游戏运行60秒后，自动结束TenioDL.exe"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 300)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(389, 36)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "说明：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "①软件在后台自动处理相应任务" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "②开启后台模式后，最小化将隐藏软件本体，可通过双击右下角图标还原"
        '
        'Background_Timer
        '
        '
        'Background_Icon
        '
        '
        'gOther_Update
        '
        Me.gOther_Update.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gOther_Update.Controls.Add(Me.CheckBox6)
        Me.gOther_Update.Controls.Add(Me.TextBox12)
        Me.gOther_Update.Controls.Add(Me.Label26)
        Me.gOther_Update.Controls.Add(Me.TextBox10)
        Me.gOther_Update.Controls.Add(Me.Label23)
        Me.gOther_Update.Controls.Add(Me.TextBox11)
        Me.gOther_Update.Controls.Add(Me.Label24)
        Me.gOther_Update.Controls.Add(Me.Label25)
        Me.gOther_Update.Controls.Add(Me.Button27)
        Me.gOther_Update.Location = New System.Drawing.Point(248, 12)
        Me.gOther_Update.Name = "gOther_Update"
        Me.gOther_Update.Size = New System.Drawing.Size(532, 362)
        Me.gOther_Update.TabIndex = 20
        Me.gOther_Update.TabStop = False
        Me.gOther_Update.Text = "软件更新"
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(8, 141)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(144, 16)
        Me.CheckBox6.TabIndex = 13
        Me.CheckBox6.Text = "运行软件时不搜索更新"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'TextBox12
        '
        Me.TextBox12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox12.Location = New System.Drawing.Point(195, 78)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(331, 21)
        Me.TextBox12.TabIndex = 12
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(12, 81)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(113, 12)
        Me.Label26.TabIndex = 11
        Me.Label26.Text = "更新地址(点击访问)"
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox10.Location = New System.Drawing.Point(195, 49)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(331, 21)
        Me.TextBox10.TabIndex = 8
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(12, 52)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 12)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "最新版本"
        '
        'TextBox11
        '
        Me.TextBox11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox11.Location = New System.Drawing.Point(195, 20)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(331, 21)
        Me.TextBox11.TabIndex = 6
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(12, 23)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 12)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "当前软件版本"
        '
        'Label25
        '
        Me.Label25.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 300)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(125, 24)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "说明：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "①搜索软件的更新版本"
        '
        'Button27
        '
        Me.Button27.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button27.Location = New System.Drawing.Point(6, 111)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(520, 23)
        Me.Button27.TabIndex = 3
        Me.Button27.Text = "搜索更新"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'gOther_Contact
        '
        Me.gOther_Contact.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gOther_Contact.Controls.Add(Me.TextBox14)
        Me.gOther_Contact.Controls.Add(Me.Label29)
        Me.gOther_Contact.Controls.Add(Me.PictureBox4)
        Me.gOther_Contact.Controls.Add(Me.Button26)
        Me.gOther_Contact.Controls.Add(Me.TextBox13)
        Me.gOther_Contact.Controls.Add(Me.Label27)
        Me.gOther_Contact.Controls.Add(Me.PictureBox1)
        Me.gOther_Contact.Controls.Add(Me.Button25)
        Me.gOther_Contact.Location = New System.Drawing.Point(248, 12)
        Me.gOther_Contact.Name = "gOther_Contact"
        Me.gOther_Contact.Size = New System.Drawing.Size(532, 362)
        Me.gOther_Contact.TabIndex = 21
        Me.gOther_Contact.TabStop = False
        Me.gOther_Contact.Text = "联系我们"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(308, 278)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.ReadOnly = True
        Me.TextBox14.Size = New System.Drawing.Size(191, 21)
        Me.TextBox14.TabIndex = 16
        Me.TextBox14.Text = "679078251"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(261, 283)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(41, 12)
        Me.Label29.TabIndex = 15
        Me.Label29.Text = "群号："
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.神秘力量V.My.Resources.Resources.qun2
        Me.PictureBox4.Location = New System.Drawing.Point(266, 20)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(238, 250)
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'Button26
        '
        Me.Button26.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button26.Location = New System.Drawing.Point(260, 306)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(266, 23)
        Me.Button26.TabIndex = 13
        Me.Button26.Text = "点击加入交♂流♂群（入群费1.0元）"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(61, 276)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.ReadOnly = True
        Me.TextBox13.Size = New System.Drawing.Size(191, 21)
        Me.TextBox13.TabIndex = 8
        Me.TextBox13.Text = "421483534"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(14, 281)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(41, 12)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "群号："
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.神秘力量V.My.Resources.Resources.qun1
        Me.PictureBox1.Location = New System.Drawing.Point(14, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 250)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button25
        '
        Me.Button25.Location = New System.Drawing.Point(6, 306)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(246, 23)
        Me.Button25.TabIndex = 5
        Me.Button25.Text = "点击加入交流群（入群费0.1元）"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'gOther_Donate
        '
        Me.gOther_Donate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gOther_Donate.Controls.Add(Me.PictureBox3)
        Me.gOther_Donate.Controls.Add(Me.Label28)
        Me.gOther_Donate.Controls.Add(Me.PictureBox2)
        Me.gOther_Donate.Location = New System.Drawing.Point(248, 12)
        Me.gOther_Donate.Name = "gOther_Donate"
        Me.gOther_Donate.Size = New System.Drawing.Size(532, 362)
        Me.gOther_Donate.TabIndex = 22
        Me.gOther_Donate.TabStop = False
        Me.gOther_Donate.Text = "赞助开发者"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.神秘力量V.My.Resources.Resources.zfb
        Me.PictureBox3.Location = New System.Drawing.Point(131, 20)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 135)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'Label28
        '
        Me.Label28.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 300)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(197, 48)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "说明：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "①一块两块不嫌少，百八十万不嫌多" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "②开心♂就好" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "③我替黄旭东祝你这辈子都不出神话"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.神秘力量V.My.Resources.Resources.wx
        Me.PictureBox2.Location = New System.Drawing.Point(14, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 135)
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'gDriverInfo
        '
        Me.gDriverInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gDriverInfo.Controls.Add(Me.TextBox16)
        Me.gDriverInfo.Location = New System.Drawing.Point(248, 12)
        Me.gDriverInfo.Name = "gDriverInfo"
        Me.gDriverInfo.Size = New System.Drawing.Size(532, 362)
        Me.gDriverInfo.TabIndex = 23
        Me.gDriverInfo.TabStop = False
        Me.gDriverInfo.Text = "常规禁用说明"
        '
        'TextBox16
        '
        Me.TextBox16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox16.Location = New System.Drawing.Point(8, 20)
        Me.TextBox16.Multiline = True
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.ReadOnly = True
        Me.TextBox16.Size = New System.Drawing.Size(518, 336)
        Me.TextBox16.TabIndex = 0
        Me.TextBox16.Text = resources.GetString("TextBox16.Text")
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(308, 185)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(113, 12)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "点击下载替换资源包"
        Me.LinkLabel1.Visible = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 473)
        Me.Controls.Add(Me.gExtra_Background)
        Me.Controls.Add(Me.gExtra_trim)
        Me.Controls.Add(Me.gExtra_DNFCFG)
        Me.Controls.Add(Me.gDriverInfo)
        Me.Controls.Add(Me.gOther_Contact)
        Me.Controls.Add(Me.gOther_Donate)
        Me.Controls.Add(Me.gHello)
        Me.Controls.Add(Me.gDriver)
        Me.Controls.Add(Me.gNormal)
        Me.Controls.Add(Me.gOther_Update)
        Me.Controls.Add(Me.gDList)
        Me.Controls.Add(Me.gNormalInfo)
        Me.Controls.Add(Me.gExtraInfo)
        Me.Controls.Add(Me.gNList)
        Me.Controls.Add(Me.gExtra_BSOD)
        Me.Controls.Add(Me.gExtra_Purge)
        Me.Controls.Add(Me.gExtra_Win10MTC)
        Me.Controls.Add(Me.gExtra_takeown)
        Me.Controls.Add(Me.gExtra_chkdsk)
        Me.Controls.Add(Me.gGamePath)
        Me.Controls.Add(Me.tv)
        Me.Controls.Add(Me.Log)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form248.12"
        Me.gGamePath.ResumeLayout(False)
        Me.gGamePath.PerformLayout()
        Me.gNList.ResumeLayout(False)
        Me.gNList.PerformLayout()
        CType(Me.NList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NListMenu.ResumeLayout(False)
        Me.gNormal.ResumeLayout(False)
        Me.gNormal.PerformLayout()
        Me.gNormalInfo.ResumeLayout(False)
        Me.gNormalInfo.PerformLayout()
        Me.gDList.ResumeLayout(False)
        Me.gDList.PerformLayout()
        CType(Me.DList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DLisMenu.ResumeLayout(False)
        Me.gDriver.ResumeLayout(False)
        Me.gDriver.PerformLayout()
        Me.gHello.ResumeLayout(False)
        Me.gHello.PerformLayout()
        Me.gExtraInfo.ResumeLayout(False)
        Me.gExtraInfo.PerformLayout()
        Me.gExtra_chkdsk.ResumeLayout(False)
        Me.gExtra_chkdsk.PerformLayout()
        Me.gExtra_takeown.ResumeLayout(False)
        Me.gExtra_takeown.PerformLayout()
        Me.gExtra_trim.ResumeLayout(False)
        Me.gExtra_trim.PerformLayout()
        Me.gExtra_Win10MTC.ResumeLayout(False)
        Me.gExtra_Win10MTC.PerformLayout()
        Me.gExtra_DNFCFG.ResumeLayout(False)
        Me.gExtra_DNFCFG.PerformLayout()
        Me.gExtra_Purge.ResumeLayout(False)
        Me.gExtra_Purge.PerformLayout()
        Me.gExtra_BSOD.ResumeLayout(False)
        Me.gExtra_BSOD.PerformLayout()
        Me.gExtra_Background.ResumeLayout(False)
        Me.gExtra_Background.PerformLayout()
        Me.gOther_Update.ResumeLayout(False)
        Me.gOther_Update.PerformLayout()
        Me.gOther_Contact.ResumeLayout(False)
        Me.gOther_Contact.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gOther_Donate.ResumeLayout(False)
        Me.gOther_Donate.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gDriverInfo.ResumeLayout(False)
        Me.gDriverInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Log As TextBox
    Friend WithEvents gGamePath As GroupBox
    Friend WithEvents tDNFPath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents tv As TreeView
    Friend WithEvents gNList As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NList As DataGridView
    Friend WithEvents NListMenu As ContextMenuStrip
    Friend WithEvents 添加插件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 修改插件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 修改禁用方式ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IFEO或ACLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 仅IFEOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 仅ACLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 刷新ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewButtonColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents gNormal As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents gNormalInfo As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents gDList As GroupBox
    Friend WithEvents DList As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents DLisMenu As ContextMenuStrip
    Friend WithEvents 添加拦截ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 删除拦截ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gDriver As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tDRStatus As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tDSStatus As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tDFStatus As TextBox
    Friend WithEvents tDPath As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents 修改AltitudeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gHello As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents gExtraInfo As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents gExtra_chkdsk As GroupBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents gExtra_takeown As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Button14 As Button
    Friend WithEvents gExtra_trim As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button15 As Button
    Friend WithEvents gExtra_Win10MTC As GroupBox
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Button16 As Button
    Friend WithEvents gExtra_DNFCFG As GroupBox
    Friend WithEvents Button20 As Button
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Button21 As Button
    Friend WithEvents gExtra_Purge As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Button22 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents gExtra_BSOD As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Button24 As Button
    Friend WithEvents gExtra_Background As GroupBox
    Friend WithEvents Button19 As Button
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Background_Timer As Timer
    Friend WithEvents Background_Icon As NotifyIcon
    Friend WithEvents 引用常规禁用的清单ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gOther_Update As GroupBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Button27 As Button
    Friend WithEvents gOther_Contact As GroupBox
    Friend WithEvents Button25 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents gOther_Donate As GroupBox
    Friend WithEvents Label28 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button26 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents gDriverInfo As GroupBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Button29 As Button
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents CheckBox13 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
