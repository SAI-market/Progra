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
            vidaFiller.BackColor = Color.FromArgb(0, 192, 0); // <-- CAMBIO ESTÉTICO
            vidaFiller.Location = new Point(10, 40); // <-- CAMBIO ESTÉTICO
            vidaFiller.Name = "vidaFiller";
            vidaFiller.Size = new Size(276, 25); // <-- CAMBIO ESTÉTICO
            vidaFiller.TabIndex = 0;
            vidaFiller.TabStop = false;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0); // <-- CAMBIO ESTÉTICO
            lbl_Nombre.ForeColor = Color.White; // <-- CAMBIO ESTÉTICO
            lbl_Nombre.Location = new Point(10, 10); // <-- CAMBIO ESTÉTICO
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(57, 21); // (El tamaño cambia por la fuente, pero el texto no)
            lbl_Nombre.TabIndex = 1;
            lbl_Nombre.Text = "label1"; // <-- TEXTO ORIGINAL CONSERVADO
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(64, 64, 64); // <-- CAMBIO ESTÉTICO
            pictureBox1.Location = new Point(10, 40); // <-- CAMBIO ESTÉTICO
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 25); // <-- CAMBIO ESTÉTICO
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UC_BarraVida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent; // <-- CAMBIO ESTÉTICO
            Controls.Add(lbl_Nombre);
            Controls.Add(vidaFiller);
            Controls.Add(pictureBox1);
            Name = "UC_BarraVida";
            Size = new Size(294, 75); // <-- CAMBIO ESTÉTICO
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