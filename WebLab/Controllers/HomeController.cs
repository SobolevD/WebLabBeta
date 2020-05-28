using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebLab.Models;

namespace WebLab.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult TestsCpp()
        {
            return View();
        }

        public IActionResult CppLessonsReferences()
        {
            return View();
        }

        public IActionResult CppGuide()
        {
            
            return View();
        }
    }
}
