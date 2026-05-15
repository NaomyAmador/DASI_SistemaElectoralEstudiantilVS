namespace SistemaElectoralEstudiantil.Principal
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtBox_Usuario = new System.Windows.Forms.TextBox();
            this.Lbl_Decoración1 = new System.Windows.Forms.Label();
            this.Lbl_Decoración2 = new System.Windows.Forms.Label();
            this.Lbl_Decoración3 = new System.Windows.Forms.Label();
            this.Lbl_Decoración4 = new System.Windows.Forms.Label();
            this.Lbl_Decoración5 = new System.Windows.Forms.Label();
            this.Lbl_Indicaciones = new System.Windows.Forms.Label();
            this.Lbl_Decoración7 = new System.Windows.Forms.Label();
            this.Lbl_Decoración8 = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Lbl_Contraseña = new System.Windows.Forms.Label();
            this.TxtBox_Password = new System.Windows.Forms.TextBox();
            this.Btn_IniciarSesión = new System.Windows.Forms.Button();
            this.Btn_VerPassword = new System.Windows.Forms.Button();
            this.Btn_NoVerPassword = new System.Windows.Forms.Button();
            this.ProgressBar_InicioSesión = new System.Windows.Forms.ProgressBar();
            this.Lbl_ProgressBarTexto = new System.Windows.Forms.Label();
            this.Tiempo_InicioSesión = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TxtBox_Usuario
            // 
            this.TxtBox_Usuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Usuario.ForeColor = System.Drawing.Color.Gray;
            this.TxtBox_Usuario.Location = new System.Drawing.Point(134, 207);
            this.TxtBox_Usuario.Name = "TxtBox_Usuario";
            this.TxtBox_Usuario.Size = new System.Drawing.Size(174, 28);
            this.TxtBox_Usuario.TabIndex = 1;
            // 
            // Lbl_Decoración1
            // 
            this.Lbl_Decoración1.AutoSize = true;
            this.Lbl_Decoración1.Font = new System.Drawing.Font("Century Gothic", 6F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Decoración1.ForeColor = System.Drawing.Color.Peru;
            this.Lbl_Decoración1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Decoración1.Location = new System.Drawing.Point(289, 10);
            this.Lbl_Decoración1.Name = "Lbl_Decoración1";
            this.Lbl_Decoración1.Size = new System.Drawing.Size(140, 14);
            this.Lbl_Decoración1.TabIndex = 2;
            this.Lbl_Decoración1.Text = "Proyecto No. 2 - Votaciones";
            // 
            // Lbl_Decoración2
            // 
            this.Lbl_Decoración2.AutoSize = true;
            this.Lbl_Decoración2.Font = new System.Drawing.Font("Papillion PERSONAL USE ONLY", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Decoración2.ForeColor = System.Drawing.Color.Chocolate;
            this.Lbl_Decoración2.Location = new System.Drawing.Point(194, 23);
            this.Lbl_Decoración2.Name = "Lbl_Decoración2";
            this.Lbl_Decoración2.Size = new System.Drawing.Size(341, 81);
            this.Lbl_Decoración2.TabIndex = 3;
            this.Lbl_Decoración2.Text = "Sistema Electoral Estudiantil";
            // 
            // Lbl_Decoración3
            // 
            this.Lbl_Decoración3.AutoSize = true;
            this.Lbl_Decoración3.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Decoración3.ForeColor = System.Drawing.Color.Maroon;
            this.Lbl_Decoración3.Location = new System.Drawing.Point(211, 84);
            this.Lbl_Decoración3.Name = "Lbl_Decoración3";
            this.Lbl_Decoración3.Size = new System.Drawing.Size(284, 17);
            this.Lbl_Decoración3.TabIndex = 4;
            this.Lbl_Decoración3.Text = "Decide el Rumbo de nuestro Centro Educativo";
            // 
            // Lbl_Decoración4
            // 
            this.Lbl_Decoración4.AutoSize = true;
            this.Lbl_Decoración4.Font = new System.Drawing.Font("Papillion PERSONAL USE ONLY", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Decoración4.ForeColor = System.Drawing.Color.Sienna;
            this.Lbl_Decoración4.Location = new System.Drawing.Point(231, 100);
            this.Lbl_Decoración4.Name = "Lbl_Decoración4";
            this.Lbl_Decoración4.Size = new System.Drawing.Size(244, 52);
            this.Lbl_Decoración4.TabIndex = 5;
            this.Lbl_Decoración4.Text = "Elige nuestro futuro en un solo lugar";
            // 
            // Lbl_Decoración5
            // 
            this.Lbl_Decoración5.AutoSize = true;
            this.Lbl_Decoración5.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Decoración5.ForeColor = System.Drawing.Color.Maroon;
            this.Lbl_Decoración5.Location = new System.Drawing.Point(295, 142);
            this.Lbl_Decoración5.Name = "Lbl_Decoración5";
            this.Lbl_Decoración5.Size = new System.Drawing.Size(146, 15);
            this.Lbl_Decoración5.TabIndex = 6;
            this.Lbl_Decoración5.Text = "¡Tu Voto hace la Diferencia!";
            // 
            // Lbl_Indicaciones
            // 
            this.Lbl_Indicaciones.AutoSize = true;
            this.Lbl_Indicaciones.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Indicaciones.ForeColor = System.Drawing.Color.Maroon;
            this.Lbl_Indicaciones.Location = new System.Drawing.Point(6, 172);
            this.Lbl_Indicaciones.Name = "Lbl_Indicaciones";
            this.Lbl_Indicaciones.Size = new System.Drawing.Size(603, 16);
            this.Lbl_Indicaciones.TabIndex = 7;
            this.Lbl_Indicaciones.Text = "✦• Datos a Completar para Ingresar  •✦···········································" +
    "·····································•✦";
            // 
            // Lbl_Decoración7
            // 
            this.Lbl_Decoración7.AutoSize = true;
            this.Lbl_Decoración7.Font = new System.Drawing.Font("Century Gothic", 4.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Decoración7.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Lbl_Decoración7.Location = new System.Drawing.Point(482, 188);
            this.Lbl_Decoración7.Name = "Lbl_Decoración7";
            this.Lbl_Decoración7.Size = new System.Drawing.Size(110, 12);
            this.Lbl_Decoración7.TabIndex = 8;
            this.Lbl_Decoración7.Text = "Desarrollo de Aplicaciones";
            // 
            // Lbl_Decoración8
            // 
            this.Lbl_Decoración8.AutoSize = true;
            this.Lbl_Decoración8.Font = new System.Drawing.Font("Century Gothic", 4.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Decoración8.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Lbl_Decoración8.Location = new System.Drawing.Point(496, 207);
            this.Lbl_Decoración8.Name = "Lbl_Decoración8";
            this.Lbl_Decoración8.Size = new System.Drawing.Size(96, 12);
            this.Lbl_Decoración8.TabIndex = 9;
            this.Lbl_Decoración8.Text = "y Sistemas Informáticos";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.ForeColor = System.Drawing.Color.Sienna;
            this.Lbl_Usuario.Location = new System.Drawing.Point(14, 208);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(117, 23);
            this.Lbl_Usuario.TabIndex = 10;
            this.Lbl_Usuario.Text = "○ Usuario ●";
            // 
            // Lbl_Contraseña
            // 
            this.Lbl_Contraseña.AutoSize = true;
            this.Lbl_Contraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contraseña.ForeColor = System.Drawing.Color.Sienna;
            this.Lbl_Contraseña.Location = new System.Drawing.Point(14, 256);
            this.Lbl_Contraseña.Name = "Lbl_Contraseña";
            this.Lbl_Contraseña.Size = new System.Drawing.Size(159, 23);
            this.Lbl_Contraseña.TabIndex = 11;
            this.Lbl_Contraseña.Text = "○ Contraseña ●";
            // 
            // TxtBox_Password
            // 
            this.TxtBox_Password.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Password.ForeColor = System.Drawing.Color.Gray;
            this.TxtBox_Password.Location = new System.Drawing.Point(178, 254);
            this.TxtBox_Password.Name = "TxtBox_Password";
            this.TxtBox_Password.PasswordChar = '*';
            this.TxtBox_Password.Size = new System.Drawing.Size(174, 28);
            this.TxtBox_Password.TabIndex = 12;
            // 
            // Btn_IniciarSesión
            // 
            this.Btn_IniciarSesión.BackColor = System.Drawing.Color.Chocolate;
            this.Btn_IniciarSesión.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_IniciarSesión.ForeColor = System.Drawing.Color.White;
            this.Btn_IniciarSesión.Location = new System.Drawing.Point(217, 324);
            this.Btn_IniciarSesión.Name = "Btn_IniciarSesión";
            this.Btn_IniciarSesión.Size = new System.Drawing.Size(189, 40);
            this.Btn_IniciarSesión.TabIndex = 13;
            this.Btn_IniciarSesión.Text = "Iniciar Sesión";
            this.Btn_IniciarSesión.UseVisualStyleBackColor = false;
            this.Btn_IniciarSesión.Click += new System.EventHandler(this.Btn_IniciarSesión_Click);
            // 
            // Btn_VerPassword
            // 
            this.Btn_VerPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_VerPassword.BackgroundImage")));
            this.Btn_VerPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_VerPassword.Location = new System.Drawing.Point(355, 251);
            this.Btn_VerPassword.Name = "Btn_VerPassword";
            this.Btn_VerPassword.Size = new System.Drawing.Size(41, 32);
            this.Btn_VerPassword.TabIndex = 14;
            this.Btn_VerPassword.UseVisualStyleBackColor = true;
            this.Btn_VerPassword.Click += new System.EventHandler(this.Btn_VerPassword_Click);
            // 
            // Btn_NoVerPassword
            // 
            this.Btn_NoVerPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_NoVerPassword.BackgroundImage")));
            this.Btn_NoVerPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_NoVerPassword.Location = new System.Drawing.Point(397, 251);
            this.Btn_NoVerPassword.Name = "Btn_NoVerPassword";
            this.Btn_NoVerPassword.Size = new System.Drawing.Size(42, 32);
            this.Btn_NoVerPassword.TabIndex = 15;
            this.Btn_NoVerPassword.UseVisualStyleBackColor = true;
            this.Btn_NoVerPassword.Click += new System.EventHandler(this.Btn_NoVerPassword_Click);
            // 
            // ProgressBar_InicioSesión
            // 
            this.ProgressBar_InicioSesión.Location = new System.Drawing.Point(18, 409);
            this.ProgressBar_InicioSesión.Name = "ProgressBar_InicioSesión";
            this.ProgressBar_InicioSesión.Size = new System.Drawing.Size(587, 30);
            this.ProgressBar_InicioSesión.TabIndex = 16;
            // 
            // Lbl_ProgressBarTexto
            // 
            this.Lbl_ProgressBarTexto.AutoSize = true;
            this.Lbl_ProgressBarTexto.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ProgressBarTexto.Location = new System.Drawing.Point(17, 380);
            this.Lbl_ProgressBarTexto.Name = "Lbl_ProgressBarTexto";
            this.Lbl_ProgressBarTexto.Size = new System.Drawing.Size(139, 17);
            this.Lbl_ProgressBarTexto.TabIndex = 17;
            this.Lbl_ProgressBarTexto.Text = "Procesando el Login";
            // 
            // Tiempo_InicioSesión
            // 
            this.Tiempo_InicioSesión.Tick += new System.EventHandler(this.Tiempo_InicioSesión_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(530, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 18;
            this.label1.Text = "✐📓ˎˊ˗";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Peru;
            this.label2.Location = new System.Drawing.Point(449, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "☕︎‧₊˚⏱٠࣪⋆💻₊˚ᵎ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(171, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 40);
            this.label3.TabIndex = 20;
            this.label3.Text = "◉";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(411, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 40);
            this.label4.TabIndex = 21;
            this.label4.Text = "◉";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(617, 460);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_ProgressBarTexto);
            this.Controls.Add(this.ProgressBar_InicioSesión);
            this.Controls.Add(this.Btn_NoVerPassword);
            this.Controls.Add(this.Btn_VerPassword);
            this.Controls.Add(this.Btn_IniciarSesión);
            this.Controls.Add(this.TxtBox_Password);
            this.Controls.Add(this.Lbl_Contraseña);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Lbl_Decoración8);
            this.Controls.Add(this.Lbl_Decoración7);
            this.Controls.Add(this.Lbl_Indicaciones);
            this.Controls.Add(this.Lbl_Decoración5);
            this.Controls.Add(this.Lbl_Decoración4);
            this.Controls.Add(this.Lbl_Decoración3);
            this.Controls.Add(this.Lbl_Decoración2);
            this.Controls.Add(this.Lbl_Decoración1);
            this.Controls.Add(this.TxtBox_Usuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtBox_Usuario;
        private System.Windows.Forms.Label Lbl_Decoración1;
        private System.Windows.Forms.Label Lbl_Decoración2;
        private System.Windows.Forms.Label Lbl_Decoración3;
        private System.Windows.Forms.Label Lbl_Decoración4;
        private System.Windows.Forms.Label Lbl_Decoración5;
        private System.Windows.Forms.Label Lbl_Indicaciones;
        private System.Windows.Forms.Label Lbl_Decoración7;
        private System.Windows.Forms.Label Lbl_Decoración8;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_Contraseña;
        private System.Windows.Forms.TextBox TxtBox_Password;
        private System.Windows.Forms.Button Btn_IniciarSesión;
        private System.Windows.Forms.Button Btn_VerPassword;
        private System.Windows.Forms.Button Btn_NoVerPassword;
        private System.Windows.Forms.ProgressBar ProgressBar_InicioSesión;
        private System.Windows.Forms.Label Lbl_ProgressBarTexto;
        private System.Windows.Forms.Timer Tiempo_InicioSesión;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}