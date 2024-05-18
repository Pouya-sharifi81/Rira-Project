using AutoMapper;
using Rira_Project.Enum;
using Rira_Project.Models;

namespace Rira_Project.Repository
{
    public class ProductRepositories : IProductRepositories
    {
        private readonly IMapper _mapper;
        public ProductRepositories(IMapper mapper)
        {
                _mapper = mapper;
        }
        public double AveragePrice()
        {
            var averagePrice = ProductContext.products.Average(n => n.Price);
            return averagePrice;
        }

        public decimal TotalPrice()
        {
            var tolalPrice = ProductContext.products.Sum(n => n.Price);
            return tolalPrice;
        }

        public List<ProductDto> ProductsByCategory()
        {
            var products = ProductContext.products.Where(n => n.Category == Category.Category1).ToList();
            var productDto = _mapper.Map<List<ProductDto>>(products);
            return productDto;
        }

        public ProductDto ProductWithHighestPrice()
        {
            var product = ProductContext.products.OrderByDescending(n => n.Price).FirstOrDefault();
            var productDto = _mapper.Map<ProductDto>(product);
            return productDto;
        }

        public List<ProductDto> GetProducts()
        {
            var products = ProductContext.products;
            var productDto = _mapper.Map<List<ProductDto>>(products);
            return productDto;
        }
      
    }
}
