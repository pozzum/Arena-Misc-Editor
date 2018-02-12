Imports System.IO    'Files
Imports System.Text ' Text Encoding

Public Class _2K18Misc
    Dim active_file As String
    Dim misc_array As Byte()
    Private Sub _2K18Misc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Application.OpenForms().OfType(Of MainMenu).Any Then
            MainMenu.Close()
        End If
        DataGridView1.TopLeftHeaderCell.Value = "Arena"
    End Sub
#Region "Reading Misc"

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            active_file = OpenFileDialog1.FileName
            If File.Exists(active_file) Then
                OpenMisc(active_file)
            End If
        End If
    End Sub

    Private Sub OpenMisc(ByVal Source As String)
        Dim fileLength As Long
        Using reader As New BinaryReader(File.Open(Source, FileMode.Open, FileAccess.Read))
            fileLength = reader.BaseStream.Length
            misc_array = reader.ReadBytes(fileLength)
        End Using
        'MessageBox.Show(fileLength)
        Dim arena_count As Integer = BitConverter.ToInt32(misc_array, 0)
        DataGridView1.Rows.Clear()
        For i As Integer = 0 To arena_count - 1
            Dim ArenaNum As String = Encoding.ASCII.GetString(misc_array, 25 + i * 32, 2)
            Dim tempstart As Integer = BitConverter.ToInt32(misc_array, 40 + i * 32)
            Dim templength As Integer = BitConverter.ToInt32(misc_array, 36 + i * 32)
            Dim Arena_String As String = Encoding.ASCII.GetString(misc_array, tempstart, templength)
            'MessageBox.Show(Arena_String)
            Dim Stadium As String = Arena_String.Substring(Arena_String.IndexOf("Stadium") + 9, Arena_String.IndexOf(",", Arena_String.IndexOf("Stadium") + 9) - Arena_String.IndexOf("Stadium") - 9)
            Dim Advert As String = Arena_String.Substring(Arena_String.IndexOf("Advertisement") + 15, Arena_String.IndexOf(",", Arena_String.IndexOf("Advertisement") + 15) - Arena_String.IndexOf("Advertisement") - 15)
            Dim CornerPost As String = Arena_String.Substring(Arena_String.IndexOf("CornerPost") + 12, Arena_String.IndexOf(",", Arena_String.IndexOf("CornerPost") + 12) - Arena_String.IndexOf("CornerPost") - 12)
            Dim TempLEDCorner As Integer = Arena_String.IndexOf("LED_CornerPost")
            Dim LEDCorner As String = "-1"
            If TempLEDCorner = -1 Then
            Else
                LEDCorner = Arena_String.Substring(Arena_String.IndexOf("LED_CornerPost") + 16, Arena_String.IndexOf(",", Arena_String.IndexOf("LED_CornerPost") + 16) - Arena_String.IndexOf("LED_CornerPost") - 16)
            End If
            Dim Rope As String = Arena_String.Substring(Arena_String.IndexOf("Rope") + 6, Arena_String.IndexOf(",", Arena_String.IndexOf("Rope") + 6) - Arena_String.IndexOf("Rope") - 6)
            Dim Apron As String = Arena_String.Substring(Arena_String.IndexOf("Apron") + 7, Arena_String.IndexOf(",", Arena_String.IndexOf("Apron") + 7) - Arena_String.IndexOf("Apron") - 7)
            Dim LEDApron As String = Arena_String.Substring(Arena_String.IndexOf("LED_Apron") + 11, Arena_String.IndexOf(",", Arena_String.IndexOf("LED_Apron") + 11) - Arena_String.IndexOf("LED_Apron") - 11)
            Dim Turnbuckle As String = Arena_String.Substring(Arena_String.IndexOf("Turnbuckle") + 12, Arena_String.IndexOf(",", Arena_String.IndexOf("Turnbuckle") + 12) - Arena_String.IndexOf("Turnbuckle") - 12)
            Dim Barricade As String = Arena_String.Substring(Arena_String.IndexOf("Barricade") + 11, Arena_String.IndexOf(",", Arena_String.IndexOf("Barricade") + 11) - Arena_String.IndexOf("Barricade") - 11)
            Dim Fence As String = Arena_String.Substring(Arena_String.IndexOf("Fence") + 7, Arena_String.IndexOf(",", Arena_String.IndexOf("Fence") + 7) - Arena_String.IndexOf("Fence") - 7)
            Dim CeilingLight As String = Arena_String.Substring(Arena_String.IndexOf("CeilingLighting") + 17, Arena_String.IndexOf(",", Arena_String.IndexOf("CeilingLighting") + 17) - Arena_String.IndexOf("CeilingLighting") - 17)
            Dim SpotLight As String = Arena_String.Substring(Arena_String.IndexOf("Spotlight") + 11, Arena_String.IndexOf(",", Arena_String.IndexOf("Spotlight") + 11) - Arena_String.IndexOf("Spotlight") - 11)
            Dim Stairs As String = Arena_String.Substring(Arena_String.IndexOf("Stairs") + 8, Arena_String.IndexOf(",", Arena_String.IndexOf("Stairs") + 8) - Arena_String.IndexOf("Stairs") - 8)
            Dim CommentarySeat As String = Arena_String.Substring(Arena_String.IndexOf("CommentarySeat") + 16, Arena_String.IndexOf(",", Arena_String.IndexOf("CommentarySeat") + 16) - Arena_String.IndexOf("CommentarySeat") - 16)
            Dim RingMat As String = Arena_String.Substring(Arena_String.IndexOf("RingMat") + 9, Arena_String.IndexOf(",", Arena_String.IndexOf("RingMat") + 9) - Arena_String.IndexOf("RingMat") - 9)
            Dim FloorMat As String = Arena_String.Substring(Arena_String.IndexOf("FloorMattress") + 15, Arena_String.IndexOf(",", Arena_String.IndexOf("FloorMattress") + 15) - Arena_String.IndexOf("FloorMattress") - 15)
            Dim Crowd As String = Arena_String.Substring(Arena_String.IndexOf("Crowd") + 7, Arena_String.IndexOf(",", Arena_String.IndexOf("Crowd") + 7) - Arena_String.IndexOf("Crowd") - 7)
            Dim IBL As String = Arena_String.Substring(Arena_String.IndexOf("IBL") + 5, Arena_String.IndexOf(",", Arena_String.IndexOf("IBL") + 5) - Arena_String.IndexOf("IBL") - 5)
            Dim Titantron As String = Arena_String.Substring(Arena_String.IndexOf("Titantron") + 11, Arena_String.IndexOf(",", Arena_String.IndexOf("Titantron") + 11) - Arena_String.IndexOf("Titantron") - 11)
            Dim Minitron As String = Arena_String.Substring(Arena_String.IndexOf("Minitron") + 10, Arena_String.IndexOf(",", Arena_String.IndexOf("Minitron") + 10) - Arena_String.IndexOf("Minitron") - 10)
            Dim Wall_L As String = Arena_String.Substring(Arena_String.IndexOf("Wall_L") + 8, Arena_String.IndexOf(",", Arena_String.IndexOf("Wall_L") + 8) - Arena_String.IndexOf("Wall_L") - 8)
            Dim Wall_R As String = Arena_String.Substring(Arena_String.IndexOf("Wall_R") + 8, Arena_String.IndexOf(",", Arena_String.IndexOf("Wall_R") + 8) - Arena_String.IndexOf("Wall_R") - 8)
            Dim Header As String = Arena_String.Substring(Arena_String.IndexOf("Header") + 8, Arena_String.IndexOf(",", Arena_String.IndexOf("Header") + 8) - Arena_String.IndexOf("Header") - 8)
            Dim Floor As String = Arena_String.Substring(Arena_String.IndexOf("Floor""") + 7, Arena_String.IndexOf(",", Arena_String.IndexOf("Floor""") + 7) - Arena_String.IndexOf("Floor""") - 7)
            Dim MiscObject As String = Arena_String.Substring(Arena_String.IndexOf("MiscObjects") + 13, Arena_String.IndexOf(",", Arena_String.IndexOf("MiscObjects") + 13) - Arena_String.IndexOf("MiscObjects") - 13)
            Dim TempLightType As Integer = Arena_String.IndexOf("LightingType")
            Dim LightingType As String = "-1"
            If TempLightType = -1 Then
            Else
                LightingType = Arena_String.Substring(Arena_String.IndexOf("LightingType") + 14, Arena_String.IndexOf(",", Arena_String.IndexOf("LightingType") + 14) - Arena_String.IndexOf("LightingType") - 14)
            End If
            Dim TempCornerCM As Integer = Arena_String.IndexOf("CornerPost_CM")
            Dim CornerPost_CM As String = "0"
            If TempCornerCM = -1 Then
            Else
                CornerPost_CM = Arena_String.Substring(Arena_String.IndexOf("CornerPost_CM") + 15, Arena_String.IndexOf(",", Arena_String.IndexOf("CornerPost_CM") + 15) - Arena_String.IndexOf("CornerPost_CM") - 15)
            End If
            Dim TempRopeCM As Integer = Arena_String.IndexOf("Rope_CM")
            Dim Rope_CM As String = "0"
            If TempRopeCM = -1 Then
            Else
                Rope_CM = Arena_String.Substring(Arena_String.IndexOf("Rope_CM") + 9, Arena_String.IndexOf(",", Arena_String.IndexOf("Rope_CM") + 9) - Arena_String.IndexOf("Rope_CM") - 9)
            End If
            Dim TempApronCM As Integer = Arena_String.IndexOf("Apron_CM")
            Dim Apron_CM As String = "0"
            If TempApronCM = -1 Then
            Else
                Apron_CM = Arena_String.Substring(Arena_String.IndexOf("Apron_CM") + 10, Arena_String.IndexOf(",", Arena_String.IndexOf("Apron_CM") + 10) - Arena_String.IndexOf("Apron_CM") - 10)
            End If
            Dim TempTurnCM As Integer = Arena_String.IndexOf("Turnbuckle_CM")
            Dim Turnbuckle_CM As String = "0"
            If TempTurnCM = -1 Then
            Else
                Turnbuckle_CM = Arena_String.Substring(Arena_String.IndexOf("Turnbuckle_CM") + 15, Arena_String.IndexOf(",", Arena_String.IndexOf("Turnbuckle_CM") + 15) - Arena_String.IndexOf("Turnbuckle_CM") - 15)
            End If
            Dim TempRinmMatCM As Integer = Arena_String.IndexOf("Turnbuckle_CM")
            Dim RingMat_CM As String = "0"
            If TempRinmMatCM = -1 Then
            Else
                RingMat_CM = Arena_String.Substring(Arena_String.IndexOf("RingMat_CM") + 12, Arena_String.IndexOf(",", Arena_String.IndexOf("RingMat_CM") + 12) - Arena_String.IndexOf("RingMat_CM") - 12)
            End If
            Dim version As String = Arena_String.Substring(Arena_String.IndexOf("version") + 9, Arena_String.IndexOf("}", Arena_String.IndexOf("version") + 9) - Arena_String.IndexOf("version") - 9)
            'MessageBox.Show(temparena)
            DataGridView1.Rows.Add(Stadium, Advert, CornerPost, LEDCorner, Rope, Apron, LEDApron, Turnbuckle, Barricade, Fence,
                                       CeilingLight, SpotLight, Stairs, CommentarySeat, RingMat, FloorMat, Crowd, IBL, Titantron, Minitron, Wall_L,
                                       Wall_R, Header, Floor, MiscObject, LightingType, CornerPost_CM, Rope_CM, Apron_CM, Turnbuckle_CM, RingMat_CM, version)
            DataGridView1.Rows.Item(i).HeaderCell.Value = ArenaNum
        Next
    End Sub

#End Region
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        File.Copy(active_file, active_file & ".bak", True)
        Dim Active_Offset As Integer
        Dim Temp_Array As Byte() = New Byte(&H20000) {}
        Temp_Array(0) = DataGridView1.RowCount
        Temp_Array(5) = 1
        Temp_Array(&HC) = &H10
        For i As Integer = 0 To DataGridView1.RowCount - 1
            If i = 0 Then
                Active_Offset = &H10 + &H20 * DataGridView1.RowCount
            End If
            'Making the header 
            Dim Part_Head_Array As Byte() = New Byte(&H20) {}
            'Adding the text parts.
            Buffer.BlockCopy(Encoding.ASCII.GetBytes("arenaInfo" & DataGridView1.Rows.Item(i).HeaderCell.Value), 0, Part_Head_Array, 0, 11)
            Buffer.BlockCopy(Encoding.ASCII.GetBytes("jsn"), 0, Part_Head_Array, &H10, 3)
            'Build the Arena String
            Dim Part_String As String = buildarena(i)
            'MessageBox.Show(Part_String)
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
    Function buildarena(index As Integer) As String
        ' Chr(&H7B) = { Chr(&HD) = Carriage return Chr(&HA) = Line feed
        Dim Temp_String As String = Chr(&H7B) & Chr(&HD) & Chr(&HA) & "    " & """Stadium"":" & DataGridView1(0, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Advertisement"":" & DataGridView1(1, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """CornerPost"":" & DataGridView1(2, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """LED_CornerPost"":" & DataGridView1(3, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Rope"":" & DataGridView1(4, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Apron"":" & DataGridView1(5, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """LED_Apron"":" & DataGridView1(6, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Turnbuckle"":" & DataGridView1(7, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Barricade"":" & DataGridView1(8, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Fence"":" & DataGridView1(9, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """CeilingLighting"":" & DataGridView1(10, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Spotlight"":" & DataGridView1(11, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Stairs"":" & DataGridView1(12, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """CommentarySeat"":" & DataGridView1(13, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """RingMat"":" & DataGridView1(14, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """FloorMattress"":" & DataGridView1(15, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Crowd"":" & DataGridView1(16, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """IBL"":" & DataGridView1(17, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Titantron"":" & DataGridView1(18, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Minitron"":" & DataGridView1(19, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Wall_L"":" & DataGridView1(20, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Wall_R"":" & DataGridView1(21, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Header"":" & DataGridView1(22, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Floor"":" & DataGridView1(23, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """MiscObjects"":" & DataGridView1(24, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """LightingType"":" & DataGridView1(25, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """CornerPost_CM"":" & DataGridView1(26, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Rope_CM"":" & DataGridView1(27, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Apron_CM"":" & DataGridView1(28, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """Turnbuckle_CM"":" & DataGridView1(29, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """RingMat_CM"":" & DataGridView1(30, index).Value.ToString & ","
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & "    " & """version"":" & DataGridView1(31, index).Value.ToString
        Temp_String = Temp_String & Chr(&HD) & Chr(&HA) & Chr(&H7D) & Chr(&HD) & Chr(&HA)
        Return Temp_String
    End Function
End Class