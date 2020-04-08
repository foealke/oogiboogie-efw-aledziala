using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameworkPlayground
{
    [Table("Product")]
    class Product
    {
        [Column("ID")]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        [Column("UnitPrice")]
        public decimal Price { get; set; }
        [Column("UnitsInStock")]
        public short Stock { get; set; }
        public bool Discontinued { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
