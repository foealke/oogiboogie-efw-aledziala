using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EntityFrameworkPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Northwind())
            {
                IQueryable<Category> cats = db.Categories
                .Include(c => c.Products);
                foreach (var cat in cats)
                {
                    Console.WriteLine($"{cat.CategoryName} : {cat.Products.Count}");
                }
            }
        }
    }
}
