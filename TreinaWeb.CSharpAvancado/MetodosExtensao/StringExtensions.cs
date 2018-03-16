using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodosExtensao.Extensoes
{
    public static class StringExtensions
    {
        public static string InverterCaixas(this string parametro, bool estadoInicial)
        {
            bool isUpperCase = estadoInicial;
            string resultado = "";
            for (int i = 0; i < parametro.Length; i++)
            {
                resultado += isUpperCase ? parametro[i].ToString().ToUpper() : parametro[i].ToString().ToLower();
                isUpperCase = !isUpperCase;
            }
            return resultado;
        }
    }
}
