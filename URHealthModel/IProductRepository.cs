using System.Collections.Generic;
using URHealth.Model;

namespace URHealth.Model
{
    public interface IProductRepository
    {
        IList<Product> GetAllProducts();
    }
}