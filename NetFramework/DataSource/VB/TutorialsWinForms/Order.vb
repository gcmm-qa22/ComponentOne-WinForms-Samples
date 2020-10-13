'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel

Partial Public Class Order
	Implements INotifyPropertyChanged
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Sub OnPropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    Private _OrderID As Integer
    Public Property OrderID As Integer
        Get
            Return _OrderID
        End Get
        Set(ByVal value As Integer)
            _OrderID = value
            OnPropertyChanged("OrderID")
        End Set
    End Property

    Private _CustomerID As String
    Public Property CustomerID As String
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As String)
            _CustomerID = value
            OnPropertyChanged("CustomerID")
        End Set
    End Property

    Private _EmployeeID As Nullable(Of Integer)
    Public Property EmployeeID As Nullable(Of Integer)
        Get
            Return _EmployeeID
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _EmployeeID = value
            OnPropertyChanged("EmployeeID")
        End Set
    End Property

    Private _OrderDate As Nullable(Of Date)
    Public Property OrderDate As Nullable(Of Date)
        Get
            Return _OrderDate
        End Get
        Set(ByVal value As Nullable(Of Date))
            _OrderDate = value
            OnPropertyChanged("OrderDate")
        End Set
    End Property

    Private _RequiredDate As Nullable(Of Date)
    Public Property RequiredDate As Nullable(Of Date)
        Get
            Return _RequiredDate
        End Get
        Set(ByVal value As Nullable(Of Date))
            _RequiredDate = value
            OnPropertyChanged("RequiredDate")
        End Set
    End Property

    Private _ShippedDate As Nullable(Of Date)
    Public Property ShippedDate As Nullable(Of Date)
        Get
            Return _ShippedDate
        End Get
        Set(ByVal value As Nullable(Of Date))
            _ShippedDate = value
            OnPropertyChanged("ShippedDate")
        End Set
    End Property

    Private _ShipVia As Nullable(Of Integer)
    Public Property ShipVia As Nullable(Of Integer)
        Get
            Return _ShipVia
        End Get
        Set(ByVal value As Nullable(Of Integer))
            _ShipVia = value
            OnPropertyChanged("ShipVia")
        End Set
    End Property

    Private _Freight As Nullable(Of Decimal)
    Public Property Freight As Nullable(Of Decimal)
        Get
            Return _Freight
        End Get
        Set(ByVal value As Nullable(Of Decimal))
            _Freight = value
            OnPropertyChanged("Freight")
        End Set
    End Property

    Private _ShipName As String
    Public Property ShipName As String
        Get
            Return _ShipName
        End Get
        Set(ByVal value As String)
            _ShipName = value
            OnPropertyChanged("ShipName")
        End Set
    End Property

    Private _ShipAddress As String
    Public Property ShipAddress As String
        Get
            Return _ShipAddress
        End Get
        Set(ByVal value As String)
            _ShipAddress = value
            OnPropertyChanged("ShipAddress")
        End Set
    End Property

    Private _ShipCity As String
    Public Property ShipCity As String
        Get
            Return _ShipCity
        End Get
        Set(ByVal value As String)
            _ShipCity = value
            OnPropertyChanged("ShipCity")
        End Set
    End Property

    Private _ShipRegion As String
    Public Property ShipRegion As String
        Get
            Return _ShipRegion
        End Get
        Set(ByVal value As String)
            _ShipRegion = value
            OnPropertyChanged("ShipRegion")
        End Set
    End Property

    Private _ShipPostalCode As String
    Public Property ShipPostalCode As String
        Get
            Return _ShipPostalCode
        End Get
        Set(ByVal value As String)
            _ShipPostalCode = value
            OnPropertyChanged("ShipPostalCode")
        End Set
    End Property

    Private _ShipCountry As String
    Public Property ShipCountry As String
        Get
            Return _ShipCountry
        End Get
        Set(ByVal value As String)
            _ShipCountry = value
            OnPropertyChanged("ShipCountry")
        End Set
    End Property


    Private _Customer As Customer
    Public Overridable Property Customer As Customer
        Get
            Return _Customer
        End Get
        Set(ByVal value As Customer)
            _Customer = value
            OnPropertyChanged("Customer")
        End Set
    End Property

    Private _Employee As Employee
    Public Overridable Property Employee As Employee
        Get
            Return _Employee
        End Get
        Set(ByVal value As Employee)
            _Employee = value
            OnPropertyChanged("Employee")
        End Set
    End Property

    Private _Order_Details As ObservableCollection(Of Order_Detail) = New ObservableCollection(Of Order_Detail)
    Public Overridable Property Order_Details As ObservableCollection(Of Order_Detail)
        Get
            Return _Order_Details
        End Get
        Set(ByVal value As ObservableCollection(Of Order_Detail))
            _Order_Details = value
            OnPropertyChanged("Order_Details")
        End Set
    End Property

    Private _Shipper As Shipper
    Public Overridable Property Shipper As Shipper
        Get
            Return _Shipper
        End Get
        Set(ByVal value As Shipper)
            _Shipper = value
            OnPropertyChanged("Shipper")
        End Set
    End Property

End Class
