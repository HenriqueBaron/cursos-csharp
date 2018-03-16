using CadastroPessoa.Persistencia.NH.Maps;
using CadastroPessoas.Dominio;
using CadastroPessoas.Persistencia.EF;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CadastroPessoas.Repositorio
{
    public class PessoaRepositorio : IRepositorio<Pessoa>
    {
        /* Os métodos abaixo definem o acesso ao banco de dados com o NHibernate. Eles foram comentados
         * para dar lugar aos métodos que acessam o banco de dados através do Entity Framework.
         * 
        private NHibernate.ISessionFactory sessionFactory;

        /// <summary>
        /// Este construtor tem finalidade apenas no uso do NHibernate. Ele configura o acesso ao banco de dados e
        /// inicia a conexão, criando uma ISessionFactory.
        /// </summary>
        public PessoaRepositorio()
        {
            Configuration config = new Configuration();
            config.Configure();
            config.AddAssembly(typeof(Pessoa).Assembly);
            HbmMapping mapping = CreateMappings();
            config.AddDeserializedMapping(mapping, null);
            sessionFactory = config.BuildSessionFactory();
        }

        /// <summary>
        /// Cria um mapeamento para configurar o acesso ao banco de dados.
        /// </summary>
        /// <returns>HbmMapping é um mapeamento do NHibernate</returns>
        private HbmMapping CreateMappings()
        {
            ModelMapper mapper = new ModelMapper();
            mapper.AddMapping(typeof(PessoaMap));
            return mapper.CompileMappingForAllExplicitlyAddedEntities();
        }

        public List<Pessoa> SelecionarTodos()
        {
            using (ISession sessao = sessionFactory.OpenSession())
            {
                IQuery consulta = sessao.CreateQuery("FROM Pessoa");
                return consulta.List<Pessoa>().ToList();
            }
        }

        public int Adicionar(Pessoa item)
        {
            using (ISession sessao = sessionFactory.OpenSession())
            {
                using (var transacao = sessao.BeginTransaction())
                {
                    sessao.Save(item);
                    transacao.Commit();
                    return 0;
                }
            }
        }
        */

        /* Os métodos abaixo definem o acesso ao banco de dados com o Entity Framework. */
        public List<Pessoa> SelecionarTodos()
        {
            CadastroPessoasDbContext contexto = new CadastroPessoasDbContext(); // Cria a conexão com o banco de dados
            List<Pessoa> pessoas = contexto.Pessoas.AsParallel().AsOrdered().OrderBy(o => o.Nome).ToList(); // Obtém a lista de pessoas, ordenadas por nome
            contexto.Dispose(); // Destrói a referência de conexão com o banco de dados
            return pessoas;
        }

        public async void Adicionar(Pessoa item, Action<int> callBack)
        {
            CadastroPessoasDbContext contexto = new CadastroPessoasDbContext(); // Cria a conexão com o banco de dados
            contexto.Pessoas.Add(item); // Adiciona um item à tabela (à lista de pessoas)

            Thread.Sleep(1000); // Um atraso é criado intencionalmente para simular uma demora no acesso

            // Somente na chamada do método SaveChanges() é que as alterações são aplicadas na base de dados
            await contexto.SaveChangesAsync().ContinueWith((taskAnterior) =>
            {
                int linhasAfetadas = taskAnterior.Result;
                callBack(linhasAfetadas);
            });
        }

        public List<Pessoa> Selecionar(Func<Pessoa, bool> whereClause)
        {
            CadastroPessoasDbContext contexto = new CadastroPessoasDbContext(); // Cria a conexão com o banco de dados
            List<Pessoa> pessoas = contexto.Pessoas.AsParallel().Where(whereClause).ToList(); // Obtém a lista de pessoas, ordenadas por nome
            contexto.Dispose(); // Destrói a referência de conexão com o banco de dados
            return pessoas;
        }
    }
}
