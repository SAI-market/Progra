using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2CombateTurnos.Models;

namespace Parcial2CombateTurnos.BLL
{
    // Estado que maneja el turno de la IA
    internal class EstadoTurnoIA : IEstadoCombate
    {
        private readonly CombateService _ctx;
        private static readonly Random _rng = new Random();

        public EstadoTurnoIA(CombateService ctx) => _ctx = ctx;

        // Notifica que es turno de la IA y ejecuto su acción.
        public void Entrar()
        {
            _ctx.PublicarLogInterno("Es turno de la IA.");
            _ctx.OnTurnoCambiado_Invoke(TurnService.Turno.Enemigo);
            EjecutarTurnoIA();
        }

        // Si el jugador intenta actuar en este estado, lo rechaza.
        public void EjecutarAccionJugador(int habilidadId)
        {
            _ctx.PublicarLogInterno("No es turno del jugador.");
        }

        // IA elige una habilidad al azar, calcula daño y actualiza vidas/events.
        public void EjecutarTurnoIA()
        {
            var ia = _ctx.Enemigo;
            var jugador = _ctx.Jugador;

            // Elije habilidad
            var hab = ia.Habilidades[_rng.Next(ia.Habilidades.Count)];

            // Si es magia y falla, lo registra; si no, aplica daño.
            if (hab.MultiplicadorMagia > 1.0 && _rng.NextDouble() < hab.ChanceFallar)
            {
                _ctx.PublicarLogInterno($"{ia.Nombre} intenta {hab.Nombre} pero falla.");
            }
            else
            {
                int danio = (int)(hab.Poder * hab.MultiplicadorMagia);
                jugador.VidaActual = Math.Max(0, jugador.VidaActual - danio);
                _ctx.PublicarLogInterno($"{ia.Nombre} usa {hab.Nombre} y hace {danio} de daño a {jugador.Nombre}.");
            }

            // Actualiza UI
            _ctx.OnVidaCambiada_Invoke(jugador, true);
            _ctx.OnVidaCambiada_Invoke(ia, false);

            // Si el jugador muere, pasa al estado final; si no, da el turno al jugador.
            if (!jugador.EstaViva)
            {
                _ctx.SetEstado(new EstadoCombateFinalizado(_ctx, ia));
                return;
            }

            _ctx.SetEstado(new EstadoTurnoJugador(_ctx));
        }
    }
}