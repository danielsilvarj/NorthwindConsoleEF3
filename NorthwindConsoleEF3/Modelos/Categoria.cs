using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NorthwindConsoleEF3.Modelos
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        
        [Column(TypeName ="VARCHAR(255)")]
        
        public string Nome { get; set; }
        
        [Column(TypeName = "VARCHAR(255)")]
        public string Descricao { get; set; }

        public virtual ICollection<Produto> Produtos { get; set; }

        public Categoria()
        {
            this.Produtos = new List<Produto>();
        }
    }
}
