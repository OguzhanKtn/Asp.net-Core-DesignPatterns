namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductByIDQuery
    {
        public int ID { get; set; }
        public GetProductByIDQuery(int id)
        {
            this.ID = id;
        }

       
    }
}
