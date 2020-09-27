using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wish.Models
{
    public class WishListRelateProduct
    {
        public WishListRelateProduct()
        {
        }

        public string Descript { get; set; }
        public string Url { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        public DateTime CreateTime { get; set; }
        [DataType(DataType.Date)]
        public DateTime UpdateTime { get; set; }

        [Key]
        public int RelateId { get; set; }

        public int WishListId { get; set; }
        public WishList WishList { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
}
}
