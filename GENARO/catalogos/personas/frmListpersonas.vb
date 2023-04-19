Option Explicit On
Imports MyLIB

Public Class frmlistpersonas
    Private obus As Catalogos
    Private outil As Utilerias

    Private Sub frmlistpersonas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro

        Try
            outil = New Utilerias
            oparent = Me.ParentForm
            obus = New Catalogos(oparent.conexion)
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmListpersonas.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub cbodetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbodetalle.Click
        If Me.gridpersonas.SelectedRows.Count > 0 Then
            Dim ofrm As frmPersona
            ofrm = New frmPersona
            ofrm.MdiParent = Me.ParentForm
            ofrm.cdpersona = Me.gridpersonas.SelectedRows.Item(0).Cells("clave").Value
            ofrm.Show()
        Else
            MsgBox("No hay ningún renglón seleccionado", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        End If
    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Dim ofrm As frmPersona
        ofrm = New frmPersona
        ofrm.MdiParent = Me.ParentForm
        ofrm.Show()
    End Sub

    Private Sub btnstaffload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstaffload.Click
        Call Consultar_Personas()
    End Sub

    Private Sub Consultar_Personas()

        Dim cpersonas As Collection
        Try
            cpersonas = obus.getPersonas()
            gridpersonas.Rows.Clear()
            gridpersonas.Columns.Clear()
            gridpersonas.Columns.Add("clave", "Clave")
            gridpersonas.Columns.Add("nombre", "Nombre")
            gridpersonas.Columns.Add("empresa", "Empresa")
            gridpersonas.Columns.Add("comment", "Comentario")

            gridpersonas.Columns.Item(1).Width = 200
            gridpersonas.Columns.Item(2).Width = 200
            gridpersonas.Columns.Item(3).Width = 200

            gridpersonas.Columns.Item("clave").SortMode = DataGridViewColumnSortMode.NotSortable
            gridpersonas.Columns.Item("nombre").SortMode = DataGridViewColumnSortMode.NotSortable
            gridpersonas.Columns.Item("empresa").SortMode = DataGridViewColumnSortMode.NotSortable
            gridpersonas.Columns.Item("comment").SortMode = DataGridViewColumnSortMode.NotSortable

            For Each oper As Persona In cpersonas
                gridpersonas.Rows.Add(oper.cdpersona, oper.nbpersona, oper.nbempresa, oper.comment)
            Next

            txttotpersonas.Text = "En total son " & cpersonas.Count & " Personas Registradas"

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmListpersonas.Consultar_Personas()", "Ocurrio un error al realizar la consulta")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btndel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndel.Click
        Try
            If obus.delPersona(Me.gridpersonas.SelectedRows.Item(0).Cells("clave").Value) Then
                Call Consultar_Personas()
            Else
                MsgBox(IIf(obus.mensaje.Equals(""), "Existio un error al eliminar los datos de la persona", obus.mensaje), MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmListpersonas.btndel_Click()", "Ocurrio un error al eliminar a la persona")
            outil.ShowException(ex)
        End Try

    End Sub
End Class