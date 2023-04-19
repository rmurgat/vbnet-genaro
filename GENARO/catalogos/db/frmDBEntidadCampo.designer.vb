<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBEntidadCampo
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdecimales = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdgrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtcomment = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtlongitud = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnbcampo = New System.Windows.Forms.TextBox()
        Me.txtnbentidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnbftedatos = New System.Windows.Forms.TextBox()
        Me.txtcdftedatos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcdorden = New System.Windows.Forms.TextBox()
        Me.chkpermitenulos = New System.Windows.Forms.CheckBox()
        Me.chkesllave = New System.Windows.Forms.CheckBox()
        Me.chkpropagar = New System.Windows.Forms.CheckBox()
        Me.txtipo = New System.Windows.Forms.TextBox()
        Me.chkesalterna = New System.Windows.Forms.CheckBox()
        Me.chkautoincremento = New System.Windows.Forms.CheckBox()
        Me.chksecuencia = New System.Windows.Forms.CheckBox()
        Me.txtsecuencia = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(159, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Decimales :"
        '
        'txtdecimales
        '
        Me.txtdecimales.Location = New System.Drawing.Point(228, 125)
        Me.txtdecimales.MaxLength = 20
        Me.txtdecimales.Name = "txtdecimales"
        Me.txtdecimales.Size = New System.Drawing.Size(73, 20)
        Me.txtdecimales.TabIndex = 73
        Me.txtdecimales.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "Tipo :"
        '
        'cmdgrabar
        '
        Me.cmdgrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdgrabar.Location = New System.Drawing.Point(475, 44)
        Me.cmdgrabar.Name = "cmdgrabar"
        Me.cmdgrabar.Size = New System.Drawing.Size(87, 23)
        Me.cmdgrabar.TabIndex = 70
        Me.cmdgrabar.Text = "Grabar"
        Me.cmdgrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(475, 14)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 23)
        Me.btnSalir.TabIndex = 69
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtcomment
        '
        Me.txtcomment.Location = New System.Drawing.Point(80, 195)
        Me.txtcomment.MaxLength = 1000
        Me.txtcomment.Multiline = True
        Me.txtcomment.Name = "txtcomment"
        Me.txtcomment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtcomment.Size = New System.Drawing.Size(481, 59)
        Me.txtcomment.TabIndex = 68
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Comentario :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Longitud :"
        '
        'txtlongitud
        '
        Me.txtlongitud.Location = New System.Drawing.Point(80, 125)
        Me.txtlongitud.MaxLength = 20
        Me.txtlongitud.Name = "txtlongitud"
        Me.txtlongitud.Size = New System.Drawing.Size(73, 20)
        Me.txtlongitud.TabIndex = 65
        Me.txtlongitud.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Nombre :"
        '
        'txtnbcampo
        '
        Me.txtnbcampo.Location = New System.Drawing.Point(81, 72)
        Me.txtnbcampo.MaxLength = 60
        Me.txtnbcampo.Name = "txtnbcampo"
        Me.txtnbcampo.Size = New System.Drawing.Size(377, 20)
        Me.txtnbcampo.TabIndex = 63
        '
        'txtnbentidad
        '
        Me.txtnbentidad.Location = New System.Drawing.Point(81, 46)
        Me.txtnbentidad.Name = "txtnbentidad"
        Me.txtnbentidad.ReadOnly = True
        Me.txtnbentidad.Size = New System.Drawing.Size(377, 20)
        Me.txtnbentidad.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Entidad :"
        '
        'txtnbftedatos
        '
        Me.txtnbftedatos.Location = New System.Drawing.Point(160, 16)
        Me.txtnbftedatos.Name = "txtnbftedatos"
        Me.txtnbftedatos.ReadOnly = True
        Me.txtnbftedatos.Size = New System.Drawing.Size(298, 20)
        Me.txtnbftedatos.TabIndex = 57
        '
        'txtcdftedatos
        '
        Me.txtcdftedatos.Location = New System.Drawing.Point(81, 16)
        Me.txtcdftedatos.Name = "txtcdftedatos"
        Me.txtcdftedatos.ReadOnly = True
        Me.txtcdftedatos.Size = New System.Drawing.Size(73, 20)
        Me.txtcdftedatos.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Fuente :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(316, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Orden :"
        '
        'txtcdorden
        '
        Me.txtcdorden.Location = New System.Drawing.Point(385, 125)
        Me.txtcdorden.MaxLength = 20
        Me.txtcdorden.Name = "txtcdorden"
        Me.txtcdorden.Size = New System.Drawing.Size(73, 20)
        Me.txtcdorden.TabIndex = 76
        Me.txtcdorden.Text = "0"
        '
        'chkpermitenulos
        '
        Me.chkpermitenulos.AutoSize = True
        Me.chkpermitenulos.Location = New System.Drawing.Point(81, 151)
        Me.chkpermitenulos.Name = "chkpermitenulos"
        Me.chkpermitenulos.Size = New System.Drawing.Size(91, 17)
        Me.chkpermitenulos.TabIndex = 75
        Me.chkpermitenulos.Text = "Permite Nulos"
        Me.chkpermitenulos.UseVisualStyleBackColor = True
        '
        'chkesllave
        '
        Me.chkesllave.AutoSize = True
        Me.chkesllave.Location = New System.Drawing.Point(228, 151)
        Me.chkesllave.Name = "chkesllave"
        Me.chkesllave.Size = New System.Drawing.Size(118, 17)
        Me.chkesllave.TabIndex = 78
        Me.chkesllave.Text = "Es llave PRIMARIA"
        Me.chkesllave.UseVisualStyleBackColor = True
        '
        'chkpropagar
        '
        Me.chkpropagar.AutoSize = True
        Me.chkpropagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkpropagar.Location = New System.Drawing.Point(80, 260)
        Me.chkpropagar.Name = "chkpropagar"
        Me.chkpropagar.Size = New System.Drawing.Size(307, 16)
        Me.chkpropagar.TabIndex = 79
        Me.chkpropagar.Text = "PROPAGAR COMENTARIO EN CAMPOS CON MISMO NOMBRE"
        Me.chkpropagar.UseVisualStyleBackColor = True
        '
        'txtipo
        '
        Me.txtipo.Location = New System.Drawing.Point(81, 95)
        Me.txtipo.MaxLength = 60
        Me.txtipo.Name = "txtipo"
        Me.txtipo.Size = New System.Drawing.Size(149, 20)
        Me.txtipo.TabIndex = 80
        '
        'chkesalterna
        '
        Me.chkesalterna.AutoSize = True
        Me.chkesalterna.Location = New System.Drawing.Point(385, 151)
        Me.chkesalterna.Name = "chkesalterna"
        Me.chkesalterna.Size = New System.Drawing.Size(116, 17)
        Me.chkesalterna.TabIndex = 81
        Me.chkesalterna.Text = "Es llave ALTERNA"
        Me.chkesalterna.UseVisualStyleBackColor = True
        '
        'chkautoincremento
        '
        Me.chkautoincremento.AutoSize = True
        Me.chkautoincremento.Location = New System.Drawing.Point(81, 169)
        Me.chkautoincremento.Name = "chkautoincremento"
        Me.chkautoincremento.Size = New System.Drawing.Size(117, 17)
        Me.chkautoincremento.TabIndex = 82
        Me.chkautoincremento.Text = "Auto incrementable"
        Me.chkautoincremento.UseVisualStyleBackColor = True
        '
        'chksecuencia
        '
        Me.chksecuencia.AutoSize = True
        Me.chksecuencia.Location = New System.Drawing.Point(228, 169)
        Me.chksecuencia.Name = "chksecuencia"
        Me.chksecuencia.Size = New System.Drawing.Size(77, 17)
        Me.chksecuencia.TabIndex = 83
        Me.chksecuencia.Text = "Secuencia"
        Me.chksecuencia.UseVisualStyleBackColor = True
        '
        'txtsecuencia
        '
        Me.txtsecuencia.Location = New System.Drawing.Point(319, 169)
        Me.txtsecuencia.MaxLength = 60
        Me.txtsecuencia.Name = "txtsecuencia"
        Me.txtsecuencia.Size = New System.Drawing.Size(139, 20)
        Me.txtsecuencia.TabIndex = 84
        '
        'frmDBEntidadCampo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 284)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtsecuencia)
        Me.Controls.Add(Me.chksecuencia)
        Me.Controls.Add(Me.chkautoincremento)
        Me.Controls.Add(Me.chkesalterna)
        Me.Controls.Add(Me.txtipo)
        Me.Controls.Add(Me.chkpropagar)
        Me.Controls.Add(Me.chkesllave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcdorden)
        Me.Controls.Add(Me.chkpermitenulos)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtdecimales)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdgrabar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtcomment)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtlongitud)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnbcampo)
        Me.Controls.Add(Me.txtnbentidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnbftedatos)
        Me.Controls.Add(Me.txtcdftedatos)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDBEntidadCampo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Detalle de un campo para la Entidad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtdecimales As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdgrabar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtcomment As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtlongitud As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnbcampo As System.Windows.Forms.TextBox
    Friend WithEvents txtnbentidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnbftedatos As System.Windows.Forms.TextBox
    Friend WithEvents txtcdftedatos As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcdorden As System.Windows.Forms.TextBox
    Friend WithEvents chkpermitenulos As System.Windows.Forms.CheckBox
    Friend WithEvents chkesllave As System.Windows.Forms.CheckBox
    Friend WithEvents chkpropagar As System.Windows.Forms.CheckBox
    Friend WithEvents txtipo As System.Windows.Forms.TextBox
    Friend WithEvents chkesalterna As System.Windows.Forms.CheckBox
    Friend WithEvents chkautoincremento As System.Windows.Forms.CheckBox
    Friend WithEvents chksecuencia As System.Windows.Forms.CheckBox
    Friend WithEvents txtsecuencia As System.Windows.Forms.TextBox
End Class
