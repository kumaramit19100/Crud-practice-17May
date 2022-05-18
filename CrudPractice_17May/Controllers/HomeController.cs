using CrudPractice_17May.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudPractice_17May.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Properties p = new Properties();
            DataLayer data = new DataLayer();
            p.Action = 2;
            p.data = data.Operation(p);
            return View(p);
        }
        public JsonResult Insert(Properties p)
        {
            DataLayer dataLayer = new DataLayer();
            DataTable dt = dataLayer.Operation(p);
            return Json("success");
        }

        public JsonResult DeleteData(Properties p)
        {
            DataLayer layer = new DataLayer();
            DataTable dt = layer.Operation(p);
            return Json("Deleted Success!!!");
        }

        public JsonResult EditData(Properties p)
        {
            DataLayer layer = new DataLayer();
            DataTable dt = layer.Operation(p);
            if (dt.Rows.Count > 0)
            {
                p.Name = dt.Rows[0]["Name"].ToString();
                p.Email = dt.Rows[0]["Email"].ToString();
                p.Number = dt.Rows[0]["MNumber"].ToString();
            }
            return Json(p);
        }

        public JsonResult Update(Properties p)
        {
            DataLayer layer = new DataLayer();
            DataTable dt = layer.Operation(p);
            return Json("Update Success");
        }



























        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}