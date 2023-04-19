Imports Microsoft.VisualBasic

''' <summary>
'''     Clave del proyecto
''' </summary>
''' <empresa>
'''     01 - ATL Solutions S.A. de C.V. 
''' </empresa>
''' </autor>
'''     Rubén Murga Tapia ()
''' </autor>
''' <remarks></remarks>

Public Class SincroniaEvento
    Private scdsincronia As String = ""  'Clave de sincronia
    Private scdproyecto As String = ""   'Clave del proyecto
    Private scdpantalla As String = ""   'Clave de la pantalla
    Private scdevento As String = ""     'Clave del evento
    Private sestatus As String = "AC"      'Estatus de Sincronia para el evento
    Private sxmlevento As String = ""    'Configuración XML del evento

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
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
    ''' PROPIEDAD: Clave del evento
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdevento() As String
        Get
            Return scdevento
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdevento = pscd.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Estatus de Sincronia para el evento
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
    ''' PROPIEDAD: Configuración XML del evento
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property xmlevento() As String
        Get
            Return sxmlevento
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            sxmlevento = psval
        End Set
    End Property

End Class   ' fin clase [SincroniaEvento]

