Module Code
    Public bkCheckBox_Checked As Boolean = True
    Public Update_Server = "update.vocyt.com"  'update_address
    Public CONFIG As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\" + Application.ProductName
    Public INI As String = CONFIG + "\config.ini"
    Public IFEO_PATH As String = Path_Fix(IO.Path.GetDirectoryName(INI) + "\VoCytDefenderEx.exe")
    Public vLimit_DAT As String = "C:\Users\Public\Documents\vLimit\vLimit.dat"
    Public vLimit_SYS As String = "C:\Users\Public\Documents\vLimit\vLimit.sys"
    Public LastError As String
    Public Last_DNF_PID As Integer
    Public TREE_MANUAL_SELECT As Boolean = True
    Public Hide_Active As Boolean = False
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As IntPtr, ByVal lpFileName As String) As IntPtr
    Private Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As IntPtr
    Public Declare Ansi Function RtlAdjustPrivilege Lib "ntdll.dll" (ByVal Privilege As Integer, ByVal Enable As Boolean, ByVal Client As Boolean, ByRef WasEnabled As Integer) As Integer
    Public Declare Ansi Function RtlSetProcessIsCritical Lib "ntdll.dll" (ByVal NewValue As Integer, ByVal Value As Integer, ByVal WinLogon As Integer) As Integer
    Public Declare Ansi Function NtRaiseHardError Lib "ntdll.dll" (ByVal ErrorStatus As Integer, ByVal NumberOfParameters As Integer, ByVal UnicodeStringParameterMask As Integer, ByVal Parameters As Integer, ByVal ValidResponseOption As Integer, ByRef Response As Integer) As UInteger
    <System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError:=True, CharSet:=Runtime.InteropServices.CharSet.Unicode)>
    Public Function OpenSCManager(ByVal machineName As String, ByVal databaseName As String, ByVal dwAccess As UInteger) As IntPtr
    End Function
    <System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError:=True, CharSet:=Runtime.InteropServices.CharSet.Unicode)>
    Public Function CreateService(ByVal hSCManager As IntPtr, ByVal lpServiceName As String, ByVal lpDisplayName As String, ByVal dwDesiredAccess As Integer, ByVal dwServiceType As Integer, ByVal dwStartType As Integer, ByVal dwErrorControl As Integer, ByVal lpBinaryPathName As String, ByVal lpLoadOrderGroup As String, ByVal lpdwTagId As Integer, ByVal lpDependencies As Integer, ByVal lpServiceStartName As Integer, ByVal lpPassword As Integer) As IntPtr
    End Function
    <System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError:=True)>
    Public Function CloseServiceHandle(ByVal serviceHandle As IntPtr) As Boolean
    End Function
    Public Const SC_MANAGER_CREATE_SERVICE = 2
    Public Const SERVICE_START = 16
    Public Const SERVICE_KERNEL_DRIVER = 1
    Public Const SERVICE_DEMAND_START = 3
    Public Const SERVICE_ERROR_IGNORE = 0
    Public Const SC_MINIMIZE = &HF020 '窗体最小化消息
    Public Const WM_SYSCOMMAND = &H112
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
        Return Replace(inString, "\\", "\")
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
    Public Function vCINT(ByVal inObject As Object)
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
