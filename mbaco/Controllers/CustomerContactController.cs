using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MBAco.BLL;
using MBAco.BusinessModel;
using System.Web.Security;

namespace mbaco.Controllers
{
    public class CustomerContactController : Controller
    {
        //
        // GET: /CustomerContact/

        public ActionResult Index()
        {
            int customerId = 0;
            int contactId = 0;
            IEnumerable<CustomerContactModel> viewData;

            if (Request.QueryString["customerid"] != null)
                customerId = int.Parse(Request.QueryString["customerid"].ToString());

            if (Request.QueryString["contactId"] != null)
                contactId = int.Parse(Request.QueryString["customerid"].ToString());

            if (customerId > 0)
                viewData = new CustomerContactListBiz().GetAll().Where(t => t.CustomerID == customerId);
            else if (contactId > 0)
                viewData = new CustomerContactListBiz().GetAll().Where(t => t.ContactID == contactId);
            else
                viewData = new CustomerContactListBiz().GetAll();


            return View(viewData);
        }



        //
        // GET: /CustomerContact/Details/5

        public ActionResult Details(int id)
        {
            return View(CustomerContactBiz.Get(id));
        }

        //
        // GET: /CustomerContact/Create

        public ActionResult Create()
        {
            ViewData["Customers"] = new SelectList(
            new MBAco.BLL.CustomerListBiz().GetAll().ToList(),
            "CustomerID", "Name");

            ViewData["Contacts"] = new SelectList(
                        new MBAco.BLL.ContactListBiz().GetAll().ToList(),
                        "ContactID", "FullName");

            return View();
        }

        //
        // POST: /CustomerContact/Create

        [HttpPost]
        public ActionResult Create(int customerId, int contactId, string post, string comment)
        {

            try
            {
                CustomerContactBiz.Save(new CustomerContactModel()
                {
                    CustomerID = customerId,
                    ContactID = contactId,
                    Post = post,
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
        // GET: /CustomerContact/Edit/5

        public ActionResult Edit(int id)
        {
            var model = CustomerContactBiz.Get(id);
            ViewData["Customers"] = new SelectList(
                        new MBAco.BLL.CustomerListBiz().GetAll().ToList(),
                        "CustomerID", "Name", model.CustomerID);

            ViewData["Contacts"] = new SelectList(
                        new MBAco.BLL.ContactListBiz().GetAll().ToList(),
                        "ContactID", "FullName", model.ContactID);


            return View(model);
        }

        //
        // POST: /CustomerContact/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, int customerId, int contactId, string post, string comment)
        {
            try
            {

                CustomerContactBiz.Save(new CustomerContactModel()
                {
                    CustomerContactID = id,
                    CustomerID = customerId,
                    ContactID = contactId,
                    Post = post,
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
        // GET: /CustomerContact/Delete/5

        public ActionResult Delete(int id)
        {
            return View(CustomerContactBiz.Get(id));
        }

        //
        // POST: /CustomerContact/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                CustomerContactBiz.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
