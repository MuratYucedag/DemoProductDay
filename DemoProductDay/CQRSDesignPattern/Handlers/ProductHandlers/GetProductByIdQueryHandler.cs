using DemoProductDay.Context;
using DemoProductDay.CQRSDesignPattern.Queries.ProductQueries;
using DemoProductDay.CQRSDesignPattern.Results.ProductResults;

namespace DemoProductDay.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly CQRSContext _context;
        public GetProductByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var value = _context.Products.Find(query.ProductId);
            return new GetProductByIdQueryResult
            {
                CategoryId = value.CategoryId,
                ProductId = value.ProductId,
                ProductName = value.ProductName,
                ProductStock = value.ProductStock
            };
        }
    }
}
