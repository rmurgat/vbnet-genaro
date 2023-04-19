Imports Microsoft.VisualBasic

''' <summary>
'''     Nombre del archivo HTML (Prototipo)
''' </summary>
''' <empresa>
'''     01 - ATL Solutions S.A. de C.V. 
''' </empresa>
''' </autor>
'''     Rubén Murga Tapia ()
''' </autor>
''' <remarks></remarks>

Public Class SincroniaPantalla
    Private scdsincronia As String = ""    'Clave de sincronia
    Private scdproyecto As String = ""     'Clave del proyecto
    Private scdpantalla As String = ""     'Clave de la pantalla
    Private sestatus As String = ""        'Estatus de sincronización de la pantalla
    Private snbextension As String = ""    'Extesión de los archivos
    Private snbhtmlfile As String = ""     'Nombre del archivo html
    Private sxmlpantalla As String = ""    'Configuración XML de la pantalla
    Private snbhtmlforma As String = ""    'Nombre de la forma en HTML
    Private snbcomponente As String = ""     ' Nombre del componente final
    Private scdestilofuncion As String = ""  ' Clave del estilo de funcionamiento

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New(ByVal scdsinc As String, ByVal scdproy As String, ByVal scdpant As String)
        scdsincronia = scdsinc
        scdproyecto = scdproy
        scdpantalla = scdpant
    End Sub

    ''' <summary>
    ''' PROPIEDAD: Clave de sincronia
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdsincronia() As String
        Get
            Return scdsincronia
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdsincronia = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del proyecto
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdproyecto() As String
        Get
            Return scdproyecto
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdproyecto = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave de la pantalla
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdpantalla() As String
        Get
            Return scdpantalla
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdpantalla = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Estatus de sincronización de la pantalla
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property estatus() As String
        Get
            Return sestatus
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            sestatus = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Extesión de los archivos
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbextension() As String
        Get
            Return snbextension
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then Exit Property
            snbextension = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre del archivo html
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbhtmlfile() As String
        Get
            Return snbhtmlfile
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then Exit Property
            snbhtmlfile = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Configuración XML de la pantalla
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property xmlpantalla() As String
        Get
            Return sxmlpantalla
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            sxmlpantalla = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre de la forma en HTML
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbhtmlforma() As String
        Get
            Return snbhtmlforma
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then Exit Property
            snbhtmlforma = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Nombre del componente
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbcomponente() As String
        Get
            Return snbcomponente
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then Exit Property
            snbcomponente = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del estilo de funcionamiento
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdestilofuncion() As String
        Get
            Return scdestilofuncion
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdestilofuncion = pscd.Trim
        End Set
    End Property

End Class   ' fin clase [SincroniaPantalla]

