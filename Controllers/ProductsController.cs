using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryApp.Data;
using DeliveryApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace DeliveryApp.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    public class ProductsController : Controller
    {
        private ApplicationDbContext _context;
        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public ActionResult Confirmed()
        {
            return View();
        }
        public ActionResult Entry()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EntryData(Product product, string type, string foodname, string price, int quantity, string description)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }
            Product oProduct = new Product()
            {
                Type = type,
                FoodName = foodname,
                Price = price,
                Quantity = quantity,
                Description = description
            };
            _context.Products.Add(oProduct);
            _context.SaveChanges();

            return View("Confirmed");
        }
    }
}
