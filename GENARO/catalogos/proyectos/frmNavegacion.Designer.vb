<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNavegacion
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
        Me.txtnbproyecto = New System.Windows.Forms.TextBox()
        Me.txtcdproyecto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.txtnbdesde = New System.Windows.Forms.TextBox()
        Me.txtcdesde = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnbhasta = New System.Windows.Forms.TextBox()
        Me.txtcdhasta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chknewindow = New System.Windows.Forms.CheckBox()
        Me.radpost = New System.Windows.Forms.RadioButton()
        Me.radget = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnaddall = New System.Windows.Forms.Button()
        Me.gridparametros = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gridparametros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnbproyecto
        '
        Me.txtnbproyecto.Location = New System.Drawing.Point(191, 16)
        Me.txtnbproyecto.Name = "txtnbproyecto"
        Me.txtnbproyecto.ReadOnly = True
        Me.txtnbproyecto.Size = New System.Drawing.Size(363, 20)
        Me.txtnbproyecto.TabIndex = 39
        '
        'txtcdproyecto
        '
        Me.txtcdproyecto.Location = New System.Drawing.Point(81, 16)
        Me.txtcdproyecto.Name = "txtcdproyecto"
        Me.txtcdproyecto.ReadOnly = True
        Me.txtcdproyecto.Size = New System.Drawing.Size(100, 20)
        Me.txtcdproyecto.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Proyecto :"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(590, 14)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 23)
        Me.btnSalir.TabIndex = 42
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabar.Location = New System.Drawing.Point(590, 43)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(94, 23)
        Me.btnGrabar.TabIndex = 41
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'txtnbdesde
        '
        Me.txtnbdesde.Location = New System.Drawing.Point(191, 45)
        Me.txtnbdesde.Name = "txtnbdesde"
        Me.txtnbdesde.ReadOnly = True
        Me.txtnbdesde.Size = New System.Drawing.Size(363, 20)
        Me.txtnbdesde.TabIndex = 45
        '
        'txtcdesde
        '
        Me.txtcdesde.Location = New System.Drawing.Point(81, 45)
        Me.txtcdesde.Name = "txtcdesde"
        Me.txtcdesde.ReadOnly = True
        Me.txtcdesde.Size = New System.Drawing.Size(100, 20)
        Me.txtcdesde.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Desde :"
        '
        'txtnbhasta
        '
        Me.txtnbhasta.Location = New System.Drawing.Point(191, 74)
        Me.txtnbhasta.Name = "txtnbhasta"
        Me.txtnbhasta.ReadOnly = True
        Me.txtnbhasta.Size = New System.Drawing.Size(363, 20)
        Me.txtnbhasta.TabIndex = 48
        '
        'txtcdhasta
        '
        Me.txtcdhasta.Location = New System.Drawing.Point(81, 74)
        Me.txtcdhasta.Name = "txtcdhasta"
        Me.txtcdhasta.ReadOnly = True
        Me.txtcdhasta.Size = New System.Drawing.Size(100, 20)
        Me.txtcdhasta.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Hasta :"
        '
        'chknewindow
        '
        Me.chknewindow.AutoSize = True
        Me.chknewindow.Location = New System.Drawing.Point(464, 107)
        Me.chknewindow.Name = "chknewindow"
        Me.chknewindow.Size = New System.Drawing.Size(90, 17)
        Me.chknewindow.TabIndex = 55
        Me.chknewindow.Text = "New Window"
        Me.chknewindow.UseVisualStyleBackColor = True
        '
        'radpost
        '
        Me.radpost.AutoSize = True
        Me.radpost.Checked = True
        Me.radpost.Location = New System.Drawing.Point(139, 105)
        Me.radpost.Name = "radpost"
        Me.radpost.Size = New System.Drawing.Size(46, 17)
        Me.radpost.TabIndex = 54
        Me.radpost.TabStop = True
        Me.radpost.Text = "Post"
        Me.radpost.UseVisualStyleBackColor = True
        '
        'radget
        '
        Me.radget.AutoSize = True
        Me.radget.Location = New System.Drawing.Point(81, 105)
        Me.radget.Name = "radget"
        Me.radget.Size = New System.Drawing.Size(42, 17)
        Me.radget.TabIndex = 53
        Me.radget.TabStop = True
        Me.radget.Text = "Get"
        Me.radget.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Tipo :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnaddall)
        Me.GroupBox1.Controls.Add(Me.gridparametros)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 174)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Parámetros "
        '
        'btnaddall
        '
        Me.btnaddall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddall.Location = New System.Drawing.Point(22, 145)
        Me.btnaddall.Name = "btnaddall"
        Me.btnaddall.Size = New System.Drawing.Size(160, 23)
        Me.btnaddall.TabIndex = 57
        Me.btnaddall.Text = "Agregar todas las entradas..."
        Me.btnaddall.UseVisualStyleBackColor = True
        '
        'gridparametros
        '
        Me.gridparametros.AllowUserToOrderColumns = True
        Me.gridparametros.AllowUserToResizeRows = False
        Me.gridparametros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridparametros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridparametros.Location = New System.Drawing.Point(22, 28)
        Me.gridparametros.MultiSelect = False
        Me.gridparametros.Name = "gridparametros"
        Me.gridparametros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gridparametros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridparametros.Size = New System.Drawing.Size(499, 114)
        Me.gridparametros.TabIndex = 24
        '
        'frmNavegacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 319)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chknewindow)
        Me.Controls.Add(Me.radpost)
        Me.Controls.Add(Me.radget)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnbhasta)
        Me.Controls.Add(Me.txtcdhasta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnbdesde)
        Me.Controls.Add(Me.txtcdesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.txtnbproyecto)
        Me.Controls.Add(Me.txtcdproyecto)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmNavegacion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Navegación"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.gridparametros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtnbproyecto As System.Windows.Forms.TextBox
    Friend WithEvents txtcdproyecto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents txtnbdesde As System.Windows.Forms.TextBox
    Friend WithEvents txtcdesde As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnbhasta As System.Windows.Forms.TextBox
    Friend WithEvents txtcdhasta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chknewindow As System.Windows.Forms.CheckBox
    Friend WithEvents radpost As System.Windows.Forms.RadioButton
    Friend WithEvents radget As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gridparametros As System.Windows.Forms.DataGridView
    Friend WithEvents btnaddall As System.Windows.Forms.Button
End Class
