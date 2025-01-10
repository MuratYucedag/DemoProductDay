using DemoProductDay.Context;
using DemoProductDay.CQRSDesignPattern.Queries.CategoryQueries;
using DemoProductDay.CQRSDesignPattern.Results.CategoryResults;

namespace DemoProductDay.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly CQRSContext _context;
        public GetCategoryByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public GetCategoryByIdQueryResult Handle(GetCategoryByIdQuery query)
        {
            var value = _context.Categories.Find(query.CategoryId);
            return new GetCategoryByIdQueryResult
            {
                CategoryId = value.CategoryId,
                CategoryName = value.CategoryName
            };
        }
    }
}
