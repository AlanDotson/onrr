using System.Web.Mvc;
using QEP.ONRR.Web.Models;

namespace QEP.ONRR.Web.Controllers
{
    public class ReportsController : Controller
    {

        // Reports
        public ActionResult Reports()
        {
            var vm = new ReportsViewModel { Title = "Reports" };
            return View(vm);
        }

   }
}