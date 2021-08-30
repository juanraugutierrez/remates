Public Class Ccalculafctura
    Public idremate As Integer
    Public mandante As String
    Public sucursal As String
    Public lisdetalle As List(Of detalle_factura)
    Dim factur As New EFactura
    Dim nroinicio, nrofinal, idclif As Integer
    Dim para As New parametro
    Dim glob As New Cglobales

    Sub recibe_datos(adjudicatario As String, fa As EFactura, llotes As List(Of lotes), nroii As Integer, cantidadliq As Integer, idmandante As Integer, porcentaje As Decimal, afe As Boolean, fecha As DateTime, idcli As Integer, idrematet As Integer, vila As Boolean)
        idclif = idcli
        idremate = idrematet
        Dim nrofactura As Integer = nroii
        Dim i As Integer = 0
        Dim ppp As New List(Of detalle_factura)
        Dim pp As New detalle_factura
        Dim bodegaje As Long = 0

        For Each t In llotes
            i += 1
            pp = Nothing
            pp = New detalle_factura
            pp.id_factura = 0
            pp.id_lote = t.id_lote
            pp.nro_lote = t.nro_lote
            pp.sub_lote = t.sub_lote
            pp.descripcion = t.descripcion
            pp.precio_unitario = t.precio_unitario_final
            pp.precio_total = t.precio_final
            pp.cantidad = t.nro_unidades_final
            pp.afecto = t.afecto
            pp.bodegaje = bodegaje
            pp.garantia = t.garantia
            pp.desistido = t.desistido
            pp.ila = False

            ppp.Add(pp)
            If (i / 20 = i \ 20) Or (llotes.Count = i) Then
                calculacarga(ppp, afe, idclif, nrofactura, fecha, vila)
                nrofactura += 1
                ppp = Nothing
                ppp = New List(Of detalle_factura)
            End If
        Next

    End Sub


    Sub calculacarga(ppp As List(Of detalle_factura), afe As Boolean, idmandante As Integer, nrofactura As Integer, fecha As DateTime, vila As Boolean)
        Dim mm As New facturas
        Dim neto As Long = 0
        Dim iva As Long = 0
        Dim ila As Long = 0
        Dim comision As Long = 0
        Dim cargo As Long = 0
        Dim total As Long = 0
        Dim garantia As Long = 0
        Dim liquido As Long = 0

        Dim fletes As Long = 0
        Dim publicidad As Long = 0
        Dim impues_recaudado As Long = 0


        For Each t In ppp

            If Not (t.desistido) Then
                neto += t.precio_total
            Else
                cargo += t.precio_total * 0.3
            End If

            If Not (IsNothing(t.garantia)) Then
                garantia += t.garantia
            End If

        Next
        cargo = cargo + CInt(para.parametroForname("cargo"))
        comision = neto * My.Settings.comision
        comision = Math.Ceiling(comision)

        If afe Then
            neto = (neto + comision + cargo + fletes + publicidad)
            iva = Math.Ceiling(neto * 0.19)
        Else
            iva = Math.Ceiling((comision + cargo + fletes + publicidad) * 0.19)
        End If
        If vila Then
            ila = Math.Ceiling(neto * 0.205)
        End If


        mm.monto_comision = CDec(comision)
        mm.monto_neto = neto
        mm.monto_iva = iva
        mm.monto_ila = ila

        total = neto + iva + ila
        mm.monto_total = total
        mm.garantia = garantia
        liquido = total - garantia
        mm.ingreso_liquido = liquido
        mm.nro_factura = nrofactura
        mm.nro_lotes = ppp.Count + 1
        mm.fecha = fecha.ToShortDateString & " " & fecha.ToLongTimeString
        Dim fac As New factura



        Dim dbfactura As New facturadb
        dbfactura.cargo = cargo
        dbfactura.Comision = comision
        dbfactura.id_comuna = (From cli In contex.clientes Where cli.id_cliente = idclif Select cli.id_comuna).FirstOrDefault()
        dbfactura.id_cliente = idclif
        dbfactura.id_condicionespago = 1
        dbfactura.NumeroFactura = nrofactura
        dbfactura.nlotes = ppp.Count()
        dbfactura.id_remate = idremate
        dbfactura.Iva = iva
        dbfactura.Ila = ila
        dbfactura.Neto = neto
        dbfactura.Total = total
        dbfactura.Garantia = garantia
        dbfactura.ingreso_liquido = liquido
        dbfactura.fecha = Now
        Dim rt As New rut
        Dim idfact As Integer = dbfactura.cargafa()

        Dim repec As New receptorview
        repec = (From cli In contex.clientes Where cli.id_cliente = idclif Select New receptorview With {.razonsocial = cli.razon_social, .giro = cli.giro, .rut = cli.rut, .direccion = cli.direccion, .ciudad = cli.id_comuna, .comuna = cli.id_comuna}).FirstOrDefault()



        repec.comuna = (From co In contex.comunas Where co.id_comuna = repec.comuna Select co.comuna).FirstOrDefault()
        repec.comuna = repec.comuna.ToUpper()
        repec.ciudad = "  "
        repec.rut = rt.formato1(repec.rut)



        If vila Then
            factuila(ppp, afe, idmandante, nrofactura, fecha, vila, repec, neto, iva, total, ila, garantia, comision, cargo, liquido)
            Exit Sub
        End If

        Dim detalle As New detalle_factura
        For Each t In ppp
            detalle.id_factura = idfact
            detalle.nro_lote = t.nro_lote
            detalle.sub_lote = t.sub_lote
            detalle.precio_unitario = t.precio_unitario
            detalle.precio_total = t.precio_total
            detalle.afecto = t.afecto
            detalle.cantidad = t.cantidad
            detalle.garantia = t.garantia
            detalle.id_lote = t.id_lote
            detalle.descripcion = t.descripcion
            contex.AddTodetalle_factura(detalle)
            contex.SaveChanges()
            contex.AcceptAllChanges()
            detalle = Nothing
            detalle = New detalle_factura
        Next







        Dim factuele As New factura_electronica.dte_norma
        factuele.esquema()
        Dim hoy As String = String.Concat(fecha.Year.ToString(), "-", fecha.Month.ToString("0#"), "-", fecha.Day.ToString("0#"))
        factuele.docucabecera("33", nrofactura.ToString(), hoy)
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
        For Each t In ppp
            If Not (t.desistido) Then
                If (t.precio_unitario * t.cantidad <> t.precio_total) Then
                    valorunitario = (Decimal.Round(CDec((t.precio_total / t.cantidad)), 4)).ToString()
                    valorunitario = valorunitario.Replace(",", ".")
                    factuele.docudetalle(i.ToString, t.descripcion.ToString(), t.cantidad.ToString(), "Unid", valorunitario, t.precio_total.ToString(), "interno", "Lote " & t.nro_lote & "" & t.sub_lote)
                Else
                    factuele.docudetalle(i.ToString, t.descripcion.ToString(), t.cantidad.ToString(), "Unid", t.precio_unitario.ToString(), t.precio_total.ToString(), "interno", "Lote " & t.nro_lote & "" & t.sub_lote)
                End If
                i += 1
            End If

        Next
        If Not (IsNothing(comision)) Or comision > 0 Then

            factuele.docudetalle(i.ToString, "COMISION", 1, "Unid", comision.ToString(), comision.ToString(), "interno", "Otros")
            i += 1
        End If
        If Not (IsNothing(cargo)) Or cargo > 0 Then
            factuele.docudetalle(i.ToString, "CARGOS", 1, "Unid", cargo.ToString(), cargo.ToString(), "interno", "Otros")
            i += 1
        End If

        Dim ff As String = String.Concat("SON: ", Num2Text(total).ToUpper(), " PESOS.-", vbCrLf, "Garantia: ", garantia, vbCrLf, "Liquido a pagar: ", liquido)
        factuele.docuadjuntos(ff, My.Settings.impresorafac, "3")
        factuele.graba(String.Concat("FacturaPersa_", nrofactura.ToString()), My.Settings.rutafac)
        factuele.graba(String.Concat("FacturaPersa_", nrofactura.ToString()), "c:\xml_factura\")



        Dim lo As New lotes
        Dim idactivo As Integer

        For Each t In ppp
            If Not (t.desistido) Then
                lo = Nothing
                lo = New lotes
                idactivo = t.id_lote
                lo = (From l In contex.lotes Where l.id_lote = idactivo Select l).FirstOrDefault()
                lo.facturado = 1
                lo.nrofactura = nrofactura.ToString()
                lo.fecha_factura = hoy
                contex.ApplyCurrentValues("lotes", lo)
                contex.SaveChanges()
                contex.AcceptAllChanges()
            End If
        Next

        glob.modificafac(nrofactura)
        glob.valoresini()


    End Sub

    Sub calculacarga(ppp As List(Of detalle_factura), afe As Boolean, idmandante As Integer, nrofactura As Integer, fecha As DateTime, vila As Boolean, discr As Boolean)
        Dim mm As New facturas
        Dim neto As Long = 0
        Dim iva As Long = 0
        Dim ila As Long = 0
        Dim comision As Long = 0
        Dim cargo As Long = 0
        Dim total As Long = 0
        Dim garantia As Long = 0
        Dim liquido As Long = 0

        Dim fletes As Long = 0
        Dim publicidad As Long = 0
        Dim impues_recaudado As Long = 0


        For Each t In ppp
            neto += t.precio_total
        Next

        comision = 0
        cargo = 0

        If afe Then
            neto = (neto + comision + cargo + fletes + publicidad)
            iva = Math.Ceiling(neto * 0.19)
        Else
            iva = Math.Ceiling((comision + cargo + fletes + publicidad) * 0.19)
        End If

        mm.monto_comision = CDec(comision)
        mm.monto_neto = neto
        mm.monto_iva = iva
        mm.monto_ila = ila

        total = neto + iva
        mm.monto_total = total
        mm.garantia = garantia
        liquido = total - garantia
        mm.ingreso_liquido = liquido
        mm.nro_factura = nrofactura
        mm.nro_lotes = ppp.Count + 1
        mm.fecha = fecha.ToShortDateString & " " & fecha.ToLongTimeString
        Dim fac As New factura
        Dim dbfactura As New facturadb
        dbfactura.cargo = cargo
        dbfactura.Comision = comision
        dbfactura.id_comuna = (From cli In contex.clientes Where cli.id_cliente = idmandante Select cli.id_comuna).FirstOrDefault()
        dbfactura.id_cliente = idmandante
        dbfactura.id_condicionespago = 1
        dbfactura.NumeroFactura = nrofactura
        dbfactura.nlotes = ppp.Count()
        dbfactura.id_remate = 99
        dbfactura.Iva = iva
        dbfactura.Ila = ila
        dbfactura.Neto = neto
        dbfactura.Total = total
        dbfactura.Garantia = garantia
        dbfactura.ingreso_liquido = liquido
        dbfactura.fecha = Now
        Dim rt As New rut
        Dim idfact As Integer = dbfactura.cargafa()

        Dim repec As New receptorview
        repec = (From cli In contex.clientes Where cli.id_cliente = idmandante Select New receptorview With {.razonsocial = cli.razon_social, .giro = cli.giro, .rut = cli.rut, .direccion = cli.direccion, .ciudad = cli.id_comuna, .comuna = cli.id_comuna}).FirstOrDefault()



        repec.comuna = (From co In contex.comunas Where co.id_comuna = repec.comuna Select co.comuna).FirstOrDefault()
        repec.comuna = repec.comuna.ToUpper()
        repec.ciudad = "  "
        repec.rut = rt.formato1(repec.rut)




        Dim detalle As New detalle_factura
        For Each t In ppp
            detalle.id_factura = idfact
            detalle.nro_lote = 0
            detalle.sub_lote = 0
            detalle.precio_unitario = t.precio_unitario
            detalle.precio_total = t.precio_total
            detalle.afecto = t.afecto
            detalle.cantidad = t.cantidad
            detalle.garantia = t.garantia
            detalle.id_lote = 0
            detalle.descripcion = t.descripcion

            contex.AddTodetalle_factura(detalle)
            contex.SaveChanges()
            contex.AcceptAllChanges()
            detalle = Nothing
            detalle = New detalle_factura
        Next

        Dim factuele As New factura_electronica.dte_norma


        factuele.esquema()
        Dim hoy As String = String.Concat(fecha.Year.ToString(), "-", fecha.Month.ToString("0#"), "-", fecha.Day.ToString("0#"))

        factuele.docucabecera("33", nrofactura.ToString(), hoy)
        factuele.docuemisor("76520318-K", "Remates Persa Spa", "Remates", "726000", "Camino Lo Boza 8410, Galpon 5", "Renca", "Santiago")


        If repec.giro.Length > 40 Then
            repec.giro = repec.giro.Substring(0, 40)
        End If
        If repec.razonsocial.Length > 40 Then
            repec.razonsocial = repec.razonsocial.Substring(0, 40)
        End If
        If repec.direccion.Length > 40 Then
            repec.direccion = repec.direccion.Substring(0, 40)
        End If

        factuele.docureceptor(repec.rut.Replace(".", ""), repec.razonsocial, repec.giro, repec.direccion, repec.comuna, repec.ciudad)
        factuele.docutotal(neto, "19", iva, total)

        Dim i = 1
        For Each t In ppp
            factuele.docudetalle(i.ToString, t.descripcion.ToString(), t.cantidad.ToString(), "Unid", t.precio_unitario.ToString(), t.precio_total.ToString(), "interno", "Prod y Serv")
        Next

        Dim ff As String = String.Concat("SON: ", Num2Text(total).ToUpper(), " PESOS.-", vbCrLf, "Garantia: ", garantia, vbCrLf, "Liquido a pagar: ", liquido, My.Settings.leyenda)
        Try
            factuele.docuadjuntos(ff, My.Settings.impresorafac, "3")
            factuele.graba(String.Concat("FacturaPersa_serv_", nrofactura.ToString()), My.Settings.rutafac)
            factuele.graba(String.Concat("FacturaPersa_serv_", nrofactura.ToString()), "c:\xml_factura\")


        Catch ex As Exception
            MsgBox("Error al grabar documento", MsgBoxStyle.Critical, "Facturacion")
        End Try

        glob.modificafac(nrofactura)
        glob.valoresini()

    End Sub

    Sub calcula(idremate, mandante, sucursal)




    End Sub

    Sub creareporte()

    End Sub

    Function carga(mm As facturas)
        Try
            contex.AddTofacturas(mm)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, "Liquidacion")
        End Try
        Return mm.id_factura
    End Function

    Sub cargadetalle(t As detalle_factura)
        contex.AddTodetalle_factura(t)
        contex.SaveChanges()
        contex.AcceptAllChanges()
    End Sub


    Sub factuila(ppp As List(Of detalle_factura), afe As Boolean, idmandante As Integer, nrofactura As Integer, fecha As DateTime, vila As Boolean, repec As receptorview, neto As Double, iva As Long, total As Long, ila As Long, garantia As Long, comision As Long, cargo As Long, liquido As Long)

        Dim factuele As New factura_electronica.dte_norma_ila
        factuele.esquema()
        Dim hoy As String = String.Concat(fecha.Year.ToString(), "-", fecha.Month.ToString("0#"), "-", fecha.Day.ToString("0#"))
        factuele.docucabecera("33", nrofactura.ToString(), hoy)
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
        factuele.docutotal(neto, "19", iva, total, "25", "20.5", ila)
        Dim i = 1
        For Each t In ppp
            If Not (t.desistido) Then
                If (t.precio_unitario * t.cantidad <> t.precio_total) Then
                    valorunitario = (Decimal.Round(CDec((t.precio_total / t.cantidad)), 4)).ToString()
                    valorunitario = valorunitario.Replace(",", ".")
                    factuele.docudetalle(i.ToString, t.descripcion.ToString(), t.cantidad.ToString(), "Unid", valorunitario, t.precio_total.ToString(), "interno", "Lote " & t.nro_lote & "" & t.sub_lote, "25")
                Else
                    factuele.docudetalle(i.ToString, t.descripcion.ToString(), t.cantidad.ToString(), "Unid", t.precio_unitario.ToString(), t.precio_total.ToString(), "interno", "Lote " & t.nro_lote & "" & t.sub_lote, "25")
                End If
                i += 1
            End If

        Next
        If Not (IsNothing(comision)) Or comision > 0 Then
            factuele.docudetalle(i.ToString, "COMISION", 1, "Unid", comision.ToString(), comision.ToString(), "interno", "Otros")
            i += 1
        End If
        If Not (IsNothing(cargo)) Or cargo > 0 Then
            factuele.docudetalle(i.ToString, "CARGOS", 1, "Unid", cargo.ToString(), cargo.ToString(), "interno", "Otros")
            i += 1
        End If

        Dim ff As String = String.Concat("SON: ", Num2Text(total).ToUpper(), " PESOS.-", vbCrLf, "Garantia: ", garantia, vbCrLf, "Liquido a pagar: ", liquido)
        factuele.docuadjuntos(ff, My.Settings.impresorafac, "3")
        factuele.graba(String.Concat("FacturaPersa_", nrofactura.ToString()), My.Settings.rutafac)
        factuele.graba(String.Concat("FacturaPersa_", nrofactura.ToString()), "c:\xml_factura\")



        Dim lo As New lotes
        Dim idactivo As Integer

        For Each t In ppp
            If Not (t.desistido) Then
                lo = Nothing
                lo = New lotes
                idactivo = t.id_lote
                lo = (From l In contex.lotes Where l.id_lote = idactivo Select l).FirstOrDefault()
                lo.facturado = 1
                lo.nrofactura = nrofactura.ToString()
                lo.fecha_factura = hoy
                contex.ApplyCurrentValues("lotes", lo)
                contex.SaveChanges()
                contex.AcceptAllChanges()
            End If
        Next

        glob.modificafac(nrofactura)
        glob.valoresini()


    End Sub

End Class
