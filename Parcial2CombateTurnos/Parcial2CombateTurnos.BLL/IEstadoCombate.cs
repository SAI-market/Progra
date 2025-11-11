using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2CombateTurnos.Models;

namespace Parcial2CombateTurnos.BLL
{
    // Interfaz que define lo que espera cada estado del combate.
    public interface IEstadoCombate
    {
        // Ejecutado al entrar al estado
        void Entrar();

        // Ejecuta la acción del jugador (habilidad por id)
        void EjecutarAccionJugador(int habilidadId);

        // Ejecuta el turno de la IA.
        void EjecutarTurnoIA();
    }
}