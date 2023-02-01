using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;
using ToDoApp.NewFolder;

namespace ToDoApp.Controllers
{
    public class EditController : Controller
    {
        private ApplicationDbContext db;

        public EditController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int? id)
        {
            var task = db.Tasks.Find(id);
            return View(task);
        }
        [HttpPost]
        public IActionResult Edit(TaskModel mytask)
        {

            db.Tasks.Update(mytask);
            db.SaveChanges();
            return RedirectToAction(actionName: "Index", controllerName: "Home");
        }

    }
}
