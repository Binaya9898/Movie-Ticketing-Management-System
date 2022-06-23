<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registervb
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Ugender = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Udob = New System.Windows.Forms.Label()
        Me.Uaddress = New System.Windows.Forms.Label()
        Me.Uname = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Teal
        Me.GroupBox1.Controls.Add(Me.BtnSubmit)
        Me.GroupBox1.Controls.Add(Me.backBtn)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Ugender)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Udob)
        Me.GroupBox1.Controls.Add(Me.Uaddress)
        Me.GroupBox1.Controls.Add(Me.Uname)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1140, 788)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Ugender
        '
        Me.Ugender.AutoSize = True
        Me.Ugender.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Ugender.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Ugender.Location = New System.Drawing.Point(868, 367)
        Me.Ugender.Name = "Ugender"
        Me.Ugender.Size = New System.Drawing.Size(112, 38)
        Me.Ugender.TabIndex = 8
        Me.Ugender.Text = "Gender"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI Emoji", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(298, 344)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(346, 43)
        Me.DateTimePicker1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Teal
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.TextBox1.Location = New System.Drawing.Point(406, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(393, 57)
        Me.TextBox1.TabIndex = 6
        Me.TextBox1.Text = "Enter Your Credentials"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(39, 636)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(230, 41)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = " New Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(39, 529)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 41)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "User Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(39, 437)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 41)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Email"
        '
        'Udob
        '
        Me.Udob.AutoSize = True
        Me.Udob.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Udob.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Udob.Location = New System.Drawing.Point(39, 346)
        Me.Udob.Name = "Udob"
        Me.Udob.Size = New System.Drawing.Size(206, 41)
        Me.Udob.TabIndex = 2
        Me.Udob.Text = "Date Of Birth"
        '
        'Uaddress
        '
        Me.Uaddress.AutoSize = True
        Me.Uaddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Uaddress.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Uaddress.Location = New System.Drawing.Point(39, 254)
        Me.Uaddress.Name = "Uaddress"
        Me.Uaddress.Size = New System.Drawing.Size(131, 41)
        Me.Uaddress.TabIndex = 1
        Me.Uaddress.Text = "Address"
        '
        'Uname
        '
        Me.Uname.AutoSize = True
        Me.Uname.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Uname.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Uname.Location = New System.Drawing.Point(39, 164)
        Me.Uname.Name = "Uname"
        Me.Uname.Size = New System.Drawing.Size(161, 41)
        Me.Uname.TabIndex = 0
        Me.Uname.Text = "Full Name"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Teal
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox1.Location = New System.Drawing.Point(986, 330)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 42)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Male"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Teal
        Me.CheckBox2.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox2.Location = New System.Drawing.Point(986, 363)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(128, 42)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "Female"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.BackColor = System.Drawing.Color.Teal
        Me.CheckBox3.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox3.Location = New System.Drawing.Point(986, 400)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(122, 42)
        Me.CheckBox3.TabIndex = 11
        Me.CheckBox3.Text = "Others"
        Me.CheckBox3.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.Location = New System.Drawing.Point(298, 169)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(346, 38)
        Me.TextBox2.TabIndex = 12
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox3.Location = New System.Drawing.Point(298, 259)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(346, 38)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox4.Location = New System.Drawing.Point(298, 442)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(346, 38)
        Me.TextBox4.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox5.Location = New System.Drawing.Point(298, 544)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(346, 38)
        Me.TextBox5.TabIndex = 15
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox6.Location = New System.Drawing.Point(298, 639)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(346, 38)
        Me.TextBox6.TabIndex = 16
        '
        'backBtn
        '
        Me.backBtn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.backBtn.Location = New System.Drawing.Point(18, 38)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(94, 29)
        Me.backBtn.TabIndex = 17
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnSubmit.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSubmit.Location = New System.Drawing.Point(509, 727)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(152, 55)
        Me.BtnSubmit.TabIndex = 18
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'Registervb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 802)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Registervb"
        Me.Text = "Registervb"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Udob As Label
    Friend WithEvents Uaddress As Label
    Friend WithEvents Uname As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Ugender As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents backBtn As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
