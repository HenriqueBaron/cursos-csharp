using System;
using System.Collections.Generic;

namespace CadastroPessoas.Repositorio
{
    public interface IRepositorio<T>
    {
        List<T> SelecionarTodos();
        void Adicionar(T item, Action<int> callback);
        List<T> Selecionar(Func<T, bool> whereClause);
    }
}
