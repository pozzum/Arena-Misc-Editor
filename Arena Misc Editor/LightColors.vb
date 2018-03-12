Imports System.IO    'Files
Imports System.Text ' Text Encoding
Public Class LightColors
    Dim active_file As String
    Dim color_array As Byte()
    Dim LightCount As Integer
    Dim ShowCount As Integer
    Private Sub LightColors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Application.OpenForms().OfType(Of MainMenu).Any Then
            MainMenu.Close()
        End If
        DataGridView1.TopLeftHeaderCell.Value = "Number"
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            active_file = OpenFileDialog1.FileName
            If File.Exists(active_file) Then
                ColorSelectToolStripMenuItem.Visible = True
                ExportToCSVToolStripMenuItem.Visible = True
                OpenColors(active_file)
            End If
        End If
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        File.Copy(active_file, active_file & ".bak", True)
        Dim Temp_Array As Byte() = color_array
        For i As Integer = 0 To DataGridView1.RowCount - 1
            For j As Integer = 0 To DataGridView1.ColumnCount - 1
                Try
                    Temp_Array(&H30 + &H20 * LightCount + i * 4 + j * 4 * ShowCount + 2) = Convert.ToInt16(Strings.Left(DataGridView1(j, i).Value.ToString, 2), 16)
                    Temp_Array(&H30 + &H20 * LightCount + i * 4 + j * 4 * ShowCount + 1) = Convert.ToInt16(Strings.Mid(DataGridView1(j, i).Value.ToString, 3, 2), 16)
                    Temp_Array(&H30 + &H20 * LightCount + i * 4 + j * 4 * ShowCount + 0) = Convert.ToInt16(Strings.Right(DataGridView1(j, i).Value.ToString, 2), 16)
                Catch ex As Exception
                    MessageBox.Show(ex.Message & vbNewLine & i & vbNewLine & j)
                End Try
            Next
        Next
        File.WriteAllBytes(active_file, Temp_Array)
        MessageBox.Show("File Saved")
    End Sub
    Private Sub OpenColors(ByVal Source As String)
        Dim fileLength As Long
        Using reader As New BinaryReader(File.Open(Source, FileMode.Open, FileAccess.Read))
            fileLength = reader.BaseStream.Length
            color_array = reader.ReadBytes(fileLength)
        End Using
        'MessageBox.Show(fileLength)
        LightCount = BitConverter.ToInt32(color_array, &H8)
        ShowCount = BitConverter.ToInt32(color_array, &HC)
        DataGridView1.Columns.Clear()
        DataGridView1.Rows.Clear()

        For i As Integer = 0 To LightCount - 1
            DataGridView1.Columns.Add("Column" & i, Encoding.ASCII.GetString(color_array, &H30 + i * &H20, &H10))
        Next
        For i As Integer = 0 To ShowCount - 1
            DataGridView1.Rows.Add()
            For j As Integer = 0 To LightCount - 1
                DataGridView1(j, i).Value = Strings.Right(Hex(BitConverter.ToInt32(color_array, &H30 + &H20 * LightCount + i * 4 + j * 4 * ShowCount)).PadRight(8, "0"), 6)
                DataGridView1.Rows(i).Cells(j).Style.BackColor = ColorTranslator.FromHtml("#" & DataGridView1(j, i).Value)
                Dim FontColor As String = Hex(&HFF - color_array(&H30 + &H20 * LightCount + i * 4 + j * 4 * ShowCount + 2)).PadLeft(2, "0") &
                    Hex(&HFF - color_array(&H30 + &H20 * LightCount + i * 4 + j * 4 * ShowCount + 1)).PadLeft(2, "0") &
                    Hex(&HFF - color_array(&H30 + &H20 * LightCount + i * 4 + j * 4 * ShowCount)).PadLeft(2, "0")
                DataGridView1.Rows(i).Cells(j).Style.ForeColor = ColorTranslator.FromHtml("#" & FontColor)
            Next
            DataGridView1.Rows(i).HeaderCell.Value = i.ToString
        Next
        ' DataGridView1.Rows.Add()
        '  DataGridView1(0, index).Value = Hex(BitConverter.ToInt32(color_array, current_poition)) ' Dim NameRef As String = 
    End Sub

    Private Sub ColorSelectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorSelectToolStripMenuItem.Click
        ColorDialog1.Color = DataGridView1.SelectedCells(0).Style.BackColor

        If (ColorDialog1.ShowDialog() = DialogResult.OK) Then
            DataGridView1.SelectedCells(0).Style.BackColor = ColorDialog1.Color
            Dim hex_color As String = String.Format("{0:X2}{1:X2}{2:X2}", ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B)
            Dim text_color As String = String.Format("{0:X2}{1:X2}{2:X2}", &HFF - ColorDialog1.Color.B, &HFF - ColorDialog1.Color.G, &HFF - ColorDialog1.Color.R)
            DataGridView1.SelectedCells(0).Style.ForeColor = ColorTranslator.FromHtml("#" & text_color)
            DataGridView1.SelectedCells(0).Value = hex_color
        End If
    End Sub

    Private Sub ExportToCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToCSVToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim headers = (From header As DataGridViewColumn In DataGridView1.Columns.Cast(Of DataGridViewColumn)()
                           Select header.HeaderText).ToArray
            Dim rows As List(Of String) = New List(Of String)
            For Each temprow As DataGridViewRow In DataGridView1.Rows
                If Not temprow.IsNewRow Then
                    rows.Add(temprow.HeaderCell.Value.ToString & "," & String.Join(",", Array.ConvertAll(temprow.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))))
                End If
            Next
            Using sw As New IO.StreamWriter(SaveFileDialog1.FileName)
                sw.WriteLine("Number," & String.Join(",", headers))
                For Each r In rows
                    sw.Write(r)
                Next
            End Using
            MessageBox.Show("File Saved")
        End If
    End Sub
End Class