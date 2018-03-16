using CadastroPessoas.Dominio;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa.Persistencia.NH.Maps
{
    public class PessoaMap : ClassMapping<Pessoa>
    {
        /// <summary>
        /// Cria um mapeamento que cria um objeto no banco de dados, atribuindo uma propriedade do POCO como chave
        /// primária do banco, e os outros como propriedades.
        /// </summary>
        public PessoaMap()
        {
            Table("Pessoas");
            Id(pk => pk.Id, (map) => { map.Generator(Generators.Identity); });
            Property(p => p.Nome);
            Property(p => p.Idade);
            Property(p => p.Endereco);
        }
    }
}
