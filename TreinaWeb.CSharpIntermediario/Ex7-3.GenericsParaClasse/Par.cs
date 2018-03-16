using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_3.GenericsParaClasse
{
    public class Par<T,U>
    {
        public T Var1 { get; set; }
        public U Var2 { get; set; }

        public Par(T var1, U var2)
        {
            this.Var1 = var1;
            this.Var2 = var2;
        }

        public override String ToString()
        {
            return "(" + Var1 + ", " + Var2 + ")";
        }
    }
}
