using System.Web.Mvc;

namespace QEP.ONRR.Web.Controllers
{
    public class ErrorController : Controller
    {

        // GET: /Error/HttpError404
        public ActionResult HttpError404(string message)
        {
            ViewBag.ErrorMessage = message;
            return View("404Error");
        }

        // GET: /Error/HttpError500
        public ActionResult HttpError500(string message)
        {
            ViewBag.ErrorMessage = message;
            return View("500Error");
        }

        // GET: /Error/GeneralError
        public ActionResult GeneralError(string message)
        {
            ViewBag.ErrorMessage = message;
            return View("GeneralError");
        }
    }
}