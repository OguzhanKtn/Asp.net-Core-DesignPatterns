using DesignPattern.CQRS.CQRSPattern.Command;
using DesignPattern.CQRS.CQRSPattern.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler getProductQueryHandler;
        private readonly CreateProductCommandHandler createProductCommandHandler;  
        public DefaultController(GetProductQueryHandler getProductQueryHandler,CreateProductCommandHandler createProductCommandHandler) 
        { 
            this.getProductQueryHandler = getProductQueryHandler;
            this.createProductCommandHandler = createProductCommandHandler;
        }
        public IActionResult Index()
        {
            var values = getProductQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(CreateProductCommand command)
        {
            createProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
