using System.Collections.Generic;
using URHealth.Model;

namespace URHealth.Repository
{
    public interface IProductContext
    {
        List<Category> Categories { get; }
        List<Product> Products { get; }
    }
}