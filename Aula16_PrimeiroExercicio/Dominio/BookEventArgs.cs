using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula16_PrimeiroExercicio.Dominio
{
    public class BookEventArgs: EventArgs
    {
        public Book book { get; set; }

        public BookEventArgs(Book book)
        {
            this.book = book;
        }
    }
}
