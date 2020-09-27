using System;
using System.ComponentModel.DataAnnotations;
using Wish.Models;

namespace WishLogin.Models
{
    public class SharedUrl
    {
        public SharedUrl()
        {
        }

        [Key]
        public String ShortUrl { get; set; }

        public int WishListId { get; set; }
        public WishList WishList { get; set; }
    }
}
