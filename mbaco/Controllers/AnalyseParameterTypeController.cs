using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MBAco.BLL;

namespace mbaco.Controllers
{
    public class AnalyseParameterTypeController : Controller
    {
        //
        // GET: /AnalyseParameterType/

        public ActionResult Index()
        {
            return View(new AnalyseParameterTypeListBiz().GetAll());
        }

        //
        // GET: /AnalyseParameterType/Details/5

        public ActionResult Details(int id)
        {
            return View(AnalyseParameterTypeBiz.Get(id));
        }

        //
        // GET: /AnalyseParameterType/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /AnalyseParameterType/Create

        [HttpPost]
        public ActionResult Create(string name, string comment)
        {
            try
            {
                // TODO: Add insert logic here
                AnalyseParameterTypeBiz.Save(new MBAco.BusinessModel.AnalyseParameterTypeModel()
                {
                    Name = name,
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
        // GET: /AnalyseParameterType/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(AnalyseParameterTypeBiz.Get(id));
        }

        //
        // POST: /AnalyseParameterType/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, string name, string comment)
        {
            try
            {
                // TODO: Add update logic here
                AnalyseParameterTypeBiz.Save(new MBAco.BusinessModel.AnalyseParameterTypeModel()
                {
                    AnalyseParameterTypeID = id,
                    Name = name,
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
        // GET: /AnalyseParameterType/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(AnalyseParameterTypeBiz.Get(id));
        }

        //
        // POST: /AnalyseParameterType/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection form)
        {
            try
            {
                AnalyseParameterTypeBiz.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
