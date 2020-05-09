Public Class vLimit_Add
    Public oString As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fs As New OpenFileDialog
        fs.Filter = "PE文件(*.exe,*.dll)|*.exe;*.dll"
        If fs.ShowDialog = DialogResult.OK Then
            If ComboBox1.SelectedIndex = 0 Then
                TextBox1.Text = fs.FileName
            Else
                TextBox1.Text = fs.SafeFileName
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fs As New OpenFileDialog
        fs.Filter = "PE文件(*.exe)|*.exe"
        If fs.ShowDialog = DialogResult.OK Then
            TextBox2.Text = fs.SafeFileName
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        oString = ""
        Select Case ComboBox1.SelectedIndex
            Case 0
                If Not IO.File.Exists(TextBox1.Text) Then
                    MsgBox("拦截目标不存在")
                    Exit Sub
                End If
                oString = "h|"
            Case 1
                oString = "H|"
            Case Else
                MsgBox("请选择拦截模式")
                Exit Sub
        End Select
        oString += TextBox1.Text + "|" + TextBox2.Text
        Me.Close()
    End Sub
End Class