using FeedMeDaily.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FeedMeDaily.Controllers
{
    //If this code works, then it was writen by Rosabel Olugbenga. If it doesn't, then i can only say one thing  "IT IS WHAT IT IS".

    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           return View();
        }

        public ActionResult Insert() 
        {
            var Result = InsertIntoDb.Insert(1, "bread and egg", DateTime.Now);
            return View();
        }
    }
}
