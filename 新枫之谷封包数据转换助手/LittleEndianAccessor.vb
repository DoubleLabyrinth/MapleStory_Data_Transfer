Public Class LittleEndianAccessor
    Private SourceString As String = ""
    Private ByteCounts As Integer = 0
    Private ResultBytes() As Byte
    Public Sub New(ByVal source As String, ByVal ToTpye As String)
        SourceString = source
        Try
            While 3 * ByteCounts - 2 <= SourceString.Length - 1
                ByteCounts += 1
            End While
            ByteCounts -= 1
            ReDim ResultBytes(ByteCounts)
            For i = 1 To ByteCounts Step 1
                ResultBytes(i - 1) = CByte("&H" & Mid(SourceString, 3 * i - 2, 2))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, "Error!")
        End Try
    End Sub
    Public Function readMapleAsciiString() As String
        Dim ret As String = ""
        Try
            Dim strLength As UShort = CUShort("&H" & Hex(ResultBytes(1)) & Hex(ResultBytes(0)))
            For i = 1 To strLength Step 1
                ret += ChrW(ResultBytes(1 + i))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, "Error!")
        End Try

        Return ret
    End Function
    Public Function readShort() As String
        Dim ret As Short = 0
        Try
            ret = CShort("&H" & Hex(ResultBytes(1)) & Hex(ResultBytes(0)))
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, "Error!")
        End Try

        Return ret.ToString()
    End Function
    Public Function readInt() As String
        Dim ret As Integer = 0
        Try
            ret = CInt("&H" & Hex(ResultBytes(3)) & Hex(ResultBytes(2)) & Hex(ResultBytes(1)) & Hex(ResultBytes(0)))
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, "Error!")
        End Try

        Return ret.ToString()
    End Function
    Public Function readLong() As String
        Dim ret As Long = 0
        Try
            ret = CLng("&H" & Hex(ResultBytes(7)) & Hex(ResultBytes(6)) & Hex(ResultBytes(5)) & Hex(ResultBytes(4)) & Hex(ResultBytes(3)) & Hex(ResultBytes(2)) & Hex(ResultBytes(1)) & Hex(ResultBytes(0)))
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, "Error!")
        End Try

        Return ret.ToString()
    End Function
    Public Function readChar() As String
        Dim ret As Char
        Try
            ret = ChrW(ResultBytes(0))
        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.OkOnly, "Error!")
        End Try

        Return ret
    End Function
    Public Function readAsciiString(ByVal strLength As Integer) As String
        Dim ret As String = ""
        Try
            For i = 1 To strLength Step 1
                ret += ChrW(ResultBytes(i - 1))
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly, "Error!")
        End Try

        Return ret
    End Function
    Public Function readHex() As String
        Dim ret As String = ""
        Dim tmp As Boolean = True
        Try
            For i = ResultBytes.Length To 1 Step -1
                If tmp Then
                    If ResultBytes(i - 1) <> 0 Then
                        ret += Hex(ResultBytes(i - 1))
                        tmp = False
                    End If
                Else
                    If ResultBytes(i - 1) >= 0 And ResultBytes(i - 1) < 10 Then
                        ret += "0" & Hex(ResultBytes(i - 1))
                    Else
                        ret += Hex(ResultBytes(i - 1))
                    End If
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly, "Error!")
        End Try

        Return ret
    End Function
    Public Function readDec() As String
        Dim ret As String = ""
        Try
            ret = readHex()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly, "Error!")
        End Try

        Return CDec("&H" & ret).ToString()
    End Function
End Class
