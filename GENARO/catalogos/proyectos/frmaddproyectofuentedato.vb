Option Explicit On
Imports MyLIB

Public Class frmaddproyectofuentedato
    Private obus As Catalogos
    Private outil As Utilerias          'Utilerias del sistema
    Private scdproject As String       'Clave del proyecto

    ''' <summary>
    ''' PROPIEDAD: Clave del proyecto
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property cdproject() As String
        Get
            Return scdproject
        End Get
        Set(ByVal psnb As String)
            scdproject = psnb
        End Set
    End Property

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmaddproyectofuentedato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim cftes As Collection
        Dim ocrit As Criterio
        Dim oproyecto As Proyecto

        Try
            'PASO 1: Inicializa objetos de negocio 
            oparent = Me.ParentForm
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias
            ocrit = New Criterio
            oproyecto = obus.getProyecto(scdproject)
            ocrit.cdcliente = oproyecto.cdcliente

            'PASO 2: LLena el catálogo de tipos de entidad de datos

            cftes = obus.getFuenteDatos(ocrit)
            For Each ofte As FuenteDato In cftes
                cbofuente.Items.Add(ofte.cdfuentedato & " - " & ofte.nbfuentedato)
            Next
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmaddproyectofuentedato.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click
        Dim obj As ProyectoFuenteDato = New ProyectoFuenteDato

        If Me.cbofuente.SelectedIndex < 0 Then
            MsgBox("Es necesario seleccionar una fuente de datos", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        If Me.txtcomentario.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el comentario al margen", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            obj.cdproyecto = Me.cdproject
            obj.cdfuentedato = outil.Toma_Token(1, Me.cbofuente.SelectedItem, "-")
            obj.txcomment = Me.txtcomentario.Text

            obus.saveProyectoFuenteDato(obj)
            MsgBox("Se dio de alta la relación con la fuente de datos", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.Close()
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmaddproyectofuentedato.cmdgrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmaddproyectofuentedato.cmdgrabar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub
End Class