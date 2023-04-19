Option Explicit On

''' <summary>
''' Clase que tiene las propiedades y metodos de los roles del proyecto
''' </summary>
''' <company>ATL Solutions</company>
''' <project>VBNET_Proyecto</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>18-Mayo-2008  12:00 am</created>
''' <remarks></remarks>
Public Class Rol
    Private sclave As String        ' Clave del rol
    Private snombre As String       ' Nombre del rol

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

End Class
