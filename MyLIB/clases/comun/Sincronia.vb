Imports Microsoft.VisualBasic

''' <summary>
'''     Clave del proyecto
''' </summary>
''' <empresa>
'''     01 - HANYGEN Software S.A. de C.V.
''' </empresa>
''' </autor>
'''     Rubén Murga Tapia ()
''' </autor>
''' <remarks></remarks>

Public Class Sincronia
    Private scdproyecto As String = ""      'Clave del proyecto
    Private scdsincronia As String = ""     'Clave de la sincronización
    Private sestatus As String = "AC"       'Estatus de la sincronia
    Private snbsincronia As String = ""     'Nombre del estilo
    Private sxmsincronia As String = ""     'Configuración xml de sincronia
    Private scdestilogenera As String = ""   ' Clave del estilo de generación


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
            If pscd Is Nothing Then Exit Property
            scdproyecto = pscd.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Clave de la sincronización
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
    ''' PROPIEDAD: Estatus de la sincronia
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
    ''' PROPIEDAD: Nombre de la sincronia
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbsincronia() As String
        Get
            Return snbsincronia
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then Exit Property
            snbsincronia = psnb.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Configuración xml de sincronia
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property xmsincronia() As String
        Get
            Return sxmsincronia
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            sxmsincronia = psval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del estilo de generación
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdestilogenera() As String
        Get
            Return scdestilogenera
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdestilogenera = pscd.Trim
        End Set
    End Property

End Class   ' fin clase [scdproyecto]

