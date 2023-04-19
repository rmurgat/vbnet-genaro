Imports Microsoft.Office.Interop
Imports System.Security.Cryptography
Imports System.IO
Imports System.Windows.Forms

''' <summary>
''' Clase que tiene los metodos utilizados dentro del sistema de PSIQUE
''' </summary>
''' <autor>
''' Rubén Murga Tapia (1-Abril-2008)
''' </autor>
''' <remarks></remarks>
Public Class Utilerias
    Private sBuffer As String ' Para usarla en las funciones GetSection(s)
    Private Declare Function GetPrivateProfileSection Lib "kernel32" Alias "GetPrivateProfileSectionA" (ByVal lpAppName As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    Public Function LeeINI(ByVal Archivo As String, ByVal Seccion As String, ByVal Clave As String) As String
        Dim iRetLen As Integer
        Dim sRet As String
        sRet = Space(255)
        iRetLen = GetPrivateProfileString(Seccion, Clave, "", sRet, Len(sRet), Archivo)
        sRet = Left(sRet, iRetLen)
        LeeINI = sRet
    End Function

    Public Function IniGetSection(ByVal sFileName As String, ByVal sSection As String) As String()
        Dim aSeccion() As String
        Dim n As Integer

        Try
            ReDim aSeccion(0)
            sBuffer = New String(ChrW(0), 32767)         ' El tamaño máximo para Windows 95
            n = GetPrivateProfileSection(sSection, sBuffer, sBuffer.Length, sFileName)
            If n > 0 Then
                sBuffer = sBuffer.Substring(0, n - 2).TrimEnd()
                aSeccion = sBuffer.Split(New Char() {ChrW(0)})
            End If
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Utilerias.IniGetSection()", "Ocurrio un error al leer el archivo .ini")
        End Try

        Return aSeccion
    End Function

    '--------------------------------------------------------------------------------
    ' DESCRIPCIóN:
    '   Función que se encarga de validar la ruta de acceso de cierto archivo.
    '--------------------------------------------------------------------------------
    Public Function Existe_Archivo(ByVal psArchivo As String) As Boolean
        Dim sValida As String       'cadena con la que se define la existencia del archivo

        Existe_Archivo = False

        sValida = Dir(Trim$(psArchivo), vbDirectory)   'valido si existe la ruta señalada

        'si no trajo nada, entonces es un directorio invalido
        If Trim$(sValida) = vbNullString Then
            Return False
            Exit Function
        End If

        Return True
    End Function

    '----------------------------------------------------------------------------
    '  Descripción:
    '    Cuenta los tokens que se encuentran en una expresión
    '
    '  Parámetros:
    '    psExpresion     --> Expresión que contiene los tokens a contar
    '
    '  Ejemplo:
    '    iNumTokensFormats = Cuenta_Tokens("24655, 45625, 462016", ",")
    '
    '  Responsable:
    '    Rubén Murga Tapia    05/Jun/1997
    '----------------------------------------------------------------------------
    Public Function Cuenta_Tokens(ByVal psExpresion As String, ByVal psSeparador As String) As Integer
        Dim iPosCar As Integer          'posicion actual en la expresión
        Dim iNumTokens As Integer       'número de tokens en la expresión

        If psExpresion = vbNullString Then Exit Function 'si la expresión no tiene nada se sale

        'inicializo variables...
        Cuenta_Tokens = 0
        iNumTokens = 0

        'recorro los caracteres...
        For iPosCar = 1 To Len(psExpresion)
            If LCase(Mid$(psExpresion, iPosCar, Len(psSeparador))) = LCase(psSeparador) Then iNumTokens = iNumTokens + 1
        Next

        Cuenta_Tokens = iNumTokens + 1

    End Function

    '-----------------------------------------------------------------------------
    ' Descripción:
    '   Toma el token que se haya elejido
    '
    ' Parámetros:
    '   iNumTokens    --> Número de token en el sistema
    '   pszExpresion  --> Expresión que contiene los tokens
    '   pszCaracater  --> Caracater que divide los tokens
    '
    ' Ejemplo:
    '   Formato1 = Toma_Token(1, "#########, 000000000" , ",")
    '
    ' Responsable:
    '   Rubén Murga Tapia    05/jun/1997
    '-----------------------------------------------------------------------------
    Public Function Toma_Token(ByVal iNumToken As Integer, ByVal pszExpresion As String, ByVal pszCaracter As String) As String
        Dim pszArrToken() As String = Nothing
        Dim iNumValores As Integer

        Try

            Toma_Token = vbNullString
            iNumValores = Aparta_Tokens(pszExpresion, pszArrToken, pszCaracter)
            If iNumToken > iNumValores Then Exit Function
            Toma_Token = pszArrToken(iNumToken)

        Catch ex As HANYException
            ex.add("MyLIB.Utilerias.Toma_Token()", "Ocurrio un error al tomar el token")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Utilerias.Toma_Token()", "Ocurrio un error al tomar el token [" & ex1.ToString & "]")
        End Try
    End Function

    '----------------------------------------------------------------------------
    ' Descripción:
    '   Reune los diferentes token en una expresion, y la regresa al usuario
    '
    ' Parámetros:
    '   pszarrTokens() --> Arreglo de los tokens
    '   pszDelimitador --> delimitador entre los tokens
    '
    ' Ejemplo:
    '   pszExpresion = Reune_Tokens(pszarrValores(),"|")
    '
    ' Responsable:
    '   Rubén Murga Tapia   28/May/1997
    '----------------------------------------------------------------------------
    Public Function Reune_Tokens(ByVal pszarrTokens() As String, ByVal pszDelimitador As String) As String
        Dim iIdxArr As Integer            'Indice del arreglo
        Dim iIdxMaxArr As Integer         'Maximo para el arreglo
        Dim pszExpres As String           'Expresión

        Try
            'inicializo...
            Reune_Tokens = vbNullString        'Inicializa la función
            pszExpres = vbNullString           'Inicializa la expresión que regresa
            'En caso de que no tenga delimitador se le coloca una ',' coma
            If pszDelimitador = vbNullString Then
                pszDelimitador = ","
            End If
            iIdxMaxArr = UBound(pszarrTokens) 'Número de posiciones
            pszExpres = pszarrTokens(1)       'Inicializa con la posicion 1
            iIdxArr = 2                       'Indice del arreglo en posición 2
            If iIdxMaxArr > 1 Then
                Do
                    pszExpres = pszExpres & pszDelimitador & pszarrTokens(iIdxArr)
                    iIdxArr = iIdxArr + 1
                Loop Until iIdxArr > iIdxMaxArr
            End If
        Catch ex As HANYException
            ex.add("MyLIB.Utilerias.Reune_Tokens()", "Ocurrio un error al reunir tokens")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Utilerias.Reune_Tokens()", "Ocurrio un error al reunir tokens [" & ex1.ToString & "]")
        End Try

        Reune_Tokens = pszExpres
    End Function

    '----------------------------------------------------------------------------
    '  Descripción:
    '    Quita el token de una cadena de tokens.
    '
    '  Parámetros:
    '    iNumToken    -->  Número de token en la expresión.
    '    pszExpresion -->  Expresión que contiene los tokens.
    '
    '  Ejemplo:
    '    Expresion = Quita_Token(1, "25462246, 4624652, 26462", ",")
    '
    '  Responsable:
    '    Rúben Murga Tapia       05/Jun/1997
    '----------------------------------------------------------------------------
    Public Function Quita_Token(ByVal iNumToken As Integer, ByVal pszExpresion As String, ByVal pszCaracter As String) As String

        Dim iNumValores As Integer      'número de tokens
        Dim pszArrToken() As String     'arreglo que contendran los tokens
        Dim pszCadena As String         'cadena armada con los tokens
        Dim iIdxArr As Integer          'indice para recorrer el arreglo

        Try
            'inicializo...
            Quita_Token = vbNullString
            pszCadena = vbNullString
            pszArrToken = Nothing

            'aparto primero los tokens
            iNumValores = Aparta_Tokens(pszExpresion, pszArrToken, pszCaracter)

            'si el token que se quiere no existe, me salgo...
            If iNumToken > iNumValores Then Exit Function

            'otravez armo la expresión, pero sin el token que me pidieron...
            For iIdxArr = 1 To iNumValores
                If iIdxArr <> iNumToken Then pszCadena = Anade_Token(pszCadena, pszArrToken(iIdxArr), pszCaracter)
            Next

        Catch ex As HANYException
            ex.add("MyLIB.Utileria.Quita_Token()", "Ocurrio un error al consultar las empresas")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Utileria.Quita_Token()", "Ocurrio un error al consultar las empresas [" & ex1.ToString & "]")
        End Try

        Quita_Token = pszCadena   'regresa la nueva expresión
    End Function

    '----------------------------------------------------------------------------
    ' Descripción:
    '   Aparta los tokens de una cadena formada por elementos:
    '   La cadena pueden conteneter
    '     Nada
    '     Un Elemento
    '     2 o Mas elementos separados por un delimitador
    '
    ' Parámetros:
    '   pszExpresión   --> Cadena que contiene los tokens separados por un delimitador
    '   psArrToken()  --> Arreglo dinamico donde se colocaran los tokens
    '   psDelimitador --> Caracter delimitador para los tokens
    '                      si se trata de vbNullString, por default es ',' la coma
    '
    ' Regresa:
    '   0,  No existen valores
    '   >0, Número de valores leidos en la cadana
    '
    ' Ejemplo:
    '   iNumValores = Aparta_Tokens("1,2,3,4",pszarrPresupuestos(), vbNullString)
    '   iNumValores = Aparta_Tokens("1,2,3,4",pszarrPresupuestos(), "|")
    '
    ' Responsable:
    '   Rubén Murga Tapia    28/May/1997
    '
    ' Observaciones:
    '   Los valores los empieza a regresar desde la posición 1 en adelante,
    '   en caso de que el arreglo sea UBound(varrToken) = 0 entonces
    '   no se encontro información en la expresión.
    '
    '  Responsable:
    '    Rubén Murga Tapia      5/Jun/19897
    '-----------------------------------------------------------------------------
    Public Function Aparta_Tokens(ByRef psExpresion As String, ByRef psArrToken() As String, ByVal psDelimitador As String) As Integer

        Dim iNumToken As Integer      'Número de tokens, número de elemento
        Dim iIniToken As Integer      'Posición del inicio del token
        Dim iLonExpre As Integer      'Longitud de la expresión
        Dim iPosDelim As Integer      'Posición donde se encuentra el delimitador

        Try
            Aparta_Tokens = 0  'Inicializa el valor que regresa

            'En caso de estar vacia la expresión se sale...
            If Trim$(psExpresion) = vbNullString Then Exit Function

            'Inicializa el arreglo para los tokens apartados
            ReDim psArrToken(0)

            'En caso de no tener delimitador, coloca uno por default
            If psDelimitador = vbNullString Then
                psDelimitador = ","
            End If

            iIniToken = 1                  'Desde donde inicia el token
            iNumToken = 1                  'Número de tokens en la expresión
            iLonExpre = Len(psExpresion)   'Longitud de token

            'Busca la primera posición del delimitador
            iPosDelim = InStr(iIniToken, psExpresion, psDelimitador)

            While iPosDelim > 0
                ReDim Preserve psArrToken(iNumToken)  'Redimensiona el arreglo del token
                'Asigna a la posición el token extraido
                psArrToken(iNumToken) = Trim$(Mid$(psExpresion, iIniToken, iPosDelim - iIniToken))
                iIniToken = iPosDelim + Len(Trim$(psDelimitador)) 'Define la posición inicial del token otra vez
                iPosDelim = InStr(iIniToken, psExpresion, psDelimitador)
                iNumToken = iNumToken + 1 'Incrementa el número de tokens encontrados
            End While
            'Extrae el unico ó ultimo token de la expresión
            ReDim Preserve psArrToken(iNumToken)
            psArrToken(iNumToken) = Mid$(psExpresion, iIniToken, iLonExpre)

        Catch ex As HANYException
            ex.add("MyLIB.Utilerias.Aparta_Tokens()", "Ocurrio un error al apartar TOKENS")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Utilerias.Aparta_Tokens()", "Ocurrio un error al apartar TOKENS [" & ex1.ToString & "]")
        End Try

        Aparta_Tokens = iNumToken
    End Function

    ''' <summary>
    ''' Función para apartar los tokens de una cadena formada por elementos
    ''' </summary>
    ''' <param name="psExpresion">expresión de tokens</param>
    ''' <param name="psDelimitador">carácter delimitador si se trata de vbNullString, por default es ',' la coma</param>
    ''' <returns>Collection</returns>
    ''' <remarks>
    ''' Ejemplo:
    '''     Dim cValores As Collection = CAparta_Tokens("1,2,3,4", vbNullString)
    '''     Dim cValores As Collection = CAparta_Tokens("1,2,3,4", "|")
    ''' Autor:
    '''     Rubén Murga Tapia    28/May/1997
    '''     Rubén Murga Tapia    21/Jun/2008  - manejo de objeto collection
    ''' Observaciones:
    '''     Los valores los empieza a regresar desde la posición 1 en adelante,
    '''     en caso de que el arreglo sea UBound(varrToken) = 0 entonces
    '''     no se encontro información en la expresión.
    ''' </remarks>
    Public Function CAparta_Tokens(ByRef psExpresion As String, ByVal psDelimitador As String) As Collection
        Dim crespuesta As Collection
        Dim iNumToken As Integer      'Número de tokens, número de elemento
        Dim iIniToken As Integer      'Posición del inicio del token
        Dim iLonExpre As Integer      'Longitud de la expresión
        Dim iPosDelim As Integer      'Posición donde se encuentra el delimitador

        Try
            'PASO 1: Inicializa la colección
            crespuesta = New Collection

            'PASO 2: En caso de estar vacia la expresión se sale...
            If Trim$(psExpresion) = vbNullString Then
                Return crespuesta
            End If

            'PASO 3: En caso de no tener delimitador, coloca uno por default
            If psDelimitador = vbNullString Then
                psDelimitador = ","
            End If

            iIniToken = 1                  'Desde donde inicia el token
            iNumToken = 1                  'Número de tokens en la expresión
            iLonExpre = Len(psExpresion)   'Longitud de token

            'Busca la primera posición del delimitador
            iPosDelim = InStr(iIniToken, psExpresion, psDelimitador)

            While iPosDelim > 0
                'Asigna a la posición el token extraido
                crespuesta.Add(Trim$(Mid$(psExpresion, iIniToken, iPosDelim - iIniToken)))
                iIniToken = iPosDelim + Len(Trim$(psDelimitador)) 'Define la posición inicial del token otra vez
                iPosDelim = InStr(iIniToken, psExpresion, psDelimitador)
                iNumToken = iNumToken + 1 'Incrementa el número de tokens encontrados
            End While
            'Extrae el unico ó ultimo token de la expresión
            crespuesta.Add(Trim$(Mid$(psExpresion, iIniToken, iLonExpre)))

        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Utilerias.CAparta_Tokens()", "Ocurrio un error al consultar las empresas [" & ex1.ToString & "]")
        End Try

        Return crespuesta
    End Function

    '-----------------------------------------------------------------------------
    '  Descripción:
    '    Añade un token a una cadena
    '
    '  Parámetro:
    '    pszExpresión    -->  Expresión que contendra los tokens
    '    psToken        -->  Token que se adicionara
    '    psDelimitador     -->  caracter que los divide
    '
    '  Ejemplo:
    '    Expresion = Anade_Token ("546562, 65465265, 656546", "654654", ",")
    '
    '  Responsable:
    '    Rubén Murga Tapia      5/Jun/19897
    '
    '-----------------------------------------------------------------------------
    Public Function Anade_Token(ByVal psExpresion As String, ByVal psToken As String, ByVal psDelimitador As String) As String

        Try
            'Inicializo la función
            Anade_Token = vbNullString

            'Valido que sea factible el proceso, sino me salgo...
            If psToken = vbNullString Then
                Anade_Token = psExpresion
                Exit Function
            End If

            'Si encuentro el Caracter(es) de distinción entre tokens, entonces le sumo otro y la expresión
            If Trim$(psExpresion) = vbNullString Then
                Anade_Token = psExpresion & psToken
            Else
                Anade_Token = psExpresion & psDelimitador & psToken
            End If
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Utilerias.Anade_Token()", "Ocurrio un error al consultar las empresas [" & ex1.ToString & "]")
        End Try

    End Function

    '----------------------------------------------------------------------------
    ' DescriIdxCadpción:
    '   De una cadena que se le envía, devuelve la misma cadena
    '   pero antes le quita todas las ocurrencias de <psCaracter>
    '   que existan (si es que existen)
    '
    ' Parámetros:
    '   psCadena --> String a la que se quiere quitar blancos
    '   psCaracter-> sCaracter que se ha de eliminar de la Cadena
    '
    ' Resultado:
    '   Devuelve la misma cadena sin el psCaracter
    '
    ' Ejemplo: "Quita todos los blancos de una cadena" pero puede quitar
    '          también todas las Arrobas o Amperson o lo que sea.
    '   pszarrCvePres(iCvePptals) = Quita_Caracter((vgblDatoLeidoSS), " ")
    '
    'Responsable:
    '----------------------------------------------------------------------------
    Function Quita_Caracter(ByVal psCadena As String, ByVal saquitar As String) As String
        Dim iIdxCad As Integer          'indice para recorrer la cadena
        Dim sCadena As String           'cadena

        If psCadena = vbNullString Then Return ""

        'inicializo...
        Quita_Caracter = vbNullString
        sCadena = ""

        'recorre la cadena...
        For iIdxCad = 1 To Len(psCadena)
            Dim ccar As String = psCadena.Substring(iIdxCad - 1, 1)
            If saquitar.IndexOf(ccar) < 0 Then sCadena = sCadena & ccar
        Next

        'concluyo...
        Quita_Caracter = sCadena
    End Function

    ''' <summary>
    ''' Procedimiento para remplazar un caracter
    ''' </summary>
    ''' <param name="psCadena">cadena original</param>
    ''' <param name="saquitar">caracteres que se van a remplazar</param>
    ''' <param name="snuevo">nuevo caracter</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Remplaza_Caracter(ByVal psCadena As String, ByVal saquitar As String, ByVal snuevo As String) As String
        Dim iIdxCad As Integer          'indice para recorrer la cadena
        Dim sCadena As String           'cadena

        If psCadena = vbNullString Then Return ""

        'inicializo...
        Remplaza_Caracter = vbNullString
        sCadena = ""

        'recorre la cadena...
        For iIdxCad = 1 To Len(psCadena)
            Dim ccar As String = psCadena.Substring(iIdxCad - 1, 1)
            If saquitar.IndexOf(ccar) >= 0 Then
                sCadena = sCadena & snuevo
            Else
                sCadena = sCadena & ccar
            End If
        Next

        'concluyo...
        Remplaza_Caracter = sCadena
    End Function

    ''' <summary>
    ''' Función para obtener la cadena que se encuentra entre scad1 y scad2
    ''' </summary>
    ''' <param name="ssource">Cadena original</param>
    ''' <param name="scad1">Primer cadena a buscar</param>
    ''' <param name="scad2">Segunda cadena a buscar</param>
    ''' <returns>cadena resultante</returns>
    ''' <remarks></remarks>
    Public Function ObtenCadenaBetween(ByRef ssource As String, ByVal scad1 As String, ByVal scad2 As String) As String
        Dim ipos1 As Integer
        Dim ipos2 As Integer
        Dim inewpos1 As Integer
        Dim sholdstr As String = ""

        ipos1 = InStr(ssource, scad1)
        If ipos1 > 0 Then
            ipos2 = InStr(ssource, scad2)
        End If
        If ipos1 > 0 And ipos2 > 0 Then
            inewpos1 = ipos1 + Len(scad1)
            sholdstr = New String(Mid(ssource, inewpos1, ipos2 - inewpos1))
        End If

        Return sholdstr
    End Function

    ''' <summary>
    ''' Función para buscar un texto en un documento word y substituir todos sus valores
    ''' </summary>
    ''' <param name="Documento">objeto con el documento</param>
    ''' <param name="sbuscar">texto a buscar</param>
    ''' <param name="snuevo">nuevo texto a incluir</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function findyreplace(ByRef Documento As Object, ByVal sbuscar As String, ByVal snuevo As String) As Boolean

        Try
            ' Busca la cadena dentro del documento DOC   
            With Documento.ActiveWindow.Selection.Find
                .ClearFormatting()
                .Text = sbuscar
                .Replacement.Text = snuevo
                .Forward = True
                .Wrap = Word.WdFindWrap.wdFindContinue
                .Format = False
                .MatchCase = False
                .MatchWholeWord = False
                .MatchWildcards = False
                .MatchSoundsLike = False
                .MatchAllWordForms = False
                .Execute() 'ejecuta la búsqueda   
            End With

            With Documento.ActiveWindow.Selection
                If .Find.Forward = True Then
                    .Collapse(Direction:=Word.WdCollapseDirection.wdCollapseStart)
                Else
                    .Collapse(Direction:=Word.WdCollapseDirection.wdCollapseEnd)
                End If
                .Find.Execute(Replace:=Word.WdReplace.wdReplaceAll)
                If .Find.Forward = True Then
                    .Collapse(Direction:=Word.WdCollapseDirection.wdCollapseEnd)
                Else
                    .Collapse(Direction:=Word.WdCollapseDirection.wdCollapseStart)
                End If
                .Find.Execute()
            End With

        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Utilerias.findyreplace()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Function

    ''' <summary>
    ''' Functión para encontrar la posición donde se encuentra un texto dentro de un documento
    ''' </summary>
    ''' <param name="Documento">objeto tipo documento donde se buscará el texto</param>
    ''' <param name="sbuscar">texto a buscar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function findpos(ByRef Documento As Object, ByVal sbuscar As String) As Boolean
        Dim ipos As Integer = 0

        'PASO 1: Busqueda del texto en documento 
        Try

            ' Busca la cadena dentro del documento DOC   
            With Documento.ActiveWindow.Selection.Find
                .ClearFormatting()
                .Text = sbuscar
                .Replacement.Text = ""
                .Forward = True
                .Wrap = Word.WdFindWrap.wdFindContinue
                .Format = False
                .MatchCase = False
                .MatchWholeWord = False
                .MatchWildcards = False
                .MatchSoundsLike = False
                .MatchAllWordForms = False
                .Execute() 'ejecuta la búsqueda   
            End With

            If Not Documento.ActiveWindow.Selection.Find.Found Then
                Return False
            End If

        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Utilerias.findpos()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        Return True
    End Function

    ''' <summary>
    ''' Regresa el listado de todos los archivos que se encuentran en el directorio actual y sus subdirectorios
    ''' </summary>
    ''' <param name="sdirectorio">clave del subdirectorio</param>
    ''' <param name="bversubdirs">bandera para ver subdirectorios</param>
    ''' <param name="spatron">patron de los archivos</param>
    ''' <returns>Colección de nombres de archivos</returns>
    ''' <remarks></remarks>
    Public Function Leer_Directorio(ByVal sdirectorio As String, ByVal bversubdirs As Boolean, ByVal spatron As String) As Collection
        Dim sarchivo, scarpeta As String
        Dim sarchivos(), scarpetas() As String
        Dim archivoInfo As FileInfo
        Dim cres As Collection

        Try
            'PASO 1: Inicializa los valores
            cres = New Collection

            'PASO 2: Lectura de los archivos y carpetas
            sarchivos = Directory.GetFiles(sdirectorio)
            scarpetas = Directory.GetDirectories(sdirectorio)

            'PASO 3: Recorre el arreglo de archivos leidos del directorio actual
            For Each sarchivo In sarchivos
                archivoInfo = New FileInfo(sarchivo)
                If archivoInfo.Name.ToLower.IndexOf(spatron.ToLower) > 0 Then
                    cres.Add(archivoInfo)
                End If
            Next

            'PASO 4: Recorre el arreglo de carpetas leidas del directorio e incorpora archivos en subdirectorios
            If bversubdirs Then
                For Each scarpeta In scarpetas
                    Dim csubres As Collection = Leer_Directorio(scarpeta, True, spatron)
                    For Each archivoInfo In csubres
                        If archivoInfo.Name.ToLower.IndexOf(spatron.ToLower) > 0 Then
                            cres.Add(archivoInfo)
                        End If
                    Next
                Next
            End If

        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Utilerias.Leer_Directorio()", "Ocurrio un error al leer el directorio [" & ex1.ToString & "]")
        End Try

        'PASO 5: Regresa el resultado 
        Return cres

    End Function


    ''' <summary>
    ''' Procedimiento para consultar todo el texto que se encuentra entre dos cadenas (incluyendolas)
    ''' </summary>
    ''' <param name="sorigen">Cadena de origen</param>
    ''' <param name="scad1">Cadena no.1</param>
    ''' <param name="scad2">Cadena no.2</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function getStrBetweenInclude(ByVal sorigen As String, ByVal scad1 As String, ByVal scad2 As String) As String
        Dim iini As Integer = 0
        Dim ifin As Integer = 0

        Try
            iini = sorigen.IndexOf(scad1)
            ifin = sorigen.IndexOf(scad2, iini)
            If ifin < 0 Then Return ""
        Catch ex As Exception
            Return ""
        End Try
        Return sorigen.Substring(iini, (ifin - iini) + scad2.Length)
    End Function

    ''' <summary>
    ''' Procedimiento para consultar todo el texto que se encuentra entre dos cadenas (sin incluirlas)
    ''' </summary>
    ''' <param name="sorigen">Cadena de origen</param>
    ''' <param name="scad1">Cadena no.1</param>
    ''' <param name="scad2">Cadena no.2</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function getStrBetween(ByVal sorigen As String, ByVal scad1 As String, ByVal scad2 As String) As String
        Try
            Dim iini As Integer = sorigen.IndexOf(scad1)
            If iini < 0 Then Return ""
            Dim ifin As Integer = sorigen.IndexOf(scad2, iini)
            If ifin < 0 Then Return ""
            Return sorigen.Substring(iini + scad1.Length(), (ifin - (iini + scad1.Length)))
        Catch ex As Exception
            Throw New HANYException("MyLIB.Utilerias.getStrBetween()", "Ocurrio un error [" & ex.ToString & "]")
        End Try
    End Function

    ''' <summary>
    ''' Función para consultar la ultima posición de la siguiente cadena, iniciando a partir del indice 
    ''' del 2do parámetro
    ''' </summary>
    ''' <param name="scontenido">contenido donde buscar</param>
    ''' <param name="stofind">cadena a buscar</param>
    ''' <param name="idxStart">inicio</param>
    ''' <returns>Integer</returns>
    ''' <remarks></remarks>
    Public Function getLastPosNextString(ByRef scontenido As String, ByVal stofind As String, ByVal idxStart As Integer) As Integer
        Dim ipos As Integer
        Try
            ipos = scontenido.IndexOf(stofind, idxStart, System.StringComparison.OrdinalIgnoreCase)
        Catch ex As Exception
            Throw New HANYException("MyLIB.Utilerias.getStrBetween()", "Ocurrio un error [" & ex.ToString & "]")
        End Try
        Return ipos + stofind.Length
    End Function

    ''' <summary>
    ''' Procedimiento para encriptar con el metodo de MD5
    ''' </summary>
    ''' <param name="str">Cadena para Encriptar</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function MD5Encrypt(ByVal str As String) As String
        Dim md5 As MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim strOutput As String = Nothing
        Dim i As Integer

        Try
            ' Create New Crypto Service Provider Object
            md5 = New MD5CryptoServiceProvider

            ' Convert the original string to array of Bytes
            bytValue = System.Text.Encoding.UTF8.GetBytes(str)

            ' Compute the Hash, returns an array of Bytes
            bytHash = md5.ComputeHash(bytValue)
            md5.Clear()

            For i = 0 To bytHash.Length - 1
                'don't lose the leading 0
                strOutput &= bytHash(i).ToString("x").PadLeft(2, "0")
            Next

            MD5Encrypt = strOutput
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Utilerias.MD5Encrypt()", "Error al encryptar cadena [" & ex1.ToString & "]")
        End Try

    End Function

    ''' <summary>
    ''' Utileria para agregar un mensaje al debug de una lista
    ''' </summary>
    ''' <param name="olist">objeto tipo lista</param>
    ''' <param name="smensaje">mensaje para agregar</param>
    ''' <remarks></remarks>
    Public Sub addToListDebug(ByRef olist As ListBox, ByRef smensaje As String)
        Try
            olist.Items.Add(smensaje)
            olist.TopIndex = olist.Items.Count - 1
            olist.Refresh()
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Utilerias.addToListDebug()", "Error al agregar un elemento [" & ex1.ToString & "]")
        End Try

    End Sub

    ''' <summary>
    ''' Procedimiento para preveer la información en un editor
    ''' </summary>
    ''' <param name="stexto"></param>
    ''' <remarks></remarks>
    Public Sub Preveer(ByVal stexto As String)
        Me.Preveer("", stexto)
    End Sub

    ''' <summary>
    ''' Procedimiento para preveer la información en un editor
    ''' </summary>
    ''' <param name="stexto"></param>
    ''' <remarks></remarks>
    Public Sub Preveer(ByVal stitulo As String, ByVal stexto As String)
        Dim ofrm As frmeditor

        ofrm = New frmeditor()
        ofrm.Text = stitulo
        ofrm.rtbeditor.Text = stexto
        ofrm.Show()
    End Sub

    ''' <summary>
    ''' Procedimiento para visualizar una pantalla con el track de la excepción que sucedio
    ''' </summary>
    ''' <param name="oex">Objeto de excepciones</param>
    ''' <remarks></remarks>
    Public Sub ShowException(ByRef oex As HANYException)
        Dim ofrm As frmException
        ofrm = New frmException()
        ofrm.Cursor = Cursors.Default
        ofrm.txtexception.Text = oex.getstackString
        ofrm.ShowDialog()
    End Sub

    ''' <summary>
    ''' Procedimiento para listar entre varias opciones y seleccionar una de ellas
    ''' </summary>
    ''' <param name="slist">Lista de opciones</param>
    ''' <remarks></remarks>
    Public Function SelectOne(ByVal slist As String) As String
        Return SelectOne("SELECCIONA UNA OPCION", slist)
    End Function

    ''' <summary>
    ''' Procedimiento para listar entre varias opciones y seleccionar una de ellas
    ''' </summary>
    ''' <param name="stitulo">Titulo de la pantalla</param>
    ''' <param name="slist">Lista de opciones</param>
    ''' <remarks></remarks>
    Public Function SelectOne(ByVal stitulo As String, ByVal slist As String) As String
        Dim ofrm As frmListSelectOne

        ofrm = New frmListSelectOne()
        ofrm.Text = stitulo
        ofrm.opciones = slist
        ofrm.ShowDialog()
        If ofrm.result.Equals("CANCEL") Then Return "CANCEL"
        Return ofrm.result
    End Function

    ''' <summary>
    ''' Función para remplazar un pedazo de cadena desde una posición inicia y hasta la final.
    ''' </summary>
    ''' <param name="soriginal">Cadena original</param>
    ''' <param name="iidxini">posición inicial</param>
    ''' <param name="iidxfin">posición final</param>
    ''' <param name="ssegmento">cadena a sustituir</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function ReplaceString(ByVal soriginal As String, ByVal iidxini As Integer, ByVal iidxfin As Integer, ByVal ssegmento As String) As String
        Dim santerior As String
        Dim sposterior As String

        santerior = soriginal.Substring(0, iidxini)
        sposterior = soriginal.Substring(iidxfin)
        Return New String(santerior & ssegmento & sposterior)
    End Function

    ''' <summary>
    ''' Función para escribir el contenido de un archivo
    ''' </summary>
    ''' <param name="snombre">Nombre del archivo</param>
    ''' <param name="scontenido">Contenido del archivo</param>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Function EscribeNuevoArchivo(ByVal snombre As String, ByVal scontenido As String) As Boolean

        'PASO 1: Valida y escribe el archivo
        Try
            If Me.Existe_Archivo(snombre) Then Return False
            My.Computer.FileSystem.WriteAllText(snombre, scontenido, False, System.Text.Encoding.GetEncoding(28593))
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.Utilerias.EscribeNuevoArchivo()", "Ocurrio un error al escribir el archivo [" & ex1.ToString & "]")
        End Try
        Return True
    End Function

    ''' <summary>
    ''' Función para rellenar con espacios una cadena
    ''' </summary>
    ''' <param name="scad">Cadena original</param>
    ''' <param name="ilen">Longitud</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function RefillSpaces(ByVal scad As String, ByVal ilen As Integer) As String
        Dim sres As String
        sres = scad & New String(" ", ilen)
        Return sres.Substring(0, ilen)
    End Function

    ''' <summary>
    ''' Función para rellenar con ceros a la izquiera un número
    ''' </summary>
    ''' <param name="inum">número</param>
    ''' <param name="ilen">longitud</param>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function RefillCeros(ByVal inum As Integer, ByVal ilen As Integer) As String
        Dim sres As String
        sres = New String("0", ilen) & inum.ToString
        Return sres.Substring(sres.Length() - ilen)
    End Function

    ''' <summary>
    ''' Función para quitar los carácteres especiales como acentos y ñ
    ''' </summary>
    ''' <param name="str">cadena a procesar</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Quitar_Especiales(ByRef str As String)

        Dim sresult As String
        Dim idx As Integer          'indice para recorrer la cadena

        'PASO 1: Inicializa...
        sresult = ""
        If str = vbNullString Then Return ""

        'PASO 2: recorre la cadena...
        For idx = 1 To Len(str)
            Dim ccar As String = str.Substring(idx - 1, 1)
            Select Case ccar
                Case "á"
                    sresult = sresult & "a"
                Case "Á"
                    sresult = sresult & "A"
                Case "é"
                    sresult = sresult & "e"
                Case "É"
                    sresult = sresult & "E"
                Case "í"
                    sresult = sresult & "i"
                Case "Í"
                    sresult = sresult & "I"
                Case "ó"
                    sresult = sresult & "o"
                Case "Ó"
                    sresult = sresult & "O"
                Case "ú"
                    sresult = sresult & "u"
                Case "Ú"
                    sresult = sresult & "U"
                Case "ñ"
                    sresult = sresult & "n"
                Case "Ñ"
                    sresult = sresult & "N"
                Case Else
                    sresult = sresult & ccar
            End Select
        Next
        'concluyo...
        Return sresult
    End Function

End Class   ' fin clase [Utilerias]
