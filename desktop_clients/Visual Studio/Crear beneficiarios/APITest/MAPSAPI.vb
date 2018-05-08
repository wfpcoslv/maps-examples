Imports System
Imports System.Net
Imports System.Security.Cryptography.X509Certificates
' Requiere Newtonsoft JSON, descargar desde: http://www.newtonsoft.com/json
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class MAPSAPI
    Private _token As String
    Private _tokenExpires As DateTime
    Private _username As String
    Private _password As String
    Private _authServer As String
    Private _connected As Boolean

    Public ReadOnly Property Token() As String
        Get
            ' Token expired. Generate a new Token
            If DateTime.Compare(Me._tokenExpires, DateTime.Today) > 0 Then
                Me.UpdateToken()
            End If
            Return Me._token
        End Get
    End Property

    Public Sub New(Optional ByVal server As String = "maps-staging.wfp.famoco.com")
        Me._token = ""
        Me._tokenExpires = DateTime.Now
        Me._username = ""
        Me._password = ""
        Me._authServer = server
        Me._connected = False
    End Sub

    Public Sub SetCredentials(ByVal user As String, ByVal pass As String)
        Me._username = user
        Me._password = pass
    End Sub

    Public Sub SetAuthServer(ByVal server As String)
        Me._authServer = server
    End Sub

    Public Function AcceptAllCertifications()
        Return True
    End Function

    Public Function IsConnected() As Boolean
        Return Me._connected
    End Function

    Public Function AddBeneficiary(ByVal data As JObject) As Int32
        Dim newId = -1
        Dim jsonTxt As String
        Dim buffer As Byte()
        Dim objHttpWebRequest As System.Net.HttpWebRequest
        Dim requestURL As String
        Dim requestStream As System.IO.Stream
        Dim webResponse As System.Net.WebResponse
        Dim textReader As System.IO.StreamReader
        Dim tokenRsp As JObject

        ' Texto en JSON
        jsonTxt = data.ToString(Newtonsoft.Json.Formatting.None)
        ' Texto en Bytes para enviar en el cuerpo de la solicitud
        buffer = System.Text.Encoding.Unicode.GetBytes(jsonTxt)

        ' Importante: la siguiente línea ignora el origen del certificado.
        System.Net.ServicePointManager.ServerCertificateValidationCallback = AddressOf AcceptAllCertifications

        ' Petición de ingreso de beneficiario en URL:
        ' https://maps-staging.wfp.famoco.com/backoffice/swagger-ui/index.html#!/beneficiary-resource/createBeneficiaryUsingPOST
        requestURL = "https://" + Me._authServer + "/backoffice/api/beneficiaries"
        objHttpWebRequest = System.Net.HttpWebRequest.Create(requestURL)
        objHttpWebRequest.Method = "POST"
        objHttpWebRequest.ContentType = "application/json"
        objHttpWebRequest.Accept = "application/json"
        ' Utilizamos el token obtenido anteriormente
        objHttpWebRequest.Headers.Add("Authorization", "Bearer " + Me.Token)

        Try
            ' Enviamos la data en JSON como cuerpo de la petición
            requestStream = objHttpWebRequest.GetRequestStream()
            requestStream.Write(buffer, 0, buffer.Length)
            requestStream.Close()

            ' Obtenemos la respuesta, devuelve un objeto de características similares
            ' a las enviadas en la petición
            webResponse = objHttpWebRequest.GetResponse()
            textReader = New System.IO.StreamReader(webResponse.GetResponseStream)
            tokenRsp = JsonConvert.DeserializeObject(textReader.ReadToEnd())

            newId = CInt(tokenRsp.GetValue("id").ToString())
        Catch ex As Exception
            newId = -1
        End Try

        Return newId
    End Function

    Public Sub UpdateToken()
        Dim objHttpWebRequest As System.Net.HttpWebRequest
        Dim requestURL As String
        Dim webResponse As System.Net.WebResponse
        Dim textReader As System.IO.StreamReader
        Dim tokenRsp As JObject

        ' Importante: la siguiente línea ignora el origen del certificado.
        System.Net.ServicePointManager.ServerCertificateValidationCallback = AddressOf Me.AcceptAllCertifications

        ' Iniciamos sesion con nuestro usuario y password
        requestURL = "https://" + Me._authServer + "/backoffice/oauth/token?username=" + Me._username + "&password=" + Me._password + "&grant_type=password&scope=read%20write&client_secret=my-secret-token-to-change-in-production&client_id=mapsapp"
        objHttpWebRequest = System.Net.HttpWebRequest.Create(requestURL)
        objHttpWebRequest.Method = "POST"

        Try
            ' Llamada a OAUTH
            webResponse = objHttpWebRequest.GetResponse()

            ' Convertimos respuesta a JSON
            textReader = New System.IO.StreamReader(webResponse.GetResponseStream)
            tokenRsp = JsonConvert.DeserializeObject(textReader.ReadToEnd())


            Me._token = tokenRsp.Item("access_token")
            Dim expiresIn = DateTime.Today
            Now.AddSeconds(CDbl(tokenRsp.Item("expires_in")))

            Me._tokenExpires = expiresIn
            Me._connected = True
        Catch e As Exception
            ' Exception on Token generation procedure
            Me._connected = False
        End Try
    End Sub
End Class
