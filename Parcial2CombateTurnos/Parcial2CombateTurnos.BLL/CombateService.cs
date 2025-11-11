using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2CombateTurnos.Models;

namespace Parcial2CombateTurnos.BLL
{
    // Servicio que orquesta el combate y expone eventos para la UI.
    public class CombateService
    {
        private IEstadoCombate _estadoActual;

        // Entidades del combate, solo lectura
        public Unidad Jugador { get; private set; }
        public Unidad Enemigo { get; private set; }

        // Eventos que usa la UI para actualizar barras, logs y estado del turno.
        public event EventHandler<VidaEventArgs> OnVidaCambiada;
        public event EventHandler<string> OnTurnoRegistrado;
        public event EventHandler<CombateFinalizadoEventArgs> OnCombateFinalizado;
        public event EventHandler<TurnoEventArgs> OnTurnoCambiado;

        // Ayudante público para publicar logs rápido.
        public Action<string> PublicarLog => (texto) => OnTurnoRegistrado?.Invoke(this, texto);

        public CombateService() { }

        // Inicializa el combate con dos unidades.
        public void IniciarCombate(Unidad jugador, Unidad enemigo)
        {
            Jugador = jugador ?? throw new ArgumentNullException(nameof(jugador));
            Enemigo = enemigo ?? throw new ArgumentNullException(nameof(enemigo));

            // Emite las vidas iniciales para que la UI las muestre.
            OnVidaCambiada?.Invoke(this, new VidaEventArgs(Jugador, true));
            OnVidaCambiada?.Invoke(this, new VidaEventArgs(Enemigo, false));

            // Comienza con el turno del jugador.
            SetEstado(new EstadoTurnoJugador(this));
        }

        // Cambio de estado interno (patrón State).
        internal void SetEstado(IEstadoCombate nuevoEstado)
        {
            _estadoActual = nuevoEstado ?? throw new ArgumentNullException(nameof(nuevoEstado));
            _estadoActual.Entrar();
        }

        // Métodos públicos usados por la UI para disparar acciones.
        public void EjecutarAccionJugador(int habilidadId) => _estadoActual?.EjecutarAccionJugador(habilidadId);
        public void EjecutarTurnoIA() => _estadoActual?.EjecutarTurnoIA();

        // Métodos internos para que los estados invoquen los eventos correctamente.
        internal void OnVidaCambiada_Invoke(Unidad unidad, bool esJugador) => OnVidaCambiada?.Invoke(this, new VidaEventArgs(unidad, esJugador));
        internal void OnCombateFinalizado_Invoke(Unidad ganador) => OnCombateFinalizado?.Invoke(this, new CombateFinalizadoEventArgs(ganador));
        internal void OnTurnoCambiado_Invoke(TurnService.Turno turno) => OnTurnoCambiado?.Invoke(this, new TurnoEventArgs(turno));

        // Helper interno para que los estados publiquen logs
        internal void PublicarLogInterno(string texto) => OnTurnoRegistrado?.Invoke(this, texto);
    }
}