using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication4.Controllers
{
    public class FilesController : Controller
    {
        //
        // GET: /Files/

        public ActionResult Upload(HttpPostedFileBase[] file1)
        {
            foreach (var file in file1)
            {
                SaveFile(file.FileName, file.ContentType, file.InputStream);
            }
            return RedirectToAction("index", "home");
        }

        private void SaveFile(string fileName, string contentType, Stream inputStream)
        {
            using (var fileStream = System.IO.File.Create("D:\\Tests\\" + fileName))
            {
                inputStream.CopyTo(fileStream);
            }
        }
    }
}
