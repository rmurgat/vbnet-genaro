Option Explicit On
Imports MyLIB

Public Class frmPMIaddproyecto
    Private obus As Catalogos
    Private outil As Utilerias          'Utilerias del sistema

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub frmaddproyecto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim cempresas As Collection
        Dim cctes As Collection

        Try
            'PASO 1: Inicializa objetos de negocio 
            oparent = Me.ParentForm
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias

            'PASO 2: LLena el catálogo de empresas
            cempresas = obus.getEmpresas()
            For Each oemp As Empresa In cempresas
                cboempresa.Items.Add(oemp.cdempresa & " - " & oemp.nbempresa)
            Next

            'PASO 3: LLena el catálogo de clientes
            cctes = obus.getClientes()
            For Each octe As Cliente In cctes
                cbocliente.Items.Add(octe.cdcliente & " - " & octe.nbcliente)
            Next
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmaddproyecto.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click
        Dim obj As Proyecto = New Proyecto
        Me.txtnombre.Text = Me.txtnombre.Text.ToUpper

        If Me.txtnombre.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el nombre del proyecto", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        If Me.cboempresa.SelectedIndex < 0 Then
            MsgBox("Es necesario seleccionar la empresa que desarrolla el sistema", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        If Me.cbocliente.SelectedIndex < 0 Then
            MsgBox("Es necesario seleccionar el cliente al que se le desarrolla el sisema", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        If Me.txtcomentario.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el comentario del proyecto", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            obj.nbproyecto = Me.txtnombre.Text
            obj.cdpmp = "000000"
            obj.cdcliente = outil.Toma_Token(1, Me.cbocliente.SelectedItem, "-")
            obj.cdempresa = outil.Toma_Token(1, Me.cboempresa.SelectedItem, "-")
            obj.cdstproyecto = "UN"
            obj.comment = Me.txtcomentario.Text

            obus.saveProyecto(obj)
            MsgBox("Se dieron de alta los datos del nuevo proyecto exitosamente", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.Close()
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmaddproyecto.cmdgrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmaddproyecto.cmdgrabar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub
End Class