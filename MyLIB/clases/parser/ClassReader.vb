Imports System.Text.RegularExpressions
Imports System.IO

Public Class ClassReader
    Private sdir As String = ""       'directorio actual del archivo
    Private sfile As String = ""      'nombre del archivo
    Private scontent As String = ""   'contenido del archivo
    Private outil As Utilerias        'utilerias del sistema
    Private oClase As Clase           'objeto tipo clase
    Private cmensajes As Collection   'colección de mensajes

    Private sregclase As String = ""         'expresión regular para el apuntador de la clase
    Private sregcommentclase As String = ""  'expresión regular para el apuntador del comentario
    Private sregcommentmetodo As String = "" 'expresión regular para el apuntador del metodo
    Private sregprocedure As String = ""     'expresión regular para el apuntador del procedimiento
    Private sregcarquitar As String = ""     'Caracteres para quitar
    Private sregmetsinretorno As String = "" 'expresión regular para aquellos metodos que no tienen retorno
    Private sregmetpublico As String = ""    'expresión regular para aquellos metodos que son publicos
    Private oxmlclase As Nodo     'configuracion para una clase
    Private oxmlmetodo As Nodo    'configuración para un metodo
    Private oxmlpseudocodigo As Nodo 'configuración para un pseudocodigo

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.sdir = ""
        Me.sfile = ""
        outil = New Utilerias
        cmensajes = New Collection
    End Sub

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <param name="sdir">Nombre del directorio</param>
    ''' <param name="sfile">Nombre del archivo</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal sdir As String, ByVal sfile As String)
        Me.sdir = sdir
        Me.sfile = sfile
        outil = New Utilerias
        cmensajes = New Collection
    End Sub

    ''' <summary>
    '''  PROPIEDAD: directorio actual del archivo
    ''' </summary>
    ''' <value></value>
    ''' <returns>valor</returns>
    ''' <remarks></remarks>
    Public Property dir() As String
        Get
            Return sdir
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            sdir = psval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: nombre del archivo
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property file() As String
        Get
            Return sfile
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            sfile = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: contenido del archivo
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property content() As String
        Get
            Return scontent
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            scontent = psval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: expresión regular para el apuntador de la clase
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property regclase() As String
        Get
            Return sregclase
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            sregclase = psval.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: expresión regular para el apuntador del comentario para la clase
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property regcommentclase() As String
        Get
            Return sregcommentclase
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            sregcommentclase = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: expresión regular para el apuntador del comentario para el metodo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property regcommentmetodo() As String
        Get
            Return sregcommentmetodo
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            sregcommentmetodo = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: expresión regular para aquellos metodos que no tienen retorno
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property regmetsinretorno() As String
        Get
            Return sregmetsinretorno
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            sregmetsinretorno = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: expresión regular para el apuntador del procedimiento
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property regprocedure() As String
        Get
            Return sregprocedure
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            sregprocedure = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Caracteres para quitar
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property regcarquitar() As String
        Get
            Return sregcarquitar
        End Get
        Set(ByVal psval As String)
            If psval Is Nothing Then Exit Property
            sregcarquitar = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: configuracion para una clase
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property xmlclase() As Nodo
        Get
            Return oxmlclase
        End Get
        Set(ByVal obj As Nodo)
            oxmlclase = obj
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: configuración para un metodo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property xmlmetodo() As Nodo
        Get
            Return oxmlmetodo
        End Get
        Set(ByVal obj As Nodo)
            oxmlmetodo = obj
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: configuración para un pseudocodigo
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property xmlpseudocodigo() As Nodo
        Get
            Return oxmlpseudocodigo
        End Get
        Set(ByVal obj As Nodo)
            oxmlpseudocodigo = obj
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: expresión regular para aquellos metodos que son publicos
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property regmetpublico() As String
        Get
            Return sregmetpublico
        End Get
        Set(ByVal psval As String)
            sregmetpublico = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' Procedimiento que regresa el nombre completo de un archivo, incluyendo la ruta
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Getfullname() As String
        Dim sfull As String = ""
        If sdir.Substring(sdir.Length - 1, 1).Equals("\") Then
            sfull = sdir & sfile
        Else
            sfull = sdir & "\" & sfile
        End If
        Return sfull
    End Function

    ''' <summary>
    ''' Procedimiento para regresar el objeto clase
    ''' </summary>
    ''' <returns>objeto</returns>
    ''' <remarks></remarks>
    Public Function GetClase() As Clase
        Return oClase
    End Function

    ''' <summary>
    ''' Procedimiento para agregar un nuevo mensaje resultado de algún proceso de la clase
    ''' </summary>
    ''' <param name="sclave">clave del mensaje</param>
    ''' <param name="sdescripcion">descripción del mensaje</param>
    ''' <param name="sorigen">origen del mensaje</param>
    ''' <remarks></remarks>
    Public Sub AddMensaje(ByVal sclave As String, ByVal sdescripcion As String, ByVal sorigen As String)
        Dim omsg As Mensaje = New Mensaje
        omsg.clave = sclave
        omsg.description = sdescripcion
        omsg.origen = sorigen
        omsg.iserror = False
        cmensajes.Add(omsg)
    End Sub

    ''' <summary>
    ''' Procedimiento para agregar un nuevo mensaje resultado de algún proceso de la clase
    ''' </summary>
    ''' <param name="sclave">clave del mensaje</param>
    ''' <param name="sdescripcion">descripción del mensaje</param>
    ''' <param name="sorigen">origen del mensaje</param>
    ''' <remarks></remarks>
    Public Sub AddMensajeError(ByVal sclave As String, ByVal sdescripcion As String, ByVal sorigen As String)
        Dim omsg As Mensaje = New Mensaje
        omsg.clave = sclave
        omsg.description = sdescripcion
        omsg.origen = sorigen
        omsg.iserror = True
        cmensajes.Add(omsg)
    End Sub

    ''' <summary>
    ''' Función para extraer todos los mensajes que ocurrieron con el archivo
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getMensajes() As Collection
        Return cmensajes
    End Function


    ''' <summary>
    ''' Procedimiento para hacer un parse al archivo, identificando su clase y methodos
    ''' </summary>
    ''' <returns>true/false</returns>
    ''' <remarks></remarks>
    Public Function Parse() As Boolean
        Dim ofile As System.IO.File
        Dim oread As System.IO.StreamReader
        Dim o_RegExp As Regex
        Dim o_Match As Match
        Dim o_Matches As MatchCollection

        Try
            'PASO 1: inicia
            o_RegExp = New Regex(sregclase)
            oClase = New Clase

            'PASO 2: Lee el contenido del archivo con la clase
            oread = New StreamReader(Me.Getfullname(), System.Text.Encoding.GetEncoding(28593))      'Abre el archivo   
            Me.content = oread.ReadToEnd()      'Lee el contenido del fichero y lo almacena en la var
            oread.Close()
            Me.content = outil.Quita_Caracter(Me.content, vbCr)     ' quita el salto de <return>
            cmensajes = New Collection

            'PASO 3: Ejecuta la busqueda para las clases
            o_Matches = o_RegExp.Matches(Me.content)

            If o_Matches.Count = 0 Then
                Me.AddMensajeError("ERR0006", "ERROR: No se ha encontrado ninguna clase en el archivo", "Psique.vbnetfile.Parse()")
                Return False
            End If

            If o_Matches.Count > 1 Then
                Me.AddMensajeError("ERR0001", "ERROR: No está permitido por PSIQUE tener más de una clase por archivo", "Psique.vbnetfile.Parse()")
                Return False
            End If

            'PASO 4: Asigna las propiedades de la clase
            o_Match = o_Matches.Item(0)
            oClase.file = Me.Getfullname()
            oClase.name = o_Match.Groups("name").Value
            oClase.comment = Me.GetComment(0, o_Match.Index, "clase")
            oClase.declaracion = Me.GetLine(o_Match.Index)

            'PASO 5: Consulta los metodos 
            oClase.methods = Me.GetMethods(o_Match.Index)

            'PASO 6: Termina
            ofile = Nothing 'Cierra el archivo   

        Catch ex As HANYException
            ex.add("MyLIB.ClassReader.Parse()", "Ocurrio un error al hacer parse a un archivo HTML")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.ClassReader.Parse()", "Ocurrio un error al hacer parse a un archivo HTML [" & ex1.ToString & "]")
        End Try

        Return True
    End Function


    ''' <summary>
    ''' Function para regresar el comentario para una clase ó para un metodo
    ''' </summary>
    ''' <param name="ifirst">primer posición desde donde buscar</param>
    ''' <param name="ilast">última posición donde buscar</param>
    ''' <returns>Declaración del comentario</returns>
    ''' <remarks></remarks>
    Private Function GetComment(ByVal ifirst As Integer, ByVal ilast As Integer, ByVal stipo As String) As String
        Dim o_Matches As MatchCollection
        Dim o_RegExp As Regex = New Regex("")
        Dim o_Match As Match
        Dim scomment As String
        Dim sresult As String = ""

        Try
            'PASO 1: inicializa el proceso
            Select Case stipo
                Case "clase"
                    o_RegExp = New Regex(sregcommentclase)
                Case "metodo"
                    o_RegExp = New Regex(sregcommentmetodo)
            End Select

            'PASO 2: Executa el MATCH
            scomment = Me.content.Substring(ifirst, ilast - ifirst)
            o_Matches = o_RegExp.Matches(scomment)

            'PASO 3: Si no hay comentario, regreso de inmediato
            If o_Matches.Count = 0 Then Return ""

            'PASO 4: Si encuentro mas de un comentario es un error y regreso nada
            If o_Matches.Count > 1 Then
                Me.AddMensajeError("ERR0002", "ERROR: No está permitido por PSIQUE tener más de un comentario por clase ó método", "Psique.vbnetfile.GetCommentFull()")
                Return ""
            End If

            'PASO 5: Toma el primer comentario encontrado
            o_Match = o_Matches.Item(0)
            scomment = outil.Quita_Caracter(scomment.Substring(o_Match.Index).ToLower, sregcarquitar)

            'PASO 6: Utiliza la configuración dependiendo del tipo de comentario solicitado
            Select Case stipo
                Case "clase"
                    If oxmlclase.getValue("comentario.tipo").Equals("entre_texto") Then

                        sresult = outil.ObtenCadenaBetween(scomment, oxmlclase.getValue("comentario.texto_inicio"), oxmlclase.getValue("comentario.texto_fin")).Trim
                    End If
                    If oxmlclase.getValue("comentario.tipo").Equals("no_inicia_con") Then
                        Dim ccol As Collection = outil.CAparta_Tokens(scomment, vbLf)
                        sresult = ""
                        For Each slinea As String In ccol
                            If Not Trim(slinea).StartsWith(oxmlclase.getValue("comentario.texto_inicio")) Then sresult = sresult & " " & slinea
                        Next
                    End If
                    If oxmlclase.getValue("comentario.tipo").Equals("todo") Then sresult = scomment

                Case "metodo"
                    If oxmlmetodo.getValue("comentario.tipo").Equals("entre_texto") Then
                        sresult = outil.ObtenCadenaBetween(scomment, oxmlmetodo.getValue("comentario.texto_inicio"), oxmlmetodo.getValue("comentario.texto_fin")).Trim
                    End If
                    If oxmlmetodo.getValue("comentario.tipo").Equals("no_inicia_con") Then
                        Dim ccol As Collection = outil.CAparta_Tokens(scomment, vbLf)
                        sresult = ""
                        For Each slinea As String In ccol
                            If Not Trim(slinea).StartsWith(oxmlmetodo.getValue("comentario.texto_inicio")) Then sresult = sresult & " " & slinea
                        Next
                    End If
                    If oxmlmetodo.getValue("comentario.tipo").Equals("todo") Then sresult = scomment
            End Select

            'PASO 7: Termina!
            Return outil.Quita_Caracter(sresult, vbLf)

        Catch ex As HANYException
            ex.add("MyLIB.ClassReader.GetComment()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.ClassReader.GetComment()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Function

    ''' <summary>
    ''' Functión para regresar los metodos que existen dentro de una parte del codigo
    ''' </summary>
    ''' <param name="iposicion">posición desde donde buscar</param>
    ''' <returns>colección de metodos</returns>
    ''' <remarks></remarks>
    Private Function GetMethods(ByVal iposicion As Integer) As Collection
        Dim cmethods As Collection = Nothing
        Dim o_RegExp As Regex
        Dim o_Matches As MatchCollection
        Dim o_Match As Match
        Dim ilastpos As Integer
        Dim oexreg_MetPublico As Regex

        Try
            'PASO 1: Inicia valores
            o_RegExp = New Regex(sregprocedure)
            oexreg_MetPublico = New Regex(regmetpublico)
            cmethods = New Collection
            ilastpos = iposicion

            'PASO 2: Executa el Match 
            o_Matches = o_RegExp.Matches(Me.content)

            'PASO 4: Valida si no hay methodos
            If o_Matches.Count = 0 Then
                Me.AddMensaje("INF0001", "No existen métodos en la clase", "Psique.vbnetfile.GetMethods()")
                Return cmethods
            End If

            'PASO 3: Recorre todos los metodos encontrados...
            For Each o_Match In o_Matches
                Dim omethod As Metodo = New Metodo
                Dim o_Matches1 As MatchCollection

                'PASO 3.1: Lee las propiedades de un metodo
                omethod.file = oClase.file
                omethod.languaje = oClase.languaje
                omethod.clase = oClase.name
                omethod.hasretorno = Me.DeterminaSiTieneRetorno(Me.GetLine(o_Match.Index))
                omethod.declaracion = outil.Toma_Token(1, Me.GetLine(o_Match.Index), "{")
                omethod.tipo = o_Match.Groups("tipo").Value
                omethod.nombre = o_Match.Groups("name").Value
                omethod.comment = Me.GetComment(ilastpos, o_Match.Index, "metodo")
                ilastpos = o_Match.Index

                'PASO 3.1: Determina si es publico
                o_Matches1 = oexreg_MetPublico.Matches(omethod.declaracion)
                If o_Matches1.Count > 0 Then omethod.ispublico = True

                cmethods.Add(omethod)
            Next

            Return cmethods
        Catch ex As HANYException
            ex.add("MyLIB.ClassReader.GetMethods()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.ClassReader.GetMethods()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Function

    ''' <summary>
    ''' Función para determinar si se tiene un retorno para este metodo
    ''' </summary>
    ''' <param name="slinea"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function DeterminaSiTieneRetorno(ByVal slinea As String) As Boolean
        Dim o_RegExp As Regex
        Dim o_Matches As MatchCollection

        If sregmetsinretorno.Equals("") Then Return True

        Try
            'PASO 1: Inicializa los valores
            o_RegExp = New Regex(sregmetsinretorno)

            'PASO 2: Executa el Match 
            o_Matches = o_RegExp.Matches(slinea)

            'PASO 4: Valida si no hay methodos
            If o_Matches.Count > 0 Then Return False

        Catch ex As HANYException
            ex.add("MyLIB.ClassReader.DeterminaSiTieneRetorno()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.ClassReader.DeterminaSiTieneRetorno()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        Return True
    End Function

    ''' <summary>
    ''' Procedimiento para regresar una linea desde la posicion actual
    ''' </summary>
    ''' <param name="iposition">posicion desde donde iniciar</param>
    ''' <returns>cadena con la linea</returns>
    ''' <remarks></remarks>
    Private Function GetLine(ByVal iposition As Integer) As String
        Dim iposlinefeed As Integer
        Dim slinea As String = ""
        Try
            iposlinefeed = Me.content.IndexOf(vbLf, iposition)
            If iposlinefeed < 0 Then
                Me.AddMensajeError("ERR0003", "ERROR: No se encontro el fin de linea", "Psique.vbnetfile.GetLine()")
                Return slinea
            End If
            slinea = Me.content.Substring(iposition, iposlinefeed - iposition)
            Return slinea
        Catch ex As HANYException
            ex.add("MyLIB.ClassReader.GetLine()", "Ocurrio un error al hacer parse a un archivo HTML")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.ClassReader.GetLine()", "Ocurrio un error al hacer parse a un archivo HTML [" & ex1.ToString & "]")
        End Try

    End Function

    ''' <summary>
    ''' Procedimiento para validar la existencia de todos los comentarios en el archivos
    ''' Comentario tanto para la clase, como para los metodos
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function isallComented() As Boolean
        Try
            If Not oClase.hascomment() Then Me.AddMensaje("ERR0004", "No existe un comentario para la clase [" & oClase.name & "]", "Psique.vbnetfile.isallComented()")
            For Each omethod As Metodo In oClase.methods
                If Not omethod.hascomment() Then Me.AddMensaje("ERR0005", "No existe un comentario para el método [" & omethod.nombre & "]", "Psique.vbnetfile.isallComented()")
            Next
        Catch ex As HANYException
            ex.add("MyLIB.ClassReader.isallComented()", "Ocurrio un error al hacer parse a un archivo HTML")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.ClassReader.isallComented()", "Ocurrio un error al hacer parse a un archivo HTML [" & ex1.ToString & "]")
        End Try

    End Function

End Class   'fin claswe 

