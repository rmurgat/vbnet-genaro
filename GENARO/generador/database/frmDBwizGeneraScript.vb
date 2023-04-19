Option Explicit On

Imports MyLIB

Public Class frmDBwizGeneraScript
    Private ipagina As Integer = 1
    Private outil As Utilerias = New MyLIB.Utilerias
    Private omdipa As MDIGenaro
    Private obus As Catalogos
    Private ozip As ZipArchivo = New MyLIB.ZipArchivo

    Private Sub frmDBwizGeneraScript_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cftes As Collection
        Dim oxmlmain As Nodo
        Dim oxmlparsers As Nodo
        Dim ocol As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            outil = New Utilerias
            ozip.Open(omdipa.configuracion)

            'PASO 2: LLena el catálogo de fuentes de datos
            cftes = obus.getFuenteDatos(New Criterio)
            For Each ofte As FuenteDato In cftes
                cbofuente.Items.Add(ofte.cdfuentedato & " - " & ofte.nbfuentedato)
            Next

            'PASO 3: LLena el catálogo de configuración para hacer parser a una DDL( Data Definition Languaje )
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlparsers = oxmlmain.getPrimerNodo("estilos-programacion")
            ocol = oxmlparsers.Buscar("estilo", "tipo", "ddl")
            For Each onodo As Nodo In ocol
                Me.cboestilo.Items.Add(onodo.getValue("estilo.clave") & " - " & onodo.getValue("estilo.nombre"))
            Next

        Catch ex As HANYException
            ex.add("MyGENARO.frmDBwizGeneraScript.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmDBwizGeneraScript.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

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

    Private Sub btnleer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnleer.Click
        Dim centidades As Collection
        Dim irow As Integer

        'PASO 1: Valida la fuente de datos
        If Me.cbofuente.SelectedIndex < 0 Then
            MsgBox("No hay ninguna fuente de datos seleccionada", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            'PASO 1: Configura el grid
            Call Configura_Grid()

            'PASO 2: Llena el catálogo de entidades
            centidades = obus.getEntidaDatos(outil.Toma_Token(1, Me.cbofuente.SelectedItem, "-"))

            'PASO 3: Llena el grid de entidades de datos
            irow = 1
            For Each oent As EntidaDato In centidades
                gridEntidades.Rows.Add(irow, False, oent.nbentidadato)
                irow = irow + 1
            Next

        Catch ex As HANYException
            ex.add("MyGENARO.frmDBwizGeneraScript.btnleer_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmDBwizGeneraScript.btnleer_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub Configura_Grid()
        Dim oselect As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn(False)
        oselect.Name = "select"
        oselect.HeaderText = "Seleccionar"
        oselect.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        oselect.Width = 60
        gridEntidades.Rows.Clear()
        gridEntidades.Columns.Clear()
        gridEntidades.Columns.Add("row", "#")
        gridEntidades.Columns.Insert(1, oselect)
        gridEntidades.Columns.Add("entidad", "Entidad")
        gridEntidades.Columns.Item("row").Width = 40
        gridEntidades.Columns.Item("entidad").Width = 320
        gridEntidades.Columns.Item("entidad").ReadOnly = True
        gridEntidades.Columns.Item("row").SortMode = DataGridViewColumnSortMode.NotSortable
        gridEntidades.Columns.Item("entidad").SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub chktodas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodas.CheckedChanged
        Dim iren As Integer
        For iren = 0 To gridEntidades.Rows.Count - 1
            gridEntidades.Item("select", iren).Value = chktodas.Checked
        Next iren
    End Sub

    Private Sub btngenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngenerar.Click
        Dim oxmlmain, oxmlestilos, oxmlestilo, oxmllenguaje, oxmlmeta As Nodo
        Dim ometa As MetacodigoReader
        Dim iren As Integer
        Dim sres As String

        'PASO 1: Valida los insumos del proceso
        If cbofuente.SelectedIndex < 0 Then
            MsgBox("No hay ninguna fuente de datos seleccionada", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        If chkescribir.Checked Then
            If txtfile.Text.Equals("") Then
                MsgBox("Es necesario tener un archivo donde se grabará el Script", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If
        End If

        Try
            'PASO 2: Inicializa...
            Me.Cursor = Cursors.WaitCursor
            sres = ""
            lstdebug.Items.Clear()
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "PASO 1: Inciando generación ")

            'PASO 3: Lee el archivo de configuración
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlestilos = oxmlmain.getPrimerNodo("estilos-programacion")
            oxmlestilo = oxmlestilos.BuscarPrimero("estilo", "clave", outil.Toma_Token(1, Me.cboestilo.SelectedItem, "-"))
            oxmllenguaje = New Nodo(ozip.getFileInflated(oxmlestilo.getValue("directorio") & oxmlestilo.getValue("configuracion")))

            'PASO 4: Arma el metacodigo
            ometa = New MetacodigoReader()
            oxmlmeta = oxmllenguaje.BuscarPrimero("codigo", "clave", "ddl")
            ometa.source = ozip.getFileInflated(oxmlestilo.getValue("directorio") & oxmlmeta.getValue("archivo"))

            'PASO 6: Arma el xml con la información de los campos
            outil.addToListDebug(lstdebug, "PASO 2: Generación de Script por entidad")
            For iren = 0 To gridEntidades.Rows.Count - 1
                If gridEntidades.Item("select", iren).Value = True Then
                    Dim oentidad As EntidaDato
                    oentidad = obus.getEntidaDato(outil.Toma_Token(1, Me.cbofuente.SelectedItem, "-"), gridEntidades.Item("entidad", iren).Value)
                    oentidad.ccampos = obus.getEntidaDatoCampos(outil.Toma_Token(1, Me.cbofuente.SelectedItem, "-"), gridEntidades.Item("entidad", iren).Value)
                    sres = sres & ometa.Interpreta(oentidad.GetXML())
                    outil.addToListDebug(lstdebug, " GENERANDO " & oentidad.nbentidadato)
                End If
            Next iren

            'PASO 8: Escribe en un archivo y/o muestra resultado en pantalla
            If chkescribir.Checked Then
                If Not outil.EscribeNuevoArchivo(Me.txtfile.Text, sres) Then
                    outil.addToListDebug(lstdebug, "  Error Escribiendo : " & Me.txtfile.Text)
                End If
            End If
            If Me.chkpantalla.Checked Then outil.Preveer(sres)

            'PASO 9: Termina
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "!PROCESO TERMINADO!")
            Me.Cursor = Cursors.Default
            MsgBox("!PROCESO TERMINADO!", MsgBoxStyle.Information, "ATL Tools Suit")

        Catch ex As HANYException
            ex.add("MyGENARO.frmDBwizGeneraScript.btngenerar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmDBwizGeneraScript.btngenerar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub btncommentfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfile.Click
        If (SaveFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtfile.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub chkescribir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkescribir.CheckedChanged
        lblfile.Enabled = chkescribir.Checked
        txtfile.Enabled = chkescribir.Checked
        btnfile.Enabled = chkescribir.Checked
    End Sub
End Class