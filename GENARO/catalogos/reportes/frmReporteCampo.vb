Option Explicit On
Imports MyLIB

Public Class frmReporteCampo
    Private obus As Catalogos
    Private scdproject As String = ""   'Clave del proyecto
    Private scdreporte As String = ""   'Clave del reporte
    Private scdcampo As String = ""     'Clave del campo
    Private oproject As Proyecto        'Objeto que tiene las propiedades del proyecto
    Private oreporte As Reporte         'Objeto que tiene las propiedades del reporte
    Private ocampo As ReporteCampo      'Objeto que tiene las propiedades y metodos de un campo
    Private bSoloLectura As Boolean     'bandera de solo lectura
    Private outil As Utilerias

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
    ''' PROPIEDAD: Clave del reporte
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdreporte() As String
        Get
            Return scdreporte
        End Get
        Set(ByVal pscd As String)
            scdreporte = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Clave del campo
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdcampo() As String
        Get
            Return scdcampo
        End Get
        Set(ByVal pscd As String)
            scdcampo = pscd
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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmReporteCampo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim ctipocampos As Collection
        Dim carreglos As Collection

        Try
            outil = New Utilerias
            oparent = Me.ParentForm

            'PASO 1: Incializa los objetos de negocio y utilerias
            obus = New Catalogos(oparent.conexion)
            oproject = obus.getProyecto(Me.cdproject)
            oreporte = obus.getReporte(Me.cdproject, Me.cdreporte)

            'PASO 2: Coloca los valores del reporte
            txtcdproyecto.Text = oproject.cdproyecto
            txtnbproyecto.Text = oproject.nbproyecto
            txtcdreporte.Text = oreporte.cdreporte
            txtnbreporte.Text = oreporte.nbreporte

            'PASO 3: Llena el catálogo de tipos de campo
            ctipocampos = obus.getTpCampos()
            For Each ost As Estatus In ctipocampos
                Me.cbotipo.Items.Add(ost.clave & " - " & ost.nombre)
            Next

            'PASO 4: Llena el catálogo de arreglos
            Me.cboarreglo.Items.Add("")
            carreglos = obus.getReporteArreglos(Me.cdproject, Me.cdreporte)
            For Each oarr As ReporteArreglo In carreglos
                Me.cboarreglo.Items.Add(oarr.cdarreglo & " - " & oarr.nbarreglo)
            Next

            Consulta_Campo()
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmReporteCampo.Load()", "Ocurrio un error al cargar la pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub Consulta_Campo()
        Try
            If Not Me.cdcampo.Equals("") Then
                ocampo = obus.getReporteCampo(Me.cdproject, Me.cdreporte, Me.cdcampo)
                txtcdcampo.Text = ocampo.cdcampo
                txtNombre.Text = ocampo.nbcampo
                cbotipo.SelectedIndex = cbotipo.FindString(ocampo.cdtpcampo)
                cboarreglo.SelectedIndex = cboarreglo.FindString(ocampo.cdarreglo)
                txtdecimales.Text = ocampo.nudecimales
                Me.txtcomentario.Text = ocampo.txcomment
            Else
                txtdecimales.Text = 0
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmReporteCampo.Consulta_Campo()", "Ocurrio un error al consultar el campo")
            Throw ex
        End Try

    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click
        txtNombre.Text = txtNombre.Text.ToUpper
        If Me.txtNombre.Text.Trim.Equals("") Then
            MsgBox("Es necesario que ingrese el nombre del campo", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        If Me.cbotipo.SelectedIndex < 0 Then
            MsgBox("Es necesario que ingrese el tipo de campo", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        Try
            ocampo = New ReporteCampo
            ocampo.cdproyecto = Me.cdproject
            ocampo.cdreporte = Me.cdreporte
            ocampo.cdcampo = Me.txtcdcampo.Text
            ocampo.nudecimales = Me.txtdecimales.Text
            ocampo.cdtpcampo = outil.Toma_Token(1, Me.cbotipo.SelectedItem, "-")
            ocampo.cdarreglo = outil.Toma_Token(1, Me.cboarreglo.SelectedItem, "-")
            ocampo.nbcampo = Me.txtNombre.Text
            ocampo.txcomment = Me.txtcomentario.Text

            obus.saveReporteCampo(ocampo)
            MsgBox("La información del campo fué grabada exitosamente", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.Close()
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmReporteCampo.cmdgrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmReporteCampo.cmdgrabar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try
    End Sub
End Class