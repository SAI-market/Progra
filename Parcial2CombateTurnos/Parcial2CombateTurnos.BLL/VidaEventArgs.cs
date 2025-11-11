using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2CombateTurnos.Models;


namespace Parcial2CombateTurnos.BLL
{
    // Evento para enviar info de vida a la UI.
    public class VidaEventArgs : EventArgs
    {
        public Unidad Unidad { get; }
        public bool EsJugador { get; }

        public VidaEventArgs(Unidad unidad, bool esJugador)
        {
            Unidad = unidad;
            EsJugador = esJugador;
        }
    }

}