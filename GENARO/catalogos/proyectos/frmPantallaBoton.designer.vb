<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPantallaBoton
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
        Me.txtnbpantalla = New System.Windows.Forms.TextBox()
        Me.txtcdpantalla = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnbproyecto = New System.Windows.Forms.TextBox()
        Me.txtcdproyecto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcdboton = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtcomentario = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.cmdgrabar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtnbpantalla
        '
        Me.txtnbpantalla.Location = New System.Drawing.Point(160, 36)
        Me.txtnbpantalla.Name = "txtnbpantalla"
        Me.txtnbpantalla.ReadOnly = True
        Me.txtnbpantalla.Size = New System.Drawing.Size(298, 20)
        Me.txtnbpantalla.TabIndex = 19
        '
        'txtcdpantalla
        '
        Me.txtcdpantalla.Location = New System.Drawing.Point(81, 36)
        Me.txtcdpantalla.Name = "txtcdpantalla"
        Me.txtcdpantalla.ReadOnly = True
        Me.txtcdpantalla.Size = New System.Drawing.Size(73, 20)
        Me.txtcdpantalla.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Pantalla :"
        '
        'txtnbproyecto
        '
        Me.txtnbproyecto.Location = New System.Drawing.Point(160, 6)
        Me.txtnbproyecto.Name = "txtnbproyecto"
        Me.txtnbproyecto.ReadOnly = True
        Me.txtnbproyecto.Size = New System.Drawing.Size(298, 20)
        Me.txtnbproyecto.TabIndex = 16
        '
        'txtcdproyecto
        '
        Me.txtcdproyecto.Location = New System.Drawing.Point(81, 6)
        Me.txtcdproyecto.Name = "txtcdproyecto"
        Me.txtcdproyecto.ReadOnly = True
        Me.txtcdproyecto.Size = New System.Drawing.Size(73, 20)
        Me.txtcdproyecto.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Proyecto :"
        '
        'txtcdboton
        '
        Me.txtcdboton.Location = New System.Drawing.Point(81, 63)
        Me.txtcdboton.Name = "txtcdboton"
        Me.txtcdboton.ReadOnly = True
        Me.txtcdboton.Size = New System.Drawing.Size(73, 20)
        Me.txtcdboton.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Botón :"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(81, 89)
        Me.txtNombre.MaxLength = 60
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(377, 20)
        Me.txtNombre.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nombre :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Comentario :"
        '
        'txtcomentario
        '
        Me.txtcomentario.Location = New System.Drawing.Point(81, 114)
        Me.txtcomentario.MaxLength = 1000
        Me.txtcomentario.Multiline = True
        Me.txtcomentario.Name = "txtcomentario"
        Me.txtcomentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtcomentario.Size = New System.Drawing.Size(377, 63)
        Me.txtcomentario.TabIndex = 29
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(475, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 23)
        Me.btnSalir.TabIndex = 30
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'cmdgrabar
        '
        Me.cmdgrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdgrabar.Location = New System.Drawing.Point(475, 34)
        Me.cmdgrabar.Name = "cmdgrabar"
        Me.cmdgrabar.Size = New System.Drawing.Size(87, 23)
        Me.cmdgrabar.TabIndex = 31
        Me.cmdgrabar.Text = "Grabar"
        Me.cmdgrabar.UseVisualStyleBackColor = True
        '
        'frmPantallaBoton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 184)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdgrabar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtcomentario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtcdboton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnbpantalla)
        Me.Controls.Add(Me.txtcdpantalla)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnbproyecto)
        Me.Controls.Add(Me.txtcdproyecto)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPantallaBoton"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Datos de un boton"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnbpantalla As System.Windows.Forms.TextBox
    Friend WithEvents txtcdpantalla As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnbproyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtcdproyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtcdboton As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcomentario As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents cmdgrabar As System.Windows.Forms.Button
End Class
