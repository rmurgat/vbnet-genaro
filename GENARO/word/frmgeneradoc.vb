Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Imports MyLIB

''' <summary>
'''    Clase para ejecutar el wizard de visual basic
''' </summary>
''' <remarks></remarks>
Public Class frmgeneradoc
    Private ipagina As Integer = 1
    Private outil As Utilerias
    Private omdipa As MDIGenaro
    Public MSWord As New Word.Application
    Public oDocumento As Object
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

    Private Sub frmgeneradoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oxmlmain As Nodo = New Nodo
        Dim oxmldocs As Nodo = New Nodo
        Dim ocol As Collection

        Try
            outil = New Utilerias
            omdipa = Me.ParentForm
            ozip.Open(omdipa.configuracion)
            oxmlmain.SetXML(ozip.getFileInflated("main.xml"))
            oxmldocs = oxmlmain.getPrimerNodo("proyecto-documentacion")
            ocol = oxmldocs.getNodo("documento")
            cbotipo.Items.Add("")
            For Each onodo As Nodo In ocol
                cbotipo.Items.Add(onodo.getValue("documento.clave") & " - " & onodo.getValue("documento.nombre"))
            Next
            Me.cbotipo.SelectedIndex = 0
        Catch ex As HANYException
            ex.add("MyDOCUMENTOR.frmgeneradoc.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyDOCUMENTOR.frmgeneradoc.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnexamacro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexamacro.Click
        Dim orow As DataGridViewRow

        orow = Me.dgvmacros.SelectedRows(0)
        OpenFileDialog.Filter = "Documento de Word (*.docx)|*.docx|Script de SQL(*.sql)|*.sql|Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        OpenFileDialog.InitialDirectory = Comun.STR_DIRECTORIO
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            orow.Cells("colArchivo").Value = OpenFileDialog.FileName
            Comun.STR_DIRECTORIO = OpenFileDialog.RestoreDirectory
        End If
    End Sub

    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click
        Dim stemplate As String
        Dim sres As String
        Dim bhayerror As Boolean = False
        Dim cmacros As Collection
        Dim oxmlmain As Nodo = New Nodo
        Dim oxmldocs As Nodo
        Dim oxmldocto As Nodo
        Dim oxmlmacros As Nodo
        Dim oxmltemplate As Nodo
        Dim sdirectorio As String

        Try
            'PASO 1: 
            oxmlmain.SetXML(ozip.getFileInflated("main.xml"))
            oxmldocs = oxmlmain.getPrimerNodo("proyecto-documentacion")
            oxmldocto = oxmldocs.BuscarPrimero("documento", "clave", outil.Toma_Token(1, Me.cbotipo.SelectedItem, "-"))
            sdirectorio = oxmldocto.getValue("documento.directorio")
            oxmltemplate = New Nodo(ozip.getFileInflated(sdirectorio + oxmldocto.getValue("documento.configuracion")))

            'PASO 2: Valida las rutas del archivo
            lstdebug.Items.Clear()
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "VALIDANDO los valores de las variables")

            'PASO 3: Valida los valores de las variables
            For Each orow As DataGridViewRow In Me.dgvVariables.Rows
                Dim svar As String = orow.Cells("colNombre").Value
                Dim sval As String = orow.Cells("colValor").Value
                If Not svar Is Nothing Then
                    If sval.Trim.Equals("") Then
                        sres = "No tiene valor"
                        bhayerror = True
                    Else
                        sres = "Ok"
                    End If
                    outil.addToListDebug(lstdebug, "  Variable " & svar & ": " & sres)
                End If
            Next

            'PASO 4: Validando las rutas de las macros
            oxmlmacros = oxmltemplate.getPrimerNodo("macros")
            cmacros = oxmlmacros.getNodo("macro")
            For Each onodo As Nodo In cmacros
                Dim sfile As String
                If Not onodo.getValue("macro.archivo").Equals("?") And Not onodo.getValue("macro.archivo").Equals("") Then
                    sfile = sdirectorio + onodo.getValue("macro.archivo")
                    If Not ozip.ExisteArchivo(sfile) Then
                        outil.addToListDebug(lstdebug, "      !ERROR! No existe archivo " & sfile)
                        bhayerror = True
                    End If
                End If
            Next

            If bhayerror Then
                outil.addToListDebug(lstdebug, "")
                outil.addToListDebug(lstdebug, "¡ GENERACION ABORTADA !")
                Exit Sub
            End If

            'PASO 5: Copia el formato del archivo .doc a su destino 
            stemplate = System.IO.Path.GetTempPath & "Microsoftdocx" & CInt(Int((10000 * Rnd()) + 1)) & "TMP.tmp"
            If Not ozip.writeFileInflated(sdirectorio & oxmltemplate.getValue("documento.archivo"), stemplate) Then
                MsgBox("Error al unzip un archivo [" & sdirectorio + oxmltemplate.getValue("documento.archivo") & "]")
            End If


            'PASO 6: Abrimos el objeto con la aplicación
            MSWord = New Word.Application

            'PASO 7: Abrimos el documento con el template
            MSWord.Documents.Open(stemplate.ToString, ReadOnly:=True)

            'PASO 8: Copiamos todo el contenido
            MSWord.Selection.WholeStory()
            MSWord.Selection.Copy()
            MSWord.Documents.Close()

            'PASO 9: Agregamos un nuevo documento para pegar lo que copiamos
            oDocumento = MSWord.Documents.Add()
            MSWord.Selection.EndKey(Unit:=Word.WdUnits.wdStory)
            MSWord.Selection.Paste()

            'PASO 10: Copia el formato del archivo .doc a su destino 
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "SUBSTITUENDO Valores de variables")
            For Each orow As DataGridViewRow In Me.dgvVariables.Rows
                Dim svar As String = orow.Cells("colNombre").Value
                Dim sval As String = orow.Cells("colValor").Value
                If Not sval Is Nothing Then
                    outil.findyreplace(oDocumento, "{" & svar.Trim.ToLower & "}", sval)
                    outil.addToListDebug(lstdebug, "  Variable " & svar)
                End If
            Next

            'PASO 11: Copia el formato del archivo .doc a su destino 
            'outil.addToListDebug(lstdebug, "INCORPORANTO archivos en macros")
            'For Each orow As DataGridViewRow In Me.dgvmacros.Rows
            'Dim smac As String = orow.Cells("colMacro").Value
            'Dim sfile As String = orow.Cells("colArchivo").Value
            'If Not smac Is Nothing Then
            'If Not sfile.Equals("") And outil.findpos(oDocumento, "_PSIQUE." + smac.ToUpper + "_") Then
            'oDocumento.ActiveWindow.Selection.InsertFile(sfile)
            'End If
            'outil.addToListDebug(lstdebug, "  Macro " & smac)
            'End If
            'Next
            MSWord.Visible = True
            MSWord = Nothing
            MsgBox("!PROCESO TERMINADO!", MsgBoxStyle.Information, "MySUIT")

        Catch ex As HANYException
            ex.add("MyDOCUMENTOR.frmgeneradoc.btngenerar_Click()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyDOCUMENTOR.frmgeneradoc.btngenerar_Click()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub Cargar_MacrosyVariables()
        Dim cvariables As Collection
        Dim cmacros As Collection
        Dim oxmlmain As Nodo = New Nodo
        Dim oxmldocs As Nodo
        Dim oxmldocto As Nodo
        Dim oxmlmacros As Nodo
        Dim oxmlvariables As Nodo
        Dim oxmltemplate As Nodo
        Dim sdirectorio As String

        Try
            'PASO 1: Carzo el archivo .zip
            oxmlmain.SetXML(ozip.getFileInflated("main.xml"))
            oxmldocs = oxmlmain.getPrimerNodo("proyecto-documentacion")
            oxmldocto = oxmldocs.BuscarPrimero("documento", "clave", outil.Toma_Token(1, Me.cbotipo.SelectedItem, "-"))
            sdirectorio = oxmldocto.getValue("documento.directorio")
            oxmltemplate = New Nodo(ozip.getFileInflated(sdirectorio + oxmldocto.getValue("documento.configuracion")))
            oxmlmacros = oxmltemplate.getPrimerNodo("macros")
            cmacros = oxmlmacros.getNodo("macro")
            dgvmacros.Rows.Clear()
            For Each omacro As Nodo In cmacros
                Dim sval As String = omacro.getValue("macro.archivo")
                dgvmacros.Rows.Add(omacro.getValue("macro.nombre"), IIf(sval.Equals("?"), "", sval.Trim))
            Next

            oxmlvariables = oxmltemplate.getPrimerNodo("variables")
            cvariables = oxmlvariables.getNodo("variable")
            dgvVariables.Rows.Clear()
            For Each ovar As Nodo In cvariables
                Dim sval As String = ovar.getValue("variable.valor")
                dgvVariables.Rows.Add(ovar.getValue("variable.etiqueta"), IIf(sval.Equals("?"), "", sval.Trim), ovar.getValue("variable.nombre"))
            Next

        Catch ex As HANYException
            ex.add("MyDOCUMENTOR.frmgeneradoc.Cargar_MacrosyVariables()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyDOCUMENTOR.frmgeneradoc.Cargar_MacrosyVariables()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try

    End Sub

    Private Sub cbotipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotipo.SelectedIndexChanged

        Try
            If cbotipo.SelectedIndex > 0 Then
                Me.Cargar_MacrosyVariables()
            End If
        Catch ex As HANYException
            ex.add("MyDOCUMENTOR.frmgeneradoc.cbotipo_SelectedIndexChanged()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyDOCUMENTOR.frmgeneradoc.cbotipo_SelectedIndexChanged()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

End Class

