namespace SistemaElectoralEstudiantil
{
    partial class CrearPlancha
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
            this.dgv_CrearCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CrearCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_CrearCliente
            // 
            this.dgv_CrearCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CrearCliente.Location = new System.Drawing.Point(92, 365);
            this.dgv_CrearCliente.Name = "dgv_CrearCliente";
            this.dgv_CrearCliente.RowHeadersWidth = 51;
            this.dgv_CrearCliente.RowTemplate.Height = 24;
            this.dgv_CrearCliente.Size = new System.Drawing.Size(612, 344);
            this.dgv_CrearCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crear Plancha Electoral";
            // 
            // CrearPlancha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 792);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_CrearCliente);
            this.Name = "CrearPlancha";
            this.Text = "CrearPlancha";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CrearCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_CrearCliente;
        private System.Windows.Forms.Label label1;
    }
}