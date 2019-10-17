Option Strict On
Option Explicit On
Option Infer Off

Public Class Patient
    Inherits Person

    Public Shared UniqueIDs As Integer = 0 'Used to generate new id's
    Private _PatientNo As Integer
    Protected _DOB As String
    Protected _Address As String
    Private _Seen As Boolean


    '<Property Methods>
    Public ReadOnly Property PatientNo As Integer
        Get
            Return _PatientNo
        End Get
    End Property

    Public Property Address As String
        Get
            Return _Address
        End Get
        Set(value As String)
            _Address = value
        End Set
    End Property

    Public ReadOnly Property Seen As Boolean
        Get
            Return _Seen
        End Get
    End Property

    '<Constructors>
    Public Sub New(ByVal ID As String)
        GenID()     'generate patient id
        _ID = ID
        'Initialise
        _Seen = False
    End Sub

    '<Methods>

    'Generate unique id for each patient
    Private Sub GenID()
        UniqueIDs += 1  'change value
        _PatientNo = UniqueIDs   'set id for patient
    End Sub

    'Patient was checked by Dr.
    Private Sub VisitedDr()
        _Seen = True
    End Sub

End Class
