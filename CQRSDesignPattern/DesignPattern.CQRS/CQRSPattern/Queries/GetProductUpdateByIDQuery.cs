namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductUpdateByIDQuery
    {
        public int Id { get; set; }

        public GetProductUpdateByIDQuery(int id)
        {
            this.Id = id;
        }
    }
}
