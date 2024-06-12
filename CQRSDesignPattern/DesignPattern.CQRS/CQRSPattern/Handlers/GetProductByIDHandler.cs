using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductByIDHandler
    {
        Context _context;

        public GetProductByIDHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIDQueryResult Handle(GetProductByIDQuery getProductByIDQuery)
        {
           var product = _context.Set<Product>().Find(getProductByIDQuery.ID);

            return new GetProductByIDQueryResult
            {
                ProductID = product.ProductID,
                Name = product.Name,
                Stock = product.Stock,
                Price = product.Price,
            };
        }
    }
}
