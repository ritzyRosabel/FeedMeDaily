using FeedMeDaily.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FeedMeDaily.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var Result = InsertIntoDb.Insert(1, "bread and egg", DateTime.Now);

            return View();
        }
        public ActionResult Insert() 
        {
            var Result = InsertIntoDb.Insert(1, "bread and egg", DateTime.Now);
            return View();
        }
    }
}
