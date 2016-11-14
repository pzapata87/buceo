using System;
using System.Web.Mvc;
using Buceo.Models;

namespace Buceo.Controllers
{
    public class HomeController : Controller
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
                    success = true;
                }
            }
            catch (Exception ex)
            {
                
            }

            return Json(success, JsonRequestBehavior.AllowGet);
        }
    }
}