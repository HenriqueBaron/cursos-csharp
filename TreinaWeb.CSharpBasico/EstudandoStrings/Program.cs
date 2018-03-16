using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "ABC";
            string string2 = "DEF";
            StringBuilder sb = new StringBuilder();
            //Console.WriteLine(string1 + " " + string2 + " ghi");
            sb.Append(string1);
            sb.Append(" ");
            sb.Append(string2);
            sb.Append(" GHI");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
