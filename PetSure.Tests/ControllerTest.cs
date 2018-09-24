using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using PetSure.Web;
using PetSure.Web.Controllers;
using System.IO;

namespace PetSure.Tests
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void Index()
        {
            HomeController homeController = new HomeController();
            ViewResult viewResult = homeController.Index() as ViewResult;
            Assert.IsNotNull(viewResult);
        }

        [TestMethod]
        public void UploadFiles()
        {
            HomeController homeController = new HomeController();
            JsonResult viewResult = homeController.UploadFiles("test") as JsonResult;
            Assert.IsNotNull(viewResult);
        }
    }
}
