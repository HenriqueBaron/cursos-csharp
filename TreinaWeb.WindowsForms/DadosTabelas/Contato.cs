using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosTabelas
{
    public enum Sexo
    {
        Masculino,
        Feminino
    }

    public class Contato
    {
        public string Nome { get; set; }
        public Sexo Sexo { get; set; }
        [Browsable(false)] // Esta anotação torna a propriedade abaixo dela invisível no DataGridView.
        public DateTime DataNascimento { get; set; }

        public Contato(string nome, Sexo sexo, DateTime dataNascimento)
        {
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
        }
    }
}
