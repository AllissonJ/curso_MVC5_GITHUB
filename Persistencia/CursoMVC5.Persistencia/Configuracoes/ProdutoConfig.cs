using CursoMVC5.Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoMVC5.Persistencia.Configuracoes
{
    class ProdutoConfig : EntityTypeConfiguration<Produto>
    {

        public ProdutoConfig()
        {
            ToTable("MVC_PRODUTO");
            HasKey(x => x.ID);

            Property(x => x.CategoriaID).HasColumnName("CATEGORIA_ID");
            Property(x => x.Nome).HasColumnName("PROD_NOME")
                                    .HasColumnType("VARCHAR")
                                    .HasMaxLength(50)
                                    .IsRequired();

            Property(x => x.Valor).HasColumnName("PROP_VALOR")
                                    .HasColumnType("DECIMAL")
                                    .HasPrecision(10, 2)
                                    .IsRequired();
        }

    }
}
