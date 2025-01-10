using DemoProductDay.Context;
using DemoProductDay.CQRSDesignPattern.Results.CustomerResults;

namespace DemoProductDay.CQRSDesignPattern.Handlers.CustomerHandlers
{
    public class GetCustomerQueryHandler
    {
        private readonly CQRSContext _context;
        public GetCustomerQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public List<GetCustomerQueryResult> Handle()
        {
            var values = _context.Customers.Select(x => new GetCustomerQueryResult
            {
                CustomerId = x.CustomerId,
                CustomerName = x.CustomerName,
                CustomerSurname = x.CustomerSurname
            }).ToList();
            return values;
        }
    }
}
//AsNoTracking