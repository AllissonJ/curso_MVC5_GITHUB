using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoMVC5.Persistencia.Entidades
{
    public class Pedido
    {
        public int ID { get; set; }
        public int ClienteID{ get; set; }
        public int Qtd { get; set; }
        public decimal ValorTotal { get; set; }
        /*public List<Pedido> Pedido { get; set; }*/
    }
}
