namespace SistemaElectoralEstudiantil.EditarPlanchaYCandidato
{
    partial class GestionPlancha
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
            this.dgv_Planchas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btn_CambiarLogo = new System.Windows.Forms.Button();
            this.cB_PlanchaActiva = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Planchas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Planchas
            // 
            this.dgv_Planchas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Planchas.Location = new System.Drawing.Point(100, 333);
            this.dgv_Planchas.Name = "dgv_Planchas";
            this.dgv_Planchas.RowHeadersWidth = 51;
            this.dgv_Planchas.RowTemplate.Height = 24;
            this.dgv_Planchas.Size = new System.Drawing.Size(891, 368);
            this.dgv_Planchas.TabIndex = 0;
            this.dgv_Planchas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Planchas_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestión de Planchas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(240, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(549, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aqui podrás desactivar/activar planchas, actualizarlas y eliminarlas\r\n";
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizar.Location = new System.Drawing.Point(280, 85);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(235, 39);
            this.btn_Actualizar.TabIndex = 3;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Location = new System.Drawing.Point(554, 85);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(235, 39);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.Text = "Eiminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre Plancha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(605, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Logo:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(200, 163);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(387, 22);
            this.txt_Nombre.TabIndex = 9;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(199, 194);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Descripcion.Size = new System.Drawing.Size(388, 63);
            this.txt_Descripcion.TabIndex = 10;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(682, 150);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(185, 165);
            this.picLogo.TabIndex = 11;
            this.picLogo.TabStop = false;
            // 
            // btn_CambiarLogo
            // 
            this.btn_CambiarLogo.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CambiarLogo.Location = new System.Drawing.Point(889, 218);
            this.btn_CambiarLogo.Name = "btn_CambiarLogo";
            this.btn_CambiarLogo.Size = new System.Drawing.Size(154, 39);
            this.btn_CambiarLogo.TabIndex = 12;
            this.btn_CambiarLogo.Text = "Cambiar Logo";
            this.btn_CambiarLogo.UseVisualStyleBackColor = true;
            this.btn_CambiarLogo.Click += new System.EventHandler(this.btn_CambiarLogo_Click);
            // 
            // cB_PlanchaActiva
            // 
            this.cB_PlanchaActiva.AutoSize = true;
            this.cB_PlanchaActiva.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_PlanchaActiva.Location = new System.Drawing.Point(47, 285);
            this.cB_PlanchaActiva.Name = "cB_PlanchaActiva";
            this.cB_PlanchaActiva.Size = new System.Drawing.Size(151, 24);
            this.cB_PlanchaActiva.TabIndex = 13;
            this.cB_PlanchaActiva.Text = "Plancha Activa";
            this.cB_PlanchaActiva.UseVisualStyleBackColor = true;
            // 
            // GestionPlancha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 729);
            this.Controls.Add(this.cB_PlanchaActiva);
            this.Controls.Add(this.btn_CambiarLogo);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Planchas);
            this.Name = "GestionPlancha";
            this.Text = "GestionPlancha";
            this.Load += new System.EventHandler(this.GestionPlancha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Planchas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Planchas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btn_CambiarLogo;
        private System.Windows.Forms.CheckBox cB_PlanchaActiva;
    }
}