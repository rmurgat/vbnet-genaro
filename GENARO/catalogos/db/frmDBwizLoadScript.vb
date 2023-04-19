Option Explicit On
Imports MyLIB
Imports System.Text.RegularExpressions
Imports System.IO

Public Class frmDBwizLoadScript
    Private ipagina As Integer = 1
    Private obus As Catalogos
    Private outil As Utilerias          'Utilerias del sistema
    Private ocentidades As Collection   'Colección de entidades leidas
    Private ozip As ZipArchivo = New MyLIB.ZipArchivo
    Private omdipa As MDIGenaro

    Const COL_TABLA_NOMBRE As Integer = 0
    Const COL_TABLA_CAMPO As Integer = 1
    Const COL_TABLA_TIPODB As Integer = 2
    Const COL_TABLA_LLAVE As Integer = 3
    Const COL_TABLA_TIPOVB As Integer = 4
    Const COL_TABLA_NBVB As Integer = 5
    Const COL_TABLA_COMMENT As Integer = 6

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

    Private Sub frmwizloadentityfromdll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oxmlmain As Nodo
        Dim oxmlparsers As Nodo
        Dim cftes As Collection
        Dim ocol As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            outil = New Utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            ozip.Open(omdipa.configuracion)

            'PASO 3: LLena el catálogo de fuentes de datos
            cftes = obus.getFuenteDatos(New Criterio)
            For Each ofte As FuenteDato In cftes
                cboftedatos.Items.Add(ofte.cdfuentedato & " - " & ofte.nbfuentedato)
            Next

            'PASO 4: LLena el catálogo de configuración para hacer parser a una DDL( Data Definition Languaje )
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlparsers = oxmlmain.getPrimerNodo("estilos-parsers")
            ocol = oxmlparsers.Buscar("estilo", "tipo", "ddl")
            For Each onodo As Nodo In ocol
                Me.cboestilo.Items.Add(onodo.getValue("estilo.clave") & " - " & onodo.getValue("estilo.nombre"))
            Next

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBwizloaddll.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBwizloaddll.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub btnExtraer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtraer.Click
        Dim oparser As DDLReader = New DDLReader
        Dim oxmlmain As Nodo
        Dim oxmlparsers As Nodo
        Dim oxmlestilo As Nodo
        Dim oxmlparser As Nodo
        Dim oxmlregulars As Nodo
        Dim oread As System.IO.StreamReader

        If raddll.Checked Then
            If txtddl.Text.Trim.Equals("") Then
                MsgBox("Es necesario ingresar un Script con la definición de datos", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If
        Else
            If txtfile.Text.Trim.Equals("") Then
                MsgBox("Es necesario ingresar un Archivo con la definición de datos", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If
        End If

        If Me.cboestilo.SelectedIndex < 0 Then
            MsgBox("Es necesario seleccionar un estilo para la lectura de scripts", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            oxmlmain = New Nodo(ozip.getFileInflated("main.xml"))
            oxmlparsers = oxmlmain.getPrimerNodo("estilos-parsers")
            oxmlestilo = oxmlparsers.BuscarPrimero("estilo", "clave", outil.Toma_Token(1, cboestilo.SelectedItem, "-"))
            oxmlparser = New Nodo(ozip.getFileInflated(oxmlestilo.getValue("estilo.directorio") & oxmlestilo.getValue("estilo.configuracion")))
            oxmlregulars = oxmlparser.getPrimerNodo("exp-regulares")
            oparser.regentidad = oxmlregulars.BuscarPrimero("expresion", "nombre", "tabla").getValue("expresion.valor")
            oparser.regcampos = oxmlregulars.BuscarPrimero("expresion", "nombre", "campo").getValue("expresion.valor")
            oparser.regprimary = oxmlregulars.BuscarPrimero("expresion", "nombre", "primarykey").getValue("expresion.valor")
            oparser.txnotnull = oxmlregulars.BuscarPrimero("expresion", "nombre", "nonull").getValue("expresion.valor")
            If raddll.Checked Then
                ocentidades = oparser.Parse(Me.txtddl.Text)
            Else
                oread = New StreamReader(Me.txtfile.Text, System.Text.Encoding.GetEncoding(28593))      'Abre el archivo   
                ocentidades = oparser.Parse(oread.ReadToEnd)
                oread.Close()
            End If
            Call Load_gridTablas(ocentidades)
            Me.Cursor = Cursors.Default
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBwizloaddll.btnExtraer_Click_1()", "Ocurrio un error al extraer información")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBwizloaddll.btnExtraer_Click_1()", "Ocurrio un error al extraer información [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub Load_gridTablas(ByRef pocentidades As Collection)

        Try
            gridTablas.Rows.Clear()
            gridTablas.Columns.Clear()
            gridTablas.Columns.Add("snbentidad", "Entidad")
            gridTablas.Columns.Add("snbcampo", "Campo")
            gridTablas.Columns.Add("scdtpdbcampo", "Tipo")
            gridTablas.Columns.Add("sstesllave", "Llave")
            gridTablas.Columns.Add("snulongitud", "Long")
            gridTablas.Columns.Add("snudecimales", "Dec")

            gridTablas.Columns.Item(0).Width = 150
            gridTablas.Columns.Item(1).Width = 150
            gridTablas.Columns.Item(2).Width = 60
            gridTablas.Columns.Item(3).Width = 50
            gridTablas.Columns.Item(4).Width = 30
            gridTablas.Columns.Item(5).Width = 30

            gridTablas.Columns.Item(0).SortMode = DataGridViewColumnSortMode.NotSortable
            gridTablas.Columns.Item(1).SortMode = DataGridViewColumnSortMode.NotSortable
            gridTablas.Columns.Item(2).SortMode = DataGridViewColumnSortMode.NotSortable
            gridTablas.Columns.Item(3).SortMode = DataGridViewColumnSortMode.NotSortable
            gridTablas.Columns.Item(4).SortMode = DataGridViewColumnSortMode.NotSortable
            gridTablas.Columns.Item(5).SortMode = DataGridViewColumnSortMode.NotSortable

            For Each oent As EntidaDato In pocentidades
                Dim otipo As Tipo = obus.getTpEntidaDato(oent.tpentidadato)
                gridTablas.Rows.Add(oent.nbentidadato, "", "", "")
                For Each ocampo As EntidaDatoCampo In oent.ccampos
                    gridTablas.Rows.Add("", ocampo.nbcampo, ocampo.cdtpdatofisico, IIf(ocampo.stesllave.Equals("AC"), "*", ""), ocampo.nulongitud, ocampo.nudecimales)
                Next
            Next
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBwizloaddll.Load_gridTablas()", "Ocurrio un error al extraer información")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBwizloaddll.Load_gridTablas()", "Ocurrio un error al extraer información [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click
        Dim sfte As String

        'PASO 1: Valida los insumos
        If Me.cboftedatos.SelectedIndex < 0 Then
            MsgBox("Es necesario seleccionar una fuente de datos", MsgBoxStyle.Information, "ATL Tools Suit")
            Exit Sub
        End If

        Try
            'PASO 2: Inicializa
            lstdebug.Items.Clear()
            sfte = outil.Toma_Token(1, Me.cboftedatos.SelectedItem, "-")

            'PASO 3: Limpia la lista de debug
            outil.addToListDebug(lstdebug, "")

            'PASO 4: recorre cada entidad de datos
            For Each oent As EntidaDato In ocentidades
                oent.cdfuentedato = sfte
                Dim otmp As EntidaDato = obus.getEntidaDato(sfte, oent.nbentidadato)

                'PASO 4.1 Si existe 
                If Not otmp Is Nothing Then
                    oent.txcomment = otmp.txcomment
                    obus.saveEntidaDato(oent)
                    lstdebug.Items.Add(oent.nbentidadato + " ... Actualizada!")
                    Dim ocantes As Collection = obus.getEntidaDatoCampos(sfte, oent.nbentidadato)
                    For Each oantes As EntidaDatoCampo In ocantes
                        oent.AsignaComentario(oantes.nbcampo, oantes.txcomment)
                    Next
                    For Each ocampo As EntidaDatoCampo In oent.ccampos
                        ocampo.cdfuentedato = sfte
                        obus.saveEntidaDatoCampo(ocampo)
                    Next
                End If

                'PASO 4.2 Si es nueva
                If otmp Is Nothing Then
                    obus.saveEntidaDato(oent)
                    lstdebug.Items.Add(oent.nbentidadato + " ... Registrada!")
                    For Each ocampo As EntidaDatoCampo In oent.ccampos
                        ocampo.cdfuentedato = sfte
                        obus.saveEntidaDatoCampo(ocampo)
                    Next
                End If
            Next

            'PASO 5: Concluye
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "!PROCESO TERMINADO!")
            MsgBox("!PROCESO TERMINADO!", MsgBoxStyle.Information, "ATL Tools Suit")

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBwizloaddll.btngrabar_Click()", "Ocurrio un error al grabar")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBwizloaddll.btngrabar_Click()", "Ocurrio un error al grabar [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnfuente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfuente.Click
        If Me.cboftedatos.SelectedIndex > -1 Then
            Dim ofrm As frmFuenteDatos
            ofrm = New frmFuenteDatos
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdftedatos = outil.Toma_Token(1, Me.cboftedatos.SelectedItem.ToString, "-")
            ofrm.Show()
        Else
            MsgBox("No hay ninguna fuente de datos seleccionada", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btncommentfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfile.Click
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txtfile.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub raddll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles raddll.CheckedChanged
        txtfile.Enabled = Not raddll.Checked
        btnfile.Enabled = Not raddll.Checked
    End Sub

    Private Sub radarchivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radarchivo.CheckedChanged
        txtfile.Enabled = radarchivo.Checked
        btnfile.Enabled = radarchivo.Checked
    End Sub
End Class