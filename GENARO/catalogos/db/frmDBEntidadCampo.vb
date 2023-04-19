Option Explicit On

Imports MyLIB

Public Class frmDBEntidadCampo
    Private obus As Catalogos
    Private scdftedatos As String = ""      'Clave de la fuente de datos
    Private snbdbentidad As String = ""     'Nombre de la entidad de datos
    Private snbdbcampo As String = ""       'Nombre del campo
    Private oftedatos As FuenteDato         'Objeto con la fuente de datos
    Private odbentidad As EntidaDato         'Objeto que tiene las propiedades de una entidad de datos
    Private odbcampo As EntidaDatoCampo      'Objeto que tiene los datos del campo
    Private outil As Utilerias              'Utilerias del sistema
    Private bSoloLectura As Boolean         'bandera de solo lectura

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
    ''' PROPIEDAD: Nombre de la entidad de datos
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbdbentidad() As String
        Get
            Return snbdbentidad
        End Get
        Set(ByVal pscd As String)
            snbdbentidad = pscd
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Nombre del campo
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property nbdbcampo() As String
        Get
            Return snbdbcampo
        End Get
        Set(ByVal pscd As String)
            snbdbcampo = pscd
        End Set
    End Property

    Private Sub frmDBEntidadCampo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            oparent = Me.ParentForm
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias

            'PASO 2: Consulta la fuente y entidad de datos
            oftedatos = obus.getFuenteDato(Me.cdftedatos)
            odbentidad = obus.getEntidaDato(Me.cdftedatos, Me.nbdbentidad)
            txtcdftedatos.Text = oftedatos.cdfuentedato
            txtnbftedatos.Text = oftedatos.nbfuentedato
            txtnbentidad.Text = odbentidad.nbentidadato

            'PASO 4: Si trae un nombre de campo, procede a consultarlo
            If Not snbdbcampo.Equals("") Then
                Consulta_Campo(snbdbcampo)
                Me.txtnbcampo.Enabled = False
            End If

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBEntidadCampo.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub Consulta_Campo(ByVal snbcampo As String)
        odbcampo = obus.getEntidaDatoCampo(Me.cdftedatos, Me.nbdbentidad, Me.nbdbcampo)
        If odbcampo Is Nothing Then
            MsgBox("Existio un error al consulta la información del Campo[" + Me.nbdbcampo + "]", MsgBoxStyle.Critical, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        txtnbcampo.Text = odbcampo.nbcampo
        txtipo.Text = odbcampo.cdtpdatofisico
        txtlongitud.Text = odbcampo.nulongitud
        txtdecimales.Text = odbcampo.nudecimales
        txtcdorden.Text = odbcampo.cdorden
        chkpermitenulos.Checked = IIf(odbcampo.stpermitenulos.Equals("AC"), True, False)
        chkesllave.Checked = IIf(odbcampo.stesllave.Equals("AC"), True, False)
        chkesalterna.Checked = IIf(odbcampo.stesalterna.Equals("AC"), True, False)
        chkautoincremento.Checked = IIf(odbcampo.stesautoincremento.Equals("AC"), True, False)
        chksecuencia.Checked = IIf(odbcampo.stessecuencia.Equals("AC"), True, False)
        txtsecuencia.Text = odbcampo.nbsecuencia
        txtcomment.Text = odbcampo.txcomment
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmdgrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdgrabar.Click

        Try
            'PASO 1: Leo la información de la pantalla
            If Not Valida_Campos() Then Exit Sub
            odbcampo = New EntidaDatoCampo
            odbcampo.cdfuentedato = Me.cdftedatos
            odbcampo.nbentidadato = Me.nbdbentidad
            odbcampo.nbcampo = Me.txtnbcampo.Text
            odbcampo.nulongitud = Me.txtlongitud.Text
            odbcampo.nudecimales = Me.txtdecimales.Text
            odbcampo.cdorden = Me.txtcdorden.Text
            odbcampo.stpermitenulos = IIf(Me.chkpermitenulos.Checked, "AC", "IN")
            odbcampo.stesllave = IIf(Me.chkesllave.Checked, "AC", "IN")
            odbcampo.stesalterna = IIf(Me.chkesalterna.Checked, "AC", "IN")
            odbcampo.stesautoincremento = IIf(Me.chkautoincremento.Checked, "AC", "IN")
            odbcampo.stessecuencia = IIf(Me.chksecuencia.Checked, "AC", "IN")
            odbcampo.nbsecuencia = Me.txtsecuencia.Text
            odbcampo.cdtpdatofisico = Me.txtipo.Text
            odbcampo.txcomment = Me.txtcomment.Text

            'PASO 2: Grabo los ajustes sobre el campo
            obus.saveEntidaDatoCampo(odbcampo)

            'PASO 3: Si quieren propagar los comentarios
            If chkpropagar.Checked Then obus.updPropagarCommentEntidadCampo(Me.cdftedatos, odbcampo.nbcampo, odbcampo.txcomment)

            MsgBox("La información del campo fué grabada exitosamente", MsgBoxStyle.Information, "HANYGEN SOFTWARE")
            Me.Close()
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmDBEntidadCampo.cmdgrabar_Click()", "Ocurrio un error en Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmDBEntidadCampo.cmdgrabar_Click()", "Ocurrio un error en Pantalla [" & ex1.ToString & "]"))
        End Try
    End Sub

    ''' <summary>
    ''' Procedimiento para validar los campos que participan en la pantalla
    ''' </summary>
    ''' <returns>true/false</returns>
    ''' <remarks></remarks>
    Private Function Valida_Campos() As Boolean

        If Me.txtnbcampo.Text.Trim.Equals("") Then
            MsgBox("Es necesario que ingrese el nombre del campo", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Return False
        End If
        If Me.txtipo.Text.Trim.Equals("") Then
            MsgBox("Es necesario que ingrese el tipo de campo", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Return False
        End If
        If Not IsNumeric(Me.txtlongitud.Text) Then
            MsgBox("Es necesario que la longitud sea un numero entero", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Return False
        End If
        If Not IsNumeric(Me.txtdecimales.Text) Then
            MsgBox("Es necesario que los decimales sea un numero entero", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Return False
        End If
        Return True
    End Function
End Class