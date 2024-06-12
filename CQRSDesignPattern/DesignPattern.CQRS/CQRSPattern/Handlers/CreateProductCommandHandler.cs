using DesignPattern.CQRS.CQRSPattern.Command;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;
        public CreateProductCommandHandler(Context context) 
        { 
            _context = context;
        }

        public void Handle(CreateProductCommand command) 
        {
            _context.Products.Add(new Product
            {
                Name = command.Name,
                Stock = command.Stock,
                Price = command.Price,
                Description = command.Description,
                Status = true
            });
            _context.SaveChanges();
        }
    }
}
