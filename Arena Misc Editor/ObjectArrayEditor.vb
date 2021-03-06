﻿Imports System.IO    'Files
Imports System.Text ' Text Encoding
Public Class ObjectArrayEditor
    Dim active_file As String
    Dim Chair_Array As Byte()
    Dim ChairCount As Integer
    Private Sub ChairEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Application.OpenForms().OfType(Of MainMenu).Any Then
            MainMenu.Close()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            active_file = OpenFileDialog1.FileName
            If File.Exists(active_file) Then
                ExportToCSVToolStripMenuItem.Visible = True
                OpenChairs(active_file)
                AddRowToolStripMenuItem.Visible = True
            End If
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        DataGridView1.ClearSelection()
        File.Copy(active_file, active_file & ".bak", True)
        Dim Temp_Array As Byte() = Chair_Array
        Dim Counter As Integer = 0
        'For i As Integer = 0 To DataGridView1.RowCount - 1
        Try
            Do While Counter < DataGridView1.RowCount
                'Number
                Buffer.BlockCopy(BitConverter.GetBytes(CInt(DataGridView1(0, Counter).Value)), 0, Temp_Array, &H24 + Counter * 8, 4)
                'Enabled
                If DataGridView1(1, Counter).Value Then
                    Temp_Array(&H20 + Counter * 8) = 1
                Else
                    Temp_Array(&H20 + Counter * 8) = 0
                End If
                'Object Names
                Buffer.BlockCopy(Encoding.ASCII.GetBytes(DataGridView1(2, Counter).Value), 0, Temp_Array, &H20 + ChairCount * 8 + Counter * &H30, DataGridView1(2, Counter).Value.ToString.Length)
                'X Float
                Buffer.BlockCopy(BitConverter.GetBytes(CType(DataGridView1(3, Counter).Value, Single)),
                                     0, Temp_Array, &H30 + ChairCount * 8 + Counter * &H30, 4)
                'Y Float
                Buffer.BlockCopy(BitConverter.GetBytes(CType(DataGridView1(4, Counter).Value, Single)),
                                     0, Temp_Array, &H34 + ChairCount * 8 + Counter * &H30, 4)
                'Z Float
                Buffer.BlockCopy(BitConverter.GetBytes(CType(DataGridView1(5, Counter).Value, Single)),
                                     0, Temp_Array, &H38 + ChairCount * 8 + Counter * &H30, 4)
                'RX Float
                Buffer.BlockCopy(BitConverter.GetBytes(CType(DataGridView1(6, Counter).Value, Single)),
                                     0, Temp_Array, &H3C + ChairCount * 8 + Counter * &H30, 4)
                'RY Float
                Buffer.BlockCopy(BitConverter.GetBytes(CType(DataGridView1(7, Counter).Value, Single)),
                                     0, Temp_Array, &H40 + ChairCount * 8 + Counter * &H30, 4)
                'RZ Float
                Buffer.BlockCopy(BitConverter.GetBytes(CType(DataGridView1(8, Counter).Value, Single)),
                                     0, Temp_Array, &H44 + ChairCount * 8 + Counter * &H30, 4)
                'D1 Decimal
                Buffer.BlockCopy(BitConverter.GetBytes(CInt(DataGridView1(9, Counter).Value)),
                                     0, Temp_Array, &H48 + ChairCount * 8 + Counter * &H30, 4)
                'D2 Decimal
                Buffer.BlockCopy(BitConverter.GetBytes(CInt(DataGridView1(10, Counter).Value)),
                                     0, Temp_Array, &H4C + ChairCount * 8 + Counter * &H30, 4)
                'Temp_Array(&H30 + &H20 * ChairCount + i * 4) = Convert.ToInt16(Strings.Left(DataGridView1(0, i).Value.ToString, 2), 16)
                'Temp_Array(&H30 + &H20 * ChairCount + i * 4) = Convert.ToInt16(Strings.Mid(DataGridView1(1, i).Value.ToString, 3, 2), 16)
                'Temp_Array(&H30 + &H20 * ChairCount + i * 4) = Convert.ToInt16(Strings.Right(DataGridView1(2, i).Value.ToString, 2), 16)
                Counter += 1
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbNewLine & Counter)
        Finally
            File.Copy(active_file, active_file & ".bak", True)
            File.WriteAllBytes(active_file, Temp_Array)
            MessageBox.Show("File Saved")
        End Try
        'Next

    End Sub
    Private Sub OpenChairs(ByVal Source As String)
        Dim fileLength As Long
        Using reader As New BinaryReader(File.Open(Source, FileMode.Open, FileAccess.Read))
            fileLength = reader.BaseStream.Length
            Chair_Array = reader.ReadBytes(fileLength)
        End Using
        'MessageBox.Show(fileLength)
        ChairCount = BitConverter.ToInt32(Chair_Array, &HC)
        DataGridView1.Rows.Clear()
        For i As Integer = 0 To ChairCount - 1
            DataGridView1.Rows.Add(
            BitConverter.ToInt32(Chair_Array, &H24 + i * 8), 'Number
            BitConverter.ToBoolean(Chair_Array, &H20 + i * 8), 'Enabled
            Encoding.ASCII.GetString(Chair_Array, &H20 + ChairCount * 8 + i * &H30, &H10), 'Chair Name
            BitConverter.ToSingle(Chair_Array, &H30 + ChairCount * 8 + i * &H30), 'X Float
            BitConverter.ToSingle(Chair_Array, &H34 + ChairCount * 8 + i * &H30), 'Y Float
            BitConverter.ToSingle(Chair_Array, &H38 + ChairCount * 8 + i * &H30), 'Z Float
            BitConverter.ToSingle(Chair_Array, &H3C + ChairCount * 8 + i * &H30), 'RX Float
            BitConverter.ToSingle(Chair_Array, &H40 + ChairCount * 8 + i * &H30), 'RY Float
            BitConverter.ToSingle(Chair_Array, &H44 + ChairCount * 8 + i * &H30), 'RZ Float
            BitConverter.ToInt32(Chair_Array, &H48 + ChairCount * 8 + i * &H30), 'D1 Decimal
            BitConverter.ToInt32(Chair_Array, &H4C + ChairCount * 8 + i * &H30)) 'D2 Decimal 
        Next
    End Sub

    Private Sub ExportToCSVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToCSVToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Dim headers = (From header As DataGridViewColumn In DataGridView1.Columns.Cast(Of DataGridViewColumn)()
                           Select header.HeaderText).ToArray
            Dim rows As List(Of String) = New List(Of String)
            For Each temprow As DataGridViewRow In DataGridView1.Rows
                If Not temprow.IsNewRow Then
                    Dim Tempstring As String = ""
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

    Private Sub AddRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddRowToolStripMenuItem.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            Dim Temprow As DataGridViewRow = DataGridView1.Rows(DataGridView1.Rows.Count - 1).Clone
            Temprow.Cells(0).Value = DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Value + 1
            For i As Integer = 1 To Temprow.Cells.Count - 1
                Temprow.Cells(i).Value = DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(i).Value
            Next
            DataGridView1.Rows.Add(Temprow)
            MessageBox.Show("Added row to the end of the file.")
        Else
            Dim Temprow As DataGridViewRow = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Clone
            Temprow.Cells(0).Value = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(0).Value + 1
            For i As Integer = 1 To Temprow.Cells.Count - 1
                Temprow.Cells(i).Value = DataGridView1.Rows(DataGridView1.SelectedRows(0).Index).Cells(i).Value
            Next
            For i As Integer = DataGridView1.SelectedRows(0).Index + 1 To DataGridView1.Rows.Count - 1
                DataGridView1.Rows(i).Cells(0).Value += 1
            Next
            DataGridView1.Rows.Insert(DataGridView1.SelectedRows(0).Index + 1, Temprow)
            MessageBox.Show("Added row after active row.")
        End If
    End Sub
End Class