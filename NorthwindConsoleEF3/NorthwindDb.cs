using Microsoft.EntityFrameworkCore;
using NorthwindConsoleEF3.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindConsoleEF3
{
    public class NorthwindDb : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {

            //var connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var connectionString = "Server=(localdb)\\MSSQLLocalDB; Database=NorthwindEF3;TrustServerCertificate=true;MultiSubnetFailover=true;";

            optionsBuilder.UseSqlServer(connectionString);
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(categoria => categoria.Nome)
                .IsRequired();
        }
    }
}
