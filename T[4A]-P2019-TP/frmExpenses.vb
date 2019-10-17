' *********************************************************************************
' TEAM NUMBER: 4A
' Member 1: Patel, U (219019235)
' Member 2: Bennett, J (219078393)
' Member 3: Madzivadondo, P (219089895)
' Member 4: Sethosa, M (218029523)
' Class name: frmExpenses
' *********************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Imports System.IO

Public Class frmExpenses

    'When form is closed
    Private Sub frmExpenses_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'show the main form
        frmHome.Show()
    End Sub

End Class