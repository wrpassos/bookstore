using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductService.Context;
using ProductService.Models;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ProductContext _context;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ProductController(ProductContext context)
        {
            _context = context;
        }

        public void Add(Product Product)
        {
            _context.Add(Product);
            _context.SaveChanges();
        }

//        public IEnumerable<Product> GetAll()
//        {
//            return _context.Products.Include(c => c.Category).ToList();
//        }
    }
}