Imports Microsoft.Reporting.WinForms

Public Class Frm_loteo
    Dim rema As New Remate
    Dim indice As Integer
    Dim llote As New loteo
    Dim remele As remates_mercaderia
    Dim lotee As lotes
    Dim lmandant As New lmandante

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Frm_loteo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            Me.StartPosition = FormStartPosition.CenterParent
            ''Dim x As Integer
            ''Dim y As Integer
            ''x = Screen.PrimaryScreen.WorkingArea.Width / 2 - 450
            ''y = Screen.PrimaryScreen.WorkingArea.Height / 2 - 250
            ''Me.Location = New Point(x, y)
            Me.Lbl_nlote.Text = String.Empty
            carga()
            For Each c As Control In Me.GroupBox2.Controls
                If TypeOf (c) Is Button Then
                    c.Enabled = False
                End If
            Next
            Txt_preciom.Text = 0
            Txt_unidades.Text = 1
            Txtbmandante.Visible = True

            With Dtg_lotes
                .AllowUserToAddRows = False
                .AllowDrop = False
                .AllowUserToOrderColumns = False
            End With


        Catch ex As Exception

        End Try
    End Sub


    Sub carga()
        Me.Cmb_remate.DataSource = rema.listaremates
        Me.Cmb_remate.DisplayMember = "codigo_remate"
        Me.Cmb_remate.ValueMember = "fecha_remate"

        Me.CmbMandantes.DataSource = lmandant.listamandantes()
        Me.CmbMandantes.DisplayMember = "razonsocial_mandante"
        Me.CmbMandantes.ValueMember = "razonsocial_mandante"

    End Sub

    Private Sub Cmb_remate_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_remate.SelectedIndexChanged
        Btn_agregar.Enabled = True
        Btn_sublote.Enabled = True
        Btn_papeles.Enabled = True
        Try
            remele = Nothing
            remele = New remates_mercaderia
            Txt_fecha.Text = Cmb_remate.SelectedValue
            remele = Cmb_remate.SelectedItem
            cargalote(remele.id_remate)
            Me.Txt_detalle_especie.Focus()
            Lbl_nlote.Text = llote.numlote(remele.id_remate)

        Catch ex As Exception

        End Try
    End Sub
    Sub cargalote(mle As Integer)
        Try

            Me.Dtg_lotes.DataSource = llote.listaloteo(mle)
            Me.Dtg_lotes.RowHeadersVisible = False

            For Each t In Me.Dtg_lotes.Columns
                t.visible = False
            Next

            Dim ancho As Integer
            ancho = Me.Dtg_lotes.Width
            Me.Dtg_lotes.Columns(2).Visible = True
            Me.Dtg_lotes.Columns(3).Visible = True
            Me.Dtg_lotes.Columns(4).Visible = True
            Me.Dtg_lotes.Columns(5).Visible = True
            Me.Dtg_lotes.Columns(7).Visible = True
            Me.Dtg_lotes.Columns(9).Visible = True
            Me.Dtg_lotes.Columns(17).Visible = True
            Me.Dtg_lotes.Columns(18).Visible = True
            Me.Dtg_lotes.Columns(19).Visible = True
            Me.Dtg_lotes.Columns(20).Visible = True
            Me.Dtg_lotes.Columns(22).Visible = True
            Me.Dtg_lotes.Columns(23).Visible = True


            With Me.Dtg_lotes

                .Columns(2).DisplayIndex = 1
                .Columns(3).DisplayIndex = 2
                .Columns(4).DisplayIndex = 3
                .Columns(5).DisplayIndex = 4
                .Columns(7).DisplayIndex = 8
                .Columns(9).DisplayIndex = 5
                .Columns(17).DisplayIndex = 6
                .Columns(18).DisplayIndex = 7
                .Columns(19).DisplayIndex = 9
                .Columns(20).DisplayIndex = 10
                .Columns(22).DisplayIndex = 11
                .Columns(23).DisplayIndex = 12




                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(2).Width = ancho * 0.05
                .Columns(3).Width = ancho * 0.05
                .Columns(4).Width = ancho * 0.2
                .Columns(5).Width = ancho * 0.08
                .Columns(7).Width = ancho * 0.18
                .Columns(9).Width = ancho * 0.08
                .Columns(17).Width = ancho * 0.05
                .Columns(18).Width = ancho * 0.05
                .Columns(19).Width = ancho * 0.09
                .Columns(20).Width = ancho * 0.05
                .Columns(22).Width = ancho * 0.05
                .Columns(23).Width = ancho * 0.05

                .Columns(2).HeaderText = "N° de Lote"
                .Columns(3).HeaderText = "Sub Lote"
                .Columns(4).HeaderText = "Descripcion"
                .Columns(5).HeaderText = "Unidades"
                .Columns(7).HeaderText = "Observaciones"
                .Columns(9).HeaderText = "Precio Minimo"
                .Columns(17).HeaderText = "Afecto a IVA"
                .Columns(18).HeaderText = "Afecto ILA"
                .Columns(19).HeaderText = "Valor Comercial"
                .Columns(20).HeaderText = "Mandante"
                .Columns(22).HeaderText = "Sucursal"
                .Columns(23).HeaderText = "Pasillo"
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Txt_detalle_especie_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_detalle_especie.TextChanged

    End Sub

    Private Sub Btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_agregar.Click
        Try
            If remele.tipo_remate = 2 Then

                lotee = Nothing
                lotee = New lotes
                lotee.nro_lote = llote.numlotemas(remele.id_remate)
                lotee.nro_unidades = 1

                Frm_loteovehi.ShowDialog()
                If Windows.Forms.DialogResult.OK Then
                    lotee.descripcion = Frm_loteovehi.descripcion
                    lotee.precio_minimo = Frm_loteovehi.preciom
                    lotee.observaciones = Frm_loteovehi.observacion
                    lotee.mandante = Frm_loteovehi.Mandante
                Else
                    lotee = Nothing
                    Exit Sub
                End If




                lotee.id_remate = remele.id_remate

                lotee.mandante = CmbMandantes.SelectedValue
                lotee.sucursal = Txt_sucursal.Text.ToUpper
                lotee.pasillo = Npasillo.Value
                lotee.mandante = CmbMandantes.SelectedValue
                lotee.valor_comercial = IIf(String.IsNullOrEmpty(TxtValorComercial.Text), 0, TxtValorComercial.Text)
                lotee.facturado = False
                lotee.liquidado = False
                lotee.nro_unidades_final = 0
                lotee.precio_unitario_final = 0
                lotee.precio_final = 0
                lotee.garantia = 0
                lotee.desistido = 0
                lotee.id_ejecutivo = 0


                If Chk_Afecto.Checked Then
                    lotee.afecto = True
                Else
                    lotee.afecto = False
                End If

                If Chk_ila.Checked Then
                    lotee.ila = True
                Else
                    lotee.ila = False
                End If

            Else
                lotee = Nothing
                lotee = New lotes

                lotee.nro_lote = llote.numlotemas(remele.id_remate)

                lotee.nro_unidades = CInt(Txt_unidades.Text)
                lotee.observaciones = Txt_obesrvacion.Text.ToUpper

                lotee.descripcion = Txt_detalle_especie.Text.ToUpper



                lotee.id_remate = remele.id_remate
                If String.IsNullOrEmpty(Txt_preciom.Text.ToString()) Then
                    lotee.precio_minimo = 0
                Else
                    lotee.precio_minimo = CLng(Txt_preciom.Text)
                End If

                lotee.mandante = CmbMandantes.SelectedValue
                lotee.sucursal = Txt_sucursal.Text.ToUpper


                lotee.facturado = False
                lotee.liquidado = False
                lotee.nro_unidades_final = 0
                lotee.precio_unitario_final = 0
                lotee.precio_final = 0
                lotee.garantia = 0
                lotee.desistido = 0
                lotee.id_ejecutivo = 0


                If Chk_Afecto.Checked Then
                    lotee.afecto = True
                Else
                    lotee.afecto = False
                End If

                If Chk_ila.Checked Then
                    lotee.ila = True
                Else
                    lotee.ila = False
                End If
            End If
            lotee.pasillo = Npasillo.Value
            llote.carga(lotee)
            For Each c As Control In Me.GroupBox1.Controls
                If TypeOf (c) Is TextBox Then
                    c.Text = String.Empty
                End If
            Next
            cargalote(remele.id_remate)
            Txt_preciom.Text = 0
            Txt_unidades.Text = 1
            Lbl_nlote.Text = llote.numlote(remele.id_remate)
            remele.numero_lotes = llote.numlote(remele.id_remate)

            rema.Updaterematenrolote(remele.id_remate, remele)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Txt_fecha_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_fecha.TextChanged

    End Sub

    Private Sub Dtg_lotes_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dtg_lotes.CellContentClick
        limpiar()

        Me.Btn_modificar.Enabled = True
        Me.Btn_eliminar.Enabled = True

        Try
            lotee = Nothing
            lotee = New lotes


            indice = Dtg_lotes.Rows(e.RowIndex).Cells(0).Value
            lotee = llote.loteForidl(Dtg_lotes.Rows(e.RowIndex).Cells(0).Value, remele.id_remate)

            Me.Txt_detalle_especie.Text = lotee.descripcion
            Me.Txt_obesrvacion.Text = lotee.observaciones

            Me.Txt_unidades.Text = lotee.nro_unidades
            Me.Txt_preciom.Text = CStr(lotee.precio_minimo)
            Me.Txtbmandante.Text = lotee.mandante

            Me.Txt_sucursal.Text = lotee.sucursal.ToString()

            Chk_Afecto.Checked = lotee.afecto
            Chk_ila.Checked = lotee.ila
            Me.TxtValorComercial.Text = lotee.valor_comercial.ToString()
            Me.Lbl_nlote.Text = lotee.nro_lote & " " & lotee.sub_lote
        Catch ex As Exception

        End Try

    End Sub

    Private Function DataGridViewCheckBoxCell() As DataGridViewCellStyle
        Throw New NotImplementedException
    End Function

    Private Function DataGridViewCheckBoxColumn() As String
        Throw New NotImplementedException
    End Function

    Private Sub Btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_eliminar.Click
        Try
            llote.borralote(lotee.id_lote)

        Catch ex As Exception

        End Try
        limpiar()
        Me.Btn_modificar.Enabled = False
        Me.Btn_eliminar.Enabled = False
        Me.Txt_detalle_especie.Focus()

    End Sub

    Private Sub Btn_modificar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_modificar.Click
        Dim lo As New lotes
        Try

            lo = Nothing
            lo = New lotes

            lo = (From lotesl In contex.lotes Where lotesl.id_lote = indice Select lotesl).FirstOrDefault()

            lo.descripcion = Txt_detalle_especie.Text.ToUpper
            lo.nro_unidades = CInt(Txt_unidades.Text)
            lo.precio_minimo = CInt(Txt_preciom.Text)

            lo.sucursal = Txt_sucursal.Text.ToUpper
            lo.observaciones = Txt_obesrvacion.Text.ToUpper
            lo.afecto = Chk_Afecto.Checked
            lo.ila = Chk_ila.Checked
            lo.pasillo = Npasillo.Value
            lo.mandante = CmbMandantes.SelectedValue

            'If CDbl(TxtValorComercial.Text) Then

            '    Throw New ArgumentException("Valor comercial no ingresado")
            'End If


            lo.valor_comercial = IIf(String.IsNullOrEmpty(TxtValorComercial.Text) And IsNumeric(TxtValorComercial.Text), 0, CInt(TxtValorComercial.Text))

            contex.ApplyCurrentValues("lotes", lo)
            contex.SaveChanges()
            contex.AcceptAllChanges()
            llote.Updatelote(lotee.nro_lote, lotee.id_remate, lotee)

        Catch ex As Exception
            lo.valor_comercial = 0
            contex.ApplyCurrentValues("lotes", lo)
            contex.SaveChanges()
            contex.AcceptAllChanges()
            'llote.Updatelote(lotee.nro_lote, lotee.id_remate, lotee)
        End Try
        limpiar()
        Frm_loteo_Load(Me, e)
        Cargalotes(remele.id_remate)
        Me.Refresh()

        Btn_agregar.Enabled = True
        Btn_sublote.Enabled = True
        Btn_papeles.Enabled = True
        Try
            cargalote(remele.id_remate)
            Me.Txt_detalle_especie.Focus()
            Lbl_nlote.Text = llote.numlote(remele.id_remate)

        Catch ex As Exception

        End Try



        Dim row As DataGridViewRow = Dtg_lotes.Rows.OfType(Of DataGridViewRow).FirstOrDefault(Function(pre) pre.Cells("id_lote").Value.Equals(lo.id_lote))
        If Not (IsNothing(row)) Then
            Dtg_lotes.CurrentCell = Dtg_lotes.Rows(row.Index).Cells(2)
        End If
        Me.Btn_modificar.Enabled = False
        Me.Btn_eliminar.Enabled = False
        Me.Txt_detalle_especie.Focus()
    End Sub

    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
    Sub limpiar()
        For Each c As Control In Me.GroupBox1.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next
        Lbl_nlote.Text = String.Empty
    End Sub
    Private Sub Btn_limpiar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_limpiar.Click
        limpiar()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Btn_sublote.Click
        Try
            Frm_sublote.lote = 0
            Frm_sublote.sublote = String.Empty
            lotee = Nothing
            lotee = New lotes

            Frm_sublote.ShowDialog()
            If Windows.Forms.DialogResult.OK Then
                lotee.nro_lote = Frm_sublote.lote
                lotee.sub_lote = Frm_sublote.sublote

            Else
                MsgBox("No se creara el sublote", MsgBoxStyle.Critical, "Sub Lote")
                limpiar()
                Me.Txt_detalle_especie.Focus()
                Exit Sub

            End If

            lotee.nro_unidades = CInt(Txt_unidades.Text)
            lotee.observaciones = Txt_obesrvacion.Text.ToUpper
            lotee.descripcion = Txt_detalle_especie.Text.ToUpper
            lotee.id_remate = remele.id_remate
            lotee.precio_minimo = Txt_preciom.Text
            lotee.mandante = CmbMandantes.SelectedValue
            lotee.pasillo = Npasillo.Value

            lotee.facturado = False
            lotee.liquidado = False
            lotee.nro_unidades_final = 0
            lotee.precio_unitario_final = 0
            lotee.precio_final = 0
            lotee.garantia = 0
            lotee.desistido = 0
            lotee.id_ejecutivo = 0


            If Chk_Afecto.Checked Then
                lotee.afecto = True
            Else
                lotee.afecto = False
            End If

            If Chk_ila.Checked Then
                lotee.ila = True
            Else
                lotee.ila = False
            End If
            llote.cargasb(lotee)
            For Each c As Control In Me.GroupBox1.Controls
                If TypeOf (c) Is TextBox Then
                    c.Text = String.Empty
                End If
            Next
            cargalote(remele.id_remate)
            Txt_preciom.Text = 0
            Txt_unidades.Text = 1
            Lbl_nlote.Text = llote.numlote(remele.id_remate)
            remele.numero_lotes = llote.numlote(remele.id_remate)
            rema.Updaterematenrolote(remele.id_remate, remele)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click


    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Btn_buscar.Click

    End Sub

    Private Sub Btn_papeles_Click(sender As System.Object, e As System.EventArgs) Handles Btn_papeles.Click

        Try
            If remele IsNot Nothing Then
                Dim llote As New loteo
                Dim papeleslst As New List(Of lotespapeles)()

                papeleslst = Cargalotes(remele.id_remate)

                Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.papeles.rdlc"
                Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()
                Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("rloteo", papeleslst))
                Frm_muestrareportes.ReportViewer1.RefreshReport()

                Frm_muestrareportes.Show()
            Else
                MsgBox("Debe elegir un remate para generar los papeles", MsgBoxStyle.Critical, "Loteo")
            End If


        Catch ex As Exception

        End Try


    End Sub

    Private Sub Txt_unidades_MouseHover(sender As System.Object, e As System.EventArgs) Handles Txt_unidades.MouseHover
        Txt_unidades.Text = String.Empty
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

    End Sub

    'Private Sub Txtbmandante_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txtbmandante.TextChanged

    '    If Txtbmandante.TextLength > 3 Then
    '        Me.CmbMandantes.DataSource = Nothing
    '        Me.CmbMandantes.DataSource = lmandant.listamandantes(Me.Txtbmandante.Text)
    '        Me.CmbMandantes.DisplayMember = "razonsocial_mandante"
    '        Me.CmbMandantes.ValueMember = "razonsocial_mandante"
    '        Me.CmbMandantes.Refresh()
    '    Else
    '        Me.CmbMandantes.DataSource = Nothing
    '        Me.CmbMandantes.DataSource = lmandant.listamandantes()
    '        Me.CmbMandantes.DisplayMember = "razonsocial_mandante"
    '        Me.CmbMandantes.ValueMember = "razonsocial_mandante"
    '        Me.CmbMandantes.Refresh()

    '    End If

    'End Sub

    Private Sub CmbMandantes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbMandantes.SelectedIndexChanged

    End Sub

    Private Sub CmbMandantes_Click(sender As System.Object, e As System.EventArgs) Handles CmbMandantes.Click
        Txtbmandante.Text = Me.CmbMandantes.SelectedValue.ToString()
    End Sub

    Private Sub Txtbmandante_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txtbmandante.KeyPress
        'buscar
        If Txtbmandante.TextLength > 3 Then
            Me.CmbMandantes.DataSource = Nothing
            Me.CmbMandantes.DataSource = lmandant.listamandantes(Me.Txtbmandante.Text)
            Me.CmbMandantes.DisplayMember = "razonsocial_mandante"
            Me.CmbMandantes.ValueMember = "razonsocial_mandante"
            Me.CmbMandantes.Refresh()
        Else
            Me.CmbMandantes.DataSource = Nothing
            Me.CmbMandantes.DataSource = lmandant.listamandantes()
            Me.CmbMandantes.DisplayMember = "razonsocial_mandante"
            Me.CmbMandantes.ValueMember = "razonsocial_mandante"
            Me.CmbMandantes.Refresh()
        End If

    End Sub
    Private Sub Txtbmandante_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txtbmandante.TextChanged

    End Sub

End Class