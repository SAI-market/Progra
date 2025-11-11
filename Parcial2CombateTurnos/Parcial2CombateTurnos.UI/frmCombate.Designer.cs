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
            uC_BarraVidaJugador.Location = new Point(242, 7);
            uC_BarraVidaJugador.Margin = new Padding(3, 2, 3, 2);
            uC_BarraVidaJugador.Name = "uC_BarraVidaJugador";
            uC_BarraVidaJugador.Size = new Size(322, 98);
            uC_BarraVidaJugador.TabIndex = 0;
            uC_BarraVidaJugador.Load += uC_BarraVidaJugador_Load;
            // 
            // uC_BarraVidaEnemigo
            // 
            uC_BarraVidaEnemigo.Location = new Point(242, 99);
            uC_BarraVidaEnemigo.Margin = new Padding(3, 2, 3, 2);
            uC_BarraVidaEnemigo.Name = "uC_BarraVidaEnemigo";
            uC_BarraVidaEnemigo.Size = new Size(322, 98);
            uC_BarraVidaEnemigo.TabIndex = 1;
            // 
            // btn_ConfirmAction
            // 
            btn_ConfirmAction.Location = new Point(578, 211);
            btn_ConfirmAction.Margin = new Padding(3, 2, 3, 2);
            btn_ConfirmAction.Name = "btn_ConfirmAction";
            btn_ConfirmAction.Size = new Size(82, 22);
            btn_ConfirmAction.TabIndex = 2;
            btn_ConfirmAction.Text = "Proceed";
            btn_ConfirmAction.UseVisualStyleBackColor = true;
            btn_ConfirmAction.Click += btn_ConfirmAction_Click;
            // 
            // listBx_Logs
            // 
            listBx_Logs.FormattingEnabled = true;
            listBx_Logs.ItemHeight = 15;
            listBx_Logs.Location = new Point(181, 176);
            listBx_Logs.Margin = new Padding(3, 2, 3, 2);
            listBx_Logs.Name = "listBx_Logs";
            listBx_Logs.Size = new Size(372, 124);
            listBx_Logs.TabIndex = 3;
            // 
            // cbx_Habilidades
            // 
            cbx_Habilidades.FormattingEnabled = true;
            cbx_Habilidades.Location = new Point(242, 304);
            cbx_Habilidades.Margin = new Padding(3, 2, 3, 2);
            cbx_Habilidades.Name = "cbx_Habilidades";
            cbx_Habilidades.Size = new Size(226, 23);
            cbx_Habilidades.TabIndex = 4;
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(578, 251);
            btn_Reset.Margin = new Padding(3, 2, 3, 2);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(82, 22);
            btn_Reset.TabIndex = 5;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // frmCombate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btn_Reset);
            Controls.Add(cbx_Habilidades);
            Controls.Add(listBx_Logs);
            Controls.Add(btn_ConfirmAction);
            Controls.Add(uC_BarraVidaEnemigo);
            Controls.Add(uC_BarraVidaJugador);
            Margin = new Padding(3, 2, 3, 2);
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
