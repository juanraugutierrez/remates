Public Class Frm_facturaVtas
    Dim reso As New resolucion
    Dim rema As New Remate
    Dim factu As New factura
    Dim para As New parametro
    Public contex As New persaEntities11
    Dim usecli As New cliente
    Dim remate As Integer
    Public cli As New clientes
    Dim comuna As New ocomuna
    Dim articulos As New List(Of EArticulovta)
    Dim articulos2 As New List(Of detalle_factura)
    Dim articulo As EArticulovta
    Dim ffecha As DateTime
    Dim gfactvtas As New Ccalculafctura

    Dim neto As Long
    Dim iva As Long
    Dim comision As Long = 0
    Dim vcomision As Double
    Dim cargo As Long
    Dim total As Long
    Dim garantia As Long
    Dim liquido As Long
    Dim manda As New mandantes
    Dim mandat As New acc_mandante

    Public id_clien As Integer
    Public id_comuna As Integer
    Dim valor As Integer
    Dim colCheck As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
    Dim cliente As String

    Private Sub Frm_facturaimp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        reso.ajustarResolucion(Me)
        Try
            Me.WindowState = FormWindowState.Normal
            Dim x As Integer
            Dim y As Integer
            x = Screen.PrimaryScreen.WorkingArea.Width / 2 - 500
            y = Screen.PrimaryScreen.WorkingArea.Height / 2 - 350
            Me.Location = New Point(x, y)
            carga()
            cliente = String.Empty
            valor = CInt(para.parametroForname("cargo"))
            vcomision = CDbl(para.parametroForname("comision")) / 1000
            Chk_comision_CheckedChanged(Me, e)
            ffecha = Now
        Catch ex As Exception

        End Try
    End Sub

    Sub carga()

        Me.Cmb_mandante.DataSource = mandat.listamandantes
        Me.Cmb_mandante.DisplayMember = "razonsocial_mandante"
        Me.Cmb_mandante.ValueMember = "id_mandante"

        Me.Dtg_articulos.DataSource = articulos.ToList()
        Me.Dtg_articulos.RowHeadersVisible = False
        Me.Chk_afecto.Checked = True
        Me.Cmb_pago.DataSource = factu.tipospagos()
        Me.Cmb_pago.DisplayMember = "descripcion_pago"
        Me.Cmb_pago.ValueMember = "id_tipopago"

        With Me.Dtg_articulos
            .Columns(1).DisplayIndex = 0
            .Columns(0).DisplayIndex = 1
            .Columns(2).DisplayIndex = 2
            .Columns(3).DisplayIndex = 3



            .Columns(2).DefaultCellStyle.Format = "$ #,##0"
            .Columns(3).DefaultCellStyle.Format = "$ #,##0"
            .Columns(1).DefaultCellStyle.Format = "#,##0"



            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            Dim ancho As Integer
            ancho = .Width

            .Columns(0).Width = ancho * 0.55
            .Columns(1).Width = ancho * 0.1
            .Columns(2).Width = ancho * 0.14
            .Columns(3).Width = ancho * 0.19

            .Columns(0).HeaderText = "Descripcion"
            .Columns(1).HeaderText = "Cantidad"
            .Columns(2).HeaderText = "Precio Unitario"
            .Columns(3).HeaderText = "Total"

        End With

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Btn_imprimir.Click
        Dim nlotes As Integer = 0

        Dim estado As Boolean = False
        Dim Invoice As New List(Of EFactura)()

        Dim idfact As Integer = 0

        Dim factur As New EFactura


        factur.Razonsocial = Txt_razonsocial.Text.ToUpper
        factur.Rut = Txt_rut.Text.ToUpper
        factur.Direccion = Txt_direccion.Text.ToUpper
        factur.Comuna = Txt_Comuna.Text.ToUpper
        factur.Giro = Txt_giro.Text

        factur.Total = total
        factur.Iva = iva
        factur.Neto = neto
        factur.comision = comision
        factur.totaltexto = "SON :" & Num2Text(total).ToUpper & " PESOS"

        If IsNumeric(Txt_nrofactura.Text) Then
            Try
                factur.NumeroFactura = Txt_nrofactura.Text.ToUpper
            Catch ex As Exception
                MsgBox("Debe ingresar Numero de Factura", MsgBoxStyle.Critical, "Facturacion")
                Exit Sub

            End Try

            If Not (IsNumeric(Txt_nrofactura.Text)) Then
                MsgBox("Debe ingresar Numero de Factura", MsgBoxStyle.Critical, "Facturacion")
                Exit Sub
            End If

            factur.FechaFacturacion = ffecha.Day & "               " & mesliteral(ffecha.Month) & "                                     " & ffecha.Year.ToString().Substring(2, 2)









            Invoice.Add(factur)

            If Rdb_factura.Checked Then
                estado = True
                Dim dbfactura As New facturadb
                dbfactura.cargo = 0
                dbfactura.comision = factur.comision
                dbfactura.id_comuna = id_comuna
                dbfactura.id_cliente = id_clien
                dbfactura.id_condicionespago = Cmb_pago.SelectedValue
                dbfactura.NumeroFactura = factur.NumeroFactura
                dbfactura.id_remate = 0

                dbfactura.Iva = factur.Iva
                dbfactura.Neto = factur.Neto
                dbfactura.Total = factur.Total
                dbfactura.Garantia = 0
                dbfactura.ingreso_liquido = factur.Total

                'dbfactura.fecha = Now

                'Detail = CargaArticulos(remate, cliente, estado, Chk_afecto.Checked, idfact)
                articulos2 = Nothing
                articulos2 = New List(Of detalle_factura)
                For Each t In articulos

                    Dim detalle As New detalle_factura
                    detalle.id_factura = idfact
                    detalle.nro_lote = 0
                    detalle.sub_lote = ""
                    detalle.precio_unitario = CDbl(t.Precio_unitario)
                    detalle.precio_total = CDbl(t.Total)
                    detalle.afecto = Chk_afecto.Checked
                    detalle.cantidad = CInt(t.Cantidad)
                    detalle.garantia = 0
                    detalle.id_lote = 1

                    If Chk_mandante.Checked Then
                        detalle.descripcion = t.Descripcion & "( mandante:" & Cmb_mandante.SelectedItem & ")"
                    Else
                        detalle.descripcion = t.Descripcion
                    End If

                    articulos2.Add(detalle)
                    'contex.AddTodetalle_factura(detalle)
                    'contex.SaveChanges()
                    'contex.AcceptAllChanges()
                    detalle = Nothing
                    nlotes = nlotes + t.Cantidad

                Next


            End If


            gfactvtas.calculacarga(articulos2, Chk_afecto.Checked, cli.id_cliente, CInt(Txt_nrofactura.Text), ffecha, False, False)




            'Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.Facturavtas.rdlc"
            'Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            'Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()


            'Dim parameters(1) As ReportParameter
            'parameters(0) = New ReportParameter("nlotes", nlotes)
            'parameters(1) = New ReportParameter("tcomision", comision)

            'Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dfactura", Invoice))
            'Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dfacturadet", articulos))
            'Frm_muestrareportes.ReportViewer1.LocalReport.SetParameters(parameters)
            'Frm_muestrareportes.ReportViewer1.RefreshReport()
            'Frm_muestrareportes.WindowState = FormWindowState.Maximized
            'Frm_muestrareportes.Show()
            'Me.Dtg_articulos.DataSource = Nothing
            'Try
            '    Dtg_articulos.DataSource = Nothing
            '    If Chk_comision.Checked Then
            '        comision = Math.Ceiling(neto * (CDbl(para.parametroForname("comision") / 1000)))
            '    Else
            '        comision = 0
            '    End If


            '    If Chk_afecto.Checked Then
            '        iva = Math.Ceiling((neto + comision + cargo) * 0.19)
            '    Else
            '        iva = Math.Ceiling((comision + cargo) * 0.19)
            '    End If



            'Catch ex As Exception

            'End Try
            For Each c As Control In Me.GroupBox1.Controls
                If TypeOf (c) Is TextBox Then
                    c.Text = String.Empty
                End If
            Next
            For Each c As Control In Me.GroupBox3.Controls
                If TypeOf (c) Is TextBox Then
                    c.Text = String.Empty
                End If
            Next
            articulos = Nothing
            articulos = New List(Of EArticulovta)
            Me.Dtg_articulos.DataSource = Nothing
            Me.Dtg_articulos.Refresh()

        End If


    End Sub


    Private Sub Btn_actualizar_Click(sender As System.Object, e As System.EventArgs)



    End Sub

    Private Sub Btn_limpiar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_limpiar.Click
        For Each c As Control In Me.GroupBox1.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Frm_clientes.Btn_asignar.Enabled = True
        Frm_clientes.Btn_asignar.Visible = True
        Frm_clientes.formulario = Me
        Frm_clientes.RdbNombre.Checked = True


        Frm_clientes.ShowDialog()
        cli = Nothing
        cli = New clientes
        cli = usecli.buscarclienterut(Txt_rut.Text)


    End Sub

    Private Sub Txt_nrofactura_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_nrofactura.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_rut__KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_rut.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) And Not (AscW(e.KeyChar) = 45) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            Try
                cli = usecli.buscarclienterut(Txt_rut.Text)

                Me.Txt_razonsocial.Text = cli.razon_social.ToUpper
                Me.Txt_Comuna.Text = comuna.listacomunatext(cli.id_comuna)
                id_clien = cli.id_cliente
                Me.Txt_giro.Text = cli.giro.ToUpper
                Me.Txt_direccion.Text = cli.direccion.ToUpper
                id_comuna = cli.id_comuna
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Cliente")
                Frm_clientes.Btn_asignar.Enabled = True
                Frm_clientes.Btn_asignar.Visible = True
                Frm_clientes.formulario = Me
                Frm_clientes.ShowDialog()
            End Try
        End If

    End Sub

    Private Sub Txt_unidades_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_unidades.KeyPress, Txt_vunitario.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) Then
            e.Handled = True
        End If


        If e.KeyChar = ChrW(Keys.Return) Then
            Try

            Catch ex As Exception

            End Try
        End If

    End Sub


    Private Sub btn_ingresar_Click(sender As System.Object, e As System.EventArgs) Handles btn_ingresar.Click
        articulo = New EArticulovta
        articulo.Cantidad = CInt(Txt_unidades.Text)
        articulo.Descripcion = Txt_descripcion.Text.ToUpper
        articulo.Precio_unitario = CInt(Txt_vunitario.Text)
        articulo.Total = articulo.Precio_unitario * articulo.Cantidad
        articulos.Add(articulo)
        carga()
        neto = 0
        iva = 0
        total = 0

        For Each t In articulos
            neto += t.Total
        Next

        If Chk_afecto.Checked Then
            iva = CInt(Math.Ceiling(CDbl(neto * 0.19)))
        Else
            iva = 0
        End If

        total = iva + neto

        Me.Txt_neto.Text = Format(neto, "$ #,##0")
        Me.Txt_iva.Text = Format(iva, "$ #,##0")
        Me.Txt_total.Text = Format(total, "$ #,##0")

        For Each c As Control In Me.GroupBox4.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next

    End Sub



    Private Sub Chk_afecto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Chk_afecto.CheckedChanged

        If Chk_afecto.Checked Then
            neto = 0
            iva = 0
            total = 0

            For Each t In articulos
                neto += t.Total
            Next

            iva = CInt(Math.Ceiling(CDbl((neto + comision) * 0.19)))


            total = iva + neto + comision

            Me.Txt_neto.Text = Format(neto, "$ #,##0")
            Me.Txt_comision.Text = Format(comision, "$ #,##0")
            Me.Txt_iva.Text = Format(iva, "$ #,##0")
            Me.Txt_total.Text = Format(total, "$ #,##0")
        Else

            neto = 0
            iva = 0
            total = 0
            For Each t In articulos
                neto += t.Total
            Next
            iva = 0
            total = iva + neto + comision
            Me.Txt_neto.Text = Format(neto, "$ #,##0")
            Me.Txt_comision.Text = Format(comision, "$ #,##0")
            Me.Txt_iva.Text = Format(iva, "$ #,##0")
            Me.Txt_total.Text = Format(total, "$ #,##0")

        End If

    End Sub

    Private Sub Chk_comision_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Chk_comision.CheckedChanged

        If Chk_comision.Checked Then
            comision = Math.Ceiling(neto * CDbl(para.parametroForname("comision") / 1000))
        Else
            comision = 0
        End If

        Chk_afecto_CheckedChanged(Me, e)

        Txt_comision.Text = Format(comision, "$ #,##0")
    End Sub

    Private Sub MCale_DateChanged(sender As System.Object, e As System.Windows.Forms.DateRangeEventArgs) Handles MCale.DateChanged
        ffecha = MCale.SelectionStart
        MsgBox(ffecha, MsgBoxStyle.Critical, "fecha")
    End Sub


    Private Sub Chk_mandante_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Chk_mandante.CheckedChanged

        If Chk_mandante.Checked Then
            Grp_mandante.Visible = True
        Else
            Grp_mandante.Visible = False

        End If





    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Dim fa As New factura_electronica.dte_norma
        fa.esquema()
        Dim fecha As DateTime = Now
        Dim hoy As String = String.Concat(fecha.Year.ToString(), "-", fecha.Month.ToString("0#"), "-", fecha.Day.ToString("0#"))
        fa.docucabecera("33", "1", hoy)
        fa.docuemisor("76520318-K", "Remates Persa Spa", "Remates", "726000", "Camino Lo Boza 8410, Galpon 5", "Renca", "Santiago")





        fa.docureceptor("96792430-K", "SODIMAC S.A.", "VENTA AL MAYOR DE MATERIALES DE CONSTRUCCION", "AVDA. EDUARDO FREI MONTALVA 3092", "Renca", "Santiago")

        Dim ff As String
        ff = String.Concat("SON: ", Num2Text(300000), " PESOS.-")

        MessageBox.Show(ff)
        fa.docutotal("252101", "19.00", "47899", "300000")
        fa.docudetalle("1", "COSTOS DE PUBLICIDAD REMATE 27-12-2016", "1", "Unid", "252101", "252101", "", "")


        fa.docuadjuntos(ff, "TOSHIBA e-STUDIO451c PS3", "3")
        fa.graba(String.Concat("factura_servicio_", "1"), "c:\xml_factura\")


    End Sub
End Class