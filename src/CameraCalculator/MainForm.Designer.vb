<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TrackBar_focal_length = New System.Windows.Forms.TrackBar()
        Me.Label_focal_length = New System.Windows.Forms.Label()
        Me.Label_focal_length_value = New System.Windows.Forms.Label()
        Me.Label_radian = New System.Windows.Forms.Label()
        Me.Label_radian_value = New System.Windows.Forms.Label()
        Me.Label_angle = New System.Windows.Forms.Label()
        Me.Label_angle_value = New System.Windows.Forms.Label()
        Me.RadioButton_focal_length = New System.Windows.Forms.RadioButton()
        Me.RadioButton_distance = New System.Windows.Forms.RadioButton()
        Me.RadioButton_size = New System.Windows.Forms.RadioButton()
        Me.TextBox_size = New System.Windows.Forms.TextBox()
        Me.TextBox_distance = New System.Windows.Forms.TextBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.Button50 = New System.Windows.Forms.Button()
        Me.Button70 = New System.Windows.Forms.Button()
        Me.Button85 = New System.Windows.Forms.Button()
        Me.Button100 = New System.Windows.Forms.Button()
        Me.Button135 = New System.Windows.Forms.Button()
        Me.Button200 = New System.Windows.Forms.Button()
        Me.Button300 = New System.Windows.Forms.Button()
        Me.Button400 = New System.Windows.Forms.Button()
        Me.Button500 = New System.Windows.Forms.Button()
        Me.Button600 = New System.Windows.Forms.Button()
        Me.Button700 = New System.Windows.Forms.Button()
        Me.Button800 = New System.Windows.Forms.Button()
        CType(Me.TrackBar_focal_length, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar_focal_length
        '
        Me.TrackBar_focal_length.Location = New System.Drawing.Point(65, 12)
        Me.TrackBar_focal_length.Maximum = 1600
        Me.TrackBar_focal_length.Minimum = 1
        Me.TrackBar_focal_length.Name = "TrackBar_focal_length"
        Me.TrackBar_focal_length.Size = New System.Drawing.Size(601, 45)
        Me.TrackBar_focal_length.TabIndex = 0
        Me.TrackBar_focal_length.TickFrequency = 50
        Me.TrackBar_focal_length.Value = 10
        '
        'Label_focal_length
        '
        Me.Label_focal_length.AutoSize = True
        Me.Label_focal_length.Location = New System.Drawing.Point(672, 9)
        Me.Label_focal_length.Name = "Label_focal_length"
        Me.Label_focal_length.Size = New System.Drawing.Size(77, 12)
        Me.Label_focal_length.TabIndex = 1
        Me.Label_focal_length.Text = "等效焦距(mm)"
        '
        'Label_focal_length_value
        '
        Me.Label_focal_length_value.AutoSize = True
        Me.Label_focal_length_value.Location = New System.Drawing.Point(755, 9)
        Me.Label_focal_length_value.Name = "Label_focal_length_value"
        Me.Label_focal_length_value.Size = New System.Drawing.Size(11, 12)
        Me.Label_focal_length_value.TabIndex = 2
        Me.Label_focal_length_value.Text = "0"
        '
        'Label_radian
        '
        Me.Label_radian.AutoSize = True
        Me.Label_radian.Location = New System.Drawing.Point(672, 24)
        Me.Label_radian.Name = "Label_radian"
        Me.Label_radian.Size = New System.Drawing.Size(59, 12)
        Me.Label_radian.TabIndex = 3
        Me.Label_radian.Text = "弧度(rad)"
        '
        'Label_radian_value
        '
        Me.Label_radian_value.AutoSize = True
        Me.Label_radian_value.Location = New System.Drawing.Point(755, 24)
        Me.Label_radian_value.Name = "Label_radian_value"
        Me.Label_radian_value.Size = New System.Drawing.Size(11, 12)
        Me.Label_radian_value.TabIndex = 4
        Me.Label_radian_value.Text = "0"
        '
        'Label_angle
        '
        Me.Label_angle.AutoSize = True
        Me.Label_angle.Location = New System.Drawing.Point(672, 39)
        Me.Label_angle.Name = "Label_angle"
        Me.Label_angle.Size = New System.Drawing.Size(53, 12)
        Me.Label_angle.TabIndex = 5
        Me.Label_angle.Text = "角度(°)"
        '
        'Label_angle_value
        '
        Me.Label_angle_value.AutoSize = True
        Me.Label_angle_value.Location = New System.Drawing.Point(755, 39)
        Me.Label_angle_value.Name = "Label_angle_value"
        Me.Label_angle_value.Size = New System.Drawing.Size(11, 12)
        Me.Label_angle_value.TabIndex = 6
        Me.Label_angle_value.Text = "0"
        '
        'RadioButton_focal_length
        '
        Me.RadioButton_focal_length.AutoSize = True
        Me.RadioButton_focal_length.Location = New System.Drawing.Point(12, 12)
        Me.RadioButton_focal_length.Name = "RadioButton_focal_length"
        Me.RadioButton_focal_length.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton_focal_length.TabIndex = 8
        Me.RadioButton_focal_length.Text = "焦距"
        Me.RadioButton_focal_length.UseVisualStyleBackColor = True
        '
        'RadioButton_distance
        '
        Me.RadioButton_distance.AutoSize = True
        Me.RadioButton_distance.Checked = True
        Me.RadioButton_distance.Location = New System.Drawing.Point(12, 135)
        Me.RadioButton_distance.Name = "RadioButton_distance"
        Me.RadioButton_distance.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton_distance.TabIndex = 9
        Me.RadioButton_distance.TabStop = True
        Me.RadioButton_distance.Text = "距离"
        Me.RadioButton_distance.UseVisualStyleBackColor = True
        '
        'RadioButton_size
        '
        Me.RadioButton_size.AutoSize = True
        Me.RadioButton_size.Location = New System.Drawing.Point(12, 93)
        Me.RadioButton_size.Name = "RadioButton_size"
        Me.RadioButton_size.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton_size.TabIndex = 10
        Me.RadioButton_size.Text = "尺寸"
        Me.RadioButton_size.UseVisualStyleBackColor = True
        '
        'TextBox_size
        '
        Me.TextBox_size.Location = New System.Drawing.Point(65, 92)
        Me.TextBox_size.Name = "TextBox_size"
        Me.TextBox_size.Size = New System.Drawing.Size(601, 21)
        Me.TextBox_size.TabIndex = 15
        '
        'TextBox_distance
        '
        Me.TextBox_distance.Location = New System.Drawing.Point(65, 134)
        Me.TextBox_distance.Name = "TextBox_distance"
        Me.TextBox_distance.Size = New System.Drawing.Size(601, 21)
        Me.TextBox_distance.TabIndex = 16
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(65, 63)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(25, 23)
        Me.Button14.TabIndex = 17
        Me.Button14.Text = "14"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(96, 63)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(25, 23)
        Me.Button20.TabIndex = 18
        Me.Button20.Text = "20"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(127, 63)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(25, 23)
        Me.Button24.TabIndex = 19
        Me.Button24.Text = "24"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button28
        '
        Me.Button28.Location = New System.Drawing.Point(158, 63)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(25, 23)
        Me.Button28.TabIndex = 20
        Me.Button28.Text = "28"
        Me.Button28.UseVisualStyleBackColor = True
        '
        'Button35
        '
        Me.Button35.Location = New System.Drawing.Point(189, 63)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(25, 23)
        Me.Button35.TabIndex = 21
        Me.Button35.Text = "35"
        Me.Button35.UseVisualStyleBackColor = True
        '
        'Button50
        '
        Me.Button50.Location = New System.Drawing.Point(220, 63)
        Me.Button50.Name = "Button50"
        Me.Button50.Size = New System.Drawing.Size(25, 23)
        Me.Button50.TabIndex = 22
        Me.Button50.Text = "50"
        Me.Button50.UseVisualStyleBackColor = True
        '
        'Button70
        '
        Me.Button70.Location = New System.Drawing.Point(251, 63)
        Me.Button70.Name = "Button70"
        Me.Button70.Size = New System.Drawing.Size(25, 23)
        Me.Button70.TabIndex = 23
        Me.Button70.Text = "70"
        Me.Button70.UseVisualStyleBackColor = True
        '
        'Button85
        '
        Me.Button85.Location = New System.Drawing.Point(282, 63)
        Me.Button85.Name = "Button85"
        Me.Button85.Size = New System.Drawing.Size(25, 23)
        Me.Button85.TabIndex = 24
        Me.Button85.Text = "85"
        Me.Button85.UseVisualStyleBackColor = True
        '
        'Button100
        '
        Me.Button100.Location = New System.Drawing.Point(313, 63)
        Me.Button100.Name = "Button100"
        Me.Button100.Size = New System.Drawing.Size(31, 23)
        Me.Button100.TabIndex = 25
        Me.Button100.Text = "100"
        Me.Button100.UseVisualStyleBackColor = True
        '
        'Button135
        '
        Me.Button135.Location = New System.Drawing.Point(350, 63)
        Me.Button135.Name = "Button135"
        Me.Button135.Size = New System.Drawing.Size(31, 23)
        Me.Button135.TabIndex = 26
        Me.Button135.Text = "135"
        Me.Button135.UseVisualStyleBackColor = True
        '
        'Button200
        '
        Me.Button200.Location = New System.Drawing.Point(387, 63)
        Me.Button200.Name = "Button200"
        Me.Button200.Size = New System.Drawing.Size(31, 23)
        Me.Button200.TabIndex = 27
        Me.Button200.Text = "200"
        Me.Button200.UseVisualStyleBackColor = True
        '
        'Button300
        '
        Me.Button300.Location = New System.Drawing.Point(424, 63)
        Me.Button300.Name = "Button300"
        Me.Button300.Size = New System.Drawing.Size(31, 23)
        Me.Button300.TabIndex = 28
        Me.Button300.Text = "300"
        Me.Button300.UseVisualStyleBackColor = True
        '
        'Button400
        '
        Me.Button400.Location = New System.Drawing.Point(461, 63)
        Me.Button400.Name = "Button400"
        Me.Button400.Size = New System.Drawing.Size(31, 23)
        Me.Button400.TabIndex = 29
        Me.Button400.Text = "400"
        Me.Button400.UseVisualStyleBackColor = True
        '
        'Button500
        '
        Me.Button500.Location = New System.Drawing.Point(498, 63)
        Me.Button500.Name = "Button500"
        Me.Button500.Size = New System.Drawing.Size(31, 23)
        Me.Button500.TabIndex = 30
        Me.Button500.Text = "500"
        Me.Button500.UseVisualStyleBackColor = True
        '
        'Button600
        '
        Me.Button600.Location = New System.Drawing.Point(535, 63)
        Me.Button600.Name = "Button600"
        Me.Button600.Size = New System.Drawing.Size(31, 23)
        Me.Button600.TabIndex = 31
        Me.Button600.Text = "600"
        Me.Button600.UseVisualStyleBackColor = True
        '
        'Button700
        '
        Me.Button700.Location = New System.Drawing.Point(572, 63)
        Me.Button700.Name = "Button700"
        Me.Button700.Size = New System.Drawing.Size(31, 23)
        Me.Button700.TabIndex = 32
        Me.Button700.Text = "700"
        Me.Button700.UseVisualStyleBackColor = True
        '
        'Button800
        '
        Me.Button800.Location = New System.Drawing.Point(609, 63)
        Me.Button800.Name = "Button800"
        Me.Button800.Size = New System.Drawing.Size(31, 23)
        Me.Button800.TabIndex = 33
        Me.Button800.Text = "800"
        Me.Button800.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 177)
        Me.Controls.Add(Me.Button800)
        Me.Controls.Add(Me.Button700)
        Me.Controls.Add(Me.Button600)
        Me.Controls.Add(Me.Button500)
        Me.Controls.Add(Me.Button400)
        Me.Controls.Add(Me.Button300)
        Me.Controls.Add(Me.Button200)
        Me.Controls.Add(Me.Button135)
        Me.Controls.Add(Me.Button100)
        Me.Controls.Add(Me.Button85)
        Me.Controls.Add(Me.Button70)
        Me.Controls.Add(Me.Button50)
        Me.Controls.Add(Me.Button35)
        Me.Controls.Add(Me.Button28)
        Me.Controls.Add(Me.Button24)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.TextBox_distance)
        Me.Controls.Add(Me.TextBox_size)
        Me.Controls.Add(Me.RadioButton_size)
        Me.Controls.Add(Me.RadioButton_distance)
        Me.Controls.Add(Me.RadioButton_focal_length)
        Me.Controls.Add(Me.Label_angle_value)
        Me.Controls.Add(Me.Label_angle)
        Me.Controls.Add(Me.Label_radian_value)
        Me.Controls.Add(Me.Label_radian)
        Me.Controls.Add(Me.Label_focal_length_value)
        Me.Controls.Add(Me.Label_focal_length)
        Me.Controls.Add(Me.TrackBar_focal_length)
        Me.Name = "MainForm"
        Me.Text = "相机计算器"
        CType(Me.TrackBar_focal_length, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrackBar_focal_length As TrackBar
    Friend WithEvents Label_focal_length As Label
    Friend WithEvents Label_focal_length_value As Label
    Friend WithEvents Label_radian As Label
    Friend WithEvents Label_radian_value As Label
    Friend WithEvents Label_angle As Label
    Friend WithEvents Label_angle_value As Label
    Friend WithEvents RadioButton_focal_length As RadioButton
    Friend WithEvents RadioButton_distance As RadioButton
    Friend WithEvents RadioButton_size As RadioButton
    Friend WithEvents TextBox_size As TextBox
    Friend WithEvents TextBox_distance As TextBox
    Friend WithEvents Button14 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Button35 As Button
    Friend WithEvents Button50 As Button
    Friend WithEvents Button70 As Button
    Friend WithEvents Button85 As Button
    Friend WithEvents Button100 As Button
    Friend WithEvents Button135 As Button
    Friend WithEvents Button200 As Button
    Friend WithEvents Button300 As Button
    Friend WithEvents Button400 As Button
    Friend WithEvents Button500 As Button
    Friend WithEvents Button600 As Button
    Friend WithEvents Button700 As Button
    Friend WithEvents Button800 As Button
End Class
