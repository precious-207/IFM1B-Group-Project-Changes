Option Strict On
Option Explicit On
Option Infer Off

Public Class FrmHIVTB

    Private hivot() As HIVorTBpatient     'Array for hiv/tb patients

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btninputdt.Click

        Dim hot As Integer        'Hiv/Tb
        Dim tab As Integer        'Number of tablets recieved at beginning of month
        Dim pati As String        'Patient ID
        Dim stat As String        'Status
        Dim remi As Integer       'Remaining days till next pickup
        Dim pnum As Integer       'Patient Number

        ReDim Preserve hivot(Patient.UniqueIDs)

        pnum = CInt(InputBox("Enter Patient Number"))
        pati = InputBox("Enter Patient ID")
        hot = CInt(InputBox("Does The Patient Have TB=1" + Environment.NewLine + "HIV=2"))
        tab = CInt(InputBox("How Many Tablets Did The Patient Recieve?"))
        remi = tab - 3
        hivot(pnum) = New HIVorTBpatient(pati, hot, tab)

        If hot = 2 Then
            stat = "HIV"
        Else
            stat = "TB"
        End If

        txthivtb.Text = "Patient: " + CStr(pati) + Environment.NewLine + "Patient Status: " + stat + Environment.NewLine + "Amount Of Tablets: " + CStr(tab) + "Days Remaining Till Next Pickup: " + CStr(remi)

    End Sub

End Class