Public Class Frm_reportesadhoc
    Dim rema As New Remate
    Dim contex As New persaEntities11

    Private Shared frmInstance As Frm_reportesadhoc = Nothing


    Public Shared Function Instance() As Form
        If frmInstance Is Nothing OrElse frmInstance.IsDisposed = True Then
            frmInstance = New Frm_reportesadhoc
        End If
        frmInstance.BringToFront()
        Return frmInstance
    End Function
    Private Sub Frm_reportesadhoc_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Cmbremates.DataSource = rema.listarematesr
        Me.Cmbremates.DisplayMember = "codigo_remate"
        Me.Cmbremates.ValueMember = "id_remate"

        Me.CmbFremates.DataSource = rema.listarematesr
        Me.CmbFremates.DisplayMember = "codigo_remate"
        Me.CmbFremates.ValueMember = "id_remate"

        'Me.CmbLremates.DataSource = rema.listarematesr
        'Me.CmbLremates.DisplayMember = "codigo_remate"
        'Me.CmbLremates.ValueMember = "id_remate"



        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.CenterParent
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width / 2 - (Me.Width / 2)
        y = Screen.PrimaryScreen.WorkingArea.Height / 2 - (Me.Height / 2)
        Me.Location = New Point(x, y)

        For i As Integer = 1 To 12
            CmbAño.Items.Add((i + Now.Year) - 2)
            CmbMes.Items.Add(i)
            CmbAñol.Items.Add((i + Now.Year) - 2)
            CmbMesl.Items.Add(i)
        Next

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim re As New Creporte_excel
        Dim r As Integer
        r = Cmbremates.SelectedValue

        Dim l As New List(Of detalleviewreporte)
        l = (From lo In contex.lotes Where lo.id_remate = r Order By CInt(lo.nro_lote) Ascending, lo.sub_lote Ascending Select New detalleviewreporte With {.idlote = lo.id_lote, .idremate = lo.id_remate, .nro_lote = lo.nro_lote, .sub_lote = lo.sub_lote, .descripcion = lo.descripcion, .cantidad = lo.nro_unidades_final, .precio_unitario = lo.precio_unitario_final, .precio_total = lo.precio_final, .garantia = lo.garantia, .facturado = lo.facturado, .liquidado = lo.liquidado, .mandante = lo.mandante, .adjudicatario = lo.adjudicatario, .nrofactura = 0, .nroliquidacion = 0, .observacion = lo.observaciones}).ToList()
        re.CreaCabecera(r.ToString())
        re.detalle(l)
        re.CIERRA("Remate", Cmbremates.SelectedValue)
        MsgBox("Listo", MsgBoxStyle.Critical, "Listo")
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles BtnLibroVenta.Click
        Cursor = Cursors.WaitCursor
        Dim re As New Creporte_excel
        Dim r As Integer
        r = Cmbremates.SelectedValue
        Dim mes, año As Integer
        mes = CmbMes.SelectedItem
        año = CmbAño.SelectedItem
        Dim l As New List(Of LibroVtaReporte)
        l = (From fa In contex.facturas Join cli In contex.clientes On fa.id_cliente Equals cli.id_cliente
             Where CInt(fa.fecha.Value.Month) = mes And CInt(fa.fecha.Value.Year) = año
             Order By CInt(fa.nro_factura) Ascending Select New LibroVtaReporte With {.Fecha = fa.fecha, .NroDocumento = fa.nro_factura, .TipoDocumento = "Factura", .Rut = cli.rut,
            .Neto = fa.monto_neto, .IVA = (fa.monto_neto * 0.19), .Comision = fa.monto_comision, .Cargos = fa.mto_cargos,
            .IVAp = (fa.monto_comision + fa.mto_cargos) * 0.19, .Total = fa.monto_total,
            .Garantia = fa.garantia, .Liquido = fa.ingreso_liquido, .Estado = fa.id_estado}).Distinct().ToList()
        re.CreaCabecera("Mes:" & mes & " Año:" & año)
        re.detalleLibrVta(l)
        re.CIERRA("LibroVenta", CInt(String.Concat(año, mes)))
        Cursor = Cursors.Default
        MsgBox("Listo", MsgBoxStyle.Critical, "Listo")
    End Sub

    Private Sub GroupBox4_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Cursor = Cursors.WaitCursor
        Dim re As New Creporte_excel
        Dim r As Integer
        r = CmbFremates.SelectedValue
        Dim mes, año As Integer
        mes = CmbMes.SelectedItem
        año = CmbAño.SelectedItem
        Dim l As New List(Of LibroVtaReporte)
        l = (From fa In contex.facturas Join cli In contex.clientes On fa.id_cliente Equals cli.id_cliente
             Where fa.id_remate = r
             Order By CInt(fa.nro_factura) Ascending Select New LibroVtaReporte With {.Fecha = fa.fecha, .NroDocumento = fa.nro_factura, .TipoDocumento = "Factura", .Rut = cli.rut,
            .Neto = fa.monto_neto, .IVA = (fa.monto_neto * 0.19), .Comision = fa.monto_comision, .Cargos = fa.mto_cargos,
            .IVAp = (fa.monto_comision + fa.mto_cargos) * 0.19, .Total = fa.monto_total,
            .Garantia = fa.garantia, .Liquido = fa.ingreso_liquido, .Estado = fa.id_estado}).Distinct().ToList()
        re.CreaCabecera(r.ToString())

        re.detalleLibrVta(l)
        If ChkNominas.Checked Then
            Dim l1 As New List(Of nominaview)
            l1 = (From fa In contex.facturas Join cud In contex.Cuadratura_detalle On fa.id_factura Equals cud.id_factura
                  Join cu In contex.Cuadratura On cud.id_cuadra Equals cu.id_cuadra
                  Where fa.id_remate = r
                  Order By CInt(cu.id_cuadra) Ascending Select New nominaview With {.nronomina = cu.id_cuadra, .fecha = cu.fecha_cuadra, .Monto = cu.total_nomina}).Distinct().ToList()
            re.detalleLibrVtaNominas(l1)
        End If





        re.CIERRA("LibroVenta-Remate", r)
        Cursor = Cursors.Default
        MsgBox("Listo", MsgBoxStyle.Critical, "Listo")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ChkNominas.CheckedChanged

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        Cursor = Cursors.WaitCursor
        Dim re As New Creporte_excel
        Dim r As Integer
        r = Cmbremates.SelectedValue
        Dim mes, año As Integer
        mes = CmbMesl.SelectedItem
        año = CmbAñol.SelectedItem
        Dim l As New List(Of Lqd)
        l = (From li In contex.liquidacion Join ma In contex.mandantes On li.id_mandante Equals ma.id_mandante
             Where CInt(li.fecha.Value.Month) = mes And CInt(li.fecha.Value.Year) = año
             Order By CInt(li.nro_liquidacion) Ascending Select New Lqd With {.RazonSocial = ma.razonsocial_mandante, .fecha = li.fecha, .nro_liquidacion = li.nro_liquidacion, .mtoneto = li.mto_neto, .mtoimpreacudado = li.mto_impreacudado,
            .flete = li.flete, .publicidad = li.publicidad, .comision = li.comision, .iva = li.iva, .liquido = li.liquido, .nrolotes = li.nro_lotes}).Distinct().Distinct().ToList()
        re.CreaCabecera("Mes:" & mes & " Año:" & año)
        re.detalleLibrLqd(l)
        re.CIERRA("LibroVenta_liquidaciones", CInt(String.Concat(año, mes)))
        Cursor = Cursors.Default
        MsgBox("Listo", MsgBoxStyle.Critical, "Listo")
    End Sub




    Private Sub CmbLremates_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Btnliquidacion.Click
        Cursor = Cursors.WaitCursor
        Dim re As New Creporte_excel
        Dim r As Integer
        r = CInt(Txtnliquidacion.Text)

        Dim l As New List(Of lotesliquidacionview)
        l = (From li In contex.liquidacion Join de In contex.detalle_liquidacion On li.id_liquidacion Equals de.id_liquidacion Where li.nro_liquidacion = CInt(Txtnliquidacion.Text) Order By CInt(de.nro_lote) Ascending, de.sub_lote Ascending
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
        MsgBox("Listo", MsgBoxStyle.Critical, "Listo")
        Cursor = Cursors.Default
    End Sub

    Private Sub Txtnliquidacion_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txtnliquidacion.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) And Not (AscW(e.KeyChar) = 45) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            Btnliquidacion.Focus()
        End If
    End Sub
End Class