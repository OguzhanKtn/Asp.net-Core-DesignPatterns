using DesignPattern.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlan netflixPlan = new BasicPlan();
            ViewBag.v1 = netflixPlan.PlanType("Basic Plan");
            ViewBag.v2 = netflixPlan.CountPerson(1);
            ViewBag.v3 = netflixPlan.Price(65.99);
            ViewBag.v4 = netflixPlan.Content("Film-Dizi");
            ViewBag.v5 = netflixPlan.Resolution("720px");
            return View();
        }

        public IActionResult StandardPlanIndex()
        {
            NetflixPlan netflixPlan = new StandardPlan();
            ViewBag.v1 = netflixPlan.PlanType("Standard Plan");
            ViewBag.v2 = netflixPlan.CountPerson(2);
            ViewBag.v3 = netflixPlan.Price(94.99);
            ViewBag.v4 = netflixPlan.Content("Film-Dizi-Animasyon");
            ViewBag.v5 = netflixPlan.Resolution("1080px");
            return View();
        }

        public IActionResult UltraPlanIndex()
        {
            NetflixPlan netflixPlan = new UltraPlan();
            ViewBag.v1 = netflixPlan.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlan.CountPerson(4);
            ViewBag.v3 = netflixPlan.Price(134.99);
            ViewBag.v4 = netflixPlan.Content("Film-Dizi-Animasyon-Belgesel");
            ViewBag.v5 = netflixPlan.Resolution("ultra hd");
            return View();
        }
    }
}
