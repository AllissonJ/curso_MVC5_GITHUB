using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoMVC5.Persistencia.Entidades
{   
    public class Produto
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Por favor digite nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor digite Valor")]
        public Decimal Valor { get; set; }

        [Required(ErrorMessage = "Por favor Selecione")]
        public int CategoriaID { get; set; }

        public Categoria Categoria  { get; set; }
    }
}
