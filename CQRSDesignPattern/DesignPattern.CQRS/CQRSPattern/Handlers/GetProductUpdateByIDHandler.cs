using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductUpdateByIDHandler
    {
        Context _context;

        public GetProductUpdateByIDHandler(Context context)
        {
            _context = context;
        }

        public GetProductUpdateByQueryResult Handle(GetProductUpdateByIDQuery query)
        {
           var product = _context.Products.Find(query.Id);
            return new GetProductUpdateByQueryResult
            {
                ProductID = product.ProductID,
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock,
                Description = product.Description,
            };
        }
    }
}
