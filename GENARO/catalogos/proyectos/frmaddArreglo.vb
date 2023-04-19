Option Explicit On
Imports MyLIB

Public Class frmaddArreglo
    Private obus As Catalogos           ' Objeto con los metodos de negocio
    Private scdproject As String = ""   ' Clave del proyecto
    Private scdpantalla As String = ""  ' Clave de la pantalla
    Private scdreporte As String = ""   ' Clave del reporte
    Private oproject As Proyecto        ' Objeto que tiene las propiedades del proyecto
    Private opantalla As Pantalla       ' Objeto que tiene las propiedades de la pantalla
    Private outil As Utilerias          ' Utilerias del sistema
    Private btppantalla As Boolean = False    'bandera tipo pantalla
    Private btpreporte As Boolean = False     'bandera tipo reporte


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
    ''' PROPIEDAD: Clave de la pantalla
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property cdpantalla() As String
        Get
            Return scdpantalla
        End Get
        Set(ByVal pscd As String)
            scdpantalla = pscd
            btppantalla = True
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
            btpreporte = True
        End Set
    End Property

    Private Sub frmaddPantallaArreglo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro

        Try
            oparent = Me.ParentForm
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmaddArreglo.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try
    End Sub

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click

        'PASO 1: Valida el nombre
        If Me.txtNombre.Text.Trim.Equals("") Then
            MsgBox("Es necesario que ingrese el nombre del arreglo", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        Try
            If btppantalla Then
                Dim oadd As Pantallarreglo

                'PASO 2: Inicializa el objeto
                oadd = New Pantallarreglo()
                oadd.cdproyecto = Me.cdproject
                oadd.cdpantalla = Me.cdpantalla
                oadd.nbarreglo = Me.txtNombre.Text
                oadd.tpinoutput = IIf(radinput.Checked, Comun.TIPO_CAMPO_INPUT, Comun.TIPO_CAMPO_OUTPUT)

                'PASO 3: graba la información de la pantalla
                obus.savePantallarreglo(oadd)
            End If
            If btpreporte Then
                Dim oadd As ReporteArreglo

                'PASO 4: Inicializa el objeto
                oadd = New ReporteArreglo()
                oadd.cdproyecto = Me.cdproject
                oadd.cdreporte = Me.cdreporte
                oadd.nbarreglo = Me.txtNombre.Text

                'PASO 5: graba la información de la pantalla
                obus.saveReporteArreglo(oadd)
            End If

            'PASO 6: Muestra el mensaje
            MsgBox("La información del arreglo fué grabada exitosamente", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.Close()

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmaddArreglo.cmdgrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        End Try
    End Sub
End Class