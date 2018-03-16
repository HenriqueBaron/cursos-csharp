using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.CSAvEx162.Repos.Comum
{
    public interface IRepositorio<TDominio>
    {
        Task<List<TDominio>> SelecionarTodos();
        TDominio SelecionarPorId(int id);
        void Inserir(TDominio entidade);
        void Atualizar(TDominio entidade);
        void Excluir(TDominio entidade);
    }
}
