' *********************************************************************************
' TEAM NUMBER: 4A
' Member 1: Patel, U (219019235)
' Member 2: Bennett, J (219078393)
' Member 3: Madzivadondo, P (219089895)
' Member 4: Sethosa, M (218029523)
' Class name: frmBookingSystem
' *********************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Imports System.IO

Public Class frmBookingSystem

    'Form is loaded:
    Private Sub frmBookingSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Read patient data from file *fix

        'Setup Grid
        SetGrid()
    End Sub



    '<Custom Methods>

    'Method to place text onto grid
    Public Sub PT(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grdBook.Row = r
        grdBook.Col = c
        grdBook.Text = t
    End Sub

    'Methods to Setup Grid
    Private Sub SetGrid()
        'Input headings for cols
        PT(0, 0, "Patient ID")
        PT(0, 1, "Name")
        PT(0, 2, "Surname")
        PT(0, 3, "Paid for booking")
        PT(0, 4, "Booking Date")
    End Sub

    'Booking system form is closed
    Private Sub frmBookingSystem_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Show the main home form
        frmHome.Show()
    End Sub

    'Viewed Patients button clicked:
    Private Sub btnViewedPatients_Click(sender As Object, e As EventArgs) Handles btnViewedPatients.Click
        'Show the viewed patients form and correct the position
        frmVisitedPatients.Show()
        frmVisitedPatients.StartPosition = FormStartPosition.CenterParent
    End Sub
End Class