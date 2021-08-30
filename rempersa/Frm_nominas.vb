Imports Microsoft.Reporting.WinForms

Public Class Frm_nominas
    Dim reso As New resolucion
    Dim fac = New List(Of facturas)
    Dim lisfac As New lfacturas
    Dim listadofactu As New List(Of listadofac)
    Dim nom As New Cuadratura
    Dim detnom As New List(Of Cuadratura_detalle)()
    Dim totefec As Long
    Dim totdeposito As Long
    Dim tottranf As Long
    Dim totnt As Long
    Dim tgaran As Long
    Dim lcuadra As New lcuadraturas
    Dim id As Integer


    Private Sub Frm_nominas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        reso.ajustarResolucion(Me)
        nom = New Cuadratura
        Me.WindowState = FormWindowState.Maximized
        Btn_imprimir.Visible = False
        carga()
        Lbl_gar.Text = Format(tgaran, "$ #,##0")

        For Each c As Control In GroupBox3.Controls
            If TypeOf (c) Is TextBox Then
                If c.Name.Substring(0, 4) = "Txtd" And c.Name.Length = 5 Then
                    c.Text = 0
                    AddHandler c.KeyPress, AddressOf solodigitos
                End If
                If c.Name = "Txtd10" Then
                    c.Text = 0
                    AddHandler c.KeyPress, AddressOf solodigitos
                End If
            End If
        Next
        For Each c As Control In GroupBox4.Controls
            If TypeOf (c) Is TextBox Then
                If c.Name.Substring(0, 6) = "Txttra" And c.Name.Length = 7 Then
                    c.Text = 0
                    AddHandler c.KeyPress, AddressOf solodigitos
                End If
                If c.Name = "Txttra10" Then
                    c.Text = 0
                    AddHandler c.KeyPress, AddressOf solodigitos
                End If
            End If
        Next
        For Each c As Control In GroupBox1.Controls
            If TypeOf (c) Is TextBox Then
                If c.Name.Substring(0, 5) = "Txtnt" And c.Name.Length = 6 Then
                    c.Text = 0
                    AddHandler c.KeyPress, AddressOf solodigitos
                End If
                If c.Name = "Txtnt10" Then
                    c.Text = 0
                    AddHandler c.KeyPress, AddressOf solodigitos
                End If
            End If
        Next
        Rtxt_observaciones.Text = String.Empty
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

    Sub carga()
        tgaran = 0
        Dim total As Long = 0
        Me.Dtgfa.RowHeadersVisible = False
        Me.Dtg_montofacturas.RowHeadersVisible = False
        Me.Dtg_montoingresado.RowHeadersVisible = False
        fac = lisfac.listafacturas()
        Try
            For Each t In fac
                Dim tt As New listadofac
                tt.id = CInt(t.id_factura)
                tt.rzon = t.razon_social
                tt.nrof = t.nro_factura
                tt.fecha = t.fecha
                tt.liquido = t.ingreso_liquido
                tt.garantia = t.garantia
                tt.estado = IIf(t.id_estado = 0, "Nula", "Vigente")
                tgaran += t.garantia
                listadofactu.Add(tt)
                total += t.ingreso_liquido
                tt = Nothing
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.InnerException.Message)
        End Try

        nom.efectivo_facturas = total
        Me.Label34.Text = Format(nom.efectivo_facturas, "$ #,##0")

        Me.Dtgfa.DataSource = listadofactu




        Me.Dtgfa.Refresh()

        With Me.Dtgfa
            .Columns(0).Visible = False
            .Columns(2).DefaultCellStyle.Format = "#,##0"
            .Columns(3).DefaultCellStyle.Format = "$ #,##0"
            .Columns(4).DefaultCellStyle.Format = "$ #,##0"

            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(1).HeaderText = "Razon Social"
            .Columns(2).HeaderText = "N° Factura"
            .Columns(3).HeaderText = "Monto"
            .Columns(4).HeaderText = "Garantia"
            .Columns(5).HeaderText = "Fecha"
            .Columns(6).HeaderText = "Estado"
        End With

        For Each t In Me.Dtgfa.Columns
            t.visible = True
        Next
        With Dtgfa
            .Columns(0).Visible = False
            .Columns(1).Visible = False
        End With

    End Sub

    Private Sub Dtg_listfacturas_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Txt20m_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt20m.KeyPress, Txt10m.KeyPress, Txt5m.KeyPress, Txt2m.KeyPress, Txt1m.KeyPress, Txt500.KeyPress, Txt100.KeyPress, Txt50.KeyPress, Txt10.KeyPress, Txt5.KeyPress, Txt1.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) And Not (AscW(e.KeyChar) = 45) Then
            e.Handled = True
        End If
        Try
            If e.KeyChar = ChrW(Keys.Return) Then
                totefec = 0
                Dim t As TextBox = CType(sender, TextBox)
                Select Case t.Name
                    Case Is = "Txt20m"
                        Lbl20m.Text = Format(CInt(Txt20m.Text) * 20000, "$ #,##0")
                    Case Is = "Txt10m"
                        Lbl10m.Text = Format(CInt(Txt10m.Text) * 10000, "$ #,##0")
                    Case Is = "Txt5m"
                        Lbl5m.Text = Format(CInt(Txt5m.Text) * 5000, "$ #,##0")
                    Case Is = "Txt2m"
                        Lbl2m.Text = Format(CInt(Txt2m.Text) * 2000, "$ #,##0")
                    Case Is = "Txt1m"
                        Lbl1m.Text = Format(CInt(Txt1m.Text) * 1000, "$ #,##0")
                    Case Is = "Txt500"
                        Lbl500.Text = Format(CInt(Txt500.Text) * 500, "$ #,##0")
                    Case Is = "Txt100"
                        Lbl100.Text = Format(CInt(Txt100.Text) * 100, "$ #,##0")
                    Case Is = "Txt50"
                        Lbl50.Text = Format(CInt(Txt50.Text) * 50, "$ #,##0")
                    Case Is = "Txt10"
                        Lbl10.Text = Format(CInt(Txt10.Text) * 10, "$ #,##0")
                    Case Is = "Txt5"
                        Lbl5.Text = Format(CInt(Txt5.Text) * 5, "$ #,##0")
                    Case Is = "Txt1"
                        Lbl1.Text = Format(CInt(Txt1.Text) * 1, "$ #,##0")
                End Select
                Lbl_totefec.Text = 0
                totefec = 0
                For Each c As Control In GroupBox2.Controls
                    If TypeOf (c) Is Label Then
                        If c.Name.Substring(0, 3) = "Lbl" Then
                            If Not (String.IsNullOrEmpty(c.Text)) Then
                                totefec = totefec + CLng(c.Text)
                            End If
                        End If
                    End If
                Next
                Lbl_totefec.Text = Format(totefec, "$ #,##0")
                Label36.Text = Format(totefec + totdeposito + tottranf + (-totnt), "$ #,##0")
                Lbl_totefec.Refresh()
                Label36.Refresh()

                Label2.Text = Format((totefec + totdeposito + tottranf + (-totnt)) - nom.efectivo_facturas, "$ #,##0")
                If (totefec + totdeposito + tottranf + (-totnt)) - nom.efectivo_facturas > 0 Then
                    Label2.BackColor = Color.Aquamarine
                Else
                    Label2.BackColor = Color.Red
                End If
                Label2.Refresh()
            End If
        Catch ex As Exception
            MsgBox("Nominas", MsgBoxStyle.Critical, "Error al ingresar valor")
        End Try





    End Sub
    Sub ctotal()

    End Sub

    Private Sub TextBox59_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txtnt5.TextChanged

    End Sub

    Private Sub Txtd1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txtd1.KeyPress, Txtd2.KeyPress, Txtd3.KeyPress, Txtd4.KeyPress, Txtd5.KeyPress, Txtd6.KeyPress, Txtd7.KeyPress, Txtd8.KeyPress, Txtd9.KeyPress, Txtd10.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) And Not (AscW(e.KeyChar) = 45) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            totdeposito = 0
            For Each c As Control In GroupBox3.Controls
                If TypeOf (c) Is TextBox Then
                    If c.Name.Substring(0, 4) = "Txtd" And c.Name.Length = 5 Or c.Name = "Txtd10" Then
                        If Not (String.IsNullOrEmpty(c.Text)) Then
                            totdeposito = totdeposito + CLng(c.Text)
                        End If
                    End If
                End If
            Next
            Lbl_totdepo.Text = Format(totdeposito, "$ #,##0")
            Label36.Text = Format(totefec + totdeposito + tottranf + (-totnt), "$ #,##0")
            Label36.Refresh()

            Label2.Text = Format((totefec + totdeposito + tottranf + (-totnt)) - nom.efectivo_facturas, "$ #,##0")
            If (totefec + totdeposito + tottranf + (-totnt)) - nom.efectivo_facturas > 0 Then
                Label2.BackColor = Color.Aquamarine
            Else
                Label2.BackColor = Color.Red
            End If
            Label2.Refresh()

        End If

    End Sub

    Private Sub Txttra1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txttra1.KeyPress, Txttra2.KeyPress, Txttra3.KeyPress, Txttra4.KeyPress, Txttra5.KeyPress, Txttra6.KeyPress, Txttra7.KeyPress, Txttra8.KeyPress, Txttra9.KeyPress, Txttra10.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) And Not (AscW(e.KeyChar) = 45) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            tottranf = 0
            For Each c As Control In GroupBox4.Controls
                If TypeOf (c) Is TextBox Then
                    If c.Name.Substring(0, 6) = "Txttra" And c.Name.Length = 7 Or c.Name = "Txttra10" Then
                        If Not (String.IsNullOrEmpty(c.Text)) Then
                            tottranf = tottranf + CLng(c.Text)
                        End If
                    End If
                End If
            Next
            Lbl_tottrans.Text = Format(tottranf, "$ #,##0")
            Lbl_tottrans.Refresh()
            Label36.Text = Format(totefec + totdeposito + tottranf + (-totnt), "$ #,##0")
            Label36.Refresh()

            Label2.Text = Format((totefec + totdeposito + tottranf + (-totnt)) - nom.efectivo_facturas, "$ #,##0")
            If (totefec + totdeposito + tottranf + (-totnt)) - nom.efectivo_facturas > 0 Then
                Label2.BackColor = Color.Aquamarine
            Else
                Label2.BackColor = Color.Red
            End If
            Label2.Refresh()


        End If

    End Sub

    Private Sub Txtnt1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txtnt1.KeyPress, Txtnt2.KeyPress, Txtnt3.KeyPress, Txtnt4.KeyPress, Txtnt5.KeyPress, Txtnt6.KeyPress, Txtnt7.KeyPress, Txtnt8.KeyPress, Txtnt9.KeyPress, Txtnt10.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) And Not (AscW(e.KeyChar) = 45) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            totnt = 0
            For Each c As Control In GroupBox1.Controls
                If TypeOf (c) Is TextBox Then
                    If c.Name.Substring(0, 5) = "Txtnt" Then
                        If Not (String.IsNullOrEmpty(c.Text)) Then
                            totnt = totnt + CLng(c.Text)
                        End If
                    End If
                End If
            Next
            Lbl_totajustes.Text = Format(totnt, "$ #,##0")
            Lbl_totajustes.Refresh()
            Label36.Text = Format(totefec + totdeposito + tottranf + (-totnt), "$ #,##0")
            Label36.Refresh()

            Label2.Text = Format((totefec + totdeposito + tottranf + (-totnt)) - nom.efectivo_facturas, "$ #,##0")
            If (totefec + totdeposito + tottranf + (-totnt)) - nom.efectivo_facturas > 0 Then
                Label2.BackColor = Color.Aquamarine
            Else
                Label2.BackColor = Color.Red
            End If
            Label2.Refresh()

        End If

    End Sub



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Btn_graba.Click
        nom = Nothing
        nom = New Cuadratura

        nom.transbank_facturas = 0
        nom.id_remate = 0
        nom.obs_cuadra = Rtxt_observaciones.Text
        nom.total_nomina = totefec + totdeposito + tottranf + (-totnt)
        nom.efectivo = totefec
        nom.depositos = totdeposito
        nom.tranferencias = tottranf
        nom.notas_credito = totnt

        nom.efectivo_facturas = CDec(Label34.Text.Replace("$", "").Replace(".", ""))

        For Each c As Control In Me.GroupBox2.Controls
            If TypeOf (c) Is TextBox Then
                If Not IsNumeric(c.Text) Then
                    c.Text = 0
                End If
            End If
        Next









        nom.bill_20000 = Lbl20m.Text
        nom.bill_10000 = Lbl10m.Text
        nom.bill_5000 = Lbl5m.Text
        nom.bill_2000 = Lbl2m.Text
        nom.bill_1000 = Lbl1m.Text
        nom.bill_500 = Lbl500.Text
        nom.bill_100 = Lbl100.Text
        nom.bill_50 = Lbl50.Text
        nom.bill_10 = Lbl10.Text
        nom.bill_5 = Lbl5.Text
        nom.bill_1 = Lbl1.Text

        nom.depo_m1 = Txtd1.Text.Replace("$", "").Replace(".", "")
        nom.depo_m2 = Txtd2.Text.Replace("$", "").Replace(".", "")
        nom.depo_m3 = Txtd3.Text.Replace("$", "").Replace(".", "")
        nom.depo_m4 = Txtd4.Text.Replace("$", "").Replace(".", "")
        nom.depo_m5 = Txtd5.Text.Replace("$", "").Replace(".", "")
        nom.depo_m6 = Txtd6.Text.Replace("$", "").Replace(".", "")
        nom.depo_m7 = Txtd7.Text.Replace("$", "").Replace(".", "")
        nom.depo_m8 = Txtd8.Text.Replace("$", "").Replace(".", "")
        nom.depo_m9 = Txtd9.Text.Replace("$", "").Replace(".", "")
        nom.depo_m10 = Txtd10.Text.Replace("$", "").Replace(".", "")

        nom.depo_b1 = Txtdt1.Text.ToUpper()
        nom.depo_b2 = Txtdt2.Text.ToUpper()
        nom.depo_b3 = Txtdt3.Text.ToUpper()
        nom.depo_b4 = Txtdt4.Text.ToUpper()
        nom.depo_b5 = Txtdt5.Text.ToUpper()
        nom.depo_b6 = Txtdt6.Text.ToUpper()
        nom.depo_b7 = Txtdt7.Text.ToUpper()
        nom.depo_b8 = Txtdt8.Text.ToUpper()
        nom.depo_b9 = Txtdt9.Text.ToUpper()
        nom.depo_b10 = Txtdt10.Text.ToUpper()






        nom.transfer_m1 = Txttra1.Text.Replace("$", "").Replace(".", "")
        nom.transfer_m2 = Txttra2.Text.Replace("$", "").Replace(".", "")
        nom.transfer_m3 = Txttra3.Text.Replace("$", "").Replace(".", "")
        nom.transfer_m4 = Txttra4.Text.Replace("$", "").Replace(".", "")
        nom.transfer_m5 = Txttra5.Text.Replace("$", "").Replace(".", "")
        nom.transfer_m6 = Txttra6.Text.Replace("$", "").Replace(".", "")
        nom.transfer_m7 = Txttra7.Text.Replace("$", "").Replace(".", "")
        nom.transfer_m8 = Txttra8.Text.Replace("$", "").Replace(".", "")
        nom.transfer_m9 = Txttra9.Text.Replace("$", "").Replace(".", "")
        nom.transfer_m10 = Txttra10.Text.Replace("$", "").Replace(".", "")

        nom.transbank_b1 = Txttrat1.Text.ToUpper()
        nom.transbank_b2 = Txttrat2.Text.ToUpper()
        nom.transbank_b3 = Txttrat3.Text.ToUpper()
        nom.transbank_b4 = Txttrat4.Text.ToUpper()
        nom.transbank_b5 = Txttrat5.Text.ToUpper()
        nom.transbank_b6 = Txttrat6.Text.ToUpper()
        nom.transbank_b7 = Txttrat7.Text.ToUpper()
        nom.transbank_b8 = Txttrat8.Text.ToUpper()
        nom.transbank_b9 = Txttrat9.Text.ToUpper()
        nom.transbank_b10 = Txttrat10.Text.ToUpper()


        nom.nc_1 = Txtnt1.Text.Replace("$", "").Replace(".", "")
        nom.nc_2 = Txtnt2.Text.Replace("$", "").Replace(".", "")
        nom.nc_3 = Txtnt3.Text.Replace("$", "").Replace(".", "")
        nom.nc_4 = Txtnt4.Text.Replace("$", "").Replace(".", "")
        nom.nc_5 = Txtnt5.Text.Replace("$", "").Replace(".", "")
        nom.nc_6 = Txtnt6.Text.Replace("$", "").Replace(".", "")
        nom.nc_7 = Txtnt7.Text.Replace("$", "").Replace(".", "")
        nom.nc_8 = Txtnt8.Text.Replace("$", "").Replace(".", "")
        nom.nc_9 = Txtnt9.Text.Replace("$", "").Replace(".", "")
        nom.nc_10 = Txtnt10.Text.Replace("$", "").Replace(".", "")



        nom.fecha_cuadra = Now

        lcuadra.carga(nom)

        For Each t In Dtgfa.Rows
            Dim bbb As New Cuadratura_detalle
            bbb.id_cuadra = nom.id_cuadra
            bbb.id_factura = CInt(t.Cells(0).Value)
            bbb.liquido_factura = CInt(t.Cells(3).Value)
            bbb.nro_factura = t.Cells(2).Value
            bbb.tipo_pago = 1
            bbb.VER = True
            lcuadra.cargadetalle(bbb)
            lcuadra.regfact(CInt(t.Cells(0).Value), nom.id_cuadra)
            bbb = Nothing
        Next

        Lbl_nronomina.Text = nom.id_cuadra
        Lbl_nronomina.Refresh()
        Btn_imprimir.Visible = True
        Btn_graba.Enabled = False


    End Sub

    Private Sub Btn_imprimir_Click(sender As System.Object, e As System.EventArgs) Handles Btn_imprimir.Click

        Dim a As New List(Of Cuadratura)()
        a.Add(nom)

        Dim b As New List(Of Cuadratura_detalle)()
        Dim i As Integer = 1

        For Each t As DataGridViewRow In Dtgfa.Rows
            Dim bbb As New Cuadratura_detalle
            Try

                bbb.id_cuadra = nom.id_cuadra
                bbb.id_factura = CInt(t.Cells(2).Value)
                bbb.nro_factura = t.Cells(2).Value
                bbb.tipo_pago = 1
                bbb.liquido_factura = CInt(t.Cells(3).Value)
                bbb.garantia = t.Cells(4).Value
                bbb.VER = True
                b.Add(bbb)
                bbb = Nothing
                i += 1
            Catch ex As Exception

            End Try

        Next






        Dim parameters1 As ReportParameter

        parameters1 = New ReportParameter("tt_garan", tgaran)


        Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.nomina.rdlc"
        Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()



        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("lnomina", a.ToList()))
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("ldetalle", b))
        Frm_muestrareportes.ReportViewer1.LocalReport.SetParameters(parameters1)
        Frm_muestrareportes.ReportViewer1.RefreshReport()
        AddHandler Frm_muestrareportes.ReportViewer1.LocalReport.SubreportProcessing, AddressOf infoParametros3


        Frm_muestrareportes.Show()
        'Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("lnomina", a.ToList()))

    End Sub
    Sub infoParametros3(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)
        Dim b As New List(Of Cuadratura_detalle)()
        Dim i As Integer = 1

        For Each t As DataGridViewRow In Dtgfa.Rows
            Dim bbb As New Cuadratura_detalle
            Try
                bbb.garantia = CInt(t.Cells(4).Value)
                bbb.id_cuadra = nom.id_cuadra
                bbb.id_factura = CInt(t.Cells(0).Value)
                bbb.nro_factura = t.Cells(2).Value
                bbb.tipo_pago = 1
                bbb.liquido_factura = CInt(t.Cells(3).Value)
                bbb.VER = True
                b.Add(bbb)
                bbb = Nothing
                i += 1
            Catch ex As Exception

            End Try

        Next
        e.DataSources.Add(New ReportDataSource("ldetalle", b))
    End Sub


    Private Sub Btn_reimprime_Click(sender As System.Object, e As System.EventArgs) Handles Btn_reimprime.Click
        nom = Nothing
        nom = New Cuadratura
        detnom = Nothing
        detnom = New List(Of Cuadratura_detalle)

        id = CInt(InputBox("ingrese numero de nomina"))
        nom = lcuadra.buscacuadratura(id)


        Dim a As New List(Of Cuadratura)()
        a.Add(nom)

        Dim b As New List(Of Cuadratura_detalle)()
        Dim i As Integer = 1

        detnom = lcuadra.buscacuadraturadetalle(id)
        tgaran = 0

        For Each p As Cuadratura_detalle In detnom
            Try
                tgaran += p.garantia
            Catch ex As Exception

            End Try

        Next


        Dim parameters1 As ReportParameter

        parameters1 = New ReportParameter("tt_garan", tgaran)
        Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.nomina.rdlc"
        Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()



        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("lnomina", a.ToList()))
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("ldetalle", detnom))
        Frm_muestrareportes.ReportViewer1.LocalReport.SetParameters(parameters1)
        Frm_muestrareportes.ReportViewer1.RefreshReport()

        AddHandler Frm_muestrareportes.ReportViewer1.LocalReport.SubreportProcessing, AddressOf infoParametros2


        Frm_muestrareportes.Show()

    End Sub

    Sub infoParametros2(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)
        Dim b As New List(Of Cuadratura_detalle)()
        b = lcuadra.buscacuadraturadetalle(id)
        e.DataSources.Add(New ReportDataSource("ldetalle", b))
    End Sub


    Private Sub Txt20m_MouseHover(sender As System.Object, e As System.EventArgs) Handles Txt20m.MouseHover, Txt1.MouseHover, Txt10.MouseHover, Txt100.MouseHover, Txt10m.MouseHover, Txt1m.MouseHover, Txt2m.MouseHover, Txt5.MouseHover, Txt50.MouseHover, Txt500.MouseHover, Txt5m.MouseHover
        Dim t As TextBox = CType(sender, TextBox)
        Select Case t.Name
            Case Is = "Txt20m"
                Txt20m.Text = String.Empty
                Lbl20m.Text = Format(0 * 20000, "$ #,##0")
            Case Is = "Txt10m"
                Txt10m.Text = String.Empty
                Lbl10m.Text = Format(0 * 10000, "$ #,##0")
            Case Is = "Txt5m"
                Txt5m.Text = String.Empty
                Lbl5m.Text = Format(0 * 5000, "$ #,##0")
            Case Is = "Txt2m"
                Txt2m.Text = String.Empty
                Lbl2m.Text = Format(0 * 2000, "$ #,##0")
            Case Is = "Txt1m"
                Txt1m.Text = String.Empty
                Lbl1m.Text = Format(0 * 1000, "$ #,##0")
            Case Is = "Txt500"
                Txt500.Text = String.Empty
                Lbl500.Text = Format(0 * 500, "$ #,##0")
            Case Is = "Txt100"
                Txt100.Text = String.Empty
                Lbl100.Text = Format(0 * 100, "$ #,##0")
            Case Is = "Txt50"
                Txt50.Text = String.Empty
                Lbl50.Text = Format(0 * 50, "$ #,##0")
            Case Is = "Txt10"
                Txt10.Text = String.Empty
                Lbl10.Text = Format(0 * 10, "$ #,##0")
            Case Is = "Txt5"
                Txt5.Text = String.Empty
                Lbl5.Text = Format(0 * 5, "$ #,##0")
            Case Is = "Txt1"
                Txt1.Text = String.Empty
                Lbl1.Text = Format(0 * 1, "$ #,##0")
        End Select
        Lbl_totefec.Text = 0
        totefec = 0
        For Each c As Control In GroupBox2.Controls
            If TypeOf (c) Is Label Then
                If c.Name.Substring(0, 3) = "Lbl" Then
                    If Not (String.IsNullOrEmpty(c.Text)) Then
                        totefec = totefec + CLng(c.Text)
                    End If
                End If
            End If
        Next
        Lbl_totefec.Text = Format(totefec, "$ #,##0")
        Label36.Text = Format(totefec + totdeposito + tottranf + (-totnt), "$ #,##0")
        Lbl_totefec.Refresh()
        Label36.Refresh()

        Label2.Text = Format((totefec + totdeposito + tottranf + (-totnt)) - nom.efectivo_facturas, "$ #,##0")
        If (totefec + totdeposito + tottranf + (-totnt)) - nom.efectivo_facturas > 0 Then
            Label2.BackColor = Color.Aquamarine
        Else
            Label2.BackColor = Color.Red
        End If
        Label2.Refresh()



    End Sub


End Class