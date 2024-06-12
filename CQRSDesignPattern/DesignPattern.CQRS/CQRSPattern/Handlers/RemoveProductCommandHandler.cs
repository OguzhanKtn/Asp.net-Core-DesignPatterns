using DesignPattern.CQRS.CQRSPattern.Command;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class RemoveProductCommandHandler
    {
        Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveProductCommand command) 
        {
            var product = _context.Set<Product>().Find(command.Id);
            _context.Products.Remove(product);
            _context.SaveChanges();

        }
    }
}
