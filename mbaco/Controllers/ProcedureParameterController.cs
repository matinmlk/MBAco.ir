using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MBAco.BLL;

namespace mbaco.Controllers
{
    public class ProcedureParameterController : Controller
    {
        //
        // GET: /ProcedureParameter/

        public ActionResult Index()
        {
            var type = Request.QueryString["type"];
            var customer = Request.QueryString["customer"];



            if (type == null)
            {
                ViewData["AnalyseType"] = 1;
                return View(new ProcedureParameterListBiz().GetAll().Where(p => p.AnalayseParameter.AnalyseParameterTypeId == 1));
            }
            else if( customer!= null)
            {
                ViewData["AnalyseType"] = int.Parse(type);
                int customerid = int.Parse(customer);
                return View(new ProcedureParameterListBiz().GetAll().Where(p => p.AnalayseParameter.AnalyseParameterTypeId == int.Parse(type) && p.CustomerID == customerid));
            }
            else 
            {
                ViewData["AnalyseType"] = int.Parse(type);
                return View(new ProcedureParameterListBiz().GetAll().Where(p => p.AnalayseParameter.AnalyseParameterTypeId == int.Parse(type)));
            }
        
        }

        //
        // GET: /ProcedureParameter/Details/5

        public ActionResult Details(int id)
        {
            return View(ProcedureParameterBiz.Get(id));
        }

        //
        // GET: /ProcedureParameter/Create

        public ActionResult Create()
        {

            ViewData["Customers"] = new SelectList(
                            new MBAco.BLL.CustomerListBiz().GetAll().ToList(),
                            "CustomerID", "Name");

            ViewData["Params"] = new SelectList(
                new MBAco.BLL.AnalayseParameterListBiz().GetAll().ToList(),
                "AnalayseParameterID", "Symbol");

            ViewData["Msgs"] = new SelectList(
                new MBAco.BLL.NotificationMessageListBiz().GetAll().ToList(),
                "NotificationMessageID", "Text");

            return View();
        }

        //
        // POST: /ProcedureParameter/Create

        [HttpPost]
        public ActionResult Create(int customerId, int analayseParameterId,
            float dangerMaxLimit, float dangerMinLimit, float warningMaxLimit,
            float warningMinLimit, float possibleMaxLimit, float possibleMinLimit,
            int dangerMaxMessageId, int dangerMinMessageId,
            int warningMaxMessageId, int warningMinMessageId, int possibleMaxMessageId,
            int possibleMinMessageId, string comment)
        {
            try
            {
                ProcedureParameterBiz.Save(new MBAco.BusinessModel.ProcedureParameterModel()
                {

                    CustomerID = customerId,
                    AnalayseParameterID = analayseParameterId,
                    DangerMaxLimit = dangerMaxLimit,
                    DangerMinLimit = dangerMinLimit,
                    DangerMaxMessageId = dangerMaxMessageId,
                    DangerMinMessageId = dangerMinMessageId,
                    WarningMaxMessageId = warningMaxMessageId,
                    WarningMaxLimit = warningMaxLimit,
                    WarningMinLimit = warningMinLimit,
                    WarningMinMessageId = warningMinMessageId,
                    PossibleMaxLimit = possibleMaxLimit,
                    PossibleMinLimit = possibleMinLimit,
                    PossibleMinMessageId = possibleMinMessageId,
                    PossibleMaxMessageId = possibleMaxMessageId,
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
        // GET: /ProcedureParameter/Edit/5

        public ActionResult Edit(int id)
        {
            var model = ProcedureParameterBiz.Get(id);

            ViewData["Customers"] = new SelectList(
                new MBAco.BLL.CustomerListBiz().GetAll().ToList(),
                "CustomerID", "Name");

            ViewData["Params"] = new SelectList(
                new MBAco.BLL.AnalayseParameterListBiz().GetAll().ToList(),
                "AnalayseParameterID", "Symbol");

            ViewData["PossibleMinMsgs"] = new SelectList(
                new MBAco.BLL.NotificationMessageListBiz().GetAll().ToList(),
                "NotificationMessageID", "Text", model.PossibleMinMessageId);

            ViewData["PossibleMaxMsgs"] = new SelectList(
                new MBAco.BLL.NotificationMessageListBiz().GetAll().ToList(),
                "NotificationMessageID", "Text", model.PossibleMaxMessageId);

            ViewData["WarningMaxMsgs"] = new SelectList(
                new MBAco.BLL.NotificationMessageListBiz().GetAll().ToList(),
                "NotificationMessageID", "Text", model.WarningMaxMessageId);

            ViewData["WarningMinMsgs"] = new SelectList(
                new MBAco.BLL.NotificationMessageListBiz().GetAll().ToList(),
                "NotificationMessageID", "Text", model.WarningMinMessageId);

            ViewData["DangerMinMsgs"] = new SelectList(
                new MBAco.BLL.NotificationMessageListBiz().GetAll().ToList(),
                "NotificationMessageID", "Text", model.DangerMinMessageId);

            ViewData["DangerMaxMsgs"] = new SelectList(
                new MBAco.BLL.NotificationMessageListBiz().GetAll().ToList(),
                "NotificationMessageID", "Text", model.DangerMaxMessageId);
            return View(model);
        }

        //
        // POST: /ProcedureParameter/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, int customerID, int analayseParameterId,
            float dangerMaxLimit, float dangerMinLimit, float warningMaxLimit,
            float warningMinLimit, float possibleMaxLimit, float possibleMinLimit,
            int dangerMaxMessageId, int dangerMinMessageId,
            int warningMaxMessageId, int warningMinMessageId, int possibleMaxMessageId, int possibleMinMessageId, string comment)
        {
            try
            {
                ProcedureParameterBiz.Save(new MBAco.BusinessModel.ProcedureParameterModel()
                {
                    ProcedureParameterID = id,
                    CustomerID = customerID,
                    AnalayseParameterID = analayseParameterId,
                    DangerMaxLimit = double.Parse(dangerMaxLimit.ToString()),
                    DangerMinLimit = double.Parse(dangerMinLimit.ToString()),
                    DangerMaxMessageId = dangerMaxMessageId,
                    DangerMinMessageId = dangerMinMessageId,
                    WarningMaxMessageId = warningMaxMessageId,
                    WarningMaxLimit = double.Parse(warningMaxLimit.ToString()),
                    WarningMinLimit = double.Parse(warningMinLimit.ToString()),
                    WarningMinMessageId = warningMinMessageId,
                    PossibleMaxLimit = double.Parse(possibleMaxLimit.ToString()),
                    PossibleMinLimit = double.Parse(possibleMinLimit.ToString()),
                    PossibleMinMessageId = possibleMinMessageId,
                    PossibleMaxMessageId = possibleMaxMessageId,
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
        // GET: /ProcedureParameter/Delete/5

        public ActionResult Delete(int id)
        {
            return View(ProcedureParameterBiz.Get(id));
        }

        //
        // POST: /ProcedureParameter/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                ProcedureParameterBiz.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
