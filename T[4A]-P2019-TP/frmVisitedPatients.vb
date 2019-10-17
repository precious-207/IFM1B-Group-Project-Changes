' *********************************************************************************
' TEAM NUMBER: 4A
' Member 1: Patel, U (219019235)
' Member 2: Bennett, J (219078393)
' Member 3: Madzivadondo, P (219089895)
' Member 4: Sethosa, M (218029523)
' Class name: frmVisitedPatients
' *********************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Imports System.IO

Public Class frmVisitedPatients

    'Form is loaded:
    Private Sub frmVisitedPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load visited Patients from file that have boolean value of True - field name [Seen]    *fix


        'SetUp grid
        SetGrid()
    End Sub

    '<Custom Methods>

    'Method to place text onto grid
    Public Sub PT(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grdVPatient.Row = r
        grdVPatient.Col = c
        grdVPatient.Text = t
    End Sub

    'Methods to Setup Grid
    Private Sub SetGrid()
        'Input headings for cols
        PT(0, 0, "Patient ID")
        PT(0, 1, "Name")
        PT(0, 2, "Surname")
        PT(0, 3, "Date Seen")
    End Sub

End Class