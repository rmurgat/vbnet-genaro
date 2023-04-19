Option Explicit On
Imports MyLIB

Public Class frmPantallaTools
    Private obus As Catalogos
    Private scdproject As String = ""   'Clave del proyecto
    Private scdpantalla As String = ""  'Clave de la pantalla
    Private outil As Utilerias          'Utilerias del sistema
    Private oproject As Proyecto        'Objeto que tiene las propiedades del proyecto
    Private opantalla As Pantalla       'Objeto que tiene las propiedades de la pantalla


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
        End Set
    End Property

    Private Sub btnsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub

    Private Sub frmPantallaTools_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oparent As MDIGenaro
        Dim cprojects As Collection

        Try
            'PASO 1: Incializa los objetos de negocio y utilerias
            oparent = Me.ParentForm
            obus = New Catalogos(oparent.conexion)
            outil = New Utilerias

            'PASO 2: Consulta los datos del proyecto y la pantalla
            oproject = obus.getProyecto(Me.cdproject)
            opantalla = obus.getPantalla(Me.cdproject, Me.cdpantalla)
            txtcdproyecto.Text = oproject.cdproyecto
            txtnbproyecto.Text = oproject.nbproyecto
            txtcdpantalla.Text = opantalla.cdpantalla
            txtnbpantalla.Text = opantalla.nbpantalla

            'PASO 3: Consulta todos los proyectos
            cprojects = obus.getProyectos(New Criterio())
            cboproyecto.Items.Add("")
            For Each oproy As Proyecto In cprojects
                cboproyecto.Items.Add(oproy.cdproyecto & " - " & oproy.nbproyecto)
            Next

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantallaTools.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmPantallaTools.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub cboproyecto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboproyecto.SelectedIndexChanged
        Dim cpantallas As Collection

        If cboproyecto.SelectedIndex > 0 Then
            cbopantalla.Items.Clear()
            cpantallas = obus.getPantallas(outil.Toma_Token(1, cboproyecto.SelectedItem, "-"))
            cbopantalla.Items.Add("")
            For Each opant As Pantalla In cpantallas
                cbopantalla.Items.Add(opant.cdpantalla & " - " & opant.nbpantalla)
            Next

        End If
    End Sub

    Private Sub btniniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btniniciar.Click
        Dim ctmp As Collection
        Try
            'PASO 1: copia los botones
            If chkboton.Checked Then
                'PASO 1.1: busca los botones actuales y los borra
                ctmp = obus.getPantallaBotones(Me.cdproject, Me.cdpantalla)
                For Each obj As PantallaBoton In ctmp
                    obus.delPantallaBoton(obj.cdproyecto, obj.cdpantalla, obj.cdboton)
                Next

                'PASO 1.2: ahora busca los nuevos botones
                ctmp = obus.getPantallaBotones(outil.Toma_Token(1, cboproyecto.SelectedItem, "-"), outil.Toma_Token(1, cbopantalla.SelectedItem, "-"))
                For Each obj As PantallaBoton In ctmp
                    obj.cdproyecto = Me.cdproject
                    obj.cdpantalla = Me.cdpantalla
                    obj.cdboton = ""
                    obus.saveBoton(obj)
                Next

            End If

            'PASO 2: copia los controles de io
            If chkio.Checked Then
                'PASO 2.1: busca los arreglos io actuales y los borra
                ctmp = obus.getPantallarreglos(Me.cdproject, Me.cdpantalla)
                For Each obj As Pantallarreglo In ctmp
                    obus.delPantallarreglo(obj.cdproyecto, obj.cdpantalla, obj.cdarreglo)
                Next

                'PASO 2.2: busca los controles io actuales y los borra
                ctmp = obus.getPantallaCampos(Me.cdproject, Me.cdpantalla)
                For Each obj As PantallaCampo In ctmp
                    obus.delPantallaCampo(obj.cdproyecto, obj.cdpantalla, obj.cdcampo)
                Next

                'paso 2.3: ahora busca los nuevos arreglos io
                ctmp = obus.getPantallarreglos(outil.Toma_Token(1, cboproyecto.SelectedItem, "-"), outil.Toma_Token(1, cbopantalla.SelectedItem, "-"))
                For Each obj As Pantallarreglo In ctmp
                    obj.cdproyecto = Me.cdproject
                    obj.cdpantalla = Me.cdpantalla
                    obj.cdarreglo = ""
                    obus.savePantallarreglo(obj)
                Next

                'PASO 2.4: ahora busca los nuevos controles io
                ctmp = obus.getPantallaCampos(outil.Toma_Token(1, cboproyecto.SelectedItem, "-"), outil.Toma_Token(1, cbopantalla.SelectedItem, "-"))
                For Each obj As PantallaCampo In ctmp
                    obj.cdproyecto = Me.cdproject
                    obj.cdpantalla = Me.cdpantalla
                    obj.cdcampo = ""
                    obus.savePantallaCampo(obj)
                Next
            End If

            'PASO 3: copia los eventos
            If chkevento.Checked Then
                'PASO 3.1: busca los eventos actuales y los borra
                ctmp = obus.getPantallaEventos(Me.cdproject, Me.cdpantalla)
                For Each obj As PantallaEvento In ctmp
                    obus.delPantallaEvento(obj.cdproyecto, obj.cdpantalla, obj.cdevento)
                Next
                'PASO 3.2: ahora busca los nuevos controles io
                ctmp = obus.getPantallaEventos(outil.Toma_Token(1, cboproyecto.SelectedItem, "-"), outil.Toma_Token(1, cbopantalla.SelectedItem, "-"))
                For Each obj As PantallaEvento In ctmp
                    obj.cdproyecto = Me.cdproject
                    obj.cdpantalla = Me.cdpantalla
                    obj.cdevento = ""
                    obus.savePantallaEvento(obj)
                Next
            End If

            MsgBox("! COPIA TERMINADA !")

        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantallaTools.btniniciar_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmPantallaTools.btniniciar_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try
    End Sub

    Private Sub cbopantalla_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbopantalla.SelectedIndexChanged
        Dim opant As Pantalla
        Try
            opant = obus.getPantalla(Me.cdproject, outil.Toma_Token(1, Me.cbopantalla.SelectedItem, "-"))
            Me.picpreview.Load(opant.nbimagefile)
        Catch ex As HANYException
            ex.add("MyCATALOGOS.frmPantallaTools.cbopantalla_SelectedIndexChanged()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyCATALOGOS.frmPantallaTools.cbopantalla_SelectedIndexChanged()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try
    End Sub
End Class