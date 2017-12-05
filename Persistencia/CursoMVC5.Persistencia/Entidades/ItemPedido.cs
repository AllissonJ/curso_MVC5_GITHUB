using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoMVC5.Persistencia.Entidades
{
    public class ItemPedido
    {
        public int ID { get; set; }

        public Produto Produto { get; set; }
        public int ProdutoID { get; set; }

        public virtual Pedido Pedido { get; set; }

        public int PedidoID { get; set; }
        public int ItensPedidosQtd { get; set; }
        public decimal Valor { get; set; }
        /*public List<ItemPedido> ItemPedido { get; set; }*/
    }
}
