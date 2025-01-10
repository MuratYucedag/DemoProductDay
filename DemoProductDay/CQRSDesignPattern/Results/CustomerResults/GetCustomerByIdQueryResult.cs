namespace DemoProductDay.CQRSDesignPattern.Results.CustomerResults
{
    public class GetCustomerByIdQueryResult
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
