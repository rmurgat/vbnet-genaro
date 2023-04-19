Option Explicit On

''' <summary>
''' Clase que tiene las propieades y metodos para los parámetros de navegación
''' </summary>
''' <remarks></remarks>
Public Class NavegacionParam
    Private scdproyecto As String = ""    'clave del proyecto
    Private scdesde As String = ""        'clave de la pantalla desde donde se llama
    Private scdhasta As String = ""       'clave de la pantalla hasta 
    Private scdparam As String = ""       'clave del parámetro
    Private snbparam As String = ""       'Nombre del parámetro
    Private bstconstante As Boolean   'Estatus que determina si el valor es constante
    Private stxconstante As String = ""   'Valor constante del parámetro

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
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
    ''' PROPIEDAD: clave del parámetro
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdparam() As String
        Get
            Return scdparam
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdparam = pscd.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Nombre del parámetro
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nbparam() As String
        Get
            Return snbparam
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then Exit Property
            snbparam = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Estatus que determina si el valor es constante
    ''' </summary>
    ''' <value></value>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Property stconstante() As Boolean
        Get
            Return bstconstante
        End Get
        Set(ByVal psst As Boolean)
            bstconstante = psst
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Valor constante del parámetro
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property txconstante() As String
        Get
            Return stxconstante
        End Get
        Set(ByVal pstx As String)
            If pstx Is Nothing Then Exit Property
            stxconstante = pstx.Trim
        End Set
    End Property

End Class 'fin clase [NavegacionParam]