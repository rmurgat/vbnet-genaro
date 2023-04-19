Option Explicit On
''' <summary>
''' Clase que contiene las propiedades y metodos de los criterios de consulta
''' </summary>
''' <company>ATL Solutions</company>
''' <project>VBNET_Proyecto</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>18-Mayo-2008  12:00 am</created>
''' <remarks></remarks>

Public Class Criterio
    Private scdproyecto As String = ""      'Clave del proyecto
    Private scdcliente As String = ""       'Clave del clientes
    Private scdstproyecto As String = ""    'Estatus del Proyecto
    Private scdrolstaff As String = ""      'Clave del rol del staff

    Private scdjunta As String = ""         'Clave de la junta
    Private sestatus As String = ""         'Clave del estatus

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
            scdproyecto = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del clientes
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
    ''' PROPIEDAD: Estatus del Proyecto
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
    ''' PROPIEDAD: Clave del rol del staff
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdrolstaff() As String
        Get
            Return scdrolstaff
        End Get
        Set(ByVal pscd As String)
            scdrolstaff = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave de la junta
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdjunta() As String
        Get
            Return scdjunta
        End Get
        Set(ByVal pscd As String)
            scdjunta = pscd.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Clave del estatus
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property estatus() As String
        Get
            Return sestatus
        End Get
        Set(ByVal psval As String)
            sestatus = psval.Trim
        End Set
    End Property

End Class  'fin clase [Criterio]
