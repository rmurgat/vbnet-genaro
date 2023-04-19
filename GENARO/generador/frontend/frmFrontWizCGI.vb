Option Explicit On

Imports MyLIB

Public Class frmFrontWizCGI
    Private obus As Catalogos
    Private outil As Utilerias
    Private omdipa As MDIGenaro
    Private ipagina As Integer = 1
    Private olog As HANYLog = New MyLIB.HANYLog
    Private ozip As ZipArchivo = New MyLIB.ZipArchivo
    Private cClases As Collection

    Private Sub btnsiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiguiente.Click
        ipagina = ipagina + 1
        Call Cambia_pagina()
    End Sub

    Private Sub btnanterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanterior.Click
        ipagina = ipagina - 1
        Call Cambia_pagina()
    End Sub

    Private Sub Cambia_pagina()
        If ipagina < 1 Then ipagina = 1
        If ipagina > 5 Then ipagina = 5

        If ipagina = 1 Then
            grbpaso1.Visible = True
            grbpaso2.Visible = False
            grbpaso3.Visible = False
            grbpaso4.Visible = False
            grbpaso5.Visible = False
        End If
        If ipagina = 2 Then
            Dim csyncs As Collection
            grbpaso1.Visible = False
            grbpaso2.Visible = True
            grbpaso3.Visible = False
            grbpaso4.Visible = False
            grbpaso5.Visible = False
            'Carga las sincronias
            Me.cbosincronia.Items.Clear()
            csyncs = obus.getSincronias(outil.Toma_Token(1, Me.cboproyecto.SelectedItem, "-"))
            For Each osyn As Sincronia In csyncs
                Me.cbosincronia.Items.Add(osyn.cdsincronia & " - " & osyn.nbsincronia)
            Next
            If csyncs.Count = 0 Then MsgBox("No Existe ninguna sincronización para este proyecto!", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
        If ipagina = 3 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = False
            grbpaso3.Visible = True
            grbpaso4.Visible = False
            grbpaso5.Visible = False
        End If
        If ipagina = 4 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = False
            grbpaso3.Visible = False
            grbpaso4.Visible = True
            grbpaso5.Visible = False
        End If
        If ipagina = 5 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = False
            grbpaso3.Visible = False
            grbpaso4.Visible = False
            grbpaso5.Visible = True
        End If
    End Sub

    Private Sub btnterminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub

    Private Sub frmFrontWizCGI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oxmlmain As Nodo
        Dim oxmlestilos As Nodo
        Dim cproys As Collection
        Dim ocrit As Criterio
        Dim ocol As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            outil = New Utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            ocrit = New Criterio
            ozip.Open(omdipa.configuracion)
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")

            'PASO 2: LLena el catálogo de proyectos
            cproys = obus.getProyectos(ocrit)
            For Each oproy As Proyecto In cproys
                cboproyecto.Items.Add(oproy.cdproyecto & " - " & oproy.nbproyecto)
            Next

            'PASO 3: Llena el catálogo con los estilos de los scripts
            ocol = oxmlestilos.Buscar("estilo", "tipo", "cgi")
            'RMT For Each onodo As Nodo In ocol
            'RMT Me.cboestilo.Items.Add(onodo.getValue("estilo.clave") & " - " & onodo.getValue("estilo.nombre"))
            'RMT Next

            'PASO 4: Termina
            'RMT Me.cboestilo.SelectedIndex = 0

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontWizCGI.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontWizCGI.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnexaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexaminar.Click
        FolderBrowserDialog.SelectedPath = Comun.STR_DIRECTORIO
        If (FolderBrowserDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtdirectory.Text = FolderBrowserDialog.SelectedPath
            Comun.STR_DIRECTORIO = Me.txtdirectory.Text
        End If
    End Sub

    Private Sub btncargapantallas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncargapantallas.Click
        If Me.cboproyecto.SelectedIndex < 0 Then
            MsgBox("No hay ningún proyecto seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        If Me.cbosincronia.SelectedIndex < 0 Then
            MsgBox("No hay ninguna sincronización seleccionada", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            Call Load_gridpantallas(outil.Toma_Token(1, Me.cbosincronia.SelectedItem.ToString, "-"), outil.Toma_Token(1, Me.cboproyecto.SelectedItem.ToString, "-"))
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontWizCGI.btncargapantallas_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontWizCGI.btncargapantallas_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub Load_gridpantallas(ByVal scdsincronia As String, ByVal scdproyecto As String)
        Dim oselect As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)
        Dim cpants As Collection
        Dim icountersync As Integer = 0
        Dim bready As Boolean = True

        Try
            'PASO 1: Inserta las columnas que participan
            oselect.Name = "genera"
            oselect.HeaderText = "Generar"
            oselect.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            oselect.Width = 60
            gridpantalla.Rows.Clear()
            gridpantalla.Columns.Clear()
            gridpantalla.Columns.Add(oselect)
            gridpantalla.Columns.Add("clave", "Clave de Pantalla")
            gridpantalla.Columns.Add("estatus", "Estatus")
            gridpantalla.Columns.Add("codigo", "Codigo")
            gridpantalla.Columns.Add("nombre", "Nombre de la Pantalla")

            'PASO 2: Define el ancho de cada columna
            gridpantalla.Columns.Item("clave").Width = 60
            gridpantalla.Columns.Item("estatus").Width = 90
            gridpantalla.Columns.Item("codigo").Width = 80
            gridpantalla.Columns.Item("nombre").Width = 200
            gridpantalla.Columns.Item("genera").SortMode = DataGridViewColumnSortMode.NotSortable
            gridpantalla.Columns.Item("clave").SortMode = DataGridViewColumnSortMode.NotSortable
            gridpantalla.Columns.Item("estatus").SortMode = DataGridViewColumnSortMode.NotSortable
            gridpantalla.Columns.Item("codigo").SortMode = DataGridViewColumnSortMode.NotSortable
            gridpantalla.Columns.Item("nombre").SortMode = DataGridViewColumnSortMode.NotSortable

            'PASO 3: Las determina como de solo lectura
            gridpantalla.Columns.Item("clave").ReadOnly = True
            gridpantalla.Columns.Item("estatus").ReadOnly = True
            gridpantalla.Columns.Item("codigo").ReadOnly = True
            gridpantalla.Columns.Item("nombre").ReadOnly = True

            'PASO 4: Agrega la información de cada pantalla
            cpants = obus.getPantallas(scdproyecto)
            For Each opant As Pantalla In cpants
                Dim osinc As SincroniaPantalla
                Dim sestatus As String

                sestatus = ""
                osinc = obus.getSincroniaPantalla(scdsincronia, scdproyecto, opant.cdpantalla)
                If Not osinc Is Nothing Then sestatus = osinc.estatus
                If sestatus.Equals(Comun.ST_SINCRONIZADO_HTML) Then
                    sestatus = "SINCRONIZADA"
                    icountersync = icountersync + 1
                Else
                    sestatus = ""
                End If
                gridpantalla.Rows.Add(False, opant.cdpantalla, sestatus, opant.cdcodigo, opant.nbpantalla)
            Next
            txtpantallas.Text = "Un total de " & cpants.Count & " pantallas, y " & icountersync & " sincronizadas"

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontWizCGI.Load_gridpantallas()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontWizCGI.Load_gridpantallas()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Sub

    Private Sub btniniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btniniciar.Click
        Dim iren As Integer
        Dim osincronia As Sincronia
        Dim opantalla As Pantalla
        Dim scdproyecto As String
        Dim scdsincronia As String
        Dim oclibs As Collection
        Dim oconfig As ConfigXML
        Dim oxmlCGI As Nodo

        Try
            'PASO 1: Inicializa las variables
            oconfig = New ConfigXML(ozip)
            scdproyecto = outil.Toma_Token(1, Me.cboproyecto.SelectedItem.ToString, "-")
            scdsincronia = outil.Toma_Token(1, Me.cbosincronia.SelectedItem.ToString, "-")
            osincronia = obus.getSincronia(scdsincronia, scdproyecto)
            oxmlCGI = oconfig.getUnEstiloProgramacion(osincronia.cdestilogenera)
            Me.Cursor = Cursors.WaitCursor
            Me.prbarmado.Maximum = 100
            Me.prbarmado.Minimum = 0

            'PASO 2: Generando los componentes de las pantallas
            lstdebug.Items.Clear()
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "PASO 1: Generando los componentes del proyecto")
            For iren = 0 To gridpantalla.Rows.Count - 1

                'Los componentes que se generan son los seleccionados y además que tenga estatus de sincronizado
                If gridpantalla.Item("genera", iren).Value = True And gridpantalla.Item("estatus", iren).Value.Equals("SINCRONIZADA") Then
                    Dim oxmlFuncion, oxmlpars As Nodo
                    Dim scdpantalla As String
                    Dim ohtml As Html2CGI
                    Dim sresult As String
                    Dim sxmlgen As String

                    'PASO 2.1: Me voy a traer la información relativa a la pantalla
                    scdpantalla = gridpantalla.Item("clave", iren).Value
                    opantalla = obus.getPantallaSinc(scdsincronia, scdproyecto, scdpantalla)
                    oxmlFuncion = oconfig.getUnaFuncion(osincronia.cdestilogenera, opantalla.sincronia.cdestilofuncion)
                    oxmlpars = oxmlCGI.getPrimerNodo("code.parametros")
                    sxmlgen = ""
                    sresult = ""
                    ohtml = New Html2CGI
                    ohtml.estilo = osincronia.cdestilogenera
                    ohtml.procesador = opantalla.sincronia.cdestilofuncion
                    ohtml.zipconfig = ozip

                    'PASO 2.2: Voy a traer la información relativa a la pantalla
                    sxmlgen = "<general>"
                    sxmlgen = sxmlgen & "<nbcomponente>" & opantalla.sincronia.nbcomponente & "</nbcomponente>"
                    sxmlgen = sxmlgen & "<extcgi>" & oxmlpars.BuscarPrimero("parametro", "nombre", "extension-cgi").getValue("parametro.valor") & "</extcgi>"
                    sxmlgen = sxmlgen & "<cdproyecto>" & outil.Toma_Token(1, Me.cboproyecto.SelectedItem.ToString, "-") & "</cdproyecto>"
                    sxmlgen = sxmlgen & "<nbproyecto>" & outil.Toma_Token(2, Me.cboproyecto.SelectedItem.ToString, "-") & "</nbproyecto>"
                    sxmlgen = sxmlgen & "</general>"

                    'opantalla.nbscriptfile = opantalla.getjustnbhtmlfile() & oxmlparametros.BuscarPrimero("parametro", "nombre", "extension-cgi").getValue("parametro.valor")
                    outil.addToListDebug(lstdebug, "  Procesando pantalla [" & opantalla.cdpantalla & " - " & opantalla.nbpantalla & "]")

                    'PASO 2.3: Lee el archivo html desde el prototipo
                    If Not ohtml.Carga(opantalla.sincronia.nbhtmlfile) Then
                        outil.addToListDebug(lstdebug, "! ERROR ! La pantalla [" & scdpantalla & "] sin relación con su HTML")
                        Exit Sub
                    End If

                    'PASO 2.4: Lee la información a detalle para la pantalla
                    opantalla.Campos = obus.getPantallaCamposSinc(scdsincronia, scdproyecto, scdpantalla)
                    opantalla.Eventos = obus.getPantallaEventosSinc(scdsincronia, scdproyecto, scdpantalla)

                    'PASO 2.5: Recorre los campos para crear las validaciones...
                    ohtml.SetXML(sxmlgen & opantalla.GetXML())
                    sresult = ohtml.generaCGI()

                    'PASO 2.6: Escribe en el archivo
                    If Not outil.EscribeNuevoArchivo(Me.txtdirectory.Text & "/" & opantalla.sincronia.nbcomponente & oxmlpars.BuscarPrimero("parametro", "nombre", "extension-cgi").getValue("parametro.valor"), sresult) Then
                        outil.addToListDebug(lstdebug, "  Error Generando : " & opantalla.sincronia.nbcomponente & oxmlpars.BuscarPrimero("parametro", "nombre", "extension-cgi").getValue("parametro.valor"))
                    End If

                End If
            Next

            'PASO 3: Se Generan los componentes de las librerias que componen la solución
            If chklibs.Checked Then
                Dim oxmllibs As Nodo

                oxmllibs = oxmlCGI.getPrimerNodo("code.librerias")
                outil.addToListDebug(lstdebug, "")
                outil.addToListDebug(lstdebug, "PASO 2: Generando los librerias default")
                oclibs = oxmllibs.getNodo("libreria")
                For Each oxml As Nodo In oclibs
                    Dim sxmlgen As String
                    Dim ometareader As MetacodigoReader
                    Dim sresult As String

                    'PASO 3.1: Inicializa
                    sresult = ""
                    ometareader = New MetacodigoReader()
                    sxmlgen = "<general>"
                    sxmlgen = sxmlgen & "<nbcomponente>" & outil.Toma_Token(1, oxml.getValue("libreria.archivo"), ".") & "</nbcomponente>"
                    sxmlgen = sxmlgen & "<extension>" & oxml.getValue("libreria.extension") & "</extension>"
                    sxmlgen = sxmlgen & "<cdproyecto>" & outil.Toma_Token(1, Me.cboproyecto.SelectedItem.ToString, "-") & "</cdproyecto>"
                    sxmlgen = sxmlgen & "<nbproyecto>" & outil.Toma_Token(2, Me.cboproyecto.SelectedItem.ToString, "-") & "</nbproyecto>"
                    sxmlgen = sxmlgen & "</general>"

                    outil.addToListDebug(lstdebug, "  Procesando libreria [" & outil.Toma_Token(1, oxml.getValue("libreria.archivo"), ".") & oxml.getValue("libreria.extension") & "]")

                    'PASO 3.2: Prepara la interpretación
                    ometareader.source = ozip.getFileInflated(oxmlCGI.getValue("estilo.directorio") & oxml.getValue("libreria.archivo"))
                    ometareader.SetXML(sxmlgen)
                    sresult = ometareader.Interpreta()

                    'PASO 3.3: Escribe el resultado en el archivo
                    If Not outil.EscribeNuevoArchivo(Me.txtdirectory.Text & "/" & outil.Toma_Token(1, oxml.getValue("libreria.archivo"), ".") & oxml.getValue("libreria.extension"), sresult) Then
                        outil.addToListDebug(lstdebug, "  Error Generando : " & outil.Toma_Token(1, oxml.getValue("libreria.archivo"), ".") & oxml.getValue("libreria.extension"))
                    End If
                Next
            End If

            'PASO 4: Termina 
            Me.Cursor = Cursors.Default
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "! PROCESO TERMINADO !")

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontWizCGI.btniniciar_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontWizCGI.btniniciar_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try

    End Sub

End Class