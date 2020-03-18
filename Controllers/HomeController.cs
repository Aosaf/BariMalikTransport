using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BariMalikTransport.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            PageInfo pageInfo = new PageInfo();
            pageInfo.Title = "Bari Malik Goods Transpot";
            pageInfo.Description = "Local and Nationalwide Goods Transport Solutions all over Pakistan";
            pageInfo.URL = Url.Action("Index", "Home");
            return View(pageInfo);
        }
    }
}