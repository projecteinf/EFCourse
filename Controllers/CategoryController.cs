using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UdemyCourse.DataAccess;
using UdemyCourse.Model.Models;

namespace UdemyCourse.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> categories = _db.Categories.ToList();
            return View(categories);
        }
        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if (id == null) return View(category);
            else {
                category = _db.Categories.FirstOrDefault(c => c.Id == id);
                if (category == null) return NotFound();
                else return View(category);
            }
        }
    }
}
