using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MBAco.BLL;

namespace mbaco.Controllers
{
    public class NotificationMessageController : Controller
    {
        //
        // GET: /NotificationMessage/

        public ActionResult Index()
        {
            return View(new NotificationMessageListBiz().GetAll());
        }

        //
        // GET: /NotificationMessage/Details/5

        public ActionResult Details(int id)
        {
            return View(NotificationMessageBiz.Get(id));
        }

        //
        // GET: /NotificationMessage/Create

        public ActionResult Create()
        {
            ViewData["Types"] = new SelectList(
                            new MBAco.BLL.NotificationMessageTypeListBiz().GetAll().ToList(),
                            "NotificationMessageTypeID", "Name");

            return View();
        } 

        //
        // POST: /NotificationMessage/Create

        [HttpPost]
        public ActionResult Create(int typeId, string text, string shortText, string fullText, string comment)
        {
            try
            {
                NotificationMessageBiz.Save(new MBAco.BusinessModel.NotificationMessageModel() { 
                    CultureID = 1,
                    TypeId = typeId,
                    Text = text,
                    ShortText = shortText,
                    FullText = fullText,
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
        // GET: /NotificationMessage/Edit/5
 
        public ActionResult Edit(int id)
        {
            var model = NotificationMessageBiz.Get(id);
            ViewData["Types"] = new SelectList(
                new MBAco.BLL.NotificationMessageTypeListBiz().GetAll().ToList(),
                "NotificationMessageTypeID", "Name", model.TypeId);
            return View(model);
        }

        //
        // POST: /NotificationMessage/Edit/5

        [HttpPost]
        public ActionResult Edit(int id,int typeId, string text, string shortText, string fullText, string comment)
        {
            try
            {
                NotificationMessageBiz.Save(new MBAco.BusinessModel.NotificationMessageModel()
                {
                    NotificationMessageID = id,
                    CultureID = 1,
                    TypeId = typeId,
                    Text = text,
                    ShortText = shortText,
                    FullText = fullText,
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
        // GET: /NotificationMessage/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(NotificationMessageBiz.Get(id));
        }

        //
        // POST: /NotificationMessage/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                NotificationMessageBiz.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
