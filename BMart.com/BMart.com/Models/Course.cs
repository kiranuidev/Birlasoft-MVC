using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BMart.com.Models
{
    public class Course
    {
        [Display(Name="Course Name")]
        public string Name { get; set; }

        [Display(Name = "Course Category")]
        [Required(ErrorMessage ="Course Category")]
        [MinLength(5,ErrorMessage ="Minimum Course Length is 5")]
        [RegularExpression("^[A-Za-z]+$",ErrorMessage ="Invalid Course Category")]
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