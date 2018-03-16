using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10LinqToSql
{
    [Table(Name = "Production.ProductSubCategory")]
    class ProductSubCategory
    {
        [Column(IsPrimaryKey = true)]
        public int ProductSubCategoryId { get; set; }

        [Column]
        public int ProductCategoryId { get; set; }

        [Column]
        public string Name { get; set; }

        [Column(Name = "rowguid")]
        public Guid SubCategoryGuid { get; set; }

        [Column]
        public DateTime ModifiedDate { get; set; }

        private EntityRef<ProductCategory> productCategory;

        [Association(Storage = "productCategory", ThisKey = "ProductCategoryId", IsForeignKey = true)]
        public ProductCategory ProductCategory
        {
            get { return productCategory.Entity; }
            set { productCategory.Entity = value; }
        }

        /* O atributo Association define que a propriedade abaixo dele corresponde a uma linha de outra tabela.
         * Ele possui os seguintes parâmetros:
         *      - Name: Define o nome utilizado para estabelecer o relacionamento.
         *      - Storage: Informa em qual variável, declarada na classe, será armazenado o valor vindo do banco de dados.
         *      - ThisKey: Informa em qual campo da tabela o valor da chave está armazenado.
         *      - OtherKey: Informa em qual variável, declarada na classe referenciada, está armazenado o valor da chave estrangeira.
         *      - IsForeignKey: Define se o campo passado em ThisKey é uma chave estrangeira.*/
    }
}
