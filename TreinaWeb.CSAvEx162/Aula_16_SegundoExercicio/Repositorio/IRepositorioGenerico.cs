using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_16_SegundoExercicio.Repositorio
{
    interface IRepositorioGenerico<T>
    {
        List<T> GetDados();
        T GetById(int id);
        void Inserir(T entidade);
        void Atualizar(T entidade);
        void Excluir(T entidade);
    }
}
