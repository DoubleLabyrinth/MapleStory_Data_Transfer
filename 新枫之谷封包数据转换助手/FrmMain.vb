Public Class FrmMain
    Dim CalType As String = ""
    Dim CalculateType As String = ""
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxInputData.Text = ""
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "+"
    End Sub

    Private Sub RadioButtonToAsciiString_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonToAsciiString.CheckedChanged
        If RadioButtonToAsciiString.Checked Then
            TextBoxAsciiString.ReadOnly = False
            TextBoxAsciiString.Text = "在此输入长度。"
            TextBoxAsciiString.ForeColor = Color.White
            CalculateType = "ToAsciiString"
        Else
            TextBoxAsciiString.Text = ""
            TextBoxAsciiString.ForeColor = Color.Black
            TextBoxAsciiString.ReadOnly = True
        End If
    End Sub

    Private Sub TextBoxAsciiString_TextChanged(sender As Object, e As EventArgs) Handles TextBoxAsciiString.MouseClick
        If TextBoxAsciiString.ReadOnly = False Then
            TextBoxAsciiString.Text = ""
            TextBoxAsciiString.ForeColor = Color.Black
        End If
    End Sub

    Private Sub RadioButtonDec_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDec.CheckedChanged
        If RadioButtonDec.Checked Then
            CalType = "Dec"
        End If
    End Sub

    Private Sub ButtonCal_Click(sender As Object, e As EventArgs) Handles ButtonCal.Click
        Dim a As New SpecialString(TextBoxCal1.Text, CalType)
        Dim b As New SpecialString(TextBoxCal2.Text, CalType)
        Select Case CalType
            Case "Dec"
                Select Case ComboBox1.Text
                    Case "+"
                        If a.getSourceStringInitializationStatus() And b.getSourceStringInitializationStatus() Then
                            TextBoxCalResult.Text = (a.getSourceStringDecValue() + b.getSourceStringDecValue()).ToString()
                        Else
                            MsgBox("数据格式不正确！", MsgBoxStyle.OkOnly, "Error!")
                        End If
                    Case "-"
                        If a.getSourceStringInitializationStatus() And b.getSourceStringInitializationStatus() Then
                            TextBoxCalResult.Text = (a.getSourceStringDecValue() - b.getSourceStringDecValue()).ToString()
                        Else
                            MsgBox("数据格式不正确！", MsgBoxStyle.OkOnly, "Error!")
                        End If
                    Case "*"
                        If a.getSourceStringInitializationStatus() And b.getSourceStringInitializationStatus() Then
                            TextBoxCalResult.Text = (a.getSourceStringDecValue() * b.getSourceStringDecValue()).ToString()
                        Else
                            MsgBox("数据格式不正确！", MsgBoxStyle.OkOnly, "Error!")
                        End If
                    Case "/"
                        If a.getSourceStringInitializationStatus() And b.getSourceStringInitializationStatus() Then
                            TextBoxCalResult.Text = CLng(a.getSourceStringDecValue() / b.getSourceStringDecValue()).ToString()
                        Else
                            MsgBox("数据格式不正确！", MsgBoxStyle.OkOnly, "Error!")
                        End If
                End Select
            Case "Hex"
                Select Case ComboBox1.Text
                    Case "+"
                        If a.getSourceStringInitializationStatus() And b.getSourceStringInitializationStatus() Then
                            TextBoxCalResult.Text = Hex(a.getSourceStringDecValue() + b.getSourceStringDecValue())
                        Else
                            MsgBox("数据格式不正确！", MsgBoxStyle.OkOnly, "Error!")
                        End If
                    Case "-"
                        If a.getSourceStringInitializationStatus() And b.getSourceStringInitializationStatus() Then
                            TextBoxCalResult.Text = Hex(a.getSourceStringDecValue() - b.getSourceStringDecValue())
                        Else
                            MsgBox("数据格式不正确！", MsgBoxStyle.OkOnly, "Error!")
                        End If
                    Case "*"
                        If a.getSourceStringInitializationStatus() And b.getSourceStringInitializationStatus() Then
                            TextBoxCalResult.Text = Hex(a.getSourceStringDecValue() * b.getSourceStringDecValue())
                        Else
                            MsgBox("数据格式不正确！", MsgBoxStyle.OkOnly, "Error!")
                        End If
                    Case "/"
                        If a.getSourceStringInitializationStatus() And b.getSourceStringInitializationStatus() Then
                            TextBoxCalResult.Text = Hex(CLng(a.getSourceStringDecValue() / b.getSourceStringDecValue()))
                        Else
                            MsgBox("数据格式不正确！", MsgBoxStyle.OkOnly, "Error!")
                        End If
                End Select
        End Select

    End Sub

    Private Sub RadioButtonHex_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonHex.CheckedChanged
        If RadioButtonHex.Checked Then
            CalType = "Hex"
        End If
    End Sub

    Private Sub RadioButtonToShort_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonToShort.CheckedChanged
        If RadioButtonToShort.Checked Then CalculateType = "ToShort"
    End Sub

    Private Sub RadioButtonToInt_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonToInt.CheckedChanged
        If RadioButtonToInt.Checked Then CalculateType = "ToInt"
    End Sub

    Private Sub RadioButtonToLong_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonToLong.CheckedChanged
        If RadioButtonToLong.Checked Then CalculateType = "ToLong"
    End Sub

    Private Sub RadioButtonToChar_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonToChar.CheckedChanged
        If RadioButtonToChar.Checked Then CalculateType = "ToChar"
    End Sub

    Private Sub RadioButtonToMapleAsciiString_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonToMapleAsciiString.CheckedChanged
        If RadioButtonToMapleAsciiString.Checked Then CalculateType = "ToMapleAsciiString"
    End Sub

    Private Sub RadioButtonToHex_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonToHex.CheckedChanged
        If RadioButtonToHex.Checked Then CalculateType = "ToHex"
    End Sub

    Private Sub RadioButtonToDec_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonToDec.CheckedChanged
        If RadioButtonToDec.Checked Then CalculateType = "ToDec"
    End Sub

    Private Sub RadioButtonToBinary_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonToBinary.CheckedChanged
        If RadioButtonToBinary.Checked Then CalculateType = "ToBinary"
    End Sub

    Private Sub RadioButtonBinaryToDec_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonBinaryToDec.CheckedChanged
        If RadioButtonBinaryToDec.Checked Then CalculateType = "BinaryToDec"
    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim slea As New LittleEndianAccessor(TextBoxInputData.Text, CalculateType)
        Select Case CalculateType
            Case "ToShort"
                TextBoxResult.Text = slea.readShort()
            Case "ToInt"
                TextBoxResult.Text = slea.readInt()
            Case "ToLong"
                TextBoxResult.Text = slea.readLong()
            Case "ToChar"
                TextBoxResult.Text = slea.readChar()
            Case "ToAsciiString"
                TextBoxResult.Text = slea.readAsciiString(CInt(TextBoxAsciiString.Text))
            Case "ToMapleAsciiString"
                TextBoxResult.Text = slea.readMapleAsciiString()
            Case "ToHex"
                TextBoxResult.Text = slea.readHex()
            Case "ToDec"
                TextBoxResult.Text = slea.readDec()
            Case "ToBinary"
                TextBoxResult.Text = Convert.ToString(CLng(slea.readDec()), 2)
            Case "BinaryToDec"
                TextBoxResult.Text = BinaryToDec(TextBoxInputData.Text).ToString()
        End Select
    End Sub
    Private Function BinaryToDec(ByVal SourceBinaryString As String) As Decimal
        Dim ret As Decimal = 0
        Try
            For i = SourceBinaryString.Length To 1 Step -1
                If Mid(SourceBinaryString, SourceBinaryString.Length - i + 1, 1) = "1" Then ret += CDec(2 ^ (i - 1))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly, "Error!")
        End Try
        Return ret
    End Function
End Class
