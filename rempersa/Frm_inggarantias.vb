Imports Microsoft.Reporting.WinForms
Public Class Frm_inggarantias
    Dim totefec As Long
    Dim rema As New Remate
    Public remele As remates_mercaderia
    Dim reso As New resolucion
    Public contex As New persaEntities11
    Public activo As List(Of lotes)
    Public pares As New List(Of lotes)
    Public impares As New List(Of lotes)
    Public nlotes As Integer = 0

    Dim totpar As Long = 0
    Dim totimpar As Long = 0

    Public llote As New loteo

    Private Sub Txt20m_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt20m.KeyPress, Txt10m.KeyPress, Txt5m.KeyPress, Txt2m.KeyPress, Txt1m.KeyPress, Txt500.KeyPress, Txt100.KeyPress, Txt50.KeyPress, Txt10.KeyPress, Txt5.KeyPress, Txt1.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) And Not (AscW(e.KeyChar) = 45) Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(Keys.Return) Then
            totefec = 0
            Dim t As TextBox = CType(sender, TextBox)
            Select Case t.Name
                Case Is = "Txt20m"
                    Lbl20m.Text = Format(CInt(Txt20m.Text) * 20000, "$ #,##0")
                Case Is = "Txt10m"
                    Lbl10m.Text = Format(CInt(Txt10m.Text) * 10000, "$ #,##0")
                Case Is = "Txt5m"
                    Lbl5m.Text = Format(CInt(Txt5m.Text) * 5000, "$ #,##0")
                Case Is = "Txt2m"
                    Lbl2m.Text = Format(CInt(Txt2m.Text) * 2000, "$ #,##0")
                Case Is = "Txt1m"
                    Lbl1m.Text = Format(CInt(Txt1m.Text) * 1000, "$ #,##0")
                Case Is = "Txt500"
                    Lbl500.Text = Format(CInt(Txt500.Text) * 500, "$ #,##0")
                Case Is = "Txt100"
                    Lbl100.Text = Format(CInt(Txt100.Text) * 100, "$ #,##0")
                Case Is = "Txt50"
                    Lbl50.Text = Format(CInt(Txt50.Text) * 50, "$ #,##0")
                Case Is = "Txt10"
                    Lbl10.Text = Format(CInt(Txt10.Text) * 10, "$ #,##0")
                Case Is = "Txt5"
                    Lbl5.Text = Format(CInt(Txt5.Text) * 5, "$ #,##0")
                Case Is = "Txt1"
                    Lbl1.Text = Format(CInt(Txt1.Text) * 1, "$ #,##0")
            End Select
            Lbl_totefec.Text = 0


            For Each c As Control In GroupBox2.Controls
                If TypeOf (c) Is Label Then
                    If c.Name.Substring(0, 3) = "Lbl" Then
                        If Not (String.IsNullOrEmpty(c.Text)) Then
                            totefec = totefec + CLng(c.Text)


                        End If
                    End If
                End If
            Next
            Lbl_totefec.Text = Format(totefec, "$ #,##0")
        End If

    End Sub

    Private Sub Frm_inggarantias_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        carga()
    End Sub
    Sub carga()
        Me.Cmb_remate.DataSource = rema.listaremates
        Me.Cmb_remate.DisplayMember = "codigo_remate"
        Me.Cmb_remate.ValueMember = "fecha_remate"
    End Sub

    Sub paridad()

        totpar = 0
        totimpar = 0
        nlotes = 0
        Lbl_nlotes.Text = Format(0, "#,##0") & ".-"

        activo = llote.loteForID(remele.id_remate)
        For Each p As lotes In activo
            Dim lote As New lotes
            If (p.nro_lote Mod 2) = 0 Then
                lote.nro_lote = p.nro_lote
                lote.sub_lote = p.sub_lote
                lote.garantia = p.garantia
                lote.adjudicatario = p.adjudicatario
                lote.nro_unidades_final = p.nro_unidades_final
                lote.precio_final = p.precio_final
                lote.descripcion = p.descripcion
                lote.precio_minimo = 0
                pares.Add(lote)
                totpar += lote.garantia

                If lote.garantia > 0 And Rdb_par.Checked Then
                    nlotes += 1
                End If
                lote = Nothing
            End If

            If (p.nro_lote Mod 2) <> 0 Then

                lote.nro_lote = p.nro_lote
                lote.sub_lote = p.sub_lote
                lote.garantia = p.garantia
                lote.adjudicatario = p.adjudicatario
                lote.nro_unidades_final = p.nro_unidades_final
                lote.precio_final = p.precio_final
                lote.descripcion = p.descripcion
                lote.precio_minimo = 0
                impares.Add(lote)
                totimpar += lote.garantia
                If lote.garantia > 0 And Rdb_impar.Checked Then
                    nlotes += 1
                End If
                lote = Nothing
            End If

        Next
        Lbl_nlotes.Text = Format(nlotes, "#,##0") & ".-"
    End Sub

    Private Sub Cmb_remate_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_remate.SelectedIndexChanged
        Try
            remele = Nothing
            remele = New remates_mercaderia
            Txt_fecha.Text = Cmb_remate.SelectedValue
            remele = Cmb_remate.SelectedItem
            Dtg_garantias.DataSource = Nothing

            pares = Nothing
            impares = Nothing

            pares = New List(Of lotes)
            impares = New List(Of lotes)

            Rdb_par.Checked = True
            Rdb_par_CheckedChanged(Me, e)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Rdb_par_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Rdb_par.CheckedChanged

        For Each c As Control In GroupBox2.Controls
            If TypeOf (c) Is Label Then
                If c.Name.Substring(0, 3) = "Lbl" Then
                    If Not (String.IsNullOrEmpty(c.Text)) Then
                        c.Text = "$      0.-"
                    End If
                End If
            End If
            If TypeOf (c) Is TextBox Then
                c.Text = 0
            End If
        Next

        pares = Nothing
        impares = Nothing

        pares = New List(Of lotes)
        impares = New List(Of lotes)

        paridad()
        If Rdb_par.Checked Then
            Dtg_garantias.DataSource = pares
            Dtg_garantias.RowHeadersVisible = False
            For Each t In Me.Dtg_garantias.Columns
                t.visible = False
            Next
            Dtg_garantias.Columns(2).Visible = True
            Dtg_garantias.Columns(3).Visible = True
            Dtg_garantias.Columns(4).Visible = True
            Dtg_garantias.Columns(6).Visible = True
            Dtg_garantias.Columns(14).Visible = True
            Dtg_garantias.Columns(16).Visible = True
            Dtg_garantias.Columns(21).Visible = True


            Lbl_totlotes.Text = Format(totpar, "$ #,##0")
        End If
    End Sub





    Private Sub Rdb_impar_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Rdb_impar.CheckedChanged

        For Each c As Control In GroupBox2.Controls
            If TypeOf (c) Is Label Then
                If c.Name.Substring(0, 3) = "Lbl" Then
                    If Not (String.IsNullOrEmpty(c.Text)) Then
                        c.Text = "$      0.-"
                    End If
                End If
            End If
            If TypeOf (c) Is TextBox Then
                c.Text = 0
            End If
        Next
        paridad()
        If Rdb_impar.Checked Then
            Dtg_garantias.DataSource = impares
            Dtg_garantias.RowHeadersVisible = False
            For Each t In Me.Dtg_garantias.Columns
                t.visible = False
            Next
            Dtg_garantias.Columns(2).Visible = True
            Dtg_garantias.Columns(3).Visible = True
            Dtg_garantias.Columns(4).Visible = True
            Dtg_garantias.Columns(6).Visible = True
            Dtg_garantias.Columns(14).Visible = True
            Dtg_garantias.Columns(16).Visible = True
            Dtg_garantias.Columns(21).Visible = True

            Lbl_totlotes.Text = Format(totimpar, "$ #,##0")
        End If
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim rendicion As New rgarantia
        rendicion.bill_1 = CInt(Replace(Replace(Txt1.Text, "$", ""), ".", ""))
        rendicion.bill_10 = CInt(Replace(Replace(Txt10.Text, "$", ""), ".", ""))
        rendicion.bill_100 = CInt(Replace(Replace(Txt100.Text, "$", ""), ".", ""))
        rendicion.bill_1000 = CInt(Replace(Replace(Txt1m.Text, "$", ""), ".", ""))
        rendicion.bill_10000 = CInt(Replace(Replace(Txt10m.Text, "$", ""), ".", ""))
        rendicion.bill_2000 = CInt(Replace(Replace(Txt2m.Text, "$", ""), ".", ""))
        rendicion.bill_20000 = CInt(Replace(Replace(Txt20m.Text, "$", ""), ".", ""))
        rendicion.bill_5 = CInt(Replace(Replace(Txt5.Text, "$", ""), ".", ""))
        rendicion.bill_50 = CInt(Replace(Replace(Txt50.Text, "$", ""), ".", ""))
        rendicion.bill_500 = CInt(Replace(Replace(Txt500.Text, "$", ""), ".", ""))
        rendicion.bill_5000 = CInt(Replace(Replace(Txt5m.Text, "$", ""), ".", ""))
        rendicion.Ejecutivo = Txt_ejecutivo.Text.ToUpper()
        rendicion.paridad = IIf(Rdb_par.Checked, "PAR", "IMPAR")
        rendicion.efectivo = CLng(Replace(Replace(Lbl_totefec.Text, "$", ""), ".", ""))
        rendicion.efectivo_lotes = CLng(Replace(Replace(Lbl_totlotes.Text, "$", ""), ".", ""))
        rendicion.fecha_rgarantia = Now
        rendicion.estado_rgarantia = 1
        rendicion.nro_lotes = nlotes
        rendicion.id_remate = remele.id_remate
        rendicion.total_rgarantia = CLng(Replace(Replace(Lbl_totefec.Text, "$", ""), ".", ""))

        contex.AddTorgarantia(rendicion)
        contex.SaveChanges()
        contex.AcceptAllChanges()
        Dim rgarantiasr As New List(Of rgarantia)
        rgarantiasr.Add(rendicion)

        Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.rgarantia.rdlc"
        Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("rgarantia", rgarantiasr))
        Frm_muestrareportes.ReportViewer1.RefreshReport()
        Frm_muestrareportes.Show()



        For Each c As Control In GroupBox2.Controls
            If TypeOf (c) Is Label Then
                If c.Name.Substring(0, 3) = "Lbl" Then
                    If Not (String.IsNullOrEmpty(c.Text)) Then
                        c.Text = "$      0.-"
                    End If
                End If
            End If
            If TypeOf (c) Is TextBox Then
                c.Text = 0
            End If
        Next

        pares = Nothing
        impares = Nothing



    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try


            Dim t As Integer
            t = CInt(InputBox("Ingrese numero de rendicion", "Rendiciones"))

            Dim rendicion As New rgarantia
            rendicion = (From c In contex.rgarantia Where c.id_rgarantia = t Select c).First
            Dim rgarantiasr As New List(Of rgarantia)
            rgarantiasr.Add(rendicion)

            'If rendicion.paridad = "par" Then
            '    Cmb_remate.SelectedItem = rendicion.id_remate
            '    Rdb_par_CheckedChanged(Me, e)

            'End If



            Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.rgarantia.rdlc"
            Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()
            Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("rgarantia", rgarantiasr))
            Frm_muestrareportes.ReportViewer1.RefreshReport()
            Frm_muestrareportes.Show()

        Catch ex As Exception

        End Try

    End Sub
End Class