using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2CombateTurnos.Models;

namespace Parcial2CombateTurnos.BLL
{
    // Evento simple que lleva cuando el combate termina.
    public class CombateFinalizadoEventArgs : EventArgs
    {
        public Unidad Ganador { get; }
        public CombateFinalizadoEventArgs(Unidad ganador) { Ganador = ganador; }
    }
}