using Bike_Zone.DataDb;
using Bike_Zone.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bike_Zone.Controllers
{
    public class PurchasesController : Controller
    {
        private readonly majedDbContext _context;

        public PurchasesController(majedDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                IEnumerable<Purchase> purchases = _context.Purchases.ToList();
                return View(purchases);
            }
            catch (Exception ex)
            {
                return Content("تواصل معنا على رقم 0434837543");
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Purchase purchase)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(purchase);
                }

                _context.Purchases.Add(purchase);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content("تواصل معنا على رقم 0434837543");
            }
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var purchase = _context.Purchases.Find(Id);
            return View(purchase);
        }

        [HttpPost]
        public IActionResult Edit(Purchase purchase)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(purchase);
                }

                _context.Purchases.Update(purchase);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content("تواصل معنا على رقم 0434837543");
            }
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var purchase = _context.Purchases.Find(Id);
            return View(purchase);
        }

        [HttpPost]
        public IActionResult Delete(Purchase purchase)
        {
            try
            {
                _context.Purchases.Remove(purchase);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Content("تواصل معنا على رقم 0434837543");
            }
        }
    }
}
