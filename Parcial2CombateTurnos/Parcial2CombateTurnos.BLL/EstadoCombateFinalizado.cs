using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2CombateTurnos.Models;

namespace Parcial2CombateTurnos.BLL
{
    // Estado que representa que el combate terminó.
    internal class EstadoCombateFinalizado : IEstadoCombate
    {
        private readonly CombateService _ctx;
        private readonly Unidad _ganador;

        public EstadoCombateFinalizado(CombateService ctx, Unidad ganador)
        {
            _ctx = ctx;
            _ganador = ganador;
        }

        // Al entrar, publica el mensaje final y dispara el evento de combate finalizado.
        public void Entrar()
        {
            var msg = _ganador == _ctx.Jugador ? "¡Has ganado el combate!" : "Has sido derrotado.";
            _ctx.PublicarLogInterno(msg);
            _ctx.OnCombateFinalizado_Invoke(_ganador);
        }

        // Si alguien intenta actuar, informa que ya terminó.
        public void EjecutarAccionJugador(int habilidadId)
        {
            _ctx.PublicarLogInterno("El combate ya finalizó.");
        }

        public void EjecutarTurnoIA()
        {
            _ctx.PublicarLogInterno("El combate ya finalizó.");
        }
    }
}