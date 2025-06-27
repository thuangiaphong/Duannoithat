using Duannoithat.Data;
using Duannoithat.Models.Interface;
using System.Collections.Generic;
using System.Linq;
using Duannoithat.Models;

namespace Duannoithat.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private NoithatDbContext dbContext;
        public ProductRepository(NoithatDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return dbContext.Products;
        }

        public Product? GetProductDetail(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return dbContext.Products.Where(p => p.IsTrendingProduct);
        }
    }
}
