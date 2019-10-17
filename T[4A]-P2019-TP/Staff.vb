Option Strict On
Option Explicit On
Option Infer Off

Public MustInherit Class Staff
    Inherits Person

    Protected _Salary As Double
    Protected _Qualification As String
    Protected _Attendance As Integer

    Public Property Qulification() As String
        Get
            Return _Qualification
        End Get
        Set(value As String)
            _Qualification = value
        End Set
    End Property

    Public Property Attendance() As Integer
        Get
            Return _Attendance
        End Get
        Set(value As Integer)
            _Attendance = value
        End Set
    End Property

    Public Sub New(ByVal Name As String, ByVal Surname As String, ByVal ID As String)
        _Name = Name
        _Surname = Surname
        _ID = ID 'ID has to be int
    End Sub

#Region "Methods"
    Public MustOverride Function CalcSalary() As Double

    Public MustOverride Function DisplaySalary() As String
#End Region

End Class
