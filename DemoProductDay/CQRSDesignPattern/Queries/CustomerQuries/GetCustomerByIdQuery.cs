namespace DemoProductDay.CQRSDesignPattern.Queries.CustomerQuries
{
    public class GetCustomerByIdQuery
    {
        public int CustomerId { get; set; }

        public GetCustomerByIdQuery(int customerId)
        {
            CustomerId = customerId;
        }
    }
}
