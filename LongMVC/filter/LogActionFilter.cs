using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LongMVC.filter
{
    public class LogActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = filterContext.ActionDescriptor.ActionName;
            string username = filterContext.HttpContext.Session["username"] == null ? null : filterContext.HttpContext.Session["username"].ToString();

            List<string> list = new List<string>() { "","execited log:","username: "+username+", controllerName: "+controllerName+", actionName:"+actionName};
            string path = filterContext.HttpContext.Server.MapPath("~/long.txt");
            File.AppendAllLines(path, list);
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = filterContext.ActionDescriptor.ActionName;
            string username = filterContext.HttpContext.Session["username"] == null ? null : filterContext.HttpContext.Session["username"].ToString();

            List<string> list = new List<string>() { "", "execiting log:", "username: " + username + ", controllerName: " + controllerName + ", actionName:" + actionName };
            string path = filterContext.HttpContext.Server.MapPath("~/long.txt");
            File.AppendAllLines(path, list);
        }
    }
}