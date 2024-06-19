using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Queries
{
    public class GetProductUpdateByIDQuery : IRequest<UpdateProductByIDQueryResult>
    {
        public int Id { get; set; }

        public GetProductUpdateByIDQuery(int id)
        {
            Id = id;
        }


    }
}
