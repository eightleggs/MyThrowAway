using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LearningApplication.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearningApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new HelloWorldViewModel();
            model.ModelName = "My veryfirst Model";
            model.HelloTimeStamp = DateTime.Now;
            return View(model);
        }

        public IActionResult DestroyIt()
        {
            var model = new HelloWorldViewModel();
            model.ModelName = "Destroyed";
            model.HelloTimeStamp = DateTime.Now;
            return View("index", model);

        }
    }
}
