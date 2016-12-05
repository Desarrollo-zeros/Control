Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO

Public Class ListadoDeUsarios
    Private Dispositivos As FilterInfoCollection
    Private FuenteDeVideo As VideoCaptureDevice
    Dim encriptar As New Logica.Enciptar
    Dim Desencriptar As New Logica.Enciptar
    Dim corre As New Logica.Correo

    ''camara ''
    Dim CAMARA As VideoCaptureDevice 'CAMARA QUE ESTAMOS USANDO
    Dim BMP As Bitmap 'PARA GENERACION DE IMAGENES
    'Dim ESCRITOR As New VideoFileWriter() 'GUARDA LAS IMAGENES EN MEMORIA

    '

    Dim Users As New BindingSource
    Dim lu As New Logica.LogicaUsuario


    Private Sub ListadoDeUsarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.images
        mostrarUsuario()
        llenarCombobox()
        txtID.ReadOnly = True
        txtrbac.ReadOnly = True
        txtContraseña.PasswordChar = "*"
        Clipboard.Clear()
        chek()
        Me.ToolTip1.IsBalloon = True
        TxtTelefono.Mask = "+570000000000"
        ''Camara''
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        '
    End Sub

    Sub mostrarUsuario()
        Users.DataSource = lu.listado
        GrillaUsuario.DataSource = Users
        PictureBox1.Image = My.Resources.images
    End Sub

    Sub llenarCombobox()
        rbacname.Items.Add("1")
        rbacname.Items.Add("2")
        rbacname.Items.Add("3")
        rbacname.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Sub buscar()
        If TxtBuscarCedula.TextLength = 0 Then
            Users.RemoveFilter()
            Exit Sub
        End If
        Try
            Users.Filter = BoxBuscar.Text & " LIKE " & "'%" & TxtBuscarCedula.Text & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub TxtBuscarCedula_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarCedula.TextChanged
        buscar()
    End Sub

    Private Sub BoxBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BoxBuscar.SelectedIndexChanged
        BoxBuscar.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub



    Private Sub rbacname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rbacname.KeyPress
        e.KeyChar = ""
        Clipboard.Clear()
    End Sub

    Private Sub rbacname_MouseDown(sender As Object, e As MouseEventArgs) Handles rbacname.MouseDown
        rbacname.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub BoxBuscar_MouseDown(sender As Object, e As MouseEventArgs) Handles BoxBuscar.MouseDown
        BoxBuscar.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub


    Private Sub BoxBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BoxBuscar.KeyPress
        e.KeyChar = ""
        Clipboard.Clear()
    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If InStr("0123456789-", e.KeyChar) = 0 And Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8 Then
            e.Handled = 1
        End If




    End Sub



    Private Sub txtUsuario_MouseDown(sender As Object, e As MouseEventArgs) Handles txtUsuario.MouseDown
        If (e.Button = MouseButtons.Right) Then
            txtUsuario.ReadOnly = True
            Clipboard.Clear()
        Else
            txtUsuario.ReadOnly = False
            Clipboard.Clear()
        End If
    End Sub




    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        Clipboard.Clear()
    End Sub

    Private Sub txtContraseña_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged
        Clipboard.Clear()
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        Clipboard.Clear()
    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged
        Clipboard.Clear()
    End Sub

    Private Sub TxtTelefono_TextChanged(sender As Object, e As EventArgs)

        Clipboard.Clear()
    End Sub

    Private Sub txtCorreo_TextChanged(sender As Object, e As EventArgs) Handles txtCorreo.TextChanged
        Clipboard.Clear()

    End Sub

    Private Sub txtContraseña_MouseDown(sender As Object, e As MouseEventArgs) Handles txtContraseña.MouseDown
        If (e.Button = MouseButtons.Right) Then
            txtContraseña.ReadOnly = True
            Clipboard.Clear()
        Else
            txtContraseña.ReadOnly = False
            Clipboard.Clear()
        End If
    End Sub

    Private Sub txtNombre_MouseDown(sender As Object, e As MouseEventArgs) Handles txtNombre.MouseDown
        If (e.Button = MouseButtons.Right) Then
            txtNombre.ReadOnly = True
            Clipboard.Clear()
        Else
            txtNombre.ReadOnly = False
            Clipboard.Clear()
        End If
    End Sub

    Private Sub txtApellido_MouseDown(sender As Object, e As MouseEventArgs) Handles txtApellido.MouseDown
        If (e.Button = MouseButtons.Right) Then
            txtApellido.ReadOnly = True
            Clipboard.Clear()
        Else
            txtApellido.ReadOnly = False
            Clipboard.Clear()
        End If
    End Sub


    Private Sub TxtTelefono_MouseDown(sender As Object, e As MouseEventArgs)
        If (e.Button = MouseButtons.Right) Then
            TxtTelefono.ReadOnly = True
            Clipboard.Clear()
        Else
            TxtTelefono.ReadOnly = False
            Clipboard.Clear()
        End If
    End Sub


    Private Sub txtCorreo_MouseDown(sender As Object, e As MouseEventArgs) Handles txtCorreo.MouseDown
        If (e.Button = MouseButtons.Right) Then
            txtCorreo.ReadOnly = True
            Clipboard.Clear()
        Else
            txtCorreo.ReadOnly = False
            Clipboard.Clear()
        End If
    End Sub


    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

   




    Sub eliminacion()
        Dim resultado As DialogResult
        resultado = MessageBox.Show("Desea Realmente Eliminar los Registros Seleccionados?", "Eliminando Usuarios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resultado = Windows.Forms.DialogResult.OK Then
            Try
                Dim sw As Boolean = False
                For Each row As DataGridViewRow In GrillaUsuario.Rows
                    Dim mark = Convert.ToBoolean(row.Cells("Eliminar").Value)
                    If mark Then
                        sw = True
                        Dim id As Integer = row.Cells("ID").Value

                        lu.eliminarUsuario(id)
                    End If
                Next
                If sw = True Then
                    MessageBox.Show("Productos Eliminados Correctamente", "Eliminacion de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                    mostrarUsuario()
                Else
                    MessageBox.Show("Seleccione items a  Eliminar", "Eliminacion de Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
                'MessageBox.Show("Clientes Eliminados Correctamente", "Eliminacion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al eliminar", "Eliminacion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Cancelando Eliminacion de de registros", "Eliminacion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        eliminacion()

    End Sub


    Sub limpiar()
        txtID.Text = ""
        txtUsuario.Text = ""
        txtContraseña.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        TxtTelefono.Text = ""
        txtCorreo.Text = ""
        txtCedula.Text = ""
        txtrbac.Text = ""


        BtnEditar.Visible = False
        BtnGuardar.Visible = True
        txtCedula.ReadOnly = False

    End Sub


    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        limpiar()
        mostrarUsuario()

    End Sub

    Private Sub chEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chEliminar.CheckedChanged
        chek()
    End Sub

    Sub chek()
        If chEliminar.CheckState = CheckState.Checked Then
            GrillaUsuario.Columns.Item("Eliminar").Visible = True
        Else
            GrillaUsuario.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub GrillaUsuario_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaUsuario.CellClick
        Try
            txtCedula.ReadOnly = True
            txtID.Text = GrillaUsuario.CurrentRow.Cells.Item(1).Value
            txtUsuario.Text = GrillaUsuario.CurrentRow.Cells.Item(2).Value
            txtContraseña.Text = GrillaUsuario.CurrentRow.Cells.Item(3).Value
            txtNombre.Text = GrillaUsuario.CurrentRow.Cells.Item(4).Value
            txtApellido.Text = GrillaUsuario.CurrentRow.Cells.Item(5).Value
            TxtTelefono.Text = GrillaUsuario.CurrentRow.Cells.Item(6).Value
            txtCorreo.Text = GrillaUsuario.CurrentRow.Cells.Item(7).Value
            txtCedula.Text = GrillaUsuario.CurrentRow.Cells.Item(8).Value
            txtrbac.Text = GrillaUsuario.CurrentRow.Cells.Item(9).Value
            PictureBox1.Image = My.Resources.images
            txtID.ReadOnly = True
            txtUsuario.ReadOnly = True
            txtContraseña.ReadOnly = True
            txtNombre.ReadOnly = True
            txtApellido.ReadOnly = True
            TxtTelefono.ReadOnly = True
            txtCorreo.ReadOnly = True
            txtCedula.ReadOnly = True
            txtrbac.ReadOnly = True
            rbacname.DropDownStyle = ComboBoxStyle.DropDownList
            Try
                Dim b() As Byte = GrillaUsuario.SelectedCells.Item(10).Value
                Dim ms As New MemoryStream(b)
                PictureBox1.Image = Image.FromStream(ms)
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

            Catch ex As Exception

            End Try

            BtnEditar.Visible = True
            BtnGuardar.Visible = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GrillaUsuario_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaUsuario.CellContentClick
        If e.ColumnIndex = GrillaUsuario.Columns.Item("Eliminar").Index Then
            Dim checCell As DataGridViewCheckBoxCell = GrillaUsuario.Rows(e.RowIndex).Cells("Eliminar")
            checCell.Value = Not checCell.Value
        End If
    End Sub

    Sub guardar()
        Dim b As New Entidades.EntidadesUsuarios
        Try
            If txtUsuario.Text = "" Or txtCorreo.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or TxtTelefono.Text = "" Or txtCorreo.Text = "" Or txtCedula.Text = "" Or rbacname.Text = "" Then
                MsgBox("Por favor ingrese bien los datos")
            Else : Dim msj As String
                Dim ms As New MemoryStream
                b.UsuarioID = txtUsuario.Text
                b.ContraseñaID = encriptar.Encriptar(txtContraseña.Text)
                b.NombreID = txtNombre.Text
                b.ApellidID = txtApellido.Text

                If TxtTelefono.Text.Length < 10 Or txtCedula.Text.Length <= 8 Or txtCedula.Text.Length >= 11 Or TxtTelefono.Text.Length > 13 Then
                    MsgBox("Capo incorrecto")
                    ToolTip1.ToolTipTitle = "Invalid Input"
                    If TxtTelefono.Text.Length < 10 Or TxtTelefono.Text.Length > 13 Then
                        ToolTip1.Show("Numeros de (0,9) maximo 13 + indicativo, minimo 10 .", TxtTelefono, 5000)
                        TxtTelefono.Text = ""
                    Else
                        ToolTip1.Show("Numeros de (0,9) maximo 13 + indicativo, minimo 10 .", txtCedula, 5000)
                        txtCedula.Text = ""
                    End If

                Else
                    If corre.ValidateEmail(txtCorreo.Text) = True Then
                        b.TelefonoID = TxtTelefono.Text
                        b.CorreID = txtCorreo.Text
                        b.CedulaID = txtCedula.Text
                        b.Rbacs = rbacname.Text
                        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                        b.imagen = ms.GetBuffer
                        msj = lu.GuardarUsuario(b)
                        limpiar()
                        mostrarUsuario()
                        MessageBox.Show(msj, "AGREGAR USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        MsgBox("El correo esta mal escrito por favor verifica tu correo")
                        txtCorreo.Text = ""
                    End If
                End If
              
            End If


        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Try
            guardar()

        Catch ex As Exception

        End Try

    End Sub


    Private Sub txtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True

        End If
    End Sub

    Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs) Handles txtCedula.TextChanged
        Clipboard.Clear()
    End Sub




    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Try
            Dim existe As Boolean = False
            If BtnStart.Text = "iniciar" Then
                If existe = False Then
                    Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm() 'DIALOGO CAMARAS DISPONIBLES
                    If CAMARAS.ShowDialog() = DialogResult.OK Then
                        CAMARA = CAMARAS.VideoDevice 'CAMARA ELEGIDA
                        AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR) ' EJECUTARA CADA VEZ QUE SE GENERE UNA IMAGEN
                        CAMARA.Start() 'INICIA LA PRESENTACION DE IMAGENES EN EL PICTUREBOX
                        BtnStart.Text = "Detener"
                    End If
                Else
                    MessageBox.Show("Error: No se encuentra dispositivo.")
                End If
            Else
                CAMARA.Stop()

                BtnStart.Text = "iniciar"
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub CAPTURAR(sender As Object, eventArgs As NewFrameEventArgs)
        Try
            BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'PONE LOS DATOS EN EL BITMAP
            PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap) 'LOS PRESENTA EN EL PICTURE BOX
        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnTfoto_Click(sender As Object, e As EventArgs) Handles BtnTfoto.Click
        'PictureBox1.Image = PictureBox1.Image 'COPIA LA IMAGEN QUE HAY EN EL PICTUREBOX EN EL PICTUREBOX DEL FORMULARIO CAPTURA
        'CAMARA.Stop()
        Dim existe As Boolean = False
        If BtnTfoto.Text = "Tomar foto" Then
            If existe = False Then
                PictureBox1.Image = PictureBox1.Image
                BtnTfoto.Text = "Guardar"
            Else
                MsgBox("Error")
            End If
        Else
            Dim folder As String = Path.Combine(Application.StartupPath, "img")
            If (Not Directory.Exists(folder)) Then
                Directory.CreateDirectory(folder)
            End If
            Try
                ' Nombre del archivo.
                Dim fileName As String = Path.Combine(folder, "Nueva.jpg")

                ' Guardamos en disco la imagen existente en el control PictureBox,
                ' sobrescribiendo sin previo aviso cualquier otro archivo existente
                ' con igual nombre.
                '
                PictureBox1.Image.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                CAMARA.Stop()
                PictureBox1.Image = New System.Drawing.Bitmap(fileName)
                '  PictureBox1.Image = PictureBox1.Image
                MsgBox("se ha tomado una foto")
            Catch ex As Exception
                ' Se ha producido un error.
                MessageBox.Show(ex.Message)

            End Try
        End If
    End Sub

    Private Sub GboxUserGriw_Enter(sender As Object, e As EventArgs) Handles GboxUserGriw.Enter

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Try
            If CAMARA.IsRunning Then
                CAMARA.Stop()
                Close()
                Dispose()

            Else
                Me.Close()
                Dispose()

            End If
        Catch ex As Exception
        End Try
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub BtnSfoto_Click(sender As Object, e As EventArgs) Handles BtnSfoto.Click
        OpenFileDialog1.Filter = "Imagenes JPG|*.jpg|Imagenes GIF|*.gif|Imagenes bitmasps|*.bmp"
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Sub editar()
        Dim b As New Entidades.EntidadesUsuarios
        Try
            If txtUsuario.Text = "" Or txtCorreo.Text = "" Or txtNombre.Text = "" Or txtApellido.Text = "" Or TxtTelefono.Text = "" Or txtCorreo.Text = "" Or txtCedula.Text = "" Or rbacname.Text = "" Then
                MsgBox("Por favor ingrese bien los datos")
            Else : Dim msj As String
                Dim ms As New MemoryStream
                b.UsuarioID = txtUsuario.Text
                b.ContraseñaID = encriptar.Encriptar(txtContraseña.Text)
                b.NombreID = txtNombre.Text
                b.ApellidID = txtApellido.Text

                If TxtTelefono.Text.Length < 10 Or txtCedula.Text.Length <= 8 Or txtCedula.Text.Length >= 11 Or TxtTelefono.Text.Length > 13 Then
                    MsgBox("Capo incorrecto")
                    ToolTip1.ToolTipTitle = "Invalid Input"
                    If TxtTelefono.Text.Length < 10 Or TxtTelefono.Text.Length > 13 Then
                        ToolTip1.Show("Numeros de (0,9) maximo 13 + indicativo, minimo 10 .", TxtTelefono, 5000)
                        TxtTelefono.Text = ""
                    Else
                        ToolTip1.Show("Numeros de (0,9) maximo 13 + indicativo, minimo 10 .", txtCedula, 5000)
                        txtCedula.Text = ""
                    End If

                Else
                    If corre.ValidateEmail(txtCorreo.Text) = True Then
                        b.TelefonoID = TxtTelefono.Text
                        b.CorreID = txtCorreo.Text
                        b.CedulaID = txtCedula.Text
                        b.Rbacs = rbacname.Text
                        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                        b.imagen = ms.GetBuffer
                        msj = lu.actualizarUsuario(b)
                        MessageBox.Show(msj, "AGREGAR USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        limpiar()
                        mostrarUsuario()
                    Else
                        MsgBox("El correo esta mal escrito por favor verifica tu correo")
                        txtCorreo.Text = ""
                    End If
                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Dim existe As Boolean = False
        If BtnEditar.Text = "Editar" Then
            If existe = False Then
                txtID.ReadOnly = True
                txtUsuario.ReadOnly = False
                txtContraseña.ReadOnly = False
                txtNombre.ReadOnly = False
                txtApellido.ReadOnly = False
                TxtTelefono.ReadOnly = False
                txtCorreo.ReadOnly = False
                txtCedula.ReadOnly = True
                txtrbac.ReadOnly = True
                rbacname.DropDownStyle = ComboBoxStyle.DropDown
                BtnEditar.Text = "Actualizar"
            Else
                MsgBox("error")
            End If

        Else
            editar()
            BtnEditar.Text = "Editar"
        End If

        Try

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtCedula_MouseDown(sender As Object, e As MouseEventArgs) Handles txtCedula.MouseDown
        If (e.Button = MouseButtons.Right) Then
            TxtTelefono.ReadOnly = True
            Clipboard.Clear()
        Else
            TxtTelefono.ReadOnly = False
            Clipboard.Clear()
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles TxtTelefono.MaskInputRejected
    End Sub

    Private Sub ListadoDeUsarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Try
            CAMARA.Stop()
        Catch ex As Exception

        End Try

        Me.Dispose()
    End Sub
End Class