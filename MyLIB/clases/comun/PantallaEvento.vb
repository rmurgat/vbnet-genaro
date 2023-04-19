Option Explicit On

Public Class PantallaEvento
    Private scdproyecto As String = ""   ' Clave del proyecto
    Private scdpantalla As String = ""   ' Clave de la pantalla
    Private scdevento As String = ""     ' Clave del evento que sucede en la pantalla
    Private snbevento As String = ""     ' Nombre del evento que sucede en pantalla
    Private scdtpevento As String = ""   ' Tipo de Evento
    Private scdmetacodigo As String = "" ' Meta-codigo asociado con el evento
    Private stxcomment As String = ""    ' Comentario
    Private osincronia As SincroniaEvento = Nothing   'Objeto con información de sincronización

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

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
            scdpantalla = pscd.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Clave del evento del objeto
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdevento() As String
        Get
            Return scdevento
        End Get
        Set(ByVal pscd As String)
            scdevento = pscd.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Nombre del evento del objecto
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbevento() As String
        Get
            Return snbevento
        End Get
        Set(ByVal psnb As String)
            snbevento = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Tipo de Evento
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdtpevento() As String
        Get
            Return scdtpevento
        End Get
        Set(ByVal pscd As String)
            scdtpevento = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Meta-codigo asociado con el evento
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdmetacodigo() As String
        Get
            Return scdmetacodigo
        End Get
        Set(ByVal pscd As String)
            scdmetacodigo = pscd.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Comentario
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property txcomment() As String
        Get
            Return stxcomment
        End Get
        Set(ByVal pstx As String)
            stxcomment = pstx.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Objeto con información de sincronización
    ''' </summary>
    ''' <value></value>
    ''' <returns>SincroniaEvento</returns>
    ''' <remarks></remarks>
    Public Property sincronia() As SincroniaEvento
        Get
            Return osincronia
        End Get
        Set(ByVal poval As SincroniaEvento)
            osincronia = poval
        End Set
    End Property

    ''' <summary>
    ''' Procedimiento que regresa la especificación xml de un evento
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetXML() As String
        Dim sxml As String

        sxml = "<evento>"
        sxml = sxml & "<cdproyecto>" & Me.scdproyecto & "</cdproyecto>"
        sxml = sxml & "<cdpantalla>" & Me.scdpantalla & "</cdpantalla>"
        sxml = sxml & "<cdevento>" & Me.scdevento & "</cdevento>"
        sxml = sxml & "<nbevento>" & Me.snbevento & "</nbevento>"
        sxml = sxml & "<tpevento>" & Me.scdtpevento & "</tpevento>"
        sxml = sxml & "<cdmetacodigo>" & Me.scdmetacodigo & "</cdmetacodigo>"
        sxml = sxml & "<txcomment>" & Me.stxcomment & "</txcomment>"
        If Not osincronia Is Nothing Then sxml = sxml & osincronia.xmlevento
        sxml = sxml & "</evento>"

        Return sxml
    End Function

End Class ' fin clase [PantallaEvento] 
