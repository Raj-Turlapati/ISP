using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URHealth.Model;

namespace URHealth.Repository
{
    public class ProductRepository : IProductRepository
    {
        private IProductContext _dbContext; 

        public ProductRepository(IProductContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IList<Product> GetAllProducts()
        {
            IList<Product> products;

            products = _dbContext.Products;

            return products;
        }
    }
}
