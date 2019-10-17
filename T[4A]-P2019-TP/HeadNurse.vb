Option Strict On
Option Explicit On
Option Infer Off

Public Class HeadNurse
    Inherits Nurse

    Public Sub New(ByVal Name As String, ByVal Surname As String, ByVal ID As String)
        MyBase.New(Name, Surname, ID)
    End Sub

    Public Overrides Function CalcSalary() As Double
        Return 1500
        'fixed salary amount
    End Function

    Public Overrides Function DisplaySalary() As String
        Return ">> HEAD NURSE <<" + Environment.NewLine +
            "Name: " + _Name + Environment.NewLine +
            "Surname: " + _Surname + Environment.NewLine +
            "Gender: " + Gender + Environment.NewLine +
            "ID: " + _ID + Environment.NewLine +
            "Qualification: " + _Qualification + Environment.NewLine +
            "Total Salary: " + CStr(CalcSalary()) + Environment.NewLine
    End Function

End Class


