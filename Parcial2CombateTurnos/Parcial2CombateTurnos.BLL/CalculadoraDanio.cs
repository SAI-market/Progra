using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2CombateTurnos.Models;

namespace Parcial2CombateTurnos.BLL
{
    // Clase estática para calcular daño de una habilidad.
    public static class CalculadoraDanio
    {
        // Generador de números aleatorios usado para determinar fallos.
        private static readonly Random rng = new Random();

        // Calculo simple del daño: si es magia puede fallar; si no, devuelve poder * multiplicador.
        public static int Calcular(Unidad atacante, Unidad defensor, Habilidad hab)
        {
            // Si es magia y el random indica fallo, devuelve 0.
            if (hab.EsMagia && rng.NextDouble() < hab.ChanceFallar)
                return 0; // falla

            // De lo contrario calcula daño base por multiplicador mágico y lo devuelve como entero.
            return (int)(hab.Poder * hab.MultiplicadorMagia);
        }
    }
}