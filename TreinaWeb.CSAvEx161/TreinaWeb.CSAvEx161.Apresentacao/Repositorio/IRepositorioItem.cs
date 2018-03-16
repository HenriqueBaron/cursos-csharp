using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinaWeb.CSAvEx161.Apresentacao.Repositorio
{
    /// <summary>
    /// Define um repositório genérico de itens, que define a interação para uma fonte de dados qualquer.
    /// </summary>
    interface IRepositorioItem
    {
        /// <summary>
        /// Retorna em uma lista todos os itens da base de dados, recebendo também uma Action a ser executada para cada item
        /// acrescentado à lista.
        /// </summary>
        /// <param name="callBack">Ação que deve ser executada ao adicionar um item.</param>
        /// <returns></returns>
        List<Item> SelecionarTodos(Action<Item> callBack);
    }
}
