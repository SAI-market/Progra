using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2CombateTurnos.Models;

namespace Parcial2CombateTurnos.BLL
{
    public class CombatEndedEventArgs : EventArgs
    {
        public Unidad Ganador { get; }
        public CombatEndedEventArgs(Unidad ganador) { Ganador = ganador; }
    }
}