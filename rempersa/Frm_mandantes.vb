Public Class Frm_mandantes
    Public contex As New persaEntities11
    Dim manda As New lmandante
    Dim ma As New mandantes
    Dim usecli As New cliente
    Dim id_clien As Integer
    Public formulario As Object
    Dim comuna As New ocomuna
    Dim comu As String


    Private Sub Frm_mandantes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        carga()
        For Each c As Control In Me.GroupBox1.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next
    End Sub

    Sub carga()
        Me.dtg_clientes.DataSource = manda.listamandantes
        Me.dtg_clientes.RowHeadersVisible = False

        Me.dtg_clientes.Columns(4).Visible = False



        Me.Cmb_region.DataSource = manda.listaregiones
        Me.Cmb_region.DisplayMember = "region"
        Me.Cmb_region.ValueMember = "id_region"

    End Sub



    Private Sub Btn_asignar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_asignar.Click
        formulario.Txt_direccion.text = Split(Me.Txt_direccion.Text, ",")(0).ToString()
        formulario.Txt_razonsocial.Text = Me.Txt_rzonsocial.Text
        formulario.Txt_rut.Text = Me.Txt_rut.Text
        formulario.Txt_giro.Text = Me.Txt_giro.Text
        If formulario.Txt_giro.Text.ToString().Length > 40 Then
            formulario.Txt_giro.Text.ToString.Substring(0, 40)
        End If

        comu = comuna.listacomunatext(ma.id_comuna)

        formulario.Txt_Comuna.Text = comu
        'formulario = id_manda
        DialogResult = DialogResult.OK
        Return
    End Sub

    Private Sub Btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_agregar.Click
        Dim rt As New rut
        Dim regi As New regiones
        regi = Cmb_region.SelectedItem
        Dim comu As New comunas
        comu = Cmb_comuna.SelectedItem
        ma = Nothing
        ma = New mandantes
        ma.razonsocial_mandante = Txt_rzonsocial.Text.ToUpper
        ma.direccion_mandante = Txt_direccion.Text.ToUpper & " " & comu.comuna.ToUpper
        ma.email = Txt_email.Text.ToLower
        ma.giro = Txt_giro.Text.ToUpper
        ma.rut_mandante = rt.formato1(Txt_rut.Text)
        ma.Replegal_mandante = Txt_replegal.Text.ToUpper
        ma.nrocontratos_mandante = 1
        ma.nroliquidaciones_mandante = 0
        ma.mandato = Chk_madanto.Checked
        ma.id_comuna = comu.id_comuna
        ma.repDireccion_mandante = String.Empty

        If Txt_telefono.Text IsNot Nothing Then
            ma.telefono_mandante = Txt_telefono.Text
        Else
            ma.telefono_mandante = String.Empty
        End If
        ma.vigente = Chk_vigente.Checked
        manda.carga(ma)
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
            Dim rt As New rut
            id_clien = dtg_clientes.Item(0, e.RowIndex).Value

            ma = manda.buscarmandante(id_clien)

            Me.Txt_rzonsocial.Text = ma.razonsocial_mandante
            Me.Txt_direccion.Text = ma.direccion_mandante
            Me.Txt_email.Text = ma.email
            Me.Txt_giro.Text = ma.giro
            Me.Txt_rut.Text = rt.formato(ma.rut_mandante)
            Me.Txt_telefono.Text = ma.telefono_mandante
            Me.Txt_replegal.Text = ma.Replegal_mandante

            Me.Chk_madanto.Checked = ma.mandato
            Me.Chk_vigente.Checked = ma.vigente

            '***************
            Dim bu As Integer = 0
            bu = CInt(dtg_clientes.Item(4, e.RowIndex).Value.ToString())
            Cmb_region.SelectedIndex = Cmb_region.FindStringExact(comuna.listaregiontext(bu))
            Cmb_comuna.SelectedIndex = Cmb_comuna.FindStringExact(comuna.listacomunatext(CInt(dtg_clientes.Item(4, e.RowIndex).Value.ToString())))


            '***************


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

        '*********************************

        Me.dtg_clientes.DataSource = Nothing
        Try
            If RdbRut.Checked Then
                Me.dtg_clientes.DataSource = manda.buscarmandanterutr(Txt_buscar.Text)
            End If
        Catch ex As Exception

        End Try
        Try
            If RdbNombre.Checked Then

                Me.dtg_clientes.DataSource = manda.buscarmandanten(Txt_buscar.Text)
            End If
        Catch ex As Exception

        End Try


        Me.dtg_clientes.Refresh()
        '*****************************************

    End Sub



    Private Sub Btn_buscar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_buscar.Click
        Me.dtg_clientes.DataSource = Nothing
        Try
            If RdbRut.Checked Then
                Me.dtg_clientes.DataSource = manda.buscarmandanterutr(Txt_buscar.Text)
                Me.dtg_clientes.Columns(4).Visible = False
            End If
        Catch ex As Exception

        End Try
        Try
            If RdbNombre.Checked Then

                Me.dtg_clientes.DataSource = manda.buscarmandanten(Txt_buscar.Text)
                Me.dtg_clientes.Columns(4).Visible = False
            End If
        Catch ex As Exception

        End Try


        Me.dtg_clientes.Refresh()
    End Sub


    Private Sub Txt_rut_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_rut.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) And Not (AscW(e.KeyChar) = 45) And Not (AscW(e.KeyChar) = 75) And Not (AscW(e.KeyChar) = 107) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            Try
                Dim rt As New rut
                If Not (rt.validarRut(Txt_rut.Text)) Then
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

    Private Sub Btn_limpiar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_limpiar.Click
        For Each t In Me.GroupBox1.Controls
            If TypeOf (t) Is TextBox Then
                t.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub Btn_modificar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_modificar.Click
        ma = Nothing
        Dim rt As New rut
        Dim regi As New regiones
        regi = Cmb_region.SelectedItem
        Dim comu As New comunas
        comu = Cmb_comuna.SelectedItem

        ma = New mandantes
        ma.id_mandante = id_clien

        ma.razonsocial_mandante = Txt_rzonsocial.Text.ToUpper
        ma.direccion_mandante = Txt_direccion.Text.ToUpper & " " & comu.comuna.ToUpper
        ma.email = Txt_email.Text.ToLower
        ma.giro = Txt_giro.Text.ToUpper
        ma.rut_mandante = rt.formato1(Txt_rut.Text)
        ma.Replegal_mandante = Txt_replegal.Text.ToUpper
        ma.nrocontratos_mandante = 1
        ma.nroliquidaciones_mandante = 0
        ma.mandato = Chk_madanto.Checked
        ma.id_comuna = comu.id_comuna
        ma.repDireccion_mandante = String.Empty
        ma.telefono_mandante = Txt_telefono.Text

        If Txt_telefono.Text IsNot Nothing Then
            ma.telefono_mandante = Txt_telefono.Text
        Else
            ma.telefono_mandante = String.Empty
        End If
        ma.vigente = Chk_vigente.Checked

        manda.Updatemandante(ma)

        For Each t In Me.GroupBox1.Controls
            If TypeOf (t) Is TextBox Then
                t.Text = String.Empty
            End If
        Next

        carga()

    End Sub

    Private Sub Btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_eliminar.Click
        If id_clien > 0 Then
            Me.Cursor = Cursors.WaitCursor
            manda.borramandante(id_clien)
            Me.Cursor = Cursors.Default
            carga()
        Else
            MsgBox("Debe Elegir un mandante", MsgBoxStyle.Critical, "Mandantes")
        End If
        For Each t In Me.GroupBox1.Controls
            If TypeOf (t) Is TextBox Then
                t.Text = String.Empty
            End If
        Next
        Exit Sub
    End Sub

    Private Sub Txt_rut_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_rut.TextChanged

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

    Private Sub RdbNombre_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RdbNombre.CheckedChanged
        If RdbNombre.Checked Then
            RemoveHandler Txt_buscar.KeyPress, AddressOf Txt_buscar_KeyPress
            RemoveHandler Txt_buscar.KeyPress, AddressOf solodigitos
            Me.Txt_rut.Text = String.Empty
            limpiar()
            carga()
            AddHandler Txt_buscar.KeyPress, AddressOf sololetras
            AddHandler Txt_buscar.KeyPress, AddressOf Txt_buscar_KeyPress
            Txt_buscar.Focus()
        End If
    End Sub

    Private Sub Txt_buscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_buscar.TextChanged

    End Sub

    Private Sub Txt_buscar_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles Txt_buscar.KeyDown
        Me.dtg_clientes.DataSource = Nothing
        If RdbRut.Checked Then
            Me.dtg_clientes.DataSource = manda.buscarmandanterutr(Txt_buscar.Text)
        End If
        If RdbNombre.Checked Then
            Me.dtg_clientes.DataSource = manda.buscarmandanten(Txt_buscar.Text)
            Me.dtg_clientes.Refresh()
        End If

        Me.dtg_clientes.Columns(4).Visible = False
        Me.dtg_clientes.Refresh()
    End Sub
End Class