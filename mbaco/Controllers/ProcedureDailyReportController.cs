using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MBAco.BLL;

namespace mbaco.Controllers
{
    public class ProcedureDailyReportController : Controller
    {
        //
        // GET: /ProcedureDailyReport/

        public ActionResult Index()
        {
            return View(new ProcedureParameterListBiz().GetAll());
        }

        //
        // GET: /ProcedureDailyReport/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ProcedureDailyReport/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /ProcedureDailyReport/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /ProcedureDailyReport/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ProcedureDailyReport/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /ProcedureDailyReport/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ProcedureDailyReport/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
