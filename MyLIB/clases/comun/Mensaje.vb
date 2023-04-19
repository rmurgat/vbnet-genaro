Public Class Mensaje
    Private sdescription As String = ""    'Descripción del mensaje
    Private sclave As String = ""      'Clave del error
    Private sorigen As String = ""     'Origen del mensaje
    Private biserror As Boolean = False     'determina si el mensaje es un error

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    'PROPIEDAD: Descripción del mensaje
    Public Property description() As String
        Get
            Return sdescription
        End Get
        Set(ByVal psval As String)
            sdescription = psval.Trim
        End Set
    End Property

    'PROPIEDAD: Número del mensaje
    Public Property clave() As String
        Get
            Return sclave
        End Get
        Set(ByVal psval As String)
            sclave = psval.Trim
        End Set
    End Property

    'PROPIEDAD: Origen del mensaje
    Public Property origen() As String
        Get
            Return sorigen
        End Get
        Set(ByVal psval As String)
            sorigen = psval.Trim
        End Set
    End Property

    'PROPIEDAD: determina si el mensaje es un error
    Public Property iserror() As Boolean
        Get
            Return biserror
        End Get
        Set(ByVal pbval As Boolean)
            biserror = pbval
        End Set
    End Property
End Class
