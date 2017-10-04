Imports System
Imports System.Net
Imports System.Security.Cryptography.X509Certificates
' Requiere Newtonsoft JSON, descargar desde: http://www.newtonsoft.com/json
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1
    ' Se llama al momento de carga del formulario para inicializar valores por defecto
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
    End Sub

    ' Esta rutina descarga el Token 
    Public Sub DownloadToken()
        Dim objHttpWebRequest As System.Net.HttpWebRequest
        Dim requestURL As String
        Dim webResponse As System.Net.WebResponse
        Dim textReader As System.IO.StreamReader
        Dim tokenRsp As JObject

        ' Importante: la siguiente línea ignora el origen del certificado.
        System.Net.ServicePointManager.ServerCertificateValidationCallback = AddressOf AcceptAllCertifications

        ' Iniciamos sesion con nuestro usuario y password
        requestURL = "https://maps-staging.wfp.famoco.com/backoffice/oauth/token?username=" + txtUser.Text + "&password=" + txtPass.Text + "&grant_type=password&scope=read%20write&client_secret=my-secret-token-to-change-in-production&client_id=mapsapp"
        objHttpWebRequest = System.Net.HttpWebRequest.Create(requestURL)
        objHttpWebRequest.Method = "POST"

        Try
            txtStatus.Text = "Intentando obtener token"

            ' Llamada a OAUTH
            webResponse = objHttpWebRequest.GetResponse()

            ' Convertimos respuesta a JSON
            textReader = New System.IO.StreamReader(webResponse.GetResponseStream)
            tokenRsp = JsonConvert.DeserializeObject(textReader.ReadToEnd())

            ' Extraemos el Token y habilitamos el formulario
            TextBox1.Text = tokenRsp.Item("access_token")
            EnableInputs()

            txtStatus.Text = "Token obtenido exitosamente"
        Catch e As Exception
            txtStatus.Text = "Error: revise conexion o credenciales."
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim objHttpWebRequest As System.Net.HttpWebRequest
        Dim data As JObject
        Dim benefGroup As JObject
        Dim requestURL As String
        Dim requestStream As System.IO.Stream
        Dim buffer As Byte()
        Dim webResponse As System.Net.WebResponse
        Dim textReader As System.IO.StreamReader
        Dim tokenRsp As JObject
        Dim jsonTxt As String

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

        ' Texto en JSON
        jsonTxt = data.ToString(Newtonsoft.Json.Formatting.None)
        ' Texto en Bytes para enviar en el cuerpo de la solicitud
        buffer = System.Text.Encoding.Unicode.GetBytes(jsonTxt)

        ' Importante: la siguiente línea ignora el origen del certificado.
        System.Net.ServicePointManager.ServerCertificateValidationCallback = AddressOf AcceptAllCertifications

        ' Petición de ingreso de beneficiario en URL:
        ' https://maps-staging.wfp.famoco.com/backoffice/swagger-ui/index.html#!/beneficiary-resource/createBeneficiaryUsingPOST
        requestURL = "https://maps-staging.wfp.famoco.com/backoffice/api/beneficiaries"
        objHttpWebRequest = System.Net.HttpWebRequest.Create(requestURL)
        objHttpWebRequest.Method = "POST"
        objHttpWebRequest.ContentType = "application/json"
        objHttpWebRequest.Accept = "application/json"
        ' Utilizamos el token obtenido anteriormente
        objHttpWebRequest.Headers.Add("Authorization", "Bearer " + TextBox1.Text)

        Try
            txtStatus.Text = "Enviando info beneficiario"

            ' Enviamos la data en JSON como cuerpo de la petición
            requestStream = objHttpWebRequest.GetRequestStream()
            requestStream.Write(buffer, 0, buffer.Length)
            requestStream.Close()

            ' Obtenemos la respuesta, devuelve un objeto de características similares
            ' a las enviadas en la petición
            webResponse = objHttpWebRequest.GetResponse()
            textReader = New System.IO.StreamReader(webResponse.GetResponseStream)
            tokenRsp = JsonConvert.DeserializeObject(textReader.ReadToEnd())

            txtStatus.Text = "Beneficiario registrado. ID: " + tokenRsp.GetValue("id").ToString()
        Catch ex As Exception
            txtStatus.Text = "Error en registro, revise parametros o conexion."
        End Try

    End Sub

End Class
