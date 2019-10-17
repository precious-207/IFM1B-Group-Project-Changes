Option Strict On
Option Explicit On
Option Infer Off

Public MustInherit Class Person

    Protected _Name As String
    Protected _Surname As String
    Protected _Gender As String
    Protected _ID As String

    '<Property Methods>

    Public Property Name As String
        Set(value As String)
            _Name = value
        End Set
        Get
            Return _Name
        End Get
    End Property

    Public Property Surname As String
        Set(value As String)
            _Surname = value
        End Set
        Get
            Return _Surname
        End Get
    End Property

    Public Property Gender As String
        Set(value As String)
            _Gender = value
        End Set
        Get
            Return _Gender
        End Get
    End Property






End Class
