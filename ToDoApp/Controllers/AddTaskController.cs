using Microsoft.AspNetCore.Mvc;
using ToDoApp.Models;
using ToDoApp.NewFolder;

namespace ToDoApp.Controllers
{
    public class AddTaskController : Controller
    {
        private readonly ApplicationDbContext db;

        public AddTaskController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult addMyTask(TaskModel mytask)
        {
            db.Tasks.Add(mytask);
            db.SaveChanges();
            return RedirectToAction(actionName: "index", controllerName: "Home");
        }
        

    }
}
