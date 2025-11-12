using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2CombateTurnos.Models;

namespace Parcial2CombateTurnos.BLL
{
    internal class StateTurnPlayer : StateofCombat
    {
        private readonly CombatService _ctx;

        public StateTurnPlayer(CombatService ctx) => _ctx = ctx;

        public void Entrar()
        {
            _ctx.PublicarLogInterno("Es turno del jugador.");
            _ctx.OnTurnoCambiado_Invoke(TurnService.Turno.Jugador);
        }

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


            int danio = damageCalculator.Calcular(jugador, enemigo, hab);

            if (danio == 0 && hab.EsMagia)
            {
                _ctx.PublicarLogInterno($"{jugador.Nombre} intenta {hab.Nombre} pero falla.");
            }
            else
            {
                enemigo.VidaActual = Math.Max(0, enemigo.VidaActual - danio);
                _ctx.PublicarLogInterno($"{jugador.Nombre} usa {hab.Nombre} y hace {danio} de daño a {enemigo.Nombre}.");
            }



            _ctx.OnVidaCambiada_Invoke(enemigo, false);
            _ctx.OnVidaCambiada_Invoke(jugador, true);

            if (!enemigo.EstaViva)
            {
                _ctx.SetEstado(new CombatStatusEnded(_ctx, jugador));
                return;
            }

            _ctx.SetEstado(new IAShiftState(_ctx));
        }

        public void EjecutarTurnoIA()
        {
            _ctx.PublicarLogInterno("No es turno de la IA.");
        }
    }
}