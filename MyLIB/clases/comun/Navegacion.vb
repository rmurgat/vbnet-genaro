Option Explicit On

''' <summary>
''' Clase que tiene los detalles de una navegación entre distintas pantallas
''' </summary>
''' <remarks></remarks>
Public Class Navegacion
    Private scdproyecto As String = ""    'clave del proyecto
    Private scdesde As String = ""        'clave de la pantalla desde donde se llama
    Private scdhasta As String = ""       'clave de la pantalla hasta 
    Private stpnavegacion As String = ""  'Tipo de navegación
    Private bstopenwindow As Boolean      'Estatus para abrir la ventana
    Private cparametros As Collection     'Colección de parámetros

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        cparametros = New Collection
    End Sub

    ''' <summary>
    ''' PROPIEDAD: clave del proyecto
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
    ''' PROPIEDAD: clave de la pantalla desde donde se llama
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdesde() As String
        Get
            Return scdesde
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdesde = pscd.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: clave de la pantalla hasta
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdhasta() As String
        Get
            Return scdhasta
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdhasta = pscd.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Tipo de navegación
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property tpnavegacion() As String
        Get
            Return stpnavegacion
        End Get
        Set(ByVal pstp As String)
            If pstp Is Nothing Then Exit Property
            stpnavegacion = pstp.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Estatus para abrir la ventana
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property stopenwindow() As Boolean
        Get
            Return bstopenwindow
        End Get
        Set(ByVal bst As Boolean)
            bstopenwindow = bst
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Colección de parámetros
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property parametros() As Collection
        Get
            Return cparametros
        End Get
        Set(ByVal pcval As Collection)
            If pcval Is Nothing Then Exit Property
            cparametros = pcval
        End Set
    End Property


End Class   'fin clase [Navegacion]
