<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoDeUsarios
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
        Me.components = New System.ComponentModel.Container()
        Me.GboxUser = New System.Windows.Forms.GroupBox()
        Me.TxtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnSfoto = New System.Windows.Forms.Button()
        Me.BtnTfoto = New System.Windows.Forms.Button()
        Me.txtrbac = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.rbacname = New System.Windows.Forms.ComboBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GboxUserGriw = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.chEliminar = New System.Windows.Forms.CheckBox()
        Me.GrillaUsuario = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.TxtBuscarCedula = New System.Windows.Forms.TextBox()
        Me.BoxBuscar = New System.Windows.Forms.ComboBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GboxUser.SuspendLayout()
        Me.GboxUserGriw.SuspendLayout()
        CType(Me.GrillaUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GboxUser
        '
        Me.GboxUser.Controls.Add(Me.TxtTelefono)
        Me.GboxUser.Controls.Add(Me.PictureBox1)
        Me.GboxUser.Controls.Add(Me.BtnStart)
        Me.GboxUser.Controls.Add(Me.BtnSfoto)
        Me.GboxUser.Controls.Add(Me.BtnTfoto)
        Me.GboxUser.Controls.Add(Me.txtrbac)
        Me.GboxUser.Controls.Add(Me.Label10)
        Me.GboxUser.Controls.Add(Me.BtnEditar)
        Me.GboxUser.Controls.Add(Me.BtnGuardar)
        Me.GboxUser.Controls.Add(Me.rbacname)
        Me.GboxUser.Controls.Add(Me.txtCorreo)
        Me.GboxUser.Controls.Add(Me.txtApellido)
        Me.GboxUser.Controls.Add(Me.txtNombre)
        Me.GboxUser.Controls.Add(Me.txtContraseña)
        Me.GboxUser.Controls.Add(Me.txtUsuario)
        Me.GboxUser.Controls.Add(Me.txtCedula)
        Me.GboxUser.Controls.Add(Me.txtID)
        Me.GboxUser.Controls.Add(Me.Label9)
        Me.GboxUser.Controls.Add(Me.Label8)
        Me.GboxUser.Controls.Add(Me.Label7)
        Me.GboxUser.Controls.Add(Me.Label6)
        Me.GboxUser.Controls.Add(Me.Label5)
        Me.GboxUser.Controls.Add(Me.Label4)
        Me.GboxUser.Controls.Add(Me.Label3)
        Me.GboxUser.Controls.Add(Me.Label1)
        Me.GboxUser.Controls.Add(Me.Label2)
        Me.GboxUser.Location = New System.Drawing.Point(12, 47)
        Me.GboxUser.Name = "GboxUser"
        Me.GboxUser.Size = New System.Drawing.Size(402, 319)
        Me.GboxUser.TabIndex = 0
        Me.GboxUser.TabStop = False
        Me.GboxUser.Text = "Datos De Usuario"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(67, 161)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(150, 20)
        Me.TxtTelefono.TabIndex = 26
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(269, 19)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(81, 27)
        Me.BtnStart.TabIndex = 24
        Me.BtnStart.Text = "iniciar"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnSfoto
        '
        Me.BtnSfoto.Location = New System.Drawing.Point(310, 180)
        Me.BtnSfoto.Name = "BtnSfoto"
        Me.BtnSfoto.Size = New System.Drawing.Size(81, 27)
        Me.BtnSfoto.TabIndex = 21
        Me.BtnSfoto.Text = "subir foto"
        Me.BtnSfoto.UseVisualStyleBackColor = True
        '
        'BtnTfoto
        '
        Me.BtnTfoto.Location = New System.Drawing.Point(223, 180)
        Me.BtnTfoto.Name = "BtnTfoto"
        Me.BtnTfoto.Size = New System.Drawing.Size(81, 27)
        Me.BtnTfoto.TabIndex = 20
        Me.BtnTfoto.Text = "Tomar foto"
        Me.BtnTfoto.UseVisualStyleBackColor = True
        '
        'txtrbac
        '
        Me.txtrbac.Location = New System.Drawing.Point(67, 214)
        Me.txtrbac.Name = "txtrbac"
        Me.txtrbac.Size = New System.Drawing.Size(150, 20)
        Me.txtrbac.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 217)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "ID-rebac"
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(154, 274)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(81, 25)
        Me.BtnEditar.TabIndex = 16
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(67, 274)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(81, 25)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'rbacname
        '
        Me.rbacname.FormattingEnabled = True
        Me.rbacname.Location = New System.Drawing.Point(67, 241)
        Me.rbacname.Name = "rbacname"
        Me.rbacname.Size = New System.Drawing.Size(150, 21)
        Me.rbacname.TabIndex = 2
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(67, 187)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(150, 20)
        Me.txtCorreo.TabIndex = 15
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(67, 135)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(150, 20)
        Me.txtApellido.TabIndex = 13
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(67, 108)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(150, 20)
        Me.txtNombre.TabIndex = 12
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(67, 85)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(150, 20)
        Me.txtContraseña.TabIndex = 11
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(67, 62)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(150, 20)
        Me.txtUsuario.TabIndex = 10
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(67, 36)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(150, 20)
        Me.txtCedula.TabIndex = 9
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(67, 13)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(150, 20)
        Me.txtID.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 249)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Rbac"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Cedula"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Correo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Apellido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario"
        '
        'GboxUserGriw
        '
        Me.GboxUserGriw.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.GboxUserGriw.BackColor = System.Drawing.SystemColors.Control
        Me.GboxUserGriw.Controls.Add(Me.BtnEliminar)
        Me.GboxUserGriw.Controls.Add(Me.chEliminar)
        Me.GboxUserGriw.Controls.Add(Me.GrillaUsuario)
        Me.GboxUserGriw.Controls.Add(Me.BtnActualizar)
        Me.GboxUserGriw.Controls.Add(Me.TxtBuscarCedula)
        Me.GboxUserGriw.Controls.Add(Me.BoxBuscar)
        Me.GboxUserGriw.Location = New System.Drawing.Point(433, 32)
        Me.GboxUserGriw.Name = "GboxUserGriw"
        Me.GboxUserGriw.Size = New System.Drawing.Size(456, 303)
        Me.GboxUserGriw.TabIndex = 1
        Me.GboxUserGriw.TabStop = False
        Me.GboxUserGriw.Text = "Listado De Usuario"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(6, 272)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(81, 25)
        Me.BtnEliminar.TabIndex = 17
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'chEliminar
        '
        Me.chEliminar.AutoSize = True
        Me.chEliminar.Location = New System.Drawing.Point(93, 277)
        Me.chEliminar.Name = "chEliminar"
        Me.chEliminar.Size = New System.Drawing.Size(62, 17)
        Me.chEliminar.TabIndex = 21
        Me.chEliminar.Text = "Eliminar"
        Me.chEliminar.UseVisualStyleBackColor = True
        '
        'GrillaUsuario
        '
        Me.GrillaUsuario.AllowUserToAddRows = False
        Me.GrillaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.GrillaUsuario.Location = New System.Drawing.Point(6, 47)
        Me.GrillaUsuario.Name = "GrillaUsuario"
        Me.GrillaUsuario.ReadOnly = True
        Me.GrillaUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrillaUsuario.Size = New System.Drawing.Size(450, 220)
        Me.GrillaUsuario.TabIndex = 20
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(356, 15)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(81, 25)
        Me.BtnActualizar.TabIndex = 18
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'TxtBuscarCedula
        '
        Me.TxtBuscarCedula.Location = New System.Drawing.Point(147, 19)
        Me.TxtBuscarCedula.Name = "TxtBuscarCedula"
        Me.TxtBuscarCedula.Size = New System.Drawing.Size(203, 20)
        Me.TxtBuscarCedula.TabIndex = 1
        '
        'BoxBuscar
        '
        Me.BoxBuscar.FormattingEnabled = True
        Me.BoxBuscar.Items.AddRange(New Object() {"Cedula", "Nombre", "Usuario", "Telefono", "Correo"})
        Me.BoxBuscar.Location = New System.Drawing.Point(6, 19)
        Me.BoxBuscar.Name = "BoxBuscar"
        Me.BoxBuscar.Size = New System.Drawing.Size(135, 21)
        Me.BoxBuscar.TabIndex = 0
        Me.BoxBuscar.Text = "Cedula"
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(601, 355)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(81, 25)
        Me.BtnSalir.TabIndex = 26
        Me.BtnSalir.Text = "Atras"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.Captura1
        Me.PictureBox1.Location = New System.Drawing.Point(261, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 122)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'ListadoDeUsarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 392)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GboxUserGriw)
        Me.Controls.Add(Me.GboxUser)
        Me.Name = "ListadoDeUsarios"
        Me.Text = "ListadoDeUsarios"
        Me.GboxUser.ResumeLayout(False)
        Me.GboxUser.PerformLayout()
        Me.GboxUserGriw.ResumeLayout(False)
        Me.GboxUserGriw.PerformLayout()
        CType(Me.GrillaUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GboxUser As System.Windows.Forms.GroupBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtCedula As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GboxUserGriw As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBuscarCedula As System.Windows.Forms.TextBox
    Friend WithEvents BoxBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents rbacname As System.Windows.Forms.ComboBox
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnGuardar As System.Windows.Forms.Button
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtrbac As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnActualizar As System.Windows.Forms.Button
    Friend WithEvents chEliminar As System.Windows.Forms.CheckBox
    Friend WithEvents GrillaUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents BtnSfoto As System.Windows.Forms.Button
    Friend WithEvents BtnTfoto As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TxtTelefono As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip


End Class
