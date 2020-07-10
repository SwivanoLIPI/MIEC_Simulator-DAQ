<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim StripLine3 As System.Windows.Forms.DataVisualization.Charting.StripLine = New System.Windows.Forms.DataVisualization.Charting.StripLine()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series21 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series22 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series23 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series24 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series25 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series26 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series27 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series28 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series29 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series30 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button38 = New System.Windows.Forms.Button()
        Me.Button44 = New System.Windows.Forms.Button()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.Button37 = New System.Windows.Forms.Button()
        Me.Button62 = New System.Windows.Forms.Button()
        Me.Button61 = New System.Windows.Forms.Button()
        Me.Button59 = New System.Windows.Forms.Button()
        Me.Button60 = New System.Windows.Forms.Button()
        Me.Button63 = New System.Windows.Forms.Button()
        Me.Button64 = New System.Windows.Forms.Button()
        Me.Button45 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.Anchor = System.Windows.Forms.AnchorStyles.None
        ChartArea3.Area3DStyle.Enable3D = True
        ChartArea3.Area3DStyle.IsClustered = True
        ChartArea3.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea3.Area3DStyle.PointDepth = 40
        ChartArea3.Area3DStyle.PointGapDepth = 1
        ChartArea3.Area3DStyle.WallWidth = 10
        ChartArea3.AxisX.ScaleBreakStyle.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea3.AxisX2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle
        ChartArea3.AxisX2.InterlacedColor = System.Drawing.Color.Red
        ChartArea3.AxisX2.IsInterlaced = True
        ChartArea3.AxisX2.LineColor = System.Drawing.Color.Blue
        ChartArea3.AxisX2.StripLines.Add(StripLine3)
        ChartArea3.AxisY2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines
        ChartArea3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        ChartArea3.Name = "ChartArea1"
        ChartArea3.ShadowColor = System.Drawing.Color.Silver
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(21, 11)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(2)
        Me.Chart1.Name = "Chart1"
        Series21.ChartArea = "ChartArea1"
        Series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series21.Legend = "Legend1"
        Series21.Name = "Series1"
        Series22.ChartArea = "ChartArea1"
        Series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series22.Legend = "Legend1"
        Series22.Name = "Series2"
        Series23.ChartArea = "ChartArea1"
        Series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series23.Legend = "Legend1"
        Series23.Name = "Series3"
        Series24.ChartArea = "ChartArea1"
        Series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series24.Legend = "Legend1"
        Series24.Name = "Series4"
        Series25.ChartArea = "ChartArea1"
        Series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series25.Legend = "Legend1"
        Series25.Name = "Series5"
        Series26.ChartArea = "ChartArea1"
        Series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series26.Legend = "Legend1"
        Series26.Name = "Series6"
        Series27.ChartArea = "ChartArea1"
        Series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series27.Legend = "Legend1"
        Series27.Name = "Series7"
        Series28.ChartArea = "ChartArea1"
        Series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series28.Legend = "Legend1"
        Series28.Name = "Series8"
        Series29.ChartArea = "ChartArea1"
        Series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series29.Legend = "Legend1"
        Series29.Name = "Series9"
        Series30.ChartArea = "ChartArea1"
        Series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series30.Legend = "Legend1"
        Series30.Name = "Series10"
        Me.Chart1.Series.Add(Series21)
        Me.Chart1.Series.Add(Series22)
        Me.Chart1.Series.Add(Series23)
        Me.Chart1.Series.Add(Series24)
        Me.Chart1.Series.Add(Series25)
        Me.Chart1.Series.Add(Series26)
        Me.Chart1.Series.Add(Series27)
        Me.Chart1.Series.Add(Series28)
        Me.Chart1.Series.Add(Series29)
        Me.Chart1.Series.Add(Series30)
        Me.Chart1.Size = New System.Drawing.Size(1267, 536)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.AutoSize = True
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(986, 552)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 26)
        Me.Button4.TabIndex = 475
        Me.Button4.Text = "Manage Label"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button31
        '
        Me.Button31.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button31.AutoSize = True
        Me.Button31.Location = New System.Drawing.Point(896, 552)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(90, 26)
        Me.Button31.TabIndex = 474
        Me.Button31.Text = "Save Graphic"
        Me.Button31.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button16.AutoSize = True
        Me.Button16.Location = New System.Drawing.Point(750, 552)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(73, 26)
        Me.Button16.TabIndex = 473
        Me.Button16.Text = "Min-Up"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button18.AutoSize = True
        Me.Button18.Location = New System.Drawing.Point(823, 552)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(73, 26)
        Me.Button18.TabIndex = 472
        Me.Button18.Text = "Min-Down"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button12.AutoSize = True
        Me.Button12.Location = New System.Drawing.Point(677, 552)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(73, 26)
        Me.Button12.TabIndex = 470
        Me.Button12.Text = "Max-Down"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button15.AutoSize = True
        Me.Button15.Location = New System.Drawing.Point(604, 552)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(73, 26)
        Me.Button15.TabIndex = 471
        Me.Button15.Text = "Max-Up"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button38
        '
        Me.Button38.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button38.AutoSize = True
        Me.Button38.Location = New System.Drawing.Point(531, 552)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(73, 26)
        Me.Button38.TabIndex = 469
        Me.Button38.Text = "Min-Right"
        Me.Button38.UseVisualStyleBackColor = True
        '
        'Button44
        '
        Me.Button44.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button44.AutoSize = True
        Me.Button44.Location = New System.Drawing.Point(458, 552)
        Me.Button44.Name = "Button44"
        Me.Button44.Size = New System.Drawing.Size(73, 26)
        Me.Button44.TabIndex = 468
        Me.Button44.Text = "Min-Left"
        Me.Button44.UseVisualStyleBackColor = True
        '
        'Button34
        '
        Me.Button34.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button34.AutoSize = True
        Me.Button34.Location = New System.Drawing.Point(385, 552)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(73, 26)
        Me.Button34.TabIndex = 467
        Me.Button34.Text = "Max-Right"
        Me.Button34.UseVisualStyleBackColor = True
        '
        'Button37
        '
        Me.Button37.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button37.AutoSize = True
        Me.Button37.Location = New System.Drawing.Point(312, 552)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(73, 26)
        Me.Button37.TabIndex = 466
        Me.Button37.Text = "Max-Left"
        Me.Button37.UseVisualStyleBackColor = True
        '
        'Button62
        '
        Me.Button62.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button62.AutoSize = True
        Me.Button62.Location = New System.Drawing.Point(276, 552)
        Me.Button62.Name = "Button62"
        Me.Button62.Size = New System.Drawing.Size(36, 26)
        Me.Button62.TabIndex = 465
        Me.Button62.Text = "2D"
        Me.Button62.UseVisualStyleBackColor = True
        '
        'Button61
        '
        Me.Button61.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button61.AutoSize = True
        Me.Button61.Location = New System.Drawing.Point(240, 552)
        Me.Button61.Name = "Button61"
        Me.Button61.Size = New System.Drawing.Size(36, 26)
        Me.Button61.TabIndex = 464
        Me.Button61.Text = "3D"
        Me.Button61.UseVisualStyleBackColor = True
        '
        'Button59
        '
        Me.Button59.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button59.AutoSize = True
        Me.Button59.Location = New System.Drawing.Point(169, 552)
        Me.Button59.Name = "Button59"
        Me.Button59.Size = New System.Drawing.Size(71, 26)
        Me.Button59.TabIndex = 463
        Me.Button59.Text = "Anti-Clock"
        Me.Button59.UseVisualStyleBackColor = True
        '
        'Button60
        '
        Me.Button60.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button60.AutoSize = True
        Me.Button60.Location = New System.Drawing.Point(97, 552)
        Me.Button60.Name = "Button60"
        Me.Button60.Size = New System.Drawing.Size(71, 26)
        Me.Button60.TabIndex = 462
        Me.Button60.Text = "Clockwise"
        Me.Button60.UseVisualStyleBackColor = True
        '
        'Button63
        '
        Me.Button63.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button63.AutoSize = True
        Me.Button63.Location = New System.Drawing.Point(60, 552)
        Me.Button63.Name = "Button63"
        Me.Button63.Size = New System.Drawing.Size(37, 26)
        Me.Button63.TabIndex = 461
        Me.Button63.Text = "<<"
        Me.Button63.UseVisualStyleBackColor = True
        '
        'Button64
        '
        Me.Button64.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button64.AutoSize = True
        Me.Button64.Location = New System.Drawing.Point(21, 552)
        Me.Button64.Name = "Button64"
        Me.Button64.Size = New System.Drawing.Size(39, 26)
        Me.Button64.TabIndex = 460
        Me.Button64.Text = ">>"
        Me.Button64.UseVisualStyleBackColor = True
        '
        'Button45
        '
        Me.Button45.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button45.AutoSize = True
        Me.Button45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button45.Location = New System.Drawing.Point(1086, 552)
        Me.Button45.Name = "Button45"
        Me.Button45.Size = New System.Drawing.Size(103, 26)
        Me.Button45.TabIndex = 476
        Me.Button45.Text = "Manage Graphic"
        Me.Button45.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(1189, 552)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 26)
        Me.Button1.TabIndex = 477
        Me.Button1.Text = "Hide Label"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(1299, 602)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button45)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button31)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button18)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button38)
        Me.Controls.Add(Me.Button44)
        Me.Controls.Add(Me.Button34)
        Me.Controls.Add(Me.Button37)
        Me.Controls.Add(Me.Button62)
        Me.Controls.Add(Me.Button61)
        Me.Controls.Add(Me.Button59)
        Me.Controls.Add(Me.Button60)
        Me.Controls.Add(Me.Button63)
        Me.Controls.Add(Me.Button64)
        Me.Controls.Add(Me.Chart1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form8"
        Me.Text = "Form8"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button38 As System.Windows.Forms.Button
    Friend WithEvents Button44 As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents Button37 As System.Windows.Forms.Button
    Friend WithEvents Button62 As System.Windows.Forms.Button
    Friend WithEvents Button61 As System.Windows.Forms.Button
    Friend WithEvents Button59 As System.Windows.Forms.Button
    Friend WithEvents Button60 As System.Windows.Forms.Button
    Friend WithEvents Button63 As System.Windows.Forms.Button
    Friend WithEvents Button64 As System.Windows.Forms.Button
    Friend WithEvents Button45 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
