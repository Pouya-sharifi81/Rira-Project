using Rira_Project.Enum;
using Rira_Project.Models;

namespace Rira_Project.Repository
{
    public static class ProductContext 
    {
        public static List<Product> products { get; set; } = new List<Product>()
        {
            new Product
             {
              Id = 1,
              Name = "Product A",
              Category = Category.Category1,
              Price = 100,
          },
             new Product
             {
                 Id = 2,
                 Name = "Product B",
                 Category = Category.Category1,
                 Price = 150,
             }, new Product
             {
                 Id = 3,
                 Name = "Product C",
                 Category = Category.Category2,
                 Price = 120,
             }, new Product
             {
                 Id = 4,
                 Name = "Product D",
                 Category = Category.Category3,
                 Price = 200,
             }, new Product
             {
                 Id = 5,
                 Name = "Product E",
                 Category = Category.Category1,
                 Price = 80,
             },
        };

  
    }
}




         