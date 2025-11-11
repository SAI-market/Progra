using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2CombateTurnos.Models
{
    public class Habilidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Poder { get; set; }
        public double MultiplicadorMagia { get; set; } = 1;
        public double ChanceFallar { get; set; } = 0;
        // Propiedad para saber si es magia
        public bool EsMagia => MultiplicadorMagia > 1 || ChanceFallar > 0;
        public override string ToString() => Nombre;
    }

}