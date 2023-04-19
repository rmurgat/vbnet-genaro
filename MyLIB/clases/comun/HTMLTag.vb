Imports System.Text.RegularExpressions
Imports System.IO

Public Class HTMLTag
    Private snombre As String = ""      'Nombre del tag
    Private stipo As String = ""        'Tipo de Tag
    Private sid As String = ""          'Id del Tag
    Private svalor As String = ""       'Valor del Tag
    Private stag As String = ""         'tag
    Private saction As String = ""      'Acción

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' PROPIEDAD: Nombre del tag
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property nombre() As String
        Get
            Return snombre
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            snombre = psval.Trim.ToLower
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Tipo de Tag
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property tipo() As String
        Get
            Return stipo
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            stipo = psval.Trim.ToLower
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Id del Tag
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property id() As String
        Get
            Return sid
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            sid = psval.Trim.ToLower
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Valor del Tag
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property valor() As String
        Get
            Return svalor
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            svalor = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: tag
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property tag() As String
        Get
            Return stag
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            stag = psval.Trim
        End Set
    End Property  'Private saction As String = ""      'Acción

    ''' <summary>
    ''' PROPIEDAD: Acción
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property action() As String
        Get
            Return saction
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            saction = psval.Trim
        End Set
    End Property

End Class  'fin clase [HTMLTag]
