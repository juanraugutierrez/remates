Public Class rut

    Dim rt As String
    Dim largo As Integer

    Public Function validarRut(rt) As Boolean
        Dim dvt As String
        Dim validacion As Boolean = False
        Dim largo, mult, suma, dv, resto As Integer

        Try

            rt = rt.ToUpper()
            rt = rt.Replace(".", "")
            rt = rt.Replace("-", "")
            rt = rt.ToString.TrimEnd()
            rt = rt.ToString.TrimStart()


            Dim dvstr, rtAux As String

            rtAux = Integer.Parse(rt.Substring(0, rt.Length - 1))
            dvt = rt.Substring(rt.Length - 1, 1)


            largo = rtAux.ToString.Length
            suma = 0
            mult = 2
            For j = largo To 1 Step -1
                If mult = 8 Then mult = 2
                suma = suma + Val(Mid(rtAux, j, 1)) * mult
                mult = mult + 1
            Next j

            resto = suma Mod 11
            dv = 11 - resto

            'If dv = 11 Then dvstr = 0
            'If dv = 10 Then dvstr = "K"
            'If dv <> 11 And dv <> 10 Then
            '    dvstr = Str(dv)
            'End If


            If dv = CInt(dvt) And dvt <> "K" Then
                validacion = True
            ElseIf (dv = 10 And dvt = "K") Then
                validacion = True
            ElseIf (dv = 11 And dvt = "0") Then
                validacion = True
            Else
                validacion = False
            End If
        Catch ex As Exception

            If dv = 10 And dvt = "K" Then
                validacion = True
            End If

        End Try
        Return validacion

    End Function

    Function formato(rt As String)
        rt = rt.Trim()
        rt = rt.ToUpper()
        rt = rt.Replace(".", "")
        rt = rt.Replace("-", "")
        rt = rt.ToString.TrimEnd()
        rt = rt.ToString.TrimStart()
        Dim frut(4) As String
        If rt.Length = 9 Then
            frut(0) = rt.Substring(0, 2)
            frut(1) = rt.Substring(2, 3)
            frut(2) = rt.Substring(5, 3)
            frut(3) = rt.Substring(8, 1).ToUpper
        End If
        If rt.Length = 8 Then
            frut(0) = rt.Substring(0, 1)
            frut(1) = rt.Substring(1, 3)
            frut(2) = rt.Substring(4, 3)
            frut(3) = rt.Substring(7, 1).ToUpper
        End If

        Return frut(0) + "." + frut(1) + "." + frut(2) + "-" + frut(3)
    End Function

    Public Function formato1(rt As String)

        rt = rt.Trim()
        rt = rt.ToUpper()
        rt = rt.Replace(".", "")
        rt = rt.Replace("-", "")
        rt = rt.ToString.TrimEnd()
        rt = rt.ToString.TrimStart()

        Dim frut(4) As String
        If rt.Length = 9 Then
            frut(0) = rt.Substring(0, 2)
            frut(1) = rt.Substring(2, 3)
            frut(2) = rt.Substring(5, 3)
            frut(3) = rt.Substring(8, 1).ToUpper
        End If
        If rt.Length = 8 Then
            frut(0) = rt.Substring(0, 1)
            frut(1) = rt.Substring(1, 3)
            frut(2) = rt.Substring(4, 3)
            frut(3) = rt.Substring(7, 1).ToUpper
        End If

        Return frut(0) + frut(1) + frut(2) + "-" + frut(3)
    End Function
End Class
