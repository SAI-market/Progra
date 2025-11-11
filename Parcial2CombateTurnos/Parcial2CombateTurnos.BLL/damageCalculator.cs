using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2CombateTurnos.Models;

namespace Parcial2CombateTurnos.BLL
{
    public static class damageCalculator
    {
        private static readonly Random rng = new Random();

        public static int Calcular(Unidad atacante, Unidad defensor, Habilidad hab)
        {
            if (hab.EsMagia && rng.NextDouble() < hab.ChanceFallar)
                return 0; // falla

            return (int)(hab.Poder * hab.MultiplicadorMagia);
        }
    }
}