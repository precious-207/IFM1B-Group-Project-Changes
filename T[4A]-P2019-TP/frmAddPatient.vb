' *********************************************************************************
' TEAM NUMBER: 4A
' Member 1: Patel, U (219019235)
' Member 2: Bennett, J (219078393)
' Member 3: Madzivadondo, P (219089895)
' Member 4: Sethosa, M (218029523)
' Class name: frmAddPatient 
' *********************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmAddPatient

    'Variables
    Private Patients() As Patient
    Private nP As Integer = 0 ' number of patients

    'File members:  ***fix
    Private FS As FileStream
    Private BF As BinaryFormatter
    Private Const FILENAME As String = "PatientInfo.txt"


    '(When form loads):
    Private Sub frmAddPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disable id textbox
        txtID.Enabled = False
        's
    End Sub

    '[Get User info from TextBox's]

    'Add button clicked:
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'temp variables to collect from textbox
        Dim Name, Surname, Gender, DateOfBirth, ID, Address As String

        Name = txtName.Text
        Surname = txtSurname.Text
        Gender = txtGender.Text
        DateOfBirth = txtDOB.Text
        ID = txtID.Text
        Address = txtAddress1.Text + " " + txtAddress2.Text

        'Flag used to check if Patient can be recorded
        Dim Create As Boolean = False

        'Check if id/Passport option is selected:
        If rbtnID.Checked = True Or rbtnPassport.Checked = True Then

            'Create the patient

            nP += 1   'increase number of patients
            ReDim Preserve Patients(nP)

            'Create patient obj & Set info
            Patients(nP) = New Patient(ID)
            Patients(nP).Name = Name
            Patients(nP).Surname = Surname
            Patients(nP).Gender = Gender
            Patients(nP).Address = Address

            'Display message: Patient saved.
            Dim msgTodisplay As String = "Successfully recorded Patient information for: " & Patients(nP).Name & " " & Patients(nP).Surname
            MsgBox(msgTodisplay)
            ClearTxtB()         'Clear the textbox's


        Else
            'If no selection:
            MsgBox("Error, Please select an option for Id or Passport.", MsgBoxStyle.Critical, "Id option.")

        End If



    End Sub


    '(Cancel Button is clicked):
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Display message box with Prompt:
        Dim result As Integer = MsgBox("Are you sure you would like to Cancel?", MsgBoxStyle.YesNo, "Cancel Member Info")

        'User result Yes:
        If result = 6 Then
            'Close the Patient info form and Show mainpage form
            Me.Close()
            frmHome.BringToFront()
        End If
    End Sub

    'When form is closed:
    Private Sub frmAddPatient_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmHome.Show()
    End Sub

    '**[Radio buttons]:

    'Id radio button clicked
    Private Sub rbtnID_Click(sender As Object, e As EventArgs) Handles rbtnID.Click
        'Enable Id textbox
        txtID.Enabled = True

        rbtnPassport.Checked = False
    End Sub

    'Passport radio button clicked:
    Private Sub rbtnPassport_Click(sender As Object, e As EventArgs) Handles rbtnPassport.Click
        'Enable Id textbox
        txtID.Enabled = True

        rbtnID.Checked = False
    End Sub

    '<Custom subs>:

    'Clear all textbox's on the form
    Public Sub ClearTxtB()
        txtName.Clear()
        txtSurname.Clear()
        txtGender.Clear()
        txtDOB.Clear()
        txtAddress1.Clear()
        txtAddress2.Clear()
        txtID.Clear()
    End Sub


End Class