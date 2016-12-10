namespace LC_RK9.ResultViewer
{
    partial class Histogram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblLoHi = new System.Windows.Forms.Label();
            this.lblLoLo = new System.Windows.Forms.Label();
            this.lblHiHi = new System.Windows.Forms.Label();
            this.lblHiLo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.butAlterRange = new System.Windows.Forms.Button();
            this.cmbVariables = new System.Windows.Forms.ComboBox();
            this.sliderHi = new System.Windows.Forms.TrackBar();
            this.sliderLo = new System.Windows.Forms.TrackBar();
            this.chrtHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.sliderHi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderLo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoHi
            // 
            this.lblLoHi.AutoSize = true;
            this.lblLoHi.Location = new System.Drawing.Point(698, 450);
            this.lblLoHi.Name = "lblLoHi";
            this.lblLoHi.Size = new System.Drawing.Size(31, 15);
            this.lblLoHi.TabIndex = 19;
            this.lblLoHi.Text = "Max";
            // 
            // lblLoLo
            // 
            this.lblLoLo.AutoSize = true;
            this.lblLoLo.Location = new System.Drawing.Point(77, 449);
            this.lblLoLo.Name = "lblLoLo";
            this.lblLoLo.Size = new System.Drawing.Size(28, 15);
            this.lblLoLo.TabIndex = 18;
            this.lblLoLo.Text = "Min";
            // 
            // lblHiHi
            // 
            this.lblHiHi.AutoSize = true;
            this.lblHiHi.Location = new System.Drawing.Point(698, 377);
            this.lblHiHi.Name = "lblHiHi";
            this.lblHiHi.Size = new System.Drawing.Size(31, 15);
            this.lblHiHi.TabIndex = 17;
            this.lblHiHi.Text = "Max";
            // 
            // lblHiLo
            // 
            this.lblHiLo.AutoSize = true;
            this.lblHiLo.Location = new System.Drawing.Point(77, 376);
            this.lblHiLo.Name = "lblHiLo";
            this.lblHiLo.Size = new System.Drawing.Size(28, 15);
            this.lblHiLo.TabIndex = 16;
            this.lblHiLo.Text = "Min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Выберите параметр для гистограммы";
            // 
            // butAlterRange
            // 
            this.butAlterRange.Location = new System.Drawing.Point(584, 8);
            this.butAlterRange.Name = "butAlterRange";
            this.butAlterRange.Size = new System.Drawing.Size(165, 23);
            this.butAlterRange.TabIndex = 14;
            this.butAlterRange.Text = "Изменить диапазон";
            this.butAlterRange.UseVisualStyleBackColor = true;
            // 
            // cmbVariables
            // 
            this.cmbVariables.FormattingEnabled = true;
            this.cmbVariables.Location = new System.Drawing.Point(259, 8);
            this.cmbVariables.Name = "cmbVariables";
            this.cmbVariables.Size = new System.Drawing.Size(184, 23);
            this.cmbVariables.TabIndex = 13;
            // 
            // sliderHi
            // 
            this.sliderHi.Location = new System.Drawing.Point(77, 402);
            this.sliderHi.Maximum = 1000;
            this.sliderHi.Name = "sliderHi";
            this.sliderHi.Size = new System.Drawing.Size(645, 45);
            this.sliderHi.TabIndex = 12;
            this.sliderHi.TickFrequency = 100;
            // 
            // sliderLo
            // 
            this.sliderLo.Location = new System.Drawing.Point(77, 345);
            this.sliderLo.Maximum = 1000;
            this.sliderLo.Name = "sliderLo";
            this.sliderLo.Size = new System.Drawing.Size(645, 45);
            this.sliderLo.TabIndex = 11;
            this.sliderLo.TickFrequency = 100;
            // 
            // chrtHistogram
            // 
            chartArea3.Name = "ChartArea1";
            this.chrtHistogram.ChartAreas.Add(chartArea3);
            this.chrtHistogram.Location = new System.Drawing.Point(22, 38);
            this.chrtHistogram.Name = "chrtHistogram";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.Name = "Histogram";
            this.chrtHistogram.Series.Add(series3);
            this.chrtHistogram.Size = new System.Drawing.Size(727, 300);
            this.chrtHistogram.TabIndex = 10;
            this.chrtHistogram.Text = "chart1";
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 478);
            this.Controls.Add(this.lblLoHi);
            this.Controls.Add(this.lblLoLo);
            this.Controls.Add(this.lblHiHi);
            this.Controls.Add(this.lblHiLo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butAlterRange);
            this.Controls.Add(this.cmbVariables);
            this.Controls.Add(this.sliderHi);
            this.Controls.Add(this.sliderLo);
            this.Controls.Add(this.chrtHistogram);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Histogram";
            this.Text = "Hystogram";
            ((System.ComponentModel.ISupportInitialize)(this.sliderHi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sliderLo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtHistogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoHi;
        private System.Windows.Forms.Label lblLoLo;
        private System.Windows.Forms.Label lblHiHi;
        private System.Windows.Forms.Label lblHiLo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butAlterRange;
        private System.Windows.Forms.ComboBox cmbVariables;
        private System.Windows.Forms.TrackBar sliderHi;
        private System.Windows.Forms.TrackBar sliderLo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtHistogram;
    }
}