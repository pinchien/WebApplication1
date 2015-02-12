using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[] 
        { 
            new Product { Id = 1, Name = "Noodle Soup", Category = "Groceries", Price = 5 }, 
            new Product { Id = 2, Name = "Bicycle", Category = "Toys", Price = 15.75M }, 
            new Product { Id = 3, Name = "Computer", Category = "Hardware", Price = 100.99M },
            new Product { Id = 4, Name = "Whatever", Category = "Others", Price= 1000 }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
