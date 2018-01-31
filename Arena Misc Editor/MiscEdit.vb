Imports System.IO    'Files
Imports System.Text ' Text Encoding
Public Class MiscEdit
    Dim active_file As String
    Dim Arena_Info(0) As NumericUpDown
    Dim Stadium(0) As NumericUpDown
    Dim Advertisement(0) As NumericUpDown
    Dim Cornerpost(0) As NumericUpDown
    Dim Rope(0) As NumericUpDown
    Dim Apron(0) As NumericUpDown
    Dim LED_Apron(0) As NumericUpDown
    Dim Turnbuckle(0) As NumericUpDown
    Dim Barricade(0) As NumericUpDown
    Dim Fence(0) As NumericUpDown
    Dim Ceiling_Light(0) As NumericUpDown
    Dim Spotlight(0) As NumericUpDown
    Dim Stairs(0) As NumericUpDown
    Dim Announcer_Steats(0) As NumericUpDown
    Dim Ringmat(0) As NumericUpDown
    Dim Floormat(0) As NumericUpDown
    Dim Crowd(0) As NumericUpDown
    Dim IBL(0) As NumericUpDown
    Dim Titantron(0) As NumericUpDown
    Dim Minitron(0) As NumericUpDown
    Dim Walltron_L(0) As NumericUpDown
    Dim Walltron_R(0) As NumericUpDown
    Dim Header(0) As NumericUpDown
    Dim Floor(0) As NumericUpDown
    Dim Misc_Objects(0) As NumericUpDown
    Dim Light_Type(0) As NumericUpDown


    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            active_file = OpenFileDialog1.FileName
            If File.Exists(active_file) Then
                OpenMisc(active_file)
            End If
        End If
    End Sub

    Private Sub OpenMisc(ByVal Source As String)
        Dim Arena_Count As Integer = BitConverter.ToInt32(ReadFile(Source, 0, 4), 0)
        For i As Integer = 0 To Arena_Count - 1
            AddArena(i)
        Next
    End Sub

    Shared Function ReadFile(Filepath As String, pos As Long, requiredbytes As Integer, Optional reverse As Boolean = False) As Byte()
        'Dim pos As Long = 6160
        'Dim requiredBytes As Integer = 12
        Dim value(0 To requiredbytes - 1) As Byte
        Using reader As New BinaryReader(File.Open(Filepath, FileMode.Open))
            ' Loop through length of file.
            Dim fileLength As Long = reader.BaseStream.Length
            Dim byteCount As Integer = 0
            reader.BaseStream.Seek(pos, SeekOrigin.Begin)
            While pos < fileLength And byteCount < requiredbytes
                value(byteCount) = reader.ReadByte()
                pos += 1
                byteCount += 1
            End While
        End Using
        If reverse = True Then
            Array.Reverse(value, 0, value.Length)
        End If
        Return value
    End Function
    Private Sub AddArena(Count As Integer, Optional NewArena As Boolean = False)
        Dim New_Num As NumericUpDown
        '---------------
        ReDim Preserve Arena_Info(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 6
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 57
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = Count
        Arena_Info(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Arena_Info(Count))
        ReDim Preserve Stadium(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 69
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 45
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Stadium(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Stadium(Count))
        ReDim Preserve Advertisement(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 119
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 43
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Advertisement(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Advertisement(Count))
        ReDim Preserve Cornerpost(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 168
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 41
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Cornerpost(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Cornerpost(Count))
        ReDim Preserve Rope(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 215
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 36
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Rope(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Rope(Count))
        ReDim Preserve Apron(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 258
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 37
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Apron(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Apron(Count))
        ReDim Preserve LED_Apron(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 301
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 31
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        LED_Apron(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(LED_Apron(Count))
        ReDim Preserve Turnbuckle(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 338
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 43
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Turnbuckle(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Turnbuckle(Count))
        ReDim Preserve Barricade(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 387
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 55
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Barricade(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Barricade(Count))
        ReDim Preserve Fence(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 448
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 40
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Fence(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Fence(Count))
        ReDim Preserve Ceiling_Light(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 494
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 51
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Ceiling_Light(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Ceiling_Light(Count))
        ReDim Preserve Spotlight(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 551
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 32
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Spotlight(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Spotlight(Count))
        ReDim Preserve Stairs(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 589
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 36
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Stairs(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Stairs(Count))
        ReDim Preserve Announcer_Steats(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 631
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 32
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Announcer_Steats(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Announcer_Steats(Count))
        ReDim Preserve Ringmat(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 669
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 49
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Ringmat(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Ringmat(Count))
        ReDim Preserve Floormat(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 724
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 50
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Floormat(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Floormat(Count))
        ReDim Preserve Crowd(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 780
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 40
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Crowd(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Crowd(Count))
        ReDim Preserve IBL(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 826
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 26
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        IBL(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(IBL(Count))
        ReDim Preserve Titantron(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 858
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 35
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Titantron(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Titantron(Count))
        ReDim Preserve Minitron(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 899
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 36
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Minitron(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Minitron(Count))
        ReDim Preserve Walltron_L(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 941
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 40
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Walltron_L(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Walltron_L(Count))
        ReDim Preserve Walltron_R(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 987
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 42
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Walltron_R(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Walltron_R(Count))
        ReDim Preserve Header(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 1035
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 45
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Header(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Header(Count))
        ReDim Preserve Floor(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 1086
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 33
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Floor(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Floor(Count))
        ReDim Preserve Misc_Objects(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 1125
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 32
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Misc_Objects(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Misc_Objects(Count))
        ReDim Preserve Light_Type(Count)
        New_Num = New NumericUpDown
        New_Num.Left = 1162
        New_Num.Top = 3 + 26 * Count
        New_Num.Width = 31
        New_Num.Minimum = -1
        New_Num.Maximum = 99
        New_Num.Value = -1
        Light_Type(Count) = New_Num
        SplitContainer1.Panel2.Controls.Add(Light_Type(Count))
        If NewArena = False Then
            Dim File_Header As Byte() = ReadFile(active_file, &H10 + Count * &H20, &H20)
            Arena_Info(Count).Value = Convert.ToInt32(System.Text.Encoding.ASCII.GetString({File_Header(9), File_Header(10)}))
            Dim Offset As Integer = BitConverter.ToInt32({File_Header(&H18), File_Header(&H19), File_Header(&H1A), File_Header(&H1B)}, 0)
            Dim Length As Integer = BitConverter.ToInt32({File_Header(&H14), File_Header(&H15), File_Header(&H16), File_Header(&H17)}, 0)
            Dim Arena_Array As Byte() = ReadFile(active_file, Offset, Length)
            Dim Arena_String As String = System.Text.Encoding.ASCII.GetString(Arena_Array)
            Stadium(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("Stadium") + 9, Arena_String.IndexOf(",", Arena_String.IndexOf("Stadium") + 9) - Arena_String.IndexOf("Stadium") - 9))
            Advertisement(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("Advertisement") + 15, Arena_String.IndexOf(",", Arena_String.IndexOf("Advertisement") + 15) - Arena_String.IndexOf("Advertisement") - 15))
            Cornerpost(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("CornerPost") + 12, Arena_String.IndexOf(",", Arena_String.IndexOf("CornerPost") + 12) - Arena_String.IndexOf("CornerPost") - 12))
            Rope(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("Rope") + 6, Arena_String.IndexOf(",", Arena_String.IndexOf("Rope") + 6) - Arena_String.IndexOf("Rope") - 6))
            Apron(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("Apron") + 7, Arena_String.IndexOf(",", Arena_String.IndexOf("Apron") + 7) - Arena_String.IndexOf("Apron") - 7))
            If Arena_String.IndexOf("LED_Apron") = -1 Then
                LED_Apron(Count).Value = -1
            Else
                LED_Apron(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("LED_Apron") + 11, Arena_String.IndexOf(",", Arena_String.IndexOf("LED_Apron") + 11) - Arena_String.IndexOf("LED_Apron") - 11))
            End If
            Turnbuckle(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("Turnbuckle") + 12, Arena_String.IndexOf(",", Arena_String.IndexOf("Turnbuckle") + 12) - Arena_String.IndexOf("Turnbuckle") - 12))
            Barricade(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("Barricade") + 11, Arena_String.IndexOf(",", Arena_String.IndexOf("Barricade") + 11) - Arena_String.IndexOf("Barricade") - 11))
            Fence(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("Fence") + 7, Arena_String.IndexOf(",", Arena_String.IndexOf("Fence") + 7) - Arena_String.IndexOf("Fence") - 7))
            Ceiling_Light(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("CeilingLighting") + 17, Arena_String.IndexOf(",", Arena_String.IndexOf("CeilingLighting") + 17) - Arena_String.IndexOf("CeilingLighting") - 17))
            Spotlight(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("Spotlight") + 11, Arena_String.IndexOf(",", Arena_String.IndexOf("Spotlight") + 11) - Arena_String.IndexOf("Spotlight") - 11))
            Stairs(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("Stairs") + 8, Arena_String.IndexOf(",", Arena_String.IndexOf("Stairs") + 8) - Arena_String.IndexOf("Stairs") - 8))
            Announcer_Steats(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("CommentarySeat") + 16, Arena_String.IndexOf(",", Arena_String.IndexOf("CommentarySeat") + 16) - Arena_String.IndexOf("CommentarySeat") - 16))
            Ringmat(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("RingMat") + 9, Arena_String.IndexOf(",", Arena_String.IndexOf("RingMat") + 9) - Arena_String.IndexOf("RingMat") - 9))
            Floormat(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("FloorMattress") + 15, Arena_String.IndexOf(",", Arena_String.IndexOf("FloorMattress") + 15) - Arena_String.IndexOf("FloorMattress") - 15))
            Crowd(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("Crowd") + 7, Arena_String.IndexOf(",", Arena_String.IndexOf("Crowd") + 7) - Arena_String.IndexOf("Crowd") - 7))
            IBL(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("IBL") + 5, Arena_String.IndexOf(",", Arena_String.IndexOf("IBL") + 5) - Arena_String.IndexOf("IBL") - 5))
            If Arena_String.IndexOf("Titantron") = -1 Then
                Titantron(Count).Value = -1
            Else
                Titantron(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("Titantron") + 11, Arena_String.IndexOf(",", Arena_String.IndexOf("Titantron") + 11) - Arena_String.IndexOf("Titantron") - 11))
            End If
            If Arena_String.IndexOf("Minitron") = -1 Then
                Minitron(Count).Value = -1
            Else
                Minitron(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("Minitron") + 10, Arena_String.IndexOf(",", Arena_String.IndexOf("Minitron") + 10) - Arena_String.IndexOf("Minitron") - 10))
            End If
            If Arena_String.IndexOf("Wall_L") = -1 Then
                Walltron_L(Count).Value = -1
            Else
                Walltron_L(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("Wall_L") + 8, Arena_String.IndexOf(",", Arena_String.IndexOf("Wall_L") + 8) - Arena_String.IndexOf("Wall_L") - 8))
            End If
            If Arena_String.IndexOf("Wall_R") = -1 Then
                Walltron_R(Count).Value = -1
            Else
                Walltron_R(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("Wall_R") + 8, Arena_String.IndexOf(",", Arena_String.IndexOf("Wall_R") + 8) - Arena_String.IndexOf("Wall_R") - 8))
            End If
            If Arena_String.IndexOf("Header") = -1 Then
                Header(Count).Value = -1
            Else
                Header(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("Header") + 8, Arena_String.IndexOf(",", Arena_String.IndexOf("Header") + 8) - Arena_String.IndexOf("Header") - 8))
            End If
            If Arena_String.IndexOf("Floor""") = -1 Then
                Floor(Count).Value = -1
            Else
                Floor(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("Floor""") + 7, Arena_String.IndexOf(",", Arena_String.IndexOf("Floor""") + 7) - Arena_String.IndexOf("Floor""") - 7))
            End If
            If Arena_String.IndexOf("MiscObjects") = -1 Then
                Misc_Objects(Count).Value = -1
            Else
                Misc_Objects(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("MiscObjects") + 13, Arena_String.IndexOf(",", Arena_String.IndexOf("MiscObjects") + 13) - Arena_String.IndexOf("MiscObjects") - 13))
            End If
            If Arena_String.IndexOf("LightingType") = -1 Then
                Light_Type(Count).Value = -1
            Else
                Light_Type(Count).Value = Convert.ToInt32(Arena_String.Substring(Arena_String.IndexOf("LightingType") + 14, Arena_String.IndexOf(",", Arena_String.IndexOf("LightingType") + 14) - Arena_String.IndexOf("LightingType") - 14))
            End If
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        File.Copy(active_file, active_file & ".bak", True)
        Dim Active_Offset As Integer
        Dim Temp_Array As Byte() = New Byte(&H10000) {}
        Temp_Array(0) = Arena_Info.Length
        Temp_Array(5) = 1
        Temp_Array(&HC) = &H10
        For i As Integer = 0 To Arena_Info.Length - 1
            If i = 0 Then
                Active_Offset = &H10 + &H20 * Arena_Info.Length
            End If
            'Making the header 
            Dim Part_Head_Array As Byte() = New Byte(&H20) {}
            'Adding the text parts.
            Buffer.BlockCopy(Encoding.ASCII.GetBytes("arenaInfo" & Arena_Info(i).Value.ToString.PadLeft(2, "0")), 0, Part_Head_Array, 0, 11)
            Buffer.BlockCopy(Encoding.ASCII.GetBytes("jsn"), 0, Part_Head_Array, &H10, 3)
            'Build the Arena String
            Dim Part_String As String = BuildArena(i)
            'Add the Length to the Header
            Dim Length_Array As Byte() = System.BitConverter.GetBytes(Part_String.Length)
            'Array.Reverse(Length_Array, 0, Length_Array.Length)
            Buffer.BlockCopy(Length_Array, 0, Part_Head_Array, &H14, 4)
            'Add the offset to the header
            Dim Offset_Array As Byte() = System.BitConverter.GetBytes(Active_Offset)
            'Array.Reverse(Offset_Array, 0, Offset_Array.Length)
            Buffer.BlockCopy(Offset_Array, 0, Part_Head_Array, &H18, 4)
            'injecting the header
            Buffer.BlockCopy(Part_Head_Array, 0, Temp_Array, &H10 + &H20 * i, &H20)
            'Adding the ArenaInfo to the ararry
            Buffer.BlockCopy(Encoding.ASCII.GetBytes(Part_String), 0, Temp_Array, Active_Offset, Part_String.Length)
            'Updating the Active Offset
            Active_Offset = Active_Offset + Part_String.Length + (16 - Part_String.Length Mod 16)
        Next
        Dim Final_Array As Byte() = New Byte(Active_Offset - 1) {}
        Buffer.BlockCopy(Temp_Array, 0, Final_Array, 0, Active_Offset)
        File.WriteAllBytes(active_file, Final_Array)
        MessageBox.Show("File Saved")
    End Sub

    Private Function BuildArena(Count As Integer) As String
        ' Chr(&H7B) = { Chr(&HD) = Carriage return Chr(&HA) = Line feed
        Dim Temp_String As String =
            Chr(&H7B) & Chr(&HD) & Chr(&HA) & "    " & """Stadium"":" & Stadium(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """Advertisement"":" & Advertisement(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """CornerPost"":" & Cornerpost(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """Rope"":" & Rope(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """Apron"":" & Apron(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """LED_Apron"":" & LED_Apron(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """Turnbuckle"":" & Turnbuckle(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """Barricade"":" & Barricade(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """Fence"":" & Fence(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """CeilingLighting"":" & Ceiling_Light(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """Spotlight"":" & Spotlight(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """Stairs"":" & Stairs(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """CommentarySeat"":" & Announcer_Steats(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """RingMat"":" & Ringmat(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """FloorMattress"":" & Floormat(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """Crowd"":" & Crowd(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """IBL"":" & IBL(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """Titantron"":" & Titantron(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """Minitron"":" & Minitron(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """Wall_L"":" & Walltron_L(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """Wall_R"":" & Walltron_R(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """Header"":" & Header(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """Floor"":" & Floor(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """MiscObjects"":" & Misc_Objects(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """LightingType"":" & Light_Type(Count).Value & "," &
            Chr(&HD) & Chr(&HA) & "    " & """version"":""1.0""" & Chr(&HD) & Chr(&HA) & Chr(&H7D) & Chr(&HD) & Chr(&HA)
        Return Temp_String
    End Function

End Class
