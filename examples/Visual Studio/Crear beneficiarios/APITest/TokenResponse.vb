Public Class TokenResponse
    Private _access_token As String
    Public Property access_token() As String
        Get
            Return Me._access_token
        End Get
        Set(ByVal value As String)
            Me._access_token = value
        End Set
    End Property
    Private _token_type As String
    Public Property token_type() As String
        Get
            Return Me._token_type
        End Get
        Set(ByVal value As String)
            Me._token_type = value
        End Set
    End Property
    Private _refresh_token As String
    Public Property refresh_token() As String
        Get
            Return Me._refresh_token
        End Get
        Set(ByVal value As String)
            Me._refresh_token = value
        End Set
    End Property
    Private _expires_in As Integer
    Public Property expires_in() As Integer
        Get
            Return Me._expires_in
        End Get
        Set(ByVal value As Integer)
            Me._expires_in = value
        End Set
    End Property
    Private _scope As Integer
    Public Property scope() As Integer
        Get
            Return Me._scope
        End Get
        Set(ByVal value As Integer)
            Me._scope = value
        End Set
    End Property
End Class
