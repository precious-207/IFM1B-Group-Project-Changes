Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMadicationSupply
    Private price As Double
    Private supply As Integer


    'calculate the price of the supply of medication odered
    Private Sub btninput_Click(sender As Object, e As EventArgs) Handles btninput.Click
        supply = CInt(InputBox("PLEASE ENTER THE AMOUNT OF MEDICATION SUPPLY YOU NEED"))

        If supply >= 1000 Then
            price = (supply * 10) * 0.07
        Else
            price = supply * 10
        End If

        txtsupply.Text = CStr(price)
    End Sub

    'When form is closed
    Private Sub frmMadicationSupply_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'show the main home form
        frmHome.Show()
    End Sub
End Class