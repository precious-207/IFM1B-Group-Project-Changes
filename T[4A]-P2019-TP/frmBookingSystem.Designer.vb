<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookingSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookingSystem))
        Me.grdBook = New UJGrid.UJGrid()
        Me.btnViewedPatients = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'grdBook
        '
        Me.grdBook.Cols = 5
        Me.grdBook.FixedCols = 1
        Me.grdBook.FixedRows = 1
        Me.grdBook.Location = New System.Drawing.Point(349, 36)
        Me.grdBook.Margin = New System.Windows.Forms.Padding(4)
        Me.grdBook.Name = "grdBook"
        Me.grdBook.Rows = 6
        Me.grdBook.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdBook.Size = New System.Drawing.Size(635, 239)
        Me.grdBook.TabIndex = 0
        Me.grdBook.TabStop = False
        '
        'btnViewedPatients
        '
        Me.btnViewedPatients.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnViewedPatients.Image = Global.T_4A__P2019_TP.My.Resources.Resources.confirm_schedule
        Me.btnViewedPatients.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnViewedPatients.Location = New System.Drawing.Point(12, 202)
        Me.btnViewedPatients.Name = "btnViewedPatients"
        Me.btnViewedPatients.Size = New System.Drawing.Size(321, 74)
        Me.btnViewedPatients.TabIndex = 3
        Me.btnViewedPatients.Text = "Patients that have been seen by Dr."
        Me.btnViewedPatients.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnViewedPatients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnViewedPatients.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.AntiqueWhite
        Me.btnEdit.Image = Global.T_4A__P2019_TP.My.Resources.Resources.edit
        Me.btnEdit.Location = New System.Drawing.Point(12, 139)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(321, 53)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit Patient Booking"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.LightCoral
        Me.btnDelete.Image = Global.T_4A__P2019_TP.My.Resources.Resources.x_button
        Me.btnDelete.Location = New System.Drawing.Point(12, 76)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(321, 53)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete Patient Booking"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightGreen
        Me.btnAdd.Image = Global.T_4A__P2019_TP.My.Resources.Resources.plus__2_
        Me.btnAdd.Location = New System.Drawing.Point(12, 13)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(321, 53)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Patient Booking"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(563, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 26)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Current Booking Schedule:"
        '
        'frmBookingSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 288)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnViewedPatients)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grdBook)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBookingSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdBook As UJGrid.UJGrid
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnViewedPatients As Button
    Friend WithEvents Label1 As Label
End Class
