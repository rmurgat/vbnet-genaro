<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddNavegacion1
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.cbodesde = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnbproyecto = New System.Windows.Forms.TextBox()
        Me.lblcdproyecto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbohasta = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radget = New System.Windows.Forms.RadioButton()
        Me.radpost = New System.Windows.Forms.RadioButton()
        Me.chknewindow = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(460, 123)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 23)
        Me.btnSalir.TabIndex = 40
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Location = New System.Drawing.Point(368, 123)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabar.TabIndex = 39
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'cbodesde
        '
        Me.cbodesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbodesde.FormattingEnabled = True
        Me.cbodesde.Location = New System.Drawing.Point(81, 32)
        Me.cbodesde.Name = "cbodesde"
        Me.cbodesde.Size = New System.Drawing.Size(473, 21)
        Me.cbodesde.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Desde :"
        '
        'txtnbproyecto
        '
        Me.txtnbproyecto.Location = New System.Drawing.Point(191, 6)
        Me.txtnbproyecto.Name = "txtnbproyecto"
        Me.txtnbproyecto.ReadOnly = True
        Me.txtnbproyecto.Size = New System.Drawing.Size(363, 20)
        Me.txtnbproyecto.TabIndex = 36
        '
        'lblcdproyecto
        '
        Me.lblcdproyecto.Location = New System.Drawing.Point(81, 6)
        Me.lblcdproyecto.Name = "lblcdproyecto"
        Me.lblcdproyecto.ReadOnly = True
        Me.lblcdproyecto.Size = New System.Drawing.Size(100, 20)
        Me.lblcdproyecto.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Proyecto :"
        '
        'cbohasta
        '
        Me.cbohasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbohasta.FormattingEnabled = True
        Me.cbohasta.Location = New System.Drawing.Point(81, 59)
        Me.cbohasta.Name = "cbohasta"
        Me.cbohasta.Size = New System.Drawing.Size(473, 21)
        Me.cbohasta.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Hasta :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Tipo :"
        '
        'radget
        '
        Me.radget.AutoSize = True
        Me.radget.Location = New System.Drawing.Point(81, 91)
        Me.radget.Name = "radget"
        Me.radget.Size = New System.Drawing.Size(42, 17)
        Me.radget.TabIndex = 48
        Me.radget.TabStop = True
        Me.radget.Text = "Get"
        Me.radget.UseVisualStyleBackColor = True
        '
        'radpost
        '
        Me.radpost.AutoSize = True
        Me.radpost.Checked = True
        Me.radpost.Location = New System.Drawing.Point(139, 91)
        Me.radpost.Name = "radpost"
        Me.radpost.Size = New System.Drawing.Size(46, 17)
        Me.radpost.TabIndex = 49
        Me.radpost.TabStop = True
        Me.radpost.Text = "Post"
        Me.radpost.UseVisualStyleBackColor = True
        '
        'chknewindow
        '
        Me.chknewindow.AutoSize = True
        Me.chknewindow.Location = New System.Drawing.Point(464, 93)
        Me.chknewindow.Name = "chknewindow"
        Me.chknewindow.Size = New System.Drawing.Size(90, 17)
        Me.chknewindow.TabIndex = 51
        Me.chknewindow.Text = "New Window"
        Me.chknewindow.UseVisualStyleBackColor = True
        '
        'frmaddNavegacion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 158)
        Me.ControlBox = False
        Me.Controls.Add(Me.chknewindow)
        Me.Controls.Add(Me.radpost)
        Me.Controls.Add(Me.radget)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbohasta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.cbodesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtnbproyecto)
        Me.Controls.Add(Me.lblcdproyecto)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmaddNavegacion1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Agregar una Navegación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents cbodesde As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnbproyecto As System.Windows.Forms.TextBox
    Friend WithEvents lblcdproyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbohasta As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents radget As System.Windows.Forms.RadioButton
    Friend WithEvents radpost As System.Windows.Forms.RadioButton
    Friend WithEvents chknewindow As System.Windows.Forms.CheckBox
End Class
