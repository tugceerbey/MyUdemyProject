using Microsoft.AspNetCore.Mvc;

namespace OtelProje.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
