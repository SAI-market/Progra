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
            uC_BarraVidaJugador.BackColor = Color.Transparent;
            uC_BarraVidaJugador.Location = new Point(12, 12); // <-- CAMBIO ESTÉTICO
            uC_BarraVidaJugador.Margin = new Padding(3, 2, 3, 2);
            uC_BarraVidaJugador.Name = "uC_BarraVidaJugador";
            uC_BarraVidaJugador.Size = new Size(294, 75); // <-- CAMBIO ESTÉTICO
            uC_BarraVidaJugador.TabIndex = 0;
            uC_BarraVidaJugador.Load += uC_BarraVidaJugador_Load;
            // 
            // uC_BarraVidaEnemigo
            // 
            uC_BarraVidaEnemigo.BackColor = Color.Transparent;
            uC_BarraVidaEnemigo.Location = new Point(394, 12); // <-- CAMBIO ESTÉTICO
            uC_BarraVidaEnemigo.Margin = new Padding(3, 2, 3, 2);
            uC_BarraVidaEnemigo.Name = "uC_BarraVidaEnemigo";
            uC_BarraVidaEnemigo.Size = new Size(294, 75); // <-- CAMBIO ESTÉTICO
            uC_BarraVidaEnemigo.TabIndex = 1;
            // 
            // btn_ConfirmAction
            // 
            btn_ConfirmAction.BackColor = Color.FromArgb(60, 60, 60); // <-- CAMBIO ESTÉTICO
            btn_ConfirmAction.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btn_ConfirmAction.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            btn_ConfirmAction.FlatStyle = FlatStyle.Flat; // <-- CAMBIO ESTÉTICO
            btn_ConfirmAction.ForeColor = Color.White; // <-- CAMBIO ESTÉTICO
            btn_ConfirmAction.Location = new Point(443, 304); // <-- CAMBIO ESTÉTICO
            btn_ConfirmAction.Margin = new Padding(3, 2, 3, 2);
            btn_ConfirmAction.Name = "btn_ConfirmAction";
            btn_ConfirmAction.Size = new Size(130, 30); // <-- CAMBIO ESTÉTICO
            btn_ConfirmAction.TabIndex = 2;
            btn_ConfirmAction.Text = "Proceed"; // <-- TEXTO ORIGINAL CONSERVADO
            btn_ConfirmAction.UseVisualStyleBackColor = false;
            btn_ConfirmAction.Click += btn_ConfirmAction_Click;
            // 
            // listBx_Logs
            // 
            listBx_Logs.BackColor = Color.FromArgb(30, 30, 30); // <-- CAMBIO ESTÉTICO
            listBx_Logs.BorderStyle = BorderStyle.FixedSingle; // <-- CAMBIO ESTÉTICO
            listBx_Logs.ForeColor = Color.WhiteSmoke; // <-- CAMBIO ESTÉTICO
            listBx_Logs.FormattingEnabled = true;
            listBx_Logs.ItemHeight = 15;
            listBx_Logs.Location = new Point(12, 103); // <-- CAMBIO ESTÉTICO
            listBx_Logs.Margin = new Padding(3, 2, 3, 2);
            listBx_Logs.Name = "listBx_Logs";
            listBx_Logs.Size = new Size(676, 182); // <-- CAMBIO ESTÉTICO
            listBx_Logs.TabIndex = 3;
            // 
            // cbx_Habilidades
            // 
            cbx_Habilidades.BackColor = Color.FromArgb(60, 60, 60); // <-- CAMBIO ESTÉTICO
            cbx_Habilidades.DropDownStyle = ComboBoxStyle.DropDownList; // <-- CAMBIO ESTÉTICO
            cbx_Habilidades.FlatStyle = FlatStyle.Flat; // <-- CAMBIO ESTÉTICO
            cbx_Habilidades.ForeColor = Color.White; // <-- CAMBIO ESTÉTICO
            cbx_Habilidades.FormattingEnabled = true;
            cbx_Habilidades.Location = new Point(128, 308); // <-- CAMBIO ESTÉTICO
            cbx_Habilidades.Margin = new Padding(3, 2, 3, 2);
            cbx_Habilidades.Name = "cbx_Habilidades";
            cbx_Habilidades.Size = new Size(286, 23); // <-- CAMBIO ESTÉTICO
            cbx_Habilidades.TabIndex = 4;
            // 
            // btn_Reset
            // 
            btn_Reset.BackColor = Color.FromArgb(60, 60, 60); // <-- CAMBIO ESTÉTICO
            btn_Reset.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 80);
            btn_Reset.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 80, 80);
            btn_Reset.FlatStyle = FlatStyle.Flat; // <-- CAMBIO ESTÉTICO
            btn_Reset.ForeColor = Color.White; // <-- CAMBIO ESTÉTICO
            btn_Reset.Location = new Point(579, 304); // <-- CAMBIO ESTÉTICO
            btn_Reset.Margin = new Padding(3, 2, 3, 2);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(109, 30); // <-- CAMBIO ESTÉTICO
            btn_Reset.TabIndex = 5;
            btn_Reset.Text = "Reset"; // <-- TEXTO ORIGINAL CONSERVADO
            btn_Reset.UseVisualStyleBackColor = false;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // frmCombate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40); // <-- CAMBIO ESTÉTICO
            ClientSize = new Size(700, 348); // <-- CAMBIO ESTÉTICO
            Controls.Add(btn_Reset);
            Controls.Add(cbx_Habilidades);
            Controls.Add(listBx_Logs);
            Controls.Add(btn_ConfirmAction);
            Controls.Add(uC_BarraVidaEnemigo);
            Controls.Add(uC_BarraVidaJugador);
            FormBorderStyle = FormBorderStyle.FixedSingle; // <-- CAMBIO ESTÉTICO
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false; // <-- CAMBIO ESTÉTICO
            Name = "frmCombate";
            Text = "Form1"; // <-- TEXTO ORIGINAL CONSERVADO
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