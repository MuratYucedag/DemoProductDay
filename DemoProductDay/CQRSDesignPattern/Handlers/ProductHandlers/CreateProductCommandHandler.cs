using DemoProductDay.Context;
using DemoProductDay.CQRSDesignPattern.Commands.ProductCommands;
using DemoProductDay.Entities;

namespace DemoProductDay.CQRSDesignPattern.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly CQRSContext _context;

        public CreateProductCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                ProductName = command.ProductName,
                ProductStock = command.ProductStock,
                CategoryId = command.CategoryId
            });
            _context.SaveChanges();
        }
    }
}
