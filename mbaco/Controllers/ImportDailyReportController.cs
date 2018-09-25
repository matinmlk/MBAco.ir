using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MBAco.BusinessModel;
using MBAco.BLL;
using System.Globalization;

namespace mbaco.Controllers
{
    public class ImportDailyReportController : Controller
    {

        public ActionResult Import(int id)
        {
            var model = ProcedureParameterBiz.Get(id);

            return View(model);
        }

        //
        // POST: /DailyAnalyseReport/Edit/5

        [HttpPost]
        public ActionResult Import(int id, string comment)
        {
            var model = ProcedureParameterBiz.Get(id);
            var fileContents = comment.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            foreach (var item in fileContents)
            {
                if (item == "")
                    continue;
                var s = item.Split('\t');
                s[0] = s[0].Replace('.', '/');
                s[0] = "13" + s[0];
                var x = new DailyAnalyseReportModel()
                {
                    CustomerID = model.CustomerID,
                    ProcedureParameterID = model.ProcedureParameterID,
                    DatePersian = s[0].Trim(),
                    Value = double.Parse(s[1].Trim()),
                    IsApproved = true
                };

                DailyAnalyseReportBiz.Save(x);
            } 
            
            return View(Redirect("~/"));
        }
        //
        // GET: /ImportDailyReport/

        public ActionResult Index()
        {
            var fileContents = System.IO.File.ReadAllLines(Server.MapPath(@"~/App_Data/phmaroon.txt"));

            foreach (var item in fileContents)
            {

                var s = item.Split('\t');
                s[0] = s[0].Replace('.', '/');
                s[0] = "13" + s[0];
                var x = new DailyAnalyseReportModel()
                {
                    CustomerID = 1,
                    ProcedureParameterID = 4,
                    DatePersian = s[0].Trim(),
                    Value = double.Parse(s[1].Trim()),
                    IsApproved = true
                };

                DailyAnalyseReportBiz.Save(x);
            }

            //ViewData["Message"] = ExportData();
            //ViewData["Model"] = proc;
            return View();
        }

        ProcedureParameterModel proc;

        private string ExportData()
        {
            var items = new DailyAnalyseReportListBiz().GetAll();
            proc = items[0].ProcedureParameter;
            string s = "[\r\n";
            foreach (var item in items)
            {
                var dt = DateTimeToUnixTimestamp(item.Date);
                s += "[" + dt.ToString() + "000," + item.Value.ToString("0.00") + "],\r\n";
            }


            s = s.Trim(',');
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
            return (dateTime - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds;
        }


    }
}
