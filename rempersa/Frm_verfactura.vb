Imports Microsoft.Reporting.WinForms

Public Class Frm_verfactura
    Dim reso As New resolucion
    Dim estado As Boolean = False
    Dim Invoice As New List(Of EFactura)()
    Dim Detail As New List(Of EArticulo)()
    Dim values As Integer
    Dim item As Integer
    Dim idfact As Integer = 0
    Dim facturas As New lfacturas
    Dim rt As New rut
    Dim pp As New Facturaview
    Dim factur As New EFactura

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
        Txt_nomina.Text = String.Empty
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
                pp = facturas.muestrafacturaA(Me.txt_nrof.Text)
            Else
                pp = facturas.muestrafactura(Me.txt_nrof.Text)
            End If

            Lbl_comuna.Text = pp.comuna
            Lbl_razonsocial.Text = pp.direccion
            Lbl_direccion.Text = pp.direccion
            Lbl_giro.Text = pp.giro
            Lbl_razonsocial.Text = pp.razon_social
            Lbl_rut.Text = rt.formato(pp.rut)
            Lbl_fecha.Text = pp.fecha
            Lbl_comuna.Text = pp.comuna.ToUpper

            Txt_cargo.Text = Format(pp.mto_cargos, "$ #,##0")
            Txt_comision.Text = Format(pp.monto_comision, "$ #,##0")
            'Txt_garantia.Text = Format(pp.garantia, "$ #,##0")
            Txt_iva.Text = Format(pp.monto_iva, "$ #,##0")
            'Txt_liquido.Text = Format(pp.ingreso_liquido, "$ #,##0")
            Txt_neto.Text = Format(pp.monto_neto, "$ #,##0")
            Txt_total.Text = Format(pp.monto_total, "$ #,##0")
            Txt_lotes.Text = Format(pp.nro_lotes, "#,##0")
            Txt_nomina.Text = Format(pp.id_nomina, "#,##0")

            idfact = pp.id_factura

            Dtg_lotes.DataSource = facturas.vdetallefactura(pp.id_factura)
            For Each t In Me.Dtg_lotes.Columns
                t.visible = False
            Next
            Dim ancho As Integer
            ancho = Me.Dtg_lotes.Width
            Me.Dtg_lotes.RowHeadersVisible = False

            With Dtg_lotes
                .Columns(4).DisplayIndex = 0
                .Columns(17).DisplayIndex = 1
                .Columns(3).DisplayIndex = 2
                .Columns(2).DisplayIndex = 3
                .Columns(5).DisplayIndex = 4
                .Columns(6).DisplayIndex = 5
                .Columns(7).DisplayIndex = 6

                .Columns(4).Visible = True
                .Columns(17).Visible = True
                .Columns(3).Visible = True
                .Columns(2).Visible = True
                .Columns(5).Visible = True
                .Columns(6).Visible = True
                .Columns(7).Visible = True


                .Columns(5).DefaultCellStyle.Format = "$ #,##0"
                .Columns(6).DefaultCellStyle.Format = "$ #,##0"
                .Columns(7).DefaultCellStyle.Format = "$ #,##0"

                .Columns(2).DefaultCellStyle.Format = "#,##0"

                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter


                .Columns(4).Width = ancho * 0.08
                .Columns(17).Width = ancho * 0.08
                .Columns(3).Width = ancho * 0.42
                .Columns(2).Width = ancho * 0.09
                .Columns(5).Width = ancho * 0.09
                .Columns(6).Width = ancho * 0.12
                .Columns(7).Width = ancho * 0.11


                .Columns(4).HeaderText = "N° Lote"
                .Columns(17).HeaderText = "Sub Lote"
                .Columns(3).HeaderText = "Especie"
                .Columns(2).HeaderText = "Unidades"
                .Columns(5).HeaderText = "V. Unitario"
                .Columns(6).HeaderText = "V. Total"
                .Columns(7).HeaderText = "Garantia"
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

    Private Sub Btn_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Btn_imprimir.Click
        factur = Nothing
        factur = New EFactura
        factur.Razonsocial = Lbl_razonsocial.Text.ToUpper
        factur.Rut = Lbl_rut.Text.ToUpper
        factur.Direccion = Lbl_direccion.Text.ToUpper
        factur.Comuna = Lbl_comuna.Text.ToUpper
        factur.Giro = Lbl_giro.Text
        factur.totaltexto = "SON :" & Num2Text(CInt(pp.monto_total)).ToUpper & " PESOS"
        factur.NumeroFactura = CInt(txt_nrof.Text)


        factur.FechaFacturacion = pp.fecha.Value.Day & "               " & mesliteral(pp.fecha.Value.Month) & "                                             " & pp.fecha.Value.Year.ToString().Substring(2, 2)

        factur.Neto = CDec(Txt_neto.Text.Replace("$", "").Replace(".", ""))
        factur.Comision = CDec(Txt_comision.Text.Replace("$", "").Replace(".", ""))
        factur.Cargos = CDec(Txt_cargo.Text.Replace("$", "").Replace(".", ""))
        factur.Iva = CDec(Txt_iva.Text.Replace("$", "").Replace(".", ""))
        factur.Total = CDec(Txt_total.Text.Replace("$", "").Replace(".", ""))
        'factur.Garantia = CDec(rgarantia.Text.Replace("$", "").Replace(".", ""))
        'If Txt_liquido.Text.IndexOfAny("-") > -1 Then
        '    factur.Liquido = Trim(Txt_liquido.Text.Replace("$", "").Replace(".", "").Replace("-", ""))
        '    factur.Liquido = factur.Liquido * -1

        'Else
        '    factur.Liquido = LTrim(RTrim(Trim(Txt_liquido.Text.Replace("$", "").Replace(".", ""))))
        'End If


        Invoice = Nothing
        Invoice = New List(Of EFactura)()
        Invoice.Add(factur)
        Detail = Nothing
        Detail = New List(Of EArticulo)()
        Try



            values = facturas.vdetallefactura(idfact, 0)
            If values > 0 Then

                For Each t In facturas.vdetallefactura(idfact, "p")
                    Dim pp As New EArticulo
                    pp.Cantidad = 1
                    If t.descripcion.Length > 18 Then
                        pp.Descripcion = t.descripcion.Substring(0, 18) & "(Lot." & t.nro_lote & " " & t.sub_lote & ")" & "(" & t.nro_unidades_final & " U. aprox.)"
                    Else

                        pp.Descripcion = t.descripcion & "(Lot." & t.nro_lote & " " & t.sub_lote & ")" & "(" & t.nro_unidades_final & " U. aprox.)"
                    End If

                    pp.Precio_unitario = t.precio_unitario
                    pp.Total = t.precio_total
                    Detail.Add(pp)
                Next
            Else

                idfact = pp.id_factura
                Dim b As EArticulo

                For Each t In facturas.vdetallefactura(pp.id_factura)
                    b = New EArticulo
                    b.Cantidad = 1
                    b.Descripcion = t.descripcion


                    b.Precio_unitario = t.precio_unitario
                    b.Total = t.precio_total
                    item += 1
                    Detail.Add(b)
                Next

            End If


        Catch ex As Exception


        End Try

        Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.Facturavtas.rdlc"
        Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()
        Dim parameters(1) As ReportParameter

        If values > 1 Then
            parameters(0) = New ReportParameter("nlotes", pp.nro_lotes)
        Else
            parameters(0) = New ReportParameter("nlotes", item)
        End If

        parameters(1) = New ReportParameter("tcomision", pp.monto_comision)
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dfactura", Invoice))
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dfacturadet", Detail))
        Frm_muestrareportes.ReportViewer1.LocalReport.SetParameters(parameters)
        Frm_muestrareportes.ReportViewer1.RefreshReport()
        Frm_muestrareportes.WindowState = FormWindowState.Maximized
        Frm_muestrareportes.Show()








    End Sub

    Private Sub GroupBox4_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox4.Enter

    End Sub
End Class