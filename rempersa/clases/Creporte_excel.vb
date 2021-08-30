
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Public Class Creporte_excel
    ''Dim objLibroExcel As New m_Excel.Workbooks.Add
    ''Dim objHojaExcel as objLibroExcel.Worksheets(1)
    ''dim    objHojaExcel.Visible  as Excel.XlSheetVisibility.xlSheetVisible
    'Dim xlApp As New Microsoft.Office.Interop.Excel.Application
    'Dim m_Excel As Excel.Application
    'Dim objLibroExcel As New m_Excel.Workbook
    'Dim objHojaExcel As Excel.Worksheet


    'm_Excel = New Excel.Application

    Dim excel As Application = New Application
    Dim wor As Excel.Workbook
    Dim objHojaExcel As Excel.Worksheet

    Sub New()

    End Sub

    Sub CreaCabecera(remate As String)

        wor = excel.Workbooks.Add()
        objHojaExcel = wor.Sheets.Add()
        'wor = excel.Workbooks()
        'objHojaExcel = wor.Sheets(1)
        objHojaExcel.Activate()
        objHojaExcel.Range("A3:N3").Merge()
        objHojaExcel.Range("A3:N3").Value = "REMATES PERSA Spa Remate: " & remate
        objHojaExcel.Range("A3:N3").Font.Bold = True
        objHojaExcel.Range("A3:N3").Font.Size = 15

    End Sub
    Sub CreaCabecera(liquidacion As Integer)

        wor = excel.Workbooks.Add()
        objHojaExcel = wor.Sheets.Add()
        'wor = excel.Workbooks()
        'objHojaExcel = wor.Sheets(1)
        objHojaExcel.Activate()
        objHojaExcel.Range("A3:N3").Merge()
        objHojaExcel.Range("A3:N3").Value = "REMATES PERSA Spa LIQUIDACION: " & liquidacion
        objHojaExcel.Range("A3:N3").Font.Bold = True
        objHojaExcel.Range("A3:N3").Font.Size = 15

    End Sub

    Sub CreaCabecera()

        wor = excel.Workbooks.Add()
        objHojaExcel = wor.Sheets.Add()
        'wor = excel.Workbooks()e
        'objHojaExcel = wor.Sheets(1)
        objHojaExcel.Activate()
        objHojaExcel.Range("A3:N3").Merge()
        objHojaExcel.Range("A3:N3").Value = "REMATES PERSA Spa"
        objHojaExcel.Range("A3:N3").Font.Bold = True
        objHojaExcel.Range("A3:N3").Font.Size = 15

    End Sub

    Sub detalle(lista As List(Of detalleviewreporte))

        objHojaExcel.Range("A5").Activate()

        objHojaExcel.Range("A5").Value = "N° Lote"
        objHojaExcel.Range("B5").Value = "Sub Lote"
        objHojaExcel.Range("C5").Value = "Descripcion Descripcion"
        objHojaExcel.Range("D5").Value = "Cantidad Cantidad"
        objHojaExcel.Range("E5").Value = "Precio Unitario"
        objHojaExcel.Range("F5").Value = "Precio Total"
        objHojaExcel.Range("G5").Value = "Garantia"
        objHojaExcel.Range("H5").Value = "Facturado"
        objHojaExcel.Range("I5").Value = "Liquidado"
        objHojaExcel.Range("J5").Value = "Mandante"
        objHojaExcel.Range("K5").Value = "Adjudicatario"
        objHojaExcel.Range("L5").Value = "N° Factura"
        objHojaExcel.Range("M5").Value = "N° liquidacion"
        objHojaExcel.Range("N5").Value = "Observacion"


        objHojaExcel.Range("A6").Activate()
        Dim i As Integer = 6

        For Each l In lista
            objHojaExcel.Range("A" & i).Value = l.nro_lote
            objHojaExcel.Range("B" & i).Value = IIf(String.IsNullOrEmpty(l.sub_lote) Or IsNothing(l.sub_lote), "", l.sub_lote)
            objHojaExcel.Range("C" & i).Value = l.descripcion.ToUpper
            objHojaExcel.Range("D" & i).Value = l.cantidad
            objHojaExcel.Range("E" & i).Value = l.precio_unitario
            objHojaExcel.Range("F" & i).Value = l.precio_total
            objHojaExcel.Range("G" & i).Value = l.garantia
            objHojaExcel.Range("H" & i).Value = l.facturado
            objHojaExcel.Range("I" & i).Value = l.liquidado
            objHojaExcel.Range("J" & i).Value = l.mandante.ToUpper
            objHojaExcel.Range("K" & i).Value = IIf(String.IsNullOrEmpty(l.adjudicatario) Or l.adjudicatario = Nothing, "SIN POSTOR", l.adjudicatario)
            objHojaExcel.Range("L" & i).Value = l.nrofactura
            objHojaExcel.Range("M" & i).Value = l.nroliquidacion
            objHojaExcel.Range("N" & i).Value = l.observacion
            i += 1
        Next
        objHojaExcel.Range("A1").Select()
        objHojaExcel.Pictures.Insert(My.Settings.ruta_logo)

        objHojaExcel.Rows("2:2").Select()
        excel.Selection.RowHeight = 43.5


        objHojaExcel.Columns("E:G").Select()

        excel.Selection.NumberFormat = "_-$* #,##0_-;-$* #,##0_-;_-$* ""-""??_-;_-@_-"


        objHojaExcel.Range("A5:N5").Select()
        With excel.Selection.Interior
            .Pattern = 1
            .PatternColorIndex = -4105
            .ThemeColor = 2
            .TintAndShade = 0
            .PatternTintAndShade = 0
        End With
        With excel.Selection.Font
            .ThemeColor = 2
            .TintAndShade = 0
        End With

        With excel.Selection.Font
            .ThemeColor = 1
            .TintAndShade = 0
        End With
        excel.Selection.Font.Bold = True

        With excel.Selection
            .HorizontalAlignment = 1
            .VerticalAlignment = -4107
            .WrapText = True
            .Orientation = 0
            .AddIndent = False
            .IndentLevel = 0
            .ShrinkToFit = False
            .ReadingOrder = -5002
            .MergeCells = False
        End With
        With excel.Selection
            .HorizontalAlignment = 1
            .VerticalAlignment = -4160
            .WrapText = True
            .Orientation = 0
            .AddIndent = False
            .IndentLevel = 0
            .ShrinkToFit = False
            .ReadingOrder = -5002
            .MergeCells = False
        End With


        objHojaExcel.Columns("A:A").Select()
        excel.Selection.NumberFormat = "General"
        objHojaExcel.Columns("D:D").Select()
        excel.Selection.NumberFormat = "General"
        objHojaExcel.Columns("L:M").Select()
        excel.Selection.NumberFormat = "General"





        objHojaExcel.Range("A1").Select()
    End Sub
    Sub detalleLibrLqd(lista As List(Of Lqd))

        objHojaExcel.Range("A5").Activate()

        objHojaExcel.Range("A5").Value = "Razon Social"
        objHojaExcel.Range("B5").Value = "Nº Liquidacion"
        objHojaExcel.Range("C5").Value = "Fecha"
        objHojaExcel.Range("D5").Value = "Monto Neto"
        objHojaExcel.Range("E5").Value = "Impt. recau. por cta Terceros"
        objHojaExcel.Range("F5").Value = "Comision"
        objHojaExcel.Range("G5").Value = "IVA"
        objHojaExcel.Range("H5").Value = "Fletes"
        objHojaExcel.Range("I5").Value = "Publicidad"
        objHojaExcel.Range("J5").Value = "Liquido"
        objHojaExcel.Range("K5").Value = "Nro de Lotes"




        objHojaExcel.Range("A6").Activate()
        Dim i As Integer = 6

        For Each l In lista
            objHojaExcel.Range("A" & i).Value = l.RazonSocial
            objHojaExcel.Range("B" & i).Value = l.nro_liquidacion
            objHojaExcel.Range("C" & i).Value = l.fecha
            objHojaExcel.Range("D" & i).Value = l.mtoimpreacudado
            objHojaExcel.Range("E" & i).Value = l.mtoneto
            objHojaExcel.Range("F" & i).Value = l.comision
            objHojaExcel.Range("G" & i).Value = l.iva
            objHojaExcel.Range("H" & i).Value = l.flete
            objHojaExcel.Range("I" & i).Value = l.publicidad
            objHojaExcel.Range("J" & i).Value = l.liquido
            objHojaExcel.Range("K" & i).Value = l.nrolotes


            i += 1
        Next
        objHojaExcel.Range("A1").Select()
        Try


            objHojaExcel.Pictures.Insert(My.Settings.ruta_logo)

            objHojaExcel.Rows("2:2").Select()
            excel.Selection.RowHeight = 43.5






            objHojaExcel.Range("A5:N5").Select()
            With excel.Selection.Interior
                .Pattern = 1
                .PatternColorIndex = -4105
                .ThemeColor = 2
                .TintAndShade = 0
                .PatternTintAndShade = 0
            End With
            With excel.Selection.Font
                .ThemeColor = 2
                .TintAndShade = 0
            End With

            With excel.Selection.Font
                .ThemeColor = 1
                .TintAndShade = 0
            End With
            excel.Selection.Font.Bold = True

            With excel.Selection
                .HorizontalAlignment = 1
                .VerticalAlignment = -4107
                .WrapText = True
                .Orientation = 0
                .AddIndent = False
                .IndentLevel = 0
                .ShrinkToFit = False
                .ReadingOrder = -5002
                .MergeCells = False
            End With
            With excel.Selection
                .HorizontalAlignment = 1
                .VerticalAlignment = -4160
                .WrapText = True
                .Orientation = 0
                .AddIndent = False
                .IndentLevel = 0
                .ShrinkToFit = False
                .ReadingOrder = -5002
                .MergeCells = False
            End With


        Catch ex As Exception

        End Try



        objHojaExcel.Range("A1").Select()
    End Sub






    Sub detalleLibrVta(lista As List(Of LibroVtaReporte))

        objHojaExcel.Range("A5").Activate()

        objHojaExcel.Range("A5").Value = "Fecha"
        objHojaExcel.Range("B5").Value = "Nº Documento"
        objHojaExcel.Range("C5").Value = "Tipo Documento"
        objHojaExcel.Range("D5").Value = "Rut"
        objHojaExcel.Range("E5").Value = "Neto"
        objHojaExcel.Range("F5").Value = "IVA"
        objHojaExcel.Range("G5").Value = "Comision"
        objHojaExcel.Range("H5").Value = "Cargos"
        objHojaExcel.Range("I5").Value = "IVA"
        objHojaExcel.Range("J5").Value = "Total"
        objHojaExcel.Range("K5").Value = "Garantia"
        objHojaExcel.Range("L5").Value = "Liquido"
        objHojaExcel.Range("M5").Value = "Estado"



        objHojaExcel.Range("A6").Activate()
        Dim i As Integer = 6

        For Each l In lista
            objHojaExcel.Range("A" & i).Value = "'" & String.Concat(l.Fecha.Day, "-", l.Fecha.Month, "-", l.Fecha.Year)
            objHojaExcel.Range("B" & i).Value = l.NroDocumento
            objHojaExcel.Range("C" & i).Value = l.TipoDocumento
            objHojaExcel.Range("D" & i).Value = l.Rut
            objHojaExcel.Range("E" & i).Value = l.Neto
            objHojaExcel.Range("F" & i).Value = l.IVA
            objHojaExcel.Range("G" & i).Value = l.Comision
            objHojaExcel.Range("H" & i).Value = l.Cargos
            objHojaExcel.Range("I" & i).Value = l.IVAp
            objHojaExcel.Range("J" & i).Value = l.Total
            objHojaExcel.Range("K" & i).Value = l.Garantia
            objHojaExcel.Range("L" & i).Value = l.Liquido
            objHojaExcel.Range("M" & i).Value = IIf(l.Estado = "1", "Activa", "Nula")

            i += 1
        Next
        objHojaExcel.Range("A1").Select()
        Try


            objHojaExcel.Pictures.Insert(My.Settings.ruta_logo)

            objHojaExcel.Rows("2:2").Select()
            excel.Selection.RowHeight = 43.5






            objHojaExcel.Range("A5:N5").Select()
            With excel.Selection.Interior
                .Pattern = 1
                .PatternColorIndex = -4105
                .ThemeColor = 2
                .TintAndShade = 0
                .PatternTintAndShade = 0
            End With
            With excel.Selection.Font
                .ThemeColor = 2
                .TintAndShade = 0
            End With

            With excel.Selection.Font
                .ThemeColor = 1
                .TintAndShade = 0
            End With
            excel.Selection.Font.Bold = True

            With excel.Selection
                .HorizontalAlignment = 1
                .VerticalAlignment = -4107
                .WrapText = True
                .Orientation = 0
                .AddIndent = False
                .IndentLevel = 0
                .ShrinkToFit = False
                .ReadingOrder = -5002
                .MergeCells = False
            End With
            With excel.Selection
                .HorizontalAlignment = 1
                .VerticalAlignment = -4160
                .WrapText = True
                .Orientation = 0
                .AddIndent = False
                .IndentLevel = 0
                .ShrinkToFit = False
                .ReadingOrder = -5002
                .MergeCells = False
            End With


            'objHojaExcel.Columns("A:A").Select()
            'excel.Selection.NumberFormat = "General"
            'objHojaExcel.Columns("D:D").Select()
            'excel.Selection.NumberFormat = "General"
            'objHojaExcel.Columns("L:M").Select()
            '    excel.Selection.NumberFormat = "General"

            '    objHojaExcel.Range("A1").Select()
            '    excel.Selection.activate()



            '    objHojaExcel.Columns("A:A").Select()
            '    excel.Selection.NumberFormat = "dd-mm-yyyy"

            '    objHojaExcel.Range("A1").Select()
            '    excel.Selection.activate()

            '    objHojaExcel.Columns("E:L").Select()
            '    excel.Selection.NumberFormat = "_-$* #,##0_-;-$* #,##0_-;_-$* ""-""??_-;_-@_-"

        Catch ex As Exception

        End Try



        objHojaExcel.Range("A1").Select()
    End Sub

    Sub detalleliquidaciones(lista As List(Of lotesliquidacionview), nroliqu As Integer)
        objHojaExcel.Range("A5").Activate()

        objHojaExcel.Range("A5").Value = "N° Lote"
        objHojaExcel.Range("B5").Value = "Sub Lote"
        objHojaExcel.Range("C5").Value = "Descripcion"
        objHojaExcel.Range("D5").Value = "Unidades"
        objHojaExcel.Range("E5").Value = "P Unit"
        objHojaExcel.Range("F5").Value = "P Final"
        objHojaExcel.Range("G5").Value = "Mandante"
        objHojaExcel.Range("H5").Value = "Sucursal"
        objHojaExcel.Range("I5").Value = "Observaciones"

        objHojaExcel.Range("A6").Activate()
        Dim i As Integer = 6

        For Each l In lista
            objHojaExcel.Range("A" & i).Value = l.nrolot
            objHojaExcel.Range("B" & i).Value = l.nrosblote
            objHojaExcel.Range("C" & i).Value = l.descripcion
            objHojaExcel.Range("D" & i).Value = l.unidades
            objHojaExcel.Range("E" & i).Value = l.Punitario
            objHojaExcel.Range("F" & i).Value = l.Total
            objHojaExcel.Range("G" & i).Value = l.mandante
            objHojaExcel.Range("H" & i).Value = l.sucursal
            objHojaExcel.Range("I" & i).Value = l.observacion.ToUpperInvariant()
            i += 1
        Next
        objHojaExcel.Range("A1").Select()
        Try


            objHojaExcel.Pictures.Insert(My.Settings.ruta_logo)

            objHojaExcel.Rows("2:2").Select()
            excel.Selection.RowHeight = 43.5






            objHojaExcel.Range("A5:I5").Select()
            With excel.Selection.Interior
                .Pattern = 1
                .PatternColorIndex = -4105
                .ThemeColor = 2
                .TintAndShade = 0
                .PatternTintAndShade = 0
            End With
            With excel.Selection.Font
                .ThemeColor = 2
                .TintAndShade = 0
            End With

            With excel.Selection.Font
                .ThemeColor = 1
                .TintAndShade = 0
            End With
            excel.Selection.Font.Bold = True

            With excel.Selection
                .HorizontalAlignment = 1
                .VerticalAlignment = -4107
                .WrapText = True
                .Orientation = 0
                .AddIndent = False
                .IndentLevel = 0
                .ShrinkToFit = False
                .ReadingOrder = -5002
                .MergeCells = False
            End With
            With excel.Selection
                .HorizontalAlignment = 1
                .VerticalAlignment = -4160
                .WrapText = True
                .Orientation = 0
                .AddIndent = False
                .IndentLevel = 0
                .ShrinkToFit = False
                .ReadingOrder = -5002
                .MergeCells = False
            End With

            objHojaExcel.Range("E6:F" & i).Select()
            excel.Selection.Style = "Currency [0]"


        Catch ex As Exception

        End Try



        objHojaExcel.Range("A1").Select()
    End Sub



    Sub detalleLibrVtaNominas(lista As List(Of nominaview))

        objHojaExcel.Range("P5").Activate()

        objHojaExcel.Range("P5").Value = "Nro Nomina"
        objHojaExcel.Range("Q5").Value = "Fecha"
        objHojaExcel.Range("R5").Value = "Monto"




        objHojaExcel.Range("P6").Activate()
        Dim i As Integer = 6

        For Each l In lista
            objHojaExcel.Range("P" & i).Value = l.nronomina
            objHojaExcel.Range("Q" & i).Value = "'" & l.fecha.ToShortDateString
            objHojaExcel.Range("R" & i).Value = l.Monto
            i += 1
        Next
        objHojaExcel.Range("A1").Select()
    End Sub

    Sub CIERRA(tipo As String, remate As Integer)
        Dim exists As Boolean
        exists = System.IO.Directory.Exists("c:\reportes")
        If exists Then
            wor.SaveAs("c:\reportes\reporte_" & tipo & "_" & remate & "_.xlsx")
            wor.Close()
        Else
            System.IO.Directory.CreateDirectory("c:\reportes")
            wor.SaveAs("c:\reportes\reporte_" & tipo & "_" & remate & "_.xlsx")
            wor.Close()
        End If

    End Sub


End Class
