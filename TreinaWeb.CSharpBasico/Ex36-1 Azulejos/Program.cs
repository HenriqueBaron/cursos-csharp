using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_1_Azulejos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas:");
            Console.Write("hp: ");
            double hp = double.Parse(Console.ReadLine());
            Console.Write("lp: ");
            double lp = double.Parse(Console.ReadLine());
            Console.Write("ha: ");
            double ha = double.Parse(Console.ReadLine());
            Console.Write("la: ");
            double la = double.Parse(Console.ReadLine());

            double areaAzulejo = ha * la;
            double areaParede = hp * lp;
            Console.WriteLine("A quantidade mínima de azulejos necessária será de {0}", Math.Ceiling(areaParede / areaAzulejo));
            Console.ReadKey();
        }
    }
}
