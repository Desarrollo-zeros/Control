<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Operador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AgregarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarVehiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarTranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DarDeBajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarVehiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarVehiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarTransaccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarClienteToolStripMenuItem, Me.RealizarTranToolStripMenuItem, Me.DarDeBajaToolStripMenuItem, Me.ActualizarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(847, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AgregarClienteToolStripMenuItem
        '
        Me.AgregarClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarClienteToolStripMenuItem1, Me.AgregarVehiculoToolStripMenuItem})
        Me.AgregarClienteToolStripMenuItem.Name = "AgregarClienteToolStripMenuItem"
        Me.AgregarClienteToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.AgregarClienteToolStripMenuItem.Text = "Agregar"
        '
        'AgregarClienteToolStripMenuItem1
        '
        Me.AgregarClienteToolStripMenuItem1.Name = "AgregarClienteToolStripMenuItem1"
        Me.AgregarClienteToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.AgregarClienteToolStripMenuItem1.Text = "Agregar Cliente"
        '
        'AgregarVehiculoToolStripMenuItem
        '
        Me.AgregarVehiculoToolStripMenuItem.Name = "AgregarVehiculoToolStripMenuItem"
        Me.AgregarVehiculoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.AgregarVehiculoToolStripMenuItem.Text = "Agregar Vehiculo"
        '
        'RealizarTranToolStripMenuItem
        '
        Me.RealizarTranToolStripMenuItem.Name = "RealizarTranToolStripMenuItem"
        Me.RealizarTranToolStripMenuItem.Size = New System.Drawing.Size(134, 20)
        Me.RealizarTranToolStripMenuItem.Text = "Realizar transacciones"
        '
        'DarDeBajaToolStripMenuItem
        '
        Me.DarDeBajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarVehiculoToolStripMenuItem, Me.EliminarClienteToolStripMenuItem})
        Me.DarDeBajaToolStripMenuItem.Name = "DarDeBajaToolStripMenuItem"
        Me.DarDeBajaToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.DarDeBajaToolStripMenuItem.Text = "Dar de baja"
        '
        'EliminarVehiculoToolStripMenuItem
        '
        Me.EliminarVehiculoToolStripMenuItem.Name = "EliminarVehiculoToolStripMenuItem"
        Me.EliminarVehiculoToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.EliminarVehiculoToolStripMenuItem.Text = "Eliminar vehiculo"
        '
        'EliminarClienteToolStripMenuItem
        '
        Me.EliminarClienteToolStripMenuItem.Name = "EliminarClienteToolStripMenuItem"
        Me.EliminarClienteToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.EliminarClienteToolStripMenuItem.Text = "Eliminar cliente"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarVehiculoToolStripMenuItem, Me.EditarTransaccionesToolStripMenuItem, Me.EditarClienteToolStripMenuItem})
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'EditarVehiculoToolStripMenuItem
        '
        Me.EditarVehiculoToolStripMenuItem.Name = "EditarVehiculoToolStripMenuItem"
        Me.EditarVehiculoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.EditarVehiculoToolStripMenuItem.Text = "Editar Vehiculo"
        '
        'EditarTransaccionesToolStripMenuItem
        '
        Me.EditarTransaccionesToolStripMenuItem.Name = "EditarTransaccionesToolStripMenuItem"
        Me.EditarTransaccionesToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.EditarTransaccionesToolStripMenuItem.Text = "Editar transacciones"
        '
        'EditarClienteToolStripMenuItem
        '
        Me.EditarClienteToolStripMenuItem.Name = "EditarClienteToolStripMenuItem"
        Me.EditarClienteToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.EditarClienteToolStripMenuItem.Text = "Editar cliente"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 378)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Label5"
        '
        'Operador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 438)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Operador"
        Me.Text = "Operador"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AgregarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarClienteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarVehiculoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealizarTranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DarDeBajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarVehiculoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarVehiculoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarTransaccionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
