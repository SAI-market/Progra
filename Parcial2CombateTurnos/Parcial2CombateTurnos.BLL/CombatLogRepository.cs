using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Parcial2CombateTurnos.BLL
{
    internal class CombatLogRepository
    {
        private readonly List<string> _log = new List<string>();

        public void GuardarLinea(string linea) => _log.Add(linea);

        public IReadOnlyList<string> ObtenerLog() => _log.AsReadOnly();

        public void Limpiar() => _log.Clear();
    }
}