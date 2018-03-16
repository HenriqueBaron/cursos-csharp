namespace MySqlEntityApp
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class TreinaWebMySqlModel : DbContext
    {
        // Your context has been configured to use a 'TreinaWebMySqlModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MySqlEntityApp.TreinaWebMySqlModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TreinaWebMySqlModel' 
        // connection string in the application configuration file.
        public TreinaWebMySqlModel()
            : base("name=TreinaWebMySqlModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Curso> Cursos { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    public class Curso
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}