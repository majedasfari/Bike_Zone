using Bike_Zone.DataDb;
using Bike_Zone.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Bike_Zone.Controllers
{
    public class PurchaseItemsController : Controller
    {
        private readonly majedDbContext _context;

        public PurchaseItemsController(majedDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            try
            {
                IEnumerable<PurchaseItem> data = _context.PurchaseItems.Include(c => c.Purchase).ToList();
                return View(data);
            }
            catch (Exception ex)
            {
                return Content("تواصل معنا على رقم 0509164022");
            }
        }

        private void createlist()
        {
            IEnumerable<Purchase> purchases = _context.Purchases.ToList();
            SelectList selectListItems = new SelectList(purchases, "Id", "BuyerName");
            ViewBag.purchases = selectListItems;
        }

        [HttpGet]
        public IActionResult Create()
        {
            createlist();
            return View();
        }

        [HttpPost]
        public IActionResult Create(PurchaseItem purchaseItem)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(purchaseItem);
                }

                _context.PurchaseItems.Add(purchaseItem);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content("تواصل معنا على رقم 0509164022");
            }
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var purchaseItem = _context.PurchaseItems.Find(Id);
            createlist();
            return View(purchaseItem);
        }

        [HttpPost]
        public IActionResult Edit(PurchaseItem purchaseItem)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(purchaseItem);
                }

                _context.PurchaseItems.Update(purchaseItem);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content("تواصل معنا على رقم 0509164022");
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var product = _context.PurchaseItems.Find(Id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(PurchaseItem purchaseItem)
        {
            try
            {
                _context.PurchaseItems.Remove(purchaseItem);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content("تواصل معنا على رقم 0509164022");
            }
        }
    }
}
