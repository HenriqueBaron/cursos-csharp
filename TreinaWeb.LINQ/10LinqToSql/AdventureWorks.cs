using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10LinqToSql
{
    class AdventureWorks : DataContext
    {
        public AdventureWorks(string connection) : base(connection) { }

        public Table<ProductCategory> ProductCategories { get { return GetTable<ProductCategory>(); } }

        public Table<ProductSubCategory> ProductSubCategories { get { return GetTable<ProductSubCategory>(); } }
    }
}
