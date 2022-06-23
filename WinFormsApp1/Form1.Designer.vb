<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.loginPassword = New System.Windows.Forms.MaskedTextBox()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnLgn = New System.Windows.Forms.Button()
        Me.Upassword = New System.Windows.Forms.Label()
        Me.loginName = New System.Windows.Forms.TextBox()
        Me.Uname = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.loginPassword)
        Me.Panel1.Controls.Add(Me.BtnNew)
        Me.Panel1.Controls.Add(Me.BtnLgn)
        Me.Panel1.Controls.Add(Me.Upassword)
        Me.Panel1.Controls.Add(Me.loginName)
        Me.Panel1.Controls.Add(Me.Uname)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Panel1.Location = New System.Drawing.Point(12, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1276, 803)
        Me.Panel1.TabIndex = 0
        '
        'loginPassword
        '
        Me.loginPassword.Font = New System.Drawing.Font("Segoe UI Emoji", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.loginPassword.Location = New System.Drawing.Point(158, 418)
        Me.loginPassword.Name = "loginPassword"
        Me.loginPassword.Size = New System.Drawing.Size(491, 43)
        Me.loginPassword.TabIndex = 9
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.Teal
        Me.BtnNew.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnNew.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnNew.Location = New System.Drawing.Point(1009, 513)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(220, 89)
        Me.BtnNew.TabIndex = 8
        Me.BtnNew.Text = "Create New Account"
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'BtnLgn
        '
        Me.BtnLgn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnLgn.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnLgn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnLgn.Location = New System.Drawing.Point(168, 529)
        Me.BtnLgn.Name = "BtnLgn"
        Me.BtnLgn.Size = New System.Drawing.Size(190, 50)
        Me.BtnLgn.TabIndex = 7
        Me.BtnLgn.Text = "Log In"
        Me.BtnLgn.UseVisualStyleBackColor = False
        '
        'Upassword
        '
        Me.Upassword.AutoSize = True
        Me.Upassword.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Upassword.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Upassword.Location = New System.Drawing.Point(158, 360)
        Me.Upassword.Name = "Upassword"
        Me.Upassword.Size = New System.Drawing.Size(150, 41)
        Me.Upassword.TabIndex = 5
        Me.Upassword.Text = "Password"
        '
        'loginName
        '
        Me.loginName.AccessibleName = "UserName"
        Me.loginName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.loginName.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.loginName.Location = New System.Drawing.Point(168, 281)
        Me.loginName.Name = "loginName"
        Me.loginName.Size = New System.Drawing.Size(481, 43)
        Me.loginName.TabIndex = 4
        '
        'Uname
        '
        Me.Uname.AutoSize = True
        Me.Uname.Font = New System.Drawing.Font("Segoe UI Emoji", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Uname.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Uname.Location = New System.Drawing.Point(168, 197)
        Me.Uname.Name = "Uname"
        Me.Uname.Size = New System.Drawing.Size(173, 40)
        Me.Uname.TabIndex = 3
        Me.Uname.Text = "User Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1005, 258)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 215)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Emoji", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox1.Location = New System.Drawing.Point(249, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(921, 50)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Welcome To Movie Ticket Management System"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 815)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "MTMS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Upassword As Label
    Friend WithEvents loginName As TextBox
    Friend WithEvents Uname As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnNew As Button
    Friend WithEvents BtnLgn As Button

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub UserName(sender As Object, e As EventArgs) Handles loginName.TextChanged



    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog

    Private Sub BtnLgn_Click(sender As Object, e As EventArgs) Handles BtnLgn.Click
        Dim Name As String
        Dim Password As String
        Name = loginName.Text
        Password = loginPassword.Text
        If Name = "Binaya" And Password = "Binaya123" Then
            Admin_Panel.Show()

        Else
            User_Pannel.Show()

        End If




    End Sub

    Friend WithEvents loginPassword As MaskedTextBox

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Registervb.Show()
        Me.Hide()
    End Sub
End Class
