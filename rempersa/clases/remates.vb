Public Class Remate
    Public contex As New persaEntities11

    Private Property var As System.Linq.IQueryable(Of persaEntities11)
    Private Property quer As System.Linq.IQueryable


    Sub procesatotales(idr As Integer)
        contex.ExecuteStoreCommand("exec [dbo].[totales_remates] {0}", idr)
        contex.SaveChanges()
        contex.AcceptAllChanges()
    End Sub


    Public Function rematetipo(id As Integer) As Integer
        Try
            Dim rema As Integer
            rema = (From c In contex.remates_mercaderia Where c.id_remate = id Select c.tipo_remate).FirstOrDefault()

            Return rema
        Catch ex As Exception
            Dim rema As Integer = 0

            Return rema
        End Try

    End Function

    Public Sub totales(ByVal id_remate As Integer)
        Dim lislots As New List(Of lotes)
        lislots = (From l In contex.lotes Where l.id_remate = id_remate).ToList()

        Dim rema As Object
        rema = From c In contex.remates_mercaderia Where c.id_remate = id_remate Select c
        rema.numero_lotes = lislots.Count

        rema.lotes_desistidos = Aggregate l In contex.lotes
                           Where l.id_remate = id_remate And l.desistido = 1
                            Into Count()

        rema.lotes_adjudicados = Aggregate l In contex.lotes
                           Where l.id_remate = id_remate And (l.adjudicatario <> vbNull And l.adjudicatario <> "Sin Postor")
                            Into Count()


        rema.monto_Adjudicado = Aggregate l In contex.lotes
                           Where l.id_remate = id_remate And (l.adjudicatario <> vbNull And l.adjudicatario <> "Sin Postor")
                            Into Sum(l.precio_final)

        rema.monto_facturado = Aggregate l In contex.lotes
                            Where l.id_remate = id_remate And l.facturado = True
                            Into Sum(l.precio_final)

        Me.Updateremate(id_remate, rema)


    End Sub

    Public Function listaremates() As IQueryable
        quer = From c In contex.remates_mercaderia Where c.estado_remate >= 1 Order By c.id_remate Descending Select c
        Return quer
    End Function
    Public Function listarematesr() As IQueryable
        quer = From c In contex.remates_mercaderia Order By c.id_remate Descending Select c
        Return quer
    End Function
    Public Function listaremates(tipo As String) As IQueryable
        Select Case tipo
            Case Is = "P"
                quer = From c In contex.remates_mercaderia Where c.tipo_remate = 10 Order By c.id_remate Descending Select c
            Case Is = "V"
                quer = From c In contex.remates_mercaderia Where c.tipo_remate = 2 Order By c.id_remate Descending Select c
        End Select

        Return quer
    End Function

    Public Function listaremates(id As Integer) As remates_mercaderia
        Try
            Dim rema As Object
            rema = (From c In contex.remates_mercaderia Where c.id_remate = id Select c).Single()

            Return rema
        Catch ex As Exception
            Dim rema As New remates_mercaderia
            Return rema
        End Try

    End Function


    Sub carga(mm As remates_mercaderia)
        Try

            contex.AddToremates_mercaderia(mm)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.InnerException.Message)
        End Try


    End Sub

    Function remateForID(id As Integer)
        Dim eve As Object
        eve = (From c In contex.remates_mercaderia Where c.id_remate = id).Single()
        Return eve
    End Function

    Function ultimoremate() As Integer
        Dim eve As Integer
        Try
            eve = (From c In contex.remates_mercaderia Select c.id_remate).Max()
        Catch ex As Exception

        End Try

        Return eve
    End Function



    Function remateForcodigo(id As String)
        Dim eve As Object
        eve = From c In contex.remates_mercaderia Where c.codigo_remate = id Select c
        Return eve
    End Function

    Function remateForfecha(id As Date)
        Dim eve As Object
        eve = From c In contex.remates_mercaderia Where c.fecha_remate = id Select c
        Return eve
    End Function



    Public Sub Updateremate(id As Integer, mm As remates_mercaderia)
        Dim rema As remates_mercaderia
        rema = (From c In contex.remates_mercaderia Where c.id_remate = id).Single()

        rema.lotes_adjudicados = mm.lotes_adjudicados
        rema.lotes_desistidos = mm.lotes_desistidos
        rema.lotes_sinpostor = mm.lotes_sinpostor
        rema.lotes = mm.lotes
        rema.monto_Adjudicado = mm.monto_Adjudicado
        rema.monto_desistido = mm.monto_desistido
        rema.monto_facturado = mm.monto_facturado
        rema.numero_lotes = mm.numero_lotes
        rema.tipo_remate = mm.tipo_remate
        rema.estado_remate = mm.estado_remate





        contex.SaveChanges()
        contex.AcceptAllChanges()


    End Sub
    Public Sub Updaterematenrolote(id As Integer, mm As remates_mercaderia)
        Dim rema As remates_mercaderia
        rema = (From c In contex.remates_mercaderia Where c.id_remate = id).Single()

        rema.numero_lotes = mm.numero_lotes

        contex.SaveChanges()
        contex.AcceptAllChanges()
    End Sub





    Public Function borraremate(id As Integer) As Boolean

        Dim eve As Object
        eve = (From c In contex.remates_mercaderia Where c.id_remate = id).Single()
        Try
            contex.DeleteObject(eve)
            contex.SaveChanges()
            contex.AcceptAllChanges()
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function



End Class






