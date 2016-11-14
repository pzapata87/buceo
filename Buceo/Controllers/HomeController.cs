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
            if (ModelState.IsValid)
            {
                
            }

            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}