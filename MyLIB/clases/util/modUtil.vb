Option Explicit On 

Module modUtil


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

        'inicializo...
        Toma_Token = vbNullString

        iNumValores = Aparta_Tokens(pszExpresion, pszArrToken, pszCaracter)

        If iNumToken > iNumValores Then Exit Function

        Toma_Token = pszArrToken(iNumToken)

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

        Dim iNumValores As Integer               'número de tokens
        Dim pszArrToken() As String = Nothing    'arreglo que contendran los tokens
        Dim pszCadena As String                  'cadena armada con los tokens
        Dim iIdxArr As Integer                   'indice para recorrer el arreglo

        'inicializo...
        Quita_Token = vbNullString
        pszCadena = vbNullString

        'aparto primero los tokens
        iNumValores = Aparta_Tokens(pszExpresion, pszArrToken, pszCaracter)

        'si el token que se quiere no existe, me salgo...
        If iNumToken > iNumValores Then Exit Function

        'otravez armo la expresión, pero sin el token que me pidieron...
        For iIdxArr = 1 To iNumValores
            If iIdxArr <> iNumToken Then pszCadena = Anade_Token(pszCadena, pszArrToken(iIdxArr), pszCaracter)
        Next

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
    '    Rubén Murga Tapia      5/Jun/1997
    '-----------------------------------------------------------------------------
    Public Function Aparta_Tokens(ByVal psExpresion As String, ByRef psArrToken() As String, ByVal psDelimitador As String) As Integer

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
            Aparta_Tokens = iNumToken

        Catch ex As HANYException
            ex.add("MyLIB.modUtil.Aparta_Tokens()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyLIB.modUtil.Aparta_Tokens()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

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
    '    Rubén Murga Tapia      5/Jun/1997
    '
    '-----------------------------------------------------------------------------
    Public Function Anade_Token(ByVal psExpresion As String, ByVal psToken As String, ByVal psDelimitador As String) As String

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

    End Function

    '-----------------------------------------------------------------------------
    '  Descripción:
    '    Funcion par quitar los espacios de una cadena
    '
    '  Parámetro:
    '    pszExpresión    -->  Expresión que contendra los la cadena a tratar
    '
    '  Ejemplo:
    '    Expresion = Quita_Espacio("546562   65465265   656546") = "546562, 65..."
    '
    '  Responsable:
    '    Rubén Murga Tapia      5/Jun/19897
    '
    '-----------------------------------------------------------------------------
    Public Function Quita_Espacio(ByVal psExp As String, ByVal pscar As String) As String
        Dim sres As String = ""
        Dim pstrim As String
        Dim ipos As Integer
        Dim scar As String
        Dim slastcar As String = ""

        pstrim = Trim$(psExp)
        For ipos = 1 To Len(pstrim)
            scar = Mid$(pstrim, ipos, 1)
            If scar = " " Then
                If slastcar <> " " Then sres = sres + pscar
            Else
                sres = sres + scar
            End If
            slastcar = scar
        Next
        Quita_Espacio = sres
    End Function

    '---------------------------------------------------------------------------------------
    ' Descripción:
    '     Quita de la cadena que se encuentra en el párametro 1 la cadena que se encuentra
    '     en el parámetro 2 y regresa el valor resultante.
    '
    ' Parámetros:
    '     psBuscarEn  --> Cadena donde se buscara la información
    '     psBuscarA   --> Cadena que contiene la información a buscar y a quitar también.
    '
    ' Regresa:
    '     Cadena que contiene la cadena del parametro 1 sin la cadena del parametro 2
    '---------------------------------------------------------------------------------------
    Public Function Quita_Cadena(ByVal psBuscarEn As String, ByVal psBuscarA As String) As String
        Dim iPosicion As Integer

        psBuscarEn = Quita_Caracter(psBuscarEn, " ")
        'Checo primero en que posición se encuentra
        iPosicion = InStr(psBuscarEn, psBuscarA)

        'En caso de no haber encontrado nada, me salgo...
        If iPosicion = 0 Then
            Quita_Cadena = psBuscarEn     'Regresa la misma cadena
            Exit Function
        End If

        'Regreso la cadena sin la subcadena
        Quita_Cadena = Mid$(psBuscarEn, 1, iPosicion - 1) & Mid$(psBuscarEn, iPosicion + Len(psBuscarA) + 1)

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
    Function Quita_Caracter(ByVal psCadena As String, ByVal psCaracter As String) As String
        Dim iIdxCad As Integer          'indice para recorrer la cadena
        Dim sCadena As String           'cadena
        Dim sCaracter As String         'caracter extraido de la cadena

        If psCadena = vbNullString Then 'si la cadena es nula se sale
            Return ""
        End If

        'inicializo...
        Quita_Caracter = vbNullString
        sCadena = vbNullString

        'recorre la cadena...
        For iIdxCad = 1 To Len(psCadena)
            sCaracter = Mid$(psCadena, iIdxCad, 1)
            If sCaracter <> psCaracter Then sCadena = sCadena & sCaracter
        Next

        'concluyo...
        Quita_Caracter = sCadena
    End Function
End Module
