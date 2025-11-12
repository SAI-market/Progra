using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2CombateTurnos.UI
{
    public partial class UC_BarraVida : UserControl
    {
        public UC_BarraVida()
        {
            InitializeComponent();
        }

        private void UC_BarraVida_Load(object sender, EventArgs e)
        {

        }

        // --- MÉTODO ACTUALIZADO CON LÓGICA DE COLOR ---
        public void ActualizarVida(int vidaActual, int vidaMax, string nombre)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ActualizarVida(vidaActual, vidaMax, nombre)));
                return;
            }

            lbl_Nombre.Text = nombre;

            // Calcula el porcentaje de vida
            double porcentaje = (double)vidaActual / Math.Max(1, vidaMax);

            // Ajusta el ancho de la barra de vida (el "filler")
            // Usamos el ancho del 'pictureBox1' (el fondo) como referencia
            vidaFiller.Width = (int)(pictureBox1.Width * porcentaje);

            // --- LÓGICA DE COLOR DINÁMICO ---
            if (porcentaje > 0.6)
            {
                vidaFiller.BackColor = Color.FromArgb(0, 192, 0); // Verde
            }
            else if (porcentaje > 0.3)
            {
                vidaFiller.BackColor = Color.Yellow; // Amarillo
            }
            else
            {
                vidaFiller.BackColor = Color.Red; // Rojo
            }

            vidaFiller.Refresh();
        }
    }
}