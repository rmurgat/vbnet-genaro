Option Explicit On

Imports System.Windows.Forms

Public Class frmWizard
    Private sxmlin As String = ""
    Private sxmlout As String = ""
    Private oxmlvalues As Nodo = New Nodo()     'valor de los nodos
    Private outil As Utilerias

    ''' <summary>
    ''' PROPIEDAD: XML input
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property xmlin() As String
        Get
            Return sxmlin
        End Get
        Set(ByVal psxml As String)
            sxmlin = psxml
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: XML output
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property xmlout() As String
        Get
            Return sxmlout
        End Get
        Set(ByVal psxml As String)
            sxmlout = psxml
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: valor de los nodos
    ''' </summary>
    ''' <value></value>
    ''' <returns>Nodo</returns>
    ''' <remarks></remarks>
    Public Property xmlvalues() As Nodo
        Get
            Return oxmlvalues
        End Get
        Set(ByVal oval As Nodo)
            If oval Is Nothing Then
                oval = New Nodo()
            End If
            oxmlvalues = oval
        End Set
    End Property

    Private Sub frmWizard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oxmlinterpreta, oxmlentradas, oxmlopciones As Nodo
        Dim ocGrupos As Collection
        oxmlinterpreta = New Nodo(sxmlin)

        Try
            outil = New Utilerias
            Me.Text = oxmlinterpreta.getValue("general.titulo")
            Me.Height = oxmlinterpreta.getValue("general.alto")
            Me.Width = oxmlinterpreta.getValue("general.ancho")

            Me.btnCancelar.Top = Me.Height - 70
            Me.btnAceptar.Top = Me.Height - 70
            Me.tabGrupos.Height = Me.Height - 100
            Me.tabGrupos.Width = Me.Width - 40

            oxmlentradas = oxmlinterpreta.getPrimerNodo("entradas")
            ocGrupos = oxmlentradas.getNodo("grupo")

            For Each oxmlgrupo As Nodo In ocGrupos
                Dim oxmldatos As Nodo = oxmlgrupo.getPrimerNodo("datos")
                Dim ocDatos As Collection
                Dim itop As Integer = 10

                Me.tabGrupos.TabPages.Add(oxmlgrupo.getValue("id"), oxmlgrupo.getValue("titulo"))
                ocDatos = oxmldatos.getNodo("dato")

                For Each oxmldato As Nodo In ocDatos
                    Dim olbl As Label = New Label

                    olbl.Top = itop
                    olbl.Left = 10
                    olbl.Height = olbl.Height + 19
                    olbl.Text = oxmldato.getValue("etiqueta")

                    Me.tabGrupos.TabPages(oxmlgrupo.getValue("id")).Controls.Add(olbl)

                    If oxmldato.getValue("tipo").ToString.Equals("texto") Then
                        Dim otxt As TextBox = New TextBox
                        otxt.Name = "txt" & oxmldato.getValue("id")
                        If Not oxmlvalues.getValue(oxmlgrupo.getValue("id") & "." & oxmldato.getValue("id")).Equals("") Then
                            otxt.Text = oxmlvalues.getValue(oxmlgrupo.getValue("id") & "." & oxmldato.getValue("id"))
                        Else
                            otxt.Text = oxmldato.getValue("default")
                        End If
                        otxt.Top = itop
                        otxt.Left = 110
                        otxt.Width = oxmldato.getValue("ancho")
                        Me.tabGrupos.TabPages(oxmlgrupo.getValue("id")).Controls.Add(otxt)
                        itop = itop + otxt.Height + 20
                    ElseIf oxmldato.getValue("tipo").ToString.Equals("lista") Then
                        Dim ocopciones As Collection
                        Dim ocbo As ComboBox = New ComboBox
                        oxmlopciones = oxmldato.getPrimerNodo("lista")
                        ocbo.Name = "txt" & oxmldato.getValue("id")
                        ocbo.Text = oxmldato.getValue("default")
                        ocbo.Top = itop
                        ocbo.Left = 110
                        ocbo.Width = oxmldato.getValue("ancho")
                        ocopciones = oxmldato.getNodo("opcion")
                        For Each oxmlopcion As Nodo In ocopciones
                            ocbo.Items.Add(oxmlopcion.getValue("valor") & " - " & oxmlopcion.getValue("texto"))
                        Next
                        Me.tabGrupos.TabPages(oxmlgrupo.getValue("id")).Controls.Add(ocbo)
                        itop = itop + ocbo.Height + 20
                    End If
                Next
            Next
        Catch ex As HANYException
            ex.add("MyLIB.frmWizard.Load()", "Ocurrio un error al cargar la Pantalla")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyLIB.frmWizard.Load()", "Ocurrio un error al cargar la Pantalla [" & ex1.ToString & "]"))
        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim oxmlinterpreta, oxmlentradas As Nodo
        Dim ocGrupos As Collection
        Dim sxmltmp As String = ""

        Try
            oxmlinterpreta = New Nodo(sxmlin)
            oxmlentradas = oxmlinterpreta.getPrimerNodo("entradas")
            ocGrupos = oxmlentradas.getNodo("grupo")

            'PASO 1: Valida cada uno de los campos
            For Each oxmlgrupo As Nodo In ocGrupos
                Dim oxmldatos As Nodo = oxmlgrupo.getPrimerNodo("datos")
                Dim ocDatos As Collection
                ocDatos = oxmldatos.getNodo("dato")
                For Each oxmldato As Nodo In ocDatos
                    Dim oinput As Control = Me.tabGrupos.TabPages(oxmlgrupo.getValue("id")).Controls.Item("txt" & oxmldato.getValue("id"))
                    If oxmldato.getValue("requerido").ToString.Equals("Si") Then
                        If oinput.Text.Trim.Equals("") Then
                            MsgBox("! El campos [" & oxmldato.getValue("id") & "] de la pestaña [" & oxmlgrupo.getValue("titulo") & "] no puede estar vacio !", MsgBoxStyle.Critical, "MyLIB")
                            Exit Sub
                        End If
                    End If
                Next
            Next

            'PASO 2: Arma el xml resultante
            For Each oxmlgrupo As Nodo In ocGrupos
                Dim oxmldatos As Nodo = oxmlgrupo.getPrimerNodo("datos")
                Dim ocDatos As Collection

                sxmltmp = sxmltmp & "<" & oxmlgrupo.getValue("id") & ">"
                ocDatos = oxmldatos.getNodo("dato")
                For Each oxmldato As Nodo In ocDatos
                    Dim oinput As Control = Me.tabGrupos.TabPages(oxmlgrupo.getValue("id")).Controls.Item("txt" & oxmldato.getValue("id"))
                    sxmltmp = sxmltmp & "<" & oxmldato.getValue("id") & ">" & oinput.Text.Trim & "</" & oxmldato.getValue("id") & ">"
                    If oxmldato.getValue("requerido").ToString.Equals("Si") Then
                        If oinput.Text.Trim.Equals("") Then
                            MsgBox("! El campos [" & oxmldato.getValue("id") & "] de la pestaña [" & oxmlgrupo.getValue("titulo") & "] no puede estar vacio !", MsgBoxStyle.Critical, "MyLIB")
                            Exit Sub
                        End If
                    End If
                Next
                sxmltmp = sxmltmp & "</" & oxmlgrupo.getValue("id") & ">"
            Next
            sxmlout = sxmltmp
            Me.Close()
        Catch ex As HANYException
            ex.add("MyLIB.frmWizard.btnAceptar_Click()", "Ocurrio un error")
            outil.ShowException(ex)
        Catch ex1 As Exception
            outil.ShowException(New HANYException("MyLIB.frmWizard.btnAceptar_Click()", "Ocurrio un error [" & ex1.ToString & "]"))
        End Try

    End Sub

End Class