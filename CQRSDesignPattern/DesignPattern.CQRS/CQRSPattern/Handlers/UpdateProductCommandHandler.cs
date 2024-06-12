using DesignPattern.CQRS.CQRSPattern.Command;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
           var product = _context.Products.Find(command.ProductID);

            product.Name = command.Name;
            product.Description = command.Description;
            product.Price = command.Price;
            product.Stock = command.Stock;
            product.Status = true;
            _context.SaveChanges();
        }
    }
}
