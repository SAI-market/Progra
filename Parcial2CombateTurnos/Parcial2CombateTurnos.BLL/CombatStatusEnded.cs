using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2CombateTurnos.Models;

namespace Parcial2CombateTurnos.BLL
{
    internal class CombatStatusEnded : StateofCombat
    {
        private readonly CombatService _ctx;
        private readonly Unidad _ganador;

        public CombatStatusEnded(CombatService ctx, Unidad ganador)
        {
            _ctx = ctx;
            _ganador = ganador;
        }

        public void Entrar()
        {
            var msg = _ganador == _ctx.Jugador ? "¡Has ganado el combate!" : "Has sido derrotado.";
            _ctx.PublicarLogInterno(msg);
            _ctx.OnCombateFinalizado_Invoke(_ganador);
        }

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