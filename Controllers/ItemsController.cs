using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cafesito.Models;
using Microsoft.EntityFrameworkCore;

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
            var items = _context.Items.Include(i => i.Category).ToList();

            return View(items);
        }

        public IActionResult Details(int Id){
            var item = _context.Items.SingleOrDefault(i => i.Id == Id);

            if(item == null){
                return NotFound();
            }
            
            return View(item);
            
        }
    }
}