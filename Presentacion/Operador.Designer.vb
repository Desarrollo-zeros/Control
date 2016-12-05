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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Operador))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BoxFre = New System.Windows.Forms.ComboBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.GrillaOperador = New System.Windows.Forms.DataGridView()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxTTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.TxtEdad = New System.Windows.Forms.MaskedTextBox()
        Me.TxtCedula = New System.Windows.Forms.MaskedTextBox()
        Me.TxTDirecion = New System.Windows.Forms.TextBox()
        Me.TxTTotal = New System.Windows.Forms.TextBox()
        Me.TxTCompra = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.BoxCiudad = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BoxGenero = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AgregarClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarVehiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealizarTranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaOperador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarClienteToolStripMenuItem, Me.RealizarTranToolStripMenuItem, Me.ListaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(885, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Chart1)
        Me.GroupBox1.Controls.Add(Me.BoxFre)
        Me.GroupBox1.Controls.Add(Me.BtnEliminar)
        Me.GroupBox1.Controls.Add(Me.GrillaOperador)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.BtnEditar)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TxTTelefono)
        Me.GroupBox1.Controls.Add(Me.TxtEdad)
        Me.GroupBox1.Controls.Add(Me.TxtCedula)
        Me.GroupBox1.Controls.Add(Me.TxTDirecion)
        Me.GroupBox1.Controls.Add(Me.TxTTotal)
        Me.GroupBox1.Controls.Add(Me.TxTCompra)
        Me.GroupBox1.Controls.Add(Me.TxtCorreo)
        Me.GroupBox1.Controls.Add(Me.TextNombre)
        Me.GroupBox1.Controls.Add(Me.TxtID)
        Me.GroupBox1.Controls.Add(Me.BoxCiudad)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.BoxGenero)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(873, 385)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Cliente"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(401, 342)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox1.TabIndex = 36
        Me.CheckBox1.Text = "Eliminar"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(480, 27)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(322, 162)
        Me.Chart1.TabIndex = 35
        Me.Chart1.Text = "Chart1"
        '
        'BoxFre
        '
        Me.BoxFre.FormattingEnabled = True
        Me.BoxFre.Location = New System.Drawing.Point(92, 205)
        Me.BoxFre.Name = "BoxFre"
        Me.BoxFre.Size = New System.Drawing.Size(169, 21)
        Me.BoxFre.TabIndex = 34
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(309, 337)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(86, 24)
        Me.BtnEliminar.TabIndex = 33
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'GrillaOperador
        '
        Me.GrillaOperador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaOperador.Location = New System.Drawing.Point(309, 204)
        Me.GrillaOperador.Name = "GrillaOperador"
        Me.GrillaOperador.Size = New System.Drawing.Size(552, 127)
        Me.GrillaOperador.TabIndex = 31
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(184, 337)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(86, 24)
        Me.BtnEditar.TabIndex = 29
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(92, 337)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(86, 24)
        Me.BtnGuardar.TabIndex = 28
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(410, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 30)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxTTelefono
        '
        Me.TxTTelefono.Location = New System.Drawing.Point(92, 126)
        Me.TxTTelefono.Name = "TxTTelefono"
        Me.TxTTelefono.Size = New System.Drawing.Size(169, 20)
        Me.TxTTelefono.TabIndex = 24
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(92, 97)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(169, 20)
        Me.TxtEdad.TabIndex = 23
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(92, 71)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(169, 20)
        Me.TxtCedula.TabIndex = 22
        '
        'TxTDirecion
        '
        Me.TxTDirecion.Location = New System.Drawing.Point(92, 256)
        Me.TxTDirecion.Name = "TxTDirecion"
        Me.TxTDirecion.Size = New System.Drawing.Size(169, 20)
        Me.TxTDirecion.TabIndex = 21
        '
        'TxTTotal
        '
        Me.TxTTotal.Location = New System.Drawing.Point(92, 230)
        Me.TxTTotal.Name = "TxTTotal"
        Me.TxTTotal.Size = New System.Drawing.Size(169, 20)
        Me.TxTTotal.TabIndex = 20
        '
        'TxTCompra
        '
        Me.TxTCompra.Location = New System.Drawing.Point(92, 179)
        Me.TxTCompra.Name = "TxTCompra"
        Me.TxTCompra.Size = New System.Drawing.Size(169, 20)
        Me.TxTCompra.TabIndex = 18
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(92, 152)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(169, 20)
        Me.TxtCorreo.TabIndex = 17
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(92, 46)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(169, 20)
        Me.TextNombre.TabIndex = 16
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(92, 17)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(169, 20)
        Me.TxtID.TabIndex = 15
        '
        'BoxCiudad
        '
        Me.BoxCiudad.FormattingEnabled = True
        Me.BoxCiudad.Location = New System.Drawing.Point(92, 283)
        Me.BoxCiudad.Name = "BoxCiudad"
        Me.BoxCiudad.Size = New System.Drawing.Size(200, 21)
        Me.BoxCiudad.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 313)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Genero"
        '
        'BoxGenero
        '
        Me.BoxGenero.FormattingEnabled = True
        Me.BoxGenero.Location = New System.Drawing.Point(92, 310)
        Me.BoxGenero.Name = "BoxGenero"
        Me.BoxGenero.Size = New System.Drawing.Size(200, 21)
        Me.BoxGenero.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 283)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Ciudad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 258)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Direcion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 237)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Total Compras"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(0, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Cliente Frecuente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total Compra"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Correo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telefon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Edad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cedula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Button2
        '
        Me.Button2.Image = Global.Presentacion.My.Resources.Resources.Foto1
        Me.Button2.Location = New System.Drawing.Point(276, 159)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 30)
        Me.Button2.TabIndex = 30
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.sinfoto
        Me.PictureBox1.Location = New System.Drawing.Point(276, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 172)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'AgregarClienteToolStripMenuItem
        '
        Me.AgregarClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarClienteToolStripMenuItem1, Me.AgregarVehiculoToolStripMenuItem})
        Me.AgregarClienteToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.Guardar
        Me.AgregarClienteToolStripMenuItem.Name = "AgregarClienteToolStripMenuItem"
        Me.AgregarClienteToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AgregarClienteToolStripMenuItem.Text = "Agregar"
        '
        'AgregarClienteToolStripMenuItem1
        '
        Me.AgregarClienteToolStripMenuItem1.Image = Global.Presentacion.My.Resources.Resources.Guardar1
        Me.AgregarClienteToolStripMenuItem1.Name = "AgregarClienteToolStripMenuItem1"
        Me.AgregarClienteToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.AgregarClienteToolStripMenuItem1.Text = "Agregar Producto"
        '
        'AgregarVehiculoToolStripMenuItem
        '
        Me.AgregarVehiculoToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.Guardar1
        Me.AgregarVehiculoToolStripMenuItem.Name = "AgregarVehiculoToolStripMenuItem"
        Me.AgregarVehiculoToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AgregarVehiculoToolStripMenuItem.Text = "Agregar Vehiculo"
        '
        'RealizarTranToolStripMenuItem
        '
        Me.RealizarTranToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.transacción
        Me.RealizarTranToolStripMenuItem.Name = "RealizarTranToolStripMenuItem"
        Me.RealizarTranToolStripMenuItem.Size = New System.Drawing.Size(150, 20)
        Me.RealizarTranToolStripMenuItem.Text = "Realizar transacciones"
        '
        'ListaToolStripMenuItem
        '
        Me.ListaToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.Buscar
        Me.ListaToolStripMenuItem.Name = "ListaToolStripMenuItem"
        Me.ListaToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ListaToolStripMenuItem.Text = "Lista "
        '
        'Operador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 485)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Operador"
        Me.Text = "Operador"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaOperador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AgregarClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarClienteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarVehiculoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RealizarTranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BoxCiudad As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BoxGenero As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxTTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtEdad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxtCedula As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TxTDirecion As System.Windows.Forms.TextBox
    Friend WithEvents TxTTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxTCompra As System.Windows.Forms.TextBox
    Friend WithEvents TxtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents TextNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GrillaOperador As System.Windows.Forms.DataGridView
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents BoxFre As System.Windows.Forms.ComboBox
End Class
