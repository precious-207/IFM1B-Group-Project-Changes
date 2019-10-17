Option Strict On
Option Explicit On
Option Infer Off

Public Class frmSalary

    Private Staff() As Staff
    Private nS As Integer

    Private Sub BtnRegisterEmployees_Click(sender As Object, e As EventArgs) Handles BtnRegisterEmployees.Click

        nS = CInt(InputBox("How many Staff Memebers in Total?"))
        ReDim Staff(nS)

    End Sub

    Private Sub BtnTakeAttendance_Click(sender As Object, e As EventArgs) Handles BtnTakeAttendance.Click

        For s As Integer = 1 To nS

            Dim Choice As Integer
            Choice = CInt(InputBox("1. Head Nurse, 2. Nurse, 3. Doctor, 4. Specialist, 5. Maintanance Person"))

            Dim Name, Surname, Qualification, Gender, ID As String
            Dim Attendance As Integer

            Name = InputBox("Name:")
            Surname = InputBox("Surname: ")
            Gender = InputBox("1. Male, 2. Female")
            ID = InputBox("ID: ")
            Qualification = InputBox("Qualification: ")
            Attendance = CInt(InputBox("Days of Attendance: "))

            Select Case Choice
                Case 1 ' Head Nurse
                    Dim tmpHeadNurse As New HeadNurse(Name, Surname, ID)
                    tmpHeadNurse.Gender = Gender
                    tmpHeadNurse.Qulification = Qualification
                    tmpHeadNurse.Attendance = Attendance

                    Staff(s) = tmpHeadNurse 'upcasting

                Case 2 ' Nurse

                    Dim tmpNurse As New Nurse(Name, Surname, ID)
                    tmpNurse.Gender = Gender
                    tmpNurse.Qulification = Qualification
                    tmpNurse.Attendance = Attendance

                    Staff(s) = tmpNurse 'upcasting

                Case 3 'Doctor

                    Dim tmpDoctor As New Doctor(Name, Surname, ID)
                    tmpDoctor.Gender = Gender
                    tmpDoctor.Qulification = Qualification
                    tmpDoctor.Attendance = Attendance

                    Staff(s) = tmpDoctor 'upcasting

                Case 4 'specialist

                    Dim tmpSpecialist As New Specialist(Name, Surname, ID)
                    tmpSpecialist.Gender = Gender
                    tmpSpecialist.Qulification = Qualification
                    tmpSpecialist.Attendance = Attendance

                    Staff(s) = tmpSpecialist 'upcasting

                Case 5 'Maintanance Person

                    Dim tmpMaintanance As New CommunityMember(Name, Surname, ID)
                    tmpMaintanance.Gender = Gender
                    tmpMaintanance.Qulification = Qualification
                    tmpMaintanance.Attendance = Attendance

                    Staff(s) = tmpMaintanance 'upcasting

            End Select

        Next s

    End Sub

    Private Sub BtnDisplaySalary_Click(sender As Object, e As EventArgs) Handles BtnDisplaySalary.Click

        For s As Integer = 1 To nS
            TxtSalary.AppendText(Staff(s).DisplaySalary() + Environment.NewLine)
        Next s

    End Sub

    Private Sub frmSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'When the form is closed.
    Private Sub frmSalary_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'show the main home page
        frmHome.Show()
    End Sub
End Class