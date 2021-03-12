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
            var items = _context.Items.ToList();

            return View(items);
        }
    }
}