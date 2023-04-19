Option Explicit On
''' <summary>
''' Clase que tiene las propiedades y metodos de las Entidades de base de datos
''' </summary>
''' <company>ATL Solutions</company>
''' <project>VBNET_Proyecto</project>
''' <autor>Rubén Murga Tapia</autor>
''' <created>18-Mayo-2008  12:00 am</created>
''' <remarks></remarks>
Public Class EntidaDato
    Private scdfuentedato As String = ""   ' Clave de la fuente de datos que se trata
    Private snbentidadato As String = ""   ' Nombre que identifica de manera unica a la entidad de base de datos
    Private stpentidadato As String = ""   ' Tipo de entidad : Tabla/Vista/Procedimiento
    Private snbclase As String = ""        ' Nombre de la clase
    Private stxddl As String = ""          ' Código DDL para una entidad de datos
    Private stxcomment As String = ""      ' Comentarios de la entidad de datos
    Private stxclasecomment As String = "" ' Comentarios definidos para la clase
    Private occampos As Collection         ' Colección de campos
    Private ocllaves As Collection         ' Colección de campos llave
    Private ocreferences As Collection     ' Colección de referencias

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        occampos = New Collection
        ocreferences = New Collection
        ocllaves = New Collection
    End Sub

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <param name="sfuentedato">clave de la fuente de datos</param>
    ''' <param name="snbentidadato">nombre de la entidad de datos</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal sfuentedato As String, ByVal snbentidadato As String)
        occampos = New Collection
        Me.cdfuentedato = sfuentedato
        Me.nbentidadato = snbentidadato
    End Sub

    ''' <summary>
    ''' PROPIEDAD: Clave de la fuente de datos que se trata
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdfuentedato() As String
        Get
            Return scdfuentedato
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            scdfuentedato = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre que identifica de manera unica a la entidad de base de datos
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbentidadato() As String
        Get
            Return snbentidadato
        End Get
        Set(ByVal pscd As String)
            If pscd Is Nothing Then Exit Property
            snbentidadato = pscd.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Tipo de entidad : Tabla/Vista/Procedimiento
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property tpentidadato() As String
        Get
            Return stpentidadato
        End Get
        Set(ByVal pstp As String)
            If pstp Is Nothing Then Exit Property
            stpentidadato = pstp
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre de la clase
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbclase() As String
        Get
            Return snbclase
        End Get
        Set(ByVal psnb As String)
            If psnb Is Nothing Then Exit Property
            snbclase = psnb.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Comentarios de la entidad de datos
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property txcomment() As String
        Get
            Return stxcomment
        End Get
        Set(ByVal pstx As String)
            If pstx Is Nothing Then Exit Property
            stxcomment = pstx.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Comentarios definidos para la clase
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property txclasecomment() As String
        Get
            Return stxclasecomment
        End Get
        Set(ByVal pstx As String)
            stxclasecomment = pstx.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Código DDL para una entidad de datos
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property txddl() As String
        Get
            Return stxddl
        End Get
        Set(ByVal psval As String)
            stxddl = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD:  Colección de campos
    ''' </summary>
    ''' <value>Collection</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property ccampos() As Collection
        Get
            Return occampos
        End Get
        Set(ByVal pcval As Collection)
            occampos = pcval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Colección de campos llave
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property cllaves() As Collection
        Get
            Return ocllaves
        End Get
        Set(ByVal poval As Collection)
            ocllaves = poval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Colección de referencias
    ''' </summary>
    ''' <value></value>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Property creferences() As Collection
        Get
            Return ocreferences
        End Get
        Set(ByVal poval As Collection)
            ocreferences = poval
        End Set
    End Property

    ''' <summary>
    ''' Procedimiento para agregar un nuevo campo a la entidad de datos
    ''' </summary>
    ''' <param name="ocampo">objeto que tiene propiedades y metodos de campo</param>
    ''' <remarks></remarks>
    Public Sub AddCampo(ByRef ocampo As EntidaDatoCampo)
        occampos.Add(ocampo)
    End Sub

    ''' <summary>
    ''' Procedimiento para asignar el campo como una llave
    ''' </summary>
    ''' <param name="snbcampo">nombre del campo</param>
    ''' <remarks></remarks>
    Public Sub AsignaComoLlave(ByVal snbcampo As String)
        For Each ocampo As EntidaDatoCampo In occampos
            If ocampo.nbcampo.Equals(snbcampo) Then ocampo.stesllave = Comun.ST_ACTIVO
        Next

    End Sub

    ''' <summary>
    ''' Procedimiento para actualizar solo el comentario
    ''' </summary>
    ''' <param name="snbcampo">nombre del campo</param>
    ''' <param name="scomment">nuevo comentario</param>
    ''' <remarks></remarks>
    Public Sub AsignaComentario(ByVal snbcampo As String, ByVal scomment As String)
        For Each ocampo As EntidaDatoCampo In occampos
            If ocampo.nbcampo.Equals(snbcampo) Then ocampo.txcomment = scomment
        Next
    End Sub

    ''' <summary>
    ''' Procedimiento que regresa una interpretación en xml de la variable
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetXML() As String
        Dim sxml As String = ""
        sxml = "<entidad>"
        sxml = sxml & "<ftedatos>" & Me.scdfuentedato & "</ftedatos>"
        sxml = sxml & "<nombre>" & Me.snbentidadato & "</nombre>"
        sxml = sxml & "<tipo>" & Me.stpentidadato & "</tipo>"
        sxml = sxml & "<comment>" & Me.stxcomment & "</comment>"
        sxml = sxml & "<clasecomment>" & Me.stxcomment & "</clasecomment>"
        sxml = sxml & "<clase>" & Me.snbclase & "</clase>"
        sxml = sxml & "<llavecompuesta>" & IIf(Me.gethasLlaveCompuesta(), "Si", "No") & "</llavecompuesta>"
        sxml = sxml & "<campos>"
        For Each ocam As EntidaDatoCampo In Me.ccampos
            sxml = sxml & ocam.getxml
        Next
        sxml = sxml & "</campos>"
        sxml = sxml & "</entidad>"
        Return sxml
    End Function

    ''' <summary>
    ''' Procedimiento para marcar las llaves
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Marcarllaves()
        For Each sllave As String In Me.ocllaves
            For Each ocampo As EntidaDatoCampo In Me.ccampos
                If ocampo.nbcampo.Equals(sllave) Then ocampo.stesllave = Comun.ST_ACTIVO
            Next
        Next
    End Sub

    ''' <summary>
    ''' Función para determinar si la entidad de datos tiene una llave compuesta
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function gethasLlaveCompuesta() As Boolean
        Dim icounter As Integer = 0
        For Each ocampo As EntidaDatoCampo In occampos
            If ocampo.isllave Then icounter = icounter + 1
        Next
        If icounter > 1 Then Return True
        Return False
    End Function

End Class  'fin clase [EntidaDato]