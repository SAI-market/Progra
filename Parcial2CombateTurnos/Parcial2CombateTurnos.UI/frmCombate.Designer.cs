namespace Parcial2CombateTurnos.UI
{
    partial class frmCombate
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uC_BarraVidaJugador = new UC_BarraVida();
            uC_BarraVidaEnemigo = new UC_BarraVida();
            btn_ConfirmAction = new Button();
            listBx_Logs = new ListBox();
            cbx_Habilidades = new ComboBox();
            btn_Reset = new Button();
            SuspendLayout();
            // 
            // uC_BarraVidaJugador
            // 
            uC_BarraVidaJugador.Location = new Point(12, 91);
            uC_BarraVidaJugador.Name = "uC_BarraVidaJugador";
            uC_BarraVidaJugador.Size = new Size(368, 131);
            uC_BarraVidaJugador.TabIndex = 0;
            // 
            // uC_BarraVidaEnemigo
            // 
            uC_BarraVidaEnemigo.Location = new Point(386, 91);
            uC_BarraVidaEnemigo.Name = "uC_BarraVidaEnemigo";
            uC_BarraVidaEnemigo.Size = new Size(368, 131);
            uC_BarraVidaEnemigo.TabIndex = 1;
            // 
            // btn_ConfirmAction
            // 
            btn_ConfirmAction.Location = new Point(286, 281);
            btn_ConfirmAction.Name = "btn_ConfirmAction";
            btn_ConfirmAction.Size = new Size(94, 29);
            btn_ConfirmAction.TabIndex = 2;
            btn_ConfirmAction.Text = "Proceed";
            btn_ConfirmAction.UseVisualStyleBackColor = true;
            btn_ConfirmAction.Click += btn_ConfirmAction_Click;
            // 
            // listBx_Logs
            // 
            listBx_Logs.FormattingEnabled = true;
            listBx_Logs.Location = new Point(386, 219);
            listBx_Logs.Name = "listBx_Logs";
            listBx_Logs.Size = new Size(389, 224);
            listBx_Logs.TabIndex = 3;
            // 
            // cbx_Habilidades
            // 
            cbx_Habilidades.FormattingEnabled = true;
            cbx_Habilidades.Location = new Point(12, 256);
            cbx_Habilidades.Name = "cbx_Habilidades";
            cbx_Habilidades.Size = new Size(258, 28);
            cbx_Habilidades.TabIndex = 4;
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(286, 316);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(94, 29);
            btn_Reset.TabIndex = 5;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // frmCombate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Reset);
            Controls.Add(cbx_Habilidades);
            Controls.Add(listBx_Logs);
            Controls.Add(btn_ConfirmAction);
            Controls.Add(uC_BarraVidaEnemigo);
            Controls.Add(uC_BarraVidaJugador);
            Name = "frmCombate";
            Text = "Form1";
            Load += frmCombate_Load;
            ResumeLayout(false);
        }

        #endregion

        private UC_BarraVida uC_BarraVidaJugador;
        private UC_BarraVida uC_BarraVidaEnemigo;
        private Button btn_ConfirmAction;
        private ListBox listBx_Logs;
        private ComboBox cbx_Habilidades;
        private Button btn_Reset;
    }
}
