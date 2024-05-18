using Rira_Project.Enum;
using Rira_Project.Models;

namespace Rira_Project.Repository
{
    public interface IProductRepositories
    {
         List<ProductDto> ProductsByCategory();
        ProductDto ProductWithHighestPrice();
        decimal TotalPrice();
        List<ProductDto> GetProducts();
        double AveragePrice();

    }
}
