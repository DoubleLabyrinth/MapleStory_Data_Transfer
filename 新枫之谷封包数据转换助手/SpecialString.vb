Public Class SpecialString
    Private CheckedOk As Boolean = False
    Private Initialized As Boolean = False
    Private SourceString As String = ""
    Private SourceStringType As String = ""
    Private ResultDec As Decimal = 0
    Private ResultHex As String = ""
    Public Sub New(ByVal source As String, ByVal type As String)
        SourceString = source
        SourceStringType = type
        CheckSourceString(SourceStringType)
        If CheckedOk Then
            Initializing()
        End If
    End Sub
    Private Sub Initializing()
        Select Case SourceStringType
            Case "Hex"
                ResultDec = CDec("&H" & SourceString)
                ResultHex = Hex(ResultDec)
                Initialized = True
            Case "Dec"
                ResultDec = CDec(SourceString)
                ResultHex = Hex(ResultDec)
                Initialized = True
        End Select
    End Sub
    Private Sub CheckSourceString(ByVal type As String)
        Select Case type
            Case "Hex"
                If Not (SourceString Like "[!0-9A-Fa-f]") Then CheckedOk = True
            Case "Dec"
                If IsNumeric(SourceString) Then CheckedOk = True
        End Select
    End Sub
    Public Function getSourceStringDecValue() As Decimal
        Return ResultDec
    End Function
    Public Function getSourceStringHexValue() As String
        Return ResultHex
    End Function
    Public Function getSourceStringInitializationStatus() As Boolean
        Return Initialized
    End Function
End Class
