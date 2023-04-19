Option Explicit On 

Public Class Tabladb
    Private snombre As String       'nombre de la tabla
    Private bselectone As Boolean   'bandera para seleccionar uno solo
    Private bselectsome As Boolean  'bandera para seleccionar varios
    Private bselectall As Boolean   'bandera para seleccionar todos
    Private bdelete As Boolean      'bandera para eliminar 
    Private bupdate As Boolean      'bandera para actualizar
    Private binsert As Boolean      'bandera para poder insertar
    Private sclase As String        'nombre de la clase
    Private occols As Collection

    'CONSTRUCTOR
    Public Sub New()
        occols = New Collection()
    End Sub

    'PROPIEDAD: nombre de la tabla
    Public Property nombre() As String
        Get
            Return snombre
        End Get
        Set(ByVal snb As String)
            snombre = snb
        End Set
    End Property

    'PROPIEDAD: posibilidad de seleccionar uno
    Public Property selectone() As Boolean
        Get
            Return bselectone
        End Get
        Set(ByVal bban As Boolean)
            bselectone = bban
        End Set
    End Property

    'PROPIEDAD: posibilidad de seleccionar algunos
    Public Property selectsome() As Boolean
        Get
            Return bselectsome
        End Get
        Set(ByVal bban As Boolean)
            bselectsome = bban
        End Set
    End Property

    'PROPIEDAD: posibilidad de seleccionar todos
    Public Property selectall() As Boolean
        Get
            Return bselectall
        End Get
        Set(ByVal bban As Boolean)
            bselectall = bban
        End Set
    End Property

    'PROPIEDAD: posibilidad de eliminar registros
    Public Property delete() As Boolean
        Get
            Return bdelete
        End Get
        Set(ByVal bban As Boolean)
            bdelete = bban
        End Set
    End Property

    'PROPIEDAD: posibilidad de actualizar registros
    Public Property update() As Boolean
        Get
            Return bupdate
        End Get
        Set(ByVal bban As Boolean)
            bupdate = bban
        End Set
    End Property

    'PROPIEDAD: posibilidad de insertar registros
    Public Property insert() As Boolean
        Get
            Return binsert
        End Get
        Set(ByVal bban As Boolean)
            binsert = bban
        End Set
    End Property

    'PROPIEDAD: nombre de la clase
    Public Property clase() As String
        Get
            Return sclase
        End Get
        Set(ByVal snb As String)
            sclase = snb
        End Set
    End Property

    'PROPIEDAD: coleccion de variables utilizadas
    Public Property ovariables() As Collection
        Get
            Return occols
        End Get
        Set(ByVal oc As Collection)
            occols = oc
        End Set
    End Property

End Class
