Option Explicit On

Imports MyLIB
Imports System.Windows.Forms
Imports System.IO

Public Class frmDBwizStoreProcedures
    Private ipagina As Integer = 1
    Private outil As Utilerias = New MyLIB.Utilerias
    Private olog As HANYLog = New MyLIB.HANYLog
    Private omdipa As MDIGenaro
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

    Private Sub frmDBwizStoreProcedures_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cftes As Collection
        Dim oxmlmain, oxmlestilos As Nodo
        Dim ocol As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            outil = New Utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            ozip.Open(omdipa.configuracion)
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")

            'PASO 2: LLena el catálogo de fuentes de datos
            cftes = obus.getFuenteDatos(New Criterio)
            For Each ofte As FuenteDato In cftes
                cboftedatos.Items.Add(ofte.cdfuentedato & " - " & ofte.nbfuentedato)
            Next

            'PASO 3: Llena el estilo de diccionarios de datos
            ocol = oxmlestilos.Buscar("estilo", "tipo", "store-procedure")
            For Each onodo As Nodo In ocol
                Me.cboestilo.Items.Add(onodo.getValue("estilo.clave") & " - " & onodo.getValue("estilo.nombre"))
            Next
            Me.cboestilo.SelectedIndex = 0
        Catch ex As HANYException
            ex.add("MyGENARO.frmDBwizStoreProcedures.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmDBwizStoreProcedures.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

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

    Private Sub btnleerfte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnleerfte.Click
        Dim centidades As Collection

        Try
            'PASO 1: Inicia el procedimiento
            Me.clbEntidad.Items.Clear()
            centidades = New Collection

            'PASO 2: Valida la fuente de datos valida
            If Me.cboftedatos.SelectedIndex < 0 Then
                MsgBox("Se necesita seleccionar la fuente de datos", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If

            'PASO 3: Procede a la lectura del directorio
            centidades = obus.getEntidaDatos(outil.Toma_Token(1, Me.cboftedatos.SelectedItem, "-"))
            For Each oent As EntidaDato In centidades
                Me.clbEntidad.Items.Add(oent.nbentidadato)
            Next
        Catch ex As HANYException
            ex.add("MyGENARO.frmDBwizStoreProcedures.btnleerfte_Click()", "Ocurrio un error al leer el fuente")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmDBwizStoreProcedures.btnleerfte_Click()", "Ocurrio un error al leer el fuente [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub chkselectall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkselectall.CheckedChanged
        For i As Integer = 0 To Me.clbEntidad.Items.Count - 1
            Me.clbEntidad.SetItemChecked(i, Me.chkselectall.Checked)
        Next
    End Sub

    Private Sub btndocfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndocfile.Click
        If (Me.FolderBrowserDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtdirectory.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btniniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btniniciar.Click
        Dim oxmlmain, oxmlestilos, oxmlestilo, oxmllenguaje, oxmlwizard, oxmlgeneral, oxmlmeta As Nodo
        Dim ofrm As frmWizard = New frmWizard()
        Dim i As Integer
        Dim ometa As MetacodigoReader
        Dim sfuente As String
        Dim sfilecontent As String
        Dim icounter As Integer
        Dim sxml As String

        Try
            'PASO 1: Incializa todo...
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            sfuente = outil.Toma_Token(1, Me.cboftedatos.SelectedItem, "-")
            sxml = ""

            'PASO 2: Lee el archivo de configuración
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
            oxmlestilo = oxmlestilos.BuscarPrimero("estilo", "clave", outil.Toma_Token(1, Me.cboestilo.SelectedItem, "-"))
            oxmllenguaje = New Nodo(ozip.getFileInflated(oxmlestilo.getValue("directorio") & oxmlestilo.getValue("configuracion")))

            'PASO 3: Lee los parámetros propios de la plataforma
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "STEP01: Lectura de los parámetros necesarios")
            oxmlwizard = New Nodo(ozip.getFileInflated(oxmlestilo.getValue("directorio") & oxmllenguaje.getValue("code.general.wizard")))
            ofrm.xmlin = oxmlwizard.GetXML()
            ofrm.ShowDialog()
            If ofrm.xmlout.Trim.Equals("") Then Exit Sub
            oxmlgeneral = New Nodo(ofrm.xmlout)

            'PASO 4: Lee cada una de las entidades para armar el xml necesario para la generación del código 
            i = 0
            Me.prbarmado.Value = 0
            Me.prbarmado.Maximum = Me.clbEntidad.CheckedItems.Count
            outil.addToListDebug(lstdebug, "STEP02: Armando lo necesario para la generación del código")
            ometa = New MetacodigoReader()
            oxmlmeta = oxmllenguaje.BuscarPrimero("codigo", "clave", "abc-storeprocedure")
            ometa.source = ozip.getFileInflated(oxmlestilo.getValue("directorio") & oxmlmeta.getValue("archivo"))

            'PASO 5: Arma el xml que tiene los datos a evaluar por parte del interprete
            sxml = "<fuentedatos>"
            sxml = sxml & "<entidades>"
            'recorre las entidades marcadas
            For Each sentidad As String In Me.clbEntidad.CheckedItems
                Dim oent As EntidaDato = obus.getEntidaDato(sfuente, sentidad)
                oent.ccampos = obus.getEntidaDatoCampos(sfuente, sentidad)
                sfilecontent = ometa.Interpreta(oxmlgeneral.GetXML() & oent.GetXML())
                My.Computer.FileSystem.WriteAllText(Me.txtdirectory.Text & "/" & oent.nbentidadato & oxmlmeta.getValue("extension"), sfilecontent, True)
                outil.addToListDebug(lstdebug, "  Leyendo : " & oent.nbentidadato & oxmlmeta.getValue("extension"))
                lstdebug.TopIndex = lstdebug.Items.Count - 1
                lstdebug.Refresh()
                icounter = icounter + 1
                prbarmado.Value = icounter
            Next
            sxml = sxml & "</entidades>"
            sxml = sxml & "</fuentedatos>"

            MsgBox("!PROCESO TERMINADO!", MsgBoxStyle.Information, "ATL Tools Suit")
            'PASO 5: Termina
            ofrm = Nothing
        Catch ex As HANYException
            ex.add("MyGENARO.frmDBwizStoreProcedures.btniniciar_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmDBwizStoreProcedures.btniniciar_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try

    End Sub
End Class ' fin clase [frmDBwizStoreProcedures]