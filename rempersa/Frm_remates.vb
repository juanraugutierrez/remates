Imports System.IO
Imports Microsoft.Reporting.WinForms




Public Class Frm_remates
    Dim reso As New resolucion
    Dim rema As New Remate
    Dim tiprem As New tipo_remates
    Dim estrem As New estado_remates
    Dim indice As Integer
    Dim remesco As remates_mercaderia
    Public contex As New persaEntities11

    Private Property boletaslst As Object

    Private Sub Frm_remates_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        reso.ajustarResolucion(Me)
        Try
            Me.WindowState = FormWindowState.Normal
            Me.StartPosition = FormStartPosition.CenterParent
            Dim x As Integer
            Dim y As Integer
            x = Screen.PrimaryScreen.WorkingArea.Width / 2 - 550
            y = Screen.PrimaryScreen.WorkingArea.Height / 2 - 350
            Me.Location = New Point(x, y)
            Me.Lbl_codigo.Text = String.Empty
            carga()
            Rdb_pdf.Checked = True
            Rdb_excel.Checked = False


        Catch ex As Exception

        End Try

    End Sub
    Sub carga()
        Me.Dtg_remates.DataSource = rema.listaremates()
        Me.Dtg_remates.RowHeadersVisible = False

        For Each t In Me.Dtg_remates.Columns
            t.visible = False
        Next

        Dim ancho As Integer
        ancho = Me.Dtg_remates.Width
        Me.Dtg_remates.Columns(1).Visible = True
        Me.Dtg_remates.Columns(2).Visible = True
        Me.Dtg_remates.Columns(4).Visible = True
        Me.Dtg_remates.Columns(11).Visible = True

        With Me.Dtg_remates
            .Columns(2).DisplayIndex = 0
            .Columns(1).DisplayIndex = 1
            .Columns(4).DisplayIndex = 2
            .Columns(11).DisplayIndex = 3

            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns(1).Width = ancho * 0.2
            .Columns(2).Width = ancho * 0.4
            .Columns(4).Width = ancho * 0.2
            .Columns(11).Width = ancho * 0.2

            .Columns(2).HeaderText = "Direccion de Remate"
            .Columns(1).HeaderText = "Fecha del Remate"
            .Columns(4).HeaderText = "N° de Lotes"
            .Columns(11).HeaderText = "Codigo del Remate"
        End With

        Me.Cmb_tiporemate.DataSource = tiprem.lista_tiporemates
        Me.Cmb_tiporemate.DisplayMember = "descripcion"
        Me.Cmb_tiporemate.ValueMember = "id_tiporemate"

        Me.Cmb_estadoremate.DataSource = estrem.lista_estadoremates
        Me.Cmb_estadoremate.DisplayMember = "estado_remate"
        Me.Cmb_estadoremate.ValueMember = "id_estadoremate"



    End Sub

    Private Sub Dtg_remates_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Dtg_remates.CellContentClick

        For Each c As Control In GroupBox4.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next
        For Each c As Control In principal.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next
        Me.Lbl_codigo.Text = String.Empty
        Try
            If e.RowIndex > -1 Then
                remesco = Nothing
                remesco = New remates_mercaderia
                indice = Dtg_remates.Rows(e.RowIndex).Cells(0).Value
                remesco = rema.listaremates(Dtg_remates.Rows(e.RowIndex).Cells(0).Value)
                Me.Lbl_codigo.Text = String.Empty
                Me.Lbl_codigo.Text = remesco.codigo_remate
                Me.Txt_direccion.Text = remesco.direccion
                Me.Dtp_fecharemate.Value = remesco.fecha_remate




                Me.Txt_nlotes.Text = remesco.numero_lotes
                rema.totales(remesco.id_remate)

                rema.procesatotales(indice)
                Me.Refresh()

                remesco = rema.listaremates(Dtg_remates.Rows(e.RowIndex).Cells(0).Value)
                Me.Refresh()
                If String.IsNullOrEmpty(remesco.lotes_desistidos) Then
                    Me.Txt_lotesDesitidos.Text = 0
                Else
                    Me.Txt_lotesDesitidos.Text = remesco.lotes_desistidos
                End If

                Me.Txt_lotesAdj.Text = IIf(IsNothing(remesco.lotes_adjudicados), 0, remesco.lotes_adjudicados)
                Me.Txt_lotesSpostor.Text = remesco.lotes_sinpostor

                Me.Txt_montoAdjudicado.Text = Format(remesco.monto_Adjudicado, "$ #,##0")
                Me.Txt_montoFacturado.Text = Format(remesco.monto_facturado, " #,##0")
                Me.Txt_pfacturar.Text = Format(remesco.monto_Adjudicado - remesco.monto_facturado, "$ #,##0")

                Me.Txt_porcefactu.Text = Format((remesco.monto_facturado / remesco.monto_Adjudicado), " #.#0 %")

                Me.Txt_Gimputadaejec1.Text = Format(remesco.garantia_imputada, "$ #,##0")
                Me.Txt_GRegistradaejec1.Text = Format(remesco.garantias_registradas, "$ #,##0")
                Me.Txt_GRejec1.Text = Format(remesco.garantias_recibidas, "$ #,##0")




                Me.Txt_lotesAdj.Text = remesco.lotes_adjudicados
                Me.Txt_lotesSpostor.Text = remesco.lotes_sinpostor

                Me.Txt_montoAdjudicado.Text = remesco.monto_Adjudicado
                Me.Txt_montoFacturado.Text = Format(remesco.monto_facturado, "$ #,##0")

                Me.Txt_Gimputadaejec1.Text = Format(remesco.garantia_imputada, "$ #,##0")
                Me.Txt_GRegistradaejec1.Text = Format(remesco.garantias_registradas, "$ #,##0")
                Me.Txt_GRejec1.Text = Format(remesco.garantias_recibidas, " $ #,##0")

                Me.Txt_montoAdjudicado.Text = Format(remesco.monto_Adjudicado, "$ #,##0")


                Me.Cmb_estadoremate.SelectedItem = remesco.estado_remate
                Me.Cmb_tiporemate.SelectedItem = remesco.tipo_remate


            End If
        Catch ex As Exception

        End Try



    End Sub

    Private Sub Btn_agregar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_agregar.Click
        Dim remesco As New remates_mercaderia
        If String.IsNullOrEmpty(Me.Txt_direccion.Text) Then
            MsgBox("Debe ingresar direccion del remate", MsgBoxStyle.Critical, "Remates")
            remesco = Nothing
            Exit Sub
        End If
        remesco.direccion = Me.Txt_direccion.Text.ToUpper
        remesco.tipo_remate = Cmb_tiporemate.SelectedValue
        remesco.estado_remate = Cmb_estadoremate.SelectedValue
        remesco.id_ejecutivo1 = 0
        remesco.id_ejecutivo2 = 1
        remesco.numero_lotes = 0
        remesco.garantia_imputada = 0
        remesco.garantias_recibidas = 0
        remesco.garantias_registradas = 0
        remesco.lotes_desistidos = 0
        remesco.lotes_sinpostor = 0
        remesco.lotes_adjudicados = 0
        remesco.monto_Adjudicado = 0
        remesco.monto_desistido = 0
        remesco.monto_facturado = 0
        remesco.total_remate = 0
        remesco.fecha_remate = Dtp_fecharemate.Value.ToShortDateString
        remesco.codigo_remate = Dtp_fecharemate.Value.Year.ToString.Substring(2, 2) & "0" & Format(rema.ultimoremate() + 1, "00#") & Format(Dtp_fecharemate.Value.Month, "0#")
        remesco.codigo_remate = Replace(remesco.codigo_remate, "#", "")


        rema.carga(remesco)
        carga()


    End Sub

    Private Sub Cmb_estadoremate_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_estadoremate.SelectedIndexChanged
        Try
            Dim estadoremate As Integer
            estadoremate = Cmb_estadoremate.SelectedValue


        Catch ex As Exception

        End Try



    End Sub

    Private Sub Btn_eliminar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_eliminar.Click
        If indice < 1 Then
            MsgBox("Debe elegir un remate que eliminar")
        Else
            rema.borraremate(indice)
            MsgBox("Remate Eliminado")
            carga()
            indice = 0
        End If
    End Sub

    Private Sub Btn_modificar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_modificar.Click
        If indice >= 1 Then
            Dim remesco As New remates_mercaderia

            remesco = rema.listaremates(indice)
            remesco.direccion = Me.Txt_direccion.Text.ToUpper
            remesco.fecha_remate = Me.Dtp_fecharemate.Value

            remesco.numero_lotes = CInt(Me.Txt_nlotes.Text)
            remesco.lotes_desistidos = CInt(Me.Txt_lotesDesitidos.Text)
            remesco.lotes_adjudicados = CInt(Me.Txt_lotesAdj.Text)
            remesco.lotes_sinpostor = CInt(Me.Txt_lotesSpostor.Text)


            remesco.total_remate = CLng(Me.Txt_montoAdjudicado.Text)
            remesco.monto_facturado = CLng(Me.Txt_montoFacturado.Text)

            remesco.garantia_imputada = CLng(Me.Txt_Gimputadaejec1.Text)
            remesco.garantias_registradas = CLng(Me.Txt_GRegistradaejec1.Text)
            remesco.garantias_recibidas = CLng(Me.Txt_GRejec1.Text)

            remesco.total_remate = CLng(Me.Txt_montoAdjudicado.Text)

            rema.Updateremate(indice, remesco)
            indice = 0
            carga()
        End If


    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Try
            Dim llote As New loteo
            Dim papeleslst As New List(Of lotespapeles)()

            papeleslst = Cargalotes(remesco.id_remate)

            Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.papeles.rdlc"
            Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()
            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("rloteo", papeleslst))
            Frm_muestrareportes.ReportViewer1.RefreshReport()

            Frm_muestrareportes.Show()

        Catch ex As Exception

        End Try



    End Sub
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Try
            Dim llote As New loteo
            Dim boletaslst As New List(Of boletabase)()
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim lott As Object = llote.listalotesboletas(remesco.id_remate)

            For Each t In lott
                Dim bole As New boletabase
                bole.correo = My.Settings.correo
                bole.cuenta = My.Settings.cuentabanco
                If remesco.tipo_remate = 3 Then
                    Dim tt() As String
                    'MsgBox(t.descripcion.ToString(), MsgBoxStyle.Critical, "Boletas")
                    tt = t.descripcion.ToString().Split(vbCrLf)
                    bole.descripcion = tt(0).ToString.ToUpper & " " & tt(1).ToString.ToUpper
                    bole.descripcion = bole.descripcion.Trim()
                Else
                    bole.descripcion = "Lote Compuesto por: " & t.descripcion.ToString.ToUpper
                End If

                bole.fecfacturacion = "Primer dia Habil:" + horario + vbCrLf & "Segundo dia Habil:" + horario
                bole.fecha = t.fecha_remate.ToString()
                bole.lote = t.nro_lote & " " & t.sub_lote
                bole.numeroboleta = "0201-" & t.codigo_remate & Replace(bole.lote, "-", "") & "-RP"
                boletaslst.Add(bole)
                bole = Nothing
            Next


            'MsgBox(boletaslst.ToList().Count, MsgBoxStyle.Critical, "Total de Lotes")
            Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.boletas1.rdlc"
            Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()
            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("baseboleta", boletaslst.ToList()))
            Frm_muestrareportes.ReportViewer1.RefreshReport()
            Frm_muestrareportes.Show()


        Catch ex As Exception

        End Try
        Try
            'Frm_boletasgen.ShowDialog()
        Catch ex As Exception

        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim llote As New loteo


            Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.martillero.rdlc"
            Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()

            Dim parameters(2) As ReportParameter

            parameters(0) = New ReportParameter("nremate", remesco.codigo_remate)
            parameters(1) = New ReportParameter("tremate", "Voluntario Mercaderia")
            parameters(2) = New ReportParameter("fecremate", remesco.fecha_remate)

            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("rmartillero", llote.listaloteoa(remesco.id_remate)))
            Frm_muestrareportes.ReportViewer1.LocalReport.SetParameters(parameters)
            Frm_muestrareportes.ReportViewer1.RefreshReport()

            Frm_muestrareportes.Show()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Btn_procesar.Click
        'contex.AcceptAllChanges()
        'contex.Refresh(Objects.RefreshMode.StoreWins, contex.remates_mercaderia)
        'contex.Refresh(Objects.RefreshMode.StoreWins, contex.lotes)
        contex.AcceptAllChanges()
        contex.Refresh(Objects.RefreshMode.ClientWins, contex.remates_mercaderia)
        contex.Refresh(Objects.RefreshMode.ClientWins, contex.lotes)
        Me.Cursor = Cursors.WaitCursor

        For Each c As Control In GroupBox4.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next
        For Each c As Control In principal.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next


        rema.procesatotales(indice)
        Me.Refresh()

        remesco = rema.listaremates(indice)

        Me.Txt_direccion.Text = remesco.direccion
        Me.Dtp_fecharemate.Value = remesco.fecha_remate

        Me.Txt_nlotes.Text = remesco.numero_lotes

        If String.IsNullOrEmpty(remesco.lotes_desistidos) Then
            Me.Txt_lotesDesitidos.Text = 0
        Else
            Me.Txt_lotesDesitidos.Text = remesco.lotes_desistidos
        End If

        Me.Txt_lotesAdj.Text = IIf(IsNothing(remesco.lotes_adjudicados), 0, remesco.lotes_adjudicados)
        Me.Txt_lotesSpostor.Text = remesco.lotes_sinpostor

        Me.Txt_montoAdjudicado.Text = Format(remesco.monto_Adjudicado, "$ #,##0")
        Me.Txt_montoFacturado.Text = Format(remesco.monto_facturado, " #,##0")
        Me.Txt_pfacturar.Text = Format(remesco.monto_Adjudicado - remesco.monto_facturado, " #,##0")

        Me.Txt_porcefactu.Text = Format((remesco.monto_facturado / remesco.monto_Adjudicado), " #.#0 %")

        Me.Txt_Gimputadaejec1.Text = Format(remesco.garantia_imputada, "$ #,##0")
        Me.Txt_GRegistradaejec1.Text = Format(remesco.garantias_registradas, "$ #,##0")
        Me.Txt_GRejec1.Text = Format(remesco.garantias_recibidas, "$ #,##0")



        Me.Lbl_codigo.Text = String.Empty
        Me.Lbl_codigo.Text = remesco.codigo_remate.ToString()

        Me.Cmb_estadoremate.SelectedItem = remesco.estado_remate
        Me.Cmb_tiporemate.SelectedItem = remesco.tipo_remate

        Me.Refresh()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Txt_nlotes_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_nlotes.KeyPress, Txt_Gimputadaejec1.KeyPress, Txt_Gimputadaejec2.KeyPress, Txt_GRegistradaejec1.KeyPress, Txt_GRegistradaejec2.KeyPress, Txt_lotesAdj.KeyPress, Txt_lotesDesitidos.KeyPress, Txt_lotesSpostor.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Txt_nlotes_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_nlotes.TextChanged

    End Sub

    Private Sub Button6_Click_1(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Try
            Dim cierre As New Object
            Dim llote As New loteo
            cierre = llote.listaloteo(indice)


            Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.cierreremate.rdlc"
            Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()
            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("cierre", cierre))
            Frm_muestrareportes.ReportViewer1.RefreshReport()

            Frm_muestrareportes.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Btn_informes.Click
        remesco = rema.listaremates(indice)
        Dim paso As New List(Of remates_mercaderia)
        Dim b As New List(Of lotesinfoview)()
        Dim c As New List(Of lotesinfoview)()
        paso.Add(remesco)

        Dim llote As New loteo
        Dim parameters(1) As ReportParameter
        parameters(0) = New ReportParameter("lotesfacturados", llote.nlotesfacturados(indice))



        Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.cierreremate.rdlc"
        Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("Cierre", paso))
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("detalleremate", c))
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("rmandante", b))

        Frm_muestrareportes.ReportViewer1.LocalReport.SetParameters(parameters(0))

        Frm_muestrareportes.ReportViewer1.RefreshReport()
        AddHandler Frm_muestrareportes.ReportViewer1.LocalReport.SubreportProcessing, AddressOf infoParametros2
        AddHandler Frm_muestrareportes.ReportViewer1.LocalReport.SubreportProcessing, AddressOf infoParametros

        Frm_muestrareportes.Show()


    End Sub

    Sub infoParametros(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)
        Dim c As New List(Of lotesinfoview)()

        For Each t In contex.getlistado_remate_adjudicatarios(remesco.id_remate)
            Dim cc As New lotesinfoview
            cc.adjudicatario = t.Adjudicatario
            cc.comision = t.Comision
            cc.descripcion = t.Descripcion
            cc.facturado = t.Facturado
            cc.garantia = t.Garantia
            cc.iva = t.IVA
            cc.lote = t.Lote
            cc.mandante = t.Mandante
            cc.nro_unidades = t.Nunidades
            cc.nro_unidades_finales = t.NFinales
            cc.precio_final = t.Precio_Final
            cc.precio_unitario = t.Precio_Unitario
            cc.sub_lote = t.Sub_lote
            cc.sucursal = t.Sucursal
            cc.total = t.Total
            c.Add(cc)

            cc = Nothing
        Next



        e.DataSources.Add(New ReportDataSource("detalleremate", c))

    End Sub

    Sub infoParametros2(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)
        Dim b As New List(Of ResumenMandantesView)()
        Dim pp = contex.getlistado_remate_adjudicatarios(remesco.id_remate)

        Dim va = From p In pp Group By p.Facturado, p.Mandante
                    Into Precio = Sum(p.Precio_Final), nro_lote = Count(p.Lote), comision = Sum(p.Comision), iva = Sum(p.IVA), garantia = Sum(p.Garantia), nro_unidades = Sum(p.NFinales), total = Sum(p.Total)
                 Order By Facturado Ascending, Precio Descending, Mandante Descending



        For Each t In va
            Dim bb As New ResumenMandantesView
            bb.mandante = t.Mandante
            bb.facturado = t.Facturado
            bb.comision = t.comision
            bb.garantia = t.garantia
            bb.iva = t.iva
            bb.nlotes = t.nro_lote
            bb.nro_unidades_finales = t.nro_unidades
            bb.precio_final = t.Precio
            bb.total = t.total
            b.Add(bb)
        Next
        e.DataSources.Add(New ReportDataSource("rmandante", b))

    End Sub




    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            Dim llote As New loteo
            Dim boletaslst As New List(Of boletabase)()

            Dim lott As Object = llote.listalotesboletas(remesco.id_remate)

            For Each t In lott
                Dim bole As New boletabase
                bole.correo = My.Settings.correo
                bole.cuenta = My.Settings.cuentabanco
                If remesco.tipo_remate = 3 Then
                    Dim tt() As String
                    MsgBox(t.descripcion.ToString(), MsgBoxStyle.Critical, "Boletas")
                    tt = t.descripcion.ToString().Split(vbCrLf)
                    bole.descripcion = tt(0).ToString.ToUpper & vbCrLf & tt(1).ToString.ToUpper & vbCrLf & tt(2).ToString.ToUpper
                    bole.descripcion = bole.descripcion.Trim()
                Else
                    bole.descripcion = "Lote Compuesto por: " & t.descripcion.ToString.ToUpper
                End If
                bole.fecfacturacion = "Primer dia Habil: 09:00 a 17:00 hrs." & vbCrLf & "Segundo dia Habil:09:00 a 17:00 hrs."
                bole.fecha = t.fecha_remate.ToString()
                bole.lote = t.nro_lote & " " & t.sub_lote
                bole.numeroboleta = "0201-" & t.codigo_remate & Replace(bole.lote, "-", "") & "-RP"
                bole.unidades = t.nro_unidades
                boletaslst.Add(bole)
                bole = Nothing
            Next


            MsgBox(boletaslst.ToList().Count, MsgBoxStyle.Critical, "Total de Lotes")

            Dim parameters(1) As ReportParameter

            parameters(0) = New ReportParameter("remate", remesco.codigo_remate)
            parameters(1) = New ReportParameter("fecha", remesco.fecha_remate)

            Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.catalogo.rdlc"
            Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()
            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("baseb", boletaslst.ToList()))
            Frm_muestrareportes.ReportViewer1.LocalReport.SetParameters(parameters)
            Frm_muestrareportes.ReportViewer1.RefreshReport()
            Frm_muestrareportes.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Btn_adjudicatarios_Click(sender As System.Object, e As System.EventArgs) Handles Btn_adjudicatarios.Click
        If indice > 0 Then
            Dim ctx As New persaEntities11
            Dim ll As New List(Of ladjudicatarios)

            Dim var = ctx.getlistado_remate_adjudicatarios(indice)

            For Each t In var
                Dim ladj As New ladjudicatarios
                ladj.Adjudicatario = t.Adjudicatario
                ladj.Lote = t.Lote
                ladj.Sub_lote = t.Sub_lote
                ladj.Descripcion = t.Descripcion
                ladj.Nunidades = t.Nunidades
                ladj.Mandante = t.Mandante
                ladj.Sucursal = t.Sucursal
                ladj.NFinales = t.NFinales
                ladj.Precio_Unitario = t.Precio_Unitario
                ladj.Precio_Final = t.Precio_Final
                ladj.Comision = t.Comision
                ladj.Iva = t.IVA
                ladj.Garantia = t.Garantia
                ladj.Total = t.Total
                ladj.Facturado = t.Facturado
                ll.Add(ladj)
                ladj = Nothing
            Next

            Dim lo As New ladjudicatarios


            If Rdb_pdf.Checked Then

                '**************



                Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.ladjudicados.rdlc"
                Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()

                Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("listas", ll))
                'Frm_muestrareportes.ReportViewer1.LocalReport.SetParameters(parameters1)
                Frm_muestrareportes.ReportViewer1.RefreshReport()
                'Frm_muestrareportes.WindowState = FormWindowState.Maximized
                'Frm_muestrareportes.Show()

                Dim mimeType As String = Nothing
                Dim encoding As String = Nothing
                Dim fileNameExtension As String = Nothing
                Dim streams As String() = Nothing
                Dim war As Warning() = Nothing

                Dim svfd As New SaveFileDialog
                svfd.InitialDirectory = "C:\"
                svfd.Title = "Grabar archivo Pdf"
                svfd.FileName = ""
                svfd.Filter = "Pdf Files|*.pdf"
                With svfd

                    If .ShowDialog() = DialogResult.OK Then

                        ' MsgBox(Application.LocalUserAppDataPath & "\liquidacion\", MsgBoxStyle.Critical, "Ruta")

                        Dim Bit As Byte() = Frm_muestrareportes.ReportViewer1.LocalReport.Render("PDF", Nothing, mimeType, encoding, fileNameExtension, streams, war)
                        Dim Fs As New FileStream(.FileName, FileMode.Create)
                        Fs.Write(Bit, 0, Bit.Length)
                        Fs.Close()
                    End If
                End With

            ElseIf Rdb_excel.Checked Then


                Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.ladjudicados.rdlc"
                Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
                Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()

                Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("listas", ll))

                Frm_muestrareportes.ReportViewer1.RefreshReport()


                Dim mimeType As String = Nothing
                Dim encoding As String = Nothing
                Dim fileNameExtension As String = Nothing
                Dim streams As String() = Nothing
                Dim war As Warning() = Nothing

                Dim svfd As New SaveFileDialog
                svfd.InitialDirectory = "C:\"
                svfd.Title = "Grabar archivo Excel"
                svfd.FileName = ""
                svfd.Filter = "Excel Files(2003)|*.xls|Excel Files(2007)|*.xlsx"
                With svfd

                    If .ShowDialog() = DialogResult.OK Then

                        ' MsgBox(Application.LocalUserAppDataPath & "\liquidacion\", MsgBoxStyle.Critical, "Ruta")

                        Dim Bit = Frm_muestrareportes.ReportViewer1.LocalReport.Render("Excel", Nothing, mimeType, encoding, fileNameExtension, streams, war)
                        Dim Fs As New FileStream(.FileName, FileMode.Create)
                        Fs.Write(Bit, 0, Bit.Length)
                        Fs.Close()
                    End If
                End With



            End If

        End If



    End Sub

    Private Sub Button8_Click_1(sender As System.Object, e As System.EventArgs)




    End Sub
End Class