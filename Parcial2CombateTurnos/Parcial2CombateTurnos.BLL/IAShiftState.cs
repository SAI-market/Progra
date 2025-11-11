using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2CombateTurnos.Models;

namespace Parcial2CombateTurnos.BLL
{
    internal class IAShiftState : StateofCombat
    {
        private readonly CombatService _ctx;

        private static readonly Random _rngSelectorHabilidad = new Random();

        public IAShiftState(CombatService ctx) => _ctx = ctx;

        public void Entrar()
        {
            _ctx.PublicarLogInterno("Es turno de la IA.");
            _ctx.OnTurnoCambiado_Invoke(TurnService.Turno.Enemigo);
            EjecutarTurnoIA();
        }

        public void EjecutarAccionJugador(int habilidadId)
        {
            _ctx.PublicarLogInterno("No es turno del jugador.");
        }

        public void EjecutarTurnoIA()
        {
            var ia = _ctx.Enemigo;
            var jugador = _ctx.Jugador;

            var hab = ia.Habilidades[_rngSelectorHabilidad.Next(ia.Habilidades.Count)];


            int danio = damageCalculator.Calcular(ia, jugador, hab);

            if (danio == 0 && hab.EsMagia)
            {
                _ctx.PublicarLogInterno($"{ia.Nombre} intenta {hab.Nombre} pero falla.");
            }
            else
            {
                jugador.VidaActual = Math.Max(0, jugador.VidaActual - danio);
                _ctx.PublicarLogInterno($"{ia.Nombre} usa {hab.Nombre} y hace {danio} de daño a {jugador.Nombre}.");
            }



            _ctx.OnVidaCambiada_Invoke(jugador, true);
            _ctx.OnVidaCambiada_Invoke(ia, false);

            if (!jugador.EstaViva)
            {
                _ctx.SetEstado(new CombatStatusEnded(_ctx, ia));
                return;
            }

            _ctx.SetEstado(new StateTurnPlayer(_ctx));
        }
    }
}