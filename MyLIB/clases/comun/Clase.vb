Option Explicit On 

''' <summary>
''' Clase que tiene las descripciones de cada declaración 
''' </summary>
''' <remarks></remarks>
Public Class Clase
    Private sfile As String = ""        'nombre del archivo que la contiene
    Private sname As String = ""        'nombre de la clase
    Private slanguaje As String = ""    'lenguaje de programación
    Private scomment As String = ""     'comentario de la clase
    Private cvariables As Collection    'colección de variables
    Private cmethods As Collection      'coleccion de methodos
    Private sdeclaracion As String = "" 'instruccion de declaración de la clase
    Private sprogramador As String      'nombre del programador
    Private sempresa As String          'nombre de la empresa
    Private sfhcreacion As String       'fecha de creación del código
    Private spaquete As String          'nombre del paquete
    Private sproyecto As String         'nombre del proyecto de vb.net
    Private oentidato As EntidaDato     'objeto tipo entidad de datos

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        cvariables = New Collection
        cmethods = New Collection
        oentidato = New EntidaDato
    End Sub

    ''' <summary>
    ''' PROPIEDAD: nombre del archivo que la contiene
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>nombre del archivo</returns>
    ''' <remarks></remarks>
    Public Property file() As String
        Get
            Return sfile
        End Get
        Set(ByVal psval As String)
            sfile = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: nombre de la clase
    ''' </summary>
    ''' <value></value>
    ''' <returns>nombre de la clase</returns>
    ''' <remarks></remarks>
    Public Property name() As String
        Get
            Return sname
        End Get
        Set(ByVal psval As String)
            sname = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: lenguaje de programación
    ''' </summary>
    ''' <value></value>
    ''' <returns>lenguaje</returns>
    ''' <remarks></remarks>
    Public Property languaje() As String
        Get
            Return slanguaje
        End Get
        Set(ByVal psval As String)
            slanguaje = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: comentario de la clase
    ''' </summary>
    ''' <value></value>
    ''' <returns>comentario</returns>
    ''' <remarks></remarks>
    Public Property comment() As String

        Get
            Return scomment
        End Get
        Set(ByVal psval As String)
            scomment = psval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: nombre del programador
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property programador() As String
        Get
            Return sprogramador
        End Get
        Set(ByVal psval As String)
            sprogramador = psval.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: nombre de la empresa
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property empresa() As String
        Get
            Return sempresa
        End Get
        Set(ByVal psval As String)
            sempresa = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: fecha de creación del código
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property fhcreacion() As String
        Get
            Return sfhcreacion
        End Get
        Set(ByVal psfh As String)
            sfhcreacion = psfh.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: nombre del paquete
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property paquete() As String
        Get
            Return spaquete
        End Get
        Set(ByVal psval As String)
            spaquete = psval.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: nombre del proyecto de vb.net
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property proyecto() As String
        Get
            Return sproyecto
        End Get
        Set(ByVal psval As String)
            sproyecto = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: colección de variables
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property variables() As Collection
        Get
            Return cvariables
        End Get
        Set(ByVal pcval As Collection)
            cvariables = pcval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: coleccion de methodos
    ''' </summary>
    ''' <value></value>
    ''' <returns>metodos</returns>
    ''' <remarks></remarks>
    Public Property methods() As Collection
        Get
            Return cmethods
        End Get
        Set(ByVal pcval As Collection)
            cmethods = pcval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: objeto tipo entidad de datos
    ''' </summary>
    ''' <value></value>
    ''' <returns>EntidaDato</returns>
    ''' <remarks></remarks>
    Public Property entidato() As EntidaDato
        Get
            Return oentidato
        End Get
        Set(ByVal poval As EntidaDato)
            oentidato = poval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: instruccion de declaración de la clase
    ''' </summary>
    ''' <value></value>
    ''' <returns>linea de declaración</returns>
    ''' <remarks></remarks>
    Public Property declaracion() As String
        Get
            Return sdeclaracion
        End Get
        Set(ByVal psval As String)
            sdeclaracion = psval
        End Set
    End Property

    ''' <summary>
    ''' Funcion que determina si la clase fué comentarizada apropiadamente
    ''' </summary>
    ''' <returns>true/false</returns>
    ''' <remarks></remarks>
    Public Function hascomment() As Boolean
        If Me.comment.Trim.Equals("") Then Return False
        Return True
    End Function

    ''' <summary>
    ''' Procedimiento que regresa una interpretación en xml de la variable
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetXML() As String
        Dim sxml As String = ""
        sxml = "<clase>"
        sxml = sxml & "<nbclase>" & Me.sname & "</nbclase>"
        sxml = sxml & "<archclase>" & Me.sfile & "</archclase>"
        sxml = sxml & "<commclase>" & Me.comment & "</commclase>"
        sxml = sxml & "<nbentidadato>" & oentidato.nbentidadato & "</nbentidadato>"
        sxml = sxml & "<llavecompuesta>" & IIf(oentidato.gethasLlaveCompuesta(), "Si", "No") & "</llavecompuesta>"
        sxml = sxml & "<clavariables>"
        For Each ovar As Variable In Me.variables
            sxml = sxml & ovar.GetXML()
        Next
        sxml = sxml & "</clavariables>"
        sxml = sxml & "<clametodos>"
        For Each omet As Metodo In Me.methods
            sxml = sxml & omet.GetXML()
        Next
        sxml = sxml & "</clametodos>"
        sxml = sxml & "</clase>"
        Return sxml
    End Function

End Class ' fin clase [Clase]
