using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MBAco.BLL;

namespace mbaco.Controllers
{
    public class NotificationMessageTypeController : Controller
    {
        //
        // GET: /NotificationMessageType/

        public ActionResult Index()
        {
            return View(new NotificationMessageTypeListBiz().GetAll());
        }

        //
        // GET: /NotificationMessageType/Details/5

        public ActionResult Details(int id)
        {
            return View(NotificationMessageTypeBiz.Get(id));
        }

        //
        // GET: /NotificationMessageType/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /NotificationMessageType/Create

        [HttpPost]
        public ActionResult Create( string name, string comment)
        {
            try
            {
                NotificationMessageTypeBiz.Save(new MBAco.BusinessModel.NotificationMessageTypeModel()
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
        // GET: /NotificationMessageType/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View(NotificationMessageTypeBiz.Get(id));
        }

        //
        // POST: /NotificationMessageType/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, string name, string comment)
        {
            try
            {
                NotificationMessageTypeBiz.Save(new MBAco.BusinessModel.NotificationMessageTypeModel() { 
                    NotificationMessageTypeID = id,
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
        // GET: /NotificationMessageType/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(NotificationMessageTypeBiz.Get(id));
        }

        //
        // POST: /NotificationMessageType/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                NotificationMessageTypeBiz.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
