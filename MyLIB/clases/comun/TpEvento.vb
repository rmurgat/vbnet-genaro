
''' <summary>
''' Clase que tiene las propieades y metodos propios del tipo de Evento
''' </summary>
''' <remarks></remarks>
Public Class TpEvento
    Private sclave As String        ' Clave del tipo
    Private snombre As String       ' Nombre del tipo
    Private scdmetacod As String    ' Clave del metacódigo

    ''' <summary>
    ''' PROPIEDAD: clave del rol
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property clave() As String
        Get
            Return sclave
        End Get
        Set(ByVal psval As String)
            sclave = psval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: nombre del rol
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property nombre() As String
        Get
            Return snombre
        End Get
        Set(ByVal psval As String)
            snombre = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: clave del metacodigo
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property cdmetacod() As String
        Get
            Return scdmetacod
        End Get
        Set(ByVal psval As String)
            scdmetacod = psval.Trim
        End Set
    End Property

End Class   'fin clase [TpEvento]
