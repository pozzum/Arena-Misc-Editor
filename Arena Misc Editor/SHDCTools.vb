Public Class DataInfoClass
    Public ReferenceName As String
    Public Length As Integer
    Public StartOffset As Long
    Public FullData As Byte()
    Public ErrorMessage As String
End Class
Public Class SHDCTools
    Public Function ExtractAllParts(FullSHDC As Byte()) As List(Of DataInfoClass)
        Dim ReturnedDataInfo As New List(Of DataInfoClass)
        If Not BitConverter.ToString(FullSHDC, 0, 4) = "SHDC" Then
            Dim PartCount As Integer = BitConverter.ToInt32(FullSHDC, &H38)
            If PartCount = 0 Then
                Dim TempDataInfo As DataInfoClass = New DataInfoClass
                TempDataInfo.ErrorMessage = "SHDC file Contains no extractable parts"
                ReturnedDataInfo.Add(TempDataInfo)
                Return ReturnedDataInfo
            End If
            Dim HeaderStart As Integer = BitConverter.ToInt32(FullSHDC, &H1C)
            For i As Integer = 0 To PartCount - 1
                Dim TempDataInfo As DataInfoClass = New DataInfoClass
                TempDataInfo.ReferenceName = Hex(BitConverter.ToInt32(FullSHDC, HeaderStart + i * &H10))
                TempDataInfo.Length = BitConverter.ToInt32(FullSHDC, HeaderStart + i * &H10 + 4)
                TempDataInfo.StartOffset = BitConverter.ToInt64(FullSHDC, HeaderStart + i * &H10 + 8)
                TempDataInfo.FullData = New Byte(TempDataInfo.Length) {}
                Buffer.BlockCopy(FullSHDC, TempDataInfo.StartOffset, TempDataInfo.FullData, 0, TempDataInfo.Length)
                ReturnedDataInfo.Add(TempDataInfo)
            Next
        Else
            Dim TempDataInfo As DataInfoClass = New DataInfoClass
            TempDataInfo.ErrorMessage = "File is not SHDC File"
            ReturnedDataInfo.Add(TempDataInfo)
        End If
        Return ReturnedDataInfo
    End Function
    Public Function ExtractNamedPart(FullSHDC As Byte(), RequestedPart As String) As DataInfoClass
        Dim TempDataInfo As DataInfoClass = New DataInfoClass
        TempDataInfo.ErrorMessage = "Part not found!"
        If Not BitConverter.ToString(FullSHDC, 0, 4) = "SHDC" Then
            Dim PartCount As Integer = BitConverter.ToInt32(FullSHDC, &H38)
            If PartCount = 0 Then
                TempDataInfo.ErrorMessage = "SHDC file Contains no extractable parts"
                Return TempDataInfo
            End If
            Dim HeaderStart As Integer = BitConverter.ToInt32(FullSHDC, &H1C)
            For i As Integer = 0 To PartCount - 1
                If Hex(BitConverter.ToInt32(FullSHDC, HeaderStart + i * &H10)) = RequestedPart Then
                    TempDataInfo.ReferenceName = Hex(BitConverter.ToInt32(FullSHDC, HeaderStart + i * &H10))
                    TempDataInfo.Length = BitConverter.ToInt32(FullSHDC, HeaderStart + i * &H10 + 4)
                    TempDataInfo.StartOffset = BitConverter.ToInt64(FullSHDC, HeaderStart + i * &H10 + 8)
                    TempDataInfo.FullData = New Byte(TempDataInfo.Length) {}
                    Buffer.BlockCopy(FullSHDC, TempDataInfo.StartOffset, TempDataInfo.FullData, 0, TempDataInfo.Length)
                    TempDataInfo.ErrorMessage = ""
                    Return TempDataInfo
                End If
            Next
        Else
            TempDataInfo.ErrorMessage = "File is not SHDC File"
        End If
        Return TempDataInfo
    End Function
    Public Function CheckPartName(FullSHDC As Byte(), TestString As String) As Boolean
        If Not BitConverter.ToString(FullSHDC, 0, 4) = "SHDC" Then
            Dim PartCount As Integer = BitConverter.ToInt32(FullSHDC, &H38)
            If PartCount = 0 Then
                Return False
            End If
            Dim HeaderStart As Integer = BitConverter.ToInt32(FullSHDC, &H1C)
            For i As Integer = 0 To PartCount - 1
                If Hex(BitConverter.ToInt32(FullSHDC, HeaderStart + i * &H10)) = TestString Then
                    Return True
                End If
            Next
        Else
            Return False
        End If
        Return False
    End Function
End Class
