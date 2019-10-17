<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMadicationSupply
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
        Me.btninput = New System.Windows.Forms.Button()
        Me.txtsupply = New System.Windows.Forms.TextBox()
        Me.lblsupply = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btninput
        '
        Me.btninput.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btninput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btninput.Image = Global.T_4A__P2019_TP.My.Resources.Resources.pill_icon
        Me.btninput.Location = New System.Drawing.Point(12, 12)
        Me.btninput.Name = "btninput"
        Me.btninput.Size = New System.Drawing.Size(119, 69)
        Me.btninput.TabIndex = 0
        Me.btninput.Text = "SUPPLY"
        Me.btninput.UseVisualStyleBackColor = False
        '
        'txtsupply
        '
        Me.txtsupply.Location = New System.Drawing.Point(119, 95)
        Me.txtsupply.Name = "txtsupply"
        Me.txtsupply.Size = New System.Drawing.Size(128, 20)
        Me.txtsupply.TabIndex = 2
        '
        'lblsupply
        '
        Me.lblsupply.AutoSize = True
        Me.lblsupply.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblsupply.Location = New System.Drawing.Point(12, 98)
        Me.lblsupply.Name = "lblsupply"
        Me.lblsupply.Size = New System.Drawing.Size(101, 13)
        Me.lblsupply.TabIndex = 3
        Me.lblsupply.Text = "PRICE OF SUPPLY"
        '
        'frmMadicationSupply
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 127)
        Me.Controls.Add(Me.lblsupply)
        Me.Controls.Add(Me.txtsupply)
        Me.Controls.Add(Me.btninput)
        Me.Name = "frmMadicationSupply"
        Me.Text = "Madication Supply"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btninput As Button
    Friend WithEvents txtsupply As TextBox
    Friend WithEvents lblsupply As Label
End Class
