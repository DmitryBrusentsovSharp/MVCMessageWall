using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MessageWallController : Controller
    {
        // GET: MessageWallController1
        public ActionResult Index()
        {
            return View();
        }

        // GET: MessageWallController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MessageWallController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MessageWallController1/Create
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

        // GET: MessageWallController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MessageWallController1/Edit/5
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

        // GET: MessageWallController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MessageWallController1/Delete/5
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
