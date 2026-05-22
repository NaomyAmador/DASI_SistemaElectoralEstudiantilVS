namespace SistemaElectoralEstudiantil
{
    partial class ReporteIntegrantesdelpartido
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombrePlancha = new System.Windows.Forms.TextBox();
            this.btnBuscarPartido = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(40, 153);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1614, 1204);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(41, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(946, 98);
            this.label1.TabIndex = 1;
            this.label1.Text = "Integrantes del partido";
            // 
            // txtNombrePlancha
            // 
            this.txtNombrePlancha.Location = new System.Drawing.Point(1041, 86);
            this.txtNombrePlancha.Name = "txtNombrePlancha";
            this.txtNombrePlancha.Size = new System.Drawing.Size(211, 31);
            this.txtNombrePlancha.TabIndex = 2;
            // 
            // btnBuscarPartido
            // 
            this.btnBuscarPartido.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Italic);
            this.btnBuscarPartido.Location = new System.Drawing.Point(1267, 70);
            this.btnBuscarPartido.Name = "btnBuscarPartido";
            this.btnBuscarPartido.Size = new System.Drawing.Size(143, 47);
            this.btnBuscarPartido.TabIndex = 3;
            this.btnBuscarPartido.Text = "Buscar";
            this.btnBuscarPartido.UseVisualStyleBackColor = true;
            this.btnBuscarPartido.Click += new System.EventHandler(this.btnBuscarPartido_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1036, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre del partido";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(1439, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ReporteIntegrantesdelpartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 1392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarPartido);
            this.Controls.Add(this.txtNombrePlancha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteIntegrantesdelpartido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteIntegrantesdelpartido";
            this.Load += new System.EventHandler(this.ReporteIntegrantesdelpartido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombrePlancha;
        private System.Windows.Forms.Button btnBuscarPartido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}