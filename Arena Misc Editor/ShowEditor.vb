Imports System.IO    'Files
Imports System.Text ' Text Encoding
Public Class ShowEditor
    Dim active_file As String
    Dim show_array As Byte()
    Private Sub ShowEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Application.OpenForms().OfType(Of MainMenu).Any Then
            MainMenu.Close()
        End If
        DataGridView1.TopLeftHeaderCell.Value = "Number"
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            active_file = OpenFileDialog1.FileName
            If File.Exists(active_file) Then
                OpenShow(active_file)
            End If
        End If
    End Sub
    Private Sub OpenShow(ByVal Source As String)
        Dim fileLength As Long
        Using reader As New BinaryReader(File.Open(Source, FileMode.Open, FileAccess.Read))
            fileLength = reader.BaseStream.Length
            show_array = reader.ReadBytes(fileLength)
        End Using
        'MessageBox.Show(fileLength)
        DataGridView1.Rows.Clear()
        Dim index As Integer = 0
        Dim current_poition As Long = &HC
        While current_poition < fileLength
            DataGridView1.Rows.Add()
            DataGridView1(0, index).Value = Hex(BitConverter.ToInt32(show_array, current_poition)) ' Dim NameRef As String = 
            DataGridView1(1, index).Value = Hex(show_array(current_poition + 4)) 'Dim S1 As String =
            DataGridView1(2, index).Value = Hex(show_array(current_poition + 5)) 'Dim S2 As String =
            DataGridView1(3, index).Value = Hex(show_array(current_poition + 6)) 'Dim S3 As String = 
            DataGridView1(4, index).Value = Hex(show_array(current_poition + 7)) ' Dim S4 As String = 
            DataGridView1(5, index).Value = Hex(show_array(current_poition + 8)) 'Dim A1 As String =
            DataGridView1(6, index).Value = Hex(show_array(current_poition + 10)) 'Dim A2 As String = 
            DataGridView1(7, index).Value = Hex(BitConverter.ToInt16(show_array, current_poition + 12)) 'Dim B As String = 
            DataGridView1(8, index).Value = BitConverter.ToBoolean(show_array, current_poition + 24) 'Dim C1 As Boolean = 
            DataGridView1(9, index).Value = BitConverter.ToBoolean(show_array, current_poition + 25) ' Dim C2 As Boolean = 
            DataGridView1(10, index).Value = BitConverter.ToBoolean(show_array, current_poition + 26) 'Dim C3 As Boolean = 
            DataGridView1(11, index).Value = BitConverter.ToBoolean(show_array, current_poition + 27) ' Dim C4 As Boolean = 
            DataGridView1(12, index).Value = BitConverter.ToBoolean(show_array, current_poition + 30) 'Dim C5 As Boolean = 
            DataGridView1(13, index).Value = Hex(show_array(current_poition + 31)) 'Dim Stage As String = 
            DataGridView1(14, index).Value = Hex(show_array(current_poition + 34)) 'Dim D1 As String = 
            DataGridView1(15, index).Value = Hex(show_array(current_poition + 35)) 'Dim D2 As String = 
            DataGridView1(16, index).Value = BitConverter.ToBoolean(show_array, current_poition + 36) 'Dim Crowd As Boolean = 
            DataGridView1(17, index).Value = BitConverter.ToBoolean(show_array, current_poition + 37) ' Dim E1 As Boolean = 
            DataGridView1(18, index).Value = BitConverter.ToBoolean(show_array, current_poition + 38) 'Dim E2 As Boolean = 
            DataGridView1(19, index).Value = BitConverter.ToBoolean(show_array, current_poition + 39) ' Dim E3 As Boolean = 
            DataGridView1(20, index).Value = Hex(show_array(current_poition + 40)) 'Dim Ref As String
            'Dim Filter As String
            DataGridView1(21, index).Value = Hex(show_array(current_poition + 41)).PadLeft(2, "0") &
                                             Hex(show_array(current_poition + 42)).PadLeft(2, "0") &
                                             Hex(show_array(current_poition + 43)).PadLeft(2, "0") &
                                             Hex(show_array(current_poition + 44)).PadLeft(2, "0") &
                                             Hex(show_array(current_poition + 45)).PadLeft(2, "0") &
                                             Hex(show_array(current_poition + 46)).PadLeft(2, "0")
            'Dim F1 As String
            DataGridView1(22, index).Value = Hex(BitConverter.ToInt32(show_array, current_poition + 52))
            'DataGridView1(22, index).Value = Hex(show_array(current_poition + 52)).PadLeft(2, "0") &
            'Hex(show_array(current_poition + 53)).PadLeft(2, "0") &
            'Hex(show_array(current_poition + 54)).PadLeft(2, "0") &
            'Hex(show_array(current_poition + 55)).PadLeft(2, "0")
            DataGridView1(23, index).Value = Hex(show_array(current_poition + 56)) 'Dim F2 As String
            DataGridView1(24, index).Value = Hex(show_array(current_poition + 60)) 'Dim G1 As String
            DataGridView1(25, index).Value = Hex(show_array(current_poition + 62)) 'Dim G2 As String
            DataGridView1(26, index).Value = Hex(show_array(current_poition + 64)) 'Dim H1 As String
            DataGridView1(27, index).Value = Hex(show_array(current_poition + 65)) 'Dim H2 As String
            DataGridView1(28, index).Value = Hex(show_array(current_poition + 66)) 'Dim H3 As String
            DataGridView1(29, index).Value = Hex(show_array(current_poition + 67)) 'Dim H4 As String
            DataGridView1(30, index).Value = Hex(show_array(current_poition + 69)) 'Dim Bar As String
            'Dim Unknown As String
            Dim temparray As Byte() = New Byte(33) {}
            Buffer.BlockCopy(show_array, current_poition + 70, temparray, 0, 34)
            DataGridView1(31, index).Value = ByteArrayToHex(temparray)
            DataGridView1(32, index).Value = Hex(show_array(current_poition + 107)) 'Dim I1 As String
            DataGridView1(33, index).Value = Hex(show_array(current_poition + 108)) 'Dim I2 As String
            DataGridView1(34, index).Value = Hex(show_array(current_poition + 110))  'Dim I3 As String
            DataGridView1(35, index).Value = Hex(show_array(current_poition + 113)) 'Dim live As String
            DataGridView1(36, index).Value = Hex(show_array(current_poition + 116)) 'Dim J As String
            'DataGridView1.Rows.Add(NameRef, S1, S2, S3, S4, A1, A2, B, C1, C2, C3, C4, C5, Stage, D1, D2, Crowd, E1, E2, E3)
            DataGridView1.Rows(index).HeaderCell.Value = index.ToString
            index += 1
            current_poition += &H78
        End While
        ExportToCSVToolStripMenuItem.Visible = True
    End Sub


    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        File.Copy(active_file, active_file & ".bak", True)
        Dim Active_Offset As Integer = &HC
        Dim Temp_Array As Byte() = show_array
        For i As Integer = 0 To DataGridView1.RowCount - 1
            Buffer.BlockCopy(buildshow(i), 0, Temp_Array, Active_Offset, &H78)
            Active_Offset += &H78
        Next
        File.WriteAllBytes(active_file, Temp_Array)
        MessageBox.Show("File Saved")
    End Sub
    Function buildshow(index As Integer) As Byte()
        Dim Temp_Array As Byte() = New Byte(&H78) {}
        Buffer.BlockCopy(BitConverter.GetBytes(Convert.ToInt64(DataGridView1(0, index).Value, 16)), 0, Temp_Array, 0, 4)
        Buffer.BlockCopy(BitConverter.GetBytes(Convert.ToInt16(DataGridView1(1, index).Value, 16)), 0, Temp_Array, 4, 1)
        Buffer.BlockCopy(BitConverter.GetBytes(Convert.ToInt16(DataGridView1(2, index).Value, 16)), 0, Temp_Array, 5, 1)
        Buffer.BlockCopy(BitConverter.GetBytes(Convert.ToInt16(DataGridView1(3, index).Value, 16)), 0, Temp_Array, 6, 1)
        Buffer.BlockCopy(BitConverter.GetBytes(Convert.ToInt16(DataGridView1(4, index).Value, 16)), 0, Temp_Array, 7, 1)
        Buffer.BlockCopy(BitConverter.GetBytes(Convert.ToInt16(DataGridView1(5, index).Value, 16)), 0, Temp_Array, 8, 1)
        Buffer.BlockCopy(BitConverter.GetBytes(Convert.ToInt16(DataGridView1(6, index).Value, 16)), 0, Temp_Array, 10, 1)
        Buffer.BlockCopy(BitConverter.GetBytes(Convert.ToInt32(DataGridView1(7, index).Value, 16)), 0, Temp_Array, 12, 2)
        If DataGridView1(8, index).Value Then
            Temp_Array(24) = 1
        Else
            Temp_Array(24) = 0
        End If
        If DataGridView1(9, index).Value Then
            Temp_Array(25) = 1
        Else
            Temp_Array(25) = 0
        End If
        If DataGridView1(10, index).Value Then
            Temp_Array(26) = 1
        Else
            Temp_Array(26) = 0
        End If
        If DataGridView1(11, index).Value Then
            Temp_Array(27) = 1
        Else
            Temp_Array(27) = 0
        End If
        If DataGridView1(12, index).Value Then
            Temp_Array(30) = 1
        Else
            Temp_Array(30) = 0
        End If
        Temp_Array(31) = Convert.ToInt16(DataGridView1(13, index).Value, 16)
        Temp_Array(34) = Convert.ToInt16(DataGridView1(14, index).Value, 16)
        Temp_Array(35) = Convert.ToInt16(DataGridView1(15, index).Value, 16)
        If DataGridView1(16, index).Value Then
            Temp_Array(36) = 1
        Else
            Temp_Array(36) = 0
        End If
        If DataGridView1(17, index).Value Then
            Temp_Array(37) = 1
        Else
            Temp_Array(37) = 0
        End If
        If DataGridView1(18, index).Value Then
            Temp_Array(38) = 1
        Else
            Temp_Array(38) = 0
        End If
        If DataGridView1(19, index).Value Then
            Temp_Array(39) = 1
        Else
            Temp_Array(39) = 0
        End If
        Temp_Array(40) = Convert.ToInt16(DataGridView1(20, index).Value, 16)
        Buffer.BlockCopy(HexToArray(DataGridView1(21, index).Value), 0, Temp_Array, 41, 6)
        Temp_Array(47) = &HFF
        Temp_Array(48) = &HFF
        Temp_Array(49) = &HFF
        Buffer.BlockCopy(BitConverter.GetBytes(Convert.ToInt64(DataGridView1(22, index).Value, 16)), 0, Temp_Array, 52, 4)
        Temp_Array(56) = Convert.ToInt16(DataGridView1(23, index).Value, 16)
        Temp_Array(60) = Convert.ToInt16(DataGridView1(24, index).Value, 16)
        Temp_Array(62) = Convert.ToInt16(DataGridView1(25, index).Value, 16)
        Temp_Array(64) = Convert.ToInt16(DataGridView1(26, index).Value, 16)
        Temp_Array(65) = Convert.ToInt16(DataGridView1(27, index).Value, 16)
        Temp_Array(66) = Convert.ToInt16(DataGridView1(28, index).Value, 16)
        Temp_Array(67) = Convert.ToInt16(DataGridView1(29, index).Value, 16)
        Temp_Array(69) = Convert.ToInt16(DataGridView1(30, index).Value, 16)
        Buffer.BlockCopy(HexToArray(DataGridView1(31, index).Value), 0, Temp_Array, 70, 34)
        Temp_Array(104) = &H70
        Temp_Array(105) = &H70
        Temp_Array(106) = &H70
        Temp_Array(107) = Convert.ToInt16(DataGridView1(32, index).Value, 16)
        Temp_Array(108) = Convert.ToInt16(DataGridView1(33, index).Value, 16)
        Temp_Array(110) = Convert.ToInt16(DataGridView1(34, index).Value, 16)
        Temp_Array(113) = Convert.ToInt16(DataGridView1(35, index).Value, 16)
        Temp_Array(114) = &HFF
        Temp_Array(116) = Convert.ToInt16(DataGridView1(36, index).Value, 16)

        Return Temp_Array
    End Function
    Private Function ByteArrayToHex(ByRef ByteArray() As Byte) As String
        Dim l As Long, strRet As String

        For l = LBound(ByteArray) To UBound(ByteArray)
            strRet = strRet & Hex(ByteArray(l)).PadLeft(2, "0") & " "
        Next l

        'Remove last space at end.
        ByteArrayToHex = strRet.TrimEnd(" ") '(strRet, Len(strRet) - 1)
    End Function

    Private Function HexToArray(TempText As String) As Byte()
        TempText = TempText.Replace(" ", "")
        Dim length As Integer = TempText.Length
        Dim loc As Integer = 0
        Dim RetArray As Byte() = New Byte(length / 2) {}
        Try
            While loc < length
                RetArray(loc / 2) = Convert.ToInt16(TempText.Substring(loc, 2), 16)
                loc += 2
            End While
        Catch ex As Exception
            MessageBox.Show(loc & " " & length & " " & ex.Message)
        End Try
        Return RetArray
    End Function

    Private Sub ExportToCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToCSVToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim headers = (From header As DataGridViewColumn In DataGridView1.Columns.Cast(Of DataGridViewColumn)()
                           Select header.HeaderText).ToArray
            Dim rows As List(Of String) = New List(Of String)
            For Each temprow As DataGridViewRow In DataGridView1.Rows
                If Not temprow.IsNewRow Then
                    Dim Tempstring = temprow.HeaderCell.Value.ToString
                    For Each tempcell As DataGridViewCell In temprow.Cells
                        If tempcell.ValueType = GetType(CheckBox) Then
                            MessageBox.Show("Checkbox")
                            If tempcell.Value Then
                                Tempstring += ",1"
                            Else
                                Tempstring += ",0"
                            End If
                        Else
                            Tempstring += "," & tempcell.Value
                        End If
                    Next
                    rows.Add(Tempstring)
                End If
            Next
            Using sw As New IO.StreamWriter(SaveFileDialog1.FileName)
                sw.WriteLine("Number," & String.Join(",", headers))
                For Each r In rows
                    sw.WriteLine(r)
                Next
            End Using
            MessageBox.Show("File Saved")
        End If
    End Sub
End Class