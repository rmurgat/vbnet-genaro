Option Explicit On

Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Imports System.IO
Imports MyLIB

Public Class frmdfgenera
    Private MSWord As Word.Application
    Private ipagina As Integer = 1
    Private outil As Utilerias = New MyLIB.Utilerias
    Private olog As HANYLog = New MyLIB.HANYLog
    Private omdipa As MDIGenaro
    Private Documento As Word.Document
    Private obus As Catalogos
    Private ozip As ZipArchivo = New MyLIB.ZipArchivo

    Private Sub btndocfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de Word (*.docx)|*.docx"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtdocfile.Text = OpenFileDialog.FileName
        End If
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
        If ipagina > 3 Then ipagina = 3

        If ipagina = 1 Then
            grbpaso1.Visible = True
            grbpaso2.Visible = False
            grbpaso3.Visible = False
        End If
        If ipagina = 2 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = True
            grbpaso3.Visible = False
        End If
        If ipagina = 3 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = False
            grbpaso3.Visible = True
        End If

    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub frmdfcompiladocto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oxmlmain As Nodo = New Nodo
        Dim oxmldocs As Nodo = New Nodo
        Dim cproys As Collection
        Dim ocrit As Criterio
        Dim ocol As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            outil = New Utilerias
            ocrit = New Criterio
            ozip.Open(omdipa.configuracion)
            oxmlmain.SetXML(ozip.getFileInflated("main.xml"))
            oxmldocs = oxmlmain.getPrimerNodo("proyecto-documentacion")

            'PASO 2: LLena el catálogo de proyectos
            cproys = obus.getProyectos(ocrit)
            For Each oproy As Proyecto In cproys
                cboproyecto.Items.Add(oproy.cdproyecto & " - " & oproy.nbproyecto)
            Next

            'PASO 3: Llena el catálogo de tipos de documentación
            oxmldocs = oxmlmain.getPrimerNodo("proyecto-documentacion")
            ocol = oxmldocs.Buscar("documento", "tipo", "funcional")
            For Each onodo As Nodo In ocol
                Me.cbotipo.Items.Add(onodo.getValue("documento.clave") & " - " & onodo.getValue("documento.nombre"))
            Next
            Me.cbotipo.SelectedIndex = 0

        Catch ex As HANYException
            ex.add("MyDOCUMENTOR.frmdfgenera.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyDOCUMENTOR.frmdfgenera.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btndocfile_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndocfile.Click
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de Word (*.docx)|*.docx"
        OpenFileDialog.InitialDirectory = Comun.STR_DIRECTORIO
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtdocfile.Text = OpenFileDialog.FileName
            Comun.STR_DIRECTORIO = OpenFileDialog.RestoreDirectory
        End If
    End Sub

    Private Sub btniniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btniniciar.Click
        Dim i As Integer = 1
        Dim Tabla As Word.Table
        Dim cpantallas As Collection
        Dim creportes As Collection
        Dim oxmlmain As Nodo = New Nodo
        Dim oxmldocs As Nodo
        Dim oxmldocto As Nodo
        Dim oxmlmacros As Nodo
        Dim oxmltemplate As Nodo
        Dim oxmlmacro As Nodo
        Dim sdirectorio As String
        Dim stemplate As String

        omdipa = Me.ParentForm

        Try
            'PASO 1: Iniciando variables...
            Me.Cursor = Cursors.WaitCursor
            oxmlmain.SetXML(ozip.getFileInflated("main.xml"))
            oxmldocs = oxmlmain.getPrimerNodo("proyecto-documentacion")
            oxmldocto = oxmldocs.BuscarPrimero("documento", "clave", outil.Toma_Token(1, Me.cbotipo.SelectedItem, "-"))
            sdirectorio = oxmldocto.getValue("documento.directorio")
            oxmltemplate = New Nodo(ozip.getFileInflated(sdirectorio + oxmldocto.getValue("documento.configuracion")))
            oxmlmacros = oxmltemplate.getPrimerNodo("macros")
            cpantallas = obus.getPantallas(outil.Toma_Token(1, Me.cboproyecto.SelectedItem, "-"))
            creportes = obus.getReportes(outil.Toma_Token(1, Me.cboproyecto.SelectedItem, "-"))
            MSWord = New Word.Application

            'PASO 2: Iniciando pantalla...
            Me.prbdocto.Maximum = cpantallas.Count + creportes.Count
            Me.prbdocto.Minimum = 0
            lstdebug.Items.Clear()

            'PASO 3: Validando todos los insumos
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "STEP01: Validando los insumos de la generación")
            If Me.cboproyecto.SelectedIndex < 0 Then
                Me.Cursor = Cursors.Default
                MsgBox("Es necesario seleccionar al menos un proyecto para poder iniciar la compilación !", MsgBoxStyle.Exclamation, "MySUIT")
                outil.addToListDebug(lstdebug, "")
                outil.addToListDebug(lstdebug, "¡ GENERACION ABORTADA !")
                Exit Sub
            End If
            If Me.txtdocfile.Text.Equals("") Then
                Me.Cursor = Cursors.Default
                MsgBox("Es necesario abrir primero el archivo donde se grabará el diseño funcional !", MsgBoxStyle.Exclamation, "MySUIT")
                outil.addToListDebug(lstdebug, "")
                outil.addToListDebug(lstdebug, "¡ GENERACION ABORTADA !")
                Exit Sub
            End If
            If Me.cbotipo.Text.Equals("") Then
                Me.Cursor = Cursors.Default
                MsgBox("Es necesario seleccionar el tipo de diseño funcional !", MsgBoxStyle.Exclamation, "MySUIT")
                outil.addToListDebug(lstdebug, "")
                outil.addToListDebug(lstdebug, "¡ GENERACION ABORTADA !")
                Exit Sub
            End If

            'PASO 4: Procesando para hacer el inventario de las pantallas
            i = 0
            Me.prbdocto.Value = 0
            outil.addToListDebug(lstdebug, "")
            oxmlmacro = oxmlmacros.BuscarPrimero("macro", "nombre", "inventario_pantallas")
            outil.addToListDebug(lstdebug, "STEP02: Procesando el inventario de pantallas en .doc")
            stemplate = System.IO.Path.GetTempPath & "Microsoft04" & CInt(Int((10000 * Rnd()) + 1)) & "TMP.tmp"
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

            For Each opan As Pantalla In cpantallas
                Tabla.Rows.Add()
                outil.addToListDebug(lstdebug, "  PANTALLA [" & opan.cdcodigo & "]")
                Tabla.Cell(Tabla.Rows.Count - 1, 1).Range.Text = opan.cdcodigo
                Tabla.Cell(Tabla.Rows.Count - 1, 2).Range.Text = opan.nbpantalla
                Me.prbdocto.Value = i
                i = i + 1
            Next
            MSWord.Selection.WholeStory()
            MSWord.Selection.Copy()
            Documento.Close(Word.WdSaveOptions.wdDoNotSaveChanges)
            Documento = MSWord.Documents.Open(Me.txtdocfile.Text.ToString)
            If outil.findpos(Documento, "_PSIQUE.INVENTARIO_PANTALLAS_") Then
                MSWord.Selection.Paste()
            End If
            Documento.Close(Word.WdSaveOptions.wdSaveChanges)

            'PASO 5: Procesando cada pantalla para documentar su imagen + sus campos + sus botones
            i = 0
            Me.prbdocto.Value = 0
            outil.addToListDebug(lstdebug, "")
            oxmlmacro = oxmlmacros.BuscarPrimero("macro", "nombre", "detalle_pantallas")
            outil.addToListDebug(lstdebug, "STEP03: Procesando el detalle de cada pantalla en .doc")
            stemplate = System.IO.Path.GetTempPath & "Microsoft05" & CInt(Int((10000 * Rnd()) + 1)) & "TMP.tmp"
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

            For Each opan As Pantalla In cpantallas
                Dim ccampos As Collection
                Dim cbotones As Collection

                ccampos = obus.getPantallaCampos(opan.cdproyecto, opan.cdpantalla)
                cbotones = obus.getPantallaBotones(opan.cdproyecto, opan.cdpantalla)
                MSWord.Selection.EndKey(Unit:=Word.WdUnits.wdStory)
                MSWord.Selection.Paste()
                outil.addToListDebug(lstdebug, "  PANTALLA [" & opan.cdcodigo & "]")
                outil.findyreplace(Documento, "_PSIQUE.PANTALLA_CODIGO_", opan.cdcodigo)
                outil.findyreplace(Documento, "_PSIQUE.PANTALLA_NOMBRE_", opan.nbpantalla)
                outil.findpos(Documento, "_PSIQUE.PANTALLA_OBJETIVO_")
                Documento.ActiveWindow.Selection.Text = opan.txobjetivo
                outil.findpos(Documento, "_PSIQUE.PANTALLA_DESCRIPCION_")
                Documento.ActiveWindow.Selection.Text = opan.txcomment

                If outil.Existe_Archivo(opan.nbimagefile) Then
                    outil.findpos(Documento, "_PSIQUE.PANTALLA_IMAGEN_")
                    Documento.ActiveWindow.Selection.InlineShapes.AddPicture(opan.nbimagefile)
                End If

                Tabla = Documento.Tables.Item(Documento.Tables.Count - 1)
                For Each ocam As PantallaCampo In ccampos
                    outil.addToListDebug(lstdebug, "    CAMPO [" & ocam.nbcampo & "]")
                    Tabla.Rows.Add()
                    Tabla.Cell(Tabla.Rows.Count, 1).Range.Text = ocam.nbcampo
                    Tabla.Cell(Tabla.Rows.Count, 2).Range.Text = ocam.txcomment
                Next
                Tabla = Documento.Tables.Item(Documento.Tables.Count)
                For Each obot As PantallaBoton In cbotones
                    outil.addToListDebug(lstdebug, "    BOTON [" & obot.nbboton & "]")
                    Tabla.Rows.Add()
                    Tabla.Cell(Tabla.Rows.Count, 1).Range.Text = obot.nbboton
                    Tabla.Cell(Tabla.Rows.Count, 2).Range.Text = obot.txcomment
                Next

                Me.prbdocto.Value = i
                i = i + 1
            Next

            MSWord.Selection.WholeStory()
            MSWord.Selection.Copy()

            Documento.Close(Word.WdSaveOptions.wdDoNotSaveChanges)

            Documento = MSWord.Documents.Open(Me.txtdocfile.Text.ToString)
            If outil.findpos(Documento, "_PSIQUE.DETALLE_PANTALLAS_") Then
                MSWord.Selection.Paste()
            End If

            'PASO 6: Procesando el inventario de reportes
            i = 0
            Me.prbdocto.Value = 0
            Me.prbdocto.Maximum = creportes.Count
            outil.addToListDebug(lstdebug, "")
            oxmlmacro = oxmlmacros.BuscarPrimero("macro", "nombre", "inventario_reportes")
            outil.addToListDebug(lstdebug, "STEP04: Procesando el inventario de reportes en .doc")
            stemplate = System.IO.Path.GetTempPath & "Microsoft06" & CInt(Int((10000 * Rnd()) + 1)) & "TMP.tmp"
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

            For Each orep As Reporte In creportes
                Tabla.Rows.Add()
                outil.addToListDebug(lstdebug, "  REPORTE [" & orep.cdcodigo & "]")
                Tabla.Cell(Tabla.Rows.Count - 1, 1).Range.Text = orep.cdcodigo
                Tabla.Cell(Tabla.Rows.Count - 1, 2).Range.Text = orep.nbreporte
                Me.prbdocto.Value = i
                i = i + 1
            Next
            MSWord.Selection.WholeStory()
            MSWord.Selection.Copy()
            Documento.Close(Word.WdSaveOptions.wdDoNotSaveChanges)
            Documento = MSWord.Documents.Open(Me.txtdocfile.Text.ToString)
            If outil.findpos(Documento, "_PSIQUE.INVENTARIO_REPORTES_") Then
                MSWord.Selection.Paste()
            End If
            Documento.Close(Word.WdSaveOptions.wdSaveChanges)

            'PASO 7: Procesando el detalle de cada reporte
            i = 0
            Me.prbdocto.Value = 0
            outil.addToListDebug(lstdebug, "")
            oxmlmacro = oxmlmacros.BuscarPrimero("macro", "nombre", "detalle_reportes")
            outil.addToListDebug(lstdebug, "STEP05: Procesando el detalle de cada reporte en .doc")
            stemplate = System.IO.Path.GetTempPath & "Microsoft07" & CInt(Int((10000 * Rnd()) + 1)) & "TMP.tmp"
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

            For Each orep As Reporte In creportes
                Dim ccampos As Collection

                ccampos = obus.getReporteCampos(orep.cdproyecto, orep.cdreporte)
                MSWord.Selection.EndKey(Unit:=Word.WdUnits.wdStory)
                MSWord.Selection.Paste()
                outil.addToListDebug(lstdebug, "  REPORTE [" & orep.cdcodigo & "]")
                outil.findyreplace(Documento, "_PSIQUE.REPORTE_CODIGO_", orep.cdcodigo)
                outil.findyreplace(Documento, "_PSIQUE.REPORTE_NOMBRE_", orep.nbreporte)
                outil.findpos(Documento, "_PSIQUE.REPORTE_OBJETIVO_")
                Documento.ActiveWindow.Selection.Text = orep.txobjetivo
                outil.findpos(Documento, "_PSIQUE.REPORTE_DESCRIPCION_")
                Documento.ActiveWindow.Selection.Text = orep.txcomment

                If outil.Existe_Archivo(orep.nbimagefile) Then
                    outil.findpos(Documento, "_PSIQUE.REPORTE_IMAGEN_")
                    Documento.ActiveWindow.Selection.InlineShapes.AddPicture(orep.nbimagefile)
                End If

                'aqui van a ir los criterios
                'Tabla = Documento.Tables.Item(Documento.Tables.Count - 1)
                'For Each ocam As PantallaCampo In ccampos
                'outil.addToListDebug(lstdebug, "    CAMPO [" & ocam.nbcampo & "]")
                'Tabla.Rows.Add()
                'Tabla.Cell(Tabla.Rows.Count, 1).Range.Text = ocam.nbcampo
                'Tabla.Cell(Tabla.Rows.Count, 2).Range.Text = ocam.txcomment
                'Next
                Tabla = Documento.Tables.Item(Documento.Tables.Count)
                For Each ocam As ReporteCampo In ccampos
                    outil.addToListDebug(lstdebug, "    CAMPO [" & ocam.nbcampo & "]")
                    Tabla.Rows.Add()
                    Tabla.Cell(Tabla.Rows.Count, 1).Range.Text = ocam.nbcampo
                    Tabla.Cell(Tabla.Rows.Count, 2).Range.Text = ocam.txcomment
                Next

                Me.prbdocto.Value = i
                i = i + 1
            Next

            MSWord.Selection.WholeStory()
            MSWord.Selection.Copy()

            Documento.Close(Word.WdSaveOptions.wdDoNotSaveChanges)

            Documento = MSWord.Documents.Open(Me.txtdocfile.Text.ToString)
            If outil.findpos(Documento, "_PSIQUE.DETALLE_REPORTES_") Then
                MSWord.Selection.Paste()
            End If

            Documento.Close(Word.WdSaveOptions.wdSaveChanges)

            If Me.chkopenfile.Checked Then
                MSWord.Visible = True
            End If

            'PASO 5: Grabando la inf. y también terminando
            Me.Cursor = Cursors.Default
            Me.prbdocto.Value = Me.prbdocto.Maximum
            MSWord = Nothing
            MsgBox("!PROCESO TERMINADO!", MsgBoxStyle.Information, "MySUIT")

        Catch ex As HANYException
            ex.add("MyDOCUMENTOR.frmdfgenera.btniniciar_Click()", "Ocurrio un error al generar el diseño funcional")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyDOCUMENTOR.frmdfgenera.btniniciar_Click()", "Ocurrio un error al generar el diseño funcional [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub cbotipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotipo.SelectedIndexChanged

    End Sub
End Class