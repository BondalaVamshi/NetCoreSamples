using CRUDUsingMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDUsingMVC.Controllers
{
    public class BookMVCsController : Controller
    {
        private readonly ApplicationDBContext _db;
        [BindProperty]
        public BookMVC BookMVC { get; set; }
        public BookMVCsController(ApplicationDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id)
        {
            BookMVC = new BookMVC();
            if (id == null)
            {
                //create
                return View(BookMVC);
            }
            //update
            BookMVC = _db.BookMVCs.FirstOrDefault(u => u.Id == id);
            if (BookMVC == null)
            {
                return NotFound();
            }
            return View(BookMVC);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)
            {
                if (BookMVC.Id == 0)
                {
                    //create
                    _db.BookMVCs.Add(BookMVC);
                }
                else
                {
                    _db.BookMVCs.Update(BookMVC);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(BookMVC);
        }

        #region API Calls
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.BookMVCs.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var bookFromDb = await _db.BookMVCs.FirstOrDefaultAsync(u => u.Id == id);
            if (bookFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _db.BookMVCs.Remove(bookFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion

    }
}
