Imports System.IO
Imports iTextSharp.text.pdf
Imports iTextSharp.tool.xml
'Imports WebSupergoo.ABCpdf10



Module detalle_facturamodule

    Dim contex As New persaEntities11

    Public Function CargaArticulos(Remate As Integer, cliente As String, estado As Boolean, afe As Boolean) As List(Of EArticulo)
        Dim factu As New factura
        Dim listaArticulos As New List(Of EArticulo)()
        Dim var As Object
        var = factu.lotfacturablesd(Remate, cliente, afe)

        For Each t In var
            Dim item As New EArticulo()
            Try
                item.Cantidad = 1

                If t.nro_unidades_final = 1 Then
                    If t.descripcion.ToString().Length > 31 Then
                        item.Descripcion = t.descripcion.ToString().Substring(0, 30) & " ( Lote " & t.nro_lote & " " & t.sub_lote & ")"
                    Else
                        item.Descripcion = t.descripcion.ToString() & " ( Lote " & t.nro_lote & " " & t.sub_lote & ")"

                    End If

                Else
                    item.Descripcion = t.descripcion & "  (" & t.nro_unidades_final & " unid. aprox)( Lote " & t.nro_lote & " " & t.sub_lote & ")"
                End If

                item.Precio_unitario = t.precio_unitario_final
                item.Total = t.precio_final
                listaArticulos.Add(item)
                item = Nothing
            Catch ex As Exception

            End Try

        Next
        If estado Then
            factu.lotfacturablesfactu(Remate, cliente)
        End If

        Return listaArticulos
    End Function

    Public Function CargaArticulos(Remate As Integer, cliente As String, estado As Boolean, afe As Boolean, idfactura As Integer) As List(Of EArticulo)
        Dim factu As New factura
        Dim listaArticulos As New List(Of EArticulo)()
        Dim var As Object
        var = factu.lotfacturablesd(Remate, cliente, afe)

        For Each t In var
            Dim item As New EArticulo()
            Try
                item.Cantidad = 1

                If t.nro_unidades_final = 1 Then
                    If t.descripcion.ToString().Length >= 20 Then
                        item.Descripcion = t.descripcion.ToString().Substring(0, 20) & " ( Lote " & t.nro_lote & " " & t.sub_lote & ")"
                    Else
                        item.Descripcion = t.descripcion.ToString() & " ( Lote " & t.nro_lote & " " & t.sub_lote & ")"

                    End If

                Else
                    item.Descripcion = t.descripcion & "  (" & t.nro_unidades_final & " unid. aprox)( Lote " & t.nro_lote & " " & t.sub_lote & ")"
                End If

                item.Precio_unitario = t.precio_unitario_final
                item.Total = t.precio_final


                listaArticulos.Add(item)
                Dim detalle As New detalle_factura
                detalle.id_factura = idfactura
                detalle.nro_lote = t.nro_lote
                detalle.sub_lote = t.sub_lote
                detalle.precio_unitario = CDbl(t.precio_unitario_final)
                detalle.precio_total = CDbl(t.precio_final)
                detalle.afecto = t.afecto
                detalle.cantidad = CInt(t.nro_unidades_final)
                detalle.garantia = CDbl(t.garantia)
                detalle.id_lote = t.id_lote
                detalle.descripcion = t.descripcion

                contex.AddTodetalle_factura(detalle)
                contex.SaveChanges()
                contex.AcceptAllChanges()

                item = Nothing
            Catch ex As Exception

            End Try

        Next
        If estado Then
            factu.lotfacturablesfactu(Remate, cliente)
        End If

        Return listaArticulos
    End Function


    Public Function CargaArticulosv(Remate As Integer, cliente As String, estado As Boolean, afe As Boolean, idfactura As Integer, leyenda As String) As List(Of EArticulo)
        Dim factu As New factura
        Dim listaArticulos As New List(Of EArticulo)()
        Dim var As Object

        var = factu.lotfacturablesd(Remate, cliente, afe)

        For Each t In var
            Try
                Dim item As New EArticulo()

                item.Cantidad = 1
                item.Descripcion = t.descripcion.ToString() & vbCrLf & leyenda
                item.Precio_unitario = t.precio_unitario_final
                item.Total = t.precio_final
                listaArticulos.Add(item)


                Dim detalle As New detalle_factura
                detalle.id_factura = idfactura
                detalle.nro_lote = t.nro_lote
                detalle.sub_lote = t.sub_lote
                detalle.precio_unitario = CDbl(t.precio_unitario_final)
                detalle.precio_total = CDbl(t.precio_final)
                detalle.afecto = t.afecto
                detalle.cantidad = CInt(t.nro_unidades_final)
                detalle.garantia = CDbl(t.garantia)
                detalle.id_lote = t.id_lote
                detalle.descripcion = item.Descripcion

                contex.AddTodetalle_factura(detalle)
                contex.SaveChanges()
                contex.AcceptAllChanges()

                item = Nothing
            Catch ex As Exception

            End Try

        Next
        If estado Then
            factu.lotfacturablesfactu(Remate, cliente)
        End If

        Return listaArticulos
    End Function



    Public Function CargaArticulos8(Remate As Integer, cliente As String, estado As Boolean, afe As Boolean, idfactura As Integer) As List(Of EArticulo)
        Dim factu As New factura
        Dim listaArticulos As New List(Of EArticulo)()
        Dim var As Object
        var = factu.lotfacturablesd(Remate, cliente, afe)

        For Each t In var
            Dim item As New EArticulo()
            Try
                item.Cantidad = 1

                If t.nro_unidades_final = 1 Then
                    If t.descripcion.ToString().Length >= 20 Then
                        item.Descripcion = t.descripcion.ToString().Substring(0, 20) & " ( Lote " & t.nro_lote & " " & t.sub_lote & ")"
                    Else
                        item.Descripcion = t.descripcion.ToString() & " ( Lote " & t.nro_lote & " " & t.sub_lote & ")"

                    End If

                Else
                    item.Descripcion = t.descripcion & "  (" & t.nro_unidades_final & " unid. aprox)( Lote " & t.nro_lote & " " & t.sub_lote & ")"
                End If

                item.Precio_unitario = t.precio_unitario_final
                item.Total = t.precio_final


                listaArticulos.Add(item)
                Dim detalle As New detalle_factura
                detalle.id_factura = idfactura
                detalle.nro_lote = t.nro_lote
                detalle.sub_lote = t.sub_lote
                detalle.precio_unitario = CDbl(t.precio_unitario_final)
                detalle.precio_total = CDbl(t.precio_final)
                detalle.afecto = t.afecto
                detalle.cantidad = CInt(t.nro_unidades_final)
                detalle.garantia = CDbl(t.garantia)
                detalle.id_lote = t.id_lote
                detalle.descripcion = t.descripcion

                contex.AddTodetalle_factura(detalle)
                contex.SaveChanges()
                contex.AcceptAllChanges()

                item = Nothing
            Catch ex As Exception

            End Try

        Next
        If estado Then
            factu.lotfacturablesfactu(Remate, cliente)
        End If

        Return listaArticulos
    End Function


    'Public Function CargalArticulos(lotes As List(Of lotesliquidacion), cliente As String, detalle As Boolean, afe As Boolean) As List(Of EArticulo)
    '    Dim factu As New factura
    '    Dim listaArticulos As New List(Of EArticulo)()
    '    Dim var As Object
    '    'Dim pp As New detalle_liquidacion
    '    'Dim liqu As New liquidaciones
    '    'If vehi Then


    '    If detalle Then


    '        For Each t In lotes
    '            Dim item As New EArticulo()


    '            Try
    '                item.Cantidad = 1
    '                If t.unidades = 1 Then
    '                    If t.descripcion.Length > 20 Then
    '                        item.Descripcion = t.descripcion.Substring(0, 20) & " ( Lote " & t.nrolot & " " & t.nrosblote & ")"
    '                    Else
    '                        item.Descripcion = t.descripcion & " ( Lote " & t.nrolot & " " & t.nrosblote & ")"
    '                    End If

    '                Else

    '                    If t.descripcion.Length > 20 Then
    '                        item.Descripcion = t.descripcion.Substring(0, 20) & "  (" & t.unidades & " U.aprox)( Lote " & t.nrolot & " " & t.nrosblote & ")"

    '                    Else
    '                        item.Descripcion = t.descripcion & "  (" & t.unidades & " U.aprox)( Lote " & t.nrolot & " " & t.nrosblote & ")"
    '                    End If
    '                End If

    '                item.Precio_unitario = t.Punitario
    '                item.Total = t.Total
    '                listaArticulos.Add(item)
    '                contex.ExecuteStoreCommand("update lotes set liquidado=1 where id_lote={0} and id_remate={1}", t.idlote, t.idremate)
    '                item = Nothing
    '            Catch ex As Exception

    '            End Try

    '        Next
    '    Else
    '        Dim item1 As New EArticulo()

    '        Dim unidades As Integer
    '        Dim neto As Long

    '        For Each t In lotes
    '            Try
    '                unidades += t.unidades
    '                neto += t.Total
    '                contex.ExecuteStoreCommand("update lotes set liquidado=1 where id_lote={0}", t.idlote)
    '                contex.SaveChanges()
    '                contex.AcceptAllChanges()

    '            Catch ex As Exception

    '            End Try
    '        Next
    '        item1.Cantidad = unidades
    '        item1.Descripcion = "Liquidacion según detalles adjuntos "
    '        item1.Precio_unitario = 0
    '        item1.Total = neto

    '        listaArticulos.Add(item1)
    '    End If
    '    'Else
    '    '    Dim item As New EArticulo()
    '    '    var = factu.lotliquidables(Remate, cliente, afe)


    '    'End If

    '    Return listaArticulos
    'End Function
    Public Function CargalArticulos(lotes As List(Of lotesliquidacionview), cliente As String, detalle As Boolean, afe As Boolean) As List(Of EArticulol)
        Dim factu As New factura
        Dim listaArticulos As New List(Of EArticulol)()

        If detalle Then
            For Each t In lotes
                Dim item As New EArticulol()
                Try
                    item.Cantidad = 1
                    If t.unidades = 1 Then
                        If t.descripcion.Length > 20 Then
                            item.Descripcion = t.descripcion.Substring(0, 20) & " ( Lote " & t.nrolot & " " & t.nrosblote & ")"
                        Else
                            item.Descripcion = t.descripcion & " ( Lote " & t.nrolot & " " & t.nrosblote & ")"
                        End If

                    Else

                        If t.descripcion.Length > 20 Then
                            item.Descripcion = t.descripcion.Substring(0, 20) & "  (" & t.unidades & " U.aprox)( Lote " & t.nrolot & " " & t.nrosblote & ")"

                        Else
                            item.Descripcion = t.descripcion & "  (" & t.unidades & " U.aprox)( Lote " & t.nrolot & " " & t.nrosblote & ")"
                        End If
                    End If

                    item.Precio_unitario = t.Punitario
                    item.Total = t.Total
                    item.Mandante = String.Empty
                    item.sucursal = String.Empty
                    listaArticulos.Add(item)
                    contex.ExecuteStoreCommand("update lotes set liquidado=1 where id_lote={0} and id_remate={1}", t.idlote, t.idremate)

                Catch ex As Exception

                End Try
                item = Nothing

            Next
        Else
            Dim item1 As New EArticulol()

            Dim unidades As Integer
            Dim neto As Long

            For Each t In lotes
                Try
                    unidades += t.unidades
                    neto += t.Total
                    contex.ExecuteStoreCommand("update lotes set liquidado=1 where id_lote={0}", t.idlote)
                    contex.SaveChanges()
                    contex.AcceptAllChanges()

                Catch ex As Exception

                End Try
            Next
            item1.Cantidad = unidades
            item1.Descripcion = "Liquidacion según detalles adjuntos "
            item1.Precio_unitario = 0
            item1.Total = neto
            item1.Mandante = String.Empty
            item1.sucursal = String.Empty

            listaArticulos.Add(item1)
        End If
        'Else
        '    Dim item As New EArticulo()
        '    var = factu.lotliquidables(Remate, cliente, afe)


        'End If

        Return listaArticulos
    End Function



    Public Function CargalArticulos(lotes As List(Of lotesliquidacionview), cliente As String, detalle As Boolean, afe As Boolean, vehiculo As Boolean) As List(Of EArticulol)
        Dim factu As New factura
        Dim listaArticulos As New List(Of EArticulol)()

        If detalle Then
            For Each t In lotes
                Dim item As New EArticulol()
                Try
                    item.Cantidad = 1
                    If t.unidades = 1 Then

                        item.Descripcion = t.descripcion & vbCrLf & " ( Lote " & t.nrolot & " " & t.nrosblote & ")"
                    End If

                    item.Precio_unitario = t.Punitario
                    item.Total = t.Total
                    item.Mandante = String.Empty
                    item.sucursal = String.Empty
                    listaArticulos.Add(item)
                    contex.ExecuteStoreCommand("update lotes set liquidado=1 where id_lote={0} and id_remate={1}", t.idlote, t.idremate)

                Catch ex As Exception

                End Try
                item = Nothing

            Next
        Else
            Dim item1 As New EArticulol()

            Dim unidades As Integer
            Dim neto As Long

            For Each t In lotes
                Try
                    unidades += t.unidades
                    neto += t.Total
                    contex.ExecuteStoreCommand("update lotes set liquidado=1 where id_lote={0}", t.idlote)
                    contex.SaveChanges()
                    contex.AcceptAllChanges()

                Catch ex As Exception

                End Try
            Next
            item1.Cantidad = unidades
            item1.Descripcion = "Lotes Venta Directa segun detalle adjunto "
            item1.Precio_unitario = 0
            item1.Total = neto
            item1.Mandante = String.Empty
            item1.sucursal = String.Empty

            listaArticulos.Add(item1)
        End If
        'Else
        '    Dim item As New EArticulo()
        '    var = factu.lotliquidables(Remate, cliente, afe)


        'End If

        Return listaArticulos
    End Function




    Public Function CargalArticulos(lotes As List(Of lotesliquidacionview), cliente As String, afe As Boolean) As List(Of EArticulol)
        Dim factu As New factura
        Dim listaArticulos As New List(Of EArticulol)()
        'Dim pp As New detalle_liquidacion
        'Dim liqu As New liquidaciones



        For Each t In lotes

            Dim item As New EArticulol()
            Try
                item.Cantidad = t.unidades
                item.Descripcion = t.descripcion & " (Lote: " & t.nrolot & " " & t.nrosblote & " )"
                item.Precio_unitario = t.Punitario
                item.Total = t.Total
                item.Mandante = t.mandante.ToUpper()
                Try
                    item.sucursal = t.sucursal.ToUpper()
                Catch ex As Exception

                End Try

                listaArticulos.Add(item)
                item = Nothing


            Catch ex As Exception

            End Try

        Next

        Return listaArticulos
    End Function






    Public Function Num2Text(ByVal value As Double) As String
        Select Case value
            Case 0 : Num2Text = "CERO"
            Case 1 : Num2Text = "UN"
            Case 2 : Num2Text = "DOS"
            Case 3 : Num2Text = "TRES"
            Case 4 : Num2Text = "CUATRO"
            Case 5 : Num2Text = "CINCO"
            Case 6 : Num2Text = "SEIS"
            Case 7 : Num2Text = "SIETE"
            Case 8 : Num2Text = "OCHO"
            Case 9 : Num2Text = "NUEVE"
            Case 10 : Num2Text = "DIEZ"
            Case 11 : Num2Text = "ONCE"
            Case 12 : Num2Text = "DOCE"
            Case 13 : Num2Text = "TRECE"
            Case 14 : Num2Text = "CATORCE"
            Case 15 : Num2Text = "QUINCE"
            Case Is < 20 : Num2Text = "DIECI" & Num2Text((value - 10))
            Case 20 : Num2Text = "VEINTE"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text((value - 20))
            Case 30 : Num2Text = "TREINTA"
            Case 40 : Num2Text = "CUARENTA"
            Case 50 : Num2Text = "CINCUENTA"
            Case 60 : Num2Text = "SESENTA"
            Case 70 : Num2Text = "SETENTA"
            Case 80 : Num2Text = "OCHENTA"
            Case 90 : Num2Text = "NOVENTA"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
            Case 100 : Num2Text = "CIEN"
            Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num2Text = "QUINIENTOS"
            Case 700 : Num2Text = "SETECIENTOS"
            Case 900 : Num2Text = "NOVECIENTOS"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "MIL"
            Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "UN MILLON"
            Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
            Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES "
                If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : Num2Text = "UN BILLON"
            Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select

    End Function

    Function mesliteral(mes As Integer) As String

        Select Case mes
            Case 1 : mesliteral = "Enero"
            Case 2 : mesliteral = "Febrero"
            Case 3 : mesliteral = "Marzo"
            Case 4 : mesliteral = "Abril"
            Case 5 : mesliteral = "Mayo"
            Case 6 : mesliteral = "Junio"
            Case 7 : mesliteral = "Julio"
            Case 8 : mesliteral = "Agosto"
            Case 9 : mesliteral = "Septiembre"
            Case 10 : mesliteral = "Octubre"
            Case 11 : mesliteral = "Noviembre"
            Case 12 : mesliteral = "Diciembre"
        End Select
    End Function


    Sub pdfboletas(ByVal html As String)
        Dim strHtml As String
        'Dim memStream As New MemoryStream()

        strHtml = html

        Dim strFileShortName As String = "boletas" & DateTime.Now.Ticks & ".pdf"
        Dim strFileName As String = "C:/pacifico/" & strFileShortName
        Dim docWorkingDocument As iTextSharp.text.Document = New iTextSharp.text.Document(iTextSharp.text.PageSize.HALFLETTER.Rotate(), 1, 1, 0, 0)
        Dim srdDocToString As StringReader = Nothing
        Try
            Dim pdfWrite As PdfWriter
            pdfWrite = PdfWriter.GetInstance(docWorkingDocument, New FileStream(strFileName, FileMode.Create))
            srdDocToString = New StringReader(strHtml)
            docWorkingDocument.Open()



            Dim worker As XMLWorkerHelper = XMLWorkerHelper.GetInstance
            worker.ParseXHtml(pdfWrite, docWorkingDocument, New StringReader(strHtml))


            'XMLWorkerHelper.GetInstance().ParseXHtml(pdfWrite, docWorkingDocument, srdDocToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If Not docWorkingDocument Is Nothing Then
                docWorkingDocument.Close()
            End If
            If Not srdDocToString Is Nothing Then
                srdDocToString.Close()
                srdDocToString.Dispose()
            End If
        End Try
    End Sub


    'Sub pdfboletas2(ByVal html As String, llote As Object)
    '    Dim strHtml As String
    '    'Dim memStream As New MemoryStream()


    '    strHtml = html

    '    Dim strFileShortName As String = "boletas" & DateTime.Now.Ticks & ".pdf"
    '    Dim strFileName As String = "C:/pacifico/" & strFileShortName

    '    Dim theDoc As Doc = New Doc()
    '    Dim theFont1 As Integer = theDoc.EmbedFont("Verdana", LanguageType.Latin, False, True)
    '    Dim theFont2 As Integer = theDoc.EmbedFont("Verdana Bold", LanguageType.Latin, False, True)
    '    Dim w As Double = theDoc.MediaBox.Width
    '    Dim h As Double = theDoc.MediaBox.Height
    '    Dim l As Double = theDoc.MediaBox.Left
    '    Dim b As Double = theDoc.MediaBox.Bottom
    '    Dim theImg As XImage = New XImage()
    '    theImg.SetFile("C:\Users\pc\Pictures\rematespacifico.jpg")

    '    'theDoc.Transform.Rotate(90, l, b)
    '    'theDoc.Transform.Translate(w, 0)

    '    ' rotate our rectangle
    '    theDoc.Rect.Width = h
    '    theDoc.Rect.Height = w

    '    ' add some text
    '    theDoc.Rect.Inset(1, 1)

    '    theDoc.FontSize = 14
    '    theDoc.TextStyle.HPos = 0.1 ' centered
    '    theDoc.TextStyle.VPos = 0.2 ' ...
    '    For Each t In llote
    '        theDoc.Page = theDoc.AddPage()
    '        Dim txt As String
    '        theDoc.FontSize = 22

    '        theDoc.Rect.Inset(10, 10)
    '        theDoc.FrameRect()

    '        txt = "<b>N° de Lote:" & t.nro_lote & " " & t.sub_lote & vbCrLf & "</b>Descripcion   " & t.descripcion
    '        txt = txt & vbCrLf & "Adjudicado en subasta  Publica a:____________________________"
    '        txt = txt & vbCrLf & "<b>Valor Unitario</b>  $_______________           <b> Nro. Unidades</b>  __________________"


    '        txt = txt + theDoc.Page.ToString()

    '        txt = "<font pid=" + theFont1.ToString() + ">" + txt + "</font>"
    '        txt = txt.Replace("<b>", "<font pid=" + theFont2.ToString() + ">")
    '        txt = txt.Replace("</b>", "</font>")

    '        theDoc.AddText(txt)
    '    Next

    '    For i As Integer = 1 To theDoc.PageCount
    '        theDoc.Rect.String = "100 650 500 750"
    '        theDoc.TextStyle.HPos = 0
    '        theDoc.TextStyle.VPos = 0
    '        theDoc.Color.String = "0 0 0"
    '        theDoc.PageNumber = i
    '        theDoc.FontSize = 48
    '        'theDoc.Rect.Left = 0
    '        'theDoc.Rect.Bottom = 0.001
    '        theDoc.Rect.Width = theImg.Width
    '        theDoc.Rect.Height = theImg.Height
    '        theDoc.AddImageObject(theImg, False)
    '        theDoc.AddText("Boleta de Garantia ")
    '        theDoc.FrameRect()
    '    Next

    '    theDoc.Save(strFileName)
    '    theDoc.Clear()
    'End Sub

End Module
