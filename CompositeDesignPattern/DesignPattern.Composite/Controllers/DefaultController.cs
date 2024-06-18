using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Composite.Controllers
{
    public class DefaultController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
