using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4 : ViewComponent
    {

        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Admins.Where(x => x.AdminId == 1).Select(y => y.Name).FirstOrDefault();
            ViewBag.v2 = context.Admins.Where(x => x.AdminId == 1).Select(y => y.ImageUrl).FirstOrDefault();
            ViewBag.v3 = context.Admins.Where(x => x.AdminId == 1).Select(y => y.ShortDescription).FirstOrDefault();
            return View();
        }
    }
}
