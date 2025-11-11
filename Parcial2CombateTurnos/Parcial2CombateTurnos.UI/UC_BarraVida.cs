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
        public void ActualizarVida(int vidaActual, int vidaMax, string nombre)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ActualizarVida(vidaActual, vidaMax, nombre)));
                return;
            }
            lbl_Nombre.Text = nombre;
            vidaFiller.Width = (int)((pictureBox1.Width - 20) * ((double)vidaActual / Math.Max(1, vidaMax)));
            vidaFiller.Refresh();
        }

    }
}
