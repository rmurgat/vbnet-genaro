Imports Microsoft.VisualBasic

''' <summary>
'''     Clave de la pantalla
''' </summary>
''' <empresa>
'''     01 - ATL Solutions S.A. de C.V. 
''' </empresa>
''' </autor>
'''     Rubén Murga Tapia ()
''' </autor>
''' <remarks></remarks>

Public Class SincroniaCampo
    Private scdsincronia As String = ""     'Clave de sincronia
    Private scdproyecto As String = ""      'Clave del proyecto
    Private scdpantalla As String = ""      'Clave de la pantalla
    Private scdcampo As String = ""         'Clave del campo
    Private sestatus As String = "AC"         'Estatus de sincronización del campo
    Private snbidhtml As String = ""        'Id del HTML
    Private sxmlcampo As String = ""        'Configuración XML del campo

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
    ''' PROPIEDAD: Clave del campo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdcampo() As String
        Get
            Return scdcampo
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdcampo = pscd.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Estatus de sincronización del campo
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
    ''' PROPIEDAD: Id del HTML
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbidhtml() As String
        Get
            Return snbidhtml
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then Exit Property
            snbidhtml = psnb.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Configuración XML del campo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property xmlcampo() As String
        Get
            Return sxmlcampo
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            sxmlcampo = psval
        End Set
    End Property


End Class   ' fin clase [scdpantalla]

