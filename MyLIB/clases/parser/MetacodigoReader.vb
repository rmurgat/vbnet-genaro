Imports System.Text.RegularExpressions
Imports System.IO

''' <summary>
''' Lector de metacodigo 
''' </summary>
''' <remarks></remarks>
Public Class MetacodigoReader
    Private sdir As String      'directorio actual del archivo
    Private sfile As String     'nombre del archivo
    Private ssource As String   'contenido del archivo original
    Private outil As Utilerias  'utilerias del sistema
    Private alineas() As String = Nothing
    Private bmismalinea As Boolean = False
    Private oxmlmain As Nodo
    Private oLog As HANYLog
    Private stmp As String
    Private sdebug As String = ""            ' Cadena que tiene el detalle del debug en una conversión
    Private bsincespeciales As Boolean       ' Bandera que determina que esto no lleva caracteres especiales

    ''' <summary>
    ''' CONSTRUCTOR
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Me.sdir = ""
        Me.sfile = ""
        outil = New Utilerias
        oxmlmain = New Nodo
        oLog = New HANYLog
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
            sfile = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Bandera que determina que esto no lleva caracteres especiales
    ''' </summary>
    ''' <value></value>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Property sincespeciales() As Boolean
        Get
            Return bsincespeciales
        End Get
        Set(ByVal pbval As Boolean)
            bsincespeciales = pbval
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
            sfull = sdir & "/" & sfile
        End If
        Return sfull
    End Function

    ''' <summary>
    ''' PROPIEDAD: contenido del archivo original
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property source() As String
        Get
            Return ssource
        End Get
        Set(ByVal psval As String)
            ssource = psval
        End Set
    End Property

    ''' <summary>
    ''' Función para regresar el debug
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function getdebug() As String
        Return sdebug
    End Function

    ''' <summary>
    ''' Procedimiento para cargar el metacodigo fuente
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoadSource()
        Dim oread As System.IO.StreamReader
        Dim sline As String = ""

        Try
            oread = New StreamReader(Me.Getfullname())      'Abre el archivo   
            Me.source = oread.ReadToEnd()      'Lee el contenido del fichero y lo almacena en la var
            oread.Close()
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.MetacodigoReader.LoadSource()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para interpretar el metacódigo 
    ''' </summary>
    ''' <param name="sxml">codigo en xml para la interpretación</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Interpreta(ByVal sxml As String) As String
        Dim sresult As String

        sresult = Nothing
        Try
            If Me.sincespeciales Then
                Me.SetXML(outil.Quitar_Especiales(sxml))
            Else
                Me.SetXML(sxml)
            End If
            sresult = Interpreta()
        Catch ex As HANYException
            ex.add("MyLIB.MetacodigoReader.Interpreta(sxml)", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.MetacodigoReader.Interpreta(sxml)", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
        Return sresult
    End Function

    ''' <summary>
    ''' Procedimiento para interpretar el metacódigo 
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function Interpreta() As String
        Dim ilineas, iIniToken As Integer
        Dim sresult As String = ""
        Dim iposdelim As Integer
        Dim ccontextos As Collection

        If ssource.Equals("") Then Return ""

        Try
            'PASO 1: Inicializa valores
            ReDim alineas(0)
            iIniToken = 1                  'Desde donde inicia el token
            ilineas = 1                  'Número de tokens en la expresión
            ccontextos = New Collection
            iposdelim = InStr(iIniToken, Me.source, Chr(13) + Chr(10))
            sdebug = sdebug & "---->  [INICIANDO INTERPRETACION DE META-CODIGO]" & vbCr
            sdebug = sdebug & "---->  [META-CODIGO:" & Me.file & "]" & vbCr

            'PASO 2: recorre las lineas
            While iposdelim > 0
                ReDim Preserve alineas(ilineas)  'Redimensiona el arreglo del token
                alineas(ilineas) = Mid$(Me.source, iIniToken, iposdelim - iIniToken)
                iIniToken = iposdelim + Len(Trim$(Chr(13) + Chr(10))) 'Define la posición inicial del token otra vez
                iposdelim = InStr(iIniToken, Me.source, Chr(13) + Chr(10))
                ilineas = ilineas + 1 'Incrementa el número de tokens encontrados
            End While

            'PASO 3: Extrae el unico ó ultimo token de la expresión
            ReDim Preserve alineas(ilineas)
            alineas(ilineas) = Mid$(Me.source, iIniToken, Len(Me.source))
            If ilineas = 0 Then Return ""
            ccontextos.Add(oxmlmain)
            sresult = InterpretaA(1, ilineas, ccontextos)

        Catch ex As HANYException
            ex.add("MyLIB.MetacodigoReader.Interpreta()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.MetacodigoReader.Interpreta()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
        Return sresult
    End Function

    ''' <summary>
    ''' Procedimiento para interpretar el metacódigo 
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Private Function InterpretaA(ByVal iini As Integer, ByVal ifin As Integer, ByRef ccontextos As Collection) As String
        Dim ipos As Integer
        Dim ilast As Integer
        Dim sresult As String = ""
        Dim o_RegExp As Regex
        Dim o_Matches As MatchCollection
        Dim o_Match As Match
        Dim iitem As Integer
        Dim ihola As Integer
        'Dim bhola As Boolean
        ipos = iini


        Try
            Do While ipos <= ifin

                'If ipos = 240 And Me.file.Equals("negocio.met") Then
                'bhola = True
                'End If
                o_RegExp = New Regex("#(?<instruccion>\w+)\s+")
                o_Matches = o_RegExp.Matches(alineas(ipos))
                sdebug = sdebug & "---->        INTERPRETA LINEA Num=[" & ipos & "] Content=[" & alineas(ipos) & "]" & vbCr
                If alineas(ipos).IndexOf("class") > 0 Then
                    ihola = 0
                End If
                If o_Matches.Count > 0 Then
                    o_Match = o_Matches.Item(0)
                    Select Case o_Match.Groups("instruccion").Value
                        Case "SI"
                            o_RegExp = New Regex("#SI\s+(?<name>\S+)\s+(?<condicion>ESIGUALA|ESDIFERENTEA|ESTAEN)\s+(?<constante>=?\S+)\s*#")
                            o_Matches = o_RegExp.Matches(alineas(ipos))
                            If o_Matches.Count > 0 Then
                                Dim ilastbloque1 As Integer
                                Dim ilastbloque2 As Integer
                                Dim svalor As String
                                Dim sconstante As String

                                ilast = Me.getposfinbloqueinclude("#SI", "#FIN SI#", ipos, ifin)
                                ilastbloque1 = Me.getposfinbloque1("#SI", "#Y SI NO#", "#FIN SI#", ipos, ilast)
                                ilastbloque2 = Me.getposfinbloqueinclude("#SI", "#Y SI NO#", "#FIN SI#", IIf(ilastbloque1 > 0, ilastbloque1, ipos), ilast)
                                o_Match = o_Matches.Item(0)

                                svalor = Me.getValor(ccontextos, o_Match.Groups("name").Value)
                                If o_Match.Groups("name").Value.Equals("variable.valor") Then
                                    sconstante = ""
                                End If
                                If Not o_Match.Groups("constante").Value.Equals(Comun.STR_XML_VALOR_VACIO) Then
                                    If svalor.Equals("") Then
                                        Throw New Exception("Error, no se puede encontrar el valor de " & o_Match.Groups("name").Value & " en " & Me.file)
                                    End If
                                End If
                                If svalor.Equals(Comun.STR_XML_VALOR_VACIO) Then svalor = ""
                                sconstante = Me.getConstante(ccontextos, o_Match.Groups("constante").Value)
                                sdebug = sdebug & "-------->       VALOR=[" & svalor & "]" & vbCr
                                sdebug = sdebug & "-------->       CONSTANTE=[" & sconstante & "]" & vbCr

                                If ilastbloque1 = 0 Then   'si no encuentra la instrucción #Y SI NO#
                                    If o_Match.Groups("condicion").Value.Equals("ESIGUALA") And svalor.Equals(sconstante) Then
                                        sresult = sresult & Me.InterpretaA(ipos + 1, ilast - 1, ccontextos)
                                    End If
                                    If o_Match.Groups("condicion").Value.Equals("ESDIFERENTEA") And Not svalor.Equals(sconstante) Then
                                        sresult = sresult & Me.InterpretaA(ipos + 1, ilast - 1, ccontextos)
                                    End If
                                    If o_Match.Groups("condicion").Value.Equals("ESTAEN") And sconstante.IndexOf(svalor) >= 0 Then
                                        sresult = sresult & Me.InterpretaA(ipos + 1, ilast - 1, ccontextos)
                                    End If
                                Else ' si encuentra la instrucción #Y SI NO#
                                    If o_Match.Groups("condicion").Value.Equals("ESIGUALA") Then
                                        If svalor.Equals(sconstante) Then
                                            sresult = sresult & Me.InterpretaA(ipos + 1, ilastbloque1 - 1, ccontextos)
                                        Else
                                            sresult = sresult & Me.InterpretaA(ilastbloque1 + 1, ilastbloque2 - 1, ccontextos)
                                        End If
                                    End If
                                    If o_Match.Groups("condicion").Value.Equals("ESDIFERENTEA") Then
                                        If Not svalor.Equals(sconstante) Then
                                            sresult = sresult & Me.InterpretaA(ipos + 1, ilastbloque1 - 1, ccontextos)
                                        Else
                                            sresult = sresult & Me.InterpretaA(ilastbloque1 + 1, ilastbloque2 - 1, ccontextos)
                                        End If
                                    End If
                                    If o_Match.Groups("condicion").Value.Equals("ESTAEN") Then
                                        If sconstante.IndexOf(svalor) < 0 Then
                                            sresult = sresult & Me.InterpretaA(ilastbloque1 + 1, ilastbloque2 - 1, ccontextos)
                                        Else
                                            sresult = sresult & Me.InterpretaA(ipos + 1, ilastbloque1 - 1, ccontextos)
                                        End If
                                    End If
                                End If
                                ipos = ilast + 1
                            Else
                                'si no hay correspondencia...sencillamente se pasa a la siguiente
                                ipos = ipos + 1
                            End If

                        Case "SIHAY"

                            Dim onodo As Nodo
                            Dim cnodos As Collection
                            ilast = Me.getposfinbloqueinclude("#SIHAY", "#FIN SIHAY#", ipos, ifin)
                            o_RegExp = New Regex("#SIHAY\s+(?<name>\w+)\s+EN\s+(?<coleccion>\w+|\w+\.\w+|\w+\.\w+\.\w+)\s*#")
                            o_Matches = o_RegExp.Matches(alineas(ipos))
                            If o_Matches.Count > 0 Then
                                o_Match = o_Matches.Item(0)
                                onodo = Me.getPrimerNodo(ccontextos, o_Match.Groups("coleccion").Value)
                                If onodo Is Nothing Then
                                    ipos = ilast + 1
                                    Exit Select
                                End If
                                cnodos = onodo.getNodo(o_Match.Groups("name").Value)
                                sdebug = sdebug & "-------->       NUMERO NODOS=[" & cnodos.Count & "]" & vbCr

                                If cnodos.Count > 1 Then
                                    sresult = sresult & Me.InterpretaA(ipos + 1, ilast - 1, ccontextos)
                                End If
                                ipos = ilast + 1
                            Else
                                o_RegExp = New Regex("#SIHAY\s+(?<name>\w+)\s+EN\s+(?<coleccion>\S+)\s+DONDE\s+(?<variable>\S+)\s+ESIGUALA\s+(?<constante>=?\w+|=?\w+\.\w+|=?\w+\.\w+\.\w+)\s*#")
                                o_Matches = o_RegExp.Matches(alineas(ipos))
                                If o_Matches.Count > 0 Then
                                    Dim sconstante As String
                                    o_Match = o_Matches.Item(0)
                                    onodo = Me.getPrimerNodo(ccontextos, o_Match.Groups("coleccion").Value)
                                    If onodo Is Nothing Then
                                        ipos = ilast + 1
                                        Exit Select
                                    End If
                                    sconstante = Me.getConstante(ccontextos, o_Match.Groups("constante").Value)
                                    cnodos = onodo.Buscar(o_Match.Groups("name").Value, o_Match.Groups("variable").Value, sconstante)
                                    sdebug = sdebug & "-------->       NUMERO NODOS QUE CUMPLEN=[" & cnodos.Count & "]" & vbCr
                                    If cnodos.Count > 0 Then
                                        sresult = sresult & Me.InterpretaA(ipos + 1, ilast - 1, ccontextos)
                                    End If
                                    ipos = ilast + 1
                                End If
                            End If

                        Case "PARA"

                            Dim onodo As Nodo
                            Dim cnodos As Collection
                            ilast = Me.getposfinbloqueinclude("#PARA CADA", "#FIN PARA CADA#", ipos, ifin)
                            o_RegExp = New Regex("#PARA CADA\s+(?<name>\w+)\s+EN\s+(?<coleccion>\w+|\w+\.\w+|\w+\.\w+\.\w+|\w+\.\w+\.\w+.\w+)\s*#")
                            o_Matches = o_RegExp.Matches(alineas(ipos))
                            If o_Matches.Count > 0 Then
                                o_Match = o_Matches.Item(0)

                                If o_Match.Groups("clase").Value.Equals("") Then
                                    stmp = ""
                                End If
                                onodo = Me.getPrimerNodo(ccontextos, o_Match.Groups("coleccion").Value)
                                If onodo Is Nothing Then
                                    ipos = ilast + 1
                                    Exit Select
                                End If
                                cnodos = onodo.getNodo(o_Match.Groups("name").Value)
                                sdebug = sdebug & "-------->       NUMERO NODOS=[" & cnodos.Count & "]" & vbCr
                                For iitem = 1 To cnodos.Count
                                    Dim ono As Nodo = cnodos.Item(iitem)
                                    ono.addNodoEn(o_Match.Groups("name").Value, New Nodo("<esprimero>" & IIf(iitem = 1, "Si", "No") & "</esprimero>"))
                                    ono.addNodoEn(o_Match.Groups("name").Value, New Nodo("<esultimo>" & IIf(iitem = cnodos.Count, "Si", "No") & "</esultimo>"))
                                    ccontextos.Add(ono)
                                    sresult = sresult & Me.InterpretaA(ipos + 1, ilast - 1, ccontextos)
                                    ccontextos.Remove(ccontextos.Count)
                                Next
                                ipos = ilast + 1
                            Else
                                o_RegExp = New Regex("#PARA CADA\s+(?<name>\w+)\s+EN\s+(?<coleccion>\S+)\s+DONDE\s+(?<variable>\S+)\s+(?<condicion>ESIGUALA|ESDIFERENTEA)\s+(?<constante>\S+)\s*#")
                                o_Matches = o_RegExp.Matches(alineas(ipos))
                                If o_Matches.Count > 0 Then
                                    Dim sconstante As String
                                    Dim scondicion As String
                                    o_Match = o_Matches.Item(0)

                                    onodo = Me.getPrimerNodo(ccontextos, o_Match.Groups("coleccion").Value)
                                    If onodo Is Nothing Then
                                        ipos = ilast + 1
                                        Exit Select
                                    End If
                                    scondicion = o_Match.Groups("condicion").Value
                                    sconstante = Me.getConstante(ccontextos, o_Match.Groups("constante").Value)
                                    cnodos = IIf(scondicion.Equals("ESIGUALA"), onodo.Buscar(o_Match.Groups("name").Value, o_Match.Groups("variable").Value, sconstante), onodo.BuscarDiferente(o_Match.Groups("name").Value, o_Match.Groups("variable").Value, sconstante))
                                    sdebug = sdebug & "-------->       NUMERO NODOS QUE CUMPLEN=[" & cnodos.Count & "]" & vbCr
                                    For iitem = 1 To cnodos.Count
                                        Dim ono As Nodo = cnodos.Item(iitem)
                                        ono.addNodoEn(o_Match.Groups("name").Value, New Nodo("<esprimero>" & IIf(iitem = 1, "Si", "No") & "</esprimero>"))
                                        ono.addNodoEn(o_Match.Groups("name").Value, New Nodo("<esultimo>" & IIf(iitem = cnodos.Count, "Si", "No") & "</esultimo>"))
                                        ccontextos.Add(ono)
                                        sresult = sresult & Me.InterpretaA(ipos + 1, ilast - 1, ccontextos)
                                        ccontextos.Remove(ccontextos.Count)
                                    Next
                                    ipos = ilast + 1
                                Else
                                    ipos = ipos + 1
                                End If
                            End If


                        Case "ASIGNA"
                            o_RegExp = New Regex("#ASIGNA\s+(?<constante>=?\w+|=?\w+\.\w+|=?\w+\.\w+\.\w+)\s+AVARIABLE\s+(?<variable>\w+)\s*")
                            o_Matches = o_RegExp.Matches(alineas(ipos))
                            If o_Matches.Count > 0 Then
                                Dim svariable As String
                                Dim sconstante As String
                                o_Match = o_Matches.Item(0)
                                sconstante = Me.getConstante(ccontextos, o_Match.Groups("constante").Value)
                                svariable = o_Match.Groups("variable").Value
                                sdebug = sdebug & "-------->       VARIABLE=[" & svariable & "]" & vbCr
                                sdebug = sdebug & "-------->       CONSTANTE=[" & sconstante & "]" & vbCr
                                Me.AsignaVariable(ccontextos, svariable, sconstante)
                            End If
                            ipos = ipos + 1

                        Case "USANDO"
                            Dim onodo As Nodo
                            Dim cnodos As Collection
                            Dim inumero As Integer

                            ilast = Me.getposfinbloqueinclude("#USANDO", "#FIN USANDO#", ipos, ifin)
                            o_RegExp = New Regex("#USANDO\s+(?<name>\w+)\s+EN\s+(?<coleccion>\w+|\w+\.\w+|\w+\.\w+\.\w+)\s+POSICION\s+(?<numero>\d+)\s*")
                            o_Matches = o_RegExp.Matches(alineas(ipos))
                            If o_Matches.Count > 0 Then
                                o_Match = o_Matches.Item(0)
                                onodo = Me.getPrimerNodo(ccontextos, o_Match.Groups("coleccion").Value)
                                inumero = Integer.Parse(o_Match.Groups("numero").Value)
                                If onodo Is Nothing Then
                                    ipos = ilast + 1
                                    Exit Select
                                End If
                                cnodos = onodo.getNodo(o_Match.Groups("name").Value)
                                sdebug = sdebug & "-------->       NUMERO=[" & inumero & "]" & vbCr
                                sdebug = sdebug & "-------->       TOTAL DE NODOS=[" & cnodos.Count & "]" & vbCr
                                If inumero > cnodos.Count Then
                                    ipos = ilast + 1
                                    Exit Select
                                End If
                                Dim ono As Nodo = cnodos.Item(inumero)
                                ono.addNodoEn(o_Match.Groups("name").Value, New Nodo("<esprimero>" & IIf(iitem = 1, "Si", "No") & "</esprimero>"))
                                ono.addNodoEn(o_Match.Groups("name").Value, New Nodo("<esultimo>" & IIf(iitem = cnodos.Count, "Si", "No") & "</esultimo>"))
                                ccontextos.Add(ono)
                                sresult = sresult & Me.InterpretaA(ipos + 1, ilast - 1, ccontextos)
                                ccontextos.Remove(ccontextos.Count)
                                ipos = ilast + 1
                            End If

                        Case "INCREMENTA"
                            o_RegExp = New Regex("#INCREMENTA\s+(?<constante>=?\w+)\s+AVARIABLE\s+(?<variable>\w+)\s*")
                            o_Matches = o_RegExp.Matches(alineas(ipos))
                            If o_Matches.Count > 0 Then
                                Dim svalor As String
                                Dim sincremento As String
                                Dim inuevo As Integer
                                o_Match = o_Matches.Item(0)
                                sincremento = o_Match.Groups("constante").Value
                                svalor = Me.getValor(ccontextos, o_Match.Groups("variable").Value)
                                inuevo = Integer.Parse(svalor) + Integer.Parse(sincremento)
                                sdebug = sdebug & "-------->       INCREMENTO=[" & sincremento & "]" & vbCr
                                sdebug = sdebug & "-------->       ANTERIOR=[" & svalor & "]" & vbCr
                                sdebug = sdebug & "-------->       NUEVO=[" & inuevo & "]" & vbCr

                                Me.AsignaVariable(ccontextos, o_Match.Groups("variable").Value, inuevo.ToString())
                            End If
                            ipos = ipos + 1

                        Case Else
                            sresult = sresult & InterpretaCodigo(alineas(ipos), ccontextos)
                            ipos = ipos + 1
                    End Select
                Else
                    sresult = sresult & InterpretaCodigo(alineas(ipos), ccontextos)
                    ipos = ipos + 1
                End If
            Loop

        Catch ex As HANYException
            ex.add("MyLIB.MetacodigoReader.InterpretaA()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.MetacodigoReader.InterpretaA()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        Return sresult
    End Function

    ''' <summary>
    ''' Procedimiento para encontra la instrucción final en un rango en particular
    ''' </summary>
    ''' <param name="sinstini">instrucción del bloque de inicio</param>
    ''' <param name="sinstfin">instrucción del bloque de fin</param>
    ''' <param name="iini">inicio</param>
    ''' <param name="ifin">fin</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getposfinbloqueinclude(ByVal sinstini As String, ByVal sinstfin As String, ByVal iini As Integer, ByVal ifin As Integer) As Integer
        Dim ipos As Integer = 0
        Dim inivel As Integer = 0

        Try
            For ipos = iini To ifin
                If alineas(ipos).IndexOf(sinstfin) > -1 And inivel = 1 Then Return ipos
                If alineas(ipos).IndexOf(sinstini) > -1 Then inivel = inivel + 1
                If alineas(ipos).IndexOf(sinstfin) > -1 And inivel > 0 Then inivel = inivel - 1
            Next
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.MetacodigoReader.getposfinbloqueinclude(4)", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        Return 0
    End Function

    ''' <summary>
    ''' Procedimiento para encontra la instrucción final en un rango en particular
    ''' </summary>
    ''' <param name="sinstini">instrucción del bloque de inicio</param>
    ''' <param name="sinstfin">instrucción del bloque de fin</param>
    ''' <param name="iini">inicio</param>
    ''' <param name="ifin">fin</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getposfinbloqueinclude(ByVal sinstini As String, ByVal sinstmed As String, ByVal sinstfin As String, ByVal iini As Integer, ByVal ifin As Integer) As Integer
        Dim ipos As Integer = 0
        Dim inivel As Integer = 0
        Try
            For ipos = iini To ifin
                If alineas(ipos).IndexOf(sinstfin) > -1 And inivel = 0 Then Return ipos
                If alineas(ipos).IndexOf(sinstini) > -1 Then inivel = inivel + 1
                If alineas(ipos).IndexOf(sinstfin) > -1 And inivel > 0 Then inivel = inivel - 1
            Next
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.MetacodigoReader.getposfinbloqueinclude(5)", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        Return 0
    End Function


    ''' <summary>
    ''' Procedimiento para encontra la instrucción final en un rango en particular
    ''' </summary>
    ''' <param name="sinstini">instrucción del bloque de inicio</param>
    ''' <param name="sinstfin">instrucción del bloque de fin</param>
    ''' <param name="iini">inicio</param>
    ''' <param name="ifin">fin</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getposfinbloque1(ByVal sinstini As String, ByVal sinstmed As String, ByVal sinstfin As String, ByVal iini As Integer, ByVal ifin As Integer) As Integer
        Dim ipos As Integer = 0
        Dim inivel As Integer = 0
        Try
            For ipos = iini To ifin
                If alineas(ipos).IndexOf(sinstmed) > -1 And inivel = 1 Then Return ipos
                If alineas(ipos).IndexOf(sinstini) > -1 Then inivel = inivel + 1
                If alineas(ipos).IndexOf(sinstfin) > -1 And inivel > 0 Then inivel = inivel - 1
            Next
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.MetacodigoReader.getposfinbloqueinclude(5)", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        Return 0
    End Function

    ''' <summary>
    ''' Procedimiento para interpretar una linea en particular
    ''' </summary>
    ''' <param name="slinea">contenido de la linea</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Private Function InterpretaCodigo(ByVal slinea As String, ByRef ccontextos As Collection) As String
        Dim o_RegExp As Regex
        Dim o_Matches As MatchCollection
        Dim o_Match As Match
        Dim sres As String = slinea
        Dim svalor As String = ""
        Dim sfuncion As String = ""
        Dim idx As Integer = 0
        Dim spar1 As String
        Dim spar2 As String

        Try
            'PASO 1: Resuelve todo aquello que se trate de una sustitución directa
            o_RegExp = New Regex("#=(?<name>\w+|\w+\.\w+|\w+\.\w+\.\w+|\w+\.\w+\.\w+.\w+)#")
            o_Matches = o_RegExp.Matches(slinea)

            If o_Matches.Count > 0 Then
                For Each o_Match In o_Matches
                    svalor = Me.getValor(ccontextos, o_Match.Groups("name").Value)
                    sres = sres.Replace(o_Match.Value, svalor)
                Next
            End If
            o_Matches = Nothing

            'PASO 2: Resuelve todo aquello que se trate de una sustitución que pasa por función
            o_RegExp = New Regex("#=(?<funcion>\w+)\((?<name>\w+|\w+\.\w+|\w+\.\w+\.\w+|\w+\.\w+\.\w+.\w+)(?<par1>,\w+)?(?<par2>,\w+)?\)#")
            o_Matches = o_RegExp.Matches(slinea)
            If o_Matches.Count > 0 Then
                For Each o_Match In o_Matches
                    sfuncion = o_Match.Groups("funcion").Value.ToLower
                    svalor = Me.getValor(ccontextos, o_Match.Groups("name").Value).Trim
                    If svalor.Equals("") Then svalor = Me.getValor(ccontextos, o_Match.Groups("name").Value).Trim()
                    Select Case sfuncion
                        Case "aminuscula"
                            svalor = svalor.ToLower
                        Case "amayuscula"
                            svalor = svalor.ToUpper
                        Case "trim"
                            svalor = svalor.Trim
                        Case "length"
                            svalor = svalor.Length

                        Case "substring"            'lo necesito para java
                            spar1 = o_Match.Groups("par1").Value
                            spar2 = o_Match.Groups("par2").Value
                            If spar1.Equals("") And spar2.Equals("") Then
                                svalor = "ERROR DE FUNCION"
                                Exit Select
                            End If
                            If spar2.Equals("") Then
                                svalor = svalor.Substring(spar1.Substring(1))
                            Else
                                svalor = svalor.Substring(spar1.Substring(1), spar2.Substring(1))
                            End If
                    End Select

                    If Not svalor.Equals("") Then sres = sres.Replace(o_Match.Value, svalor)
                Next
            End If

            If bmismalinea = True Then
                sres = sres.Trim
                bmismalinea = False
            End If

            'PASO 3: verifica si se trata de preservar la misma linea
            If sres.IndexOf("#_#") > -1 Then
                bmismalinea = True
                sres = sres.Replace("#_#", "")
            End If

            Return sres & IIf(bmismalinea, "", vbCrLf)
        Catch ex As HANYException
            ex.add("MyLIB.MetacodigoReader.InterpretaLinea()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.MetacodigoReader.InterpretaLinea()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Function

    ''' <summary>
    ''' Function para asignar un valor a una variable
    ''' </summary>
    ''' <param name="ccontextos">arreglo de contextos</param>
    ''' <param name="svariable">variable</param>
    ''' <param name="sconstante">su valor constante</param>
    ''' <remarks></remarks>
    Private Function AsignaVariable(ByRef ccontextos As Collection, ByVal svariable As String, ByVal sconstante As String) As String
        Dim idx As Integer
        Dim bexiste As Boolean
        Dim oxmlcontext As Nodo

        Try
            'PASO 1: Asigna los valores
            bexiste = False
            oxmlcontext = Nothing

            'PASO 2: Recorre los contextos (iniciando del ultimo) para encontrar la existencia de la variable
            For idx = ccontextos.Count To 1 Step -1
                oxmlcontext = ccontextos.Item(idx)
                If oxmlcontext.ExistNodo(svariable) Then
                    bexiste = True
                    Exit For
                End If
            Next

            'PASO 3: Si la variable no exite, entonces la integro pero sobre el último contexto
            If Not bexiste Then
                oxmlcontext = ccontextos.Item(ccontextos.Count)
                oxmlcontext.addNodoNuevo(New Nodo("<" & svariable & ">" & sconstante & "</" & svariable & ">"))
            Else
                oxmlcontext.updNodoValor(svariable, sconstante)
            End If

        Catch ex As HANYException
            ex.add("MyLIB.MetacodigoReader.AsignaVariable()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.MetacodigoReader.AsignaVariable()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        Return svariable
    End Function

    ''' <summary>
    ''' Función para consultar el valor de una propiedad particular dentro de los distintos contextos
    ''' </summary>
    ''' <param name="ccontextos">Colección de contextos</param>
    ''' <param name="spropiedad">Nombre de la propiedad</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Private Function getValor(ByRef ccontextos As Collection, ByVal spropiedad As String) As String
        Dim idx As Integer
        Dim sresult As String = ""

        Try
            For idx = ccontextos.Count To 1 Step -1
                Dim oxml As Nodo = ccontextos.Item(idx)
                sresult = oxml.getValue(spropiedad).Trim
                If Not sresult.Equals("") Then Exit For
            Next
        Catch ex As HANYException
            ex.add("MyLIB.MetacodigoReader.getValor(col, prop)", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.MetacodigoReader.getValor(col, prop)", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
        Return sresult
    End Function

    ''' <summary>
    ''' Función para consultar un valor constante 
    ''' </summary>
    ''' <param name="ccontextos">Contextos de variables</param>
    ''' <param name="spropiedad">Nombre de la propiedad</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Private Function getConstante(ByRef ccontextos As Collection, ByVal spropiedad As String) As String
        Dim stmp As String = spropiedad.Trim()
        Dim sresult As String = stmp

        Try
            If stmp.StartsWith("=") Then sresult = Me.getValor(ccontextos, stmp.Substring(1))
            If stmp.Equals(Comun.STR_XML_VALOR_VACIO) Then sresult = ""
        Catch ex As HANYException
            ex.add("MyLIB.MetacodigoReader.getConstante()", "Ocurrio un error")
            Throw ex
        End Try
        Return sresult
    End Function

    Private Function getPrimerNodo(ByRef ccontextos As Collection, ByVal spropiedad As String) As Nodo
        Dim idx As Integer
        Dim onodo As Nodo = Nothing

        Try
            For idx = ccontextos.Count To 1 Step -1
                Dim oxml As Nodo = ccontextos.Item(idx)
                onodo = oxml.getPrimerNodo(spropiedad)
                If Not onodo Is Nothing Then Exit For
            Next
        Catch ex As HANYException
            ex.add("MyLIB.MetacodigoReader.getPrimerNodo()", "Ocurrio un error")
            Throw ex
        End Try

        Return onodo
    End Function

    ''' <summary>
    ''' Procedimiento para asignar un valor xml 
    ''' </summary>
    ''' <param name="sxml"></param>
    ''' <remarks></remarks>
    Public Sub SetXML(ByVal sxml As String)
        If sxml Is Nothing Then
            oxmlmain = New Nodo()
        End If
        oxmlmain.SetXML(sxml)
    End Sub

    ''' <summary>
    ''' Función para regresar el valor de xml
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetXML() As String
        Return oxmlmain.GetXML()
    End Function

End Class   'fin clase [MetacodigoReader] 
