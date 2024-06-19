using DesignPattern.Mediator.MediatorPattern.Commands;
using DesignPattern.Mediator.MediatorPattern.Handlers;
using DesignPattern.Mediator.MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace DesignPattern.Mediator.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllProductQuery());
            return View(values);
        }

        public async Task<IActionResult> GetProduct(int id)
        {
            var value = await _mediator.Send(new GetProductByIDQuery(id));
            return View(value);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteProductCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
           var value = await _mediator.Send(new GetProductUpdateByIDQuery(id));
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateProductCommand productCommand)
        {
            await _mediator.Send(productCommand);
            return RedirectToAction("Index");
        }
    }
}
