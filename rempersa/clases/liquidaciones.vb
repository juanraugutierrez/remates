Public Class liquidaciones
    Public contex As New persaEntities11


    Function carga(mm As liquidacion)

        Try
            contex.AddToliquidacion(mm)
            contex.SaveChanges()
            contex.AcceptAllChanges()

        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, "Liquidacion")

        End Try
        Return mm.id_liquidacion
    End Function
    Sub cargadetalle(mm As detalle_liquidacion)

        Try
            contex.AddTodetalle_liquidacion(mm)


            contex.ExecuteStoreCommand("update lotes set liquidado=1 where id_lote={0}", mm.id_lote)

            contex.SaveChanges()
            contex.AcceptAllChanges()

        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, "Liquidacion")
        End Try

    End Sub

    Function detalleli(id As Integer)
        Dim detalle As List(Of detalleviewl)
        Try
            detalle = (From d In contex.detalle_liquidacion Where d.id_liquidacion = id Select New detalleviewl With {.id_detalle = d.id_detalle, .id_liquidacion = d.id_liquidacion, .id_lote = d.id_lote, .nro_lote = d.nro_lote, .sub_lote = d.sub_lote, .descripcion = d.descripcion, .unidades = d.unidades, .precio_unitario = d.precio_unitario, .afecto = d.afecto, .mandante = d.mandante, .sucursal = d.sucursal}).ToList()
        Catch ex As Exception
            MsgBox(ex.InnerException.Message, MsgBoxStyle.Critical, "Liquidacion")
            detalle = Nothing
        End Try
        Return detalle
    End Function

End Class
