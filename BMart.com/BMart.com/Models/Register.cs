using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMart.com.Models
{
    public class Register
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public String SelectedCountry { get; set; }
        public string Gender { get; set; }
    }

    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public List<Country> GetCountries()
        {
            var countries = new List<Country>();
            countries.Add(new Country() { Code = "IN", Name = "India" });
            countries.Add(new Country() { Code = "US", Name = "United States" });
            return countries;
        }
    }
}