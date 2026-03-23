using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Compilador1.Clases
{
    public class Lexico
    {
        ConfigManager config;

        public Lexico(ConfigManager cfg)
        {
            config = cfg;
        }

        public List<Token> Analizar(string texto, List<string> errores)
        {
            List<Token> tokens = new List<Token>();

            string[] partes = texto.Split(' ');

            foreach (string p in partes)
            {
                if (config.Reservadas.Contains(p))
                {
                    tokens.Add(new Token(p, "Palabra Reservada"));
                }
                else if (config.Operadores.Contains(p))
                {
                    tokens.Add(new Token(p, "Operador"));
                }
                else if (config.Delimitadores.Contains(p))
                {
                    tokens.Add(new Token(p, "Delimitador"));
                }
                else if (Regex.IsMatch(p, @"^[a-zA-Z][a-zA-Z0-9]*$"))
                {
                    tokens.Add(new Token(p, "Identificador"));
                }
                else if (Regex.IsMatch(p, @"^[0-9]+$"))
                {
                    tokens.Add(new Token(p, "Numero"));
                }
                else
                {
                    errores.Add("Token no reconocido: " + p);
                }
            }

            return tokens;
        }
    }
}
