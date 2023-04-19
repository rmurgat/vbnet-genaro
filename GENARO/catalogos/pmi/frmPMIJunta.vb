Option Explicit On
Imports MyLIB
Imports System.Windows.Forms

Public Class frmPMIJunta
    Private ocat As Catalogos
    Private opmi As BPmi
    Private scdproject As String = ""   'Clave del proyecto
    Private scdjunta As String = ""     'Clave de la junta
    Private oproject As Proyecto        'Objeto que tiene las propiedades del proyecto
    Private ojunta As Junta             'Objeto que tiene las propieades de una junta
    Private outil As Utilerias          'Utilerias del sistema
    Private omdipa As MDIGenaro

    ''' <summary>
    ''' PROPIEDAD: Clave del proyecto
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdproject() As String
        Get
            Return scdproject
        End Get
        Set(ByVal pscd As String)
            scdproject = pscd.Trim
        End Set
    End Property


    ''' <summary>
    ''' PROPIEDAD: Clave de la junta
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property cdjunta() As String
        Get
            Return scdjunta
        End Get
        Set(ByVal pscd As String)
            scdjunta = pscd.Trim
        End Set
    End Property

    Private Sub frmPMIJunta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            omdipa = Me.ParentForm
            opmi = New BPmi(omdipa.conexion)
            ocat = New Catalogos(omdipa.conexion)
            outil = New Utilerias
            oproject = ocat.getProyecto(scdproject)

            'Pinta la información en pantalla
            txtcdproyecto.Text = oproject.cdproyecto
            txtnbproyecto.Text = oproject.nbproyecto
            If Not scdjunta.Equals("") Then Consulta_Junta()
            If scdjunta.Equals("") Then
                tabacuerdos.Hide()
                tabparticipa.Hide()
                tabtareas.Hide()
            End If
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPMIJunta.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmPMIJunta.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub Consulta_Junta()
        Try
            ojunta = opmi.getJunta(Me.cdproject, Me.cdjunta)
            txtcdjunta.Text = ojunta.cdjunta
            txtnbjunta.Text = ojunta.nbjunta
            txtclave.Text = ojunta.cdjunta
            cbotipo.SelectedIndex = cbotipo.FindString(ojunta.tpjunta)
            txtnombre.Text = ojunta.nbjunta
            cboEstatus.SelectedIndex = cboEstatus.FindString(ojunta.stjunta)
            txtfecha.Text = ojunta.fhjunta
            txtObjetivo.Text = ojunta.txobjetivo
            txtComent.Text = ojunta.txcomment
            txtlugar.Text = ojunta.nblugar
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPMIJunta.Consulta_Junta()", "Ocurrio un error")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyCATALOGOS.frmPMIJunta.Consulta_Junta()", "Ocurrio un error [" & ex1.ToString & "]")
        End Try
    End Sub

    Private Sub btngrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngrabar.Click

        If cbotipo.SelectedIndex < 0 Then
            MsgBox("Es necesario seleccionar el tipo de junta", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        If txtnombre.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el nombre con el que identificamos la junta", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        If txtlugar.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar el lugar donde se realiza la junta", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        If cboEstatus.SelectedIndex < 0 Then
            MsgBox("Es necesario seleccionar el estatus de la junta", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        If txtfecha.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar la fecha y hora en que realizaremos la junta", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        If txtObjetivo.Text.Trim.Equals("") Then
            MsgBox("Es necesario ingresar los objetivos de la junta", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        Try
            ojunta = New Junta()
            ojunta.cdproyecto = Me.cdproject
            ojunta.cdjunta = txtclave.Text
            ojunta.nbjunta = txtnombre.Text
            ojunta.tpjunta = outil.Toma_Token(1, cbotipo.SelectedItem, "-")
            ojunta.stjunta = outil.Toma_Token(1, cboEstatus.SelectedItem, "-")
            ojunta.fhjunta = txtfecha.Text
            ojunta.txobjetivo = txtObjetivo.Text
            ojunta.txcomment = txtComent.Text
            ojunta.nblugar = txtlugar.Text

            opmi.saveJunta(ojunta)

            txtclave.Text = txtcdjunta.Text = ojunta.cdjunta
            txtnbjunta.Text = ojunta.nbjunta
            tabacuerdos.Show()
            tabparticipa.Show()
            tabtareas.Show()

            MsgBox("Se ha registrado la información de una junta", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPMIJunta.btngrabar_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmPMIJunta.btngrabar_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnjuntasload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnjuntasload.Click
        Dim cholders As Collection
        Dim cparticipa As Collection
        Dim sparticipa As String

        Try

            'PASO 1: Se leen los participantes
            sparticipa = ""
            cparticipa = opmi.getJuntaParticipas(Me.cdproject, Me.cdjunta)
            For Each operson As JuntaParticipa In cparticipa
                sparticipa = sparticipa & operson.cdsteackholder & ","
            Next

            'PASO 2: Se leen los steackholders
            Me.lstholders.Items.Clear()
            cholders = ocat.getSteackholders(Me.cdproject)
            For Each ohold As Steackholder In cholders
                If sparticipa.IndexOf(ohold.cdsteackholder) < 0 Then
                    Dim operson As Persona
                    operson = ocat.getPersona(ohold.cdpersona)
                    lstholders.Items.Add(operson.nbpersona & "                       |" & ohold.cdsteackholder)
                End If
            Next

            'PASO 3: Se colocan los participantes ahora
            For Each oparticipa As JuntaParticipa In cparticipa
                Dim ohold As Steackholder = ocat.getSteackholder(Me.cdproject, oparticipa.cdsteackholder)
                Dim operson As Persona = ocat.getPersona(ohold.cdpersona)
                lstparticipa.Items.Add(operson.nbpersona & "                       |" & ohold.cdsteackholder)
            Next

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPMIJunta.btnjuntasload_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmPMIJunta.btnjuntasload_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub btnonein_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnonein.Click
        Dim iindex As Integer
        iindex = lstholders.SelectedIndex
        lstparticipa.Items.Add(lstholders.Items.Item(iindex))
        lstholders.Items.RemoveAt(iindex)
    End Sub

    Private Sub btnoneout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnoneout.Click
        Dim iindex As Integer
        iindex = lstparticipa.SelectedIndex
        lstholders.Items.Add(Me.lstparticipa.Items.Item(iindex))
        lstparticipa.Items.RemoveAt(iindex)
    End Sub

    Private Sub btnallin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnallin.Click
        Dim i As Integer
        For i = 0 To lstholders.Items.Count - 1
            lstparticipa.Items.Add(lstholders.Items.Item(i))
        Next
        lstholders.Items.Clear()
    End Sub

    Private Sub btnallout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnallout.Click
        Dim i As Integer
        For i = 0 To lstparticipa.Items.Count - 1
            lstholders.Items.Add(lstparticipa.Items.Item(i))
        Next
        lstparticipa.Items.Clear()
    End Sub
End Class