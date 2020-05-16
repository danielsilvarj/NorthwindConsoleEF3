using Microsoft.EntityFrameworkCore;
using NorthwindConsoleEF3.Modelos;
using System;
using System.Linq;

namespace NorthwindConsoleEF3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConultarCategorias();
        }

        private static void ConultarCategorias()
        {
            var db = new NorthwindDb();

            IQueryable<Categoria> categorias = db.Categorias
                .Include(c => c.Produtos);

            foreach (var c in categorias)
            {
                Console.WriteLine($"{c.Nome} possui {c.Produtos.Count} produtos.");
                foreach (var p in c.Produtos)
                {
                    Console.WriteLine($"- {p.Nome} ({p.Estoque} unidades no estoque)");
                }
            }

        }
    }
}
