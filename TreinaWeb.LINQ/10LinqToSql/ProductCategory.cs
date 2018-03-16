using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10LinqToSql
{
    [Table(Name = "Production.ProductCategory")]
    class ProductCategory
    {
        [Column(IsPrimaryKey = true)]
        public int ProductCategoryId { get; set; }

        [Column]
        public string Name { get; set; }

        [Column(Name = "rowguid")]
        public Guid CategoryGuid { get; set; }

        [Column]
        public DateTime ModifiedDate { get; set; }

        [Association(OtherKey = "ProductCategoryId")]
        public EntitySet<ProductSubCategory> ProductSubCategories { get; set; }

        /* O atributo Table tem apenas o parâmetro Name, que foi definido logo acima do nome da classe.
         * Já o atributo Column, além do parâmetro Name, possui os seguintes:
         *      - Storage: Informa em qual variável, declarada na classe, será armazenado o valor que vem do banco de dados
         *      - AutoSync: Define se o valor será automaticamente sincronizado com o valor gerado pelo banco de dados em
         *                  um comando INSERT ou UPDATE. É do tipo enumerado AutoSync, que tem os valores Always, Never,
         *                  OnInsert e OnUpdate
         *      - DbType: Mapeia o tipo de dados definido na coluna do banco de dados
         *      - IsPrimary Key: Informa se a coluna é chave primária da tabela
         *      - IsDbGenerated: Informa se o valor da coluna é gerado automaticamente pelo banco de dados
         *      - CanBeNull: corresponde ao oposto da propriedade NOT NULL da definição da coluna da tabela no SQL */
    }
}
