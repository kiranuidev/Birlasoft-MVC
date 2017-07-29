using BMart.com.IRepository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using BMart.com.IRepository;

namespace BMart.com.Models
{
    public class ExternalProductService
    {
        readonly string baseUri = "http://localhost:3000/products";
        public string walmartUrl = "http://api.walmartlabs.com/v1/search?format=json&apiKey=yjrruzc9fgbxvs28qw2rjczv&query=";
        public WalmartInfo GetWalmartProducts(string query)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(walmartUrl+query);
                return JsonConvert.DeserializeObjectAsync<WalmartInfo>(response.Result).Result;

            }
        }

        public ResultProduct GetProducts()
        { using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(baseUri);
                return JsonConvert.DeserializeObjectAsync<ResultProduct>(response.Result).Result;

            }

        }

        //public T GetProductInfo<T>(string query)
        //{
        //    using (HttpClient httpClient = new HttpClient())
        //    {
        //        Task<String> response = httpClient.GetStringAsync(baseUri+query);
        //        return JsonConvert.DeserializeObjectAsync<T>(response.Result).Result;

        //    }
        //}
        // [{"_id":"593f82c3e257256aca2ffc6e","index":0,
        //"guid":"04499ff5-598e-4058-87e5-745c977b1b20",
        // "isActive":true,"price":"$3,853.08",
        // "picture":"http://placehold.it/32x32","Price":3680,"Make":"Samsung","Model":"iPhone7","Description":"Yyyy"}
    }

    public class ResultProduct
    {
        public List<ExternalProduct> products { get; set; }
    }

    public class ExternalProduct
    {
        public string _id { get; set; }
        public int index { get; set; }
        public string picture { get; set; }
        public string Model { get; set; }
    }


    public class WalmartInfo
    {
        public string query { get; set; }
        public int numItems { get; set; }
        public List<WalmartProdcuts> items{get;set;}
}
    public class WalmartProdcuts
    {
        public float salePrice { get; set; }
        public string name { get; set; }
        public string thumbnailImage { get; set; }

    }
}