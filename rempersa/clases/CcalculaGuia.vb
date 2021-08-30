﻿Imports factura_electronica
Public Class CcalculaGuia
    Public idremate As Integer
    Public mandante As String
    Public sucursal As String
    Public lisdetalle As List(Of detalle_factura)
    Dim factur As New EFactura
    Dim nroinicio, nrofinal, idclif As Integer
    Dim para As New parametro
    Dim glob As New Cglobales

    


    Sub guiaTransporte(cli As clientes, detalle As List(Of DetalleGuiaView), nro As Integer, trans As CTrasnportista)
        Dim neto As Long = 0
        Dim iva As Long = 0
        Dim ila As Long = 0
        Dim comision As Long = 0
        Dim cargo As Long = 0
        Dim total As Long = 0
        Dim garantia As Long = 0
        Dim liquido As Long = 0


        Dim rt As New rut

        Dim repec As New receptorview
        repec = (From cl In contex.clientes Where cl.id_cliente = cli.id_cliente Select New receptorview With {.razonsocial = cl.razon_social, .giro = cl.giro, .rut = cl.rut, .direccion = cl.direccion, .ciudad = cl.id_comuna, .comuna = cl.id_comuna}).FirstOrDefault()
        repec.comuna = (From co In contex.comunas Where co.id_comuna = repec.comuna Select co.comuna).FirstOrDefault()
        repec.comuna = repec.comuna.ToUpper()
        repec.ciudad = trans.Ciudad
        repec.rut = rt.formato1(repec.rut)
        Dim factuele As New factura_electronica.dte_guiadespacho
        factuele.esquema()
        'Dim hoy1 As String = String.Concat(Now.Year.ToString(), "-", Now.Month.ToString("0#"), "-", Now.Day.ToString("0#"))
        Dim fecha = Now
        Dim hoy As String = String.Concat(fecha.Year.ToString(), "-", fecha.Month.ToString("0#"), "-", fecha.Day.ToString("0#"))
        factuele.docucabecera("52", nro.ToString(), hoy)
        factuele.docuemisor("76520318-K", "Remates Persa Spa", "Remates", "726000", "Camino Lo Boza 8410, Galpon 5", "Renca", "Santiago")

        If repec.giro.Length > 40 Then
            repec.giro = repec.giro.Substring(0, 40)
        End If
        If repec.razonsocial.Length > 40 Then
            repec.razonsocial = repec.razonsocial.Substring(0, 40)
        End If
        If repec.direccion.Length > 69 Then
            repec.direccion = repec.direccion.Substring(0, 69)
        End If



        factuele.docureceptor(repec.rut.Replace(".", ""), repec.razonsocial, repec.giro, repec.direccion, repec.comuna, repec.ciudad)
        factuele.docutranspote(trans.patente, trans.rut, trans.destino, trans.ComunaDes, trans.Ciudad)
        factuele.docutotal(neto, "19", iva, total)
        Dim i = 1

        For Each t In detalle
            factuele.docudetalle(i.ToString, t.descripcion.ToString(), t.cantidad.ToString(), "Unid", t.precioU.ToString(), t.precio.ToString(), "interno", "MERPER" + i.ToString("000#"))
            i += 1
        Next
        factuele.docuadjuntos(My.Settings.impresorafac, "3")
        factuele.graba(String.Concat("GuiaDespachoTrans_", nro.ToString()), My.Settings.rutafac)
        factuele.graba(String.Concat("GuiaDespachoTrans_", nro.ToString()), "c:\xml_factura\")

    End Sub


    Sub calculacargadevmerca(cli As clientes, detalle As List(Of detalle_factura), factu As facturas, nro As Integer)
        Dim neto As Long = 0
        Dim iva As Long = 0
        Dim ila As Long = 0
        Dim comision As Long = 0
        Dim cargo As Long = 0
        Dim total As Long = 0
        Dim garantia As Long = 0
        Dim liquido As Long = 0

        For Each t In detalle
            neto = neto + t.precio_total
        Next
        comision = neto * My.Settings.comision
        iva = Math.Ceiling((neto + comision) * 0.19)

        total = neto + +comision + iva
        neto = neto + comision
        liquido = total - garantia



        'neto = factu.monto_neto
        'cargo = factu.mto_cargos
        'comision = factu.monto_comision
        'iva = factu.monto_iva
        'total = factu.monto_total
        'liquido = factu.ingreso_liquido
        Dim dbfactura As New facturadb
        dbfactura.id_condicionespago = 1
        Dim rt As New rut
        Dim repec As New receptorview
        repec = (From cl In contex.clientes Where cl.id_cliente = factu.id_cliente Select New receptorview With {.razonsocial = cl.razon_social, .giro = cl.giro, .rut = cl.rut, .direccion = cl.direccion, .ciudad = cl.id_comuna, .comuna = cl.id_comuna}).FirstOrDefault()
        repec.comuna = (From co In contex.comunas Where co.id_comuna = repec.comuna Select co.comuna).FirstOrDefault()
        repec.comuna = repec.comuna.ToUpper()
        repec.ciudad = "  "
        repec.rut = rt.formato1(repec.rut)
        Dim factuele As New factura_electronica.dte_notacredito
        factuele.esquema()
        Dim hoy1 As String = String.Concat(CDate(factu.fecha).Year.ToString(), "-", CDate(factu.fecha).Month.ToString("0#"), "-", CDate(factu.fecha).Day.ToString("0#"))
        Dim fecha = Now
        Dim hoy As String = String.Concat(fecha.Year.ToString(), "-", fecha.Month.ToString("0#"), "-", fecha.Day.ToString("0#"))
        factuele.docucabecera("61", nro.ToString(), hoy)
        factuele.docuemisor("76520318-K", "Remates Persa Spa", "Remates", "726000", "Camino Lo Boza 8410, Galpon 5", "Renca", "Santiago")

        If repec.giro.Length > 40 Then
            repec.giro = repec.giro.Substring(0, 40)
        End If
        If repec.razonsocial.Length > 40 Then
            repec.razonsocial = repec.razonsocial.Substring(0, 40)
        End If
        If repec.direccion.Length > 69 Then
            repec.direccion = repec.direccion.Substring(0, 69)
        End If

        Dim valorunitario As String

        factuele.docureceptor(repec.rut.Replace(".", ""), repec.razonsocial, repec.giro, repec.direccion, repec.comuna, repec.ciudad)
        factuele.docutotal(neto, "19", iva, total)
        Dim i = 1
        For Each t In detalle

            If (t.precio_unitario * t.cantidad <> t.precio_total) Then
                valorunitario = (Decimal.Round(CDec((t.precio_total / t.cantidad)), 4)).ToString()
                valorunitario = valorunitario.Replace(",", ".")
                factuele.docudetalle(i.ToString, t.descripcion.ToString(), t.cantidad.ToString(), "Unid", valorunitario, t.precio_total.ToString(), "interno", "Lote " & t.nro_lote & "" & t.sub_lote)
            Else
                factuele.docudetalle(i.ToString, t.descripcion.ToString(), t.cantidad.ToString(), "Unid", t.precio_unitario.ToString(), t.precio_total.ToString(), "interno", "Lote " & t.nro_lote & "" & t.sub_lote)
            End If
            i += 1


        Next
        If Not (IsNothing(comision)) Or comision > 0 Then
            factuele.docudetalle(i.ToString, "COMISION", 1, "Unid", comision.ToString(), comision.ToString(), "interno", "Otros")
            i += 1
        End If

        factuele.docureferencia("1", "33", factu.nro_factura.ToString(), hoy1, "3", "DEVOLUCION DE MERCADERIA")
        Dim ff As String = String.Concat("SON: ", Num2Text(total).ToUpper(), " PESOS.-", vbCrLf, "Garantia: ", garantia, vbCrLf, "Liquido a pagar: ", liquido)
        factuele.docuadjuntos(ff, My.Settings.impresorafac, "3")
        factuele.graba(String.Concat("NotaCreditoPersa_", nro.ToString()), My.Settings.rutafac)
        factuele.graba(String.Concat("NotaCreditoPersa_", nro.ToString()), "c:\xml_factura\")

    End Sub



    Sub creareporte()

    End Sub



End Class
