Option Explicit On
''' <summary>
''' Clase que tiene las propiedades y metodos de los campos de las pantallas de captura
''' </summary>
''' <company>ATL Solutions</company>
''' <project>VBNET_Proyecto</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>18-Mayo-2008  12:00 am</created>
''' <remarks></remarks>
Public Class PantallaCampo
    Private scdpantalla As String = ""  ' Clave de la pantalla
    Private stxcomment As String = ""   ' Comentario
    Private scdcampo As String = ""     ' Clave del campo
    Private scdproyecto As String = ""  ' Clave del proyecto
    Private scdtpcampo As String = ""   ' Tipo de campo
    Private stpinoutput As String = ""  ' Tipo input / output
    Private inudecimales As Integer = 0 ' Numero de decimales
    Private inulongitud As Integer = 0  ' Longitud del campo
    Private scdarreglo As String = ""   ' Clave del arreglo
    Private snbcampo As String = ""      ' Nombre del campo
    Private osincronia As SincroniaCampo = Nothing   'Objeto con información de sincronización

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' PROPIEDAD: Clave del proyecto
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdproyecto() As String
        Get
            Return scdproyecto
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdproyecto = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave de la pantalla
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdpantalla() As String
        Get
            Return scdpantalla
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdpantalla = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del campo
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdcampo() As String
        Get
            Return scdcampo
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdcampo = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del arreglo
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdarreglo() As String
        Get
            Return scdarreglo
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdarreglo = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre del campo
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbcampo() As String
        Get
            Return snbcampo
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then Exit Property
            snbcampo = psnb
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Comentario
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
            stxcomment = pstx
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Tipo de campo
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdtpcampo() As String
        Get
            Return scdtpcampo
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdtpcampo = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Tipo input / output
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property tpinoutput() As String
        Get
            Return stpinoutput
        End Get
        Set(ByVal pstp As String)
            If pstp Is Nothing Then Exit Property
            stpinoutput = pstp
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Numero de decimales
    ''' </summary>
    ''' <value>Integer</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nudecimales() As Integer
        Get
            Return inudecimales
        End Get
        Set(ByVal pival As Integer)
            inudecimales = pival
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Longitud del campo
    ''' </summary>
    ''' <value>Integer</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nulongitud() As Integer
        Get
            Return inulongitud
        End Get
        Set(ByVal pival As Integer)
            inulongitud = pival
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Objeto con información de sincronización
    ''' </summary>
    ''' <value></value>
    ''' <returns>SincroniaCampo</returns>
    ''' <remarks></remarks>
    Public Property sincronia() As SincroniaCampo
        Get
            Return osincronia
        End Get
        Set(ByVal poval As SincroniaCampo)
            osincronia = poval
        End Set
    End Property

    ''' <summary>
    ''' Procedimiento para regresar el xml relacionado a este campo
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetXML() As String
        Dim sxml As String

        sxml = "<campo>"
        sxml = sxml & "<cdproyecto>" & Me.scdproyecto & "</cdproyecto>"
        sxml = sxml & "<cdpantalla>" & Me.cdpantalla & "</cdpantalla>"
        sxml = sxml & "<txcomment>" & Me.txcomment & "</txcomment>"
        sxml = sxml & "<cdcampo>" & Me.cdcampo & "</cdcampo>"
        sxml = sxml & "<tpcampo>" & Me.cdtpcampo & "</tpcampo>"
        sxml = sxml & "<tpinoutput>" & Me.tpinoutput & "</tpinoutput>"
        sxml = sxml & "<nudecimales>" & Me.inudecimales & "</nudecimales>"
        sxml = sxml & "<nulongitud>" & Me.nulongitud & "</nulongitud>"
        sxml = sxml & "<cdarreglo>" & Me.cdarreglo & "</cdarreglo>"
        sxml = sxml & "<nbcampo>" & Me.nbcampo & "</nbcampo>"
        If Not osincronia Is Nothing Then
            sxml = sxml & "<nbidhtml>" & osincronia.nbidhtml & "</nbidhtml>"
            sxml = sxml & osincronia.xmlcampo
        End If
        sxml = sxml & "</campo>"

        Return sxml
    End Function

End Class  'fin clase [PantallaCampo]