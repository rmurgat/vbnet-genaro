Option Explicit On
Imports MyLIB
Imports System.Windows.Forms
Imports System.IO

''' <summary>
'''    Clase para ejecutar el wizard de visual basic
''' </summary>
''' <remarks></remarks>
Public Class frmQAValidainsumos
    Private ipagina As Integer = 1
    Private outil As Utilerias
    Private ozip As ZipArchivo = New MyLIB.ZipArchivo
    Private omdipa As MDIGenaro


    Private Sub btnexaminar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexaminar.Click

        FolderBrowserDialog.SelectedPath = Comun.STR_DIRECTORIO
        If (FolderBrowserDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtdirectory.Text = FolderBrowserDialog.SelectedPath
            Comun.STR_DIRECTORIO = Me.txtdirectory.Text
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

    Private Sub chkselectall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkselectall.CheckedChanged
        For i As Integer = 0 To Me.clbArchivos.Items.Count - 1
            Me.clbArchivos.SetItemChecked(i, Me.chkselectall.Checked)
        Next
    End Sub

    Private Sub btniniciar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btniniciar.Click
        Dim oxmlmain, oxmlestilos, oxmlestilo, oxmllenguaje, oxmlparametros, oxmlcomments As Nodo
        Dim i As Integer = 1
        Dim o As Object
        Dim slanguaje As String
        Dim ofile As ClassReader

        Try
            'PASO 1: Inicia el proceso
            lstdebug.Items.Clear()
            ozip.Open(omdipa.configuracion)
            slanguaje = outil.Toma_Token(2, Me.cboestilo.SelectedItem, "|")
            Me.prbvalidacion.Minimum = 0
            Me.prbvalidacion.Maximum = Me.clbArchivos.CheckedItems.Count
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
            oxmlestilo = oxmlmain.BuscarPrimero("estilo", "clave", outil.Toma_Token(1, Me.cboestilo.SelectedItem, "-"))
            oxmllenguaje = New Nodo(ozip.getFileInflated(oxmlestilo.getValue("estilo.directorio") & oxmlestilo.getValue("estilo.configuracion")))
            oxmlparametros = oxmllenguaje.getPrimerNodo("code.parametros")
            oxmlcomments = oxmllenguaje.getPrimerNodo("code.comentarios")
            btnClipboard.Visible = True

            'PASO 2: Valida los insumos
            If Me.clbArchivos.CheckedItems.Count = 0 Then
                MsgBox("Es necesario seleccionar archivos para poder iniciar la validacion !", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If

            'PASO 3: Valida cada uno de los archivos seleccionados
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
                outil.addToListDebug(lstdebug, "")
                outil.addToListDebug(lstdebug, "VALIDANDO [" + outil.Toma_Token(1, o, "|") + "]")
                ofile.dir = outil.Toma_Token(2, o, "|")
                ofile.file = outil.Toma_Token(1, o, "|")
                If Not ofile.Parse() Then
                    Dim cmsgs As Collection = ofile.getMensajes()
                    For Each omsg As Mensaje In cmsgs
                        outil.addToListDebug(lstdebug, "  " & omsg.clave & " - " & omsg.description)
                    Next
                End If
                If Not ofile.isallComented() Then
                    Dim cmsgs As Collection = ofile.getMensajes()
                    For Each omsg As Mensaje In cmsgs
                        outil.addToListDebug(lstdebug, "  " & omsg.clave & " - " & omsg.description)
                    Next
                End If
                Me.prbvalidacion.Value = i
                i = i + 1
            Next
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmvalidainsumos.btniniciar_Click_1()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmvalidainsumos.btniniciar_Click_1()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnleerdir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnleerdir.Click
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
            oxmlparametros = oxmlenguaje.getPrimerNodo("code.parametros")

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
                Me.clbArchivos.Items.Add(oarch.Name + "                                                                                                   |" + oarch.DirectoryName)
            Next

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmvalidainsumos.btnleerdir_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmvalidainsumos.btnleerdir_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub frmvalidcomment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oxmlmain, oxmlestilos As Nodo
        Dim ocol As Collection

        Try
            outil = New Utilerias
            omdipa = Me.ParentForm
            ozip.Open(omdipa.configuracion)
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
            ocol = oxmlestilos.Buscar("estilo", "tipo", "model")
            For Each onodo As Nodo In ocol
                Me.cboestilo.Items.Add(onodo.getValue("estilo.clave") & " - " & onodo.getValue("estilo.nombre"))
            Next
            Me.cboestilo.SelectedIndex = 0
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmvalidainsumos.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmvalidainsumos.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnterminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnterminar.Click
        Me.Close()
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
End Class
