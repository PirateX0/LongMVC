using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LongMVC.filter
{
    public class HandleExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            List<string> list = new List<string>() {"error:", filterContext.Exception.ToString() };
            string path = filterContext.HttpContext.Server.MapPath("~/error.txt");
            File.AppendAllLines(path, list);
            filterContext.ExceptionHandled = true;//如果有其他的IExceptionFilter不再执行
            filterContext.Result = new ContentResult() { Content = "error" };

        }
    }
}