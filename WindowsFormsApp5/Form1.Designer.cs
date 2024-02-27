namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TimeSteps = new System.Windows.Forms.Label();
            this.BtStart = new System.Windows.Forms.Button();
            this.EdSpeed = new System.Windows.Forms.NumericUpDown();
            this.EdAngle = new System.Windows.Forms.NumericUpDown();
            this.EdHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textDistance = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textEndSpeed = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdHeight)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textEndSpeed);
            this.panel1.Controls.Add(this.textHeight);
            this.panel1.Controls.Add(this.textDistance);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.TimeSteps);
            this.panel1.Controls.Add(this.BtStart);
            this.panel1.Controls.Add(this.EdSpeed);
            this.panel1.Controls.Add(this.EdAngle);
            this.panel1.Controls.Add(this.EdHeight);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 147);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(731, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "EndSpeed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(722, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "MaxHeight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(731, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Distance";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(490, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "0.01";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TimeSteps
            // 
            this.TimeSteps.AutoSize = true;
            this.TimeSteps.Location = new System.Drawing.Point(395, 38);
            this.TimeSteps.Name = "TimeSteps";
            this.TimeSteps.Size = new System.Drawing.Size(89, 18);
            this.TimeSteps.TabIndex = 7;
            this.TimeSteps.Text = "TimeSteps";
            // 
            // BtStart
            // 
            this.BtStart.Location = new System.Drawing.Point(453, 78);
            this.BtStart.Name = "BtStart";
            this.BtStart.Size = new System.Drawing.Size(157, 52);
            this.BtStart.TabIndex = 6;
            this.BtStart.Text = "Start";
            this.BtStart.UseVisualStyleBackColor = true;
            this.BtStart.Click += new System.EventHandler(this.BtStart_Click);
            // 
            // EdSpeed
            // 
            this.EdSpeed.Location = new System.Drawing.Point(247, 112);
            this.EdSpeed.Name = "EdSpeed";
            this.EdSpeed.Size = new System.Drawing.Size(120, 28);
            this.EdSpeed.TabIndex = 5;
            this.EdSpeed.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // EdAngle
            // 
            this.EdAngle.Location = new System.Drawing.Point(247, 67);
            this.EdAngle.Name = "EdAngle";
            this.EdAngle.Size = new System.Drawing.Size(120, 28);
            this.EdAngle.TabIndex = 4;
            this.EdAngle.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // EdHeight
            // 
            this.EdHeight.Location = new System.Drawing.Point(247, 28);
            this.EdHeight.Name = "EdHeight";
            this.EdHeight.Size = new System.Drawing.Size(120, 28);
            this.EdHeight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Location = new System.Drawing.Point(-9, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 426);
            this.panel2.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea2.AxisX.MajorTickMark.Interval = 0D;
            chartArea2.AxisX.Maximum = 25D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Maximum = 6D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.BorderColor = System.Drawing.Color.Red;
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series3";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series4";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(1044, 426);
            this.chart1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textDistance
            // 
            this.textDistance.Location = new System.Drawing.Point(830, 32);
            this.textDistance.Name = "textDistance";
            this.textDistance.Size = new System.Drawing.Size(100, 28);
            this.textDistance.TabIndex = 12;
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(830, 69);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(100, 28);
            this.textHeight.TabIndex = 13;
            // 
            // textEndSpeed
            // 
            this.textEndSpeed.Location = new System.Drawing.Point(830, 111);
            this.textEndSpeed.Name = "textEndSpeed";
            this.textEndSpeed.Size = new System.Drawing.Size(100, 28);
            this.textEndSpeed.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 569);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EdHeight)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtStart;
        private System.Windows.Forms.NumericUpDown EdSpeed;
        private System.Windows.Forms.NumericUpDown EdAngle;
        private System.Windows.Forms.NumericUpDown EdHeight;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label TimeSteps;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEndSpeed;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textDistance;
    }
}

