using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2CombateTurnos.BLL
{
    public class TurnEventArgs : EventArgs
    {
        public TurnService.Turno TurnoActual { get; }
        public TurnEventArgs(TurnService.Turno turno) { TurnoActual = turno; }
    }
}