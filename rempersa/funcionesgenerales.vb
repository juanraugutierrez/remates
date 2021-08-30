Module funcionesgenerales
    Public uactivo As Boolean = False
    Public contex As New persaEntities11

    Public Function redimensiona(ByRef filename As Bitmap, ByVal patente As String) As Bitmap
        Dim imagenOriginal As Bitmap
        Dim imagenRedimensionada As Bitmap
        Dim ff As New Font("Calabri", 12, FontStyle.Bold)
        Dim pp As New Point
        imagenOriginal = New Bitmap(filename)
        imagenRedimensionada = New Bitmap(352, 264)

        Using gr As Graphics = Graphics.FromImage(imagenRedimensionada)
            gr.DrawImage(imagenOriginal, 0, 0, imagenRedimensionada.Width, imagenRedimensionada.Height)
            pp.X = Math.Truncate((imagenRedimensionada.Width \ 20) * 2)
            pp.Y = Math.Truncate((imagenRedimensionada.Height \ 20) * 19)
            gr.DrawString("® REMATES KOZAK -" & Now.Year & " " & patente, ff, Brushes.White, pp)

        End Using
        Return imagenRedimensionada
    End Function

    Public Function redimensiona(ByRef filename As Bitmap) As Bitmap
        Dim imagenOriginal As Bitmap
        Dim imagenRedimensionada As Bitmap
        Dim ff As New Font("Calabri", 12, FontStyle.Bold)
        Dim pp As New Point
        imagenOriginal = New Bitmap(filename)
        imagenRedimensionada = New Bitmap(352, 264)

        Using gr As Graphics = Graphics.FromImage(imagenRedimensionada)
            gr.DrawImage(imagenOriginal, 0, 0, imagenRedimensionada.Width, imagenRedimensionada.Height)
            pp.X = Math.Truncate((imagenRedimensionada.Width \ 20) * 2)
            pp.Y = Math.Truncate((imagenRedimensionada.Height \ 20) * 19)
        End Using
        Return imagenRedimensionada
    End Function

    Public Function Cargalotes(remate As Integer) As List(Of lotespapeles)
        Dim llote As New loteo
        Dim Lloteol As New List(Of lotespapeles)()
        Dim var As Object
        var = llote.listaloteo(remate)

        For Each t In var
            Try
                Dim item As New lotespapeles()
                item.nrolote = "LOTE N° " & t.nro_lote & t.sub_lote

                If t.descripcion.ToString.Length < 120 Then
                    item.descripcion = " LOTE DE " & t.descripcion.ToString().Replace("lote de", "") & vbCrLf & vbCrLf & vbCrLf & " ( " & t.nro_unidades & " UNID APROX.)"
                Else
                    item.descripcion = " LOTE DE " & t.descripcion.ToString().Substring(0, 120).Replace("lote de", "") & vbCrLf & vbCrLf & vbCrLf & " ( " & t.nro_unidades & " UNID APROX.)"
                End If

                Lloteol.Add(item)
                item = Nothing
            Catch ex As Exception

            End Try

        Next
        Return Lloteol
    End Function

    'Public Function Cargaboletas(remate As Integer) As List(Of boletabase)
    '    Dim llote As New loteo
    '    Dim Lloteol As New List(Of boletabase)()
    '    Dim var As Object
    '    var = llote.listaloteo(remate)

    '    For Each t In var
    '        Try
    '            Dim item As New lotesboletas()

    '            item.nroboleta = "0201-" & remate & Now().Year() & Now().Month & t.nro_lote & "-RP"
    '            item.lote = "LOTE N° " & t.nro_lote & t.sub_lote
    '            item.adjudicatario = "Adjudicado via subasta pública a: ___________________________"
    '            item.valorU = "Valor Unitario:    $____________"
    '            item.cantidad = "Nro Unidades:       ____________"
    '            item.garantia = "Garantia Depositada:___________________________ "
    '            item.descripcion = "Lote compuesto de : " & t.descripcion.ToString().Replace("lote de", "") & vbCrLf & " ( " & t.nro_unidades & " Unid. Aprox.)"
    '            item.leyenda = "Rematadas a la vista, en las condiciones que se encuentran, sin posibilidad de cambio ni reclamo posterior de acuerdo a las bases del remate.-"

    '            Lloteol.Add(item)
    '            item = Nothing
    '        Catch ex As Exception

    '        End Try

    '    Next
    '    Return Lloteol
    'End Function

    Function GetTable(lista As List(Of lotesboletas)) As DataTable
        ' Create new DataTable instance.
        Dim table As New DataTable

        table.Columns.Add("descripcion", GetType(String))
        table.Columns.Add("nroboleta", GetType(String))
        table.Columns.Add("lote", GetType(String))
        table.Columns.Add("adjudicatario", GetType(String))
        table.Columns.Add("valorU", GetType(String))
        table.Columns.Add("garantia", GetType(String))
        table.Columns.Add("leyenda", GetType(String))
        table.Columns.Add("cantidad", GetType(String))

        For Each l In lista
            table.Rows.Add(l.descripcion, l.nroboleta, l.lote, l.adjudicatario, l.valorU, l.garantia, l.leyenda, l.cantidad)
        Next



        Return table
    End Function
    Function limpiastring(valor As String) As String
        valor = valor.Replace("$", "")
        valor = valor.Replace(".", "")
        If valor = "" Then
            valor = 0
        End If
        Return valor
    End Function


End Module
