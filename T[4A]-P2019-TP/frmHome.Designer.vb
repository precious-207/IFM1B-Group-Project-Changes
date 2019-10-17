<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.btnMedication = New System.Windows.Forms.Button()
        Me.btnManagepatients = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.btnExpenses = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(765, 635)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(261, 22)
        Me.DateTimePicker1.TabIndex = 5
        Me.DateTimePicker1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1027, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(117, 24)
        Me.ToolStripMenuItem1.Text = "Check this up..."
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 28)
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Location = New System.Drawing.Point(763, 610)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(66, 17)
        Me.lblLocation.TabIndex = 8
        Me.lblLocation.Text = "Location:"
        '
        'btnMedication
        '
        Me.btnMedication.BackColor = System.Drawing.Color.Violet
        Me.btnMedication.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMedication.Font = New System.Drawing.Font("Segoe UI Symbol", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedication.Image = Global.T_4A__P2019_TP.My.Resources.Resources.pill_icon72
        Me.btnMedication.Location = New System.Drawing.Point(517, 426)
        Me.btnMedication.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMedication.Name = "btnMedication"
        Me.btnMedication.Size = New System.Drawing.Size(316, 142)
        Me.btnMedication.TabIndex = 9
        Me.btnMedication.Text = "Medication Supplies"
        Me.btnMedication.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnMedication.UseVisualStyleBackColor = False
        '
        'btnManagepatients
        '
        Me.btnManagepatients.BackColor = System.Drawing.Color.LightCoral
        Me.btnManagepatients.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnManagepatients.Font = New System.Drawing.Font("Segoe UI Symbol", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManagepatients.Image = Global.T_4A__P2019_TP.My.Resources.Resources.managep
        Me.btnManagepatients.Location = New System.Drawing.Point(172, 426)
        Me.btnManagepatients.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnManagepatients.Name = "btnManagepatients"
        Me.btnManagepatients.Size = New System.Drawing.Size(316, 142)
        Me.btnManagepatients.TabIndex = 3
        Me.btnManagepatients.Text = "Edit/Delete Patients"
        Me.btnManagepatients.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnManagepatients.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI Symbol", 6.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = Global.T_4A__P2019_TP.My.Resources.Resources.Log_in_icon
        Me.btnLogout.Location = New System.Drawing.Point(5, 578)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(84, 81)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.TabStop = False
        Me.btnLogout.Text = "Log Out"
        Me.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnBooking
        '
        Me.btnBooking.BackColor = System.Drawing.Color.Bisque
        Me.btnBooking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBooking.Font = New System.Drawing.Font("Segoe UI Symbol", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooking.Image = Global.T_4A__P2019_TP.My.Resources.Resources.Books_icon
        Me.btnBooking.Location = New System.Drawing.Point(352, 257)
        Me.btnBooking.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(319, 142)
        Me.btnBooking.TabIndex = 1
        Me.btnBooking.Text = "Booking System"
        Me.btnBooking.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnBooking.UseVisualStyleBackColor = False
        '
        'btnExpenses
        '
        Me.btnExpenses.BackColor = System.Drawing.Color.Honeydew
        Me.btnExpenses.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExpenses.Font = New System.Drawing.Font("Segoe UI Symbol", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpenses.Image = Global.T_4A__P2019_TP.My.Resources.Resources.Coins_icon2
        Me.btnExpenses.Location = New System.Drawing.Point(699, 257)
        Me.btnExpenses.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnExpenses.Name = "btnExpenses"
        Me.btnExpenses.Size = New System.Drawing.Size(319, 142)
        Me.btnExpenses.TabIndex = 2
        Me.btnExpenses.Text = "Expenses"
        Me.btnExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnExpenses.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.T_4A__P2019_TP.My.Resources.Resources.Home_Page_logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1027, 223)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnCapture
        '
        Me.btnCapture.BackColor = System.Drawing.Color.SkyBlue
        Me.btnCapture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCapture.Font = New System.Drawing.Font("Segoe UI Symbol", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapture.Image = Global.T_4A__P2019_TP.My.Resources.Resources.Pen_4_icon
        Me.btnCapture.Location = New System.Drawing.Point(5, 257)
        Me.btnCapture.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(316, 142)
        Me.btnCapture.TabIndex = 0
        Me.btnCapture.Text = "Record Patient Information"
        Me.btnCapture.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnCapture.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(879, 595)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "create file"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1027, 666)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnMedication)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.btnManagepatients)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnBooking)
        Me.Controls.Add(Me.btnExpenses)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome: SHH Home Page"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCapture As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnExpenses As Button
    Friend WithEvents btnBooking As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnManagepatients As Button
    Friend WithEvents lblLocation As Label
    Friend WithEvents btnMedication As Button
    Friend WithEvents Button1 As Button
End Class
