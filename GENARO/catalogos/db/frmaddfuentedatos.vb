Option Explicit On

Imports MyLIB

Public Class frmaddfuentedatos
    Private obus As Catalogos
    Private outil As Utilerias          'Utilerias del sistema

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmaddfuentedatos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim cctes As Collection

        Try
            'PASO 1: Inicializa objetos de negocio 
            oparent = Me.ParentForm
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias

            'PASO 2: LLena el catálogo de clientes
            cctes = obus.getClientes()
            For Each octe As Cliente In cctes
                cbocliente.Items.Add(octe.cdcliente & " - " & octe.nbcliente)
            Next
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmaddfuentedatos.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click
        Dim obj As FuenteDato = New FuenteDato

        If Me.txtnombre.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el nombre de la fuente de datos", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        If Me.cbocliente.SelectedIndex < 0 Then
            MsgBox("Es necesario seleccionar el cliente al que pertenece la fuente de datos", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        If Me.cbotipo.SelectedIndex < 0 Then
            MsgBox("Es necesario seleccionar el tipo de fuente de datos", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        If Me.txtcomentario.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el comentario de la fuente de datos", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            obj.nbfuentedato = Me.txtnombre.Text
            obj.cdcliente = outil.Toma_Token(1, Me.cbocliente.SelectedItem, "-")
            obj.tpfuentedato = outil.Toma_Token(1, Me.cbotipo.SelectedItem, "-")
            obj.stfuentedato = "AC"
            obj.txcomment = Me.txtcomentario.Text

            obus.saveFuenteDato(obj)
            MsgBox("Se dieron de alta los datos de la nueva fuente de datos exitosamente", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.Close()
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmaddfuentedatos.cmdgrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmaddfuentedatos.cmdgrabar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub
End Class