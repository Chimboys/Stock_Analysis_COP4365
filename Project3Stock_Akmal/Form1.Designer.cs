namespace Project3Stock_Akmal
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart_tickerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BindingSource_candlestickData = new System.Windows.Forms.BindingSource(this.components);
            this.OpenFileDialog_fileSelector = new System.Windows.Forms.OpenFileDialog();
            this.Label_Ticker = new System.Windows.Forms.Label();
            this.Button_openFile = new System.Windows.Forms.Button();
            this.DateTimePicker_startDateTime = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker_endDateTime = new System.Windows.Forms.DateTimePicker();
            this.Label_startDate = new System.Windows.Forms.Label();
            this.Label_endDate = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.Label_Timeframe = new System.Windows.Forms.Label();
            this.ComboBox_Patterns = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_tickerChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_candlestickData)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart_tickerChart
            // 
            this.Chart_tickerChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "AreaOHLC";
            chartArea2.AxisY.LabelStyle.Interval = 0D;
            chartArea2.Name = "AreaVolume";
            this.Chart_tickerChart.ChartAreas.Add(chartArea1);
            this.Chart_tickerChart.ChartAreas.Add(chartArea2);
            this.Chart_tickerChart.DataSource = this.BindingSource_candlestickData;
            this.Chart_tickerChart.Location = new System.Drawing.Point(12, 11);
            this.Chart_tickerChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Chart_tickerChart.Name = "Chart_tickerChart";
            series1.ChartArea = "AreaOHLC";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=LimeGreen, PointWidth=0.9";
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Name = "OHLC";
            series1.XValueMember = "Date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueMembers = "High, Low, Open, Close";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "AreaVolume";
            series2.CustomProperties = "PointWidth=0.9";
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.Name = "Volume";
            series2.XValueMember = "Date";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValueMembers = "Volume";
            series2.YValuesPerPoint = 4;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.Chart_tickerChart.Series.Add(series1);
            this.Chart_tickerChart.Series.Add(series2);
            this.Chart_tickerChart.Size = new System.Drawing.Size(1325, 625);
            this.Chart_tickerChart.TabIndex = 0;
            this.Chart_tickerChart.Text = "Chart";
            this.Chart_tickerChart.UseWaitCursor = true;
            // 
            // BindingSource_candlestickData
            // 
            this.BindingSource_candlestickData.DataSource = typeof(Project3Stock_Akmal.Code.CandleStick);
            // 
            // OpenFileDialog_fileSelector
            // 
            this.OpenFileDialog_fileSelector.FileName = "openFileDialog";
            this.OpenFileDialog_fileSelector.Filter = "All Stock files|*.csv|Daily Stocks|*-Day.csv|Weekly Stocks|*-Week.csv|Monthly Sto" +
    "cks|*-Month.csv";
            this.OpenFileDialog_fileSelector.Multiselect = true;
            this.OpenFileDialog_fileSelector.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // Label_Ticker
            // 
            this.Label_Ticker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_Ticker.AutoSize = true;
            this.Label_Ticker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Ticker.Location = new System.Drawing.Point(13, 678);
            this.Label_Ticker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Ticker.Name = "Label_Ticker";
            this.Label_Ticker.Size = new System.Drawing.Size(72, 25);
            this.Label_Ticker.TabIndex = 2;
            this.Label_Ticker.Text = "Ticker";
            this.Label_Ticker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Ticker.UseWaitCursor = true;
            // 
            // Button_openFile
            // 
            this.Button_openFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_openFile.Location = new System.Drawing.Point(12, 743);
            this.Button_openFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_openFile.Name = "Button_openFile";
            this.Button_openFile.Size = new System.Drawing.Size(115, 46);
            this.Button_openFile.TabIndex = 3;
            this.Button_openFile.Text = "Open File";
            this.Button_openFile.UseVisualStyleBackColor = true;
            this.Button_openFile.UseWaitCursor = true;
            this.Button_openFile.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // DateTimePicker_startDateTime
            // 
            this.DateTimePicker_startDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DateTimePicker_startDateTime.CustomFormat = "MM/dd/yyyy h:mm tt\t";
            this.DateTimePicker_startDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_startDateTime.Location = new System.Drawing.Point(160, 753);
            this.DateTimePicker_startDateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateTimePicker_startDateTime.Name = "DateTimePicker_startDateTime";
            this.DateTimePicker_startDateTime.Size = new System.Drawing.Size(192, 22);
            this.DateTimePicker_startDateTime.TabIndex = 5;
            this.DateTimePicker_startDateTime.UseWaitCursor = true;
            this.DateTimePicker_startDateTime.ValueChanged += new System.EventHandler(this.StartDateTimePicker_ValueChanged);
            // 
            // DateTimePicker_endDateTime
            // 
            this.DateTimePicker_endDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DateTimePicker_endDateTime.CustomFormat = "MM/dd/yyyy h:mm tt\t";
            this.DateTimePicker_endDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker_endDateTime.Location = new System.Drawing.Point(162, 809);
            this.DateTimePicker_endDateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DateTimePicker_endDateTime.Name = "DateTimePicker_endDateTime";
            this.DateTimePicker_endDateTime.Size = new System.Drawing.Size(192, 22);
            this.DateTimePicker_endDateTime.TabIndex = 6;
            this.DateTimePicker_endDateTime.UseWaitCursor = true;
            this.DateTimePicker_endDateTime.ValueChanged += new System.EventHandler(this.EndDateTimePicker_ValueChanged);
            // 
            // Label_startDate
            // 
            this.Label_startDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_startDate.AutoSize = true;
            this.Label_startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_startDate.Location = new System.Drawing.Point(158, 729);
            this.Label_startDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_startDate.Name = "Label_startDate";
            this.Label_startDate.Size = new System.Drawing.Size(91, 20);
            this.Label_startDate.TabIndex = 7;
            this.Label_startDate.Text = "Start Date:";
            this.Label_startDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_startDate.UseWaitCursor = true;
            // 
            // Label_endDate
            // 
            this.Label_endDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_endDate.AutoSize = true;
            this.Label_endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_endDate.Location = new System.Drawing.Point(158, 785);
            this.Label_endDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_endDate.Name = "Label_endDate";
            this.Label_endDate.Size = new System.Drawing.Size(84, 20);
            this.Label_endDate.TabIndex = 8;
            this.Label_endDate.Text = "End Date:";
            this.Label_endDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_endDate.UseWaitCursor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateButton.Location = new System.Drawing.Point(12, 797);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(116, 46);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.UseWaitCursor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Label_Timeframe
            // 
            this.Label_Timeframe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Label_Timeframe.AutoSize = true;
            this.Label_Timeframe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Timeframe.Location = new System.Drawing.Point(157, 678);
            this.Label_Timeframe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_Timeframe.Name = "Label_Timeframe";
            this.Label_Timeframe.Size = new System.Drawing.Size(114, 25);
            this.Label_Timeframe.TabIndex = 10;
            this.Label_Timeframe.Text = "Timeframe";
            this.Label_Timeframe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label_Timeframe.UseWaitCursor = true;
            // 
            // ComboBox_Patterns
            // 
            this.ComboBox_Patterns.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComboBox_Patterns.FormattingEnabled = true;
            this.ComboBox_Patterns.Location = new System.Drawing.Point(406, 682);
            this.ComboBox_Patterns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBox_Patterns.Name = "ComboBox_Patterns";
            this.ComboBox_Patterns.Size = new System.Drawing.Size(243, 24);
            this.ComboBox_Patterns.TabIndex = 11;
            this.ComboBox_Patterns.UseWaitCursor = true;
            this.ComboBox_Patterns.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Patterns_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 856);
            this.Controls.Add(this.ComboBox_Patterns);
            this.Controls.Add(this.Label_Timeframe);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.Label_endDate);
            this.Controls.Add(this.Label_startDate);
            this.Controls.Add(this.DateTimePicker_endDateTime);
            this.Controls.Add(this.DateTimePicker_startDateTime);
            this.Controls.Add(this.Button_openFile);
            this.Controls.Add(this.Label_Ticker);
            this.Controls.Add(this.Chart_tickerChart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project3Stock_Akmal";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart_tickerChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_candlestickData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart_tickerChart;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_fileSelector;
        private System.Windows.Forms.BindingSource BindingSource_candlestickData;
        private System.Windows.Forms.Label Label_Ticker;
        private System.Windows.Forms.Button Button_openFile;
        private System.Windows.Forms.DateTimePicker DateTimePicker_startDateTime;
        private System.Windows.Forms.DateTimePicker DateTimePicker_endDateTime;
        private System.Windows.Forms.Label Label_startDate;
        private System.Windows.Forms.Label Label_endDate;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label Label_Timeframe;
        private System.Windows.Forms.ComboBox ComboBox_Patterns;
    }
}

