<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddreporte
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
        Me.cmdgrabar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtobjetivo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnbproyecto = New System.Windows.Forms.TextBox()
        Me.txtcdproyecto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdgrabar
        '
        Me.cmdgrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdgrabar.Location = New System.Drawing.Point(600, 39)
        Me.cmdgrabar.Name = "cmdgrabar"
        Me.cmdgrabar.Size = New System.Drawing.Size(87, 23)
        Me.cmdgrabar.TabIndex = 34
        Me.cmdgrabar.Text = "Grabar"
        Me.cmdgrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(600, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 23)
        Me.btnSalir.TabIndex = 33
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtobjetivo
        '
        Me.txtobjetivo.Location = New System.Drawing.Point(81, 78)
        Me.txtobjetivo.MaxLength = 400
        Me.txtobjetivo.Multiline = True
        Me.txtobjetivo.Name = "txtobjetivo"
        Me.txtobjetivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobjetivo.Size = New System.Drawing.Size(483, 64)
        Me.txtobjetivo.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Objetivo :"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(81, 41)
        Me.txtnombre.MaxLength = 60
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(483, 20)
        Me.txtnombre.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Reporte :"
        '
        'txtnbproyecto
        '
        Me.txtnbproyecto.Location = New System.Drawing.Point(187, 6)
        Me.txtnbproyecto.Name = "txtnbproyecto"
        Me.txtnbproyecto.ReadOnly = True
        Me.txtnbproyecto.Size = New System.Drawing.Size(377, 20)
        Me.txtnbproyecto.TabIndex = 28
        '
        'txtcdproyecto
        '
        Me.txtcdproyecto.Location = New System.Drawing.Point(81, 6)
        Me.txtcdproyecto.Name = "txtcdproyecto"
        Me.txtcdproyecto.ReadOnly = True
        Me.txtcdproyecto.Size = New System.Drawing.Size(100, 20)
        Me.txtcdproyecto.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Proyecto :"
        '
        'frmaddreporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 151)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdgrabar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtobjetivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnbproyecto)
        Me.Controls.Add(Me.txtcdproyecto)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmaddreporte"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Alta de un nuevo reporte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdgrabar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtobjetivo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnbproyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtcdproyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
