
using GorevYoneticisi.Data;
using GorevYoneticisi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace GorevYoneticisi.Controllers
{
    public class GorevController : Controller
    {

        private readonly ApplicationDbContext _db;

        public GorevController(ApplicationDbContext db)
        {
            _db = db;

        }

        public IActionResult Index()
        {
            IEnumerable<Gorev> objList = _db.Gorev;
            
            return View(objList);
        }

        //get for create
        public IActionResult Create()
        {
            
            return View();
        }


        //post for create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Gorev obj)
        {
            if (ModelState.IsValid)
            {
                _db.Gorev.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        //get for edit
        public IActionResult Edit(int? id)
        {
            if(id==null || id ==0)
            {
                return NotFound();
            }
            var obj = _db.Gorev.Find(id);
            if (obj==null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //post for editing
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Gorev obj)
        {
            if (ModelState.IsValid)
            {
                _db.Gorev.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        //GETELEMENT FOR DELETE
        public IActionResult Delete(int? id)
        {
            var obj = _db.Gorev.Find(id);

            if (obj==null)
            {
                return NotFound();
            }
                _db.Gorev.Remove(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            

            
        }

    }
}
