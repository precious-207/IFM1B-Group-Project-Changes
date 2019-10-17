Option Strict On
Option Explicit On
Option Infer Off

Friend Class RecordStructures

    'Unique Id's
    Friend Shared UniqueIDs As Integer = 0

    'Can only be accessed by this application.
    Friend Structure PatientRec
        Public PatientID As Integer
        <VBFixedString(30)> Public Name As String
        <VBFixedString(30)> Public Surname As String
        <VBFixedString(10)> Public Gender As String
        <VBFixedString(15)> Public ID As String
        <VBFixedString(8)> Public DOB As String
        <VBFixedString(200)> Public Address As String
    End Structure
    'size of structure = 594 bytes
    'nRecords to store = 4050 max records



    'Generate New id for a patient
    Public Sub GenID()
        UniqueIDs += 1
    End Sub

End Class
