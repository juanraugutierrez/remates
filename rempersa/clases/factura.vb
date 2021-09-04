Public Class factura
    Public contex As New persaEntities11

    Private Property var As System.Linq.IQueryable(Of lotes)
    Private Property quer As System.Linq.IQueryable

    Public Function listaitem() As IEnumerable
        var = From c In contex.lotes Select c
        Return var

    End Function

    'Public Function generafatura(t As Object) As Boolean
    '    'Dim factu As New facturas
    '    'factu.nro_factura = t.NumeroFactura
    '    'factu.id_cliente=t.


    'End Function

    Public Function listaclientes(rema As Integer, afe As Boolean, ila As Boolean) As IQueryable
        quer = (From c In contex.lotes Where c.id_remate = rema And c.adjudicatario <> "SIN POSTOR" And c.facturado <> True And c.afecto = afe And c.ila = ila Select c.adjudicatario).Distinct()
        Return quer
    End Function

    Public Function listamandantes(rema As Integer, afecto As Boolean) As IQueryable
        quer = (From c In contex.lotes Where c.id_remate = rema And c.facturado = True And c.afecto = afecto And c.liquidado = False Select c.mandante).Distinct()
        Return quer
    End Function

    Public Function listamandantes() As IQueryable
        quer = (From c In contex.lotes Join r In contex.remates_mercaderia On c.id_remate Equals r.id_remate Where c.facturado = True And c.liquidado = False And c.precio_final > 0 And (c.mandante <> "Sin Postor" And c.mandante <> "") Select c.mandante).Distinct()
        Return quer
    End Function

    Public Function lremate(rema As String) As Integer
        Dim quer As Integer
        quer = (From c In contex.remates_mercaderia Where c.codigo_remate = rema Order By CInt(c.codigo_remate) Descending Select c.id_remate).First
        Return quer
    End Function
    Public Function lremates() As IQueryable
        quer = (From c In contex.remates_mercaderia Join l In contex.lotes On c.id_remate Equals l.id_remate Where l.liquidado = 0 And c.estado_remate <> 5 Order By CInt(c.id_remate) Descending Select c.id_remate, c.codigo_remate).Distinct().OrderByDescending(Function(x) x.id_remate)
        Return quer
    End Function
    Public Function lremates(id As Integer) As Integer
        Dim valor As Integer
        valor = (From c In contex.remates_mercaderia Join l In contex.lotes On c.id_remate Equals l.id_remate Where l.id_lote = id Select c.id_remate).Distinct().FirstOrDefault()
        Return valor
    End Function

    Public Function fremates(codre As String) As String
        Dim fe As DateTime
        fe = (From c In contex.remates_mercaderia Where c.codigo_remate = codre Select c.fecha_remate).First
        Return fe
    End Function

    Public Function lotfacturables(codre As Integer, cliente As String, afe As Boolean) As IQueryable
        Dim mm As Object
        mm = (From c In contex.lotes Where c.id_remate = codre And c.adjudicatario = cliente And c.facturado = False And c.adjudicatario <> "SIN POSTOR" And c.afecto = afe Select c)
        Return mm
    End Function
    Public Function lotfacturables1(codre As Integer, cliente As String, afe As Boolean) As Object
        Dim mm As Object
        mm = (From c In contex.lotes Where c.id_remate = codre And c.adjudicatario = cliente And c.facturado = False And c.adjudicatario <> "SIN POSTOR" And c.afecto = afe Select c).ToList()
        Return mm
    End Function
    Public Function lotfacturablesd(codre As Integer, cliente As String, afe As Boolean) As IQueryable
        Dim mm As Object
        mm = (From c In contex.lotes Where c.id_remate = codre And c.adjudicatario = cliente And c.facturado = False And c.desistido = False And c.adjudicatario <> "SIN POSTOR" And c.afecto = afe Select c).Distinct()
        Return mm
    End Function

    Public Function tipospagos() As IQueryable
        Dim mm As Object
        mm = (From c In contex.tipo_pago Select c).Distinct
        Return mm
    End Function



    Public Sub lotfacturablesfactu(codre As Integer, cliente As String)
        Dim mm As Object
        mm = (From c In contex.lotes Where c.id_remate = codre And c.adjudicatario = cliente And c.desistido = 0 And c.facturado = False And c.adjudicatario <> "SIN POSTOR" Select c)

        For Each t As lotes In mm
            't.facturado = True
            'contex.SaveChanges()
            'contex.AcceptAllChanges()
            contex.ExecuteStoreCommand("update lotes set facturado=1 where id_lote={0} and id_remate={1}", t.id_lote, t.id_remate)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Next
    End Sub



    Public Sub lotfacturablesliquidado(codre As Integer, cliente As String)
        Dim mm As Object
        mm = (From c In contex.lotes Where c.id_remate = codre And c.adjudicatario = cliente And c.desistido = 0 And c.facturado = True And c.adjudicatario <> "SIN POSTOR" Select c)

        For Each t As lotes In mm
            't.facturado = True
            'contex.SaveChanges()
            'contex.AcceptAllChanges()
            contex.ExecuteStoreCommand("update lotes set liquidado=1 where id_lote={0} and id_remate={1}", t.id_lote, t.id_remate)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Next
    End Sub
    Public Function lotliquidablest(codre As Integer, cliente As String, afecto As Boolean) As Object
        Dim mm As Object
        mm = (From c In contex.lotes Where c.id_remate = codre And c.mandante = cliente And c.facturado = True And c.afecto = afecto And c.liquidado = False And c.precio_final > 0 Select New With {c.id_lote, c.id_remate, Now, c.nro_lote, c.sub_lote, c.nro_unidades_final, c.descripcion, c.precio_unitario_final, c.precio_final, c.mandante, c.sucursal, c.afecto, c.facturado}).ToList()
        Return mm
    End Function





    Public Function lotliquidables(codre As Integer, cliente As String, afecto As Boolean) As IQueryable
        Dim mm As Object
        mm = (From c In contex.lotes Where c.id_remate = codre And c.mandante = cliente And c.facturado = True And c.liquidado = False And c.afecto = afecto And c.precio_final > 0 Select c).Distinct
        Return mm
    End Function
    Public Function lotliquidables(codre As Integer, cliente As String, afecto As Boolean, mandantes As String, sucursales As String) As IQueryable
        Dim mm As Object
        mm = (From c In contex.lotes Where c.id_remate = codre And c.mandante = cliente And c.facturado = True And c.liquidado = False And c.afecto = afecto And c.precio_final > 0 And c.mandante = mandantes And c.sucursal = sucursales Select c).Distinct
        Return mm
    End Function

    Public Function lotliquidablessucu(codre As Integer, cliente As String, afecto As Boolean, sucursal As String) As IQueryable
        Dim mm As Object
        mm = (From c In contex.lotes Where c.id_remate = codre And c.mandante = cliente And c.facturado = True And c.liquidado = False And c.afecto = afecto And c.precio_final > 0 And c.sucursal = sucursal Select c).Distinct
        Return mm
    End Function

    Public Function lotliquidablessucu(cliente As String, afecto As Boolean, sucursal As String) As IQueryable
        Dim mm As Object
        mm = (From c In contex.lotes Join r In contex.remates_mercaderia On c.id_remate Equals r.id_remate Where r.estado_remate <> 5 And c.mandante = cliente And c.facturado = True And c.liquidado = False And c.afecto = afecto And c.precio_final > 0 And c.sucursal = sucursal Select c).Distinct
        Return mm
    End Function
    Public Function lotliquidables(cliente As String, afecto As Boolean) As IQueryable
        Dim mm As Object
        mm = (From c In contex.lotes Join r In contex.remates_mercaderia On c.id_remate Equals r.id_remate Where r.estado_remate <> 5 And c.mandante = cliente And c.facturado = True And c.liquidado = False And c.afecto = afecto And c.precio_final > 0 Select c).Distinct
        Return mm
    End Function

    Public Function lotliquidables(id As Integer) As Object
        Dim mm As Object
        mm = (From c In contex.lotes Join d In contex.detalle_liquidacion On c.id_lote Equals d.id_lote Where d.id_liquidacion = id Select c).Distinct.ToList()
        Return mm
    End Function
    Public Function lotliquidables(cliente As String, afecto As Boolean, mandantes As String, sucursales As String) As IQueryable
        Dim mm As Object
        mm = (From c In contex.lotes Join r In contex.remates_mercaderia On c.id_remate Equals r.id_remate Where r.estado_remate <> 5 And c.mandante = cliente And c.facturado = True And c.liquidado = False And c.afecto = afecto And c.precio_final > 0 And c.mandante = mandantes And c.sucursal = sucursales Select c).Distinct
        Return mm
    End Function
    Public Function lotliquidablesafec(codre As Integer, cliente As String) As IQueryable
        Dim mm As Object
        mm = (From c In contex.lotes Where c.id_remate = codre And c.mandante = cliente And c.facturado = True And c.liquidado = False And c.afecto = True Select c).Distinct
        Return mm
    End Function

    Public Function lotliquidablesnafe(codre As Integer, cliente As String) As IQueryable
        Dim mm As Object
        mm = (From c In contex.lotes Where c.id_remate = codre And c.mandante = cliente And c.facturado = True And c.liquidado = False And c.afecto = False Select c).Distinct
        Return mm
    End Function

    Public Function lotfacturTotal(codre As Integer, cliente As String, afe As Boolean) As Long
        Dim var As Long = 0
        Try
            var = (From c In contex.lotes Where c.id_remate = codre And c.adjudicatario = cliente And c.facturado = False And c.afecto = afe Select c Group By c.adjudicatario Into total = Sum(c.precio_final) Select total).First()
            Return var
        Catch ex As Exception
            var = 0
            Return var
        End Try

    End Function
    Public Function lotfacturTotald(codre As Integer, cliente As String, afe As Boolean) As Long
        Dim var As Long = 0
        Try
            var = (From c In contex.lotes Where c.id_remate = codre And c.adjudicatario = cliente And c.facturado = False And c.desistido = False And c.afecto = afe Select c Group By c.adjudicatario Into total = Sum(c.precio_final) Select total).First()
            Return var
        Catch ex As Exception
            var = 0
            Return var
        End Try

    End Function
    Public Function lotliquiTotal(codre As Integer, cliente As String, afe As Boolean) As Long
        Dim var As Long
        var = (From c In contex.lotes Where c.id_remate = codre And c.afecto = afe And c.mandante = cliente And c.facturado = True And c.liquidado = False Select c Group By c.mandante Into total = Sum(c.precio_final) Select total).First()
        Return var
    End Function
    Public Function lotliquiTotal(cliente As String, afe As Boolean) As Long
        Dim var As Long
        var = (From c In contex.lotes Where c.mandante = cliente And c.facturado = True And c.afecto = afe And c.liquidado = False Select c Group By c.mandante Into total = Sum(c.precio_final) Select total).First()
        Return var
    End Function

    Public Function lotliquiTotalAfe(codre As Integer, cliente As String) As Long
        Dim var As Long
        var = (From c In contex.lotes Where c.id_remate = codre And c.mandante = cliente And c.facturado = True And c.afecto = True And c.liquidado = False Select c Group By c.mandante Into total = Sum(c.precio_final) Select total).First()
        Return var
    End Function
    Public Function lotliquiTotalAfe(cliente As String) As Long
        Dim var As Long
        var = (From c In contex.lotes Where c.mandante = cliente And c.facturado = True And c.afecto = True Select c Group By c.mandante Into total = Sum(c.precio_final) Select total).First()
        Return var
    End Function
    Public Function lotliquiTotalnAfe(codre As Integer, cliente As String) As Long
        Dim var As Long
        var = (From c In contex.lotes Where c.id_remate = codre And c.mandante = cliente And c.facturado = True And c.afecto = False Select c Group By c.mandante Into total = Sum(c.precio_final) Select total).First()
        Return var
    End Function
    Public Function lotliquiTotalnAfe(cliente As String) As Long
        Dim var As Long
        var = (From c In contex.lotes Where c.mandante = cliente And c.facturado = True And c.afecto = False Select c Group By c.mandante Into total = Sum(c.precio_final) Select total).First()
        Return var
    End Function


    Public Function lotfacturgarantia(codre As Integer, cliente As String, afe As Boolean) As Long
        Try
            Dim var As Long
            var = (From c In contex.lotes Where c.id_remate = codre And c.adjudicatario = cliente And c.facturado = False And c.afecto = afe Select c Group By c.adjudicatario Into total = Sum(c.garantia) Select total).First()
            Return var
        Catch ex As Exception
            Return 0
        End Try

    End Function
    Public Function lotfacturgarantiad(codre As Integer, cliente As String, afe As Boolean) As Long
        Try
            Dim var As Long
            var = (From c In contex.lotes Where c.id_remate = codre And c.adjudicatario = cliente And c.desistido = False And c.facturado = False And c.afecto = afe Select c Group By c.adjudicatario Into total = Sum(c.garantia) Select total).First()
            Return var
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Function lotfactlotes(codre As Integer, cliente As String, afe As Boolean) As Long
        Dim var As Long
        Try
            var = (From c In contex.lotes Where c.id_remate = codre And c.adjudicatario = cliente And c.facturado = False And c.afecto = afe Select c Group By c.adjudicatario Into total = Count(c.nro_lote) Select total).First()
            Return var
        Catch ex As Exception
            var = 0
            Return var
        End Try
    End Function
    Public Function lotliqutlotes(codre As Integer, cliente As String, afe As Boolean) As Long
        Dim var As Long
        Try
            var = (From c In contex.lotes Where c.id_remate = codre And c.mandante = cliente And c.facturado = False And c.afecto = afe Select c Group By c.mandante Into total = Count(c.nro_lote) Select total).First()
            Return var
        Catch ex As Exception
            var = 0
            Return var
        End Try
    End Function

    Public Function lotliqutlotes(cliente As String, afe As Boolean) As Long
        Dim var As Long
        Try
            var = (From c In contex.lotes Where c.mandante = cliente And c.facturado = False And c.afecto = afe Select c Group By c.mandante Into total = Count(c.nro_lote) Select total).First()
            Return var
        Catch ex As Exception
            var = 0
            Return var
        End Try

    End Function
    Public Function lotfactlotesd(codre As Integer, cliente As String, afe As Boolean) As Long
        Dim var As Long
        Try
            var = (From c In contex.lotes Where c.id_remate = codre And c.adjudicatario = cliente And c.facturado = False And c.desistido = False And c.afecto = afe Select c Group By c.adjudicatario Into total = Count(c.nro_lote) Select total).First()
            Return var
        Catch ex As Exception
            var = 0
            Return var
        End Try

    End Function


    Public Function lotfactlotes10(codre As Integer, cliente As String, afe As Boolean) As Long
        Dim var As Long
        Try
            var = (From c In contex.lotes Where c.id_remate = codre And c.adjudicatario = cliente And c.facturado = False And c.afecto = afe Select c Group By c.adjudicatario Into total = Count(c.nro_lote) Select total).First()
            Return var
        Catch ex As Exception
            var = 0
            Return var
        End Try

    End Function


    Public Function tremates(codre As Integer) As String
        Dim cod As String
        cod = (From c In contex.remates_mercaderia, t In contex.tipo_remates Where c.tipo_remate = t.id_tiporemate And c.id_remate = codre Select t.descripcion).First
        Return cod.ToString
    End Function
    Public Function tremates1(codre As String) As String
        Dim cod As String
        cod = (From c In contex.remates_mercaderia, t In contex.tipo_remates Where c.tipo_remate = t.id_tiporemate And c.codigo_remate = codre Select t.descripcion).First
        Return cod.ToString
    End Function

    Public Function listaite(id As Integer) As IEnumerable
        var = From c In contex.lotes Where c.id_remate = id Select c
        Return var
    End Function

    'Public Function listaitem(id As Integer, r As String)
    '    Dim retorno As New List(Of item)
    '    var = From c In contex.item Where c.id_evento = id
    '    For Each l In var
    '        Dim itt As New item
    '        itt.Numero_lote = l.item_orden
    '        itt.descripcion = l.item_descripcion
    '        itt.observacion = l.item_observavion
    '        itt.cantidad = l.item_cantidad
    '        retorno.Add(itt)
    '        itt = Nothing
    '    Next

    '    Return retorno
    'End Function

    Public Function listaitem(id As Integer, r As Boolean) As Integer
        Dim total As Integer
        If r Then
            var = (From c In contex.lotes Where c.id_remate = id)
            For Each v In var
                total += v.nro_unidades
            Next
            Return total
        Else
            Return 0
        End If
    End Function

    Function ordenplus(id As Integer) As Integer
        Dim ordenm As Integer
        Try
            ordenm = (From c In contex.lotes Where c.id_remate = id Select maximo = c.nro_lote).Max()
        Catch ex As Exception
            ordenm = 0
        End Try
        If IsNothing(ordenm) Or ordenm = 0 Then
            ordenm = 1
        Else
            ordenm += 1
        End If

        Return ordenm
    End Function

    Sub carga(mm As lotes)
        contex.AddTolotes(mm)
        contex.SaveChanges()
        contex.AcceptAllChanges()
    End Sub


    Public Sub Updateitem(id As Integer, id_item As Integer, mm As lotes)
        Dim ite As Object
        ite = (From c In contex.lotes Where c.id_remate = id And c.nro_lote = id_item).Single()
        ite.item_descripcion = mm.descripcion
        ite.item_observacion = mm.observaciones
        ite.item_cantidad = mm.nro_unidades
        contex.SaveChanges()
        contex.AcceptAllChanges()
    End Sub

    Public Sub Updateitemf(mm As lotes)
        Dim ite As Object
        ite = From c In contex.lotes Where c.id_lote = mm.id_lote Select c
        ite.facturado =
        contex.SaveChanges()
        contex.AcceptAllChanges()
    End Sub

    Public Function borraitem(id As Integer) As Boolean

        Dim ite As Object
        ite = (From c In contex.lotes Where c.nro_lote = id).Single()
        Try
            contex.DeleteObject(ite)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    Private Function item_descripcion() As Object
        Throw New NotImplementedException
    End Function

    Private Function id_lote() As Object
        Throw New NotImplementedException
    End Function




End Class
