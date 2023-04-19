Option Explicit On
Imports MyLIB

Public Class frmDBEliminacion
    Private obus As Catalogos
    Private outil As Utilerias          'Utilerias del sistema
    Private omdipa As MDIGenaro

    Private Sub frmDBEliminacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cftes As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            outil = New Utilerias
            omdipa = Me.ParentForm
            obus = New Catalogos(omdipa.conexion)

            'PASO 3: LLena el catálogo de fuentes de datos
            cftes = obus.getFuenteDatos(New Criterio)
            For Each ofte As FuenteDato In cftes
                cbofuente.Items.Add(ofte.cdfuentedato & " - " & ofte.nbfuentedato)
            Next

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBEliminacion.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBEliminacion.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub btnfuente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfuente.Click
        If Me.cbofuente.SelectedIndex > -1 Then
            Dim ofrm As frmFuenteDatos
            ofrm = New frmFuenteDatos
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdftedatos = outil.Toma_Token(1, Me.cbofuente.SelectedItem.ToString, "-")
            ofrm.Show()
        Else
            MsgBox("No hay ninguna fuente de datos seleccionada", MsgBoxStyle.Exclamation, "MySUIT Tools")
        End If
    End Sub

    Private Sub btnleer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnleer.Click
        Dim centidades As Collection
        Dim irow As Integer

        'PASO 1: Valida la fuente de datos
        If Me.cbofuente.SelectedIndex < 0 Then
            MsgBox("No hay ninguna fuente de datos seleccionada", MsgBoxStyle.Exclamation, "MySUIT Tools")
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
            ex.add("MyCATALOGOS.frmDBEliminacion.btnleer_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBEliminacion.btnleer_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub chktodas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chktodas.CheckedChanged
        Dim iren As Integer
        For iren = 0 To gridEntidades.Rows.Count - 1
            gridEntidades.Item("select", iren).Value = chktodas.Checked
        Next iren
    End Sub

    Private Sub cbosalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbosalir.Click
        Me.Close()
    End Sub

    Private Sub cboeliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboeliminar.Click
        Dim iren As Integer
        Dim cftes As Collection

        If Not Valida_Datos() Then Exit Sub
        Try
            'PASO 2: En caso de haber seleccionado algunas
            Me.Cursor = Cursors.WaitCursor
            For iren = 0 To gridEntidades.Rows.Count - 1
                If gridEntidades.Item("select", iren).Value = True Then
                    If chkdelall.Checked Then obus.delallEntidadDato(outil.Toma_Token(1, Me.cbofuente.SelectedItem, "-"), gridEntidades.Item("entidad", iren).Value)
                    If chkdelref.Checked Then obus.delallReferences(outil.Toma_Token(1, Me.cbofuente.SelectedItem, "-"), gridEntidades.Item("entidad", iren).Value)
                End If
            Next iren

            'PASO 2: LLena el catálogo de fuentes de datos
            cftes = obus.getFuenteDatos(New Criterio)
            For Each ofte As FuenteDato In cftes
                cbofuente.Items.Add(ofte.cdfuentedato & " - " & ofte.nbfuentedato)
            Next

            'PASO 3: Reconfigura el grid
            Call Configura_Grid()
            Me.Cursor = Cursors.Default
            MsgBox("!PROCESO TERMINADO!", MsgBoxStyle.Information, "ATL Tools Suit")

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBEliminacion.cboeliminar_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBEliminacion.cboeliminar_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try

        MsgBox("Se ha Eliminado la información del sistema", MsgBoxStyle.Information, "MySUIT Tools")
    End Sub

    ''' <summary>
    ''' Funcion para validar los insumos 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Valida_Datos() As Boolean
        If chkdelall.Checked = False And chkdelref.Checked = False Then
            MsgBox("No se ha seleccionado nada de información a eliminar", MsgBoxStyle.Exclamation, "MySUIT Tools")
            Return False
        End If
        Return True
    End Function

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

    Private Sub chkdelall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdelall.CheckedChanged
        If chkdelall.Checked = True Then
            chkdelref.Checked = True
        End If
    End Sub
End Class