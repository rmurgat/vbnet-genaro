<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelCasa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtteloficina = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtempresa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcomentario = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave : "
        '
        'txtclave
        '
        Me.txtclave.Location = New System.Drawing.Point(79, 10)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.ReadOnly = True
        Me.txtclave.Size = New System.Drawing.Size(145, 20)
        Me.txtclave.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre : "
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(79, 141)
        Me.txtnombre.MaxLength = 60
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(404, 20)
        Me.txtnombre.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo : "
        '
        'txtRfc
        '
        Me.txtRfc.Location = New System.Drawing.Point(79, 62)
        Me.txtRfc.MaxLength = 20
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.Size = New System.Drawing.Size(145, 20)
        Me.txtRfc.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "RFC : "
        '
        'txtTelCasa
        '
        Me.txtTelCasa.Location = New System.Drawing.Point(79, 115)
        Me.txtTelCasa.MaxLength = 20
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.Size = New System.Drawing.Size(145, 20)
        Me.txtTelCasa.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tel Casa : "
        '
        'txtteloficina
        '
        Me.txtteloficina.Location = New System.Drawing.Point(338, 115)
        Me.txtteloficina.MaxLength = 20
        Me.txtteloficina.Name = "txtteloficina"
        Me.txtteloficina.Size = New System.Drawing.Size(145, 20)
        Me.txtteloficina.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tel Oficina : "
        '
        'txtempresa
        '
        Me.txtempresa.Location = New System.Drawing.Point(79, 167)
        Me.txtempresa.MaxLength = 100
        Me.txtempresa.Name = "txtempresa"
        Me.txtempresa.Size = New System.Drawing.Size(404, 20)
        Me.txtempresa.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Empresa : "
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(79, 193)
        Me.txtemail.MaxLength = 200
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(253, 20)
        Me.txtemail.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Email : "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Comentario : "
        '
        'txtcomentario
        '
        Me.txtcomentario.Location = New System.Drawing.Point(79, 219)
        Me.txtcomentario.MaxLength = 255
        Me.txtcomentario.Multiline = True
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtcomentario.Size = New System.Drawing.Size(404, 81)
        Me.txtcomentario.TabIndex = 9
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(396, 10)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 23)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Location = New System.Drawing.Point(396, 39)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(87, 23)
        Me.btnGrabar.TabIndex = 19
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(79, 88)
        Me.txtUsuario.MaxLength = 6
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(145, 20)
        Me.txtUsuario.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Usuario : "
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Items.AddRange(New Object() {"FISICA", "MORAL"})
        Me.cbotipo.Location = New System.Drawing.Point(79, 35)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(145, 21)
        Me.cbotipo.TabIndex = 21
        '
        'frmPersona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtcomentario)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtempresa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtteloficina)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTelCasa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRfc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtclave)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPersona"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Información de la persona"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtclave As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRfc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTelCasa As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtteloficina As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtempresa As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcomentario As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
End Class
