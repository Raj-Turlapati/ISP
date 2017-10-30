using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Model
{
    public class Product
    {
        public Category Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public int Calories { get; set; }
    }
}
