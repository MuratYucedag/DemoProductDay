using DemoProductDay.Context;
using DemoProductDay.CQRSDesignPattern.Results.CategoryResults;

namespace DemoProductDay.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler
    {
        private readonly CQRSContext _context;
        public GetCategoryQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public List<GetCategoryQueryResult> Handle()
        {
            var values = _context.Categories.Select(x => new GetCategoryQueryResult
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName
            });
            return values.ToList();
        }
    }
}
