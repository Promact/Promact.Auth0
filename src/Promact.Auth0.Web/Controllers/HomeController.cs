using Microsoft.AspNetCore.Mvc;

namespace Promact.Auth0.Web.Controllers
{
    public class HomeController : Auth0ControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}