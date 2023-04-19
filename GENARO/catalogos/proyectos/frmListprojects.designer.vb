<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlistprojects
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
        Me.gridprojects = New System.Windows.Forms.DataGridView()
        Me.cbodetalle = New System.Windows.Forms.Button()
        CType(Me.gridprojects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridprojects
        '
        Me.gridprojects.AllowUserToAddRows = False
        Me.gridprojects.AllowUserToDeleteRows = False
        Me.gridprojects.AllowUserToResizeRows = False
        Me.gridprojects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridprojects.Location = New System.Drawing.Point(12, 12)
        Me.gridprojects.MultiSelect = False
        Me.gridprojects.Name = "gridprojects"
        Me.gridprojects.ReadOnly = True
        Me.gridprojects.RowHeadersVisible = False
        Me.gridprojects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridprojects.Size = New System.Drawing.Size(360, 378)
        Me.gridprojects.TabIndex = 30
        '
        'cbodetalle
        '
        Me.cbodetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cbodetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbodetalle.Location = New System.Drawing.Point(12, 394)
        Me.cbodetalle.Name = "cbodetalle"
        Me.cbodetalle.Size = New System.Drawing.Size(86, 20)
        Me.cbodetalle.TabIndex = 31
        Me.cbodetalle.Text = "ver detalle"
        Me.cbodetalle.UseVisualStyleBackColor = True
        
        '
	        'frmlistprojects
	        '
	        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
	        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
	        Me.ClientSize = New System.Drawing.Size(383, 419)
	        Me.Controls.Add(Me.cbodetalle)
	        Me.Controls.Add(Me.gridprojects)
	        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
	        Me.MaximizeBox = False
	        Me.MinimizeBox = False
        'Me.Name = "frmlistprojects"
	        Me.ShowIcon = False
	        Me.ShowInTaskbar = False
	        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
	        Me.Text = "GENARO - Listado de proyectos"
	        CType(Me.gridprojects, System.ComponentModel.ISupportInitialize).EndInit()
	        Me.ResumeLayout(False)


    End Sub
    Friend WithEvents Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gridprojects As System.Windows.Forms.DataGridView
    Friend WithEvents cbodetalle As System.Windows.Forms.Button
End Class
