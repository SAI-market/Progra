using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2CombateTurnos.BLL
{
    // EventArgs para notificar qué turno es
    public class TurnoEventArgs : EventArgs
    {
        public TurnService.Turno TurnoActual { get; }
        public TurnoEventArgs(TurnService.Turno turno) { TurnoActual = turno; }
    }
}