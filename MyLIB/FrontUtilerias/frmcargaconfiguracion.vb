Option Explicit On
Imports MyLIB
Imports System.Windows.Forms

Public Class frmcargaconfiguracion
    Private outil As Utilerias = New MyLIB.Utilerias
    Private sconfiguracion As String            'Cadena con la configuración de la aplicación
    Private bacepto As Boolean = False          'Bandera que determina si acepto 

    ''' <summary>
    ''' PROPIEDAD: Cadena con la configuración de la aplicación
    ''' </summary>
    ''' <value></value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property configuracion() As String
        Get
            Return sconfiguracion
        End Get
        Set(ByVal psval As String)
            sconfiguracion = psval.Trim
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Bandera que determina si acepto
    ''' </summary>
    ''' <value></value>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public Property acepto() As Boolean
        Get
            Return bacepto
        End Get
        Set(ByVal pbval As Boolean)
            bacepto = pbval
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmcargaconfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If sconfiguracion.Trim.Equals("") Then
                MsgBox("Es necesario ingresar la configuración actual de la aplicación", MsgBoxStyle.Information, "HANYGEN")
            Else
                Call Me.Muestra_Archivo(sconfiguracion)
            End If
        Catch ex As HANYException
            ex.add("MyGENARO.frmcargaconfiguracion.Load()", "Ocurrio un error al cargar la pantalla")
            outil.ShowException(ex)
        End Try

    End Sub

    Private Sub Muestra_Archivo(ByVal sarchivo As String)
        Dim ozip As ZipArchivo = New ZipArchivo
        Dim oxml As Nodo = New Nodo
        Dim oxmlestilos As Nodo
        Dim oxmldocs As Nodo
        Dim ocol As Collection

        Try
            lstdebug.Items.Clear()
            ozip.Open(sconfiguracion)
            oxml.SetXML(ozip.getFileInflated("main.xml"))
            Me.txttemplate.Text = sconfiguracion
            Me.txtautor.Text = oxml.getValue("configuracion.autor")
            Me.txtdate.Text = oxml.getValue("configuracion.fecha")
            Me.txtdescription.Text = oxml.getValue("configuracion.descripcion")

            outil.addToListDebug(lstdebug, "[ ESTILOS PROGRAMACION ]")
            oxmlestilos = oxml.getPrimerNodo("estilos-programacion")
            ocol = oxmlestilos.getNodo("estilo")
            For Each onodo As Nodo In ocol
                outil.addToListDebug(lstdebug, "  + " & onodo.getValue("estilo.nombre"))
            Next
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "[ DOCUMENTACION DEL PROYECTO ]")
            oxmldocs = oxml.getPrimerNodo("proyecto-documentacion")
            ocol = oxmldocs.getNodo("documento")
            For Each onodo As Nodo In ocol
                outil.addToListDebug(lstdebug, "  + " & onodo.getValue("documento.nombre"))
            Next
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "[ DOCUMENTACION PMI ]")
            oxmldocs = oxml.getPrimerNodo("documentacion-pmi")
            ocol = oxmldocs.getNodo("documento")
            For Each onodo As Nodo In ocol
                outil.addToListDebug(lstdebug, "  + " & onodo.getValue("documento.nombre"))
            Next
            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "[ VALIDANDO SUB-CONFIGURACIONES ]")
            outil.addToListDebug(lstdebug, "... Validando estilos de programación")
            oxmlestilos = oxml.getPrimerNodo("estilos-programacion")
            ocol = oxmlestilos.getNodo("estilo")
            For Each onodo As Nodo In ocol
                Dim sfile As String = onodo.getValue("estilo.directorio") + onodo.getValue("estilo.configuracion")
                If Not ozip.ExisteArchivo(sfile) Then
                    outil.addToListDebug(lstdebug, "      !ERROR! No existe archivo " & sfile)
                    'Else
                    '   Dim oxmlcod As Nodo = New Nodo(ozip.getFileInflated(sfile))
                    '  Dim oxmlmodel As Nodo = oxmlcod.getPrimerNodo("model")
                    ' Dim ocol1 As Collection = oxmlmodel.getNodo("codigo")
                    'For Each onodo1 As Nodo In ocol1
                    'If Not ozip.ExisteArchivo(onodo.getValue("estilo.directorio") + onodo1.getValue("codigo.archivo")) Then outil.addToListDebug(lstdebug, "      !ERROR! No existe archivo " & onodo1.getValue("codigo.archivo") & " en " & sfile)
                    'Next
                End If
            Next

            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "... Validando documentacion del proyecto")
            oxmldocs = oxml.getPrimerNodo("proyecto-documentacion")
            ocol = oxmldocs.getNodo("documento")
            For Each onodo As Nodo In ocol
                Dim sfile As String = onodo.getValue("documento.directorio") + onodo.getValue("documento.configuracion")
                If Not ozip.ExisteArchivo(sfile) Then
                    outil.addToListDebug(lstdebug, "      !ERROR! No existe archivo " & sfile)
                Else
                    Dim oxmlcod As Nodo = New Nodo(ozip.getFileInflated(sfile))
                    Dim oxmlmodel As Nodo = oxmlcod.getPrimerNodo("macros")
                    Dim ocol1 As Collection = oxmlmodel.getNodo("macro")
                    For Each onodo1 As Nodo In ocol1
                        If Not onodo1.getValue("macro.archivo").Equals("?") Then
                            If Not ozip.ExisteArchivo(onodo.getValue("documento.directorio") + onodo1.getValue("macro.archivo")) Then outil.addToListDebug(lstdebug, "      !ERROR! No existe archivo " & onodo1.getValue("macro.archivo") & " en " & sfile)
                        End If
                    Next
                End If
            Next

            outil.addToListDebug(lstdebug, "")
            outil.addToListDebug(lstdebug, "... Validando documentacion pmi")
            oxmldocs = oxml.getPrimerNodo("documentacion-pmi")
            ocol = oxmldocs.getNodo("documento")
            For Each onodo As Nodo In ocol
                Dim sfile As String = onodo.getValue("documento.directorio") + onodo.getValue("documento.configuracion")
                If Not ozip.ExisteArchivo(sfile) Then
                    outil.addToListDebug(lstdebug, "      !ERROR! No existe archivo " & sfile)
                Else
                    Dim oxmlcod As Nodo = New Nodo(ozip.getFileInflated(sfile))
                    Dim oxmlmodel As Nodo = oxmlcod.getPrimerNodo("documentos")
                    Dim ocol1 As Collection = oxmlmodel.getNodo("documento")
                    For Each onodo1 As Nodo In ocol1
                        If Not onodo1.getValue("documento.archivo").Equals("?") Then
                            If Not ozip.ExisteArchivo(onodo.getValue("documento.directorio") + onodo1.getValue("documento.archivo")) Then outil.addToListDebug(lstdebug, "      !ERROR! No existe archivo " & onodo1.getValue("documento.archivo") & " en " & sfile)
                        End If
                    Next
                End If
            Next
        Catch ex As HANYException
            ex.add("MyGENARO.frmcargaconfiguracion.Muestra_Archivo()", "Ocurrio un error al consultar el archivo")
            Throw ex
        Catch ex1 As Exception
            Throw New HANYException("MyGENARO.frmcargaconfiguracion.Muestra_Archivo()", "Ocurrio un error al consultar el archivo [" & ex1.ToString & "]")
        End Try

    End Sub

    Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
        sconfiguracion = Me.txttemplate.Text
        Me.Muestra_Archivo(sconfiguracion)
        'omdipa.configuracion = sconfiguracion
        MsgBox("La configuración ha sido cargada con exito", MsgBoxStyle.Information, "HANYGEN")
    End Sub

    Private Sub btnExplorar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExplorar.Click
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de HANYGEN (*.hag)|*.hag"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Me.txttemplate.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        acepto = True
        Me.Close()
    End Sub
End Class
