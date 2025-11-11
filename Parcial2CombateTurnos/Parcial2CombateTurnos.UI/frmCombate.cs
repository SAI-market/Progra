using System;
using System.Linq;
using System.Windows.Forms;
using Parcial2CombateTurnos.BLL;
using Parcial2CombateTurnos.Models;

namespace Parcial2CombateTurnos.UI
{
    public partial class frmCombate : Form
    {
        private CombatService _combateService;

        public frmCombate()
        {
            InitializeComponent();
        }

        private void frmCombate_Load(object sender, EventArgs e)
        {
            IniciarCombate();
        }

        private void IniciarCombate()
        {
            listBx_Logs.Items.Clear();

            var jugador = new Unidad
            {
                Nombre = "Hunter",
                VidaMax = 40,
                VidaActual = 40,
                Habilidades = new System.Collections.Generic.List<Habilidad>
                {
                    new Habilidad{ Id=1, Nombre="Espadazo", Poder=5 },
                    new Habilidad{ Id=2, Nombre="Bola de Fuego", Poder=6, MultiplicadorMagia=1.5, ChanceFallar=0.3 },
                    new Habilidad{ Id=3, Nombre="Puñetazo", Poder=4 },
                    new Habilidad{ Id=4, Nombre="Rayo Arcano", Poder=7, MultiplicadorMagia=2, ChanceFallar=0.4 }
                }
            };

            var enemigo = new Unidad
            {
                Nombre = "Orc",
                VidaMax = 35,
                VidaActual = 35,
                Habilidades = new System.Collections.Generic.List<Habilidad>
                {
                    new Habilidad{ Id=1, Nombre="Mordisco", Poder=4 },
                    new Habilidad{ Id=2, Nombre="Lanzallamas", Poder=6, MultiplicadorMagia=1.5, ChanceFallar=0.25 }
                }
            };

            _combateService = new CombatService();
            _combateService.OnVidaCambiada += CombateService_OnVidaCambiada;
            _combateService.OnTurnoRegistrado += CombateService_OnTurnoRegistrado;
            _combateService.OnCombateFinalizado += CombateService_OnCombateFinalizado;
            _combateService.OnTurnoCambiado += CombateService_OnTurnoCambiado;

            _combateService.IniciarCombate(jugador, enemigo);

            cbx_Habilidades.Items.Clear();
            foreach (var h in jugador.Habilidades)
                cbx_Habilidades.Items.Add(h);
            if (cbx_Habilidades.Items.Count > 0)
                cbx_Habilidades.SelectedIndex = 0;
        }

        private void CombateService_OnTurnoCambiado(object sender, TurnEventArgs e)
        {
            bool esJugador = e.TurnoActual == TurnService.Turno.Jugador;
            btn_ConfirmAction.Enabled = esJugador;
            cbx_Habilidades.Enabled = esJugador;
        }

        private void CombateService_OnCombateFinalizado(object sender, CombatEndedEventArgs e)
        {
            MessageBox.Show(e.Ganador == _combateService.Jugador ? "¡Ganaste!" : "Perdiste.");
            btn_ConfirmAction.Enabled = false;
            cbx_Habilidades.Enabled = false;
        }

        private void CombateService_OnTurnoRegistrado(object sender, string e)
        {
            listBx_Logs.Items.Add(e);
            listBx_Logs.TopIndex = listBx_Logs.Items.Count - 1; // hacer scroll automático
        }

        private void CombateService_OnVidaCambiada(object sender, VidaEventArgs e)
        {
            if (e.EsJugador)
                uC_BarraVidaJugador.ActualizarVida(e.Unidad.VidaActual, e.Unidad.VidaMax, e.Unidad.Nombre);
            else
                uC_BarraVidaEnemigo.ActualizarVida(e.Unidad.VidaActual, e.Unidad.VidaMax, e.Unidad.Nombre);
        }

        private void btn_ConfirmAction_Click(object sender, EventArgs e)
        {
            if (!_combateService.Jugador.EstaViva) return;

            if (cbx_Habilidades.SelectedItem is Habilidad hab)
            {
                _combateService.EjecutarAccionJugador(hab.Id);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            IniciarCombate();
        }

        private void uC_BarraVidaJugador_Load(object sender, EventArgs e)
        {

        }
    }
}
