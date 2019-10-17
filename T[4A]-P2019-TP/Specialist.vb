Option Strict On
Option Explicit On
Option Infer Off

Public Class Specialist
    Inherits Doctor

    Public Sub New(ByVal Name As String, ByVal Surname As String, ByVal ID As String)
        MyBase.New(Name, Surname, ID)
    End Sub

#Region "methods"

    Public Overrides Function CalcSalary() As Double
        Return 2500
        'R2500 per day for 3 days
    End Function

    Public Overrides Function DisplaySalary() As String
        Return ">> SPECIALIST <<" + Environment.NewLine +
            "Name: " + _Name + Environment.NewLine +
            "Surname: " + _Surname + Environment.NewLine +
            "Gender: " + Gender + Environment.NewLine +
            "ID: " + _ID + Environment.NewLine +
            "Qualification: " + _Qualification + Environment.NewLine +
            "Total Salary: " + CStr(CalcSalary()) + Environment.NewLine
    End Function

#End Region

End Class
