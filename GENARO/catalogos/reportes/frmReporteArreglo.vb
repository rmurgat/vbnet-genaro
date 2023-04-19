Option Explicit On
Imports MyLIB

Public Class frmReporteArreglo
    Private obus As Catalogos
    Private scdproject As String = ""   ' Clave del proyecto
    Private scdreporte As String = ""   ' Clave del reporte
    Private scdarreglo As String = ""   ' Clave del arreglo
    Private oproject As Proyecto        ' Objeto que tiene las propiedades del proyecto
    Private oreporte As Reporte         ' Objeto que tiene las propiedades del reporte
    Private oarreglo As ReporteArreglo  ' Objeto que tiene las propiedades y metodos de un arreglo
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
    ''' PROPIEDAD: Clave del arreglo
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdarreglo() As String
        Get
            Return scdarreglo
        End Get
        Set(ByVal pscd As String)
            scdarreglo = pscd
        End Set
    End Property

    Private Sub frmReporteArreglo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim carreglos As Collection

        Try
            oparent = Me.ParentForm
            outil = New Utilerias

            'PASO 1: Incializa los objetos de negocio y utilerias
            obus = New Catalogos(oparent.conexion)
            oproject = obus.getProyecto(Me.cdproject)
            oreporte = obus.getReporte(Me.cdproject, Me.cdreporte)

            'PASO 2: Coloca los valores del proyecto y pantalla
            txtcdproyecto.Text = oproject.cdproyecto
            txtnbproyecto.Text = oproject.nbproyecto
            txtcdreporte.Text = oreporte.cdreporte
            txtnbreporte.Text = oreporte.nbreporte

            'PASO 3: consulta la información del arreglo
            Consulta_Arreglo()

            'PASO 5: Consulta todos los arreglos de la pantalla
            carreglos = obus.getReporteArreglos(Me.cdproject, Me.cdreporte)
            For Each oarr As ReporteArreglo In carreglos
                Me.cboarreglo.Items.Add(oarr.cdarreglo & " - " & oarr.nbarreglo)
            Next

            'PASO 4: En caso de traer información del arreglo
            If Not Me.cdarreglo.Equals("") Then Me.cboarreglo.SelectedIndex = cboarreglo.FindString(Me.cdarreglo)

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmReporteArreglo.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub Consulta_Arreglo()
        Try
            oarreglo = obus.getReporteArreglo(Me.cdproject, Me.cdreporte, Me.cdarreglo)
            txtNombre.Text = oarreglo.nbarreglo
            txtregistros.Text = oarreglo.nurensxpagina
            chkpaginacion.Checked = IIf(oarreglo.haspaginacion(), True, False)
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmReporteArreglo.Consulta_Arreglo()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyCATALOGOS.frmReporteArreglo.Consulta_Arreglo()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click

        If Me.txtNombre.Text.Trim.Equals("") Then
            MsgBox("Es necesario que ingrese el nombre del arreglo", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        If Me.txtregistros.Text.Trim.Equals("") Then
            MsgBox("Es necesario que ingrese el número de registros por pantalla", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If

        Try
            oarreglo.nbarreglo = txtNombre.Text
            oarreglo.nurensxpagina = txtregistros.Text
            oarreglo.stpaginacion = IIf(chkpaginacion.Checked, Comun.ST_ACTIVO, Comun.ST_INACTIVO)
            obus.saveReporteArreglo(oarreglo)
            MsgBox("La información del arreglo fué grabada exitosamente", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.Close()
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmReporteArreglo.cmdgrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmReporteArreglo.cmdgrabar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class