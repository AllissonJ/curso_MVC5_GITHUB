using CursoMVC5.Persistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoMVC5.Persistencia.Configuracoes
{
    class ItemPedidoConfig : EntityTypeConfiguration<ItemPedido>
    {
        public ItemPedidoConfig()
        {
            ToTable("MVC_ITEM_PEDIDO");
            HasKey(x => x.ID);

            Property(x => x.ID).HasColumnName("ITEM_PEDIDO_ID");
            Property(x => x.PedidoID).HasColumnName("PEDIDO_ID");
            Property(x => x.ProdutoID).HasColumnName("PRODUTO_QTD");
            Property(x => x.Valor).HasColumnName("PEDIDO_VALOR");
            Property(x => x.ItensPedidosQtd).HasColumnName("ITENS_PEDIDO_QTD");

        }
    }
}
