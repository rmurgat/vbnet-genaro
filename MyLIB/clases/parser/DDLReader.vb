Option Explicit On

Imports System.Text.RegularExpressions
Imports System.IO

''' <summary>
''' Clase con los métodos necesarios para hacer el parse sobre un Lenguaje de Definición de Datos
''' </summary>
''' <remarks></remarks>
Public Class DDLReader
    Private sregentidad As String = ""         'expresión regular para el apuntador de las entidades
    Private sregcampos As String = ""          'expresión regular para el apuntador de los campos
    Private sregprimary As String = ""         'expresión regular para las primary keys
    Private stxnotnull As String = ""          'texto que determina que no es null
    Private sregreference As String = ""       'expresión regular para el apuntador de las referencias
    Private scontent As String = ""            'contenido del ddl
    Private outil As Utilerias                 'objeto con las utilerias 
    Private cmensajes As Collection            'colección de mensajes

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        outil = New Utilerias
        cmensajes = New Collection
    End Sub

    ''' <summary>
    ''' PROPIEDAD: expresión regular para el apuntador de las entidades
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property regentidad() As String
        Get
            Return sregentidad
        End Get
        Set(ByVal psval As String)
            sregentidad = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: expresión regular para el apuntador de los campos
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property regcampos() As String
        Get
            Return sregcampos
        End Get
        Set(ByVal psval As String)
            sregcampos = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: expresión regular para el apuntador de las referencias
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property regreference() As String
        Get
            Return sregreference
        End Get
        Set(ByVal psval As String)
            sregreference = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: expresión regular para las primary keys
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property regprimary() As String
        Get
            Return sregprimary
        End Get
        Set(ByVal psval As String)
            sregprimary = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: contenido del ddl
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property content() As String
        Get
            Return scontent
        End Get
        Set(ByVal psval As String)
            scontent = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: texto que determina que no es null
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property txnotnull() As String
        Get
            Return stxnotnull
        End Get
        Set(ByVal pstx As String)
            stxnotnull = pstx.Trim
        End Set
    End Property


    ''' <summary>
    ''' Función para hacer el Parse de un Lenguaje de Definición de datos
    ''' </summary>
    ''' <param name="sddl">Instrucción sql</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function Parse(ByVal sddl As String) As Collection
        Dim ocres As Collection
        Dim idx, idxlast As Integer
        Dim ocurEntidad As EntidaDato = Nothing
        Dim o_RegExp As Regex
        Dim o_Match As Match
        Dim o_Matches As MatchCollection

        Try
            'PASO 1: Inicializa
            idx = 0
            ocres = New Collection
            o_RegExp = New Regex(Me.sregentidad)
            Me.content = outil.Remplaza_Caracter(sddl, vbCr & vbLf, " ")     ' quita el salto de <return>

            'PASO 2: Ejecuta la busqueda para las entidades
            o_Matches = o_RegExp.Matches(Me.content)
            If o_Matches.Count = 0 Then
                Me.AddMensajeError("ERR0001", "ERROR: No se ha encontrado ninguna tabla en el archivo", "MyLIB.DDLReader.Parse(1)")
                Return New Collection
            End If

            'PASO 3: Recorre los matchs de las entidades
            For idx = 0 To o_Matches.Count - 1
                Dim oentidad As EntidaDato

                'PASO 3.1: Incluye los datos de la entidad
                oentidad = New EntidaDato
                o_Match = o_Matches.Item(idx)
                If idx + 1 < o_Matches.Count Then
                    Dim o_Match_Next As Match
                    o_Match_Next = o_Matches.Item(idx + 1)
                    idxlast = o_Match_Next.Index
                Else
                    idxlast = Me.content.Length
                End If
                oentidad.nbentidadato = o_Match.Groups("nombre").Value
                oentidad.txddl = Me.content.Substring(o_Match.Index, idxlast - o_Match.Index)
                oentidad.tpentidadato = "TA"

                'PASO 3.2: Realiza el parser a cada uno de los campos
                oentidad.ccampos = Me.ParseCampos(oentidad)

                'PASO 3.3: Realiza el parser a la llave principal
                oentidad.cllaves = Me.ParseLlave(oentidad)
                oentidad.Marcarllaves()

                ocres.Add(oentidad)
            Next

        Catch ex As HANYException
            ex.add("MyLIB.DLLReader.Parse()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DLLReader.Parse()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        Return ocres
    End Function

    ''' <summary>
    ''' Procedimiento para realizar un parse y determinar aquellos que son llaves
    ''' </summary>
    ''' <param name="oentidad">Objeto tipo entidad</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ParseLlave(ByRef oentidad As EntidaDato) As Collection
        Dim ocres As Collection
        Dim idx As Integer
        Dim sllave As String

        Dim o_RegExp As Regex
        Dim o_Match As Match
        Dim o_Matches As MatchCollection

        Try
            'PASO 1: Inicializa
            idx = 0
            ocres = New Collection
            o_RegExp = New Regex(Me.regprimary)
            o_Matches = o_RegExp.Matches(oentidad.txddl)

            'PASO 2: Recorre los matchs de las entidades
            If o_Matches.Count = 1 Then
                o_Match = o_Matches.Item(0)
                sllave = outil.Quita_Caracter(o_Match.Groups("llave").Value, ")")
                Return outil.CAparta_Tokens(sllave, ",")
            End If
        Catch ex As HANYException
            ex.add("MyLIB.DLLReader.ParseLlave()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DLLReader.ParseLlave()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
        Return New Collection
    End Function

    ''' <summary>
    ''' Procedimiento para realizar un parser de cada uno de los campos del DDL
    ''' </summary>
    ''' <param name="oentidad">objeto con la información de la entidad</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function ParseCampos(ByRef oentidad As EntidaDato) As Collection
        Dim ocres As Collection
        Dim idx As Integer
        Dim o_RegExp As Regex
        Dim o_Match As Match
        Dim o_Matches As MatchCollection

        Try
            'PASO 1: Inicializa
            idx = 0
            ocres = New Collection
            o_RegExp = New Regex(Me.regcampos)

            'PASO 2: Ejecuta la busqueda para las entidades
            o_Matches = o_RegExp.Matches(oentidad.txddl)
            If o_Matches.Count = 0 Then
                Me.AddMensajeError("ERR0001", "ERROR: No se ha encontrado ningún campo en la entidad [" & oentidad.nbentidadato & "]", "MyLIB.DDLReader.Parse(1)")
                Return New Collection
            End If

            'PASO 3: Recorre los matchs 
            For idx = 0 To o_Matches.Count - 1
                Dim ocampo As EntidaDatoCampo

                'PASO 3.1: Arma los datos del campo
                ocampo = New EntidaDatoCampo
                o_Match = o_Matches.Item(idx)
                ocampo.cdorden = idx + 1
                ocampo.nbentidadato = oentidad.nbentidadato
                ocampo.nbcampo = o_Match.Groups("campo").Value
                If ocampo.nbcampo.Equals("IM_TOTAL") Then
                    idx = idx
                End If
                ocampo.cdtpdatofisico = o_Match.Groups("tipo").Value
                If o_Match.Groups("long").Value.Equals("") Then
                    ocampo.nulongitud = 0
                Else
                    ocampo.nulongitud = Integer.Parse(o_Match.Groups("long").Value)
                End If
                If o_Match.Groups("dec").Value.Equals("") Then
                    ocampo.nudecimales = 0
                Else
                    ocampo.nudecimales = Integer.Parse(o_Match.Groups("dec").Value)
                    ocampo.cdtpdatofisico = ocampo.cdtpdatofisico & "(n,n)"
                End If
                ocampo.stpermitenulos = IIf(o_Match.Groups("null").Value.Equals(Me.txnotnull), Comun.ST_INACTIVO, Comun.ST_ACTIVO)

                'PASO 3.2: Agrega el campo a la colección
                ocres.Add(ocampo)
            Next

        Catch ex As HANYException
            ex.add("MyLIB.DLLReader.ParseCampos()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DLLReader.ParseCampos()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
        Return ocres
    End Function

    ''' <summary>
    ''' Procedimiento para realizar un parser de cada uno de los campos del DDL
    ''' </summary>
    ''' <param name="sddl">Instrucción sql</param>
    ''' <returns>Collection</returns>
    ''' <remarks></remarks>
    Public Function ParseReference(ByVal sddl As String) As Collection
        Dim ocres As Collection
        Dim ocurEntidad As EntidaDato = Nothing
        Dim o_RegExp As Regex
        Dim o_Match As Match
        Dim o_Matches As MatchCollection
        Dim idx As Integer

        Try
            'PASO 1: Inicializa
            ocres = New Collection
            o_RegExp = New Regex(Me.sregreference)
            Me.content = outil.Remplaza_Caracter(sddl, vbCr & vbLf, " ")     ' quita el salto de <return>

            'PASO 2: Ejecuta la busqueda para las entidades
            o_Matches = o_RegExp.Matches(Me.content)
            If o_Matches.Count = 0 Then
                Me.AddMensajeError("ERR0001", "ERROR: No se ha encontrado ninguna tabla en el archivo", "MyLIB.DDLReader.Parse(1)")
                Return New Collection
            End If

            'PASO 3: Recorre los matchs de las referencias foraneas
            For idx = 0 To o_Matches.Count - 1
                Dim oentidad As EntidaDato
                Dim creferences As Collection
                Dim ccampos As Collection
                Dim crefcampos As Collection
                Dim oreference As Referencia

                'PASO 3.1: Incluye los datos de la entidad
                oentidad = New EntidaDato
                creferences = New Collection
                crefcampos = New Collection
                o_Match = o_Matches.Item(idx)
                oentidad.nbentidadato = o_Match.Groups("tabla").Value
                oentidad.creferences = creferences
                oreference = New Referencia
                creferences.Add(oreference)
                oreference.nbentidadato = oentidad.nbentidadato
                oreference.nbreferencia = o_Match.Groups("referencia").Value
                oreference.txcomment = "FOREIGN KEY"
                ccampos = outil.CAparta_Tokens(o_Match.Groups("params").Value, ",")
                For Each scampo As String In ccampos
                    Dim obj As Referenciacampo = New Referenciacampo
                    obj.nbcampo = scampo
                    obj.nbentidadato = oentidad.nbentidadato
                    crefcampos.Add(obj)
                Next
                oreference.cCampos = crefcampos
                ocres.Add(oentidad)
            Next

        Catch ex As HANYException
            ex.add("MyLIB.DLLReader.ParseReference()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.DLLReader.ParseReference()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        Return ocres
    End Function

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

End Class
