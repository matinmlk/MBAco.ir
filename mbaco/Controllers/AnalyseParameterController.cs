using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MBAco.BLL;
using MBAco.BusinessModel;

namespace mbaco.Controllers
{
    public class AnalyseParameterController : Controller
    {
        //
        // GET: /AnalyseParameter/

        public ActionResult Index()
        {
            return View(new MBAco.BLL.AnalayseParameterListBiz().GetAll());
        }

        //
        // GET: /AnalyseParameter/Details/5

        public ActionResult Details(int id)
        {
            return View(AnalayseParameterBiz.Get(id));
        }

        //
        // GET: /AnalyseParameter/Create

        public ActionResult Create()
        {
            var model = AnalayseParameterBiz.New();
            ViewData["AnalyseParameterType"] = new SelectList(
                                        new MBAco.BLL.AnalyseParameterTypeListBiz().GetAll().ToList(),
                                        "AnalyseParameterTypeID", "Name");
            return View(model);
        } 

        //
        // POST: /AnalyseParameter/Create

        [HttpPost]
        public ActionResult Create(string name, string symbol, int analyseParameterTypeId, string comment)
        {
            try
            {
                AnalayseParameterBiz.Save(new AnalayseParameterModel()
                {
                    Name = name,
                    Symbol = symbol,
                    AnalyseParameterTypeId = analyseParameterTypeId,
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
        // GET: /AnalyseParameter/Edit/5
 
        public ActionResult Edit(int id)
        {

            var model = AnalayseParameterBiz.Get(id);
            ViewData["AnalyseParameterType"] = new SelectList(
                                        new MBAco.BLL.AnalyseParameterTypeListBiz().GetAll().ToList(),
                                        "AnalyseParameterTypeID", "Name");
            return View(model);
        }

        //
        // POST: /AnalyseParameter/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, string name, string symbol, int analyseParameterTypeId, string comment)
        {
            try
            {
                AnalayseParameterBiz.Save(new AnalayseParameterModel()
                {
                    Name = name,
                    Symbol = symbol,
                    AnalayseParameterID = id,
                    AnalyseParameterTypeId = analyseParameterTypeId,
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
        // GET: /AnalyseParameter/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(AnalayseParameterBiz.Get(id));
        }

        //
        // POST: /AnalyseParameter/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                AnalayseParameterBiz.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
