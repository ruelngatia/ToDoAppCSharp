using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDoApp.Models;
using ToDoApp.NewFolder;

namespace ToDoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db) 
        {
            this._logger = logger;
            this.db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<TaskModel> result = db.Tasks.ToList();
            return View(result);
        }

     
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}