Option Explicit On

Imports MyLIB

Public Class frmaddNavegacion1
    Private obus As Catalogos
    Private scdproject As String = ""   'Clave del proyecto
    Private scddesde As String = ""     'Clave de la pantalla desde
    Private oproject As Proyecto        'Objeto que tiene las propiedades del proyecto
    Private outil As Utilerias          'Utilerias del sistema

    ''' <summary>
    ''' PROPIEDAD: Clave del proyecto
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdproject() As String
        Get
            Return scdproject
        End Get
        Set(ByVal pscd As String)
            scdproject = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave de la pantalla desde
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cddesde() As String
        Get
            Return scddesde
        End Get
        Set(ByVal pscd As String)
            scddesde = pscd
        End Set
    End Property

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmaddNavegacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim ocol As Collection

        Try
            'PASO 1: Inicializa objetos de negocio 
            oparent = Me.ParentForm
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias

            'PASO 2: Consulta los datos del proyecto
            oproject = obus.getProyecto(Me.cdproject)
            Me.lblcdproyecto.Text = oproject.cdproyecto
            Me.txtnbproyecto.Text = oproject.nbproyecto

            'PASO 3: Consulta las pantallas
            ocol = obus.getPantallas(Me.cdproject)
            For Each opan As Pantalla In ocol
                cbodesde.Items.Add(opan.cdpantalla & " - " & opan.nbpantalla)
                cbohasta.Items.Add(opan.cdpantalla & " - " & opan.nbpantalla)
            Next

            'PASO 4: Si trae la clave desde...
            If Not scddesde.Equals("") Then
                cbodesde.SelectedIndex = Me.cbodesde.FindString(Me.cddesde)
                cbodesde.Enabled = False
            End If
        Catch ex As HANYException
            ex.add("MyGENARO.frmaddNavegacion.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim obj As Navegacion = New Navegacion

        If Me.cbodesde.SelectedIndex < 0 Then
            MsgBox("Es necesario seleccionar la pantalla inicial", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        If Me.cbohasta.SelectedIndex < 0 Then
            MsgBox("Es necesario seleccionar la pantalla final", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            obj.cdproyecto = Me.cdproject
            obj.cdesde = outil.Toma_Token(1, Me.cbodesde.SelectedItem, "-")
            obj.cdhasta = outil.Toma_Token(1, Me.cbohasta.SelectedItem, "-")
            obj.tpnavegacion = IIf(Me.radget.Checked, "GET", "POST")
            obj.stopenwindow = Me.chknewindow.Checked

            obus.saveNavegacion(obj)
            MsgBox("Se dieron de alta los datos de la navegación exitosamente", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.Close()
        Catch ex As HANYException
            ex.add("MyGENARO.frmaddNavegacion.btnGrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyGENARO.frmaddNavegacion.btnGrabar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub
End Class