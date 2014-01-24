using System.Data;
using System.Linq;
using System.Web.Mvc;

using Mvc3CodeFirst.Models;

namespace Mvc3CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        private SampleDataContext db = new SampleDataContext();

        //
        // GET: /Home/

        public ActionResult About()
        {
            return View();
        }

        //
        // GET: /Home/

        public ActionResult Linkout()
        {
            return View();
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(db.Activities.ToList());
        }

        //
        // GET: /Thumbnails/

        public ActionResult Thumbnails()
        {
            return View(db.Students.ToList());
        }

        //
        // GET: /Tabular/

        public ActionResult Tabular()
        {
            return View(db.Students.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id = 0)
        {
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        //
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View(new Student());
        }

        //
        // POST: /Home/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return RedirectToAction("Tabular");
            }

            return View(student);
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Tabular");
            }
            return View(student);
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Tabular");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
