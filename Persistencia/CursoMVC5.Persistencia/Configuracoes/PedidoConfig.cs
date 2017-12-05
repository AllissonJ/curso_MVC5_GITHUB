using CursoMVC5.Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoMVC5.Persistencia.Configuracoes
{
    class PedidoConfig : EntityTypeConfiguration<Pedido>
    {
        public PedidoConfig()
        {
            ToTable("MVC_PEDIDO");
                 HasKey(x => x.ID);

            Property(x => x.ID).HasColumnName("PEDIDO_ID");
            Property(x => x.ClienteID).HasColumnName("CLIENTE_ID");
            Property(x => x.Qtd).HasColumnName("PEDIDO_QTD");


            Property(x => x.ValorTotal).HasColumnName("VALOR_TOTAL");
                                
        }
    }
    
}
