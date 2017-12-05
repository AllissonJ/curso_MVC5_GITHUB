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
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<ItemPedido> ItemPedidos { get; set; }
        public int PluralizingTableNameConvetion { get; private set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.
            Conventions.
            Remove
            <PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
            //  Tipos para o banco de dados //
            modelBuilder.Properties<string>()
               .Configure(p => p.HasColumnType("varchar").HasMaxLength(100));

            modelBuilder.Properties<DateTime>()
              .Configure(p => p.HasColumnType("datetime"));

            modelBuilder.Properties<int>()
              .Configure(p => p.HasColumnType("int"));

            modelBuilder.Properties<decimal>()
              .Configure(p => p.HasColumnType("decimal").HasPrecision(10, 2));
            modelBuilder.
                    Configurations.Add(new CategoriaConfig());

            modelBuilder.
                    Configurations.Add(new ProdutoConfig());
            modelBuilder.
                    Configurations.Add(new PedidoConfig());
            modelBuilder.
                    Configurations.Add(new ItemPedidoConfig());
            modelBuilder.
                    Configurations.Add(new ClienteConfig());

        }
    }
}
