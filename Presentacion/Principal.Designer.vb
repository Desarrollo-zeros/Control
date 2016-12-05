<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnvioCorreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoogleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlocDeNotasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DerechoDeAutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.OperadorToolStripMenuItem, Me.EnvioCorreoToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(825, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(741, 289)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bienvenido A Control"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(266, 325)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.z1
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(729, 270)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.descarga
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'OperadorToolStripMenuItem
        '
        Me.OperadorToolStripMenuItem.Image = CType(resources.GetObject("OperadorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OperadorToolStripMenuItem.Name = "OperadorToolStripMenuItem"
        Me.OperadorToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.OperadorToolStripMenuItem.Text = "Operador"
        '
        'EnvioCorreoToolStripMenuItem
        '
        Me.EnvioCorreoToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.chat1
        Me.EnvioCorreoToolStripMenuItem.Name = "EnvioCorreoToolStripMenuItem"
        Me.EnvioCorreoToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.EnvioCorreoToolStripMenuItem.Text = "Envio Correo"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoogleToolStripMenuItem, Me.BlocDeNotasToolStripMenuItem, Me.CalculadoraToolStripMenuItem, Me.FotoToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.images__2_
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'GoogleToolStripMenuItem
        '
        Me.GoogleToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.descarga__1_
        Me.GoogleToolStripMenuItem.Name = "GoogleToolStripMenuItem"
        Me.GoogleToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.GoogleToolStripMenuItem.Text = "Google"
        '
        'BlocDeNotasToolStripMenuItem
        '
        Me.BlocDeNotasToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.descarga__2_
        Me.BlocDeNotasToolStripMenuItem.Name = "BlocDeNotasToolStripMenuItem"
        Me.BlocDeNotasToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.BlocDeNotasToolStripMenuItem.Text = "Bloc De Notas"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.calcuworld2
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.CalculadoraToolStripMenuItem.Text = "Calculadora"
        '
        'FotoToolStripMenuItem
        '
        Me.FotoToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.Foto11
        Me.FotoToolStripMenuItem.Name = "FotoToolStripMenuItem"
        Me.FotoToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.FotoToolStripMenuItem.Text = "Foto"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DerechoDeAutoToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.descarga__3_
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'DerechoDeAutoToolStripMenuItem
        '
        Me.DerechoDeAutoToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.Buscar1
        Me.DerechoDeAutoToolStripMenuItem.Name = "DerechoDeAutoToolStripMenuItem"
        Me.DerechoDeAutoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DerechoDeAutoToolStripMenuItem.Text = "Acerca De...."
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 357)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = "Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OperadorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents EnvioCorreoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoogleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlocDeNotasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DerechoDeAutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
