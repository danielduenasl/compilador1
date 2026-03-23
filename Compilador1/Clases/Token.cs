using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador1.Clases
{
    public class Token
    {
        public string Lexema { get; set; }
        public string Tipo { get; set; }

        public Token(string lexema, string tipo)
        {
            Lexema = lexema;
            Tipo = tipo;
        }
    }
}
