using DemoProductDay.Context;
using DemoProductDay.CQRSDesignPattern.Results.ProductResults;

namespace DemoProductDay.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class GetProductQueryHandler
    {
        private readonly CQRSContext _context;
        public GetProductQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                CategoryId = x.CategoryId,
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductStock = x.ProductStock
            }).ToList();
            return values;
        }
    }
}
