' *********************************************************************************
' TEAM NUMBER: 4A
' Member 1: Patel, U (219019235)
' Member 2: Bennett, J (219078393)
' Member 3: Madzivadondo, P (219089895)
' Member 4: Sethosa, M (218029523)
' Class name: frmLogin
' *********************************************************************************

Option Strict On
Option Explicit On
Option Infer Off

'Login form/page
Public Class frmLogin
    'm
    'Login details hardcoded.
    'Case sensitive
    Private Username As String = "Admin"
    Private password As String = "Admin"

    'Button Login:
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Validate if correct credentials are entered:
        If txtUsername.Text = Username And txtPassword.Text = password Then

            frmHome.Show()      'show the main home page to user
            Me.Close() 'Close the login page

        Else         'if password is wrong
            'Display a message with courtesy 
            MsgBox("Error, invalid Username or Password entered, please try again. ", MsgBoxStyle.Critical, "Incorrect details. ")

        End If

    End Sub

    'Show password Checkbox: 
    Private Sub cboxPassword_CheckedChanged(sender As Object, e As EventArgs) Handles cboxPassword.CheckedChanged
        'If box is ticked: Show password
        If cboxPassword.Checked Then
            txtPassword.UseSystemPasswordChar = False

        Else
            'If box is not ticked: Hide password
            txtPassword.UseSystemPasswordChar = True
        End If


    End Sub

    'Link label to clear textboxes
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class