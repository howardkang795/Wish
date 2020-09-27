using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Wish.Models;
using WishLogin.Models;

namespace Wish.DAL
{
    public class WishContext : IdentityDbContext
    {


        public WishContext(DbContextOptions<WishContext> options) : base(options)
        {
        }

        public DbSet<WishList> WishList { get; set; }
        public DbSet<WishListRelateProduct> WishListRelateProduct { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<SharedUrl> SharedUrl { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<WishListRelateProduct>()
        //        .HasKey(c => new { c.WishListId, c.ProductId });
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<SharedUrl>()
            //    .HasKey(c => new { c.WishListId, c.ShortUrl });
        }
    }

}
