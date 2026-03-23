using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Compilador1.Clases
{
    public class ErrorManager
    {
        private Dictionary<string, string> errores = new Dictionary<string, string>();

        public ErrorManager(string ruta)
        {
            foreach (var linea in File.ReadAllLines(ruta))
            {
                var partes = linea.Split('|');
                errores.Add(partes[0], partes[1]);
            }
        }

        public string GetError(string codigo)
        {
            if (errores.ContainsKey(codigo))
                return errores[codigo];

            return "Error desconocido";
        }
    }
}
