﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System


'This class was auto-generated by the StronglyTypedResourceBuilder
'class via a tool like ResGen or Visual Studio.
'To add or remove a member, edit your .ResX file then rerun ResGen
'with the /str option, or rebuild your VS project.
'''<summary>
'''  A strongly-typed resource class, for looking up localized strings, etc.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
Friend Class Resources
    
    Private Shared resourceMan As Global.System.Resources.ResourceManager
    
    Private Shared resourceCulture As Global.System.Globalization.CultureInfo
    
    <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
    Friend Sub New()
        MyBase.New
    End Sub
    
    '''<summary>
    '''  Returns the cached ResourceManager instance used by this class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
        Get
            If Object.ReferenceEquals(resourceMan, Nothing) Then
                Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("DashboardDemo.Resources", GetType(Resources).Assembly)
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
    Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
        Get
            Return resourceCulture
        End Get
        Set
            resourceCulture = value
        End Set
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to SELECT * FROM Customers.
    '''</summary>
    Friend Shared ReadOnly Property Customers() As String
        Get
            Return ResourceManager.GetString("Customers", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to .
    '''</summary>
    Friend Shared ReadOnly Property qwe() As String
        Get
            Return ResourceManager.GetString("qwe", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to SELECT DISTINCT 
    '''    Round( ([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount) , 2) AS [Sales],
    '''    Orders.OrderDate AS [OrderDate],
    '''    Products.ProductName AS [Product],
    '''    Customers.CompanyName AS [Customer],
    '''    Customers.Country AS [Country],
    '''    Employees.FirstName + &apos; &apos; + Employees.LastName AS [Employee],
    '''    Categories.CategoryName AS [Category]
    '''FROM 
    '''    (Employees INNER JOIN
    '''    (Customers INNER JOIN
    '''    (Orders INNER JOIN
    '''    ([Order Details] INNER JOIN
    '''    (Pro [rest of string was truncated]&quot;;.
    '''</summary>
    Friend Shared ReadOnly Property Sales() As String
        Get
            Return ResourceManager.GetString("Sales", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to SELECT DISTINCT 
    '''    Round( Sum(([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount)), 2) AS [Sales],
    '''    Customers.Country AS [Country]
    '''FROM 
    '''    (Employees INNER JOIN
    '''    (Customers INNER JOIN
    '''    (Orders INNER JOIN
    '''    ([Order Details] INNER JOIN
    '''    (Products INNER JOIN Categories 
    '''    ON Categories.CategoryID = Products.CategoryID)
    '''    ON Products.ProductID = [Order Details].ProductID)
    '''    ON Orders.OrderID = [Order Details].OrderID)
    '''    ON Customers.CustomerID = Orders.C [rest of string was truncated]&quot;;.
    '''</summary>
    Friend Shared ReadOnly Property SalesByCountry() As String
        Get
            Return ResourceManager.GetString("SalesByCountry", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to SELECT DISTINCT 
    '''    ROUND( Sum(([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount)), 2) AS [Sales],
    '''    Employees.FirstName + &apos; &apos; + Employees.LastName AS [Employee]
    '''FROM 
    '''    (Employees INNER JOIN
    '''    (Customers INNER JOIN
    '''    (Orders INNER JOIN
    '''    ([Order Details] INNER JOIN
    '''    (Products INNER JOIN Categories 
    '''    ON Categories.CategoryID = Products.CategoryID)
    '''    ON Products.ProductID = [Order Details].ProductID)
    '''    ON Orders.OrderID = [Order Details].OrderID)
    '''    ON C [rest of string was truncated]&quot;;.
    '''</summary>
    Friend Shared ReadOnly Property SalesByEmployee() As String
        Get
            Return ResourceManager.GetString("SalesByEmployee", resourceCulture)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized string similar to SELECT DISTINCT 
    '''    ROUND(Sum(([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount)), 2) AS [Sales]
    '''FROM 
    '''    [Order Details].
    '''</summary>
    Friend Shared ReadOnly Property TotalSales() As String
        Get
            Return ResourceManager.GetString("TotalSales", resourceCulture)
        End Get
    End Property
End Class
