Option Explicit On

Public Class MetodoParametro
    Private sparametro As String = ""      'parametro del método
    Private svalor As String = ""          'Valor del parámetro en XML
    Private stipo As String = ""           'tipo de parámetro
    Private sclase As String = ""          'Nombre de la clase

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' PROPIEDAD: parametro del método
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property parametro() As String
        Get
            Return sparametro
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            sparametro = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: tipo de parámetro
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
            stipo = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Valor del parámetro en XML
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
    ''' PROPIEDAD: Nombre de la clase
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property clase() As String
        Get
            Return sclase
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            sclase = psval.Trim
        End Set
    End Property

End Class  'fin clase [MetodoParametro]
