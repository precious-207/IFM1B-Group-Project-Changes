<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHIVTB
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
        Me.btninputdt = New System.Windows.Forms.Button()
        Me.txthivtb = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btninputdt
        '
        Me.btninputdt.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btninputdt.Location = New System.Drawing.Point(12, 70)
        Me.btninputdt.Name = "btninputdt"
        Me.btninputdt.Size = New System.Drawing.Size(121, 40)
        Me.btninputdt.TabIndex = 0
        Me.btninputdt.Text = "Input Data"
        Me.btninputdt.UseVisualStyleBackColor = False
        '
        'txthivtb
        '
        Me.txthivtb.Location = New System.Drawing.Point(139, 12)
        Me.txthivtb.Multiline = True
        Me.txthivtb.Name = "txthivtb"
        Me.txthivtb.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txthivtb.Size = New System.Drawing.Size(307, 170)
        Me.txthivtb.TabIndex = 1
        '
        'FrmHIVTB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 191)
        Me.Controls.Add(Me.txthivtb)
        Me.Controls.Add(Me.btninputdt)
        Me.Name = "FrmHIVTB"
        Me.Text = "HIVTB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btninputdt As Button
    Friend WithEvents txthivtb As TextBox
End Class
