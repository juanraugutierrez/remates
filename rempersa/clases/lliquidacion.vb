Public Class lliquidacion
    Public contex As New persaEntities11

    Private Property var As System.Linq.IQueryable(Of lotes)
    Private Property quer As System.Linq.IQueryable

    Public Function lista() As IEnumerable
        var = From l In contex.liquidacion Select l
        Return var

    End Function


    Public Function muestraliquidacion(numero As Integer) As Object
        Dim v As New LiquidacionView

        v = (From f In contex.liquidacion Join c In contex.mandantes On f.id_mandante Equals c.id_mandante _
             Join co In contex.comunas On c.id_comuna Equals co.id_comuna _
             Where CInt(f.nro_liquidacion) = numero And f.mto_neto > 0 And f.fecha >= "01-02-2017" _
             Select New LiquidacionView With {.id_liquidacion = f.id_liquidacion, .comuna = co.comuna, .razon_social = c.razonsocial_mandante, .giro = c.giro, .direccion = c.direccion_mandante, .fecha = f.fecha, .nro_liquidacion = f.nro_liquidacion, .monto_neto = f.mto_neto, _
                                          .monto_impuestoreca = f.mto_impreacudado, .monto_iva = f.iva, .monto_ila = f.mto_ila, .liquido_apagar = f.liquido, .mto_comision = f.comision,
                                           .monto_flete = f.flete, .nro_lotes = 0, .rut = c.rut_mandante}).SingleOrDefault
        Return v
    End Function

    Public Function muestraliquidacionA(numero As Integer) As Object
        Dim v As New LiquidacionView

        v = (From f In contex.liquidacion Join c In contex.mandantes On f.id_mandante Equals c.id_mandante _
             Join co In contex.comunas On c.id_comuna Equals co.id_comuna _
             Where CInt(f.nro_liquidacion) = numero And f.mto_neto > 0 And f.fecha < "01-02-2017" _
             Select New LiquidacionView With {.id_liquidacion = f.id_liquidacion, .comuna = co.comuna, .razon_social = c.razonsocial_mandante, .giro = c.giro, .direccion = c.direccion_mandante, .fecha = f.fecha, .nro_liquidacion = f.nro_liquidacion, .monto_neto = f.mto_neto, _
                                          .monto_impuestoreca = f.mto_impreacudado, .monto_iva = f.iva, .monto_ila = f.mto_ila, .liquido_apagar = f.liquido, .mto_comision = f.comision,
                                           .monto_flete = f.flete, .nro_lotes = 0, .rut = c.rut_mandante}).SingleOrDefault
        Return v
    End Function

    Public Function vdetalleliquidacion(id As Integer)
        quer = (From d In contex.detalle_liquidacion Where d.id_liquidacion = id
                Select d)
        Return quer
    End Function

    Public Function vdetalleliquidacion(id As Integer, t As String)
        quer = (From d In contex.detalle_liquidacion Join lo In contex.lotes On d.id_lote Equals lo.id_lote Where d.id_liquidacion = id
                Select New With {d.descripcion, d.nro_lote, d.sub_lote, d.unidades, lo.nro_unidades_final, d.precio_unitario, d.precio_final})
        Return quer
    End Function
    Public Function vdetallefactura(id As Integer, t As Integer) As Integer
        t = (From d In contex.detalle_liquidacion Join lo In contex.lotes On d.id_lote Equals lo.id_lote Where d.id_liquidacion = id Select d.id_lote).Count
        Return t
    End Function

    Public Function listafacturas() As IQueryable
        quer = (From l In contex.liquidacion Join m In contex.mandantes On l.id_mandante Equals m.id_mandante Order By l.nro_liquidacion Ascending Select New With {l.id_liquidacion, m.razonsocial_mandante, l.nro_liquidacion, l.fecha, l.liquido})
        Return quer
    End Function


    Public Function listafacturas(numero As Integer) As Object
        Dim v As Object
        v = (From l In contex.liquidacion Join m In contex.mandantes On l.id_mandante Equals m.id_mandante Where CInt(l.nro_liquidacion) = numero Select New With {l.id_liquidacion, m.razonsocial_mandante, l.nro_liquidacion, l.fecha, l.liquido}).ToList()
        Return v
    End Function

    Public Function listaliquidaciones(numero As Integer) As Object
        Dim v As Object
        v = (From l In contex.liquidacion Join m In contex.mandantes On l.id_mandante Equals m.id_mandante Where CInt(l.nro_liquidacion) = numero Select New With {l.id_liquidacion, m.razonsocial_mandante, l.nro_liquidacion, l.fecha, l.liquido}).ToList()
        Return v
    End Function

    'Public Function muestrafactura(numero As Integer) As Object
    '    Dim v As New Facturaview
    '    v = (From f In contex.facturas Join c In contex.clientes On f.id_cliente Equals c.id_cliente _
    '         Join co In contex.comunas On f.id_comuna Equals co.id_comuna _
    '         Join ti In contex.tipo_pago On f.id_condicion_pago Equals ti.id_tipopago
    '         Where CInt(f.nro_factura) = numero And f.id_estado = 1 _
    '         Select New Facturaview With {.id_factura = f.id_factura, .comuna = co.comuna, .razon_social = c.razon_social, .giro = c.giro, .direccion = c.direccion, .fecha = f.fecha, .nro_factura = f.nro_factura, .monto_neto = f.monto_neto, _
    '                                      .monto_comision = f.monto_comision, .mto_cargos = f.mto_cargos, .monto_iva = f.monto_iva, .monto_total = f.monto_total, _
    '                                      .garantia = f.garantia, .ingreso_liquido = f.ingreso_liquido, .nro_lotes = f.nro_lotes, .id_nomina = f.id_nomina, .rut = c.rut}).SingleOrDefault
    '    Return v
    'End Function

    'Public Function vdetallefactura(id As Integer)
    '    quer = (From d In contex.detalle_factura Where d.id_factura = id
    '         Select d)
    '    Return quer
    'End Function
    'Public Function vdetallefactura(id As Integer, t As String)
    '    quer = (From d In contex.detalle_factura Join lo In contex.lotes On d.id_lote Equals lo.id_lote Where d.id_factura = id
    '            Select New With {d.descripcion, d.nro_lote, d.sub_lote, d.cantidad, lo.nro_unidades_final, d.precio_unitario, d.precio_total})
    '    Return quer
    'End Function
    'Public Function vdetallefactura(id As Integer, t As Integer) As Integer
    '    t = (From d In contex.detalle_factura Join lo In contex.lotes On d.id_lote Equals lo.id_lote Where d.id_factura = id Select d.id_lote).Count
    '    Return t
    'End Function


    Public Function anula(nroliquidacion As Integer) As String
        Try
            contex.ExecuteStoreCommand("anula_liquidacion {0}", nroliquidacion)
            contex.SaveChanges()
            contex.AcceptAllChanges()
            Return "Anulacion  de Liquidacion Ejecutada"

        Catch ex As Exception
            Return "Error al anular factura"
        End Try
    End Function
    'Public Function elimina(idfactura As Integer) As String
    '    Dim factura As String
    '    Try
    '        Try
    '            factura = (From c In contex.facturas Where c.id_factura = idfactura And c.id_nomina = 0 Select c.id_nomina).SingleOrDefault()
    '            If Not (IsNothing(factura)) And factura > 0 Then
    '                Return "Error al eliminad factura," & vbCrLf & "Factura asociada a nomina " & factura.ToString()
    '            End If
    '        Catch ex As Exception
    '            Return "Error al Eliminar factura"
    '        End Try
    '        Try
    '            contex.ExecuteStoreCommand("anulafactura {0}", idfactura)
    '            contex.SaveChanges()
    '            contex.AcceptAllChanges()
    '        Catch ex As Exception
    '            Return "Error al anular factura no se eliminara factura"
    '        End Try

    '        contex.ExecuteStoreCommand("elimina_factura {0}", idfactura)
    '        contex.SaveChanges()
    '        contex.AcceptAllChanges()
    '        Return "Factura Eliminada"
    '    Catch ex As Exception
    '        Return "Error al Eliminar Factura"
    '    End Try
    'End Function

End Class
