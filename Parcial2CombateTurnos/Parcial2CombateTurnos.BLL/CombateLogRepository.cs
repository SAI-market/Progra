using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Parcial2CombateTurnos.BLL
{
    // Repsitorio interno para mantener el log en memoria.
    internal class CombateLogRepository
    {
        private readonly List<string> _log = new List<string>();

        // Agrega una línea al log.
        public void GuardarLinea(string linea) => _log.Add(linea);

        // Devuelve el log como lectura sólo.
        public IReadOnlyList<string> ObtenerLog() => _log.AsReadOnly();

        // Limpia todo el historial.
        public void Limpiar() => _log.Clear();
    }
}