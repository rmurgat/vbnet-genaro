Option Explicit On
Imports MyLIB

Public Class frmpmiprojects
    Private obus As Catalogos
    Private outil As Utilerias

    Private Sub btndelfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprydel.Click
        Try
            If Me.gridprojects.SelectedRows.Count > 0 Then
                If obus.delProyecto(Me.gridprojects.SelectedRows.Item(0).Cells(0).Value) Then
                    MsgBox("Se ha eliminado el proyecto", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                    Call Consulta_Proyectos()
                Else
                    MsgBox(obus.mensaje, MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
                End If
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmListprojects.btndelfile_Click()", "Ocurrio un error al eliminar el registro")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub frmlistprojects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim cctes As Collection
        Dim cestatus As Collection

        Try
            oparent = Me.ParentForm
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias

            'PASO 1: LLena el catálogo de clientes
            cctes = obus.getClientes()
            cboCliente.Items.Add("-TODOS-")
            For Each octe As Cliente In cctes
                cboCliente.Items.Add(octe.cdcliente & " - " & octe.nbcliente)
            Next

            'PASO 2: Llena el catálogo de estatus
            cestatus = obus.getStProyectos()
            cboEstatus.Items.Add("-TODOS-")
            For Each ost As Estatus In cestatus
                cboEstatus.Items.Add(ost.clave & " - " & ost.nombre)
            Next

            cboCliente.SelectedIndex = 0
            cboEstatus.SelectedIndex = 0
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmListprojects.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmListprojects.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Call Consulta_Proyectos()
    End Sub

    Private Sub Consulta_Proyectos()
        Dim cproys As Collection
        Dim irow As Integer
        Dim ocrit As Criterio

        Try
            'PASO 1: Incializa variables
            ocrit = New Criterio
            irow = 1
            ocrit.cdcliente = outil.Toma_Token(1, Me.cboCliente.SelectedItem, "-")
            ocrit.cdstproyecto = outil.Toma_Token(1, Me.cboEstatus.SelectedItem, "-")
            cproys = obus.getProyectos(ocrit)

            'PASO 2: Formatea el grid de proyectos
            gridprojects.Rows.Clear()
            gridprojects.Columns.Clear()
            gridprojects.Columns.Add("cdproyecto", "Clave")
            gridprojects.Columns.Add("nbproyecto", "Nombre")
            gridprojects.Columns.Add("cdestatus", "Estatus")
            gridprojects.Columns.Add("nbcliente", "Cliente")
            gridprojects.Columns.Add("txcomment", "Comentario")

            gridprojects.Columns.Item("cdproyecto").Width = 60
            gridprojects.Columns.Item("nbproyecto").Width = 300
            gridprojects.Columns.Item("cdestatus").Width = 115
            gridprojects.Columns.Item("nbcliente").Width = 200
            gridprojects.Columns.Item("txcomment").Width = 400

            gridprojects.Columns.Item("cdproyecto").SortMode = DataGridViewColumnSortMode.NotSortable
            gridprojects.Columns.Item("nbproyecto").SortMode = DataGridViewColumnSortMode.NotSortable
            gridprojects.Columns.Item("cdestatus").SortMode = DataGridViewColumnSortMode.NotSortable
            gridprojects.Columns.Item("nbcliente").SortMode = DataGridViewColumnSortMode.NotSortable
            gridprojects.Columns.Item("txcomment").SortMode = DataGridViewColumnSortMode.NotSortable

            For Each op As Proyecto In cproys
                Dim ocliente As Cliente
                Dim oestatus As Estatus
                ocliente = obus.getCliente(op.cdcliente)
                oestatus = obus.getStProyecto(op.cdstproyecto)
                Me.gridprojects.Rows.Add(op.cdproyecto, op.nbproyecto, oestatus.nombre, ocliente.nbcliente, op.comment)
            Next

            txttotprojects.Text = "Un total de " & cproys.Count & " proyectos "
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmListprojects.Consulta_Proyectos()", "Ocurrio un error al consultar la información")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cbodetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbodetalle.Click
        If Me.gridprojects.SelectedRows.Count > 0 Then
            Dim ofrm As frmPMIProyecto
            ofrm = New frmPMIProyecto
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdproject = Me.gridprojects.SelectedRows.Item(0).Cells(0).Value
            ofrm.Show()
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btnpryadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpryadd.Click
        Dim ofrm As frmPMIaddproyecto
        ofrm = New frmPMIaddproyecto
        ofrm.MdiParent = Me.ParentForm
        ofrm.Show()
    End Sub
End Class