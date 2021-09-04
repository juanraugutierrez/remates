Public Class Ccalculaliquidacion
    Public idremate As Integer
    Public mandante As String
    Public sucursal As String
    Public lisdetalle As List(Of detalle_liquidacion)
    Dim factur As New EFactura
    Dim nroinicio, nrofinal As Integer


    Sub recibe_datos(fa As EFactura, llotes As List(Of lotesliquidacionview), nroii As Integer, cantidadliq As Integer, idmandante As Integer, porcentaje As Decimal, afe As Boolean, fecha As DateTime)

        Dim nroliquidacion As Integer = nroii
        Dim i As Integer = 0
        Dim ppp As New List(Of detalle_liquidacion)
        Dim pp As New detalle_liquidacion

        For Each t In llotes
            i += 1
            pp = Nothing
            pp = New detalle_liquidacion
            pp.id_liquidacion = 0
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
            ppp.Add(pp)
            If (cantidadliq > 1) And ((i / 20 = i \ 20) Or (llotes.Count = i)) Then
                calculacarga(ppp, porcentaje, afe, idmandante, nroliquidacion, fecha)
                nroliquidacion += 1
                ppp = Nothing
                ppp = New List(Of detalle_liquidacion)
            End If
        Next
        If (cantidadliq = 1) Then
            calculacarga(ppp, porcentaje, afe, idmandante, nroliquidacion, fecha, False)
        End If



    End Sub


    Sub calculacarga(ppp As List(Of detalle_liquidacion), porcentaje As Decimal, afe As Boolean, idmandante As Integer, nroliquidacion As Integer, fecha As DateTime)
        Dim mm As New liquidacion
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
            neto += t.precio_final
        Next
        comision = neto * porcentaje
        comision = comision / 100
        comision = Math.Ceiling(comision)
        If afe Then
            impues_recaudado = Math.Ceiling(neto * 0.19)
            iva = Math.Ceiling((comision) * 0.19)
        Else
            impues_recaudado = 0
            iva = Math.Ceiling((comision) * 0.19)
        End If
        liquido = (neto + impues_recaudado + ila) - (comision + iva)

        mm.comision = CDec(comision)
        mm.id_mandante = idmandante
        mm.tasa_comision = porcentaje
        mm.mto_neto = neto
        mm.mto_impreacudado = impues_recaudado
        mm.iva = iva
        mm.mto_ila = ila
        mm.liquido = liquido
        mm.nro_liquidacion = nroliquidacion
        mm.nro_lotes = ppp.Count + 1
        mm.publicidad = publicidad
        mm.flete = fletes
        mm.fecha = fecha.ToShortDateString & " " & fecha.ToLongTimeString
        Dim liqu As New liquidaciones
        Dim id_Factu As Integer = liqu.carga(mm)
        For Each t In ppp
            t.id_liquidacion = id_Factu
            liqu.cargadetalle(t)
        Next
        Dim liquiele As New factura_electronica.dte_liquidacion

        liquiele.esquema()
        Dim hoy As String = String.Concat(fecha.Year.ToString(), "-", fecha.Month.ToString("0#"), "-", fecha.Day.ToString("0#"))

        liquiele.docucabecera("43", nroliquidacion.ToString(), hoy)
        liquiele.docuemisor("76520318-K", "Remates Persa Spa", "Remates", "726000", "Camino Lo Boza 8410, Galpon 5", "Renca", "Santiago")

        Dim repec As New receptorview
        repec = (From ma In contex.mandantes Where ma.id_mandante = idmandante Select New receptorview With {.razonsocial = ma.razonsocial_mandante, .giro = ma.giro, .rut = ma.rut_mandante, .direccion = ma.direccion_mandante, .ciudad = "", .comuna = ma.id_comuna}).FirstOrDefault()
        repec.comuna = (From co In contex.comunas Where co.id_comuna = repec.comuna Select co.comuna).FirstOrDefault()
        repec.ciudad = "  "
        If repec.giro.Length > 40 Then
            repec.giro = repec.giro.Substring(0, 40)
        End If
        If repec.razonsocial.Length > 40 Then
            repec.razonsocial = repec.razonsocial.Substring(0, 40)
        End If
        If repec.direccion.Length > 69 Then
            repec.direccion = repec.direccion.Substring(0, 69)
        End If
        liquiele.docureceptor(repec.rut, repec.razonsocial, repec.giro, repec.direccion, repec.comuna, repec.ciudad)
        'liquiele.docureceptor("96792430-K", "SODIMAC S.A.", "VENTA AL MAYOR DE MATERIALES DE CONSTRUCCION", "AVDA. EDUARDO FREI MONTALVA 3092", "Renca", "Santiago")
        liquiele.docutotaliqui(neto.ToString(), "19", impues_recaudado.ToString(), liquido.ToString(), comision.ToString(), iva.ToString())
        Dim tasa As String
        tasa = porcentaje.ToString()
        tasa = tasa.Replace(",", ".")
        liquiele.docucomision("1", "C", "COMISION MARTILLERO", mm.tasa_comision, mm.comision.ToString(), 0, iva.ToString())
        Dim i = 1
        Dim valorunitario As String

        For Each t In ppp

            If t.precio_unitario * t.unidades <> t.precio_final Then
                valorunitario = (Decimal.Round(CDec((t.precio_final / t.unidades)), 4)).ToString()
                valorunitario = valorunitario.Replace(",", ".")
                liquiele.docudetalle(i.ToString, t.descripcion.ToString(), t.unidades.ToString(), "Lote", valorunitario, t.precio_final.ToString(), "interno", "Lote " & t.nro_lote & "" & t.sub_lote)
            Else
                liquiele.docudetalle(i.ToString, t.descripcion.ToString(), t.unidades.ToString(), "Lote", t.precio_unitario.ToString(), t.precio_final.ToString(), "interno", "Lote " & t.nro_lote & "" & t.sub_lote)
            End If
            i += 1
        Next
        'i += 1
        'liquiele.docudetalle(i.ToString, "Comision Martillero", "1", "Unid", St mm.comision.ToString()), String.Concat("-", mm.comision.ToString()), "interno", "Comision ")
        Dim ff As String = String.Concat("SON: ", Num2Text(liquido).ToUpper(), " PESOS.-")
        liquiele.docuadjuntos(ff, "TOSHIBA e-STUDIO3500c PS3", "3")
        liquiele.grabal(String.Concat("Liquidacionfctura_P_", nroliquidacion.ToString()), "c:\xml_factura\")
        liquiele.grabal(String.Concat("Liquidacionfctura_", nroliquidacion.ToString()), My.Settings.rutafac)

        Dim lo As New lotes
        Dim idactivo As Integer

        For Each t In ppp
            lo = Nothing
            lo = New lotes
            idactivo = t.id_lote
            lo = (From lotesl In contex.lotes Where lotesl.id_lote = idactivo Select lotesl).FirstOrDefault()
            lo.liquidado = 1
            lo.nro_liquidacion = nroliquidacion.ToString()
            lo.fecha_liquidacion = hoy
            lo.observaciones = lo.observaciones.Trim + " n°liqui:" & nroliquidacion.ToString() & " liqui:" + Now.ToShortDateString + " " + Now.ToLongTimeString()
            contex.ApplyCurrentValues("lotes", lo)
            contex.SaveChanges()
            contex.AcceptAllChanges()

        Next




        Dim re As New Creporte_excel
        Dim r As Integer
        r = CInt(nroliquidacion.ToString())

        Dim l As New List(Of lotesliquidacionview)
        l = (From li In contex.liquidacion Join de In contex.detalle_liquidacion On li.id_liquidacion Equals de.id_liquidacion Join lotesl In contex.lotes On de.id_lote Equals lotesl.id_lote Where li.nro_liquidacion = nroliquidacion And li.id_liquidacion = id_Factu Order By CInt(de.nro_lote) Ascending, de.sub_lote Ascending
             Select New lotesliquidacionview With {.idlote = de.id_lote, .idremate = 0, .nrolot = de.nro_lote,
                                                   .nrosblote = de.sub_lote, .descripcion = de.descripcion,
                                                   .unidades = de.unidades, .Punitario = de.precio_unitario,
                                                   .Total = de.precio_final, .mandante = de.mandante,
                                                   .sucursal = de.sucursal,
                                                   .observacion = lo.observaciones,
                                                   .fecha = li.fecha,
                                                   .afecto = de.afecto}).ToList()
        re.CreaCabecera(r)
        re.detalleliquidaciones(l, r)
        re.CIERRA("Detalle_liquidacion", r)
        MsgBox("Detalle Grabado" & vbCrLf & "Detalle Liquidacion N°:" & nroliquidacion.ToString(), MsgBoxStyle.Critical, "Detalle")

    End Sub

    Sub calculacarga(ppp As List(Of detalle_liquidacion), porcentaje As Decimal, afe As Boolean, idmandante As Integer, nroliquidacion As Integer, fecha As DateTime, detalle As Boolean)
        Dim mm As New liquidacion
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
            neto += t.precio_final
        Next
        comision = neto * porcentaje
        comision = comision / 100
        comision = Math.Ceiling(comision)
        If afe Then
            impues_recaudado = Math.Ceiling(neto * 0.19)
            iva = Math.Ceiling((comision) * 0.19)
        Else
            impues_recaudado = 0
            iva = Math.Ceiling((comision) * 0.19)
        End If
        liquido = (neto + impues_recaudado + ila) - (comision + iva)

        mm.comision = CDec(comision)
        mm.id_mandante = idmandante
        mm.tasa_comision = porcentaje
        mm.mto_neto = neto
        mm.mto_impreacudado = impues_recaudado
        mm.iva = iva
        mm.mto_ila = ila
        mm.liquido = liquido
        mm.nro_liquidacion = nroliquidacion
        mm.nro_lotes = ppp.Count + 1
        mm.publicidad = publicidad
        mm.flete = fletes
        mm.fecha = fecha.ToShortDateString & " " & fecha.ToLongTimeString
        Dim liqu As New liquidaciones
        Dim id_Factu As Integer = liqu.carga(mm)
        For Each t In ppp
            t.id_liquidacion = id_Factu
            liqu.cargadetalle(t)
        Next
        Dim liquiele As New factura_electronica.dte_liquidacion_2

        liquiele.esquema()
        Dim hoy As String = String.Concat(fecha.Year.ToString(), "-", fecha.Month.ToString("0#"), "-", fecha.Day.ToString("0#"))

        liquiele.docucabecera("43", nroliquidacion.ToString(), hoy)
        liquiele.docuemisor("76520318-K", "Remates Persa Spa", "Remates", "726000", "Camino Lo Boza 8410, Galpon 5", "Renca", "Santiago")

        Dim repec As New receptorview
        repec = (From ma In contex.mandantes Where ma.id_mandante = idmandante Select New receptorview With {.razonsocial = ma.razonsocial_mandante, .giro = ma.giro, .rut = ma.rut_mandante, .direccion = ma.direccion_mandante, .ciudad = "", .comuna = ma.id_comuna}).FirstOrDefault()
        repec.comuna = (From co In contex.comunas Where co.id_comuna = repec.comuna Select co.comuna).FirstOrDefault()
        repec.ciudad = "  "
        If repec.giro.Length > 40 Then
            repec.giro = repec.giro.Substring(0, 40)
        End If
        If repec.razonsocial.Length > 40 Then
            repec.razonsocial = repec.razonsocial.Substring(0, 40)
        End If
        If repec.direccion.Length > 69 Then
            repec.direccion = repec.direccion.Substring(0, 69)
        End If
        liquiele.docureceptor(repec.rut, repec.razonsocial, repec.giro, repec.direccion, repec.comuna, repec.ciudad)
        'liquiele.docureceptor("96792430-K", "SODIMAC S.A.", "VENTA AL MAYOR DE MATERIALES DE CONSTRUCCION", "AVDA. EDUARDO FREI MONTALVA 3092", "Renca", "Santiago")
        liquiele.docutotaliqui(neto.ToString(), "19", impues_recaudado.ToString(), liquido.ToString(), comision.ToString(), iva.ToString())
        Dim tasa As String
        tasa = porcentaje.ToString()
        tasa = tasa.Replace(",", ".")
        liquiele.docucomision("1", "C", "COMISION MARTILLERO", mm.tasa_comision, mm.comision.ToString(), 0, iva.ToString())
        Dim i = 1
        Dim valorunitario As String


        Dim datotipoR As String = InputBox("ingresa dato")
        Dim datoTipoR1 As String = InputBox("ingresa dato")

        liquiele.docudetalle(i.ToString, datoTipoR1, 1, "UNID", neto.ToString(), neto.ToString, "interno", "Item", datotipoR)

        'i += 1
        'liquiele.docudetalle(i.ToString, "Comision Martillero", "1", "Unid", St mm.comision.ToString()), String.Concat("-", mm.comision.ToString()), "interno", "Comision ")
        Dim ff As String = String.Concat("SON: ", Num2Text(liquido).ToUpper(), " PESOS.-")
        liquiele.docuadjuntos(ff, "TOSHIBA e-STUDIO3500c PS3", "3")
        liquiele.grabal(String.Concat("Liquidacionfctura_P_", nroliquidacion.ToString()), "c:\xml_factura\")
        liquiele.grabal(String.Concat("Liquidacionfctura_", nroliquidacion.ToString()), My.Settings.rutafac)

        Dim lo As New lotes
        Dim idactivo As Integer

        For Each t In ppp
            lo = Nothing
            lo = New lotes
            idactivo = t.id_lote
            lo = (From lotesl In contex.lotes Where lotesl.id_lote = idactivo Select lotesl).FirstOrDefault()
            lo.liquidado = 1
            lo.nro_liquidacion = nroliquidacion.ToString()
            lo.fecha_liquidacion = hoy
            lo.observaciones = lo.observaciones.Trim + " n°liqui:" & nroliquidacion.ToString() & " liqui:" + Now.ToShortDateString + " " + Now.ToLongTimeString()
            contex.ApplyCurrentValues("lotes", lo)
            Try
                contex.SaveChanges()
                contex.AcceptAllChanges()
            Catch ex As Exception

            End Try


        Next




        Dim re As New Creporte_excel
        Dim r As Integer
        r = CInt(nroliquidacion.ToString())

        Dim l As New List(Of lotesliquidacionview)
        l = (From li In contex.liquidacion Join de In contex.detalle_liquidacion On li.id_liquidacion Equals de.id_liquidacion Join lotesl In contex.lotes On de.id_lote Equals lotesl.id_lote Where li.nro_liquidacion = nroliquidacion And li.id_liquidacion = id_Factu Order By CInt(de.nro_lote) Ascending, de.sub_lote Ascending
             Select New lotesliquidacionview With {.idlote = de.id_lote, .idremate = 0, .nrolot = de.nro_lote,
                                                   .nrosblote = de.sub_lote, .descripcion = de.descripcion,
                                                   .unidades = de.unidades, .Punitario = de.precio_unitario,
                                                   .Total = de.precio_final, .mandante = de.mandante,
                                                   .sucursal = de.sucursal,
                                                   .observacion = lo.observaciones,
                                                   .fecha = li.fecha,
                                                   .afecto = de.afecto}).ToList()
        re.CreaCabecera(r)
        re.detalleliquidaciones(l, r)
        re.CIERRA("Detalle_liquidacion", r)
        MsgBox("Detalle Grabado" & vbCrLf & "Detalle Liquidacion N°:" & nroliquidacion.ToString(), MsgBoxStyle.Critical, "Detalle")

    End Sub


    Sub calcula(idremate, mandante, sucursal)




    End Sub
    Sub creareporte()

    End Sub


End Class
