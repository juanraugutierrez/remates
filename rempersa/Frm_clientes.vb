Public Class Frm_clientes
    Public contex As New persaEntities11
    Dim cli As New clientes
    Dim usecli As New cliente
    Dim id_clien As Integer
    Public formulario As Object
    Dim comuna As New ocomuna
    Dim comu As String


    Private Sub Frm_clientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carga()
        For Each c As Control In Me.GroupBox1.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next
        Txt_buscar.Text = String.Empty
    End Sub

    Sub carga()
        Me.dtg_clientes.DataSource = usecli.listaclientes
        Me.dtg_clientes.RowHeadersVisible = False


        Me.Cmb_region.DataSource = usecli.listaregiones
        Me.Cmb_region.DisplayMember = "region"
        Me.Cmb_region.ValueMember = "id_region"

    End Sub



    Private Sub Btn_asignar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_asignar.Click
        formulario.Txt_direccion.Text = Split(Me.Txt_direccion.Text, ",")(0).ToString()
        formulario.Txt_razonsocial.Text = Me.Txt_rzonsocial.Text
        formulario.Txt_rut.Text = Me.Txt_rut.Text
        formulario.Txt_giro.Text = Me.Txt_giro.Text
        'Dim comu As New comunas
        'comu = Cmb_comuna.SelectedItem
        formulario.id_comuna = cli.id_comuna
        formulario.Txt_Comuna.Text = comu
        formulario.id_clien = id_clien
        DialogResult = DialogResult.OK
        Return
    End Sub

    Private Sub Btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_agregar.Click
        Dim regi As New regiones
        Dim rt As New rut
        regi = Cmb_region.SelectedItem
        Dim comu As New comunas
        comu = Cmb_comuna.SelectedItem
        cli = Nothing
        cli = New clientes
        cli.razon_social = Txt_rzonsocial.Text.ToUpper
        cli.direccion = Txt_direccion.Text.ToUpper & " " & comu.comuna.ToUpper
        cli.email = Txt_email.Text.ToLower
        cli.giro = Txt_giro.Text.ToUpper
        cli.rut = rt.formato1(Txt_rut.Text.ToUpper())
        cli.nombre_replegal = Txt_replegal.Text.ToUpper
        cli.estado_cliente = 1
        cli.id_comuna = comu.id_comuna
        If Not (String.IsNullOrEmpty(Txt_telefono.Text)) Then
            cli.telefono = Txt_telefono.Text
        End If


        usecli.carga(cli)
        carga()

        For Each t In Me.GroupBox1.Controls
            If TypeOf (t) Is TextBox Then
                t.Text = String.Empty
            End If
        Next

    End Sub

    Private Sub Cmb_region_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_region.SelectedIndexChanged

        Dim regi As New regiones
        regi = Cmb_region.SelectedItem
        Try
            Me.Cmb_comuna.DataSource = usecli.listacomunas(regi.id_region)
            Me.Cmb_comuna.DisplayMember = "comuna"
            Me.Cmb_comuna.ValueMember = "id_comuna"

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtg_clientes_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtg_clientes.CellContentClick
        Try
            Dim bu As Integer = 0
            Cmb_region.SelectedIndex = Nothing
            Cmb_comuna.SelectedIndex = Nothing

            id_clien = dtg_clientes.Item(0, e.RowIndex).Value
            Me.Txt_rzonsocial.Text = dtg_clientes.Item(1, e.RowIndex).Value
            Me.Txt_direccion.Text = dtg_clientes.Item(2, e.RowIndex).Value.ToString().ToUpper
            Try
                Me.Txt_email.Text = dtg_clientes.Item(7, e.RowIndex).Value.ToString().ToLower()

            Catch ex As Exception
                Me.Txt_email.Text = String.Empty
            End Try
            Try
                Me.Txt_telefono.Text = dtg_clientes.Item(5, e.RowIndex).Value.ToString().ToUpper

            Catch ex As Exception
                Me.Txt_telefono.Text = String.Empty
            End Try

            Me.Txt_giro.Text = dtg_clientes.Item(4, e.RowIndex).Value.ToString().ToUpper
            Me.Txt_rut.Text = dtg_clientes.Item(11, e.RowIndex).Value.ToString().ToUpper
            bu = CInt(dtg_clientes.Item(3, e.RowIndex).Value.ToString())
            Cmb_region.SelectedIndex = Cmb_region.FindStringExact(comuna.listaregiontext(bu))
            Cmb_comuna.SelectedIndex = Cmb_comuna.FindStringExact(comuna.listacomunatext(CInt(dtg_clientes.Item(3, e.RowIndex).Value.ToString())))

            Cmb_comuna.Refresh()
            Cmb_region.Refresh()

            'busca(dtg_clientes.Item(3, e.RowIndex).Value)

            Cmb_comuna.Refresh()

            cli = usecli.buscarcliente(id_clien)
            comu = comuna.listacomunatext(cli.id_comuna)


        Catch ex As Exception

        End Try


    End Sub



    Sub busca(valor As Integer)


        For ii = 1 To Cmb_region.Items.Count
            Cmb_region.SelectedIndex = ii - 1
            For i = 1 To Cmb_comuna.Items.Count

                Cmb_comuna.SelectedIndex = i - 1
                If Cmb_comuna.SelectedValue = valor Then
                    Exit Sub
                End If
            Next i
        Next ii

    End Sub

    Private Sub Txt_buscar_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_buscar.KeyPress
        Me.dtg_clientes.DataSource = Nothing
        Try
            If RdbRut.Checked Then
                Me.dtg_clientes.DataSource = usecli.buscarclienterutr(Txt_buscar.Text)
            End If
        Catch ex As Exception

        End Try
        Try
            If RdbNombre.Checked Then
                Me.dtg_clientes.DataSource = usecli.buscarclienten(Txt_buscar.Text)
            End If
        Catch ex As Exception

        End Try


        Me.dtg_clientes.Refresh()
    End Sub



    Private Sub Btn_buscar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_buscar.Click
        If RdbRut.Checked Then
            Me.dtg_clientes.DataSource = Nothing
            Me.dtg_clientes.DataSource = usecli.buscarclienterutr(Txt_buscar.Text)
            Me.dtg_clientes.Refresh()
        ElseIf RdbNombre.Checked Then
            Me.dtg_clientes.DataSource = Nothing
            Me.dtg_clientes.DataSource = usecli.buscarclienten(Txt_buscar.Text)
            Me.dtg_clientes.Refresh()
        End If

    End Sub



    Private Sub Txt_rut_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_rut.KeyPress

        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) And Not (AscW(e.KeyChar) = 45) And Not (AscW(e.KeyChar) = 75) And Not (AscW(e.KeyChar) = 107) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            Try
                Dim rt As New rut
                If Not (rt.validarRut(rt.formato1(Txt_rut.Text))) Then
                    MsgBox("El rut ingresado no es valido", MsgBoxStyle.Critical, "Valiacion de Rut")
                    Txt_rut.Text = String.Empty
                    Me.Txt_rut.Focus()
                    Exit Sub
                Else
                    Txt_rut.Text = rt.formato(Txt_rut.Text)
                End If
            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub Btn_modificar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_modificar.Click
        Dim regi As New regiones
        regi = Cmb_region.SelectedItem
        Dim comu As New comunas
        comu = Cmb_comuna.SelectedItem
        cli.razon_social = Txt_rzonsocial.Text.ToUpper
        cli.direccion = Txt_direccion.Text.ToUpper & " " & comu.comuna.ToUpper
        cli.email = Txt_email.Text.ToLower
        cli.giro = Txt_giro.Text.ToUpper
        cli.rut = Txt_rut.Text
        cli.nombre_replegal = Txt_replegal.Text.ToUpper
        cli.estado_cliente = 1
        cli.id_comuna = comu.id_comuna
        If Not (IsNothing(Txt_telefono.Text)) Then
            cli.telefono = Txt_telefono.Text
        End If


        usecli.Updatelote(cli)
        carga()

        For Each t In Me.GroupBox1.Controls
            If TypeOf (t) Is TextBox Then
                t.Text = String.Empty
            End If
        Next

    End Sub

    Private Sub Btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_eliminar.Click

    End Sub


    Sub solodigitos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If (e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(44) Or e.KeyChar = ChrW(Keys.Back) Or e.KeyChar = ChrW(Keys.Delete) Or e.KeyChar = ChrW(Keys.Left) Or e.KeyChar = ChrW(Keys.Right) Or IsNumeric(e.KeyChar)) Then
            If (e.KeyChar = "," And sender.Text.IndexOf(",") > 0) Then
                e.Handled = True
            End If
            e.Handled = False
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If

    End Sub

    Sub sololetras(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsLetterOrDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If

    End Sub
    Private Sub RdbRut_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdbRut.CheckedChanged
        If RdbRut.Checked Then
            RemoveHandler Txt_buscar.KeyPress, AddressOf Txt_buscar_KeyPress
            RemoveHandler Txt_buscar.KeyPress, AddressOf sololetras
            Me.Txt_rut.Text = String.Empty
            limpiar()
            carga()
            AddHandler Txt_buscar.KeyPress, AddressOf solodigitos
            AddHandler Txt_buscar.KeyPress, AddressOf Txt_buscar_KeyPress
            Txt_buscar.Focus()
        End If

    End Sub

    Sub limpiar()
        For Each ctrl In Me.GroupBox1.Controls
            If (TypeOf (ctrl) Is TextBox) Then
                Dim miTextBox As TextBox
                miTextBox = CType(ctrl, TextBox)
                miTextBox.Text = String.Empty
            End If
        Next
        For Each ctrl In Me.GroupBox2.Controls
            If (TypeOf (ctrl) Is TextBox) Then
                Dim miTextBox As TextBox
                miTextBox = CType(ctrl, TextBox)
                miTextBox.Text = String.Empty
            End If
        Next
    End Sub
    Private Sub RdbNombre_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdbNombre.CheckedChanged

        If RdbNombre.Checked Then
            RemoveHandler Txt_buscar.KeyPress, AddressOf Txt_buscar_KeyPress
            RemoveHandler Txt_buscar.KeyPress, AddressOf solodigitos
            Me.Txt_rut.Text = String.Empty
            limpiar()
            carga()
            RemoveHandler Txt_buscar.KeyPress, AddressOf sololetras
            AddHandler Txt_buscar.KeyPress, AddressOf Txt_buscar_KeyPress
            Txt_buscar.Focus()
        End If
    End Sub


    Private Sub Txt_buscar_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Txt_buscar.KeyDown
        Me.dtg_clientes.DataSource = Nothing
        If RdbRut.Checked Then
            Me.dtg_clientes.DataSource = usecli.buscarclienterutr(Txt_buscar.Text)
        End If
        If RdbNombre.Checked Then
            Me.dtg_clientes.DataSource = usecli.buscarclienten(Txt_buscar.Text)
        End If

        Me.dtg_clientes.Refresh()
    End Sub


End Class