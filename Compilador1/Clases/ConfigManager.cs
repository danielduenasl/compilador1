using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador1.Clases
{
    public class ConfigManager
    {
        public List<string> Reservadas { get; set; }
        public List<string> Operadores { get; set; }
        public List<string> Delimitadores { get; set; }

        private string rutaReservadas;
        private string rutaOperadores;
        private string rutaDelimitadores;

        public ConfigManager()
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;

            rutaReservadas = Path.Combine(baseDir, "Config", "reservadas.txt");
            rutaOperadores = Path.Combine(baseDir, "Config", "operadores.txt");
            rutaDelimitadores = Path.Combine(baseDir, "Config", "delimitadores.txt");

            Reservadas = new List<string>(File.ReadAllLines(rutaReservadas));
            Operadores = new List<string>(File.ReadAllLines(rutaOperadores));
            Delimitadores = new List<string>(File.ReadAllLines(rutaDelimitadores));
        }

        public void GuardarReservadas()
        {
            File.WriteAllLines(rutaReservadas, Reservadas);
        }

        public void GuardarDelimitadores()
        {
            File.WriteAllLines(rutaDelimitadores, Delimitadores);
        }
    }
}
