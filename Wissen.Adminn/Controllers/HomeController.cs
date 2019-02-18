using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Wissen.Service;

namespace Wissen.Adminn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService categoryService;
        public HomeController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public ActionResult Test()
        {
            var categories = categoryService.GetAll();
            return View(categories);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}