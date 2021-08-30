Imports System.Data.Objects

Public Class loteo
    Public contex As New persaEntities11

    Private Property var As System.Linq.IQueryable(Of persaEntities11)
    Private Property quer As System.Linq.IQueryable

    Public Function listaloteo() As IQueryable
        quer = From c In contex.lotes Select c
        Return quer

    End Function

    Public Function listaloteo(id As Integer) As IQueryable
        quer = From c In contex.lotes Order By CInt(c.nro_lote) Descending Where c.id_remate = id Select c
        Return quer
    End Function

    Public Function listaloteo(id As Integer, mini As Integer, maxi As Integer) As IQueryable
        quer = From c In contex.lotes Where c.nro_lote >= mini And c.nro_lote <= maxi Order By CInt(c.nro_lote) Descending Where c.id_remate = id Select c
        Return quer
    End Function

    Public Function listalotesboletas(id As Integer) As IQueryable
        quer = From l In contex.lotes Join r In contex.remates_mercaderia On l.id_remate Equals r.id_remate Order By CInt(l.nro_lote) Ascending Where l.id_remate = id Select New With {l.nro_lote, l.sub_lote, l.descripcion, r.fecha_remate, r.id_remate, r.codigo_remate, l.nro_unidades}
        Return quer
    End Function

    Public Function listagarantias(id As Integer) As IQueryable
        Dim mm As Object
        mm = (From c In contex.lotes Order By CInt(c.nro_lote) Descending Where c.id_remate = id And c.garantia > 1 Select c)
        Return mm
    End Function


    Public Function listaloteoa(id As Integer) As IQueryable
        quer = From c In contex.lotes Order By CInt(c.nro_lote) Ascending, c.sub_lote Ascending Where c.id_remate = id Select c
        Return quer
    End Function

    Public Function genboletasloteo(id As Integer) As IQueryable
        quer = From c In contex.lotes Order By CInt(c.nro_lote) Descending Where c.id_remate = id Select c
        Return quer
    End Function

    Public Function listaloteAdju(id As Integer, adju As String) As IQueryable
        quer = (From c In contex.lotes Order By CInt(c.adjudicatario) Ascending Where c.id_remate = id And c.adjudicatario.Contains(adju) Select c.adjudicatario).Distinct()
        Return quer
    End Function


    Public Function numlote(id As Integer) As Integer
        Dim nl As Integer
        Try
            nl = (From c In contex.lotes Where c.id_remate = id Select CInt(c.nro_lote)).Max()
        Catch ex As Exception
            nl = 1
        End Try
        Return nl
    End Function

    Public Function totalgarantias(id As Integer) As Long
        Dim nl As Long
        Try
            nl = (From c In contex.lotes Where c.id_remate = id Select c.garantia).Sum()
        Catch ex As Exception
            nl = 0
        End Try
        Return nl
    End Function

    Public Function totalmto(id As Integer) As Long
        Dim nl As Long
        Try
            nl = (From c In contex.lotes Where c.id_remate = id Select c.precio_final).Sum()
        Catch ex As Exception
            nl = 0
        End Try
        Return nl
    End Function

    Public Function nlotegarantia(id As Integer) As Integer
        Dim nl As Integer
        Try
            nl = (From c In contex.lotes Where c.id_remate = id And c.garantia > 0 Select c.garantia).Count()
        Catch ex As Exception
            nl = 0
        End Try
        Return nl
    End Function

    Public Function nlotesfacturados(id As Integer) As Integer
        Dim nl As Integer
        Try
            nl = (From c In contex.lotes Where c.id_remate = id And c.facturado = True Select c.garantia).Count()
        Catch ex As Exception
            nl = 0
        End Try
        Return nl
    End Function

    Public Function nlotesingarantia(id As Integer) As Integer
        Dim nl As Integer
        Try
            nl = (From c In contex.lotes Where c.id_remate = id And (c.garantia = 0 Or c.garantia = "") Select c.garantia).Count()
        Catch ex As Exception
            nl = 0
        End Try
        Return nl
    End Function

    Public Function nloteadjudicatarios(id As Integer) As Integer
        Dim nl As Integer
        Try
            nl = (From c In contex.lotes Where c.id_remate = id And (c.adjudicatario <> "Sin Postor" And c.adjudicatario <> "") And c.garantia > 0 Select c.adjudicatario).Count()
        Catch ex As Exception
            nl = 0
        End Try
        Return nl
    End Function


    Public Function numlotemas(id As Integer) As Integer
        Dim nl As Integer
        Try
            nl = (From c In contex.lotes Where c.id_remate = id Select CInt(c.nro_lote)).Max()
            nl += 1
        Catch ex As Exception
            nl = 1
        End Try
        Return nl
    End Function
    Public Function codremate(id As String) As Integer
        Dim Idr As Integer
        Try
            Idr = (From c In contex.remates_mercaderia Where c.codigo_remate = id Select c.id_remate).First()
        Catch ex As Exception

        End Try
        Return Idr
    End Function

    Sub carga(mm As lotes)
        Dim nro_lote = mm.nro_lote
        If nro_lote = numlotemas(mm.id_remate) Then
            contex.AddTolotes(mm)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Else
            mm.nro_lote = numlotemas(mm.id_remate)
            contex.AddTolotes(mm)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        End If

    End Sub

    Sub cargasb(mm As lotes)
        Dim nro_lote = mm.nro_lote
        Try
            contex.AddTolotes(mm)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Catch ex As Exception

        End Try



    End Sub



    Function loteForID(id As Integer, idr As Integer) As IQueryable
        Dim eve As Object
        eve = (From c In contex.lotes Where c.id_lote = id And c.id_remate = idr Select c).Single()
        Return eve
    End Function

    Function loteForID(idr As Integer) As Object
        Dim eve As Object
        eve = (From c In contex.lotes Where c.id_remate = idr Order By CInt(c.nro_lote) Ascending, c.sub_lote Ascending Select c).ToList()
        Return eve
    End Function


    Function loteForIDpar(idr As Integer) As Object
        Dim eve As Object
        eve = (From c In contex.lotes Where c.id_remate = idr And (CInt(c.nro_lote) \ 2 = CInt(c.nro_lote) / 2) Order By CInt(c.nro_lote) Ascending, c.sub_lote Ascending Select c).ToList()
        Return eve
    End Function
    Function loteForIDimpar(idr As Integer) As Object
        Dim eve As Object
        eve = (From c In contex.lotes Where c.id_remate = idr And (CInt(c.nro_lote) \ 2 <> CInt(c.nro_lote) / 2) Order By CInt(c.nro_lote) Ascending, c.sub_lote Ascending Select c).ToList()
        Return eve
    End Function

    Function loteForidlote(id As Integer, idr As Integer)
        Try
            Dim eve As Object
            eve = (From c In contex.lotes Where c.id_lote = id And c.id_remate = idr Select c).First()
            Return eve
        Catch ex As Exception
            Dim eve As Object
            eve = (From c In contex.lotes Where c.nro_lote = 1 And c.id_remate = idr Select c).First()
            Return eve

        End Try

    End Function



    Function loteFornumlote(numlote As Integer, idr As Integer)
        Try
            Dim eve As Object
            eve = (From c In contex.lotes Where CInt(c.nro_lote) = numlote + 1 And c.id_remate = idr Select c).First()

            eve = (From c In contex.lotes Where CInt(c.nro_lote) = numlote And c.id_remate = idr Select c).First()
            Return eve
        Catch ex As Exception
            Dim eve As Object
            eve = (From c In contex.lotes Where CInt(c.nro_lote) = 1 And c.id_remate = idr Select c).First()
            Return eve

        End Try

    End Function
    Sub procesa(idr As Integer)




    End Sub



    Function loteForidl(idlote As Integer, idr As Integer)
        Try
            Dim eve As Object
            eve = (From c In contex.lotes Order By c.nro_lote Ascending, c.sub_lote Descending Where c.id_lote = idlote And c.id_remate = idr Select c).Single()
            Return eve
        Catch ex As Exception
            Dim eve As Object
            eve = (From c In contex.lotes Where c.nro_lote = 1 And c.id_remate = idr Select c).Single()
            Return eve

        End Try

    End Function


    Public Sub Updatelote(numlote As Integer, idr As Integer, mm As lotes)
        Dim lot As Object
        lot = (From c In contex.lotes Where c.nro_lote = numlote And c.id_remate = idr).Single()
        lot = mm
        contex.ApplyCurrentValues("lotes", lot)
        contex.SaveChanges()
        contex.AcceptAllChanges()

        Dim refreshableObjects = (From entry In contex.ObjectStateManager.GetObjectStateEntries(EntityState.Modified)
                                  Where (entry.EntityKey <> Nothing)
                                  Select entry.Entity)

        contex.Refresh(RefreshMode.StoreWins, refreshableObjects)

        refreshableObjects = Nothing

        refreshableObjects = (From entry In contex.ObjectStateManager.GetObjectStateEntries(EntityState.Unchanged)
                              Where (entry.EntityKey <> Nothing)
                              Select entry.Entity)

        contex.Refresh(RefreshMode.StoreWins, refreshableObjects)
        refreshableObjects = Nothing

        refreshableObjects = (From entry In contex.ObjectStateManager.GetObjectStateEntries(EntityState.Added)
                              Where (entry.EntityKey <> Nothing)
                              Select entry.Entity)

        contex.Refresh(RefreshMode.StoreWins, refreshableObjects)

        refreshableObjects = Nothing

        refreshableObjects = (From entry In contex.ObjectStateManager.GetObjectStateEntries(EntityState.Deleted)
                              Where (entry.EntityKey <> Nothing)
                              Select entry.Entity)

        contex.Refresh(RefreshMode.StoreWins, refreshableObjects)




    End Sub

    Public Sub UpdateloteID(IDlote As Integer, idr As Integer, mm As lotes)
        Dim lot As Object
        lot = (From c In contex.lotes Where c.id_lote = IDlote And c.id_remate = idr).Single()
        lot.id_remate = mm.id_remate
        lot = mm
        contex.ApplyCurrentValues("lotes", lot)
        contex.SaveChanges()
        contex.AcceptAllChanges()

    End Sub



    Public Function borralote(id As Integer) As Boolean

        Dim lote As Object
        lote = (From c In contex.lotes Where c.id_lote = id).Single()
        Try
            contex.DeleteObject(lote)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function



End Class






