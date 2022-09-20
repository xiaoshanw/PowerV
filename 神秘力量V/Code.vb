Module Code
    Public bkCheckBox_Checked As Boolean = True
    Public Update_Server = "update.vocyt.com"  'update_address
    'Public CONFIG As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\" + Application.ProductName
    Public CONFIG As String = "C:\Users\Public\Documents\PowerV"
    Public INI As String = CONFIG + "\config.ini"
    Public IFEO_PATH As String = CONFIG + "\VoCytDefenderEx.exe"
    Public vLimit_DAT As String = "C:\Users\Public\Documents\vLimit\vLimit.dat"
    Public vLimit_INI As String = "C:\Users\Public\Documents\vLimit\vLimit.ini"
    Public vLimit_SYS As String = "C:\Users\Public\Documents\vLimit\vLimit.sys"
    Public SGuard_Path As String = "C:\Program Files\AntiCheatExpert\SGuard"
    Public LastError As String
    Public Last_DNF_PID As Integer
    Public TREE_MANUAL_SELECT As Boolean = True
    Public Hide_Active As Boolean = False
    Structure AUTO_LST_TYPE
        Dim Path As String
        Dim Length As Integer
        Dim CMD5 As String
    End Structure
#If DEBUG Then
    Public DEBUG_FLAG = True
#Else
    Public DEBUG_FLAG = False
#End If


    Public Function WriteINI(ByVal FileName As String, ByVal SectionName As String, ByVal KeyName As String, ByVal Value As String) As IntPtr
        Return WritePrivateProfileString(SectionName, KeyName, Value, FileName)
    End Function
    Public Function ReadINI(ByVal FileName As String, ByVal SectionName As String, ByVal KeyName As String, Optional ByVal Value As String = "", Optional ByVal Size As Integer = &HFFFF) As String
        Dim Str As String
        Str = LSet("", Size)
        GetPrivateProfileString(SectionName, KeyName, Value, Str, Len(Str), FileName)
        Return Left(Str, InStr(Str, Chr(0)) - 1)
    End Function
    Public Function Check_Game_Path(ByVal inPath As String) As Boolean
        If IO.Directory.Exists(inPath) = False Then Return False
        Dim eax = 0
        For Each vline In New IO.DirectoryInfo(inPath).GetDirectories
            If vline.Name.ToLower = "ImagePacks2".ToLower Then eax += 1
            If vline.Name.ToLower = "SoundPacks".ToLower Then eax += 1
            If vline.Name.ToLower = "start".ToLower Then eax += 1
            If vline.Name.ToLower = "TCLS".ToLower Then eax += 1
        Next
        If eax = 4 Then Return True Else Return False
    End Function
    Public Function Path_Fix(ByVal inString As String) As String
        Return Replace(Replace(inString, "\\", "\"), """", "")
    End Function
    Public Function String_to_Base64(ByVal inString As String) As String
        Try
            Return Convert.ToBase64String(Text.Encoding.Unicode.GetBytes(inString))
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function Base64_to_String(ByVal inString As String) As String
        Try
            Return Text.Encoding.Unicode.GetString(Convert.FromBase64String(inString))
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function vCINT(ByVal inObject As Object) As Integer
        Try
            If IsNumeric(inObject) Then Return CInt(inObject)
        Catch ex As Exception

        End Try
        Return 0
    End Function
    Public Function Check_ACL(ByVal inFilePath As String) As Boolean
        If IO.File.Exists(inFilePath) = False Then Return False
        Try
            IO.File.OpenRead(inFilePath).Close()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function Check_IFEO(ByVal inFileName As String) As Boolean
        Dim tReg As Microsoft.Win32.RegistryKey
        Dim tReturn() As Boolean = {True, True}
        For i = 0 To 1
            Try
                If i = 0 Then
                    tReg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options")
                Else
                    tReg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows NT\CurrentVersion\Image File Execution Options")
                End If
                tReg = tReg.OpenSubKey(inFileName)
                If tReg.GetValue("debugger", "").ToString <> "" Then
                    tReturn(i) = False
                End If
            Catch ex As Exception
                tReturn(i) = True
            End Try
        Next
        If tReturn(0) Then
            If tReturn(1) Then
                Return True
            End If
        End If
        Return False
    End Function
    Public Function Set_IFEO_Status(ByVal inFileName As String, ByVal inStatus As Boolean) As Boolean
        Try
            Dim tReg As Microsoft.Win32.RegistryKey
            If Not inFileName.ToLower.EndsWith(".exe") Then
                LastError = "非exe文件不可用"
                Return False
            End If
            For i = 0 To 1
                If i = 0 Then
                    tReg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options", True)
                Else
                    tReg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Wow6432Node\Microsoft\Windows NT\CurrentVersion\Image File Execution Options", True)
                End If
                tReg = tReg.CreateSubKey(inFileName)
                If inStatus Then
                    tReg.DeleteValue("Debugger", False)
                Else
                    tReg.SetValue("Debugger", """" + IFEO_PATH + """" + " -f ""VoCyt Tools"" -fx """" ""VoCyt Defender"" """" ""主面板"" ""Receiver"" -n " + inFileName + " -e")
                End If
            Next
            Return True
        Catch ex As Exception
            LastError = ex.Message
            Return False
        End Try
    End Function
    Public Function Set_ACL_Status(ByVal inFilePath As String, ByVal inStatus As Boolean) As Boolean
        Dim tFileInfo
        Dim tFileACL
        Dim isFile = IO.File.Exists(inFilePath)
        Try
            Try
                If isFile Then
                    tFileInfo = New IO.FileInfo(inFilePath)
                Else
                    tFileInfo = New IO.DirectoryInfo(inFilePath)
                End If
                tFileACL = tFileInfo.GetAccessControl
            Catch ex2 As Exception
                Shell("cmd.exe /c """ + "takeown" + " /f " + inFilePath + """", AppWinStyle.Hide, True)
                If isFile Then
                    tFileInfo = New IO.FileInfo(inFilePath)
                Else
                    tFileInfo = New IO.DirectoryInfo(inFilePath)
                End If
                tFileACL = tFileInfo.GetAccessControl
            End Try
            tFileACL.SetAccessRuleProtection(True, False)
            Dim tRules = tFileACL.GetAccessRules(True, True, GetType(System.Security.Principal.NTAccount))
            For Each vline As System.Security.AccessControl.FileSystemAccessRule In tRules
                tFileACL.RemoveAccessRule(vline)
            Next
            tFileACL.SetAccessRuleProtection(True, False)
            If inStatus Then
                tFileACL.SetAccessRule(New Security.AccessControl.FileSystemAccessRule("Everyone", Security.AccessControl.FileSystemRights.FullControl, Security.AccessControl.AccessControlType.Allow))
            Else
                tFileACL.SetAccessRule(New Security.AccessControl.FileSystemAccessRule("Everyone", Security.AccessControl.FileSystemRights.FullControl, Security.AccessControl.AccessControlType.Deny))
            End If
            tFileInfo.SetAccessControl(tFileACL)
        Catch ex As Exception
            LastError = ex.Message
            If inStatus Then
                Shell("cmd.exe /c """ + "icacls" + " " + inFilePath + " /reset""", AppWinStyle.Hide, True)
            Else
                Shell("cmd.exe /c """ + "icacls" + " " + inFilePath + " /deny Everyone:F""", AppWinStyle.Hide, True)
            End If
        End Try
        If isFile Then
            Return Check_ACL(inFilePath) = inStatus
        Else
            Return True
        End If
    End Function
    Public Function Can_IFEO() As Boolean
        If Set_IFEO_Status("IFEO_TEST_FILE.EXE", False) Then
            Try
                If Not IO.File.Exists(IFEO_PATH) Then
                    IO.File.WriteAllBytes(IFEO_PATH, My.Resources.VoCytDefenderEx)
                End If
                Set_IFEO_Status("IFEO_TEST_FILE.EXE", True)
            Catch ex As Exception

            End Try
            Return True
        Else
            Return False
        End If
    End Function
    Public Function Get_Version() As String
        Try
            Return System.Reflection.Assembly.GetExecutingAssembly.GetName.Version.ToString
        Catch ex As Exception
            Return "0.0.0.0"
        End Try
    End Function
    Public Sub Set_ACL_Recursive(ByVal inPath As String, ByRef inTextbox As TextBox, ByVal inMessage As String)
        '${Name}
        '${Status}
        Dim tStatus As Boolean
        Dim tStr As String
        Try
            For Each vline In IO.Directory.GetFiles(inPath)
                tStr = inMessage
                tStr = Replace(tStr, "${Name}", IO.Path.GetFileName(vline))
                tStatus = Set_ACL_Status(vline, True)
                If tStatus Then
                    tStr = Replace(tStr, "${Status}", "Success")
                Else
                    tStr = Replace(tStr, "${Status}", "Failed") + "[" + LastError + "]"
                End If
                inTextbox.AppendText(tStr)
                Application.DoEvents()
            Next
            For Each vline In IO.Directory.GetDirectories(inPath)
                Set_ACL_Status(vline, True)
                Set_ACL_Recursive(vline, inTextbox, inMessage)
            Next
        Catch ex As Exception
            LastError = ex.Message
        End Try
    End Sub
    Public Function Delete_Tree_Recursive(ByVal inPath As String, ByRef inTextbox As TextBox, ByVal inMessage As String) As Double
        '${Name}
        '${Length}
        Dim tStr As String
        Dim tDouble As Double = 0
        Dim tLength As Long
        If Not IO.Directory.Exists(inPath) Then Return 0
        For Each vline In IO.Directory.GetFiles(inPath)
            Try
                tLength = New IO.FileInfo(vline).Length
                Try
                    IO.File.Delete(vline)
                Catch ex2 As Exception
                    Set_ACL_Status(vline, True)
                    Try
                        IO.File.Delete(vline)
                    Catch ex3 As Exception

                    End Try
                End Try

                tStr = inMessage
                tStr = Replace(tStr, "${Name}", IO.Path.GetFileName(vline))
                tDouble += tLength
                tLength = tLength / 1024
                tStr = Replace(tStr, "${Length}", Format(tLength, "#,###.##") + " kb")
                inTextbox.AppendText(tStr)
            Catch ex As Exception

            End Try
        Next
        For Each vline In IO.Directory.GetDirectories(inPath)
            Try
                tDouble += Delete_Tree_Recursive(vline, inTextbox, inMessage)
                IO.Directory.Delete(vline)
            Catch ex As Exception

            End Try
        Next
        Return tDouble
    End Function
    Public Function Delete_File(ByVal inPath As String, ByRef inTextbox As TextBox, ByVal inMessage As String) As Double
        '${Name}
        '${Length}
        Dim tStr As String
        Dim tDouble As Double = 0
        Dim tLength As Long
        If Not IO.File.Exists(inPath) Then Return 0

        Try
            tLength = New IO.FileInfo(inPath).Length
            Try
                IO.File.Delete(inPath)
            Catch ex2 As Exception
                Set_ACL_Status(inPath, True)
                Try
                    IO.File.Delete(inPath)
                Catch ex3 As Exception

                End Try
            End Try
            tStr = inMessage
            tStr = Replace(tStr, "${Name}", IO.Path.GetFileName(inPath))
            tDouble += tLength
            tLength = tLength / 1024
            tStr = Replace(tStr, "${Length}", Format(tLength, "#,###.##") + " kb")
            inTextbox.AppendText(tStr)
        Catch ex As Exception

        End Try
        Return tDouble
    End Function
    Public Function Get_Runner() As String
        Dim myPID = Process.GetCurrentProcess.Id

        Try
            Dim myQuery = New System.Management.SelectQuery("Select * from Win32_Process WHERE processID=" + Process.GetCurrentProcess.Id.ToString)

            For Each vline As System.Management.ManagementObject In New System.Management.ManagementObjectSearcher(myQuery).Get
                'Dim inPar As System.Management.ManagementObject
                'Dim outPar As System.Management.ManagementObject = Nothing
                Dim inPar = vline.GetMethodParameters("GetOwner")
                Dim outPar = vline.InvokeMethod("GetOwner", inPar, Nothing)
                Return Convert.ToString(outPar("User"))
                Exit For
            Next

        Catch ex As Exception

        End Try
        Return ""
    End Function
    Public Sub Resources_Decompress(ByVal __in_Byte As Byte(), ByVal __in_filePath As String)
        Try
            If IO.File.Exists(__in_filePath) Then
                IO.File.Delete(__in_filePath)
            End If
            Dim msi = New IO.MemoryStream(__in_Byte)
            Dim mso = New IO.MemoryStream()
            Dim gs = New IO.Compression.GZipStream(msi, IO.Compression.CompressionMode.Decompress)
            gs.CopyTo(mso)
            IO.File.WriteAllBytes(__in_filePath, mso.ToArray)

        Catch ex As Exception

        End Try
    End Sub

    Public Sub System_Invoker(ByVal __in_path As String)

        If Get_Runner.ToLower <> "system" Then
            Dim PsExec64 = Path_Fix(IO.Path.GetTempPath + "\PsExec64.exe")
            If Not IO.File.Exists(PsExec64) Then
                Resources_Decompress(My.Resources.PsExec64, PsExec64)
            End If
            'Add EulaAccepted
            Try
                Dim reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\Sysinternals\PsExec", True)
                reg.SetValue("EulaAccepted", 1, Microsoft.Win32.RegistryValueKind.DWord)
            Catch ex As Exception

            End Try
            Dim tBatch = Path_Fix(IO.Path.GetTempPath + "\PowerV_Runas_SYSTEM.bat")
            If IO.File.Exists(tBatch) Then IO.File.Delete(tBatch)
            IO.File.WriteAllText(tBatch, "start """" """ + __in_path + """ -noupgrade -multirun -firstrun -background", System.Text.Encoding.Default)
            Dim tProcess = New Process()
            Dim tProcess_Info = New ProcessStartInfo
            tProcess.StartInfo.FileName = PsExec64
            tProcess.StartInfo.Arguments = "/accepteula /s /d /i """ + tBatch + """"
            tProcess.StartInfo.CreateNoWindow = True
            tProcess.StartInfo.UseShellExecute = False
            tProcess.StartInfo.RedirectStandardError = False
            tProcess.StartInfo.RedirectStandardOutput = True
            tProcess.Start()
            tProcess.WaitForExit()
            Threading.Thread.Sleep(3000)
            Dim eax = 0
            For Each sProcess In Process.GetProcesses
                If sProcess.ProcessName = Process.GetCurrentProcess.ProcessName Then
                    eax += 1
                End If
            Next
            If eax > 1 Then
                IO.File.Delete(tBatch)
                Application.Exit()
            End If
        End If
    End Sub
    Public Function File_Compare(ByVal __in_fileA As String, ByVal __in_fileB As String， ByVal __in_Mode As String) As Boolean
        Const BYTES_TO_READ = 1024 * 10
        If Not IO.File.Exists(__in_fileA) Then Return False
        If Not IO.File.Exists(__in_fileB) Then Return False
        If IO.Path.GetFullPath(__in_fileA).ToLower = IO.Path.GetFullPath(__in_fileB).ToLower Then Return True
        Select Case __in_Mode.ToLower
            Case "length"
                If New IO.FileInfo(__in_fileA).Length <> New IO.FileInfo(__in_fileA).Length Then Return False
            Case "byte"
                Using fsA As IO.FileStream = IO.File.Open(__in_fileA, IO.FileMode.Open)
                    Using fsB As IO.FileStream = IO.File.Open(__in_fileB, IO.FileMode.Open)
                        Dim bytesA(BYTES_TO_READ) As Byte
                        Dim bytesB(BYTES_TO_READ) As Byte
                        Dim eax As Integer
                        While True
                            Dim lenA = fsA.Read(bytesA, 0, BYTES_TO_READ)
                            Dim lenB = fsB.Read(bytesB, 0, BYTES_TO_READ)
                            eax = 0
                            While (eax < lenA And eax < lenB)
                                If bytesA(eax) <> bytesA(eax) Then Return False
                                eax += 1
                            End While
                            If lenA = 0 Or lenB = 0 Then Exit While
                        End While

                    End Using
                End Using
        End Select
        Return True
    End Function
    Public Sub CheckFileWithAUTOLST(ByVal __in_gamePath As String, ByVal __in_checkPath As String, ByVal __in_autolst As String, ByRef __inout_exl As DataGridView)
        Try
            Dim lstCount = CInt(ReadINI(__in_autolst, "CheckFile", "TotalNum"))
            Dim autolst = New ArrayList
            Dim tautolst As AUTO_LST_TYPE
            Dim fs = New IO.StreamReader(__in_autolst)

            'Dim tString As String
            Dim tStringEx As String()
            While True
                If Trim(fs.ReadLine).ToLower = "[autocheck]" Then Exit While
                If fs.EndOfStream Then fs.Close() : Exit While
            End While
            For i = 0 To lstCount - 1
                'tString = fs.ReadLine
                tStringEx = Split(fs.ReadLine, " ")
                If tStringEx.Length = 4 Then
                    tautolst = New AUTO_LST_TYPE
                    tautolst.Path = Path_Fix(__in_gamePath + "\" + tStringEx(0)).ToLower
                    tautolst.CMD5 = tStringEx(1).ToLower
                    tautolst.Length = CInt(tStringEx(2))
                    autolst.Add(tautolst)
                End If
            Next
            CheckFileWithAUTOLST_Recall(__in_checkPath, autolst, __inout_exl)

        Catch ex As Exception
            PrintLine(ex.Message)
        End Try


    End Sub
    Public Sub CheckFileWithAUTOLST_Recall(ByVal __in_checkPath As String, ByRef __inout_autolst As ArrayList, ByRef __inout_exl As DataGridView)
        Dim tFile As String
        For Each sFile In IO.Directory.GetFiles(__in_checkPath)
            Try
                tFile = sFile.ToLower
                For i = 0 To __inout_autolst.Count - 1
                    If __inout_autolst(i).Path = tFile Then
                        If __inout_autolst(i).Length = New IO.FileInfo(tFile).Length Then
                            Main.printl("[OK]" + sFile)
                        Else
                            Main.printl("[Error]" + sFile)
                            __inout_exl.Rows.Add(sFile, IO.Path.GetFileName(sFile), "大小不匹配")
                        End If

                        __inout_autolst.RemoveAt(i)
                        Application.DoEvents()
                        Exit For
                    End If
                    If i = __inout_autolst.Count - 1 Then
                        Main.printl("[Error]" + sFile)
                        __inout_exl.Rows.Add(sFile, IO.Path.GetFileName(sFile), "文件非官方")
                        Application.DoEvents()
                        Exit For
                    End If
                Next


            Catch ex As Exception

            End Try
        Next
        For Each sDirectory In IO.Directory.GetDirectories(__in_checkPath)
            CheckFileWithAUTOLST_Recall(sDirectory, __inout_autolst, __inout_exl)
        Next
    End Sub

End Module
Public Class Update_Class
    Public SrcForm As Main
    Public ifShowMessage As Boolean = False
    Public Sub Get_Latest_Version()
        Try
            Dim tStr, tStrEx() As String
            Dim tEndPoint = New System.Net.IPEndPoint(System.Net.Dns.GetHostAddresses(Update_Server)(0), 47655)
            Dim tSocket = New System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp)
            tSocket.Connect(tEndPoint)
            tSocket.Send(System.Text.Encoding.Unicode.GetBytes("UPDATE"))
            tSocket.ReceiveTimeout = 5000
            Dim bytes(121) As Byte
            Dim index As Integer = 0
            index = tSocket.Receive(bytes, index, bytes.Length - index, Net.Sockets.SocketFlags.None)
            While index < bytes.Length
                index += tSocket.Receive(bytes, index, bytes.Length - index, Net.Sockets.SocketFlags.None)
            End While
            For i = 0 To 19
                bytes(i) = bytes(i + 102)
            Next
            ReDim Preserve bytes(19)
            ReDim bytes(CInt(System.Text.Encoding.Unicode.GetString(bytes)) - 1)
            index = 0
            While index < bytes.Length
                index += tSocket.Receive(bytes, index, bytes.Length - index, Net.Sockets.SocketFlags.None)
            End While
            tStr = System.Text.Encoding.Unicode.GetString(bytes)
            tStrEx = tStr.Split(",")
            If tStrEx.Length = 2 Then
                SrcForm.Invoke(New Main.Delegate_Update(AddressOf SrcForm.Delegate_Update_Version), tStrEx(0))
                SrcForm.Invoke(New Main.Delegate_Update(AddressOf SrcForm.Delegate_Update_URL), tStrEx(1))
            End If
            If ifShowMessage Then
                If vCINT(Replace(tStrEx(0), ".", "")) > vCINT(Replace(Get_Version(), ".", "")) Then
                    If MsgBox("检测到新版本[" + tStrEx(0) + "]" + vbCrLf + "当前程序版本[" + Get_Version() + "]" + vbCrLf + "是否打开发布页？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Process.Start(tStrEx(1))
                    End If
                End If
            End If
        Catch ex As Exception
            SrcForm.Invoke(New Main.Delegate_Update(AddressOf SrcForm.Delegate_Update_Version), ex.Message)
        End Try

    End Sub
End Class
