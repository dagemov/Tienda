using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IdentityCape;
using BusinessCape;
namespace AdminCape.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Users()
        {
            return View();
        }

        //REMEMBER For UserList yo need do CapeDates SQL CONNECTION AND READER, and COneccion string in webConfig
        [HttpGet]
        public JsonResult UsersList() {

            List<User> users = new List<User>();

            users =  new CN_Users().List();

            //return Json(users,JsonRequestBehavior.AllowGet);
            // this shape send Json is for send information for query
            //return Json(new { element = users, FirstName="sebastian" }, JsonRequestBehavior.AllowGet);

            //estructura jSon que recibe data table

            return Json(new { data = users }, JsonRequestBehavior.AllowGet);
        }
    }
}