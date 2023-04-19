Option Explicit On

Imports MyLIB
Imports System.Windows.Forms
Imports System.IO

Public Class frmFrontWizSyncProyCGI
    Private obus As Catalogos
    Private outil As Utilerias
    Private omdipa As MDIGenaro
    Private ipagina As Integer = 1
    Private olog As HANYLog = New MyLIB.HANYLog
    Private ozip As ZipArchivo = New MyLIB.ZipArchivo
    Private cClases As Collection
    Private scdsincronia As String = ""

    Private Sub btnterminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub

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
        If ipagina > 6 Then ipagina = 6

        If ipagina = 1 Then
            grbpaso1.Visible = True
            grbpaso2.Visible = False
            grbpaso3.Visible = False
            grbpaso4.Visible = False
            grbpaso5.Visible = False
            grbpaso6.Visible = False
        End If
        If ipagina = 2 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = True
            grbpaso3.Visible = False
            grbpaso4.Visible = False
            grbpaso5.Visible = False
            grbpaso6.Visible = False
        End If
        If ipagina = 3 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = False
            grbpaso3.Visible = True
            grbpaso4.Visible = False
            grbpaso5.Visible = False
            grbpaso6.Visible = False
        End If
        If ipagina = 4 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = False
            grbpaso3.Visible = False
            grbpaso4.Visible = True
            grbpaso5.Visible = False
            grbpaso6.Visible = False
        End If
        If ipagina = 5 Then
            grbpaso1.Visible = False
            grbpaso3.Visible = False
            grbpaso4.Visible = False
            grbpaso5.Visible = True
            grbpaso6.Visible = False
        End If
        If ipagina = 6 Then
            grbpaso1.Visible = False
            grbpaso3.Visible = False
            grbpaso4.Visible = False
            grbpaso5.Visible = False
            grbpaso6.Visible = True
        End If
    End Sub

    ''' <summary>
    ''' Procedimiento para cargar las sincronias
    ''' </summary>
    ''' <param name="sproy">clave del proyecto</param>
    ''' <remarks></remarks>
    Private Sub Carga_Sincronias(ByVal sproy As String)
        Dim csyncs As Collection

        Me.cbosincronia.Items.Clear()
        csyncs = obus.getSincronias(outil.Toma_Token(1, Me.cboproyecto.SelectedItem, "-"))
        For Each osyn As Sincronia In csyncs
            Me.cbosincronia.Items.Add(osyn.cdsincronia & " - " & osyn.nbsincronia)
        Next

        If csyncs.Count = 0 Then
            radExiste.Enabled = False
            radNueva.Checked = True
            cbosincronia.Enabled = False
        Else
            radExiste.Enabled = True
            radExiste.Checked = True
            cbosincronia.Enabled = True
        End If
    End Sub

    Private Sub frmFrontWizSyncProyecto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cproys As Collection
        Dim ocrit As Criterio
        Dim ocol As Collection
        Dim oconfig As ConfigXML

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            outil = New Utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            ocrit = New Criterio
            ozip.Open(omdipa.configuracion)
            oconfig = New ConfigXML(ozip)
            outil = New Utilerias

            'PASO 2: LLena el catálogo de proyectos
            cproys = obus.getProyectos(ocrit)
            For Each oproy As Proyecto In cproys
                cboproyecto.Items.Add(oproy.cdproyecto & " - " & oproy.nbproyecto)
            Next

            'PASO 3: Llena el catálogo con los estilos de la programación del backend
            ocol = oconfig.getEstiloProgramacion("model")
            For Each onodo As Nodo In ocol
                Me.cboestilo.Items.Add(onodo.getValue("estilo.clave") & " - " & onodo.getValue("estilo.nombre"))
            Next

            'PASO 2: Llena el catálogo con los estilos de los scripts
            ocol = oconfig.getEstiloProgramacion("cgi")
            For Each onodo As Nodo In ocol
                Me.cboFrontEnd.Items.Add(onodo.getValue("estilo.clave") & " - " & onodo.getValue("estilo.nombre"))
            Next

            Me.cboestilo.SelectedIndex = 0

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontWizSyncProyCGI.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontWizSyncProyCGI.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnexaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexaminar.Click
        FolderBrowserDialog.SelectedPath = Comun.STR_DIRECTORIO
        If (FolderBrowserDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtdirectory.Text = FolderBrowserDialog.SelectedPath
            Comun.STR_DIRECTORIO = Me.txtdirectory.Text
        End If
    End Sub

    Private Sub btnleerdir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnleerdir.Click
        Dim oxmlmain, oxmlestilos, oxmlestilo, oxmllenguaje, oxmlparametros As Nodo
        Dim carchivos As Collection
        Dim oarch As FileInfo

        Try
            'PASO 1: Inicia el procedimiento
            Me.clbArchivos.Items.Clear()
            carchivos = New Collection
            ozip.Open(omdipa.configuracion)
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
            oxmlestilo = oxmlestilos.BuscarPrimero("estilo", "clave", outil.Toma_Token(1, Me.cboestilo.SelectedItem, "-"))
            oxmllenguaje = New Nodo(ozip.getFileInflated(oxmlestilo.getValue("estilo.directorio") & oxmlestilo.getValue("estilo.configuracion")))
            oxmlparametros = oxmllenguaje.getPrimerNodo("code.parametros")
            Me.lblextension.Text = "Extensión : " & oxmlparametros.BuscarPrimero("parametro", "nombre", "extension_deprogramas").getValue("parametro.valor")

            'PASO 2: Valida los insumos necesarios
            If Me.txtdirectory.Text.Trim.Equals("") Then
                MsgBox("Es necesario que se seleccione un directorio desde donde se leerán los archivos", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If
            If Me.cboestilo.SelectedIndex < 0 Then
                MsgBox("Se necesita seleccionar el lenguaje de programación", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If

            'PASO 3: Procede a la lectura del directorio
            carchivos = outil.Leer_Directorio(Me.txtdirectory.Text, Me.chksubdirectorios.Checked, oxmlparametros.BuscarPrimero("parametro", "nombre", "extension_deprogramas").getValue("parametro.valor"))
            For Each oarch In carchivos
                Me.clbArchivos.Items.Add(oarch.Name + New String(" ", 200) + "|" + oarch.DirectoryName)
            Next
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontWizSyncProyCGI.btnleerdir_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontWizSyncProyCGI.btnleerdir_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub chkselectall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkselectall.CheckedChanged
        For i As Integer = 0 To Me.clbArchivos.Items.Count - 1
            Me.clbArchivos.SetItemChecked(i, Me.chkselectall.Checked)
        Next
    End Sub

    Private Sub Load_gridpantallas(ByVal scdsincronia As String, ByVal scdproyecto As String)
        Dim cpants As Collection
        Dim icountersync As Integer = 0

        Try
            gridpantalla.Rows.Clear()
            gridpantalla.Columns.Clear()
            gridpantalla.Columns.Add("clave", "Clave de Pantalla")
            gridpantalla.Columns.Add("estatus", "Estatus")
            gridpantalla.Columns.Add("codigo", "Codigo")
            gridpantalla.Columns.Add("nombre", "Nombre de la Pantalla")

            gridpantalla.Columns.Item("clave").Width = 60
            gridpantalla.Columns.Item("estatus").Width = 90
            gridpantalla.Columns.Item("codigo").Width = 80
            gridpantalla.Columns.Item("nombre").Width = 350

            gridpantalla.Columns.Item("clave").SortMode = DataGridViewColumnSortMode.NotSortable
            gridpantalla.Columns.Item("estatus").SortMode = DataGridViewColumnSortMode.NotSortable
            gridpantalla.Columns.Item("codigo").SortMode = DataGridViewColumnSortMode.NotSortable
            gridpantalla.Columns.Item("nombre").SortMode = DataGridViewColumnSortMode.NotSortable

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
                gridpantalla.Rows.Add(opant.cdpantalla, sestatus, opant.cdcodigo, opant.nbpantalla)
            Next
            txtpantallas.Text = "Un total de " & cpants.Count & " pantallas, y " & icountersync & " sincronizadas"
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontWizSyncProyCGI.Load_gridpantallas()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontWizSyncProyCGI.Load_gridpantallas()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Sub

    Private Sub btniniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btniniciar.Click
        Dim i As Integer = 1
        Dim o As Object
        Dim slanguaje As String
        Dim oxmlmain, oxmlestilos, oxmlestilo, oxmllenguaje, oxmlparametros, oxmlcomments As Nodo
        Dim ofile As ClassReader

        Try
            'PASO 1: Inicializa las variables
            Me.Cursor = Cursors.WaitCursor
            omdipa = Me.ParentForm
            Me.prbarmado.Maximum = Me.clbArchivos.CheckedItems.Count
            Me.prbarmado.Minimum = 0
            cClases = New Collection
            lstdebug.Items.Clear()
            slanguaje = outil.Toma_Token(2, Me.cboestilo.SelectedItem, "|")
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
            oxmlestilo = oxmlestilos.BuscarPrimero("estilo", "clave", outil.Toma_Token(1, Me.cboestilo.SelectedItem, "-"))
            oxmllenguaje = New Nodo(ozip.getFileInflated(oxmlestilo.getValue("estilo.directorio") & oxmlestilo.getValue("estilo.configuracion")))
            oxmlparametros = oxmllenguaje.getPrimerNodo("code.parametros")
            oxmlcomments = oxmllenguaje.getPrimerNodo("code.comentarios")

            'PASO 1: Validando todos los insumos...
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "STEP01: Validando que se hayan seleccionado los programas")
            If Me.clbArchivos.CheckedItems.Count = 0 Then
                Me.Cursor = Cursors.Default
                MsgBox("Es necesario seleccionar al menos un archivo para poder iniciar la incorporación !", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If

            'PASO 2: Haciendo un parse a cada uno de los programas fuentes...
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "STEP02: Parse a programas fuente...")
            ofile = New ClassReader
            Call Configura_Parametros(ofile, oxmlparametros)
            Call Configura_Comentarios(ofile, oxmlcomments)
            For Each o In Me.clbArchivos.CheckedItems
                outil.addToListDebug(lstdebug, "PARSE A [" + outil.Toma_Token(1, o, "|") + "]")
                ofile.dir = outil.Toma_Token(2, o, "|")
                ofile.file = outil.Toma_Token(1, o, "|")
                If Not ofile.Parse() Then
                    Dim cmsgs As Collection = ofile.getMensajes()
                    For Each omsg As Mensaje In cmsgs
                        outil.addToListDebug(lstdebug, "  " & omsg.clave & " - " & omsg.description)
                    Next
                Else
                    cClases.Add(ofile.GetClase())
                End If
                Me.prbarmado.Value = i
                i = i + 1
            Next

            'PASO 3: Haciendo un parse a cada uno de los programas fuentes...
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "! Proceso Terminado !")
            Me.Cursor = Cursors.Default
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontWizSyncProyCGI.btniniciar_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontWizSyncProyCGI.btniniciar_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub Configura_Parametros(ByRef ofile As ClassReader, ByRef oxmlparametros As Nodo)
        Dim oxmlpar As Nodo

        Try
            'PASO 1: expresión regular de la clase
            oxmlpar = oxmlparametros.BuscarPrimero("parametro", "nombre", "apuntador_clase")
            If oxmlpar Is Nothing Then oxmlpar = New Nodo()
            ofile.regclase = oxmlpar.getValue("parametro.valor")

            'PASO 2: expresión regular del comentario de la clase
            oxmlpar = oxmlparametros.BuscarPrimero("parametro", "nombre", "apuntador_comentario_clase")
            If oxmlpar Is Nothing Then oxmlpar = New Nodo()
            ofile.regcommentclase = oxmlpar.getValue("parametro.valor")

            'PASO 3: expresión regular del comentario de un metodo
            oxmlpar = oxmlparametros.BuscarPrimero("parametro", "nombre", "apuntador_comentario_metodo")
            If oxmlpar Is Nothing Then oxmlpar = New Nodo()
            ofile.regcommentmetodo = oxmlpar.getValue("parametro.valor")

            'PASO 4: expresión regular con el apuntador a un procedimiento
            oxmlpar = oxmlparametros.BuscarPrimero("parametro", "nombre", "apuntador_procedimiento")
            If oxmlpar Is Nothing Then oxmlpar = New Nodo()
            ofile.regprocedure = oxmlpar.getValue("parametro.valor")

            'PASO 5: expresión regular con los caracteres a eliminar
            oxmlpar = oxmlparametros.BuscarPrimero("parametro", "nombre", "chars_aeliminar_encomentario")
            If oxmlpar Is Nothing Then oxmlpar = New Nodo()
            ofile.regcarquitar = oxmlpar.getValue("parametro.valor")

            'PASO 6: expresión regular con los metodos sin retorno
            oxmlpar = oxmlparametros.BuscarPrimero("parametro", "nombre", "metodo_sin_retorno")
            If oxmlpar Is Nothing Then oxmlpar = New Nodo()
            ofile.regmetsinretorno = oxmlpar.getValue("parametro.valor")

            'PASO 7: expresión regular para los metodos publicos
            oxmlpar = oxmlparametros.BuscarPrimero("parametro", "nombre", "expresion_metodo_pulico")
            If oxmlpar Is Nothing Then oxmlpar = New Nodo()
            ofile.regmetpublico = oxmlpar.getValue("parametro.valor")


        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontWizSyncProyCGI.Configura_Parametros()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontWizSyncProyCGI.Configura_Parametros()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Sub

    Private Sub Configura_Comentarios(ByRef ofile As ClassReader, ByRef oxmlcomments As Nodo)
        Dim oxmlcomm As Nodo

        Try
            'PASO 1: determina cual es el comentario para una clase
            oxmlcomm = oxmlcomments.BuscarPrimero("comentario", "nombre", "clase")
            If oxmlcomm Is Nothing Then oxmlcomm = New Nodo()
            ofile.xmlclase = oxmlcomm

            'PASO 2: determina cual es el comentario para un metodo
            oxmlcomm = oxmlcomments.BuscarPrimero("comentario", "nombre", "metodo")
            If oxmlcomm Is Nothing Then oxmlcomm = New Nodo()
            ofile.xmlmetodo = oxmlcomm

            'PASO 2: determina cual es el comentario del pseudocodigo
            oxmlcomm = oxmlcomments.BuscarPrimero("comentario", "nombre", "pseudocodigo")
            If oxmlcomm Is Nothing Then oxmlcomm = New Nodo()
            ofile.xmlpseudocodigo = oxmlcomm

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontWizSyncProyCGI.Configura_Comentarios()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontWizSyncProyCGI.Configura_Comentarios()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
    End Sub

    Private Sub btnstaffload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstaffload.Click

        Try
            'PASO 1: Valida los insumos
            If Not Valida_Insumos() Then Exit Sub

            'PASO 2: Carga el grid de pantallas
            If radExiste.Checked Then
                Call Load_gridpantallas(outil.Toma_Token(1, Me.cbosincronia.SelectedItem.ToString, "-"), outil.Toma_Token(1, Me.cboproyecto.SelectedItem.ToString, "-"))
            Else
                Call Load_gridpantallas("", outil.Toma_Token(1, Me.cboproyecto.SelectedItem.ToString, "-"))
            End If
        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontWizSyncProyCGI.btnstaffload_Click()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontWizSyncProyCGI.btnstaffload_Click()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try
    End Sub

    ''' <summary>
    ''' Función para validar los insumos que participan en la generación
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Valida_Insumos() As Boolean

        Try
            If cboproyecto.SelectedIndex < 0 Then
                MsgBox("No hay ningún proyecto seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Return False
            End If

            If radExiste.Checked Then
                If cbosincronia.SelectedIndex < 0 Then
                    MsgBox("No hay ninguna sincronia seleccionada", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                    Return False
                End If
            End If
            If radNueva.Checked Then
                If txtsincronia.Text.Trim.Equals("") Then
                    MsgBox("Es necesario ingresar los datos de la nueva sincronizacion", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                    Return False
                End If
                If Me.cboFrontEnd.SelectedIndex < 0 Then
                    MsgBox("Es necesario ingresar el lenguaje en que se está sincronizando", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                    Return False
                End If
            End If

            'If cClases.Count = 0 Then
            'MsgBox("Es necesario ingresar los programas del back-end para su sincronización con prototipo.", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
            'Return False
            'End If

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontWizSyncProyCGI.Valida_Insumos()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmFrontWizSyncProyCGI.Valida_Insumos()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

        Return True
    End Function

    Private Sub btnsync_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsync.Click

        Try
            'PASO 1: Valida los insumos
            If Not Valida_Insumos() Then Exit Sub

            If Me.gridpantalla.SelectedRows.Count > 0 Then
                Dim ofrm As frmFrontSyncPantCGI

                'PASO 2: Si es una nueva sincronización, la da de alta
                If radNueva.Checked And Me.scdsincronia.Equals("") Then
                    Dim oadd As Sincronia
                    oadd = New Sincronia()
                    oadd.cdproyecto = outil.Toma_Token(1, cboproyecto.SelectedItem.ToString, "-")
                    oadd.cdestilogenera = outil.Toma_Token(1, cboFrontEnd.SelectedItem.ToString, "-")
                    oadd.nbsincronia = txtsincronia.Text
                    obus.addSincronia(oadd)
                    Call Carga_Sincronias(oadd.cdproyecto)
                    cbosincronia.SelectedIndex = cbosincronia.FindString(oadd.cdsincronia)
                    radExiste.Checked = True
                    Me.scdsincronia = oadd.cdsincronia
                Else
                    Me.scdsincronia = outil.Toma_Token(1, Me.cbosincronia.SelectedItem.ToString, "-")
                End If

                'PASO 3: Ahora muestra la pantalla de sincronización para la pantalla seleccionada
                ofrm = New frmFrontSyncPantCGI
                ofrm.MdiParent = Me.ParentForm
                ofrm.cdproject = outil.Toma_Token(1, Me.cboproyecto.SelectedItem, "-")
                ofrm.cdpantalla = Me.gridpantalla.SelectedRows.Item(0).Cells("clave").Value
                ofrm.cdsincronia = Me.scdsincronia
                ofrm.Text = ofrm.Text & " " & Me.gridpantalla.SelectedRows.Item(0).Cells("codigo").Value & " - " & Me.gridpantalla.SelectedRows.Item(0).Cells("nombre").Value
                ofrm.Clases = cClases
                ofrm.Show()
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If

        Catch ex As HANYException
            ex.add("MyGENARO.frmFrontWizSyncProyCGI.btnsync_Click()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmFrontWizSyncProyCGI.btnsync_Click()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub cboproyecto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboproyecto.SelectedIndexChanged
        If cboproyecto.SelectedIndex > 0 Then
            Call Carga_Sincronias(outil.Toma_Token(1, Me.cboproyecto.SelectedItem, "-"))
        End If
    End Sub

    Private Sub radNueva_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNueva.CheckedChanged
        cbosincronia.Enabled = False
        lblnvoestilo.Enabled = True
        cboFrontEnd.Enabled = True
        txtsincronia.Enabled = True
    End Sub

    Private Sub radExiste_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radExiste.CheckedChanged
        cbosincronia.Enabled = True
        lblnvoestilo.Enabled = False
        cboFrontEnd.Enabled = False
        txtsincronia.Enabled = False
    End Sub
End Class