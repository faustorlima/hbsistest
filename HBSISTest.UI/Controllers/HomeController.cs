using System.Web.Mvc;

namespace HBSISTest.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Contribuinte");
        }
    }
}