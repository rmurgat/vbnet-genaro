<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPryEliminacion
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
        Me.cboeliminar = New System.Windows.Forms.Button()
        Me.cbosalir = New System.Windows.Forms.Button()
        Me.btnleer = New System.Windows.Forms.Button()
        Me.chktodas = New System.Windows.Forms.CheckBox()
        Me.gridPantallas = New System.Windows.Forms.DataGridView()
        Me.btnproyecto = New System.Windows.Forms.Button()
        Me.cboproyecto = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.gridPantallas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboeliminar
        '
        Me.cboeliminar.Location = New System.Drawing.Point(268, 354)
        Me.cboeliminar.Name = "cboeliminar"
        Me.cboeliminar.Size = New System.Drawing.Size(86, 23)
        Me.cboeliminar.TabIndex = 34
        Me.cboeliminar.Text = "ELIMINAR"
        Me.cboeliminar.UseVisualStyleBackColor = True
        '
        'cbosalir
        '
        Me.cbosalir.Location = New System.Drawing.Point(360, 354)
        Me.cbosalir.Name = "cbosalir"
        Me.cbosalir.Size = New System.Drawing.Size(75, 23)
        Me.cbosalir.TabIndex = 33
        Me.cbosalir.Text = "Salir"
        Me.cbosalir.UseVisualStyleBackColor = True
        '
        'btnleer
        '
        Me.btnleer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnleer.Location = New System.Drawing.Point(209, 58)
        Me.btnleer.Name = "btnleer"
        Me.btnleer.Size = New System.Drawing.Size(118, 20)
        Me.btnleer.TabIndex = 32
        Me.btnleer.Text = "Leer Información ..."
        Me.btnleer.UseVisualStyleBackColor = True
        '
        'chktodas
        '
        Me.chktodas.AutoSize = True
        Me.chktodas.Location = New System.Drawing.Point(4, 354)
        Me.chktodas.Name = "chktodas"
        Me.chktodas.Size = New System.Drawing.Size(111, 17)
        Me.chktodas.TabIndex = 31
        Me.chktodas.Text = "Seleccionar todas"
        Me.chktodas.UseVisualStyleBackColor = True
        '
        'gridPantallas
        '
        Me.gridPantallas.AllowUserToAddRows = False
        Me.gridPantallas.AllowUserToDeleteRows = False
        Me.gridPantallas.AllowUserToResizeColumns = False
        Me.gridPantallas.AllowUserToResizeRows = False
        Me.gridPantallas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridPantallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPantallas.Location = New System.Drawing.Point(3, 84)
        Me.gridPantallas.MultiSelect = False
        Me.gridPantallas.Name = "gridPantallas"
        Me.gridPantallas.RowHeadersVisible = False
        Me.gridPantallas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gridPantallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridPantallas.Size = New System.Drawing.Size(433, 264)
        Me.gridPantallas.TabIndex = 30
        '
        'btnproyecto
        '
        Me.btnproyecto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnproyecto.Location = New System.Drawing.Point(333, 58)
        Me.btnproyecto.Name = "btnproyecto"
        Me.btnproyecto.Size = New System.Drawing.Size(103, 20)
        Me.btnproyecto.TabIndex = 29
        Me.btnproyecto.Text = "Ver Proyecto..."
        Me.btnproyecto.UseVisualStyleBackColor = True
        '
        'cboproyecto
        '
        Me.cboproyecto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboproyecto.FormattingEnabled = True
        Me.cboproyecto.Location = New System.Drawing.Point(3, 31)
        Me.cboproyecto.Name = "cboproyecto"
        Me.cboproyecto.Size = New System.Drawing.Size(433, 21)
        Me.cboproyecto.TabIndex = 28
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(3, 9)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(69, 16)
        Me.TextBox3.TabIndex = 27
        Me.TextBox3.Text = "Proyecto : "
        '
        'frmPryEliminacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 386)
        Me.ControlBox = False
        Me.Controls.Add(Me.cboeliminar)
        Me.Controls.Add(Me.cbosalir)
        Me.Controls.Add(Me.btnleer)
        Me.Controls.Add(Me.chktodas)
        Me.Controls.Add(Me.gridPantallas)
        Me.Controls.Add(Me.btnproyecto)
        Me.Controls.Add(Me.cboproyecto)
        Me.Controls.Add(Me.TextBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPryEliminacion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Herramienta de eliminación masiva"
        CType(Me.gridPantallas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboeliminar As System.Windows.Forms.Button
    Friend WithEvents cbosalir As System.Windows.Forms.Button
    Friend WithEvents btnleer As System.Windows.Forms.Button
    Friend WithEvents chktodas As System.Windows.Forms.CheckBox
    Friend WithEvents gridPantallas As System.Windows.Forms.DataGridView
    Friend WithEvents btnproyecto As System.Windows.Forms.Button
    Friend WithEvents cboproyecto As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
End Class
