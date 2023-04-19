Option Explicit On

Public Class Estatus
    Private sclave As String        'clave del estatus
    Private snombre As String       'nombre del estatus

    ''' <summary>
    ''' PROPIEDAD: clave del estatus
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
    ''' PROPIEDAD: nombre del estatus
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property nombre() As String
        Get
            Return snombre
        End Get
        Set(ByVal psval As String)
            snombre = psval
        End Set
    End Property

End Class
