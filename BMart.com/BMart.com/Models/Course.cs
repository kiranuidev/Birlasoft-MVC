using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMart.com.Models
{
    public class Course
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Id { get; set; }

        public List<Course> GetCourses()
        {
            var courses = new List<Course>();
            courses.Add(new Course
            {
                Id = 1,
                Name = "ASP.Net MVC",
                Category = "Software"
            });
            courses.Add(new Course
            {
                Id = 2,
                Name = "Angular",
                Category = "Software"
            });
            return courses;
        }
    }
}