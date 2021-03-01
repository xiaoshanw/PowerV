Imports System.Runtime.InteropServices
Module winapi
    <System.Runtime.InteropServices.DllImport("ntdll.dll", SetLastError:=True)>
    Public Function NtSuspendProcess(ByVal processHandle As IntPtr) As IntPtr
    End Function
    <System.Runtime.InteropServices.DllImport("ntdll.dll", SetLastError:=True)>
    Public Function NtResumeProcess(ByVal processHandle As IntPtr) As IntPtr
    End Function
    <System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError:=True, CharSet:=Runtime.InteropServices.CharSet.Unicode)>
    Public Function OpenSCManager(ByVal machineName As String, ByVal databaseName As String, ByVal dwAccess As UInteger) As IntPtr
    End Function
    <System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError:=True, CharSet:=Runtime.InteropServices.CharSet.Unicode)>
    Public Function CreateService(ByVal hSCManager As IntPtr, ByVal lpServiceName As String, ByVal lpDisplayName As String, ByVal dwDesiredAccess As Integer, ByVal dwServiceType As Integer, ByVal dwStartType As Integer, ByVal dwErrorControl As Integer, ByVal lpBinaryPathName As String, ByVal lpLoadOrderGroup As String, ByVal lpdwTagId As Integer, ByVal lpDependencies As Integer, ByVal lpServiceStartName As Integer, ByVal lpPassword As Integer) As IntPtr
    End Function
    <System.Runtime.InteropServices.DllImport("advapi32.dll", SetLastError:=True)>
    Public Function CloseServiceHandle(ByVal serviceHandle As IntPtr) As Boolean
    End Function

    Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As IntPtr, ByVal lpFileName As String) As IntPtr
    Public Declare Function WritePrivateProfileString Lib "kernel32" Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As IntPtr
    Public Declare Ansi Function RtlAdjustPrivilege Lib "ntdll.dll" (ByVal Privilege As Integer, ByVal Enable As Boolean, ByVal Client As Boolean, ByRef WasEnabled As Integer) As Integer
    Public Declare Ansi Function RtlSetProcessIsCritical Lib "ntdll.dll" (ByVal NewValue As Integer, ByVal Value As Integer, ByVal WinLogon As Integer) As Integer
    Public Declare Ansi Function NtRaiseHardError Lib "ntdll.dll" (ByVal ErrorStatus As Integer, ByVal NumberOfParameters As Integer, ByVal UnicodeStringParameterMask As Integer, ByVal Parameters As Integer, ByVal ValidResponseOption As Integer, ByRef Response As Integer) As UInteger

    Public Const SC_MANAGER_CREATE_SERVICE = 2
    Public Const SERVICE_START = 16
    Public Const SERVICE_KERNEL_DRIVER = 1
    Public Const SERVICE_DEMAND_START = 3
    Public Const SERVICE_ERROR_IGNORE = 0
    Public Const SC_MINIMIZE = &HF020 '窗体最小化消息
    Public Const WM_SYSCOMMAND = &H112

End Module
