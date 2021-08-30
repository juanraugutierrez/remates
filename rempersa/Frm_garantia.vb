Imports Microsoft.Reporting.WinForms

Public Class Frm_garantia
    Dim rema As New Remate
    Dim factu As New factura
    Dim llote As New loteo
    Dim lotess As lotes
    Dim remaelegido As remates_mercaderia
    Dim paso As Integer = 1


    Dim activo As List(Of lotes)
    Dim indice As Integer = 0

    Private Shared frmInstance As Frm_garantia = Nothing


    Public Shared Function Instance() As Form
        If frmInstance Is Nothing OrElse frmInstance.IsDisposed = True Then
            frmInstance = New Frm_garantia
        End If
        frmInstance.BringToFront()
        Return frmInstance
    End Function
    Private Sub Frm_adjudcatario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.GroupBox2.Visible = False
        carga()
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width / 2 - 500
        y = Screen.PrimaryScreen.WorkingArea.Height / 2 - 300
        Me.Location = New Point(x, y)

    End Sub
    Sub carga()
        Me.Cmb_remates.DataSource = rema.listaremates()
        Me.Cmb_remates.DisplayMember = "codigo_remate"
        Me.Cmb_remates.ValueMember = "id_remate"
    End Sub

    Private Sub Cmb_remates_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_remates.SelectedIndexChanged
        remaelegido = Nothing
        remaelegido = New remates_mercaderia
        remaelegido = Cmb_remates.SelectedItem
        Me.Lbl_fecharema.Text = "Fecha de Remate :" & factu.fremates(remaelegido.codigo_remate)
        Me.Lbl_tiporema.Text = factu.tremates(remaelegido.id_remate)
        Me.Lbl_nrolotes.Text = remaelegido.numero_lotes
        Me.GroupBox2.Visible = True
        activo = New List(Of lotes)
        activo = llote.loteForID(remaelegido.id_remate)

        If activo.Count() <= 0 Then
            MsgBox("No hay lotes para este Remate", MsgBoxStyle.Critical, "Adjudicatario")
            Exit Sub
        End If
        indice = 0
        mostrar(indice)



        'If remaelegido.numero_lotes >= 1 And remaelegido.id_remate > 0 Then
        '    lotess = Nothing
        '    lotess = New lotes
        '    lotess = llote.loteFornumlote(1, remaelegido.id_remate)

        '    Lbl_lotem.Text = lotess.nro_lote
        '    Lbl_descripcion.Text = lotess.descripcion
        '    Txt_garantia.Text = IIf(IsNothing(lotess.garantia), Format(0, "$ #,##0"), Format(lotess.garantia, "$ #,##0"))

        'End If



    End Sub

    Sub mostrar(indice As Integer)
        Try
            Lbl_lotem.Text = activo(indice).nro_lote & " " & activo(indice).sub_lote
            Lbl_descripcion.Text = activo(indice).descripcion
            Txt_garantia.Text = Format(activo(indice).garantia, "$ #,##0")
        Catch ex As Exception

        End Try

    End Sub


    Private Sub Btn_grabar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_grabar.Click

        Try
            If String.IsNullOrEmpty(Txt_garantia.Text) Then
                MsgBox("Debe ingresar garantia mayor a 0", MsgBoxStyle.Critical, "Garantia")
                Exit Sub
            End If


            lotess = activo(indice)

            lotess.garantia = CLng(Txt_garantia.Text)
            llote.UpdateloteID(lotess.id_lote, remaelegido.id_remate, lotess)
            indice += paso
            If indice > activo.Count - 1 Then indice = 0


            mostrar(indice)



        Catch ex As Exception

        End Try



    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Btn_buscar.Click
        Try
            activo = Nothing
            activo = New List(Of lotes)
            activo = llote.loteForID(remaelegido.id_remate)

            'lotess = llote.loteFornumlote(CInt(Txt_buscar.Text), remaelegido.id_remate)

            'Lbl_lotem.Text = lotess.nro_lote
            'Lbl_descripcion.Text = lotess.descripcion
            'lotess.nro_unidades_final = lotess.nro_unidades
            'Txt_garantia.Text = lotess.garantia
            indice = CInt(activo.FindIndex(Function(x) CInt(x.nro_lote) = CInt(Txt_buscar.Text)))
            mostrar(indice)

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Txt_punitario_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            Try

                lotess.garantia = CLng(Txt_garantia.Text)


                Txt_garantia.Text = lotess.garantia


            Catch ex As Exception
                MsgBox("Hubo en error al cargar los datos de garantia, revise  y corrija", MsgBoxStyle.Critical, "Garantia")



                Txt_garantia.Text = lotess.garantia


            End Try




        End If

    End Sub

    Private Sub Txt_garantia_GotFocus(sender As Object, e As System.EventArgs) Handles Txt_garantia.GotFocus
        Me.Txt_garantia.Text = String.Empty
    End Sub

    Private Sub Txt_unidades_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_garantia.KeyPress
        If Not IsNumeric(e.KeyChar) And Not (AscW(e.KeyChar) = 8) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            Try
                lotess.garantia = CInt(Txt_garantia.Text)


            Catch ex As Exception
                MsgBox("Hubo en error al cargar los datos de garantia, revise  y corrija", MsgBoxStyle.Critical, "Garantia")

                lotess.precio_unitario_final = 0
                lotess.precio_final = 0
                lotess.nro_unidades = 0

                Txt_garantia.Text = lotess.garantia


            End Try




        End If

    End Sub

    Private Sub Txt_total_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)

        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Return) Then
            Try
                Txt_garantia.Text = lotess.garantia
            Catch ex As Exception
                MsgBox("Hubo en error al cargar los datos del adjudicatario, revise  y corrija", MsgBoxStyle.Critical, "Adjudicatarios")

                Txt_garantia.Text = lotess.garantia
            End Try
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        indice += paso
        If indice > activo.Count - 1 Then indice = 0
        mostrar(indice)


        'If lotess.nro_lote + 1 > CInt(Lbl_nrolotes.Text) Then
        '    lotess = Nothing
        '    lotess = New lotes
        '    lotess = llote.loteFornumlote(1, remaelegido.id_remate)

        '    Lbl_lotem.Text = lotess.nro_lote
        '    Lbl_descripcion.Text = lotess.descripcion
        '    lotess.nro_unidades_final = lotess.nro_unidades
        '    Txt_garantia.Text = lotess.garantia
        'Else
        '    Dim pp As Integer = lotess.nro_lote
        '    lotess = Nothing
        '    lotess = New lotes
        '    lotess = llote.loteFornumlote(pp + 1, remaelegido.id_remate)

        '    Lbl_lotem.Text = lotess.nro_lote
        '    Lbl_descripcion.Text = lotess.descripcion
        '    lotess.nro_unidades_final = lotess.nro_unidades
        '    Txt_garantia.Text = Format(lotess.garantia, "$ #,##0")

        'End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        indice -= paso
        If indice < 0 Then indice = activo.Count - 1
        mostrar(indice)

        'If lotess.nro_lote - 1 < 1 Then
        '    lotess = Nothing
        '    lotess = New lotes
        '    lotess = llote.loteFornumlote(1, remaelegido.id_remate)

        '    Lbl_lotem.Text = lotess.nro_lote
        '    Lbl_descripcion.Text = lotess.descripcion
        '    lotess.nro_unidades_final = lotess.nro_unidades
        '    Txt_garantia.Text = lotess.garantia

        'Else
        '    Dim pp As Integer = lotess.nro_lote
        '    lotess = Nothing
        '    lotess = New lotes
        '    lotess = llote.loteFornumlote(pp - 1, remaelegido.id_remate)

        '    Lbl_lotem.Text = lotess.nro_lote
        '    Lbl_descripcion.Text = lotess.descripcion
        '    lotess.nro_unidades_final = lotess.nro_unidades
        '    Txt_garantia.Text = Format(lotess.garantia, "$ #,##0")


        'End If
    End Sub


    Private Sub Btn_reporte_Click(sender As System.Object, e As System.EventArgs) Handles Btn_reporte.Click
        Dim lisgara As New List(Of rglotes)()
        Dim togaranti As New List(Of Totalgaran)()
        Dim var As Object
        var = llote.listagarantias(remaelegido.id_remate)


        Dim lisgar As rglotes
        For Each g In var
            lisgar = Nothing
            lisgar = New rglotes
            lisgar.nrolot = g.nro_lote
            lisgar.nrosblote = g.sub_lote
            lisgar.garan = g.garantia
            lisgar.Total = Format(g.precio_final, "$ #,##0")
            If g.precio_final > 0 Then
                lisgar.porcentaje = g.garantia * (1 / g.precio_final)
            Else
                lisgar.porcentaje = 0
            End If
            lisgar.adjud = g.adjudicatario
            lisgara.Add(lisgar)
        Next

        Dim tt As New Totalgaran
        tt.adjudicatrios = llote.nloteadjudicatarios(remaelegido.id_remate)
        tt.ganlotes = llote.nlotegarantia(remaelegido.id_remate)
        tt.lotesingrantia = llote.nlotesingarantia(remaelegido.id_remate)
        tt.togaran = llote.totalgarantias(remaelegido.id_remate)
        tt.total = llote.totalmto(remaelegido.id_remate)
        tt.porcentaje = tt.togaran / IIf(tt.total <= 0, 1, tt.total)

        togaranti.Add(tt)

        Dim parameters(1) As ReportParameter

        parameters(0) = New ReportParameter("nremate", remaelegido.codigo_remate)
        parameters(1) = New ReportParameter("nfecharemate", remaelegido.fecha_remate.ToLongDateString().ToUpper())

        Frm_muestrareportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "rempersa.garantias.rdlc"

        Frm_muestrareportes.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)

        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Clear()

        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("rgarantias", togaranti))
        Frm_muestrareportes.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("rgarantiaslist", lisgara))
        Frm_muestrareportes.ReportViewer1.LocalReport.SetParameters(parameters)
        Frm_muestrareportes.ReportViewer1.RefreshReport()
        Frm_muestrareportes.WindowState = FormWindowState.Maximized

        Frm_muestrareportes.Show()



    End Sub

    Private Sub Txt_garantia_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_garantia.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox2.Checked = False
            CheckBox2.Refresh()
            indice = 0
            activo = Nothing
            activo = New List(Of lotes)
            activo = llote.loteForIDimpar(remaelegido.id_remate)
            mostrar(indice)
        ElseIf Not (CheckBox2.Checked) Then
            indice = 0
            activo = Nothing
            activo = New List(Of lotes)
            activo = llote.loteForIDpar(remaelegido.id_remate)
            mostrar(indice)
        Else
            indice = 0
            paso = 1
            mostrar(indice)

        End If

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            indice = 0
            paso = 1
            CheckBox1.Checked = False
            Try
                activo = llote.loteForID(remaelegido.id_remate)
                mostrar(indice)
            Catch ex As Exception

            End Try

        End If
    End Sub
End Class