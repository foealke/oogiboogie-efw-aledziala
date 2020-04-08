using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameworkPlayground
{
    class Northwind : DbContext
    {
        // Zbiorek 1: Categories
        public DbSet<Category> Categories { get; set; }
        // Zbiorek 2: Products
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            string path = System.IO.Path.Combine(Environment.CurrentDirectory, "northwind.sqlite");

            optionsBuilder.UseSqlite($"Filename={path}");

        }
    }
}
