Option Explicit On

Imports MyLIB

Public Class frmDBWizConversion
    Private ipagina As Integer = 1
    Private outil As Utilerias = New MyLIB.Utilerias
    Private omdipa As MDIGenaro
    Private obus As Catalogos

    Private Sub frmDBWizConversion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cftes As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)
            outil = New Utilerias

            'PASO 2: LLena el catálogo de fuentes de datos
            cftes = obus.getFuenteDatos(New Criterio)
            For Each ofte As FuenteDato In cftes
                cbofteorigen.Items.Add(ofte.cdfuentedato & " - " & ofte.nbfuentedato)
                cboftedestino.Items.Add(ofte.cdfuentedato & " - " & ofte.nbfuentedato)
            Next
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBWizConversion.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBWizConversion.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
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

    Private Sub btnfuente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfuente.Click
        If Me.cbofteorigen.SelectedIndex > -1 Then
            Dim ofrm As frmFuenteDatos
            ofrm = New frmFuenteDatos
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdftedatos = outil.Toma_Token(1, Me.cbofteorigen.SelectedItem.ToString, "-")
            ofrm.Show()
        Else
            MsgBox("No hay ninguna fuente de datos seleccionada", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btncargatipos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncargatipos.Click
        Dim ctipos As Collection
        Dim irow As Integer

        'PASO 1: Valida insumos
        If Me.cbofteorigen.SelectedIndex < 0 Then
            MsgBox("No hay ninguna fuente de datos ORIGEN seleccionada", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            'PASO 2: Inicializa
            irow = 1
            Call Configura_Grid()

            'PASO 3: Llena el grid con los tipos de datos a considerar
            ctipos = obus.getallTipoAConvertir(outil.Toma_Token(1, Me.cbofteorigen.SelectedItem.ToString, "-"))
            For Each stipo As String In ctipos
                gridTipos.Rows.Add(irow, stipo)
                irow = irow + 1
            Next
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBWizConversion.btncargatipos_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBWizConversion.btncargatipos_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub Configura_Grid()
        gridTipos.Rows.Clear()
        gridTipos.Columns.Clear()
        gridTipos.Columns.Add("row", "#")
        gridTipos.Columns.Add("origen", "Tipo Original")
        gridTipos.Columns.Add("destino", "Tipo Destino")
        gridTipos.Columns.Item("row").Width = 40
        gridTipos.Columns.Item("origen").Width = 150
        gridTipos.Columns.Item("destino").Width = 150
        gridTipos.Columns.Item("origen").ReadOnly = True
        gridTipos.Columns.Item("row").ReadOnly = True
        gridTipos.Columns.Item("row").SortMode = DataGridViewColumnSortMode.NotSortable
        gridTipos.Columns.Item("origen").SortMode = DataGridViewColumnSortMode.NotSortable
        gridTipos.Columns.Item("destino").SortMode = DataGridViewColumnSortMode.NotSortable

    End Sub

    Private Sub btnconvertir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconvertir.Click
        Dim centidades As Collection
        Dim corigen As Collection
        Dim cdestino As Collection
        Dim ipos As Integer

        'PASO 1: Valida los datos
        corigen = New Collection
        cdestino = New Collection
        If Me.cbofteorigen.SelectedIndex < 0 Then
            MsgBox("No hay ninguna fuente de datos ORIGEN seleccionada", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        If Me.cboftedestino.SelectedIndex < 0 Then
            MsgBox("No hay ninguna fuente de datos ORIGEN seleccionada", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        If Me.gridTipos.RowCount = 0 Then
            MsgBox("Es necesario ingresar los tipos de datos a convertir", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        'PASO 1.1 : Valida las reglas de conversión
        For Each orow As DataGridViewRow In Me.gridTipos.Rows
            Dim sorigen As String = orow.Cells("origen").Value
            Dim sdestino As String = orow.Cells("destino").Value
            If sdestino.Equals("") Then
                MsgBox("Es necesario ingresar todas las reglas de conversión", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
                Exit Sub
            End If
            corigen.Add(sorigen)
            cdestino.Add(sdestino)
        Next

        Try

            'PASO 2: Inicializa 
            lstdebug.Items.Clear()

            'PASO 3: Inicia la conversióna la nueva fuente de datos
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "PASO 1: CONVIRTIENDO los tipos de datos")
            centidades = obus.getEntidaDatos(outil.Toma_Token(1, Me.cbofteorigen.SelectedItem.ToString, "-"))
            For Each oent As EntidaDato In centidades
                oent.ccampos = obus.getEntidaDatoCampos(oent.cdfuentedato, oent.nbentidadato)
                outil.addToListDebug(lstdebug, "  ENTIDAD : " & oent.nbentidadato)
                For Each ocampo As EntidaDatoCampo In oent.ccampos
                    For ipos = 1 To corigen.Count
                        If corigen.Item(ipos).Equals(ocampo.cdtpdatofisico) Then
                            ocampo.cdtpdatofisico = cdestino.Item(ipos)
                        End If
                    Next
                    ocampo.cdfuentedato = outil.Toma_Token(1, Me.cboftedestino.SelectedItem.ToString, "-")
                Next
                oent.cdfuentedato = outil.Toma_Token(1, Me.cboftedestino.SelectedItem.ToString, "-")
            Next

            'PASO 4: Inicia el proceso para grabar las entidades convertidas
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "PASO 2: GBRABANDO en la nueva fuente de datos")
            For Each oent As EntidaDato In centidades
                Dim otmp As EntidaDato

                'PASO 4.1: Busca la entidad de datos, y si no la encuentra graba la información
                otmp = obus.getEntidaDato(outil.Toma_Token(1, Me.cboftedestino.SelectedItem.ToString, "-"), oent.nbentidadato)
                If otmp Is Nothing Then
                    obus.saveEntidaDato(oent)
                    outil.addToListDebug(lstdebug, "  ENTIDAD : " & oent.nbentidadato)
                    For Each ocampo As EntidaDatoCampo In oent.ccampos
                        obus.saveEntidaDatoCampo(ocampo)
                    Next
                Else
                    outil.addToListDebug(lstdebug, "  ERROR ENTIDAD : " & otmp.nbentidadato & " YA EXISTE!")
                End If
            Next

            'PASO 5: Termina
            outil.addToListDebug(lstdebug, "!PROCESO TERMINADO!")
            MsgBox("!PROCESO TERMINADO!", MsgBoxStyle.Information, "ATL Tools Suit")

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBWizConversion.btnconvertir_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBWizConversion.btnconvertir_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try

    End Sub
End Class