using Microsoft.AspNetCore.Mvc;
using ProductService.Persistence;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IProductRepository _productRepository;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productRepository"></param>
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
    }
}