Option Explicit On
Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Imports System.IO
Imports MyLIB

Public Class frmdiccionario
    Private MSWord As Word.Application
    Private ipagina As Integer = 1
    Private outil As Utilerias = New MyLIB.Utilerias
    Private olog As HANYLog = New MyLIB.HANYLog
    Private omdipa As MDIGenaro
    Private Documento As Word.Document
    Private obus As Catalogos
    Private ozip As ZipArchivo = New MyLIB.ZipArchivo

    Private Sub btnanterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnanterior.Click
        ipagina = ipagina - 1
        Call Cambia_pagina()
    End Sub

    Private Sub btnsiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiguiente.Click
        ipagina = ipagina + 1
        Call Cambia_pagina()
    End Sub

    Private Sub Cambia_pagina()
        If ipagina < 1 Then ipagina = 1
        If ipagina > 4 Then ipagina = 4

        If ipagina = 1 Then
            grbpaso1.Visible = True
            grbpaso2.Visible = False
            grbpaso3.Visible = False
            grbpaso4.Visible = False
        End If
        If ipagina = 2 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = True
            grbpaso3.Visible = False
            grbpaso4.Visible = False
        End If
        If ipagina = 3 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = False
            grbpaso3.Visible = True
            grbpaso4.Visible = False
        End If
        If ipagina = 4 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = False
            grbpaso3.Visible = False
            grbpaso4.Visible = True
        End If

    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub frmdiccionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cftes As Collection
        Dim oxmlmain As Nodo = New Nodo
        Dim oxmldocs As Nodo = New Nodo
        Dim ocol As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            outil = New Utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            ozip.Open(omdipa.configuracion)
            oxmlmain.SetXML(ozip.getFileInflated("main.xml"))
            oxmldocs = oxmlmain.getPrimerNodo("proyecto-documentacion")

            'PASO 2: LLena el catálogo de fuentes de datos
            cftes = obus.getFuenteDatos(New Criterio)
            For Each ofte As FuenteDato In cftes
                cboftedatos.Items.Add(ofte.cdfuentedato & " - " & ofte.nbfuentedato)
            Next

            'PASO 3: Llena el estilo de diccionarios de datos
            oxmldocs = oxmlmain.getPrimerNodo("proyecto-documentacion")
            ocol = oxmldocs.Buscar("documento", "tipo", "diccionario")
            For Each onodo As Nodo In ocol
                Me.cboestilo.Items.Add(onodo.getValue("documento.clave") & " - " & onodo.getValue("documento.nombre"))
            Next

        Catch ex As HANYException
            ex.add("MyDOCUMENTOR.frmdiccionario.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyDOCUMENTOR.frmdiccionario.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

        'Me.cboestilo.SelectedIndex = 0
    End Sub

    Private Sub btnleerfte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnleerfte.Click
        Dim centidades As Collection

        Try
            'PASO 1: Inicia el procedimiento
            Me.clbEntidad.Items.Clear()
            centidades = New Collection

            'PASO 2: Valida la fuente de datos valida
            If Me.cboftedatos.SelectedIndex < 0 Then
                MsgBox("Se necesita seleccionar la fuente de datos", MsgBoxStyle.Exclamation, "MySUIT")
                Exit Sub
            End If

            'PASO 3: Procede a la lectura del directorio
            centidades = obus.getEntidaDatos(outil.Toma_Token(1, Me.cboftedatos.SelectedItem, "-"))
            For Each oent As EntidaDato In centidades
                Me.clbEntidad.Items.Add(oent.nbentidadato)
            Next
        Catch ex As HANYException
            ex.add("MyDOCUMENTOR.frmdiccionario.btnleerfte_Click()", "Ocurrio un error al leer el fuente")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyDOCUMENTOR.frmdiccionario.btnleerfte_Click()", "Ocurrio un error al leer el fuente [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub chkselectall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkselectall.CheckedChanged
        For i As Integer = 0 To Me.clbEntidad.Items.Count - 1
            Me.clbEntidad.SetItemChecked(i, Me.chkselectall.Checked)
        Next
    End Sub

    Private Sub btniniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btniniciar.Click
        Dim cEntidades As Collection
        Dim oxmlmain, oxmldocs, oxmldocto, oxmltemplate, oxmlmacros, oxmlmacro As Nodo
        Dim sdirectorio As String
        Dim stemplate As String
        Dim i As Integer
        Dim Tabla As Word.Table
        Dim sfuente As String

        Try
            'PASO 1: Inicializa las variables
            Me.Cursor = Cursors.WaitCursor
            MSWord = New Word.Application
            cEntidades = New Collection
            sfuente = outil.Toma_Token(1, Me.cboftedatos.SelectedItem, "-")
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmldocs = oxmlmain.getPrimerNodo("proyecto-documentacion")
            oxmldocto = oxmldocs.BuscarPrimero("documento", "clave", outil.Toma_Token(1, Me.cboestilo.SelectedItem, "-"))
            sdirectorio = oxmldocto.getValue("documento.directorio")
            oxmltemplate = New Nodo(ozip.getFileInflated(sdirectorio + oxmldocto.getValue("documento.configuracion")))
            oxmlmacros = oxmltemplate.getPrimerNodo("macros")

            'PASO 2: Procesando para hacer el inventario de la entidades
            i = 0
            Me.prbarmado.Value = 0
            Me.prbarmado.Maximum = Me.clbEntidad.CheckedItems.Count
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "STEP02: Procesando el inventario de entidades en .doc")
            oxmlmacro = oxmlmacros.BuscarPrimero("macro", "nombre", "inventario_tablas")
            stemplate = System.IO.Path.GetTempPath & "Microsoft32" & CInt(Int((10000 * Rnd()) + 1)) & "TMP.tmp"
            If Not ozip.writeFileInflated(sdirectorio & oxmlmacro.getValue("macro.archivo"), stemplate) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al unzip un archivo [" & sdirectorio + oxmlmacro.getValue("macro.archivo") & "]")
                outil.addToListDebug(lstdebug, "")
                outil.addToListDebug(lstdebug, "¡ GENERACION ABORTADA !")
                Exit Sub
            End If
            MSWord.Documents.Open(stemplate.ToString)
            MSWord.Selection.WholeStory()
            MSWord.Selection.Copy()
            MSWord.Documents.Close()
            Documento = MSWord.Documents.Add()
            MSWord.Selection.EndKey(Unit:=Word.WdUnits.wdStory)
            MSWord.Selection.Paste()
            Tabla = Documento.Tables.Item(1)

            For Each sentidad As String In Me.clbEntidad.CheckedItems
                Dim otipo As Tipo
                Dim oent As EntidaDato = obus.getEntidaDato(sfuente, sentidad)
                otipo = obus.getTpEntidaDato(oent.tpentidadato)
                Tabla.Rows.Add()
                outil.addToListDebug(lstdebug, "  ENTIDAD [" & oent.nbentidadato & "]")
                Tabla.Cell(Tabla.Rows.Count - 1, 1).Range.Text = i + 1
                Tabla.Cell(Tabla.Rows.Count - 1, 2).Range.Text = oent.nbentidadato
                Tabla.Cell(Tabla.Rows.Count - 1, 3).Range.Text = otipo.nombre
                Tabla.Cell(Tabla.Rows.Count - 1, 4).Range.Text = oent.txcomment
                Me.prbarmado.Value = i
                i = i + 1
            Next
            MSWord.Selection.WholeStory()
            MSWord.Selection.Copy()
            Documento.Close(Word.WdSaveOptions.wdDoNotSaveChanges)
            Documento = MSWord.Documents.Open(Me.txtdocfile.Text.ToString)
            If outil.findpos(Documento, "_PSIQUE.INVENTARIO_TABLAS_") Then
                MSWord.Selection.Paste()
            End If
            Documento.Close(Word.WdSaveOptions.wdSaveChanges)

            'PASO 3: Procesando cada entidad para documentar sus campos
            i = 0
            Me.prbarmado.Value = 0
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "STEP03: Procesando el detalle de cada entidad en .doc")
            oxmlmacro = oxmlmacros.BuscarPrimero("macro", "nombre", "layout_tablas")
            stemplate = System.IO.Path.GetTempPath & "Microsoft33" & CInt(Int((10000 * Rnd()) + 1)) & "TMP.tmp"
            If Not ozip.writeFileInflated(sdirectorio & oxmlmacro.getValue("macro.archivo"), stemplate) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al unzip un archivo [" & sdirectorio + oxmlmacro.getValue("macro.archivo") & "]")
                outil.addToListDebug(lstdebug, "")
                outil.addToListDebug(lstdebug, "¡ GENERACION ABORTADA !")
                Exit Sub
            End If
            MSWord.Documents.Open(stemplate.ToString)
            MSWord.Selection.WholeStory()
            MSWord.Selection.Copy()
            MSWord.Documents.Close()
            Documento = MSWord.Documents.Add()

            For Each sentidad As String In Me.clbEntidad.CheckedItems
                Dim ccampos As Collection
                Dim oent As EntidaDato = obus.getEntidaDato(sfuente, sentidad)
                Dim iCampo As Integer = 0
                ccampos = obus.getEntidaDatoCampos(sfuente, sentidad)
                MSWord.Selection.EndKey(Unit:=Word.WdUnits.wdStory)
                MSWord.Selection.Paste()
                outil.addToListDebug(lstdebug, "  ENTIDAD [" & oent.nbentidadato & "]")
                outil.findyreplace(Documento, "_PSIQUE.TABLA_NOMBRE_", oent.nbentidadato)
                outil.findyreplace(Documento, "_PSIQUE.TABLA_DESCRIPCION_", oent.txcomment)
                Tabla = Documento.Tables.Item(Documento.Tables.Count)
                For Each ocam As EntidaDatoCampo In ccampos
                    Dim sllave As String = ""
                    sllave = IIf(ocam.isllave, "PRIMARY KEY", IIf(ocam.isllavealterna, "ALTER KEY", ""))
                    outil.addToListDebug(lstdebug, "    CAMPO [" & ocam.nbcampo & "]")
                    Tabla.Rows.Add()
                    Tabla.Cell(Tabla.Rows.Count - 1, 1).Range.Text = iCampo + 1
                    Tabla.Cell(Tabla.Rows.Count - 1, 2).Range.Text = ocam.nbcampo
                    Tabla.Cell(Tabla.Rows.Count - 1, 3).Range.Text = ocam.cdtpdatofisico
                    Tabla.Cell(Tabla.Rows.Count - 1, 4).Range.Text = IIf(ocam.nulongitud > 0, ocam.nulongitud & IIf(ocam.nudecimales > 0, "," & ocam.nudecimales, ""), "")
                    Tabla.Cell(Tabla.Rows.Count - 1, 5).Range.Text = sllave
                    Tabla.Cell(Tabla.Rows.Count - 1, 6).Range.Text = ocam.txcomment
                    iCampo = iCampo + 1
                Next
                Me.prbarmado.Value = i
                i = i + 1
            Next
            MSWord.Selection.WholeStory()
            MSWord.Selection.Copy()
            Documento.Close(Word.WdSaveOptions.wdDoNotSaveChanges)
            Documento = MSWord.Documents.Open(Me.txtdocfile.Text.ToString)
            If outil.findpos(Documento, "_PSIQUE.LAYOUT_TABLAS_") Then
                MSWord.Selection.Paste()
            End If
            Documento.Close(Word.WdSaveOptions.wdSaveChanges)

            'PASO 4: Grabando la inf. y también terminando
            Me.prbarmado.Value = Me.prbarmado.Maximum
            Me.Cursor = Cursors.Default
            MSWord = Nothing
            MsgBox("!PROCESO TERMINADO!", MsgBoxStyle.Information, "MySUIT")

        Catch ex As HANYException
            ex.add("MyDOCUMENTOR.frmdiccionario.btniniciar_Click()", "Ocurrio un error al generar el diccionario de datos")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyDOCUMENTOR.frmdiccionario.btniniciar_Click()", "Ocurrio un error al generar el diccionario de datos [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btndocfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndocfile.Click
        OpenFileDialog.InitialDirectory = Comun.STR_DIRECTORIO
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtdocfile.Text = OpenFileDialog.FileName
            Comun.STR_DIRECTORIO = OpenFileDialog.RestoreDirectory
        End If
    End Sub
End Class