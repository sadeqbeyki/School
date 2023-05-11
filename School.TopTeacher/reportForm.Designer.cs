namespace School.TopTeacher
{
    partial class reportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            flexChart = new C1.Win.Chart.FlexChart();
            selectChart = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)flexChart).BeginInit();
            SuspendLayout();
            // 
            // flexChart
            // 
            flexChart.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            flexChart.AnimationLoad.Duration = 400;
            flexChart.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            flexChart.AnimationLoad.Type = C1.Chart.AnimationType.All;
            flexChart.AnimationSettings = C1.Chart.AnimationSettings.None;
            flexChart.AnimationUpdate.Duration = 400;
            flexChart.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            flexChart.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            flexChart.AxisX.AxisLine = true;
            flexChart.AxisX.Chart = flexChart;
            flexChart.AxisX.DataSource = null;
            flexChart.AxisX.Formatter = null;
            flexChart.AxisX.GroupProvider = null;
            flexChart.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart.AxisX.GroupStyle.VerticalText = false;
            flexChart.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart.AxisX.GroupVisibilityLevel = 0;
            flexChart.AxisX.MajorGridStyle.VerticalText = false;
            flexChart.AxisX.MinorGridStyle.VerticalText = false;
            flexChart.AxisX.PlotAreaName = null;
            flexChart.AxisX.Position = C1.Chart.Position.Bottom;
            flexChart.AxisX.Style.VerticalText = false;
            flexChart.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart.AxisX.TitleStyle.VerticalText = false;
            flexChart.AxisY.AxisLine = false;
            flexChart.AxisY.Chart = flexChart;
            flexChart.AxisY.DataSource = null;
            flexChart.AxisY.Formatter = null;
            flexChart.AxisY.GroupProvider = null;
            flexChart.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart.AxisY.GroupStyle.VerticalText = false;
            flexChart.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart.AxisY.GroupVisibilityLevel = 0;
            flexChart.AxisY.MajorGrid = true;
            flexChart.AxisY.MajorGridStyle.VerticalText = false;
            flexChart.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            flexChart.AxisY.MinorGridStyle.VerticalText = false;
            flexChart.AxisY.PlotAreaName = null;
            flexChart.AxisY.Position = C1.Chart.Position.Left;
            flexChart.AxisY.Style.VerticalText = false;
            flexChart.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart.AxisY.TitleStyle.VerticalText = false;
            flexChart.DataLabel.Angle = 0;
            flexChart.DataLabel.Border = false;
            flexChart.DataLabel.BorderStyle.VerticalText = false;
            flexChart.DataLabel.ConnectingLine = false;
            flexChart.DataLabel.Content = null;
            flexChart.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            flexChart.DataLabel.MaxAutoLabels = 100;
            flexChart.DataLabel.MaxLines = 0;
            flexChart.DataLabel.MaxWidth = 0;
            flexChart.DataLabel.Offset = 0;
            flexChart.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            flexChart.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            flexChart.DataLabel.Position = C1.Chart.LabelPosition.None;
            flexChart.DataLabel.Style.VerticalText = false;
            flexChart.Dock = DockStyle.Fill;
            flexChart.Legend.ItemMaxWidth = 0;
            flexChart.Legend.Orientation = C1.Chart.Orientation.Auto;
            flexChart.Legend.Position = C1.Chart.Position.Right;
            flexChart.Legend.Reversed = false;
            flexChart.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            flexChart.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            flexChart.Legend.Title = null;
            flexChart.Location = new Point(0, 0);
            flexChart.Margin = new Padding(10);
            flexChart.Name = "flexChart";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            flexChart.Options.ClusterSize = elementSize1;
            flexChart.PlotMargin = new Padding(0);
            flexChart.PlotStyle.VerticalText = false;
            flexChart.SelectedSeries = null;
            flexChart.SelectionStyle.StrokeColor = Color.Red;
            flexChart.SelectionStyle.VerticalText = false;
            series1.DataLabel = null;
            series1.Name = "Series 1";
            series1.StackingGroup = -1;
            series1.Style.StrokeWidth = 2F;
            series1.Style.VerticalText = false;
            series1.SymbolStyle.VerticalText = false;
            series1.Tooltip = null;
            flexChart.Series.Add(series1);
            flexChart.Size = new Size(778, 444);
            flexChart.TabIndex = 0;
            flexChart.Text = "Top Report";
            // 
            // 
            // 
            flexChart.ToolTip.Content = "";
            // 
            // selectChart
            // 
            selectChart.FormattingEnabled = true;
            selectChart.Location = new Point(584, 12);
            selectChart.Name = "selectChart";
            selectChart.Size = new Size(182, 33);
            selectChart.TabIndex = 1;
            selectChart.SelectedIndexChanged += selectChart_SelectedIndexChanged;
            // 
            // reportForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 444);
            Controls.Add(selectChart);
            Controls.Add(flexChart);
            Name = "reportForm";
            Text = "reportForm";
            Load += reportForm_Load;
            ((System.ComponentModel.ISupportInitialize)flexChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.Chart.FlexChart flexChart;
        private ComboBox selectChart;
    }
}