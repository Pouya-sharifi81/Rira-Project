using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Rira_Project.Enum;
using Rira_Project.Models;
using Rira_Project.Repository;

namespace Rira_Project.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ProductController : Controller    
    {
        private readonly IProductRepositories _productRepositories;
        public ProductController(IProductRepositories productRepositories)
        {

            _productRepositories = productRepositories;

        }
        [HttpGet]
        [Route("Category")]
        //In this method it takes all the products that are of the Category1
        public ActionResult< IEnumerable<ProductDto>> GetProductsByCategory()
        {
          return Ok(_productRepositories.ProductsByCategory());
        }
        [HttpGet]
        [Route("HighestPrice")]
        //This method returns a product with the highest price
        public ActionResult<ProductDto> GetProductWithHighestPrice()
        {
            return Ok(_productRepositories.ProductWithHighestPrice());
        }
        [HttpGet]
        [Route("TotalPrice")]
        //This method returns the sum of the total product prices
        public ActionResult<decimal> CalculateTotalPrice()
        {
            return Ok(_productRepositories.TotalPrice());
        }
        [HttpGet]
        [Route("GroupByCategory")]
        //This method grouping the product based on their Category
        public ActionResult<ProductDto> GroupProductByCategory()
        {
            var groupProduct = _productRepositories.GetProducts().GroupBy(n=>n.Category).ToDictionary(n=>n.Key,n=>n.ToList());
            return Ok(groupProduct);
           
        }
       
        [HttpGet]
        [Route("AveragePrice")]
        //This method returns the average price of products
        public ActionResult<double> CalculateAveragePrice()
        {
            return Ok( _productRepositories.AveragePrice());
        }
    }
}

