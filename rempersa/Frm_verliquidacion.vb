
Imports Microsoft.Reporting.WinForms

Public Class Frm_verliquidacion
    Dim reso As New resolucion
    Dim factu As New factura
    Dim estado As Boolean = False
    Dim Invoice As New List(Of EFactura)()
    Dim Detail As New List(Of EArticulo)()
    Dim values As Integer
    Dim item As Integer
    Dim idfact As Integer = 0
    Dim rliquidacion As New lliquidacion
    Dim rt As New rut
    Dim pp As New LiquidacionView
    Dim factur As New EFactura
    Dim idremate As Integer
    Dim cliente As String


    Private Shared frmInstance As Frm_verliquidacion = Nothing


    Public Shared Function Instance() As Form
        If frmInstance Is Nothing OrElse frmInstance.IsDisposed = True Then
            frmInstance = New Frm_verliquidacion
        End If
        frmInstance.BringToFront()
        Return frmInstance
    End Function


    Private Sub Frm_verfactura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        idfact = 0
        'reso.ajustarResolucion(Me)
        For Each c As Control In Me.GroupBox7.Controls
            If TypeOf (c) Is Label Then
                c.Text = String.Empty
            End If
        Next
        For Each c As Control In Me.GroupBox4.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next
        Me.Text = "Ver Liquidacion"
        Me.Dtg_lotes.DataSource = Nothing
        Me.Dtg_lotes.Refresh()

        'Me.WindowState = FormWindowState.Normal
        Me.Text = "Ver Facturas"
        Me.StartPosition = FormStartPosition.CenterParent
        'Dim x As Integer
        'Dim y As Integer
        'x = (Screen.PrimaryScreen.WorkingArea.Width / 2) - 530
        'y = (Screen.PrimaryScreen.WorkingArea.Height / 2) - 370
        'Me.Location = New Point(x, y)
    End Sub

    Private Sub TextBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nrof.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            Button1.Focus()
        End If


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        buscar()

    End Sub
    Sub buscar()

        Try
            If chKAntiguas.Checked Then
                pp = rliquidacion.muestraliquidacionA(Me.txt_nrof.Text)
            Else
                pp = rliquidacion.muestraliquidacion(Me.txt_nrof.Text)
            End If



            Lbl_comuna.Text = pp.comuna
            Lbl_razonsocial.Text = pp.direccion
            Lbl_direccion.Text = pp.direccion
            Lbl_giro.Text = pp.giro
            Lbl_razonsocial.Text = pp.razon_social
            Lbl_rut.Text = rt.formato(pp.rut)
            Lbl_fecha.Text = pp.fecha
            Lbl_comuna.Text = pp.comuna.ToUpper

            Txt_neto.Text = Format(pp.monto_neto, "$ #,##0")
            Txt_impuestorec.Text = Format(pp.monto_impuestoreca, "$ #,##0")
            Txt_iva.Text = Format(pp.monto_iva, "$ #,##0")
            Txt_ila.Text = Format(pp.monto_ila, "$ #,##0")
            Txt_liquido.Text = Format(pp.liquido_apagar, "$ #,##0")
            Txt_fletes.Text = Format(pp.monto_flete, "$ #,##0")
            Txt_comision.Text = Format(pp.mto_comision, "$ #,##0")
            Txt_lotes.Text = Format(pp.nro_lotes, "#,##0")


            idfact = pp.id_liquidacion

            Dtg_lotes.DataSource = rliquidacion.vdetalleliquidacion(pp.id_liquidacion)
            For Each t In Me.Dtg_lotes.Columns
                t.visible = False
            Next
            Dim ancho As Integer
            ancho = Me.Dtg_lotes.Width
            Me.Dtg_lotes.RowHeadersVisible = False

            With Dtg_lotes
                .Columns(3).DisplayIndex = 0
                .Columns(4).DisplayIndex = 1
                .Columns(5).DisplayIndex = 2
                .Columns(6).DisplayIndex = 3
                .Columns(7).DisplayIndex = 4
                .Columns(8).DisplayIndex = 5
                .Columns(10).DisplayIndex = 6
                .Columns(11).DisplayIndex = 7

                .Columns(3).Visible = True
                .Columns(4).Visible = True
                .Columns(5).Visible = True
                .Columns(6).Visible = True
                .Columns(7).Visible = True
                .Columns(8).Visible = True
                .Columns(10).Visible = True
                .Columns(11).Visible = True


                '.Columns(5).DefaultCellStyle.Format = "$ #,##0"
                '.Columns(6).DefaultCellStyle.Format = "$ #,##0"
                '.Columns(7).DefaultCellStyle.Format = "$ #,##0"

                '.Columns(2).DefaultCellStyle.Format = "#,##0"

                '.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                '.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                '.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                '.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                '.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                .Columns(3).Width = ancho * 0.08
                .Columns(4).Width = ancho * 0.08
                .Columns(5).Width = ancho * 0.42
                .Columns(6).Width = ancho * 0.09
                .Columns(7).Width = ancho * 0.09
                .Columns(8).Width = ancho * 0.12
                .Columns(10).Width = ancho * 0.11
                .Columns(11).Width = ancho * 0.11


                .Columns(3).HeaderText = "N° Lote"
                .Columns(4).HeaderText = "Sub Lote"
                .Columns(5).HeaderText = "Especie"
                .Columns(6).HeaderText = "Unidades"
                .Columns(7).HeaderText = "V. Unitario"
                .Columns(8).HeaderText = "V. Total"
                .Columns(10).HeaderText = "Mandante"
                .Columns(11).HeaderText = "Sucursal"
            End With
            Dtg_lotes.Refresh()
        Catch ex As Exception

        End Try




    End Sub

    Private Sub GroupBox7_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub txt_nrof_MouseHover(sender As System.Object, e As System.EventArgs) Handles txt_nrof.MouseHover
        txt_nrof.Text = String.Empty
        Me.Dtg_lotes.DataSource = Nothing
        Me.Dtg_lotes.Refresh()
        Frm_verfactura_Load(Me, e)

    End Sub

    Private Sub txt_nrof_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_nrof.TextChanged

    End Sub

    'Private Sub Btn_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Btn_imprimir.Click
    '    factur = Nothing
    '    factur = New EFactura
    '    factur.Razonsocial = Lbl_razonsocial.Text.ToUpper
    '    factur.Rut = Lbl_rut.Text.ToUpper
    '    factur.Direccion = Lbl_direccion.Text.ToUpper
    '    factur.Comuna = Lbl_comuna.Text.ToUpper
    '    factur.Giro = Lbl_giro.Text
    '    factur.totaltexto = "SON :" & Num2Text(CInt(pp.monto_total)).ToUpper & " PESOS"
    '    factur.NumeroFactura = CInt(txt_nrof.Text)


    '    factur.FechaFacturacion = pp.fecha.Value.Day & "               " & mesliteral(pp.fecha.Value.Month) & "                                             " & pp.fecha.Value.Year.ToString().Substring(2, 2)

    '    factur.Neto = CDec(Txt_neto.Text.Replace("$", "").Replace(".", ""))
    '    factur.Comision = CDec(Txt_comision.Text.Replace("$", "").Replace(".", ""))
    '    factur.Cargos = CDec(Txt_ca.Text.Replace("$", "").Replace(".", ""))
    '    factur.Iva = CDec(Txt_iva.Text.Replace("$", "").Replace(".", ""))
    '    factur.Total = CDec(Txt_total.Text.Replace("$", "").Replace(".", ""))
    '    factur.Garantia = CDec(Txt_garantia.Text.Replace("$", "").Replace(".", ""))
    '    factur.Liquido = CDec(Txt_liquido.Text.Replace("$", "").Replace(".", ""))

    '    Invoice = Nothing
    '    Invoice = New List(Of EFactura)()
    '    Invoice.Add(factur)
    '    Detail = Nothing
    '    Detail = New List(Of EArticulo)()
    '    Try



    '        values = rliquidacion.vdetalleliquidacion(idfact, 0)
    '        If values > 0 Then

    '            For Each t In rliquidacion.vdetalleliquidacion(idfact, "p")
    '                Dim pp As New EArticulo
    '                pp.Cantidad = 1
    '                If t.descripcion.Length > 18 Then
    '                    pp.Descripcion = t.descripcion.Substring(0, 18) & "(Lot." & t.nro_lote & " " & t.sub_lote & ")" & "(" & t.nro_unidades_final & " U. aprox.)"
    '                Else

    '                    pp.Descripcion = t.descripcion & "(Lot." & t.nro_lote & " " & t.sub_lote & ")" & "(" & t.nro_unidades_final & " U. aprox.)"
    '                End If

    '                pp.Precio_unitario = t.precio_unitario
    '                pp.Total = t.precio_total
    '                Detail.Add(pp)
    '            Next
    '        Else

    '            idfact = pp.id_liquidacion
    '            Dim b As EArticulo

    '            For Each t In rliquidacion.vdetalleliquidacion(pp.id_liquidacion)
    '                b = New EArticulo
    '                b.Cantidad = 1
    '                b.Descripcion = t.descripcion


    '                b.Precio_unitario = t.precio_unitario
    '                b.Total = t.precio_total
    '                item += 1
    '                Detail.Add(b)
    '            Next

    '        End If


    '    Catch ex As Exception


    '    End Try

    '    Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.Facturavtas.rdlc"
    '    Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    '    Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()
    '    Dim parameters(1) As ReportParameter

    '    If values > 1 Then
    '        parameters(0) = New ReportParameter("nlotes", pp.nro_lotes)
    '    Else
    '        parameters(0) = New ReportParameter("nlotes", item)
    '    End If

    '    parameters(1) = New ReportParameter("tcomision", pp.monto_comision)
    '    Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dfactura", Invoice))
    '    Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dfacturadet", Detail))
    '    Frm_muestrareportes.ReportViewer1.LocalReport.SetParameters(parameters)
    '    Frm_muestrareportes.ReportViewer1.RefreshReport()
    '    Frm_muestrareportes.WindowState = FormWindowState.Maximized
    '    Frm_muestrareportes.Show()








    'End Sub

    Private Sub GroupBox4_Enter(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Btn_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Btn_imprimir.Click
        Dim lottes As New List(Of lotesliquidacionview)
        Me.Cursor = Cursors.WaitCursor
        Dim Invoice As New List(Of EFactura)()
        Dim Detail As New List(Of EArticulol)()
        Dim factur As New EFactura

        factur.Razonsocial = Lbl_razonsocial.Text.ToUpper
        factur.Rut = Lbl_rut.Text
        factur.Direccion = Lbl_direccion.Text.ToUpper
        factur.Comuna = Lbl_comuna.Text.ToUpper
        factur.totaltexto = "SON :" & Num2Text(CLng(Txt_liquido.Text)).ToUpper & " PESOS"
        factur.Giro = Lbl_giro.Text
        Try
            factur.NumeroFactura = txt_nrof.Text.ToUpper
        Catch ex As Exception
            factur.NumeroFactura = 1
        End Try

        factur.FechaFacturacion = CDate(Lbl_fecha.Text).Day & "               " & mesliteral(CDate(Lbl_fecha.Text).Month) & "                                             " & CDate(Lbl_fecha.Text).Year.ToString().Substring(2, 2)


        factur.Neto = CDec(limpiastring(Txt_neto.Text))
        factur.impuesto_recauda = CDec(limpiastring(Txt_impuestorec.Text))
        factur.Comision = CDec(limpiastring(Txt_comision.Text))
        factur.Publicidad = CDec(limpiastring(Txt_publicidad.Text))
        factur.Fletes = CDec(limpiastring(Txt_fletes.Text))

        factur.Iva = CDec(limpiastring(Txt_iva.Text))
        factur.Ila = CDec(limpiastring(Txt_ila.Text))
        factur.Liquido = CDec(limpiastring(Txt_liquido.Text))



        Invoice.Add(factur)

        Dim liqu As New liquidaciones

        Dim pp As New List(Of detalleviewl)
        pp = liqu.detalleli(idfact)
        Dim disc As Boolean = False

        Dim aafe As Boolean
        Dim idlote As Integer
        For Each p In pp
            aafe = p.afecto
            idlote = p.id_lote
        Next

        '********
        lottes = New List(Of lotesliquidacionview)
        cliente = Lbl_razonsocial.Text
        Dim Remate As Integer = factu.lremates(idlote)

        Dim lotesliq As Object

        If aafe Then
            lotesliq = factu.lotliquidables(idfact)
        Else
            lotesliq = factu.lotliquidables(idfact)
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
        '********




        If aafe And Not (disc) Then

            Detail = CargalArticulos(lottes, Lbl_razonsocial.Text.ToUpper(), False, aafe, True)
            disc = True
        Else
            Detail = CargalArticulos(lottes, Lbl_razonsocial.Text.ToUpper(), aafe)
            disc = True
        End If










        Dim parameters1(3) As ReportParameter
        parameters1(0) = New ReportParameter("remate", 1)
        parameters1(1) = New ReportParameter("fecha", Lbl_fecha.Text)
        parameters1(2) = New ReportParameter("Mandante", Lbl_razonsocial.Text.ToUpper())
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

        'Dim Bit As Byte() = Frm_muestrareportes.ReportViewer1.LocalReport.Render("PDF", Nothing, mimeType, encoding, fileNameExtension, streams, war)
        'Dim Fs As New IO.FileStream("C:\liquidacion\" & Lst_clientes.SelectedValue & "_" & Txt_nrofactura.Text & "_.pdf", IO.FileMode.Create)
        'Fs.Write(Bit, 0, Bit.Length)
        'Fs.Close()
        ''************************************************
        'Bit = Nothing
        'Bit = Frm_muestrareportes.ReportViewer1.LocalReport.Render("Excel", Nothing, mimeType, encoding, fileNameExtension, streams, war)
        'Fs = Nothing
        'Fs = New IO.FileStream("C:\liquidacion\" & Lst_clientes.SelectedValue & "_" & Txt_nrofactura.Text & "_.xls", IO.FileMode.Create)
        'Fs.Write(Bit, 0, Bit.Length)
        'Fs.Close()
        ''************************************************
        'MsgBox("detalle Grabado", MsgBoxStyle.Critical, "Detalle")


        'End If

        'If remtipo.rematetipo(Remate) = 2 Then

        '    Detail = CargalArticulos(lottes, cliente, True, Chk_afecto.Checked, True)

        'Else
        '    Detail = CargalArticulos(lottes, cliente, Not (Me.Chk_detalle.Checked), Me.Chk_afecto.Checked)

        'End If





        Dim parameters(0) As ReportParameter
        parameters(0) = New ReportParameter("vcomision", limpiastring(Txt_comision.Text))

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


        Me.Refresh()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub chKAntiguas_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chKAntiguas.CheckedChanged

    End Sub
End Class