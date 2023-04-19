Option Explicit On
''' <summary>
''' Clase que tiene las propiedades y metodos de los reportes
''' </summary>
''' <company>ATL Solutions</company>
''' <project>VBNET_Proyecto</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>18-Mayo-2008  12:00 am</created>
''' <remarks></remarks>
Public Class Reporte
    Private scdproyecto As String = "" ' Clave del proyecto
    Private scdreporte As String = "" ' Clave del reporte
    Private stxobjetivo As String = ""  'Objetivo del reporte
    Private stxcomment As String = "" ' Comentarios del proyecto
    Private snbreporte As String = "" ' Nombre del reporte
    Private scdanalista As String = "" ' Clave del analista
    Private snbanalista As String = "" ' Nombre del analista
    Private scdprogramador As String = "" ' Clave del programador
    Private snbprogramador As String = "" ' Nombre del programador
    Private scdcodigo As String = "" ' Codigo asignado al reporte
    Private scdstanalisis As String = "" ' Estatus del analisis
    Private snbstanalisis As String = "" ' Estatus del analisis
    Private scdstconstruccion As String = "" ' Estatus de la construcción
    Private snbstconstruccion As String = "" ' Estatus de la construcción
    Private snbimagefile As String = "" ' Nombre del archivo con la imagen del reporte

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' PROPIEDAD:  Clave del proyecto
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdproyecto() As String
        Get
            Return scdproyecto
        End Get
        Set(ByVal pscd As String)
            scdproyecto = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Clave del reporte
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdreporte() As String
        Get
            Return scdreporte
        End Get
        Set(ByVal pscd As String)
            scdreporte = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Nombre del reporte
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbreporte() As String
        Get
            Return snbreporte
        End Get
        Set(ByVal psnb As String)
            snbreporte = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Comentarios del proyecto
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
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
    ''' PROPIEDAD:  objetivo del proyecto
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property txobjetivo() As String
        Get
            Return stxobjetivo
        End Get
        Set(ByVal pstx As String)
            stxobjetivo = pstx.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD:  Clave del analista
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdanalista() As String
        Get
            Return scdanalista
        End Get
        Set(ByVal pscd As String)
            scdanalista = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Nombre del analista
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbanalista() As String
        Get
            Return snbanalista
        End Get
        Set(ByVal psnb As String)
            snbanalista = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Clave del programador
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdprogramador() As String
        Get
            Return scdprogramador
        End Get
        Set(ByVal pscd As String)
            scdprogramador = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Nombre del programador
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbprogramador() As String
        Get
            Return snbprogramador
        End Get
        Set(ByVal psnb As String)
            snbprogramador = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Codigo asignado al reporte
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdcodigo() As String
        Get
            Return scdcodigo
        End Get
        Set(ByVal pscd As String)
            scdcodigo = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Estatus del analisis
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdstanalisis() As String
        Get
            Return scdstanalisis
        End Get
        Set(ByVal pscd As String)
            scdstanalisis = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Estatus del analisis
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbstanalisis() As String
        Get
            Return snbstanalisis
        End Get
        Set(ByVal psnb As String)
            snbstanalisis = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Estatus de la construcción
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdstconstruccion() As String
        Get
            Return scdstconstruccion
        End Get
        Set(ByVal pscd As String)
            scdstconstruccion = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Estatus de la construcción
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbstconstruccion() As String
        Get
            Return snbstconstruccion
        End Get
        Set(ByVal psnb As String)
            snbstconstruccion = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Nombre del archivo con la imagen del reporte
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbimagefile() As String
        Get
            Return snbimagefile
        End Get
        Set(ByVal psnb As String)
            snbimagefile = psnb
        End Set
    End Property

End Class  'fin clase [Reporte]
