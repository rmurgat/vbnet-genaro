Option Explicit On

Imports MyLIB

Public Class frmlistfuentedatos
    Private obus As Catalogos
    Private outil As Utilerias

    Private Sub frmlistprojects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim cctes As Collection

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

            cboCliente.SelectedIndex = 0
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmListfuentedatos.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmListfuentedatos.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
        Call Consulta_FuenteDatos()
    End Sub

    Private Sub Consulta_FuenteDatos()
        Dim cdatasources As Collection
        Dim ocrit As Criterio

        Try
            gridatasource.Rows.Clear()
            gridatasource.Columns.Clear()
            gridatasource.Columns.Add("clave", "Clave")
            gridatasource.Columns.Add("fuente", "Nombre")
            gridatasource.Columns.Add("cliente", "Nombre del Cliente")

            gridatasource.Columns.Item("clave").Width = 60
            gridatasource.Columns.Item("fuente").Width = 300
            gridatasource.Columns.Item("cliente").Width = 350

            gridatasource.Columns.Item("clave").SortMode = DataGridViewColumnSortMode.NotSortable
            gridatasource.Columns.Item("fuente").SortMode = DataGridViewColumnSortMode.NotSortable
            gridatasource.Columns.Item("cliente").SortMode = DataGridViewColumnSortMode.NotSortable

            ocrit = New Criterio
            ocrit.cdcliente = outil.Toma_Token(1, Me.cboCliente.SelectedItem, "-")
            cdatasources = obus.getFuenteDatos(ocrit)
            For Each ods As FuenteDato In cdatasources
                Dim octe As Cliente = obus.getCliente(ods.cdcliente)
                Dim snbcliente As String = ""
                If Not octe Is Nothing Then snbcliente = octe.nbcliente
                gridatasource.Rows.Add(ods.cdfuentedato, ods.nbfuentedato, snbcliente)
            Next
            txttotdatasource.Text = "Un total de " & cdatasources.Count & " fuentes de datos"
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmListfuentedatos.Consulta_FuenteDatos()", "Ocurrio un error al consultar las fuentes de datos")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmListfuentedatos.Consulta_FuenteDatos()", "Ocurrio un error al consultar las fuentes de datos [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim ofrm As frmaddfuentedatos
        ofrm = New frmaddfuentedatos
        ofrm.MdiParent = Me.ParentForm
        ofrm.Show()
    End Sub

    Private Sub cbodetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbodetalle.Click
        If Me.gridatasource.SelectedRows.Count > 0 Then
            Dim ofrm As frmFuenteDatos
            ofrm = New frmFuenteDatos
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdftedatos = Me.gridatasource.SelectedRows.Item(0).Cells("clave").Value
            ofrm.Show()
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        Try
            If Me.gridatasource.SelectedRows.Count > 0 Then
                If obus.delFuenteDato(Me.gridatasource.SelectedRows.Item(0).Cells("clave").Value) Then
                    MsgBox("Se ha eliminado el registro de la fuente de datos", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
                    Call Consulta_FuenteDatos()
                Else
                    MsgBox(obus.mensaje, MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
                End If
            Else
                MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmListfuentedatos.btndel_Click()", "ocurrio un error en operación")
            outil.ShowException(ex)
        End Try

    End Sub
End Class