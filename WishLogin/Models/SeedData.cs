using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Wish.DAL;
using System.Linq;
namespace Wish.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DAL.WishContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WishContext>>()))
            {

                if (context.WishList.Any())
                {
                    return;   // DB has been seeded
                }

                context.WishList.AddRange(
                    new WishList
                    {
                        WishListId = 1,
                        Count = 1,
                        CreateTime = new DateTime(),
                        UpdateTime = new DateTime()
                    }
                );
                context.Product.AddRange(
                    new Product
                    {
                        ProductId = 1,
                        ProductName = "4wd",
                        CreateTime = new DateTime(),
                        UpdateTime = new DateTime()
                    }
                );
                context.Product.AddRange(
                    new Product
                    {
                        ProductId = 2,
                        ProductName = "BackPack",
                        CreateTime = new DateTime(),
                        UpdateTime = new DateTime()
                    }
                );
                context.Product.AddRange(
                    new Product
                    {
                        ProductId = 3,
                        ProductName = "Comic",
                        CreateTime = new DateTime(),
                        UpdateTime = new DateTime()
                    }
                );
                context.Product.AddRange(
                    new Product
                    {
                        ProductId = 4,
                        ProductName = "Dumpling",
                        CreateTime = new DateTime(),
                        UpdateTime = new DateTime()
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
