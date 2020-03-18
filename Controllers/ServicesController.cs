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
            PageInfo pageInfo = new PageInfo();
            pageInfo.Title = "Our Services";
            pageInfo.Description = "Local and Nationalwide Goods Transport Solutions all over Pakistan";
            pageInfo.URL = Url.Action("Index", "Services");
            return View(pageInfo);
        }
        public ActionResult AutomobileTransportation()
        {
            PageInfo pageInfo = new PageInfo();
            pageInfo.Title = "Automobile Transportation";
            pageInfo.Description = "Local and Nationalwide Goods Transport Solutions all over Pakistan";
            pageInfo.URL = Url.Action("Index", "Services");
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
        public ActionResult ContainerShifting()
        {
            return View();
        }
        public ActionResult LocalTruckingServices()
        {
            return View();
        }
        public ActionResult FullContainerLoad()
        {
            return View();
        }

        //Contact Us
        public ActionResult ContactUs()
        {
            return View();
        }

    }
    
}