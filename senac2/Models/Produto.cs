using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace senac2.Models
{
    public class Produto : EntityBase
    {
        public string Nome {get; set;}
        public decimal Preco {get;set;}
        public int Quantidade {get;set;}
        //entidades
        public virtual TipoProduto TipoProduto {get;set;}
        public virtual Marca Marca {get;set;}
        //virtual override - Entity

        [ForeignKey("MarcaId")]
        public int MarcaId { get; set; }
        [ForeignKey("TipoProdutoId")]
        public int TipoProdutoId { get; set; }

    }
}
