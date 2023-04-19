Option Explicit On

Imports MyLIB
Imports System.Windows.Forms
Imports System.Configuration
Imports System.Data.SQLite

Public Class frmFronCalificaSync
    Private obus As Catalogos
    Private scdproject As String             'Clave del proyecto
    Private scdpantalla As String            'Clave de la pantalla
    Private scdsincronia As String           'Clave de la sincronia
    Private opantalla As Pantalla            'Objeto que tiene las propiedades de la pantalla
    Private opantsync As SincroniaPantalla   'Objeto que tiene las propiedades de sincronización de la pantalla
    Private outil As Utilerias               'Utilerias del sistema
    Private oconexion As SQLiteConnection     'Conexión a la base de datos
    Private ohtml As HTMLReader

    ''' <summary>
    ''' PROPIEDAD: Clave del proyecto
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdproject() As String
        Get
            Return scdproject
        End Get
        Set(ByVal pscd As String)
            scdproject = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave de la pantalla
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdpantalla() As String
        Get
            Return scdpantalla
        End Get
        Set(ByVal pscd As String)
            scdpantalla = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave de la sincronia
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdsincronia() As String
        Get
            Return scdsincronia
        End Get
        Set(ByVal pscd As String)
            scdsincronia = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Conexión a la base de datos
    ''' </summary>
    ''' <value>OleDbConnection</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property conexion() As SQLiteConnection
        Get
            Return oconexion
        End Get
        Set(ByVal poval As SQLiteConnection)
            oconexion = poval
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmFronCalificaSync_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            outil = New Utilerias
            obus = New Catalogos(Me.conexion)

            Call Llena_GridCalifica()

        Catch ex As HANYException
            ex.add("MyGENARO.frmFronCalificaSync.Load()", "Ocurrio un error al cargar la pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub Llena_GridCalifica()
        Dim ocal As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)
        ocal.Name = "califica"
        ocal.HeaderText = "Califica"
        ocal.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter

        grdCalifica.Rows.Clear()
        grdCalifica.Columns.Clear()
        grdCalifica.Columns.Add("clave", "Clave")
        grdCalifica.Columns.Add("concepto", "Concepto")
        grdCalifica.Columns.Add(ocal)
        grdCalifica.Columns.Item("clave").Width = 60
        grdCalifica.Columns.Item("concepto").Width = 370
        grdCalifica.Columns.Item("califica").Width = 100
        grdCalifica.Columns.Item("clave").SortMode = DataGridViewColumnSortMode.NotSortable
        grdCalifica.Columns.Item("califica").SortMode = DataGridViewColumnSortMode.NotSortable
        grdCalifica.Columns.Item("concepto").SortMode = DataGridViewColumnSortMode.NotSortable
        grdCalifica.Columns.Item("califica").SortMode = DataGridViewColumnSortMode.NotSortable

        grdCalifica.Rows.Add("01", "Validación configuración de Pantalla", False)
        grdCalifica.Rows.Add("02", "Asociación de Entradas", False)
        grdCalifica.Rows.Add("03", "Asociación de Salidas", False)
        grdCalifica.Rows.Add("04", "Sincronización de Entradas", False)
        grdCalifica.Rows.Add("05", "Sincronización de Salidas", False)
        grdCalifica.Rows.Add("06", "Sincronización de Arreglos", False)
        grdCalifica.Rows.Add("07", "Sincronización de Eventos", False)
        grdCalifica.Rows.Add("08", "Configuración de Navegación", False)
    End Sub

    Private Sub btnClipboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClipboard.Click
        Dim sDatos As String = ""
        Dim i As Integer

        For i = 0 To lstdebug.Items.Count - 1
            sDatos = sDatos & vbCr & vbLf & lstdebug.Items.Item(i).ToString
        Next
        Clipboard.Clear()
        Clipboard.SetText(sDatos)
        MsgBox("Se ha copiado el resultado al portapapeles", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Dim opantsinc As SincroniaPantalla
        Dim ccampos As Collection
        Dim ceventos As Collection
        Dim cnavs As Collection
        Dim ctags As Collection
        Dim carreglo As Collection
        Dim bcalifico01 As Boolean = True
        Dim bcalifico02 As Boolean = True
        Dim bcalifico03 As Boolean = True
        Dim bcalifico04 As Boolean = True
        Dim bcalifico05 As Boolean = True
        Dim bcalifico06 As Boolean = True
        Dim bcalifico07 As Boolean = True
        Dim bcalifico08 As Boolean = True

        lstdebug.Items.Clear()
        outil.addToListDebug(lstdebug, "")

        Try
            ohtml = New HTMLReader()

            'PASO 1: Consulta la sincronización de está pantalla
            opantsinc = obus.getSincroniaPantalla(Me.cdsincronia, Me.cdproject, Me.cdpantalla)
            If opantsinc Is Nothing Then
                outil.addToListDebug(lstdebug, "  ! NO SE HA GRABADO NINGUNA SINCRONIZACION !")
                Exit Sub
            End If

            'PASO 1: Validación de configuración de pantalla
            outil.addToListDebug(lstdebug, "PASO 1: Validación configuración de Pantalla")
            If opantsinc.nbhtmlfile.Equals("") Then
                outil.addToListDebug(lstdebug, "    Falta nombre del archivo prototipo HTML")
                bcalifico01 = False
            End If
            If Not outil.Existe_Archivo(opantsinc.nbhtmlfile) Then
                outil.addToListDebug(lstdebug, "    El archivo prototipo HTML No existe !")
                bcalifico01 = False
            End If
            If opantsinc.nbcomponente.Equals("") Then
                outil.addToListDebug(lstdebug, "    Falta nombre resultado del script")
                bcalifico01 = False
            End If
            If opantsinc.nbhtmlforma.Equals("") Then
                outil.addToListDebug(lstdebug, "    Falta el nombre de la forma")
                bcalifico01 = False
            End If
            If opantsinc.cdestilofuncion.Equals("") Then
                outil.addToListDebug(lstdebug, "    Falta el estilo de funcionalidad con el que se genera la pantalla")
                bcalifico01 = False
            End If

            Call Califica_Renglon("01", bcalifico01)

            'PASO 2: Asociación de Entradas
            outil.addToListDebug(lstdebug, "PASO 2: Asociación de Entradas")
            ohtml.Carga(opantsinc.nbhtmlfile)
            ctags = ohtml.GetAllInputTags()
            For Each otag As HTMLTag In ctags
                Dim bsync As Boolean = True
                Dim ocampo As PantallaCampo

                If Not otag.id.Equals("") Then
                    ocampo = obus.getPantallaCampobyId(Me.cdproject, Me.cdpantalla, Me.cdsincronia, otag.id)
                    If ocampo Is Nothing Then
                        outil.addToListDebug(lstdebug, "    El tag [" & otag.id & "] aun no ha sido asociado")
                        bcalifico02 = False
                    End If
                End If
            Next

            Call Califica_Renglon("02", bcalifico02)

            'PASO 3: Asociación de Salidas
            outil.addToListDebug(lstdebug, "PASO 3: Asociación de Salidas")
            ctags = ohtml.GetAllOutputTags()
            For Each otag As HTMLTag In ctags
                Dim bsync As Boolean = True
                Dim ocampo As PantallaCampo

                If Not otag.id.Equals("") Then
                    ocampo = obus.getPantallaCampobyId(Me.cdproject, Me.cdpantalla, Me.cdsincronia, otag.id)
                    'If ocampo Is Nothing Then
                    'outil.addToListDebug(lstdebug, "    El tag [" & otag.id & "] aun no ha sido asociado")
                    'bcalifico03 = False
                    'End If
                End If
            Next

            Call Califica_Renglon("03", bcalifico03)

            'PASO 4: Califica la sincronización de entradas
            outil.addToListDebug(lstdebug, "PASO 4: Califica la Sincronización de Entradas")
            ccampos = obus.getPantallaCampos(Me.cdproject, Me.cdpantalla, Comun.TIPO_CAMPO_INPUT)
            For Each ocampo As PantallaCampo In ccampos
                Dim ocamposinc As SincroniaCampo
                Dim oxml As Nodo

                outil.addToListDebug(lstdebug, "    Validando [" & ocampo.nbcampo & "]")
                'PASO 4.1: Lee la sincronización del campo
                ocamposinc = obus.getSincroniaCampo(Me.cdsincronia, Me.cdproject, Me.cdpantalla, ocampo.cdcampo)
                If Not ocamposinc Is Nothing Then
                    oxml = New Nodo(ocamposinc.xmlcampo)

                    'PASO 4.2: Si tiene incorporada una clase
                    If Not oxml.getValue("object.nbclase").Trim.Equals("") Then

                        'PASO 4.2.1: valida que tenga el nombre del metodo GET
                        If oxml.getValue("object.nbmethodget").Trim.Equals("") Then
                            outil.addToListDebug(lstdebug, "      Falta el nombre del método get")
                            bcalifico04 = False
                        End If

                        'PASO 4.2.2: valida que tenga el nombre del metodo SET

                        If oxml.getValue("object.nbmethodset").Trim.Equals("") Then
                            outil.addToListDebug(lstdebug, "      Falta el nombre del método set")
                            bcalifico04 = False
                        End If

                        'PASO 4.2.3: valida que tenga el nombre del objeto
                        If oxml.getValue("object.nbobjeto").Trim.Equals("") Then
                            outil.addToListDebug(lstdebug, "      Falta el nombre del objeto")
                            bcalifico04 = False
                        End If
                    End If

                    'PASO 4.3: Si tiene incorporada una clase
                    If Not oxml.getValue("objectlist.nbclase").Trim.Equals("") Then
                        If oxml.getValue("objectlist.nbmethodcve").Trim.Equals("") Then
                            outil.addToListDebug(lstdebug, "      Falta el nombre del método list.clave")
                            bcalifico04 = False
                        End If
                        If oxml.getValue("objectlist.nbmethodnom").Trim.Equals("") Then
                            outil.addToListDebug(lstdebug, "      Falta el nombre del método list.nombre")
                            bcalifico04 = False
                        End If
                        If oxml.getValue("objectlist.nbobjeto").Trim.Equals("") Then
                            outil.addToListDebug(lstdebug, "      Falta el nombre del list.objeto")
                            bcalifico04 = False
                        End If
                    End If
                Else
                    outil.addToListDebug(lstdebug, "      Este campo no a sido sincronizado")
                    bcalifico04 = False
                End If
            Next
            Call Califica_Renglon("04", bcalifico04)

            'PASO 5: Califica la sincronización de salidas
            outil.addToListDebug(lstdebug, "PASO 5: Califica la Sincronización de Salidas")
            ccampos = obus.getPantallaCampos(Me.cdproject, Me.cdpantalla, Comun.TIPO_CAMPO_OUTPUT)
            For Each ocampo As PantallaCampo In ccampos
                Dim ocamposinc As SincroniaCampo
                Dim oxml As Nodo

                outil.addToListDebug(lstdebug, "    Validando [" & ocampo.nbcampo & "]")
                'PASO 5.1: Lee la sincronización del campo
                ocamposinc = obus.getSincroniaCampo(Me.cdsincronia, Me.cdproject, Me.cdpantalla, ocampo.cdcampo)
                If Not ocamposinc Is Nothing Then
                    oxml = New Nodo(ocamposinc.xmlcampo)

                    'PASO 5.2: Si tiene incorporada una clase
                    If Not oxml.getValue("object.nbclase").Trim.Equals("") Then

                        'PASO 5.2.1: valida que tenga el nombre del metodo GET
                        If oxml.getValue("object.nbmethodget").Trim.Equals("") Then
                            outil.addToListDebug(lstdebug, "      Falta el nombre del método get")
                            bcalifico05 = False
                        End If

                        'PASO 5.2.3: valida que tenga el nombre del objeto
                        If oxml.getValue("object.nbobjeto").Trim.Equals("") Then
                            outil.addToListDebug(lstdebug, "      Falta el nombre del objeto")
                            bcalifico05 = False
                        End If
                    End If
                Else
                    outil.addToListDebug(lstdebug, "      Este campo no a sido sincronizado")
                    bcalifico05 = False
                End If
            Next

            Call Califica_Renglon("05", bcalifico05)

            'PASO 6: Califica la sincronización de eventos
            outil.addToListDebug(lstdebug, "PASO 6: Califica la Sincronización de Arreglos")
            carreglo = obus.getPantallarreglos(Me.cdproject, Me.cdpantalla)
            For Each oarreglo As Pantallarreglo In carreglo
                Dim osincronia As SincroniArreglo

                'PASO 6.1: Consulta la información de sincronización
                outil.addToListDebug(lstdebug, "    Validando [" & oarreglo.nbarreglo & "]")
                osincronia = obus.getSincroniArreglo(Me.cdsincronia, Me.cdproject, Me.cdpantalla, oarreglo.cdarreglo)
                If Not osincronia Is Nothing Then

                    'PASO 6.2: valida que tenga el id para el renglón HTML
                    If osincronia.nbidhtml.Trim.Equals("") Then
                        outil.addToListDebug(lstdebug, "      Falta el nombre del renglón HTML")
                        bcalifico06 = False
                    End If

                    'PASO 6.3: valida que tenga el tipo de elemento
                    If osincronia.tpelement.Trim.Equals("") Then
                        outil.addToListDebug(lstdebug, "      Falta identificar la clase para elemento")
                        bcalifico06 = False
                    End If

                    'PASO 6.4: valida que tenga el tipo de elemento
                    If osincronia.nbelement.Trim.Equals("") Then
                        outil.addToListDebug(lstdebug, "      Falta nombrar el objeto para el elemento")
                        bcalifico06 = False
                    End If

                    'PASO 6.5: valida que tenga el tipo de elemento
                    If osincronia.nbobject.Trim.Equals("") Then
                        outil.addToListDebug(lstdebug, "      Falta identificar el nombre del objeto")
                        bcalifico06 = False
                    End If
                Else
                    outil.addToListDebug(lstdebug, "      Este arreglo no a sido sincronizado")
                    bcalifico06 = False
                End If
            Next
            Call Califica_Renglon("06", bcalifico06)

            'PASO 7: Califica la sincronización de eventos
            outil.addToListDebug(lstdebug, "PASO 7: Califica la Sincronización de Eventos")
            ceventos = obus.getPantallaEventos(Me.cdproject, Me.cdpantalla)
            For Each oevento As PantallaEvento In ceventos
                Dim oeventosinc As SincroniaEvento
                Dim oxml, oxmpars As Nodo
                Dim cpars As Collection

                outil.addToListDebug(lstdebug, "    Validando [" & oevento.nbevento & "]")

                'PASO 7.1: Consulta la sincronización del evento
                oeventosinc = obus.getSincroniaEvento(Me.cdsincronia, Me.cdproject, Me.cdpantalla, oevento.cdevento)
                If Not oeventosinc Is Nothing Then
                    oxml = New Nodo(oeventosinc.xmlevento)

                    If oeventosinc.xmlevento.Trim.Equals("") Then
                        outil.addToListDebug(lstdebug, "      Este evento no ha sido sincronizado!")
                        bcalifico07 = False
                    End If

                    'PASO 7.2: Valida los objetos utilizados en el servidor
                    If oxml.getValue("evehtml.exeservidor").Equals("Si") Or oxml.getValue("evehtml.exesrvbrow").Equals("Si") Then
                        If oxml.getValue("eveobject.nbclase").Trim.Equals("") Then
                            outil.addToListDebug(lstdebug, "      Falta el nombre de la clase")
                            bcalifico07 = False
                        End If
                        If oxml.getValue("eveobject.nbmethod").Trim.Equals("") Then
                            outil.addToListDebug(lstdebug, "      Falta el nombre del método a ejecutar")
                            bcalifico07 = False
                        End If
                        If oxml.getValue("eveobject.nbobjetomet").Trim.Equals("") Then
                            outil.addToListDebug(lstdebug, "      Falta el nombre del objeto")
                            bcalifico07 = False
                        End If
                        If oxml.getValue("eveobject.tieneretorno").Trim.Equals("Si") Then
                            If oxml.getValue("eveobject.nbobjetores").Trim.Equals("") Then
                                outil.addToListDebug(lstdebug, "      Falta el nombre del objeto resultante")
                                bcalifico07 = False
                            End If
                        End If
                        oxmpars = oxml.getPrimerNodo("eveobject.eveparams")
                        cpars = oxmpars.getNodo("eveparam")
                        For Each oxmpar As Nodo In cpars
                            If oxmpar.getValue("eveparam.tienevalor").Equals("No") Then
                                outil.addToListDebug(lstdebug, "      Falta asignar algún parámetro")
                                bcalifico07 = False
                            End If
                        Next
                    End If
                Else
                    outil.addToListDebug(lstdebug, "      Este evento no a sido sincronizado!")
                    bcalifico07 = False
                End If
            Next

            Call Califica_Renglon("07", bcalifico07)

            'PASO 7: Califica la configuración de navegación
            outil.addToListDebug(lstdebug, "PASO 8: Califica la Configuración de Navegación")
            cnavs = obus.getNavegaciones(Me.cdproject, Me.cdpantalla)
            For Each onav As Navegacion In cnavs
                Dim otarget As SincroniaPantalla
                Dim cpars As Collection
                Dim snbdestino As String

                snbdestino = ""
                'PASO 7.1: Consulta los parámetros de navegación y valida cada uno
                cpars = obus.getNavegacionParams(Me.cdproject, Me.cdpantalla, onav.cdhasta)
                For Each opar As NavegacionParam In cpars
                    If opar.txconstante.Equals("") Then
                        outil.addToListDebug(lstdebug, "      Falta el valor de un parámetro")
                        bcalifico08 = False
                    End If
                Next

                'PASO 7.2: Valida que la página TARGET esté sincronizada
                otarget = obus.getSincroniaPantalla(Me.cdsincronia, Me.cdproject, onav.cdhasta)
                If Not otarget Is Nothing Then snbdestino = otarget.nbcomponente.Trim
                If snbdestino.Equals("") Then
                    Dim opant As Pantalla = obus.getPantalla(Me.cdproject, onav.cdhasta)
                    outil.addToListDebug(lstdebug, "      Falta el nombre del componente destino para pantalla [" & opant.cdcodigo & "-" & opant.nbpantalla & "]")
                    bcalifico08 = False
                End If
            Next
            Call Califica_Renglon("08", bcalifico08)

            'PASO 5: Graba el estatus de sincronización de la pantalla
            If bcalifico01 And bcalifico02 And bcalifico03 And bcalifico04 And bcalifico05 And bcalifico06 And bcalifico07 Then
                lblCalif.Text = "OK"
                opantsinc.estatus = Comun.ST_SINCRONIZADO_HTML
            Else
                opantsinc.estatus = ""
            End If
            obus.saveSincroniaPantalla(opantsinc)
            btnClipboard.Visible = True

        Catch ex As HANYException
            ex.add("MyGENARO.frmFronCalificaSync.btnStart_Click()", "Ocurrio un error en el proceso de calificación")
            outil.ShowException(ex)
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para calificar un renglón en particular
    ''' </summary>
    ''' <param name="scd">Clave del renglón</param>
    ''' <param name="scal">Calificación</param>
    ''' <remarks></remarks>
    Private Sub Califica_Renglon(ByVal scd As String, ByVal scal As Boolean)
        Dim iren As Integer

        For iren = 0 To grdCalifica.Rows.Count - 1
            If grdCalifica.Item("clave", iren).Value().Equals(scd) Then grdCalifica.Item("califica", iren).Value = scal
        Next
    End Sub

End Class
