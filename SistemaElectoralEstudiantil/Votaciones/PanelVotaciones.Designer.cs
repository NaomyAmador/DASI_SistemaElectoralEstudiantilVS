namespace SistemaElectoralEstudiantil.Votaciones
{
    partial class frm_PanelVotaciones
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chart_Barras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_Pastel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_PorciNulos = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_VotosNulos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_TotalPadron = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_PorEmitido = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_VotosEmitidos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ActualizarDatos = new System.Windows.Forms.Button();
            this.tm_Actualizar = new System.Windows.Forms.Timer(this.components);
            this.lbl_TiempoRes = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Barras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Pastel)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(261, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 34);
            this.label11.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1306, 706);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.chart_Barras, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.chart_Pastel, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 243);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1300, 323);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // chart_Barras
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart_Barras.ChartAreas.Add(chartArea1);
            this.chart_Barras.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart_Barras.Legends.Add(legend1);
            this.chart_Barras.Location = new System.Drawing.Point(653, 3);
            this.chart_Barras.Name = "chart_Barras";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_Barras.Series.Add(series1);
            this.chart_Barras.Size = new System.Drawing.Size(644, 317);
            this.chart_Barras.TabIndex = 1;
            this.chart_Barras.Text = "chart2";
            title1.Name = "Title1";
            title1.Text = "Votos Válidos por Plancha";
            this.chart_Barras.Titles.Add(title1);
            // 
            // chart_Pastel
            // 
            chartArea2.Name = "ChartArea1";
            this.chart_Pastel.ChartAreas.Add(chartArea2);
            this.chart_Pastel.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart_Pastel.Legends.Add(legend2);
            this.chart_Pastel.Location = new System.Drawing.Point(3, 3);
            this.chart_Pastel.Name = "chart_Pastel";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.CustomProperties = "PieLabelStyle=Outside";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_Pastel.Series.Add(series2);
            this.chart_Pastel.Size = new System.Drawing.Size(644, 317);
            this.chart_Pastel.TabIndex = 0;
            this.chart_Pastel.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "% Votos por Plancha (Nulos Excluidos)";
            this.chart_Pastel.Titles.Add(title2);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1300, 154);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.lbl_PorciNulos);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.lbl_VotosNulos);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(876, 10);
            this.panel3.Margin = new System.Windows.Forms.Padding(10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 134);
            this.panel3.TabIndex = 2;
            // 
            // lbl_PorciNulos
            // 
            this.lbl_PorciNulos.AutoSize = true;
            this.lbl_PorciNulos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PorciNulos.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PorciNulos.Location = new System.Drawing.Point(229, 92);
            this.lbl_PorciNulos.Name = "lbl_PorciNulos";
            this.lbl_PorciNulos.Size = new System.Drawing.Size(68, 17);
            this.lbl_PorciNulos.TabIndex = 4;
            this.lbl_PorciNulos.Text = "Porciento";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(26, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 76);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_VotosNulos
            // 
            this.lbl_VotosNulos.AutoSize = true;
            this.lbl_VotosNulos.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VotosNulos.Location = new System.Drawing.Point(175, 59);
            this.lbl_VotosNulos.Name = "lbl_VotosNulos";
            this.lbl_VotosNulos.Size = new System.Drawing.Size(161, 30);
            this.lbl_VotosNulos.TabIndex = 3;
            this.lbl_VotosNulos.Text = "Votos Nulos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(155, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Votos Nulos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_TotalPadron);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 134);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 76);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_TotalPadron
            // 
            this.lbl_TotalPadron.AutoSize = true;
            this.lbl_TotalPadron.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalPadron.Location = new System.Drawing.Point(161, 59);
            this.lbl_TotalPadron.Name = "lbl_TotalPadron";
            this.lbl_TotalPadron.Size = new System.Drawing.Size(192, 34);
            this.lbl_TotalPadron.TabIndex = 1;
            this.lbl_TotalPadron.Text = "Total Padron";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(102, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Padrón Electoral";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Controls.Add(this.lbl_PorEmitido);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lbl_VotosEmitidos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(443, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 134);
            this.panel2.TabIndex = 1;
            // 
            // lbl_PorEmitido
            // 
            this.lbl_PorEmitido.AutoSize = true;
            this.lbl_PorEmitido.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PorEmitido.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PorEmitido.Location = new System.Drawing.Point(245, 96);
            this.lbl_PorEmitido.Name = "lbl_PorEmitido";
            this.lbl_PorEmitido.Size = new System.Drawing.Size(68, 17);
            this.lbl_PorEmitido.TabIndex = 3;
            this.lbl_PorEmitido.Text = "Porciento";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(26, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 76);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_VotosEmitidos
            // 
            this.lbl_VotosEmitidos.AutoSize = true;
            this.lbl_VotosEmitidos.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VotosEmitidos.Location = new System.Drawing.Point(171, 59);
            this.lbl_VotosEmitidos.Name = "lbl_VotosEmitidos";
            this.lbl_VotosEmitidos.Size = new System.Drawing.Size(221, 34);
            this.lbl_VotosEmitidos.TabIndex = 2;
            this.lbl_VotosEmitidos.Text = "Votos Emitidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(139, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Votos Emitidos";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "Panel de Votaciones";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_ActualizarDatos
            // 
            this.btn_ActualizarDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ActualizarDatos.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarDatos.Location = new System.Drawing.Point(1017, 792);
            this.btn_ActualizarDatos.Name = "btn_ActualizarDatos";
            this.btn_ActualizarDatos.Size = new System.Drawing.Size(265, 43);
            this.btn_ActualizarDatos.TabIndex = 23;
            this.btn_ActualizarDatos.Text = "Refrescar Resultados";
            this.btn_ActualizarDatos.UseVisualStyleBackColor = true;
            this.btn_ActualizarDatos.Click += new System.EventHandler(this.btn_ActualizarDatos_Click);
            // 
            // tm_Actualizar
            // 
            this.tm_Actualizar.Enabled = true;
            this.tm_Actualizar.Interval = 1000;
            this.tm_Actualizar.Tick += new System.EventHandler(this.tm_Actualizar_Tick);
            // 
            // lbl_TiempoRes
            // 
            this.lbl_TiempoRes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TiempoRes.AutoSize = true;
            this.lbl_TiempoRes.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TiempoRes.Location = new System.Drawing.Point(567, 780);
            this.lbl_TiempoRes.Name = "lbl_TiempoRes";
            this.lbl_TiempoRes.Size = new System.Drawing.Size(225, 62);
            this.lbl_TiempoRes.TabIndex = 25;
            this.lbl_TiempoRes.Text = "00:00:00";
            this.lbl_TiempoRes.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frm_PanelVotaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 847);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_ActualizarDatos);
            this.Controls.Add(this.lbl_TiempoRes);
            this.Name = "frm_PanelVotaciones";
            this.Text = "PanelVotaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPanelVotaciones_FormClosing);
            this.Load += new System.EventHandler(this.PanelVotaciones_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Barras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Pastel)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_TotalPadron;
        private System.Windows.Forms.Label lbl_VotosEmitidos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_VotosNulos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_PorciNulos;
        private System.Windows.Forms.Label lbl_PorEmitido;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Pastel;
        private System.Windows.Forms.Timer tm_Actualizar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Barras;
        private System.Windows.Forms.Button btn_ActualizarDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_TiempoRes;

    }
}