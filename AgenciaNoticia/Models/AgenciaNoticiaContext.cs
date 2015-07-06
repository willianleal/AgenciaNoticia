using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AgenciaNoticia.Models
{
    public class AgenciaNoticiaContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
        
        public AgenciaNoticiaContext() : base("name=AgenciaNoticiaContext")
        {
        }

        public System.Data.Entity.DbSet<AgenciaNoticias.Models.Secao> Secaos { get; set; }

        public System.Data.Entity.DbSet<AgenciaNoticias.Models.Materia> Materias { get; set; }

        public System.Data.Entity.DbSet<AgenciaNoticias.Models.Pessoa> Pessoas { get; set; }

        public System.Data.Entity.DbSet<AgenciaNoticias.Models.Comentario> Comentarios { get; set; }
    
    }
}
