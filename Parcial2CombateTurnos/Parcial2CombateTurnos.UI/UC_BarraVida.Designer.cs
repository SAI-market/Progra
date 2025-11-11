namespace Parcial2CombateTurnos.UI
{
    partial class UC_BarraVida
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            vidaFiller = new PictureBox();
            lbl_Nombre = new Label();
            pictureBox1 = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)vidaFiller).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // vidaFiller
            // 
            vidaFiller.BackColor = Color.Red;
            vidaFiller.Location = new Point(16, 45);
            vidaFiller.Name = "vidaFiller";
            vidaFiller.Size = new Size(255, 31);
            vidaFiller.TabIndex = 0;
            vidaFiller.TabStop = false;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(16, 12);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(50, 20);
            lbl_Nombre.TabIndex = 1;
            lbl_Nombre.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(3, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 48);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UC_BarraVida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_Nombre);
            Controls.Add(vidaFiller);
            Controls.Add(pictureBox1);
            Name = "UC_BarraVida";
            Size = new Size(294, 105);
            Load += UC_BarraVida_Load;
            ((System.ComponentModel.ISupportInitialize)vidaFiller).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox vidaFiller;
        private Label lbl_Nombre;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
