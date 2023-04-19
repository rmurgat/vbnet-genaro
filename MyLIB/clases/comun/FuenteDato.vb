Option Explicit On
''' <summary>
''' 
''' </summary>
''' <company>ATL Solutions</company>
''' <project>VBNET_Proyecto</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>18-Mayo-2008  12:00 am</created>
''' <remarks></remarks>
Public Class FuenteDato
    Private scdfuentedato As String = "" ' Clave de la fuente de datos
    Private sstfuentedato As String = "" ' Estatus de la fuente de datos
    Private stpfuentedato As String = "" ' Tipo de fuente de datos
    Private scdcliente As String = "" ' Clave del cliente
    Private snbfuentedato As String = "" ' Nombre de la fuente de datos
    Private scdconexion As String = "" ' String de conexión a la fuente de datos
    Private stxcomment As String = "" ' Comentarios de la fuente de datos

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' PROPIEDAD: Clave de la fuente de datos
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdfuentedato() As String
        Get
            Return scdfuentedato
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdfuentedato = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Estatus de la fuente de datos
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property stfuentedato() As String
        Get
            Return sstfuentedato
        End Get
        Set(ByVal psst As String)
            If psst Is Nothing Then Exit Property
            sstfuentedato = psst
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Tipo de la fuente de datos
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property tpfuentedato() As String
        Get
            Return stpfuentedato
        End Get
        Set(ByVal psst As String)
            If psst Is Nothing Then Exit Property
            stpfuentedato = psst
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del cliente
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdcliente() As String
        Get
            Return scdcliente
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdcliente = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre de la fuente de datos
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbfuentedato() As String
        Get
            Return snbfuentedato
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then Exit Property
            snbfuentedato = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: String de conexión a la fuente de datos
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdconexion() As String
        Get
            Return scdconexion
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdconexion = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Comentarios de la fuente de datos
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property txcomment() As String
        Get
            Return stxcomment
        End Get
        Set(ByVal pstx As String)
            If pstx Is Nothing Then Exit Property
            stxcomment = pstx.Trim
        End Set
    End Property

End Class  'fin clase [FuenteDato]