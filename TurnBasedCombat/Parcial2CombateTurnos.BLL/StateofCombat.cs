using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2CombateTurnos.Models;

namespace Parcial2CombateTurnos.BLL
{
    public interface StateofCombat
    {
        void Entrar();

        void EjecutarAccionJugador(int habilidadId);

        void EjecutarTurnoIA();
    }
}