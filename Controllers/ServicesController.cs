using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BariMalikTransport.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AutomobileTransportation()
        {
            return View();
        }
        public ActionResult HouseholdGoods()
        {
            return View();
        }
        public ActionResult GeneralCargo()
        {
            return View();
        }

    }
}