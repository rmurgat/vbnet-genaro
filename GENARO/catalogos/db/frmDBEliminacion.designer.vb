<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDBEliminacion
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
        Me.btnfuente = New System.Windows.Forms.Button()
        Me.cbofuente = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.gridEntidades = New System.Windows.Forms.DataGridView()
        Me.chktodas = New System.Windows.Forms.CheckBox()
        Me.btnleer = New System.Windows.Forms.Button()
        Me.cbosalir = New System.Windows.Forms.Button()
        Me.cboeliminar = New System.Windows.Forms.Button()
        Me.chkdelall = New System.Windows.Forms.CheckBox()
        Me.chkdelref = New System.Windows.Forms.CheckBox()
        CType(Me.gridEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnfuente
        '
        Me.btnfuente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfuente.Location = New System.Drawing.Point(342, 61)
        Me.btnfuente.Name = "btnfuente"
        Me.btnfuente.Size = New System.Drawing.Size(103, 20)
        Me.btnfuente.TabIndex = 15
        Me.btnfuente.Text = "Ver Fuente..."
        Me.btnfuente.UseVisualStyleBackColor = True
        '
        'cbofuente
        '
        Me.cbofuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofuente.FormattingEnabled = True
        Me.cbofuente.Location = New System.Drawing.Point(12, 34)
        Me.cbofuente.Name = "cbofuente"
        Me.cbofuente.Size = New System.Drawing.Size(433, 21)
        Me.cbofuente.TabIndex = 14
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(12, 12)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(91, 16)
        Me.TextBox3.TabIndex = 13
        Me.TextBox3.Text = "Fuente de Datos : "
        '
        'gridEntidades
        '
        Me.gridEntidades.AllowUserToAddRows = False
        Me.gridEntidades.AllowUserToDeleteRows = False
        Me.gridEntidades.AllowUserToResizeColumns = False
        Me.gridEntidades.AllowUserToResizeRows = False
        Me.gridEntidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridEntidades.Location = New System.Drawing.Point(12, 87)
        Me.gridEntidades.MultiSelect = False
        Me.gridEntidades.Name = "gridEntidades"
        Me.gridEntidades.RowHeadersVisible = False
        Me.gridEntidades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.gridEntidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridEntidades.Size = New System.Drawing.Size(433, 264)
        Me.gridEntidades.TabIndex = 20
        '
        'chktodas
        '
        Me.chktodas.AutoSize = True
        Me.chktodas.Location = New System.Drawing.Point(13, 357)
        Me.chktodas.Name = "chktodas"
        Me.chktodas.Size = New System.Drawing.Size(111, 17)
        Me.chktodas.TabIndex = 21
        Me.chktodas.Text = "Seleccionar todas"
        Me.chktodas.UseVisualStyleBackColor = True
        '
        'btnleer
        '
        Me.btnleer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnleer.Location = New System.Drawing.Point(218, 61)
        Me.btnleer.Name = "btnleer"
        Me.btnleer.Size = New System.Drawing.Size(118, 20)
        Me.btnleer.TabIndex = 22
        Me.btnleer.Text = "Leer Información ..."
        Me.btnleer.UseVisualStyleBackColor = True
        '
        'cbosalir
        '
        Me.cbosalir.Location = New System.Drawing.Point(371, 415)
        Me.cbosalir.Name = "cbosalir"
        Me.cbosalir.Size = New System.Drawing.Size(75, 23)
        Me.cbosalir.TabIndex = 23
        Me.cbosalir.Text = "Salir"
        Me.cbosalir.UseVisualStyleBackColor = True
        '
        'cboeliminar
        '
        Me.cboeliminar.Location = New System.Drawing.Point(279, 415)
        Me.cboeliminar.Name = "cboeliminar"
        Me.cboeliminar.Size = New System.Drawing.Size(86, 23)
        Me.cboeliminar.TabIndex = 24
        Me.cboeliminar.Text = "ELIMINAR"
        Me.cboeliminar.UseVisualStyleBackColor = True
        '
        'chkdelall
        '
        Me.chkdelall.AutoSize = True
        Me.chkdelall.Location = New System.Drawing.Point(292, 357)
        Me.chkdelall.Name = "chkdelall"
        Me.chkdelall.Size = New System.Drawing.Size(154, 17)
        Me.chkdelall.TabIndex = 25
        Me.chkdelall.Text = "Eliminar toda la información"
        Me.chkdelall.UseVisualStyleBackColor = True
        '
        'chkdelref
        '
        Me.chkdelref.AutoSize = True
        Me.chkdelref.Location = New System.Drawing.Point(292, 380)
        Me.chkdelref.Name = "chkdelref"
        Me.chkdelref.Size = New System.Drawing.Size(139, 17)
        Me.chkdelref.TabIndex = 26
        Me.chkdelref.Text = "Eliminar solo referencias"
        Me.chkdelref.UseVisualStyleBackColor = True
        '
        'frmDBEliminacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkdelref)
        Me.Controls.Add(Me.chkdelall)
        Me.Controls.Add(Me.cboeliminar)
        Me.Controls.Add(Me.cbosalir)
        Me.Controls.Add(Me.btnleer)
        Me.Controls.Add(Me.chktodas)
        Me.Controls.Add(Me.gridEntidades)
        Me.Controls.Add(Me.btnfuente)
        Me.Controls.Add(Me.cbofuente)
        Me.Controls.Add(Me.TextBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmDBEliminacion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "GENARO - Eliminación Masiva de Entidades"
        CType(Me.gridEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnfuente As System.Windows.Forms.Button
    Friend WithEvents cbofuente As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents gridEntidades As System.Windows.Forms.DataGridView
    Friend WithEvents chktodas As System.Windows.Forms.CheckBox
    Friend WithEvents btnleer As System.Windows.Forms.Button
    Friend WithEvents cbosalir As System.Windows.Forms.Button
    Friend WithEvents cboeliminar As System.Windows.Forms.Button
    Friend WithEvents chkdelall As System.Windows.Forms.CheckBox
    Friend WithEvents chkdelref As System.Windows.Forms.CheckBox
End Class
