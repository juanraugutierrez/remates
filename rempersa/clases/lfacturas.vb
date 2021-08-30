Public Class lfacturas
    Public contex As New persaEntities11

    Private Property var As System.Linq.IQueryable(Of lotes)
    Private Property quer As System.Linq.IQueryable

    Public Function lista() As IEnumerable
        var = From c In contex.facturas Select c
        Return var

    End Function

    Public Function listafacturas() As IQueryable
        quer = (From f In contex.facturas Join c In contex.clientes On c.id_cliente Equals f.id_cliente Where f.id_nomina = 0 Order By f.nro_factura Ascending Select New With {f.id_factura, c.razon_social, f.nro_factura, f.fecha, f.ingreso_liquido, f.garantia, f.id_estado})
        Return quer
    End Function

    Public Function listafacturas(id As Integer, cu As String) As IQueryable
        quer = (From f In contex.facturas Join c In contex.clientes On c.id_cliente Equals f.id_cliente Where f.id_nomina = id Order By f.nro_factura Ascending Select New With {f.id_factura, c.razon_social, f.nro_factura, f.fecha, f.ingreso_liquido, f.id_estado})
        Return quer
    End Function

    Public Function listafacturas(numero As Integer) As Object
        Dim v As Object
        v = (From f In contex.facturas Join c In contex.clientes On f.id_cliente Equals c.id_cliente Where CInt(f.nro_factura) = numero And f.id_estado = 1 And f.id_nomina = 0 Select New With {f.id_factura, c.razon_social, f.nro_factura, f.fecha, f.ingreso_liquido}).ToList()
        Return v
    End Function

    Public Function muestrafactura(numero As Integer) As Object
        Dim v As New Facturaview
        v = (From f In contex.facturas Join c In contex.clientes On f.id_cliente Equals c.id_cliente _
             Join co In contex.comunas On f.id_comuna Equals co.id_comuna _
             Join ti In contex.tipo_pago On f.id_condicion_pago Equals ti.id_tipopago
             Where CInt(f.nro_factura) = numero And f.id_estado = 1 And f.fecha >= "01-02-2017" _
             Select New Facturaview With {.id_factura = f.id_factura, .comuna = co.comuna, .razon_social = c.razon_social, .giro = c.giro, .direccion = c.direccion, .fecha = f.fecha, .nro_factura = f.nro_factura, .monto_neto = f.monto_neto, _
                                          .monto_comision = f.monto_comision, .mto_cargos = f.mto_cargos, .monto_iva = f.monto_iva, .monto_total = f.monto_total, _
                                          .garantia = f.garantia, .ingreso_liquido = f.ingreso_liquido, .nro_lotes = f.nro_lotes, .id_nomina = f.id_nomina, .rut = c.rut}).SingleOrDefault
        Return v
    End Function
    Public Function muestrafacturaA(numero As Integer) As Object
        Dim v As New Facturaview
        v = (From f In contex.facturas Join c In contex.clientes On f.id_cliente Equals c.id_cliente _
             Join co In contex.comunas On f.id_comuna Equals co.id_comuna _
             Join ti In contex.tipo_pago On f.id_condicion_pago Equals ti.id_tipopago
             Where CInt(f.nro_factura) = numero And f.id_estado = 1 And f.fecha < "01-02-2017" _
             Select New Facturaview With {.id_factura = f.id_factura, .comuna = co.comuna, .razon_social = c.razon_social, .giro = c.giro, .direccion = c.direccion, .fecha = f.fecha, .nro_factura = f.nro_factura, .monto_neto = f.monto_neto, _
                                          .monto_comision = f.monto_comision, .mto_cargos = f.mto_cargos, .monto_iva = f.monto_iva, .monto_total = f.monto_total, _
                                          .garantia = f.garantia, .ingreso_liquido = f.ingreso_liquido, .nro_lotes = f.nro_lotes, .id_nomina = f.id_nomina, .rut = c.rut}).SingleOrDefault
        Return v
    End Function

    Public Function vdetallefactura(id As Integer)
        quer = (From d In contex.detalle_factura Where d.id_factura = id
                Select d)
        Return quer
    End Function
    Public Function vdetallefactura(id As Integer, t As String)
        quer = (From d In contex.detalle_factura Join lo In contex.lotes On d.id_lote Equals lo.id_lote Where d.id_factura = id
                Select New With {d.descripcion, d.nro_lote, d.sub_lote, d.cantidad, lo.nro_unidades_final, d.precio_unitario, d.precio_total})
        Return quer
    End Function
    Public Function vdetallefactura(id As Integer, t As Integer) As Integer
        t = (From d In contex.detalle_factura Join lo In contex.lotes On d.id_lote Equals lo.id_lote Where d.id_factura = id Select d.id_lote).Count
        Return t
    End Function


    Public Function anula(idfactura As Integer) As String
        Dim factura As String
        Try
            Try
                factura = (From c In contex.facturas Where c.id_factura = idfactura And c.id_nomina = 0 Select c.id_nomina).SingleOrDefault()
                If Not (IsNothing(factura)) And factura <> 0 Then
                    Return "Error al anular factura," & vbCrLf & "Factura asociada a nomina " & factura.ToString()
                End If
            Catch ex As Exception
                Return "Error al Anular factura"
            End Try





            contex.ExecuteStoreCommand("anulafactura {0}", idfactura)
            contex.SaveChanges()
            contex.AcceptAllChanges()
            Return "Anulacion  de Factura Ejecutada"

        Catch ex As Exception
            Return "Error al anular factura"
        End Try
    End Function
    Public Function elimina(idfactura As Integer) As String
        Dim factura As String
        Try
            Try
                factura = (From c In contex.facturas Where c.id_factura = idfactura And c.id_nomina = 0 Select c.id_nomina).SingleOrDefault()
                If Not (IsNothing(factura)) And factura > 0 Then
                    Return "Error al eliminad factura," & vbCrLf & "Factura asociada a nomina " & factura.ToString()
                End If
            Catch ex As Exception
                Return "Error al Eliminar factura"
            End Try
            Try
                contex.ExecuteStoreCommand("anulafactura {0}", idfactura)
                contex.SaveChanges()
                contex.AcceptAllChanges()
            Catch ex As Exception
                Return "Error al anular factura no se eliminara factura"
            End Try

            contex.ExecuteStoreCommand("elimina_factura {0}", idfactura)
            contex.SaveChanges()
            contex.AcceptAllChanges()
            Return "Factura Eliminada"
        Catch ex As Exception
            Return "Error al Eliminar Factura"
        End Try
    End Function

End Class
