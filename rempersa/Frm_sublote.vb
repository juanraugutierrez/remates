Public Class Frm_sublote

    Public lote As Integer
    Public sublote As String


    Private Sub Btn_grabar_Click(sender As System.Object, e As System.EventArgs) Handles Btn_grabar.Click
        lote = CInt(Me.Txt_lote.Text)
        sublote = Me.Txt_sublote.Text.ToUpper
        DialogResult = DialogResult.OK
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_lote.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_lote.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_sublote.KeyPress
        If IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txt_sublote.TextChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        DialogResult = DialogResult.No
    End Sub

    Private Sub Frm_sublote_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lote = 0
        sublote = String.Empty


        Me.Txt_lote.Text = String.Empty
        Me.Txt_sublote.Text = String.Empty
    End Sub
End Class