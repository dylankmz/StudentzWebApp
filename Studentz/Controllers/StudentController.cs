using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.EntityFrameworkCore;
using Studentz.Models;
using Studentz.Models.Data;

namespace Studentz.Controllers
{
    public class StudentController : Controller
    {
        private readonly IHtmlLocalizer<HomeController> _localizer;

        private readonly ApplicationDbContext _db;

        [BindProperty]
        public Student Student { get; set; }
        public StudentController(ApplicationDbContext db, IHtmlLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CultureManagement(string culture, string returnUrl)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });

            return LocalRedirect(returnUrl);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.students.ToListAsync() });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert()
        {
            if (ModelState.IsValid)
            {
                if (Student.Id == 0)
                {
                    _db.students.Add(Student);
                } else
                {
                    _db.students.Update(Student);
                }
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Student);
        }

        public IActionResult Upsert(int? id)
        {
            Student = new Student();
            if(id == null)
            {
                //create
                return View(Student);
            }
            //update
            Student = _db.students.FirstOrDefault(u => u.Id == id);
            if(Student == null)
            {
                return NotFound();
            }
            return View(Student);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var studentFromDb = await _db.students.FirstOrDefaultAsync(u => u.Id == id);
            if(studentFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _db.students.Remove(studentFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successfull" });
        }
    }
}