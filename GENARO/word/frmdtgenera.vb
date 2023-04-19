Option Explicit On
Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Imports System.IO
Imports MyLIB

''' <summary>
'''    Clase para ejecutar el wizard de visual basic
''' </summary>
''' <remarks></remarks>
Public Class frmdtgenera
    Private MSWord As Word.Application
    Private ipagina As Integer = 1
    Private outil As Utilerias = New MyLIB.Utilerias
    Private olog As HANYLog = New MyLIB.HANYLog
    Private omdipa As MDIGenaro
    Private Documento As Word.Document
    Private obus As Catalogos
    Private ozip As ZipArchivo = New MyLIB.ZipArchivo

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
            grbpaso2.Visible = True
            grbpaso3.Visible = False
            grbpaso4.Visible = False
            grbpaso5.Visible = False
        End If
        If ipagina = 2 Then
            grbpaso1.Visible = False
            grbpaso2.Visible = True
            grbpaso3.Visible = False
            grbpaso4.Visible = False
            grbpaso5.Visible = False
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

    Private Sub frmvalidcomment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oxmlmain, oxmlestilos, oxmldocs As Nodo
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
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
            oxmldocs = oxmlmain.getPrimerNodo("proyecto-documentacion")

            'PASO 2: LLena el catálogo de proyectos
            cproys = obus.getProyectos(ocrit)
            For Each oproy As Proyecto In cproys
                cboproyecto.Items.Add(oproy.cdproyecto & " - " & oproy.nbproyecto)
            Next

            'PASO 3: Llena el catálogo de tipos de documentación
            ocol = oxmldocs.Buscar("documento", "tipo", "tecnico")
            For Each onodo As Nodo In ocol
                Me.cbotipo.Items.Add(onodo.getValue("documento.clave") & " - " & onodo.getValue("documento.nombre"))
            Next
            Me.cbotipo.SelectedIndex = 0

            'PASO 4: Llena el catálogo con los estilos de la documentación
            ocol = oxmlestilos.Buscar("estilo", "tipo", "model")
            For Each onodo As Nodo In ocol
                Me.cboestilo.Items.Add(onodo.getValue("estilo.clave") & " - " & onodo.getValue("estilo.nombre"))
            Next
            Me.cboestilo.SelectedIndex = 0

        Catch ex As HANYException
            ex.add("MyDOCUMENTOR.frmdtgenera.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyDOCUMENTOR.frmdtgenera.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnterminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnterminar.Click
        Me.Close()
    End Sub

    Private Sub btndocfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndocfile.Click
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de Word (*.docx)|*.docx"
        OpenFileDialog.InitialDirectory = Comun.STR_DIRECTORIO
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtdocfile.Text = OpenFileDialog.FileName
            Comun.STR_DIRECTORIO = OpenFileDialog.RestoreDirectory
        End If
    End Sub

    Private Function Inserta_renglones(ByRef tabla As Word.Table, ByVal icounter As Integer) As Boolean
        Dim i As Integer

        'PASO 2: Inserta los renglones para campos
        Try
            For i = 0 To icounter
                tabla.Rows.Add()
                tabla.Cell(tabla.Rows.Count - 1, 1).Range.Text = "_PSIQUECLASSMETHODNAME" & i & "_"
                tabla.Cell(tabla.Rows.Count - 1, 3).Range.Text = "_PSIQUECLASSMETHODESCRIPTION" & i & "_"
            Next i

        Catch ex As Exception
            'MsgBox("Error al insertar renglones en tabla " & ex.Message)
            Return False
        End Try

        'PASO 3 : Termina
        Return True
    End Function


    Private Sub btnexaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexaminar.Click

        FolderBrowserDialog.SelectedPath = Comun.STR_DIRECTORIO
        If (FolderBrowserDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtdirectory.Text = FolderBrowserDialog.SelectedPath
            Comun.STR_DIRECTORIO = Me.txtdirectory.Text
        End If

    End Sub

    Private Sub btnleerdir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnleerdir.Click
        Dim oxmlmain, oxmlestilos, oxmlestilo, oxmlenguaje, oxmlparametros As Nodo
        Dim carchivos As Collection
        Dim oarch As FileInfo

        Try
            'PASO 1: Inicia el procedimiento
            Me.clbArchivos.Items.Clear()
            carchivos = New Collection
            ozip.Open(omdipa.configuracion)
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
            oxmlestilo = oxmlmain.BuscarPrimero("estilo", "clave", outil.Toma_Token(1, Me.cboestilo.SelectedItem, "-"))
            oxmlenguaje = New Nodo(ozip.getFileInflated(oxmlestilo.getValue("estilo.directorio") & oxmlestilo.getValue("estilo.configuracion")))
            oxmlparametros = oxmlenguaje.getPrimerNodo("parametros")
            Me.lblextension.Text = "Extensión : " & oxmlparametros.BuscarPrimero("parametro", "nombre", "extension_deprogramas").getValue("parametro.valor")

            'PASO 2: Valida los insumos necesarios
            If Me.txtdirectory.Text.Trim.Equals("") Then
                MsgBox("Es necesario que se seleccione un directorio desde donde se leerán los archivos", MsgBoxStyle.Exclamation, "MySUIT")
                Exit Sub
            End If
            If Me.cboestilo.SelectedIndex < 0 Then
                MsgBox("Se necesita seleccionar el lenguaje de programación", MsgBoxStyle.Exclamation, "MySUIT")
                Exit Sub
            End If

            'PASO 3: Procede a la lectura del directorio
            carchivos = outil.Leer_Directorio(Me.txtdirectory.Text, Me.chksubdirectorios.Checked, oxmlparametros.BuscarPrimero("parametro", "nombre", "extension_deprogramas").getValue("parametro.valor"))
            For Each oarch In carchivos
                Me.clbArchivos.Items.Add(oarch.Name + "                                                                                                        |" + oarch.DirectoryName)
            Next

        Catch ex As HANYException
            ex.add("MyDOCUMENTOR.frmdtgenera.btnleerdir_Click_1()", "Ocurrio un error al leer el directorio")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyDOCUMENTOR.frmdtgenera.btnleerdir_Click_1()", "Ocurrio un error al leer el directorio [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub chkselectall_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkselectall.CheckedChanged
        For i As Integer = 0 To Me.clbArchivos.Items.Count - 1
            Me.clbArchivos.SetItemChecked(i, Me.chkselectall.Checked)
        Next
    End Sub

    Private Sub btniniciar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btniniciar.Click
        Dim i As Integer = 1
        Dim o As Object
        Dim slanguaje As String
        Dim cClases As Collection
        Dim Tabla As Word.Table
        Dim oxmlmain, oxmldocs, oxmldocto, oxmlestilo, oxmlenguaje, oxmlparametros, oxmlestilos As Nodo
        Dim oxmlmacros, oxmltemplate, oxmlmacro, oxmlcomments As Nodo
        Dim sdirectorio As String
        Dim stemplate As String
        Dim centidades As Collection
        Dim ofile As ClassReader

        Try
            'PASO 1: Inicializa las variables
            Me.Cursor = Cursors.WaitCursor
            omdipa = Me.ParentForm
            Me.prbarmado.Maximum = Me.clbArchivos.CheckedItems.Count
            Me.prbarmado.Minimum = 0
            MSWord = New Word.Application
            cClases = New Collection
            lstdebug.Items.Clear()
            slanguaje = outil.Toma_Token(2, Me.cboestilo.SelectedItem, "|")
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmldocs = oxmlmain.getPrimerNodo("proyecto-documentacion")
            oxmldocto = oxmldocs.BuscarPrimero("documento", "clave", outil.Toma_Token(1, Me.cbotipo.SelectedItem, "-"))
            sdirectorio = oxmldocto.getValue("documento.directorio")
            oxmltemplate = New Nodo(ozip.getFileInflated(sdirectorio & oxmldocto.getValue("documento.configuracion")))
            oxmlmacros = oxmltemplate.getPrimerNodo("macros")
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
            oxmlestilo = oxmlestilos.BuscarPrimero("estilo", "clave", outil.Toma_Token(1, Me.cboestilo.SelectedItem, "-"))
            oxmlenguaje = New Nodo(ozip.getFileInflated(oxmlestilo.getValue("estilo.directorio") & oxmlestilo.getValue("estilo.configuracion")))
            oxmlparametros = oxmlenguaje.getPrimerNodo("code.parametros")
            oxmlcomments = oxmlenguaje.getPrimerNodo("code.comentarios")

            'PASO 1: Validando todos los insumos
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "STEP01: Validando archivo donde grabar")
            If Me.txtdocfile.Text.Equals("") Then
                Me.Cursor = Cursors.Default
                MsgBox("Es necesario abrir primero el archivo donde se grabará la información del proyecto !", MsgBoxStyle.Exclamation, "MySUIT")
                Exit Sub
            End If

            If Me.clbArchivos.CheckedItems.Count = 0 Then
                Me.Cursor = Cursors.Default
                MsgBox("Es necesario seleccionar al menos un archivo para poder iniciar la incorporación !", MsgBoxStyle.Exclamation, "MySUIT")
                Exit Sub
            End If

            'PASO 2: Haciendo un parse a cada uno de los programas fuentes
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "STEP02: Parse a programas fuente...")
            ofile = New ClassReader
            ofile.regclase = oxmlparametros.BuscarPrimero("parametro", "nombre", "apuntador_clase").getValue("parametro.valor")
            ofile.regcommentclase = oxmlparametros.BuscarPrimero("parametro", "nombre", "apuntador_comentario_clase").getValue("parametro.valor")
            ofile.regcommentmetodo = oxmlparametros.BuscarPrimero("parametro", "nombre", "apuntador_comentario_metodo").getValue("parametro.valor")
            ofile.regprocedure = oxmlparametros.BuscarPrimero("parametro", "nombre", "apuntador_procedimiento").getValue("parametro.valor")
            ofile.regcarquitar = oxmlparametros.BuscarPrimero("parametro", "nombre", "chars_aeliminar_encomentario").getValue("parametro.valor")
            ofile.xmlclase = oxmlcomments.BuscarPrimero("comentario", "nombre", "clase")
            ofile.xmlmetodo = oxmlcomments.BuscarPrimero("comentario", "nombre", "metodo")
            ofile.xmlpseudocodigo = oxmlcomments.BuscarPrimero("comentario", "nombre", "pseudocodigo")
            For Each o In Me.clbArchivos.CheckedItems
                outil.addToListDebug(lstdebug, "PARSE A [" + outil.Toma_Token(1, o, "|") + "]")
                ofile.dir = outil.Toma_Token(2, o, "|")
                ofile.file = outil.Toma_Token(1, o, "|")
                If Not ofile.Parse() Then
                    Dim cmsgs As Collection = ofile.getMensajes()
                    For Each omsg As Mensaje In cmsgs
                        outil.addToListDebug(lstdebug, "  " & omsg.clave & " - " & omsg.description)
                    Next
                End If
                cClases.Add(ofile.GetClase())
                Me.prbarmado.Value = i
                i = i + 1
            Next

            'PASO 3: Procesando para hacer el inventario de la cases
            i = 0
            Me.prbarmado.Value = 0
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "STEP03: Procesando el inventario de clases en .doc")
            oxmlmacro = oxmlmacros.BuscarPrimero("macro", "nombre", "inventario_backend")
            stemplate = System.IO.Path.GetTempPath & "Microsoft13" & CInt(Int((10000 * Rnd()) + 1)) & "TMP.tmp"
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

            For Each ocla As Clase In cClases
                Tabla.Rows.Add()
                outil.addToListDebug(lstdebug, "  CLASE [" & ocla.name & "]")
                Tabla.Cell(Tabla.Rows.Count - 1, 1).Range.Text = ocla.name
                Tabla.Cell(Tabla.Rows.Count - 1, 2).Range.Text = ocla.comment
                Me.prbarmado.Value = i
                i = i + 1
            Next
            MSWord.Selection.WholeStory()
            MSWord.Selection.Copy()
            Documento.Close(Word.WdSaveOptions.wdDoNotSaveChanges)
            Documento = MSWord.Documents.Open(Me.txtdocfile.Text)
            If outil.findpos(Documento, "_PSIQUE.INVENTARIO_BACKEND_") Then
                MSWord.Selection.Paste()
            End If
            Documento.Close(Word.WdSaveOptions.wdSaveChanges)

            'PASO 4: Procesando cada clases para documentar sus metodos
            i = 0
            Me.prbarmado.Value = 0
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "STEP04: Procesando el detalle de cada metodo en .doc")
            oxmlmacro = oxmlmacros.BuscarPrimero("macro", "nombre", "detalle_metodos")
            stemplate = System.IO.Path.GetTempPath & "Microsoft14" & CInt(Int((10000 * Rnd()) + 1)) & "TMP.tmp"
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

            For Each ocla As Clase In cClases
                Dim cmetodos As Collection
                cmetodos = ocla.methods
                MSWord.Selection.EndKey(Unit:=Word.WdUnits.wdStory)
                MSWord.Selection.Paste()
                outil.addToListDebug(lstdebug, "  CLASE [" & ocla.name & "]")
                outil.findyreplace(Documento, "_PSIQUE.CLASE_NOMBRE_", ocla.name)
                outil.findyreplace(Documento, "_PSIQUE.CLASE_DESCRIPCION_", ocla.comment)
                Tabla = Documento.Tables.Item(Documento.Tables.Count)
                For Each omet As Metodo In cmetodos
                    outil.addToListDebug(lstdebug, "    METODO [" & omet.nombre & "]")
                    Tabla.Rows.Add()
                    Tabla.Cell(Tabla.Rows.Count, 1).Range.Text = omet.declaracion
                    Tabla.Cell(Tabla.Rows.Count, 2).Range.Text = omet.comment
                Next
                Me.prbarmado.Value = i
                i = i + 1
            Next

            MSWord.Selection.WholeStory()
            MSWord.Selection.Copy()
            Documento.Close(Word.WdSaveOptions.wdDoNotSaveChanges)

            Documento = MSWord.Documents.Open(Me.txtdocfile.Text)
            If outil.findpos(Documento, "_PSIQUE.DETALLE_METODOS_") Then
                MSWord.Selection.Paste()
            End If
            Documento.Close(Word.WdSaveOptions.wdSaveChanges)

            'PASO 5: Procesando para hacer el inventario de la entidades
            i = 0
            centidades = obus.getProyectoFuenteDatoEntidades(outil.Toma_Token(1, Me.cboproyecto.SelectedItem, "-"))
            Me.prbarmado.Value = 0
            Me.prbarmado.Maximum = centidades.Count
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "STEP02: Procesando el inventario de entidades en .doc")
            oxmlmacro = oxmlmacros.BuscarPrimero("macro", "nombre", "inventario_tablas")
            stemplate = System.IO.Path.GetTempPath & "Microsoft15" & CInt(Int((10000 * Rnd()) + 1)) & "TMP.tmp"
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

            For Each oproyftent As ProyectoFuenteDatoEntidad In centidades
                Dim otipo As Tipo
                Dim oent As EntidaDato = obus.getEntidaDato(oproyftent.cdfuentedato, oproyftent.nbentidadato)
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
            Documento = MSWord.Documents.Open(Me.txtdocfile.Text)
            If outil.findpos(Documento, "_PSIQUE.INVENTARIO_TABLAS_") Then
                MSWord.Selection.Paste()
            End If
            Documento.Close(Word.WdSaveOptions.wdSaveChanges)

            'PASO 6: Procesando cada entidad para documentar sus metodos
            i = 0
            Me.prbarmado.Value = 0
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "STEP03: Procesando el detalle de cada entidad en .doc")
            oxmlmacro = oxmlmacros.BuscarPrimero("macro", "nombre", "layout_tablas")
            stemplate = System.IO.Path.GetTempPath & "Microsoft16" & CInt(Int((10000 * Rnd()) + 1)) & "TMP.tmp"
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

            For Each oproyftent As ProyectoFuenteDatoEntidad In centidades
                Dim ccampos As Collection
                Dim oent As EntidaDato = obus.getEntidaDato(oproyftent.cdfuentedato, oproyftent.nbentidadato)
                Dim iCampo As Integer = 0
                ccampos = obus.getEntidaDatoCampos(oproyftent.cdfuentedato, oproyftent.nbentidadato)
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
            Documento = MSWord.Documents.Open(Me.txtdocfile.Text)
            If outil.findpos(Documento, "_PSIQUE.LAYOUT_TABLAS_") Then
                MSWord.Selection.Paste()
            End If
            Documento.Close(Word.WdSaveOptions.wdSaveChanges)

            If Me.chkopenfile.Checked Then MSWord.Visible = True

            'PASO 7: Grabando la inf. y también terminando
            Me.prbarmado.Value = Me.prbarmado.Maximum
            MSWord = Nothing
            Me.Cursor = Cursors.Default
            MsgBox("!PROCESO TERMINADO!", MsgBoxStyle.Information, "MySUIT")

        Catch ex As HANYException
            ex.add("MyDOCUMENTOR.frmdtgenera.btniniciar_Click_1()", "Ocurrio un error al generar el diseño técnico")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyDOCUMENTOR.frmdtgenera.btniniciar_Click_1()", "Ocurrio un error al generar el diseño técnico [" & ex1.ToString & "]"))
        End Try

    End Sub

End Class
