using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarCourse.ViewModel
{
    public class RandomMovieViewModel
    {
        public MarCourse.Models.Movie Movie { get; set; }
        public List<Models.Customer> Customers { get; set; }
    }
}