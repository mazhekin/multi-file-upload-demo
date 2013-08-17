using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication4.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index(HttpPostedFileBase[] file1)
        {
            return View();
        }

        private void SaveFile(string fileName,string contentType, Stream inputStream)
        {
 	        throw new NotImplementedException();
        }

    }
}
