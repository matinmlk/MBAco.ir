using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Globalization;
using MBAco.BLL;

namespace mbaco.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "admin, techhead, analyser, approver,customer")] 

        public ActionResult Index()
        {

            var customer = new CustomerContactListBiz().GetAll().Where(cus => cus.Contact.Post.Contains(User.Identity.Name));

            if (User.IsInRole("Customer"))
            {
                if (customer.Count() > 0)
                {
                    var i = customer.SingleOrDefault();
                    return Redirect("Customer/Monitor/" + i.CustomerID);
                }
            }
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            //ViewBag.Data1 =  "[]"; //ExportData("usdirt2013");
            //ViewBag.Data2 = ExportData("usdirt2012");
            //ViewBag.Data3 = ExportData("aedirt2012");
            ViewData["AnalyseType"] = new AnalyseParameterTypeListBiz().GetAll();
            ViewData["Customers"] = new CustomerListBiz().GetAll();

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
