using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MBAco.BLL;
using MBAco.BusinessModel;
using System.Globalization;
using System.Text;
using System.Net.Mail;
using System.Web.Routing;

namespace mbaco.Controllers
{
    public class DailyAnalyseReportController : Controller
    {
        //
        // GET: /DailyAnalyseReport/

        public ActionResult Index(int id)
        {
            var list = new DailyAnalyseReportListBiz().GetDailyAnalyseReportsByProcedureParameterID(id);
            return View(list);
        }

        public ActionResult UnApprovedIndex()
        {
            return View(new DailyAnalyseReportListBiz().GetUnApproved());
        }

        public ActionResult DeleteAllUnApproved()
        {
            var items = new DailyAnalyseReportListBiz().GetUnApproved();
            foreach (var item in items)
            {
                DailyAnalyseReportBiz.Delete(item.DailyAnalyseReportID);
            }
            return View(new DailyAnalyseReportListBiz().GetUnApproved());
        }

        public ActionResult ApproveAll()
        {
            var items = new DailyAnalyseReportListBiz().GetUnApproved();
            foreach (var item in items)
            {
                item.IsApproved = true;
                DailyAnalyseReportBiz.Save(item);
            }
            return RedirectToAction("ApprovedIndex");
        }

        public ActionResult MailAllReport()
        {

            var item = new DailyAnalyseReportListBiz().GetDailyApproved();
            if (item.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("<div style=\"direction:rtl;text-align:right;font-family:B Koodak,Tahoma\">");
                sb.AppendLine("<img src=\"http://server.shahmat.ir/mbaco/logo.png\" style=\"float:right; width:120px; height:86\">");
                sb.AppendLine("<h1>سامانه پروفایل مشتریان محافظان بهبود آب</h1>");
                sb.AppendLine("<h2> گزارش روزانه " + item.FirstOrDefault().Customer.Name + " " +
                    Shahmat.Common.CalendarHelper.ConvertJulianDateTimeToPersian(DateTime.Now) + "</h2>");

                sb.AppendLine("<table cellpadding=10>");
                sb.AppendLine("<tr>");
                foreach (var i in item)
                {
                    sb.AppendLine("<th>");
                    sb.AppendLine("<strong>" + i.ProcedureParameter.AnalayseParameter.Symbol + "</strong>");
                    sb.AppendLine("<p style=\"font-size:10px; color:#666\">" + i.ProcedureParameter.AnalayseParameter.Name + "<p>");
                    sb.AppendLine("</th>");
                }
                sb.AppendLine("</tr>");
                sb.AppendLine("<tr>");
                foreach (var i in item)
                {
                    sb.AppendLine("<td>");
                    sb.AppendLine(i.Value.ToString());
                    sb.AppendLine("</td>");
                }
                sb.AppendLine("</tr>");
                sb.AppendLine("</table>");

                foreach (var i in item)
                {

                    if (float.Parse(i.Value.ToString()) > i.ProcedureParameter.DangerMaxLimit)
                    {
                        sb.AppendLine(string.Format("<p>مقدار {0} بالاتر از حد اخطار است</p>", i.ProcedureParameter.AnalayseParameter.Name + " " + i.ProcedureParameter.AnalayseParameter.Symbol));
                        sb.AppendLine("<p>" + i.ProcedureParameter.DangerMaxMessage.FullText + "</p>");
                    }
                    else if (float.Parse(i.Value.ToString()) < i.ProcedureParameter.DangerMinLimit)
                    {
                        sb.AppendLine(string.Format("<p>مقدار {0} پایین تر از حد اخطار است</p>", i.ProcedureParameter.AnalayseParameter.Name + " " + i.ProcedureParameter.AnalayseParameter.Symbol));
                        sb.AppendLine("<p>" + i.ProcedureParameter.DangerMinMessage.FullText + "</p>");
                    }
                    else if (float.Parse(i.Value.ToString()) < i.ProcedureParameter.WarningMinLimit)
                    {
                        sb.AppendLine(string.Format("<p>مقدار {0} پایین تر از حد هشدار است</p>", i.ProcedureParameter.AnalayseParameter.Name + " " + i.ProcedureParameter.AnalayseParameter.Symbol));
                        sb.AppendLine(i.ProcedureParameter.WarningMinMessage.FullText);
                    }
                    else if (float.Parse(i.Value.ToString()) > i.ProcedureParameter.WarningMaxLimit)
                    {
                        sb.AppendLine(string.Format("<p>مقدار {0} بالاتر از حد هشدار است</p>", i.ProcedureParameter.AnalayseParameter.Name + " " + i.ProcedureParameter.AnalayseParameter.Symbol));
                        sb.AppendLine(i.ProcedureParameter.WarningMaxMessage.FullText);
                    }
                }


                sb.AppendLine("</div>");

                var contacts = new CustomerContactListBiz().GetCustomerContactsByCustomer(item.FirstOrDefault().CustomerID);
                try
                {
                    foreach (var conts in contacts)
                    {
                        MailMessage mail = new MailMessage("cs@mbaco.co", conts.Contact.Email);
                        SmtpClient client = new SmtpClient();
                        client.Port = 25;
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.UseDefaultCredentials = false;
                        client.Credentials = new System.Net.NetworkCredential("cs@mbaco.co", "_e1234");
                        client.Host = "mail.mbaco.ir";
                        mail.IsBodyHtml = true;
                        mail.Subject = Shahmat.Common.CalendarHelper.ConvertJulianDateTimeToPersian(DateTime.Now) + " گزارش روزانه محافظان بهبود آب ";
                        mail.Body = sb.ToString();
                        client.Send(mail);
                    }

                }
                catch { }

            }

            //sb.AppendLine(GetHtmlFromValues(emailTable));
            //foreach (var strings in comments)
            //{
            //    sb.AppendLine("<li>");
            //    sb.AppendLine(strings);
            //    sb.AppendLine("</li>");
            //}



            //ViewData["emailContent"] = sb.ToString();


            return RedirectToAction("ApprovedIndex");
        }

        public ActionResult ApprovedIndex()
        {
            return View(new DailyAnalyseReportListBiz().GetDailyApproved());
        }        //
        // GET: /DailyAnalyseReport/Details/5

        public ActionResult Details(int id)
        {
            return View(DailyAnalyseReportBiz.Get(id));
        }

        public ActionResult TestMail()
        {
            MailMessage mail = new MailMessage("cs@mbaco.co", "matin.mlk@gmail.com");
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("cs@mbaco.co", "_e1234");
            client.Host = "mail.mbaco.ir";
            mail.Subject = "this is a test email.";
            mail.Body = "this is my test email body";
            client.Send(mail);

            return RedirectToAction("Index");
        }

        public ActionResult Approve(int id)
        {
            var item = DailyAnalyseReportBiz.Get(id);
            item.IsApproved = true;
            DailyAnalyseReportBiz.Save(item);
            return RedirectToAction("UnApprovedIndex");
        }
        //
        // GET: /DailyAnalyseReport/Create

        public ActionResult Create()
        {
            ViewData["Customers"] = new SelectList(
                new MBAco.BLL.CustomerListBiz().GetAll().ToList(),
                "CustomerID", "Name");

            ViewData["ProcParams"] = new SelectList(
                new MBAco.BLL.ProcedureParameterListBiz().GetAll().ToList(),
                "ProcedureParameterID", "AnalayseParameter.Symbol");
            return View();
        }

        //
        // POST: /DailyAnalyseReport/Create

        [HttpPost]
        public ActionResult Create(int customerId, int procedureParameterId, string datePersian, double value, bool isApproved, string comment)
        {
            try
            {
                DailyAnalyseReportBiz.Save(new MBAco.BusinessModel.DailyAnalyseReportModel()
                {
                    CustomerID = customerId,
                    ProcedureParameterID = procedureParameterId,
                    Date = Shahmat.Common.CalendarHelper.ConvertPersianToJulianDateTime(datePersian),
                    Value = value,
                    IsApproved = isApproved,
                    Comment = comment
                });

                return RedirectToAction("Index", new { id = procedureParameterId });
            }
            catch
            {
                return View();
            }
        }

        string[] monthName = { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };
        public ActionResult CorrosionReport(int id)
        {
            List<string> years = new List<string>();
            List<string> report = new List<string>();

            var x = MBAco.BLL.DailyAnalyseReportListBiz.DeleteDailyAnalyseReportsByCustomerAndType(id, 2);

            foreach (var item in x)
            {
                string str = item.DatePersian.Remove(4);
                if (years.Contains(str))
                    continue;
                years.Add(str);
            }

            foreach (var year in years)
            {
                for (int i = 1; i <= 12; i++)
                {
                    string month = i < 10 ? "0" + i.ToString() : i.ToString();
                    var y1 = x.Where(a => a.DatePersian.StartsWith(year + "/" + month) &&
                             a.ProcedureParameter.AnalayseParameterID == 18).FirstOrDefault();
                    var y2 = x.Where(a => a.DatePersian.StartsWith(year + "/" + month) &&
                             a.ProcedureParameter.AnalayseParameterID == 19).FirstOrDefault();
                    var y3 = x.Where(a => a.DatePersian.StartsWith(year + "/" + month) &&
                             a.ProcedureParameter.AnalayseParameterID == 27).FirstOrDefault();

                    string monthly = y1 == null ? "-" : y1.Value.ToString();
                    string demonthly = y2 == null ? "-" : y2.Value.ToString();
                    string thrimonth = y3 == null ? "-" : y3.Value.ToString();

                    ViewData["r1"] += y1 == null ? "0," : y1.Value.ToString() + ",";
                    ViewData["r2"] += y2 == null ? "0," : y2.Value.ToString() + ",";
                    ViewData["r3"] += y3 == null ? "0," : y3.Value.ToString() + ",";

                    report.Add(year + "," + monthName[int.Parse(month) - 1] + "," + monthly + "," + demonthly + "," + thrimonth);
                }
            }

            ViewData["r1"] = ViewData["r1"].ToString().TrimEnd(',');
            ViewData["r2"] = ViewData["r2"].ToString().TrimEnd(',');
            ViewData["r3"] = ViewData["r3"].ToString().TrimEnd(',');

            ViewData["Report"] = report;
            return View();
        }

        public ActionResult MicrobialReport(int id)
        {
            List<string> years = new List<string>();
            List<string> report = new List<string>();

            var x = MBAco.BLL.DailyAnalyseReportListBiz.DeleteDailyAnalyseReportsByCustomerAndType(id, 3);

            foreach (var item in x)
            {
                string str = item.DatePersian.Remove(4);
                if (years.Contains(str))
                    continue;
                years.Add(str);
            }

            foreach (var year in years)
            {
                for (int i = 1; i <= 12; i++)
                {
                    string month = i < 10 ? "0" + i.ToString() : i.ToString();
                    var y2 = x.Where(a => a.DatePersian.StartsWith(year + "/" + month) && int.Parse(a.DatePersian.Substring(8))>=15 &&
                             a.ProcedureParameter.AnalayseParameterID == 25).FirstOrDefault();
                    var y1 = x.Where(a => a.DatePersian.StartsWith(year + "/" + month) && int.Parse(a.DatePersian.Substring(8))<15 &&
                             a.ProcedureParameter.AnalayseParameterID == 25).FirstOrDefault();
                    var y4 = x.Where(a => a.DatePersian.StartsWith(year + "/" + month) && int.Parse(a.DatePersian.Substring(8)) >= 15 &&
                             a.ProcedureParameter.AnalayseParameterID == 26).FirstOrDefault();
                    var y3 = x.Where(a => a.DatePersian.StartsWith(year + "/" + month) && int.Parse(a.DatePersian.Substring(8)) < 15 &&
                             a.ProcedureParameter.AnalayseParameterID == 26).FirstOrDefault();

                    string monthly1 = y1 == null ? "-" : y1.Value.ToString();
                    string monthly2 = y2 == null ? "-" : y2.Value.ToString();
                    string demonthly1 = y3 == null ? "-" : y3.Value.ToString();
                    string demonthly2 = y4 == null ? "-" : y4.Value.ToString();

                    monthly1 = monthly1 == "0" ? "NEGATIVE" : monthly1;
                    monthly2 = monthly2 == "0" ? "NEGATIVE" : monthly2;
                    demonthly1 = demonthly1 == "0" ? "NEGATIVE" : demonthly1;
                    demonthly2 = demonthly2 == "0" ? "NEGATIVE" : demonthly2;

                    report.Add(year + "," + monthName[int.Parse(month) - 1] + "," + monthly1 + "," + monthly2 + "," + demonthly1 + "," + demonthly2);
                }
            }


            ViewData["Report"] = report;
            return View();
        }


        public ActionResult MaterialsReport(int id)
        {
            List<string> years = new List<string>();
            List<string> report = new List<string>();

            var x = MBAco.BLL.DailyAnalyseReportListBiz.DeleteDailyAnalyseReportsByCustomerAndType(id, 8);

            foreach (var item in x)
            {
                string str = item.DatePersian.Remove(4);
                if (years.Contains(str))
                    continue;
                years.Add(str);
            }

            foreach (var year in years)
            {
                for (int i = 1; i <= 12; i++)
                {
                    string month = i < 10 ? "0" + i.ToString() : i.ToString();
                    var y1 = x.Where(a => a.DatePersian.StartsWith(year + "/" + month) &&
                             a.ProcedureParameter.AnalayseParameterID == 20).Sum(p => p.Value);
                    var y2 = x.Where(a => a.DatePersian.StartsWith(year + "/" + month) &&
                             a.ProcedureParameter.AnalayseParameterID == 21).Sum(p => p.Value);
                    var y3 = x.Where(a => a.DatePersian.StartsWith(year + "/" + month) &&
                             a.ProcedureParameter.AnalayseParameterID == 22).Sum(p => p.Value);
                    var y4 = x.Where(a => a.DatePersian.StartsWith(year + "/" + month) &&
                             a.ProcedureParameter.AnalayseParameterID == 23).Sum(p => p.Value);
                    var y5 = x.Where(a => a.DatePersian.StartsWith(year + "/" + month) &&
                             a.ProcedureParameter.AnalayseParameterID == 24).Sum(p => p.Value);

                    string HA = y1 == 0 ? "-" : y1.ToString();
                    string HC = y2 == 0 ? "-" : y2.ToString();
                    string P8110 = y3 == 0 ? "-" : y3.ToString();
                    string P8115 = y4 == 0 ? "-" : y4.ToString();
                    string P9511 = y5 == 0 ? "-" : y5.ToString();

                    ViewData["r1"] += y1 + ",";
                    ViewData["r2"] += y2 + ",";
                    ViewData["r3"] += y3 + ",";
                    ViewData["r4"] += y4 + ",";
                    ViewData["r5"] += y5 + ",";

                    report.Add(year + "," + monthName[int.Parse(month) - 1] + "," + HA +
                        "," + HC + "," + P8110 + "," + P8115 + "," + P9511);
                }
            }

            ViewData["r1"] = ViewData["r1"].ToString().TrimEnd(',');
            ViewData["r2"] = ViewData["r2"].ToString().TrimEnd(',');
            ViewData["r3"] = ViewData["r3"].ToString().TrimEnd(',');
            ViewData["r4"] = ViewData["r4"].ToString().TrimEnd(',');
            ViewData["r5"] = ViewData["r5"].ToString().TrimEnd(',');

            ViewData["Report"] = report;
            return View();
        }

        //
        // GET: /DailyAnalyseReport/Edit/5

        public ActionResult Edit(int id)
        {
            var model = DailyAnalyseReportBiz.Get(id);
            ViewData["Customers"] = new SelectList(
                new MBAco.BLL.CustomerListBiz().GetAll().ToList(),
                "CustomerID", "Name", model.CustomerID);



            ViewData["ProcParams"] = new SelectList(
                new MBAco.BLL.ProcedureParameterListBiz().GetAll().ToList(),
                "ProcedureParameterID", "AnalayseParameter.Symbol");


            return View(model);
        }

        //
        // POST: /DailyAnalyseReport/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, int customerId, int procedureParameterId, string datePersian, double value, bool isApproved, string comment)
        {
            try
            {
                DailyAnalyseReportBiz.Save(new MBAco.BusinessModel.DailyAnalyseReportModel()
                {
                    DailyAnalyseReportID = id,
                    CustomerID = customerId,
                    ProcedureParameterID = procedureParameterId,
                    Date = Shahmat.Common.CalendarHelper.ConvertPersianToJulianDateTime(datePersian),
                    Value = value,
                    IsApproved = isApproved,
                    Comment = comment
                });
                return RedirectToAction("Index", new { id = procedureParameterId });
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /DailyAnalyseReport/Delete/5

        public ActionResult Delete(int id)
        {
            return View(DailyAnalyseReportBiz.Get(id));
        }

        //
        // POST: /DailyAnalyseReport/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                DailyAnalyseReportBiz.Delete(id);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult DeleteAll(int id)
        {
            return View(ProcedureParameterBiz.Get(id));
        }

        //
        // POST: /DailyAnalyseReport/Delete/5

        [HttpPost]
        public ActionResult DeleteAll(int id, FormCollection collection)
        {
            try
            {
                var items = new DailyAnalyseReportListBiz().GetDailyAnalyseReportsByProcedureParameterID(id);
                foreach (var item in items)
                {
                    DailyAnalyseReportBiz.Delete(item.DailyAnalyseReportID);
                }
                return RedirectToAction("Index", "DailyAnalayseReport", new { id = id });
            }
            catch
            {
                return View();
            }
        }

        public ActionResult AddParameter(int id)
        {
            var type = Request["type"];
            var xx = CustomerBiz.Get(id);

            ViewData["Customers"] = new SelectList(
                new CustomerListBiz().GetAll().ToList(),
                "CustomerID", "Name", xx.CustomerID);

            if (type == null)
            {
                xx.ProcedureParameters = new ProcedureParameterListBiz().GetProcedureParametersByCustomer(id);
            }
            else
            {
                int t = int.Parse(type);
                xx.ProcedureParameters = new ProcedureParameterListBiz().GetProcedureParametersByCustomerAndType(id, t);
            }

            return View(xx);
        }

        [HttpPost]
        public ActionResult AddParameter(FormCollection collection, int CustomerID, string ddl)
        {
            List<String> comments = new List<string>();
            List<string[]> emailTable = new List<string[]>();
            var type = Request["type"];

            if (CustomerID != int.Parse(ddl))
                return RedirectToAction("AddParameter", "DailyAnalyseReport", new { id = int.Parse(ddl), type = int.Parse(type) });

            string customer = "";

            emailTable.Add(new string[] { "Parameter", "Limit", "Value" });
            DailyAnalyseReportModel daily = new DailyAnalyseReportModel();
            var procs = collection[3];
            var procsLst = procs.Split(',');

            var vals = collection[2];
            var valsLst = vals.Split(',');

            for (int i = 0; i < procsLst.Length; i++)
            {
                var procitem = ProcedureParameterBiz.Get(int.Parse(procsLst[i].ToString()));
                customer = procitem.Customer.Name;
                var procvalue = valsLst[i];

                if (String.IsNullOrEmpty(procvalue))
                {
                    comments.Add(String.Format("مقداری برای {0} ثبت نشد.", procitem.AnalayseParameter.Symbol));
                    continue;
                }

                else if (float.Parse(procvalue) > procitem.PossibleMaxLimit)
                {
                    comments.Add(procitem.PossibleMaxMessage.FullText);
                    comments.Add(String.Format("مقداری برای {0} ثبت نشد.", procitem.AnalayseParameter.Symbol));
                    continue;
                }
                else if (float.Parse(procvalue) < procitem.PossibleMinLimit)
                {
                    comments.Add(procitem.PossibleMinMessage.FullText);
                    comments.Add(String.Format("مقداری برای {0} ثبت نشد.", procitem.AnalayseParameter.Symbol));
                    continue;
                }

                else if (float.Parse(procvalue) > procitem.DangerMaxLimit)
                    comments.Add(procitem.DangerMaxMessage.FullText);

                else if (float.Parse(procvalue) < procitem.DangerMinLimit)
                    comments.Add(procitem.DangerMinMessage.FullText);

                else if (float.Parse(procvalue) < procitem.WarningMinLimit)
                    comments.Add(procitem.WarningMinMessage.FullText);

                else if (float.Parse(procvalue) > procitem.WarningMaxLimit)
                    comments.Add(procitem.WarningMaxMessage.FullText);

                try
                {

                    DailyAnalyseReportBiz.Save(new DailyAnalyseReportModel()
                    {

                        Date = DateTime.Now,
                        Value = double.Parse(procvalue),
                        ProcedureParameter = procitem,
                        ProcedureParameterID = procitem.ProcedureParameterID,
                        IsApproved = false,
                        CustomerID = procitem.CustomerID

                    });

                    emailTable.Add(new string[]{
                        procitem.AnalayseParameter.Symbol ,
                        procitem.PossibleMinLimit.Value.ToString() + "-" +
                        procitem.PossibleMaxLimit.Value.ToString(),
                        procvalue
                    });
                    comments.Add(String.Format("مقدار {0} برای {1} ثبت شد.", procvalue, procitem.AnalayseParameter.Symbol));

                }
                catch
                {

                }

            }

            ViewData["Customers"] = new SelectList(
                new CustomerListBiz().GetAll().ToList(),
                "CustomerID", "Name", CustomerID);

            ViewData["Params"] = comments;


            return View();
        }



        private string GetHtmlFromValues(List<string[]> emailTable)
        {
            string res = "<table border=1 cellpadding=10>";
            for (int j = 0; j < emailTable[0].Length; j++)
            {
                res += "<tr>";
                for (int i = 0; i < emailTable.Count; i++)
                {
                    res += j == 0 ? "<th>" : "<td>";
                    res += emailTable[i][j];
                    res += j == 0 ? "</th>" : "</td>";

                }
                res += "</tr>";
            }
            res += "</table>";
            return res;
        }



        public ActionResult ProcedureIndex(int id)
        {
            return View(new DailyAnalyseReportListBiz()
                .GetDailyAnalyseReportsByProcedureParameterID(id));
        }

        public ActionResult ProcedureChart(int id)
        {
            var type = Request.QueryString["type"];
            if (type == null)
                ViewData["Chart"] = ExportData(id);
            else
            {
                int ty = int.Parse(type.ToString());
                ViewData["Chart"] = ExportData(id, ty);
            }
            return View();
        }


        public ActionResult ProcedureMiniChart(int id)
        {

            ViewData["Chart"] = ExportData(id, 3);

            return View();
        }
        ProcedureParameterModel proc;

        private string ExportData(int id, int limitType = 3)
        {
            IEnumerable<DailyAnalyseReportModel> items;

            if (limitType == 1)
            {
                items = new DailyAnalyseReportListBiz()
                    .GetDailyAnalyseReportsByProcedureParameterID(id).Where(a => a.Date > DateTime.Now.AddDays(-30));
                ViewData["StartDate"] = Shahmat.Common.CalendarHelper.ConvertJulianDateTimeToPersian(DateTime.Now.AddDays(-30));
            }
            else if (limitType == 2)
            {
                items = new DailyAnalyseReportListBiz()
                    .GetDailyAnalyseReportsByProcedureParameterID(id).Where(a => a.Date > DateTime.Now.AddMonths(-2));
                ViewData["StartDate"] = Shahmat.Common.CalendarHelper.ConvertJulianDateTimeToPersian(DateTime.Now.AddMonths(-2));

            }
            else if (limitType == 4)
            {
                items = new DailyAnalyseReportListBiz()
                    .GetDailyAnalyseReportsByProcedureParameterID(id).Where(a => a.Date > DateTime.Now.AddMonths(-6));
                ViewData["StartDate"] = Shahmat.Common.CalendarHelper.ConvertJulianDateTimeToPersian(DateTime.Now.AddMonths(-6));

            }
            else if (limitType == 5)
            {
                items = new DailyAnalyseReportListBiz()
                    .GetDailyAnalyseReportsByProcedureParameterID(id).Where(a => a.Date > DateTime.Now.AddYears(-1));
                ViewData["StartDate"] = Shahmat.Common.CalendarHelper.ConvertJulianDateTimeToPersian(DateTime.Now.AddYears(-1));

            }
            else if (limitType == 6)
            {
                items = new DailyAnalyseReportListBiz().GetDailyAnalyseReportsByProcedureParameterID(id);
            }
            else
            {
                items = new DailyAnalyseReportListBiz()
                    .GetDailyAnalyseReportsByProcedureParameterID(id).Where(a => a.Date > DateTime.Now.AddMonths(-3));
                ViewData["StartDate"] = Shahmat.Common.CalendarHelper.ConvertJulianDateTimeToPersian(DateTime.Now.AddMonths(-3));

            }

            ViewData["EndDate"] = Shahmat.Common.CalendarHelper.ConvertJulianDateTimeToPersian(DateTime.Now);
            var param = ProcedureParameterBiz.Get(id);
            ViewData["Parameter"] = param.AnalayseParameter.Symbol;
            ViewData["id"] = id;
            ViewData["ChartTitle"] = String.Format("{1} گزارش تغییرات {0}", param.AnalayseParameter.Name, param.AnalayseParameter.Symbol);

            if (items.Count() == 0)
                return "";

            var proitem = ProcedureParameterBiz.Get(id);
            ViewData["DangerMax"] = proitem.DangerMaxLimit;
            ViewData["DangerMin"] = proitem.DangerMinLimit;
            ViewData["PossibleMax"] = proitem.PossibleMaxLimit;
            ViewData["PossibleMin"] = proitem.PossibleMinLimit;

            ViewData["DangerMaxMsg"] = proitem.DangerMaxMessage.ShortText;
            ViewData["DangerMinMsg"] = proitem.DangerMinMessage.ShortText;

            ViewData["Customer"] = proitem.Customer.Name;

            ViewData["DataMax"] = items.Max(p => p.Value);
            ViewData["DataMin"] = items.Min(p => p.Value);
            ViewData["DataAvg"] = items.Average(p => p.Value);

            int total = items.Count();

            var upperItems = items.Where(p => p.Value > param.DangerMaxLimit);
            int upper = upperItems.Count();
            ViewData["DataUpperPercent"] = ((float)(upper * 100) / total);
            ViewData["UpperItems"] = upperItems;


            var lowerItems = items.Where(p => p.Value < param.DangerMinLimit);
            float lower = lowerItems.Count();
            ViewData["DataLowerPercent"] = ((float)(lower * 100) / total);
            ViewData["LowerItems"] = lowerItems;

            var normalItems = items.Where(p => p.Value > param.DangerMinLimit && p.Value < param.DangerMaxLimit);
            float normal = normalItems.Count();
            ViewData["DataNormalPercent"] = ((float)(normal * 100) / total);

            ViewData["NormalItems"] = normalItems;

            proc = items.FirstOrDefault().ProcedureParameter;
            string s = "[\r\n";
            foreach (var item in items)
            {
                var dt = DateTimeToUnixTimestamp(item.Date);
                s += "[" + dt.ToString() + "000," + item.Value.ToString("0.00") + "],\r\n";
            }


            s = s.Remove(s.LastIndexOf(','));
            s += "\r\n]";
            return s;
        }


        private string ExportData(string fileName)
        {
            var fileContents = System.IO.File.ReadAllLines(Server.MapPath(@"~/App_Data/" + fileName + ".txt"));

            var items = new DailyAnalyseReportListBiz().GetAll();

            string s = "[\r\n";
            foreach (var item in items)
            {
                // [Date.UTC(1970, 9, 27), 0]
                //var itm = item.Split(' ');
                //var date = itm[0].Split('.');
                //var itm1 = itm[1].Split('\t');
                //var time = itm1[0].Split(':');
                //var sell = itm1[1];
                //var buy = itm1[2];

                // s += "[Date.UTC(" + date[0] + "," + date[1] + "," + date[2] + /*"," + time[0] + "," + time[1] + "," + time[2] +*/ ")," + buy + "],";
                var dt = DateTimeToUnixTimestamp(item.Date);
                // "[" + dt.ToString() + "000," + (float.Parse(buy) * 14).ToString("0.00") + "],\r\n";
                s += "[" + dt.ToString() + "000," + item.Value.ToString("0.00") + "],\r\n";
            }


            s = s.Trim(',');
            s += "\r\n]";
            return s;
        }

        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0,
                                                      DateTimeKind.Utc);

        public static DateTime UnixTimeToDateTime(string text)
        {
            double seconds = double.Parse(text, CultureInfo.InvariantCulture);
            return Epoch.AddSeconds(seconds);
        }

        public static double DateTimeToUnixTimestamp(DateTime dateTime)
        {
            return (DateTime.Parse(dateTime.ToShortDateString()) - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds;
        }
    }
}
