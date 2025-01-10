namespace DemoProductDay.CQRSDesignPattern.Commands.CustomerCommands
{
    public class UpdateCustomerCommand
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
