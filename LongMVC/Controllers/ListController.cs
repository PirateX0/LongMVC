using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace LongMVC.Controllers
{
    public class ListController : Controller
    {
        // GET: List
        public ActionResult Index()
        {
            DataTable dataTable = sqlHelper.executeDataTable("select * from MemberInfo");
            return View(dataTable);
        }

        public ActionResult TestJson()
        {
            string name = "dalong";
            return Json(name);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(string memName, string memMobilePhone)
        {
            sqlHelper.executeNonQuery("insert into MemberInfo(MemName,MemMobilePhone) values(@MemName, @MemMobilePhone)",
                new SqlParameter("MemName", memName),
                new SqlParameter("MemMobilePhone", memMobilePhone));
            return Redirect("/List/Index");
        }

        [HttpGet]
        public ActionResult Update(string memberId)
        {
            DataTable dataTable = sqlHelper.executeDataTable("select * from MemberInfo where MemberId  = @MemberId",
                new SqlParameter("MemberId", memberId));

            return View(dataTable);
        }

        [HttpPost]
        public ActionResult Update(string memberId, string memName, string memMobilePhone)
        {
            sqlHelper.executeNonQuery("update MemberInfo set MemName=@MemName, MemMobilePhone=@MemMobilePhone where MemberId=@MemberId",
                new SqlParameter("MemName", memName),
                new SqlParameter("MemMobilePhone", memMobilePhone),
                new SqlParameter("MemberId", memberId));
            return Redirect("/List/Index");
        }

        public ActionResult Delete(string memberId)
        {
            sqlHelper.executeNonQuery("delete from MemberInfo where MemberId=@MemberId",
                new SqlParameter("MemberId", memberId));

            return Redirect("/List/Index");
        }
    }
}