
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace PetSure.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

      

        public ActionResult UploadFiles(string value)
        {

            string fname = "";
            string valuename = value;
            string msg = "";

            if (Request != null)
            {
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    HttpPostedFileBase file = Request.Files[i];
                    if (file != null || file.ContentLength > 0)
                    {
                        fname = file.FileName;
                        string path = Server.MapPath(String.Format("~/Uploads/{0}/", value));
                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);
                        file.SaveAs(path + fname);

                        if (msg == "")
                        {
                            msg = fname;
                        }
                        else
                        {
                            msg = string.Format(msg + ",{0}", fname);
                        }
                    }
                }
            }
            msg = string.Format("Thank you for submitting " + msg + " file(s) for {0}!", value);
            return Json(new { Message = msg });
        }
    }
}