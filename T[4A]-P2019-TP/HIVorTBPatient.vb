Option Strict On
Option Explicit On
Option Infer Off

Public Class HIVorTBpatient
    Inherits Patient

    Private _HoTB As Integer
    Private _Tablets As Integer

    Public Sub New(ByVal ID As String, ByVal ht As Integer, ByVal t As Integer)
        MyBase.New(ID)
        _HoTB = ht
        _Tablets = t

    End Sub

End Class
