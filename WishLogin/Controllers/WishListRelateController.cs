using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Wish.DAL;
using Wish.Models;
using Microsoft.AspNetCore.Identity;
namespace Wish.Controllers
{
    public class WishListRelateController : Controller
    {
        private readonly WishContext _context;

        public WishListRelateController(WishContext context)
        {
            _context = context;
        }

        // GET: WishListRelate/5
        public async Task<IActionResult> Index(int? WishListId)
        {
            WishListId = 1;//WishListId should be user's wishList?
            var wishContext = _context.WishListRelateProduct
                .Include(w => w.Product)
                .Include(w => w.WishList)
                .Where(w => w.WishList.WishListId == WishListId)
                .OrderBy(w => w.Product.ProductName)
                .ThenByDescending(w => w.CreateTime);
            return View(await wishContext.ToListAsync());
        }


        // GET: WishListRelate/Create
        public IActionResult Create(int? WishListId)
        {
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "ProductName");
            ViewData["WishListId"] = new SelectList(_context.WishList, "WishListId", "WishListId"); ;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Descript,Url,WishListId,ProductId,CreateTime")] WishListRelateProduct wishListRelateProduct)
        {
            if (ModelState.IsValid)
            {
                wishListRelateProduct.CreateTime = DateTime.Now;
                _context.Add(wishListRelateProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { WishListId = wishListRelateProduct.WishListId });
            }
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId",
                "ProductId", wishListRelateProduct.ProductId);
            ViewData["WishListId"] = new SelectList(_context.WishList,
                "WishListId", "WishListId", wishListRelateProduct.WishListId);
            return View(wishListRelateProduct);
        }



        // GET: WishListRelate/Delete/5
        public async Task<IActionResult> Delete(int? RelateId)
        {
            if (RelateId == null)
            {
                return NotFound();
            }

            var wishListRelateProduct = await _context.WishListRelateProduct
                .Include(w => w.Product)
                .Include(w => w.WishList)
                .FirstOrDefaultAsync(m =>
                m.RelateId == RelateId);
            if (wishListRelateProduct == null)
            {
                return NotFound();
            }

            return View(wishListRelateProduct);
        }

        // POST: WishListRelate/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int RelateId)
        {
            var wishListRelateProduct = await _context.WishListRelateProduct
                .FindAsync(RelateId);
            _context.WishListRelateProduct.Remove(wishListRelateProduct);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index), new { WishListId = wishListRelateProduct.WishListId });
        }

        private bool WishListRelateProductExists(int id)
        {
            return _context.WishListRelateProduct.Any(e => e.WishListId == id);
        }
    }
}
