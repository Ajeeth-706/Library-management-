using Library_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_Management.Controllers
{
    
    public class IssuebookController : Controller
    {
        LibManagementEntities DB = new LibManagementEntities();
        // GET: Issuebook
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetMid(int mid)
        {
            var memberid = (from s in DB.Members where s.MemberId == mid select s.Name).ToList();
            return Json(memberid, JsonRequestBehavior.AllowGet);

        }
    }
}