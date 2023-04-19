Option Explicit On
''' <summary>
''' Clase que contiene las propiedades y metodos de los clientes
''' </summary>
''' <company>ATL Solutions</company>
''' <project>VBNET_Proyecto</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>18-Mayo-2008  12:00 am</created>
''' <remarks></remarks>
Public Class Cliente
    Private scdrfc As String ' RFC del cliente
    Private snutelefono As String ' Número de teléfono del cliente
    Private snbdireccion As String ' Dirección del cliente
    Private snbcliente As String ' Nombre del cliente
    Private scdcliente As String ' Clave del cliente

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' PROPIEDAD: RFC del cliente
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdrfc() As String
        Get
            Return scdrfc
        End Get
        Set(ByVal pscd As String)
            scdrfc = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Número de teléfono del cliente
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nutelefono() As String
        Get
            Return snutelefono
        End Get
        Set(ByVal psnu As String)
            snutelefono = psnu
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Dirección del cliente
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbdireccion() As String
        Get
            Return snbdireccion
        End Get
        Set(ByVal psnb As String)
            snbdireccion = psnb
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre del cliente
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbcliente() As String
        Get
            Return snbcliente
        End Get
        Set(ByVal psnb As String)
            snbcliente = psnb
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del cliente
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

End Class  'fin clase [Cliente]
