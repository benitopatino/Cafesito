using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cafesito.Models;

namespace Cafesito.Controllers
{
    public class ItemsController : Controller
    {
        private BloggingContext _context;

        public ItemsController()
        {
            _context = new BloggingContext();
        }
        public IActionResult Index()
        {
            var fake = new Item(){
                Id = 1,
                Name = "Coffee"
            };

            _context.Add(fake);
            _context.SaveChanges();

            return View(fake);
        }
    }
}