using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NorthwindConsoleEF3.Modelos
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        
        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        public string Nome { get; set; }

        [Column("PrecoUnitario", TypeName ="money")]
        public decimal? Preco { get; set; }

        [Column("UnidadeEstoque")]
        public short? Estoque { get; set; }

        public bool Descontinuado { get; set; }

        public int CategoriaId { get; set; }

        public virtual Categoria Categoria { get; set; }

    }
}
