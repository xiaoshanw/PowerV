Public Class Main
    Protected Overrides Sub WndProc(ByRef inMessage As Message)
        If inMessage.Msg = WM_SYSCOMMAND Then
            If inMessage.WParam.ToInt32() = SC_MINIMIZE Then
                If Background_Timer.Enabled = True Then
                    Background_Init(Background_Timer.Enabled)
                    Exit Sub
                End If
            End If
        End If
        MyBase.WndProc(inMessage)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gHello.BringToFront()
        TextBox2.Text = My.Resources.Hello
        If Not IO.Directory.Exists(CONFIG) Then IO.Directory.CreateDirectory(CONFIG)
        '创建配置文件夹
        If Not IO.Directory.Exists(IO.Path.GetDirectoryName(INI)) Then
            IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(INI))
        End If
        '表格双缓冲
        Dim DataGridView_Type As Type = NList.GetType
        Dim pi As Reflection.PropertyInfo = DataGridView_Type.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
        pi.SetValue(NList, True, Nothing)
        pi.SetValue(DList, True, Nothing)
        tv.ExpandAll()
        tDNFPath.Text = ReadINI(INI, "Settings", "DNFPath", "")
        'Dim tStr = Replace(Get_Version(), ".", "")
        Me.Text = "神秘力量V " + Get_Version() + "  Powered by VoCyt"

        '设置参数
        Dim Args_Background = False
        Dim Args_NoUpgrade = False
        For Each vline In My.Application.CommandLineArgs
            Select Case vline.ToLower
                Case "-b", "-bg", "-background"
                    Args_Background = True
                Case "-nu", "-noupgrade"
                    Args_NoUpgrade = True
            End Select
        Next
        If IO.File.Exists(CONFIG + "\NoAutoUpdate") Then Args_NoUpgrade = True
        '更新
        If Not Args_NoUpgrade Then
            Dim tClass = New Update_Class
            tClass.SrcForm = Me
            tClass.ifShowMessage = True
            Dim tThread = New Threading.Thread(AddressOf tClass.Get_Latest_Version)
            tThread.IsBackground = True
            tThread.Start()
        End If
        '自动后台
        If Args_Background Then
            bkCheckBox_Checked = False
            Background_Check()
            bkCheckBox_Checked = True
            Button19_Click(Me, e)
            Hide_Active = True
        End If
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If Check_Game_Path(tDNFPath.Text) Then WriteINI(INI, "Settings", "DNFPath", tDNFPath.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const MY_PATH = "/reg|HKLM|SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\地下城与勇士|InstallSource/path|$(driver)地下城与勇士/path|$(driver)Program Files (x86)\地下城与勇士/path|$(driver)Program Files\腾讯游戏\地下城与勇士/path|$(driver)Program Files (x86)\腾讯游戏\地下城与勇士/path|$(driver)网络游戏\地下城与勇士"
        Dim Status = False
        Try
            Dim vString = Split(MY_PATH, "\")
            Dim vString2() As String
            Dim vDriverInfo() As IO.DriveInfo
            Dim vReg As Microsoft.Win32.RegistryKey
            For i = 0 To vString.Length - 1
                If vString(i).Length = 0 Then Continue For
                vString2 = vString(i).Split("|")
                Select Case vString2(0).ToLower.Trim(" ")
                    Case "reg"
                        If vString2.Length <> 4 Then Continue For
                        Select Case vString2(1).ToLower
                            Case "hklm"
                                vReg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(vString2(2), False)
                            Case "hkcu"
                                vReg = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(vString2(2), False)
                            Case Else
                                Continue For
                        End Select
                        If vReg Is Nothing Then Continue For
                        tDNFPath.Text = vReg.GetValue(vString2(3), "").ToString
                        Status = Check_Game_Path(tDNFPath.Text)
                        If Status Then Exit For
                    Case "path"
                        If vString2.Length <> 2 Then Continue For
                        vDriverInfo = IO.DriveInfo.GetDrives()
                        For j = 0 To vDriverInfo.Length - 1
                            Select Case vDriverInfo(j).DriveType
                                Case IO.DriveType.CDRom, IO.DriveType.Ram ', IO.DriveType.Removable
                                    Continue For
                                Case Else
                                    If vDriverInfo(j).DriveType = IO.DriveType.Network Then Continue For
                                    If vDriverInfo(j).IsReady = False Then Continue For
                                    tDNFPath.Text = Path_Fix(Replace(vString2(1), "$(driver)", vDriverInfo(j).Name))
                                    Status = Check_Game_Path(tDNFPath.Text)
                                    If Status Then Exit For
                            End Select
                        Next
                    Case Else
                        Continue For
                End Select
            Next
        Catch ex As Exception
        Finally
            If Status = False Then
                printl("自动查找游戏失败，请手动选择游戏路径")
                tDNFPath.Text = ""
            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fs = New FolderBrowserDialog
        If fs.ShowDialog = DialogResult.OK Then
            If Check_Game_Path(fs.SelectedPath) Then
                tDNFPath.Text = fs.SelectedPath
            Else
                MsgBox("游戏目录有误，请重新选择")
            End If
        End If

    End Sub

    Public Sub printf(ByVal inString As String)
        Log.AppendText(inString)
    End Sub

    Public Sub printl(ByVal inString As String)
        Log.AppendText(inString + vbCrLf)
    End Sub

    Private Sub tv_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tv.AfterSelect
        If TREE_MANUAL_SELECT Then
            Select Case e.Node.Text
                Case "设置", "设置游戏目录"
                    gGamePath.BringToFront()
                Case "禁用清单 (修改清单|手动模式)"
                    gNList.BringToFront()
                    NList_Fresh()
                Case "禁用设置 (禁用|解禁)"
                    gNormal.BringToFront()
                Case "常规禁用 (IFEO+ACL)"
                    gNormalInfo.BringToFront()
                Case "拦截清单 (修改清单)"
                    gDList.BringToFront()
                    DList_Fresh()
                Case "拦截设置 (注册|卸载|启停)"
                    gDriver.BringToFront()
                    Button6_Click(Me, e)
                Case "扩展功能"
                    gExtraInfo.BringToFront()
                Case "后台模式"
                    gExtra_Background.BringToFront()
                    Background_Check()
                Case "chkdsk磁盘检查"
                    gExtra_chkdsk.BringToFront()
                Case "修复文件权限"
                    gExtra_takeown.BringToFront()
                Case "精简客户端"
                    gExtra_trim.BringToFront()
                Case "Win10自动维护"
                    gExtra_Win10MTC.BringToFront()
                    Button16_Click(Me, e)
                Case "重置游戏配置文件"
                    gExtra_DNFCFG.BringToFront()
                    Button21_Click(Me, e)
                Case "卸载DNF"
                    gExtra_Purge.BringToFront()
                Case "蓝屏"
                    gExtra_BSOD.BringToFront()
                Case "软件更新"
                    gOther_Update.BringToFront()
                    CheckBox6.Checked = IO.File.Exists(CONFIG + "\NoAutoUpdate")
                Case "联系我们&提交建议"
                    gOther_Contact.BringToFront()
                Case "赞助开发者"
                    gOther_Money.BringToFront()
                Case "驱动拦截 (vLimit)"
                    gDriverInfo.BringToFront()
            End Select
        End If
    End Sub

    Private Sub NList_Fresh(Optional inIsPrint As Boolean = True)
        With NList
            .Rows.Clear()
            Dim tStr = ReadINI(INI, "Normal List", "List", "")
            tStr = Base64_to_String(tStr)
            If tStr = "" Then
                tStr = My.Resources.default_NList
                WriteINI(INI, "Normal List", "List", String_to_Base64(tStr))
            End If
            Dim aStr() As String
            Dim tListBox = New ListBox
            Dim isIFEO, isACL As Boolean
            Dim tString As String
            Dim tColor As Color
            tListBox.Items.Add("IFEO或ACL")
            tListBox.Items.Add("仅IFEO")
            tListBox.Items.Add("仅ACL")
            For Each vline In Split(tStr, vbCrLf)
                aStr = Split(vline, "|")
                If aStr.Length = 3 Then
                    If aStr(2).ToLower.StartsWith("%dnf%") Then
                        tString = Path_Fix(tDNFPath.Text + Mid(aStr(2), 6))
                    Else
                        tString = aStr(2)
                    End If
                    If inIsPrint Then printf("扫描[" + tString + "]")
                    If IO.File.Exists(tString) Then
                        If inIsPrint Then printl("Hit")
                        .Rows.Add()
                        .Rows(.Rows.Count - 1).Cells(5).Value = tString
                        .Rows(.Rows.Count - 1).Cells(0).Value = aStr(0)
                        isIFEO = Check_IFEO(aStr(0))
                        isACL = Check_ACL(tString)
                        tColor = Color.Red
                        If isIFEO Then
                            If isACL Then
                                tString = "正常访问"
                                tColor = Color.Green
                            Else
                                tString = "ACL禁用"
                            End If
                        Else
                            If isACL Then
                                tString = "IFEO禁用"
                            Else
                                tString = "IFEO及ACL禁用"
                            End If
                        End If
                        .Rows(.Rows.Count - 1).Cells(1).Value = tString
                        .Rows(.Rows.Count - 1).Cells(1).Style.ForeColor = tColor
                        .Rows(.Rows.Count - 1).Cells(2).Value = tListBox.Items(Math.Min(vCINT(aStr(1)), tListBox.Items.Count - 1))
                        If isIFEO Then
                            .Rows(.Rows.Count - 1).Cells(3).Value = "禁用"
                        Else
                            .Rows(.Rows.Count - 1).Cells(3).Value = "恢复"
                        End If
                        If Not .Rows(.Rows.Count - 1).Cells(0).Value.ToString.ToLower.EndsWith(".exe") Then
                            .Rows(.Rows.Count - 1).Cells(3).Value = "不可用"
                        End If
                        If isACL Then
                            .Rows(.Rows.Count - 1).Cells(4).Value = "禁用"
                        Else
                            .Rows(.Rows.Count - 1).Cells(4).Value = "恢复"
                        End If
                        '.Rows(.Rows.Count - 1).Cells(5).Value = aStr(2)
                    Else
                        If inIsPrint Then printl("Miss")
                    End If
                End If
            Next
            .AutoResizeColumn(.ColumnCount - 1)
            If .RowCount < 3 Then
                If inIsPrint Then printl("[警告]有效插件小于3，请检查游戏路径是否设置正确")
            End If
        End With
    End Sub

    Private Sub NList_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles NList.CellMouseDown
        If e.Button = MouseButtons.Right Then
            NList.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub 刷新ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 刷新ToolStripMenuItem.Click
        NList_Fresh()
    End Sub

    Private Sub NList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles NList.CellContentClick
        Dim tStatus As Boolean = False
        With NList
            Select Case e.ColumnIndex
                Case 3
                    'IFEO
                    printf("对[" + .Rows(e.RowIndex).Cells(0).Value + "]执行IFEO操作[" + .Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString + "]")
                    If .Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "禁用" Then
                        tStatus = Set_IFEO_Status(.Rows(e.RowIndex).Cells(0).Value, False)
                    Else
                        tStatus = Set_IFEO_Status(.Rows(e.RowIndex).Cells(0).Value, True)
                    End If
                    If tStatus Then
                        printl("Success")
                    Else
                        printl("Failed[" + LastError + "]")
                    End If
                Case 4
                    'ACL
                    printf("对[" + .Rows(e.RowIndex).Cells(0).Value + "]执行ACL操作[" + .Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString + "]")
                    If .Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "禁用" Then
                        tStatus = Set_ACL_Status(.Rows(e.RowIndex).Cells(5).Value, False)
                    Else
                        tStatus = Set_ACL_Status(.Rows(e.RowIndex).Cells(5).Value, True)
                    End If
                    If tStatus Then
                        printl("Success")
                    Else
                        printl("Failed[" + LastError + "]")
                    End If
            End Select
            NList_Fresh(False)
            .Rows(e.RowIndex).Selected = True
        End With
    End Sub

    Private Sub 添加插件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 添加插件ToolStripMenuItem.Click
        Dim fs = New OpenFileDialog
        Dim tStr As String
        fs.InitialDirectory = tDNFPath.Text
        fs.Multiselect = True
        If fs.ShowDialog = DialogResult.OK Then
            With NList
                For i = 0 To fs.FileNames.Length - 1
                    If fs.SafeFileNames(i).ToLower.EndsWith(".exe") Then
                        tStr = "IFEO或ACL"
                    Else
                        tStr = "仅ACL"
                    End If
                    .Rows.Add(fs.SafeFileNames(i), "", tStr, "", "", fs.FileNames(i))
                    printl("添加插件[" + fs.SafeFileNames(i) + "]")
                Next
                NList_Save()
                NList_Fresh()
            End With
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ACL_Error = False
        printl("启用一键禁用")
        Tree_Select_Ex("禁用清单 (修改清单|手动模式)")
        gNList.BringToFront()
        NList_Fresh(False)
        Dim tIfIFEO = Can_IFEO()
        With NList
            Application.DoEvents()
            For i = 0 To .RowCount - 1
                printf("对[" + .Rows(i).Cells(0).Value + "]执行")
                If tIfIFEO And .Rows(i).Cells(2).Value.ToString.Contains("IFEO") Then
                    printf("IFEO操作[禁用]")
                    If Set_IFEO_Status(.Rows(i).Cells(0).Value, False) Then
                        printl("Success")
                    Else
                        printl("Failed[" + LastError + "]")
                        If LastError.Contains("未能转换部分或所有标志引用") Then ACL_Error = True
                    End If
                Else
                    printf("ACL操作[禁用]")
                    If Set_ACL_Status(.Rows(i).Cells(5).Value, False) Then
                        printl("Success")
                    Else
                        printl("Failed[" + LastError + "]")
                    End If
                End If
            Next
        End With
        NList_Fresh(False)
        printl("一键禁用结束")
        If ACL_Error Then
            If MsgBox("检测到部分ACL禁用失败，是否显示帮助说明？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Button28_Click(Me, e)
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        printl("启用一键还原")
        Tree_Select_Ex("禁用清单 (修改清单|手动模式)")
        gNList.BringToFront()
        NList_Fresh(False)
        With NList
            Application.DoEvents()
            For i = 0 To .RowCount - 1
                If .Rows(i).Cells(1).Value.ToString.Contains("IFEO") Then
                    printf("对[" + .Rows(i).Cells(0).Value + "]执行IFEO操作[恢复]")
                    If Set_IFEO_Status(.Rows(i).Cells(0).Value, True) Then
                        printl("Success")
                    Else
                        printl("Failed[" + LastError + "]")
                    End If
                End If
                If .Rows(i).Cells(1).Value.ToString.Contains("ACL") Then
                    printf("对[" + .Rows(i).Cells(0).Value + "]执行ACL操作[恢复]")
                    If Set_ACL_Status(.Rows(i).Cells(5).Value, True) Then
                        printl("Success")
                    Else
                        printl("Failed[" + LastError + "]")
                    End If
                End If
            Next
        End With
        NList_Fresh(False)
        printl("一键恢复结束")
    End Sub

    Public Sub Tree_Select_Ex(ByVal inString As String)
        TREE_MANUAL_SELECT = False
        Dim tTreeNode = Tree_Find_Node_With_Text("禁用清单 (修改清单|手动模式)")
        If tTreeNode IsNot Nothing Then
            tv.SelectedNode = tTreeNode
        End If
        TREE_MANUAL_SELECT = True
    End Sub

    Public Function Tree_Find_Node_With_Text(inString As String) As TreeNode
        Dim rTreeNode As TreeNode = Nothing
        For Each vline In tv.Nodes
            rTreeNode = Tree_Find_Loop(vline, inString)
            If rTreeNode IsNot Nothing Then Return rTreeNode
        Next
        Return Nothing
    End Function

    Private Function Tree_Find_Loop(ByVal inTreeNode As TreeNode, inString As String) As TreeNode
        Dim rTreeNode As TreeNode = Nothing
        For Each vline As TreeNode In inTreeNode.Nodes
            If vline.Text = inString Then
                rTreeNode = vline
                Exit For
            Else
                rTreeNode = Tree_Find_Loop(vline, inString)
            End If
        Next
        Return rTreeNode
    End Function

    Public Sub NList_Save()
        Dim oString = ""
        Dim tString As String
        With NList
            For i = 0 To .RowCount - 1
                tString = .Rows(i).Cells(0).Value + "|"
                Select Case .Rows(i).Cells(2).Value.ToString
                    Case "IFEO或ACL"
                        tString += "0|"
                    Case "仅IFEO"
                        tString += "1|"
                    Case "仅ACL"
                        tString += "2|"
                    Case Else
                        tString += "0|"
                End Select
                tString += .Rows(i).Cells(5).Value
                oString += tString + vbCrLf
            Next
        End With
        WriteINI(INI, "Normal List", "List", String_to_Base64(oString))
    End Sub

    Private Sub 修改插件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改插件ToolStripMenuItem.Click
        With NList
            Try
                If .SelectedRows(0) IsNot Nothing Then
                    If .SelectedRows(0).Cells(1).Style.ForeColor = Color.Red Then
                        If MsgBox("当前插件已禁用，是否在删除前先还原？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            Set_ACL_Status(.SelectedRows(0).Cells(5).Value, True)
                            Set_IFEO_Status(.SelectedRows(0).Cells(0).Value, True)
                        End If
                    End If
                    printl("删除插件[" + .SelectedRows(0).Cells(0).Value + "]")
                    .Rows.Remove(.SelectedRows(0))
                    NList_Save()
                    NList_Fresh(False)

                End If
            Catch ex As Exception

            End Try
        End With
    End Sub

    Private Sub IFEO或ACLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IFEO或ACLToolStripMenuItem.Click
        With NList
            Try
                If .SelectedRows(0) IsNot Nothing Then
                    .SelectedRows(0).Cells(2).Value = "IFEO或ACL"
                    NList_Save()
                    NList_Fresh(False)
                End If
            Catch ex As Exception
            End Try
        End With
    End Sub

    Private Sub NListMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NListMenu.Opening
        With NList
            Try
                If .SelectedRows(0) IsNot Nothing Then
                    IFEO或ACLToolStripMenuItem.Enabled = True
                    仅IFEOToolStripMenuItem.Enabled = True
                    仅ACLToolStripMenuItem.Enabled = True
                    Select Case .SelectedRows(0).Cells(2).Value
                        Case "IFEO或ACL"
                            IFEO或ACLToolStripMenuItem.Enabled = False
                        Case "仅IFEO"
                            仅IFEOToolStripMenuItem.Enabled = False
                        Case "仅ACL"
                            仅ACLToolStripMenuItem.Enabled = False
                    End Select
                    If Not .SelectedRows(0).Cells(0).Value.ToString.ToLower.EndsWith(".exe") Then
                        IFEO或ACLToolStripMenuItem.Enabled = False
                        仅IFEOToolStripMenuItem.Enabled = False
                    End If
                End If
            Catch ex As Exception
            End Try
        End With
    End Sub

    Private Sub 仅IFEOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 仅IFEOToolStripMenuItem.Click
        With NList
            Try
                If .SelectedRows(0) IsNot Nothing Then
                    .SelectedRows(0).Cells(2).Value = "仅IFEO"
                    NList_Save()
                    NList_Fresh(False)
                End If
            Catch ex As Exception
            End Try
        End With
    End Sub

    Private Sub 仅ACLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 仅ACLToolStripMenuItem.Click
        With NList
            Try
                If .SelectedRows(0) IsNot Nothing Then
                    .SelectedRows(0).Cells(2).Value = "仅ACL"
                    NList_Save()
                    NList_Fresh(False)
                End If
            Catch ex As Exception
            End Try
        End With
    End Sub

    Private Sub 添加拦截ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 添加拦截ToolStripMenuItem.Click
        Dim tForm = New vLimit_Add
        tForm.ShowDialog()
        If tForm.oString <> "" Then
            Dim aStr = Split(tForm.oString, "|")
            If aStr.Length = 3 Then
                Select Case aStr(0)
                    Case "h"
                        DList.Rows.Add(IO.Path.GetFileName(aStr(1)), "精确匹配", aStr(2), aStr(1))
                    Case "H"
                        DList.Rows.Add(aStr(1), "模糊匹配", aStr(2), aStr(1))
                End Select
            End If
        End If
        DList_Apply()
        printl("刷新列表成功")
    End Sub

    Private Sub DList_Apply()
        Dim tStr As String
        Dim tMark As String
        With DList
            tStr = Replace(Replace(gDList.Text, "驱动拦截清单(当前Altitude:", ""), ")", "")
            If Not IsNumeric(tStr) Then
                printl("修正当前Altitude")
                tStr = "370030"
            End If
            tStr = "s|" + tStr + "|"
            For i = 0 To .Rows.Count - 1
                If .Rows(i).Cells(1).Value.ToString = "精确匹配" Then
                    tMark = "h"
                Else
                    tMark = "H"
                End If
                tStr += "/" + tMark + "|" + .Rows(i).Cells(3).Value.ToString + "|"
                If .Rows(i).Cells(2).Value IsNot Nothing Then tStr += .Rows(i).Cells(2).Value.ToString
            Next
            If Not IO.Directory.Exists(IO.Path.GetDirectoryName(vLimit_DAT)) Then
                IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(vLimit_DAT))
            End If
            IO.File.WriteAllText(vLimit_DAT, tStr, System.Text.Encoding.Unicode)
            For Each vline In ServiceProcess.ServiceController.GetDevices
                If vline.DisplayName = "vLimit" Then
                    If vline.Status = ServiceProcess.ServiceControllerStatus.Running Then
                        vline.Stop()
                        vline.Start()
                    End If
                End If
            Next
        End With
    End Sub

    Private Sub DList_Fresh(Optional inIsPrint As Boolean = True)
        Dim tStr = ""
        Dim aStr() As String
        With DList
            .Rows.Clear()

            Try
                If inIsPrint Then printf("查找驱动配置文件")
                If IO.File.Exists(vLimit_DAT) Then
                    tStr = IO.File.ReadAllText(vLimit_DAT, System.Text.Encoding.Unicode)
                    If tStr <> "" Then
                        If inIsPrint Then printl("Success")
                    Else
                        If inIsPrint Then printl("Miss")
                        Exit Sub
                    End If
                    For Each vline In Split(tStr, "/")
                        aStr = Split(vline, "|")
                        If aStr.Length = 3 Then
                            Select Case aStr(0)
                                Case "s", "S"
                                    gDList.Text = "驱动拦截清单(当前Altitude:" + aStr(1) + ")"
                                Case "h"
                                    .Rows.Add(IO.Path.GetFileName(aStr(1)), "精确匹配", aStr(2), aStr(1))
                                Case "H"
                                    .Rows.Add(aStr(1), "模糊匹配", aStr(2), aStr(1))
                                Case Else
                                    Continue For
                            End Select
                            If inIsPrint Then printl("拦截目标[" + aStr(1) + "]Hit")
                        End If
                    Next

                Else
                    If inIsPrint Then printl("Miss")
                    Exit Sub
                End If
            Catch ex As Exception
                If inIsPrint Then printl(ex.Message) Else MsgBox(ex.Message)
            End Try
        End With
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        tDPath.Text = "C:\Users\Public\Documents\vLimit\vLimit.sys"
        tDFStatus.Text = "不存在"
        tDSStatus.Text = "未注册"
        tDRStatus.Text = "未运行"
        If IO.File.Exists(tDPath.Text) Then tDFStatus.Text = "正常"
        For Each vline In ServiceProcess.ServiceController.GetDevices
            If vline.DisplayName = "vLimit" Then
                tDSStatus.Text = "正常"
                If vline.Status = ServiceProcess.ServiceControllerStatus.Running Then tDRStatus.Text = "正常"
            End If
        Next
    End Sub

    Private Sub 删除拦截ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除拦截ToolStripMenuItem.Click
        If DList.SelectedRows.Count > 0 Then
            For i = DList.Rows.Count - 1 To 0 Step -1
                If DList.Rows(i).Selected Then DList.Rows.RemoveAt(i) : Exit For
            Next
            DList_Apply()
            printl("刷新列表成功")
        End If
    End Sub

    Private Sub DList_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DList.CellMouseDown
        If e.Button = MouseButtons.Right Then
            DList.Rows(e.RowIndex).Selected = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button6_Click(Me, e)
        If Not IO.Directory.Exists(IO.Path.GetDirectoryName(vLimit_DAT)) Then
            IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(vLimit_DAT))
        End If
        If tDSStatus.Text = "未注册" Then
            If Not IO.File.Exists(tDPath.Text) Then
                printf("释放驱动文件")
                IO.File.WriteAllBytes(tDPath.Text, My.Resources.vLimit)
                printl("Success")
            End If
            Try
                Dim hSCManager = OpenSCManager(Nothing, Nothing, SC_MANAGER_CREATE_SERVICE)
                CloseServiceHandle(CreateService(hSCManager, "vLimit", "vLimit", SERVICE_START, SERVICE_KERNEL_DRIVER, SERVICE_DEMAND_START, SERVICE_ERROR_IGNORE, tDPath.Text, 0, 0, 0, 0, 0))
                CloseServiceHandle(hSCManager)
                printl("注册服务成功")
            Catch ex As Exception
                printl(ex.Message)
            End Try
        End If
        Button6_Click(Me, e)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button6_Click(Me, e)
        If tDFStatus.Text = "正常" Then
            If tDRStatus.Text = "未运行" Then
                Try
                    For Each vline In ServiceProcess.ServiceController.GetDevices
                        If vline.DisplayName = "vLimit" Then
                            vline.Start()
                            Dim regist As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine
                            Dim svcreg As Microsoft.Win32.RegistryKey = regist.OpenSubKey("SYSTEM\CurrentControlSet\Services\vLimit", True)
                            svcreg.SetValue("Start", 2, Microsoft.Win32.RegistryValueKind.DWord)
                            svcreg.Flush()
                            printl("启动成功，设置自动启动")
                            Exit For
                        End If
                    Next


                Catch ex As Exception
                    printl(ex.Message + "是否未设置拦截清单？")
                End Try
            Else
                printl("驱动已运行")
            End If
        Else
            printl("驱动未注册")
        End If

        Button6_Click(Me, e)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button6_Click(Me, e)
        If tDRStatus.Text = "正常" Then
            Try
                For Each vline In ServiceProcess.ServiceController.GetDevices
                    If vline.DisplayName = "vLimit" Then
                        vline.Stop()
                        Dim regist As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine
                        Dim svcreg As Microsoft.Win32.RegistryKey = regist.OpenSubKey("SYSTEM\CurrentControlSet\Services\vLimit", True)
                        svcreg.SetValue("Start", 3, Microsoft.Win32.RegistryValueKind.DWord)
                        svcreg.Flush()
                        Exit For
                    End If
                Next
            Catch ex As Exception
                printl(ex.Message)
            End Try
        End If
        printl("停止成功，设置禁用启动")
        Button6_Click(Me, e)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button6_Click(Me, e)
        If tDRStatus.Text = "正常" Then
            Button8_Click(Me, e)
        End If
        If tDSStatus.Text = "正常" Then
            Dim str = IO.Path.GetTempFileName
            Dim ServiceInstallerObj = New ServiceProcess.ServiceInstaller
            Dim Context = New System.Configuration.Install.InstallContext(str, Nothing)
            ServiceInstallerObj.Context = Context
            ServiceInstallerObj.ServiceName = "vLimit"
            ServiceInstallerObj.Uninstall(Nothing)
            Dim tStrEx = IO.File.ReadAllLines(str)
            For i = 0 To tStrEx.Length - 1
                printl(tStrEx(i))
            Next
            IO.File.Delete(str)
            Button6_Click(Me, e)
        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            IO.Directory.Delete("C:\Users\Public\Documents\vLimit", True)
            printl("删除成功")
        Catch ex As Exception
            printl(ex.Message)
        End Try
        Button6_Click(Me, e)
    End Sub

    Private Sub 修改AltitudeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 修改AltitudeToolStripMenuItem.Click
        Dim tStr As String = "370030"
        If gDList.Text Like "驱动拦截清单(当前Altitude:*)" Then
            tStr = Replace(Replace(gDList.Text, "驱动拦截清单(当前Altitude:", ""), ")", "")
        End If
        tStr = InputBox("键入新的Altitude（默认370030）", "", tStr)
        gDList.Text = "驱动拦截清单(当前Altitude:" + tStr + ")"
        DList_Apply()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim tStr = Environment.GetEnvironmentVariable("systemdrive").ToLower
        printl("检测到系统盘" + tStr)
        Shell("cmd /c echo y | chkdsk /f " + tStr, AppWinStyle.Hide)
        MsgBox("请重新启动电脑以进行" + tStr + "盘的磁盘检查")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If tDNFPath.Text.Length > 3 Then
            Dim tStr = IO.Path.GetPathRoot(tDNFPath.Text).ToLower
            If tStr.Length = 3 Then tStr = Strings.Left(tStr, 2)
            If tStr = Environment.GetEnvironmentVariable("systemdrive").ToLower Then
                printl("游戏盘与系统盘同盘，跳转至系统盘检查")
                Button11_Click(Me, e)
                Exit Sub
            End If
            printl("检测到游戏盘" + tStr)
            If MsgBox("将卸下" + tStr + "盘所有关联句柄，所有打开文件均无效，是否继续？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Shell("cmd /c echo y | chkdsk /f " + tStr, AppWinStyle.NormalFocus)
            End If
        Else
            printl("游戏路径未设置，请先设置游戏路径")
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim sRoot = Environment.GetEnvironmentVariable("systemdrive").ToLower
        printl("检测到系统盘" + sRoot)
        Dim gRoot = IO.Path.GetPathRoot(tDNFPath.Text).ToLower
        If gRoot.Length = 3 Then gRoot = Strings.Left(gRoot, 2)
        printl("检测到游戏盘" + gRoot)
        Shell("cmd /c echo y | chkdsk /f " + sRoot, AppWinStyle.Hide)
        If sRoot <> gRoot Then
            If MsgBox("将卸下" + gRoot + "盘所有关联句柄，所有打开文件均无效，是否继续？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Shell("cmd /c echo y | chkdsk /f " + gRoot, AppWinStyle.NormalFocus)
            End If
        End If
        MsgBox("请重新启动电脑以进行" + sRoot + "盘的磁盘检查")

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Check_Game_Path(tDNFPath.Text) Then
            TextBox4.Text = ""
            Button14.Enabled = False
            Set_ACL_Recursive(tDNFPath.Text, TextBox4, "尝试获取[${Name}]${Status}" + vbCrLf)
            printl("修复结束")
            Button14.Enabled = True
        Else
            printl("游戏路径设置错误")
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Check_Game_Path(tDNFPath.Text) Then
            TextBox5.Text = ""
            Button15.Enabled = False
            Dim tDouble As Double
            tDouble += Delete_Tree_Recursive(Path_Fix(tDNFPath.Text + "\tgppatches"), TextBox5, "尝试删除[${Name}] ${Length}" + vbCrLf)
            tDouble += Delete_Tree_Recursive(Path_Fix(tDNFPath.Text + "\components"), TextBox5, "尝试删除[${Name}] ${Length}" + vbCrLf)
            tDouble += Delete_Tree_Recursive(Path_Fix(tDNFPath.Text + "\TGuard"), TextBox5, "尝试删除[${Name}] ${Length}" + vbCrLf)
            tDouble += Delete_Tree_Recursive(Path_Fix(tDNFPath.Text + "\TP_Temp"), TextBox5, "尝试删除[${Name}] ${Length}" + vbCrLf)
            printl("精简结束")
            tDouble = tDouble / 1024 / 1024
            printl("共删除" + Format(tDouble, "#,###.##") + " mb文件")
            Button15.Enabled = True
        Else
            printl("游戏路径设置错误")
        End If

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Try
            TextBox6.Text = Environment.OSVersion.VersionString
            TextBox7.Text = "未配置"
            Dim tReg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\Maintenance")
            If tReg IsNot Nothing Then
                Dim tObj = tReg.GetValue("MaintenanceDisabled", "")
                If tObj IsNot Nothing Then
                    If tObj = 1 Then
                        TextBox7.Text = "已禁用"
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Button16_Click(Me, e)
        Try
            If TextBox7.Text = "未配置" Then
                Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\Maintenance", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree).SetValue("MaintenanceDisabled", 1, Microsoft.Win32.RegistryValueKind.DWord)
                printl("设置成功，请重启电脑以生效")
            End If
        Catch ex As Exception

        End Try
        Button16_Click(Me, e)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Button16_Click(Me, e)
        Try
            If TextBox7.Text = "已禁用" Then
                Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Schedule\Maintenance", True).DeleteValue("MaintenanceDisabled", False)
                printl("设置成功，请重启电脑以生效")
            End If
        Catch ex As Exception

        End Try
        Button16_Click(Me, e)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim tStr = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low\DNF\DNF.cfg"
        If IO.File.Exists(tStr) Then
            TextBox9.Text = tStr
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If TextBox9.Text <> "" Then
            IO.File.Delete(TextBox9.Text)
            printl("重置完毕")
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If Check_Game_Path(tDNFPath.Text) Then
            Process.Start(Path_Fix(tDNFPath.Text + "\地下城与勇士卸载.exe"))
        Else
            printl("游戏路径设置错误")
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If Check_Game_Path(tDNFPath.Text) Then
            If MsgBox("是否删除下列目录，该操作不可逆" + vbCrLf + tDNFPath.Text, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Try
                    Delete_Tree_Recursive(tDNFPath.Text, Log, " ${Name} ${Length}" + vbCrLf)
                    IO.Directory.Delete(tDNFPath.Text)
                Catch ex As Exception

                End Try

            End If
            MsgBox("删除结束")
        Else
            printl("游戏路径设置错误")
        End If

    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If RtlAdjustPrivilege(20, True, False, 0) = 0 Then printl("[OK]RtlAdjustPrivilege SeShutdownPrivilege")
        If RtlSetProcessIsCritical(1, 0, 0) = 0 Then printl("[OK]RtlSetProcessIsCritical")

        'SeShutdown_Privilege = 0x13 = 19
        If RtlAdjustPrivilege(19, True, False, 0) = 0 Then printl("[OK]RtlAdjustPrivilege SeShutdownPrivilege")
        NtRaiseHardError(&HC000021A, 4, 1, 0, 6, 0)
        Application.Exit()
    End Sub

    Private Sub TextBox8_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox8.KeyPress
        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Background_Check()
        CheckBox1.Checked = Not IO.File.Exists(CONFIG + "\NoTenioDL")
        CheckBox2.Checked = Not IO.File.Exists(CONFIG + "\NoGameLoader")
        CheckBox3.Checked = Not IO.File.Exists(CONFIG + "\NoTGuardSvc")
        CheckBox4.Checked = Not IO.File.Exists(CONFIG + "\NoBallon")
        CheckBox7.Checked = Not IO.File.Exists(CONFIG + "\NoTesService")
        CheckBox5.Checked = IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\" + Application.ProductName + ".bat")
        If Background_Timer.Enabled Then
            Button19.Text = "关闭后台模式(当前状态：运行)"
        Else
            Button19.Text = "开启后台模式(当前状态：关闭)"
        End If
    End Sub

    Private Sub Background_Init(ByVal inBoolean As Boolean)
        Background_Icon.Visible = inBoolean
        Me.Visible = Not inBoolean
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If IsNumeric(TextBox8.Text) Then
            Background_Timer.Interval = CInt(TextBox8.Text) * 1000
        Else
            Background_Timer.Interval = 5000
        End If
        Background_Timer.Enabled = Not Background_Timer.Enabled
        Background_Check()
        If Background_Timer.Enabled Then
            printl("后台模式启动")
        Else
            printl("后台模式关闭")
        End If
        Background_Init(Background_Timer.Enabled)
    End Sub

    Private Sub BackGround_Timer_Tick(sender As Object, e As EventArgs) Handles Background_Timer.Tick
        'printl(Now.ToString)
        Try
            Dim tProcesses = Process.GetProcesses
            For Each sProcess In tProcesses
                If sProcess.ProcessName.ToLower = "dnf" Then
                    If sProcess.Id <> Last_DNF_PID Then
                        If DateDiff(DateInterval.Second, sProcess.StartTime, Now) > 59 Then
                            'hit
                            For Each sProcess2 In tProcesses
                                Select Case sProcess2.ProcessName.ToLower
                                    Case "teniodl"
                                        If CheckBox1.Checked Then
                                            sProcess2.Kill()
                                            printl("结束TenioDL")
                                            If Background_Icon.Visible Then Icon_Show(Background_Icon, 2000, "神秘力量V", "结束TenioDL", ToolTipIcon.Info)
                                        End If
                                    Case "gameloader"
                                        If CheckBox2.Checked Then
                                            sProcess2.Kill()
                                            printl("结束GameLoader")
                                            If Background_Icon.Visible Then Icon_Show(Background_Icon, 2000, "神秘力量V", "结束GameLoader", ToolTipIcon.Info)
                                        End If
                                    Case "tguard", "tguardsvc"
                                        If CheckBox3.Checked Then
                                            Shell("sc stop TGuardSvc", AppWinStyle.Hide)
                                            printl("关闭TGuardSvc服务")
                                            If Background_Icon.Visible Then Icon_Show(Background_Icon, 2000, "神秘力量V", "关闭TGuardSvc服务", ToolTipIcon.Info)
                                        End If
                                    Case "tesservice"
                                        If CheckBox3.Checked Then
                                            Shell("sc stop TesService", AppWinStyle.Hide)
                                            printl("关闭TesService服务")
                                            If Background_Icon.Visible Then Icon_Show(Background_Icon, 2000, "神秘力量V", "关闭TesService服务", ToolTipIcon.Info)
                                        End If

                                End Select
                            Next
                            Last_DNF_PID = sProcess.Id
                        End If
                    End If
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            printl("后台模式[“ + ex.Message + ”]")
        End Try

    End Sub

    Private Sub Icon_Show(ByVal inNotifyIcon As Windows.Forms.NotifyIcon, ByVal inTimeout As Integer, ByVal inTitle As String, ByVal inText As String, ByVal inIcon As Windows.Forms.ToolTipIcon)
        If CheckBox4.Checked Then inNotifyIcon.ShowBalloonTip(inTimeout, inTitle, inText, inIcon)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Not bkCheckBox_Checked Then Exit Sub
        Dim tStr = CONFIG + "\NoTenioDL"
        If CheckBox1.Checked Then
            If IO.File.Exists(tStr) Then IO.File.Delete(tStr)
        Else
            IO.File.Create(tStr).Close()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If Not bkCheckBox_Checked Then Exit Sub
        Dim tStr = CONFIG + "\NoGameLoader"
        If CheckBox2.Checked Then
            If IO.File.Exists(tStr) Then IO.File.Delete(tStr)
        Else
            IO.File.Create(tStr).Close()
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If Not bkCheckBox_Checked Then Exit Sub
        Dim tStr = CONFIG + "\NoTGuardSvc"
        If CheckBox3.Checked Then
            If IO.File.Exists(tStr) Then IO.File.Delete(tStr)
        Else
            IO.File.Create(tStr).Close()
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If Not bkCheckBox_Checked Then Exit Sub
        Dim tStr = CONFIG + "\NoBallon"
        If CheckBox4.Checked Then
            If IO.File.Exists(tStr) Then IO.File.Delete(tStr)
        Else
            IO.File.Create(tStr).Close()
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If Not bkCheckBox_Checked Then Exit Sub
        Dim tStr = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\" + Application.ProductName + ".bat"
        If CheckBox5.Checked Then
            IO.File.WriteAllText(tStr, "start  """" """ + Application.StartupPath + "\" + IO.Path.GetFileName(Application.ExecutablePath) + """ -b", System.Text.Encoding.Default)
        Else
            IO.File.Delete(tStr)
        End If

    End Sub

    Private Sub Background_Icon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Background_Icon.MouseDoubleClick
        Background_Icon.Visible = False
        Me.Show()
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If Hide_Active Then
            Hide_Active = False
            Me.Hide()
        End If
    End Sub

    Private Sub 引用常规禁用的清单ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 引用常规禁用的清单ToolStripMenuItem.Click
        printl("刷新常规禁用清单")
        NList_Fresh()
        If MsgBox("是否清除当前驱动拦截清单？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            DList.Rows.Clear()
        End If
        For i = 0 To NList.Rows.Count - 1
            DList.Rows.Add(NList.Rows(i).Cells(0).Value, "精确匹配", "", NList.Rows(i).Cells(5).Value)
        Next
        DList_Apply()
        DList_Fresh()
        printl("引用列表成功")
    End Sub

    Public Delegate Sub Delegate_Update(ByVal inString As String)

    Public Sub Delegate_Update_Version(ByVal inString As String)
        TextBox10.Text = inString
    End Sub
    Public Sub Delegate_Update_URL(ByVal inString As String)
        TextBox12.Text = inString
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        TextBox11.Text = Get_Version()
        Dim tClass = New Update_Class
        tClass.SrcForm = Me
        Dim tThread = New Threading.Thread(AddressOf tClass.Get_Latest_Version)
        tThread.IsBackground = True
        tThread.Start()
    End Sub

    Private Sub TextBox12_MouseDown(sender As Object, e As MouseEventArgs) Handles TextBox12.MouseDown
        If TextBox12.Text <> "" Then
            If MsgBox("是否打开网页[" + TextBox12.Text + "]", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Diagnostics.Process.Start(TextBox12.Text)
            End If
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Diagnostics.Process.Start("https://jq.qq.com/?_wv=1027&k=53KHmZj")
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        Dim tStr = CONFIG + "\NoAutoUpdate"
        If CheckBox6.Checked Then
            IO.File.Create(tStr).Close()
        Else
            If IO.File.Exists(tStr) Then IO.File.Delete(tStr)
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Try
            Dim tStr As String
            Dim tEndPoint = New System.Net.IPEndPoint(System.Net.Dns.GetHostAddresses(Update_Server)(0), 47655)
            Dim tSocket = New System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp)
            tSocket.Connect(tEndPoint)
            tStr = TextBox14.Text + vbCrLf + TextBox15.Text
            tSocket.Send(System.Text.Encoding.Unicode.GetBytes("ADVISE"))
            tSocket.Send(System.Text.Encoding.Unicode.GetBytes(tStr))
            tSocket.Close()
        Catch ex As Exception

        End Try
        MsgBox("提交成功")
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim tStr = IO.Path.GetTempFileName
        IO.File.WriteAllText(tStr, My.Resources.Win10ACLError)
        Diagnostics.Process.Start("notepad.exe", tStr)
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If Not bkCheckBox_Checked Then Exit Sub
        Dim tStr = CONFIG + "\NoTesService"
        If CheckBox7.Checked Then
            If IO.File.Exists(tStr) Then IO.File.Delete(tStr)
        Else
            IO.File.Create(tStr).Close()
        End If
    End Sub
End Class
