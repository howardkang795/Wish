using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wish.Models
{
    public class WishList
    {
        [Key]
        public int WishListId { get; set; }
        public int Count { get; set; }


        [DataType(DataType.Date)]
        public DateTime CreateTime { get; set; }
        [DataType(DataType.Date)]
        public DateTime UpdateTime { get; set; }

        public List<WishListRelateProduct> Relates { get; } = new List<WishListRelateProduct>();

        public WishList()
        {
        }
    }
}
