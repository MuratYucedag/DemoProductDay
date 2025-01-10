using DemoProductDay.Context;
using DemoProductDay.CQRSDesignPattern.Commands.CategoryCommands;

namespace DemoProductDay.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly CQRSContext _context;
        public RemoveCategoryCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public void Handle(RemoveCategoryCommand command)
        {
            var values = _context.Categories.Find(command.CategoryId);
            _context.Categories.Remove(values);
            _context.SaveChanges();
        }
    }
}
