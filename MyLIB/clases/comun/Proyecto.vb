Option Explicit On

''' <summary>
''' Clase que tiene las propiedades y metodos de los proyectos
''' </summary>
''' <company>ATL Solutions</company>
''' <project>VBNET_Proyecto</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>18-Mayo-2008  12:00 am</created>
''' <remarks></remarks>
Public Class Proyecto
    Private snbproyecto As String = ""   ' Nombre del proyecto
    Private scdproyecto As String = ""   ' Clave del proyecto
    Private scdpmp As String = ""        ' Clave del project managemente
    Private snbpmp As String = ""        ' Nombre del pmp
    Private scdcliente As String = ""    ' Clave del cliente
    Private snbcliente As String = ""    ' Nombre del cliente
    Private scdempresa As String = ""    ' Clave de la empresa
    Private snbempresa As String = ""    ' Nombre de la empresa
    Private dimprecio As Double = 0      ' Precio del proyecto
    Private dimiva As Double = 0         ' Iva del proyecto
    Private scdstproyecto As String = "" ' Clave del estatus del proyecto
    Private snbstproyecto As String = "" ' Nombre del estatus del proyecto
    Private scomment As String = ""      ' Comentarios respecto al proyecto

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
    ''' PROPIEDAD:  Nombre del proyecto
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbproyecto() As String
        Get
            Return snbproyecto
        End Get
        Set(ByVal psnb As String)
            snbproyecto = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Clave del project managemente
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdpmp() As String
        Get
            Return scdpmp
        End Get
        Set(ByVal pscd As String)
            scdpmp = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Nombre del pmp
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbpmp() As String
        Get
            Return snbpmp
        End Get
        Set(ByVal psnb As String)
            snbpmp = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Clave del cliente
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdcliente() As String
        Get
            Return scdcliente
        End Get
        Set(ByVal pscd As String)
            scdcliente = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Nombre del cliente
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbcliente() As String
        Get
            Return snbcliente
        End Get
        Set(ByVal psnb As String)
            snbcliente = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Clave de la empresa
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdempresa() As String
        Get
            Return scdempresa
        End Get
        Set(ByVal pscd As String)
            scdempresa = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Nombre de la empresa
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbempresa() As String
        Get
            Return snbempresa
        End Get
        Set(ByVal psnb As String)
            snbempresa = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Precio del proyecto
    ''' </summary>
    ''' <value>Double</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property imprecio() As Double
        Get
            Return dimprecio
        End Get
        Set(ByVal pdim As Double)
            dimprecio = pdim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Iva del proyecto
    ''' </summary>
    ''' <value>Double</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property imiva() As Double
        Get
            Return dimiva
        End Get
        Set(ByVal pdim As Double)
            dimiva = pdim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Clave del estatus del proyecto
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdstproyecto() As String
        Get
            Return scdstproyecto
        End Get
        Set(ByVal pscd As String)
            scdstproyecto = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Nombre del estatus del proyecto
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbstproyecto() As String
        Get
            Return snbstproyecto
        End Get
        Set(ByVal psnb As String)
            snbstproyecto = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Comentarios respecto al proyecto
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property comment() As String
        Get
            Return scomment
        End Get
        Set(ByVal psval As String)
            scomment = psval.Trim
        End Set
    End Property

End Class  'fin clase [Proyecto]