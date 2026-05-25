namespace SistemaElectoralEstudiantil.Reportes
{
    partial class Frm_ReportesSpace
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
            this.btn_Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Menu
            // 
            this.btn_Menu.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.Location = new System.Drawing.Point(525, 385);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(223, 38);
            this.btn_Menu.TabIndex = 0;
            this.btn_Menu.Text = "Volver al Menú";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // Frm_ReportesSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Menu);
            this.Name = "Frm_ReportesSpace";
            this.Text = "Frm_ReportesSpace";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Menu;
    }
}