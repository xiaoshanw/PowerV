﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    '此类是由 StronglyTypedResourceBuilder
    '类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    '若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    '(以 /str 作为命令选项)，或重新生成 VS 项目。
    '''<summary>
    '''  一个强类型的资源类，用于查找本地化的字符串等。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  返回此类使用的缓存的 ResourceManager 实例。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("神秘力量V.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  使用此强类型资源类，为所有资源查找
        '''  重写当前线程的 CurrentUICulture 属性。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property bitbug_favicon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("bitbug_favicon", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 TP3Helper.exe|0|%DNF%\TP3Helper.exe
        '''TPHelper.exe|0|%DNF%\TCLS\TenProtect\TP\TPHelper\TPHelper.exe
        '''TPWeb.exe|0|%DNF%\TCLS\TenProtect\TP\TPHelper\TPWeb.exe
        '''tgp_gamead.exe|0|%DNF%\start\Cross\Apps\DNFTips\tgp_gamead\tgp_gamead.exe
        '''AdvertDialog.exe|0|%DNF%\TCLS\AdvertDialog.exe
        '''AdvertTips.exe|0|%DNF%\TCLS\AdvertTips.exe
        '''BackgroundDownloader.exe|0|%DNF%\TCLS\BackgroundDownloader.exe
        '''qbclient.exe|2|%DNF%\start\Cross\Core\Stable\QBBlink\qbclient.exe
        '''DNFADApp.dll|2|%DNF%\start\Cross\Apps\DNFAD\DNFADApp.dll        ''' [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property default_NList() As String
            Get
                Return ResourceManager.GetString("default_NList", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 这是一份使用说明，以便快速上手本软件：
        '''①左侧模块为功能清单，点击即可进入
        '''②右侧模块为对应功能操作面板
        '''③右下模块为功能输出日志
        '''④点击左侧各模块后，右侧模块面板会有功能介绍及操作指引
        '''
        '''针对DNF的快速优化方案：
        '''①设置-设置游戏目录
        '''②常规禁用-禁用设置-一件禁用
        '''
        '''针对DNF的高阶优化方案：
        '''①常规禁用-禁用清单-右键-添加/删除插件/修改禁用方式
        '''②常规禁用-禁用清单-IFEO/ACL操作
        '''
        '''适用全环境的拦截方案：
        '''①驱动拦截-拦截清单-右键-添加/删除/引用拦截
        '''②驱动拦截-拦截设置-注册驱动服务-启动驱动服务
        '''
        '''更新日志：
        '''2023-01-05 Ver:0.1.2.5
        '''1.优化驱动拦截功能
        '''2.删除部分已失效功能
        '''
        '''2022-12-19 Ver:0.1.2.4
        '''1.更新驱动拦截签名文件
        '''2.更新驱动拦截失败时的提示信息
        '''3.更新软件说明书（Bilibili:https://www.bilibili.com/read/cv20651056）
        '''
        '''2022-09-20 Ver:0.1.2.3
        '''1.更新加群链接
        '''
        '''2022-07-06 Ver [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property Hello() As String
            Get
                Return ResourceManager.GetString("Hello", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property qun1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("qun1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property qun2() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("qun2", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property qun3() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("qun3", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Byte[] 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property vLimit_10() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("vLimit_10", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Byte[] 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property vLimit_7() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("vLimit_7", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Byte[] 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property VoCytDefenderEx() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("VoCytDefenderEx", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 若Win10系统出现【未能转换部分或所有标识引用】的提示，则您的系统可能存在如下问题：
        '''1、系统权限异常，如非法启用并使用Administrator用户(非原生安装系统/使用网络精简系统多数为此原因导致)
        '''2、账户权限异常，如requireAdministrator请求未按Windows默认设置审批
        '''3、系统文件缺失
        '''4、某管家某卫士某精灵的不可描述的骚操作
        '''
        '''解决方法一：
        '''1、右键游戏文件夹-属性-安全-高级-更改权限(没有这个按钮可忽略)
        '''2、点击禁用继承-选择【从此对象中删除所有已继承的权限】（点击以后“权限条目”为空）
        '''3、添加-主体选择-输入Everyone-类型：允许-勾选完全控制-确定
        '''4、勾选【使用可从此对象继承的权限项目替换所有子对象的权限项目】-确定
        '''5、弹窗提示【这将使来自XXXXXX的可继承权限替换此对象的所有子对象的明确定义权限】-是-确定
        '''6、设置结束后，本软件禁用功能可恢复正常
        '''
        '''解决方法二：
        '''1、使用驱动拦截功能 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property Win10ACLError() As String
            Get
                Return ResourceManager.GetString("Win10ACLError", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property wx() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("wx", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property zfb() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("zfb", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
