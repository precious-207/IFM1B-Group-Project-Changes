<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnDisplaySalary = New System.Windows.Forms.Button()
        Me.BtnTakeAttendance = New System.Windows.Forms.Button()
        Me.BtnRegisterEmployees = New System.Windows.Forms.Button()
        Me.TxtSalary = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnDisplaySalary
        '
        Me.BtnDisplaySalary.Location = New System.Drawing.Point(46, 174)
        Me.BtnDisplaySalary.Name = "BtnDisplaySalary"
        Me.BtnDisplaySalary.Size = New System.Drawing.Size(225, 46)
        Me.BtnDisplaySalary.TabIndex = 1
        Me.BtnDisplaySalary.Text = "Display Salary"
        Me.BtnDisplaySalary.UseVisualStyleBackColor = True
        '
        'BtnTakeAttendance
        '
        Me.BtnTakeAttendance.Location = New System.Drawing.Point(46, 100)
        Me.BtnTakeAttendance.Name = "BtnTakeAttendance"
        Me.BtnTakeAttendance.Size = New System.Drawing.Size(225, 48)
        Me.BtnTakeAttendance.TabIndex = 9
        Me.BtnTakeAttendance.Text = "Take Attendance"
        Me.BtnTakeAttendance.UseVisualStyleBackColor = True
        '
        'BtnRegisterEmployees
        '
        Me.BtnRegisterEmployees.Location = New System.Drawing.Point(46, 39)
        Me.BtnRegisterEmployees.Name = "BtnRegisterEmployees"
        Me.BtnRegisterEmployees.Size = New System.Drawing.Size(225, 46)
        Me.BtnRegisterEmployees.TabIndex = 8
        Me.BtnRegisterEmployees.Text = "Register Employees"
        Me.BtnRegisterEmployees.UseVisualStyleBackColor = True
        '
        'TxtSalary
        '
        Me.TxtSalary.Location = New System.Drawing.Point(309, 39)
        Me.TxtSalary.Multiline = True
        Me.TxtSalary.Name = "TxtSalary"
        Me.TxtSalary.Size = New System.Drawing.Size(402, 336)
        Me.TxtSalary.TabIndex = 10
        '
        'frmSalary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtSalary)
        Me.Controls.Add(Me.BtnDisplaySalary)
        Me.Controls.Add(Me.BtnTakeAttendance)
        Me.Controls.Add(Me.BtnRegisterEmployees)
        Me.Name = "frmSalary"
        Me.Text = "frmSalary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnDisplaySalary As Button
    Friend WithEvents BtnTakeAttendance As Button
    Friend WithEvents BtnRegisterEmployees As Button
    Friend WithEvents TxtSalary As TextBox
End Class
