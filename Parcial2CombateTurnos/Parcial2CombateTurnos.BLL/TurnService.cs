using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2CombateTurnos.BLL
{
    // Contenedor público para el enum de turnos.
    public static class TurnService
    {
        public enum Turno
        {
            Jugador,
            Enemigo
        }
    }
}