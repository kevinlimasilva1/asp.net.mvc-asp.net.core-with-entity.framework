using System.Threading.Tasks;
using System.Web.Mvc;

namespace BKBProductManagement.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string login, string password)
        {
            return RedirectToAction("Index", "AdminHome", new { area = "Admin" });
        }

        public ActionResult CreateAccount()
        {
            return View();
        }
    }
}