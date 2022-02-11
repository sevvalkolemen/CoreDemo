using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            Context context = new Context();
            ViewBag.value1 = context.Blogs.Count().ToString();
            ViewBag.value2 = context.Blogs.Where(x => x.WriterId == 1).Count();
            ViewBag.value3 = context.Categories.Count();
            return View();
        }

    }
}
