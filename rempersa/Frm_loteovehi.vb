Imports System.Text

Public Class Frm_loteovehi
    Public descripcion As String
    Public preciom As Integer
    Public observacion As String
    Public Mandante As String
    Public afecto As Boolean
    Public sucursal As String
    Dim manda As New mandantes
    Dim lsmanda As New acc_mandante
    Private Sub Frm_loteovehi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        For Each c As Control In Me.GroupBox1.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
            If TypeOf (c) Is RichTextBox Then
                c.Text = String.Empty
            End If
        Next
        preciom = 0
        observacion = String.Empty
        Mandante = String.Empty
        afecto = False
        sucursal = String.Empty
        descripcion = String.Empty

        Cmb_mandante.DataSource = lsmanda.listamandantes
        Cmb_mandante.DisplayMember = "razonsocial_mandante"
        Cmb_mandante.ValueMember = "id_mandante"


    End Sub

    Private Sub Btn_aceptar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_aceptar.Click
        Dim des As New StringBuilder

        For Each c As Control In Me.GroupBox1.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = c.Text.ToUpper
            End If
        Next
        des.Append("Tipo de Vehiculo:" & Txt_tipove.Text & vbCrLf)
        des.Append("Marca:" & txt_marca.Text & " Modelo:" & txt_modelo.Text & vbCrLf)
        des.Append("Año:" & txt_ano.Text & " N° Motor:" & txt_motor.Text & vbCrLf)
        des.Append("N° Chasis:" & txt_chasis.Text & vbCrLf)
        des.Append("N° Vim:" & txt_vim.Text & vbCrLf)
        des.Append("Color:" & txt_vim.Text & " Combustible:" & txt_combustible.Text & vbCrLf)
        des.Append("PBV:" & txt_pbv.Text & vbCrLf)
        des.Append("Inscripcion:" & txt_inscripcion.Text & vbCrLf)
        descripcion = des.ToString
        Try
            preciom = CInt(txt_pminimo.Text)
        Catch ex As Exception
            preciom = 0
        End Try

        Mandante = manda.razonsocial_mandante & vbCrLf & manda.rut_mandante
        observacion = rtxt_obser.Text.ToUpperInvariant
        afecto = Chk_afecto.Checked
        DialogResult = DialogResult.OK
    End Sub

    Private Sub Btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_cancelar.Click
        For Each c As Control In Me.GroupBox1.Controls
            If TypeOf (c) Is TextBox Then
                c.Text = String.Empty
            End If
        Next
        descripcion = String.Empty
        preciom = 0
        observacion = String.Empty
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cmb_mandante.SelectedIndexChanged
        manda = Nothing
        manda = New mandantes
        manda = Cmb_mandante.SelectedItem
    End Sub

    Private Sub Label14_Click(sender As System.Object, e As System.EventArgs) Handles Label14.Click

    End Sub
End Class