using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URHealth.Model;

namespace URHealth.Repository
{
    public class ProductContext : IProductContext
    {
        private List<Product> _products;
        private List<Category> _categories;

        public ProductContext()
        {
            _categories = new List<Category>();

            Category morningMeals = new Category { Id = 1, Name = "Breakfast" };
            Category afternoonMeals = new Category { Id = 2, Name = "Lunch" };
            Category eveningMeals = new Category { Id = 3, Name = "Dinner" };

            _categories.Add(morningMeals);
            _categories.Add(afternoonMeals);
            _categories.Add(eveningMeals);

            _products = new List<Product>();
            _products.Add(new Product { Id = 1, Name = "Idli", Price = 30m, Category = morningMeals, Calories = 400 });
            _products.Add(new Product { Id = 2, Name = "Bread Omlet", Price = 25m, Category = morningMeals, Calories = 500 });
            _products.Add(new Product { Id = 3, Name = "Dosa", Price = 35m, Category = morningMeals, Calories = 600 });

            _products.Add(new Product { Id = 4, Name = "Chicken", Price = 90m, Category = afternoonMeals, Calories = 800 });
            _products.Add(new Product { Id = 5, Name = "Pure Veg", Price = 75m, Category = afternoonMeals, Calories = 700 });
            _products.Add(new Product { Id = 6, Name = "Tuna Meals", Price = 150m, Category = afternoonMeals, Calories = 900 });

            _products.Add(new Product { Id = 7, Name = "Boneless Chicken", Price = 100m, Category = eveningMeals, Calories = 500 });
            _products.Add(new Product { Id = 8, Name = "Pure veg with roti", Price = 25m, Category = eveningMeals, Calories = 450 });
            _products.Add(new Product { Id = 9, Name = "Evening Dosa", Price = 35m, Category = eveningMeals, Calories = 550 });

        }

        public List<Product> Products
        {
            get { return _products; }
        }

        public List<Category> Categories
        {
            get { return _categories; }
        }
    }

}
