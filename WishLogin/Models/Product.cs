using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wish.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public String ProductName { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateTime { get; set; }
        [DataType(DataType.Date)]
        public DateTime UpdateTime { get; set; }

        public List<WishListRelateProduct> Relates { get; } = new List<WishListRelateProduct>();

        public Product()
        {
        }
    }
}
