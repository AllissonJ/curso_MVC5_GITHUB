using CursoMVC5.Persistencia.Configuracoes;
using CursoMVC5.Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoMVC5.Persistencia
{
    public class Contexto : DbContext
    {   
        public Contexto() : base("CURSOMVC5")
        {
        }

        
        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Produto> Produtos { get; set; }
        public int PluralizingTableNameConvetion { get; private set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.
            Conventions.
            Remove
            <PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);

            modelBuilder.
                    Configurations.Add(new CategoriaConfig());

            modelBuilder.
                    Configurations.Add(new ProdutoConfig());
        }
    }
}
