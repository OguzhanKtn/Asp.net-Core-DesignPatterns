using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Queries
{
    public class GetProductByIDQuery : IRequest<GetProductByIDQueryResult>
    {
        public int ID { get; set; }
        public GetProductByIDQuery(int id)
        {
            ID = id;
        }

       
    }
}
