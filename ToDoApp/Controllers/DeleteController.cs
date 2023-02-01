using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;
using ToDoApp.NewFolder;

namespace ToDoApp.Controllers
{
    public class DeleteController : Controller
    {
        private readonly ApplicationDbContext db;

        public  DeleteController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Delete(int? id)
        {
            var task = db.Tasks.Find(id);
            return View(task);
        }
        [HttpPost]
        public IActionResult Delete(TaskModel myTask)
        {
            db.Tasks.Remove(myTask);
            db.SaveChanges();
            return RedirectToAction(actionName: "Index", controllerName: "Home");
        }

    }
}
