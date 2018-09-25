using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MBAco.BLL;

namespace mbaco.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            return View(new CustomerListBiz().GetAll());
        }


        public ActionResult Monitor(int id)
        {
            var list = new ProcedureParameterListBiz().GetProcedureParametersByCustomerAndType(id,1);
            foreach (var item in list)
            {
                item.DailyAnalyseReports = new DailyAnalyseReportListBiz()
                    .GetDaily2monthAnalyseReportsByProcedureParameterID(item.ProcedureParameterID).ToList();
            }

            ViewData["Customer"] = CustomerBiz.Get(id);
            return View(list);
        }
        //
        // GET: /Customer/Details/5

        public ActionResult Details(int id)
        {
            return View(CustomerBiz.Get(id));
        }

        //
        // GET: /Customer/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Customer/Create

        [HttpPost]
        public ActionResult Create(string name, string state, string city, string address, string comment)
        {
            try
            {
                CustomerBiz.Save(new MBAco.BusinessModel.CustomerModel() {
                    Name = name,
                    State = state,
                    City = city,
                    Address = address,
                    Comment = comment
                });
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Customer/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(CustomerBiz.Get(id));
        }

        //
        // POST: /Customer/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, string name, string state, string city, string address, string comment)
        {
            try
            {
                CustomerBiz.Save(new MBAco.BusinessModel.CustomerModel()
                {
                    CustomerID =id,
                    Name = name,
                    State = state,
                    City = city,
                    Address = address,
                    Comment = comment
                });
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Customer/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(CustomerBiz.Get(id));
        }

        //
        // POST: /Customer/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                CustomerBiz.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
