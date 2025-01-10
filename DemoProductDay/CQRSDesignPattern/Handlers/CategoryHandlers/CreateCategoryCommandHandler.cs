using DemoProductDay.Context;
using DemoProductDay.CQRSDesignPattern.Commands.CategoryCommands;
using DemoProductDay.Entities;

namespace DemoProductDay.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly CQRSContext _context;
        public CreateCategoryCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public void Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Category
            {
                CategoryName = command.CategoryName,
            });
            _context.SaveChanges();
        }
    }
}
