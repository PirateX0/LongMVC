using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LongMVC.Models;
using LongMVC.lib;

namespace LongMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index(IndexRequestModel indexRequestModel)
        {
            IndexResponseModel indexResponseModel =
                new IndexResponseModel { Num1 = indexRequestModel.Num1, Num2 = indexRequestModel.Num2 };
            indexResponseModel.Result = indexResponseModel.Num1 + indexResponseModel.Num2;
            ViewBag.bag = "viewBag";
            ViewData["data"] = "viewData";
            return View(indexResponseModel);
        }

        public ActionResult TestDataValidation(Person person)
        {
            if (ModelState.IsValid)
            {
                return Content(person.Name+","+person.Age);
            }
            else
            {
                string errorMsg = MVCHelper.GetValidMsg(ModelState);
                return Content(errorMsg);
            }
        }

        public ActionResult TestAjax()
        {
            return View();
        }

        public ActionResult TestAjax2()
        {
            Person person = new Person { Name = "dalong" };
            //if (Request.IsAjaxRequest())
            //{
            //    return Json(person);
            //}
            //else
            //{
            //    return Content(person.Name);
            //}
            return Content(person.Name);

        }


        public ActionResult TestHtml()
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { Name = "dalong", Id = 1 });
            people.Add(new Person { Name = "ava", Id = 2 });
            //return View(people);

            //List<SelectListItem> selectListItems = new List<SelectListItem>();
            //selectListItems.Add(new SelectListItem { Text="dalong",Value= "dalong" });
            //selectListItems.Add(new SelectListItem { Text = "ava", Value = "ava",Selected=true });
            //return View(selectListItems);

            List<SelectListItem> selectListItems =
                people.Select(x => new SelectListItem { Text = x.Name, Value = x.Id.ToString(), Selected = x.Id == 2 })
                .ToList<SelectListItem>();
            return View(selectListItems);

            //SelectList selectList = new SelectList(people,"id","name",2);
            //return View(selectList);




        }


        public ActionResult TestTempData()
        {
            //TempData["code"] = "123";
            Session["code"] = "123";
            return View();
        }



        public ActionResult TestTempData2()
        {
            string actualCode = "123";
            //var code=(string) TempData["code"];
            var code = (string)Session["code"];
            Session["code"] = null;
            if (actualCode == code)
            {
                return Content("right");
            }
            else
            {
                return Content("error");
            }
        }

        public ActionResult TestLayout()
        {
            return View();
        }

        public ActionResult FileTest()
        {
            return File("/img/long.jpg", "image/jpeg", "longlong.jpg");
        }

        public ActionResult ErrorTest()
        {
            return HttpNotFound();
        }

        public ActionResult F1(int num1, int num2)
        {
            return Content(Convert.ToString(num1 + num2));
        }

        public ActionResult F2(FormCollection formCollection)
        {
            return Content(formCollection["num1"] + formCollection["num2"]);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string name, string age, HttpPostedFileBase httpPostedFileBase)
        {
            httpPostedFileBase.SaveAs(Server.MapPath("~/" + httpPostedFileBase.FileName));
            return Content("hi " + name + ", register successfully!");
        }

        // GET: Test
        public ActionResult TestView(IndexResponseModel indexResponseModel)
        {
            indexResponseModel.Result = indexResponseModel.Num1 + indexResponseModel.Num2;
            return View("Index", indexResponseModel);
        }
    }
}