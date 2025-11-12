using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2CombateTurnos.Models;

namespace Parcial2CombateTurnos.BLL
{
    public class CombatService
    {
        private StateofCombat _estadoActual;

        public Unidad Jugador { get; private set; }
        public Unidad Enemigo { get; private set; }

        public event EventHandler<VidaEventArgs> OnVidaCambiada;
        public event EventHandler<string> OnTurnoRegistrado;
        public event EventHandler<CombatEndedEventArgs> OnCombateFinalizado;
        public event EventHandler<TurnEventArgs> OnTurnoCambiado;

        public Action<string> PublicarLog => (texto) => OnTurnoRegistrado?.Invoke(this, texto);

        public CombatService() { }

        public void IniciarCombate(Unidad jugador, Unidad enemigo)
        {
            Jugador = jugador ?? throw new ArgumentNullException(nameof(jugador));
            Enemigo = enemigo ?? throw new ArgumentNullException(nameof(enemigo));

            OnVidaCambiada?.Invoke(this, new VidaEventArgs(Jugador, true));
            OnVidaCambiada?.Invoke(this, new VidaEventArgs(Enemigo, false));

            SetEstado(new StateTurnPlayer(this));
        }

        internal void SetEstado(StateofCombat nuevoEstado)
        {
            _estadoActual = nuevoEstado ?? throw new ArgumentNullException(nameof(nuevoEstado));
            _estadoActual.Entrar();
        }

        public void EjecutarAccionJugador(int habilidadId) => _estadoActual?.EjecutarAccionJugador(habilidadId);
        public void EjecutarTurnoIA() => _estadoActual?.EjecutarTurnoIA();

        internal void OnVidaCambiada_Invoke(Unidad unidad, bool esJugador) => OnVidaCambiada?.Invoke(this, new VidaEventArgs(unidad, esJugador));
        internal void OnCombateFinalizado_Invoke(Unidad ganador) => OnCombateFinalizado?.Invoke(this, new CombatEndedEventArgs(ganador));
        internal void OnTurnoCambiado_Invoke(TurnService.Turno turno) => OnTurnoCambiado?.Invoke(this, new TurnEventArgs(turno));

        internal void PublicarLogInterno(string texto) => OnTurnoRegistrado?.Invoke(this, texto);
    }
}