Public Class Metodo
    Private sfile As String = ""           ' Nombre del archivo que lo contiene
    Private sclase As String = ""          ' Nombre de la clase
    Private bpublic As Boolean = False     ' Alcance del metodo
    Private stipo As String = ""           ' Tipo de metodo
    Private snombre As String = ""         ' Nombre del metodo
    Private slanguaje As String = ""       ' Lenguaje de programación
    Private scomment As String = ""        ' Comentario
    Private sdeclaracion As String = ""    ' Instruccion de declaración del metodo
    Private cparameters As Collection      ' Variables que están en los parámetros
    Private sretorno As String = ""        ' Tipo de retorno del metodo
    Private iusos As Integer = 0           ' Número de veces que se utilizo el metodo
    Private bhasretorno As Boolean = True  ' Determina si el método retorna un valor 

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        cparameters = New Collection
    End Sub

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <param name="snom">nombre del metodo</param>
    ''' <param name="sretorno">tipo de retorno</param>
    ''' <param name="scomment">comentario</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal snom As String, ByVal sretorno As String, ByVal scomment As String)
        Me.nombre = snom
        Me.retorno = sretorno
        Me.comment = scomment
        cparameters = New Collection
    End Sub

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <param name="snom">nombre del metodo</param>
    ''' <param name="sretorno">tipo de retorno</param>
    ''' <param name="scomment">comentario</param>
    ''' <param name="ovar">objeto tipo variable</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal snom As String, ByVal sretorno As String, ByVal scomment As String, ByRef ovar As Variable)
        Me.nombre = snom
        Me.retorno = sretorno
        Me.comment = scomment
        cparameters = New Collection
        cparameters.Add(ovar)
    End Sub

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <param name="snom">nombre del metodo</param>
    ''' <param name="sretorno">tipo de retorno</param>
    ''' <param name="scomment">comentario</param>
    ''' <param name="sparams">colección de variables en parámetros</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal snom As String, ByVal sretorno As String, ByVal scomment As String, ByRef sparams As Collection)
        Me.nombre = snom
        Me.retorno = sretorno
        Me.comment = scomment
        Me.parameters = sparams
    End Sub

    ''' <summary>
    ''' PROPIEDAD: nombre del archivo que lo contiene
    ''' </summary>
    ''' <value></value>
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
    ''' <returns>nombre</returns>
    ''' <remarks></remarks>
    Public Property clase() As String
        Get
            Return sclase
        End Get
        Set(ByVal psval As String)
            sclase = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Alcance del metodo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property ispublico() As Boolean
        Get
            Return bpublic
        End Get
        Set(ByVal pval As Boolean)
            bpublic = pval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Tipo de metodo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property tipo() As String
        Get
            Return stipo
        End Get
        Set(ByVal psval As String)
            stipo = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre del metodo
    ''' </summary>
    ''' <value></value>
    ''' <returns>nombre</returns>
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
    ''' PROPIEDAD: comentario
    ''' </summary>
    ''' <value></value>
    ''' <returns>comentario</returns>
    ''' <remarks></remarks>
    Public Property comment() As String
        Get
            Return scomment
        End Get
        Set(ByVal psval As String)
            scomment = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: instruccion de declaración del metodo
    ''' </summary>
    ''' <value></value>
    ''' <returns>linea de declaración</returns>
    ''' <remarks></remarks>
    Public Property declaracion() As String
        Get
            Return sdeclaracion
        End Get
        Set(ByVal psval As String)
            sdeclaracion = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: variables que están en los parámetros
    ''' </summary>
    ''' <value>Collection</value>
    ''' <returns>valor de la propiedad</returns>
    ''' <remarks></remarks>
    Public Property parameters() As Collection
        Get
            Return cparameters
        End Get
        Set(ByVal pcval As Collection)
            If pcval Is Nothing Then
                cparameters = New Collection
            Else
                cparameters = pcval
            End If
        End Set
    End Property

    'PROPIEDAD: tipo de retorno del metodo
    Public Property retorno() As String
        Get
            Return sretorno
        End Get
        Set(ByVal psval As String)
            sretorno = psval.Trim
        End Set
    End Property


    ''' <summary>
    ''' Funcion que determina si el metodo fué comentarizado apropiadamente
    ''' </summary>
    ''' <returns>true/false</returns>
    ''' <remarks></remarks>
    Public Function hascomment() As Boolean
        If Me.comment.Trim.Equals("") Then Return False
        Return True
    End Function

    ''' <summary>
    ''' PROPIEDAD: Número de veces que se utilizo el metodo
    ''' </summary>
    ''' <value>Integer</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property usos() As Integer
        Get
            Return iusos
        End Get
        Set(ByVal pival As Integer)
            iusos = pival
        End Set
    End Property  'Private bhasretorno As Boolean = True  'Determina si el método retorna un valor

    ''' <summary>
    ''' PROPIEDAD: Determina si el método retorna un valor
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property hasretorno() As Boolean
        Get
            Return bhasretorno
        End Get
        Set(ByVal pbval As Boolean)
            bhasretorno = pbval
        End Set
    End Property

    ''' <summary>
    ''' Procedimiento que regresa una interpretación en xml de la variable
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetXML() As String
        Dim sxml As String = ""
        sxml = "<metodo>"
        sxml = sxml & "<nbclase>" & sclase & "</nbclase>"
        sxml = sxml & "<alcance>" & IIf(Me.ispublico, "PUBLICO", "PRIVADO") & "</alcance>"
        sxml = sxml & "<tipo>" & stipo & "</tipo>"
        sxml = sxml & "<tieneretorno>" & IIf(Me.hasretorno(), "Si", "No") & "</tieneretorno>"
        sxml = sxml & "<nombre>" & snombre & "</nombre>"
        sxml = sxml & "<lenguaje>" & slanguaje & "</lenguaje>"
        sxml = sxml & "<comment>" & scomment & "</comment>"
        sxml = sxml & "<declaracion>" & sdeclaracion & "</declaracion>"
        sxml = sxml & "<retorno>" & sretorno & "</retorno>"
        sxml = sxml & "<esprivado>" & IIf(Me.ispublico, "Si", "No") & "</esprivado>"
        sxml = sxml & "<espublico>" & IIf(Not Me.ispublico, "Si", "No") & "</espublico>"
        sxml = sxml & "<parametros></parametros>"
        sxml = sxml & "</metodo>"
        Return sxml
    End Function

End Class  ' fin clase [Metodo]
