using BMart.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BMart.com.Controllers
{
    public class AppController : ApiController
    {

        public ResultProduct Get()
        {
            // return new Product().GetProducts();
            var service = new ExternalProductService();
            return service.GetProducts();
            

        }

        public List<Product> Post(Product product)
        {
            var products = new Product().GetProducts();
            products.Add(product);
            return products;
        }


    }
}
