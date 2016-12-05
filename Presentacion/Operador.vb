Imports System.Data.SqlClient
Imports System.IO
Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class Operador
    Dim Users As New BindingSource
    Dim lu As New Logica.Cliente
    Dim db As New BaseDeDatos.Ciudad

    Dim CAMARA As VideoCaptureDevice 'CAMARA QUE ESTAMOS USANDO
    Dim BMP As Bitmap 'PARA GENERACION DE IMAGENES
    Private Sub Operador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.Image = My.Resources.sinfoto
        TxTTelefono.Mask = "+570000000000"
        mostrarUsuario()
        llenarCombobox()
        Clipboard.Clear()
        Boxbuscar.DropDownStyle = ComboBoxStyle.DropDownList
        chek()
        TxtID.ReadOnly = True
    End Sub
    Sub limpiar()
        TxtID.Text = ""
        TextNombre.Text = ""
        TxTTelefono.Text = ""
        TxtCorreo.Text = ""
        TxtCedula.Text = ""
        TxTCompra.Text = ""
        TxTDirecion.Text = ""
        TxtEdad.Text = ""
        BtnEditar.Visible = False
        BtnGuardar.Visible = True
        TxtCedula.ReadOnly = False

    End Sub

    Sub mostrarUsuario()
        Users.DataSource = lu.listado
        GrillaOperador.DataSource = Users
        PictureBox1.Image = My.Resources.sinfoto
    End Sub

    Sub llenarCombobox()
        BoxGenero.Items.Add("Femenino")
        BoxGenero.Items.Add("Masculino")
        BoxGenero.Items.Add("Otros")
        BoxCiudad.DataSource = db.consulta
        BoxCiudad.DisplayMember = "Ciudad"
        BoxCiudad.ValueMember = "id"
        BoxGenero.DropDownStyle = ComboBoxStyle.DropDownList
        BoxCiudad.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub


    Sub buscar()
        If TxtBuscar.TextLength = 0 Then
            Users.RemoveFilter()
            Exit Sub
        End If
        Try
            Users.Filter = Boxbuscar.Text & " LIKE " & "'%" & TxtBuscar.Text & "%'"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GrillaOperador_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaOperador.CellContentClick
        If e.ColumnIndex = GrillaOperador.Columns.Item("Eliminar").Index Then
            Dim checCell As DataGridViewCheckBoxCell = GrillaOperador.Rows(e.RowIndex).Cells("Eliminar")
            checCell.Value = Not checCell.Value
        End If
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub BoxGenero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BoxGenero.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEliminar.CheckedChanged
        chek()
    End Sub

    Sub chek()
        If CheckEliminar.CheckState = CheckState.Checked Then
            GrillaOperador.Columns.Item("Eliminar").Visible = True
        Else
            GrillaOperador.Columns.Item("Eliminar").Visible = False
        End If
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        buscar()
    End Sub

    Private Sub Boxbuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Boxbuscar.SelectedIndexChanged
        Boxbuscar.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        limpiar()
        mostrarUsuario()
    End Sub


    Private Sub GrillaOperador_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaOperador.CellClick
        TxtCedula.ReadOnly = True
        TxtID.Text = GrillaOperador.CurrentRow.Cells.Item(1).Value
        TextNombre.Text = GrillaOperador.CurrentRow.Cells.Item(2).Value
        TxtCedula.Text = GrillaOperador.CurrentRow.Cells.Item(3).Value
        TxtEdad.Text = GrillaOperador.CurrentRow.Cells.Item(4).Value
        BoxGenero.Text = GrillaOperador.CurrentRow.Cells.Item(5).Value
        TxTTelefono.Text = GrillaOperador.CurrentRow.Cells.Item(6).Value
        TxtCorreo.Text = GrillaOperador.CurrentRow.Cells.Item(7).Value
        TxTCompra.Text = GrillaOperador.CurrentRow.Cells.Item(8).Value
        BoxFre.Text = GrillaOperador.CurrentRow.Cells.Item(9).Value
        TxTDirecion.Text = GrillaOperador.CurrentRow.Cells.Item(10).Value
        Try

            BoxCiudad.Text = GrillaOperador.CurrentRow.Cells.Item(11).Value
        Catch ex As Exception

        End Try
    End Sub


    Sub eliminacion()
        Dim resultado As DialogResult
        resultado = MessageBox.Show("Desea Realmente Eliminar los Registros Seleccionados?", "Eliminando Usuarios", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If resultado = Windows.Forms.DialogResult.OK Then
            Try
                Dim sw As Boolean = False
                For Each row As DataGridViewRow In GrillaOperador.Rows
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            Dim a As String = "s"
            Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm() 'DIALOGO CAMARAS DISPONIBLES
            If CAMARAS.ShowDialog() = DialogResult.OK Then
                CAMARA = CAMARAS.VideoDevice 'CAMARA ELEGIDA
                AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR) ' EJECUTARA CADA VEZ QUE SE GENERE UNA IMAGEN
                CAMARA.Start() 'INICIA LA PRESENTACION DE IMAGENES EN EL PICTUREBOX
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
        PictureBox1.Image = PictureBox1.Image
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
            Try
                CAMARA.Stop()
            Catch ex As Exception

            End Try
            Catch ex As Exception
                ' Se ha producido un error.
                MessageBox.Show(ex.Message)

            End Try
    End Sub

    Private Sub Operador_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Try
            CAMARA.Stop()
            Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtID_TextChanged(sender As Object, e As EventArgs) Handles TxtID.TextChanged

    End Sub
End Class