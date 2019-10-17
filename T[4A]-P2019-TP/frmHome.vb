' *********************************************************************************
' TEAM NUMBER: 4A
' Member 1: Patel, U (219019235)
' Member 2: Bennett, J (219078393)
' Member 3: Madzivadondo, P (219089895)
' Member 4: Sethosa, M (218029523)
' Class name: frmHome 
' *********************************************************************************

Imports System.IO
Imports T_4A__P2019_TP.RecordStructures

Public Class frmHome
    'Get current date
    Public Current As DateTime = New DateTime


    'When form load/starts
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get current date:
        Current = DateTimePicker1.Value
    End Sub


    'When the add patient clicked:
    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        'show the form to add a patient
        frmAddPatient.Show()

        'Hide the main form
        Me.Hide()

    End Sub

    'Booking system button clicked:
    Private Sub btnBooking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        'Show the booking sytem form and hide the current home page form
        frmBookingSystem.Show()
        Me.Hide()
    End Sub

    'Log out button clicked:
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        'Prompt user to return to the Login Page:

        Dim prompt As Integer = MsgBox("Are you sure you would like to Log out? ", MsgBoxStyle.YesNo, "Log out")

        'validate response:
        If prompt = 6 Then
            'show login page and close current form
            frmLogin.Show()
            Me.Close()
        End If
    End Sub

    'Exit button clicked:
    Private Sub pbClose_Click(sender As Object, e As EventArgs)
        Dim close As Integer = MsgBox("Close the program.", MsgBoxStyle.YesNo, "Exit program")

        'validate response:
        If close = 6 Then
            Me.Close()
        End If
    End Sub

    'Expenses button clicked:
    Private Sub btnExpenses_Click(sender As Object, e As EventArgs) Handles btnExpenses.Click
        'Show expenses form and hide main form
        frmSalary.Show()
        Me.Hide()
    End Sub

    'create 2 random files with x amount of records
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Create file for patients information:
        Dim pFS As FileStream
        Dim BW As BinaryWriter
        Dim BR As BinaryReader
        Const patientFILELOC As String = "PatientsInfo.txt"
        Const nPatients As String = "Settings.txt"


        'Blank record
        Dim Blank As PatientRec
        Blank.PatientID = -1      'unique identifier
        Blank.Name = Space(30)
        Blank.Surname = Space(30)
        Blank.Gender = Space(10)
        Blank.ID = Space(15)
        Blank.DOB = Space(8)
        Blank.Address = Space(200)


        Dim pFilesize As Double = 594 * 4050
        pFS = New FileStream(patientFILELOC, FileMode.Create, FileAccess.Write)
        BW = New BinaryWriter(pFS)
        pFS.SetLength(pFilesize)

        'write the blank record 4050 times
        For s As Integer = 0 To 4049
            pFS.Seek(s * 594, SeekOrigin.Begin)
            BW.Write(Blank.PatientID)
            BW.Write(Blank.Name)
            BW.Write(Blank.Surname)
            BW.Write(Blank.Gender)
            BW.Write(Blank.ID)
            BW.Write(Blank.DOB)
            BW.Write(Blank.Address)
        Next s
        pFS.Close()

        MsgBox("File created successfully")
    End Sub

    'Medication supplies button clicked:
    Private Sub btnMedication_Click(sender As Object, e As EventArgs) Handles btnMedication.Click
        'Show Medication supply form and hide current home form
        frmMadicationSupply.Show()
        Me.Hide()
    End Sub
End Class


