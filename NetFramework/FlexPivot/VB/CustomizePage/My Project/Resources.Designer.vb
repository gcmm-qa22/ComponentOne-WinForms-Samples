﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34014
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
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
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property CollapseAll() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("CollapseAll", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;FlexPivotViews&gt;
        '''  
        '''  &lt;C1FlexPivotPage id=&quot;Product vs Country&quot;&gt;
        '''    &lt;C1FlexPivotEngine&gt;
        '''      &lt;Fields&gt;
        '''        &lt;Field name=&quot;Address&quot; subtotal=&quot;Count&quot; /&gt;
        '''        &lt;Field name=&quot;City&quot; subtotal=&quot;Count&quot; /&gt;
        '''        &lt;Field name=&quot;Country&quot; subtotal=&quot;Count&quot; /&gt;
        '''        &lt;Field name=&quot;CustomerID&quot; subtotal=&quot;Count&quot; /&gt;
        '''        &lt;Field name=&quot;Customers_CompanyName&quot; subtotal=&quot;Count&quot; /&gt;
        '''        &lt;Field name=&quot;Discount&quot; subtotal=&quot;Sum&quot; format=&quot;n0&quot; /&gt;
        '''        &lt;Field name=&quot;ExtendedPrice&quot; subtotal=&quot;Sum&quot; format=&quot;n0&quot; /&gt;
        '''       [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property FlexPivotViews() As String
            Get
                Return ResourceManager.GetString("FlexPivotViews", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Views_small() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Views_small", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
