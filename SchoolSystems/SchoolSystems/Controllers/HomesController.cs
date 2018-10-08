using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolSystems.Controllers
{
    public class HomesController : Controller
    {
        // GET: Homes
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult admin()
        {
            return View();
        }
        public ActionResult AdminDashboard()
        {

            return View();
        }
    }
}