using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6LinqToObjects
{
    class Cliente
    {
        public enum SexoEnum { Masculino, Feminino };

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public SexoEnum Sexo { get; set; }
        public string Email { get; set; }
    }
}
