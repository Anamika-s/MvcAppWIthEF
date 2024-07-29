using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MvcAppWIthEF.Controllers
{
    public class User1Controller : Controller
    {
        // GET: User1Controller
        public ActionResult Index()
        {
            return View();
        }

        // GET: User1Controller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User1Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User1Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: User1Controller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User1Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: User1Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User1Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
