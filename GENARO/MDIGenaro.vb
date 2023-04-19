Option Explicit On

Imports MyLIB
Imports System.Data.SQLite

Public Class MDIGenaro
    Inherits System.Windows.Forms.Form

    Private sconfiguracion As String = ""    'nombre del archivo template
    Private oconexion As SQLiteConnection = Nothing          'Conexión a la base de datos
    Friend WithEvents tssltemplate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem        'conección a la base de datos
    'String de conexión a la base de datos


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents mnuJava As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lblDatabase As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIGenaro))
        Me.mnuJava = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem47 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.MenuItem48 = New System.Windows.Forms.MenuItem()
        Me.MenuItem49 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem56 = New System.Windows.Forms.MenuItem()
        Me.MenuItem57 = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.MenuItem59 = New System.Windows.Forms.MenuItem()
        Me.MenuItem60 = New System.Windows.Forms.MenuItem()
        Me.MenuItem46 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.lblDatabase = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssltemplate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuJava
        '
        Me.mnuJava.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem11, Me.MenuItem10, Me.MenuItem2, Me.MenuItem43, Me.MenuItem59, Me.MenuItem31, Me.MenuItem14, Me.MenuItem5})
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.MenuItem7, Me.MenuItem8})
        Me.MenuItem3.Text = "PMI"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.Text = "Proyectos..."
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.Text = "Personas..."
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 2
        Me.MenuItem8.Text = "-"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem12, Me.MenuItem47, Me.MenuItem9})
        Me.MenuItem11.Text = "Documentacion"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 0
        Me.MenuItem12.Text = "Proyectos..."
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 1
        Me.MenuItem47.Text = "Fuente de Datos..."
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 2
        Me.MenuItem9.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem40, Me.MenuItem41, Me.MenuItem48})
        Me.MenuItem9.Text = "Generación Office Word"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 0
        Me.MenuItem40.Text = "Creación del documento..."
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 1
        Me.MenuItem41.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem42, Me.MenuItem45})
        Me.MenuItem41.Text = "Diseño funcional y técnico"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 0
        Me.MenuItem42.Text = "1. Wizard para la generación de diseño funcional..."
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 1
        Me.MenuItem45.Text = "2. Wizard para la generación del diseño técnico..."
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 2
        Me.MenuItem48.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem49})
        Me.MenuItem48.Text = "Base de datos"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 0
        Me.MenuItem49.Text = "1. Wizard para la generación del diccionario de datos"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 2
        Me.MenuItem10.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem19, Me.MenuItem25, Me.MenuItem29, Me.MenuItem34, Me.MenuItem37})
        Me.MenuItem10.Text = "Generador"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 0
        Me.MenuItem19.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem20, Me.MenuItem21, Me.MenuItem24})
        Me.MenuItem19.Text = "Generación Back End"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 0
        Me.MenuItem20.Text = "Generación de metodos para beans..."
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 1
        Me.MenuItem21.Text = "1. Wizard para persistencia usando SQL..."
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 2
        Me.MenuItem24.Text = "2. Wizard para persistencia usando HIBERNATE..."
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 1
        Me.MenuItem25.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem26, Me.MenuItem27, Me.MenuItem28})
        Me.MenuItem25.Text = "Generación Front End"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 0
        Me.MenuItem26.Text = "1. Wizard para sincronización HTML - Objeto..."
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 1
        Me.MenuItem27.Text = "2. Wizard todo como un CGI..."
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 2
        Me.MenuItem28.Text = "3. Wizard Microsoft ASPX con Bean..."
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 2
        Me.MenuItem29.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem30})
        Me.MenuItem29.Text = "Estadisticas de código"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 0
        Me.MenuItem30.Text = "1. Contador de uso de metodos..."
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 3
        Me.MenuItem34.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem35, Me.MenuItem36})
        Me.MenuItem34.Text = "Fuente de datos"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 0
        Me.MenuItem35.Text = "1. Wizard para la generación ABC - Store Procedures..."
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 1
        Me.MenuItem36.Text = "2. Generación de script a partir de una fuente de datos..."
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 4
        Me.MenuItem37.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem38, Me.MenuItem39})
        Me.MenuItem37.Text = "Flujo de datos Host"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 0
        Me.MenuItem38.Text = "1. Definición de flujo de datos..."
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 1
        Me.MenuItem39.Text = "2. Generación de ejemplos de flujo de datos..."
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 3
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem17})
        Me.MenuItem2.Text = "Utilerias"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem23, Me.MenuItem22, Me.MenuItem56, Me.MenuItem57, Me.MenuItem13})
        Me.MenuItem1.Text = "Fuente de Datos"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "1. WIZARD para cargar la fuente de datos desde un Script ..."
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 1
        Me.MenuItem23.Text = "2. * WIZARD para cargar la fuente de datos desde una conexión a BD..."
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 2
        Me.MenuItem22.Text = "3. WIZARD para Importar/Exportar los comentarios... "
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 3
        Me.MenuItem56.Text = "5. ELIMINACIÓN Masiva de datos..."
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 4
        Me.MenuItem57.Text = "6. WIZARD para Conversión de Datos a una nueva fuente de datos..."
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 5
        Me.MenuItem13.Text = "7. WIZARD para cargar las referencias desde un Script..."
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 1
        Me.MenuItem17.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem18})
        Me.MenuItem17.Text = "Proyecto"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 0
        Me.MenuItem18.Text = "1. ELIMINACION Masiva de datos"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 4
        Me.MenuItem43.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem44})
        Me.MenuItem43.Text = "Seguridad"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 0
        Me.MenuItem44.Text = "Usuarios del sistema..."
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 5
        Me.MenuItem59.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem60, Me.MenuItem46})
        Me.MenuItem59.Text = "Calidad"
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 0
        Me.MenuItem60.Text = "1. WIZARD para la validación de comentarios en clases..."
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 1
        Me.MenuItem46.Text = "2. WIZARD para la validación de la fuente de datos..."
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 6
        Me.MenuItem31.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem33, Me.MenuItem32})
        Me.MenuItem31.Text = "Ayuda"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 0
        Me.MenuItem33.Text = "-"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 1
        Me.MenuItem32.Text = "Acerca de GENARO..."
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 7
        Me.MenuItem14.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem15, Me.MenuItem16})
        Me.MenuItem14.Text = "Configuración"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 0
        Me.MenuItem15.Text = "Cargar archivo de configuración..."
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 1
        Me.MenuItem16.Text = "Cambiar conexión de base de datos..."
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 8
        Me.MenuItem5.Text = "Salir"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDatabase, Me.tssltemplate})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 456)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(931, 22)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'lblDatabase
        '
        Me.lblDatabase.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblDatabase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(65, 17)
        Me.lblDatabase.Text = "DATABASE"
        '
        'tssltemplate
        '
        Me.tssltemplate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tssltemplate.Name = "tssltemplate"
        Me.tssltemplate.Size = New System.Drawing.Size(101, 17)
        Me.tssltemplate.Text = "TEMPLATE NONE"
        '
        'MDIGenaro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(931, 478)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.mnuJava
        Me.MinimizeBox = False
        Me.Name = "MDIGenaro"
        Me.Text = "GENARO - Framework auxiliar para desarrollo de aplicaciones"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ''' <summary>
    ''' PROPIEDAD: nombre del archivo template
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>valor de la propiedad</returns>
    ''' <remarks></remarks>
    Public Property configuracion() As String
        Get
            Return sconfiguracion
        End Get
        Set(ByVal psval As String)
            sconfiguracion = psval
        End Set
    End Property

    ''' <summary>
    ''' PROPIEDAD: Conexión a la base de datos
    ''' </summary>
    ''' <value>SQLiteConnection</value>
    ''' <returns>valor de propiedad</returns>
    ''' <remarks></remarks>
    Public Property conexion() As SQLiteConnection
        Get
            Return oconexion
        End Get
        Set(ByVal poval As SQLiteConnection)
            oconexion = poval
        End Set
    End Property

    Public Property filetemplate() As String
        Get
            Return sconfiguracion
        End Get
        Set(ByVal psval As String)
            sconfiguracion = psval
        End Set
    End Property

    Private Sub MDIATLTools_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ofrm As frmLogin = New frmLogin

        Me.configuracion = System.Configuration.ConfigurationManager.AppSettings("configuracion")

        ofrm.ShowDialog()
        If ofrm.bvalidousuario = True Then
            Me.conexion = ofrm.ocnn
            ofrm.Close()
        Else
            ofrm.Close()
            Me.Close()
            Exit Sub
        End If

    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        Dim ofrm As frmacerca
        ofrm = New frmacerca()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim ofrm As frmDBwizLoadScript
        ofrm = New frmDBwizLoadScript()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem47.Click
        Dim ofrm As frmlistfuentedatos
        ofrm = New frmlistfuentedatos()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        conexion.Close()
        conexion = Nothing
    End Sub

    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem56.Click
        Dim ofrm As frmDBEliminacion
        ofrm = New frmDBEliminacion()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem60.Click
        Dim frm As New frmQAValidainsumos
        If Me.filetemplate.Equals("") Then
            MsgBox("Para está operación es necesario tener abierto un .ini del template...", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Normal
        frm.Show()
    End Sub

    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem46.Click
        Dim frm As New frmQAValidaFuente
        If Me.filetemplate.Equals("") Then
            MsgBox("Para está operación es necesario tener abierto un .ini del template...", MsgBoxStyle.Exclamation, "HANYGEN SOFTWARE")
            Exit Sub
        End If
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Normal
        frm.Show()
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        Dim ofrm As frmDBwizComments
        ofrm = New frmDBwizComments()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem57.Click
        Dim ofrm As frmDBWizConversion
        ofrm = New frmDBWizConversion()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        conexion.Close()
        conexion = Nothing
        Me.Close()
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Dim ofrm As frmpmiprojects
        ofrm = New frmpmiprojects()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
        Dim ofrm As frmlistprojects
        ofrm = New frmlistprojects()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Dim ofrm As frmlistpersonas
        ofrm = New frmlistpersonas()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Dim ofrm As frmDBwizLoadReference
        ofrm = New frmDBwizLoadReference()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        Dim ofrm As frmcargaconfiguracion
        ofrm = New frmcargaconfiguracion()
        ofrm.configuracion = Me.configuracion
        ofrm.WindowState = FormWindowState.Normal
        If ofrm.acepto Then
            Me.configuracion = ofrm.configuracion
        End If
        ofrm.Show()
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        Dim ofrm As frmcambiardatabase
        ofrm = New frmcambiardatabase
        ofrm.ShowDialog()
        If ofrm.acepto Then
            Me.conexion.Close()     'cierra la conexión actual
            Me.conexion = New SQLiteConnection("Data Source=" & ofrm.database & ";Pooling=true;FailIfMissing=false")
            Me.conexion.Open()
            MsgBox("Se ha cambiado la conexión de base de datos a [" & ofrm.database & "]", MsgBoxStyle.Information, "HANYGEN")
        End If
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Dim ofrm As frmgeneramethods
        ofrm = New frmgeneramethods()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Dim ofrm As frmgenerarusingsql
        ofrm = New frmgenerarusingsql
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        Dim ofrm As frmgenerahibernate
        ofrm = New frmgenerahibernate
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        Dim ofrm As frmFrontWizSyncProyCGI
        ofrm = New frmFrontWizSyncProyCGI()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        Dim ofrm As frmFrontWizCGI
        ofrm = New frmFrontWizCGI()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click

    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click

    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        Dim ofrm As frmDBwizStoreProcedures
        ofrm = New frmDBwizStoreProcedures()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem36.Click
        Dim ofrm As frmDBwizGeneraScript
        ofrm = New frmDBwizGeneraScript()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        Dim frm As New frmgeneradoc

        If Me.filetemplate.Equals("") Then
            MsgBox("Para está operación es necesario tener abierto un .ini del template...", MsgBoxStyle.Exclamation, "MySUIT")
            Exit Sub
        End If

        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Normal
        frm.Show()
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        Dim ofrm As frmdfgenera
        ofrm = New frmdfgenera()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        Dim ofrm As frmdtgenera
        ofrm = New frmdtgenera()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        Dim ofrm As frmdiccionario
        ofrm = New frmdiccionario()
        ofrm.MdiParent = Me
        ofrm.WindowState = FormWindowState.Normal
        ofrm.Show()
    End Sub
End Class
