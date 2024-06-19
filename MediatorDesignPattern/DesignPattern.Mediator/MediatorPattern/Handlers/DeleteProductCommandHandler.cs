using DesignPattern.Mediator.DAL;
using DesignPattern.Mediator.MediatorPattern.Commands;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly Context _context;

        public DeleteProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var value = _context.Products.Find(request.Id);
            _context.Products.Remove(value);

            await _context.SaveChangesAsync();
        }
    }
}
