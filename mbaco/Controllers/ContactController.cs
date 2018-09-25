using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MBAco.BLL;
using System.Web.Security;

namespace mbaco.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            return View(new ContactListBiz().GetAll());
        }

        //
        // GET: /Contact/Details/5

        public ActionResult Details(int id)
        {
            return View(ContactBiz.Get(id));
        }

        //
        // GET: /Contact/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Contact/Create

        [HttpPost]
        public ActionResult Create(string name, string family, string email, string post, string phoneNumber, string comment, bool Customer, bool Techhead, bool Analyser, bool Approver, string password)
        {
            try
            {

                Membership.CreateUser(post, password);

                if (Customer) Roles.AddUserToRole(post, "Customer");
                if (Techhead) Roles.AddUserToRole(post, "Techhead");
                if (Analyser) Roles.AddUserToRole(post, "Analyser");
                if (Approver) Roles.AddUserToRole(post, "Approver");

                ContactBiz.Save(new MBAco.BusinessModel.ContactModel()
                {
                    Name = name,
                    Family = family,
                    Email = email,
                    Post = post,
                    PhoneNumber = phoneNumber,
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
        // GET: /Contact/Edit/5
 
        public ActionResult Edit(int id)
        {
            var user = ContactBiz.Get(id);
            ViewBag.Customer = Roles.IsUserInRole(user.Post, "Customer");
            ViewBag.Techhead = Roles.IsUserInRole(user.Post, "Techhead");
            ViewBag.Approver = Roles.IsUserInRole(user.Post, "Approver");
            ViewBag.Analyser = Roles.IsUserInRole(user.Post, "Analyser");
            return View(user);
        }

        //
        // POST: /Contact/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, string name, string family, string email, string post, string phoneNumber, string comment, bool Customer, bool Techhead, bool Analyser, bool Approver, string password)
        {
            try
            {

                //Membership.UpdateUser(post, password);
                MembershipUser mu = Membership.GetUser(post);
                if (!String.IsNullOrEmpty(password))
                    mu.ChangePassword(password, password);

                if (Customer) Roles.AddUserToRole(post, "Customer");
                else 
                {
                    if (Roles.IsUserInRole(post, "Customer")) 
                        Roles.RemoveUserFromRole(post, "Customer");
                }

                if (Techhead) Roles.AddUserToRole(post, "Techhead");
                else
                {
                    if (Roles.IsUserInRole(post, "Techhead"))
                        Roles.RemoveUserFromRole(post, "Techhead");
                }

                if (Analyser) Roles.AddUserToRole(post, "Analyser");
                else
                {
                    if (Roles.IsUserInRole(post, "Analyser"))
                        Roles.RemoveUserFromRole(post, "Analyser");
                }

                if (Approver) Roles.AddUserToRole(post, "Approver");
                else
                {
                    if (Roles.IsUserInRole(post, "Approver"))
                        Roles.RemoveUserFromRole(post, "Approver");
                }

                ContactBiz.Save(new MBAco.BusinessModel.ContactModel() {
                    ContactID = id,
                    Name = name,
                    Family = family,
                    Email = email,
                    Post = post,
                    PhoneNumber = phoneNumber,
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
        // GET: /Contact/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View(ContactBiz.Get(id));
        }

        //
        // POST: /Contact/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection form)
        {
            try
            {
                ContactBiz.Delete(id);
                var item = ContactBiz.Get(id);
                Membership.DeleteUser(item.Post);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
