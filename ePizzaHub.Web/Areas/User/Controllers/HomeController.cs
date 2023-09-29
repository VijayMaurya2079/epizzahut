using Microsoft.AspNetCore.Mvc;

namespace ePizzaHub.Web.Areas.User.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
