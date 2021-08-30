Public Class Frm_boletasgen
    Dim rema As New Remate
    Dim factu As New factura
    Dim para As New parametro
    Public contex As New persaEntities11
    Dim lloteo As New loteo
    Dim remate As Integer
    Dim remaelegido As New remates_mercaderia
    Dim neto As Long
    Dim iva As Long
    Dim comision As Long
    Dim vcomision As Double
    Dim cargo As Long
    Dim total As Long
    Dim garantia As Long
    Dim liquido As Long
    Public id_clien As Integer
    Public id_comuna As Integer
    Dim valor As Integer
    Dim llotes As New lotes

    Private Sub Cmb_remates_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_remates.SelectedIndexChanged
        remaelegido = Cmb_remates.SelectedItem
        Me.Lbl_fecharema.Text = "Fecha de Remate :" & factu.fremates(remaelegido.codigo_remate)
        Me.Lbl_tiporema.Text = factu.tremates(remaelegido.id_remate)
        remate = remaelegido.id_remate
    End Sub

    Private Sub btn_generar_Click(sender As System.Object, e As System.EventArgs) Handles btn_generar.Click
        'sacavalores()


    End Sub
    'Sub sacavalores()
    '    Dim var As Object
    '    var = lloteo.listaloteo(remaelegido.id_remate)
    '    Dim boletas As New StringBuilder
    '    boletas.AppendLine("<html><STYLE> H1.SaltoDePagina(){ PAGE(-BREAK - AFTER) : always()}</STYLE><body>")
    '    For Each t As lotes In var
    '        boletas.AppendLine("<div style='line-height:10px;'>")
    '        boletas.AppendLine("<div >")
    '        boletas.AppendLine("<h1><img align='left' height='134' hspace='12' src='file:///C:\Users\pc\AppData\Local\Temp\msohtmlclip1\01\clip_image002.png' width='170' />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>Boleta de Garant&iacute;a</strong></h1>")
    '        boletas.AppendLine("<h3 style='margin-left: 70.8pt;'><strong>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;Remate 04-03-2015</strong></h3>")
    '        boletas.AppendLine("<div style='margin-left:460pt; font-size:14px;'><p><strong >0201-7" & Now().Year & Now().Month & t.nro_lote & " " & t.sub_lote & " -RP</strong></p></div>")
    '        boletas.AppendLine("<div style='margin-left:210pt;'><p><h2><strong >LOTE N&deg" & t.nro_lote & " " & t.sub_lote & "</strong></h2></p></div>")
    '        boletas.AppendLine("</div>")
    '        boletas.AppendLine("<table style='margin-left:0px;' border='.5px' cellpadding='0' cellspacing='0' >")
    '        boletas.AppendLine("<tbody>")
    '        boletas.AppendLine("<tr>")
    '        boletas.AppendLine("<td style='width:794px;height:94px;'>")
    '        boletas.AppendLine("<p><strong>Lote compuesto de:</strong></p>")
    '        boletas.AppendLine("<p><strong  align='center'>" & t.descripcion & "</strong></p>")
    '        boletas.AppendLine("</td>")
    '        boletas.AppendLine("</tr>")
    '        boletas.AppendLine("</tbody>")
    '        boletas.AppendLine("</table>")
    '        boletas.AppendLine("<table border='.5px' cellpadding='0' cellspacing='0'>")
    '        boletas.AppendLine("<tbody>")
    '        boletas.AppendLine("<tr>")
    '        boletas.AppendLine("<td style='width:794px;height:94px;'>")
    '        boletas.AppendLine("<p  align='center'><strong>Adjudicado v&iacute;a subasta p&uacute;blica a: _____________________________________</strong></p>")
    '        boletas.AppendLine("<p  align='center'><strong>Valor Unitario&nbsp; $_______________&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nro. Unidades&nbsp; __________________</strong></p>")
    '        boletas.AppendLine("</td>")
    '        boletas.AppendLine("</tr>")
    '        boletas.AppendLine("</tbody>")
    '        boletas.AppendLine("</table>")
    '        boletas.AppendLine("<div>")
    '        boletas.AppendLine("<table border='1px' cellpadding='0' cellspacing='0'>")
    '        boletas.AppendLine("	<tbody>")
    '        boletas.AppendLine("		<tr>")
    '        boletas.AppendLine("			<td style='width:794px;height:94px;'>")
    '        boletas.AppendLine("			<p align='center'><strong>Garant&iacute;a Depositada:________________________________________</strong></p>")
    '        boletas.AppendLine("			</td>")
    '        boletas.AppendLine("		</tr>")
    '        boletas.AppendLine("		<tr>")
    '        boletas.AppendLine("			<td style='width:794px;height:106px;'>")
    '        boletas.AppendLine("			<p><strong>Rematada a la vista, en las condiciones que se encuentran, sin posibilidad de cambio ni reclamo posterior de acuerdo a las bases del remate</strong></p>")
    '        boletas.AppendLine("			<div style='line-height:7px;'>")
    '        boletas.AppendLine("			<p align='center'><strong>Boleta personal e intransferible</strong></p>")
    '        boletas.AppendLine("			<p align='center' style='line-height:7px;'>Banco BBVA</p>")
    '        boletas.AppendLine("			<p align='center' style='line-height:7px;'>Cta. Cte. N&deg; 0504-0031-0100317469</p>")
    '        boletas.AppendLine("			<p align='center' style='line-height:7px;'>Remates Pacifico Limitada Rut: 76.390.282-K</p>")
    '        boletas.AppendLine("			<p align='center' style='line-height:7px;'>Correo: javier.dides@rematespacifico.cl</p>")
    '        boletas.AppendLine("			</div>")
    '        boletas.AppendLine("			</td>")
    '        boletas.AppendLine("		</tr>")
    '        boletas.AppendLine("	</tbody>")
    '        boletas.AppendLine("</table>")
    '        boletas.AppendLine("</div>")
    '        boletas.AppendLine("<p align='center' style='width:794px'>Remates Pacifico</p>")
    '        boletas.AppendLine("</div><H1 class=SaltoDePagina> </H1>")
    '    Next
    '    boletas.AppendLine("</body><html>")
    '    Dim documento As String
    '    documento = boletas.ToString
    '    WebBrowser1.DocumentText = String.Empty
    '    WebBrowser1.DocumentText = documento
    '    WebBrowser1.Refresh()
    '    Me.Refresh()
    '    Me.Cursor = Cursors.WaitCursor
    '    pdfboletas2(documento, var)
    '    Me.Cursor = Cursors.Default
    '    MsgBox("listo", MsgBoxStyle.Critical, "Boletas")


    'End Sub
    Sub generaboletas()



    End Sub

    Private Sub Frm_boletasgen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Cmb_remates.DataSource = rema.listaremates()
        Me.Cmb_remates.DisplayMember = "codigo_remate"
        Me.Cmb_remates.ValueMember = "id_remate"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        DialogResult = DialogResult.OK
        Return
    End Sub
End Class