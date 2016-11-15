using System;
using System.Web.Mvc;
using Buceo.Web.Core;
using Buceo.Web.Models;

namespace Buceo.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult EnviarEmail(MensajeEmailModel mensaje)
        {
            bool success = false;
            try
            {
                if (ModelState.IsValid)
                {
                    Email.Email.From(ConfigurationAppSettings.EmailFrom())
                   .To(ConfigurationAppSettings.EmailTo())
                   .Subject("Test")
                   .UseSsl()
                   .Body("test")
                   .Send();
                    success = true;
                }
            }
            catch (Exception ex)
            {
                LogError(ex);
            }

            return Json(success, JsonRequestBehavior.AllowGet);
        }
    }
}