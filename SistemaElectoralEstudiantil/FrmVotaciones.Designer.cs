namespace SistemaElectoralEstudiantil
{
    partial class FrmVotaciones
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
            this.flpPlanchas = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpPlanchas
            // 
            this.flpPlanchas.AutoScroll = true;
            this.flpPlanchas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPlanchas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPlanchas.Location = new System.Drawing.Point(0, 0);
            this.flpPlanchas.Name = "flpPlanchas";
            this.flpPlanchas.Size = new System.Drawing.Size(1449, 938);
            this.flpPlanchas.TabIndex = 0;
            // 
            // FrmVotaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 938);
            this.Controls.Add(this.flpPlanchas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVotaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVotaciones";
            this.Load += new System.EventHandler(this.FrmVotaciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPlanchas;
    }
}