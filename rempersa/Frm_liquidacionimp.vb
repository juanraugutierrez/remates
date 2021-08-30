Imports Microsoft.Reporting.WinForms



Public Class Frm_liquidacionimp
    Dim resu As New resolucion
    Dim factu As New factura
    Dim manda As New lmandante
    Public contex As New persaEntities11
    Public mandant As New mandantes
    Dim remate As Integer
    Dim neto As Long
    Dim iva As Long
    Dim ila As Long
    Dim comision As Long
    Dim cargo As Long
    Dim total As Long
    Dim garantia As Long
    Dim liquido As Long
    Dim fletes As Long
    Dim publicidad As Long
    Dim comuna As New ocomuna
    Dim lottes As New List(Of lotesliquidacionview)

    Dim impues_recaudado As Long
    Dim porcentaje As Integer = 10

    Dim cliente As String




    Private Sub Frm_facturaimp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        resu.ajustarResolucion(Me)
        Try
            Me.WindowState = FormWindowState.Maximized
            carga()
            cliente = String.Empty
            Me.Txt_porcentaje.Text = porcentaje
        Catch ex As Exception

        End Try
        DataGridView1.Visible = True

    End Sub

    Sub carga()
        Me.Cmb_remates.DataSource = factu.lremates()
        Me.Cmb_remates.DisplayMember = "id_remate"
        Me.Cmb_remates.ValueMember = "Remate"

        Me.Lst_clientes.DataSource = factu.listamandantes(remate, Chk_afecto.Checked)
        Me.Lst_clientes.DisplayMember = "cod_mandante"
        'Me.Cmb_cliente.ValueMember = "Cliente"
    End Sub




    Private Sub Cmb_remates_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_remates.SelectedIndexChanged


        Try
            Me.Lbl_fecharema.Text = factu.fremates(Cmb_remates.SelectedValue.ToString)
            Me.Lbl_tiporema.Text = factu.tremates1(Cmb_remates.SelectedValue.ToString)
            remate = factu.lremate(Cmb_remates.SelectedValue)



            Me.Lst_clientes.ClearSelected()
            Me.Lst_clientes.DataSource = Nothing
            Me.Lst_clientes.Refresh()


            Me.Lst_clientes.DataSource = factu.listamandantes(remate, Chk_afecto.Checked)
            Me.Lst_clientes.DisplayMember = "Cod_mandante"
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Lst_clientes_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Lst_clientes.SelectedIndexChanged

        impues_recaudado = 0
        neto = 0
        ila = 0

        liquido = 0
        comision = 0


        For Each c As Control In Me.GroupBox1.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next

        Try
            Dim lista As New Object
            lottes = Nothing
            lottes = New List(Of lotesliquidacionview)
            cliente = Lst_clientes.SelectedValue

            Dim lotesliq As Object

            If Rdb_remate.Checked Then
                lotesliq = factu.lotliquidables(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked)
            Else
                lotesliq = factu.lotliquidables(Lst_clientes.SelectedValue, Chk_afecto.Checked)
            End If





            For Each t In lotesliq
                Dim ll As New lotesliquidacionview
                ll.afecto = t.afecto
                ll.facturado = t.facturado
                ll.idlote = t.id_lote
                ll.nrolot = t.nro_lote
                ll.nrosblote = t.sub_lote
                ll.descripcion = t.descripcion
                ll.Punitario = t.precio_unitario_final
                ll.Total = t.precio_final
                ll.unidades = t.nro_unidades_final
                ll.fecha = Now
                ll.mandante = t.mandante
                ll.sucursal = t.sucursal
                ll.ila = t.ila
                lottes.Add(ll)
                ll = Nothing
            Next

            Dim sucu As New sucursalesview()

            Dim va = (From p In lottes
                      Where p.sucursal <> ""
                      Group By p.mandante, p.sucursal, p.liquidado
                      Into g = Group
                      Select New With {.mandante = mandante, .sucursal = sucursal, .total = g.Sum(Function(i) i.Total), .liquidado = liquidado}).ToList







            Me.DataGridView1.DataSource = va
            DataGridView1.Refresh()
            DataGridView1.RowHeadersVisible = False


            Me.Dtg_lotes.DataSource = lottes


            Me.Dtg_lotes.RowHeadersVisible = False

            For Each t In Me.Dtg_lotes.Columns
                t.visible = False
            Next




            If Chk_afecto.Checked Then
                lottes.RemoveAll(Function(p As lotesliquidacionview) p.afecto = False)
            Else
                lottes.RemoveAll(Function(p As lotesliquidacionview) p.afecto = True)
            End If


            neto = 0

            For Each t In lottes
                neto = neto + t.Total
                If t.ila Then
                    ila += Math.Ceiling(t.Total * 0.205)
                End If
            Next








            comision = neto * porcentaje
            comision = comision / 100
            comision = Math.Ceiling(comision)

            If Chk_afecto.Checked Then
                impues_recaudado = Math.Ceiling(neto * 0.19)
                iva = Math.Ceiling((comision) * 0.19)
            Else
                impues_recaudado = 0
                iva = Math.Ceiling((comision) * 0.19)
            End If



            liquido = (neto + impues_recaudado + ila) - (comision + iva)


            Dim ancho As Integer
            ancho = Me.Dtg_lotes.Width
            Me.Dtg_lotes.Columns(3).Visible = True
            Me.Dtg_lotes.Columns(4).Visible = True
            Me.Dtg_lotes.Columns(5).Visible = True
            Me.Dtg_lotes.Columns(6).Visible = True
            Me.Dtg_lotes.Columns(7).Visible = True
            Me.Dtg_lotes.Columns(8).Visible = True
            Me.Dtg_lotes.Columns(9).Visible = True
            Me.Dtg_lotes.Columns(10).Visible = True





            'With Me.Dtg_lotes
            '    .Columns(2).DisplayIndex = 0
            '    .Columns(3).DisplayIndex = 1
            '    .Columns(4).DisplayIndex = 2
            '    .Columns(14).DisplayIndex = 3
            '    .Columns(15).DisplayIndex = 4
            '    .Columns(16).DisplayIndex = 5
            '    .Columns(21).DisplayIndex = 6


            '.Columns(15).DefaultCellStyle.Format = "$ #,##0"
            '.Columns(16).DefaultCellStyle.Format = "$ #,##0"
            '.Columns(21).DefaultCellStyle.Format = "$ #,##0"

            '.Columns(14).DefaultCellStyle.Format = "#,##0"

            '.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            '.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            '.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



            '.Columns(2).Width = ancho * 0.08
            '.Columns(3).Width = ancho * 0.08
            '.Columns(4).Width = ancho * 0.4
            '.Columns(14).Width = ancho * 0.089
            '.Columns(15).Width = ancho * 0.089
            '.Columns(16).Width = ancho * 0.1
            '.Columns(21).Width = ancho * 0.1



            '.Columns(2).HeaderText = "N° Lote"
            '.Columns(3).HeaderText = "Sub Lote"
            '.Columns(4).HeaderText = "Especie"
            '.Columns(14).HeaderText = "Unidades"
            '.Columns(15).HeaderText = "V. Unitario"
            '.Columns(16).HeaderText = "V. Total"
            '.Columns(21).HeaderText = "Garantia"



            'End With

            'Dim chk As New DataGridViewCheckBoxColumn()

            'chk.HeaderText = "Desite"
            'chk.Name = "chk"
            'chk.TrueValue = True
            'Me.Dtg_lotes.Columns.Add(chk)


            Me.Txt_neto.TextAlign = HorizontalAlignment.Right

            Me.Txt_neto.Text = Format(neto, "$ #,##0")
            Me.Txt_iva.Text = Format(iva, "$ #,##0")
            Me.Txt_ila.Text = Format(ila, "$ #,##0")
            Me.Txt_comision.Text = Format(comision, "$ #,##0")
            Me.Txt_impuestorec.Text = Format(impues_recaudado, "$ #,##0")


            Me.Txt_liquido.Text = Format(liquido, "$ #,##0")

            Me.Txt_lotes.Text = lottes.Count

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim remtipo As New Remate
        Me.Cursor = Cursors.WaitCursor
        Dim Invoice As New List(Of EFactura)()
        Dim Detail As New List(Of EArticulol)()
        Dim factur As New EFactura

        factur.Razonsocial = Txt_razonsocial.Text.ToUpper
        factur.Rut = Txt_rut.Text.ToUpper
        factur.Direccion = Txt_direccion.Text.ToUpper
        factur.Comuna = Txt_Comuna.Text.ToUpper
        factur.totaltexto = "SON :" & Num2Text(liquido).ToUpper & " PESOS"
        factur.Giro = Txt_giro.Text
        Try
            factur.NumeroFactura = Txt_nrofactura.Text.ToUpper
        Catch ex As Exception
            factur.NumeroFactura = 1
        End Try

        factur.FechaFacturacion = Now.Day & "               " & mesliteral(Now.Month) & "                                             " & Now.Year.ToString().Substring(2, 2)


        factur.Neto = CDec(neto)
        factur.impuesto_recauda = CDec(impues_recaudado)
        factur.comision = CDec(comision)
        factur.Publicidad = CDec(publicidad)
        factur.Fletes = CDec(fletes)

        factur.Iva = CDec(iva)
        factur.Ila = CDec(ila)
        factur.Liquido = CDec(liquido)



        Invoice.Add(factur)

        Dim mm As New liquidacion
        mm.comision = CDec(comision)
        mm.id_mandante = mandant.id_mandante
        mm.tasa_comision = comision / neto
        mm.mto_neto = neto
        mm.mto_impreacudado = impues_recaudado
        mm.iva = iva
        mm.mto_ila = ila
        mm.liquido = liquido
        mm.nro_liquidacion = CInt(Txt_nrofactura.Text)
        mm.nro_lotes = CDec(Txt_lotes.Text)
        mm.publicidad = publicidad
        mm.flete = fletes
        mm.fecha = Now.ToShortDateString & " " & Now.ToLongTimeString
        Dim liqu As New liquidaciones
        Dim id_Factu As Integer = liqu.carga(mm)

        Dim pp As New detalle_liquidacion



        For Each t In lottes
            pp = Nothing
            pp = New detalle_liquidacion

            pp.id_liquidacion = id_Factu
            pp.id_lote = t.idlote
            pp.nro_lote = t.nrolot
            pp.sub_lote = t.nrosblote
            pp.descripcion = t.descripcion
            pp.precio_unitario = t.Punitario
            pp.precio_final = t.Total
            pp.sucursal = t.sucursal
            pp.mandante = t.mandante
            pp.unidades = t.unidades
            pp.afecto = t.afecto
            liqu.cargadetalle(pp)


        Next





        If Chk_detalle.Checked Then

            If remtipo.rematetipo(remate) = 2 Then

                Detail = CargalArticulos(lottes, cliente, False, Chk_afecto.Checked, True)

            Else
                Detail = CargalArticulos(lottes, cliente, Me.Chk_afecto.Checked)
            End If

        End If
        Dim parameters1(3) As ReportParameter

        parameters1(0) = New ReportParameter("remate", remate)
        parameters1(1) = New ReportParameter("fecha", Lbl_fecharema.Text)
        parameters1(2) = New ReportParameter("Mandante", Lst_clientes.SelectedValue.ToString)
        parameters1(3) = New ReportParameter("nro_liquidacion", CInt(factur.NumeroFactura))

        Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.liquidaciondajuntos.rdlc"
        Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()

        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dtliquidacion", Detail))
        Frm_muestrareportes.ReportViewer1.LocalReport.SetParameters(parameters1)
        Frm_muestrareportes.ReportViewer1.RefreshReport()
        'Frm_muestrareportes.WindowState = FormWindowState.Maximized
        'Frm_muestrareportes.Show()

        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim fileNameExtension As String = Nothing
        Dim streams As String() = Nothing
        Dim war As Warning() = Nothing

        ' MsgBox(Application.LocalUserAppDataPath & "\liquidacion\", MsgBoxStyle.Critical, "Ruta")

        Dim Bit As Byte() = Frm_muestrareportes.ReportViewer1.LocalReport.Render("PDF", Nothing, mimeType, encoding, fileNameExtension, streams, war)
        Dim Fs As New IO.FileStream("C:\liquidacion\" & Lst_clientes.SelectedValue & "_" & Txt_nrofactura.Text & "_.pdf", IO.FileMode.Create)
        Fs.Write(Bit, 0, Bit.Length)
        Fs.Close()
        '************************************************




        Dim re As New Creporte_excel
        Dim r As Integer
        r = CInt(Txt_nrofactura.Text)

        Dim l As New List(Of lotesliquidacionview)
        l = (From li In contex.liquidacion Join de In contex.detalle_liquidacion On li.id_liquidacion Equals de.id_liquidacion Where li.nro_liquidacion = CInt(Txt_nrofactura.Text) Order By CInt(de.nro_lote) Ascending, de.sub_lote Ascending
             Select New lotesliquidacionview With {.idlote = de.id_lote, .idremate = 0, .nrolot = de.nro_lote,
                                                   .nrosblote = de.sub_lote, .descripcion = de.descripcion,
                                                   .unidades = de.unidades, .Punitario = de.precio_unitario,
                                                   .Total = de.precio_final, .mandante = de.mandante,
                                                   .sucursal = de.sucursal,
                                                   .fecha = li.fecha,
                                                   .afecto = de.afecto}).ToList()
        re.CreaCabecera(r)
        re.detalleliquidaciones(l, r)
        re.CIERRA("Detalle_liquidacion", r)

        'Bit = Nothing
        'Bit = Frm_muestrareportes.ReportViewer1.LocalReport.Render("Excel", Nothing, mimeType, encoding, fileNameExtension, streams, war)
        'Fs = Nothing
        'Fs = New IO.FileStream("C:\liquidacion\" & Lst_clientes.SelectedValue & "_" & Txt_nrofactura.Text & "_.xls", IO.FileMode.Create)
        'Fs.Write(Bit, 0, Bit.Length)
        'Fs.Close()
        '************************************************
        MsgBox("detalle Grabado", MsgBoxStyle.Critical, "Detalle")




        If remtipo.rematetipo(remate) = 2 Then

            Detail = CargalArticulos(lottes, cliente, True, Chk_afecto.Checked, True)

        Else
            Detail = CargalArticulos(lottes, cliente, Not (Me.Chk_detalle.Checked), Me.Chk_afecto.Checked)

        End If





        Dim parameters(0) As ReportParameter
        parameters(0) = New ReportParameter("vcomision", comision)

        Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = Nothing
        Frm_muestrareportes.ReportViewer1.RefreshReport()
        Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.liquidacion.rdlc"
        Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()

        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dfactura", Invoice))
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dfacturadet", Detail))
        'Frm_muestrareportes.ReportViewer1.LocalReport.SetParameters(parameters)
        Frm_muestrareportes.ReportViewer1.RefreshReport()
        Frm_muestrareportes.WindowState = FormWindowState.Maximized
        Frm_muestrareportes.Show()



        Me.Lbl_fecharema.Text = factu.fremates(Cmb_remates.SelectedValue.ToString)
        Me.Lbl_tiporema.Text = factu.tremates1(Cmb_remates.SelectedValue.ToString)



        remate = factu.lremate(Cmb_remates.SelectedValue)



        Me.Lst_clientes.ClearSelected()
        Me.Lst_clientes.DataSource = Nothing
        Me.Lst_clientes.Refresh()


        Me.Lst_clientes.DataSource = factu.listamandantes(remate, Chk_afecto.Checked)
        Me.Lst_clientes.DisplayMember = "Cod_mandante"
        Me.Refresh()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub


    Private Sub Btn_recalcular_Click(sender As System.Object, e As System.EventArgs) Handles Btn_recalcular.Click


        If IsNothing(Txt_fletes.Text) Or (Txt_fletes.Text = "") Then
            Txt_fletes.Text = 0
            fletes = CLng(Txt_fletes.Text)
        Else
            fletes = CLng(Txt_fletes.Text.Replace("$", ""))
        End If

        If IsNothing(Txt_publicidad.Text) Or (Txt_publicidad.Text = "") Then
            Txt_publicidad.Text = 0
            publicidad = CLng(Txt_publicidad.Text.Replace("$", ""))
        Else
            publicidad = CLng(Txt_publicidad.Text.Replace("$", ""))
        End If

        If IsNumeric(Txt_porcentaje.Text) Then
            comision = neto * CInt(Me.Txt_porcentaje.Text) / 100
            Me.Txt_comision.Text = Format(comision, "$ #,##0")
        Else
            comision = 0
        End If

        iva = 0

        If Chk_afecto.Checked Then
            iva = Math.Ceiling(((comision + fletes + publicidad) * 0.19))
        Else
            iva = Math.Ceiling(((comision + fletes + publicidad) * 0.19))
        End If



        liquido = (neto + impues_recaudado) - (fletes + publicidad + comision + iva)


        Me.Txt_neto.Text = Format(neto, "$ #,##0")
        Me.Txt_iva.Text = Format(iva, "$ #,##0")
        Me.Txt_comision.Text = Format(comision, "$ #,##0")
        Me.Txt_impuestorec.Text = Format(impues_recaudado, "$ #,##0")
        Me.Txt_publicidad.Text = Format(publicidad, "$ #,##0")
        Me.Txt_fletes.Text = Format(fletes, "$ #,##0")


        Me.Txt_liquido.Text = Format(liquido, "$ #,##0")

        'Me.Txt_lotes.Text = Format(factu.lotfactlotes(remate, Lst_clientes.SelectedValue), "#,##0")


    End Sub

    Private Sub GroupBox4_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox4.Enter

    End Sub


    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Rdb_mandante.CheckedChanged
        If Rdb_mandante.Checked Then
            Rdb_remate.Checked = False
            GroupBox6.Visible = False
            Me.Lst_clientes.DataSource = factu.listamandantes()
            Me.Lst_clientes.DisplayMember = "mandante"
            Me.Lst_clientes.Refresh()
        End If
    End Sub

    Private Sub Rdb_remate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Rdb_remate.CheckedChanged
        If Rdb_remate.Checked Then
            Rdb_mandante.Checked = False
            GroupBox6.Visible = True
            Me.Lst_clientes.DataSource = factu.listamandantes(remate, Chk_afecto.Checked)
            Me.Lst_clientes.DisplayMember = "mandante"
            Me.Lst_clientes.Refresh()
        End If
    End Sub

    Private Sub Txt_rut_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_rut.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) And Not (AscW(e.KeyChar) = 45) And Not (AscW(e.KeyChar) = 75) And Not (AscW(e.KeyChar) = 107) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            Try
                Dim ccc As New Object
                Dim rt As New rut
                If Not (rt.validarRut(Txt_rut.Text)) Then
                    MsgBox("El rut ingresado no es valido", MsgBoxStyle.Critical, "Validacion de Rut")
                    Txt_rut.Text = String.Empty
                    Me.Txt_rut.Focus()
                    Exit Sub
                End If


                mandant = manda.buscarmandanterut(rt.formato1(Txt_rut.Text))


                Me.Txt_razonsocial.Text = mandant.razonsocial_mandante.ToUpper
                Me.Txt_Comuna.Text = comuna.listacomunatext(mandant.id_comuna)
                Me.Txt_giro.Text = mandant.giro.ToUpper
                Me.Txt_direccion.Text = mandant.direccion_mandante.ToUpper
                Me.Txt_rut.Text = rt.formato(Txt_rut.Text)
            Catch ex As Exception
                'MsgBox(ex.Message, MsgBoxStyle.Critical, "Cliente")
                'Frm_clientes.Btn_asignar.Enabled = True
                'Frm_clientes.Btn_asignar.Visible = True
                'Frm_clientes.formulario = Me
                'Frm_clientes.ShowDialog()

            End Try
        End If



    End Sub

    Private Function bMe() As Object
        Throw New NotImplementedException
    End Function



    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If Chk_detalle.Checked Then

            Dim Detail As New List(Of EArticulol)()
            Dim Invoice As New List(Of EFactura)()


            Dim factur As New EFactura
            factur.Razonsocial = Txt_razonsocial.Text.ToUpper
            factur.Rut = Txt_rut.Text.ToUpper
            factur.Direccion = Txt_direccion.Text.ToUpper
            factur.Comuna = Txt_Comuna.Text.ToUpper
            factur.totaltexto = "SON :" & Num2Text(liquido).ToUpper & " PESOS"
            factur.Giro = Txt_giro.Text
            Try
                factur.NumeroFactura = Txt_nrofactura.Text.ToUpper
            Catch ex As Exception
                factur.NumeroFactura = 1
            End Try

            factur.FechaFacturacion = Now.Day & "               " & mesliteral(Now.Month) & "                                             " & Now.Year.ToString().Substring(2, 2)


            factur.Neto = CDec(neto)
            factur.impuesto_recauda = CDec(impues_recaudado)
            factur.comision = CDec(comision)
            factur.Publicidad = CDec(publicidad)
            factur.Fletes = CDec(fletes)

            factur.Iva = CDec(iva)
            factur.Liquido = CDec(liquido)



            Invoice.Add(factur)

            Detail = CargalArticulos(lottes, cliente, Me.Chk_afecto.Checked)
            Dim parameters1(3) As ReportParameter

            parameters1(0) = New ReportParameter("remate", remate)
            parameters1(1) = New ReportParameter("fecha", Lbl_fecharema.Text)
            parameters1(2) = New ReportParameter("Mandante", Lst_clientes.SelectedValue.ToString)
            parameters1(3) = New ReportParameter("nro_liquidacion", CInt(factur.NumeroFactura))

            Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempacifico.liquidaciondajuntos.rdlc"
            Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()

            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dtliquidacion", Detail))
            Frm_muestrareportes.ReportViewer1.LocalReport.SetParameters(parameters1)
            Frm_muestrareportes.ReportViewer1.RefreshReport()
            Frm_muestrareportes.WindowState = FormWindowState.Maximized
            Frm_muestrareportes.Show()


            Dim mimeType As String = Nothing
            Dim encoding As String = Nothing
            Dim fileNameExtension As String = Nothing
            Dim streams As String() = Nothing
            Dim war As Warning() = Nothing
            Dim Bit As Byte() = Frm_muestrareportes.ReportViewer1.LocalReport.Render("PDF", Nothing, mimeType, encoding, fileNameExtension, streams, war)
            Dim Fs As New IO.FileStream("C:\paso\" & Lst_clientes.SelectedValue & "_" & Txt_nrofactura.Text & "_.pdf", IO.FileMode.Create)
            Fs.Write(Bit, 0, Bit.Length)
            Fs.Close()

        End If
    End Sub

    Private Sub Txt_rut_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_rut.TextChanged
        Dim rt As New rut
        Try
            mandant = manda.buscarmandanterut(rt.formato1(Txt_rut.Text))


            Me.Txt_razonsocial.Text = mandant.razonsocial_mandante.ToUpper
            Me.Txt_Comuna.Text = comuna.listacomunatext(mandant.id_comuna)
            Me.Txt_giro.Text = mandant.giro.ToUpper
            Me.Txt_direccion.Text = mandant.direccion_mandante.ToUpper
            Me.Txt_rut.Text = rt.formato(Txt_rut.Text)
        Catch ex As Exception




        End Try
    End Sub

    Private Sub Btn_buscar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_buscar.Click
        Frm_mandantes.Btn_asignar.Enabled = True
        Frm_mandantes.Btn_asignar.Visible = True
        Frm_mandantes.formulario = Me
        Frm_mandantes.ShowDialog()
    End Sub

    Private Sub Btn_limpiar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_limpiar.Click
        For Each c As Control In Me.GroupBox1.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub Chk_afecto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Chk_afecto.CheckedChanged
        For Each c As Control In Me.GroupBox3.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next
        Cmb_remates_SelectedIndexChanged(Me, e)
    End Sub

    Private Sub Txt_porcentaje_MouseHover(sender As System.Object, e As System.EventArgs) Handles Txt_porcentaje.MouseHover
        Txt_porcentaje.Text = String.Empty
        Txt_porcentaje.Focus()
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Try

            Dim nombremanda As String = DataGridView1.Item(0, e.RowIndex).Value
            Dim nombresucu As String = DataGridView1.Item(1, e.RowIndex).Value
            impues_recaudado = 0
            neto = 0
            ila = 0

            liquido = 0
            comision = 0


            For Each c As Control In Me.GroupBox1.Controls
                If TypeOf (c) Is TextBox Then
                    c.Text = String.Empty
                End If
            Next

            Try
                Dim lista As New Object
                lottes = Nothing
                lottes = New List(Of lotesliquidacionview)
                cliente = Lst_clientes.SelectedValue

                Dim lotesliq As Object

                If Rdb_remate.Checked Then
                    lotesliq = factu.lotliquidables(remate, Lst_clientes.SelectedValue, Chk_afecto.Checked, nombremanda, nombresucu)
                Else
                    lotesliq = factu.lotliquidables(Lst_clientes.SelectedValue, Chk_afecto.Checked)
                End If





                For Each t In lotesliq
                    Dim ll As New lotesliquidacionview
                    ll.afecto = t.afecto
                    ll.facturado = t.facturado
                    ll.idlote = t.id_lote
                    ll.nrolot = t.nro_lote
                    ll.nrosblote = t.sub_lote
                    ll.descripcion = t.descripcion
                    ll.Punitario = t.precio_unitario_final
                    ll.Total = t.precio_final
                    ll.unidades = t.nro_unidades_final
                    ll.fecha = Now
                    ll.mandante = t.mandante
                    ll.sucursal = t.sucursal
                    ll.ila = t.ila
                    lottes.Add(ll)
                    ll = Nothing
                Next

                Me.Dtg_lotes.DataSource = lottes


                Me.Dtg_lotes.RowHeadersVisible = False

                For Each t In Me.Dtg_lotes.Columns
                    t.visible = False
                Next




                If Chk_afecto.Checked Then
                    lottes.RemoveAll(Function(p As lotesliquidacionview) p.afecto = False)
                Else
                    lottes.RemoveAll(Function(p As lotesliquidacionview) p.afecto = True)
                End If


                neto = 0

                For Each t In lottes
                    neto = neto + t.Total
                    If t.ila Then
                        ila += Math.Ceiling(t.Total * 0.205)
                    End If
                Next








                comision = neto * porcentaje
                comision = comision / 100
                comision = Math.Ceiling(comision)

                If Chk_afecto.Checked Then
                    impues_recaudado = Math.Ceiling(neto * 0.19)
                    iva = Math.Ceiling((comision) * 0.19)
                Else
                    impues_recaudado = 0
                    iva = Math.Ceiling((comision) * 0.19)
                End If



                liquido = (neto + impues_recaudado + ila) - (comision + iva)


                Dim ancho As Integer
                ancho = Me.Dtg_lotes.Width
                Me.Dtg_lotes.Columns(3).Visible = True
                Me.Dtg_lotes.Columns(4).Visible = True
                Me.Dtg_lotes.Columns(5).Visible = True
                Me.Dtg_lotes.Columns(6).Visible = True
                Me.Dtg_lotes.Columns(7).Visible = True
                Me.Dtg_lotes.Columns(8).Visible = True
                Me.Dtg_lotes.Columns(9).Visible = True
                Me.Dtg_lotes.Columns(10).Visible = True





                'With Me.Dtg_lotes
                '    .Columns(2).DisplayIndex = 0
                '    .Columns(3).DisplayIndex = 1
                '    .Columns(4).DisplayIndex = 2
                '    .Columns(14).DisplayIndex = 3
                '    .Columns(15).DisplayIndex = 4
                '    .Columns(16).DisplayIndex = 5
                '    .Columns(21).DisplayIndex = 6


                '.Columns(15).DefaultCellStyle.Format = "$ #,##0"
                '.Columns(16).DefaultCellStyle.Format = "$ #,##0"
                '.Columns(21).DefaultCellStyle.Format = "$ #,##0"

                '.Columns(14).DefaultCellStyle.Format = "#,##0"

                '.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                '.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                '.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                '.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                '.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



                '.Columns(2).Width = ancho * 0.08
                '.Columns(3).Width = ancho * 0.08
                '.Columns(4).Width = ancho * 0.4
                '.Columns(14).Width = ancho * 0.089
                '.Columns(15).Width = ancho * 0.089
                '.Columns(16).Width = ancho * 0.1
                '.Columns(21).Width = ancho * 0.1



                '.Columns(2).HeaderText = "N° Lote"
                '.Columns(3).HeaderText = "Sub Lote"
                '.Columns(4).HeaderText = "Especie"
                '.Columns(14).HeaderText = "Unidades"
                '.Columns(15).HeaderText = "V. Unitario"
                '.Columns(16).HeaderText = "V. Total"
                '.Columns(21).HeaderText = "Garantia"



                'End With

                'Dim chk As New DataGridViewCheckBoxColumn()

                'chk.HeaderText = "Desite"
                'chk.Name = "chk"
                'chk.TrueValue = True
                'Me.Dtg_lotes.Columns.Add(chk)


                Me.Txt_neto.TextAlign = HorizontalAlignment.Right

                Me.Txt_neto.Text = Format(neto, "$ #,##0")
                Me.Txt_iva.Text = Format(iva, "$ #,##0")
                Me.Txt_ila.Text = Format(ila, "$ #,##0")
                Me.Txt_comision.Text = Format(comision, "$ #,##0")
                Me.Txt_impuestorec.Text = Format(impues_recaudado, "$ #,##0")


                Me.Txt_liquido.Text = Format(liquido, "$ #,##0")

                Me.Txt_lotes.Text = lottes.Count



            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try




    End Sub
End Class