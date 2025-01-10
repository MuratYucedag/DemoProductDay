using DemoProductDay.Context;
using DemoProductDay.CQRSDesignPattern.Commands.CustomerCommands;
using DemoProductDay.Entities;

namespace DemoProductDay.CQRSDesignPattern.Handlers.CustomerHandlers
{
    public class CreateCustomerCommandHandler
    {
        private readonly CQRSContext _context;
        public CreateCustomerCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public void Handle(CreateCustomerCommand command)
        {
            _context.Customers.Add(new Customer
            {
                CustomerName = command.CustomerName,
                CustomerSurname = command.CustomerSurname
            });
            _context.SaveChanges();
        }
    }
}
