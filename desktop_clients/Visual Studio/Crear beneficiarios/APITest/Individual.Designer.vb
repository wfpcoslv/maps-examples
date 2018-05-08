<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Individual
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtToken = New System.Windows.Forms.TextBox
        Me.optBenefGrp = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtComment = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDelDocumentId = New System.Windows.Forms.TextBox
        Me.txtDelFirstName = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtDocumentId = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.optGender = New System.Windows.Forms.ComboBox
        Me.optRel = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtDelLastName = New System.Windows.Forms.TextBox
        Me.datePickerBirthdate = New System.Windows.Forms.DateTimePicker
        Me.dateTimeRegDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.btnMultiLoader = New System.Windows.Forms.Button
        Me.txtSrvAddr = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Obtener Token"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Token:"
        '
        'txtToken
        '
        Me.txtToken.Location = New System.Drawing.Point(60, 87)
        Me.txtToken.Name = "txtToken"
        Me.txtToken.Size = New System.Drawing.Size(261, 20)
        Me.txtToken.TabIndex = 0
        '
        'optBenefGrp
        '
        Me.optBenefGrp.Enabled = False
        Me.optBenefGrp.FormattingEnabled = True
        Me.optBenefGrp.Items.AddRange(New Object() {"Embarazadas", "Lactantes", "Niños"})
        Me.optBenefGrp.Location = New System.Drawing.Point(137, 170)
        Me.optBenefGrp.Name = "optBenefGrp"
        Me.optBenefGrp.Size = New System.Drawing.Size(184, 21)
        Me.optBenefGrp.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Grupo Beneficiario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha nacimiento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 459)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Comentarios o data:"
        '
        'txtComment
        '
        Me.txtComment.Enabled = False
        Me.txtComment.Location = New System.Drawing.Point(137, 459)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(184, 20)
        Me.txtComment.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Docu. Delegado:"
        '
        'txtDelDocumentId
        '
        Me.txtDelDocumentId.Enabled = False
        Me.txtDelDocumentId.Location = New System.Drawing.Point(137, 328)
        Me.txtDelDocumentId.Name = "txtDelDocumentId"
        Me.txtDelDocumentId.Size = New System.Drawing.Size(184, 20)
        Me.txtDelDocumentId.TabIndex = 8
        '
        'txtDelFirstName
        '
        Me.txtDelFirstName.Enabled = False
        Me.txtDelFirstName.Location = New System.Drawing.Point(137, 354)
        Me.txtDelFirstName.Name = "txtDelFirstName"
        Me.txtDelFirstName.Size = New System.Drawing.Size(184, 20)
        Me.txtDelFirstName.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nombres delegado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 409)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Relación con titular:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Documento (o #RUP):"
        '
        'txtDocumentId
        '
        Me.txtDocumentId.Enabled = False
        Me.txtDocumentId.Location = New System.Drawing.Point(137, 249)
        Me.txtDocumentId.Name = "txtDocumentId"
        Me.txtDocumentId.Size = New System.Drawing.Size(184, 20)
        Me.txtDocumentId.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 197)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Nombres:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Enabled = False
        Me.txtFirstName.Location = New System.Drawing.Point(137, 197)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(184, 20)
        Me.txtFirstName.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 302)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Sexo:"
        '
        'txtLastName
        '
        Me.txtLastName.Enabled = False
        Me.txtLastName.Location = New System.Drawing.Point(137, 223)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(184, 20)
        Me.txtLastName.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 223)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Apellidos:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 433)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Fecha registro:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 485)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Ingresar Beneficiario"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'optGender
        '
        Me.optGender.Enabled = False
        Me.optGender.FormattingEnabled = True
        Me.optGender.Items.AddRange(New Object() {"M", "F"})
        Me.optGender.Location = New System.Drawing.Point(267, 301)
        Me.optGender.Name = "optGender"
        Me.optGender.Size = New System.Drawing.Size(54, 21)
        Me.optGender.TabIndex = 7
        '
        'optRel
        '
        Me.optRel.Enabled = False
        Me.optRel.FormattingEnabled = True
        Me.optRel.Items.AddRange(New Object() {"M"})
        Me.optRel.Location = New System.Drawing.Point(267, 406)
        Me.optRel.Name = "optRel"
        Me.optRel.Size = New System.Drawing.Size(54, 21)
        Me.optRel.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(13, 380)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "Apellido delegado:"
        '
        'txtDelLastName
        '
        Me.txtDelLastName.Enabled = False
        Me.txtDelLastName.Location = New System.Drawing.Point(137, 380)
        Me.txtDelLastName.Name = "txtDelLastName"
        Me.txtDelLastName.Size = New System.Drawing.Size(184, 20)
        Me.txtDelLastName.TabIndex = 10
        '
        'datePickerBirthdate
        '
        Me.datePickerBirthdate.Enabled = False
        Me.datePickerBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datePickerBirthdate.Location = New System.Drawing.Point(137, 275)
        Me.datePickerBirthdate.Name = "datePickerBirthdate"
        Me.datePickerBirthdate.Size = New System.Drawing.Size(184, 20)
        Me.datePickerBirthdate.TabIndex = 6
        '
        'dateTimeRegDate
        '
        Me.dateTimeRegDate.Enabled = False
        Me.dateTimeRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTimeRegDate.Location = New System.Drawing.Point(137, 433)
        Me.dateTimeRegDate.Name = "dateTimeRegDate"
        Me.dateTimeRegDate.Size = New System.Drawing.Size(184, 20)
        Me.dateTimeRegDate.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "<- Click para obtener el token"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(16, 535)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(301, 20)
        Me.txtStatus.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 515)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Último estado:"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(137, 12)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(184, 20)
        Me.txtUser.TabIndex = 41
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(137, 35)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(184, 20)
        Me.txtPass.TabIndex = 42
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(13, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Usuario:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Clave:"
        '
        'btnMultiLoader
        '
        Me.btnMultiLoader.Enabled = False
        Me.btnMultiLoader.Location = New System.Drawing.Point(16, 141)
        Me.btnMultiLoader.Name = "btnMultiLoader"
        Me.btnMultiLoader.Size = New System.Drawing.Size(305, 23)
        Me.btnMultiLoader.TabIndex = 45
        Me.btnMultiLoader.Text = "Cargador Masivo"
        Me.btnMultiLoader.UseVisualStyleBackColor = True
        '
        'txtSrvAddr
        '
        Me.txtSrvAddr.Location = New System.Drawing.Point(60, 62)
        Me.txtSrvAddr.Name = "txtSrvAddr"
        Me.txtSrvAddr.Size = New System.Drawing.Size(261, 20)
        Me.txtSrvAddr.TabIndex = 46
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Server:"
        '
        'Individual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 577)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtSrvAddr)
        Me.Controls.Add(Me.btnMultiLoader)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dateTimeRegDate)
        Me.Controls.Add(Me.datePickerBirthdate)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtDelLastName)
        Me.Controls.Add(Me.optRel)
        Me.Controls.Add(Me.optGender)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDocumentId)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDelFirstName)
        Me.Controls.Add(Me.txtDelDocumentId)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.optBenefGrp)
        Me.Controls.Add(Me.txtToken)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Individual"
        Me.Text = "MAPS API Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtToken As System.Windows.Forms.TextBox
    Friend WithEvents optBenefGrp As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDelDocumentId As System.Windows.Forms.TextBox
    Friend WithEvents txtDelFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDocumentId As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents optGender As System.Windows.Forms.ComboBox
    Friend WithEvents optRel As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDelLastName As System.Windows.Forms.TextBox
    Friend WithEvents datePickerBirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateTimeRegDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnMultiLoader As System.Windows.Forms.Button
    Friend WithEvents txtSrvAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label

End Class
