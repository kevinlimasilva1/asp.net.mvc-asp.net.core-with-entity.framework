using System.Web.Mvc;

namespace BKBProductManagement.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}