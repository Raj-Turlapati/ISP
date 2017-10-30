using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URHealth.Model;
using URHealth.Repository;

namespace URHealth.Service
{
    public class ProductService
    {
        private  IProductRepository _productRepository; 
        
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IList<Product> GetAllProducts()
        {
            IList<Product> products;
            products = _productRepository.GetAllProducts();

            return products;
        }
    }
}
