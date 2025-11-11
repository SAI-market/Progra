using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2CombateTurnos.Models;

namespace Parcial2CombateTurnos.BLL
{
    // Estado que maneja el turno del jugador.
    internal class EstadoTurnoJugador : IEstadoCombate
    {
        private readonly CombateService _ctx;
        private static readonly Random _rng = new Random();

        public EstadoTurnoJugador(CombateService ctx) => _ctx = ctx;

        // Notifica que es turno del jugador.
        public void Entrar()
        {
            _ctx.PublicarLogInterno("Es turno del jugador.");
            _ctx.OnTurnoCambiado_Invoke(TurnService.Turno.Jugador);
        }

        // Ejecuta la acción del jugador: busca la habilidad, calcula fallo/daño y actualiza estados.
        public void EjecutarAccionJugador(int habilidadId)
        {
            var jugador = _ctx.Jugador;
            var enemigo = _ctx.Enemigo;

            var hab = jugador.Habilidades.FirstOrDefault(h => h.Id == habilidadId);
            if (hab == null)
            {
                _ctx.PublicarLogInterno("Habilidad no encontrada.");
                return;
            }

            // Probabilidad de fallo si la habilidad es mágica.
            if (hab.MultiplicadorMagia > 1.0 && _rng.NextDouble() < hab.ChanceFallar)
            {
                _ctx.PublicarLogInterno($"{jugador.Nombre} intenta {hab.Nombre} pero falla.");
            }
            else
            {
                int danio = (int)(hab.Poder * hab.MultiplicadorMagia);
                enemigo.VidaActual = Math.Max(0, enemigo.VidaActual - danio);
                _ctx.PublicarLogInterno($"{jugador.Nombre} usa {hab.Nombre} y hace {danio} de daño a {enemigo.Nombre}.");
            }

            // Informa cambios de vida.
            _ctx.OnVidaCambiada_Invoke(enemigo, false);
            _ctx.OnVidaCambiada_Invoke(jugador, true);

            // Si el enemigo muere, pasa a estado final, si no, turno IA.
            if (!enemigo.EstaViva)
            {
                _ctx.SetEstado(new EstadoCombateFinalizado(_ctx, jugador));
                return;
            }

            _ctx.SetEstado(new EstadoTurnoIA(_ctx));
        }

        // Si la IA intenta ejecutar en este estado, lo rechaza.
        public void EjecutarTurnoIA()
        {
            _ctx.PublicarLogInterno("No es turno de la IA.");
        }
    }
}