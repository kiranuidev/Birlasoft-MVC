using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMart.com.Models
{
    public class Product
    {
       public int Id { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public List<Product> GetProducts()
        {
            var list = new List<Product>();
            list.Add(new Product() { Id = 1, Description = "Test one", Model = "iPhone", ImageUrl = "https://www.google.co.in/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&cad=rja&uact=8&ved=0ahUKEwi-qvu6jK7VAhXDQI8KHeUkAHUQjRwIBw&url=https%3A%2F%2Fsupport.apple.com%2Fiphone&psig=AFQjCNG4_f4sIqSjKQ-GVzAQyZvehRsxlQ&ust=1501404151979308" });

            list.Add(new Product() { Id = 2, Description = "Test two",
                Model = "SamSung", ImageUrl = "https://www.google.co.in/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&cad=rja&uact=8&ved=0ahUKEwisyZPMjK7VAhVEpo8KHUdjAfcQjRwIBw&url=https%3A%2F%2Fwww.apple.com%2Fshop%2Fproduct%2FHKKB2ZM%2FA%2Ftech21-evo-gem-case-for-iphone-6-plus-6s-plus&psig=AFQjCNG4_f4sIqSjKQ-GVzAQyZvehRsxlQ&ust=1501404151979308"
            });
            list.Add(new Product()
            {
                Id = 3,
                Description = "Test two",
                Model = "OPPO",
                ImageUrl = "https://www.google.co.in/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&cad=rja&uact=8&ved=0ahUKEwjyj9_cjK7VAhWL6Y8KHXViD3YQjRwIBw&url=https%3A%2F%2Fsupport.apple.com%2Fen-us%2FHT201296&psig=AFQjCNG4_f4sIqSjKQ-GVzAQyZvehRsxlQ&ust=1501404151979308"
            });

            return list;
        }
    }
}