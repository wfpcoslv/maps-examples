Imports System
Imports System.Net
Imports System.Security.Cryptography.X509Certificates
' Requiere Newtonsoft JSON, descargar desde: http://www.newtonsoft.com/json
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Individual
    Public api As MAPSAPI
    ' Se llama al momento de carga del formulario para inicializar valores por defecto
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        api = New MAPSAPI()
        ' Formatos de fecha utilizados para los DatePicker
        datePickerBirthdate.CustomFormat = "yyyy-MM-dd"
        dateTimeRegDate.CustomFormat = "yyyy-MM-ddTHH:mm:ss"
    End Sub

    ' Metodo llamado al hacer clic en el botón pra descargar el token
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call DownloadToken()
    End Sub

    ' Funcion utilitaria para deshabilitar el chequeo de origen del certificado.
    Public Function AcceptAllCertifications()
        Return True
    End Function

    ' Esta rutina habilita todos los controles en el formulario
    Public Sub EnableInputs()
        optBenefGrp.Enabled = True
        datePickerBirthdate.Enabled = True
        txtComment.Enabled = True
        txtDelDocumentId.Enabled = True
        txtDelFirstName.Enabled = True
        txtDelLastName.Enabled = True
        optRel.Enabled = True
        txtDocumentId.Enabled = True
        txtFirstName.Enabled = True
        optGender.Enabled = True
        txtLastName.Enabled = True
        dateTimeRegDate.Enabled = True
        btnMultiLoader.Enabled = True
    End Sub

    ' Esta rutina descarga el Token 
    Public Sub DownloadToken()
        api.SetCredentials(txtUser.Text, txtPass.Text)
        If Not txtSrvAddr.Text.Equals("") Then
            api.SetAuthServer(txtSrvAddr.Text)
        End If

        api.UpdateToken()

        If api.IsConnected Then
            txtStatus.Text = "Token obtenido exitosamente"
            txtToken.Text = api.Token
            EnableInputs()
        Else
            txtStatus.Text = "Error: revise conexion o credenciales."
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim data As JObject
        Dim benefGroup As JObject
        Dim newId As Int32

        ' Creación de objetos de estructura para llamada de API
        data = New JObject()
        benefGroup = New JObject()

        ' Los códigos de grupo deben obtenerse desde el panel de administración u opcionalmente
        ' haciendo las llamadas a la API: en https://maps-staging.wfp.famoco.com/backoffice/swagger-ui/index.html#!/beneficiary-group-resource/getBeneficiaryGroupByOrganizationUsingGET
        If String.Compare(optBenefGrp.Text, "Embarazadas") = 0 Then
            benefGroup.Add("id", 1)
        ElseIf String.Compare(optBenefGrp.Text, "Lactantes") = 0 Then
            benefGroup.Add("id", 2)
        ElseIf String.Compare(optBenefGrp.Text, "Niños") = 0 Then
            benefGroup.Add("id", 3)
        End If

        ' Grupo de beneficiarios, debe ser un objeto JSON
        data.Add("beneficiaryGroup", benefGroup)
        ' Fecha de nacimiento
        data.Add("birthDate", datePickerBirthdate.Text)
        ' Comentarios o data adicional como número de expediente u otras llaves
        data.Add("comment", txtComment.Text)

        ' Número de documento de identificación o RUP
        data.Add("documentId", txtDocumentId.Text)
        ' Primer nombre del titular
        data.Add("firstName", txtFirstName.Text)
        ' Segundo nombre del titular
        data.Add("lastName", txtLastName.Text)
        ' Sexo
        data.Add("gender", optGender.Text)

        ' Documento de identificación de delegado
        data.Add("delegateDocumentId", txtDelDocumentId.Text)
        ' Primer nombre del delegado
        data.Add("delegateFirstName", txtDelFirstName.Text)
        ' Segundo nombre del delegado
        data.Add("delegateLastName", txtDelLastName.Text)
        ' Relación del delegado con el titular.
        data.Add("delegateRelationship", optRel.Text)

        ' Fecha de registro. Se utiliza la fecha de creación de la tarjeta en el aparato
        ' Idealmente se debería de colocar la fecha de firma del convenio si se tiene
        data.Add("registrationDate", dateTimeRegDate.Text + "Z")

        ' Datos requeridos para esta versión de la API
        data.Add("version", 2)
        data.Add("deleted", False)

        txtStatus.Text = "Enviando info beneficiario"
        newId = api.AddBeneficiary(data)
        If newId > 0 Then
            txtStatus.Text = "Beneficiario registrado. ID: " + newId.ToString()
        Else
            txtStatus.Text = "Error en registro, revise parametros o conexion."
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiLoader.Click
        DataLoader.SetAPI(Me.api)
        DataLoader.Show()
        Me.Hide()
    End Sub

    Private Sub Individual_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class
