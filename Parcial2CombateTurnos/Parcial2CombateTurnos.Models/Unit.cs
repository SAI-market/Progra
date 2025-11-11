using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Parcial2CombateTurnos.Models
{
    public class Unidad
    {
        public string Nombre { get; set; }
        public int VidaMax { get; set; }
        public int VidaActual { get; set; }
        public List<Habilidad> Habilidades { get; set; } = new List<Habilidad>();

        // Chequeo rápido si está viva.
        public bool EstaViva => VidaActual > 0;
    }
}