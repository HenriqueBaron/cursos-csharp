using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingCollectionApp
{
    public class Pessoa : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public enum PessoaSexo { Masculino, Feminino };
        private int id;
        private string nome;
        private string email;
        private PessoaSexo sexo;

        public int Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Nome
        {
            get => nome;
            set
            {
                nome = value;
                OnPropertyChanged("Nome");
            }
        }
        public string Email
        {
            get => email;
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }
        public PessoaSexo Sexo
        {
            get => sexo;
            set
            {
                sexo = value;
                OnPropertyChanged("Sexo");
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
