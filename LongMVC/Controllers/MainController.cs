using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LongMVC.filter;

namespace LongMVC.Controllers
{
    public class MainController : Controller
    {
        // GET: Filter
        public ActionResult Index()
        {
            string username = Session["username"]==null?"未登录": Session["username"].ToString();
            return View((object)username);
        }
        public ActionResult Logout()
        {
            Session["username"] = null;
            return Content("logout successfully!");
        }

        [NotGloballyLogActionFilter]
        public ActionResult Zhuanzhang()
        {
            return Content("Zhuanzhang successfully!");
        }
    }
}