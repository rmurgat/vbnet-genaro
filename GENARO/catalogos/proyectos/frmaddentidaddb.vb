Option Explicit On
Imports MyLIB

Public Class frmaddentidaddb
    Private obus As Catalogos
    Private scdftedatos As String       'Clave de la fuente de datos
    Private ofuentedatos As FuenteDato  'Objeto que tiene las propiedades de una fuente de datos
    Private outil As Utilerias          'Utilerias del sistema
    Private bSoloLectura As Boolean     'bandera de solo lectura

    ''' <summary>
    ''' PROPIEDAD: Clave de la fuente de datos
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdftedatos() As String
        Get
            Return scdftedatos
        End Get
        Set(ByVal pscd As String)
            scdftedatos = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: bandera de solo lectura
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property SoloLectura() As Boolean
        Get
            Return bSoloLectura
        End Get
        Set(ByVal pbval As Boolean)
            bSoloLectura = pbval
        End Set
    End Property

    Private Sub frmaddentidaddb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim ctipos As Collection

        Try
            'PASO 1: Inicializa objetos de negocio 
            oparent = Me.ParentForm
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias

            'PASO 2: LLena el catálogo de tipos de entidad de datos
            ctipos = obus.getTpEntidaDatos()
            For Each otipo As Tipo In ctipos
                cbotipo.Items.Add(otipo.clave & " - " & otipo.nombre)
            Next
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmaddentidaddb.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click
        Dim obj As EntidaDato = New EntidaDato

        If Me.txtnombre.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el nombre de la entidad de datos", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        If Me.cbotipo.SelectedIndex < 0 Then
            MsgBox("Es necesario seleccionar el tipo de entidad de datos", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        If Me.txtcomentario.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el comentario de la entidad de datos", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            obj.cdfuentedato = Me.cdftedatos
            obj.nbentidadato = Me.txtnombre.Text
            obj.tpentidadato = outil.Toma_Token(1, Me.cbotipo.SelectedItem, "-")
            obj.txcomment = Me.txtcomentario.Text

            obus.saveEntidaDato(obj)
            MsgBox("Se dieron de alta los datos de la nueva entidad de datos exitosamente", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.Close()
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmaddentidaddb.cmdgrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmaddentidaddb.cmdgrabar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class