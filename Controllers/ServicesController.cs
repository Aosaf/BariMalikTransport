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
        public ActionResult GeneralCargo()
        {
            PageInfo pageInfo = new PageInfo();
            pageInfo.Title = "General Cargo";
            pageInfo.Description = "Local and Nationalwide Goods Transport Solutions all over Pakistan";
            pageInfo.URL = Url.Action("GeneralCargo", "Services");
            return View(pageInfo);
        }
        public ActionResult FullContainerLoad()
        {
            PageInfo pageInfo = new PageInfo();
            pageInfo.Title = "Full Container Load";
            pageInfo.Description = "Local and Nationalwide Goods Transport Solutions all over Pakistan";
            pageInfo.URL = Url.Action("FullContainerLoad", "Services");
            return View(pageInfo);
        }
        public ActionResult AutomobileTransportation()
        {
            PageInfo pageInfo = new PageInfo();
            pageInfo.Title = "Automobile Transportation";
            pageInfo.Description = "Local and Nationalwide Goods Transport Solutions all over Pakistan";
            pageInfo.URL = Url.Action("AutomobileTransportation", "Services");
            return View(pageInfo);
        }
        public ActionResult ContainerShifting()
        {
            PageInfo pageInfo = new PageInfo();
            pageInfo.Title = "Container Shifting";
            pageInfo.Description = "Local and Nationalwide Goods Transport Solutions all over Pakistan";
            pageInfo.URL = Url.Action("ContainerShifting", "Services");
            return View(pageInfo);
        }
        public ActionResult LocalTruckingServices()
        {
            PageInfo pageInfo = new PageInfo();
            pageInfo.Title = "Local Trucking Services";
            pageInfo.Description = "Local and Nationalwide Goods Transport Solutions all over Pakistan";
            pageInfo.URL = Url.Action("LocalTruckingServices", "Services");
            return View(pageInfo);
        }
        public ActionResult HouseholdGoods()
        {
            PageInfo pageInfo = new PageInfo();
            pageInfo.Title = "Household Goods";
            pageInfo.Description = "Local and Nationalwide Goods Transport Solutions all over Pakistan";
            pageInfo.URL = Url.Action("HouseholdGoods", "Services");
            return View(pageInfo);
        }
        //Contact Us
        public ActionResult ContactUs()
        {
            PageInfo pageInfo = new PageInfo();
            pageInfo.Title = "Contact Us";
            pageInfo.Description = "Let's Create Something Together";
            pageInfo.URL = Url.Action("ContactUs", "Services");
            return View(pageInfo);
        }

    }
    
}