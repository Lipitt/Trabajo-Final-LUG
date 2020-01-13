namespace TP_Final_Lipshitz
{
    partial class frmReportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvReportes = new System.Windows.Forms.DataGridView();
            this.btnMayorMonto = new System.Windows.Forms.Button();
            this.btnMenorMonto = new System.Windows.Forms.Button();
            this.btnRecaudado = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReportes
            // 
            this.dgvReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportes.Location = new System.Drawing.Point(12, 12);
            this.dgvReportes.Name = "dgvReportes";
            this.dgvReportes.Size = new System.Drawing.Size(576, 114);
            this.dgvReportes.TabIndex = 0;
            // 
            // btnMayorMonto
            // 
            this.btnMayorMonto.Location = new System.Drawing.Point(38, 142);
            this.btnMayorMonto.Name = "btnMayorMonto";
            this.btnMayorMonto.Size = new System.Drawing.Size(163, 23);
            this.btnMayorMonto.TabIndex = 1;
            this.btnMayorMonto.Text = "Mayor monto";
            this.btnMayorMonto.UseVisualStyleBackColor = true;
            this.btnMayorMonto.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMenorMonto
            // 
            this.btnMenorMonto.Location = new System.Drawing.Point(207, 142);
            this.btnMenorMonto.Name = "btnMenorMonto";
            this.btnMenorMonto.Size = new System.Drawing.Size(162, 23);
            this.btnMenorMonto.TabIndex = 2;
            this.btnMenorMonto.Text = "Menor monto";
            this.btnMenorMonto.UseVisualStyleBackColor = true;
            this.btnMenorMonto.Click += new System.EventHandler(this.btnMenorMonto_Click);
            // 
            // btnRecaudado
            // 
            this.btnRecaudado.Location = new System.Drawing.Point(375, 142);
            this.btnRecaudado.Name = "btnRecaudado";
            this.btnRecaudado.Size = new System.Drawing.Size(184, 23);
            this.btnRecaudado.TabIndex = 3;
            this.btnRecaudado.Text = "Total recaudado por marca";
            this.btnRecaudado.UseVisualStyleBackColor = true;
            this.btnRecaudado.Click += new System.EventHandler(this.btnRecaudado_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(27, 191);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(572, 321);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 592);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnRecaudado);
            this.Controls.Add(this.btnMenorMonto);
            this.Controls.Add(this.btnMayorMonto);
            this.Controls.Add(this.dgvReportes);
            this.Name = "frmReportes";
            this.Text = "Reportes";
            //this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReportes;
        private System.Windows.Forms.Button btnMayorMonto;
        private System.Windows.Forms.Button btnMenorMonto;
        private System.Windows.Forms.Button btnRecaudado;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}