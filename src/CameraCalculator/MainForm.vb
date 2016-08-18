Public Class MainForm
    '135 DSLR
    Const Width135 As Decimal = 36
    Const Height135 As Decimal = 24
    Dim Diagonal135 As Decimal = Math.Sqrt(Math.Pow(Width135, 2) + Math.Pow(Height135, 2))

    Dim Focal_Length As Integer = 0
    Dim Radian As Decimal = 0
    Dim Angle As Decimal = 0
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrackBar_focal_length.Value = 50
        TextBox_size.Text = 1.75
    End Sub
    Private Sub TrackBar_focal_length_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar_focal_length.ValueChanged
        Focal_Length = TrackBar_focal_length.Value
        Radian = Math.Atan((Diagonal135 / 2) / TrackBar_focal_length.Value) * 2
        Angle = 180 / (Math.PI / Radian)

        Label_focal_length_value.Text = Focal_Length.ToString
        Label_radian_value.Text = Radian.ToString
        Label_angle_value.Text = Angle.ToString
        Cal()
    End Sub
    Private Sub TextBox_size_TextChanged(sender As Object, e As EventArgs) Handles TextBox_size.TextChanged
        Cal()
    End Sub

    Private Sub TextBox_distance_TextChanged(sender As Object, e As EventArgs) Handles TextBox_distance.TextChanged
        Cal()
    End Sub
    Private Sub Cal()
        Select Case True
            Case RadioButton_distance.Checked
                If IsNumeric(TextBox_size.Text) Then
                    TextBox_distance.Text = CDec(TextBox_size.Text) * Focal_Length / Diagonal135
                End If
            Case RadioButton_focal_length.Checked
                If IsNumeric(TextBox_size.Text) And IsNumeric(TextBox_distance.Text) Then
                    TrackBar_focal_length.Value = CDec(TextBox_distance.Text) * Diagonal135 / CDec(TextBox_size.Text)
                End If
            Case RadioButton_size.Checked
                If IsNumeric(TextBox_distance.Text) Then
                    TextBox_size.Text = CDec(TextBox_distance.Text) * Diagonal135 / Focal_Length
                End If
        End Select

    End Sub
    Private Sub setFocalLength(ByVal myButton As Button)
        TrackBar_focal_length.Value = CInt(myButton.Text)
    End Sub

    Private Sub Button_mm_Click(sender As Object, e As EventArgs) Handles Button14.Click, Button20.Click, Button24.Click, Button28.Click, Button35.Click, Button50.Click, Button70.Click, Button85.Click, Button100.Click, Button135.Click, Button200.Click, Button300.Click, Button400.Click, Button500.Click, Button600.Click, Button700.Click, Button800.Click
        setFocalLength(sender)
    End Sub
End Class
