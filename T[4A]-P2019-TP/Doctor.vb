Option Strict On
Option Explicit On
Option Infer Off

Public Class Doctor
    Inherits Staff

    Private _Hours As Integer

    Public Sub New(ByVal Name As String, ByVal Surname As String, ByVal ID As String)
        MyBase.New(Name, Surname, ID)
    End Sub

#Region "Mehods"
    Public Overrides Function CalcSalary() As Double
        'earns R1100 for 6 hours
        Dim Total As Integer = 0
        If _Hours >= 6 Then
            Total = 1100
        End If

        'R200 per hour for extra time
        Dim ExtraTime As Integer = 0
        While _Hours - 6 > 0
            ExtraTime += _Hours * 200
        End While

        Return Total + ExtraTime
    End Function

    Public Overrides Function DisplaySalary() As String
        Return ">> DOCTOR <<" + Environment.NewLine +
            "Name: " + _Name + Environment.NewLine +
            "Surname: " + _Surname + Environment.NewLine +
            "Gender: " + Gender + Environment.NewLine +
            "ID: " + _ID + Environment.NewLine +
            "Qualification: " + _Qualification + Environment.NewLine +
            "Total Salary: " + CStr(CalcSalary()) + Environment.NewLine
    End Function
#End Region

End Class
