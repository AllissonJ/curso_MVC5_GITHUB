using CursoMVC5.Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoMVC5.Persistencia.Configuracoes
{
    class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            ToTable("MVC_CLIENTE");
            HasKey(x => x.ID);

            Property(x => x.ID).HasColumnName("Cliente_ID");
            Property(x => x.Nome).HasColumnName("CLIENTE_NOME")
                                    .HasColumnType("VARCHAR");

            Property(x => x.CPF).HasColumnName("CLIENTE_CPF")
                                    .HasColumnType("VARCHAR");
                                   
        }
    }
    
}
