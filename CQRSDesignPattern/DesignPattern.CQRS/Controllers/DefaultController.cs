using DesignPattern.CQRS.CQRSPattern.Command;
using DesignPattern.CQRS.CQRSPattern.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.CQRS.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler getProductQueryHandler;
        private readonly CreateProductCommandHandler createProductCommandHandler;  
        private readonly GetProductByIDHandler getProductByIDHandler;
        private readonly RemoveProductCommandHandler removeProductCommandHandler;
        private readonly GetProductUpdateByIDHandler getProductUpdateByIDHandler;
        private readonly UpdateProductCommandHandler updateProductCommandHandler;
        public DefaultController(GetProductQueryHandler getProductQueryHandler,CreateProductCommandHandler createProductCommandHandler, GetProductByIDHandler getProductByIDHandler, RemoveProductCommandHandler removeProductCommandHandler,GetProductUpdateByIDHandler getProductUpdateByIDHandler, UpdateProductCommandHandler updateProductCommandHandler) 
        { 
            this.getProductQueryHandler = getProductQueryHandler;
            this.createProductCommandHandler = createProductCommandHandler;
            this.getProductByIDHandler = getProductByIDHandler;
            this.removeProductCommandHandler = removeProductCommandHandler;
            this.getProductUpdateByIDHandler = getProductUpdateByIDHandler;
            this.updateProductCommandHandler = updateProductCommandHandler;
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
        public IActionResult GetProduct(int id)
        {
            var product = getProductByIDHandler.Handle(new CQRSPattern.Queries.GetProductByIDQuery(id));
            return View(product);   
        }

        public IActionResult DeleteProduct(int id) 
        {
            removeProductCommandHandler.Handle(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var product = getProductUpdateByIDHandler.Handle(new CQRSPattern.Queries.GetProductUpdateByIDQuery(id));
            return View(product);
        }

        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
            updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
