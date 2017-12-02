using CursoMVC5.Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoMVC5.Persistencia.Configuracoes
{
    class CategoriaConfig : EntityTypeConfiguration<Categoria>
    {

        public CategoriaConfig()
        {
            ToTable("MVC_CATEGORIA");
            HasKey(x => x.ID);

            Property(x => x.ID).HasColumnName("CATG_ID");
            Property(x => x.Nome).HasColumnName("CATG_NOME")
                                    .HasColumnType("VARCHAR")
                                    .HasMaxLength(50)
                                    .IsRequired();
            
        }

    }
}
