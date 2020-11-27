using Shop.Database;
using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shop.Application.ProductsAdmin.CreateProduct;

namespace Shop.Application.StockAdmin
{
    public class DeleteStock
    {
        private ApplicationDbContext _context;

        public DeleteStock(ApplicationDbContext context)
        {

            _context = context;

        }

        public async Task<bool> Do(int id)
        {
            var stock = _context.Stock.FirstOrDefault(x => x.Id == id);

            _context.Stock.Remove(stock);

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
