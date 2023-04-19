Option Explicit On

Imports MyLIB

Public Class frmlistprojects
    Private obus As Catalogos
    Private outil As Utilerias

    Private Sub frmlistprojects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Try
            oparent = Me.ParentForm
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias
            Call Consulta_Proyectos()
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmListprojects.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmListprojects.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Consulta_Proyectos()
    End Sub

    Private Sub Consulta_Proyectos()
        Dim cproys As Collection
        Dim irow As Integer

        Try
            'PASO 1: Incializa variables
            irow = 1
            cproys = obus.getProyectos(New Criterio)

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

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmListprojects.Consulta_Proyectos()", "Ocurrio un error al consultar la información")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub gridprojects_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles gridprojects.CellContentClick

    End Sub

    Private Sub cbodetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbodetalle.Click
        If Me.gridprojects.SelectedRows.Count > 0 Then
            Dim ofrm As frmProyecto
            ofrm = New frmProyecto
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdproject = Me.gridprojects.SelectedRows.Item(0).Cells(0).Value
            ofrm.Show()
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub
End Class