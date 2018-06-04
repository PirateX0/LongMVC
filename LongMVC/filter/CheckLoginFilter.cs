using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LongMVC.filter
{
    public class CheckLoginFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = filterContext.ActionDescriptor.ActionName;
            string username = filterContext.HttpContext.Session["username"]==null?null: filterContext.HttpContext.Session["username"].ToString();
            if (controllerName=="Login")
            {

            }
            else
            {
                if ( username == null)
                {
                    filterContext.Result = new RedirectResult("/Login/Index");
                }
                if (controllerName=="Main" && actionName.ToLower() =="zhuanzhang")
                {
                    if (username != "a")
                    {
                        ContentResult contentResult = new ContentResult();
                        contentResult.Content = "无转账权限";
                        filterContext.Result = contentResult;
                    }
                }
            }
        }
    }
}