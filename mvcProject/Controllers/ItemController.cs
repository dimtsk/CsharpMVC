using Microsoft.AspNetCore.Mvc;
using mvcProject.Data;
using mvcProject.Models;
using System.Collections;
using System.Collections.Generic;

namespace mvcProject.Controllers
{
    public class ItemController : Controller
    {
        /*
         * DI
         */
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;
            return View(objList);
        }
        //GET METHOD
        public IActionResult Create()
        {            
            return View();
        }
        //POST METHOD
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj)
        {  
            _db.Items.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
