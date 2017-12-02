using System.Collections.Generic;

namespace CursoMVC5.Persistencia.Entidades
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}